using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeOuputTable :Node{
        public NodeOuputTable() {
            this.Columns = new List<NodeReference>();
        }

        public List<NodeReference> Columns { get; }
    }
}