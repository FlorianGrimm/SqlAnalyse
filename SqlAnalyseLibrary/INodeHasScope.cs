namespace SqlAnalyseLibrary {
    public interface INodeHasScope {
        NodeScopeKind Scope { get; set; }
        Scopes? Scopes { get; set; }
    }
}
