namespace SqlAnalyseLibrary {
    public enum NodeScopeKind {
        Unknown,

        /// <summary>
        /// Global Scope
        /// </summary>
        GlobalScope,

        /// <summary>
        /// Local Scope
        /// </summary>
        LocalScope,

        /// <summary>
        /// Alias Scope
        /// </summary>
        AliasScope,

        /// <summary>
        /// Global, Local or Alias Scope
        /// </summary>
        AnyScope,

        Column
    }
}
