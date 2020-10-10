using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;

namespace SqlAnalyseLibrary {
    public class EvaluationState {
        public EvaluationState(SqlEnvironment sqlEnvironment) {
            this.SqlEnvironment = sqlEnvironment ?? throw new System.ArgumentNullException(nameof(sqlEnvironment));
        }

        public SqlEnvironment SqlEnvironment { get; }

        public void ResolveSchemaObjectName(MultiPartIdentifier nameSchemaObjectName) {
            // TODO: ResolveSchemaObjectName
        }
    }
}