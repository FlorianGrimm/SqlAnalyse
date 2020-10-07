using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SqlAnalyseLibrary {
    public class NodeReference : Node {
        public NodeReferenceKind Kind;
        public MultiPartIdentifier Name;
        
        public SqlScalarType ScalarType;

        internal void SetColumnRegular(MultiPartIdentifier multiPartIdentifier) {
            this.Name = multiPartIdentifier;
            this.Kind = NodeReferenceKind.ColumnRegular;
        }
        public override string ToString() {
            var i = (this.Name is object) ? string.Join("/", this.Name.Identifiers.Select(i=>i.Value)) : "";
            return i;
        }
    }

    public enum NodeReferenceKind {
        Unknown,
        ColumnRegular
    }
}
