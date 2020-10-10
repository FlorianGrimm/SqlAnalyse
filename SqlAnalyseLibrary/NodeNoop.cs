namespace SqlAnalyseLibrary {
    public class NodeNoop : Node {
        public NodeNoop() {
        }
        public NodeNoop(
            int level,
            string comment) : this() {
            this.Level = level;
            this.Comment = comment;
        }
    }
}
