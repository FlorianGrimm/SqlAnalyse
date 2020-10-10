using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Linq;

namespace SqlAnalyseLibrary {
    public class NodeNamed : Node {
        public NodeNameKind NameKind { get; set; }
        public MultiPartIdentifier Name { get; set; }

        public NodeNamed() {
            this.Name = new MultiPartIdentifier();
            this.NameKind = NodeNameKind.Unknown;
        }

        public void SetName(MultiPartIdentifier? name, NodeNameKind? kind) {
            if (name is object) {
                this.Name = name;
            }
            if (kind.HasValue) {
                this.NameKind = kind.Value;
            }
        }

        public void AddNameIdentifier(Identifier? name, NodeNameKind? kind) {
            if (name is object) {
                this.Name.Identifiers.Add(name);
            }
            if (kind.HasValue) {
                this.NameKind = kind.Value;
            }
        }

        public NodeNamed? GetLastName(NodeNameKind? kind) {
            //if (this.Name.Count == 1 && kind.HasValue && this.Kind == kind.Value) {
            //    return this;
            //}
            if (this.Name.Count > 0) {
                var result = new NodeNamed();
                result.AddNameIdentifier(this.Name[this.Name.Count - 1], kind);
                return result;
            } else {
                return null;
            }
        }
        public override string ToString()
            => $"{this.GetType().Name}:{Index} {Level} {Comment} NameKind:{NameKind}-{this.ToStringNameOnly()}";

        public string ToStringNameOnly() => (this.Name is object) ? string.Join("/", this.Name.Identifiers.Select(i => i.Value)) : "";
    }


    public enum NodeNameKind {
        Unknown,
        ColumnRegular,
        ColumnWildcard,
        ObjectAlias
    }
}
