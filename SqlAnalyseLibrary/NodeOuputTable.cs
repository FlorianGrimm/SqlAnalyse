using System;
using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeOuputTable : Node {
        public NodeOuputTable() {
            this.Columns = new List<NodeScopeElement>();
        }

        public NodeOuputTable(
            int level,
            string comment) :this() {
            this.Level = level;
            this.Comment = comment;
        }

        public List<NodeScopeElement> Columns { get; }

        public Node? NodeCtes { get; set; }
        public Node? NodeFrom { get; set; }
        public NodeExpressionTabular? Expression { get; set; }

        public override IEnumerable<Node> GetChildren() {
            if (this.NodeCtes is object) { yield return this.NodeCtes; }
            if (this.NodeFrom is object) { yield return this.NodeFrom; }
            if (this.Expression is object) { yield return this.Expression; }
            foreach (var c in this.Columns) {
                yield return c;
            }
        }

        public override void AfterInitialization() {
            foreach(var column in this.Columns) {
                if (column is NodeScopeElement columnScopeElement) {
                    columnScopeElement.Owner = this;
                }
            }
        }
    }
}