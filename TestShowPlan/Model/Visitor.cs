#if no
namespace Sqlserver.Showplan {
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    public class Visitor {
        public virtual void Enter(ShowPlanBase node) { }
        public virtual void Visit(ShowPlanBase node) { }
        public virtual void VisitExplicit(ShowPlanBase node) { }
        public virtual void Exit(ShowPlanBase node) { }
        public virtual void Visit(AdaptiveJoinType node) { node.AcceptExplicit(this); }
        public virtual void Visit(AffectingConvertWarningType node) { node.AcceptExplicit(this); }
        public virtual void Visit(AggregateType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ArithmeticType node) { node.AcceptExplicit(this); }
        public virtual void Visit(AssignType node) { node.AcceptExplicit(this); }
        public virtual void Visit(BaseStmtInfoType node) { node.AcceptExplicit(this); }
        public virtual void Visit(BatchHashTableBuildType node) { node.AcceptExplicit(this); }
        public virtual void Visit(BitmapType node) { node.AcceptExplicit(this); }
        public virtual void Visit(CLRFunctionType node) { node.AcceptExplicit(this); }
        public virtual void Visit(CollapseType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ColumnGroupType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ColumnReferenceListType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ColumnReferenceType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ColumnType node) { node.AcceptExplicit(this); }
        public virtual void Visit(CompareType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ComputeScalarType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ConcatType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ConditionalType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ConstantScanType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ConstantScanTypeValues node) { node.AcceptExplicit(this); }
        public virtual void Visit(ConstType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ConvertType node) { node.AcceptExplicit(this); }
        public virtual void Visit(CreateIndexType node) { node.AcceptExplicit(this); }
        public virtual void Visit(CursorPlanType node) { node.AcceptExplicit(this); }
        public virtual void Visit(CursorPlanTypeOperation node) { node.AcceptExplicit(this); }
        public virtual void Visit(DefinedValuesListType node) { node.AcceptExplicit(this); }
        public virtual void Visit(DefinedValuesListTypeDefinedValue node) { node.AcceptExplicit(this); }
        public virtual void Visit(DefinedValuesListTypeDefinedValueValueVector node) { node.AcceptExplicit(this); }
        public virtual void Visit(FilterType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ForeignKeyReferenceCheckType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ForeignKeyReferencesCheckType node) { node.AcceptExplicit(this); }
        public virtual void Visit(FunctionType node) { node.AcceptExplicit(this); }
        public virtual void Visit(GenericType node) { node.AcceptExplicit(this); }
        public virtual void Visit(GuessedSelectivityType node) { node.AcceptExplicit(this); }
        public virtual void Visit(HashSpillDetailsType node) { node.AcceptExplicit(this); }
        public virtual void Visit(HashType node) { node.AcceptExplicit(this); }
        public virtual void Visit(IdentType node) { node.AcceptExplicit(this); }
        public virtual void Visit(IndexedViewInfoType node) { node.AcceptExplicit(this); }
        public virtual void Visit(IndexScanType node) { node.AcceptExplicit(this); }
        public virtual void Visit(InternalInfoType node) { node.AcceptExplicit(this); }
        public virtual void Visit(IntrinsicType node) { node.AcceptExplicit(this); }
        public virtual void Visit(LogicalType node) { node.AcceptExplicit(this); }
        public virtual void Visit(MemoryFractionsType node) { node.AcceptExplicit(this); }
        public virtual void Visit(MemoryGrantType node) { node.AcceptExplicit(this); }
        public virtual void Visit(MemoryGrantWarningInfo node) { node.AcceptExplicit(this); }
        public virtual void Visit(MergeType node) { node.AcceptExplicit(this); }
        public virtual void Visit(MissingIndexesType node) { node.AcceptExplicit(this); }
        public virtual void Visit(MissingIndexGroupType node) { node.AcceptExplicit(this); }
        public virtual void Visit(MissingIndexType node) { node.AcceptExplicit(this); }
        public virtual void Visit(MultAssignType node) { node.AcceptExplicit(this); }
        public virtual void Visit(NestedLoopsType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ObjectType node) { node.AcceptExplicit(this); }
        public virtual void Visit(OptimizerHardwareDependentPropertiesType node) { node.AcceptExplicit(this); }
        public virtual void Visit(OptimizerStatsUsageType node) { node.AcceptExplicit(this); }
        public virtual void Visit(OrderByType node) { node.AcceptExplicit(this); }
        public virtual void Visit(OrderByTypeOrderByColumn node) { node.AcceptExplicit(this); }
        public virtual void Visit(ParallelismType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ParallelismTypeActivation node) { node.AcceptExplicit(this); }
        public virtual void Visit(ParallelismTypeBrickRouting node) { node.AcceptExplicit(this); }
        public virtual void Visit(ParameterizationType node) { node.AcceptExplicit(this); }
        public virtual void Visit(PutType node) { node.AcceptExplicit(this); }
        public virtual void Visit(QueryExecTimeType node) { node.AcceptExplicit(this); }
        public virtual void Visit(QueryPlanType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ReceivePlanType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ReceivePlanTypeOperation node) { node.AcceptExplicit(this); }
        public virtual void Visit(RelOpBaseType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RelOpType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RemoteFetchType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RemoteModifyType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RemoteQueryType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RemoteRangeType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RemoteType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RollupInfoType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RollupLevelType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RowsetType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RunTimeInformationType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RunTimeInformationTypeRunTimeCountersPerThread node) { node.AcceptExplicit(this); }
        public virtual void Visit(RunTimePartitionSummaryType node) { node.AcceptExplicit(this); }
        public virtual void Visit(RunTimePartitionSummaryTypePartitionsAccessed node) { node.AcceptExplicit(this); }
        public virtual void Visit(RunTimePartitionSummaryTypePartitionsAccessedPartitionRange node) { node.AcceptExplicit(this); }
        public virtual void Visit(ScalarExpressionListType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ScalarExpressionType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ScalarInsertType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ScalarSequenceType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ScalarType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ScanRangeType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SeekPredicateNewType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SeekPredicatePartType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SeekPredicatesType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SeekPredicateType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SegmentType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SequenceType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SetOptionsType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SetPredicateElementType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ShowPlanXML node) { node.AcceptExplicit(this); }
        public virtual void Visit(ShowPlanXMLBatchSequence node) { node.AcceptExplicit(this); }
        public virtual void Visit(ShowPlanXMLBatchSequenceBatch node) { node.AcceptExplicit(this); }
        public virtual void Visit(SimpleIteratorOneChildType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SimpleUpdateType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SingleColumnReferenceType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SortSpillDetailsType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SortType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SpillToTempDbType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SplitType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SpoolType node) { node.AcceptExplicit(this); }
        public virtual void Visit(StarJoinInfoType node) { node.AcceptExplicit(this); }
        public virtual void Visit(StatsInfoType node) { node.AcceptExplicit(this); }
        public virtual void Visit(StmtBlockType node) { node.AcceptExplicit(this); }
        public virtual void Visit(StmtCondType node) { node.AcceptExplicit(this); }
        public virtual void Visit(StmtCondTypeCondition node) { node.AcceptExplicit(this); }
        public virtual void Visit(StmtCondTypeElse node) { node.AcceptExplicit(this); }
        public virtual void Visit(StmtCondTypeThen node) { node.AcceptExplicit(this); }
        public virtual void Visit(StmtCursorType node) { node.AcceptExplicit(this); }
        public virtual void Visit(StmtReceiveType node) { node.AcceptExplicit(this); }
        public virtual void Visit(StmtSimpleType node) { node.AcceptExplicit(this); }
        public virtual void Visit(StmtUseDbType node) { node.AcceptExplicit(this); }
        public virtual void Visit(StreamAggregateType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SubqueryType node) { node.AcceptExplicit(this); }
        public virtual void Visit(SwitchType node) { node.AcceptExplicit(this); }
        public virtual void Visit(TableScanType node) { node.AcceptExplicit(this); }
        public virtual void Visit(TableValuedFunctionType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ThreadReservationType node) { node.AcceptExplicit(this); }
        public virtual void Visit(ThreadStatType node) { node.AcceptExplicit(this); }
        public virtual void Visit(TopSortType node) { node.AcceptExplicit(this); }
        public virtual void Visit(TopType node) { node.AcceptExplicit(this); }
        public virtual void Visit(TraceFlagListType node) { node.AcceptExplicit(this); }
        public virtual void Visit(TraceFlagType node) { node.AcceptExplicit(this); }
        public virtual void Visit(UDAggregateType node) { node.AcceptExplicit(this); }
        public virtual void Visit(UDFType node) { node.AcceptExplicit(this); }
        public virtual void Visit(UDTMethodType node) { node.AcceptExplicit(this); }
        public virtual void Visit(UDXType node) { node.AcceptExplicit(this); }
        public virtual void Visit(UnmatchedIndexesType node) { node.AcceptExplicit(this); }
        public virtual void Visit(UpdateType node) { node.AcceptExplicit(this); }
        public virtual void Visit(WaitStatListType node) { node.AcceptExplicit(this); }
        public virtual void Visit(WaitStatType node) { node.AcceptExplicit(this); }
        public virtual void Visit(WaitWarningType node) { node.AcceptExplicit(this); }
        public virtual void Visit(WarningsType node) { node.AcceptExplicit(this); }
        public virtual void Visit(WindowAggregateType node) { node.AcceptExplicit(this); }
        public virtual void Visit(WindowType node) { node.AcceptExplicit(this); }

        public virtual void VisitExplicit(AdaptiveJoinType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(AffectingConvertWarningType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(AggregateType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ArithmeticType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(AssignType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(BaseStmtInfoType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(BatchHashTableBuildType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(BitmapType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(CLRFunctionType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(CollapseType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ColumnGroupType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ColumnReferenceListType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ColumnReferenceType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ColumnType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(CompareType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ComputeScalarType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ConcatType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ConditionalType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ConstantScanType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ConstantScanTypeValues node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ConstType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ConvertType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(CreateIndexType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(CursorPlanType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(CursorPlanTypeOperation node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(DefinedValuesListType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(DefinedValuesListTypeDefinedValue node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(DefinedValuesListTypeDefinedValueValueVector node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(FilterType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ForeignKeyReferenceCheckType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ForeignKeyReferencesCheckType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(FunctionType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(GenericType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(GuessedSelectivityType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(HashSpillDetailsType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(HashType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(IdentType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(IndexedViewInfoType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(IndexScanType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(InternalInfoType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(IntrinsicType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(LogicalType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(MemoryFractionsType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(MemoryGrantType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(MemoryGrantWarningInfo node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(MergeType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(MissingIndexesType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(MissingIndexGroupType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(MissingIndexType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(MultAssignType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(NestedLoopsType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ObjectType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(OptimizerHardwareDependentPropertiesType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(OptimizerStatsUsageType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(OrderByType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(OrderByTypeOrderByColumn node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ParallelismType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ParallelismTypeActivation node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ParallelismTypeBrickRouting node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ParameterizationType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(PutType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(QueryExecTimeType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(QueryPlanType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ReceivePlanType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ReceivePlanTypeOperation node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RelOpBaseType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RelOpType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RemoteFetchType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RemoteModifyType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RemoteQueryType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RemoteRangeType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RemoteType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RollupInfoType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RollupLevelType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RowsetType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RunTimeInformationType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RunTimeInformationTypeRunTimeCountersPerThread node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RunTimePartitionSummaryType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RunTimePartitionSummaryTypePartitionsAccessed node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(RunTimePartitionSummaryTypePartitionsAccessedPartitionRange node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ScalarExpressionListType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ScalarExpressionType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ScalarInsertType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ScalarSequenceType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ScalarType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ScanRangeType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SeekPredicateNewType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SeekPredicatePartType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SeekPredicatesType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SeekPredicateType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SegmentType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SequenceType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SetOptionsType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SetPredicateElementType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ShowPlanXML node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ShowPlanXMLBatchSequence node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ShowPlanXMLBatchSequenceBatch node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SimpleIteratorOneChildType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SimpleUpdateType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SingleColumnReferenceType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SortSpillDetailsType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SortType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SpillToTempDbType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SplitType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SpoolType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StarJoinInfoType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StatsInfoType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StmtBlockType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StmtCondType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StmtCondTypeCondition node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StmtCondTypeElse node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StmtCondTypeThen node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StmtCursorType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StmtReceiveType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StmtSimpleType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StmtUseDbType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(StreamAggregateType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SubqueryType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(SwitchType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(TableScanType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(TableValuedFunctionType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ThreadReservationType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(ThreadStatType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(TopSortType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(TopType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(TraceFlagListType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(TraceFlagType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(UDAggregateType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(UDFType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(UDTMethodType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(UDXType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(UnmatchedIndexesType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(UpdateType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(WaitStatListType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(WaitStatType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(WaitWarningType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(WarningsType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(WindowAggregateType node) { node.AcceptChildren(this); }
        public virtual void VisitExplicit(WindowType node) { node.AcceptChildren(this); }


    }
    public partial class ShowPlanBase {
        public virtual void Accept(Visitor visitor) { }
        public virtual void AcceptExplicit(Visitor visitor) { }
        public virtual void AcceptChildren(Visitor visitor) { }
    }

    public partial class AffectingConvertWarningType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class AggregateType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ArithmeticType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class AssignType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class BaseStmtInfoType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class CLRFunctionType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ColumnGroupType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ColumnReferenceListType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ColumnReferenceType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ColumnType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class CompareType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ConditionalType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ConstantScanTypeValues : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ConstType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ConvertType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class CursorPlanType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class CursorPlanTypeOperation : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class DefinedValuesListType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class DefinedValuesListTypeDefinedValue : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class DefinedValuesListTypeDefinedValueValueVector : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ForeignKeyReferenceCheckType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class FunctionType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class GuessedSelectivityType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class HashSpillDetailsType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class IdentType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class IndexedViewInfoType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class InternalInfoType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class IntrinsicType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class LogicalType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class MemoryFractionsType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class MemoryGrantType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class MemoryGrantWarningInfo : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class MissingIndexesType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class MissingIndexGroupType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class MissingIndexType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class MultAssignType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ObjectType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class OptimizerHardwareDependentPropertiesType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class OptimizerStatsUsageType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class OrderByType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class OrderByTypeOrderByColumn : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ParallelismTypeActivation : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ParallelismTypeBrickRouting : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ParameterizationType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class QueryExecTimeType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class QueryPlanType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ReceivePlanType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ReceivePlanTypeOperation : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RelOpType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RollupInfoType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RollupLevelType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RunTimeInformationType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RunTimeInformationTypeRunTimeCountersPerThread : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RunTimePartitionSummaryType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RunTimePartitionSummaryTypePartitionsAccessed : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RunTimePartitionSummaryTypePartitionsAccessedPartitionRange : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ScalarExpressionListType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ScalarExpressionType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ScalarSequenceType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ScalarType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ScanRangeType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SeekPredicateNewType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SeekPredicatePartType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SeekPredicatesType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SeekPredicateType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SetOptionsType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ShowPlanXML : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ShowPlanXMLBatchSequence : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ShowPlanXMLBatchSequenceBatch : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SingleColumnReferenceType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SortSpillDetailsType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SpillToTempDbType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StarJoinInfoType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StatsInfoType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StmtBlockType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StmtCondTypeCondition : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StmtCondTypeElse : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StmtCondTypeThen : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SubqueryType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ThreadReservationType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ThreadStatType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class TraceFlagListType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class TraceFlagType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class UDAggregateType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class UDFType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class UDTMethodType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class UnmatchedIndexesType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class WaitStatListType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class WaitStatType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class WaitWarningType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class WarningsType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }

    public partial class RelOpBaseType : ShowPlanBase {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class AdaptiveJoinType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class BatchHashTableBuildType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class BitmapType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class CollapseType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ComputeScalarType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ConcatType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ConstantScanType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class FilterType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ForeignKeyReferencesCheckType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class GenericType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class HashType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class MergeType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class NestedLoopsType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ParallelismType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RemoteType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SegmentType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SequenceType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RowsetType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SimpleIteratorOneChildType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SortType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SplitType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SpoolType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StreamAggregateType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class TableValuedFunctionType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class TopType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class UDXType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class WindowAggregateType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class WindowType : RelOpBaseType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }

    public partial class RemoteFetchType : RemoteType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RemoteModifyType : RemoteType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RemoteQueryType : RemoteType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class RemoteRangeType : RemoteType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }

    public partial class CreateIndexType : RowsetType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class IndexScanType : RowsetType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class ScalarInsertType : RowsetType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SimpleUpdateType : RowsetType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class TableScanType : RowsetType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class UpdateType : RowsetType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }

    public partial class StmtCondType : BaseStmtInfoType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StmtCursorType : BaseStmtInfoType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StmtReceiveType : BaseStmtInfoType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StmtSimpleType : BaseStmtInfoType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class StmtUseDbType : BaseStmtInfoType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }

    public partial class SetPredicateElementType : ScalarExpressionType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }

    public partial class PutType : RemoteQueryType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
    public partial class SwitchType : ConcatType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }

    public partial class TopSortType : SortType {
        public override void Accept(Visitor visitor) { visitor.Visit(this); }
        public override void AcceptExplicit(Visitor visitor) { visitor.Enter(this); visitor.VisitExplicit(this); visitor.Exit(this); }
        public override void AcceptChildren(Visitor visitor) { }
    }
}
#endif