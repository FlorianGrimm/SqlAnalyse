namespace SqlAnalyseLibrary {
    public class EvaluationState {
        public EvaluationState(SqlEnvironment sqlEnvironment) {
            this.SqlEnvironment = sqlEnvironment ?? throw new System.ArgumentNullException(nameof(sqlEnvironment));
        }

        public SqlEnvironment SqlEnvironment { get; }
    }
}