namespace SqlAnalyseLibrary {
    public class Scopes {
        private static int __Index;
        private int _Index;
        public int Index => _Index;

        public GlobalScope GlobalScope { get; }
        public LocalScope LocalScope { get; }
        public AliasScope AliasScope { get; }
        public INodeHasScope Node { get; }

        public Scopes() {
            this._Index = 1 + System.Threading.Interlocked.Increment(ref __Index);
            this.GlobalScope = new GlobalScope();
            this.LocalScope = new LocalScope(null);
            this.AliasScope = new AliasScope(null);
            this.Node = null;
        }
        public Scopes(GlobalScope globalScope, LocalScope localScope, AliasScope aliasScope, INodeHasScope node) {
            this._Index = 1 + System.Threading.Interlocked.Increment(ref __Index);
            this.GlobalScope = globalScope;
            this.LocalScope = localScope;
            this.AliasScope = aliasScope;
            this.Node = node;
            if (node is object) {
                node.Scopes = this;
            }
        }
        internal Scopes EnterGlobalScope(INodeHasScope node) {
            return new Scopes(new GlobalScope(), new LocalScope(null), new AliasScope(null), node);
        }
        internal Scopes EnterLocalScope(INodeHasScope node) {
            return new Scopes(this.GlobalScope, new LocalScope(this.LocalScope), new AliasScope(null), node);
        }
        internal Scopes EnterAliasScope(INodeHasScope node) {
            return new Scopes(this.GlobalScope, this.LocalScope, new AliasScope(this.AliasScope), node);
        }
        public override string ToString()
            => $"G:{GlobalScope.ToString()} L:{LocalScope.ToString()} A:{AliasScope.ToString()}";
        public virtual string ToDebugString()
            => $"G:{GlobalScope.ToDebugString()} L:{LocalScope.ToDebugString()} A:{AliasScope.ToDebugString()}";

    }
}
