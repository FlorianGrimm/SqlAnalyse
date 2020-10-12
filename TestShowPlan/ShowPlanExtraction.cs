using Sqlserver.Showplan;

using System;

namespace TestShowPlan {
    internal class ShowPlanExtraction {
        public ShowPlanExtraction() {
        }

        public void Extract(ShowPlanXML showPlan) {
            CallForeach(showPlan.BatchSequence, (b)=>Extract(b));
        }

        public void Extract(ShowPlanXMLBatchSequenceBatch batchSequence) {
            CallForeach(batchSequence.Statements, stmt=>Extract(stmt));
        }

        public void Extract(StmtBlockType stmt) {
            CallForeach(stmt.StmtCond, stmtCond => Extract(stmtCond));
        }

        public void Extract(StmtCondType stmtCond) {
            //stmtCond.Condition
            //stmtCond.Then
            //stmtCond.Else
        }

        private void CallForeach<T>(System.Collections.ObjectModel.Collection<T> collection, Action<T> action) {
            if (collection is object) {
                foreach (T item in collection) {
                    action(item);
                }
            }
        }
    }
}