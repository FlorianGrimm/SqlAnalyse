using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeControlFlow : Node {
        public NodeControlFlowKind Kind;
        public Node? Condition;
        public Node? TrueBranch;
        public Node? FalseBranch;
        public override IEnumerable<Node> GetChildren() {
            if (this.Condition is object) {
                yield return this.Condition;
            }
            if (this.TrueBranch is object) {
                yield return this.TrueBranch;
            }
            if (this.FalseBranch is object) {
                yield return this.FalseBranch;
            }
        }
    }
    public enum NodeControlFlowKind {
        Unknown,
        JoinBranch,
        Sequence,
        If,
        While
    }
}
