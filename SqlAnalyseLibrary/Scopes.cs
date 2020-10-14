namespace SqlAnalyseLibrary {
    public class Scopes {
        private static int __Index;
        private int _Index;
        public int Index => _Index;

        public GlobalScope GlobalScope { get; }
        public LocalScope LocalScope { get; }
        public AliasScope AliasScope { get; }
        public INodeHasScope? Node { get; }
        public NodeTableReferences? NodeTableReferences{ get; }

        public Scopes(GlobalScope? globalScope = null) {
            this._Index = 1 + System.Threading.Interlocked.Increment(ref __Index);
            this.GlobalScope = globalScope ?? (new GlobalScope(null));
            this.LocalScope = new LocalScope(null);
            this.AliasScope = new AliasScope(null);
            this.Node = null;
        }
        public Scopes(
                GlobalScope globalScope,
                LocalScope localScope,
                AliasScope aliasScope,
                NodeTableReferences? nodeTableReferences,
                INodeHasScope node) {
            this._Index = 1 + System.Threading.Interlocked.Increment(ref __Index);
            this.GlobalScope = globalScope;
            this.LocalScope = localScope;
            this.AliasScope = aliasScope;
            this.NodeTableReferences = nodeTableReferences;
            this.Node = node;
            if (node is object) {
                node.Scopes = this;
            }
        }
        internal Scopes EnterGlobalScope(INodeHasScope node) {
            return new Scopes(new GlobalScope(this.GlobalScope), new LocalScope(null), new AliasScope(null), null, node);
        }
        internal Scopes EnterLocalScope(INodeHasScope node) {
            return new Scopes(this.GlobalScope, new LocalScope(this.LocalScope), new AliasScope(null), null, node);
        }
        internal Scopes EnterAliasScope(INodeHasScope node) {
            return new Scopes(this.GlobalScope, this.LocalScope, new AliasScope(this.AliasScope), (node as NodeTableReferences) ?? this.NodeTableReferences, node);
        }
        public override string ToString()
            => $"G:{GlobalScope.ToString()} L:{LocalScope.ToString()} A:{AliasScope.ToString()}";
        public virtual string ToDebugString()
            => $"G:{GlobalScope.ToDebugString()} L:{LocalScope.ToDebugString()} A:{AliasScope.ToDebugString()}";

    }
}
