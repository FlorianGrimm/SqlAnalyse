using System;
using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeScopeElement : NodeNamed, INodeHasScope {
        public Node? Element;
        public NodeScopeKind Scope { get; set; }
        public Scopes? Scopes { get; set; }

        public NodeScopeElement() {
        }

        public override void Resolve(EvaluationState evaluationState) {
            if (this.Element is Node element && this.Scopes is Scopes scopes) {
                if (this.Scope == NodeScopeKind.Alias) {
                    Add table
                } else if (this.Scope == NodeScopeKind.Local) {
                } else if (this.Scope == NodeScopeKind.Global) {
                } else if (this.Scope == NodeScopeKind.Column) {
                    if (element is NodeScopeElement nodeScopeElement) {
                        var name = nodeScopeElement.Name;
                    } else {
                        throw new InvalidOperationException(element.GetType().Name);
                    }
                } else {
                }
            }
            base.Resolve(evaluationState);
        }

        public override IEnumerable<Node> GetChildren() {
            if (this.Element is object) {
                yield return this.Element;
            }
        }
        public override string ToString()
            => $"{this.GetType().Name}:{Index} {Level} {Comment} Scope:{Scope}";

        internal void AddToScope() {
            switch (this.Scope) {
                case NodeScopeKind.Unknown:
                    break;
                case NodeScopeKind.Global:
                    if (this.Scopes is null || this.Element is null) { return; }
                    this.Scopes.GlobalScope.Add(this, this.Element);
                    break;
                case NodeScopeKind.Local:
                    if (this.Scopes is null || this.Element is null) { return; }
                    this.Scopes.LocalScope.Add(this, this.Element);
                    break;
                case NodeScopeKind.Alias:
                    if (this.Scopes is null || this.Element is null) { return; }
                    this.Scopes.AliasScope.Add(this, this.Element);
                    break;
                case NodeScopeKind.Column:
                    break;
                default:
                    break;
            }
        }
    }
}
