using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;

namespace SqlAnalyseLibrary {
    public class EvaluationState {
        public EvaluationState(SqlEnvironment sqlEnvironment, GlobalScope? globalScope) {
            this.SqlEnvironment = sqlEnvironment ?? throw new System.ArgumentNullException(nameof(sqlEnvironment));
            this.GlobalScope = globalScope ?? (new GlobalScope(null));
        }

        public SqlEnvironment SqlEnvironment { get; }
        public GlobalScope GlobalScope { get; }

        public (bool found, Node? result) ResolveSchemaObjectName(MultiPartIdentifier nameSchemaObjectName, NodeScopeKind scope, Scopes scopes, NodeElementKind elementKind) {
            // TODO: ResolveSchemaObjectName
            if (scope == NodeScopeKind.AliasScope || scope == NodeScopeKind.AnyScope) {
                var result = this.ResolveSchemaObjectNameOnScope(nameSchemaObjectName, scopes.AliasScope, elementKind);
                if (result.found) { return result; }
            }
            if (scope == NodeScopeKind.LocalScope || scope == NodeScopeKind.AnyScope) {
                var result = this.ResolveSchemaObjectNameOnScope(nameSchemaObjectName, scopes.LocalScope, elementKind);
                if (result.found) { return result; }
            }
            if (scope == NodeScopeKind.GlobalScope || scope == NodeScopeKind.AnyScope) {
                var result = this.ResolveSchemaObjectNameOnScope(nameSchemaObjectName, scopes.GlobalScope, elementKind);
                if (result.found) { return result; }
            }
            return (false, null);
        }

        public (bool found, Node? result) ResolveSchemaObjectNameOnScope(MultiPartIdentifier nameSchemaObjectName, BaseScope scope, NodeElementKind elementKind) {
            var items = scope.GetItems();
            foreach (var item in items) {
                if (item.IsNameEqual(nameSchemaObjectName)) {
                    if (NodeElementKindUtility.Matches(item.ElementKind, elementKind)) {
                        return (true, item.Value);
                    } else {
                        return (false, null);
                    }
                }
            }
            foreach (var item in items) {
                if (item.IsSchemaObjectNameEqual(nameSchemaObjectName, this.SqlEnvironment)) {
                    if (NodeElementKindUtility.Matches(item.ElementKind, elementKind)) {
                        return (true, item.Value);
                    } else {
                        return (false, null);
                    }
                }
            }
            return (false, null);
        }
    }
}