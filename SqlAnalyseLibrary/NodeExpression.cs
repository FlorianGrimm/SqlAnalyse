using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeExpression : NodeNamedWithResolvedType {
        public object? ConstValue;
        public List<Node> Callable;
        public List<Node> Parameters;

        public NodeExpression() {
            this.Callable = new List<Node>();
            this.Parameters = new List<Node>();
        }
        public void AddCallable(Node node) {
            if (node is object) {
                this.Callable.Add(node);
            }
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
            => $"{this.GetType().Name}:{this.Index} {this.Level} {this.Comment} {this.ElementKind} {this.Callable.Count} {this.Parameters.Count}";
    }
}
