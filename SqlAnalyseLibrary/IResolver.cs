using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace SqlAnalyseLibrary {
    public interface IResolver {
        (bool found, Node? result) ResolveSchemaObjectName (MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind);
        (bool found, Node? result) ResolveColumnName (MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind);
        List<Node> ? ResolveCurrentTableReferences (MultiPartIdentifier name);
    }

    public interface IResolverChainable {
        IResolver? GetResolver (IResolver resolver, NodeElementKind elementKind);
    }
    public class Resolver : IResolver {
        public static IResolver GetResolverUsingScopes (Scopes? scopes, IResolver resolver) {
            if (scopes is null) {
                return resolver;
            } else {
                return new ResolverWithScopes (scopes, resolver);
            }
        }

        public static IResolver GetResolverForChainable (Node? nodeMayBeResolverChainable, IResolver resolver, NodeElementKind nodeElementKind) {
            if (nodeMayBeResolverChainable is IResolverChainable resolverChainable) {
                var result = resolverChainable.GetResolver (resolver, nodeElementKind);
                if (result is object) {
                    return result;
                }
            }
            return resolver;
        }

        protected IResolver _Resolver;
        protected Resolver (IResolver resolver) {
            this._Resolver = resolver ??
                throw new System.ArgumentNullException (nameof (resolver));
        }

        public virtual (bool found, Node? result) ResolveSchemaObjectName (MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) => this._Resolver.ResolveSchemaObjectName (name, scope, scopes, elementKind);

        public virtual (bool found, Node? result) ResolveColumnName (MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) => this._Resolver.ResolveColumnName (name, scope, scopes, elementKind);

        public List<Node> ? ResolveCurrentTableReferences (MultiPartIdentifier name) => this._Resolver.ResolveCurrentTableReferences (name);
    }

    public class ResolverWithScopes : IResolver {

        private readonly Scopes? _Scopes;
        private readonly IResolver _Resolver;

        public ResolverWithScopes (Scopes? scopes, IResolver resolver) {
            this._Scopes = scopes;
            this._Resolver = resolver;
        }

        public (bool found, Node? result) ResolveColumnName (MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) => this._Resolver.ResolveColumnName (name, scope, scopes ?? this._Scopes, elementKind);

        public (bool found, Node? result) ResolveSchemaObjectName (MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) => this._Resolver.ResolveSchemaObjectName (name, scope, scopes ?? this._Scopes, elementKind);

        public List<Node> ? ResolveCurrentTableReferences (MultiPartIdentifier name) {
            var nodeTableReferences = this._Scopes?.NodeTableReferences;
            if (nodeTableReferences is object) {
                while (true) {
                    if ((nodeTableReferences.Children.Count == 0) &&
                        (nodeTableReferences.TabularResult is NodeOuputTable nodeOuputTable)) {
                        if (nodeOuputTable.Columns.Count == 0 && nodeOuputTable.NodeFrom is null) {
                            var nodeFrom = nodeOuputTable.Expression?.NodeFrom;
                            if (nodeFrom is NodeTableReferences nextNodeTableReferences) {
                                nodeTableReferences = nextNodeTableReferences;
                                continue;
                            }
                        }
                    }
                    break;
                }
                return nodeTableReferences.Children.ToList ();
            }
            return this._Resolver.ResolveCurrentTableReferences (name);
        }
    }
}