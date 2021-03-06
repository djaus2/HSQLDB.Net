/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.Statement
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("687E5E63-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.Statement")]
    public interface Statement :
        global::Java.Sql.Wrapper,
        global::Java.Lang.AutoCloseable
    { 
        void AddBatch(string sql);
    
    
        void Cancel();
    
    
        void ClearBatch();
    
    
        void ClearWarnings();
    
    
        void CloseOnCompletion();
    
    
        bool Execute(string sql);
    
    
        bool Execute(string sql, int autoGeneratedKeys);
    
    
        bool Execute(string sql, global::Codemesh.JuggerNET.intArray columnIndexes);
    
    
        bool Execute(string sql, global::Java.Lang.StringArray columnNames);
    
    
        global::Codemesh.JuggerNET.intArray ExecuteBatch();
    
    
        global::Java.Sql.ResultSet ExecuteQuery(string sql);
    
    
        int ExecuteUpdate(string sql);
    
    
        int ExecuteUpdate(string sql, int autoGeneratedKeys);
    
    
        int ExecuteUpdate(string sql, global::Codemesh.JuggerNET.intArray columnIndexes);
    
    
        int ExecuteUpdate(string sql, global::Java.Lang.StringArray columnNames);
    
    
        global::Java.Sql.Connection GetConnection();
    
    
        int GetFetchDirection();
    
    
        int GetFetchSize();
    
    
        global::Java.Sql.ResultSet GetGeneratedKeys();
    
    
        int GetMaxFieldSize();
    
    
        int GetMaxRows();
    
    
        bool GetMoreResults();
    
    
        bool GetMoreResults(int current);
    
    
        int GetQueryTimeout();
    
    
        global::Java.Sql.ResultSet GetResultSet();
    
    
        int GetResultSetConcurrency();
    
    
        int GetResultSetHoldability();
    
    
        int GetResultSetType();
    
    
        int GetUpdateCount();
    
    
        global::Java.Sql.SQLWarning GetWarnings();
    
    
        bool IsCloseOnCompletion();
    
    
        bool IsClosed();
    
    
        bool IsPoolable();
    
    
        void SetCursorName(string name);
    
    
        void SetEscapeProcessing(bool enable);
    
    
        void SetFetchDirection(int direction);
    
    
        void SetFetchSize(int rows);
    
    
        void SetMaxFieldSize(int max);
    
    
        void SetMaxRows(int max);
    
    
        void SetPoolable(bool poolable);
    
    
        void SetQueryTimeout(int seconds);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.Statement")]
    public class StatementImpl :
        global::Java.Sql.WrapperImpl,
        global::Java.Sql.Statement
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
    
        static StatementImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.Statement", typeof(global::Java.Sql.Statement), typeof(global::Java.Sql.StatementImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Codemesh.JuggerNET.longArray), "executeLargeBatch", "()[J", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "executeLargeUpdate", "(Ljava/lang/String;)J", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "executeLargeUpdate", "(Ljava/lang/String;I)J", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "executeLargeUpdate", "(Ljava/lang/String;[I)J", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "executeLargeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)J", true, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getLargeMaxRows", "()J", true, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getLargeUpdateCount", "()J", true, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setLargeMaxRows", "(J)V", true, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "addBatch", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "cancel", "()V", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "clearBatch", "()V", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "clearWarnings", "()V", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "close", "()V", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "closeOnCompletion", "()V", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "execute", "(Ljava/lang/String;)Z", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "execute", "(Ljava/lang/String;I)Z", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "execute", "(Ljava/lang/String;[I)Z", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Codemesh.JuggerNET.intArray), "executeBatch", "()[I", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "executeUpdate", "(Ljava/lang/String;)I", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "executeUpdate", "(Ljava/lang/String;I)I", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "executeUpdate", "(Ljava/lang/String;[I)I", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Connection), "getConnection", "()Ljava/sql/Connection;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getFetchDirection", "()I", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getFetchSize", "()I", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getGeneratedKeys", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxFieldSize", "()I", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxRows", "()I", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getMoreResults", "()Z", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getMoreResults", "(I)Z", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getQueryTimeout", "()I", false, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getResultSet", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getResultSetConcurrency", "()I", false, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getResultSetHoldability", "()I", false, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getResultSetType", "()I", false, false, false );
            _cmj_fun37 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getUpdateCount", "()I", false, false, false );
            _cmj_fun38 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLWarning), "getWarnings", "()Ljava/sql/SQLWarning;", false, false, false );
            _cmj_fun39 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isClosed", "()Z", false, false, false );
            _cmj_fun40 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isCloseOnCompletion", "()Z", false, false, false );
            _cmj_fun41 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isPoolable", "()Z", false, false, false );
            _cmj_fun42 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCursorName", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun43 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setEscapeProcessing", "(Z)V", false, false, false );
            _cmj_fun44 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFetchDirection", "(I)V", false, false, false );
            _cmj_fun45 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFetchSize", "(I)V", false, false, false );
            _cmj_fun46 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setMaxFieldSize", "(I)V", false, false, false );
            _cmj_fun47 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setMaxRows", "(I)V", false, false, false );
            _cmj_fun48 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setPoolable", "(Z)V", false, false, false );
            _cmj_fun49 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setQueryTimeout", "(I)V", false, false, false );
        }
    
        public const int        CLOSE_ALL_RESULTS = 3;
        public const int        CLOSE_CURRENT_RESULT = 1;
        public const int        EXECUTE_FAILED = -3;
        public const int        KEEP_CURRENT_RESULT = 2;
        public const int        NO_GENERATED_KEYS = 2;
        public const int        RETURN_GENERATED_KEYS = 1;
        public const int        SUCCESS_NO_INFO = -2;
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public StatementImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type StatementImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.Statement</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.StatementImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.StatementImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static global::Codemesh.JuggerNET.longArray ExecuteLargeBatch()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Codemesh.JuggerNET.longArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Codemesh.JuggerNET.longArray)_cmj_fun0.CallObject( null, typeof(global::Codemesh.JuggerNET.longArray), false );
        
        }        
        
        public static long ExecuteLargeUpdate(string arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                return _cmj_fun1.CallLong( null, cmj_jmargs );
            }
        }        
        
        public static long ExecuteLargeUpdate(string arg0, int arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                return _cmj_fun2.CallLong( null, cmj_jmargs );
            }
        }        
        
        public static long ExecuteLargeUpdate(string arg0, global::Codemesh.JuggerNET.intArray arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                return _cmj_fun3.CallLong( null, cmj_jmargs );
            }
        }        
        
        public static long ExecuteLargeUpdate(string arg0, global::Java.Lang.StringArray arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                return _cmj_fun4.CallLong( null, cmj_jmargs );
            }
        }        
        
        public static long GetLargeMaxRows()
        {
            return _cmj_fun5.CallLong( null );
        }        
        
        public static long GetLargeUpdateCount()
        {
            return _cmj_fun6.CallLong( null );
        }        
        
        public static void SetLargeMaxRows(long arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                _cmj_fun7.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public void AddBatch(string sql)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql) )
            {
                _cmj_fun8.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void Cancel()
        {
            _cmj_fun9.CallVoid( this );
        }        
        
        public void ClearBatch()
        {
            _cmj_fun10.CallVoid( this );
        }        
        
        public void ClearWarnings()
        {
            _cmj_fun11.CallVoid( this );
        }        
        
        public void Close()
        {
            _cmj_fun12.CallVoid( this );
        }        
        
        public void CloseOnCompletion()
        {
            _cmj_fun13.CallVoid( this );
        }        
        
        public bool Execute(string sql)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql) )
            {
                return _cmj_fun14.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool Execute(string sql, int autoGeneratedKeys)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql).Add(autoGeneratedKeys) )
            {
                return _cmj_fun15.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool Execute(string sql, global::Codemesh.JuggerNET.intArray columnIndexes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql).Add(columnIndexes) )
            {
                return _cmj_fun16.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool Execute(string sql, global::Java.Lang.StringArray columnNames)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql).Add(columnNames) )
            {
                return _cmj_fun17.CallBool( this, cmj_jmargs );
            }
        }        
        
        public global::Codemesh.JuggerNET.intArray ExecuteBatch()
        {
            if(_cmj_fun18.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun18.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Codemesh.JuggerNET.intArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Codemesh.JuggerNET.intArray)_cmj_fun18.CallObject( this, typeof(global::Codemesh.JuggerNET.intArray), false );
        
        }        
        
        public global::Java.Sql.ResultSet ExecuteQuery(string sql)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql) )
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
        
        public int ExecuteUpdate(string sql)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql) )
            {
                return _cmj_fun20.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int ExecuteUpdate(string sql, int autoGeneratedKeys)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql).Add(autoGeneratedKeys) )
            {
                return _cmj_fun21.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int ExecuteUpdate(string sql, global::Codemesh.JuggerNET.intArray columnIndexes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql).Add(columnIndexes) )
            {
                return _cmj_fun22.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int ExecuteUpdate(string sql, global::Java.Lang.StringArray columnNames)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sql).Add(columnNames) )
            {
                return _cmj_fun23.CallInt( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.Connection GetConnection()
        {
            if(_cmj_fun24.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun24.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Connection)_cmj_fun24.CallObject( this, typeof(global::Java.Sql.Connection), false );
        
        }        
        
        public int GetFetchDirection()
        {
            return _cmj_fun25.CallInt( this );
        }        
        
        public int GetFetchSize()
        {
            return _cmj_fun26.CallInt( this );
        }        
        
        public global::Java.Sql.ResultSet GetGeneratedKeys()
        {
            if(_cmj_fun27.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun27.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun27.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public int GetMaxFieldSize()
        {
            return _cmj_fun28.CallInt( this );
        }        
        
        public int GetMaxRows()
        {
            return _cmj_fun29.CallInt( this );
        }        
        
        public bool GetMoreResults()
        {
            return _cmj_fun30.CallBool( this );
        }        
        
        public bool GetMoreResults(int current)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(current) )
            {
                return _cmj_fun31.CallBool( this, cmj_jmargs );
            }
        }        
        
        public int GetQueryTimeout()
        {
            return _cmj_fun32.CallInt( this );
        }        
        
        public global::Java.Sql.ResultSet GetResultSet()
        {
            if(_cmj_fun33.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun33.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun33.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public int GetResultSetConcurrency()
        {
            return _cmj_fun34.CallInt( this );
        }        
        
        public int GetResultSetHoldability()
        {
            return _cmj_fun35.CallInt( this );
        }        
        
        public int GetResultSetType()
        {
            return _cmj_fun36.CallInt( this );
        }        
        
        public int GetUpdateCount()
        {
            return _cmj_fun37.CallInt( this );
        }        
        
        public global::Java.Sql.SQLWarning GetWarnings()
        {
            if(_cmj_fun38.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun38.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.SQLWarning( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.SQLWarning)_cmj_fun38.CallObject( this, typeof(global::Java.Sql.SQLWarning), false );
        
        }        
        
        public bool IsClosed()
        {
            return _cmj_fun39.CallBool( this );
        }        
        
        public bool IsCloseOnCompletion()
        {
            return _cmj_fun40.CallBool( this );
        }        
        
        public bool IsPoolable()
        {
            return _cmj_fun41.CallBool( this );
        }        
        
        public void SetCursorName(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                _cmj_fun42.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetEscapeProcessing(bool enable)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(enable) )
            {
                _cmj_fun43.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetFetchDirection(int direction)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(direction) )
            {
                _cmj_fun44.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetFetchSize(int rows)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(rows) )
            {
                _cmj_fun45.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetMaxFieldSize(int max)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(max) )
            {
                _cmj_fun46.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetMaxRows(int max)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(max) )
            {
                _cmj_fun47.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetPoolable(bool poolable)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(poolable) )
            {
                _cmj_fun48.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetQueryTimeout(int seconds)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(seconds) )
            {
                _cmj_fun49.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
