using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeNoop : Node {

    }
    public class NodeJoin : Node {
        public Node Child;
        public override IEnumerable<Node> GetChildren()
        {
            if (this.Child is object) {
                yield return this.Child;
            }
        }
    }
}
