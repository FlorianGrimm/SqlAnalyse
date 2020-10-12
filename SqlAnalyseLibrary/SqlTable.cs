using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.Text;

namespace SqlAnalyseLibrary {
    public class SqlTable : SqlObjectWithColumns {
        public SqlTable(MultiPartIdentifier name) {
            this.Name = name;
            this.ElementKind = NodeElementKind.Table;
        }

        public override Node? GetResolvedType() => this;
    }
}
