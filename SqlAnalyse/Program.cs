using SqlAnalyseLibrary;

using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SqlAnalyse {
    class Program {
        static int Main(string[] args)
        {
            var sqlCode = @"
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
            var (ast, errors) = StaticEvaluator.ParseSql(sqlCode);
            if (errors is object && errors.Any()) {
                System.Console.Error.WriteLine("parse errors");
                System.Console.Error.WriteLine(string.Join("\r\n", errors.Select(e => $"{e.Line}:{e.Column} {e.Message}")));
                return 1;
            }
            if (ast is null) {
                System.Console.Error.WriteLine("Internal error");
                return 1;
            }
            var staticEvaluator = new StaticEvaluator();
            ast.Accept(staticEvaluator);
            var sn = staticEvaluator.Current;
            PrintChildren(sn.Result, "");

            staticEvaluator.Resolve(new SqlEnvironment());
            //if (sn.Result is NodeSequence nodeSequence)
            //{
            //    PrintFWL(nodeSequence.Start, "", 0);
            //}
            //PrintBWL(sn.Result, "");
            
            return 0;
        }

        private static void PrintChildren(Node node, string indent)
        {
            System.Console.Out.WriteLine(indent + node.ToString());
            if (node is INodeHasScope nodeHasScope)
            {
                if (nodeHasScope.Scopes is object)
                {
                    if (ReferenceEquals(nodeHasScope.Scopes.Node, node))
                    {
                        System.Console.Out.WriteLine(indent + "  Scope owner " + nodeHasScope.Scopes.ToDebugString());
                    }
                    else
                    {
                        System.Console.Out.WriteLine(indent + "  Scope usage " + nodeHasScope.Scopes.ToString());
                    }
                }
            }
            foreach (var c in node.GetChildren())
            {
                PrintChildren(c, indent + ". ");
            }
        }

        static void PrintFWL(Node node, string indent, int stopAtLevel)
        {
            System.Console.Out.WriteLine(indent + node.ToString());
            if (node.GetForewardLinks().Skip(1).Any())
            {
                foreach (var fwl in node.GetForewardLinks())
                {
                    System.Console.Out.WriteLine(indent + "- " + fwl.NextNode.ToString());
                }
            }

            foreach (var fwl in node.GetForewardLinks())
            {
                if (fwl.NextNode.Level < stopAtLevel)
                {
                    System.Console.Out.WriteLine(indent + ". # " + fwl.NextNode.ToString());
                }
                else
                {
                    PrintFWL(fwl.NextNode, indent + ". ", node.Level);
                }
            }
        }
        static void PrintBWL(Node node, string indent)
        {
            System.Console.Out.WriteLine(indent + node.ToString());
            foreach (var bwl in node.GetBackwardLinks())
            {
                PrintBWL(bwl.PreviousNode, indent + ". ");
            }
        }
    }
}
