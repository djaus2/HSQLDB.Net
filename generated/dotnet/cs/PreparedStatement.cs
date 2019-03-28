/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.PreparedStatement
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("5A412AA6-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.PreparedStatement")]
    public interface PreparedStatement :
        global::Java.Sql.Statement
    { 
        void AddBatch();
    
    
        void ClearParameters();
    
    
        bool Execute();
    
    
        global::Java.Sql.ResultSet ExecuteQuery();
    
    
        int ExecuteUpdate();
    
    
        global::Java.Sql.ResultSetMetaData GetMetaData();
    
    
        global::Java.Sql.ParameterMetaData GetParameterMetaData();
    
    
        void SetArray(int parameterIndex, global::Java.Sql.Array x);
    
    
        void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x);
    
    
        void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x, int length);
    
    
        void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x, long length);
    
    
        void SetBigDecimal(int parameterIndex, global::Java.Math.BigDecimal x);
    
    
        void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x);
    
    
        void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x, int length);
    
    
        void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x, long length);
    
    
        void SetBlob(int parameterIndex, global::Java.Io.InputStream inputStream);
    
    
        void SetBlob(int parameterIndex, global::Java.Sql.Blob x);
    
    
        void SetBlob(int parameterIndex, global::Java.Io.InputStream inputStream, long length);
    
    
        void SetBoolean(int parameterIndex, bool x);
    
    
        void SetByte(int parameterIndex, byte x);
    
    
        void SetBytes(int parameterIndex, global::Codemesh.JuggerNET.byteArray x);
    
    
        void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader);
    
    
        void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader, int length);
    
    
        void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader, long length);
    
    
        void SetClob(int parameterIndex, global::Java.Io.Reader reader);
    
    
        void SetClob(int parameterIndex, global::Java.Sql.Clob x);
    
    
        void SetClob(int parameterIndex, global::Java.Io.Reader reader, long length);
    
    
        void SetDate(int parameterIndex, global::Java.Sql.Date x);
    
    
        void SetDate(int parameterIndex, global::Java.Sql.Date x, global::Java.Util.Calendar cal);
    
    
        void SetDouble(int parameterIndex, double x);
    
    
        void SetFloat(int parameterIndex, float x);
    
    
        void SetInt(int parameterIndex, int x);
    
    
        void SetLong(int parameterIndex, long x);
    
    
        void SetNCharacterStream(int parameterIndex, global::Java.Io.Reader value);
    
    
        void SetNCharacterStream(int parameterIndex, global::Java.Io.Reader value, long length);
    
    
        void SetNClob(int parameterIndex, global::Java.Io.Reader reader);
    
    
        void SetNClob(int parameterIndex, global::Java.Sql.NClob value);
    
    
        void SetNClob(int parameterIndex, global::Java.Io.Reader reader, long length);
    
    
        void SetNString(int parameterIndex, string value);
    
    
        void SetNull(int parameterIndex, int sqlType);
    
    
        void SetNull(int parameterIndex, int sqlType, string typeName);
    
    
        void SetObject(int parameterIndex, object x);
    
    
        void SetObject(int parameterIndex, object x, int targetSqlType);
    
    
        void SetObject(int parameterIndex, object x, int targetSqlType, int scaleOrLength);
    
    
        void SetRef(int parameterIndex, global::Java.Sql.Ref x);
    
    
        void SetRowId(int parameterIndex, global::Java.Sql.RowId x);
    
    
        void SetSQLXML(int parameterIndex, global::Java.Sql.SQLXML xmlObject);
    
    
        void SetShort(int parameterIndex, short x);
    
    
        void SetString(int parameterIndex, string x);
    
    
        void SetTime(int parameterIndex, global::Java.Sql.Time x);
    
    
        void SetTime(int parameterIndex, global::Java.Sql.Time x, global::Java.Util.Calendar cal);
    
    
        void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp x);
    
    
        void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp x, global::Java.Util.Calendar cal);
    
    
        void SetURL(int parameterIndex, global::Java.Net.URL x);
    
    
        void SetUnicodeStream(int parameterIndex, global::Java.Io.InputStream x, int length);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.PreparedStatement")]
    public class PreparedStatementImpl :
        global::Java.Sql.StatementImpl,
        global::Java.Sql.PreparedStatement
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
    
        static PreparedStatementImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.PreparedStatement", typeof(global::Java.Sql.PreparedStatement), typeof(global::Java.Sql.PreparedStatementImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "executeLargeUpdate", "()J", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(ILjava/lang/Object;Ljava/sql/SQLType;)V", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(ILjava/lang/Object;Ljava/sql/SQLType;I)V", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "addBatch", "()V", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "clearParameters", "()V", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "execute", "()Z", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "executeQuery", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "executeUpdate", "()I", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSetMetaData), "getMetaData", "()Ljava/sql/ResultSetMetaData;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ParameterMetaData), "getParameterMetaData", "()Ljava/sql/ParameterMetaData;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setArray", "(ILjava/sql/Array;)V", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(ILjava/io/InputStream;)V", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(ILjava/io/InputStream;I)V", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(ILjava/io/InputStream;J)V", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBigDecimal", "(ILjava/math/BigDecimal;)V", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(ILjava/io/InputStream;)V", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(ILjava/io/InputStream;I)V", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(ILjava/io/InputStream;J)V", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(ILjava/io/InputStream;)V", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(ILjava/sql/Blob;)V", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(ILjava/io/InputStream;J)V", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBoolean", "(IZ)V", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setByte", "(IB)V", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBytes", "(I[B)V", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(ILjava/io/Reader;I)V", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(ILjava/sql/Clob;)V", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDate", "(ILjava/sql/Date;)V", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDouble", "(ID)V", false, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFloat", "(IF)V", false, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setInt", "(II)V", false, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setLong", "(IJ)V", false, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNCharacterStream", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun37 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNCharacterStream", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun38 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun39 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(ILjava/sql/NClob;)V", false, false, false );
            _cmj_fun40 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun41 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNString", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun42 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNull", "(II)V", false, false, false );
            _cmj_fun43 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNull", "(IILjava/lang/String;)V", false, false, false );
            _cmj_fun44 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(ILjava/lang/Object;)V", false, false, false );
            _cmj_fun45 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(ILjava/lang/Object;I)V", false, false, false );
            _cmj_fun46 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(ILjava/lang/Object;II)V", false, false, false );
            _cmj_fun47 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setRef", "(ILjava/sql/Ref;)V", false, false, false );
            _cmj_fun48 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setRowId", "(ILjava/sql/RowId;)V", false, false, false );
            _cmj_fun49 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setShort", "(IS)V", false, false, false );
            _cmj_fun50 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setSQLXML", "(ILjava/sql/SQLXML;)V", false, false, false );
            _cmj_fun51 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setString", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun52 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(ILjava/sql/Time;)V", false, false, false );
            _cmj_fun53 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun54 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTimestamp", "(ILjava/sql/Timestamp;)V", false, false, false );
            _cmj_fun55 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun56 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setUnicodeStream", "(ILjava/io/InputStream;I)V", false, false, false );
            _cmj_fun57 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setURL", "(ILjava/net/URL;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public PreparedStatementImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type PreparedStatementImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.PreparedStatement</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.PreparedStatementImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.PreparedStatementImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static long ExecuteLargeUpdate()
        {
            return _cmj_fun0.CallLong( null );
        }        
        
        public static void SetObject(int arg0, object arg1, global::Java.Sql.SQLType arg2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2) )
            {
                _cmj_fun1.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void SetObject(int arg0, object arg1, global::Java.Sql.SQLType arg2, int arg3)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2).Add(arg3) )
            {
                _cmj_fun2.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public void AddBatch()
        {
            _cmj_fun3.CallVoid( this );
        }        
        
        public void ClearParameters()
        {
            _cmj_fun4.CallVoid( this );
        }        
        
        public bool Execute()
        {
            return _cmj_fun5.CallBool( this );
        }        
        
        public global::Java.Sql.ResultSet ExecuteQuery()
        {
            if(_cmj_fun6.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun6.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun6.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public int ExecuteUpdate()
        {
            return _cmj_fun7.CallInt( this );
        }        
        
        public global::Java.Sql.ResultSetMetaData GetMetaData()
        {
            if(_cmj_fun8.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun8.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetMetaDataImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSetMetaData)_cmj_fun8.CallObject( this, typeof(global::Java.Sql.ResultSetMetaData), false );
        
        }        
        
        public global::Java.Sql.ParameterMetaData GetParameterMetaData()
        {
            if(_cmj_fun9.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun9.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ParameterMetaDataImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ParameterMetaData)_cmj_fun9.CallObject( this, typeof(global::Java.Sql.ParameterMetaData), false );
        
        }        
        
        public void SetArray(int parameterIndex, global::Java.Sql.Array x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun10.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun11.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(length) )
            {
                _cmj_fun12.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(length) )
            {
                _cmj_fun13.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBigDecimal(int parameterIndex, global::Java.Math.BigDecimal x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun14.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun15.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(length) )
            {
                _cmj_fun16.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(length) )
            {
                _cmj_fun17.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(int parameterIndex, global::Java.Io.InputStream inputStream)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(inputStream) )
            {
                _cmj_fun18.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(int parameterIndex, global::Java.Sql.Blob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun19.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(int parameterIndex, global::Java.Io.InputStream inputStream, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(inputStream).Add(length) )
            {
                _cmj_fun20.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBoolean(int parameterIndex, bool x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun21.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetByte(int parameterIndex, byte x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun22.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBytes(int parameterIndex, global::Codemesh.JuggerNET.byteArray x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun23.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader) )
            {
                _cmj_fun24.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader).Add(length) )
            {
                _cmj_fun25.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader).Add(length) )
            {
                _cmj_fun26.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(int parameterIndex, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader) )
            {
                _cmj_fun27.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(int parameterIndex, global::Java.Sql.Clob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun28.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(int parameterIndex, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader).Add(length) )
            {
                _cmj_fun29.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDate(int parameterIndex, global::Java.Sql.Date x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun30.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDate(int parameterIndex, global::Java.Sql.Date x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(cal) )
            {
                _cmj_fun31.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDouble(int parameterIndex, double x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun32.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetFloat(int parameterIndex, float x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun33.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetInt(int parameterIndex, int x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun34.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetLong(int parameterIndex, long x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun35.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNCharacterStream(int parameterIndex, global::Java.Io.Reader value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(value) )
            {
                _cmj_fun36.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNCharacterStream(int parameterIndex, global::Java.Io.Reader value, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(value).Add(length) )
            {
                _cmj_fun37.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(int parameterIndex, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader) )
            {
                _cmj_fun38.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(int parameterIndex, global::Java.Sql.NClob value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(value) )
            {
                _cmj_fun39.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(int parameterIndex, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader).Add(length) )
            {
                _cmj_fun40.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNString(int parameterIndex, string value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(value) )
            {
                _cmj_fun41.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNull(int parameterIndex, int sqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(sqlType) )
            {
                _cmj_fun42.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNull(int parameterIndex, int sqlType, string typeName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(sqlType).Add(typeName) )
            {
                _cmj_fun43.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(int parameterIndex, object x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun44.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(int parameterIndex, object x, int targetSqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(targetSqlType) )
            {
                _cmj_fun45.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(int parameterIndex, object x, int targetSqlType, int scaleOrLength)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(targetSqlType).Add(scaleOrLength) )
            {
                _cmj_fun46.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetRef(int parameterIndex, global::Java.Sql.Ref x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun47.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetRowId(int parameterIndex, global::Java.Sql.RowId x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun48.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetShort(int parameterIndex, short x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun49.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetSQLXML(int parameterIndex, global::Java.Sql.SQLXML xmlObject)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(xmlObject) )
            {
                _cmj_fun50.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetString(int parameterIndex, string x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun51.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTime(int parameterIndex, global::Java.Sql.Time x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun52.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTime(int parameterIndex, global::Java.Sql.Time x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(cal) )
            {
                _cmj_fun53.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun54.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(cal) )
            {
                _cmj_fun55.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetUnicodeStream(int parameterIndex, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(length) )
            {
                _cmj_fun56.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetURL(int parameterIndex, global::Java.Net.URL x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun57.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
