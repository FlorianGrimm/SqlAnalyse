using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Collections.Generic;
using System.Linq;

namespace SqlAnalyseLibrary {
    public class BaseScope {
        private static int __Index;
        private int _Index;
        public int Index => _Index;

        public readonly BaseScope? Parent;

        public List<ScopeItem> Items;

        public BaseScope(BaseScope? parent) {
            this._Index = 1 + System.Threading.Interlocked.Increment(ref __Index);
            this.Items = new List<ScopeItem>();
            this.Parent = parent;
        }

        public void Add(MultiPartIdentifier name, NodeElementKind elementKind, Node value) {
            this.Items.Add(new ScopeItem(name, elementKind, value));
        }

        public void Add(NodeNamed named) {
            this.Items.Add(new ScopeItem(named.Name, named.ElementKind, named));
        }

        public void Add(NodeNamed named, Node value) {
            this.Items.Add(new ScopeItem(named.Name, named.ElementKind, value));
        }

        public override string ToString()
            => $"{this.Index}";

        public virtual string ToDebugString() {
            if (this.Items.Count == 0) {
                return $"{this} []";
            } else {
                var names = string.Join(",", this.Items.Select(n => MultiPartIdentifierUtility.ConvertToDebugString(n.Name)).Take(10));
                var more = (this.Items.Count > 10) ? ", ..." : string.Empty;
                return $"{this} [{names}{more}]";
            }
        }

        public IEnumerable<ScopeItem> GetItems() {
            if (this.Parent is null) {
                return this.Items;
            } else if (this.Items.Count == 0) {
                return this.Parent.GetItems();
            } else {
                return this.Items.Concat(this.Parent.GetItems());
            }
        }
    }
    public class ScopeItem {
        public ScopeItem(MultiPartIdentifier name, NodeElementKind elementKind, Node value) {
            this.Name = name;
            this.ElementKind = elementKind;
            this.Value = value;
        }

        public MultiPartIdentifier Name { get; }
        public NodeElementKind ElementKind { get; }

        public Node Value { get; }

        public bool IsNameEqual(MultiPartIdentifier nameB)
            => MultiPartIdentifierUtility.IsEqual(this.Name, nameB);

        public bool IsSchemaObjectNameEqual(MultiPartIdentifier nameSchemaObjectName, SqlEnvironment sqlEnvironment)
            => MultiPartIdentifierUtility.IsEqual(this.Name, nameSchemaObjectName, sqlEnvironment.ServerDatabaseSchema);
    }
}