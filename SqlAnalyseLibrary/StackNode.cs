using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace SqlAnalyseLibrary {
    public class StackNode {
        public Node Previous;
        public TSqlFragment Node;
        public Node Result;

        public Scopes Scopes;
        public GlobalScope GlobalScope => Scopes.GlobalScope;
        public LocalScope LocalScope => Scopes.LocalScope;
        public AliasScope AliasScope => Scopes.AliasScope;

        public void EnterGlobalScope(INodeHasScope node) {
            this.Scopes = this.Scopes.EnterGlobalScope(node);
        }
        public void EnterLocalScope(INodeHasScope node) {
            this.Scopes = this.Scopes.EnterLocalScope(node);
        }
        public void EnterAliasScope(INodeHasScope node) {
            this.Scopes = this.Scopes.EnterAliasScope(node);
        }

        public static Node Chain(StackNode stackNode, Node previous) {
            return stackNode.Result;
        }

        public static Node Null(StackNode stackNode, Node previous) {
            return null;
        }
    }
}
