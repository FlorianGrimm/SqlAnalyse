using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlTypes;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace SqlAnalyseLibrary {
    public class SqlScalarType : SqlObject {
        public SqlScalarType(MultiPartIdentifier name) {
            this.Name = name;
        }
        //System.Data.Common.SchemaTableColumn
        public override Node? GetResolvedType() => this;
    }
}
