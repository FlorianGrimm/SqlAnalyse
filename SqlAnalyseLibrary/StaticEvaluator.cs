using Microsoft.SqlServer.TransactSql.ScriptDom;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SqlAnalyseLibrary {
    public sealed class StaticEvaluator {
        public EvaluationState EvaluationState { get; }

        public StaticEvaluator(SqlEnvironment sqlEnvironment)
            : this(new EvaluationState(sqlEnvironment)) {
        }

        public StaticEvaluator(EvaluationState evaluationState) {
            this.EvaluationState = evaluationState ?? throw new ArgumentNullException(nameof(evaluationState));
        }

        public ParseResult ParseSql(string sqlCode) {
            var parser = new TSql150Parser(false);
            var tokens = parser.GetTokenStream(new StringReader(sqlCode), out var errors);
            if (!ParseResult.IsSuccessfull(errors)) { return new ParseResult(this, null, errors); }
            var fragment = parser.Parse(tokens, out errors);
            return new ParseResult(this, fragment, errors);
        }

        public sealed class ParseResult {
            private readonly StaticEvaluator _StaticEvaluator;
            public readonly TSqlFragment? RootSqlFragment;
            public readonly IList<ParseError>? Errors;

            public ParseResult(StaticEvaluator staticEvaluator, TSqlFragment? rootSqlFragment, IList<ParseError>? errors) {
                this._StaticEvaluator = staticEvaluator;
                this.RootSqlFragment = rootSqlFragment;
                this.Errors = errors;
            }

            public bool IsSuccessfull()
                => (this.RootSqlFragment is object)
                && IsSuccessfull(this.Errors);

            public string GetErrorsAsString() {
                if ((this.Errors is null) || (!this.Errors.Any())) {
                    return string.Empty;
                } else {
                    return string.Join(
                        System.Environment.NewLine,
                        this.Errors.Select(e => $"{e.Line}:{e.Column} {e.Message}"));
                }
            }

            internal static bool IsSuccessfull(IList<ParseError>? errors)
                => (errors is null)
                    ? true
                    : (!errors.Any());

            public StaticEvaluatorVisitor.VisitorResult Visit() {
                var root = this.RootSqlFragment;
                if (!this.IsSuccessfull()) { throw new InvalidOperationException("Parsing faults."); }
                if (root is null) { throw new ArgumentNullException(nameof(RootSqlFragment)); }

                var visitor = new StaticEvaluatorVisitor(this._StaticEvaluator);
                return visitor.VistRoot(root);
            }

            //public object Resolve() {
            //    var root = this.RootSqlFragment;
            //    if (!this.IsSuccessfull()) { throw new InvalidOperationException("Parsing faults."); }
            //    if (root is null) { throw new ArgumentNullException(nameof(RootSqlFragment)); }

            //    var visitor = new StaticEvaluatorVisitor(this._StaticEvaluator);
            //    var visitorResult = visitor.VistRoot(root);
            //    if (!visitorResult.IsSuccessfull()) {
            //    } else {
            //    }
            //    return "";
            //}
        }

        public void Resolve(TSqlFragment? rootSqlFragment) {
        }
    }
}
