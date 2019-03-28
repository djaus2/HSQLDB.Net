/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.DatabaseMetaData
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("9FF7CA76-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.DatabaseMetaData")]
    public interface DatabaseMetaData :
        global::Java.Sql.Wrapper
    { 
        bool AllProceduresAreCallable();
    
    
        bool AllTablesAreSelectable();
    
    
        bool AutoCommitFailureClosesAllResultSets();
    
    
        bool DataDefinitionCausesTransactionCommit();
    
    
        bool DataDefinitionIgnoredInTransactions();
    
    
        bool DeletesAreDetected(int type);
    
    
        bool DoesMaxRowSizeIncludeBlobs();
    
    
        bool GeneratedKeyAlwaysReturned();
    
    
        global::Java.Sql.ResultSet GetAttributes(string catalog, string schemaPattern, string typeNamePattern, string attributeNamePattern);
    
    
        global::Java.Sql.ResultSet GetBestRowIdentifier(string catalog, string schema, string table, int scope, bool nullable);
    
    
        string GetCatalogSeparator();
    
    
        string GetCatalogTerm();
    
    
        global::Java.Sql.ResultSet GetCatalogs();
    
    
        global::Java.Sql.ResultSet GetClientInfoProperties();
    
    
        global::Java.Sql.ResultSet GetColumnPrivileges(string catalog, string schema, string table, string columnNamePattern);
    
    
        global::Java.Sql.ResultSet GetColumns(string catalog, string schemaPattern, string tableNamePattern, string columnNamePattern);
    
    
        global::Java.Sql.Connection GetConnection();
    
    
        global::Java.Sql.ResultSet GetCrossReference(string parentCatalog, string parentSchema, string parentTable, string foreignCatalog, string foreignSchema, string foreignTable);
    
    
        int GetDatabaseMajorVersion();
    
    
        int GetDatabaseMinorVersion();
    
    
        string GetDatabaseProductName();
    
    
        string GetDatabaseProductVersion();
    
    
        int GetDefaultTransactionIsolation();
    
    
        int GetDriverMajorVersion();
    
    
        int GetDriverMinorVersion();
    
    
        string GetDriverName();
    
    
        string GetDriverVersion();
    
    
        global::Java.Sql.ResultSet GetExportedKeys(string catalog, string schema, string table);
    
    
        string GetExtraNameCharacters();
    
    
        global::Java.Sql.ResultSet GetFunctionColumns(string catalog, string schemaPattern, string functionNamePattern, string columnNamePattern);
    
    
        global::Java.Sql.ResultSet GetFunctions(string catalog, string schemaPattern, string functionNamePattern);
    
    
        string GetIdentifierQuoteString();
    
    
        global::Java.Sql.ResultSet GetImportedKeys(string catalog, string schema, string table);
    
    
        global::Java.Sql.ResultSet GetIndexInfo(string catalog, string schema, string table, bool unique, bool approximate);
    
    
        int GetJDBCMajorVersion();
    
    
        int GetJDBCMinorVersion();
    
    
        int GetMaxBinaryLiteralLength();
    
    
        int GetMaxCatalogNameLength();
    
    
        int GetMaxCharLiteralLength();
    
    
        int GetMaxColumnNameLength();
    
    
        int GetMaxColumnsInGroupBy();
    
    
        int GetMaxColumnsInIndex();
    
    
        int GetMaxColumnsInOrderBy();
    
    
        int GetMaxColumnsInSelect();
    
    
        int GetMaxColumnsInTable();
    
    
        int GetMaxConnections();
    
    
        int GetMaxCursorNameLength();
    
    
        int GetMaxIndexLength();
    
    
        int GetMaxProcedureNameLength();
    
    
        int GetMaxRowSize();
    
    
        int GetMaxSchemaNameLength();
    
    
        int GetMaxStatementLength();
    
    
        int GetMaxStatements();
    
    
        int GetMaxTableNameLength();
    
    
        int GetMaxTablesInSelect();
    
    
        int GetMaxUserNameLength();
    
    
        string GetNumericFunctions();
    
    
        global::Java.Sql.ResultSet GetPrimaryKeys(string catalog, string schema, string table);
    
    
        global::Java.Sql.ResultSet GetProcedureColumns(string catalog, string schemaPattern, string procedureNamePattern, string columnNamePattern);
    
    
        string GetProcedureTerm();
    
    
        global::Java.Sql.ResultSet GetProcedures(string catalog, string schemaPattern, string procedureNamePattern);
    
    
        global::Java.Sql.ResultSet GetPseudoColumns(string catalog, string schemaPattern, string tableNamePattern, string columnNamePattern);
    
    
        int GetResultSetHoldability();
    
    
        global::Java.Sql.RowIdLifetime GetRowIdLifetime();
    
    
        string GetSQLKeywords();
    
    
        int GetSQLStateType();
    
    
        string GetSchemaTerm();
    
    
        global::Java.Sql.ResultSet GetSchemas();
    
    
        global::Java.Sql.ResultSet GetSchemas(string catalog, string schemaPattern);
    
    
        string GetSearchStringEscape();
    
    
        string GetStringFunctions();
    
    
        global::Java.Sql.ResultSet GetSuperTables(string catalog, string schemaPattern, string tableNamePattern);
    
    
        global::Java.Sql.ResultSet GetSuperTypes(string catalog, string schemaPattern, string typeNamePattern);
    
    
        string GetSystemFunctions();
    
    
        global::Java.Sql.ResultSet GetTablePrivileges(string catalog, string schemaPattern, string tableNamePattern);
    
    
        global::Java.Sql.ResultSet GetTableTypes();
    
    
        global::Java.Sql.ResultSet GetTables(string catalog, string schemaPattern, string tableNamePattern, global::Java.Lang.StringArray types);
    
    
        string GetTimeDateFunctions();
    
    
        global::Java.Sql.ResultSet GetTypeInfo();
    
    
        global::Java.Sql.ResultSet GetUDTs(string catalog, string schemaPattern, string typeNamePattern, global::Codemesh.JuggerNET.intArray types);
    
    
        string GetURL();
    
    
        string GetUserName();
    
    
        global::Java.Sql.ResultSet GetVersionColumns(string catalog, string schema, string table);
    
    
        bool InsertsAreDetected(int type);
    
    
        bool IsCatalogAtStart();
    
    
        bool IsReadOnly();
    
    
        bool LocatorsUpdateCopy();
    
    
        bool NullPlusNonNullIsNull();
    
    
        bool NullsAreSortedAtEnd();
    
    
        bool NullsAreSortedAtStart();
    
    
        bool NullsAreSortedHigh();
    
    
        bool NullsAreSortedLow();
    
    
        bool OthersDeletesAreVisible(int type);
    
    
        bool OthersInsertsAreVisible(int type);
    
    
        bool OthersUpdatesAreVisible(int type);
    
    
        bool OwnDeletesAreVisible(int type);
    
    
        bool OwnInsertsAreVisible(int type);
    
    
        bool OwnUpdatesAreVisible(int type);
    
    
        bool StoresLowerCaseIdentifiers();
    
    
        bool StoresLowerCaseQuotedIdentifiers();
    
    
        bool StoresMixedCaseIdentifiers();
    
    
        bool StoresMixedCaseQuotedIdentifiers();
    
    
        bool StoresUpperCaseIdentifiers();
    
    
        bool StoresUpperCaseQuotedIdentifiers();
    
    
        bool SupportsANSI92EntryLevelSQL();
    
    
        bool SupportsANSI92FullSQL();
    
    
        bool SupportsANSI92IntermediateSQL();
    
    
        bool SupportsAlterTableWithAddColumn();
    
    
        bool SupportsAlterTableWithDropColumn();
    
    
        bool SupportsBatchUpdates();
    
    
        bool SupportsCatalogsInDataManipulation();
    
    
        bool SupportsCatalogsInIndexDefinitions();
    
    
        bool SupportsCatalogsInPrivilegeDefinitions();
    
    
        bool SupportsCatalogsInProcedureCalls();
    
    
        bool SupportsCatalogsInTableDefinitions();
    
    
        bool SupportsColumnAliasing();
    
    
        bool SupportsConvert();
    
    
        bool SupportsConvert(int fromType, int toType);
    
    
        bool SupportsCoreSQLGrammar();
    
    
        bool SupportsCorrelatedSubqueries();
    
    
        bool SupportsDataDefinitionAndDataManipulationTransactions();
    
    
        bool SupportsDataManipulationTransactionsOnly();
    
    
        bool SupportsDifferentTableCorrelationNames();
    
    
        bool SupportsExpressionsInOrderBy();
    
    
        bool SupportsExtendedSQLGrammar();
    
    
        bool SupportsFullOuterJoins();
    
    
        bool SupportsGetGeneratedKeys();
    
    
        bool SupportsGroupBy();
    
    
        bool SupportsGroupByBeyondSelect();
    
    
        bool SupportsGroupByUnrelated();
    
    
        bool SupportsIntegrityEnhancementFacility();
    
    
        bool SupportsLikeEscapeClause();
    
    
        bool SupportsLimitedOuterJoins();
    
    
        bool SupportsMinimumSQLGrammar();
    
    
        bool SupportsMixedCaseIdentifiers();
    
    
        bool SupportsMixedCaseQuotedIdentifiers();
    
    
        bool SupportsMultipleOpenResults();
    
    
        bool SupportsMultipleResultSets();
    
    
        bool SupportsMultipleTransactions();
    
    
        bool SupportsNamedParameters();
    
    
        bool SupportsNonNullableColumns();
    
    
        bool SupportsOpenCursorsAcrossCommit();
    
    
        bool SupportsOpenCursorsAcrossRollback();
    
    
        bool SupportsOpenStatementsAcrossCommit();
    
    
        bool SupportsOpenStatementsAcrossRollback();
    
    
        bool SupportsOrderByUnrelated();
    
    
        bool SupportsOuterJoins();
    
    
        bool SupportsPositionedDelete();
    
    
        bool SupportsPositionedUpdate();
    
    
        bool SupportsResultSetConcurrency(int type, int concurrency);
    
    
        bool SupportsResultSetHoldability(int holdability);
    
    
        bool SupportsResultSetType(int type);
    
    
        bool SupportsSavepoints();
    
    
        bool SupportsSchemasInDataManipulation();
    
    
        bool SupportsSchemasInIndexDefinitions();
    
    
        bool SupportsSchemasInPrivilegeDefinitions();
    
    
        bool SupportsSchemasInProcedureCalls();
    
    
        bool SupportsSchemasInTableDefinitions();
    
    
        bool SupportsSelectForUpdate();
    
    
        bool SupportsStatementPooling();
    
    
        bool SupportsStoredFunctionsUsingCallSyntax();
    
    
        bool SupportsStoredProcedures();
    
    
        bool SupportsSubqueriesInComparisons();
    
    
        bool SupportsSubqueriesInExists();
    
    
        bool SupportsSubqueriesInIns();
    
    
        bool SupportsSubqueriesInQuantifieds();
    
    
        bool SupportsTableCorrelationNames();
    
    
        bool SupportsTransactionIsolationLevel(int level);
    
    
        bool SupportsTransactions();
    
    
        bool SupportsUnion();
    
    
        bool SupportsUnionAll();
    
    
        bool UpdatesAreDetected(int type);
    
    
        bool UsesLocalFilePerTable();
    
    
        bool UsesLocalFiles();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.DatabaseMetaData")]
    public class DatabaseMetaDataImpl :
        global::Java.Sql.WrapperImpl,
        global::Java.Sql.DatabaseMetaData
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun6;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun7;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun8;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun9;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun10;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun11;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun12;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun13;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun14;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun15;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun16;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun17;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun18;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun19;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun20;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun21;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun22;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun23;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun24;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun25;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun26;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun27;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun28;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun29;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun30;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun31;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun32;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun33;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun34;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun35;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun36;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun37;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun38;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun39;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun40;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun41;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun42;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun43;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun44;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun45;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun46;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun47;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun48;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun49;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun50;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun51;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun52;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun53;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun54;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun55;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun56;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun57;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun58;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun59;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun60;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun61;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun62;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun63;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun64;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun65;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun66;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun67;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun68;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun69;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun70;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun71;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun72;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun73;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun74;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun75;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun76;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun77;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun78;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun79;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun80;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun81;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun82;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun83;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun84;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun85;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun86;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun87;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun88;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun89;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun90;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun91;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun92;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun93;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun94;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun95;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun96;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun97;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun98;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun99;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun100;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun101;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun102;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun103;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun104;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun105;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun106;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun107;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun108;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun109;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun110;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun111;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun112;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun113;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun114;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun115;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun116;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun117;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun118;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun119;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun120;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun121;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun122;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun123;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun124;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun125;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun126;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun127;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun128;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun129;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun130;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun131;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun132;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun133;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun134;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun135;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun136;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun137;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun138;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun139;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun140;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun141;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun142;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun143;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun144;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun145;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun146;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun147;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun148;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun149;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun150;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun151;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun152;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun153;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun154;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun155;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun156;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun157;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun158;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun159;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun160;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun161;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun162;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun163;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun164;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun165;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun166;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun167;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun168;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun169;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun170;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun171;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun172;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun173;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun174;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun175;
    
        static DatabaseMetaDataImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.DatabaseMetaData", typeof(global::Java.Sql.DatabaseMetaData), typeof(global::Java.Sql.DatabaseMetaDataImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getMaxLogicalLobSize", "()J", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsRefCursors", "()Z", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "allProceduresAreCallable", "()Z", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "allTablesAreSelectable", "()Z", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "autoCommitFailureClosesAllResultSets", "()Z", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "dataDefinitionCausesTransactionCommit", "()Z", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "dataDefinitionIgnoredInTransactions", "()Z", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "deletesAreDetected", "(I)Z", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "doesMaxRowSizeIncludeBlobs", "()Z", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "generatedKeyAlwaysReturned", "()Z", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getAttributes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getBestRowIdentifier", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;IZ)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getCatalogs", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getCatalogSeparator", "()Ljava/lang/String;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getCatalogTerm", "()Ljava/lang/String;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getClientInfoProperties", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getColumnPrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Connection), "getConnection", "()Ljava/sql/Connection;", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getCrossReference", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDatabaseMajorVersion", "()I", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDatabaseMinorVersion", "()I", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getDatabaseProductName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getDatabaseProductVersion", "()Ljava/lang/String;", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDefaultTransactionIsolation", "()I", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDriverMajorVersion", "()I", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDriverMinorVersion", "()I", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getDriverName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getDriverVersion", "()Ljava/lang/String;", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getExportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getExtraNameCharacters", "()Ljava/lang/String;", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getFunctionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getFunctions", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getIdentifierQuoteString", "()Ljava/lang/String;", false, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getImportedKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getIndexInfo", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getJDBCMajorVersion", "()I", false, false, false );
            _cmj_fun37 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getJDBCMinorVersion", "()I", false, false, false );
            _cmj_fun38 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxBinaryLiteralLength", "()I", false, false, false );
            _cmj_fun39 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxCatalogNameLength", "()I", false, false, false );
            _cmj_fun40 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxCharLiteralLength", "()I", false, false, false );
            _cmj_fun41 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxColumnNameLength", "()I", false, false, false );
            _cmj_fun42 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxColumnsInGroupBy", "()I", false, false, false );
            _cmj_fun43 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxColumnsInIndex", "()I", false, false, false );
            _cmj_fun44 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxColumnsInOrderBy", "()I", false, false, false );
            _cmj_fun45 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxColumnsInSelect", "()I", false, false, false );
            _cmj_fun46 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxColumnsInTable", "()I", false, false, false );
            _cmj_fun47 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxConnections", "()I", false, false, false );
            _cmj_fun48 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxCursorNameLength", "()I", false, false, false );
            _cmj_fun49 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxIndexLength", "()I", false, false, false );
            _cmj_fun50 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxProcedureNameLength", "()I", false, false, false );
            _cmj_fun51 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxRowSize", "()I", false, false, false );
            _cmj_fun52 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxSchemaNameLength", "()I", false, false, false );
            _cmj_fun53 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxStatementLength", "()I", false, false, false );
            _cmj_fun54 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxStatements", "()I", false, false, false );
            _cmj_fun55 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxTableNameLength", "()I", false, false, false );
            _cmj_fun56 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxTablesInSelect", "()I", false, false, false );
            _cmj_fun57 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxUserNameLength", "()I", false, false, false );
            _cmj_fun58 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getNumericFunctions", "()Ljava/lang/String;", false, false, false );
            _cmj_fun59 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getPrimaryKeys", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun60 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getProcedureColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun61 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getProcedures", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun62 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getProcedureTerm", "()Ljava/lang/String;", false, false, false );
            _cmj_fun63 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getPseudoColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun64 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getResultSetHoldability", "()I", false, false, false );
            _cmj_fun65 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.RowIdLifetime), "getRowIdLifetime", "()Ljava/sql/RowIdLifetime;", false, false, false );
            _cmj_fun66 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getSchemas", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun67 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getSchemas", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun68 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getSchemaTerm", "()Ljava/lang/String;", false, false, false );
            _cmj_fun69 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getSearchStringEscape", "()Ljava/lang/String;", false, false, false );
            _cmj_fun70 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getSQLKeywords", "()Ljava/lang/String;", false, false, false );
            _cmj_fun71 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getSQLStateType", "()I", false, false, false );
            _cmj_fun72 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getStringFunctions", "()Ljava/lang/String;", false, false, false );
            _cmj_fun73 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getSuperTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun74 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getSuperTypes", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun75 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getSystemFunctions", "()Ljava/lang/String;", false, false, false );
            _cmj_fun76 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getTablePrivileges", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun77 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getTables", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun78 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getTableTypes", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun79 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getTimeDateFunctions", "()Ljava/lang/String;", false, false, false );
            _cmj_fun80 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getTypeInfo", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun81 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getUDTs", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[I)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun82 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getURL", "()Ljava/lang/String;", false, false, false );
            _cmj_fun83 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getUserName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun84 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getVersionColumns", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun85 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "insertsAreDetected", "(I)Z", false, false, false );
            _cmj_fun86 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isCatalogAtStart", "()Z", false, false, false );
            _cmj_fun87 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isReadOnly", "()Z", false, false, false );
            _cmj_fun88 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "locatorsUpdateCopy", "()Z", false, false, false );
            _cmj_fun89 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "nullPlusNonNullIsNull", "()Z", false, false, false );
            _cmj_fun90 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "nullsAreSortedAtEnd", "()Z", false, false, false );
            _cmj_fun91 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "nullsAreSortedAtStart", "()Z", false, false, false );
            _cmj_fun92 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "nullsAreSortedHigh", "()Z", false, false, false );
            _cmj_fun93 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "nullsAreSortedLow", "()Z", false, false, false );
            _cmj_fun94 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "othersDeletesAreVisible", "(I)Z", false, false, false );
            _cmj_fun95 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "othersInsertsAreVisible", "(I)Z", false, false, false );
            _cmj_fun96 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "othersUpdatesAreVisible", "(I)Z", false, false, false );
            _cmj_fun97 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "ownDeletesAreVisible", "(I)Z", false, false, false );
            _cmj_fun98 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "ownInsertsAreVisible", "(I)Z", false, false, false );
            _cmj_fun99 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "ownUpdatesAreVisible", "(I)Z", false, false, false );
            _cmj_fun100 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "storesLowerCaseIdentifiers", "()Z", false, false, false );
            _cmj_fun101 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "storesLowerCaseQuotedIdentifiers", "()Z", false, false, false );
            _cmj_fun102 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "storesMixedCaseIdentifiers", "()Z", false, false, false );
            _cmj_fun103 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "storesMixedCaseQuotedIdentifiers", "()Z", false, false, false );
            _cmj_fun104 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "storesUpperCaseIdentifiers", "()Z", false, false, false );
            _cmj_fun105 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "storesUpperCaseQuotedIdentifiers", "()Z", false, false, false );
            _cmj_fun106 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsAlterTableWithAddColumn", "()Z", false, false, false );
            _cmj_fun107 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsAlterTableWithDropColumn", "()Z", false, false, false );
            _cmj_fun108 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsANSI92EntryLevelSQL", "()Z", false, false, false );
            _cmj_fun109 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsANSI92FullSQL", "()Z", false, false, false );
            _cmj_fun110 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsANSI92IntermediateSQL", "()Z", false, false, false );
            _cmj_fun111 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsBatchUpdates", "()Z", false, false, false );
            _cmj_fun112 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsCatalogsInDataManipulation", "()Z", false, false, false );
            _cmj_fun113 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsCatalogsInIndexDefinitions", "()Z", false, false, false );
            _cmj_fun114 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsCatalogsInPrivilegeDefinitions", "()Z", false, false, false );
            _cmj_fun115 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsCatalogsInProcedureCalls", "()Z", false, false, false );
            _cmj_fun116 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsCatalogsInTableDefinitions", "()Z", false, false, false );
            _cmj_fun117 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsColumnAliasing", "()Z", false, false, false );
            _cmj_fun118 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsConvert", "()Z", false, false, false );
            _cmj_fun119 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsConvert", "(II)Z", false, false, false );
            _cmj_fun120 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsCoreSQLGrammar", "()Z", false, false, false );
            _cmj_fun121 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsCorrelatedSubqueries", "()Z", false, false, false );
            _cmj_fun122 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsDataDefinitionAndDataManipulationTransactions", "()Z", false, false, false );
            _cmj_fun123 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsDataManipulationTransactionsOnly", "()Z", false, false, false );
            _cmj_fun124 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsDifferentTableCorrelationNames", "()Z", false, false, false );
            _cmj_fun125 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsExpressionsInOrderBy", "()Z", false, false, false );
            _cmj_fun126 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsExtendedSQLGrammar", "()Z", false, false, false );
            _cmj_fun127 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsFullOuterJoins", "()Z", false, false, false );
            _cmj_fun128 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsGetGeneratedKeys", "()Z", false, false, false );
            _cmj_fun129 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsGroupBy", "()Z", false, false, false );
            _cmj_fun130 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsGroupByBeyondSelect", "()Z", false, false, false );
            _cmj_fun131 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsGroupByUnrelated", "()Z", false, false, false );
            _cmj_fun132 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsIntegrityEnhancementFacility", "()Z", false, false, false );
            _cmj_fun133 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsLikeEscapeClause", "()Z", false, false, false );
            _cmj_fun134 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsLimitedOuterJoins", "()Z", false, false, false );
            _cmj_fun135 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsMinimumSQLGrammar", "()Z", false, false, false );
            _cmj_fun136 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsMixedCaseIdentifiers", "()Z", false, false, false );
            _cmj_fun137 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsMixedCaseQuotedIdentifiers", "()Z", false, false, false );
            _cmj_fun138 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsMultipleOpenResults", "()Z", false, false, false );
            _cmj_fun139 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsMultipleResultSets", "()Z", false, false, false );
            _cmj_fun140 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsMultipleTransactions", "()Z", false, false, false );
            _cmj_fun141 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsNamedParameters", "()Z", false, false, false );
            _cmj_fun142 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsNonNullableColumns", "()Z", false, false, false );
            _cmj_fun143 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsOpenCursorsAcrossCommit", "()Z", false, false, false );
            _cmj_fun144 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsOpenCursorsAcrossRollback", "()Z", false, false, false );
            _cmj_fun145 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsOpenStatementsAcrossCommit", "()Z", false, false, false );
            _cmj_fun146 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsOpenStatementsAcrossRollback", "()Z", false, false, false );
            _cmj_fun147 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsOrderByUnrelated", "()Z", false, false, false );
            _cmj_fun148 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsOuterJoins", "()Z", false, false, false );
            _cmj_fun149 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsPositionedDelete", "()Z", false, false, false );
            _cmj_fun150 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsPositionedUpdate", "()Z", false, false, false );
            _cmj_fun151 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsResultSetConcurrency", "(II)Z", false, false, false );
            _cmj_fun152 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsResultSetHoldability", "(I)Z", false, false, false );
            _cmj_fun153 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsResultSetType", "(I)Z", false, false, false );
            _cmj_fun154 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSavepoints", "()Z", false, false, false );
            _cmj_fun155 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSchemasInDataManipulation", "()Z", false, false, false );
            _cmj_fun156 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSchemasInIndexDefinitions", "()Z", false, false, false );
            _cmj_fun157 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSchemasInPrivilegeDefinitions", "()Z", false, false, false );
            _cmj_fun158 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSchemasInProcedureCalls", "()Z", false, false, false );
            _cmj_fun159 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSchemasInTableDefinitions", "()Z", false, false, false );
            _cmj_fun160 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSelectForUpdate", "()Z", false, false, false );
            _cmj_fun161 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsStatementPooling", "()Z", false, false, false );
            _cmj_fun162 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsStoredFunctionsUsingCallSyntax", "()Z", false, false, false );
            _cmj_fun163 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsStoredProcedures", "()Z", false, false, false );
            _cmj_fun164 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSubqueriesInComparisons", "()Z", false, false, false );
            _cmj_fun165 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSubqueriesInExists", "()Z", false, false, false );
            _cmj_fun166 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSubqueriesInIns", "()Z", false, false, false );
            _cmj_fun167 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsSubqueriesInQuantifieds", "()Z", false, false, false );
            _cmj_fun168 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsTableCorrelationNames", "()Z", false, false, false );
            _cmj_fun169 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsTransactionIsolationLevel", "(I)Z", false, false, false );
            _cmj_fun170 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsTransactions", "()Z", false, false, false );
            _cmj_fun171 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsUnion", "()Z", false, false, false );
            _cmj_fun172 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "supportsUnionAll", "()Z", false, false, false );
            _cmj_fun173 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "updatesAreDetected", "(I)Z", false, false, false );
            _cmj_fun174 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "usesLocalFilePerTable", "()Z", false, false, false );
            _cmj_fun175 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "usesLocalFiles", "()Z", false, false, false );
        }
    
        public const short      AttributeNoNulls = 0;
        public const short      AttributeNullable = 1;
        public const short      AttributeNullableUnknown = 2;
        public const int        BestRowNotPseudo = 1;
        public const int        BestRowPseudo = 2;
        public const int        BestRowSession = 2;
        public const int        BestRowTemporary = 0;
        public const int        BestRowTransaction = 1;
        public const int        BestRowUnknown = 0;
        public const int        ColumnNoNulls = 0;
        public const int        ColumnNullable = 1;
        public const int        ColumnNullableUnknown = 2;
        public const int        FunctionColumnIn = 1;
        public const int        FunctionColumnInOut = 2;
        public const int        FunctionColumnOut = 3;
        public const int        FunctionColumnResult = 5;
        public const int        FunctionColumnUnknown = 0;
        public const int        FunctionNoNulls = 0;
        public const int        FunctionNoTable = 1;
        public const int        FunctionNullable = 1;
        public const int        FunctionNullableUnknown = 2;
        public const int        FunctionResultUnknown = 0;
        public const int        FunctionReturn = 4;
        public const int        FunctionReturnsTable = 2;
        public const int        ImportedKeyCascade = 0;
        public const int        ImportedKeyInitiallyDeferred = 5;
        public const int        ImportedKeyInitiallyImmediate = 6;
        public const int        ImportedKeyNoAction = 3;
        public const int        ImportedKeyNotDeferrable = 7;
        public const int        ImportedKeyRestrict = 1;
        public const int        ImportedKeySetDefault = 4;
        public const int        ImportedKeySetNull = 2;
        public const int        ProcedureColumnIn = 1;
        public const int        ProcedureColumnInOut = 2;
        public const int        ProcedureColumnOut = 4;
        public const int        ProcedureColumnResult = 3;
        public const int        ProcedureColumnReturn = 5;
        public const int        ProcedureColumnUnknown = 0;
        public const int        ProcedureNoNulls = 0;
        public const int        ProcedureNoResult = 1;
        public const int        ProcedureNullable = 1;
        public const int        ProcedureNullableUnknown = 2;
        public const int        ProcedureResultUnknown = 0;
        public const int        ProcedureReturnsResult = 2;
        public const int        SqlStateSQL = 2;
        public const int        SqlStateSQL99 = 2;
        public const int        SqlStateXOpen = 1;
        public const short      TableIndexClustered = 1;
        public const short      TableIndexHashed = 2;
        public const short      TableIndexOther = 3;
        public const short      TableIndexStatistic = 0;
        public const int        TypeNoNulls = 0;
        public const int        TypeNullable = 1;
        public const int        TypeNullableUnknown = 2;
        public const int        TypePredBasic = 2;
        public const int        TypePredChar = 1;
        public const int        TypePredNone = 0;
        public const int        TypeSearchable = 3;
        public const int        VersionColumnNotPseudo = 1;
        public const int        VersionColumnPseudo = 2;
        public const int        VersionColumnUnknown = 0;
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public DatabaseMetaDataImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type DatabaseMetaDataImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.DatabaseMetaData</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.DatabaseMetaDataImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.DatabaseMetaDataImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static long GetMaxLogicalLobSize()
        {
            return _cmj_fun0.CallLong( null );
        }        
        
        public static bool SupportsRefCursors()
        {
            return _cmj_fun1.CallBool( null );
        }        
        
        public bool AllProceduresAreCallable()
        {
            return _cmj_fun2.CallBool( this );
        }        
        
        public bool AllTablesAreSelectable()
        {
            return _cmj_fun3.CallBool( this );
        }        
        
        public bool AutoCommitFailureClosesAllResultSets()
        {
            return _cmj_fun4.CallBool( this );
        }        
        
        public bool DataDefinitionCausesTransactionCommit()
        {
            return _cmj_fun5.CallBool( this );
        }        
        
        public bool DataDefinitionIgnoredInTransactions()
        {
            return _cmj_fun6.CallBool( this );
        }        
        
        public bool DeletesAreDetected(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun7.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool DoesMaxRowSizeIncludeBlobs()
        {
            return _cmj_fun8.CallBool( this );
        }        
        
        public bool GeneratedKeyAlwaysReturned()
        {
            return _cmj_fun9.CallBool( this );
        }        
        
        public global::Java.Sql.ResultSet GetAttributes(string catalog, string schemaPattern, string typeNamePattern, string attributeNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(typeNamePattern).Add(attributeNamePattern) )
            {
                if(_cmj_fun10.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun10.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun10.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetBestRowIdentifier(string catalog, string schema, string table, int scope, bool nullable)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 5 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schema).Add(table).Add(scope).Add(nullable) )
            {
                if(_cmj_fun11.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun11.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun11.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetCatalogs()
        {
            if(_cmj_fun12.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun12.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun12.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public string GetCatalogSeparator()
        {
            return _cmj_fun13.CallString( this );
        }        
        
        public string GetCatalogTerm()
        {
            return _cmj_fun14.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetClientInfoProperties()
        {
            if(_cmj_fun15.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun15.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun15.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public global::Java.Sql.ResultSet GetColumnPrivileges(string catalog, string schema, string table, string columnNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schema).Add(table).Add(columnNamePattern) )
            {
                if(_cmj_fun16.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun16.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun16.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetColumns(string catalog, string schemaPattern, string tableNamePattern, string columnNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(tableNamePattern).Add(columnNamePattern) )
            {
                if(_cmj_fun17.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun17.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun17.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Connection GetConnection()
        {
            if(_cmj_fun18.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun18.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Connection)_cmj_fun18.CallObject( this, typeof(global::Java.Sql.Connection), false );
        
        }        
        
        public global::Java.Sql.ResultSet GetCrossReference(string parentCatalog, string parentSchema, string parentTable, string foreignCatalog, string foreignSchema, string foreignTable)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 6 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parentCatalog).Add(parentSchema).Add(parentTable).Add(foreignCatalog).Add(foreignSchema).Add(foreignTable) )
            {
                if(_cmj_fun19.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun19.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun19.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public int GetDatabaseMajorVersion()
        {
            return _cmj_fun20.CallInt( this );
        }        
        
        public int GetDatabaseMinorVersion()
        {
            return _cmj_fun21.CallInt( this );
        }        
        
        public string GetDatabaseProductName()
        {
            return _cmj_fun22.CallString( this );
        }        
        
        public string GetDatabaseProductVersion()
        {
            return _cmj_fun23.CallString( this );
        }        
        
        public int GetDefaultTransactionIsolation()
        {
            return _cmj_fun24.CallInt( this );
        }        
        
        public int GetDriverMajorVersion()
        {
            return _cmj_fun25.CallInt( this );
        }        
        
        public int GetDriverMinorVersion()
        {
            return _cmj_fun26.CallInt( this );
        }        
        
        public string GetDriverName()
        {
            return _cmj_fun27.CallString( this );
        }        
        
        public string GetDriverVersion()
        {
            return _cmj_fun28.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetExportedKeys(string catalog, string schema, string table)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schema).Add(table) )
            {
                if(_cmj_fun29.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun29.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun29.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public string GetExtraNameCharacters()
        {
            return _cmj_fun30.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetFunctionColumns(string catalog, string schemaPattern, string functionNamePattern, string columnNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(functionNamePattern).Add(columnNamePattern) )
            {
                if(_cmj_fun31.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun31.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun31.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetFunctions(string catalog, string schemaPattern, string functionNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(functionNamePattern) )
            {
                if(_cmj_fun32.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun32.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun32.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public string GetIdentifierQuoteString()
        {
            return _cmj_fun33.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetImportedKeys(string catalog, string schema, string table)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schema).Add(table) )
            {
                if(_cmj_fun34.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun34.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun34.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetIndexInfo(string catalog, string schema, string table, bool unique, bool approximate)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 5 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schema).Add(table).Add(unique).Add(approximate) )
            {
                if(_cmj_fun35.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun35.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun35.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public int GetJDBCMajorVersion()
        {
            return _cmj_fun36.CallInt( this );
        }        
        
        public int GetJDBCMinorVersion()
        {
            return _cmj_fun37.CallInt( this );
        }        
        
        public int GetMaxBinaryLiteralLength()
        {
            return _cmj_fun38.CallInt( this );
        }        
        
        public int GetMaxCatalogNameLength()
        {
            return _cmj_fun39.CallInt( this );
        }        
        
        public int GetMaxCharLiteralLength()
        {
            return _cmj_fun40.CallInt( this );
        }        
        
        public int GetMaxColumnNameLength()
        {
            return _cmj_fun41.CallInt( this );
        }        
        
        public int GetMaxColumnsInGroupBy()
        {
            return _cmj_fun42.CallInt( this );
        }        
        
        public int GetMaxColumnsInIndex()
        {
            return _cmj_fun43.CallInt( this );
        }        
        
        public int GetMaxColumnsInOrderBy()
        {
            return _cmj_fun44.CallInt( this );
        }        
        
        public int GetMaxColumnsInSelect()
        {
            return _cmj_fun45.CallInt( this );
        }        
        
        public int GetMaxColumnsInTable()
        {
            return _cmj_fun46.CallInt( this );
        }        
        
        public int GetMaxConnections()
        {
            return _cmj_fun47.CallInt( this );
        }        
        
        public int GetMaxCursorNameLength()
        {
            return _cmj_fun48.CallInt( this );
        }        
        
        public int GetMaxIndexLength()
        {
            return _cmj_fun49.CallInt( this );
        }        
        
        public int GetMaxProcedureNameLength()
        {
            return _cmj_fun50.CallInt( this );
        }        
        
        public int GetMaxRowSize()
        {
            return _cmj_fun51.CallInt( this );
        }        
        
        public int GetMaxSchemaNameLength()
        {
            return _cmj_fun52.CallInt( this );
        }        
        
        public int GetMaxStatementLength()
        {
            return _cmj_fun53.CallInt( this );
        }        
        
        public int GetMaxStatements()
        {
            return _cmj_fun54.CallInt( this );
        }        
        
        public int GetMaxTableNameLength()
        {
            return _cmj_fun55.CallInt( this );
        }        
        
        public int GetMaxTablesInSelect()
        {
            return _cmj_fun56.CallInt( this );
        }        
        
        public int GetMaxUserNameLength()
        {
            return _cmj_fun57.CallInt( this );
        }        
        
        public string GetNumericFunctions()
        {
            return _cmj_fun58.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetPrimaryKeys(string catalog, string schema, string table)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schema).Add(table) )
            {
                if(_cmj_fun59.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun59.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun59.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetProcedureColumns(string catalog, string schemaPattern, string procedureNamePattern, string columnNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(procedureNamePattern).Add(columnNamePattern) )
            {
                if(_cmj_fun60.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun60.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun60.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetProcedures(string catalog, string schemaPattern, string procedureNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(procedureNamePattern) )
            {
                if(_cmj_fun61.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun61.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun61.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public string GetProcedureTerm()
        {
            return _cmj_fun62.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetPseudoColumns(string catalog, string schemaPattern, string tableNamePattern, string columnNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(tableNamePattern).Add(columnNamePattern) )
            {
                if(_cmj_fun63.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun63.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun63.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public int GetResultSetHoldability()
        {
            return _cmj_fun64.CallInt( this );
        }        
        
        public global::Java.Sql.RowIdLifetime GetRowIdLifetime()
        {
            long    jnet_ref = (long)_cmj_fun65.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Sql.RowIdLifetime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }        
        
        public global::Java.Sql.ResultSet GetSchemas()
        {
            if(_cmj_fun66.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun66.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun66.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public global::Java.Sql.ResultSet GetSchemas(string catalog, string schemaPattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern) )
            {
                if(_cmj_fun67.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun67.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun67.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public string GetSchemaTerm()
        {
            return _cmj_fun68.CallString( this );
        }        
        
        public string GetSearchStringEscape()
        {
            return _cmj_fun69.CallString( this );
        }        
        
        public string GetSQLKeywords()
        {
            return _cmj_fun70.CallString( this );
        }        
        
        public int GetSQLStateType()
        {
            return _cmj_fun71.CallInt( this );
        }        
        
        public string GetStringFunctions()
        {
            return _cmj_fun72.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetSuperTables(string catalog, string schemaPattern, string tableNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(tableNamePattern) )
            {
                if(_cmj_fun73.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun73.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun73.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetSuperTypes(string catalog, string schemaPattern, string typeNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(typeNamePattern) )
            {
                if(_cmj_fun74.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun74.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun74.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public string GetSystemFunctions()
        {
            return _cmj_fun75.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetTablePrivileges(string catalog, string schemaPattern, string tableNamePattern)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(tableNamePattern) )
            {
                if(_cmj_fun76.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun76.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun76.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetTables(string catalog, string schemaPattern, string tableNamePattern, global::Java.Lang.StringArray types)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(tableNamePattern).Add(types) )
            {
                if(_cmj_fun77.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun77.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun77.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetTableTypes()
        {
            if(_cmj_fun78.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun78.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun78.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public string GetTimeDateFunctions()
        {
            return _cmj_fun79.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetTypeInfo()
        {
            if(_cmj_fun80.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun80.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun80.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public global::Java.Sql.ResultSet GetUDTs(string catalog, string schemaPattern, string typeNamePattern, global::Codemesh.JuggerNET.intArray types)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schemaPattern).Add(typeNamePattern).Add(types) )
            {
                if(_cmj_fun81.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun81.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun81.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public string GetURL()
        {
            return _cmj_fun82.CallString( this );
        }        
        
        public string GetUserName()
        {
            return _cmj_fun83.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetVersionColumns(string catalog, string schema, string table)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(catalog).Add(schema).Add(table) )
            {
                if(_cmj_fun84.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun84.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun84.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public bool InsertsAreDetected(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun85.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool IsCatalogAtStart()
        {
            return _cmj_fun86.CallBool( this );
        }        
        
        public bool IsReadOnly()
        {
            return _cmj_fun87.CallBool( this );
        }        
        
        public bool LocatorsUpdateCopy()
        {
            return _cmj_fun88.CallBool( this );
        }        
        
        public bool NullPlusNonNullIsNull()
        {
            return _cmj_fun89.CallBool( this );
        }        
        
        public bool NullsAreSortedAtEnd()
        {
            return _cmj_fun90.CallBool( this );
        }        
        
        public bool NullsAreSortedAtStart()
        {
            return _cmj_fun91.CallBool( this );
        }        
        
        public bool NullsAreSortedHigh()
        {
            return _cmj_fun92.CallBool( this );
        }        
        
        public bool NullsAreSortedLow()
        {
            return _cmj_fun93.CallBool( this );
        }        
        
        public bool OthersDeletesAreVisible(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun94.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool OthersInsertsAreVisible(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun95.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool OthersUpdatesAreVisible(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun96.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool OwnDeletesAreVisible(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun97.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool OwnInsertsAreVisible(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun98.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool OwnUpdatesAreVisible(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun99.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool StoresLowerCaseIdentifiers()
        {
            return _cmj_fun100.CallBool( this );
        }        
        
        public bool StoresLowerCaseQuotedIdentifiers()
        {
            return _cmj_fun101.CallBool( this );
        }        
        
        public bool StoresMixedCaseIdentifiers()
        {
            return _cmj_fun102.CallBool( this );
        }        
        
        public bool StoresMixedCaseQuotedIdentifiers()
        {
            return _cmj_fun103.CallBool( this );
        }        
        
        public bool StoresUpperCaseIdentifiers()
        {
            return _cmj_fun104.CallBool( this );
        }        
        
        public bool StoresUpperCaseQuotedIdentifiers()
        {
            return _cmj_fun105.CallBool( this );
        }        
        
        public bool SupportsAlterTableWithAddColumn()
        {
            return _cmj_fun106.CallBool( this );
        }        
        
        public bool SupportsAlterTableWithDropColumn()
        {
            return _cmj_fun107.CallBool( this );
        }        
        
        public bool SupportsANSI92EntryLevelSQL()
        {
            return _cmj_fun108.CallBool( this );
        }        
        
        public bool SupportsANSI92FullSQL()
        {
            return _cmj_fun109.CallBool( this );
        }        
        
        public bool SupportsANSI92IntermediateSQL()
        {
            return _cmj_fun110.CallBool( this );
        }        
        
        public bool SupportsBatchUpdates()
        {
            return _cmj_fun111.CallBool( this );
        }        
        
        public bool SupportsCatalogsInDataManipulation()
        {
            return _cmj_fun112.CallBool( this );
        }        
        
        public bool SupportsCatalogsInIndexDefinitions()
        {
            return _cmj_fun113.CallBool( this );
        }        
        
        public bool SupportsCatalogsInPrivilegeDefinitions()
        {
            return _cmj_fun114.CallBool( this );
        }        
        
        public bool SupportsCatalogsInProcedureCalls()
        {
            return _cmj_fun115.CallBool( this );
        }        
        
        public bool SupportsCatalogsInTableDefinitions()
        {
            return _cmj_fun116.CallBool( this );
        }        
        
        public bool SupportsColumnAliasing()
        {
            return _cmj_fun117.CallBool( this );
        }        
        
        public bool SupportsConvert()
        {
            return _cmj_fun118.CallBool( this );
        }        
        
        public bool SupportsConvert(int fromType, int toType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(fromType).Add(toType) )
            {
                return _cmj_fun119.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool SupportsCoreSQLGrammar()
        {
            return _cmj_fun120.CallBool( this );
        }        
        
        public bool SupportsCorrelatedSubqueries()
        {
            return _cmj_fun121.CallBool( this );
        }        
        
        public bool SupportsDataDefinitionAndDataManipulationTransactions()
        {
            return _cmj_fun122.CallBool( this );
        }        
        
        public bool SupportsDataManipulationTransactionsOnly()
        {
            return _cmj_fun123.CallBool( this );
        }        
        
        public bool SupportsDifferentTableCorrelationNames()
        {
            return _cmj_fun124.CallBool( this );
        }        
        
        public bool SupportsExpressionsInOrderBy()
        {
            return _cmj_fun125.CallBool( this );
        }        
        
        public bool SupportsExtendedSQLGrammar()
        {
            return _cmj_fun126.CallBool( this );
        }        
        
        public bool SupportsFullOuterJoins()
        {
            return _cmj_fun127.CallBool( this );
        }        
        
        public bool SupportsGetGeneratedKeys()
        {
            return _cmj_fun128.CallBool( this );
        }        
        
        public bool SupportsGroupBy()
        {
            return _cmj_fun129.CallBool( this );
        }        
        
        public bool SupportsGroupByBeyondSelect()
        {
            return _cmj_fun130.CallBool( this );
        }        
        
        public bool SupportsGroupByUnrelated()
        {
            return _cmj_fun131.CallBool( this );
        }        
        
        public bool SupportsIntegrityEnhancementFacility()
        {
            return _cmj_fun132.CallBool( this );
        }        
        
        public bool SupportsLikeEscapeClause()
        {
            return _cmj_fun133.CallBool( this );
        }        
        
        public bool SupportsLimitedOuterJoins()
        {
            return _cmj_fun134.CallBool( this );
        }        
        
        public bool SupportsMinimumSQLGrammar()
        {
            return _cmj_fun135.CallBool( this );
        }        
        
        public bool SupportsMixedCaseIdentifiers()
        {
            return _cmj_fun136.CallBool( this );
        }        
        
        public bool SupportsMixedCaseQuotedIdentifiers()
        {
            return _cmj_fun137.CallBool( this );
        }        
        
        public bool SupportsMultipleOpenResults()
        {
            return _cmj_fun138.CallBool( this );
        }        
        
        public bool SupportsMultipleResultSets()
        {
            return _cmj_fun139.CallBool( this );
        }        
        
        public bool SupportsMultipleTransactions()
        {
            return _cmj_fun140.CallBool( this );
        }        
        
        public bool SupportsNamedParameters()
        {
            return _cmj_fun141.CallBool( this );
        }        
        
        public bool SupportsNonNullableColumns()
        {
            return _cmj_fun142.CallBool( this );
        }        
        
        public bool SupportsOpenCursorsAcrossCommit()
        {
            return _cmj_fun143.CallBool( this );
        }        
        
        public bool SupportsOpenCursorsAcrossRollback()
        {
            return _cmj_fun144.CallBool( this );
        }        
        
        public bool SupportsOpenStatementsAcrossCommit()
        {
            return _cmj_fun145.CallBool( this );
        }        
        
        public bool SupportsOpenStatementsAcrossRollback()
        {
            return _cmj_fun146.CallBool( this );
        }        
        
        public bool SupportsOrderByUnrelated()
        {
            return _cmj_fun147.CallBool( this );
        }        
        
        public bool SupportsOuterJoins()
        {
            return _cmj_fun148.CallBool( this );
        }        
        
        public bool SupportsPositionedDelete()
        {
            return _cmj_fun149.CallBool( this );
        }        
        
        public bool SupportsPositionedUpdate()
        {
            return _cmj_fun150.CallBool( this );
        }        
        
        public bool SupportsResultSetConcurrency(int type, int concurrency)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type).Add(concurrency) )
            {
                return _cmj_fun151.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool SupportsResultSetHoldability(int holdability)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(holdability) )
            {
                return _cmj_fun152.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool SupportsResultSetType(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun153.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool SupportsSavepoints()
        {
            return _cmj_fun154.CallBool( this );
        }        
        
        public bool SupportsSchemasInDataManipulation()
        {
            return _cmj_fun155.CallBool( this );
        }        
        
        public bool SupportsSchemasInIndexDefinitions()
        {
            return _cmj_fun156.CallBool( this );
        }        
        
        public bool SupportsSchemasInPrivilegeDefinitions()
        {
            return _cmj_fun157.CallBool( this );
        }        
        
        public bool SupportsSchemasInProcedureCalls()
        {
            return _cmj_fun158.CallBool( this );
        }        
        
        public bool SupportsSchemasInTableDefinitions()
        {
            return _cmj_fun159.CallBool( this );
        }        
        
        public bool SupportsSelectForUpdate()
        {
            return _cmj_fun160.CallBool( this );
        }        
        
        public bool SupportsStatementPooling()
        {
            return _cmj_fun161.CallBool( this );
        }        
        
        public bool SupportsStoredFunctionsUsingCallSyntax()
        {
            return _cmj_fun162.CallBool( this );
        }        
        
        public bool SupportsStoredProcedures()
        {
            return _cmj_fun163.CallBool( this );
        }        
        
        public bool SupportsSubqueriesInComparisons()
        {
            return _cmj_fun164.CallBool( this );
        }        
        
        public bool SupportsSubqueriesInExists()
        {
            return _cmj_fun165.CallBool( this );
        }        
        
        public bool SupportsSubqueriesInIns()
        {
            return _cmj_fun166.CallBool( this );
        }        
        
        public bool SupportsSubqueriesInQuantifieds()
        {
            return _cmj_fun167.CallBool( this );
        }        
        
        public bool SupportsTableCorrelationNames()
        {
            return _cmj_fun168.CallBool( this );
        }        
        
        public bool SupportsTransactionIsolationLevel(int level)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(level) )
            {
                return _cmj_fun169.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool SupportsTransactions()
        {
            return _cmj_fun170.CallBool( this );
        }        
        
        public bool SupportsUnion()
        {
            return _cmj_fun171.CallBool( this );
        }        
        
        public bool SupportsUnionAll()
        {
            return _cmj_fun172.CallBool( this );
        }        
        
        public bool UpdatesAreDetected(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                return _cmj_fun173.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool UsesLocalFilePerTable()
        {
            return _cmj_fun174.CallBool( this );
        }        
        
        public bool UsesLocalFiles()
        {
            return _cmj_fun175.CallBool( this );
        }        
    }    
    

}
