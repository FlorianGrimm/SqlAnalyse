using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeExpressionTabular : Node {
        public NodeExpressionTabularKind Kind { get; set; }
        public SqlScalarType? ScalarType { get; set; }
        public object? ConstValue;
        public List<Node> Callable { get; }
        public List<Node> Parameters { get; }
        public List<Node> Columns { get; }
        public Node? NodeFrom { get; set; }

        public NodeExpressionTabular() {
            this.Callable = new List<Node>();
            this.Parameters = new List<Node>();
            this.Columns = new List<Node>();
        }

        public NodeExpressionTabular(
            int level,
            string comment,
            NodeExpressionTabularKind kind) : this() {
            this.Level = level;
            this.Comment = comment;
            this.Kind = kind;
        }

        public void AddParameter(Node node) {
            if (node is object) {
                this.Parameters.Add(node);
            }
        }
        public override IEnumerable<Node> GetChildren() {
            foreach (var c in this.Callable) {
                yield return c;
            }
            foreach (var c in this.Parameters) {
                yield return c;
            }
        }

        public override string ToString()
            => $"{this.GetType().Name}:{Index} {Level} {Comment} {this.Kind} {this.Callable.Count} {this.Parameters.Count}";

        public MultiPartIdentifier? GetName() {
            //if (this.Kind == NodeExpressionScalarKind.Const) {
            //    return null;
            //}
            // throw new NotSupportedException("nodeExpression.Kind is ? " + nodeExpression.Kind);
            return null;
        }
    }
    public enum NodeExpressionTabularKind {
        Unknown,
        Select,
        Query
    }
}
