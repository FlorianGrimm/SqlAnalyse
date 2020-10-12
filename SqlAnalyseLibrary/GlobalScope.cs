namespace SqlAnalyseLibrary {
    public class GlobalScope : BaseScope {
        public GlobalScope(GlobalScope? parent):base(parent) {
        }

        public new GlobalScope? Parent => base.Parent as GlobalScope;

        public override string ToString()
            => (this.Parent is object)
                ? $"{this.Index}>{this.Parent.Index}"
                : $"{this.Index}";
    }
}
