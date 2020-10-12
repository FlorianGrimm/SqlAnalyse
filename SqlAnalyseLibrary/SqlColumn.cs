using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.Text;

namespace SqlAnalyseLibrary {
    public class SqlColumn : SqlObject {
        public SqlColumn(MultiPartIdentifier name, SqlScalarType columnType) {
            this.Name = name;
            this.ElementKind = NodeElementKind.ColumnRegular;
            this.ColumnType = columnType;
        }

        public SqlScalarType ColumnType { get; set; }

        public override Node? GetResolvedType() => this.ColumnType;

    }
}
