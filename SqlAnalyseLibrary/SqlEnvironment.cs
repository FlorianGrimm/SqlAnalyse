using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace SqlAnalyseLibrary {
    public class SqlEnvironment {
        public SqlEnvironment(
            string server = "localhost",
            string database = "database",
            string schema = "dbo") {
            if (string.IsNullOrWhiteSpace(server)) {
                throw new System.ArgumentException($"'{nameof(server)}' cannot be null or whitespace", nameof(server));
            }
            if (string.IsNullOrWhiteSpace(database)) {
                throw new System.ArgumentException($"'{nameof(database)}' cannot be null or whitespace", nameof(database));
            }
            if (string.IsNullOrWhiteSpace(schema)) {
                throw new System.ArgumentException($"'{nameof(schema)}' cannot be null or whitespace", nameof(schema));
            }

            this.Server = new Identifier() { Value = server, QuoteType = QuoteType.SquareBracket };
            this.Database = new Identifier() { Value = database, QuoteType = QuoteType.SquareBracket };
            this.Schema = new Identifier() { Value = schema, QuoteType = QuoteType.SquareBracket };
            
            this.ServerDatabase = new MultiPartIdentifier();
            this.ServerDatabase.Identifiers.Add(this.Server);
            this.ServerDatabase.Identifiers.Add(this.Database);

            this.ServerDatabaseSchema = new MultiPartIdentifier();
            this.ServerDatabaseSchema.Identifiers.Add(this.Server);
            this.ServerDatabaseSchema.Identifiers.Add(this.Database);
            this.ServerDatabaseSchema.Identifiers.Add(this.Schema);
        }

        public Identifier Server { get; }
        public Identifier Database { get; }
        public Identifier Schema { get; }
        public MultiPartIdentifier ServerDatabase { get; }
        public MultiPartIdentifier ServerDatabaseSchema { get; }
    }
}