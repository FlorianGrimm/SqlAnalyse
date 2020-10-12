using System.Linq;

namespace SqlAnalyseLibrary {
    public class AliasScope : BaseScope {
        public AliasScope(AliasScope? parent) : base(parent) {
        }

        public new AliasScope? Parent => base.Parent as AliasScope;

        public override string ToString()
            => (this.Parent is object)
                ? $"{this.Index}>{this.Parent.Index}"
                : $"{this.Index}";
    }
}
