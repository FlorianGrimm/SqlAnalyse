using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class SqlObjectWithColumns : SqlObject, IResolverChainable {
        public readonly List<SqlColumn> Columns;

        public SqlObjectWithColumns() {
            this.Columns = new List<SqlColumn>();
        }

        public void AddColumn(SqlColumn sqlColumn) {
            this.Columns.Add(sqlColumn);
        }
        public void AddColumn(string name, SqlScalarType columnType) {
            this.Columns.Add(new SqlColumn(MultiPartIdentifierUtility.Create(name), columnType));
        }

        public IResolver? GetResolver(IResolver resolver, NodeElementKind elementKind) {
            if (elementKind == NodeElementKind.Column || elementKind == NodeElementKind.ColumnRegular) {
                return new ResolverColumn(this, resolver);
            }
            return null;
        }
        public class ResolverColumn : Resolver {
            private SqlObjectWithColumns _Owner;

            public ResolverColumn(SqlObjectWithColumns owner, IResolver resolver) : base(resolver) {
                this._Owner = owner;
            }

            public override (bool found, Node? result) ResolveColumnName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) {
                if (elementKind == NodeElementKind.Column || elementKind == NodeElementKind.ColumnRegular) {
                    if (name.Count > 1) {
                        name = new MultiPartIdentifier() { Identifiers = { name.Identifiers[name.Identifiers.Count - 1] } };
                    }
                    if (name.Count == 1) {
                        foreach (var column in this._Owner.Columns) {
                            if (MultiPartIdentifierUtility.IsEqual(column.Name, name)) {
                            }
                        }
                    }
                }
                return (false, null);
            }
        }
    }
}