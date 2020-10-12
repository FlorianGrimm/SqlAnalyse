using System.Linq;

namespace SqlAnalyseLibrary {
    public class LocalScope : BaseScope {
        public LocalScope(LocalScope? parent) : base(parent) {
        }
        public new LocalScope? Parent => base.Parent as LocalScope;

        public override string ToString()
            => (this.Parent is object)
                ? $"{this.Index}>{this.Parent.Index}"
                : $"{this.Index}";
    }
}
