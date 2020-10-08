using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Linq;

namespace SqlAnalyseLibrary {
    public class NodeNamed : Node {
        public NodeNameKind Kind;
        public MultiPartIdentifier Name;

        public NodeNamed() {
            this.Name = new MultiPartIdentifier();
            this.Kind = NodeNameKind.Unknown;
        }

        public void SetName(MultiPartIdentifier? name, NodeNameKind? kind) {
            if (name is object) {
                this.Name = name;
            }
            if (kind.HasValue) {
                this.Kind = kind.Value;
            }
        }

        public void AddNameIdentifier(Identifier? name, NodeNameKind? kind) {
            if (name is object) {
                this.Name.Identifiers.Add(name);
            }
            if (kind.HasValue) {
                this.Kind = kind.Value;
            }
        }
        public override string ToString()
            => $"{this.GetType().Name}:{Index} {Level} {Comment} Kind:{Kind}-{this.ToStringNameOnly()}";

        public string ToStringNameOnly() => (this.Name is object) ? string.Join("/", this.Name.Identifiers.Select(i => i.Value)) : "";
    }


    public enum NodeNameKind {
        Unknown,
        ColumnRegular,
        ColumnWildcard,
        ObjectAlias
    }
}
