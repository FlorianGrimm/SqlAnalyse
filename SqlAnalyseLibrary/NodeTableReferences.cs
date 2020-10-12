using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeTableReferences : Node, INodeHasScope, IResolverChainable {
        public Node? TabularResult { get; set; }
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
            if (this.GetResolvedType() is object) { return; }
            //base.ResolveStep1(staticEvaluatorResolver);
            bool resolved = true;
            foreach (var c in this.Children) {
                c.ResolveTypesStep1(resolver);
                if (c.GetResolvedType() is null) {
                    resolved = false;
                }
            }

            if (this.TabularResult is object) {
                this.TabularResult.ResolveTypesStep1(resolver);
                this.SetResolvedType(this.TabularResult.GetResolvedType());
            } else {
                if (resolved) {
                    this.SetResolvedType(this);
                }
            }
        }

        public IResolver? GetResolver(IResolver resolver, NodeElementKind elementKind) {
            if (elementKind == NodeElementKind.Column) {
                return new ResolverColumn(this, resolver);
            }
            return null;
        }

        public class ResolverColumn : IResolver {
            private readonly NodeTableReferences owner;
            private readonly IResolver resolver;

            public ResolverColumn(NodeTableReferences owner, IResolver resolver) {
                this.owner = owner;
                this.resolver = resolver;
            }

            public (bool found, Node? result) ResolveColumnName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) {
                foreach (var child in this.owner.Children) {
                    if (child.GetResolvedType() is object) {
                        var childResolver = Resolver.GetResolverForChainable(child.GetResolvedType(), resolver, elementKind);
                        var result = childResolver.ResolveColumnName(name, scope, scopes, elementKind);
                        if (result.found) { return result; }
                    }
                }
                return (false, null);

            }

            public (bool found, Node? result) ResolveSchemaObjectName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) {
                
                return resolver.ResolveSchemaObjectName(name, scope, scopes, elementKind);
            }
        }
    }
}
