using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Linq;

namespace SqlAnalyseLibrary {
    public class NodeNamed : Node {
        public NodeElementKind ElementKind { get; set; }
        public MultiPartIdentifier Name { get; set; }

        public NodeNamed() {
            this.Name = new MultiPartIdentifier();
            this.ElementKind = NodeElementKind.Unknown;
        }
        public bool IsNameSet()
            => (this.Name.Count > 0);

        public void SetName(MultiPartIdentifier? name, NodeElementKind? kind) {
            if (name is object) {
                this.Name = name;
            }
            if (kind.HasValue) {
                this.ElementKind = kind.Value;
            }
        }

        public void AddNameIdentifier(Identifier? name, NodeElementKind? kind) {
            if (name is object) {
                this.Name.Identifiers.Add(name);
            }
            if (kind.HasValue) {
                this.ElementKind = kind.Value;
            }
        }

        public NodeNamed? GetLastName(NodeElementKind? kind) {
            //if (this.Name.Count == 1 && kind.HasValue && this.Kind == kind.Value) {
            //    return this;
            //}
            if (this.IsNameSet()) {
                var result = new NodeNamed();
                result.AddNameIdentifier(this.Name[this.Name.Count - 1], kind);
                return result;
            } else {
                return null;
            }
        }

        public override string ToString()
            => $"{this.GetType().Name}:{this.Index} {this.Level} {this.Comment} {this.ElementKind}-{this.ToStringNameOnly()}";

        public string ToStringNameOnly() => MultiPartIdentifierUtility.ConvertToDebugString(this.Name);
    }

    public class NodeNamedWithResolvedType : NodeNamed {
        private Node? resolvedType;

        public override Node? GetResolvedType() {
            return this.resolvedType;
        }

        public override void SetResolvedType(Node? value) {
            this.resolvedType = value;
        }
    }
}
