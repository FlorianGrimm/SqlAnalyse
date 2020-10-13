namespace SqlAnalyseLibrary {
    public class NodeVoid : Node {
        public override bool IsResultNodeSet() => true;
        public override Node? GetResultNode() => null;
        public override void SetResultNode(Node? value) { }
        public override Node? GetResolvedType() => null;
        public override void SetResolvedType(Node? value) { }
        public override void ResolveTypesStep1(IResolver resolver) { }
    }
}