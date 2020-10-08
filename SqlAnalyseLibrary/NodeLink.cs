namespace SqlAnalyseLibrary {
    public class NodeLink {
        public NodeLink(Node previousNode, Node nextNode, Node? condition, bool conditionResult) {
            this.PreviousNode = previousNode;
            this.NextNode = nextNode;
            this.Condition = condition;
            this.ConditionResult = conditionResult;
        }
        public Node PreviousNode { get; set; }

        public Node NextNode { get; set; }

        public Node? Condition { get; set; }

        public bool ConditionResult { get; set; }

        internal void Connect() {
            new ForewardLink(this).Connect();
            new BackwardLink(this).Connect();
        }
    }
    public class ForewardLink {
        public ForewardLink(NodeLink nodeLink) {
            this.NodeLink = nodeLink ?? throw new System.ArgumentNullException(nameof(nodeLink));
        }

        public NodeLink NodeLink { get; }

        public ForewardLink? NextForewardLink { get; set; }


        public Node NextNode { get => NodeLink.NextNode; }
        public Node? Condition { get => NodeLink.Condition; set => NodeLink.Condition = value; }
        public bool ConditionResult { get => NodeLink.ConditionResult; set => NodeLink.ConditionResult = value; }

        public ForewardLink GetLast() {
            return (this.NextForewardLink is null)
                ? this
                : this.NextForewardLink.GetLast();
        }

        internal void Connect() {
            var previousNode = this.NodeLink.PreviousNode;
            if (previousNode.NextForewardLink is object) {
                previousNode.NextForewardLink.GetLast().NextForewardLink = this;
            } else {
                previousNode.NextForewardLink = this;
            }
        }
    }

    public class BackwardLink {
        public BackwardLink(NodeLink nodeLink) {
            this.NodeLink = nodeLink ?? throw new System.ArgumentNullException(nameof(nodeLink));
        }

        public NodeLink NodeLink { get; }
        public BackwardLink? NextBackwardLink { get; set; }
        public Node PreviousNode => NodeLink.PreviousNode;
        public Node? Condition { get => NodeLink.Condition; set => NodeLink.Condition = value; }
        public bool ConditionResult { get => NodeLink.ConditionResult; set => NodeLink.ConditionResult = value; }

        public BackwardLink GetLast() {
            return (this.NextBackwardLink is null)
                ? this
                : this.NextBackwardLink.GetLast();
        }

        internal void Connect() {
            var nextNode = this.NodeLink.NextNode;
            if (nextNode.NextBackwardLink is object) {
                nextNode.NextBackwardLink.GetLast().NextBackwardLink = this;
            } else {
                nextNode.NextBackwardLink = this;
            }
        }
    }
}
