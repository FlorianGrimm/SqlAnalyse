using System;
using System.Collections.Generic;
using System.Linq;

namespace SqlAnalyseLibrary {
    public class Node {
        private static int __Index;
        private int _Index;
        public int Index => _Index;
        public int Level { get; set; }
        public string Comment { get; set; }

        protected Node? _ResolvedType;
        public virtual Node? GetResolvedType() => this._ResolvedType;
        public virtual void SetResolvedType(Node? value) {
            this._ResolvedType = value;
        }

        protected Node? _ResultNode;
        public virtual Node? GetResultNode() => this._ResultNode;
        public virtual void SetResultNode(Node? value) {
            this._ResultNode = value;
        }

        public void SetResultNodeAndResolvedType(Node? value) {
            if (value is object) {
                this._ResultNode = value;
                if (this.GetResolvedType() is null) {
                    var resolvedType = value.GetResolvedType();
                    if (resolvedType is object) {
                        this.SetResolvedType(resolvedType);
                    }
                }
            }
        }

        public virtual bool IsResultNodeSet() => (this.GetResultNode() is object);

        protected Node() {
            this._Index = 1 + System.Threading.Interlocked.Increment(ref __Index);
            this.Comment = string.Empty;
        }
        public virtual void AfterInitialization() {
        }

        public override string ToString()
            => $"{this.GetType().Name}:{this.Index} {this.Level} {this.Comment}";

        public virtual IEnumerable<Node> GetChildren() {
            return Array.Empty<Node>();
        }

        public ForewardLink? NextForewardLink { get; set; }
        public BackwardLink? NextBackwardLink { get; set; }

        public IEnumerable<ForewardLink> GetForewardLinks() {
            var current = this.NextForewardLink;
            while (current is object) {
                yield return current;
                current = current.NextForewardLink;
            }
        }

        public virtual void ResolveTypesStep1(IResolver resolver) {
            if (this.IsResultNodeSet()) { return; }
            // System.Console.Out.WriteLine($"ResolveTypesStep1: {this.ToString()}");
            foreach (var c in this.GetChildren().ToList()) {
                c.ResolveTypesStep1(resolver);
            }
        }

        public IEnumerable<BackwardLink> GetBackwardLinks() {
            var current = this.NextBackwardLink;
            while (current is object) {
                yield return current;
                current = current.NextBackwardLink;
            }
        }

        public void AddForewardLink(Node nextNode, Node? condition, bool conditionResult) {
            new NodeLink(this, nextNode, condition, conditionResult).Connect();
        }

        public void SetForewardLink(Node nextNode, Node? condition, bool conditionResult) {
            var current = this.NextForewardLink;
            ForewardLink? previous = null;
            while (current is object) {
                if (ReferenceEquals(nextNode, current.NextNode)) {
                    current.Condition = condition;
                    current.ConditionResult = conditionResult;
                    return;
                }
                previous = current;
                current = current.NextForewardLink;
            }
            new NodeLink(this, nextNode, condition, conditionResult).Connect();
        }
    }
}