using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeOuputTable : Node {
        public NodeOuputTable() {
            this.Columns = new List<NodeScopeElement>();
        }

        public List<NodeScopeElement> Columns { get; }
        public Node? NodeFrom { get; set; }

        public override IEnumerable<Node> GetChildren() {
            if (this.NodeFrom is object) { yield return this.NodeFrom; }
            foreach (var c in this.Columns) {
                yield return c;
            }
        }
    }
}