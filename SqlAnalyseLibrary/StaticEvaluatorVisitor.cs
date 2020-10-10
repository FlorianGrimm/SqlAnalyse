using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SqlAnalyseLibrary {
    public sealed class StaticEvaluatorVisitor : TSqlConcreteFragmentVisitor {
        public readonly EvaluationState EvaluationState;

        public readonly Stack<StackNode> Stack;
        public StackNode Current;

        public StaticEvaluatorVisitor(StaticEvaluator staticEvaluator) {
            this.EvaluationState = staticEvaluator.EvaluationState;
            this.Stack = new Stack<StackNode>();
            this.Current = new StackNode(null, new Scopes(), null);
            this.Stack.Push(this.Current);
        }

        public VisitorResult VistRoot(TSqlFragment astNode) {
            astNode.Accept(this);
            var current = this.Current;
            return new VisitorResult(this.EvaluationState, current.GlobalScope, current.Result);
        }

        public sealed class VisitorResult {
            public VisitorResult(EvaluationState evaluationState, GlobalScope? globalScope, Node? nodeRoot) {
                this.EvaluationState = evaluationState;
                this.GlobalScope = globalScope;
                this.NodeRoot = nodeRoot;
            }

            public readonly EvaluationState EvaluationState;
            public readonly GlobalScope? GlobalScope;

            public readonly Node? NodeRoot;

            public bool IsSuccessfull()
                => (this.GlobalScope is object) && (this.NodeRoot is object);

            public object Resolve() {
                if (this.GlobalScope is null) { throw new InvalidOperationException(nameof(this.GlobalScope)); }
                if (this.NodeRoot is null) { throw new InvalidOperationException(nameof(this.NodeRoot)); }
                var next = new StaticEvaluatorResolver(this.EvaluationState, this.GlobalScope, this.NodeRoot);
                next.Resolve();
                return "";
            }
        }

        private void Push(TSqlFragment astNode, Node? previous) {
            var current = new StackNode(astNode, this.Current.Scopes, previous);
            this.Current = current;
            this.Stack.Push(current);
        }

        private StackNode Pop(TSqlFragment astNode) {
            var result = this.Stack.Pop();
            if (!ReferenceEquals(result.AstNode, astNode)) { throw new InvalidOperationException("AstNode is not the same."); }
            this.Current = this.Stack.Peek();
            return result;
        }

        private StackNode? Accept(TSqlFragment node, Node? previous) {
            StackNode? result = null;
            if (node is null) { return result; }
            this.Push(node, previous);
            try {
                node.Accept(this);
            } finally {
                result = this.Pop(node);
            }
            return result;
        }

        private void AcceptSetResult(TSqlFragment node, TSqlFragment child, Node? previous) {
            var result = this.Accept(child, previous);
            this.SetResult(node, result?.Result);
        }

        private List<StackNode> Accept<T>(IList<T> lst, Node? previous, Func<StackNode, Node?, Node?> calcNextPrevious)
            where T : TSqlFragment {
            var result = new List<StackNode>();
            if (lst is null) { return result; }
            foreach (var node in lst) {
                if (node is object) {
                    StackNode? resultNode = null;
                    this.Push(node, previous);
                    try {
                        node.Accept(this);
                    } finally {
                        resultNode = this.Pop(node);
                    }
                    if (resultNode is object) {
                        result.Add(resultNode);
                        previous = calcNextPrevious(resultNode, previous);
                    }
                }
            }
            return result;
        }

        private void SetResult(TSqlFragment node, Node? result) {
            if ((node is object) && (this.Current.AstNode is object) && !ReferenceEquals(node, this.Current.AstNode)) {
                throw new InvalidOperationException(node.GetType().Name + " - " + this.Current.AstNode.GetType().Name);
            }
            this.Current.Result = result;
            this.Current.AstNode = node;
        }

        private int GetLevel() {
            return (this.Current.Previous?.Index ?? -1) + 1;
        }
        public override void Visit(TSqlFragment node) {
            //base.Visit(node);
            if (node is null) { return; }
            throw new InvalidOperationException(node.GetType().Name);
        }

        public override void ExplicitVisit(TSqlScript node) {
            if (node is null) { return; }
            var first = new NodeNoop() { Level = 1, Comment = "TSqlScript.First" };
            this.Current.Previous?.AddForewardLink(first, null, true);
            var result = new NodeSequence() { Level = 1, Comment = "TSqlScript.Result" };
            this.Current.EnterGlobalScope(result);
            result.Start = first;
            var subResults = this.Accept(node.Batches, first, StackNode.Chain);
            result.Children.AddRange(subResults.SelectNotNull(r => r.Result));
            (result.Children.LastOrDefault() ?? first).AddForewardLink(result, null, true);
            first.AfterInitialization();
            result.AfterInitialization();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(TSqlBatch node) {
            if (node is null) { return; }
            var level = GetLevel();
            var first = new NodeNoop() { Level = level, Comment = "TSqlBatch.First" };
            this.Current.Previous?.AddForewardLink(first, null, true);
            var result = new NodeSequence() { Level = level, Comment = "TSqlBatch.Result" };
            result.Start = first;
            this.Current.EnterLocalScope(result);
            var subResults = this.Accept(node.Statements, first, StackNode.Chain);
            result.Children.AddRange(subResults.SelectNotNull(r => r.Result));
            (result.Children.LastOrDefault() ?? first).AddForewardLink(result, null, true);
            first.AfterInitialization();
            result.AfterInitialization();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(SelectStatement node) {
            if (node is null) { return; }
            var level = GetLevel();
            if (node.Into is object) {
                throw new NotImplementedException("TODO");
                //// node.Into
                //var result = new NodeTableReferences() { Level = level, Comment = "SelectStatement Into", Scope = NodeScopeKind.Unknown };
                //this.Current.EnterAliasScope(result);
                //var resultCTes = this.Accept(node.WithCtesAndXmlNamespaces, null)?.Result;
                //// TODO result.Ctes = resultCTes;
                //var resultQueryExpression = this.Accept(node.QueryExpression, null)?.Result;
                //if (resultQueryExpression is object) {
                //    result.Children.Add(resultQueryExpression);
                //}
                //result.AfterInitialization();
                //// TODO result.Ctes?.AfterInitialization();
                //SetResult(node, result);
            } else {
                var result = new NodeTableReferences(level, "SelectStatement", null, NodeScopeKind.Alias);
                this.Current.EnterAliasScope(result);
                var resultOuputTable = new NodeOuputTable();
                result.TabularResult = resultOuputTable;

                //var previous = this.Current.Previous;
                var resultCTes = this.Accept(node.WithCtesAndXmlNamespaces, null)?.Result;
                resultOuputTable.NodeCtes = resultCTes;


                var resultQueryExpression = this.Accept(node.QueryExpression, null)?.Result;
                if (resultQueryExpression is null) {
                    throw new NotImplementedException("TODO");
                } else if (resultQueryExpression is NodeExpressionTabular nodeExpressionTabular) {
                    //resultOuputTable.Children.Add(resultQueryExpression);
                    resultOuputTable.Expression = nodeExpressionTabular;
                } else {
                    throw new NotImplementedException("TODO");
                }
                resultOuputTable.AfterInitialization();
                result.AfterInitialization();
                SetResult(node, result);
            }
        }

        public override void ExplicitVisit(FromClause node) {
            var level = GetLevel();
            var result = new NodeTableReferences() { Level = level, Comment = "FromClause", Scopes = this.Current.Scopes };
            this.Current.Previous?.AddForewardLink(result, null, true);
            var resultTableReferences = this.Accept(node.TableReferences, null, StackNode.Null);
            result.Children.AddRange(resultTableReferences.SelectNotNull(r => r.Result));
            result.AfterInitialization();
            //result.Ctes?.AfterInitialization();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(NamedTableReference node) {
            var level = GetLevel();
            if (node.Alias is object) {
                var resultSchemaObject = this.Accept(node.SchemaObject, this.Current.Previous)?.Result;
                var result = new NodeScopeElement() { Level = level, Comment = "NamedTableReference with Alias", Scopes = this.Current.Scopes, Scope = NodeScopeKind.Alias };
                //resultSchemaObject.AddForewardLink(result, null, true);
                result.AddNameIdentifier(node.Alias, NodeNameKind.ObjectAlias);
                result.Element = resultSchemaObject;
                result.AddToScope();
                result.AfterInitialization();
                this.SetResult(node, result);
                return;
            } else {
                var resultSchemaObject = this.Accept(node.SchemaObject, this.Current.Previous)?.Result;
                var result = new NodeScopeElement() { Level = level, Comment = "NamedTableReference with Alias", Scopes = this.Current.Scopes, Scope = NodeScopeKind.Alias };
                //resultSchemaObject.AddForewardLink(result, null, true);
                if (resultSchemaObject is NodeNamed nodeNamed) {
                    result.AddNameIdentifier(nodeNamed.Name.Identifiers.Last(), NodeNameKind.ObjectAlias);
                } else {
                    throw new NotSupportedException($"?? NamedTableReference-> {resultSchemaObject?.GetType()?.Name}");
                }
                result.Element = resultSchemaObject;
                result.AddToScope();
                result.AfterInitialization();
                this.SetResult(node, result);
                return;
            }
            // node.Alias
            // node.ForPath
            // node.SchemaObject
            // node.TableHints
            // node.TableSampleClause
            // node.TemporalClause
        }

        public override void ExplicitVisit(QueryParenthesisExpression node) {
            if (node.QueryExpression is object) {
                var level = GetLevel();
                var result = new NodeTableReferences() { Level = level, Comment = "QueryParenthesisExpression", Scope = NodeScopeKind.Unknown };
                this.Current.EnterAliasScope(result);
                var subResult = this.Accept(node.QueryExpression, this.Current.Previous);
                if (subResult?.Result is Node childNode) {
                    result.Children.Add(childNode);
                }
                result.AfterInitialization();
                this.SetResult(node, result);
                return;
            }
        }

        public override void ExplicitVisit(QueryDerivedTable node) {
            //{
            //    var level = GetLevel();
            //    var result = new Node() { Level = level, Comment = "" };
            //    this.Current.Previous?.AddForewardLink(result, null, true);
            //    this.SetResult(node, result);
            //}

            var level = GetLevel();
            var resultTableReferences = new NodeTableReferences() {
                Level = level,
                Comment = "QueryDerivedTable",
                Scopes = this.Current.Scopes,
                Scope = NodeScopeKind.Alias
            };
            this.Current.EnterAliasScope(resultTableReferences);
            var resultOuputTable = new NodeOuputTable() { Level = level + 1, Comment = "QueryDerivedTable" };
            resultTableReferences.Children.Add(resultOuputTable);
            var alias = node.Alias;

            var resultScopeElement = new NodeScopeElement() {
                Level = level + 1,
                Comment = "QueryDerivedTable",
                Scopes = this.Current.Scopes,
                Scope = NodeScopeKind.Alias
            };
            resultScopeElement.AddNameIdentifier(node.Alias, NodeNameKind.ObjectAlias);
            resultTableReferences.Children.Add(resultScopeElement);
            resultScopeElement.AddToScope();

            var subResult = this.Accept(node.QueryExpression, this.Current.Previous)?.Result;
            if (subResult is object) {
                System.Console.WriteLine(subResult.GetType().Name);
            }
            var resultColumns = this.Accept(node.Columns, null, StackNode.Null);
            if (resultColumns.Count > 0) {
                System.Console.WriteLine(resultColumns.Count.ToString());
            }
            //if (subResult?.Result is Node childNode) {
            //    resultOuputTable.Children.Add(childNode);
            //}
            resultTableReferences.AfterInitialization();
            resultOuputTable.AfterInitialization();
            this.SetResult(node, resultTableReferences);
            return;
            //if (node.QueryExpression is object) {
            //}
            //throw
        }

        public override void ExplicitVisit(WithCtesAndXmlNamespaces node) {
            var level = GetLevel();
            var result = new NodeSequence() { Level = level, Comment = "WithCtesAndXmlNamespaces" };
            // this.Current.Previous?.AddForewardLink(result, null, true);
            // node.ChangeTrackingContext
            // node.XmlNamespaces
            var resultCommonTableExpressions = this.Accept(node.CommonTableExpressions, null, StackNode.Null);
            result.Children.AddRange(resultCommonTableExpressions.SelectNotNull(r => r.Result));
            result.AfterInitialization();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(CommonTableExpression node) {
            var level = GetLevel();
            var result = new NodeScopeElement() { Level = level, Comment = "CommonTableExpression", Scopes = this.Current.Scopes };
            result.AddNameIdentifier(node.ExpressionName, NodeNameKind.ObjectAlias);

            //this.Current.Previous?.AddForewardLink(result, null, true);
            var resultColumns = this.Accept(node.Columns, null, StackNode.Null);
            var resultQueryExpression = this.Accept(node.QueryExpression, result)?.Result;
            if (resultQueryExpression is null) {
                throw new InvalidOperationException("CommonTableExpression: resultQueryExpression is null");
            } else if (resultQueryExpression is NodeOuputTable nodeOuputTable) {
                var nodeColumns = resultColumns.SelectNotNull(r => r.Result).ToList();
                var cnt1 = nodeColumns.Count;
                var cnt2 = nodeOuputTable.Columns.Count;
                if (cnt1 != cnt2) {
                    throw new InvalidOperationException("CommonTableExpression: different Column count");
                } else {
                    var resultOuputTable = new NodeOuputTable() { Level = level + 1, Comment = "CommonTableExpression" };
                    result.Element = resultOuputTable;
                    for (int idx = 0; idx < cnt1; idx++) {
                        Identifier? aliasColumn = null;
                        if (nodeColumns[idx] is NodeNamed nodeAlias) {
                            aliasColumn = nodeAlias.Name.Identifiers.LastOrDefault();
                        } else {
                            throw new InvalidOperationException($"CommonTableExpression: nodeColumns[{idx}] is {nodeColumns[idx]?.GetType()?.Name}");
                        }
                        if (nodeOuputTable.Columns[idx] is NodeScopeElement nodeColumn) {
                            var aliasScopeElement = new NodeScopeElement() { Level = level + 2, Comment = "CommonTableExpression" };
                            aliasScopeElement.AddNameIdentifier(aliasColumn, NodeNameKind.ColumnRegular);
                            aliasScopeElement.Element = nodeColumn;
                            resultOuputTable.Columns.Add(aliasScopeElement);
                        } else {
                            throw new InvalidOperationException($"CommonTableExpression: nodeOuputTable.Columns[{idx}] is {nodeOuputTable.Columns[idx]?.GetType()?.Name}");
                        }
                    }
                }
            } else {
                throw new InvalidOperationException($"CommonTableExpression: resultQueryExpression is {resultQueryExpression.GetType().Name}");
            }
            // result.Children
            result.AfterInitialization();
            result.GetChildren().ToList().ForEach(c => c.AfterInitialization());
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(QuerySpecification node) {
            if (node is null) { return; }
            // node.TopRowFilter
            // node.UniqueRowFilter
            var level = GetLevel();
            //var result = new NodeOuputTable() { Level = level, Comment = "QuerySpecification" };
            var result = new NodeExpressionTabular(level, "QuerySpecification", NodeExpressionTabularKind.Query);
            result.NodeFrom = this.Accept(node.FromClause, null)?.Result;

            var resultSelectElements = this.Accept(node.SelectElements, null, StackNode.Null);
            foreach (var resultSelectElement in resultSelectElements) {
                if (resultSelectElement.Result is null) {
                    //
                } else {
                    var resultSelectElementResult = resultSelectElement.Result;
                    // NodeExpressionScalar
                    here
                }
            }
            /*
            foreach (var resultSelectElement in resultSelectElements) {
                if (resultSelectElement.Result is null) {
                    //
                } else if (resultSelectElement.Result is NodeReference nodeReference) {
                    var nodeColumn = new NodeScopeElement() { Level = result.Level + 1, Comment = "QuerySpecification", Scopes = this.Current.Scopes };
                    nodeColumn.AddNameIdentifier(nodeReference.Name?.Identifiers?.Last(), NodeNameKind.ColumnRegular);
                    nodeColumn.Scope = NodeScopeKind.Column;
                    nodeColumn.Element = nodeReference;
                    result.Columns.Add(nodeColumn);
                } else if (resultSelectElement.Result is NodeScopeElement nodeScopeElement) {
                    if (nodeScopeElement.Scope == NodeScopeKind.Column) {
                        result.Columns.Add(nodeScopeElement);
                    } else {
                        var nodeColumn = new NodeScopeElement() { Level = result.Level + 1, Comment = "QuerySpecification", Scopes = this.Current.Scopes };
                        var nameIdentifier = nodeScopeElement.Name?.Identifiers?.LastOrDefault();
                        nodeColumn.AddNameIdentifier(nameIdentifier, NodeNameKind.ColumnRegular);
                        nodeColumn.Scope = NodeScopeKind.Column;
                        nodeColumn.Element = nodeScopeElement;
                        result.Columns.Add(nodeColumn);
                    }
                } else {
                    throw new NotSupportedException(resultSelectElement.Result.GetType().Name);
                }
            }
            */

            // node.GroupByClause
            // node.HavingClause
            // node.WhereClause
            // node.OrderByClause
            // node.OffsetClause
            // node.ForClause
            result.AfterInitialization();
            result.NodeFrom?.AfterInitialization();
            result.Columns.ToList().ForEach(c => c.AfterInitialization());
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(BinaryQueryExpression node) {
            var result = this.Accept(node.FirstQueryExpression, null);
            // node.FirstQueryExpression
            // node.BinaryQueryExpressionType== BinaryQueryExpressionType.Except
            // node.BinaryQueryExpressionType == BinaryQueryExpressionType.Intersect
            // node.BinaryQueryExpressionType == BinaryQueryExpressionType.Union
            // node.All
            // TODO: also respect SecondQueryExpression
            // node.SecondQueryExpression
            SetResult(node, result?.Result);
        }

        public override void ExplicitVisit(SelectScalarExpression node) {
            var level = GetLevel();
            var resultColumnName = this.Accept(node.ColumnName, null)?.Result;
            var resultExpression = this.Accept(node.Expression, null)?.Result;

            if (resultColumnName is object) {
                throw new NotImplementedException("resultColumnName");
            }
            if (resultExpression is null) {
                throw new NotImplementedException("resultExpression");
            } else if (resultExpression is NodeReference nodeReference) {
                var result = new NodeExpressionScalar(level, "SelectScalarExpression", NodeExpressionScalarKind.ColumnAccess);
                result.AddParameter(nodeReference);
                if (nodeReference.Name.Identifiers.Count == 0) {
                    throw new NotImplementedException("nodeReference.Name.Identifiers");
                } else if (nodeReference.Name.Identifiers.Count == 1 && nodeReference.NameKind == NodeNameKind.ColumnRegular) {
                    result.AddNameIdentifier(nodeReference.Name.Identifiers.Last(), NodeNameKind.ColumnRegular);
                } else if (nodeReference.Name.Identifiers.Count == 2 && nodeReference.NameKind == NodeNameKind.ColumnRegular) {
                    result.AddNameIdentifier(nodeReference.Name.Identifiers.Last(), NodeNameKind.ColumnRegular);
                    result.AddCallable(new NodeReference(level + 1, "SelectScalarExpression", this.Current.Scopes, NodeScopeKind.Unknown));
                    here
                } else if (nodeReference.Name.Identifiers.Count == 1 && nodeReference.NameKind == NodeNameKind.ColumnWildcard) {
                    throw new NotImplementedException($"nodeReference.Name {nodeReference.NameKind}");
                } else if (nodeReference.Name.Identifiers.Count == 2 && nodeReference.NameKind == NodeNameKind.ColumnWildcard) {
                    throw new NotImplementedException($"nodeReference.Name {nodeReference.NameKind}");
                } else {
                    throw new NotImplementedException($"nodeReference.Name {nodeReference.NameKind}");
                }
                SetResult(node, result);
            } else {
                throw new NotImplementedException("resultExpression");
            }
            /*
            MultiPartIdentifier? name = null;
            if (resultColumnName is NodeNamed nodeNamed) {
                name = nodeNamed.Name;
            } else if (resultExpression is null) {
                throw new NotSupportedException("resultExpression is null ?");
            } else if (resultExpression is NodeReference nodeReference) {
                name = nodeReference.Name;
                if (name.Identifiers.Count > 1) {
                    var name1 = new MultiPartIdentifier();
                    name1.Identifiers.Add(name.Identifiers.Last());
                    name = name1;
                }
            } else if (resultExpression is NodeExpressionScalar nodeExpression) {
                name = nodeExpression.GetName();
            } else {
                throw new NotSupportedException($"resultExpression is ? {resultExpression.GetType().Name}");
            }
            var level = GetLevel();
            var result = new NodeScopeElement() { Level = level, Comment = "SelectScalarExpression", Scopes = this.Current.Scopes };
            if (name is object) {
                result.SetName(name, NodeNameKind.ColumnRegular);
            }
            if (resultExpression is object) {
                result.Element = resultExpression;
            } else {
                throw new NotSupportedException("resultExpression is null:" + node.GetType().Name);
            }
            result.AddToScope();
            result.AfterInitialization();
            this.SetResult(node, result);
            */
        }

        public override void ExplicitVisit(SelectStarExpression node) {
            var resultQualifier = this.Accept(node.Qualifier, null)?.Result;
            var level = GetLevel();
            var result = new NodeReference() { Level = level, Comment = "SelectStarExpression", Scopes = this.Current.Scopes, Scope = NodeScopeKind.Unknown };
            this.Current.Previous?.AddForewardLink(result, null, true);
            result.SetName((resultQualifier as NodeNamed)?.Name, NodeNameKind.ColumnWildcard);
            result.AfterInitialization();
            this.SetResult(node, resultQualifier);
        }

        public override void ExplicitVisit(IdentifierOrValueExpression node) {
            if (node.Identifier is object) {
                this.AcceptSetResult(node, node.Identifier, null);
                return;
            }
            if (node.ValueExpression is Literal) {
                this.AcceptSetResult(node, node.ValueExpression, null);
                return;
            }
            throw new NotSupportedException("?? :" + node.GetType().Name);

            //here
            //if (ValueExpression != null) {
            //    Literal literal = ValueExpression as Literal;
            //    if (literal != null) {
            //        return literal.Value;
            //    }
            //    VariableReference variableReference = ValueExpression as VariableReference;
            //    if (variableReference != null) {
            //        return variableReference.Name;
            //    }
            //    return (ValueExpression as GlobalVariableExpression)?.Name;
            //}

        }
        public override void ExplicitVisit(BooleanParenthesisExpression node) {
            this.AcceptSetResult(node, node.Expression, null);
        }

        public override void ExplicitVisit(BooleanComparisonExpression node) {
            var level = GetLevel();
            var result = new NodeExpressionScalar() { Level = level, Comment = "BooleanComparisonExpression" };
            this.Current.Previous?.AddForewardLink(result, null, true);
            result.Kind = (node.ComparisonType) switch
            {
                BooleanComparisonType.Equals => NodeExpressionScalarKind.Equals,
                BooleanComparisonType.GreaterThan => NodeExpressionScalarKind.GreaterThan,
                BooleanComparisonType.LessThan => NodeExpressionScalarKind.LessThan,
                BooleanComparisonType.GreaterThanOrEqualTo => NodeExpressionScalarKind.GreaterThanOrEqualTo,
                BooleanComparisonType.LessThanOrEqualTo => NodeExpressionScalarKind.LessThanOrEqualTo,
                BooleanComparisonType.NotEqualToBrackets => NodeExpressionScalarKind.NotEqualToBrackets,
                BooleanComparisonType.NotEqualToExclamation => NodeExpressionScalarKind.NotEqualToExclamation,
                BooleanComparisonType.NotLessThan => NodeExpressionScalarKind.NotLessThan,
                BooleanComparisonType.NotGreaterThan => NodeExpressionScalarKind.NotGreaterThan,
                BooleanComparisonType.LeftOuterJoin => NodeExpressionScalarKind.LeftOuterJoin,
                BooleanComparisonType.RightOuterJoin => NodeExpressionScalarKind.RightOuterJoin,
                _ => NodeExpressionScalarKind.Unknown
            };
            var resultExpression = this.Accept(node.FirstExpression, result)?.Result;
            if (resultExpression is object) {
                result.Parameters.Add(resultExpression);
            }
            resultExpression = this.Accept(node.SecondExpression, result)?.Result;
            if (resultExpression is object) {
                result.Parameters.Add(resultExpression);
            }
            result.AfterInitialization();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(VariableReference node) {
            throw new NotSupportedException("TODO:" + node.GetType().Name);
        }

        public override void ExplicitVisit(GlobalVariableExpression node) {
            throw new NotSupportedException("TODO:" + node.GetType().Name);
        }

        public override void ExplicitVisit(IntegerLiteral node) {
            var result = new NodeExpressionScalar() { Kind = NodeExpressionScalarKind.Const, ScalarType = new SqlScalarType() };

            result.AfterInitialization();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(ColumnReferenceExpression node) {
            var level = GetLevel();
            switch (node.ColumnType) {
                case ColumnType.Regular: {
                        var result = new NodeReference() { Level = level, Comment = "ColumnReferenceExpression", Scopes = this.Current.Scopes, Scope = NodeScopeKind.Column };
                        result.SetColumnRegular(node.MultiPartIdentifier);
                        result.AfterInitialization();
                        SetResult(node, result);
                        return;
                    }
                case ColumnType.IdentityCol:
                    throw new NotSupportedException("TODO:" + node.GetType().Name);
                case ColumnType.RowGuidCol:
                    throw new NotSupportedException("TODO:" + node.GetType().Name);
                case ColumnType.Wildcard:
                    throw new NotSupportedException("TODO:" + node.GetType().Name);
                case ColumnType.PseudoColumnIdentity:
                    throw new NotSupportedException("TODO:" + node.GetType().Name);
                case ColumnType.PseudoColumnRowGuid:
                    throw new NotSupportedException("TODO:" + node.GetType().Name);
                case ColumnType.PseudoColumnAction:
                    throw new NotSupportedException("TODO:" + node.GetType().Name);
                case ColumnType.PseudoColumnCuid:
                    break;
                case ColumnType.PseudoColumnGraphNodeId:
                    break;
                case ColumnType.PseudoColumnGraphEdgeId:
                    break;
                case ColumnType.PseudoColumnGraphFromId:
                    break;
                case ColumnType.PseudoColumnGraphToId:
                    break;
                default:
                    break;
            }
            throw new NotSupportedException(node.GetType().Name);
        }

        public override void ExplicitVisit(SchemaObjectName node) {
            var level = GetLevel();
            var result = new NodeNamed() { Level = level, Comment = "SchemaObjectName" };
            this.Current.Previous?.AddForewardLink(result, null, true);
            foreach (var identifier in node.Identifiers) {
                result.Name.Identifiers.Add(identifier);
            }
            result.AfterInitialization();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(Identifier node) {
            var level = GetLevel();
            var result = new NodeNamed() { Level = level, Comment = "Identifier" };
            result.AddNameIdentifier(node, NodeNameKind.Unknown);
            result.AfterInitialization();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(BeginEndBlockStatement node) {
            var level = GetLevel();
            var first = new NodeNoop() { Level = level, Comment = "BeginEndBlockStatement.First" };
            this.Current.Previous?.AddForewardLink(first, null, true);
            var result = new NodeSequence() { Level = level, Comment = "BeginEndBlockStatement.Result" };
            result.Start = first;
            var resultStatementList = this.Accept(node.StatementList.Statements, first, StackNode.Chain);
            result.Children.AddRange(resultStatementList.SelectNotNull(s => s.Result));
            result.Children.Last().AddForewardLink(result, null, true);
            result.AfterInitialization();
            first.AfterInitialization();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(IfStatement node) {
            var level = GetLevel();
            var nodeIf = new NodeControlFlow() { Level = level + 1, Comment = "IfStatement", Kind = NodeControlFlowKind.If };
            this.Current.Previous?.AddForewardLink(nodeIf, null, true);

            var result = new NodeJoin() { Level = level, Comment = "IfStatement.Join", Child = nodeIf };

            var resultPredicate = this.Accept(node.Predicate, nodeIf);
            var condition = (resultPredicate?.Result) ?? new NodeNoop() { Level = level + 1, Comment = "Condition.Fallback" };
            nodeIf.Condition = condition;

            var resultThen = this.Accept(node.ThenStatement, nodeIf);
            var trueBranch = (resultThen?.Result) ?? new NodeNoop() { Level = level + 1, Comment = "ThenStatement.Fallback" };
            nodeIf.TrueBranch = trueBranch;
            nodeIf.SetForewardLink(trueBranch, condition, true);
            trueBranch.AddForewardLink(result, null, true);

            var resultElse = this.Accept(node.ElseStatement, nodeIf);

            if (resultElse?.Result is Node falseBranch) {
                nodeIf.FalseBranch = falseBranch;
                nodeIf.SetForewardLink(falseBranch, condition, false);
                falseBranch.AddForewardLink(result, null, true);
            } else {
                nodeIf.SetForewardLink(result, condition, false);
            }

            result.AfterInitialization();
            nodeIf.AfterInitialization();
            nodeIf.Condition?.AfterInitialization();
            nodeIf.TrueBranch?.AfterInitialization();
            nodeIf.FalseBranch?.AfterInitialization();
            this.SetResult(node, result);
        }

        // TODO
        public override void ExplicitVisit(FunctionCall node) {
            var level = GetLevel();
            var result = new NodeExpressionScalar() { Level = level, Comment = "FunctionCall", Kind = NodeExpressionScalarKind.FunctionCall };
            this.Current.Previous?.AddForewardLink(result, null, true);
            var resultCallTarget = this.Accept(node.CallTarget, null)?.Result;
            // node.FunctionName
            var resultParameters = this.Accept(node.Parameters, null, StackNode.Null);
            // node.OverClause
            // node.UniqueRowFilter
            // node.WithinGroupClause
            // node.Collation
            this.SetResult(node, result);
        }
        /*
         * 
         * 
        public override void ExplicitVisit( node)
        {
            var level = GetLevel();
            var result = new Node() { Level = level, Comment = "" };
            this.Current.Previous?.AddForewardLink(result, null, true);
            this.SetResult(node, result);
        }
        */
    }
}