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

        public override void ResolveTypesStep1(IResolver resolver) {
            base.ResolveTypesStep1(resolver);
            if (this.Kind == NodeExpressionScalarKind.Const) {
                throw new NotImplementedException();
            }
            if (this.Kind == NodeExpressionScalarKind.ColumnAccess) {
                if (this.Callable.Count == 0) {
                    if (this.Parameters.Count == 1) {
                        var column = this.Parameters[0];
                        if (column is NodeNamed columnNamed) {
                            columnNamed.ResolveTypesStep1(resolver);
                        }
                        //resolver.ResolveColumnName(new MultiPartIdentifier(), )
                    } else {
                        throw new NotSupportedException();
                    }

                } else if (this.Callable.Count == 1) {
                    if (this.Callable[0] is NodeNamed nodeNamed) {
                        nodeNamed.ResolveTypesStep1(resolver);
                        //resolver.ResolveSchemaObjectName(, NodeScopeKind.AnyScope, null);
                    }
                    throw new NotImplementedException();
                } else {
                    throw new NotImplementedException();
                }
            }
        }

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
