/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.CallableStatement
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("BFE9E88B-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.CallableStatement")]
    public interface CallableStatement :
        global::Java.Sql.PreparedStatement
    { 
        global::Java.Sql.Array GetArray(int parameterIndex);
    
    
        global::Java.Sql.Array GetArray(string parameterName);
    
    
        global::Java.Math.BigDecimal GetBigDecimal(int parameterIndex);
    
    
        global::Java.Math.BigDecimal GetBigDecimal(string parameterName);
    
    
        global::Java.Math.BigDecimal GetBigDecimal(int parameterIndex, int scale);
    
    
        global::Java.Sql.Blob GetBlob(int parameterIndex);
    
    
        global::Java.Sql.Blob GetBlob(string parameterName);
    
    
        bool GetBoolean(int parameterIndex);
    
    
        bool GetBoolean(string parameterName);
    
    
        byte GetByte(int parameterIndex);
    
    
        byte GetByte(string parameterName);
    
    
        global::Codemesh.JuggerNET.byteArray GetBytes(int parameterIndex);
    
    
        global::Codemesh.JuggerNET.byteArray GetBytes(string parameterName);
    
    
        global::Java.Io.Reader GetCharacterStream(int parameterIndex);
    
    
        global::Java.Io.Reader GetCharacterStream(string parameterName);
    
    
        global::Java.Sql.Clob GetClob(int parameterIndex);
    
    
        global::Java.Sql.Clob GetClob(string parameterName);
    
    
        global::Java.Sql.Date GetDate(int parameterIndex);
    
    
        global::Java.Sql.Date GetDate(string parameterName);
    
    
        global::Java.Sql.Date GetDate(int parameterIndex, global::Java.Util.Calendar cal);
    
    
        global::Java.Sql.Date GetDate(string parameterName, global::Java.Util.Calendar cal);
    
    
        double GetDouble(int parameterIndex);
    
    
        double GetDouble(string parameterName);
    
    
        float GetFloat(int parameterIndex);
    
    
        float GetFloat(string parameterName);
    
    
        int GetInt(int parameterIndex);
    
    
        int GetInt(string parameterName);
    
    
        long GetLong(int parameterIndex);
    
    
        long GetLong(string parameterName);
    
    
        global::Java.Io.Reader GetNCharacterStream(int parameterIndex);
    
    
        global::Java.Io.Reader GetNCharacterStream(string parameterName);
    
    
        global::Java.Sql.NClob GetNClob(int parameterIndex);
    
    
        global::Java.Sql.NClob GetNClob(string parameterName);
    
    
        string GetNString(int parameterIndex);
    
    
        string GetNString(string parameterName);
    
    
        object GetObject(int parameterIndex);
    
    
        object GetObject(string parameterName);
    
    
        object GetObject(int parameterIndex, global::Java.Lang.Class type);
    
    
        object GetObject(int parameterIndex, global::Java.Util.Map map);
    
    
        object GetObject(string parameterName, global::Java.Lang.Class type);
    
    
        object GetObject(string parameterName, global::Java.Util.Map map);
    
    
        global::Java.Sql.Ref GetRef(int parameterIndex);
    
    
        global::Java.Sql.Ref GetRef(string parameterName);
    
    
        global::Java.Sql.RowId GetRowId(int parameterIndex);
    
    
        global::Java.Sql.RowId GetRowId(string parameterName);
    
    
        global::Java.Sql.SQLXML GetSQLXML(int parameterIndex);
    
    
        global::Java.Sql.SQLXML GetSQLXML(string parameterName);
    
    
        short GetShort(int parameterIndex);
    
    
        short GetShort(string parameterName);
    
    
        string GetString(int parameterIndex);
    
    
        string GetString(string parameterName);
    
    
        global::Java.Sql.Time GetTime(int parameterIndex);
    
    
        global::Java.Sql.Time GetTime(string parameterName);
    
    
        global::Java.Sql.Time GetTime(int parameterIndex, global::Java.Util.Calendar cal);
    
    
        global::Java.Sql.Time GetTime(string parameterName, global::Java.Util.Calendar cal);
    
    
        global::Java.Sql.Timestamp GetTimestamp(int parameterIndex);
    
    
        global::Java.Sql.Timestamp GetTimestamp(string parameterName);
    
    
        global::Java.Sql.Timestamp GetTimestamp(int parameterIndex, global::Java.Util.Calendar cal);
    
    
        global::Java.Sql.Timestamp GetTimestamp(string parameterName, global::Java.Util.Calendar cal);
    
    
        global::Java.Net.URL GetURL(int parameterIndex);
    
    
        global::Java.Net.URL GetURL(string parameterName);
    
    
        void RegisterOutParameter(int parameterIndex, int sqlType);
    
    
        void RegisterOutParameter(string parameterName, int sqlType);
    
    
        void RegisterOutParameter(int parameterIndex, int sqlType, int scale);
    
    
        void RegisterOutParameter(int parameterIndex, int sqlType, string typeName);
    
    
        void RegisterOutParameter(string parameterName, int sqlType, int scale);
    
    
        void RegisterOutParameter(string parameterName, int sqlType, string typeName);
    
    
        void SetAsciiStream(string parameterName, global::Java.Io.InputStream x);
    
    
        void SetAsciiStream(string parameterName, global::Java.Io.InputStream x, int length);
    
    
        void SetAsciiStream(string parameterName, global::Java.Io.InputStream x, long length);
    
    
        void SetBigDecimal(string parameterName, global::Java.Math.BigDecimal x);
    
    
        void SetBinaryStream(string parameterName, global::Java.Io.InputStream x);
    
    
        void SetBinaryStream(string parameterName, global::Java.Io.InputStream x, int length);
    
    
        void SetBinaryStream(string parameterName, global::Java.Io.InputStream x, long length);
    
    
        void SetBlob(string parameterName, global::Java.Io.InputStream inputStream);
    
    
        void SetBlob(string parameterName, global::Java.Sql.Blob x);
    
    
        void SetBlob(string parameterName, global::Java.Io.InputStream inputStream, long length);
    
    
        void SetBoolean(string parameterName, bool x);
    
    
        void SetByte(string parameterName, byte x);
    
    
        void SetBytes(string parameterName, global::Codemesh.JuggerNET.byteArray x);
    
    
        void SetCharacterStream(string parameterName, global::Java.Io.Reader reader);
    
    
        void SetCharacterStream(string parameterName, global::Java.Io.Reader reader, int length);
    
    
        void SetCharacterStream(string parameterName, global::Java.Io.Reader reader, long length);
    
    
        void SetClob(string parameterName, global::Java.Io.Reader reader);
    
    
        void SetClob(string parameterName, global::Java.Sql.Clob x);
    
    
        void SetClob(string parameterName, global::Java.Io.Reader reader, long length);
    
    
        void SetDate(string parameterName, global::Java.Sql.Date x);
    
    
        void SetDate(string parameterName, global::Java.Sql.Date x, global::Java.Util.Calendar cal);
    
    
        void SetDouble(string parameterName, double x);
    
    
        void SetFloat(string parameterName, float x);
    
    
        void SetInt(string parameterName, int x);
    
    
        void SetLong(string parameterName, long x);
    
    
        void SetNCharacterStream(string parameterName, global::Java.Io.Reader value);
    
    
        void SetNCharacterStream(string parameterName, global::Java.Io.Reader value, long length);
    
    
        void SetNClob(string parameterName, global::Java.Io.Reader reader);
    
    
        void SetNClob(string parameterName, global::Java.Sql.NClob value);
    
    
        void SetNClob(string parameterName, global::Java.Io.Reader reader, long length);
    
    
        void SetNString(string parameterName, string value);
    
    
        void SetNull(string parameterName, int sqlType);
    
    
        void SetNull(string parameterName, int sqlType, string typeName);
    
    
        void SetObject(string parameterName, object x);
    
    
        void SetObject(string parameterName, object x, int targetSqlType);
    
    
        void SetObject(string parameterName, object x, int targetSqlType, int scale);
    
    
        void SetRowId(string parameterName, global::Java.Sql.RowId x);
    
    
        void SetSQLXML(string parameterName, global::Java.Sql.SQLXML xmlObject);
    
    
        void SetShort(string parameterName, short x);
    
    
        void SetString(string parameterName, string x);
    
    
        void SetTime(string parameterName, global::Java.Sql.Time x);
    
    
        void SetTime(string parameterName, global::Java.Sql.Time x, global::Java.Util.Calendar cal);
    
    
        void SetTimestamp(string parameterName, global::Java.Sql.Timestamp x);
    
    
        void SetTimestamp(string parameterName, global::Java.Sql.Timestamp x, global::Java.Util.Calendar cal);
    
    
        void SetURL(string parameterName, global::Java.Net.URL val);
    
    
        bool WasNull();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.CallableStatement")]
    public class CallableStatementImpl :
        global::Java.Sql.PreparedStatementImpl,
        global::Java.Sql.CallableStatement
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
    
        static CallableStatementImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.CallableStatement", typeof(global::Java.Sql.CallableStatement), typeof(global::Java.Sql.CallableStatementImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(ILjava/sql/SQLType;)V", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(Ljava/lang/String;Ljava/sql/SQLType;)V", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(ILjava/sql/SQLType;I)V", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(ILjava/sql/SQLType;Ljava/lang/String;)V", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(Ljava/lang/String;Ljava/sql/SQLType;I)V", true, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(Ljava/lang/String;Ljava/sql/SQLType;Ljava/lang/String;)V", true, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(Ljava/lang/String;Ljava/lang/Object;Ljava/sql/SQLType;)V", true, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(Ljava/lang/String;Ljava/lang/Object;Ljava/sql/SQLType;I)V", true, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Array), "getArray", "(I)Ljava/sql/Array;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Array), "getArray", "(Ljava/lang/String;)Ljava/sql/Array;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "getBigDecimal", "(I)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "getBigDecimal", "(II)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Blob), "getBlob", "(I)Ljava/sql/Blob;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Blob), "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getBoolean", "(I)Z", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getBoolean", "(Ljava/lang/String;)Z", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(byte), "getByte", "(I)B", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(byte), "getByte", "(Ljava/lang/String;)B", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Codemesh.JuggerNET.byteArray), "getBytes", "(I)[B", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Codemesh.JuggerNET.byteArray), "getBytes", "(Ljava/lang/String;)[B", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getCharacterStream", "(I)Ljava/io/Reader;", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Clob), "getClob", "(I)Ljava/sql/Clob;", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Clob), "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Date), "getDate", "(I)Ljava/sql/Date;", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Date), "getDate", "(Ljava/lang/String;)Ljava/sql/Date;", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Date), "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Date), "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(double), "getDouble", "(I)D", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(double), "getDouble", "(Ljava/lang/String;)D", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(float), "getFloat", "(I)F", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(float), "getFloat", "(Ljava/lang/String;)F", false, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getInt", "(I)I", false, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getInt", "(Ljava/lang/String;)I", false, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getLong", "(I)J", false, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getLong", "(Ljava/lang/String;)J", false, false, false );
            _cmj_fun37 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getNCharacterStream", "(I)Ljava/io/Reader;", false, false, false );
            _cmj_fun38 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", false, false, false );
            _cmj_fun39 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.NClob), "getNClob", "(I)Ljava/sql/NClob;", false, false, false );
            _cmj_fun40 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.NClob), "getNClob", "(Ljava/lang/String;)Ljava/sql/NClob;", false, false, false );
            _cmj_fun41 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getNString", "(I)Ljava/lang/String;", false, false, false );
            _cmj_fun42 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getNString", "(Ljava/lang/String;)Ljava/lang/String;", false, false, false );
            _cmj_fun43 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(I)Ljava/lang/Object;", false, false, false );
            _cmj_fun44 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(Ljava/lang/String;)Ljava/lang/Object;", false, false, false );
            _cmj_fun45 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(ILjava/util/Map;)Ljava/lang/Object;", false, false, false );
            _cmj_fun46 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(ILjava/lang/Class;)Ljava/lang/Object;", false, false, false );
            _cmj_fun47 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", false, false, false );
            _cmj_fun48 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", false, false, false );
            _cmj_fun49 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Ref), "getRef", "(I)Ljava/sql/Ref;", false, false, false );
            _cmj_fun50 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Ref), "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;", false, false, false );
            _cmj_fun51 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.RowId), "getRowId", "(I)Ljava/sql/RowId;", false, false, false );
            _cmj_fun52 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.RowId), "getRowId", "(Ljava/lang/String;)Ljava/sql/RowId;", false, false, false );
            _cmj_fun53 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "getShort", "(I)S", false, false, false );
            _cmj_fun54 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "getShort", "(Ljava/lang/String;)S", false, false, false );
            _cmj_fun55 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLXML), "getSQLXML", "(I)Ljava/sql/SQLXML;", false, false, false );
            _cmj_fun56 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLXML), "getSQLXML", "(Ljava/lang/String;)Ljava/sql/SQLXML;", false, false, false );
            _cmj_fun57 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getString", "(I)Ljava/lang/String;", false, false, false );
            _cmj_fun58 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getString", "(Ljava/lang/String;)Ljava/lang/String;", false, false, false );
            _cmj_fun59 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Time), "getTime", "(I)Ljava/sql/Time;", false, false, false );
            _cmj_fun60 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Time), "getTime", "(Ljava/lang/String;)Ljava/sql/Time;", false, false, false );
            _cmj_fun61 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Time), "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;", false, false, false );
            _cmj_fun62 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Time), "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;", false, false, false );
            _cmj_fun63 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "getTimestamp", "(I)Ljava/sql/Timestamp;", false, false, false );
            _cmj_fun64 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;", false, false, false );
            _cmj_fun65 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;", false, false, false );
            _cmj_fun66 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;", false, false, false );
            _cmj_fun67 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Net.URL), "getURL", "(I)Ljava/net/URL;", false, false, false );
            _cmj_fun68 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Net.URL), "getURL", "(Ljava/lang/String;)Ljava/net/URL;", false, false, false );
            _cmj_fun69 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(II)V", false, false, false );
            _cmj_fun70 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(Ljava/lang/String;I)V", false, false, false );
            _cmj_fun71 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(III)V", false, false, false );
            _cmj_fun72 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(IILjava/lang/String;)V", false, false, false );
            _cmj_fun73 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(Ljava/lang/String;II)V", false, false, false );
            _cmj_fun74 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "registerOutParameter", "(Ljava/lang/String;ILjava/lang/String;)V", false, false, false );
            _cmj_fun75 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun76 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", false, false, false );
            _cmj_fun77 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", false, false, false );
            _cmj_fun78 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", false, false, false );
            _cmj_fun79 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun80 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", false, false, false );
            _cmj_fun81 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", false, false, false );
            _cmj_fun82 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun83 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", false, false, false );
            _cmj_fun84 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", false, false, false );
            _cmj_fun85 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBoolean", "(Ljava/lang/String;Z)V", false, false, false );
            _cmj_fun86 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setByte", "(Ljava/lang/String;B)V", false, false, false );
            _cmj_fun87 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBytes", "(Ljava/lang/String;[B)V", false, false, false );
            _cmj_fun88 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun89 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", false, false, false );
            _cmj_fun90 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun91 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun92 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", false, false, false );
            _cmj_fun93 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun94 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDate", "(Ljava/lang/String;Ljava/sql/Date;)V", false, false, false );
            _cmj_fun95 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDate", "(Ljava/lang/String;Ljava/sql/Date;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun96 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDouble", "(Ljava/lang/String;D)V", false, false, false );
            _cmj_fun97 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFloat", "(Ljava/lang/String;F)V", false, false, false );
            _cmj_fun98 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setInt", "(Ljava/lang/String;I)V", false, false, false );
            _cmj_fun99 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setLong", "(Ljava/lang/String;J)V", false, false, false );
            _cmj_fun100 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun101 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun102 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun103 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V", false, false, false );
            _cmj_fun104 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun105 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNString", "(Ljava/lang/String;Ljava/lang/String;)V", false, false, false );
            _cmj_fun106 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNull", "(Ljava/lang/String;I)V", false, false, false );
            _cmj_fun107 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNull", "(Ljava/lang/String;ILjava/lang/String;)V", false, false, false );
            _cmj_fun108 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(Ljava/lang/String;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun109 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(Ljava/lang/String;Ljava/lang/Object;I)V", false, false, false );
            _cmj_fun110 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setObject", "(Ljava/lang/String;Ljava/lang/Object;II)V", false, false, false );
            _cmj_fun111 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V", false, false, false );
            _cmj_fun112 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setShort", "(Ljava/lang/String;S)V", false, false, false );
            _cmj_fun113 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V", false, false, false );
            _cmj_fun114 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setString", "(Ljava/lang/String;Ljava/lang/String;)V", false, false, false );
            _cmj_fun115 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(Ljava/lang/String;Ljava/sql/Time;)V", false, false, false );
            _cmj_fun116 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(Ljava/lang/String;Ljava/sql/Time;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun117 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", false, false, false );
            _cmj_fun118 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;Ljava/util/Calendar;)V", false, false, false );
            _cmj_fun119 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setURL", "(Ljava/lang/String;Ljava/net/URL;)V", false, false, false );
            _cmj_fun120 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "wasNull", "()Z", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public CallableStatementImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type CallableStatementImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.CallableStatement</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.CallableStatementImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.CallableStatementImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static void RegisterOutParameter(int arg0, global::Java.Sql.SQLType arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                _cmj_fun0.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void RegisterOutParameter(string arg0, global::Java.Sql.SQLType arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                _cmj_fun1.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void RegisterOutParameter(int arg0, global::Java.Sql.SQLType arg1, int arg2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2) )
            {
                _cmj_fun2.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void RegisterOutParameter(int arg0, global::Java.Sql.SQLType arg1, string arg2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2) )
            {
                _cmj_fun3.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void RegisterOutParameter(string arg0, global::Java.Sql.SQLType arg1, int arg2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2) )
            {
                _cmj_fun4.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void RegisterOutParameter(string arg0, global::Java.Sql.SQLType arg1, string arg2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2) )
            {
                _cmj_fun5.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void SetObject(string arg0, object arg1, global::Java.Sql.SQLType arg2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2) )
            {
                _cmj_fun6.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void SetObject(string arg0, object arg1, global::Java.Sql.SQLType arg2, int arg3)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2).Add(arg3) )
            {
                _cmj_fun7.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.Array GetArray(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun8.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun8.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ArrayImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Array)_cmj_fun8.CallObject( this, typeof(global::Java.Sql.Array), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Array GetArray(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun9.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun9.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ArrayImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Array)_cmj_fun9.CallObject( this, typeof(global::Java.Sql.Array), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Math.BigDecimal GetBigDecimal(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun10.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun10.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun10.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Math.BigDecimal GetBigDecimal(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun11.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun11.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun11.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Math.BigDecimal GetBigDecimal(int parameterIndex, int scale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(scale) )
            {
                if(_cmj_fun12.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun12.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun12.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Blob GetBlob(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun13.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun13.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.BlobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Blob)_cmj_fun13.CallObject( this, typeof(global::Java.Sql.Blob), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Blob GetBlob(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun14.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun14.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.BlobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Blob)_cmj_fun14.CallObject( this, typeof(global::Java.Sql.Blob), false, cmj_jmargs );
        
            }
        }        
        
        public bool GetBoolean(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun15.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool GetBoolean(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun16.CallBool( this, cmj_jmargs );
            }
        }        
        
        public byte GetByte(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun17.CallByte( this, cmj_jmargs );
            }
        }        
        
        public byte GetByte(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun18.CallByte( this, cmj_jmargs );
            }
        }        
        
        public global::Codemesh.JuggerNET.byteArray GetBytes(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun19.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun19.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Codemesh.JuggerNET.byteArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Codemesh.JuggerNET.byteArray)_cmj_fun19.CallObject( this, typeof(global::Codemesh.JuggerNET.byteArray), false, cmj_jmargs );
        
            }
        }        
        
        public global::Codemesh.JuggerNET.byteArray GetBytes(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun20.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun20.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Codemesh.JuggerNET.byteArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Codemesh.JuggerNET.byteArray)_cmj_fun20.CallObject( this, typeof(global::Codemesh.JuggerNET.byteArray), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.Reader GetCharacterStream(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun21.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun21.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Reader)_cmj_fun21.CallObject( this, typeof(global::Java.Io.Reader), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.Reader GetCharacterStream(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun22.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun22.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Reader)_cmj_fun22.CallObject( this, typeof(global::Java.Io.Reader), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Clob GetClob(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun23.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun23.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Clob)_cmj_fun23.CallObject( this, typeof(global::Java.Sql.Clob), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Clob GetClob(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun24.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun24.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Clob)_cmj_fun24.CallObject( this, typeof(global::Java.Sql.Clob), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Date GetDate(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun25.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun25.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Date)_cmj_fun25.CallObject( this, typeof(global::Java.Sql.Date), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Date GetDate(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun26.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun26.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Date)_cmj_fun26.CallObject( this, typeof(global::Java.Sql.Date), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Date GetDate(int parameterIndex, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(cal) )
            {
                if(_cmj_fun27.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun27.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Date)_cmj_fun27.CallObject( this, typeof(global::Java.Sql.Date), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Date GetDate(string parameterName, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(cal) )
            {
                if(_cmj_fun28.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun28.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Date)_cmj_fun28.CallObject( this, typeof(global::Java.Sql.Date), false, cmj_jmargs );
        
            }
        }        
        
        public double GetDouble(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun29.CallDouble( this, cmj_jmargs );
            }
        }        
        
        public double GetDouble(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun30.CallDouble( this, cmj_jmargs );
            }
        }        
        
        public float GetFloat(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun31.CallFloat( this, cmj_jmargs );
            }
        }        
        
        public float GetFloat(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun32.CallFloat( this, cmj_jmargs );
            }
        }        
        
        public int GetInt(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun33.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int GetInt(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun34.CallInt( this, cmj_jmargs );
            }
        }        
        
        public long GetLong(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun35.CallLong( this, cmj_jmargs );
            }
        }        
        
        public long GetLong(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun36.CallLong( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Io.Reader GetNCharacterStream(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun37.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun37.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Reader)_cmj_fun37.CallObject( this, typeof(global::Java.Io.Reader), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.Reader GetNCharacterStream(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun38.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun38.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Reader)_cmj_fun38.CallObject( this, typeof(global::Java.Io.Reader), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.NClob GetNClob(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun39.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun39.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.NClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.NClob)_cmj_fun39.CallObject( this, typeof(global::Java.Sql.NClob), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.NClob GetNClob(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun40.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun40.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.NClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.NClob)_cmj_fun40.CallObject( this, typeof(global::Java.Sql.NClob), false, cmj_jmargs );
        
            }
        }        
        
        public string GetNString(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun41.CallString( this, cmj_jmargs );
            }
        }        
        
        public string GetNString(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun42.CallString( this, cmj_jmargs );
            }
        }        
        
        public object GetObject(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun43.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun44.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(int parameterIndex, global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(map) )
            {
                return _cmj_fun45.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(int parameterIndex, global::Java.Lang.Class type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(type) )
            {
                return _cmj_fun46.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(string parameterName, global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(map) )
            {
                return _cmj_fun47.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(string parameterName, global::Java.Lang.Class type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(type) )
            {
                return _cmj_fun48.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.Ref GetRef(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun49.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun49.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.RefImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Ref)_cmj_fun49.CallObject( this, typeof(global::Java.Sql.Ref), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Ref GetRef(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun50.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun50.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.RefImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Ref)_cmj_fun50.CallObject( this, typeof(global::Java.Sql.Ref), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.RowId GetRowId(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun51.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun51.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.RowIdImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.RowId)_cmj_fun51.CallObject( this, typeof(global::Java.Sql.RowId), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.RowId GetRowId(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun52.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun52.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.RowIdImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.RowId)_cmj_fun52.CallObject( this, typeof(global::Java.Sql.RowId), false, cmj_jmargs );
        
            }
        }        
        
        public short GetShort(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun53.CallShort( this, cmj_jmargs );
            }
        }        
        
        public short GetShort(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun54.CallShort( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.SQLXML GetSQLXML(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun55.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun55.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.SQLXMLImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.SQLXML)_cmj_fun55.CallObject( this, typeof(global::Java.Sql.SQLXML), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.SQLXML GetSQLXML(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun56.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun56.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.SQLXMLImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.SQLXML)_cmj_fun56.CallObject( this, typeof(global::Java.Sql.SQLXML), false, cmj_jmargs );
        
            }
        }        
        
        public string GetString(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                return _cmj_fun57.CallString( this, cmj_jmargs );
            }
        }        
        
        public string GetString(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                return _cmj_fun58.CallString( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.Time GetTime(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun59.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun59.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Time( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Time)_cmj_fun59.CallObject( this, typeof(global::Java.Sql.Time), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Time GetTime(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun60.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun60.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Time( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Time)_cmj_fun60.CallObject( this, typeof(global::Java.Sql.Time), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Time GetTime(int parameterIndex, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(cal) )
            {
                if(_cmj_fun61.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun61.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Time( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Time)_cmj_fun61.CallObject( this, typeof(global::Java.Sql.Time), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Time GetTime(string parameterName, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(cal) )
            {
                if(_cmj_fun62.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun62.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Time( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Time)_cmj_fun62.CallObject( this, typeof(global::Java.Sql.Time), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Timestamp GetTimestamp(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                if(_cmj_fun63.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun63.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun63.CallObject( this, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Timestamp GetTimestamp(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                if(_cmj_fun64.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun64.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun64.CallObject( this, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Timestamp GetTimestamp(int parameterIndex, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(cal) )
            {
                if(_cmj_fun65.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun65.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun65.CallObject( this, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Timestamp GetTimestamp(string parameterName, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(cal) )
            {
                if(_cmj_fun66.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun66.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun66.CallObject( this, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Net.URL GetURL(int parameterIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex) )
            {
                long    jnet_ref = (long)_cmj_fun67.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Net.URL( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }        
        
        public global::Java.Net.URL GetURL(string parameterName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName) )
            {
                long    jnet_ref = (long)_cmj_fun68.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Net.URL( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }        
        
        public void RegisterOutParameter(int parameterIndex, int sqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(sqlType) )
            {
                _cmj_fun69.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void RegisterOutParameter(string parameterName, int sqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(sqlType) )
            {
                _cmj_fun70.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void RegisterOutParameter(int parameterIndex, int sqlType, int scale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(sqlType).Add(scale) )
            {
                _cmj_fun71.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void RegisterOutParameter(int parameterIndex, int sqlType, string typeName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterIndex).Add(sqlType).Add(typeName) )
            {
                _cmj_fun72.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void RegisterOutParameter(string parameterName, int sqlType, int scale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(sqlType).Add(scale) )
            {
                _cmj_fun73.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void RegisterOutParameter(string parameterName, int sqlType, string typeName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(sqlType).Add(typeName) )
            {
                _cmj_fun74.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(string parameterName, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun75.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(string parameterName, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(length) )
            {
                _cmj_fun76.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetAsciiStream(string parameterName, global::Java.Io.InputStream x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(length) )
            {
                _cmj_fun77.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBigDecimal(string parameterName, global::Java.Math.BigDecimal x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun78.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(string parameterName, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun79.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(string parameterName, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(length) )
            {
                _cmj_fun80.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBinaryStream(string parameterName, global::Java.Io.InputStream x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(length) )
            {
                _cmj_fun81.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(string parameterName, global::Java.Io.InputStream inputStream)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(inputStream) )
            {
                _cmj_fun82.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(string parameterName, global::Java.Sql.Blob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun83.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBlob(string parameterName, global::Java.Io.InputStream inputStream, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(inputStream).Add(length) )
            {
                _cmj_fun84.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBoolean(string parameterName, bool x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun85.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetByte(string parameterName, byte x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun86.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetBytes(string parameterName, global::Codemesh.JuggerNET.byteArray x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun87.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(string parameterName, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader) )
            {
                _cmj_fun88.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(string parameterName, global::Java.Io.Reader reader, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader).Add(length) )
            {
                _cmj_fun89.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCharacterStream(string parameterName, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader).Add(length) )
            {
                _cmj_fun90.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(string parameterName, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader) )
            {
                _cmj_fun91.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(string parameterName, global::Java.Sql.Clob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun92.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetClob(string parameterName, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader).Add(length) )
            {
                _cmj_fun93.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDate(string parameterName, global::Java.Sql.Date x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun94.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDate(string parameterName, global::Java.Sql.Date x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(cal) )
            {
                _cmj_fun95.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetDouble(string parameterName, double x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun96.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetFloat(string parameterName, float x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun97.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetInt(string parameterName, int x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun98.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetLong(string parameterName, long x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun99.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNCharacterStream(string parameterName, global::Java.Io.Reader value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(value) )
            {
                _cmj_fun100.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNCharacterStream(string parameterName, global::Java.Io.Reader value, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(value).Add(length) )
            {
                _cmj_fun101.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(string parameterName, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader) )
            {
                _cmj_fun102.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(string parameterName, global::Java.Sql.NClob value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(value) )
            {
                _cmj_fun103.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNClob(string parameterName, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(reader).Add(length) )
            {
                _cmj_fun104.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNString(string parameterName, string value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(value) )
            {
                _cmj_fun105.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNull(string parameterName, int sqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(sqlType) )
            {
                _cmj_fun106.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNull(string parameterName, int sqlType, string typeName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(sqlType).Add(typeName) )
            {
                _cmj_fun107.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(string parameterName, object x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun108.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(string parameterName, object x, int targetSqlType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(targetSqlType) )
            {
                _cmj_fun109.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetObject(string parameterName, object x, int targetSqlType, int scale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(targetSqlType).Add(scale) )
            {
                _cmj_fun110.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetRowId(string parameterName, global::Java.Sql.RowId x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun111.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetShort(string parameterName, short x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun112.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetSQLXML(string parameterName, global::Java.Sql.SQLXML xmlObject)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(xmlObject) )
            {
                _cmj_fun113.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetString(string parameterName, string x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun114.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTime(string parameterName, global::Java.Sql.Time x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun115.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTime(string parameterName, global::Java.Sql.Time x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(cal) )
            {
                _cmj_fun116.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTimestamp(string parameterName, global::Java.Sql.Timestamp x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x) )
            {
                _cmj_fun117.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTimestamp(string parameterName, global::Java.Sql.Timestamp x, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(x).Add(cal) )
            {
                _cmj_fun118.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetURL(string parameterName, global::Java.Net.URL val)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterName).Add(val) )
            {
                _cmj_fun119.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public bool WasNull()
        {
            return _cmj_fun120.CallBool( this );
        }        
    }    
    

}
