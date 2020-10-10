using SqlAnalyseLibrary;

using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SqlAnalyse {
    class Program {
        static int Main(string[] args) {
            var sqlCode = @"
WITH
    E1(A)        AS (SELECT 1 UNION ALL SELECT 1 UNION ALL SELECT 1 UNION ALL SELECT 1 UNION ALL SELECT 1 UNION ALL SELECT 1 UNION ALL SELECT 1 UNION ALL SELECT 1 UNION ALL SELECT 1 UNION ALL SELECT 1),
    E2(B)        AS (SELECT 1 FROM E1 a, E1 b),
    cteTally(C)  AS (SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) FROM E2)
SELECT C
    FROM cteTally s;
GO
SELECT c.a, c.b FROM (SELECT [a],[b] FROM [SqlAnalyseLibrary].[dbo].[t]) as c
GO
SELECT a=1, b=2;
GO
IF (1=1) BEGIN
    SELECT * FROM t;
END ELSE BEGIN
    SELECT a,b FROM t;
END;
GO
SELECT a,b FROM t;
GO
SELECT a as aAS, bEQ = b FROM t;
";

            sqlCode = @"
SELECT a,b FROM t;
GO
";
            var staticEvaluator = new StaticEvaluator(
                new SqlEnvironment("localhost", "SqlAnalyseLibrary", "dbo"));
            var parseResult = staticEvaluator.ParseSql(sqlCode);
            if (!parseResult.IsSuccessfull()) {
                System.Console.Error.WriteLine("parse errors");
                System.Console.Error.WriteLine(parseResult.GetErrorsAsString());
                return 1;
            } else {
                var visitorResult = parseResult.Visit();
                if (!visitorResult.IsSuccessfull()) {
                    System.Console.Error.WriteLine("visit errors");
                    return 2;
                } else {
                    PrintChildren(visitorResult.NodeRoot!, "");
                    //visitorResult.Resolve();
                }
            }
            /*
             SELECT [a],[b]
              FROM [SqlAnalyseLibrary].[dbo].[t]
            //PrintChildren(sn.Result, "");
             */
            //if (sn.Result is NodeSequence nodeSequence)
            //{
            //    PrintFWL(nodeSequence.Start, "", 0);
            //}
            //PrintBWL(sn.Result, "");

            return 0;
        }

        private static void PrintChildren(Node node, string indent) {
            System.Console.Out.WriteLine(indent + node.ToString());
            if (node is INodeHasScope nodeHasScope) {
                if (nodeHasScope.Scopes is object) {
                    if (ReferenceEquals(nodeHasScope.Scopes.Node, node)) {
                        System.Console.Out.WriteLine(indent + "  Scope owner " + nodeHasScope.Scopes.ToDebugString());
                    } else {
                        System.Console.Out.WriteLine(indent + "  Scope usage " + nodeHasScope.Scopes.ToString());
                    }
                }
            }
            foreach (var c in node.GetChildren()) {
                PrintChildren(c, indent + ". ");
            }
        }

        static void PrintFWL(Node node, string indent, int stopAtLevel) {
            System.Console.Out.WriteLine(indent + node.ToString());
            if (node.GetForewardLinks().Skip(1).Any()) {
                foreach (var fwl in node.GetForewardLinks()) {
                    System.Console.Out.WriteLine(indent + "- " + fwl.NextNode.ToString());
                }
            }

            foreach (var fwl in node.GetForewardLinks()) {
                if (fwl.NextNode.Level < stopAtLevel) {
                    System.Console.Out.WriteLine(indent + ". # " + fwl.NextNode.ToString());
                } else {
                    PrintFWL(fwl.NextNode, indent + ". ", node.Level);
                }
            }
        }
        static void PrintBWL(Node node, string indent) {
            System.Console.Out.WriteLine(indent + node.ToString());
            foreach (var bwl in node.GetBackwardLinks()) {
                PrintBWL(bwl.PreviousNode, indent + ". ");
            }
        }
    }
}
