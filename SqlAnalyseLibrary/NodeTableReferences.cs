using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeTableReferences : Node, INodeHasScope, IResolverChainable {
        public NodeOuputTable? TabularResult { get; set; }
        public List<Node> Children { get; }
        public NodeScopeKind Scope { get; set; }
        public Scopes? Scopes { get; set; }

        public NodeTableReferences() {
            this.Children = new List<Node>();
        }

        public NodeTableReferences(
            int level,
            string comment,
            Scopes? scopes,
            NodeScopeKind scope) : this() {
            this.Level = level;
            this.Comment = comment;
            this.Scopes = scopes;
            this.Scope = scope;
        }

        public override IEnumerable<Node> GetChildren() {
            foreach (var c in this.Children) {
                yield return c;
            }
            if (this.TabularResult is object) {
                yield return this.TabularResult;
            }
        }

        public override void ResolveTypesStep1(IResolver resolver) {
            if (this.IsResultNodeSet()) { return; }

            var resolverScopes = Resolver.GetResolverUsingScopes(this.Scopes, resolver);

            //bool resolved = true;
            var tableRefs = new List<Node>();
            foreach (var c in this.Children) {
                c.ResolveTypesStep1(resolverScopes);
                tableRefs.Add(c);
            }            
            //NodeResolveUtility.ResolveNowOrLater(this, tableRefs, CreateSqlObjectWithColumns, resolver);


            var tabularResult = this.TabularResult;
            if (tabularResult is null) {
                this.SetResultNode(this);
                this.SetResolvedType(this);
            } else { 
                tabularResult.ResolveTypesStep1(resolverScopes);
                NodeResolveUtility.ResolveNowOrLater(this, tabularResult);
            }


            //if (this.TabularResult is object) {
            //    this.TabularResult.ResolveTypesStep1(resolver);
            //    if (resolved) {
            //        var resolvedType = this.TabularResult.GetResolvedType();
            //        if (resolvedType is object) {
            //            this.SetResolvedType(resolvedType);
            //        }
            //    }
            //} else {
            //    if (resolved) {
            //        this.SetResolvedType(this);
            //    }
            //}
        }

        private static Node? CreateSqlObjectWithColumns(Node that, List<Node> items) {
            var result = new SqlObjectWithColumns();
            foreach (var item in items) { 
            }
            return result;
        }

        public IResolver? GetResolver(IResolver resolver, NodeElementKind elementKind) {
            if (elementKind == NodeElementKind.Column) {
                return new ResolverColumn(this, resolver);
            }
            return null;
        }

        public class ResolverColumn : IResolver {
            private readonly NodeTableReferences owner;
            private readonly IResolver _Resolver;

            public ResolverColumn(NodeTableReferences owner, IResolver resolver) {
                this.owner = owner;
                this._Resolver = resolver;
            }

            public (bool found, Node? result) ResolveColumnName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) {
                foreach (var child in this.owner.Children) {
                    var nodeResolvedType = child.GetResolvedType();
                    if (nodeResolvedType is object) {
                        var childResolver = Resolver.GetResolverForChainable(nodeResolvedType, this._Resolver, elementKind);
                        var result = childResolver.ResolveColumnName(name, scope, scopes, elementKind);
                        if (result.found) { return result; }
                    }
                }
                return (false, null);
            }

            public (bool found, Node? result) ResolveSchemaObjectName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) 
                => this._Resolver.ResolveSchemaObjectName(name, scope, scopes, elementKind);

            public List<Node>? ResolveCurrentTableReferences(MultiPartIdentifier name)
                => this._Resolver.ResolveCurrentTableReferences(name);
        }
    }
}
