using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Linq;

namespace SqlAnalyseLibrary {
    public class NodeNamed : Node {
        public NodeNameKind Kind;
        public MultiPartIdentifier Name;

        public NodeNamed()
        {
            this.Name = new MultiPartIdentifier();
            this.Kind = NodeNameKind.Unknown;
        }

        public void SetName(MultiPartIdentifier name, NodeNameKind? kind)
        {
            if (name is object)
            {
                this.Name = name;
            }
            if (kind.HasValue)
            {
                this.Kind = kind.Value;
            }
        }

        public void AddNameIdentifier(Identifier name, NodeNameKind? kind)
        {
            if (name is object)
            {
                this.Name.Identifiers.Add(name);
            }
            if (kind.HasValue)
            {
                this.Kind = kind.Value;
            }
        }
        public override string ToString()
        {
            var i = (this.Name is object) ? string.Join("/", this.Name.Identifiers.Select(i => i.Value)) : "";
            return $"{this.GetType().Name}:{Index} {Level} {Comment} Kind:{Kind}-{i}";
        }
    }


    public enum NodeNameKind {
        Unknown,
        ColumnRegular,
        ColumnWildcard,
        ObjectAlias
    }
}
