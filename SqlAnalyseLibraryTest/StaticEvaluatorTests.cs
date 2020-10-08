using SqlAnalyseLibrary;

using System.Linq;

using Xunit;

namespace SqlAnalyseLibraryTest {
    public class StaticEvaluatorTests {
        [Fact]
        public void StaticEvaluator201Select() {
            var sqlCode = "SELECT a,b FROM t;";
            var (actNode, errors) = StaticEvaluator.ParseSql(sqlCode);
            Assert.False(errors is object && errors.Any());
            var staticEvaluator = new StaticEvaluator();
            actNode.Accept(staticEvaluator);

            //var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            //Assert.NotNull(actNode);
            //var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            //Assert.NotNull(actEval);
            //Utils.NodeOuput(sqlCode, actNode, actEval);
        }

#if false
        [Fact]
        public void StaticEvaluator101CreateTable() {
            var sqlCode = @"
USE SqlAnalyseLibrary;
GO
IF (OBJECT_ID('[dbo].[t]') IS NULL) BEGIN
    CREATE TABLE [dbo].[t](
        [a] [nchar](10) NULL,
        [b] [int] NOT NULL
    ) ON [PRIMARY]
END;
";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator102InsertData() {
            var sqlCode = @"
IF (0=(SELECT COUNT(1) FROM dbo.t)) BEGIN
    INSERT INTO dbo.t (a,b) values ('a',1), ('aa',2);
END;
";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator201Select() {
            var sqlCode = "SELECT a,b FROM t;";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator202SelectAs() {
            var sqlCode = "SELECT a as c,b as d FROM t;";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator203SelectAs() {
            var sqlCode = "SELECT c=a,d=b FROM t;";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator204SelectTwo() {
            var sqlCode = "SELECT a,b FROM t;SELECT a,b FROM t;";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator205SelectGoSelect() {
            var sqlCode = @"
SELECT a,b FROM t;
GO
SELECT a,b FROM t;
GO";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator206SelectJoin() {
            var sqlCode = @"
SELECT a=c.a, b1=c.b, b2=d.b FROM dbo.t c INNER JOIN dbo.t d ON c.a = d.a;
GO";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator301CreateProcedure() {
            var sqlCode = @"
CREATE PROCEDURE dbo.p1 AS BEGIN SET NOCOUNT ON; END;
";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator302AlterProcedure() {
            var sqlCode = @"
CREATE PROCEDURE dbo.p1 AS BEGIN SET NOCOUNT ON; END;
GO
ALTER PROCEDURE dbo.p1 
AS BEGIN 
    SET NOCOUNT ON; 
    SELECT a,b FROM t;
END;
GO";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }
        [Fact]
        public void StaticEvaluator303ExeuteProcedure() {
            var sqlCode = @"
IF (OBJECT_ID('[dbo].[t]') IS NULL) BEGIN
    CREATE TABLE [dbo].[t](
        [a] [nchar](10) NULL,
        [b] [int] NOT NULL
    ) ON [PRIMARY]
END;
GO
CREATE PROCEDURE dbo.p1 
AS BEGIN 
    SET NOCOUNT ON; 
    SELECT a,b FROM t;
END;
GO
EXECUTE dbo.p1";
            Assert.NotNull(StaticEvaluator.ParseSql(sqlCode));
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }

        [Fact]
        public void StaticEvaluator900All() {
            var sqlCode = @"
SELECT 'LATER'
";
            var actNode = StaticEvaluator.ParseTransformSql(sqlCode);
            Assert.NotNull(actNode);
            var actEval = StaticEvaluator.Evaluate(actNode, new EvaluationState(Utils.StateA(), Utils.SqlEnvironmentA()));
            Assert.NotNull(actEval);
            Utils.NodeOuput(sqlCode, actNode, actEval);
        }
#endif
    }

}
