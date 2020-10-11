using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeExpressionScalar : NodeExpression {
        public NodeExpressionScalarKind Kind { get; set; }
        public SqlScalarType? ScalarType { get; set; }

        public NodeExpressionScalar() : base() {
        }

        public NodeExpressionScalar(
            int level,
            string comment,
            NodeExpressionScalarKind kind) : this() {
            this.Level = level;
            this.Comment = comment;
            this.Kind = kind;
        }


        public override IEnumerable<Node> GetChildren() {
            foreach (var c in this.Callable) {
                yield return c;
            }
            foreach (var c in this.Parameters) {
                yield return c;
            }
        }

        public override string ToString()
            => $"{this.GetType().Name}:{Index} {Level} {Comment} {this.Kind} {this.Callable.Count} {this.Parameters.Count}";

        public MultiPartIdentifier? GetName() {
            if (this.Kind == NodeExpressionScalarKind.Const) {
                return null;
            }
            // throw new NotSupportedException("nodeExpression.Kind is ? " + nodeExpression.Kind);
            return null;
        }
    }

    public enum NodeExpressionScalarKind {
        Unknown,
        Const,
        Equals,
        GreaterThan,
        LessThan,
        GreaterThanOrEqualTo,
        LessThanOrEqualTo,
        NotEqualToBrackets,
        NotEqualToExclamation,
        NotLessThan,
        NotGreaterThan,
        LeftOuterJoin,
        RightOuterJoin,
        FunctionCall,
        ColumnAccess
        //Alias
    }
}
