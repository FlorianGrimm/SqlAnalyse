using System;
using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeResolveUtility : Node {
        public static void ResolveNowOrLater(Node target, Node? node) => ResolveNowOrLater(target, node, node);
        public static void ResolveNowOrLater(Node target, Node? resultNode, Node? resolvedType) {
            bool neededResultNode = false;
            bool neededResolvedType = false;
            if (resultNode is object && target.GetResultNode() is null) {
                var getResultNode = resultNode.GetResultNode();
                if (getResultNode is object) {
                    target.SetResultNode(getResultNode);
                } else {
                    neededResultNode = true;
                }
            }
            if (resolvedType is object && target.GetResolvedType() is null) {
                var getResolvedType = resolvedType.GetResolvedType();
                if (getResolvedType is object) {
                    target.SetResolvedType(getResolvedType);
                } else {
                    neededResolvedType = true;
                }
            }
            if (neededResultNode || neededResolvedType) {
                target.SetResultNode(new NodeDelayedResolved(target, (neededResultNode) ? resultNode : null, (neededResolvedType) ? resolvedType : null));
            }
        }
        public static void ResolveNowOrLater(Node target, List<Node> sourceNodes, Func<Node, List<Node>, Node?> generator, IResolver resolver) {
            var ndrl = new NodeDelayedResolvedList(target, sourceNodes, generator);
            ndrl.Initialize(resolver);
        }
    }
    public class NodeDelayedResolvedList : Node {
        private Node target;
        private List<Node> sourceNodes;
        private Func<Node, List<Node>, Node?> generator;

        public NodeDelayedResolvedList(Node target, List<Node> sourceNodes, Func<Node, List<Node>, Node?> generator) {
            this.target = target;
            this.sourceNodes = sourceNodes;
            this.generator = generator;
        }

        internal void Initialize(IResolver? resolver) {
            if (resolver is object) {
                foreach (var sourceNode in sourceNodes) {
                    if (!sourceNode.IsResultNodeSet()) {
                        sourceNode.ResolveTypesStep1(resolver);
                    }
                }
            }
            var result = generator(target, sourceNodes);
            if (result is object && result.GetResultNode() is Node resultNode && result.GetResolvedType() is Node resolvedType) {
                target.SetResultNode(resultNode);
                target.SetResolvedType(resolvedType);
            } else {
                target.SetResultNode(this);
                target.SetResolvedType(this);
            }
        }
        public override void ResolveTypesStep1(IResolver resolver) {
            // base.ResolveTypesStep1(resolver);
            foreach (var sourceNode in sourceNodes) {
                if (!sourceNode.IsResultNodeSet()) {
                    sourceNode.ResolveTypesStep1(resolver);
                }
            }
            var result = generator(target, sourceNodes);
            if (result is object && result.GetResultNode() is Node resultNode && result.GetResolvedType() is Node resolvedType) {
                target.SetResultNode(resultNode);
                target.SetResolvedType(resolvedType);
                this.SetResultNode(resultNode);
                this.SetResolvedType(resolvedType);
            }
        }

        public override bool IsResultNodeSet() => (this._ResultNode is object);

        public override Node? GetResultNode() {
            return base.GetResultNode() ?? this;
        }
        public override Node? GetResolvedType() {
            return base.GetResolvedType() ?? this;
        }
    }

    public class NodeDelayedResolved : Node {
        private Node Target;
        private Node? SourceResultNode;
        private Node? SourceResolvedType;

        public NodeDelayedResolved(Node target, Node? resultNode, Node? resolvedType) {
            this.Target = target;
            this.SourceResultNode = resultNode;
            this.SourceResolvedType = resolvedType;
        }

        public override bool IsResultNodeSet() => (this._ResultNode is object);

        public override void ResolveTypesStep1(IResolver resolver) {
            if (this.SourceResultNode is object && this.Target.GetResultNode() is null) {
                var getResultNode = this.SourceResultNode.GetResultNode();
                if (getResultNode is object) { 
                    this.Target.SetResultNode(getResultNode);
                }
            }
            if (this.SourceResolvedType is object && this.Target.GetResolvedType() is null) {
                var getResolvedType = this.SourceResolvedType.GetResolvedType();
                if (getResolvedType is object) {
                    this.Target.SetResolvedType(getResolvedType);
                }
            }
        }

        public override Node? GetResultNode() {
            var result = this._ResultNode;
            if (result is object) {
                return result;
            } else if (this.SourceResultNode is Node src) {
                return this._ResultNode = src.GetResultNode();
            } else {
                return null;
            }
        }
        public override Node? GetResolvedType() {
            var result = this._ResolvedType;
            if (result is object) {
                return result;
            } else if (this.SourceResolvedType is Node src) {
                return this._ResolvedType = src.GetResultNode();
            } else {
                return null;
            }
        }
    }
}