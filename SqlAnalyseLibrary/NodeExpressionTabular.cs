using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.Linq;

namespace SqlAnalyseLibrary {
    public class NodeExpressionTabular : NodeExpression {
        public NodeExpressionTabularKind Kind { get; set; }
        public SqlScalarType? ScalarType { get; set; }
        public List<Node> Columns { get; }
        public Node? NodeFrom { get; set; }

        public NodeExpressionTabular() : base() {
            this.Columns = new List<Node>();
        }

        public NodeExpressionTabular(
            int level,
            string comment,
            NodeExpressionTabularKind kind) : this() {
            this.Level = level;
            this.Comment = comment;
            this.Kind = kind;
        }

        public void AddColumn(Node node) {
            if (node is object) {
                if (ReferenceEquals(this, node)) { throw new ArgumentException("this === node", nameof(node)); }
                this.Columns.Add(node);
            }
        }

        public override IEnumerable<Node> GetChildren() {
            if (this.NodeFrom is object) {
                yield return this.NodeFrom;
            }
            foreach (var c in this.Callable) {
                yield return c;
            }
            foreach (var c in this.Parameters) {
                yield return c;
            }
            foreach (var c in this.Columns) {
                yield return c;
            }

        }

        public override string ToString()
            => $"{this.GetType().Name}:{Index} {Level} {Comment} {this.Kind} {this.Callable.Count} {this.Parameters.Count}";

        public override void ResolveTypesStep1(IResolver resolver) {
            this.NodeFrom?.ResolveTypesStep1(resolver);
            foreach (var callable in this.Callable) {
                callable.ResolveTypesStep1(resolver);
            }
            foreach (var parameter in this.Parameters) {
                parameter.ResolveTypesStep1(resolver);
            }
            //if (this.Kind == NodeExpressionTabularKind.Query) {}
            if (this.Columns.Any()) {
                var resolverChained = Resolver.GetResolverForChainable(this.NodeFrom, resolver, NodeElementKind.Column);
                foreach (var column in this.Columns) {
                    column.ResolveTypesStep1(resolverChained);
                }
            }
        }

        public MultiPartIdentifier? GetName() {
            //if (this.Kind == NodeExpressionScalarKind.Const) {
            //    return null;
            //}
            // throw new NotSupportedException("nodeExpression.Kind is ? " + nodeExpression.Kind);
            return null;
        }
    }
    public enum NodeExpressionTabularKind {
        Unknown,
        Select,
        Query
    }
}
