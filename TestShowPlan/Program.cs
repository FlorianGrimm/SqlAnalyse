using Sqlserver.Showplan;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections.ObjectModel;

namespace TestShowPlan {
    class Program {
        static void Main(string[] args) {
#if false
            MainGen(args);
#else
            MainExtract(args);
#endif
        }
        static void MainGen(string[] args) {
            var types = new Type[] {
                typeof( AdaptiveJoinType ),
                typeof( AffectingConvertWarningType ),
                typeof( AggregateType ),
                typeof( ArithmeticType ),
                typeof( AssignType ),
                typeof( BaseStmtInfoType ),
                typeof( BatchHashTableBuildType ),
                typeof( BitmapType ),
                typeof( CLRFunctionType ),
                typeof( CollapseType ),
                typeof( ColumnGroupType ),
                typeof( ColumnReferenceListType ),
                typeof( ColumnReferenceType ),
                typeof( ColumnType ),
                typeof( CompareType ),
                typeof( ComputeScalarType ),
                typeof( ConcatType ),
                typeof( ConditionalType ),
                typeof( ConstantScanType ),
                typeof( ConstantScanTypeValues ),
                typeof( ConstType ),
                typeof( ConvertType ),
                typeof( CreateIndexType ),
                typeof( CursorPlanType ),
                typeof( CursorPlanTypeOperation ),
                typeof( DefinedValuesListType ),
                typeof( DefinedValuesListTypeDefinedValue ),
                typeof( DefinedValuesListTypeDefinedValueValueVector ),
                typeof( FilterType ),
                typeof( ForeignKeyReferenceCheckType ),
                typeof( ForeignKeyReferencesCheckType ),
                typeof( FunctionType ),
                typeof( GenericType ),
                typeof( GuessedSelectivityType ),
                typeof( HashSpillDetailsType ),
                typeof( HashType ),
                typeof( IdentType ),
                typeof( IndexedViewInfoType ),
                typeof( IndexScanType ),
                typeof( InternalInfoType ),
                typeof( IntrinsicType ),
                typeof( LogicalType ),
                typeof( MemoryFractionsType ),
                typeof( MemoryGrantType ),
                typeof( MemoryGrantWarningInfo ),
                typeof( MergeType ),
                typeof( MissingIndexesType ),
                typeof( MissingIndexGroupType ),
                typeof( MissingIndexType ),
                typeof( MultAssignType ),
                typeof( NestedLoopsType ),
                typeof( ObjectType ),
                typeof( OptimizerHardwareDependentPropertiesType ),
                typeof( OptimizerStatsUsageType ),
                typeof( OrderByType ),
                typeof( OrderByTypeOrderByColumn ),
                typeof( ParallelismType ),
                typeof( ParallelismTypeActivation ),
                typeof( ParallelismTypeBrickRouting ),
                typeof( ParameterizationType ),
                typeof( PutType ),
                typeof( QueryExecTimeType ),
                typeof( QueryPlanType ),
                typeof( ReceivePlanType ),
                typeof( ReceivePlanTypeOperation ),
                typeof( RelOpBaseType ),
                typeof( RelOpType ),
                typeof( RemoteFetchType ),
                typeof( RemoteModifyType ),
                typeof( RemoteQueryType ),
                typeof( RemoteRangeType ),
                typeof( RemoteType ),
                typeof( RollupInfoType ),
                typeof( RollupLevelType ),
                typeof( RowsetType ),
                typeof( RunTimeInformationType ),
                typeof( RunTimeInformationTypeRunTimeCountersPerThread ),
                typeof( RunTimePartitionSummaryType ),
                typeof( RunTimePartitionSummaryTypePartitionsAccessed ),
                typeof( RunTimePartitionSummaryTypePartitionsAccessedPartitionRange ),
                typeof( ScalarExpressionListType ),
                typeof( ScalarExpressionType ),
                typeof( ScalarInsertType ),
                typeof( ScalarSequenceType ),
                typeof( ScalarType ),
                typeof( ScanRangeType ),
                typeof( SeekPredicateNewType ),
                typeof( SeekPredicatePartType ),
                typeof( SeekPredicatesType ),
                typeof( SeekPredicateType ),
                typeof( SegmentType ),
                typeof( SequenceType ),
                typeof( SetOptionsType ),
                typeof( SetPredicateElementType ),
                typeof( ShowPlanXML ),
                typeof( ShowPlanXMLBatchSequence ),
                typeof( ShowPlanXMLBatchSequenceBatch ),
                typeof( SimpleIteratorOneChildType ),
                typeof( SimpleUpdateType ),
                typeof( SingleColumnReferenceType ),
                typeof( SortSpillDetailsType ),
                typeof( SortType ),
                typeof( SpillToTempDbType ),
                typeof( SplitType ),
                typeof( SpoolType ),
                typeof( StarJoinInfoType ),
                typeof( StatsInfoType ),
                typeof( StmtBlockType ),
                typeof( StmtCondType ),
                typeof( StmtCondTypeCondition ),
                typeof( StmtCondTypeElse ),
                typeof( StmtCondTypeThen ),
                typeof( StmtCursorType ),
                typeof( StmtReceiveType ),
                typeof( StmtSimpleType ),
                typeof( StmtUseDbType ),
                typeof( StreamAggregateType ),
                typeof( SubqueryType ),
                typeof( SwitchType ),
                typeof( TableScanType ),
                typeof( TableValuedFunctionType ),
                typeof( ThreadReservationType ),
                typeof( ThreadStatType ),
                typeof( TopSortType ),
                typeof( TopType ),
                typeof( TraceFlagListType ),
                typeof( TraceFlagType ),
                typeof( UDAggregateType ),
                typeof( UDFType ),
                typeof( UDTMethodType ),
                typeof( UDXType ),
                typeof( UnmatchedIndexesType ),
                typeof( UpdateType ),
                typeof( WaitStatListType ),
                typeof( WaitStatType ),
                typeof( WaitWarningType ),
                typeof( WarningsType ),
                typeof( WindowAggregateType ),
                typeof( WindowType )
            };
            var sb = new StringBuilder();
            sb.Append(@"namespace Sqlserver.Showplan {
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
").AppendLine();
            foreach (var t in types) {
                var n = t.Name;
                var b = t.BaseType.Name;
                sb.AppendLine($"    public partial class {n} : {b} {{");
                sb.AppendLine("        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);");
                sb.AppendLine("        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {");
                sb.AppendLine("            state = visitor.Enter(this, state);");
                sb.AppendLine("            state = visitor.VisitExplicit(this, state);");
                sb.AppendLine("            return visitor.Exit(this, state);");
                sb.AppendLine("        }");
                sb.AppendLine($"        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {{");
                foreach (var prop in t.GetProperties()) {
                    if (typeof(System.Collections.ICollection).IsAssignableFrom(prop.PropertyType) && prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Collection<>) && typeof(ShowPlanBase).IsAssignableFrom(prop.PropertyType.GenericTypeArguments[0])) {
                        var itemType = prop.PropertyType.GenericTypeArguments[0];
                        sb.AppendLine($"            // Collection<> {prop.DeclaringType.Name} at '{prop.Name}' : {itemType.Name}");
                        sb.AppendLine($"            if (this.{prop.Name} is object) {{");
                        sb.AppendLine($"                foreach ({itemType.Name} item in this.{prop.Name}) {{");
                        sb.AppendLine($"                    if (item is object) {{");
                        sb.AppendLine($"                        state = visitor.Visit(item, state);");
                        sb.AppendLine($"                    }}");
                        sb.AppendLine($"                }}");
                        sb.AppendLine($"            }}");
                    } else if (prop.PropertyType == typeof(string)) {
                        sb.AppendLine($"            // String {prop.DeclaringType.Name} at '{prop.Name}' : {prop.PropertyType.Name}");
                    } else if (prop.PropertyType.IsValueType) {
                        sb.AppendLine($"            // ValueType {prop.DeclaringType.Name} at '{prop.Name}' : {prop.PropertyType.Name}");
                    } else if (typeof(ShowPlanBase).IsAssignableFrom(prop.PropertyType)) {
                        sb.AppendLine($"            // ShowPlanBase {prop.DeclaringType.Name} at '{prop.Name}' : {prop.PropertyType.Name}");
                        sb.AppendLine($"            if ({prop.Name} is object) {{ state = visitor.Visit(this.{prop.Name}, state); }}");
                    } else {
                        sb.AppendLine($"            // ??? {prop.DeclaringType.Name} at '{prop.Name}' : {prop.PropertyType.Name}");
                    }
                }
                sb.AppendLine("            return state;");
                sb.AppendLine($"        }}");
                sb.AppendLine($"    }}");
            }
            sb.AppendLine("}");
            System.IO.File.WriteAllText(@"C:\github.com\FlorianGrimm\SqlAnalyse\TestShowPlan\Model\Sqlserver.Showplan.Visitor.txt", sb.ToString());
        }
        static void MainExtract(string[] args) {
            /*
              c:\prgs\XmlSchemaClassGenerator\XmlSchemaClassGenerator.Console.exe --output=C:\github.com\FlorianGrimm\SqlAnalyse\TestShowPlan\Model\ C:\github.com\FlorianGrimm\SqlAnalyse\TestShowPlan\Model\showplanxml.xsd
             */
            var serializer = new XmlSerializer(typeof(ShowPlanXML));
            var csb = new SqlConnectionStringBuilder();
            csb.DataSource = ".";
            csb.InitialCatalog = "SqlAnalyseLibrary";
            csb.IntegratedSecurity = true;
            var sqlInfoMessageEventReceiver = new SqlInfoMessageEventReceiver();
            string showPlanXml;
            string sqlCode = "SELECT a=a,b=b FROM dbo.t;";
            /*
            string sqlCode = System.IO.File.ReadAllText(statementPath);
            string statementPath = @"C:\github.com\FlorianGrimm\SqlAnalyse\TestShowPlan\ShowPlanXml\4-Statement.sql";
            string storePath = @"C:\github.com\FlorianGrimm\SqlAnalyse\TestShowPlan\ShowPlanXml\4-ShowPlanXml.xml";
            */
            using (var connection = new SqlConnection(csb.ConnectionString)) {
                connection.Open();
                sqlInfoMessageEventReceiver.WireConnection(connection);
                var resultOn = SqlExecuteReader(connection, "SET SHOWPLAN_XML ON;", sqlInfoMessageEventReceiver);
                var resultData = SqlExecuteReader(connection, sqlCode, sqlInfoMessageEventReceiver);
                var resultOff = SqlExecuteReader(connection, "SET SHOWPLAN_XML OFF;", sqlInfoMessageEventReceiver);
                connection.Close();
                showPlanXml = (string)resultData[0].Rows[0][0];
            }
            /*
            System.IO.File.WriteAllText(storePath, showPlanXml);
            */
            var showPlan = (ShowPlanXML)serializer.Deserialize(new System.IO.StringReader(showPlanXml));
            var s = new ShowPlanExtraction();
            var selectResults = s.Extract(showPlan).SelectResults;
            System.Console.WriteLine("Results:");
            foreach (var selectResult in selectResults) {
                System.Console.WriteLine("Result");
                System.Console.WriteLine("------");
                foreach (var column in selectResult.Columns) {
                    System.Console.WriteLine($"{column.Server}.{column.Database}.{column.Schema}.{column.Table}.{column.Column}");
                }
            }




            //if (showPlan.BatchSequence is object) {
            //    //" StatementType="SELECT"
            //    foreach (ShowPlanXMLBatchSequenceBatch batchSequenceBatch in showPlan.BatchSequence) {
            //        if (batchSequenceBatch.Statements is object) {
            //            foreach (StmtBlockType stmt in batchSequenceBatch.Statements) {
            //                if (stmt.StmtReceive is object) {
            //                    foreach (var stmtReceive in stmt.StmtReceive) {
            //                        System.Console.Out.WriteLine(stmtReceive.GetType().Name);
            //                    }
            //                }
            //                if (stmt.StmtSimple is object) {
            //                    foreach (var stmtSimple in stmt.StmtSimple) {
            //                        System.Console.Out.WriteLine(stmtSimple.GetType().Name);
            //                        var outputList = stmtSimple.QueryPlan?.RelOp?.OutputList;
            //                        foreach (var columnReference in outputList) {
            //                            System.Console.Out.WriteLine($"{columnReference.Alias} {columnReference.Column} {columnReference.Table} {columnReference.Schema} {columnReference.Database} {columnReference.Server}");
            //                        }
            //                    }
            //                }
            //            }
            //        }6
            //    }
            //}
            System.Console.Out.WriteLine("Done");
            /*
             new System.Collections.Generic.ICollectionDebugView<Sqlserver.Showplan.ColumnReferenceType>((new System.Collections.Generic.ICollectionDebugView<Sqlserver.Showplan.StmtSimpleType>((new System.Collections.Generic.ICollectionDebugView<Sqlserver.Showplan.StmtBlockType>((new System.Collections.Generic.ICollectionDebugView<Sqlserver.Showplan.ShowPlanXMLBatchSequenceBatch>(showPlan.BatchSequence).Items[0]).Statements).Items[0]).StmtSimple).Items[0]).QueryPlan.RelOp.OutputList).Items[0]
             */
        }


        private static List<SqlResult> SqlExecuteReader(SqlConnection connection, string sqlCode, SqlInfoMessageEventReceiver sqlInfoMessageEventReceiver) {
            using (var cmd = connection.CreateCommand()) {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sqlCode;
                return SqlExecuteReader(cmd, sqlInfoMessageEventReceiver);
            }
        }

        private static List<SqlResult> SqlExecuteReader(SqlCommand cmd, SqlInfoMessageEventReceiver sqlInfoMessageEventReceiver) {
            var result = new List<SqlResult>();
            sqlInfoMessageEventReceiver?.ClearMessages();
            using var reader = cmd.ExecuteReader();
            do {
                var sqlResult = new SqlResult();
                var columnCount = 0;
                System.Data.Common.DbColumn[] schema = null;
                while (reader.Read()) {
                    if (schema is null) {
                        schema = reader.GetColumnSchema().ToArray();
                        sqlResult.Schema = schema;
                        columnCount = schema.Length;
                    }
                    var values = new object[columnCount];
                    reader.GetValues(values);
                    sqlResult.Rows.Add(values);
                }
                sqlResult.Messages = sqlInfoMessageEventReceiver?.GetMessages();
                result.Add(sqlResult);
            } while (reader.NextResult());
            return result;
        }
    }
    public class SqlResult {
        public System.Data.Common.DbColumn[] Schema;
        public readonly List<object[]> Rows;
        public List<SqlInfoMessageEventArgs> Messages;

        public SqlResult() {
            this.Rows = new List<object[]>();
        }
    }
    public class SqlInfoMessageEventReceiver {
        public SqlInfoMessageEventReceiver() {
            this._Messages = new List<SqlInfoMessageEventArgs>();
        }
        private List<SqlInfoMessageEventArgs> _Messages;
        public List<SqlInfoMessageEventArgs> Messages => this._Messages;

        public List<SqlInfoMessageEventArgs> GetMessages() {
            return System.Threading.Interlocked.Exchange(ref this._Messages, new List<SqlInfoMessageEventArgs>());
        }
        public void WireConnection(SqlConnection connection) {
            connection.InfoMessage += this.SqlInfoMessageEventHandler;
            connection.FireInfoMessageEventOnUserErrors = true;
        }

        private void SqlInfoMessageEventHandler(object sender, SqlInfoMessageEventArgs e) {
            this._Messages.Add(e);
        }

        public void ClearMessages() {
            if (this.Messages.Count > 0) {
                System.Threading.Interlocked.Exchange(ref this._Messages, new List<SqlInfoMessageEventArgs>()).Clear();
            }
        }
    }
}
