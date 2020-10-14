using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Linq;

namespace SqlAnalyseLibrary {
    public class NodeReference : NodeNamedWithResolvedType, INodeHasScope {

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
            if (this.IsResultNodeSet()) { return; }
            // base.ResolveTypesStep1(resolver);
            resolver = Resolver.GetResolverUsingScopes(this.Scopes, resolver);
            {
                if (this.IsNameSet()) {
                    if (this.ElementKind == NodeElementKind.ObjectLike) {
                        var (found, result) = resolver.ResolveSchemaObjectName(this.Name, this.Scope, this.Scopes, this.ElementKind);
                        if (found && result is Node nodeResolvedElement) {
                            this.ResolvedElement = nodeResolvedElement;
                            NodeResolveUtility.ResolveNowOrLater(this, nodeResolvedElement);
                        }
                    } else if ((this.ElementKind == NodeElementKind.Column) || (this.ElementKind == NodeElementKind.ColumnRegular)) {
                        var (found, result) = resolver.ResolveColumnName(this.Name, this.Scope, this.Scopes, this.ElementKind);
                        if (found && result is Node nodeResolvedElement) {
                            this.ResolvedElement = nodeResolvedElement;
                            NodeResolveUtility.ResolveNowOrLater(this, nodeResolvedElement);
                        }
                    } else {
                        throw new NotSupportedException("??");
                        //var (found, result) = resolver.ResolveSchemaObjectName(this.Name, this.Scope, this.Scopes);
                        //if (found && result is object) { this.SetTypeResolved(result); }
                    }
                    return;
                }
            }
            if (this.ElementKind == NodeElementKind.ColumnWildcard) {
                var tables = resolver.ResolveCurrentTableReferences(new MultiPartIdentifier());
                if (tables is object){
                    foreach(var t in tables){
                        System.Console.WriteLine(t.ToString());
                    }
                }
                // here
                //resolver.ResolveSchemaObjectNames(this)
                //resolver.ResolveColumnNames(new MultiPartIdentifier(),)
                //return;
            }
            {
                throw new NotSupportedException($"?? {this.ElementKind}");
            }
        }

        // public override Node? GetResolvedType() => this.ResolvedElement?.GetResolvedType();
        // public override void SetResolvedType(Node? value) { base.SetResolvedType(value); }

        public override string ToString() {
            var i = (this.Name is object) ? string.Join("/", this.Name.Identifiers.Select(i => i.Value)) : "";
            return i;
        }
    }
}
