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
        //public static Node ParseTransformSql(string sqlCode) {
        //    var ast = ParseSql(sqlCode);
        //    return TransformSql(ast);
        //}

        public static TSqlFragment ParseSql(string sqlCode) {
            var parser = new TSql150Parser(false);

            IList<ParseError> errors;
            var tokens = parser.GetTokenStream(new StringReader(sqlCode), out errors);
            if (errors is object && errors.Count > 0) { return null; }
            TSqlFragment fragment = parser.Parse(tokens, out errors);
            if (errors is object && errors.Count > 0) { return null; }
            return fragment;

        }

        //public static Node TransformSql(TSqlFragment ast) => AstNodeGenerator.Generate(ast);

        //public static EvaluationState Evaluate(Node node, EvaluationState evaluationState) {
        //    // EvaluationState
        //    return evaluationState;
        //}
        public readonly Stack<StackNode> Stack;
        public StackNode Current;
        public StaticEvaluator() {
            this.Stack = new Stack<StackNode>();
            this.Current = new StackNode() {
                GlobalScope = new GlobalScope(),
                LocalScope = new LocalScope(),
                AliasScope = new AliasScope()
            };
            this.Stack.Push(this.Current);
        }
        private void Push(TSqlFragment node) {
            var current = new StackNode() {
                Node = node,
                GlobalScope = this.Current.GlobalScope,
                LocalScope = this.Current.LocalScope,
                AliasScope = this.Current.AliasScope
            };
            this.Current = current;
            this.Stack.Push(current);
        }
        private StackNode Pop(TSqlFragment node) {
            var result = this.Stack.Pop();
            this.Current = this.Stack.Peek();
            return result;
        }
        private StackNode Accept(TSqlFragment node) {
            StackNode result = null;
            if (node is null) { return result; }
            this.Push(node);
            try {
                node.Accept(this);
            } finally {
                result = this.Pop(node);
            }
            return result;
        }
        private void AcceptSetResult(TSqlFragment node, TSqlFragment child) {
            var result = this.Accept(child);
            this.SetResult(node, result.Result);
        }
        private List<StackNode> Accept<T>(IList<T> lst)
            where T : TSqlFragment {
            var result = new List<StackNode>();
            if (lst is null) { return result; }
            foreach (var node in lst) {
                var resultNode = this.Accept(node);
                if (resultNode is object) {
                    result.Add(resultNode);
                }
            }
            return result;
        }
        private void SetResult(TSqlFragment node, Node result) {
            if ((node is object) && (this.Current.Node is object) && !ReferenceEquals(node, this.Current.Node)) {
                throw new InvalidOperationException(node.GetType().Name + " - " + this.Current.Node.GetType().Name);
            }
            this.Current.Result = result;
        }
        public override void Visit(TSqlFragment node) {
            //base.Visit(node);
            if (node is null) { return; }
            throw new InvalidOperationException(node.GetType().Name);
        }

        public override void ExplicitVisit(TSqlScript node) {
            if (node is null) { return; }
            var subResults = this.Accept(node.Batches);
            this.SetResult(node, null);
        }
        public override void ExplicitVisit(TSqlBatch node) {
            if (node is null) { return; }
            this.Current.LocalScope = new LocalScope();
            var subResults = this.Accept(node.Statements);
            this.SetResult(node, null);
        }
        public override void ExplicitVisit(SelectStatement node) {
            if (node is null) { return; }
            this.Current.AliasScope = new AliasScope();
            var resultCTes = this.Accept(node.WithCtesAndXmlNamespaces);
            var resultQueryExpression = this.Accept(node.QueryExpression);
            if (node.Into is object) {
                // node.Into
            } else {
                SetResult(node, resultQueryExpression.Result);
            }
        }
        public override void ExplicitVisit(QueryParenthesisExpression node) {
            if (node is null) { return; }
            //base.ExplicitVisit(node);            
            if (node.QueryExpression is object) {
                var subResult = this.Accept(node.QueryExpression);
                this.SetResult(node, subResult.Result);
                return;
            }
        }
        public override void ExplicitVisit(QuerySpecification node) {
            if (node is null) { return; }
            //node.TopRowFilter
            //node.UniqueRowFilter
            var resultSelectElements = this.Accept(node.SelectElements);
            var result = new NodeOuputTable();
            result.Columns.AddRange(resultSelectElements.Select(sn => sn.Result).OfType<NodeReference>());
            //node.GroupByClause
            //node.HavingClause
            //node.WhereClause
            //node.OrderByClause
            //node.OffsetClause
            //node.ForClause
            this.SetResult(node, result);
        }
        public override void ExplicitVisit(BinaryQueryExpression node) {
            var result = this.Accept(node.FirstQueryExpression);
            //node.FirstQueryExpression
            //node.BinaryQueryExpressionType== BinaryQueryExpressionType.Except
            //node.BinaryQueryExpressionType == BinaryQueryExpressionType.Intersect
            //node.BinaryQueryExpressionType == BinaryQueryExpressionType.Union
            //node.All
            //node.SecondQueryExpression
            SetResult(node, result.Result);
        }
        public override void ExplicitVisit(SelectScalarExpression node) {
            //var result = new NodeColumnReference();
            var resultColumnName = this.Accept(node.ColumnName);
            var resultExpression = this.Accept(node.Expression);
            if ((resultColumnName is null) && (resultExpression.Result is NodeReference columnReference)) {
                SetResult(node, columnReference);
                return;
            }
            throw new NotSupportedException(node.GetType().Name);

            //SetResult(node, result);
            //if ((node.ColumnName is object) && (node.Expression is null)){
            //}
            //node.Expression
        }
        public override void ExplicitVisit(IdentifierOrValueExpression node) {
            if (node.Identifier is object) {
                this.AcceptSetResult(node, node.Identifier);
                return;
            }
            if (node.ValueExpression is Literal) {
                this.AcceptSetResult(node, node.ValueExpression);
                return;
            }
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

            return;
        }

        public override void ExplicitVisit(VariableReference node) {
            base.ExplicitVisit(node);
        }
        public override void ExplicitVisit(GlobalVariableExpression node) {
            base.ExplicitVisit(node);
        }
        public override void ExplicitVisit(ColumnReferenceExpression node) {
            switch (node.ColumnType) {
                case ColumnType.Regular: {
                        var result = new NodeReference();
                        result.SetColumnRegular(node.MultiPartIdentifier);
                        SetResult(node, result);
                        return;
                    }
                case ColumnType.IdentityCol:
                    break;
                case ColumnType.RowGuidCol:
                    break;
                case ColumnType.Wildcard:
                    break;
                case ColumnType.PseudoColumnIdentity:
                    break;
                case ColumnType.PseudoColumnRowGuid:
                    break;
                case ColumnType.PseudoColumnAction:
                    break;
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

    }
    public class Node {
        public Node() {
        }
        public ForewardLink ForewardLink { get; set; }
        public void AddForewardLink(Node nextNode, Node condition) {
            this.AddForewardLink(new ForewardLink(nextNode, condition));
        }
        public void AddForewardLink(ForewardLink forewardLink) {
            if (this.ForewardLink is null) {
                this.ForewardLink = forewardLink;
            } else {
                this.ForewardLink.GetLast().NextForewardLink = forewardLink;
            }
        }
    }
    public class ForewardLink {
        public ForewardLink() {
        }
        public ForewardLink(Node nextNode, Node condition) {
            this.NextNode = nextNode;
            this.Condition = condition;
        }
        public ForewardLink NextForewardLink { get; set; }
        public Node NextNode { get; set; }
        public Node Condition { get; set; }

        public ForewardLink GetLast() {
            return (this.NextForewardLink is null)
                ? this
                : this.NextForewardLink.GetLast();
        }
    }

    public class StackNode {
        public TSqlFragment Node;
        public Node Result;

        public GlobalScope GlobalScope;
        public LocalScope LocalScope;
        public AliasScope AliasScope;
    }
}
