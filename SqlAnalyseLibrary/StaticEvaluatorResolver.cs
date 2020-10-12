using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SqlAnalyseLibrary {
    public class StaticEvaluatorResolver : IResolver {
        public readonly EvaluationState EvaluationState;
        public readonly GlobalScope GlobalScope;
        public readonly Node NodeRoot;

        public StaticEvaluatorResolver(EvaluationState evaluationState, GlobalScope globalScope, Node nodeRoot) {
            this.EvaluationState = evaluationState;
            this.GlobalScope = globalScope;
            this.NodeRoot = nodeRoot;
        }

        public void Resolve() {
            this.NodeRoot.ResolveTypesStep1(this);
        }

        public (bool found, Node? result) ResolveColumnName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind)
            => (false, null);

        public (bool found, Node? result) ResolveSchemaObjectName(MultiPartIdentifier name, NodeScopeKind scope, Scopes? scopes, NodeElementKind elementKind)
            => (scopes is object)
                ? this.EvaluationState.ResolveSchemaObjectName(name, scope, scopes, elementKind)
                : (false, null);
    }
}
