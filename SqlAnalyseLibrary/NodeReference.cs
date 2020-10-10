using Microsoft.SqlServer.TransactSql.ScriptDom;

using System.Linq;

namespace SqlAnalyseLibrary {
    public class NodeReference : NodeNamed, INodeHasScope {

        public SqlScalarType? ScalarType;

        public NodeScopeKind Scope { get; set; }

        public Scopes? Scopes { get; set; }

        public NodeReference() {
        }

        public NodeReference(
            int level,
            string comment,
            Scopes scopes,
            NodeScopeKind scope) : this() {
            this.Level = level;
            this.Comment = comment;
            this.Scopes = scopes;
            this.Scope = scope;
        }

        internal void SetColumnRegular(MultiPartIdentifier multiPartIdentifier) {
            this.Name = multiPartIdentifier;
            this.NameKind = NodeNameKind.ColumnRegular;
        }

        public override void Resolve(EvaluationState evaluationState) {
            base.Resolve(evaluationState);
        }

        public override string ToString() {
            var i = (this.Name is object) ? string.Join("/", this.Name.Identifiers.Select(i => i.Value)) : "";
            return i;
        }
    }
}
