namespace SqlAnalyseLibrary {
    public enum NodeElementKind {
        Unknown,
        
        /// <summary>
        /// Server
        /// </summary>
        Server,

        /// <summary>
        /// Database
        /// </summary>
        Database,

        /// <summary>
        /// Schema
        /// </summary>
        Schema,

        /// <summary>
        ///  for references a Table, View or ObjectAlias.
        /// </summary>
        Object,

        /// <summary>
        /// Table
        /// </summary>
        Table,

        /// <summary>
        /// View
        /// </summary>
        View,

        /// <summary>
        /// Stored Procedure
        /// </summary>
        Procedure,

        /// <summary>
        /// Function
        /// </summary>
        Function,

        Column,
        Index,
        //
        ColumnRegular,
        ColumnWildcard,
        ObjectAlias
    }
}
