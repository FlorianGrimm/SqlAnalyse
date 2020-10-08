using System;
using System.Collections.Generic;

namespace SqlAnalyseLibrary {
    public interface INodeHasScope {
        NodeScopeKind Scope { get; set; }
        Scopes Scopes { get; set; }

    }
    public class NodeScopeElement : NodeNamed, INodeHasScope {
        public Node Element;
        public NodeScopeKind Scope { get; set; }
        public Scopes Scopes { get; set; }

        public NodeScopeElement()
        {
        }


        public override IEnumerable<Node> GetChildren()
        {
            if (this.Element is object)
            {
                yield return this.Element;
            }
        }
        public override string ToString()
            => $"{this.GetType().Name}:{Index} {Level} {Comment} Scope:{Scope}";

        internal void AddToScope()
        {
            switch (this.Scope)
            {
                case NodeScopeKind.Unknown:
                    break;
                case NodeScopeKind.Global:
                    this.Scopes.GlobalScope.Add(this, this.Element);
                    break;
                case NodeScopeKind.Local:
                    this.Scopes.LocalScope.Add(this, this.Element);
                    break;
                case NodeScopeKind.Alias:
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
