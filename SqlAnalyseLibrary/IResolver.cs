using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace SqlAnalyseLibrary {
    public interface IResolver {
        (bool found, Node? result) ResolveSchemaObjectName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind);
        (bool found, Node? result) ResolveColumnName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind);
    }

    public interface IResolverChainable {
        IResolver? GetResolver(IResolver resolver, NodeElementKind elementKind);
    }
    public class Resolver : IResolver { 
        public static IResolver GetResolverUsingScopes(Scopes? scopes, IResolver resolver) {
            if (scopes is null) {
                return resolver;
            } else {
                return new ResolverWithScopes(scopes, resolver);
            }
        }
        public static IResolver GetResolverForChainable(Node? nodeMayBeResolverChainable, IResolver resolver, NodeElementKind nodeElementKind) {
            if (nodeMayBeResolverChainable is IResolverChainable resolverChainable) {
                var result = resolverChainable.GetResolver(resolver, nodeElementKind);
                if (result is object) {
                    return result;
                }
            }
            return resolver;
        }

        protected IResolver _Resolver;
        protected Resolver(IResolver resolver) {
            this._Resolver = resolver ?? throw new System.ArgumentNullException(nameof(resolver));
        }

        public virtual (bool found, Node? result) ResolveSchemaObjectName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) => this._Resolver.ResolveSchemaObjectName(name, scope, scopes, elementKind);

        public virtual (bool found, Node? result) ResolveColumnName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind) => this._Resolver.ResolveColumnName(name, scope, scopes, elementKind);

    }
    public class ResolverWithScopes : IResolver {

        private readonly Scopes scopes;
        private readonly IResolver resolver;

        public ResolverWithScopes(Scopes scopes, IResolver resolver) {
            this.scopes = scopes;
            this.resolver = resolver;
        }

        public (bool found, Node? result) ResolveColumnName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind)
            => this.resolver.ResolveColumnName(name, scope, scopes ?? this.scopes, elementKind);

        public (bool found, Node? result) ResolveSchemaObjectName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind)
            => this.resolver.ResolveSchemaObjectName(name, scope, scopes ?? this.scopes, elementKind);
    }

    public class ResolverChainable {
    }
}