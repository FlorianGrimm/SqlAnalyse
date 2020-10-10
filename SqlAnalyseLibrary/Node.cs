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

        public Node() {
            this._Index = 1 + System.Threading.Interlocked.Increment(ref __Index);
            this.Comment = string.Empty;
        }
        public virtual void AfterInitialization() {
        }

        public override string ToString()
            => $"{this.GetType().Name}:{Index} {Level} {Comment}";

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

        public virtual void Resolve(EvaluationState evaluationState) {
            foreach (var c in this.GetChildren().ToList()) {
                c.Resolve(evaluationState);
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