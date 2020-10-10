using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;

namespace SqlAnalyseLibrary {
    public class StackNode {
        public TSqlFragment? AstNode;
        public Scopes Scopes;
        public Node? Previous;
        public Node? Result;

        public StackNode(TSqlFragment? astNode, Scopes scopes, Node? previous) {
            this.AstNode = astNode;
            this.Scopes = scopes;
            this.Previous = previous;
        }

        public GlobalScope? GlobalScope => this.Scopes?.GlobalScope;
        public LocalScope? LocalScope => this.Scopes?.LocalScope;
        public AliasScope? AliasScope => this.Scopes?.AliasScope;

        public void EnterGlobalScope(INodeHasScope node) {
            if (this.Scopes is null) { throw new InvalidOperationException(); }
            this.Scopes = this.Scopes.EnterGlobalScope(node);
        }
        public void EnterLocalScope(INodeHasScope node) {
            if (this.Scopes is null) { throw new InvalidOperationException(); }
            this.Scopes = this.Scopes.EnterLocalScope(node);
        }
        public void EnterAliasScope(INodeHasScope node) {
            if (this.Scopes is null) { throw new InvalidOperationException(); }
            this.Scopes = this.Scopes.EnterAliasScope(node);
        }

        public static Node? Chain(StackNode stackNode, Node? previous) {
            return stackNode.Result;
        }

        public static Node? Null(StackNode stackNode, Node? previous) {
            return null;
        }
    }
}
