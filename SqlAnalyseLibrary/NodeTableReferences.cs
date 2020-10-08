using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeTableReferences : Node, INodeHasScope {
        public Node? Start { get; set; }
        public List<Node> Children { get; }
        public NodeScopeKind Scope { get; set; }
        public Scopes? Scopes { get; set; }
        public NodeTableReferences() {
            this.Children = new List<Node>();
        }
        public override IEnumerable<Node> GetChildren() {
            if (this.Start is object) {
                yield return this.Start;
            }
            foreach (var c in this.Children) {
                yield return c;
            }
        }
        public override void Resolve(EvaluationState evaluationState) {
            base.Resolve(evaluationState);
        }
    }
}
