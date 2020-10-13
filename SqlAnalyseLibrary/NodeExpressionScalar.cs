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
            if (this.IsResultNodeSet()) { return; }
            // base.ResolveTypesStep1(resolver);
            if (this.Kind == NodeExpressionScalarKind.Const) {
                throw new NotImplementedException();
            }
            if (this.Kind == NodeExpressionScalarKind.ColumnAccess) {
                if (this.Callable.Count == 0) {
                    if (this.Parameters.Count == 1) {
                        var column = this.Parameters[0];
                        column.ResolveTypesStep1(resolver);
                        NodeResolveUtility.ResolveNowOrLater(this, column);
                    } else {
                        throw new NotSupportedException();
                    }
                } else if (this.Callable.Count == 1) {
                    var callable0 = this.Callable[0];
                    callable0.ResolveTypesStep1(resolver);
                    if (callable0 is NodeNamed nodeNamed) {
                        var (foundCallable0, resultCallable0) = resolver.ResolveSchemaObjectName(nodeNamed.Name, NodeScopeKind.AnyScope, null, NodeElementKind.ObjectLike);
                        if (foundCallable0 && resultCallable0 is object) {
                            resolver = Resolver.GetResolverForChainable(resultCallable0, resolver, NodeElementKind.Column);
                        }
                    }
                    if (this.Parameters.Count == 1) {
                        var column = this.Parameters[0];
                        column.ResolveTypesStep1(resolver);
                        var nodeResolvedType = column.GetResolvedType();
                        if (nodeResolvedType is object) {
                            this.SetResolvedType(nodeResolvedType);
                        }
                    } else {
                        throw new NotSupportedException();
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
