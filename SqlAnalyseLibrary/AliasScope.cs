using System.Linq;

namespace SqlAnalyseLibrary {
    public class AliasScope : BaseScope {
        public AliasScope(AliasScope? parent) {
            this.Parent = parent;
        }

        public AliasScope? Parent { get; }

        public override string ToString()
            => (this.Parent is object)
                ? $"{this.Index}>{this.Parent.Index}"
                : $"{this.Index}";
    }
}
