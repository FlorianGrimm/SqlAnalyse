using System.Collections.Generic;
using System.Linq;

namespace SqlAnalyseLibrary {
    public class BaseScope {
        private static int __Index;
        private int _Index;
        public int Index => _Index;

        public List<ScopeItem> Items;

        public BaseScope() {
            this._Index = 1 + System.Threading.Interlocked.Increment(ref __Index);
            this.Items = new List<ScopeItem>();
        }

        public void Add(NodeNamed named, Node value) {
            this.Items.Add(new ScopeItem(named, value));
        }
        public override string ToString()
            => $"{this.Index}";

        public virtual string ToDebugString() {
            if (this.Items.Count == 0) {
                return $"{this.ToString()} []";
            } else {
                var names = string.Join(",", this.Items.Select(i => i.Named).Take(10).Select(n => n.ToStringNameOnly()));
                var more = (this.Items.Count > 10) ? ", ..." : string.Empty;
                return $"{this.ToString()} [{names}{more}]";
            }
        }
    }
    public class ScopeItem {
        public ScopeItem(NodeNamed named, Node value) {
            this.Named = named;
            this.Value = value;
        }

        public NodeNamed Named { get; }
        public Node Value { get; }
    }
}