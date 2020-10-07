using SqlAnalyseLibrary;

using System;

namespace SqlAnalyse {
    class Program {
        static void Main(string[] args) {
            var sqlCode = @"
SELECT a,b FROM t;
GO
SELECT a as aAS, bEQ = b FROM t;
";
            var ast = StaticEvaluator.ParseSql(sqlCode);
            var staticEvaluator = new StaticEvaluator();
            ast.Accept(staticEvaluator);
        }
    }
}
