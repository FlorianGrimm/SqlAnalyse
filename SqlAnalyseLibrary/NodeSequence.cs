using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeSequence : Node, INodeHasScope {
        public Node Start;
        public List<Node> Children;
        public NodeScopeKind Scope { get; set; }
        public Scopes Scopes { get; set; }
        public NodeSequence() {
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
    }
}
