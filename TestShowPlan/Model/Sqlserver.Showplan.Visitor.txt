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
            // Collection<> AdaptiveJoinType at 'HashKeysBuild' : ColumnReferenceType
            if (this.HashKeysBuild is object) {
                foreach (ColumnReferenceType item in this.HashKeysBuild) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType AdaptiveJoinType at 'HashKeysBuildSpecified' : Boolean
            // Collection<> AdaptiveJoinType at 'HashKeysProbe' : ColumnReferenceType
            if (this.HashKeysProbe is object) {
                foreach (ColumnReferenceType item in this.HashKeysProbe) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType AdaptiveJoinType at 'HashKeysProbeSpecified' : Boolean
            // ShowPlanBase AdaptiveJoinType at 'BuildResidual' : ScalarExpressionType
            if (BuildResidual is object) { state = visitor.Visit(this.BuildResidual, state); }
            // ShowPlanBase AdaptiveJoinType at 'ProbeResidual' : ScalarExpressionType
            if (ProbeResidual is object) { state = visitor.Visit(this.ProbeResidual, state); }
            // ShowPlanBase AdaptiveJoinType at 'StarJoinInfo' : StarJoinInfoType
            if (StarJoinInfo is object) { state = visitor.Visit(this.StarJoinInfo, state); }
            // ShowPlanBase AdaptiveJoinType at 'Predicate' : ScalarExpressionType
            if (Predicate is object) { state = visitor.Visit(this.Predicate, state); }
            // ShowPlanBase AdaptiveJoinType at 'PassThru' : ScalarExpressionType
            if (PassThru is object) { state = visitor.Visit(this.PassThru, state); }
            // Collection<> AdaptiveJoinType at 'OuterReferences' : ColumnReferenceType
            if (this.OuterReferences is object) {
                foreach (ColumnReferenceType item in this.OuterReferences) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType AdaptiveJoinType at 'OuterReferencesSpecified' : Boolean
            // ShowPlanBase AdaptiveJoinType at 'PartitionId' : SingleColumnReferenceType
            if (PartitionId is object) { state = visitor.Visit(this.PartitionId, state); }
            // Collection<> AdaptiveJoinType at 'RelOp' : RelOpType
            if (this.RelOp is object) {
                foreach (RelOpType item in this.RelOp) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType AdaptiveJoinType at 'BitmapCreator' : Boolean
            // ValueType AdaptiveJoinType at 'BitmapCreatorSpecified' : Boolean
            // ValueType AdaptiveJoinType at 'Optimized' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ValueType AffectingConvertWarningType at 'ConvertIssue' : AffectingConvertWarningTypeConvertIssue
            // String AffectingConvertWarningType at 'Expression' : String
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
            // Collection<> AggregateType at 'ScalarOperator' : ScalarType
            if (this.ScalarOperator is object) {
                foreach (ScalarType item in this.ScalarOperator) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType AggregateType at 'ScalarOperatorSpecified' : Boolean
            // String AggregateType at 'AggType' : String
            // ValueType AggregateType at 'Distinct' : Boolean
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
            // Collection<> ArithmeticType at 'ScalarOperator' : ScalarType
            if (this.ScalarOperator is object) {
                foreach (ScalarType item in this.ScalarOperator) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ArithmeticType at 'Operation' : ArithmeticOperationType
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
            // ShowPlanBase AssignType at 'ColumnReference' : ColumnReferenceType
            if (ColumnReference is object) { state = visitor.Visit(this.ColumnReference, state); }
            // ShowPlanBase AssignType at 'ScalarOperator' : ScalarType
            if (ScalarOperator is object) { state = visitor.Visit(this.ScalarOperator, state); }
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
            // ShowPlanBase BaseStmtInfoType at 'StatementSetOptions' : SetOptionsType
            if (StatementSetOptions is object) { state = visitor.Visit(this.StatementSetOptions, state); }
            // ValueType BaseStmtInfoType at 'StatementCompId' : Int32
            // ValueType BaseStmtInfoType at 'StatementCompIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementEstRows' : Double
            // ValueType BaseStmtInfoType at 'StatementEstRowsSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementId' : Int32
            // ValueType BaseStmtInfoType at 'StatementIdSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementOptmLevel' : String
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReason' : BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReasonSpecified' : Boolean
            // String BaseStmtInfoType at 'CardinalityEstimationModelVersion' : String
            // ValueType BaseStmtInfoType at 'StatementSubTreeCost' : Double
            // ValueType BaseStmtInfoType at 'StatementSubTreeCostSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementText' : String
            // String BaseStmtInfoType at 'StatementType' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideDB' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideName' : String
            // String BaseStmtInfoType at 'PlanGuideDB' : String
            // String BaseStmtInfoType at 'PlanGuideName' : String
            // String BaseStmtInfoType at 'ParameterizedText' : String
            // String BaseStmtInfoType at 'ParameterizedPlanHandle' : String
            // String BaseStmtInfoType at 'QueryHash' : String
            // String BaseStmtInfoType at 'QueryPlanHash' : String
            // String BaseStmtInfoType at 'RetrievedFromCache' : String
            // String BaseStmtInfoType at 'StatementSqlHandle' : String
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsId' : UInt64
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'ParentObjectId' : UInt64
            // ValueType BaseStmtInfoType at 'ParentObjectIdSpecified' : Boolean
            // String BaseStmtInfoType at 'BatchSqlHandle' : String
            // ValueType BaseStmtInfoType at 'StatementParameterizationType' : Int32
            // ValueType BaseStmtInfoType at 'StatementParameterizationTypeSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyApplied' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyAppliedSpecified' : Boolean
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
            // ShowPlanBase BatchHashTableBuildType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ValueType BatchHashTableBuildType at 'BitmapCreator' : Boolean
            // ValueType BatchHashTableBuildType at 'BitmapCreatorSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> BitmapType at 'HashKeys' : ColumnReferenceType
            if (this.HashKeys is object) {
                foreach (ColumnReferenceType item in this.HashKeys) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ShowPlanBase BitmapType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // String CLRFunctionType at 'Assembly' : String
            // String CLRFunctionType at 'Class' : String
            // String CLRFunctionType at 'Method' : String
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
            // Collection<> CollapseType at 'GroupBy' : ColumnReferenceType
            if (this.GroupBy is object) {
                foreach (ColumnReferenceType item in this.GroupBy) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ShowPlanBase CollapseType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> ColumnGroupType at 'Column' : ColumnType
            if (this.Column is object) {
                foreach (ColumnType item in this.Column) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ColumnGroupType at 'Usage' : ColumnGroupTypeUsage
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
            // Collection<> ColumnReferenceListType at 'ColumnReference' : ColumnReferenceType
            if (this.ColumnReference is object) {
                foreach (ColumnReferenceType item in this.ColumnReference) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ColumnReferenceListType at 'ColumnReferenceSpecified' : Boolean
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
            // ShowPlanBase ColumnReferenceType at 'ScalarOperator' : ScalarType
            if (ScalarOperator is object) { state = visitor.Visit(this.ScalarOperator, state); }
            // ShowPlanBase ColumnReferenceType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
            // String ColumnReferenceType at 'Server' : String
            // String ColumnReferenceType at 'Database' : String
            // String ColumnReferenceType at 'Schema' : String
            // String ColumnReferenceType at 'Table' : String
            // String ColumnReferenceType at 'Alias' : String
            // String ColumnReferenceType at 'Column' : String
            // ValueType ColumnReferenceType at 'ComputedColumn' : Boolean
            // ValueType ColumnReferenceType at 'ComputedColumnSpecified' : Boolean
            // String ColumnReferenceType at 'ParameterDataType' : String
            // String ColumnReferenceType at 'ParameterCompiledValue' : String
            // String ColumnReferenceType at 'ParameterRuntimeValue' : String
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
            // String ColumnType at 'Name' : String
            // ValueType ColumnType at 'ColumnId' : Int32
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
            // Collection<> CompareType at 'ScalarOperator' : ScalarType
            if (this.ScalarOperator is object) {
                foreach (ScalarType item in this.ScalarOperator) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType CompareType at 'CompareOp' : CompareOpType
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
            // ShowPlanBase ComputeScalarType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ValueType ComputeScalarType at 'ComputeSequence' : Boolean
            // ValueType ComputeScalarType at 'ComputeSequenceSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> ConcatType at 'RelOp' : RelOpType
            if (this.RelOp is object) {
                foreach (RelOpType item in this.RelOp) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase ConditionalType at 'Condition' : ScalarExpressionType
            if (Condition is object) { state = visitor.Visit(this.Condition, state); }
            // ShowPlanBase ConditionalType at 'Then' : ScalarExpressionType
            if (Then is object) { state = visitor.Visit(this.Then, state); }
            // ShowPlanBase ConditionalType at 'Else' : ScalarExpressionType
            if (Else is object) { state = visitor.Visit(this.Else, state); }
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
            // Collection<> ConstantScanType at 'Values' : ScalarExpressionListType
            if (this.Values is object) {
                foreach (ScalarExpressionListType item in this.Values) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ConstantScanType at 'ValuesSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> ConstantScanTypeValues at 'Row' : ScalarExpressionListType
            if (this.Row is object) {
                foreach (ScalarExpressionListType item in this.Row) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ConstantScanTypeValues at 'RowSpecified' : Boolean
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
            // String ConstType at 'ConstValue' : String
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
            // ShowPlanBase ConvertType at 'Style' : ScalarExpressionType
            if (Style is object) { state = visitor.Visit(this.Style, state); }
            // ValueType ConvertType at 'Style_1' : Int32
            // ShowPlanBase ConvertType at 'ScalarOperator' : ScalarType
            if (ScalarOperator is object) { state = visitor.Visit(this.ScalarOperator, state); }
            // String ConvertType at 'DataType' : String
            // ValueType ConvertType at 'Length' : Int32
            // ValueType ConvertType at 'LengthSpecified' : Boolean
            // ValueType ConvertType at 'Precision' : Int32
            // ValueType ConvertType at 'PrecisionSpecified' : Boolean
            // ValueType ConvertType at 'Scale' : Int32
            // ValueType ConvertType at 'ScaleSpecified' : Boolean
            // ValueType ConvertType at 'Implicit' : Boolean
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
            // ShowPlanBase CreateIndexType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> RowsetType at 'Object' : ObjectType
            if (this.Object is object) {
                foreach (ObjectType item in this.Object) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> CursorPlanType at 'Operation' : CursorPlanTypeOperation
            if (this.Operation is object) {
                foreach (CursorPlanTypeOperation item in this.Operation) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType CursorPlanType at 'OperationSpecified' : Boolean
            // String CursorPlanType at 'CursorName' : String
            // ValueType CursorPlanType at 'CursorActualType' : CursorType
            // ValueType CursorPlanType at 'CursorActualTypeSpecified' : Boolean
            // ValueType CursorPlanType at 'CursorRequestedType' : CursorType
            // ValueType CursorPlanType at 'CursorRequestedTypeSpecified' : Boolean
            // ValueType CursorPlanType at 'CursorConcurrency' : CursorPlanTypeCursorConcurrency
            // ValueType CursorPlanType at 'CursorConcurrencySpecified' : Boolean
            // ValueType CursorPlanType at 'ForwardOnly' : Boolean
            // ValueType CursorPlanType at 'ForwardOnlySpecified' : Boolean
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
            // ShowPlanBase CursorPlanTypeOperation at 'QueryPlan' : QueryPlanType
            if (QueryPlan is object) { state = visitor.Visit(this.QueryPlan, state); }
            // Collection<> CursorPlanTypeOperation at 'UDF' : FunctionType
            if (this.UDF is object) {
                foreach (FunctionType item in this.UDF) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType CursorPlanTypeOperation at 'UDFSpecified' : Boolean
            // ValueType CursorPlanTypeOperation at 'OperationType' : CursorPlanTypeOperationOperationType
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
            // Collection<> DefinedValuesListType at 'DefinedValue' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValue is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValue) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType DefinedValuesListType at 'DefinedValueSpecified' : Boolean
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
            // Collection<> DefinedValuesListTypeDefinedValue at 'ValueVector' : ColumnReferenceType
            if (this.ValueVector is object) {
                foreach (ColumnReferenceType item in this.ValueVector) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType DefinedValuesListTypeDefinedValue at 'ValueVectorSpecified' : Boolean
            // ShowPlanBase DefinedValuesListTypeDefinedValue at 'ColumnReference' : ColumnReferenceType
            if (ColumnReference is object) { state = visitor.Visit(this.ColumnReference, state); }
            // ShowPlanBase DefinedValuesListTypeDefinedValue at 'ScalarOperator' : ScalarType
            if (ScalarOperator is object) { state = visitor.Visit(this.ScalarOperator, state); }
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
            // Collection<> DefinedValuesListTypeDefinedValueValueVector at 'ColumnReference' : ColumnReferenceType
            if (this.ColumnReference is object) {
                foreach (ColumnReferenceType item in this.ColumnReference) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // ShowPlanBase FilterType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ShowPlanBase FilterType at 'Predicate' : ScalarExpressionType
            if (Predicate is object) { state = visitor.Visit(this.Predicate, state); }
            // ValueType FilterType at 'StartupExpression' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase ForeignKeyReferenceCheckType at 'IndexScan' : IndexScanType
            if (IndexScan is object) { state = visitor.Visit(this.IndexScan, state); }
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
            // ShowPlanBase ForeignKeyReferencesCheckType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> ForeignKeyReferencesCheckType at 'ForeignKeyReferenceCheck' : ForeignKeyReferenceCheckType
            if (this.ForeignKeyReferenceCheck is object) {
                foreach (ForeignKeyReferenceCheckType item in this.ForeignKeyReferenceCheck) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ForeignKeyReferencesCheckType at 'ForeignKeyReferencesCount' : Int32
            // ValueType ForeignKeyReferencesCheckType at 'ForeignKeyReferencesCountSpecified' : Boolean
            // ValueType ForeignKeyReferencesCheckType at 'NoMatchingIndexCount' : Int32
            // ValueType ForeignKeyReferencesCheckType at 'NoMatchingIndexCountSpecified' : Boolean
            // ValueType ForeignKeyReferencesCheckType at 'PartialMatchingIndexCount' : Int32
            // ValueType ForeignKeyReferencesCheckType at 'PartialMatchingIndexCountSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase FunctionType at 'Statements' : StmtBlockType
            if (Statements is object) { state = visitor.Visit(this.Statements, state); }
            // String FunctionType at 'ProcName' : String
            // ValueType FunctionType at 'IsNativelyCompiled' : Boolean
            // ValueType FunctionType at 'IsNativelyCompiledSpecified' : Boolean
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
            // Collection<> GenericType at 'RelOp' : RelOpType
            if (this.RelOp is object) {
                foreach (RelOpType item in this.RelOp) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType GenericType at 'RelOpSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase GuessedSelectivityType at 'Spatial' : ObjectType
            if (Spatial is object) { state = visitor.Visit(this.Spatial, state); }
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
            // ValueType HashSpillDetailsType at 'GrantedMemoryKb' : UInt64
            // ValueType HashSpillDetailsType at 'GrantedMemoryKbSpecified' : Boolean
            // ValueType HashSpillDetailsType at 'UsedMemoryKb' : UInt64
            // ValueType HashSpillDetailsType at 'UsedMemoryKbSpecified' : Boolean
            // ValueType HashSpillDetailsType at 'WritesToTempDb' : UInt64
            // ValueType HashSpillDetailsType at 'WritesToTempDbSpecified' : Boolean
            // ValueType HashSpillDetailsType at 'ReadsFromTempDb' : UInt64
            // ValueType HashSpillDetailsType at 'ReadsFromTempDbSpecified' : Boolean
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
            // Collection<> HashType at 'HashKeysBuild' : ColumnReferenceType
            if (this.HashKeysBuild is object) {
                foreach (ColumnReferenceType item in this.HashKeysBuild) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType HashType at 'HashKeysBuildSpecified' : Boolean
            // Collection<> HashType at 'HashKeysProbe' : ColumnReferenceType
            if (this.HashKeysProbe is object) {
                foreach (ColumnReferenceType item in this.HashKeysProbe) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType HashType at 'HashKeysProbeSpecified' : Boolean
            // ShowPlanBase HashType at 'BuildResidual' : ScalarExpressionType
            if (BuildResidual is object) { state = visitor.Visit(this.BuildResidual, state); }
            // ShowPlanBase HashType at 'ProbeResidual' : ScalarExpressionType
            if (ProbeResidual is object) { state = visitor.Visit(this.ProbeResidual, state); }
            // ShowPlanBase HashType at 'StarJoinInfo' : StarJoinInfoType
            if (StarJoinInfo is object) { state = visitor.Visit(this.StarJoinInfo, state); }
            // Collection<> HashType at 'RelOp' : RelOpType
            if (this.RelOp is object) {
                foreach (RelOpType item in this.RelOp) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType HashType at 'BitmapCreator' : Boolean
            // ValueType HashType at 'BitmapCreatorSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase IdentType at 'ColumnReference' : ColumnReferenceType
            if (ColumnReference is object) { state = visitor.Visit(this.ColumnReference, state); }
            // String IdentType at 'Table' : String
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
            // Collection<> IndexedViewInfoType at 'Object' : ObjectType
            if (this.Object is object) {
                foreach (ObjectType item in this.Object) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType IndexedViewInfoType at 'ObjectSpecified' : Boolean
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
            // ShowPlanBase IndexScanType at 'SeekPredicates' : SeekPredicatesType
            if (SeekPredicates is object) { state = visitor.Visit(this.SeekPredicates, state); }
            // Collection<> IndexScanType at 'Predicate' : ScalarExpressionType
            if (this.Predicate is object) {
                foreach (ScalarExpressionType item in this.Predicate) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType IndexScanType at 'PredicateSpecified' : Boolean
            // ShowPlanBase IndexScanType at 'PartitionId' : SingleColumnReferenceType
            if (PartitionId is object) { state = visitor.Visit(this.PartitionId, state); }
            // Collection<> IndexScanType at 'IndexedViewInfo' : ObjectType
            if (this.IndexedViewInfo is object) {
                foreach (ObjectType item in this.IndexedViewInfo) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType IndexScanType at 'IndexedViewInfoSpecified' : Boolean
            // ValueType IndexScanType at 'Lookup' : Boolean
            // ValueType IndexScanType at 'LookupSpecified' : Boolean
            // ValueType IndexScanType at 'Ordered' : Boolean
            // ValueType IndexScanType at 'ScanDirection' : OrderType
            // ValueType IndexScanType at 'ScanDirectionSpecified' : Boolean
            // ValueType IndexScanType at 'ForcedIndex' : Boolean
            // ValueType IndexScanType at 'ForcedIndexSpecified' : Boolean
            // ValueType IndexScanType at 'ForceSeek' : Boolean
            // ValueType IndexScanType at 'ForceSeekSpecified' : Boolean
            // ValueType IndexScanType at 'ForceSeekColumnCount' : Int32
            // ValueType IndexScanType at 'ForceSeekColumnCountSpecified' : Boolean
            // ValueType IndexScanType at 'ForceScan' : Boolean
            // ValueType IndexScanType at 'ForceScanSpecified' : Boolean
            // ValueType IndexScanType at 'NoExpandHint' : Boolean
            // ValueType IndexScanType at 'NoExpandHintSpecified' : Boolean
            // ValueType IndexScanType at 'Storage' : StorageType
            // ValueType IndexScanType at 'StorageSpecified' : Boolean
            // ValueType IndexScanType at 'DynamicSeek' : Boolean
            // ValueType IndexScanType at 'DynamicSeekSpecified' : Boolean
            // Collection<> RowsetType at 'Object' : ObjectType
            if (this.Object is object) {
                foreach (ObjectType item in this.Object) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ??? InternalInfoType at 'Any' : Collection`1
            // ValueType InternalInfoType at 'AnySpecified' : Boolean
            // ??? InternalInfoType at 'AnyAttribute' : Collection`1
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
            // Collection<> IntrinsicType at 'ScalarOperator' : ScalarType
            if (this.ScalarOperator is object) {
                foreach (ScalarType item in this.ScalarOperator) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType IntrinsicType at 'ScalarOperatorSpecified' : Boolean
            // String IntrinsicType at 'FunctionName' : String
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
            // Collection<> LogicalType at 'ScalarOperator' : ScalarType
            if (this.ScalarOperator is object) {
                foreach (ScalarType item in this.ScalarOperator) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType LogicalType at 'Operation' : LogicalOperationType
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
            // ValueType MemoryFractionsType at 'Input' : Double
            // ValueType MemoryFractionsType at 'Output' : Double
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
            // ValueType MemoryGrantType at 'SerialRequiredMemory' : UInt64
            // ValueType MemoryGrantType at 'SerialDesiredMemory' : UInt64
            // ValueType MemoryGrantType at 'RequiredMemory' : UInt64
            // ValueType MemoryGrantType at 'RequiredMemorySpecified' : Boolean
            // ValueType MemoryGrantType at 'DesiredMemory' : UInt64
            // ValueType MemoryGrantType at 'DesiredMemorySpecified' : Boolean
            // ValueType MemoryGrantType at 'RequestedMemory' : UInt64
            // ValueType MemoryGrantType at 'RequestedMemorySpecified' : Boolean
            // ValueType MemoryGrantType at 'GrantWaitTime' : UInt64
            // ValueType MemoryGrantType at 'GrantWaitTimeSpecified' : Boolean
            // ValueType MemoryGrantType at 'GrantedMemory' : UInt64
            // ValueType MemoryGrantType at 'GrantedMemorySpecified' : Boolean
            // ValueType MemoryGrantType at 'MaxUsedMemory' : UInt64
            // ValueType MemoryGrantType at 'MaxUsedMemorySpecified' : Boolean
            // ValueType MemoryGrantType at 'MaxQueryMemory' : UInt64
            // ValueType MemoryGrantType at 'MaxQueryMemorySpecified' : Boolean
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
            // ValueType MemoryGrantWarningInfo at 'GrantWarningKind' : MemoryGrantWarningType
            // ValueType MemoryGrantWarningInfo at 'RequestedMemory' : UInt64
            // ValueType MemoryGrantWarningInfo at 'GrantedMemory' : UInt64
            // ValueType MemoryGrantWarningInfo at 'MaxUsedMemory' : UInt64
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
            // Collection<> MergeType at 'InnerSideJoinColumns' : ColumnReferenceType
            if (this.InnerSideJoinColumns is object) {
                foreach (ColumnReferenceType item in this.InnerSideJoinColumns) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType MergeType at 'InnerSideJoinColumnsSpecified' : Boolean
            // Collection<> MergeType at 'OuterSideJoinColumns' : ColumnReferenceType
            if (this.OuterSideJoinColumns is object) {
                foreach (ColumnReferenceType item in this.OuterSideJoinColumns) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType MergeType at 'OuterSideJoinColumnsSpecified' : Boolean
            // ShowPlanBase MergeType at 'Residual' : ScalarExpressionType
            if (Residual is object) { state = visitor.Visit(this.Residual, state); }
            // ShowPlanBase MergeType at 'PassThru' : ScalarExpressionType
            if (PassThru is object) { state = visitor.Visit(this.PassThru, state); }
            // ShowPlanBase MergeType at 'StarJoinInfo' : StarJoinInfoType
            if (StarJoinInfo is object) { state = visitor.Visit(this.StarJoinInfo, state); }
            // Collection<> MergeType at 'RelOp' : RelOpType
            if (this.RelOp is object) {
                foreach (RelOpType item in this.RelOp) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType MergeType at 'ManyToMany' : Boolean
            // ValueType MergeType at 'ManyToManySpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> MissingIndexesType at 'MissingIndexGroup' : MissingIndexGroupType
            if (this.MissingIndexGroup is object) {
                foreach (MissingIndexGroupType item in this.MissingIndexGroup) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // Collection<> MissingIndexGroupType at 'MissingIndex' : MissingIndexType
            if (this.MissingIndex is object) {
                foreach (MissingIndexType item in this.MissingIndex) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType MissingIndexGroupType at 'Impact' : Double
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
            // Collection<> MissingIndexType at 'ColumnGroup' : ColumnGroupType
            if (this.ColumnGroup is object) {
                foreach (ColumnGroupType item in this.ColumnGroup) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // String MissingIndexType at 'Database' : String
            // String MissingIndexType at 'Schema' : String
            // String MissingIndexType at 'Table' : String
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
            // Collection<> MultAssignType at 'Assign' : AssignType
            if (this.Assign is object) {
                foreach (AssignType item in this.Assign) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType MultAssignType at 'AssignSpecified' : Boolean
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
            // ShowPlanBase NestedLoopsType at 'Predicate' : ScalarExpressionType
            if (Predicate is object) { state = visitor.Visit(this.Predicate, state); }
            // ShowPlanBase NestedLoopsType at 'PassThru' : ScalarExpressionType
            if (PassThru is object) { state = visitor.Visit(this.PassThru, state); }
            // Collection<> NestedLoopsType at 'OuterReferences' : ColumnReferenceType
            if (this.OuterReferences is object) {
                foreach (ColumnReferenceType item in this.OuterReferences) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType NestedLoopsType at 'OuterReferencesSpecified' : Boolean
            // ShowPlanBase NestedLoopsType at 'PartitionId' : SingleColumnReferenceType
            if (PartitionId is object) { state = visitor.Visit(this.PartitionId, state); }
            // ShowPlanBase NestedLoopsType at 'ProbeColumn' : SingleColumnReferenceType
            if (ProbeColumn is object) { state = visitor.Visit(this.ProbeColumn, state); }
            // ShowPlanBase NestedLoopsType at 'StarJoinInfo' : StarJoinInfoType
            if (StarJoinInfo is object) { state = visitor.Visit(this.StarJoinInfo, state); }
            // Collection<> NestedLoopsType at 'RelOp' : RelOpType
            if (this.RelOp is object) {
                foreach (RelOpType item in this.RelOp) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType NestedLoopsType at 'Optimized' : Boolean
            // ValueType NestedLoopsType at 'WithOrderedPrefetch' : Boolean
            // ValueType NestedLoopsType at 'WithOrderedPrefetchSpecified' : Boolean
            // ValueType NestedLoopsType at 'WithUnorderedPrefetch' : Boolean
            // ValueType NestedLoopsType at 'WithUnorderedPrefetchSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // String ObjectType at 'Server' : String
            // String ObjectType at 'Database' : String
            // String ObjectType at 'Schema' : String
            // String ObjectType at 'Table' : String
            // String ObjectType at 'Index' : String
            // ValueType ObjectType at 'Filtered' : Boolean
            // ValueType ObjectType at 'FilteredSpecified' : Boolean
            // String ObjectType at 'Alias' : String
            // ValueType ObjectType at 'TableReferenceId' : Int32
            // ValueType ObjectType at 'TableReferenceIdSpecified' : Boolean
            // ValueType ObjectType at 'IndexKind' : IndexKindType
            // ValueType ObjectType at 'IndexKindSpecified' : Boolean
            // ValueType ObjectType at 'CloneAccessScope' : CloneAccessScopeType
            // ValueType ObjectType at 'CloneAccessScopeSpecified' : Boolean
            // ValueType ObjectType at 'Storage' : StorageType
            // ValueType ObjectType at 'StorageSpecified' : Boolean
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
            // ValueType OptimizerHardwareDependentPropertiesType at 'EstimatedAvailableMemoryGrant' : UInt64
            // ValueType OptimizerHardwareDependentPropertiesType at 'EstimatedPagesCached' : UInt64
            // ValueType OptimizerHardwareDependentPropertiesType at 'EstimatedAvailableDegreeOfParallelism' : UInt64
            // ValueType OptimizerHardwareDependentPropertiesType at 'EstimatedAvailableDegreeOfParallelismSpecified' : Boolean
            // ValueType OptimizerHardwareDependentPropertiesType at 'MaxCompileMemory' : UInt64
            // ValueType OptimizerHardwareDependentPropertiesType at 'MaxCompileMemorySpecified' : Boolean
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
            // Collection<> OptimizerStatsUsageType at 'StatisticsInfo' : StatsInfoType
            if (this.StatisticsInfo is object) {
                foreach (StatsInfoType item in this.StatisticsInfo) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // Collection<> OrderByType at 'OrderByColumn' : OrderByTypeOrderByColumn
            if (this.OrderByColumn is object) {
                foreach (OrderByTypeOrderByColumn item in this.OrderByColumn) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // ShowPlanBase OrderByTypeOrderByColumn at 'ColumnReference' : ColumnReferenceType
            if (ColumnReference is object) { state = visitor.Visit(this.ColumnReference, state); }
            // ValueType OrderByTypeOrderByColumn at 'Ascending' : Boolean
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
            // Collection<> ParallelismType at 'PartitionColumns' : ColumnReferenceType
            if (this.PartitionColumns is object) {
                foreach (ColumnReferenceType item in this.PartitionColumns) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ParallelismType at 'PartitionColumnsSpecified' : Boolean
            // Collection<> ParallelismType at 'OrderBy' : OrderByTypeOrderByColumn
            if (this.OrderBy is object) {
                foreach (OrderByTypeOrderByColumn item in this.OrderBy) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ParallelismType at 'OrderBySpecified' : Boolean
            // Collection<> ParallelismType at 'HashKeys' : ColumnReferenceType
            if (this.HashKeys is object) {
                foreach (ColumnReferenceType item in this.HashKeys) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ParallelismType at 'HashKeysSpecified' : Boolean
            // ShowPlanBase ParallelismType at 'ProbeColumn' : SingleColumnReferenceType
            if (ProbeColumn is object) { state = visitor.Visit(this.ProbeColumn, state); }
            // ShowPlanBase ParallelismType at 'Predicate' : ScalarExpressionType
            if (Predicate is object) { state = visitor.Visit(this.Predicate, state); }
            // ShowPlanBase ParallelismType at 'Activation' : ParallelismTypeActivation
            if (Activation is object) { state = visitor.Visit(this.Activation, state); }
            // ShowPlanBase ParallelismType at 'BrickRouting' : ParallelismTypeBrickRouting
            if (BrickRouting is object) { state = visitor.Visit(this.BrickRouting, state); }
            // ShowPlanBase ParallelismType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ValueType ParallelismType at 'PartitioningType' : PartitionType
            // ValueType ParallelismType at 'PartitioningTypeSpecified' : Boolean
            // ValueType ParallelismType at 'Remoting' : Boolean
            // ValueType ParallelismType at 'RemotingSpecified' : Boolean
            // ValueType ParallelismType at 'LocalParallelism' : Boolean
            // ValueType ParallelismType at 'LocalParallelismSpecified' : Boolean
            // ValueType ParallelismType at 'InRow' : Boolean
            // ValueType ParallelismType at 'InRowSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase ParallelismTypeActivation at 'Object' : ObjectType
            if (Object is object) { state = visitor.Visit(this.Object, state); }
            // ValueType ParallelismTypeActivation at 'Type' : ParallelismTypeActivationType
            // String ParallelismTypeActivation at 'FragmentElimination' : String
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
            // ShowPlanBase ParallelismTypeBrickRouting at 'Object' : ObjectType
            if (Object is object) { state = visitor.Visit(this.Object, state); }
            // ShowPlanBase ParallelismTypeBrickRouting at 'FragmentIdColumn' : SingleColumnReferenceType
            if (FragmentIdColumn is object) { state = visitor.Visit(this.FragmentIdColumn, state); }
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
            // Collection<> ParameterizationType at 'Object' : ObjectType
            if (this.Object is object) {
                foreach (ObjectType item in this.Object) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // ShowPlanBase PutType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // String PutType at 'ShuffleType' : String
            // String PutType at 'ShuffleColumn' : String
            // String RemoteQueryType at 'RemoteQuery' : String
            // String RemoteType at 'RemoteDestination' : String
            // String RemoteType at 'RemoteSource' : String
            // String RemoteType at 'RemoteObject' : String
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ValueType QueryExecTimeType at 'CpuTime' : UInt64
            // ValueType QueryExecTimeType at 'ElapsedTime' : UInt64
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
            // ShowPlanBase QueryPlanType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
            // ShowPlanBase QueryPlanType at 'ThreadStat' : ThreadStatType
            if (ThreadStat is object) { state = visitor.Visit(this.ThreadStat, state); }
            // Collection<> QueryPlanType at 'MissingIndexes' : MissingIndexGroupType
            if (this.MissingIndexes is object) {
                foreach (MissingIndexGroupType item in this.MissingIndexes) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType QueryPlanType at 'MissingIndexesSpecified' : Boolean
            // ShowPlanBase QueryPlanType at 'GuessedSelectivity' : GuessedSelectivityType
            if (GuessedSelectivity is object) { state = visitor.Visit(this.GuessedSelectivity, state); }
            // ShowPlanBase QueryPlanType at 'UnmatchedIndexes' : UnmatchedIndexesType
            if (UnmatchedIndexes is object) { state = visitor.Visit(this.UnmatchedIndexes, state); }
            // ShowPlanBase QueryPlanType at 'Warnings' : WarningsType
            if (Warnings is object) { state = visitor.Visit(this.Warnings, state); }
            // ShowPlanBase QueryPlanType at 'MemoryGrantInfo' : MemoryGrantType
            if (MemoryGrantInfo is object) { state = visitor.Visit(this.MemoryGrantInfo, state); }
            // ShowPlanBase QueryPlanType at 'OptimizerHardwareDependentProperties' : OptimizerHardwareDependentPropertiesType
            if (OptimizerHardwareDependentProperties is object) { state = visitor.Visit(this.OptimizerHardwareDependentProperties, state); }
            // Collection<> QueryPlanType at 'OptimizerStatsUsage' : StatsInfoType
            if (this.OptimizerStatsUsage is object) {
                foreach (StatsInfoType item in this.OptimizerStatsUsage) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType QueryPlanType at 'OptimizerStatsUsageSpecified' : Boolean
            // Collection<> QueryPlanType at 'TraceFlags' : TraceFlagListType
            if (this.TraceFlags is object) {
                foreach (TraceFlagListType item in this.TraceFlags) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType QueryPlanType at 'TraceFlagsSpecified' : Boolean
            // Collection<> QueryPlanType at 'WaitStats' : WaitStatType
            if (this.WaitStats is object) {
                foreach (WaitStatType item in this.WaitStats) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType QueryPlanType at 'WaitStatsSpecified' : Boolean
            // ShowPlanBase QueryPlanType at 'QueryTimeStats' : QueryExecTimeType
            if (QueryTimeStats is object) { state = visitor.Visit(this.QueryTimeStats, state); }
            // ShowPlanBase QueryPlanType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> QueryPlanType at 'ParameterList' : ColumnReferenceType
            if (this.ParameterList is object) {
                foreach (ColumnReferenceType item in this.ParameterList) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType QueryPlanType at 'ParameterListSpecified' : Boolean
            // ValueType QueryPlanType at 'DegreeOfParallelism' : Int32
            // ValueType QueryPlanType at 'DegreeOfParallelismSpecified' : Boolean
            // ValueType QueryPlanType at 'EffectiveDegreeOfParallelism' : Int32
            // ValueType QueryPlanType at 'EffectiveDegreeOfParallelismSpecified' : Boolean
            // String QueryPlanType at 'NonParallelPlanReason' : String
            // ValueType QueryPlanType at 'MemoryGrant' : UInt64
            // ValueType QueryPlanType at 'MemoryGrantSpecified' : Boolean
            // ValueType QueryPlanType at 'CachedPlanSize' : UInt64
            // ValueType QueryPlanType at 'CachedPlanSizeSpecified' : Boolean
            // ValueType QueryPlanType at 'CompileTime' : UInt64
            // ValueType QueryPlanType at 'CompileTimeSpecified' : Boolean
            // ValueType QueryPlanType at 'CompileCPU' : UInt64
            // ValueType QueryPlanType at 'CompileCPUSpecified' : Boolean
            // ValueType QueryPlanType at 'CompileMemory' : UInt64
            // ValueType QueryPlanType at 'CompileMemorySpecified' : Boolean
            // ValueType QueryPlanType at 'UsePlan' : Boolean
            // ValueType QueryPlanType at 'UsePlanSpecified' : Boolean
            // ValueType QueryPlanType at 'ContainsInterleavedExecutionCandidates' : Boolean
            // ValueType QueryPlanType at 'ContainsInterleavedExecutionCandidatesSpecified' : Boolean
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
            // Collection<> ReceivePlanType at 'Operation' : ReceivePlanTypeOperation
            if (this.Operation is object) {
                foreach (ReceivePlanTypeOperation item in this.Operation) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // ShowPlanBase ReceivePlanTypeOperation at 'QueryPlan' : QueryPlanType
            if (QueryPlan is object) { state = visitor.Visit(this.QueryPlan, state); }
            // ValueType ReceivePlanTypeOperation at 'OperationType' : ReceivePlanTypeOperationOperationType
            // ValueType ReceivePlanTypeOperation at 'OperationTypeSpecified' : Boolean
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
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> RelOpType at 'OutputList' : ColumnReferenceType
            if (this.OutputList is object) {
                foreach (ColumnReferenceType item in this.OutputList) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ShowPlanBase RelOpType at 'Warnings' : WarningsType
            if (Warnings is object) { state = visitor.Visit(this.Warnings, state); }
            // ShowPlanBase RelOpType at 'MemoryFractions' : MemoryFractionsType
            if (MemoryFractions is object) { state = visitor.Visit(this.MemoryFractions, state); }
            // Collection<> RelOpType at 'RunTimeInformation' : RunTimeInformationTypeRunTimeCountersPerThread
            if (this.RunTimeInformation is object) {
                foreach (RunTimeInformationTypeRunTimeCountersPerThread item in this.RunTimeInformation) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpType at 'RunTimeInformationSpecified' : Boolean
            // ShowPlanBase RelOpType at 'RunTimePartitionSummary' : RunTimePartitionSummaryType
            if (RunTimePartitionSummary is object) { state = visitor.Visit(this.RunTimePartitionSummary, state); }
            // ShowPlanBase RelOpType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
            // ShowPlanBase RelOpType at 'AdaptiveJoin' : AdaptiveJoinType
            if (AdaptiveJoin is object) { state = visitor.Visit(this.AdaptiveJoin, state); }
            // ShowPlanBase RelOpType at 'Assert' : FilterType
            if (Assert is object) { state = visitor.Visit(this.Assert, state); }
            // ShowPlanBase RelOpType at 'BatchHashTableBuild' : BatchHashTableBuildType
            if (BatchHashTableBuild is object) { state = visitor.Visit(this.BatchHashTableBuild, state); }
            // ShowPlanBase RelOpType at 'Bitmap' : BitmapType
            if (Bitmap is object) { state = visitor.Visit(this.Bitmap, state); }
            // ShowPlanBase RelOpType at 'Collapse' : CollapseType
            if (Collapse is object) { state = visitor.Visit(this.Collapse, state); }
            // ShowPlanBase RelOpType at 'ComputeScalar' : ComputeScalarType
            if (ComputeScalar is object) { state = visitor.Visit(this.ComputeScalar, state); }
            // ShowPlanBase RelOpType at 'Concat' : ConcatType
            if (Concat is object) { state = visitor.Visit(this.Concat, state); }
            // ShowPlanBase RelOpType at 'ConstantScan' : ConstantScanType
            if (ConstantScan is object) { state = visitor.Visit(this.ConstantScan, state); }
            // ShowPlanBase RelOpType at 'CreateIndex' : CreateIndexType
            if (CreateIndex is object) { state = visitor.Visit(this.CreateIndex, state); }
            // ShowPlanBase RelOpType at 'DeletedScan' : RowsetType
            if (DeletedScan is object) { state = visitor.Visit(this.DeletedScan, state); }
            // ShowPlanBase RelOpType at 'Extension' : UDXType
            if (Extension is object) { state = visitor.Visit(this.Extension, state); }
            // ShowPlanBase RelOpType at 'Filter' : FilterType
            if (Filter is object) { state = visitor.Visit(this.Filter, state); }
            // ShowPlanBase RelOpType at 'ForeignKeyReferencesCheck' : ForeignKeyReferencesCheckType
            if (ForeignKeyReferencesCheck is object) { state = visitor.Visit(this.ForeignKeyReferencesCheck, state); }
            // ShowPlanBase RelOpType at 'Generic' : GenericType
            if (Generic is object) { state = visitor.Visit(this.Generic, state); }
            // ShowPlanBase RelOpType at 'Hash' : HashType
            if (Hash is object) { state = visitor.Visit(this.Hash, state); }
            // ShowPlanBase RelOpType at 'IndexScan' : IndexScanType
            if (IndexScan is object) { state = visitor.Visit(this.IndexScan, state); }
            // ShowPlanBase RelOpType at 'InsertedScan' : RowsetType
            if (InsertedScan is object) { state = visitor.Visit(this.InsertedScan, state); }
            // ShowPlanBase RelOpType at 'LogRowScan' : RelOpBaseType
            if (LogRowScan is object) { state = visitor.Visit(this.LogRowScan, state); }
            // ShowPlanBase RelOpType at 'Merge' : MergeType
            if (Merge is object) { state = visitor.Visit(this.Merge, state); }
            // ShowPlanBase RelOpType at 'MergeInterval' : SimpleIteratorOneChildType
            if (MergeInterval is object) { state = visitor.Visit(this.MergeInterval, state); }
            // ShowPlanBase RelOpType at 'NestedLoops' : NestedLoopsType
            if (NestedLoops is object) { state = visitor.Visit(this.NestedLoops, state); }
            // ShowPlanBase RelOpType at 'OnlineIndex' : CreateIndexType
            if (OnlineIndex is object) { state = visitor.Visit(this.OnlineIndex, state); }
            // ShowPlanBase RelOpType at 'Parallelism' : ParallelismType
            if (Parallelism is object) { state = visitor.Visit(this.Parallelism, state); }
            // ShowPlanBase RelOpType at 'ParameterTableScan' : RelOpBaseType
            if (ParameterTableScan is object) { state = visitor.Visit(this.ParameterTableScan, state); }
            // ShowPlanBase RelOpType at 'PrintDataflow' : RelOpBaseType
            if (PrintDataflow is object) { state = visitor.Visit(this.PrintDataflow, state); }
            // ShowPlanBase RelOpType at 'Put' : PutType
            if (Put is object) { state = visitor.Visit(this.Put, state); }
            // ShowPlanBase RelOpType at 'RemoteFetch' : RemoteFetchType
            if (RemoteFetch is object) { state = visitor.Visit(this.RemoteFetch, state); }
            // ShowPlanBase RelOpType at 'RemoteModify' : RemoteModifyType
            if (RemoteModify is object) { state = visitor.Visit(this.RemoteModify, state); }
            // ShowPlanBase RelOpType at 'RemoteQuery' : RemoteQueryType
            if (RemoteQuery is object) { state = visitor.Visit(this.RemoteQuery, state); }
            // ShowPlanBase RelOpType at 'RemoteRange' : RemoteRangeType
            if (RemoteRange is object) { state = visitor.Visit(this.RemoteRange, state); }
            // ShowPlanBase RelOpType at 'RemoteScan' : RemoteType
            if (RemoteScan is object) { state = visitor.Visit(this.RemoteScan, state); }
            // ShowPlanBase RelOpType at 'RowCountSpool' : SpoolType
            if (RowCountSpool is object) { state = visitor.Visit(this.RowCountSpool, state); }
            // ShowPlanBase RelOpType at 'ScalarInsert' : ScalarInsertType
            if (ScalarInsert is object) { state = visitor.Visit(this.ScalarInsert, state); }
            // ShowPlanBase RelOpType at 'Segment' : SegmentType
            if (Segment is object) { state = visitor.Visit(this.Segment, state); }
            // ShowPlanBase RelOpType at 'Sequence' : SequenceType
            if (Sequence is object) { state = visitor.Visit(this.Sequence, state); }
            // ShowPlanBase RelOpType at 'SequenceProject' : ComputeScalarType
            if (SequenceProject is object) { state = visitor.Visit(this.SequenceProject, state); }
            // ShowPlanBase RelOpType at 'SimpleUpdate' : SimpleUpdateType
            if (SimpleUpdate is object) { state = visitor.Visit(this.SimpleUpdate, state); }
            // ShowPlanBase RelOpType at 'Sort' : SortType
            if (Sort is object) { state = visitor.Visit(this.Sort, state); }
            // ShowPlanBase RelOpType at 'Split' : SplitType
            if (Split is object) { state = visitor.Visit(this.Split, state); }
            // ShowPlanBase RelOpType at 'Spool' : SpoolType
            if (Spool is object) { state = visitor.Visit(this.Spool, state); }
            // ShowPlanBase RelOpType at 'StreamAggregate' : StreamAggregateType
            if (StreamAggregate is object) { state = visitor.Visit(this.StreamAggregate, state); }
            // ShowPlanBase RelOpType at 'Switch' : SwitchType
            if (Switch is object) { state = visitor.Visit(this.Switch, state); }
            // ShowPlanBase RelOpType at 'TableScan' : TableScanType
            if (TableScan is object) { state = visitor.Visit(this.TableScan, state); }
            // ShowPlanBase RelOpType at 'TableValuedFunction' : TableValuedFunctionType
            if (TableValuedFunction is object) { state = visitor.Visit(this.TableValuedFunction, state); }
            // ShowPlanBase RelOpType at 'Top' : TopType
            if (Top is object) { state = visitor.Visit(this.Top, state); }
            // ShowPlanBase RelOpType at 'TopSort' : TopSortType
            if (TopSort is object) { state = visitor.Visit(this.TopSort, state); }
            // ShowPlanBase RelOpType at 'Update' : UpdateType
            if (Update is object) { state = visitor.Visit(this.Update, state); }
            // ShowPlanBase RelOpType at 'WindowSpool' : WindowType
            if (WindowSpool is object) { state = visitor.Visit(this.WindowSpool, state); }
            // ShowPlanBase RelOpType at 'WindowAggregate' : WindowAggregateType
            if (WindowAggregate is object) { state = visitor.Visit(this.WindowAggregate, state); }
            // ValueType RelOpType at 'AvgRowSize' : Double
            // ValueType RelOpType at 'EstimateCPU' : Double
            // ValueType RelOpType at 'EstimateIO' : Double
            // ValueType RelOpType at 'EstimateRebinds' : Double
            // ValueType RelOpType at 'EstimateRewinds' : Double
            // ValueType RelOpType at 'EstimatedExecutionMode' : ExecutionModeType
            // ValueType RelOpType at 'EstimatedExecutionModeSpecified' : Boolean
            // ValueType RelOpType at 'GroupExecuted' : Boolean
            // ValueType RelOpType at 'GroupExecutedSpecified' : Boolean
            // ValueType RelOpType at 'EstimateRows' : Double
            // ValueType RelOpType at 'EstimatedRowsRead' : Double
            // ValueType RelOpType at 'EstimatedRowsReadSpecified' : Boolean
            // ValueType RelOpType at 'LogicalOp' : LogicalOpType
            // ValueType RelOpType at 'NodeId' : Int32
            // ValueType RelOpType at 'Parallel' : Boolean
            // ValueType RelOpType at 'RemoteDataAccess' : Boolean
            // ValueType RelOpType at 'RemoteDataAccessSpecified' : Boolean
            // ValueType RelOpType at 'Partitioned' : Boolean
            // ValueType RelOpType at 'PartitionedSpecified' : Boolean
            // ValueType RelOpType at 'PhysicalOp' : PhysicalOpType
            // ValueType RelOpType at 'IsAdaptive' : Boolean
            // ValueType RelOpType at 'IsAdaptiveSpecified' : Boolean
            // ValueType RelOpType at 'AdaptiveThresholdRows' : Double
            // ValueType RelOpType at 'AdaptiveThresholdRowsSpecified' : Boolean
            // ValueType RelOpType at 'EstimatedTotalSubtreeCost' : Double
            // ValueType RelOpType at 'TableCardinality' : Double
            // ValueType RelOpType at 'TableCardinalitySpecified' : Boolean
            // ValueType RelOpType at 'StatsCollectionId' : UInt64
            // ValueType RelOpType at 'StatsCollectionIdSpecified' : Boolean
            // ValueType RelOpType at 'EstimatedJoinType' : PhysicalOpType
            // ValueType RelOpType at 'EstimatedJoinTypeSpecified' : Boolean
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
            // ShowPlanBase RemoteFetchType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // String RemoteType at 'RemoteDestination' : String
            // String RemoteType at 'RemoteSource' : String
            // String RemoteType at 'RemoteObject' : String
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase RemoteModifyType at 'SetPredicate' : ScalarExpressionType
            if (SetPredicate is object) { state = visitor.Visit(this.SetPredicate, state); }
            // ShowPlanBase RemoteModifyType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // String RemoteType at 'RemoteDestination' : String
            // String RemoteType at 'RemoteSource' : String
            // String RemoteType at 'RemoteObject' : String
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // String RemoteQueryType at 'RemoteQuery' : String
            // String RemoteType at 'RemoteDestination' : String
            // String RemoteType at 'RemoteSource' : String
            // String RemoteType at 'RemoteObject' : String
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase RemoteRangeType at 'SeekPredicates' : SeekPredicatesType
            if (SeekPredicates is object) { state = visitor.Visit(this.SeekPredicates, state); }
            // String RemoteType at 'RemoteDestination' : String
            // String RemoteType at 'RemoteSource' : String
            // String RemoteType at 'RemoteObject' : String
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // String RemoteType at 'RemoteDestination' : String
            // String RemoteType at 'RemoteSource' : String
            // String RemoteType at 'RemoteObject' : String
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> RollupInfoType at 'RollupLevel' : RollupLevelType
            if (this.RollupLevel is object) {
                foreach (RollupLevelType item in this.RollupLevel) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RollupInfoType at 'HighestLevel' : Int32
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
            // ValueType RollupLevelType at 'Level' : Int32
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
            // Collection<> RowsetType at 'Object' : ObjectType
            if (this.Object is object) {
                foreach (ObjectType item in this.Object) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> RunTimeInformationType at 'RunTimeCountersPerThread' : RunTimeInformationTypeRunTimeCountersPerThread
            if (this.RunTimeCountersPerThread is object) {
                foreach (RunTimeInformationTypeRunTimeCountersPerThread item in this.RunTimeCountersPerThread) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'Thread' : Int32
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'BrickId' : Int32
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'BrickIdSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualRebinds' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualRebindsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualRewinds' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualRewindsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualRows' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualRowsRead' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualRowsReadSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'Batches' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'BatchesSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualEndOfScans' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualExecutions' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualExecutionMode' : ExecutionModeType
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualExecutionModeSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'TaskAddr' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'TaskAddrSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'SchedulerId' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'SchedulerIdSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'FirstActiveTime' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'FirstActiveTimeSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'LastActiveTime' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'LastActiveTimeSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'OpenTime' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'OpenTimeSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'FirstRowTime' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'FirstRowTimeSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'LastRowTime' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'LastRowTimeSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'CloseTime' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'CloseTimeSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualElapsedms' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualElapsedmsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualCPUms' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualCPUmsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualScans' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualScansSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLogicalReads' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLogicalReadsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualPhysicalReads' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualPhysicalReadsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualReadAheads' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualReadAheadsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLobLogicalReads' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLobLogicalReadsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLobPhysicalReads' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLobPhysicalReadsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLobReadAheads' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLobReadAheadsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'SegmentReads' : Int32
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'SegmentReadsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'SegmentSkips' : Int32
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'SegmentSkipsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLocallyAggregatedRows' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualLocallyAggregatedRowsSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'InputMemoryGrant' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'InputMemoryGrantSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'OutputMemoryGrant' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'OutputMemoryGrantSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'UsedMemoryGrant' : UInt64
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'UsedMemoryGrantSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'IsInterleavedExecuted' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'IsInterleavedExecutedSpecified' : Boolean
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualJoinType' : PhysicalOpType
            // ValueType RunTimeInformationTypeRunTimeCountersPerThread at 'ActualJoinTypeSpecified' : Boolean
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
            // ShowPlanBase RunTimePartitionSummaryType at 'PartitionsAccessed' : RunTimePartitionSummaryTypePartitionsAccessed
            if (PartitionsAccessed is object) { state = visitor.Visit(this.PartitionsAccessed, state); }
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
            // Collection<> RunTimePartitionSummaryTypePartitionsAccessed at 'PartitionRange' : RunTimePartitionSummaryTypePartitionsAccessedPartitionRange
            if (this.PartitionRange is object) {
                foreach (RunTimePartitionSummaryTypePartitionsAccessedPartitionRange item in this.PartitionRange) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RunTimePartitionSummaryTypePartitionsAccessed at 'PartitionRangeSpecified' : Boolean
            // ValueType RunTimePartitionSummaryTypePartitionsAccessed at 'PartitionCount' : UInt64
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
            // ValueType RunTimePartitionSummaryTypePartitionsAccessedPartitionRange at 'Start' : UInt64
            // ValueType RunTimePartitionSummaryTypePartitionsAccessedPartitionRange at 'End' : UInt64
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
            // Collection<> ScalarExpressionListType at 'ScalarOperator' : ScalarType
            if (this.ScalarOperator is object) {
                foreach (ScalarType item in this.ScalarOperator) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // ShowPlanBase ScalarExpressionType at 'ScalarOperator' : ScalarType
            if (ScalarOperator is object) { state = visitor.Visit(this.ScalarOperator, state); }
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
            // ShowPlanBase ScalarInsertType at 'SetPredicate' : ScalarExpressionType
            if (SetPredicate is object) { state = visitor.Visit(this.SetPredicate, state); }
            // ValueType ScalarInsertType at 'DMLRequestSort' : Boolean
            // ValueType ScalarInsertType at 'DMLRequestSortSpecified' : Boolean
            // Collection<> RowsetType at 'Object' : ObjectType
            if (this.Object is object) {
                foreach (ObjectType item in this.Object) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // String ScalarSequenceType at 'FunctionName' : String
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
            // ShowPlanBase ScalarType at 'Aggregate' : AggregateType
            if (Aggregate is object) { state = visitor.Visit(this.Aggregate, state); }
            // ShowPlanBase ScalarType at 'Arithmetic' : ArithmeticType
            if (Arithmetic is object) { state = visitor.Visit(this.Arithmetic, state); }
            // ShowPlanBase ScalarType at 'Assign' : AssignType
            if (Assign is object) { state = visitor.Visit(this.Assign, state); }
            // ShowPlanBase ScalarType at 'Compare' : CompareType
            if (Compare is object) { state = visitor.Visit(this.Compare, state); }
            // ShowPlanBase ScalarType at 'Const' : ConstType
            if (Const is object) { state = visitor.Visit(this.Const, state); }
            // ShowPlanBase ScalarType at 'Convert' : ConvertType
            if (Convert is object) { state = visitor.Visit(this.Convert, state); }
            // ShowPlanBase ScalarType at 'Identifier' : IdentType
            if (Identifier is object) { state = visitor.Visit(this.Identifier, state); }
            // ShowPlanBase ScalarType at 'IF' : ConditionalType
            if (IF is object) { state = visitor.Visit(this.IF, state); }
            // ShowPlanBase ScalarType at 'Intrinsic' : IntrinsicType
            if (Intrinsic is object) { state = visitor.Visit(this.Intrinsic, state); }
            // ShowPlanBase ScalarType at 'Logical' : LogicalType
            if (Logical is object) { state = visitor.Visit(this.Logical, state); }
            // Collection<> ScalarType at 'MultipleAssign' : AssignType
            if (this.MultipleAssign is object) {
                foreach (AssignType item in this.MultipleAssign) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ScalarType at 'MultipleAssignSpecified' : Boolean
            // Collection<> ScalarType at 'ScalarExpressionList' : ScalarType
            if (this.ScalarExpressionList is object) {
                foreach (ScalarType item in this.ScalarExpressionList) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ScalarType at 'ScalarExpressionListSpecified' : Boolean
            // ShowPlanBase ScalarType at 'Sequence' : ScalarSequenceType
            if (Sequence is object) { state = visitor.Visit(this.Sequence, state); }
            // ShowPlanBase ScalarType at 'Subquery' : SubqueryType
            if (Subquery is object) { state = visitor.Visit(this.Subquery, state); }
            // ShowPlanBase ScalarType at 'UDTMethod' : UDTMethodType
            if (UDTMethod is object) { state = visitor.Visit(this.UDTMethod, state); }
            // ShowPlanBase ScalarType at 'UserDefinedAggregate' : UDAggregateType
            if (UserDefinedAggregate is object) { state = visitor.Visit(this.UserDefinedAggregate, state); }
            // ShowPlanBase ScalarType at 'UserDefinedFunction' : UDFType
            if (UserDefinedFunction is object) { state = visitor.Visit(this.UserDefinedFunction, state); }
            // ShowPlanBase ScalarType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
            // String ScalarType at 'ScalarString' : String
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
            // Collection<> ScanRangeType at 'RangeColumns' : ColumnReferenceType
            if (this.RangeColumns is object) {
                foreach (ColumnReferenceType item in this.RangeColumns) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> ScanRangeType at 'RangeExpressions' : ScalarType
            if (this.RangeExpressions is object) {
                foreach (ScalarType item in this.RangeExpressions) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ScanRangeType at 'ScanType' : CompareOpType
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
            // Collection<> SeekPredicateNewType at 'SeekKeys' : SeekPredicateType
            if (this.SeekKeys is object) {
                foreach (SeekPredicateType item in this.SeekKeys) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // Collection<> SeekPredicatePartType at 'SeekPredicateNew' : SeekPredicateNewType
            if (this.SeekPredicateNew is object) {
                foreach (SeekPredicateNewType item in this.SeekPredicateNew) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType SeekPredicatePartType at 'SeekPredicateNewSpecified' : Boolean
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
            // Collection<> SeekPredicatesType at 'SeekPredicate' : SeekPredicateType
            if (this.SeekPredicate is object) {
                foreach (SeekPredicateType item in this.SeekPredicate) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType SeekPredicatesType at 'SeekPredicateSpecified' : Boolean
            // Collection<> SeekPredicatesType at 'SeekPredicateNew' : SeekPredicateNewType
            if (this.SeekPredicateNew is object) {
                foreach (SeekPredicateNewType item in this.SeekPredicateNew) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType SeekPredicatesType at 'SeekPredicateNewSpecified' : Boolean
            // Collection<> SeekPredicatesType at 'SeekPredicatePart' : SeekPredicatePartType
            if (this.SeekPredicatePart is object) {
                foreach (SeekPredicatePartType item in this.SeekPredicatePart) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType SeekPredicatesType at 'SeekPredicatePartSpecified' : Boolean
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
            // ShowPlanBase SeekPredicateType at 'Prefix' : ScanRangeType
            if (Prefix is object) { state = visitor.Visit(this.Prefix, state); }
            // ShowPlanBase SeekPredicateType at 'StartRange' : ScanRangeType
            if (StartRange is object) { state = visitor.Visit(this.StartRange, state); }
            // ShowPlanBase SeekPredicateType at 'EndRange' : ScanRangeType
            if (EndRange is object) { state = visitor.Visit(this.EndRange, state); }
            // ShowPlanBase SeekPredicateType at 'IsNotNull' : SingleColumnReferenceType
            if (IsNotNull is object) { state = visitor.Visit(this.IsNotNull, state); }
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
            // Collection<> SegmentType at 'GroupBy' : ColumnReferenceType
            if (this.GroupBy is object) {
                foreach (ColumnReferenceType item in this.GroupBy) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ShowPlanBase SegmentType at 'SegmentColumn' : SingleColumnReferenceType
            if (SegmentColumn is object) { state = visitor.Visit(this.SegmentColumn, state); }
            // ShowPlanBase SegmentType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> SequenceType at 'RelOp' : RelOpType
            if (this.RelOp is object) {
                foreach (RelOpType item in this.RelOp) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ValueType SetOptionsType at 'ANSI_NULLS' : Boolean
            // ValueType SetOptionsType at 'ANSI_NULLSSpecified' : Boolean
            // ValueType SetOptionsType at 'ANSI_PADDING' : Boolean
            // ValueType SetOptionsType at 'ANSI_PADDINGSpecified' : Boolean
            // ValueType SetOptionsType at 'ANSI_WARNINGS' : Boolean
            // ValueType SetOptionsType at 'ANSI_WARNINGSSpecified' : Boolean
            // ValueType SetOptionsType at 'ARITHABORT' : Boolean
            // ValueType SetOptionsType at 'ARITHABORTSpecified' : Boolean
            // ValueType SetOptionsType at 'CONCAT_NULL_YIELDS_NULL' : Boolean
            // ValueType SetOptionsType at 'CONCAT_NULL_YIELDS_NULLSpecified' : Boolean
            // ValueType SetOptionsType at 'NUMERIC_ROUNDABORT' : Boolean
            // ValueType SetOptionsType at 'NUMERIC_ROUNDABORTSpecified' : Boolean
            // ValueType SetOptionsType at 'QUOTED_IDENTIFIER' : Boolean
            // ValueType SetOptionsType at 'QUOTED_IDENTIFIERSpecified' : Boolean
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
            // ValueType SetPredicateElementType at 'SetPredicateType' : SetPredicateType
            // ValueType SetPredicateElementType at 'SetPredicateTypeSpecified' : Boolean
            // ShowPlanBase ScalarExpressionType at 'ScalarOperator' : ScalarType
            if (ScalarOperator is object) { state = visitor.Visit(this.ScalarOperator, state); }
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
            // Collection<> ShowPlanXML at 'BatchSequence' : ShowPlanXMLBatchSequenceBatch
            if (this.BatchSequence is object) {
                foreach (ShowPlanXMLBatchSequenceBatch item in this.BatchSequence) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // String ShowPlanXML at 'Version' : String
            // String ShowPlanXML at 'Build' : String
            // ValueType ShowPlanXML at 'ClusteredMode' : Boolean
            // ValueType ShowPlanXML at 'ClusteredModeSpecified' : Boolean
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
            // Collection<> ShowPlanXMLBatchSequence at 'Batch' : ShowPlanXMLBatchSequenceBatch
            if (this.Batch is object) {
                foreach (ShowPlanXMLBatchSequenceBatch item in this.Batch) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // Collection<> ShowPlanXMLBatchSequenceBatch at 'Statements' : StmtBlockType
            if (this.Statements is object) {
                foreach (StmtBlockType item in this.Statements) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // ShowPlanBase SimpleIteratorOneChildType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase SimpleUpdateType at 'SeekPredicate' : SeekPredicateType
            if (SeekPredicate is object) { state = visitor.Visit(this.SeekPredicate, state); }
            // Collection<> SimpleUpdateType at 'SeekPredicateNew' : SeekPredicateType
            if (this.SeekPredicateNew is object) {
                foreach (SeekPredicateType item in this.SeekPredicateNew) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType SimpleUpdateType at 'SeekPredicateNewSpecified' : Boolean
            // ShowPlanBase SimpleUpdateType at 'SetPredicate' : ScalarExpressionType
            if (SetPredicate is object) { state = visitor.Visit(this.SetPredicate, state); }
            // ValueType SimpleUpdateType at 'DMLRequestSort' : Boolean
            // ValueType SimpleUpdateType at 'DMLRequestSortSpecified' : Boolean
            // Collection<> RowsetType at 'Object' : ObjectType
            if (this.Object is object) {
                foreach (ObjectType item in this.Object) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase SingleColumnReferenceType at 'ColumnReference' : ColumnReferenceType
            if (ColumnReference is object) { state = visitor.Visit(this.ColumnReference, state); }
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
            // ValueType SortSpillDetailsType at 'GrantedMemoryKb' : UInt64
            // ValueType SortSpillDetailsType at 'GrantedMemoryKbSpecified' : Boolean
            // ValueType SortSpillDetailsType at 'UsedMemoryKb' : UInt64
            // ValueType SortSpillDetailsType at 'UsedMemoryKbSpecified' : Boolean
            // ValueType SortSpillDetailsType at 'WritesToTempDb' : UInt64
            // ValueType SortSpillDetailsType at 'WritesToTempDbSpecified' : Boolean
            // ValueType SortSpillDetailsType at 'ReadsFromTempDb' : UInt64
            // ValueType SortSpillDetailsType at 'ReadsFromTempDbSpecified' : Boolean
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
            // Collection<> SortType at 'OrderBy' : OrderByTypeOrderByColumn
            if (this.OrderBy is object) {
                foreach (OrderByTypeOrderByColumn item in this.OrderBy) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ShowPlanBase SortType at 'PartitionId' : SingleColumnReferenceType
            if (PartitionId is object) { state = visitor.Visit(this.PartitionId, state); }
            // ShowPlanBase SortType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ValueType SortType at 'Distinct' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ValueType SpillToTempDbType at 'SpillLevel' : UInt64
            // ValueType SpillToTempDbType at 'SpillLevelSpecified' : Boolean
            // ValueType SpillToTempDbType at 'SpilledThreadCount' : UInt64
            // ValueType SpillToTempDbType at 'SpilledThreadCountSpecified' : Boolean
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
            // ShowPlanBase SplitType at 'ActionColumn' : SingleColumnReferenceType
            if (ActionColumn is object) { state = visitor.Visit(this.ActionColumn, state); }
            // ShowPlanBase SplitType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase SpoolType at 'SeekPredicate' : SeekPredicateType
            if (SeekPredicate is object) { state = visitor.Visit(this.SeekPredicate, state); }
            // Collection<> SpoolType at 'SeekPredicateNew' : SeekPredicateType
            if (this.SeekPredicateNew is object) {
                foreach (SeekPredicateType item in this.SeekPredicateNew) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType SpoolType at 'SeekPredicateNewSpecified' : Boolean
            // ShowPlanBase SpoolType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ValueType SpoolType at 'Stack' : Boolean
            // ValueType SpoolType at 'StackSpecified' : Boolean
            // ValueType SpoolType at 'PrimaryNodeId' : Int32
            // ValueType SpoolType at 'PrimaryNodeIdSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ValueType StarJoinInfoType at 'Root' : Boolean
            // ValueType StarJoinInfoType at 'RootSpecified' : Boolean
            // ValueType StarJoinInfoType at 'OperationType' : StarJoinInfoTypeOperationType
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
            // String StatsInfoType at 'Database' : String
            // String StatsInfoType at 'Schema' : String
            // String StatsInfoType at 'Table' : String
            // String StatsInfoType at 'Statistics' : String
            // ValueType StatsInfoType at 'ModificationCount' : UInt64
            // ValueType StatsInfoType at 'SamplingPercent' : Double
            // ValueType StatsInfoType at 'LastUpdate' : DateTime
            // ValueType StatsInfoType at 'LastUpdateSpecified' : Boolean
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
            // Collection<> StmtBlockType at 'StmtSimple' : StmtSimpleType
            if (this.StmtSimple is object) {
                foreach (StmtSimpleType item in this.StmtSimple) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType StmtBlockType at 'StmtSimpleSpecified' : Boolean
            // Collection<> StmtBlockType at 'StmtCond' : StmtCondType
            if (this.StmtCond is object) {
                foreach (StmtCondType item in this.StmtCond) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType StmtBlockType at 'StmtCondSpecified' : Boolean
            // Collection<> StmtBlockType at 'StmtCursor' : StmtCursorType
            if (this.StmtCursor is object) {
                foreach (StmtCursorType item in this.StmtCursor) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType StmtBlockType at 'StmtCursorSpecified' : Boolean
            // Collection<> StmtBlockType at 'StmtReceive' : StmtReceiveType
            if (this.StmtReceive is object) {
                foreach (StmtReceiveType item in this.StmtReceive) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType StmtBlockType at 'StmtReceiveSpecified' : Boolean
            // Collection<> StmtBlockType at 'StmtUseDb' : StmtUseDbType
            if (this.StmtUseDb is object) {
                foreach (StmtUseDbType item in this.StmtUseDb) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType StmtBlockType at 'StmtUseDbSpecified' : Boolean
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
            // ShowPlanBase StmtCondType at 'Condition' : StmtCondTypeCondition
            if (Condition is object) { state = visitor.Visit(this.Condition, state); }
            // ShowPlanBase StmtCondType at 'Then' : StmtCondTypeThen
            if (Then is object) { state = visitor.Visit(this.Then, state); }
            // ShowPlanBase StmtCondType at 'Else' : StmtCondTypeElse
            if (Else is object) { state = visitor.Visit(this.Else, state); }
            // ShowPlanBase BaseStmtInfoType at 'StatementSetOptions' : SetOptionsType
            if (StatementSetOptions is object) { state = visitor.Visit(this.StatementSetOptions, state); }
            // ValueType BaseStmtInfoType at 'StatementCompId' : Int32
            // ValueType BaseStmtInfoType at 'StatementCompIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementEstRows' : Double
            // ValueType BaseStmtInfoType at 'StatementEstRowsSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementId' : Int32
            // ValueType BaseStmtInfoType at 'StatementIdSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementOptmLevel' : String
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReason' : BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReasonSpecified' : Boolean
            // String BaseStmtInfoType at 'CardinalityEstimationModelVersion' : String
            // ValueType BaseStmtInfoType at 'StatementSubTreeCost' : Double
            // ValueType BaseStmtInfoType at 'StatementSubTreeCostSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementText' : String
            // String BaseStmtInfoType at 'StatementType' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideDB' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideName' : String
            // String BaseStmtInfoType at 'PlanGuideDB' : String
            // String BaseStmtInfoType at 'PlanGuideName' : String
            // String BaseStmtInfoType at 'ParameterizedText' : String
            // String BaseStmtInfoType at 'ParameterizedPlanHandle' : String
            // String BaseStmtInfoType at 'QueryHash' : String
            // String BaseStmtInfoType at 'QueryPlanHash' : String
            // String BaseStmtInfoType at 'RetrievedFromCache' : String
            // String BaseStmtInfoType at 'StatementSqlHandle' : String
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsId' : UInt64
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'ParentObjectId' : UInt64
            // ValueType BaseStmtInfoType at 'ParentObjectIdSpecified' : Boolean
            // String BaseStmtInfoType at 'BatchSqlHandle' : String
            // ValueType BaseStmtInfoType at 'StatementParameterizationType' : Int32
            // ValueType BaseStmtInfoType at 'StatementParameterizationTypeSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyApplied' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyAppliedSpecified' : Boolean
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
            // ShowPlanBase StmtCondTypeCondition at 'QueryPlan' : QueryPlanType
            if (QueryPlan is object) { state = visitor.Visit(this.QueryPlan, state); }
            // Collection<> StmtCondTypeCondition at 'UDF' : FunctionType
            if (this.UDF is object) {
                foreach (FunctionType item in this.UDF) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType StmtCondTypeCondition at 'UDFSpecified' : Boolean
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
            // ShowPlanBase StmtCondTypeElse at 'Statements' : StmtBlockType
            if (Statements is object) { state = visitor.Visit(this.Statements, state); }
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
            // ShowPlanBase StmtCondTypeThen at 'Statements' : StmtBlockType
            if (Statements is object) { state = visitor.Visit(this.Statements, state); }
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
            // ShowPlanBase StmtCursorType at 'CursorPlan' : CursorPlanType
            if (CursorPlan is object) { state = visitor.Visit(this.CursorPlan, state); }
            // ShowPlanBase BaseStmtInfoType at 'StatementSetOptions' : SetOptionsType
            if (StatementSetOptions is object) { state = visitor.Visit(this.StatementSetOptions, state); }
            // ValueType BaseStmtInfoType at 'StatementCompId' : Int32
            // ValueType BaseStmtInfoType at 'StatementCompIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementEstRows' : Double
            // ValueType BaseStmtInfoType at 'StatementEstRowsSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementId' : Int32
            // ValueType BaseStmtInfoType at 'StatementIdSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementOptmLevel' : String
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReason' : BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReasonSpecified' : Boolean
            // String BaseStmtInfoType at 'CardinalityEstimationModelVersion' : String
            // ValueType BaseStmtInfoType at 'StatementSubTreeCost' : Double
            // ValueType BaseStmtInfoType at 'StatementSubTreeCostSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementText' : String
            // String BaseStmtInfoType at 'StatementType' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideDB' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideName' : String
            // String BaseStmtInfoType at 'PlanGuideDB' : String
            // String BaseStmtInfoType at 'PlanGuideName' : String
            // String BaseStmtInfoType at 'ParameterizedText' : String
            // String BaseStmtInfoType at 'ParameterizedPlanHandle' : String
            // String BaseStmtInfoType at 'QueryHash' : String
            // String BaseStmtInfoType at 'QueryPlanHash' : String
            // String BaseStmtInfoType at 'RetrievedFromCache' : String
            // String BaseStmtInfoType at 'StatementSqlHandle' : String
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsId' : UInt64
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'ParentObjectId' : UInt64
            // ValueType BaseStmtInfoType at 'ParentObjectIdSpecified' : Boolean
            // String BaseStmtInfoType at 'BatchSqlHandle' : String
            // ValueType BaseStmtInfoType at 'StatementParameterizationType' : Int32
            // ValueType BaseStmtInfoType at 'StatementParameterizationTypeSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyApplied' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyAppliedSpecified' : Boolean
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
            // Collection<> StmtReceiveType at 'ReceivePlan' : ReceivePlanTypeOperation
            if (this.ReceivePlan is object) {
                foreach (ReceivePlanTypeOperation item in this.ReceivePlan) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ShowPlanBase BaseStmtInfoType at 'StatementSetOptions' : SetOptionsType
            if (StatementSetOptions is object) { state = visitor.Visit(this.StatementSetOptions, state); }
            // ValueType BaseStmtInfoType at 'StatementCompId' : Int32
            // ValueType BaseStmtInfoType at 'StatementCompIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementEstRows' : Double
            // ValueType BaseStmtInfoType at 'StatementEstRowsSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementId' : Int32
            // ValueType BaseStmtInfoType at 'StatementIdSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementOptmLevel' : String
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReason' : BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReasonSpecified' : Boolean
            // String BaseStmtInfoType at 'CardinalityEstimationModelVersion' : String
            // ValueType BaseStmtInfoType at 'StatementSubTreeCost' : Double
            // ValueType BaseStmtInfoType at 'StatementSubTreeCostSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementText' : String
            // String BaseStmtInfoType at 'StatementType' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideDB' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideName' : String
            // String BaseStmtInfoType at 'PlanGuideDB' : String
            // String BaseStmtInfoType at 'PlanGuideName' : String
            // String BaseStmtInfoType at 'ParameterizedText' : String
            // String BaseStmtInfoType at 'ParameterizedPlanHandle' : String
            // String BaseStmtInfoType at 'QueryHash' : String
            // String BaseStmtInfoType at 'QueryPlanHash' : String
            // String BaseStmtInfoType at 'RetrievedFromCache' : String
            // String BaseStmtInfoType at 'StatementSqlHandle' : String
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsId' : UInt64
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'ParentObjectId' : UInt64
            // ValueType BaseStmtInfoType at 'ParentObjectIdSpecified' : Boolean
            // String BaseStmtInfoType at 'BatchSqlHandle' : String
            // ValueType BaseStmtInfoType at 'StatementParameterizationType' : Int32
            // ValueType BaseStmtInfoType at 'StatementParameterizationTypeSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyApplied' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyAppliedSpecified' : Boolean
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
            // ShowPlanBase StmtSimpleType at 'QueryPlan' : QueryPlanType
            if (QueryPlan is object) { state = visitor.Visit(this.QueryPlan, state); }
            // Collection<> StmtSimpleType at 'UDF' : FunctionType
            if (this.UDF is object) {
                foreach (FunctionType item in this.UDF) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType StmtSimpleType at 'UDFSpecified' : Boolean
            // ShowPlanBase StmtSimpleType at 'StoredProc' : FunctionType
            if (StoredProc is object) { state = visitor.Visit(this.StoredProc, state); }
            // ShowPlanBase BaseStmtInfoType at 'StatementSetOptions' : SetOptionsType
            if (StatementSetOptions is object) { state = visitor.Visit(this.StatementSetOptions, state); }
            // ValueType BaseStmtInfoType at 'StatementCompId' : Int32
            // ValueType BaseStmtInfoType at 'StatementCompIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementEstRows' : Double
            // ValueType BaseStmtInfoType at 'StatementEstRowsSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementId' : Int32
            // ValueType BaseStmtInfoType at 'StatementIdSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementOptmLevel' : String
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReason' : BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReasonSpecified' : Boolean
            // String BaseStmtInfoType at 'CardinalityEstimationModelVersion' : String
            // ValueType BaseStmtInfoType at 'StatementSubTreeCost' : Double
            // ValueType BaseStmtInfoType at 'StatementSubTreeCostSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementText' : String
            // String BaseStmtInfoType at 'StatementType' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideDB' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideName' : String
            // String BaseStmtInfoType at 'PlanGuideDB' : String
            // String BaseStmtInfoType at 'PlanGuideName' : String
            // String BaseStmtInfoType at 'ParameterizedText' : String
            // String BaseStmtInfoType at 'ParameterizedPlanHandle' : String
            // String BaseStmtInfoType at 'QueryHash' : String
            // String BaseStmtInfoType at 'QueryPlanHash' : String
            // String BaseStmtInfoType at 'RetrievedFromCache' : String
            // String BaseStmtInfoType at 'StatementSqlHandle' : String
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsId' : UInt64
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'ParentObjectId' : UInt64
            // ValueType BaseStmtInfoType at 'ParentObjectIdSpecified' : Boolean
            // String BaseStmtInfoType at 'BatchSqlHandle' : String
            // ValueType BaseStmtInfoType at 'StatementParameterizationType' : Int32
            // ValueType BaseStmtInfoType at 'StatementParameterizationTypeSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyApplied' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyAppliedSpecified' : Boolean
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
            // String StmtUseDbType at 'Database' : String
            // ShowPlanBase BaseStmtInfoType at 'StatementSetOptions' : SetOptionsType
            if (StatementSetOptions is object) { state = visitor.Visit(this.StatementSetOptions, state); }
            // ValueType BaseStmtInfoType at 'StatementCompId' : Int32
            // ValueType BaseStmtInfoType at 'StatementCompIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementEstRows' : Double
            // ValueType BaseStmtInfoType at 'StatementEstRowsSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'StatementId' : Int32
            // ValueType BaseStmtInfoType at 'StatementIdSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementOptmLevel' : String
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReason' : BaseStmtInfoTypeStatementOptmEarlyAbortReason
            // ValueType BaseStmtInfoType at 'StatementOptmEarlyAbortReasonSpecified' : Boolean
            // String BaseStmtInfoType at 'CardinalityEstimationModelVersion' : String
            // ValueType BaseStmtInfoType at 'StatementSubTreeCost' : Double
            // ValueType BaseStmtInfoType at 'StatementSubTreeCostSpecified' : Boolean
            // String BaseStmtInfoType at 'StatementText' : String
            // String BaseStmtInfoType at 'StatementType' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideDB' : String
            // String BaseStmtInfoType at 'TemplatePlanGuideName' : String
            // String BaseStmtInfoType at 'PlanGuideDB' : String
            // String BaseStmtInfoType at 'PlanGuideName' : String
            // String BaseStmtInfoType at 'ParameterizedText' : String
            // String BaseStmtInfoType at 'ParameterizedPlanHandle' : String
            // String BaseStmtInfoType at 'QueryHash' : String
            // String BaseStmtInfoType at 'QueryPlanHash' : String
            // String BaseStmtInfoType at 'RetrievedFromCache' : String
            // String BaseStmtInfoType at 'StatementSqlHandle' : String
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsId' : UInt64
            // ValueType BaseStmtInfoType at 'DatabaseContextSettingsIdSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'ParentObjectId' : UInt64
            // ValueType BaseStmtInfoType at 'ParentObjectIdSpecified' : Boolean
            // String BaseStmtInfoType at 'BatchSqlHandle' : String
            // ValueType BaseStmtInfoType at 'StatementParameterizationType' : Int32
            // ValueType BaseStmtInfoType at 'StatementParameterizationTypeSpecified' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyApplied' : Boolean
            // ValueType BaseStmtInfoType at 'SecurityPolicyAppliedSpecified' : Boolean
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
            // Collection<> StreamAggregateType at 'GroupBy' : ColumnReferenceType
            if (this.GroupBy is object) {
                foreach (ColumnReferenceType item in this.GroupBy) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType StreamAggregateType at 'GroupBySpecified' : Boolean
            // ShowPlanBase StreamAggregateType at 'RollupInfo' : RollupInfoType
            if (RollupInfo is object) { state = visitor.Visit(this.RollupInfo, state); }
            // ShowPlanBase StreamAggregateType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase SubqueryType at 'ScalarOperator' : ScalarType
            if (ScalarOperator is object) { state = visitor.Visit(this.ScalarOperator, state); }
            // ShowPlanBase SubqueryType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ValueType SubqueryType at 'Operation' : SubqueryOperationType
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
            // ShowPlanBase SwitchType at 'Predicate' : ScalarExpressionType
            if (Predicate is object) { state = visitor.Visit(this.Predicate, state); }
            // Collection<> ConcatType at 'RelOp' : RelOpType
            if (this.RelOp is object) {
                foreach (RelOpType item in this.RelOp) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase TableScanType at 'Predicate' : ScalarExpressionType
            if (Predicate is object) { state = visitor.Visit(this.Predicate, state); }
            // ShowPlanBase TableScanType at 'PartitionId' : SingleColumnReferenceType
            if (PartitionId is object) { state = visitor.Visit(this.PartitionId, state); }
            // Collection<> TableScanType at 'IndexedViewInfo' : ObjectType
            if (this.IndexedViewInfo is object) {
                foreach (ObjectType item in this.IndexedViewInfo) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType TableScanType at 'IndexedViewInfoSpecified' : Boolean
            // ValueType TableScanType at 'Ordered' : Boolean
            // ValueType TableScanType at 'ForcedIndex' : Boolean
            // ValueType TableScanType at 'ForcedIndexSpecified' : Boolean
            // ValueType TableScanType at 'ForceScan' : Boolean
            // ValueType TableScanType at 'ForceScanSpecified' : Boolean
            // ValueType TableScanType at 'NoExpandHint' : Boolean
            // ValueType TableScanType at 'NoExpandHintSpecified' : Boolean
            // ValueType TableScanType at 'Storage' : StorageType
            // ValueType TableScanType at 'StorageSpecified' : Boolean
            // Collection<> RowsetType at 'Object' : ObjectType
            if (this.Object is object) {
                foreach (ObjectType item in this.Object) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase TableValuedFunctionType at 'Object' : ObjectType
            if (Object is object) { state = visitor.Visit(this.Object, state); }
            // ShowPlanBase TableValuedFunctionType at 'Predicate' : ScalarExpressionType
            if (Predicate is object) { state = visitor.Visit(this.Predicate, state); }
            // ShowPlanBase TableValuedFunctionType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> TableValuedFunctionType at 'ParameterList' : ScalarType
            if (this.ParameterList is object) {
                foreach (ScalarType item in this.ParameterList) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType TableValuedFunctionType at 'ParameterListSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ValueType ThreadReservationType at 'NodeId' : Int32
            // ValueType ThreadReservationType at 'ReservedThreads' : Int32
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
            // Collection<> ThreadStatType at 'ThreadReservation' : ThreadReservationType
            if (this.ThreadReservation is object) {
                foreach (ThreadReservationType item in this.ThreadReservation) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType ThreadStatType at 'ThreadReservationSpecified' : Boolean
            // ValueType ThreadStatType at 'Branches' : Int32
            // ValueType ThreadStatType at 'UsedThreads' : Int32
            // ValueType ThreadStatType at 'UsedThreadsSpecified' : Boolean
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
            // ValueType TopSortType at 'Rows' : Int32
            // ValueType TopSortType at 'WithTies' : Boolean
            // ValueType TopSortType at 'WithTiesSpecified' : Boolean
            // Collection<> SortType at 'OrderBy' : OrderByTypeOrderByColumn
            if (this.OrderBy is object) {
                foreach (OrderByTypeOrderByColumn item in this.OrderBy) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ShowPlanBase SortType at 'PartitionId' : SingleColumnReferenceType
            if (PartitionId is object) { state = visitor.Visit(this.PartitionId, state); }
            // ShowPlanBase SortType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ValueType SortType at 'Distinct' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> TopType at 'TieColumns' : ColumnReferenceType
            if (this.TieColumns is object) {
                foreach (ColumnReferenceType item in this.TieColumns) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType TopType at 'TieColumnsSpecified' : Boolean
            // ShowPlanBase TopType at 'OffsetExpression' : ScalarExpressionType
            if (OffsetExpression is object) { state = visitor.Visit(this.OffsetExpression, state); }
            // ShowPlanBase TopType at 'TopExpression' : ScalarExpressionType
            if (TopExpression is object) { state = visitor.Visit(this.TopExpression, state); }
            // ShowPlanBase TopType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ValueType TopType at 'RowCount' : Boolean
            // ValueType TopType at 'RowCountSpecified' : Boolean
            // ValueType TopType at 'Rows' : Int32
            // ValueType TopType at 'RowsSpecified' : Boolean
            // ValueType TopType at 'IsPercent' : Boolean
            // ValueType TopType at 'IsPercentSpecified' : Boolean
            // ValueType TopType at 'WithTies' : Boolean
            // ValueType TopType at 'WithTiesSpecified' : Boolean
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> TraceFlagListType at 'TraceFlag' : TraceFlagType
            if (this.TraceFlag is object) {
                foreach (TraceFlagType item in this.TraceFlag) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType TraceFlagListType at 'IsCompileTime' : Boolean
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
            // ValueType TraceFlagType at 'Value' : UInt64
            // ValueType TraceFlagType at 'Scope' : TraceFlagScopeType
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
            // ShowPlanBase UDAggregateType at 'UDAggObject' : ObjectType
            if (UDAggObject is object) { state = visitor.Visit(this.UDAggObject, state); }
            // Collection<> UDAggregateType at 'ScalarOperator' : ScalarType
            if (this.ScalarOperator is object) {
                foreach (ScalarType item in this.ScalarOperator) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType UDAggregateType at 'ScalarOperatorSpecified' : Boolean
            // ValueType UDAggregateType at 'Distinct' : Boolean
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
            // Collection<> UDFType at 'ScalarOperator' : ScalarType
            if (this.ScalarOperator is object) {
                foreach (ScalarType item in this.ScalarOperator) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType UDFType at 'ScalarOperatorSpecified' : Boolean
            // ShowPlanBase UDFType at 'CLRFunction' : CLRFunctionType
            if (CLRFunction is object) { state = visitor.Visit(this.CLRFunction, state); }
            // String UDFType at 'FunctionName' : String
            // ValueType UDFType at 'IsClrFunction' : Boolean
            // ValueType UDFType at 'IsClrFunctionSpecified' : Boolean
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
            // ShowPlanBase UDTMethodType at 'CLRFunction' : CLRFunctionType
            if (CLRFunction is object) { state = visitor.Visit(this.CLRFunction, state); }
            // Collection<> UDTMethodType at 'ScalarOperator' : ScalarType
            if (this.ScalarOperator is object) {
                foreach (ScalarType item in this.ScalarOperator) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType UDTMethodType at 'ScalarOperatorSpecified' : Boolean
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
            // Collection<> UDXType at 'UsedUDXColumns' : ColumnReferenceType
            if (this.UsedUDXColumns is object) {
                foreach (ColumnReferenceType item in this.UsedUDXColumns) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType UDXType at 'UsedUDXColumnsSpecified' : Boolean
            // ShowPlanBase UDXType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // String UDXType at 'UDXName' : String
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> UnmatchedIndexesType at 'Parameterization' : ObjectType
            if (this.Parameterization is object) {
                foreach (ObjectType item in this.Parameterization) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
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
            // Collection<> UpdateType at 'SetPredicate' : SetPredicateElementType
            if (this.SetPredicate is object) {
                foreach (SetPredicateElementType item in this.SetPredicate) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType UpdateType at 'SetPredicateSpecified' : Boolean
            // ShowPlanBase UpdateType at 'ProbeColumn' : SingleColumnReferenceType
            if (ProbeColumn is object) { state = visitor.Visit(this.ProbeColumn, state); }
            // ShowPlanBase UpdateType at 'ActionColumn' : SingleColumnReferenceType
            if (ActionColumn is object) { state = visitor.Visit(this.ActionColumn, state); }
            // ShowPlanBase UpdateType at 'OriginalActionColumn' : SingleColumnReferenceType
            if (OriginalActionColumn is object) { state = visitor.Visit(this.OriginalActionColumn, state); }
            // ShowPlanBase UpdateType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // ValueType UpdateType at 'WithOrderedPrefetch' : Boolean
            // ValueType UpdateType at 'WithOrderedPrefetchSpecified' : Boolean
            // ValueType UpdateType at 'WithUnorderedPrefetch' : Boolean
            // ValueType UpdateType at 'WithUnorderedPrefetchSpecified' : Boolean
            // ValueType UpdateType at 'DMLRequestSort' : Boolean
            // ValueType UpdateType at 'DMLRequestSortSpecified' : Boolean
            // Collection<> RowsetType at 'Object' : ObjectType
            if (this.Object is object) {
                foreach (ObjectType item in this.Object) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // Collection<> WaitStatListType at 'Wait' : WaitStatType
            if (this.Wait is object) {
                foreach (WaitStatType item in this.Wait) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType WaitStatListType at 'WaitSpecified' : Boolean
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
            // String WaitStatType at 'WaitType' : String
            // ValueType WaitStatType at 'WaitTimeMs' : UInt64
            // ValueType WaitStatType at 'WaitCount' : UInt64
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
            // ValueType WaitWarningType at 'WaitType' : WaitWarningTypeWaitType
            // ValueType WaitWarningType at 'WaitTime' : UInt64
            // ValueType WaitWarningType at 'WaitTimeSpecified' : Boolean
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
            // Collection<> WarningsType at 'ColumnsWithNoStatistics' : ColumnReferenceListType
            if (this.ColumnsWithNoStatistics is object) {
                foreach (ColumnReferenceListType item in this.ColumnsWithNoStatistics) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType WarningsType at 'ColumnsWithNoStatisticsSpecified' : Boolean
            // Collection<> WarningsType at 'SpillToTempDb' : SpillToTempDbType
            if (this.SpillToTempDb is object) {
                foreach (SpillToTempDbType item in this.SpillToTempDb) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType WarningsType at 'SpillToTempDbSpecified' : Boolean
            // Collection<> WarningsType at 'Wait' : WaitWarningType
            if (this.Wait is object) {
                foreach (WaitWarningType item in this.Wait) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType WarningsType at 'WaitSpecified' : Boolean
            // Collection<> WarningsType at 'PlanAffectingConvert' : AffectingConvertWarningType
            if (this.PlanAffectingConvert is object) {
                foreach (AffectingConvertWarningType item in this.PlanAffectingConvert) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType WarningsType at 'PlanAffectingConvertSpecified' : Boolean
            // Collection<> WarningsType at 'SortSpillDetails' : SortSpillDetailsType
            if (this.SortSpillDetails is object) {
                foreach (SortSpillDetailsType item in this.SortSpillDetails) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType WarningsType at 'SortSpillDetailsSpecified' : Boolean
            // Collection<> WarningsType at 'HashSpillDetails' : HashSpillDetailsType
            if (this.HashSpillDetails is object) {
                foreach (HashSpillDetailsType item in this.HashSpillDetails) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType WarningsType at 'HashSpillDetailsSpecified' : Boolean
            // Collection<> WarningsType at 'MemoryGrantWarning' : MemoryGrantWarningInfo
            if (this.MemoryGrantWarning is object) {
                foreach (MemoryGrantWarningInfo item in this.MemoryGrantWarning) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType WarningsType at 'MemoryGrantWarningSpecified' : Boolean
            // ValueType WarningsType at 'NoJoinPredicate' : Boolean
            // ValueType WarningsType at 'NoJoinPredicateSpecified' : Boolean
            // ValueType WarningsType at 'SpatialGuess' : Boolean
            // ValueType WarningsType at 'SpatialGuessSpecified' : Boolean
            // ValueType WarningsType at 'UnmatchedIndexes' : Boolean
            // ValueType WarningsType at 'UnmatchedIndexesSpecified' : Boolean
            // ValueType WarningsType at 'FullUpdateForOnlineIndexBuild' : Boolean
            // ValueType WarningsType at 'FullUpdateForOnlineIndexBuildSpecified' : Boolean
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
            // ShowPlanBase WindowAggregateType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
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
            // ShowPlanBase WindowType at 'RelOp' : RelOpType
            if (RelOp is object) { state = visitor.Visit(this.RelOp, state); }
            // Collection<> RelOpBaseType at 'DefinedValues' : DefinedValuesListTypeDefinedValue
            if (this.DefinedValues is object) {
                foreach (DefinedValuesListTypeDefinedValue item in this.DefinedValues) {
                    if (item is object) {
                        state = visitor.Visit(item, state);
                    }
                }
            }
            // ValueType RelOpBaseType at 'DefinedValuesSpecified' : Boolean
            // ShowPlanBase RelOpBaseType at 'InternalInfo' : InternalInfoType
            if (InternalInfo is object) { state = visitor.Visit(this.InternalInfo, state); }
            return state;
        }
    }
}
