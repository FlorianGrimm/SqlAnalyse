using Sqlserver.Showplan;

using System;
using System.Collections.Generic;

namespace TestShowPlan {
    public class ExtractionResult {
        public List<SelectResult> SelectResults;
        public readonly ExtractionResult Parent;
        public string Indent;
        public ExtractionResult(ExtractionResult parent) {
            this.Parent = parent;
            if (parent is null) {
                this.Indent = "";
                this.SelectResults = new List<SelectResult>();
            } else {
                if (parent.WithinSelect) {
                    this.WithinSelect = true;
                    this.Indent = parent.Indent + "S ";
                } else {
                    this.Indent = parent.Indent + ". ";
                }
                this.SelectResults = parent.SelectResults;
            }
        }

        public bool WithinSelect;

        public ExtractionResult Pop() {
            return this.Parent;
        }
    }
    public class SelectResult {
        public readonly List<ColumnReferenceType> Columns;
        public SelectResult() {
            this.Columns = new List<ColumnReferenceType>();
        }
    }
    
    public class ShowPlanExtraction : Visitor<ExtractionResult> {
        public ShowPlanExtraction() {
        }
        public ExtractionResult Extract(ShowPlanXML showPlan) {
            var state = new ExtractionResult(null);
            state = showPlan.Accept<ExtractionResult>(this, state);
            return state;
        }
        public override ExtractionResult Enter(ShowPlanBase node, ExtractionResult state) {
            state = new ExtractionResult(state);
            System.Console.WriteLine(state.Indent + node.GetType().Name);
            return state;
        }
        public override ExtractionResult Exit(ShowPlanBase node, ExtractionResult state) {
            return state.Pop();
        }
        public override ExtractionResult Visit(StmtSimpleType node, ExtractionResult state) {
            if (string.Equals(node.StatementType, "SELECT", StringComparison.Ordinal)) {
                state.WithinSelect = true;
                state.Indent = state.Parent.Indent + "S ";
            }
            return base.Visit(node, state);
        }
        public override ExtractionResult VisitExplicit(StmtSimpleType node, ExtractionResult state) {
            return base.VisitExplicit(node, state);
        }
        public override ExtractionResult VisitExplicit(RelOpType node, ExtractionResult state) {
            if (state.WithinSelect) {
                if (node.OutputList is object) {
                    var result = new SelectResult();
                    foreach (ColumnReferenceType item in node.OutputList) {
                        if (item is object) {
                            //state = this.Visit(item, state);
                            //item.Server
                            result.Columns.Add(item);
                        }
                    }
                    state.SelectResults.Add(result);
                }
                return state; //base.VisitExplicit(node, state);
            } else {
                return state; //base.VisitExplicit(node, state);
            }
        }



        //    public void Extract(ShowPlanXML showPlan) {
        //        CallForeach(showPlan.BatchSequence, (b)=>Extract(b));
        //    }

        //    public void Extract(ShowPlanXMLBatchSequenceBatch batchSequence) {
        //        CallForeach(batchSequence.Statements, stmt=>Extract(stmt));
        //    }

        //    public void Extract(StmtBlockType stmt) {
        //        CallForeach(stmt.StmtCond, stmtCond => Extract(stmtCond));
        //    }

        //    public void Extract(StmtCondType stmtCond) {
        //        //stmtCond.Condition
        //        //stmtCond.Then
        //        //stmtCond.Else
        //    }

        //    private void CallForeach<T>(System.Collections.ObjectModel.Collection<T> collection, Action<T> action) {
        //        if (collection is object) {
        //            foreach (T item in collection) {
        //                action(item);
        //            }
        //        }
        //    }
    }
}