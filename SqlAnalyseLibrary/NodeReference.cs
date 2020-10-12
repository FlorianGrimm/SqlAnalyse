using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Linq;

namespace SqlAnalyseLibrary {
    public class NodeReference : NodeNamed, INodeHasScope {

        //public SqlScalarType? ScalarType;
        //public SqlTable? SqlTable;

        public Node? ResolvedElement;

        public NodeScopeKind Scope { get; set; }

        public Scopes? Scopes { get; set; }

        public NodeReference() {
        }

        public NodeReference(
            int level,
            string comment,
            Scopes scopes,
            NodeScopeKind scope) : this() {
            this.Level = level;
            this.Comment = comment;
            this.Scopes = scopes;
            this.Scope = scope;
        }

        internal void SetColumnRegular(MultiPartIdentifier multiPartIdentifier) {
            this.Name = multiPartIdentifier;
            this.ElementKind = NodeElementKind.ColumnRegular;
        }

        public override void ResolveTypesStep1(IResolver resolver) {
            if (this.GetResolvedType() is object) { return; }
            base.ResolveTypesStep1(resolver);
            if (this.ResolvedElement is object) {
                this.SetResolvedType(this.ResolvedElement.GetResolvedType());
            } else if (this.IsNameSet()) {
                if (this.ElementKind == NodeElementKind.ObjectLike) {
                    var (found, result) = resolver.ResolveSchemaObjectName(this.Name, this.Scope, this.Scopes, this.ElementKind);
                    if (found && result is object) { this.ResolvedElement = result; }
                } else if ((this.ElementKind == NodeElementKind.Column) || (this.ElementKind == NodeElementKind.ColumnRegular)) {
                    var (found, result) = resolver.ResolveColumnName(this.Name, this.Scope, this.Scopes, this.ElementKind);
                    if (found && result is object) { this.ResolvedElement = result; }
                } else {
                    throw new NotSupportedException("??");
                    //var (found, result) = resolver.ResolveSchemaObjectName(this.Name, this.Scope, this.Scopes);
                    //if (found && result is object) { this.SetTypeResolved(result); }
                }

            } else {
                throw new NotSupportedException("??");
            }
        }

        public override Node? GetResolvedType() => this.ResolvedElement?.GetResolvedType();

        public override string ToString() {
            var i = (this.Name is object) ? string.Join("/", this.Name.Identifiers.Select(i => i.Value)) : "";
            return i;
        }
    }
}
