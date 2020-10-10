using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SqlAnalyseLibrary {
    public class StaticEvaluatorResolver {
        public readonly EvaluationState EvaluationState;
        public readonly GlobalScope GlobalScope;
        public readonly Node NodeRoot;

        public StaticEvaluatorResolver(EvaluationState evaluationState,GlobalScope globalScope, Node nodeRoot) {
            this.EvaluationState = evaluationState;
            this.GlobalScope = globalScope;
            this.NodeRoot = nodeRoot;
        }

        public void Resolve() {
        }
    }
}
