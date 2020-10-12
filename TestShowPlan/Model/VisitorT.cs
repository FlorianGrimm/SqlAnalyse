﻿namespace Sqlserver.Showplan {
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    public class Visitor<T> {
        public virtual T Enter(ShowPlanBase node, T state) => state;
        public virtual T Visit(ShowPlanBase node, T state) => state;
        public virtual T VisitExplicit(ShowPlanBase node, T state) => state;
        public virtual T Exit(ShowPlanBase node, T state) => state;
        public virtual T Visit(AdaptiveJoinType node, T state) => node.Accept(this, state);
        public virtual T Visit(AffectingConvertWarningType node, T state) => node.Accept(this, state);
        public virtual T Visit(AggregateType node, T state) => node.Accept(this, state);
        public virtual T Visit(ArithmeticType node, T state) => node.Accept(this, state);
        public virtual T Visit(AssignType node, T state) => node.Accept(this, state);
        public virtual T Visit(BaseStmtInfoType node, T state) => node.Accept(this, state);
        public virtual T Visit(BatchHashTableBuildType node, T state) => node.Accept(this, state);
        public virtual T Visit(BitmapType node, T state) => node.Accept(this, state);
        public virtual T Visit(CLRFunctionType node, T state) => node.Accept(this, state);
        public virtual T Visit(CollapseType node, T state) => node.Accept(this, state);
        public virtual T Visit(ColumnGroupType node, T state) => node.Accept(this, state);
        public virtual T Visit(ColumnReferenceListType node, T state) => node.Accept(this, state);
        public virtual T Visit(ColumnReferenceType node, T state) => node.Accept(this, state);
        public virtual T Visit(ColumnType node, T state) => node.Accept(this, state);
        public virtual T Visit(CompareType node, T state) => node.Accept(this, state);
        public virtual T Visit(ComputeScalarType node, T state) => node.Accept(this, state);
        public virtual T Visit(ConcatType node, T state) => node.Accept(this, state);
        public virtual T Visit(ConditionalType node, T state) => node.Accept(this, state);
        public virtual T Visit(ConstantScanType node, T state) => node.Accept(this, state);
        public virtual T Visit(ConstantScanTypeValues node, T state) => node.Accept(this, state);
        public virtual T Visit(ConstType node, T state) => node.Accept(this, state);
        public virtual T Visit(ConvertType node, T state) => node.Accept(this, state);
        public virtual T Visit(CreateIndexType node, T state) => node.Accept(this, state);
        public virtual T Visit(CursorPlanType node, T state) => node.Accept(this, state);
        public virtual T Visit(CursorPlanTypeOperation node, T state) => node.Accept(this, state);
        public virtual T Visit(DefinedValuesListType node, T state) => node.Accept(this, state);
        public virtual T Visit(DefinedValuesListTypeDefinedValue node, T state) => node.Accept(this, state);
        public virtual T Visit(DefinedValuesListTypeDefinedValueValueVector node, T state) => node.Accept(this, state);
        public virtual T Visit(FilterType node, T state) => node.Accept(this, state);
        public virtual T Visit(ForeignKeyReferenceCheckType node, T state) => node.Accept(this, state);
        public virtual T Visit(ForeignKeyReferencesCheckType node, T state) => node.Accept(this, state);
        public virtual T Visit(FunctionType node, T state) => node.Accept(this, state);
        public virtual T Visit(GenericType node, T state) => node.Accept(this, state);
        public virtual T Visit(GuessedSelectivityType node, T state) => node.Accept(this, state);
        public virtual T Visit(HashSpillDetailsType node, T state) => node.Accept(this, state);
        public virtual T Visit(HashType node, T state) => node.Accept(this, state);
        public virtual T Visit(IdentType node, T state) => node.Accept(this, state);
        public virtual T Visit(IndexedViewInfoType node, T state) => node.Accept(this, state);
        public virtual T Visit(IndexScanType node, T state) => node.Accept(this, state);
        public virtual T Visit(InternalInfoType node, T state) => node.Accept(this, state);
        public virtual T Visit(IntrinsicType node, T state) => node.Accept(this, state);
        public virtual T Visit(LogicalType node, T state) => node.Accept(this, state);
        public virtual T Visit(MemoryFractionsType node, T state) => node.Accept(this, state);
        public virtual T Visit(MemoryGrantType node, T state) => node.Accept(this, state);
        public virtual T Visit(MemoryGrantWarningInfo node, T state) => node.Accept(this, state);
        public virtual T Visit(MergeType node, T state) => node.Accept(this, state);
        public virtual T Visit(MissingIndexesType node, T state) => node.Accept(this, state);
        public virtual T Visit(MissingIndexGroupType node, T state) => node.Accept(this, state);
        public virtual T Visit(MissingIndexType node, T state) => node.Accept(this, state);
        public virtual T Visit(MultAssignType node, T state) => node.Accept(this, state);
        public virtual T Visit(NestedLoopsType node, T state) => node.Accept(this, state);
        public virtual T Visit(ObjectType node, T state) => node.Accept(this, state);
        public virtual T Visit(OptimizerHardwareDependentPropertiesType node, T state) => node.Accept(this, state);
        public virtual T Visit(OptimizerStatsUsageType node, T state) => node.Accept(this, state);
        public virtual T Visit(OrderByType node, T state) => node.Accept(this, state);
        public virtual T Visit(OrderByTypeOrderByColumn node, T state) => node.Accept(this, state);
        public virtual T Visit(ParallelismType node, T state) => node.Accept(this, state);
        public virtual T Visit(ParallelismTypeActivation node, T state) => node.Accept(this, state);
        public virtual T Visit(ParallelismTypeBrickRouting node, T state) => node.Accept(this, state);
        public virtual T Visit(ParameterizationType node, T state) => node.Accept(this, state);
        public virtual T Visit(PutType node, T state) => node.Accept(this, state);
        public virtual T Visit(QueryExecTimeType node, T state) => node.Accept(this, state);
        public virtual T Visit(QueryPlanType node, T state) => node.Accept(this, state);
        public virtual T Visit(ReceivePlanType node, T state) => node.Accept(this, state);
        public virtual T Visit(ReceivePlanTypeOperation node, T state) => node.Accept(this, state);
        public virtual T Visit(RelOpBaseType node, T state) => node.Accept(this, state);
        public virtual T Visit(RelOpType node, T state) => node.Accept(this, state);
        public virtual T Visit(RemoteFetchType node, T state) => node.Accept(this, state);
        public virtual T Visit(RemoteModifyType node, T state) => node.Accept(this, state);
        public virtual T Visit(RemoteQueryType node, T state) => node.Accept(this, state);
        public virtual T Visit(RemoteRangeType node, T state) => node.Accept(this, state);
        public virtual T Visit(RemoteType node, T state) => node.Accept(this, state);
        public virtual T Visit(RollupInfoType node, T state) => node.Accept(this, state);
        public virtual T Visit(RollupLevelType node, T state) => node.Accept(this, state);
        public virtual T Visit(RowsetType node, T state) => node.Accept(this, state);
        public virtual T Visit(RunTimeInformationType node, T state) => node.Accept(this, state);
        public virtual T Visit(RunTimeInformationTypeRunTimeCountersPerThread node, T state) => node.Accept(this, state);
        public virtual T Visit(RunTimePartitionSummaryType node, T state) => node.Accept(this, state);
        public virtual T Visit(RunTimePartitionSummaryTypePartitionsAccessed node, T state) => node.Accept(this, state);
        public virtual T Visit(RunTimePartitionSummaryTypePartitionsAccessedPartitionRange node, T state) => node.Accept(this, state);
        public virtual T Visit(ScalarExpressionListType node, T state) => node.Accept(this, state);
        public virtual T Visit(ScalarExpressionType node, T state) => node.Accept(this, state);
        public virtual T Visit(ScalarInsertType node, T state) => node.Accept(this, state);
        public virtual T Visit(ScalarSequenceType node, T state) => node.Accept(this, state);
        public virtual T Visit(ScalarType node, T state) => node.Accept(this, state);
        public virtual T Visit(ScanRangeType node, T state) => node.Accept(this, state);
        public virtual T Visit(SeekPredicateNewType node, T state) => node.Accept(this, state);
        public virtual T Visit(SeekPredicatePartType node, T state) => node.Accept(this, state);
        public virtual T Visit(SeekPredicatesType node, T state) => node.Accept(this, state);
        public virtual T Visit(SeekPredicateType node, T state) => node.Accept(this, state);
        public virtual T Visit(SegmentType node, T state) => node.Accept(this, state);
        public virtual T Visit(SequenceType node, T state) => node.Accept(this, state);
        public virtual T Visit(SetOptionsType node, T state) => node.Accept(this, state);
        public virtual T Visit(SetPredicateElementType node, T state) => node.Accept(this, state);
        public virtual T Visit(ShowPlanXML node, T state) => node.Accept(this, state);
        public virtual T Visit(ShowPlanXMLBatchSequence node, T state) => node.Accept(this, state);
        public virtual T Visit(ShowPlanXMLBatchSequenceBatch node, T state) => node.Accept(this, state);
        public virtual T Visit(SimpleIteratorOneChildType node, T state) => node.Accept(this, state);
        public virtual T Visit(SimpleUpdateType node, T state) => node.Accept(this, state);
        public virtual T Visit(SingleColumnReferenceType node, T state) => node.Accept(this, state);
        public virtual T Visit(SortSpillDetailsType node, T state) => node.Accept(this, state);
        public virtual T Visit(SortType node, T state) => node.Accept(this, state);
        public virtual T Visit(SpillToTempDbType node, T state) => node.Accept(this, state);
        public virtual T Visit(SplitType node, T state) => node.Accept(this, state);
        public virtual T Visit(SpoolType node, T state) => node.Accept(this, state);
        public virtual T Visit(StarJoinInfoType node, T state) => node.Accept(this, state);
        public virtual T Visit(StatsInfoType node, T state) => node.Accept(this, state);
        public virtual T Visit(StmtBlockType node, T state) => node.Accept(this, state);
        public virtual T Visit(StmtCondType node, T state) => node.Accept(this, state);
        public virtual T Visit(StmtCondTypeCondition node, T state) => node.Accept(this, state);
        public virtual T Visit(StmtCondTypeElse node, T state) => node.Accept(this, state);
        public virtual T Visit(StmtCondTypeThen node, T state) => node.Accept(this, state);
        public virtual T Visit(StmtCursorType node, T state) => node.Accept(this, state);
        public virtual T Visit(StmtReceiveType node, T state) => node.Accept(this, state);
        public virtual T Visit(StmtSimpleType node, T state) => node.Accept(this, state);
        public virtual T Visit(StmtUseDbType node, T state) => node.Accept(this, state);
        public virtual T Visit(StreamAggregateType node, T state) => node.Accept(this, state);
        public virtual T Visit(SubqueryType node, T state) => node.Accept(this, state);
        public virtual T Visit(SwitchType node, T state) => node.Accept(this, state);
        public virtual T Visit(TableScanType node, T state) => node.Accept(this, state);
        public virtual T Visit(TableValuedFunctionType node, T state) => node.Accept(this, state);
        public virtual T Visit(ThreadReservationType node, T state) => node.Accept(this, state);
        public virtual T Visit(ThreadStatType node, T state) => node.Accept(this, state);
        public virtual T Visit(TopSortType node, T state) => node.Accept(this, state);
        public virtual T Visit(TopType node, T state) => node.Accept(this, state);
        public virtual T Visit(TraceFlagListType node, T state) => node.Accept(this, state);
        public virtual T Visit(TraceFlagType node, T state) => node.Accept(this, state);
        public virtual T Visit(UDAggregateType node, T state) => node.Accept(this, state);
        public virtual T Visit(UDFType node, T state) => node.Accept(this, state);
        public virtual T Visit(UDTMethodType node, T state) => node.Accept(this, state);
        public virtual T Visit(UDXType node, T state) => node.Accept(this, state);
        public virtual T Visit(UnmatchedIndexesType node, T state) => node.Accept(this, state);
        public virtual T Visit(UpdateType node, T state) => node.Accept(this, state);
        public virtual T Visit(WaitStatListType node, T state) => node.Accept(this, state);
        public virtual T Visit(WaitStatType node, T state) => node.Accept(this, state);
        public virtual T Visit(WaitWarningType node, T state) => node.Accept(this, state);
        public virtual T Visit(WarningsType node, T state) => node.Accept(this, state);
        public virtual T Visit(WindowAggregateType node, T state) => node.Accept(this, state);
        public virtual T Visit(WindowType node, T state) => node.Accept(this, state);

        public virtual T VisitExplicit(AdaptiveJoinType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(AffectingConvertWarningType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(AggregateType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ArithmeticType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(AssignType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(BaseStmtInfoType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(BatchHashTableBuildType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(BitmapType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(CLRFunctionType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(CollapseType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ColumnGroupType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ColumnReferenceListType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ColumnReferenceType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ColumnType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(CompareType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ComputeScalarType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ConcatType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ConditionalType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ConstantScanType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ConstantScanTypeValues node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ConstType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ConvertType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(CreateIndexType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(CursorPlanType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(CursorPlanTypeOperation node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(DefinedValuesListType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(DefinedValuesListTypeDefinedValue node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(DefinedValuesListTypeDefinedValueValueVector node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(FilterType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ForeignKeyReferenceCheckType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ForeignKeyReferencesCheckType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(FunctionType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(GenericType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(GuessedSelectivityType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(HashSpillDetailsType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(HashType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(IdentType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(IndexedViewInfoType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(IndexScanType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(InternalInfoType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(IntrinsicType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(LogicalType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(MemoryFractionsType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(MemoryGrantType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(MemoryGrantWarningInfo node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(MergeType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(MissingIndexesType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(MissingIndexGroupType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(MissingIndexType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(MultAssignType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(NestedLoopsType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ObjectType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(OptimizerHardwareDependentPropertiesType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(OptimizerStatsUsageType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(OrderByType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(OrderByTypeOrderByColumn node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ParallelismType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ParallelismTypeActivation node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ParallelismTypeBrickRouting node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ParameterizationType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(PutType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(QueryExecTimeType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(QueryPlanType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ReceivePlanType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ReceivePlanTypeOperation node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RelOpBaseType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RelOpType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RemoteFetchType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RemoteModifyType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RemoteQueryType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RemoteRangeType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RemoteType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RollupInfoType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RollupLevelType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RowsetType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RunTimeInformationType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RunTimeInformationTypeRunTimeCountersPerThread node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RunTimePartitionSummaryType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RunTimePartitionSummaryTypePartitionsAccessed node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(RunTimePartitionSummaryTypePartitionsAccessedPartitionRange node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ScalarExpressionListType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ScalarExpressionType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ScalarInsertType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ScalarSequenceType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ScalarType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ScanRangeType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SeekPredicateNewType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SeekPredicatePartType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SeekPredicatesType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SeekPredicateType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SegmentType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SequenceType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SetOptionsType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SetPredicateElementType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ShowPlanXML node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ShowPlanXMLBatchSequence node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ShowPlanXMLBatchSequenceBatch node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SimpleIteratorOneChildType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SimpleUpdateType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SingleColumnReferenceType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SortSpillDetailsType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SortType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SpillToTempDbType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SplitType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SpoolType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StarJoinInfoType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StatsInfoType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StmtBlockType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StmtCondType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StmtCondTypeCondition node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StmtCondTypeElse node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StmtCondTypeThen node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StmtCursorType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StmtReceiveType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StmtSimpleType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StmtUseDbType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(StreamAggregateType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SubqueryType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(SwitchType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(TableScanType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(TableValuedFunctionType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ThreadReservationType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(ThreadStatType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(TopSortType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(TopType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(TraceFlagListType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(TraceFlagType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(UDAggregateType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(UDFType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(UDTMethodType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(UDXType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(UnmatchedIndexesType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(UpdateType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(WaitStatListType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(WaitStatType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(WaitWarningType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(WarningsType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(WindowAggregateType node, T state) => node.AcceptChildren(this, state);
        public virtual T VisitExplicit(WindowType node, T state) => node.AcceptChildren<T>(this, state);
    }

    public partial class ShowPlanBase {
        public virtual T Accept<T>(Visitor<T> visitor, T state) => state;
        public virtual T AcceptExplicit<T>(Visitor<T> visitor, T state) => state;
        public virtual T AcceptChildren<T>(Visitor<T> visitor, T state) => state;
    }
}

