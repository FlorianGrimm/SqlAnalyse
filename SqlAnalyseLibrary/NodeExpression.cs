using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeExpression : Node {
        public NodeExpressionKind Kind { get; set; }
        public SqlScalarType ScalarType;
        public object ConstValue;
        public List<Node> Callable;
        public List<Node> Parameters;

        public NodeExpression() {
            this.Callable = new List<Node>();
            this.Parameters = new List<Node>();
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
    }

    public enum NodeExpressionKind {
        Unknown,
        Const,
        Equals,
        GreaterThan,
        LessThan,
        GreaterThanOrEqualTo,
        LessThanOrEqualTo,
        NotEqualToBrackets,
        NotEqualToExclamation,
        NotLessThan,
        NotGreaterThan,
        LeftOuterJoin,
        RightOuterJoin
    }
}