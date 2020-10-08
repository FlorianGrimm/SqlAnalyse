using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SqlAnalyseLibrary {
    public class NodeReference : NodeNamed, INodeHasScope {

        public SqlScalarType ScalarType;

        public NodeScopeKind Scope { get; set; }

        public Scopes Scopes { get; set; }

        internal void SetColumnRegular(MultiPartIdentifier multiPartIdentifier)
        {
            this.Name = multiPartIdentifier;
            this.Kind = NodeNameKind.ColumnRegular;
        }

        public override void Resolve()
        {
            base.Resolve();
        }

        public override string ToString()
        {
            var i = (this.Name is object) ? string.Join("/", this.Name.Identifiers.Select(i => i.Value)) : "";
            return i;
        }
    }
}
