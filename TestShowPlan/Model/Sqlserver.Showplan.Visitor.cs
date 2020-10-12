namespace Sqlserver.Showplan {
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;

    public partial class AdaptiveJoinType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // AdaptiveJoinType HashKeysBuild System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // AdaptiveJoinType HashKeysBuildSpecified System.Boolean
            // AdaptiveJoinType HashKeysProbe System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // AdaptiveJoinType HashKeysProbeSpecified System.Boolean
            // AdaptiveJoinType BuildResidual Sqlserver.Showplan.ScalarExpressionType
            // AdaptiveJoinType ProbeResidual Sqlserver.Showplan.ScalarExpressionType
            // AdaptiveJoinType StarJoinInfo Sqlserver.Showplan.StarJoinInfoType
            // AdaptiveJoinType Predicate Sqlserver.Showplan.ScalarExpressionType
            // AdaptiveJoinType PassThru Sqlserver.Showplan.ScalarExpressionType
            // AdaptiveJoinType OuterReferences System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // AdaptiveJoinType OuterReferencesSpecified System.Boolean
            // AdaptiveJoinType PartitionId Sqlserver.Showplan.SingleColumnReferenceType
            // AdaptiveJoinType RelOp System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RelOpType]
            // AdaptiveJoinType BitmapCreator System.Boolean
            // AdaptiveJoinType BitmapCreatorSpecified System.Boolean
            // AdaptiveJoinType Optimized System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class AffectingConvertWarningType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // AffectingConvertWarningType ConvertIssue Sqlserver.Showplan.AffectingConvertWarningTypeConvertIssue
            // AffectingConvertWarningType Expression System.String
            return state;
        }
    }
    public partial class AggregateType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // AggregateType ScalarOperator System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // AggregateType ScalarOperatorSpecified System.Boolean
            // AggregateType AggType System.String
            // AggregateType Distinct System.Boolean
            return state;
        }
    }
    public partial class ArithmeticType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ArithmeticType ScalarOperator System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // ArithmeticType Operation Sqlserver.Showplan.ArithmeticOperationType
            return state;
        }
    }
    public partial class AssignType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // AssignType ColumnReference Sqlserver.Showplan.ColumnReferenceType
            // AssignType ScalarOperator Sqlserver.Showplan.ScalarType
            return state;
        }
    }
    public partial class BaseStmtInfoType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // BaseStmtInfoType StatementSetOptions Sqlserver.Showplan.SetOptionsType
            // BaseStmtInfoType StatementCompId System.Int32
            // BaseStmtInfoType StatementCompIdSpecified System.Boolean
            // BaseStmtInfoType StatementEstRows System.Double
            // BaseStmtInfoType StatementEstRowsSpecified System.Boolean
            // BaseStmtInfoType StatementId System.Int32
            // BaseStmtInfoType StatementIdSpecified System.Boolean
            // BaseStmtInfoType StatementOptmLevel System.String
            // BaseStmtInfoType StatementOptmEarlyAbortReason Sqlserver.Showplan.BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // BaseStmtInfoType StatementOptmEarlyAbortReasonSpecified System.Boolean
            // BaseStmtInfoType CardinalityEstimationModelVersion System.String
            // BaseStmtInfoType StatementSubTreeCost System.Double
            // BaseStmtInfoType StatementSubTreeCostSpecified System.Boolean
            // BaseStmtInfoType StatementText System.String
            // BaseStmtInfoType StatementType System.String
            // BaseStmtInfoType TemplatePlanGuideDB System.String
            // BaseStmtInfoType TemplatePlanGuideName System.String
            // BaseStmtInfoType PlanGuideDB System.String
            // BaseStmtInfoType PlanGuideName System.String
            // BaseStmtInfoType ParameterizedText System.String
            // BaseStmtInfoType ParameterizedPlanHandle System.String
            // BaseStmtInfoType QueryHash System.String
            // BaseStmtInfoType QueryPlanHash System.String
            // BaseStmtInfoType RetrievedFromCache System.String
            // BaseStmtInfoType StatementSqlHandle System.String
            // BaseStmtInfoType DatabaseContextSettingsId System.UInt64
            // BaseStmtInfoType DatabaseContextSettingsIdSpecified System.Boolean
            // BaseStmtInfoType ParentObjectId System.UInt64
            // BaseStmtInfoType ParentObjectIdSpecified System.Boolean
            // BaseStmtInfoType BatchSqlHandle System.String
            // BaseStmtInfoType StatementParameterizationType System.Int32
            // BaseStmtInfoType StatementParameterizationTypeSpecified System.Boolean
            // BaseStmtInfoType SecurityPolicyApplied System.Boolean
            // BaseStmtInfoType SecurityPolicyAppliedSpecified System.Boolean
            return state;
        }
    }
    public partial class BatchHashTableBuildType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // BatchHashTableBuildType RelOp Sqlserver.Showplan.RelOpType
            // BatchHashTableBuildType BitmapCreator System.Boolean
            // BatchHashTableBuildType BitmapCreatorSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class BitmapType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // BitmapType HashKeys System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // BitmapType RelOp Sqlserver.Showplan.RelOpType
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class CLRFunctionType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // CLRFunctionType Assembly System.String
            // CLRFunctionType Class System.String
            // CLRFunctionType Method System.String
            return state;
        }
    }
    public partial class CollapseType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // CollapseType GroupBy System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // CollapseType RelOp Sqlserver.Showplan.RelOpType
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class ColumnGroupType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ColumnGroupType Column System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnType]
            // ColumnGroupType Usage Sqlserver.Showplan.ColumnGroupTypeUsage
            return state;
        }
    }
    public partial class ColumnReferenceListType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ColumnReferenceListType ColumnReference System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // ColumnReferenceListType ColumnReferenceSpecified System.Boolean
            return state;
        }
    }
    public partial class ColumnReferenceType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ColumnReferenceType ScalarOperator Sqlserver.Showplan.ScalarType
            // ColumnReferenceType InternalInfo Sqlserver.Showplan.InternalInfoType
            // ColumnReferenceType Server System.String
            // ColumnReferenceType Database System.String
            // ColumnReferenceType Schema System.String
            // ColumnReferenceType Table System.String
            // ColumnReferenceType Alias System.String
            // ColumnReferenceType Column System.String
            // ColumnReferenceType ComputedColumn System.Boolean
            // ColumnReferenceType ComputedColumnSpecified System.Boolean
            // ColumnReferenceType ParameterDataType System.String
            // ColumnReferenceType ParameterCompiledValue System.String
            // ColumnReferenceType ParameterRuntimeValue System.String
            return state;
        }
    }
    public partial class ColumnType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ColumnType Name System.String
            // ColumnType ColumnId System.Int32
            return state;
        }
    }
    public partial class CompareType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // CompareType ScalarOperator System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // CompareType CompareOp Sqlserver.Showplan.CompareOpType
            return state;
        }
    }
    public partial class ComputeScalarType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ComputeScalarType RelOp Sqlserver.Showplan.RelOpType
            // ComputeScalarType ComputeSequence System.Boolean
            // ComputeScalarType ComputeSequenceSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class ConcatType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ConcatType RelOp System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RelOpType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class ConditionalType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ConditionalType Condition Sqlserver.Showplan.ScalarExpressionType
            // ConditionalType Then Sqlserver.Showplan.ScalarExpressionType
            // ConditionalType Else Sqlserver.Showplan.ScalarExpressionType
            return state;
        }
    }
    public partial class ConstantScanType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ConstantScanType Values System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarExpressionListType]
            // ConstantScanType ValuesSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class ConstantScanTypeValues : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ConstantScanTypeValues Row System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarExpressionListType]
            // ConstantScanTypeValues RowSpecified System.Boolean
            return state;
        }
    }
    public partial class ConstType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ConstType ConstValue System.String
            return state;
        }
    }
    public partial class ConvertType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ConvertType Style Sqlserver.Showplan.ScalarExpressionType
            // ConvertType Style_1 System.Int32
            // ConvertType ScalarOperator Sqlserver.Showplan.ScalarType
            // ConvertType DataType System.String
            // ConvertType Length System.Int32
            // ConvertType LengthSpecified System.Boolean
            // ConvertType Precision System.Int32
            // ConvertType PrecisionSpecified System.Boolean
            // ConvertType Scale System.Int32
            // ConvertType ScaleSpecified System.Boolean
            // ConvertType Implicit System.Boolean
            return state;
        }
    }
    public partial class CreateIndexType : RowsetType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // CreateIndexType RelOp Sqlserver.Showplan.RelOpType
            // RowsetType Object System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class CursorPlanType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // CursorPlanType Operation System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.CursorPlanTypeOperation]
            // CursorPlanType OperationSpecified System.Boolean
            // CursorPlanType CursorName System.String
            // CursorPlanType CursorActualType Sqlserver.Showplan.CursorType
            // CursorPlanType CursorActualTypeSpecified System.Boolean
            // CursorPlanType CursorRequestedType Sqlserver.Showplan.CursorType
            // CursorPlanType CursorRequestedTypeSpecified System.Boolean
            // CursorPlanType CursorConcurrency Sqlserver.Showplan.CursorPlanTypeCursorConcurrency
            // CursorPlanType CursorConcurrencySpecified System.Boolean
            // CursorPlanType ForwardOnly System.Boolean
            // CursorPlanType ForwardOnlySpecified System.Boolean
            return state;
        }
    }
    public partial class CursorPlanTypeOperation : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // CursorPlanTypeOperation QueryPlan Sqlserver.Showplan.QueryPlanType
            // CursorPlanTypeOperation UDF System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.FunctionType]
            // CursorPlanTypeOperation UDFSpecified System.Boolean
            // CursorPlanTypeOperation OperationType Sqlserver.Showplan.CursorPlanTypeOperationOperationType
            return state;
        }
    }
    public partial class DefinedValuesListType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // DefinedValuesListType DefinedValue System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // DefinedValuesListType DefinedValueSpecified System.Boolean
            return state;
        }
    }
    public partial class DefinedValuesListTypeDefinedValue : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // DefinedValuesListTypeDefinedValue ValueVector System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // DefinedValuesListTypeDefinedValue ValueVectorSpecified System.Boolean
            // DefinedValuesListTypeDefinedValue ColumnReference Sqlserver.Showplan.ColumnReferenceType
            // DefinedValuesListTypeDefinedValue ScalarOperator Sqlserver.Showplan.ScalarType
            return state;
        }
    }
    public partial class DefinedValuesListTypeDefinedValueValueVector : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // DefinedValuesListTypeDefinedValueValueVector ColumnReference System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            return state;
        }
    }
    public partial class FilterType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // FilterType RelOp Sqlserver.Showplan.RelOpType
            // FilterType Predicate Sqlserver.Showplan.ScalarExpressionType
            // FilterType StartupExpression System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class ForeignKeyReferenceCheckType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ForeignKeyReferenceCheckType IndexScan Sqlserver.Showplan.IndexScanType
            return state;
        }
    }
    public partial class ForeignKeyReferencesCheckType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ForeignKeyReferencesCheckType RelOp Sqlserver.Showplan.RelOpType
            // ForeignKeyReferencesCheckType ForeignKeyReferenceCheck System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ForeignKeyReferenceCheckType]
            // ForeignKeyReferencesCheckType ForeignKeyReferencesCount System.Int32
            // ForeignKeyReferencesCheckType ForeignKeyReferencesCountSpecified System.Boolean
            // ForeignKeyReferencesCheckType NoMatchingIndexCount System.Int32
            // ForeignKeyReferencesCheckType NoMatchingIndexCountSpecified System.Boolean
            // ForeignKeyReferencesCheckType PartialMatchingIndexCount System.Int32
            // ForeignKeyReferencesCheckType PartialMatchingIndexCountSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class FunctionType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // FunctionType Statements Sqlserver.Showplan.StmtBlockType
            // FunctionType ProcName System.String
            // FunctionType IsNativelyCompiled System.Boolean
            // FunctionType IsNativelyCompiledSpecified System.Boolean
            return state;
        }
    }
    public partial class GenericType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // GenericType RelOp System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RelOpType]
            // GenericType RelOpSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class GuessedSelectivityType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // GuessedSelectivityType Spatial Sqlserver.Showplan.ObjectType
            return state;
        }
    }
    public partial class HashSpillDetailsType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // HashSpillDetailsType GrantedMemoryKb System.UInt64
            // HashSpillDetailsType GrantedMemoryKbSpecified System.Boolean
            // HashSpillDetailsType UsedMemoryKb System.UInt64
            // HashSpillDetailsType UsedMemoryKbSpecified System.Boolean
            // HashSpillDetailsType WritesToTempDb System.UInt64
            // HashSpillDetailsType WritesToTempDbSpecified System.Boolean
            // HashSpillDetailsType ReadsFromTempDb System.UInt64
            // HashSpillDetailsType ReadsFromTempDbSpecified System.Boolean
            return state;
        }
    }
    public partial class HashType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // HashType HashKeysBuild System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // HashType HashKeysBuildSpecified System.Boolean
            // HashType HashKeysProbe System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // HashType HashKeysProbeSpecified System.Boolean
            // HashType BuildResidual Sqlserver.Showplan.ScalarExpressionType
            // HashType ProbeResidual Sqlserver.Showplan.ScalarExpressionType
            // HashType StarJoinInfo Sqlserver.Showplan.StarJoinInfoType
            // HashType RelOp System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RelOpType]
            // HashType BitmapCreator System.Boolean
            // HashType BitmapCreatorSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class IdentType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // IdentType ColumnReference Sqlserver.Showplan.ColumnReferenceType
            // IdentType Table System.String
            return state;
        }
    }
    public partial class IndexedViewInfoType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // IndexedViewInfoType Object System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // IndexedViewInfoType ObjectSpecified System.Boolean
            return state;
        }
    }
    public partial class IndexScanType : RowsetType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // IndexScanType SeekPredicates Sqlserver.Showplan.SeekPredicatesType
            // IndexScanType Predicate System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarExpressionType]
            // IndexScanType PredicateSpecified System.Boolean
            // IndexScanType PartitionId Sqlserver.Showplan.SingleColumnReferenceType
            // IndexScanType IndexedViewInfo System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // IndexScanType IndexedViewInfoSpecified System.Boolean
            // IndexScanType Lookup System.Boolean
            // IndexScanType LookupSpecified System.Boolean
            // IndexScanType Ordered System.Boolean
            // IndexScanType ScanDirection Sqlserver.Showplan.OrderType
            // IndexScanType ScanDirectionSpecified System.Boolean
            // IndexScanType ForcedIndex System.Boolean
            // IndexScanType ForcedIndexSpecified System.Boolean
            // IndexScanType ForceSeek System.Boolean
            // IndexScanType ForceSeekSpecified System.Boolean
            // IndexScanType ForceSeekColumnCount System.Int32
            // IndexScanType ForceSeekColumnCountSpecified System.Boolean
            // IndexScanType ForceScan System.Boolean
            // IndexScanType ForceScanSpecified System.Boolean
            // IndexScanType NoExpandHint System.Boolean
            // IndexScanType NoExpandHintSpecified System.Boolean
            // IndexScanType Storage Sqlserver.Showplan.StorageType
            // IndexScanType StorageSpecified System.Boolean
            // IndexScanType DynamicSeek System.Boolean
            // IndexScanType DynamicSeekSpecified System.Boolean
            // RowsetType Object System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class InternalInfoType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // InternalInfoType Any System.Collections.ObjectModel.Collection`1[System.Xml.XmlElement]
            // InternalInfoType AnySpecified System.Boolean
            // InternalInfoType AnyAttribute System.Collections.ObjectModel.Collection`1[System.Xml.XmlAttribute]
            return state;
        }
    }
    public partial class IntrinsicType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // IntrinsicType ScalarOperator System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // IntrinsicType ScalarOperatorSpecified System.Boolean
            // IntrinsicType FunctionName System.String
            return state;
        }
    }
    public partial class LogicalType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // LogicalType ScalarOperator System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // LogicalType Operation Sqlserver.Showplan.LogicalOperationType
            return state;
        }
    }
    public partial class MemoryFractionsType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // MemoryFractionsType Input System.Double
            // MemoryFractionsType Output System.Double
            return state;
        }
    }
    public partial class MemoryGrantType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // MemoryGrantType SerialRequiredMemory System.UInt64
            // MemoryGrantType SerialDesiredMemory System.UInt64
            // MemoryGrantType RequiredMemory System.UInt64
            // MemoryGrantType RequiredMemorySpecified System.Boolean
            // MemoryGrantType DesiredMemory System.UInt64
            // MemoryGrantType DesiredMemorySpecified System.Boolean
            // MemoryGrantType RequestedMemory System.UInt64
            // MemoryGrantType RequestedMemorySpecified System.Boolean
            // MemoryGrantType GrantWaitTime System.UInt64
            // MemoryGrantType GrantWaitTimeSpecified System.Boolean
            // MemoryGrantType GrantedMemory System.UInt64
            // MemoryGrantType GrantedMemorySpecified System.Boolean
            // MemoryGrantType MaxUsedMemory System.UInt64
            // MemoryGrantType MaxUsedMemorySpecified System.Boolean
            // MemoryGrantType MaxQueryMemory System.UInt64
            // MemoryGrantType MaxQueryMemorySpecified System.Boolean
            return state;
        }
    }
    public partial class MemoryGrantWarningInfo : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // MemoryGrantWarningInfo GrantWarningKind Sqlserver.Showplan.MemoryGrantWarningType
            // MemoryGrantWarningInfo RequestedMemory System.UInt64
            // MemoryGrantWarningInfo GrantedMemory System.UInt64
            // MemoryGrantWarningInfo MaxUsedMemory System.UInt64
            return state;
        }
    }
    public partial class MergeType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // MergeType InnerSideJoinColumns System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // MergeType InnerSideJoinColumnsSpecified System.Boolean
            // MergeType OuterSideJoinColumns System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // MergeType OuterSideJoinColumnsSpecified System.Boolean
            // MergeType Residual Sqlserver.Showplan.ScalarExpressionType
            // MergeType PassThru Sqlserver.Showplan.ScalarExpressionType
            // MergeType StarJoinInfo Sqlserver.Showplan.StarJoinInfoType
            // MergeType RelOp System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RelOpType]
            // MergeType ManyToMany System.Boolean
            // MergeType ManyToManySpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class MissingIndexesType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // MissingIndexesType MissingIndexGroup System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.MissingIndexGroupType]
            return state;
        }
    }
    public partial class MissingIndexGroupType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // MissingIndexGroupType MissingIndex System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.MissingIndexType]
            // MissingIndexGroupType Impact System.Double
            return state;
        }
    }
    public partial class MissingIndexType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // MissingIndexType ColumnGroup System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnGroupType]
            // MissingIndexType Database System.String
            // MissingIndexType Schema System.String
            // MissingIndexType Table System.String
            return state;
        }
    }
    public partial class MultAssignType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // MultAssignType Assign System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.AssignType]
            // MultAssignType AssignSpecified System.Boolean
            return state;
        }
    }
    public partial class NestedLoopsType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // NestedLoopsType Predicate Sqlserver.Showplan.ScalarExpressionType
            // NestedLoopsType PassThru Sqlserver.Showplan.ScalarExpressionType
            // NestedLoopsType OuterReferences System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // NestedLoopsType OuterReferencesSpecified System.Boolean
            // NestedLoopsType PartitionId Sqlserver.Showplan.SingleColumnReferenceType
            // NestedLoopsType ProbeColumn Sqlserver.Showplan.SingleColumnReferenceType
            // NestedLoopsType StarJoinInfo Sqlserver.Showplan.StarJoinInfoType
            // NestedLoopsType RelOp System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RelOpType]
            // NestedLoopsType Optimized System.Boolean
            // NestedLoopsType WithOrderedPrefetch System.Boolean
            // NestedLoopsType WithOrderedPrefetchSpecified System.Boolean
            // NestedLoopsType WithUnorderedPrefetch System.Boolean
            // NestedLoopsType WithUnorderedPrefetchSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class ObjectType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ObjectType Server System.String
            // ObjectType Database System.String
            // ObjectType Schema System.String
            // ObjectType Table System.String
            // ObjectType Index System.String
            // ObjectType Filtered System.Boolean
            // ObjectType FilteredSpecified System.Boolean
            // ObjectType Alias System.String
            // ObjectType TableReferenceId System.Int32
            // ObjectType TableReferenceIdSpecified System.Boolean
            // ObjectType IndexKind Sqlserver.Showplan.IndexKindType
            // ObjectType IndexKindSpecified System.Boolean
            // ObjectType CloneAccessScope Sqlserver.Showplan.CloneAccessScopeType
            // ObjectType CloneAccessScopeSpecified System.Boolean
            // ObjectType Storage Sqlserver.Showplan.StorageType
            // ObjectType StorageSpecified System.Boolean
            return state;
        }
    }
    public partial class OptimizerHardwareDependentPropertiesType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // OptimizerHardwareDependentPropertiesType EstimatedAvailableMemoryGrant System.UInt64
            // OptimizerHardwareDependentPropertiesType EstimatedPagesCached System.UInt64
            // OptimizerHardwareDependentPropertiesType EstimatedAvailableDegreeOfParallelism System.UInt64
            // OptimizerHardwareDependentPropertiesType EstimatedAvailableDegreeOfParallelismSpecified System.Boolean
            // OptimizerHardwareDependentPropertiesType MaxCompileMemory System.UInt64
            // OptimizerHardwareDependentPropertiesType MaxCompileMemorySpecified System.Boolean
            return state;
        }
    }
    public partial class OptimizerStatsUsageType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // OptimizerStatsUsageType StatisticsInfo System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.StatsInfoType]
            return state;
        }
    }
    public partial class OrderByType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // OrderByType OrderByColumn System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.OrderByTypeOrderByColumn]
            return state;
        }
    }
    public partial class OrderByTypeOrderByColumn : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // OrderByTypeOrderByColumn ColumnReference Sqlserver.Showplan.ColumnReferenceType
            // OrderByTypeOrderByColumn Ascending System.Boolean
            return state;
        }
    }
    public partial class ParallelismType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ParallelismType PartitionColumns System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // ParallelismType PartitionColumnsSpecified System.Boolean
            // ParallelismType OrderBy System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.OrderByTypeOrderByColumn]
            // ParallelismType OrderBySpecified System.Boolean
            // ParallelismType HashKeys System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // ParallelismType HashKeysSpecified System.Boolean
            // ParallelismType ProbeColumn Sqlserver.Showplan.SingleColumnReferenceType
            // ParallelismType Predicate Sqlserver.Showplan.ScalarExpressionType
            // ParallelismType Activation Sqlserver.Showplan.ParallelismTypeActivation
            // ParallelismType BrickRouting Sqlserver.Showplan.ParallelismTypeBrickRouting
            // ParallelismType RelOp Sqlserver.Showplan.RelOpType
            // ParallelismType PartitioningType Sqlserver.Showplan.PartitionType
            // ParallelismType PartitioningTypeSpecified System.Boolean
            // ParallelismType Remoting System.Boolean
            // ParallelismType RemotingSpecified System.Boolean
            // ParallelismType LocalParallelism System.Boolean
            // ParallelismType LocalParallelismSpecified System.Boolean
            // ParallelismType InRow System.Boolean
            // ParallelismType InRowSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class ParallelismTypeActivation : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ParallelismTypeActivation Object Sqlserver.Showplan.ObjectType
            // ParallelismTypeActivation Type Sqlserver.Showplan.ParallelismTypeActivationType
            // ParallelismTypeActivation FragmentElimination System.String
            return state;
        }
    }
    public partial class ParallelismTypeBrickRouting : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ParallelismTypeBrickRouting Object Sqlserver.Showplan.ObjectType
            // ParallelismTypeBrickRouting FragmentIdColumn Sqlserver.Showplan.SingleColumnReferenceType
            return state;
        }
    }
    public partial class ParameterizationType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ParameterizationType Object System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            return state;
        }
    }
    public partial class PutType : RemoteQueryType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // PutType RelOp Sqlserver.Showplan.RelOpType
            // PutType ShuffleType System.String
            // PutType ShuffleColumn System.String
            // RemoteQueryType RemoteQuery System.String
            // RemoteType RemoteDestination System.String
            // RemoteType RemoteSource System.String
            // RemoteType RemoteObject System.String
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class QueryExecTimeType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // QueryExecTimeType CpuTime System.UInt64
            // QueryExecTimeType ElapsedTime System.UInt64
            return state;
        }
    }
    public partial class QueryPlanType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // QueryPlanType InternalInfo Sqlserver.Showplan.InternalInfoType
            // QueryPlanType ThreadStat Sqlserver.Showplan.ThreadStatType
            // QueryPlanType MissingIndexes System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.MissingIndexGroupType]
            // QueryPlanType MissingIndexesSpecified System.Boolean
            // QueryPlanType GuessedSelectivity Sqlserver.Showplan.GuessedSelectivityType
            // QueryPlanType UnmatchedIndexes Sqlserver.Showplan.UnmatchedIndexesType
            // QueryPlanType Warnings Sqlserver.Showplan.WarningsType
            // QueryPlanType MemoryGrantInfo Sqlserver.Showplan.MemoryGrantType
            // QueryPlanType OptimizerHardwareDependentProperties Sqlserver.Showplan.OptimizerHardwareDependentPropertiesType
            // QueryPlanType OptimizerStatsUsage System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.StatsInfoType]
            // QueryPlanType OptimizerStatsUsageSpecified System.Boolean
            // QueryPlanType TraceFlags System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.TraceFlagListType]
            // QueryPlanType TraceFlagsSpecified System.Boolean
            // QueryPlanType WaitStats System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.WaitStatType]
            // QueryPlanType WaitStatsSpecified System.Boolean
            // QueryPlanType QueryTimeStats Sqlserver.Showplan.QueryExecTimeType
            // QueryPlanType RelOp Sqlserver.Showplan.RelOpType
            // QueryPlanType ParameterList System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // QueryPlanType ParameterListSpecified System.Boolean
            // QueryPlanType DegreeOfParallelism System.Int32
            // QueryPlanType DegreeOfParallelismSpecified System.Boolean
            // QueryPlanType EffectiveDegreeOfParallelism System.Int32
            // QueryPlanType EffectiveDegreeOfParallelismSpecified System.Boolean
            // QueryPlanType NonParallelPlanReason System.String
            // QueryPlanType MemoryGrant System.UInt64
            // QueryPlanType MemoryGrantSpecified System.Boolean
            // QueryPlanType CachedPlanSize System.UInt64
            // QueryPlanType CachedPlanSizeSpecified System.Boolean
            // QueryPlanType CompileTime System.UInt64
            // QueryPlanType CompileTimeSpecified System.Boolean
            // QueryPlanType CompileCPU System.UInt64
            // QueryPlanType CompileCPUSpecified System.Boolean
            // QueryPlanType CompileMemory System.UInt64
            // QueryPlanType CompileMemorySpecified System.Boolean
            // QueryPlanType UsePlan System.Boolean
            // QueryPlanType UsePlanSpecified System.Boolean
            // QueryPlanType ContainsInterleavedExecutionCandidates System.Boolean
            // QueryPlanType ContainsInterleavedExecutionCandidatesSpecified System.Boolean
            return state;
        }
    }
    public partial class ReceivePlanType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ReceivePlanType Operation System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ReceivePlanTypeOperation]
            return state;
        }
    }
    public partial class ReceivePlanTypeOperation : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ReceivePlanTypeOperation QueryPlan Sqlserver.Showplan.QueryPlanType
            // ReceivePlanTypeOperation OperationType Sqlserver.Showplan.ReceivePlanTypeOperationOperationType
            // ReceivePlanTypeOperation OperationTypeSpecified System.Boolean
            return state;
        }
    }
    public partial class RelOpBaseType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class RelOpType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RelOpType OutputList System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // RelOpType Warnings Sqlserver.Showplan.WarningsType
            // RelOpType MemoryFractions Sqlserver.Showplan.MemoryFractionsType
            // RelOpType RunTimeInformation System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RunTimeInformationTypeRunTimeCountersPerThread]
            // RelOpType RunTimeInformationSpecified System.Boolean
            // RelOpType RunTimePartitionSummary Sqlserver.Showplan.RunTimePartitionSummaryType
            // RelOpType InternalInfo Sqlserver.Showplan.InternalInfoType
            // RelOpType AdaptiveJoin Sqlserver.Showplan.AdaptiveJoinType
            // RelOpType Assert Sqlserver.Showplan.FilterType
            // RelOpType BatchHashTableBuild Sqlserver.Showplan.BatchHashTableBuildType
            // RelOpType Bitmap Sqlserver.Showplan.BitmapType
            // RelOpType Collapse Sqlserver.Showplan.CollapseType
            // RelOpType ComputeScalar Sqlserver.Showplan.ComputeScalarType
            // RelOpType Concat Sqlserver.Showplan.ConcatType
            // RelOpType ConstantScan Sqlserver.Showplan.ConstantScanType
            // RelOpType CreateIndex Sqlserver.Showplan.CreateIndexType
            // RelOpType DeletedScan Sqlserver.Showplan.RowsetType
            // RelOpType Extension Sqlserver.Showplan.UDXType
            // RelOpType Filter Sqlserver.Showplan.FilterType
            // RelOpType ForeignKeyReferencesCheck Sqlserver.Showplan.ForeignKeyReferencesCheckType
            // RelOpType Generic Sqlserver.Showplan.GenericType
            // RelOpType Hash Sqlserver.Showplan.HashType
            // RelOpType IndexScan Sqlserver.Showplan.IndexScanType
            // RelOpType InsertedScan Sqlserver.Showplan.RowsetType
            // RelOpType LogRowScan Sqlserver.Showplan.RelOpBaseType
            // RelOpType Merge Sqlserver.Showplan.MergeType
            // RelOpType MergeInterval Sqlserver.Showplan.SimpleIteratorOneChildType
            // RelOpType NestedLoops Sqlserver.Showplan.NestedLoopsType
            // RelOpType OnlineIndex Sqlserver.Showplan.CreateIndexType
            // RelOpType Parallelism Sqlserver.Showplan.ParallelismType
            // RelOpType ParameterTableScan Sqlserver.Showplan.RelOpBaseType
            // RelOpType PrintDataflow Sqlserver.Showplan.RelOpBaseType
            // RelOpType Put Sqlserver.Showplan.PutType
            // RelOpType RemoteFetch Sqlserver.Showplan.RemoteFetchType
            // RelOpType RemoteModify Sqlserver.Showplan.RemoteModifyType
            // RelOpType RemoteQuery Sqlserver.Showplan.RemoteQueryType
            // RelOpType RemoteRange Sqlserver.Showplan.RemoteRangeType
            // RelOpType RemoteScan Sqlserver.Showplan.RemoteType
            // RelOpType RowCountSpool Sqlserver.Showplan.SpoolType
            // RelOpType ScalarInsert Sqlserver.Showplan.ScalarInsertType
            // RelOpType Segment Sqlserver.Showplan.SegmentType
            // RelOpType Sequence Sqlserver.Showplan.SequenceType
            // RelOpType SequenceProject Sqlserver.Showplan.ComputeScalarType
            // RelOpType SimpleUpdate Sqlserver.Showplan.SimpleUpdateType
            // RelOpType Sort Sqlserver.Showplan.SortType
            // RelOpType Split Sqlserver.Showplan.SplitType
            // RelOpType Spool Sqlserver.Showplan.SpoolType
            // RelOpType StreamAggregate Sqlserver.Showplan.StreamAggregateType
            // RelOpType Switch Sqlserver.Showplan.SwitchType
            // RelOpType TableScan Sqlserver.Showplan.TableScanType
            // RelOpType TableValuedFunction Sqlserver.Showplan.TableValuedFunctionType
            // RelOpType Top Sqlserver.Showplan.TopType
            // RelOpType TopSort Sqlserver.Showplan.TopSortType
            // RelOpType Update Sqlserver.Showplan.UpdateType
            // RelOpType WindowSpool Sqlserver.Showplan.WindowType
            // RelOpType WindowAggregate Sqlserver.Showplan.WindowAggregateType
            // RelOpType AvgRowSize System.Double
            // RelOpType EstimateCPU System.Double
            // RelOpType EstimateIO System.Double
            // RelOpType EstimateRebinds System.Double
            // RelOpType EstimateRewinds System.Double
            // RelOpType EstimatedExecutionMode Sqlserver.Showplan.ExecutionModeType
            // RelOpType EstimatedExecutionModeSpecified System.Boolean
            // RelOpType GroupExecuted System.Boolean
            // RelOpType GroupExecutedSpecified System.Boolean
            // RelOpType EstimateRows System.Double
            // RelOpType EstimatedRowsRead System.Double
            // RelOpType EstimatedRowsReadSpecified System.Boolean
            // RelOpType LogicalOp Sqlserver.Showplan.LogicalOpType
            // RelOpType NodeId System.Int32
            // RelOpType Parallel System.Boolean
            // RelOpType RemoteDataAccess System.Boolean
            // RelOpType RemoteDataAccessSpecified System.Boolean
            // RelOpType Partitioned System.Boolean
            // RelOpType PartitionedSpecified System.Boolean
            // RelOpType PhysicalOp Sqlserver.Showplan.PhysicalOpType
            // RelOpType IsAdaptive System.Boolean
            // RelOpType IsAdaptiveSpecified System.Boolean
            // RelOpType AdaptiveThresholdRows System.Double
            // RelOpType AdaptiveThresholdRowsSpecified System.Boolean
            // RelOpType EstimatedTotalSubtreeCost System.Double
            // RelOpType TableCardinality System.Double
            // RelOpType TableCardinalitySpecified System.Boolean
            // RelOpType StatsCollectionId System.UInt64
            // RelOpType StatsCollectionIdSpecified System.Boolean
            // RelOpType EstimatedJoinType Sqlserver.Showplan.PhysicalOpType
            // RelOpType EstimatedJoinTypeSpecified System.Boolean
            return state;
        }
    }
    public partial class RemoteFetchType : RemoteType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RemoteFetchType RelOp Sqlserver.Showplan.RelOpType
            // RemoteType RemoteDestination System.String
            // RemoteType RemoteSource System.String
            // RemoteType RemoteObject System.String
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class RemoteModifyType : RemoteType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RemoteModifyType SetPredicate Sqlserver.Showplan.ScalarExpressionType
            // RemoteModifyType RelOp Sqlserver.Showplan.RelOpType
            // RemoteType RemoteDestination System.String
            // RemoteType RemoteSource System.String
            // RemoteType RemoteObject System.String
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class RemoteQueryType : RemoteType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RemoteQueryType RemoteQuery System.String
            // RemoteType RemoteDestination System.String
            // RemoteType RemoteSource System.String
            // RemoteType RemoteObject System.String
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class RemoteRangeType : RemoteType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RemoteRangeType SeekPredicates Sqlserver.Showplan.SeekPredicatesType
            // RemoteType RemoteDestination System.String
            // RemoteType RemoteSource System.String
            // RemoteType RemoteObject System.String
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class RemoteType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RemoteType RemoteDestination System.String
            // RemoteType RemoteSource System.String
            // RemoteType RemoteObject System.String
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class RollupInfoType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RollupInfoType RollupLevel System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RollupLevelType]
            // RollupInfoType HighestLevel System.Int32
            return state;
        }
    }
    public partial class RollupLevelType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RollupLevelType Level System.Int32
            return state;
        }
    }
    public partial class RowsetType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RowsetType Object System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class RunTimeInformationType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RunTimeInformationType RunTimeCountersPerThread System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RunTimeInformationTypeRunTimeCountersPerThread]
            return state;
        }
    }
    public partial class RunTimeInformationTypeRunTimeCountersPerThread : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RunTimeInformationTypeRunTimeCountersPerThread Thread System.Int32
            // RunTimeInformationTypeRunTimeCountersPerThread BrickId System.Int32
            // RunTimeInformationTypeRunTimeCountersPerThread BrickIdSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualRebinds System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualRebindsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualRewinds System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualRewindsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualRows System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualRowsRead System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualRowsReadSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread Batches System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread BatchesSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualEndOfScans System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualExecutions System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualExecutionMode Sqlserver.Showplan.ExecutionModeType
            // RunTimeInformationTypeRunTimeCountersPerThread ActualExecutionModeSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread TaskAddr System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread TaskAddrSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread SchedulerId System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread SchedulerIdSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread FirstActiveTime System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread FirstActiveTimeSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread LastActiveTime System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread LastActiveTimeSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread OpenTime System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread OpenTimeSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread FirstRowTime System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread FirstRowTimeSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread LastRowTime System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread LastRowTimeSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread CloseTime System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread CloseTimeSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualElapsedms System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualElapsedmsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualCPUms System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualCPUmsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualScans System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualScansSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLogicalReads System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLogicalReadsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualPhysicalReads System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualPhysicalReadsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualReadAheads System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualReadAheadsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLobLogicalReads System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLobLogicalReadsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLobPhysicalReads System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLobPhysicalReadsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLobReadAheads System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLobReadAheadsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread SegmentReads System.Int32
            // RunTimeInformationTypeRunTimeCountersPerThread SegmentReadsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread SegmentSkips System.Int32
            // RunTimeInformationTypeRunTimeCountersPerThread SegmentSkipsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLocallyAggregatedRows System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread ActualLocallyAggregatedRowsSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread InputMemoryGrant System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread InputMemoryGrantSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread OutputMemoryGrant System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread OutputMemoryGrantSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread UsedMemoryGrant System.UInt64
            // RunTimeInformationTypeRunTimeCountersPerThread UsedMemoryGrantSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread IsInterleavedExecuted System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread IsInterleavedExecutedSpecified System.Boolean
            // RunTimeInformationTypeRunTimeCountersPerThread ActualJoinType Sqlserver.Showplan.PhysicalOpType
            // RunTimeInformationTypeRunTimeCountersPerThread ActualJoinTypeSpecified System.Boolean
            return state;
        }
    }
    public partial class RunTimePartitionSummaryType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RunTimePartitionSummaryType PartitionsAccessed Sqlserver.Showplan.RunTimePartitionSummaryTypePartitionsAccessed
            return state;
        }
    }
    public partial class RunTimePartitionSummaryTypePartitionsAccessed : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RunTimePartitionSummaryTypePartitionsAccessed PartitionRange System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RunTimePartitionSummaryTypePartitionsAccessedPartitionRange]
            // RunTimePartitionSummaryTypePartitionsAccessed PartitionRangeSpecified System.Boolean
            // RunTimePartitionSummaryTypePartitionsAccessed PartitionCount System.UInt64
            return state;
        }
    }
    public partial class RunTimePartitionSummaryTypePartitionsAccessedPartitionRange : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // RunTimePartitionSummaryTypePartitionsAccessedPartitionRange Start System.UInt64
            // RunTimePartitionSummaryTypePartitionsAccessedPartitionRange End System.UInt64
            return state;
        }
    }
    public partial class ScalarExpressionListType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ScalarExpressionListType ScalarOperator System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            return state;
        }
    }
    public partial class ScalarExpressionType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ScalarExpressionType ScalarOperator Sqlserver.Showplan.ScalarType
            return state;
        }
    }
    public partial class ScalarInsertType : RowsetType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ScalarInsertType SetPredicate Sqlserver.Showplan.ScalarExpressionType
            // ScalarInsertType DMLRequestSort System.Boolean
            // ScalarInsertType DMLRequestSortSpecified System.Boolean
            // RowsetType Object System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class ScalarSequenceType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ScalarSequenceType FunctionName System.String
            return state;
        }
    }
    public partial class ScalarType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ScalarType Aggregate Sqlserver.Showplan.AggregateType
            // ScalarType Arithmetic Sqlserver.Showplan.ArithmeticType
            // ScalarType Assign Sqlserver.Showplan.AssignType
            // ScalarType Compare Sqlserver.Showplan.CompareType
            // ScalarType Const Sqlserver.Showplan.ConstType
            // ScalarType Convert Sqlserver.Showplan.ConvertType
            // ScalarType Identifier Sqlserver.Showplan.IdentType
            // ScalarType IF Sqlserver.Showplan.ConditionalType
            // ScalarType Intrinsic Sqlserver.Showplan.IntrinsicType
            // ScalarType Logical Sqlserver.Showplan.LogicalType
            // ScalarType MultipleAssign System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.AssignType]
            // ScalarType MultipleAssignSpecified System.Boolean
            // ScalarType ScalarExpressionList System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // ScalarType ScalarExpressionListSpecified System.Boolean
            // ScalarType Sequence Sqlserver.Showplan.ScalarSequenceType
            // ScalarType Subquery Sqlserver.Showplan.SubqueryType
            // ScalarType UDTMethod Sqlserver.Showplan.UDTMethodType
            // ScalarType UserDefinedAggregate Sqlserver.Showplan.UDAggregateType
            // ScalarType UserDefinedFunction Sqlserver.Showplan.UDFType
            // ScalarType InternalInfo Sqlserver.Showplan.InternalInfoType
            // ScalarType ScalarString System.String
            return state;
        }
    }
    public partial class ScanRangeType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ScanRangeType RangeColumns System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // ScanRangeType RangeExpressions System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // ScanRangeType ScanType Sqlserver.Showplan.CompareOpType
            return state;
        }
    }
    public partial class SeekPredicateNewType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SeekPredicateNewType SeekKeys System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SeekPredicateType]
            return state;
        }
    }
    public partial class SeekPredicatePartType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SeekPredicatePartType SeekPredicateNew System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SeekPredicateNewType]
            // SeekPredicatePartType SeekPredicateNewSpecified System.Boolean
            return state;
        }
    }
    public partial class SeekPredicatesType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SeekPredicatesType SeekPredicate System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SeekPredicateType]
            // SeekPredicatesType SeekPredicateSpecified System.Boolean
            // SeekPredicatesType SeekPredicateNew System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SeekPredicateNewType]
            // SeekPredicatesType SeekPredicateNewSpecified System.Boolean
            // SeekPredicatesType SeekPredicatePart System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SeekPredicatePartType]
            // SeekPredicatesType SeekPredicatePartSpecified System.Boolean
            return state;
        }
    }
    public partial class SeekPredicateType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SeekPredicateType Prefix Sqlserver.Showplan.ScanRangeType
            // SeekPredicateType StartRange Sqlserver.Showplan.ScanRangeType
            // SeekPredicateType EndRange Sqlserver.Showplan.ScanRangeType
            // SeekPredicateType IsNotNull Sqlserver.Showplan.SingleColumnReferenceType
            return state;
        }
    }
    public partial class SegmentType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SegmentType GroupBy System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // SegmentType SegmentColumn Sqlserver.Showplan.SingleColumnReferenceType
            // SegmentType RelOp Sqlserver.Showplan.RelOpType
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class SequenceType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SequenceType RelOp System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RelOpType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class SetOptionsType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SetOptionsType ANSI_NULLS System.Boolean
            // SetOptionsType ANSI_NULLSSpecified System.Boolean
            // SetOptionsType ANSI_PADDING System.Boolean
            // SetOptionsType ANSI_PADDINGSpecified System.Boolean
            // SetOptionsType ANSI_WARNINGS System.Boolean
            // SetOptionsType ANSI_WARNINGSSpecified System.Boolean
            // SetOptionsType ARITHABORT System.Boolean
            // SetOptionsType ARITHABORTSpecified System.Boolean
            // SetOptionsType CONCAT_NULL_YIELDS_NULL System.Boolean
            // SetOptionsType CONCAT_NULL_YIELDS_NULLSpecified System.Boolean
            // SetOptionsType NUMERIC_ROUNDABORT System.Boolean
            // SetOptionsType NUMERIC_ROUNDABORTSpecified System.Boolean
            // SetOptionsType QUOTED_IDENTIFIER System.Boolean
            // SetOptionsType QUOTED_IDENTIFIERSpecified System.Boolean
            return state;
        }
    }
    public partial class SetPredicateElementType : ScalarExpressionType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SetPredicateElementType SetPredicateType Sqlserver.Showplan.SetPredicateType
            // SetPredicateElementType SetPredicateTypeSpecified System.Boolean
            // ScalarExpressionType ScalarOperator Sqlserver.Showplan.ScalarType
            return state;
        }
    }
    public partial class ShowPlanXML : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ShowPlanXML BatchSequence System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ShowPlanXMLBatchSequenceBatch]
            // ShowPlanXML Version System.String
            // ShowPlanXML Build System.String
            // ShowPlanXML ClusteredMode System.Boolean
            // ShowPlanXML ClusteredModeSpecified System.Boolean
            return state;
        }
    }
    public partial class ShowPlanXMLBatchSequence : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ShowPlanXMLBatchSequence Batch System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ShowPlanXMLBatchSequenceBatch]
            return state;
        }
    }
    public partial class ShowPlanXMLBatchSequenceBatch : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ShowPlanXMLBatchSequenceBatch Statements System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.StmtBlockType]
            return state;
        }
    }
    public partial class SimpleIteratorOneChildType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SimpleIteratorOneChildType RelOp Sqlserver.Showplan.RelOpType
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class SimpleUpdateType : RowsetType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SimpleUpdateType SeekPredicate Sqlserver.Showplan.SeekPredicateType
            // SimpleUpdateType SeekPredicateNew System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SeekPredicateType]
            // SimpleUpdateType SeekPredicateNewSpecified System.Boolean
            // SimpleUpdateType SetPredicate Sqlserver.Showplan.ScalarExpressionType
            // SimpleUpdateType DMLRequestSort System.Boolean
            // SimpleUpdateType DMLRequestSortSpecified System.Boolean
            // RowsetType Object System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class SingleColumnReferenceType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SingleColumnReferenceType ColumnReference Sqlserver.Showplan.ColumnReferenceType
            return state;
        }
    }
    public partial class SortSpillDetailsType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SortSpillDetailsType GrantedMemoryKb System.UInt64
            // SortSpillDetailsType GrantedMemoryKbSpecified System.Boolean
            // SortSpillDetailsType UsedMemoryKb System.UInt64
            // SortSpillDetailsType UsedMemoryKbSpecified System.Boolean
            // SortSpillDetailsType WritesToTempDb System.UInt64
            // SortSpillDetailsType WritesToTempDbSpecified System.Boolean
            // SortSpillDetailsType ReadsFromTempDb System.UInt64
            // SortSpillDetailsType ReadsFromTempDbSpecified System.Boolean
            return state;
        }
    }
    public partial class SortType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SortType OrderBy System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.OrderByTypeOrderByColumn]
            // SortType PartitionId Sqlserver.Showplan.SingleColumnReferenceType
            // SortType RelOp Sqlserver.Showplan.RelOpType
            // SortType Distinct System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class SpillToTempDbType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SpillToTempDbType SpillLevel System.UInt64
            // SpillToTempDbType SpillLevelSpecified System.Boolean
            // SpillToTempDbType SpilledThreadCount System.UInt64
            // SpillToTempDbType SpilledThreadCountSpecified System.Boolean
            return state;
        }
    }
    public partial class SplitType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SplitType ActionColumn Sqlserver.Showplan.SingleColumnReferenceType
            // SplitType RelOp Sqlserver.Showplan.RelOpType
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class SpoolType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SpoolType SeekPredicate Sqlserver.Showplan.SeekPredicateType
            // SpoolType SeekPredicateNew System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SeekPredicateType]
            // SpoolType SeekPredicateNewSpecified System.Boolean
            // SpoolType RelOp Sqlserver.Showplan.RelOpType
            // SpoolType Stack System.Boolean
            // SpoolType StackSpecified System.Boolean
            // SpoolType PrimaryNodeId System.Int32
            // SpoolType PrimaryNodeIdSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class StarJoinInfoType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StarJoinInfoType Root System.Boolean
            // StarJoinInfoType RootSpecified System.Boolean
            // StarJoinInfoType OperationType Sqlserver.Showplan.StarJoinInfoTypeOperationType
            return state;
        }
    }
    public partial class StatsInfoType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StatsInfoType Database System.String
            // StatsInfoType Schema System.String
            // StatsInfoType Table System.String
            // StatsInfoType Statistics System.String
            // StatsInfoType ModificationCount System.UInt64
            // StatsInfoType SamplingPercent System.Double
            // StatsInfoType LastUpdate System.DateTime
            // StatsInfoType LastUpdateSpecified System.Boolean
            return state;
        }
    }
    public partial class StmtBlockType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StmtBlockType StmtSimple System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.StmtSimpleType]
            // StmtBlockType StmtSimpleSpecified System.Boolean
            // StmtBlockType StmtCond System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.StmtCondType]
            // StmtBlockType StmtCondSpecified System.Boolean
            // StmtBlockType StmtCursor System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.StmtCursorType]
            // StmtBlockType StmtCursorSpecified System.Boolean
            // StmtBlockType StmtReceive System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.StmtReceiveType]
            // StmtBlockType StmtReceiveSpecified System.Boolean
            // StmtBlockType StmtUseDb System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.StmtUseDbType]
            // StmtBlockType StmtUseDbSpecified System.Boolean
            return state;
        }
    }
    public partial class StmtCondType : BaseStmtInfoType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StmtCondType Condition Sqlserver.Showplan.StmtCondTypeCondition
            // StmtCondType Then Sqlserver.Showplan.StmtCondTypeThen
            // StmtCondType Else Sqlserver.Showplan.StmtCondTypeElse
            // BaseStmtInfoType StatementSetOptions Sqlserver.Showplan.SetOptionsType
            // BaseStmtInfoType StatementCompId System.Int32
            // BaseStmtInfoType StatementCompIdSpecified System.Boolean
            // BaseStmtInfoType StatementEstRows System.Double
            // BaseStmtInfoType StatementEstRowsSpecified System.Boolean
            // BaseStmtInfoType StatementId System.Int32
            // BaseStmtInfoType StatementIdSpecified System.Boolean
            // BaseStmtInfoType StatementOptmLevel System.String
            // BaseStmtInfoType StatementOptmEarlyAbortReason Sqlserver.Showplan.BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // BaseStmtInfoType StatementOptmEarlyAbortReasonSpecified System.Boolean
            // BaseStmtInfoType CardinalityEstimationModelVersion System.String
            // BaseStmtInfoType StatementSubTreeCost System.Double
            // BaseStmtInfoType StatementSubTreeCostSpecified System.Boolean
            // BaseStmtInfoType StatementText System.String
            // BaseStmtInfoType StatementType System.String
            // BaseStmtInfoType TemplatePlanGuideDB System.String
            // BaseStmtInfoType TemplatePlanGuideName System.String
            // BaseStmtInfoType PlanGuideDB System.String
            // BaseStmtInfoType PlanGuideName System.String
            // BaseStmtInfoType ParameterizedText System.String
            // BaseStmtInfoType ParameterizedPlanHandle System.String
            // BaseStmtInfoType QueryHash System.String
            // BaseStmtInfoType QueryPlanHash System.String
            // BaseStmtInfoType RetrievedFromCache System.String
            // BaseStmtInfoType StatementSqlHandle System.String
            // BaseStmtInfoType DatabaseContextSettingsId System.UInt64
            // BaseStmtInfoType DatabaseContextSettingsIdSpecified System.Boolean
            // BaseStmtInfoType ParentObjectId System.UInt64
            // BaseStmtInfoType ParentObjectIdSpecified System.Boolean
            // BaseStmtInfoType BatchSqlHandle System.String
            // BaseStmtInfoType StatementParameterizationType System.Int32
            // BaseStmtInfoType StatementParameterizationTypeSpecified System.Boolean
            // BaseStmtInfoType SecurityPolicyApplied System.Boolean
            // BaseStmtInfoType SecurityPolicyAppliedSpecified System.Boolean
            return state;
        }
    }
    public partial class StmtCondTypeCondition : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StmtCondTypeCondition QueryPlan Sqlserver.Showplan.QueryPlanType
            // StmtCondTypeCondition UDF System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.FunctionType]
            // StmtCondTypeCondition UDFSpecified System.Boolean
            return state;
        }
    }
    public partial class StmtCondTypeElse : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StmtCondTypeElse Statements Sqlserver.Showplan.StmtBlockType
            return state;
        }
    }
    public partial class StmtCondTypeThen : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StmtCondTypeThen Statements Sqlserver.Showplan.StmtBlockType
            return state;
        }
    }
    public partial class StmtCursorType : BaseStmtInfoType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StmtCursorType CursorPlan Sqlserver.Showplan.CursorPlanType
            // BaseStmtInfoType StatementSetOptions Sqlserver.Showplan.SetOptionsType
            // BaseStmtInfoType StatementCompId System.Int32
            // BaseStmtInfoType StatementCompIdSpecified System.Boolean
            // BaseStmtInfoType StatementEstRows System.Double
            // BaseStmtInfoType StatementEstRowsSpecified System.Boolean
            // BaseStmtInfoType StatementId System.Int32
            // BaseStmtInfoType StatementIdSpecified System.Boolean
            // BaseStmtInfoType StatementOptmLevel System.String
            // BaseStmtInfoType StatementOptmEarlyAbortReason Sqlserver.Showplan.BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // BaseStmtInfoType StatementOptmEarlyAbortReasonSpecified System.Boolean
            // BaseStmtInfoType CardinalityEstimationModelVersion System.String
            // BaseStmtInfoType StatementSubTreeCost System.Double
            // BaseStmtInfoType StatementSubTreeCostSpecified System.Boolean
            // BaseStmtInfoType StatementText System.String
            // BaseStmtInfoType StatementType System.String
            // BaseStmtInfoType TemplatePlanGuideDB System.String
            // BaseStmtInfoType TemplatePlanGuideName System.String
            // BaseStmtInfoType PlanGuideDB System.String
            // BaseStmtInfoType PlanGuideName System.String
            // BaseStmtInfoType ParameterizedText System.String
            // BaseStmtInfoType ParameterizedPlanHandle System.String
            // BaseStmtInfoType QueryHash System.String
            // BaseStmtInfoType QueryPlanHash System.String
            // BaseStmtInfoType RetrievedFromCache System.String
            // BaseStmtInfoType StatementSqlHandle System.String
            // BaseStmtInfoType DatabaseContextSettingsId System.UInt64
            // BaseStmtInfoType DatabaseContextSettingsIdSpecified System.Boolean
            // BaseStmtInfoType ParentObjectId System.UInt64
            // BaseStmtInfoType ParentObjectIdSpecified System.Boolean
            // BaseStmtInfoType BatchSqlHandle System.String
            // BaseStmtInfoType StatementParameterizationType System.Int32
            // BaseStmtInfoType StatementParameterizationTypeSpecified System.Boolean
            // BaseStmtInfoType SecurityPolicyApplied System.Boolean
            // BaseStmtInfoType SecurityPolicyAppliedSpecified System.Boolean
            return state;
        }
    }
    public partial class StmtReceiveType : BaseStmtInfoType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StmtReceiveType ReceivePlan System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ReceivePlanTypeOperation]
            // BaseStmtInfoType StatementSetOptions Sqlserver.Showplan.SetOptionsType
            // BaseStmtInfoType StatementCompId System.Int32
            // BaseStmtInfoType StatementCompIdSpecified System.Boolean
            // BaseStmtInfoType StatementEstRows System.Double
            // BaseStmtInfoType StatementEstRowsSpecified System.Boolean
            // BaseStmtInfoType StatementId System.Int32
            // BaseStmtInfoType StatementIdSpecified System.Boolean
            // BaseStmtInfoType StatementOptmLevel System.String
            // BaseStmtInfoType StatementOptmEarlyAbortReason Sqlserver.Showplan.BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // BaseStmtInfoType StatementOptmEarlyAbortReasonSpecified System.Boolean
            // BaseStmtInfoType CardinalityEstimationModelVersion System.String
            // BaseStmtInfoType StatementSubTreeCost System.Double
            // BaseStmtInfoType StatementSubTreeCostSpecified System.Boolean
            // BaseStmtInfoType StatementText System.String
            // BaseStmtInfoType StatementType System.String
            // BaseStmtInfoType TemplatePlanGuideDB System.String
            // BaseStmtInfoType TemplatePlanGuideName System.String
            // BaseStmtInfoType PlanGuideDB System.String
            // BaseStmtInfoType PlanGuideName System.String
            // BaseStmtInfoType ParameterizedText System.String
            // BaseStmtInfoType ParameterizedPlanHandle System.String
            // BaseStmtInfoType QueryHash System.String
            // BaseStmtInfoType QueryPlanHash System.String
            // BaseStmtInfoType RetrievedFromCache System.String
            // BaseStmtInfoType StatementSqlHandle System.String
            // BaseStmtInfoType DatabaseContextSettingsId System.UInt64
            // BaseStmtInfoType DatabaseContextSettingsIdSpecified System.Boolean
            // BaseStmtInfoType ParentObjectId System.UInt64
            // BaseStmtInfoType ParentObjectIdSpecified System.Boolean
            // BaseStmtInfoType BatchSqlHandle System.String
            // BaseStmtInfoType StatementParameterizationType System.Int32
            // BaseStmtInfoType StatementParameterizationTypeSpecified System.Boolean
            // BaseStmtInfoType SecurityPolicyApplied System.Boolean
            // BaseStmtInfoType SecurityPolicyAppliedSpecified System.Boolean
            return state;
        }
    }
    public partial class StmtSimpleType : BaseStmtInfoType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StmtSimpleType QueryPlan Sqlserver.Showplan.QueryPlanType
            // StmtSimpleType UDF System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.FunctionType]
            // StmtSimpleType UDFSpecified System.Boolean
            // StmtSimpleType StoredProc Sqlserver.Showplan.FunctionType
            // BaseStmtInfoType StatementSetOptions Sqlserver.Showplan.SetOptionsType
            // BaseStmtInfoType StatementCompId System.Int32
            // BaseStmtInfoType StatementCompIdSpecified System.Boolean
            // BaseStmtInfoType StatementEstRows System.Double
            // BaseStmtInfoType StatementEstRowsSpecified System.Boolean
            // BaseStmtInfoType StatementId System.Int32
            // BaseStmtInfoType StatementIdSpecified System.Boolean
            // BaseStmtInfoType StatementOptmLevel System.String
            // BaseStmtInfoType StatementOptmEarlyAbortReason Sqlserver.Showplan.BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // BaseStmtInfoType StatementOptmEarlyAbortReasonSpecified System.Boolean
            // BaseStmtInfoType CardinalityEstimationModelVersion System.String
            // BaseStmtInfoType StatementSubTreeCost System.Double
            // BaseStmtInfoType StatementSubTreeCostSpecified System.Boolean
            // BaseStmtInfoType StatementText System.String
            // BaseStmtInfoType StatementType System.String
            // BaseStmtInfoType TemplatePlanGuideDB System.String
            // BaseStmtInfoType TemplatePlanGuideName System.String
            // BaseStmtInfoType PlanGuideDB System.String
            // BaseStmtInfoType PlanGuideName System.String
            // BaseStmtInfoType ParameterizedText System.String
            // BaseStmtInfoType ParameterizedPlanHandle System.String
            // BaseStmtInfoType QueryHash System.String
            // BaseStmtInfoType QueryPlanHash System.String
            // BaseStmtInfoType RetrievedFromCache System.String
            // BaseStmtInfoType StatementSqlHandle System.String
            // BaseStmtInfoType DatabaseContextSettingsId System.UInt64
            // BaseStmtInfoType DatabaseContextSettingsIdSpecified System.Boolean
            // BaseStmtInfoType ParentObjectId System.UInt64
            // BaseStmtInfoType ParentObjectIdSpecified System.Boolean
            // BaseStmtInfoType BatchSqlHandle System.String
            // BaseStmtInfoType StatementParameterizationType System.Int32
            // BaseStmtInfoType StatementParameterizationTypeSpecified System.Boolean
            // BaseStmtInfoType SecurityPolicyApplied System.Boolean
            // BaseStmtInfoType SecurityPolicyAppliedSpecified System.Boolean
            return state;
        }
    }
    public partial class StmtUseDbType : BaseStmtInfoType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StmtUseDbType Database System.String
            // BaseStmtInfoType StatementSetOptions Sqlserver.Showplan.SetOptionsType
            // BaseStmtInfoType StatementCompId System.Int32
            // BaseStmtInfoType StatementCompIdSpecified System.Boolean
            // BaseStmtInfoType StatementEstRows System.Double
            // BaseStmtInfoType StatementEstRowsSpecified System.Boolean
            // BaseStmtInfoType StatementId System.Int32
            // BaseStmtInfoType StatementIdSpecified System.Boolean
            // BaseStmtInfoType StatementOptmLevel System.String
            // BaseStmtInfoType StatementOptmEarlyAbortReason Sqlserver.Showplan.BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // BaseStmtInfoType StatementOptmEarlyAbortReasonSpecified System.Boolean
            // BaseStmtInfoType CardinalityEstimationModelVersion System.String
            // BaseStmtInfoType StatementSubTreeCost System.Double
            // BaseStmtInfoType StatementSubTreeCostSpecified System.Boolean
            // BaseStmtInfoType StatementText System.String
            // BaseStmtInfoType StatementType System.String
            // BaseStmtInfoType TemplatePlanGuideDB System.String
            // BaseStmtInfoType TemplatePlanGuideName System.String
            // BaseStmtInfoType PlanGuideDB System.String
            // BaseStmtInfoType PlanGuideName System.String
            // BaseStmtInfoType ParameterizedText System.String
            // BaseStmtInfoType ParameterizedPlanHandle System.String
            // BaseStmtInfoType QueryHash System.String
            // BaseStmtInfoType QueryPlanHash System.String
            // BaseStmtInfoType RetrievedFromCache System.String
            // BaseStmtInfoType StatementSqlHandle System.String
            // BaseStmtInfoType DatabaseContextSettingsId System.UInt64
            // BaseStmtInfoType DatabaseContextSettingsIdSpecified System.Boolean
            // BaseStmtInfoType ParentObjectId System.UInt64
            // BaseStmtInfoType ParentObjectIdSpecified System.Boolean
            // BaseStmtInfoType BatchSqlHandle System.String
            // BaseStmtInfoType StatementParameterizationType System.Int32
            // BaseStmtInfoType StatementParameterizationTypeSpecified System.Boolean
            // BaseStmtInfoType SecurityPolicyApplied System.Boolean
            // BaseStmtInfoType SecurityPolicyAppliedSpecified System.Boolean
            return state;
        }
    }
    public partial class StreamAggregateType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // StreamAggregateType GroupBy System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // StreamAggregateType GroupBySpecified System.Boolean
            // StreamAggregateType RollupInfo Sqlserver.Showplan.RollupInfoType
            // StreamAggregateType RelOp Sqlserver.Showplan.RelOpType
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class SubqueryType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SubqueryType ScalarOperator Sqlserver.Showplan.ScalarType
            // SubqueryType RelOp Sqlserver.Showplan.RelOpType
            // SubqueryType Operation Sqlserver.Showplan.SubqueryOperationType
            return state;
        }
    }
    public partial class SwitchType : ConcatType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // SwitchType Predicate Sqlserver.Showplan.ScalarExpressionType
            // ConcatType RelOp System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.RelOpType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class TableScanType : RowsetType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // TableScanType Predicate Sqlserver.Showplan.ScalarExpressionType
            // TableScanType PartitionId Sqlserver.Showplan.SingleColumnReferenceType
            // TableScanType IndexedViewInfo System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // TableScanType IndexedViewInfoSpecified System.Boolean
            // TableScanType Ordered System.Boolean
            // TableScanType ForcedIndex System.Boolean
            // TableScanType ForcedIndexSpecified System.Boolean
            // TableScanType ForceScan System.Boolean
            // TableScanType ForceScanSpecified System.Boolean
            // TableScanType NoExpandHint System.Boolean
            // TableScanType NoExpandHintSpecified System.Boolean
            // TableScanType Storage Sqlserver.Showplan.StorageType
            // TableScanType StorageSpecified System.Boolean
            // RowsetType Object System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class TableValuedFunctionType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // TableValuedFunctionType Object Sqlserver.Showplan.ObjectType
            // TableValuedFunctionType Predicate Sqlserver.Showplan.ScalarExpressionType
            // TableValuedFunctionType RelOp Sqlserver.Showplan.RelOpType
            // TableValuedFunctionType ParameterList System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // TableValuedFunctionType ParameterListSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class ThreadReservationType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ThreadReservationType NodeId System.Int32
            // ThreadReservationType ReservedThreads System.Int32
            return state;
        }
    }
    public partial class ThreadStatType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // ThreadStatType ThreadReservation System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ThreadReservationType]
            // ThreadStatType ThreadReservationSpecified System.Boolean
            // ThreadStatType Branches System.Int32
            // ThreadStatType UsedThreads System.Int32
            // ThreadStatType UsedThreadsSpecified System.Boolean
            return state;
        }
    }
    public partial class TopSortType : SortType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // TopSortType Rows System.Int32
            // TopSortType WithTies System.Boolean
            // TopSortType WithTiesSpecified System.Boolean
            // SortType OrderBy System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.OrderByTypeOrderByColumn]
            // SortType PartitionId Sqlserver.Showplan.SingleColumnReferenceType
            // SortType RelOp Sqlserver.Showplan.RelOpType
            // SortType Distinct System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class TopType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // TopType TieColumns System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // TopType TieColumnsSpecified System.Boolean
            // TopType OffsetExpression Sqlserver.Showplan.ScalarExpressionType
            // TopType TopExpression Sqlserver.Showplan.ScalarExpressionType
            // TopType RelOp Sqlserver.Showplan.RelOpType
            // TopType RowCount System.Boolean
            // TopType RowCountSpecified System.Boolean
            // TopType Rows System.Int32
            // TopType RowsSpecified System.Boolean
            // TopType IsPercent System.Boolean
            // TopType IsPercentSpecified System.Boolean
            // TopType WithTies System.Boolean
            // TopType WithTiesSpecified System.Boolean
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class TraceFlagListType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // TraceFlagListType TraceFlag System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.TraceFlagType]
            // TraceFlagListType IsCompileTime System.Boolean
            return state;
        }
    }
    public partial class TraceFlagType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // TraceFlagType Value System.UInt64
            // TraceFlagType Scope Sqlserver.Showplan.TraceFlagScopeType
            return state;
        }
    }
    public partial class UDAggregateType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // UDAggregateType UDAggObject Sqlserver.Showplan.ObjectType
            // UDAggregateType ScalarOperator System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // UDAggregateType ScalarOperatorSpecified System.Boolean
            // UDAggregateType Distinct System.Boolean
            return state;
        }
    }
    public partial class UDFType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // UDFType ScalarOperator System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // UDFType ScalarOperatorSpecified System.Boolean
            // UDFType CLRFunction Sqlserver.Showplan.CLRFunctionType
            // UDFType FunctionName System.String
            // UDFType IsClrFunction System.Boolean
            // UDFType IsClrFunctionSpecified System.Boolean
            return state;
        }
    }
    public partial class UDTMethodType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // UDTMethodType CLRFunction Sqlserver.Showplan.CLRFunctionType
            // UDTMethodType ScalarOperator System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ScalarType]
            // UDTMethodType ScalarOperatorSpecified System.Boolean
            return state;
        }
    }
    public partial class UDXType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // UDXType UsedUDXColumns System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceType]
            // UDXType UsedUDXColumnsSpecified System.Boolean
            // UDXType RelOp Sqlserver.Showplan.RelOpType
            // UDXType UDXName System.String
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class UnmatchedIndexesType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // UnmatchedIndexesType Parameterization System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            return state;
        }
    }
    public partial class UpdateType : RowsetType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // UpdateType SetPredicate System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SetPredicateElementType]
            // UpdateType SetPredicateSpecified System.Boolean
            // UpdateType ProbeColumn Sqlserver.Showplan.SingleColumnReferenceType
            // UpdateType ActionColumn Sqlserver.Showplan.SingleColumnReferenceType
            // UpdateType OriginalActionColumn Sqlserver.Showplan.SingleColumnReferenceType
            // UpdateType RelOp Sqlserver.Showplan.RelOpType
            // UpdateType WithOrderedPrefetch System.Boolean
            // UpdateType WithOrderedPrefetchSpecified System.Boolean
            // UpdateType WithUnorderedPrefetch System.Boolean
            // UpdateType WithUnorderedPrefetchSpecified System.Boolean
            // UpdateType DMLRequestSort System.Boolean
            // UpdateType DMLRequestSortSpecified System.Boolean
            // RowsetType Object System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ObjectType]
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class WaitStatListType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // WaitStatListType Wait System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.WaitStatType]
            // WaitStatListType WaitSpecified System.Boolean
            return state;
        }
    }
    public partial class WaitStatType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // WaitStatType WaitType System.String
            // WaitStatType WaitTimeMs System.UInt64
            // WaitStatType WaitCount System.UInt64
            return state;
        }
    }
    public partial class WaitWarningType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // WaitWarningType WaitType Sqlserver.Showplan.WaitWarningTypeWaitType
            // WaitWarningType WaitTime System.UInt64
            // WaitWarningType WaitTimeSpecified System.Boolean
            return state;
        }
    }
    public partial class WarningsType : ShowPlanBase {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // WarningsType ColumnsWithNoStatistics System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.ColumnReferenceListType]
            // WarningsType ColumnsWithNoStatisticsSpecified System.Boolean
            // WarningsType SpillToTempDb System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SpillToTempDbType]
            // WarningsType SpillToTempDbSpecified System.Boolean
            // WarningsType Wait System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.WaitWarningType]
            // WarningsType WaitSpecified System.Boolean
            // WarningsType PlanAffectingConvert System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.AffectingConvertWarningType]
            // WarningsType PlanAffectingConvertSpecified System.Boolean
            // WarningsType SortSpillDetails System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.SortSpillDetailsType]
            // WarningsType SortSpillDetailsSpecified System.Boolean
            // WarningsType HashSpillDetails System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.HashSpillDetailsType]
            // WarningsType HashSpillDetailsSpecified System.Boolean
            // WarningsType MemoryGrantWarning System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.MemoryGrantWarningInfo]
            // WarningsType MemoryGrantWarningSpecified System.Boolean
            // WarningsType NoJoinPredicate System.Boolean
            // WarningsType NoJoinPredicateSpecified System.Boolean
            // WarningsType SpatialGuess System.Boolean
            // WarningsType SpatialGuessSpecified System.Boolean
            // WarningsType UnmatchedIndexes System.Boolean
            // WarningsType UnmatchedIndexesSpecified System.Boolean
            // WarningsType FullUpdateForOnlineIndexBuild System.Boolean
            // WarningsType FullUpdateForOnlineIndexBuildSpecified System.Boolean
            return state;
        }
    }
    public partial class WindowAggregateType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // WindowAggregateType RelOp Sqlserver.Showplan.RelOpType
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
    public partial class WindowType : RelOpBaseType {
        public override T Accept<T>(Visitor<T> visitor, T state) => visitor.Visit(this, state);
        public override T AcceptExplicit<T>(Visitor<T> visitor, T state) {
            state = visitor.Enter(this, state);
            state = visitor.VisitExplicit(this, state);
            return visitor.Exit(this, state);
        }
        public override T AcceptChildren<T>(Visitor<T> visitor, T state) {
            // WindowType RelOp Sqlserver.Showplan.RelOpType
            // RelOpBaseType DefinedValues System.Collections.ObjectModel.Collection`1[Sqlserver.Showplan.DefinedValuesListTypeDefinedValue]
            // RelOpBaseType DefinedValuesSpecified System.Boolean
            // RelOpBaseType InternalInfo Sqlserver.Showplan.InternalInfoType
            return state;
        }
    }
}
