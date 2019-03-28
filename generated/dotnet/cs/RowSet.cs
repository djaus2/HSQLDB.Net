/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.RowSet
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("A52E9F00-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.RowSet")]
    public interface RowSet :
        global::Java.Sql.ResultSet
    { 
        void AddRowSetListener(global::Javax.Sql.RowSetListener listener);
    
    
        void ClearParameters();
    
    
        void Execute();
    
    
        string GetCommand();
    
    
        string GetDataSourceName();
    
    
        bool GetEscapeProcessing();
    
    
        int GetMaxFieldSize();
    
    
        int GetMaxRows();
    
    
        string GetPassword();
    
    
        int GetQueryTimeout();
    
    
        int GetTransactionIsolation();
    
    
        global::Java.Util.Map GetTypeMap();
    
    
        string GetUrl();
    
    
        string GetUsername();
    
    
        bool IsReadOnly();
    
    
        void RemoveRowSetListener(global::Javax.Sql.RowSetListener listener);
    
    
        void SetArray(int i, global::Java.Sql.Array x);
    
    
        void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x);
    
    
        void SetAsciiStream(string parameterName, global::Java.Io.InputStream x);
    
    
        void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x, int length);
    
    
        void SetAsciiStream(string parameterName, global::Java.Io.InputStream x, int length);
    
    
        void SetBigDecimal(int parameterIndex, global::Java.Math.BigDecimal x);
    
    
        void SetBigDecimal(string parameterName, global::Java.Math.BigDecimal x);
    
    
        void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x);
    
    
        void SetBinaryStream(string parameterName, global::Java.Io.InputStream x);
    
    
        void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x, int length);
    
    
        void SetBinaryStream(string parameterName, global::Java.Io.InputStream x, int length);
    
    
        void SetBlob(int parameterIndex, global::Java.Io.InputStream inputStream);
    
    
        void SetBlob(int i, global::Java.Sql.Blob x);
    
    
        void SetBlob(string parameterName, global::Java.Io.InputStream inputStream);
    
    
        void SetBlob(string parameterName, global::Java.Sql.Blob x);
    
    
        void SetBlob(int parameterIndex, global::Java.Io.InputStream inputStream, long length);
    
    
        void SetBlob(string parameterName, global::Java.Io.InputStream inputStream, long length);
    
    
        void SetBoolean(int parameterIndex, bool x);
    
    
        void SetBoolean(string parameterName, bool x);
    
    
        void SetByte(int parameterIndex, byte x);
    
    
        void SetByte(string parameterName, byte x);
    
    
        void SetBytes(int parameterIndex, global::Codemesh.JuggerNET.byteArray x);
    
    
        void SetBytes(string parameterName, global::Codemesh.JuggerNET.byteArray x);
    
    
        void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader);
    
    
        void SetCharacterStream(string parameterName, global::Java.Io.Reader reader);
    
    
        void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader, int length);
    
    
        void SetCharacterStream(string parameterName, global::Java.Io.Reader reader, int length);
    
    
        void SetClob(int parameterIndex, global::Java.Io.Reader reader);
    
    
        void SetClob(int i, global::Java.Sql.Clob x);
    
    
        void SetClob(string parameterName, global::Java.Io.Reader reader);
    
    
        void SetClob(string parameterName, global::Java.Sql.Clob x);
    
    
        void SetClob(int parameterIndex, global::Java.Io.Reader reader, long length);
    
    
        void SetClob(string parameterName, global::Java.Io.Reader reader, long length);
    
    
        void SetCommand(string cmd);
    
    
        void SetConcurrency(int concurrency);
    
    
        void SetDataSourceName(string name);
    
    
        void SetDate(int parameterIndex, global::Java.Sql.Date x);
    
    
        void SetDate(string parameterName, global::Java.Sql.Date x);
    
    
        void SetDate(int parameterIndex, global::Java.Sql.Date x, global::Java.Util.Calendar cal);
    
    
        void SetDate(string parameterName, global::Java.Sql.Date x, global::Java.Util.Calendar cal);
    
    
        void SetDouble(int parameterIndex, double x);
    
    
        void SetDouble(string parameterName, double x);
    
    
        void SetEscapeProcessing(bool enable);
    
    
        void SetFloat(int parameterIndex, float x);
    
    
        void SetFloat(string parameterName, float x);
    
    
        void SetInt(int parameterIndex, int x);
    
    
        void SetInt(string parameterName, int x);
    
    
        void SetLong(int parameterIndex, long x);
    
    
        void SetLong(string parameterName, long x);
    
    
        void SetMaxFieldSize(int max);
    
    
        void SetMaxRows(int max);
    
    
        void SetNCharacterStream(int parameterIndex, global::Java.Io.Reader value);
    
    
        void SetNCharacterStream(string parameterName, global::Java.Io.Reader value);
    
    
        void SetNCharacterStream(int parameterIndex, global::Java.Io.Reader value, long length);
    
    
        void SetNCharacterStream(string parameterName, global::Java.Io.Reader value, long length);
    
    
        void SetNClob(int parameterIndex, global::Java.Io.Reader reader);
    
    
        void SetNClob(int parameterIndex, global::Java.Sql.NClob value);
    
    
        void SetNClob(string parameterName, global::Java.Io.Reader reader);
    
    
        void SetNClob(string parameterName, global::Java.Sql.NClob value);
    
    
        void SetNClob(int parameterIndex, global::Java.Io.Reader reader, long length);
    
    
        void SetNClob(string parameterName, global::Java.Io.Reader reader, long length);
    
    
        void SetNString(int parameterIndex, string value);
    
    
        void SetNString(string parameterName, string value);
    
    
        void SetNull(int parameterIndex, int sqlType);
    
    
        void SetNull(string parameterName, int sqlType);
    
    
        void SetNull(int paramIndex, int sqlType, string typeName);
    
    
        void SetNull(string parameterName, int sqlType, string typeName);
    
    
        void SetObject(int parameterIndex, object x);
    
    
        void SetObject(string parameterName, object x);
    
    
        void SetObject(int parameterIndex, object x, int targetSqlType);
    
    
        void SetObject(string parameterName, object x, int targetSqlType);
    
    
        void SetObject(int parameterIndex, object x, int targetSqlType, int scaleOrLength);
    
    
        void SetObject(string parameterName, object x, int targetSqlType, int scale);
    
    
        void SetPassword(string password);
    
    
        void SetQueryTimeout(int seconds);
    
    
        void SetReadOnly(bool value);
    
    
        void SetRef(int i, global::Java.Sql.Ref x);
    
    
        void SetRowId(int parameterIndex, global::Java.Sql.RowId x);
    
    
        void SetRowId(string parameterName, global::Java.Sql.RowId x);
    
    
        void SetSQLXML(int parameterIndex, global::Java.Sql.SQLXML xmlObject);
    
    
        void SetSQLXML(string parameterName, global::Java.Sql.SQLXML xmlObject);
    
    
        void SetShort(int parameterIndex, short x);
    
    
        void SetShort(string parameterName, short x);
    
    
        void SetString(int parameterIndex, string x);
    
    
        void SetString(string parameterName, string x);
    
    
        void SetTime(int parameterIndex, global::Java.Sql.Time x);
    
    
        void SetTime(string parameterName, global::Java.Sql.Time x);
    
    
        void SetTime(int parameterIndex, global::Java.Sql.Time x, global::Java.Util.Calendar cal);
    
    
        void SetTime(string parameterName, global::Java.Sql.Time x, global::Java.Util.Calendar cal);
    
    
        void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp x);
    
    
        void SetTimestamp(string parameterName, global::Java.Sql.Timestamp x);
    
    
        void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp x, global::Java.Util.Calendar cal);
    
    
        void SetTimestamp(string parameterName, global::Java.Sql.Timestamp x, global::Java.Util.Calendar cal);
    
    
        void SetTransactionIsolation(int level);
    
    
        void SetType(int type);
    
    
        void SetTypeMap(global::Java.Util.Map map);
    
    
        void SetURL(int parameterIndex, global::Java.Net.URL x);
    
    
        void SetUrl(string url);
    
    
        void SetUsername(string name);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.RowSet")]
    public class RowSetImpl :
        global::Java.Sql.ResultSetImpl,
        global::Javax.Sql.RowSet
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
    
        static RowSetImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.RowSet", typeof(global::Javax.Sql.RowSet), typeof(global::Javax.Sql.RowSetImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "addRowSetListener", "(Ljavax/sql/RowSetListener;)V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "clearParameters", "()V", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "execute", "()V", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getCommand", "()Ljava/lang/String;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getDataSourceName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getEscapeProcessing", "()Z", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxFieldSize", "()I", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaxRows", "()I", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getPassword", "()Ljava/lang/String;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getQueryTimeout", "()I", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getTransactionIsolation", "()I", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Map), "getTypeMap", "()Ljava/util/Map;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getUrl", "()Ljava/lang/String;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getUsername", "()Ljava/lang/String;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isReadOnly", "()Z", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "removeRowSetListener", "(Ljavax/sql/RowSetListener;)V", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setArray", "(ILjava/sql/Array;)V", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(ILjava/io/InputStream;)V", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(ILjava/io/InputStream;I)V", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBigDecimal", "(ILjava/math/BigDecimal;)V", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(ILjava/io/InputStream;)V", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(ILjava/io/InputStream;I)V", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(ILjava/io/InputStream;)V", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(ILjava/sql/Blob;)V", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(ILjava/io/InputStream;J)V", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", false, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBoolean", "(IZ)V", false, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBoolean", "(Ljava/lang/String;Z)V", false, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setByte", "(IB)V", false, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setByte", "(Ljava/lang/String;B)V", false, false, false );
            _cmj_fun37 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBytes", "(I[B)V", false, false, false );
            _cmj_fun38 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBytes", "(Ljava/lang/String;[B)V", false, false, false );
            _cmj_fun39 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun40 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun41 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(ILjava/io/Reader;I)V", false, false, false );
            _cmj_fun42 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", false, false, false );
            _cmj_fun43 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun44 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(ILjava/sql/Clob;)V", false, false, false );
            _cmj_fun45 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun46 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", false, false, false );
            _cmj_fun47 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun48 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun49 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCommand", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun50 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setConcurrency", "(I)V", false, false, false );
            _cmj_fun51 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDataSourceName", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun52 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDate", "(ILjava/sql/Date;)V", false, false, false );
            _cmj_fun53 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V", false, false, false );
            _cmj_fun54 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun55 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun56 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDouble", "(ID)V", false, false, false );
            _cmj_fun57 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDouble", "(Ljava/lang/String;D)V", false, false, false );
            _cmj_fun58 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setEscapeProcessing", "(Z)V", false, false, false );
            _cmj_fun59 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFloat", "(IF)V", false, false, false );
            _cmj_fun60 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFloat", "(Ljava/lang/String;F)V", false, false, false );
            _cmj_fun61 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setInt", "(II)V", false, false, false );
            _cmj_fun62 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setInt", "(Ljava/lang/String;I)V", false, false, false );
            _cmj_fun63 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setLong", "(IJ)V", false, false, false );
            _cmj_fun64 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setLong", "(Ljava/lang/String;J)V", false, false, false );
            _cmj_fun65 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setMaxFieldSize", "(I)V", false, false, false );
            _cmj_fun66 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setMaxRows", "(I)V", false, false, false );
            _cmj_fun67 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNCharacterStream", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun68 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun69 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNCharacterStream", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun70 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun71 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun72 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(ILjava/sql/NClob;)V", false, false, false );
            _cmj_fun73 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun74 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V", false, false, false );
            _cmj_fun75 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun76 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun77 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNString", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun78 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNString", "(Ljava/lang/String;Ljava/lang/String;)V", false, false, false );
            _cmj_fun79 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNull", "(II)V", false, false, false );
            _cmj_fun80 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNull", "(Ljava/lang/String;I)V", false, false, false );
            _cmj_fun81 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNull", "(IILjava/lang/String;)V", false, false, false );
            _cmj_fun82 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNull", "(Ljava/lang/String;ILjava/lang/String;)V", false, false, false );
            _cmj_fun83 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(ILjava/lang/Object;)V", false, false, false );
            _cmj_fun84 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun85 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(ILjava/lang/Object;I)V", false, false, false );
            _cmj_fun86 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V", false, false, false );
            _cmj_fun87 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(ILjava/lang/Object;II)V", false, false, false );
            _cmj_fun88 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V", false, false, false );
            _cmj_fun89 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setPassword", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun90 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setQueryTimeout", "(I)V", false, false, false );
            _cmj_fun91 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setReadOnly", "(Z)V", false, false, false );
            _cmj_fun92 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setRef", "(ILjava/sql/Ref;)V", false, false, false );
            _cmj_fun93 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setRowId", "(ILjava/sql/RowId;)V", false, false, false );
            _cmj_fun94 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V", false, false, false );
            _cmj_fun95 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setShort", "(IS)V", false, false, false );
            _cmj_fun96 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setShort", "(Ljava/lang/String;S)V", false, false, false );
            _cmj_fun97 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setSQLXML", "(ILjava/sql/SQLXML;)V", false, false, false );
            _cmj_fun98 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V", false, false, false );
            _cmj_fun99 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setString", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun100 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setString", "(Ljava/lang/String;Ljava/lang/String;)V", false, false, false );
            _cmj_fun101 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(ILjava/sql/Time;)V", false, false, false );
            _cmj_fun102 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V", false, false, false );
            _cmj_fun103 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun104 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun105 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTimestamp", "(ILjava/sql/Timestamp;)V", false, false, false );
            _cmj_fun106 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", false, false, false );
            _cmj_fun107 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun108 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun109 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTransactionIsolation", "(I)V", false, false, false );
            _cmj_fun110 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setType", "(I)V", false, false, false );
            _cmj_fun111 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTypeMap", "(Ljava/util/Map;)V", false, false, false );
            _cmj_fun112 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setUrl", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun113 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setURL", "(ILjava/net/URL;)V", false, false, false );
            _cmj_fun114 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setUsername", "(Ljava/lang/String;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public RowSetImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type RowSetImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.RowSet</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.RowSetImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.RowSetImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void AddRowSetListener(global::Javax.Sql.RowSetListener listener)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(listener, typeof(global::Javax.Sql.RowSetListener)) )
            {
                _cmj_fun0.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void ClearParameters()
        {
            _cmj_fun1.CallVoid( this );
        }        
        
        public void Execute()
        {
            _cmj_fun2.CallVoid( this );
        }        
        
        public string GetCommand()
        {
            return _cmj_fun3.CallString( this );
        }        
        
        public string GetDataSourceName()
        {
            return _cmj_fun4.CallString( this );
        }        
        
        public bool GetEscapeProcessing()
        {
            return _cmj_fun5.CallBool( this );
        }        
        
        public int GetMaxFieldSize()
        {
            return _cmj_fun6.CallInt( this );
        }        
        
        public int GetMaxRows()
        {
            return _cmj_fun7.CallInt( this );
        }        
        
        public string GetPassword()
        {
            return _cmj_fun8.CallString( this );
        }        
        
        public int GetQueryTimeout()
        {
            return _cmj_fun9.CallInt( this );
        }        
        
        public int GetTransactionIsolation()
        {
            return _cmj_fun10.CallInt( this );
        }        
        
        public global::Java.Util.Map GetTypeMap()
        {
            if(_cmj_fun11.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun11.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.MapImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Map)_cmj_fun11.CallObject( this, typeof(global::Java.Util.Map), false );
        
        }        
        
        public string GetUrl()
        {
            return _cmj_fun12.CallString( this );
        }        
        
        public string GetUsername()
        {
            return _cmj_fun13.CallString( this );
        }        
        
        public bool IsReadOnly()
        {
            return _cmj_fun14.CallBool( this );
        }        
        
        public void RemoveRowSetListener(global::Javax.Sql.RowSetListener listener)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(listener, typeof(global::Javax.Sql.RowSetListener)) )
            {
                _cmj_fun15.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetArray(int i, global::Java.Sql.Array x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i).Add(x) )
            {
                _cmj_fun16.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun17.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(string parameterName, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun18.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(int parameterIndex, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(length) )
            {
                _cmj_fun19.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(string parameterName, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(length) )
            {
                _cmj_fun20.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBigDecimal(int parameterIndex, global::Java.Math.BigDecimal x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun21.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBigDecimal(string parameterName, global::Java.Math.BigDecimal x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun22.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun23.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(string parameterName, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun24.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(int parameterIndex, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(length) )
            {
                _cmj_fun25.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(string parameterName, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(length) )
            {
                _cmj_fun26.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(int parameterIndex, global::Java.Io.InputStream inputStream)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(inputStream) )
            {
                _cmj_fun27.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(int i, global::Java.Sql.Blob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i).Add(x) )
            {
                _cmj_fun28.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(string parameterName, global::Java.Io.InputStream inputStream)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(inputStream) )
            {
                _cmj_fun29.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(string parameterName, global::Java.Sql.Blob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun30.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(int parameterIndex, global::Java.Io.InputStream inputStream, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(inputStream).Add(length) )
            {
                _cmj_fun31.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(string parameterName, global::Java.Io.InputStream inputStream, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(inputStream).Add(length) )
            {
                _cmj_fun32.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBoolean(int parameterIndex, bool x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun33.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBoolean(string parameterName, bool x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun34.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetByte(int parameterIndex, byte x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun35.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetByte(string parameterName, byte x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun36.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBytes(int parameterIndex, global::Codemesh.JuggerNET.byteArray x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun37.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBytes(string parameterName, global::Codemesh.JuggerNET.byteArray x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun38.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader) )
            {
                _cmj_fun39.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(string parameterName, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader) )
            {
                _cmj_fun40.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(int parameterIndex, global::Java.Io.Reader reader, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader).Add(length) )
            {
                _cmj_fun41.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(string parameterName, global::Java.Io.Reader reader, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader).Add(length) )
            {
                _cmj_fun42.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(int parameterIndex, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader) )
            {
                _cmj_fun43.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(int i, global::Java.Sql.Clob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i).Add(x) )
            {
                _cmj_fun44.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(string parameterName, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader) )
            {
                _cmj_fun45.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(string parameterName, global::Java.Sql.Clob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun46.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(int parameterIndex, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader).Add(length) )
            {
                _cmj_fun47.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(string parameterName, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader).Add(length) )
            {
                _cmj_fun48.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCommand(string cmd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(cmd) )
            {
                _cmj_fun49.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetConcurrency(int concurrency)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(concurrency) )
            {
                _cmj_fun50.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDataSourceName(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                _cmj_fun51.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDate(int parameterIndex, global::Java.Sql.Date x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun52.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDate(string parameterName, global::Java.Sql.Date x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun53.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDate(int parameterIndex, global::Java.Sql.Date x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(cal) )
            {
                _cmj_fun54.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDate(string parameterName, global::Java.Sql.Date x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(cal) )
            {
                _cmj_fun55.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDouble(int parameterIndex, double x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun56.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDouble(string parameterName, double x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun57.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetEscapeProcessing(bool enable)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(enable) )
            {
                _cmj_fun58.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetFloat(int parameterIndex, float x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun59.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetFloat(string parameterName, float x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun60.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetInt(int parameterIndex, int x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun61.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetInt(string parameterName, int x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun62.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetLong(int parameterIndex, long x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun63.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetLong(string parameterName, long x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun64.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetMaxFieldSize(int max)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(max) )
            {
                _cmj_fun65.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetMaxRows(int max)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(max) )
            {
                _cmj_fun66.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNCharacterStream(int parameterIndex, global::Java.Io.Reader value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(value) )
            {
                _cmj_fun67.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNCharacterStream(string parameterName, global::Java.Io.Reader value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(value) )
            {
                _cmj_fun68.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNCharacterStream(int parameterIndex, global::Java.Io.Reader value, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(value).Add(length) )
            {
                _cmj_fun69.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNCharacterStream(string parameterName, global::Java.Io.Reader value, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(value).Add(length) )
            {
                _cmj_fun70.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(int parameterIndex, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader) )
            {
                _cmj_fun71.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(int parameterIndex, global::Java.Sql.NClob value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(value) )
            {
                _cmj_fun72.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(string parameterName, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader) )
            {
                _cmj_fun73.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(string parameterName, global::Java.Sql.NClob value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(value) )
            {
                _cmj_fun74.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(int parameterIndex, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(reader).Add(length) )
            {
                _cmj_fun75.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(string parameterName, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader).Add(length) )
            {
                _cmj_fun76.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNString(int parameterIndex, string value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(value) )
            {
                _cmj_fun77.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNString(string parameterName, string value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(value) )
            {
                _cmj_fun78.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNull(int parameterIndex, int sqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(sqlType) )
            {
                _cmj_fun79.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNull(string parameterName, int sqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(sqlType) )
            {
                _cmj_fun80.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNull(int paramIndex, int sqlType, string typeName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(paramIndex).Add(sqlType).Add(typeName) )
            {
                _cmj_fun81.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNull(string parameterName, int sqlType, string typeName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(sqlType).Add(typeName) )
            {
                _cmj_fun82.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(int parameterIndex, object x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun83.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(string parameterName, object x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun84.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(int parameterIndex, object x, int targetSqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(targetSqlType) )
            {
                _cmj_fun85.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(string parameterName, object x, int targetSqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(targetSqlType) )
            {
                _cmj_fun86.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(int parameterIndex, object x, int targetSqlType, int scaleOrLength)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(targetSqlType).Add(scaleOrLength) )
            {
                _cmj_fun87.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(string parameterName, object x, int targetSqlType, int scale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(targetSqlType).Add(scale) )
            {
                _cmj_fun88.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetPassword(string password)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(password) )
            {
                _cmj_fun89.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetQueryTimeout(int seconds)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(seconds) )
            {
                _cmj_fun90.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetReadOnly(bool value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                _cmj_fun91.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetRef(int i, global::Java.Sql.Ref x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i).Add(x) )
            {
                _cmj_fun92.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetRowId(int parameterIndex, global::Java.Sql.RowId x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun93.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetRowId(string parameterName, global::Java.Sql.RowId x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun94.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetShort(int parameterIndex, short x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun95.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetShort(string parameterName, short x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun96.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetSQLXML(int parameterIndex, global::Java.Sql.SQLXML xmlObject)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(xmlObject) )
            {
                _cmj_fun97.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetSQLXML(string parameterName, global::Java.Sql.SQLXML xmlObject)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(xmlObject) )
            {
                _cmj_fun98.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetString(int parameterIndex, string x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun99.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetString(string parameterName, string x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun100.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTime(int parameterIndex, global::Java.Sql.Time x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun101.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTime(string parameterName, global::Java.Sql.Time x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun102.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTime(int parameterIndex, global::Java.Sql.Time x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(cal) )
            {
                _cmj_fun103.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTime(string parameterName, global::Java.Sql.Time x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(cal) )
            {
                _cmj_fun104.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun105.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTimestamp(string parameterName, global::Java.Sql.Timestamp x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun106.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTimestamp(int parameterIndex, global::Java.Sql.Timestamp x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x).Add(cal) )
            {
                _cmj_fun107.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTimestamp(string parameterName, global::Java.Sql.Timestamp x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(cal) )
            {
                _cmj_fun108.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTransactionIsolation(int level)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(level) )
            {
                _cmj_fun109.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetType(int type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                _cmj_fun110.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTypeMap(global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(map) )
            {
                _cmj_fun111.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetUrl(string url)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(url) )
            {
                _cmj_fun112.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetURL(int parameterIndex, global::Java.Net.URL x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(x) )
            {
                _cmj_fun113.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetUsername(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                _cmj_fun114.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
