using System.Linq;

namespace SqlAnalyseLibrary {
    public class LocalScope : BaseScope {
        public LocalScope(LocalScope? parent) {
            this.Parent = parent;
        }
        public LocalScope? Parent { get; }

        public override string ToString()
            => (this.Parent is object)
                ? $"{this.Index}>{this.Parent.Index}"
                : $"{this.Index}";
    }
}
