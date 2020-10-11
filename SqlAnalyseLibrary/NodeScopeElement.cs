using System;
using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public class NodeScopeElement : NodeNamed, INodeHasScope {
        public Node? Element;
        public NodeScopeKind Scope { get; set; }
        public Scopes? Scopes { get; set; }

        // do this better
        public NodeOuputTable? Owner { get; internal set; }

        public NodeScopeElement() {
        }
        public NodeScopeElement(int level,
            string comment,
            Scopes scopes,
            NodeScopeKind scope) {
            this.Level = level;
            this.Comment = comment;
            this.Scopes = scopes;
            this.Scope = scope;
        }


        public override void Resolve(EvaluationState evaluationState) {
            if (this.Element is Node element && this.Scopes is Scopes scopes) {
                if (this.Scope == NodeScopeKind.AliasScope) {
                    if (this.ElementKind == NodeElementKind.ObjectAlias) {
                        var nameAlias = this.Name;
                        var nameSchemaObjectName = this.Name;
                        if (element is NodeNamed named) {
                            nameSchemaObjectName = named.Name;
                        }
                        evaluationState.ResolveSchemaObjectName(nameSchemaObjectName);
                    }
                } else if (this.Scope == NodeScopeKind.LocalScope) {
                } else if (this.Scope == NodeScopeKind.GlobalScope) {
                } else if (this.Scope == NodeScopeKind.Column) {
                    if (element is NodeScopeElement nodeScopeElement) {
                        var name1 = this.Name;
                        var name2 = nodeScopeElement.Name;
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
            => $"{this.GetType().Name}:{Index} {Level} {Comment} Scope:{Scope} Kind:{ElementKind}-{this.ToStringNameOnly()}";

        internal void AddToScope() {
            switch (this.Scope) {
                case NodeScopeKind.Unknown:
                    break;
                case NodeScopeKind.GlobalScope:
                    if (this.Scopes is null || this.Element is null) { return; }
                    this.Scopes.GlobalScope.Add(this, this.Element);
                    break;
                case NodeScopeKind.LocalScope:
                    if (this.Scopes is null || this.Element is null) { return; }
                    this.Scopes.LocalScope.Add(this, this.Element);
                    break;
                case NodeScopeKind.AliasScope:
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
