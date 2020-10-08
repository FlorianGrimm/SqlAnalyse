using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;

namespace SqlAnalyseLibrary {

    public class StaticEvaluator : TSqlConcreteFragmentVisitor {
        public static TSqlFragment ParseSql(string sqlCode)
        {
            var parser = new TSql150Parser(false);

            IList<ParseError> errors;
            var tokens = parser.GetTokenStream(new StringReader(sqlCode), out errors);
            if (errors is object && errors.Count > 0) { return null; }
            TSqlFragment fragment = parser.Parse(tokens, out errors);
            if (errors is object && errors.Count > 0) { return null; }
            return fragment;

        }

        public void Resolve()
        {
            var result = this.Current.Result;
            if (result is object)
            {
                result.Resolve();
            }
        }

        public readonly Stack<StackNode> Stack;
        public StackNode Current;

        public StaticEvaluator()
        {
            this.Stack = new Stack<StackNode>();
            this.Current = new StackNode()
            {
                Scopes = new Scopes()
            };
            this.Stack.Push(this.Current);
        }

        private void Push(TSqlFragment node, Node previous)
        {
            var current = new StackNode()
            {
                Node = node,
                Scopes = this.Current.Scopes,
                Previous = previous
            };
            this.Current = current;
            this.Stack.Push(current);
        }

        private StackNode Pop(TSqlFragment node)
        {
            var result = this.Stack.Pop();
            this.Current = this.Stack.Peek();
            return result;
        }

        private StackNode Accept(TSqlFragment node, Node previous)
        {
            StackNode result = null;
            if (node is null) { return result; }
            this.Push(node, previous);
            try
            {
                node.Accept(this);
            }
            finally
            {
                result = this.Pop(node);
            }
            return result;
        }

        private void AcceptSetResult(TSqlFragment node, TSqlFragment child, Node previous)
        {
            var result = this.Accept(child, previous);
            this.SetResult(node, result.Result);
        }

        private List<StackNode> Accept<T>(IList<T> lst, Node previous, Func<StackNode, Node, Node> calcNextPrevious)
            where T : TSqlFragment
        {
            var result = new List<StackNode>();
            if (lst is null) { return result; }
            foreach (var node in lst)
            {
                var resultNode = this.Accept(node, previous);
                if (resultNode is object)
                {
                    result.Add(resultNode);
                    previous = calcNextPrevious(resultNode, previous);
                }
            }
            return result;
        }

        private void SetResult(TSqlFragment node, Node result)
        {
            if ((node is object) && (this.Current.Node is object) && !ReferenceEquals(node, this.Current.Node))
            {
                throw new InvalidOperationException(node.GetType().Name + " - " + this.Current.Node.GetType().Name);
            }
            this.Current.Result = result;
            this.Current.Node = node;
            //if (node is object)
            //{
            //    if (this.Current.Scopes.Node is null)
            //    {
            //        if (!(node is INodeHasScope))
            //        {
            //            throw new NotSupportedException(node.GetType().Name + " must be a IHaveScope.");
            //        }
            //        this.Current.Scopes.Node = node;
            //    }
            //}
        }

        private int GetLevel()
        {
            return (this.Current.Previous?.Index ?? -1) + 1;
        }

        public override void Visit(TSqlFragment node)
        {
            //base.Visit(node);
            if (node is null) { return; }
            throw new InvalidOperationException(node.GetType().Name);
        }

        public override void ExplicitVisit(TSqlScript node)
        {
            if (node is null) { return; }
            var first = new NodeNoop() { Level = 1, Comment = "TSqlScript.First" };
            this.Current.Previous?.AddForewardLink(first, null, true);
            var result = new NodeSequence() { Level = 1, Comment = "TSqlScript.Result" };
            this.Current.EnterGlobalScope(result);
            result.Start = first;
            var subResults = this.Accept(node.Batches, first, StackNode.Chain);
            result.Children.AddRange(subResults.Select(r => r.Result).Where(r => r != null));
            (result.Children.LastOrDefault() ?? first).AddForewardLink(result, null, true);
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(TSqlBatch node)
        {
            if (node is null) { return; }
            var level = GetLevel();
            var first = new NodeNoop() { Level = level, Comment = "TSqlBatch.First" };
            this.Current.Previous?.AddForewardLink(first, null, true);
            var result = new NodeSequence() { Level = level, Comment = "TSqlBatch.Result" };
            result.Start = first;
            this.Current.EnterLocalScope(result);
            var subResults = this.Accept(node.Statements, first, StackNode.Chain);
            result.Children.AddRange(subResults.Select(r => r.Result).Where(r => r != null));
            (result.Children.LastOrDefault() ?? first).AddForewardLink(result, null, true);
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(SelectStatement node)
        {
            if (node is null) { return; }
            var level = GetLevel();
            if (node.Into is object)
            {
                // node.Into
                var result = new NodeSequence() { Level = level, Comment = "SelectStatement Into", Scope = NodeScopeKind.Unknown};
                this.Current.EnterAliasScope(result);
                var resultCTes = this.Accept(node.WithCtesAndXmlNamespaces, null);
                var resultQueryExpression = this.Accept(node.QueryExpression, null);
                SetResult(node, result);

            }
            else
            {
                var result = new NodeSequence() { Level = level, Comment = "SelectStatement", Scope = NodeScopeKind.Unknown };
                this.Current.EnterAliasScope(result);
                //var previous = this.Current.Previous;
                var resultCTes = this.Accept(node.WithCtesAndXmlNamespaces, null);
                if (resultCTes?.Result is object)
                {
                    //previous = resultCTes.Result;
                    result.Children.Add(resultCTes.Result);
                }
                var resultQueryExpression = this.Accept(node.QueryExpression, null);
                result.Children.Add(resultQueryExpression.Result);
                SetResult(node, result);
            }
        }

        public override void ExplicitVisit(FromClause node)
        {
            var level = GetLevel();
            var result = new NodeSequence() { Level = level, Comment = "FromClause" };
            this.Current.Previous?.AddForewardLink(result, null, true);
            var resultTableReferences = this.Accept(node.TableReferences, null, StackNode.Null);
            result.Children.AddRange(resultTableReferences.Select(r => r.Result).Where(r => r != null));
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(NamedTableReference node)
        {
            var level = GetLevel();
            if (node.Alias is object)
            {
                var resultSchemaObject = this.Accept(node.SchemaObject, this.Current.Previous)?.Result;
                var result = new NodeScopeElement() { Level = level, Comment = "NamedTableReference with Alias", Scopes = this.Current.Scopes, Scope = NodeScopeKind.Alias };
                //resultSchemaObject.AddForewardLink(result, null, true);
                result.AddNameIdentifier(node.Alias, NodeNameKind.ObjectAlias);
                result.Element = resultSchemaObject;
                result.AddToScope();
                this.SetResult(node, result);
                return;
            }
            else
            {
                var resultSchemaObject = this.Accept(node.SchemaObject, this.Current.Previous)?.Result;
                var result = new NodeScopeElement() { Level = level, Comment = "NamedTableReference with Alias", Scopes = this.Current.Scopes, Scope = NodeScopeKind.Alias };
                //resultSchemaObject.AddForewardLink(result, null, true);
                if (resultSchemaObject is NodeNamed nodeNamed)
                {
                    result.AddNameIdentifier(nodeNamed.Name.Identifiers.Last(), NodeNameKind.ObjectAlias);
                }
                else
                {
                    throw new NotSupportedException("?? NamedTableReference->" + resultSchemaObject.GetType().Name);
                }
                result.AddToScope();
                result.Element = resultSchemaObject;
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

        public override void ExplicitVisit(QueryParenthesisExpression node)
        {
            if (node is null) { return; }
            if (node.QueryExpression is object)
            {
                var level = GetLevel();
                var result = new NodeSequence() { Level = level, Comment = "QueryParenthesisExpression", Scope = NodeScopeKind.Unknown};
                this.Current.EnterAliasScope(result);
                var subResult = this.Accept(node.QueryExpression, this.Current.Previous);
                result.Children.Add(subResult.Result);
                this.SetResult(node, result);
                return;
            }
        }

        public override void ExplicitVisit(QuerySpecification node)
        {
            if (node is null) { return; }
            // node.TopRowFilter
            // node.UniqueRowFilter
            var level = GetLevel();
            var result = new NodeOuputTable() { Level = level, Comment = "QuerySpecification" };
            result.NodeFrom = this.Accept(node.FromClause, null)?.Result;

            var resultSelectElements = this.Accept(node.SelectElements, null, StackNode.Null);
            foreach (var resultSelectElement in resultSelectElements)
            {
                if (resultSelectElement.Result is null)
                {
                }
                else if (resultSelectElement.Result is NodeReference nodeReference)
                {
                    var nodeColumn = new NodeScopeElement() { Level = result.Level + 1, Comment = "QuerySpecification", Scopes = this.Current.Scopes };
                    nodeColumn.AddNameIdentifier(nodeReference.Name?.Identifiers?.Last(), NodeNameKind.ColumnRegular);
                    nodeColumn.Scope = NodeScopeKind.Column;
                    nodeColumn.Element = nodeReference;
                    result.Columns.Add(nodeColumn);
                }
                else if (resultSelectElement.Result is NodeScopeElement nodeScopeElement)
                {
                    if (nodeScopeElement.Scope == NodeScopeKind.Column)
                    {
                        result.Columns.Add(nodeScopeElement);
                    }
                    else
                    {
                        var nodeColumn = new NodeScopeElement() { Level = result.Level + 1, Comment = "QuerySpecification", Scopes = this.Current.Scopes };
                        nodeColumn.AddNameIdentifier(nodeScopeElement.Name?.Identifiers?.Last(), NodeNameKind.ColumnRegular);
                        nodeColumn.Scope = NodeScopeKind.Column;
                        nodeColumn.Element = nodeScopeElement;
                        result.Columns.Add(nodeColumn);
                    }
                }
                else
                {
                    throw new NotSupportedException(resultSelectElement.Result.GetType().Name);
                }
            }

            // node.GroupByClause
            // node.HavingClause
            // node.WhereClause
            // node.OrderByClause
            // node.OffsetClause
            // node.ForClause
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(BinaryQueryExpression node)
        {
            var result = this.Accept(node.FirstQueryExpression, null);
            // node.FirstQueryExpression
            // node.BinaryQueryExpressionType== BinaryQueryExpressionType.Except
            // node.BinaryQueryExpressionType == BinaryQueryExpressionType.Intersect
            // node.BinaryQueryExpressionType == BinaryQueryExpressionType.Union
            // node.All
            // node.SecondQueryExpression
            SetResult(node, result.Result);
        }

        public override void ExplicitVisit(SelectScalarExpression node)
        {
            var resultColumnName = this.Accept(node.ColumnName, null)?.Result;
            var resultExpression = this.Accept(node.Expression, null)?.Result;
            MultiPartIdentifier name = null;
            if (resultColumnName is NodeNamed nodeNamed)
            {
                name = nodeNamed.Name;
            }
            else if (resultExpression is NodeReference nodeReference)
            {
                name = nodeReference.Name;
                if (name.Identifiers.Count > 1)
                {
                    var name1 = new MultiPartIdentifier();
                    name1.Identifiers.Add(name.Identifiers.Last());
                    name = name1;
                }
            }
            else
            {
                throw new NotSupportedException("resultExpression is ?" + node.GetType().Name);
            }
            var level = GetLevel();
            var result = new NodeScopeElement() { Level = level, Comment = "SelectScalarExpression", Scopes = this.Current.Scopes };
            if (name is object)
            {
                result.SetName(name, NodeNameKind.ColumnRegular);
            }
            if (resultExpression is object)
            {
                result.Element = resultExpression;
            }
            else
            {
                throw new NotSupportedException("resultExpression is null:" + node.GetType().Name);
            }
            result.AddToScope();
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(SelectStarExpression node)
        {
            var resultQualifier = this.Accept(node.Qualifier, null)?.Result;
            var level = GetLevel();
            var result = new NodeReference() { Level = level, Comment = "SelectStarExpression", Scopes = this.Current.Scopes, Scope = NodeScopeKind.Unknown };
            this.Current.Previous?.AddForewardLink(result, null, true);
            result.SetName((resultQualifier as NodeNamed)?.Name, NodeNameKind.ColumnWildcard);
            this.SetResult(node, resultQualifier);
        }

        public override void ExplicitVisit(IdentifierOrValueExpression node)
        {
            if (node.Identifier is object)
            {
                this.AcceptSetResult(node, node.Identifier, null);
                return;
            }
            if (node.ValueExpression is Literal)
            {
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
        public override void ExplicitVisit(BooleanParenthesisExpression node)
        {
            this.AcceptSetResult(node, node.Expression, null);
        }

        public override void ExplicitVisit(BooleanComparisonExpression node)
        {
            var level = GetLevel();
            var result = new NodeExpression() { Level = level, Comment = "BooleanComparisonExpression" };
            this.Current.Previous?.AddForewardLink(result, null, true);
            result.Kind = (node.ComparisonType) switch
            {
                BooleanComparisonType.Equals => NodeExpressionKind.Equals,
                BooleanComparisonType.GreaterThan => NodeExpressionKind.GreaterThan,
                BooleanComparisonType.LessThan => NodeExpressionKind.LessThan,
                BooleanComparisonType.GreaterThanOrEqualTo => NodeExpressionKind.GreaterThanOrEqualTo,
                BooleanComparisonType.LessThanOrEqualTo => NodeExpressionKind.LessThanOrEqualTo,
                BooleanComparisonType.NotEqualToBrackets => NodeExpressionKind.NotEqualToBrackets,
                BooleanComparisonType.NotEqualToExclamation => NodeExpressionKind.NotEqualToExclamation,
                BooleanComparisonType.NotLessThan => NodeExpressionKind.NotLessThan,
                BooleanComparisonType.NotGreaterThan => NodeExpressionKind.NotGreaterThan,
                BooleanComparisonType.LeftOuterJoin => NodeExpressionKind.LeftOuterJoin,
                BooleanComparisonType.RightOuterJoin => NodeExpressionKind.RightOuterJoin,
                _ => NodeExpressionKind.Unknown
            };
            var resultExpression = this.Accept(node.FirstExpression, result)?.Result;
            if (resultExpression is object)
            {
                result.Parameters.Add(resultExpression);
            }
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(VariableReference node)
        {
            throw new NotSupportedException("TODO:" + node.GetType().Name);
        }

        public override void ExplicitVisit(GlobalVariableExpression node)
        {
            throw new NotSupportedException("TODO:" + node.GetType().Name);
        }

        public override void ExplicitVisit(IntegerLiteral node)
        {
            var result = new NodeExpression() { Kind = NodeExpressionKind.Const, ScalarType = new SqlScalarType() };

            this.SetResult(node, result);
        }
        public override void ExplicitVisit(ColumnReferenceExpression node)
        {
            var level = GetLevel();
            switch (node.ColumnType)
            {
                case ColumnType.Regular:
                    {
                        var result = new NodeReference() { Level = level, Comment = "ColumnReferenceExpression", Scopes = this.Current.Scopes, Scope = NodeScopeKind.Column };
                        result.SetColumnRegular(node.MultiPartIdentifier);
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

        public override void ExplicitVisit(SchemaObjectName node)
        {
            var level = GetLevel();
            var result = new NodeNamed() { Level = level, Comment = "SchemaObjectName" };
            this.Current.Previous?.AddForewardLink(result, null, true);
            foreach (var identifier in node.Identifiers)
            {
                result.Name.Identifiers.Add(identifier);
            }
            this.SetResult(node, result);
        }

        public override void ExplicitVisit(Identifier node)
        {
            var level = GetLevel();
            var result = new NodeNamed() { Level = level, Comment = "Identifier" };
            result.AddNameIdentifier(node, NodeNameKind.Unknown);
            this.SetResult(node, result);
        }
        public override void ExplicitVisit(BeginEndBlockStatement node)
        {
            var level = GetLevel();
            var first = new NodeNoop() { Level = level, Comment = "BeginEndBlockStatement.First" };
            this.Current.Previous?.AddForewardLink(first, null, true);
            var result = new NodeSequence() { Level = level, Comment = "BeginEndBlockStatement.Result" };
            result.Start = first;
            var resultStatementList = this.Accept(node.StatementList.Statements, first, StackNode.Chain);
            result.Children.AddRange(resultStatementList.Select(s => s.Result).Where(r => r is object));
            result.Children.Last().AddForewardLink(result, null, true);
            this.SetResult(node, result);
        }


        public override void ExplicitVisit(IfStatement node)
        {
            var level = GetLevel();
            var nodeIf = new NodeControlFlow() { Level = level + 1, Comment = "IfStatement", Kind = NodeControlFlowKind.If };
            this.Current.Previous?.AddForewardLink(nodeIf, null, true);

            var result = new NodeJoin() { Level = level, Comment = "IfStatement.Join", Child = nodeIf };

            var resultPredicate = this.Accept(node.Predicate, nodeIf);
            nodeIf.Condition = resultPredicate.Result;

            var resultThen = this.Accept(node.ThenStatement, nodeIf);
            nodeIf.TrueBranch = resultThen.Result;

            var resultElse = this.Accept(node.ElseStatement, nodeIf);
            nodeIf.FalseBranch = resultElse?.Result;


            nodeIf.SetForewardLink(nodeIf.TrueBranch, nodeIf.Condition, true);
            nodeIf.TrueBranch.AddForewardLink(result, null, true);

            if (nodeIf.FalseBranch is object)
            {
                nodeIf.SetForewardLink(nodeIf.FalseBranch, nodeIf.Condition, false);
                nodeIf.FalseBranch.AddForewardLink(result, null, true);
            }
            else
            {
                nodeIf.SetForewardLink(result, nodeIf.Condition, false);
            }

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
