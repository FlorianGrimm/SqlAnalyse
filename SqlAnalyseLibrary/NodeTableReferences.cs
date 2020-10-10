using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeTableReferences : Node, INodeHasScope {
        public Node? TabularResult { get; set; }
        public List<Node> Children { get; }
        public NodeScopeKind Scope { get; set; }
        public Scopes? Scopes { get; set; }

        public NodeTableReferences() {
            this.Children = new List<Node>();
        }

        public NodeTableReferences(
            int level,
            string comment,
            Scopes? scopes,
            NodeScopeKind scope) :this() {
            this.Level = level;
            this.Comment = comment;
            this.Scopes = scopes;
            this.Scope = scope;
        }

        public override IEnumerable<Node> GetChildren() {
            foreach (var c in this.Children) {
                yield return c;
            }
            if (this.TabularResult is object) {
                yield return this.TabularResult;
            }
        }
        public override void Resolve(EvaluationState evaluationState) {
            base.Resolve(evaluationState);
        }
    }
}
