/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.ResultSet
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("7852DFF9-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.ResultSet")]
    public interface ResultSet :
        global::Java.Sql.Wrapper,
        global::Java.Lang.AutoCloseable
    { 
        bool Absolute(int row);
    
    
        void AfterLast();
    
    
        void BeforeFirst();
    
    
        void CancelRowUpdates();
    
    
        void ClearWarnings();
    
    
        void DeleteRow();
    
    
        int FindColumn(string columnLabel);
    
    
        bool First();
    
    
        global::Java.Sql.Array GetArray(int columnIndex);
    
    
        global::Java.Sql.Array GetArray(string columnLabel);
    
    
        global::Java.Io.InputStream GetAsciiStream(int columnIndex);
    
    
        global::Java.Io.InputStream GetAsciiStream(string columnLabel);
    
    
        global::Java.Math.BigDecimal GetBigDecimal(int columnIndex);
    
    
        global::Java.Math.BigDecimal GetBigDecimal(string columnLabel);
    
    
        global::Java.Math.BigDecimal GetBigDecimal(int columnIndex, int scale);
    
    
        global::Java.Math.BigDecimal GetBigDecimal(string columnLabel, int scale);
    
    
        global::Java.Io.InputStream GetBinaryStream(int columnIndex);
    
    
        global::Java.Io.InputStream GetBinaryStream(string columnLabel);
    
    
        global::Java.Sql.Blob GetBlob(int columnIndex);
    
    
        global::Java.Sql.Blob GetBlob(string columnLabel);
    
    
        bool GetBoolean(int columnIndex);
    
    
        bool GetBoolean(string columnLabel);
    
    
        byte GetByte(int columnIndex);
    
    
        byte GetByte(string columnLabel);
    
    
        global::Codemesh.JuggerNET.byteArray GetBytes(int columnIndex);
    
    
        global::Codemesh.JuggerNET.byteArray GetBytes(string columnLabel);
    
    
        global::Java.Io.Reader GetCharacterStream(int columnIndex);
    
    
        global::Java.Io.Reader GetCharacterStream(string columnLabel);
    
    
        global::Java.Sql.Clob GetClob(int columnIndex);
    
    
        global::Java.Sql.Clob GetClob(string columnLabel);
    
    
        int GetConcurrency();
    
    
        string GetCursorName();
    
    
        global::Java.Sql.Date GetDate(int columnIndex);
    
    
        global::Java.Sql.Date GetDate(string columnLabel);
    
    
        global::Java.Sql.Date GetDate(int columnIndex, global::Java.Util.Calendar cal);
    
    
        global::Java.Sql.Date GetDate(string columnLabel, global::Java.Util.Calendar cal);
    
    
        double GetDouble(int columnIndex);
    
    
        double GetDouble(string columnLabel);
    
    
        int GetFetchDirection();
    
    
        int GetFetchSize();
    
    
        float GetFloat(int columnIndex);
    
    
        float GetFloat(string columnLabel);
    
    
        int GetHoldability();
    
    
        int GetInt(int columnIndex);
    
    
        int GetInt(string columnLabel);
    
    
        long GetLong(int columnIndex);
    
    
        long GetLong(string columnLabel);
    
    
        global::Java.Sql.ResultSetMetaData GetMetaData();
    
    
        global::Java.Io.Reader GetNCharacterStream(int columnIndex);
    
    
        global::Java.Io.Reader GetNCharacterStream(string columnLabel);
    
    
        global::Java.Sql.NClob GetNClob(int columnIndex);
    
    
        global::Java.Sql.NClob GetNClob(string columnLabel);
    
    
        string GetNString(int columnIndex);
    
    
        string GetNString(string columnLabel);
    
    
        object GetObject(int columnIndex);
    
    
        object GetObject(string columnLabel);
    
    
        object GetObject(int columnIndex, global::Java.Lang.Class type);
    
    
        object GetObject(int columnIndex, global::Java.Util.Map map);
    
    
        object GetObject(string columnLabel, global::Java.Lang.Class type);
    
    
        object GetObject(string columnLabel, global::Java.Util.Map map);
    
    
        global::Java.Sql.Ref GetRef(int columnIndex);
    
    
        global::Java.Sql.Ref GetRef(string columnLabel);
    
    
        int GetRow();
    
    
        global::Java.Sql.RowId GetRowId(int columnIndex);
    
    
        global::Java.Sql.RowId GetRowId(string columnLabel);
    
    
        global::Java.Sql.SQLXML GetSQLXML(int columnIndex);
    
    
        global::Java.Sql.SQLXML GetSQLXML(string columnLabel);
    
    
        short GetShort(int columnIndex);
    
    
        short GetShort(string columnLabel);
    
    
        global::Java.Sql.Statement GetStatement();
    
    
        string GetString(int columnIndex);
    
    
        string GetString(string columnLabel);
    
    
        global::Java.Sql.Time GetTime(int columnIndex);
    
    
        global::Java.Sql.Time GetTime(string columnLabel);
    
    
        global::Java.Sql.Time GetTime(int columnIndex, global::Java.Util.Calendar cal);
    
    
        global::Java.Sql.Time GetTime(string columnLabel, global::Java.Util.Calendar cal);
    
    
        global::Java.Sql.Timestamp GetTimestamp(int columnIndex);
    
    
        global::Java.Sql.Timestamp GetTimestamp(string columnLabel);
    
    
        global::Java.Sql.Timestamp GetTimestamp(int columnIndex, global::Java.Util.Calendar cal);
    
    
        global::Java.Sql.Timestamp GetTimestamp(string columnLabel, global::Java.Util.Calendar cal);
    
    
        int GetType_Java();
    
    
        global::Java.Net.URL GetURL(int columnIndex);
    
    
        global::Java.Net.URL GetURL(string columnLabel);
    
    
        global::Java.Io.InputStream GetUnicodeStream(int columnIndex);
    
    
        global::Java.Io.InputStream GetUnicodeStream(string columnLabel);
    
    
        global::Java.Sql.SQLWarning GetWarnings();
    
    
        void InsertRow();
    
    
        bool IsAfterLast();
    
    
        bool IsBeforeFirst();
    
    
        bool IsClosed();
    
    
        bool IsFirst();
    
    
        bool IsLast();
    
    
        bool Last();
    
    
        void MoveToCurrentRow();
    
    
        void MoveToInsertRow();
    
    
        bool Next();
    
    
        bool Previous();
    
    
        void RefreshRow();
    
    
        bool Relative(int rows);
    
    
        bool RowDeleted();
    
    
        bool RowInserted();
    
    
        bool RowUpdated();
    
    
        void SetFetchDirection(int direction);
    
    
        void SetFetchSize(int rows);
    
    
        void UpdateArray(int columnIndex, global::Java.Sql.Array x);
    
    
        void UpdateArray(string columnLabel, global::Java.Sql.Array x);
    
    
        void UpdateAsciiStream(int columnIndex, global::Java.Io.InputStream x);
    
    
        void UpdateAsciiStream(string columnLabel, global::Java.Io.InputStream x);
    
    
        void UpdateAsciiStream(int columnIndex, global::Java.Io.InputStream x, int length);
    
    
        void UpdateAsciiStream(int columnIndex, global::Java.Io.InputStream x, long length);
    
    
        void UpdateAsciiStream(string columnLabel, global::Java.Io.InputStream x, int length);
    
    
        void UpdateAsciiStream(string columnLabel, global::Java.Io.InputStream x, long length);
    
    
        void UpdateBigDecimal(int columnIndex, global::Java.Math.BigDecimal x);
    
    
        void UpdateBigDecimal(string columnLabel, global::Java.Math.BigDecimal x);
    
    
        void UpdateBinaryStream(int columnIndex, global::Java.Io.InputStream x);
    
    
        void UpdateBinaryStream(string columnLabel, global::Java.Io.InputStream x);
    
    
        void UpdateBinaryStream(int columnIndex, global::Java.Io.InputStream x, int length);
    
    
        void UpdateBinaryStream(int columnIndex, global::Java.Io.InputStream x, long length);
    
    
        void UpdateBinaryStream(string columnLabel, global::Java.Io.InputStream x, int length);
    
    
        void UpdateBinaryStream(string columnLabel, global::Java.Io.InputStream x, long length);
    
    
        void UpdateBlob(int columnIndex, global::Java.Io.InputStream inputStream);
    
    
        void UpdateBlob(int columnIndex, global::Java.Sql.Blob x);
    
    
        void UpdateBlob(string columnLabel, global::Java.Io.InputStream inputStream);
    
    
        void UpdateBlob(string columnLabel, global::Java.Sql.Blob x);
    
    
        void UpdateBlob(int columnIndex, global::Java.Io.InputStream inputStream, long length);
    
    
        void UpdateBlob(string columnLabel, global::Java.Io.InputStream inputStream, long length);
    
    
        void UpdateBoolean(int columnIndex, bool x);
    
    
        void UpdateBoolean(string columnLabel, bool x);
    
    
        void UpdateByte(int columnIndex, byte x);
    
    
        void UpdateByte(string columnLabel, byte x);
    
    
        void UpdateBytes(int columnIndex, global::Codemesh.JuggerNET.byteArray x);
    
    
        void UpdateBytes(string columnLabel, global::Codemesh.JuggerNET.byteArray x);
    
    
        void UpdateCharacterStream(int columnIndex, global::Java.Io.Reader x);
    
    
        void UpdateCharacterStream(string columnLabel, global::Java.Io.Reader reader);
    
    
        void UpdateCharacterStream(int columnIndex, global::Java.Io.Reader x, int length);
    
    
        void UpdateCharacterStream(int columnIndex, global::Java.Io.Reader x, long length);
    
    
        void UpdateCharacterStream(string columnLabel, global::Java.Io.Reader reader, int length);
    
    
        void UpdateCharacterStream(string columnLabel, global::Java.Io.Reader reader, long length);
    
    
        void UpdateClob(int columnIndex, global::Java.Io.Reader reader);
    
    
        void UpdateClob(int columnIndex, global::Java.Sql.Clob x);
    
    
        void UpdateClob(string columnLabel, global::Java.Io.Reader reader);
    
    
        void UpdateClob(string columnLabel, global::Java.Sql.Clob x);
    
    
        void UpdateClob(int columnIndex, global::Java.Io.Reader reader, long length);
    
    
        void UpdateClob(string columnLabel, global::Java.Io.Reader reader, long length);
    
    
        void UpdateDate(int columnIndex, global::Java.Sql.Date x);
    
    
        void UpdateDate(string columnLabel, global::Java.Sql.Date x);
    
    
        void UpdateDouble(int columnIndex, double x);
    
    
        void UpdateDouble(string columnLabel, double x);
    
    
        void UpdateFloat(int columnIndex, float x);
    
    
        void UpdateFloat(string columnLabel, float x);
    
    
        void UpdateInt(int columnIndex, int x);
    
    
        void UpdateInt(string columnLabel, int x);
    
    
        void UpdateLong(int columnIndex, long x);
    
    
        void UpdateLong(string columnLabel, long x);
    
    
        void UpdateNCharacterStream(int columnIndex, global::Java.Io.Reader x);
    
    
        void UpdateNCharacterStream(string columnLabel, global::Java.Io.Reader reader);
    
    
        void UpdateNCharacterStream(int columnIndex, global::Java.Io.Reader x, long length);
    
    
        void UpdateNCharacterStream(string columnLabel, global::Java.Io.Reader reader, long length);
    
    
        void UpdateNClob(int columnIndex, global::Java.Io.Reader reader);
    
    
        void UpdateNClob(int columnIndex, global::Java.Sql.NClob nClob);
    
    
        void UpdateNClob(string columnLabel, global::Java.Io.Reader reader);
    
    
        void UpdateNClob(string columnLabel, global::Java.Sql.NClob nClob);
    
    
        void UpdateNClob(int columnIndex, global::Java.Io.Reader reader, long length);
    
    
        void UpdateNClob(string columnLabel, global::Java.Io.Reader reader, long length);
    
    
        void UpdateNString(int columnIndex, string nString);
    
    
        void UpdateNString(string columnLabel, string nString);
    
    
        void UpdateNull(int columnIndex);
    
    
        void UpdateNull(string columnLabel);
    
    
        void UpdateObject(int columnIndex, object x);
    
    
        void UpdateObject(string columnLabel, object x);
    
    
        void UpdateObject(int columnIndex, object x, int scaleOrLength);
    
    
        void UpdateObject(string columnLabel, object x, int scaleOrLength);
    
    
        void UpdateRef(int columnIndex, global::Java.Sql.Ref x);
    
    
        void UpdateRef(string columnLabel, global::Java.Sql.Ref x);
    
    
        void UpdateRow();
    
    
        void UpdateRowId(int columnIndex, global::Java.Sql.RowId x);
    
    
        void UpdateRowId(string columnLabel, global::Java.Sql.RowId x);
    
    
        void UpdateSQLXML(int columnIndex, global::Java.Sql.SQLXML xmlObject);
    
    
        void UpdateSQLXML(string columnLabel, global::Java.Sql.SQLXML xmlObject);
    
    
        void UpdateShort(int columnIndex, short x);
    
    
        void UpdateShort(string columnLabel, short x);
    
    
        void UpdateString(int columnIndex, string x);
    
    
        void UpdateString(string columnLabel, string x);
    
    
        void UpdateTime(int columnIndex, global::Java.Sql.Time x);
    
    
        void UpdateTime(string columnLabel, global::Java.Sql.Time x);
    
    
        void UpdateTimestamp(int columnIndex, global::Java.Sql.Timestamp x);
    
    
        void UpdateTimestamp(string columnLabel, global::Java.Sql.Timestamp x);
    
    
        bool WasNull();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.ResultSet")]
    public class ResultSetImpl :
        global::Java.Sql.WrapperImpl,
        global::Java.Sql.ResultSet
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
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun176;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun177;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun178;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun179;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun180;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun181;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun182;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun183;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun184;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun185;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun186;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun187;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun188;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun189;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun190;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun191;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun192;
    
        static ResultSetImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.ResultSet", typeof(global::Java.Sql.ResultSet), typeof(global::Java.Sql.ResultSetImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateObject", "(ILjava/lang/Object;Ljava/sql/SQLType;)V", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateObject", "(Ljava/lang/String;Ljava/lang/Object;Ljava/sql/SQLType;)V", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateObject", "(ILjava/lang/Object;Ljava/sql/SQLType;I)V", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateObject", "(Ljava/lang/String;Ljava/lang/Object;Ljava/sql/SQLType;I)V", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "absolute", "(I)Z", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "afterLast", "()V", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "beforeFirst", "()V", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "cancelRowUpdates", "()V", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "clearWarnings", "()V", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "close", "()V", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "deleteRow", "()V", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "findColumn", "(Ljava/lang/String;)I", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "first", "()Z", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Array), "getArray", "(I)Ljava/sql/Array;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Array), "getArray", "(Ljava/lang/String;)Ljava/sql/Array;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getAsciiStream", "(I)Ljava/io/InputStream;", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getAsciiStream", "(Ljava/lang/String;)Ljava/io/InputStream;", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "getBigDecimal", "(I)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "getBigDecimal", "(Ljava/lang/String;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "getBigDecimal", "(II)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "getBigDecimal", "(Ljava/lang/String;I)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getBinaryStream", "(I)Ljava/io/InputStream;", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getBinaryStream", "(Ljava/lang/String;)Ljava/io/InputStream;", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Blob), "getBlob", "(I)Ljava/sql/Blob;", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Blob), "getBlob", "(Ljava/lang/String;)Ljava/sql/Blob;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getBoolean", "(I)Z", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getBoolean", "(Ljava/lang/String;)Z", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(byte), "getByte", "(I)B", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(byte), "getByte", "(Ljava/lang/String;)B", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Codemesh.JuggerNET.byteArray), "getBytes", "(I)[B", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Codemesh.JuggerNET.byteArray), "getBytes", "(Ljava/lang/String;)[B", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getCharacterStream", "(I)Ljava/io/Reader;", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", false, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Clob), "getClob", "(I)Ljava/sql/Clob;", false, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Clob), "getClob", "(Ljava/lang/String;)Ljava/sql/Clob;", false, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getConcurrency", "()I", false, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getCursorName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun37 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Date), "getDate", "(I)Ljava/sql/Date;", false, false, false );
            _cmj_fun38 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Date), "getDate", "(Ljava/lang/String;)Ljava/sql/Date;", false, false, false );
            _cmj_fun39 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Date), "getDate", "(ILjava/util/Calendar;)Ljava/sql/Date;", false, false, false );
            _cmj_fun40 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Date), "getDate", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Date;", false, false, false );
            _cmj_fun41 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(double), "getDouble", "(I)D", false, false, false );
            _cmj_fun42 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(double), "getDouble", "(Ljava/lang/String;)D", false, false, false );
            _cmj_fun43 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getFetchDirection", "()I", false, false, false );
            _cmj_fun44 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getFetchSize", "()I", false, false, false );
            _cmj_fun45 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(float), "getFloat", "(I)F", false, false, false );
            _cmj_fun46 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(float), "getFloat", "(Ljava/lang/String;)F", false, false, false );
            _cmj_fun47 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getHoldability", "()I", false, false, false );
            _cmj_fun48 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getInt", "(I)I", false, false, false );
            _cmj_fun49 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getInt", "(Ljava/lang/String;)I", false, false, false );
            _cmj_fun50 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getLong", "(I)J", false, false, false );
            _cmj_fun51 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getLong", "(Ljava/lang/String;)J", false, false, false );
            _cmj_fun52 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSetMetaData), "getMetaData", "()Ljava/sql/ResultSetMetaData;", false, false, false );
            _cmj_fun53 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getNCharacterStream", "(I)Ljava/io/Reader;", false, false, false );
            _cmj_fun54 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getNCharacterStream", "(Ljava/lang/String;)Ljava/io/Reader;", false, false, false );
            _cmj_fun55 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.NClob), "getNClob", "(I)Ljava/sql/NClob;", false, false, false );
            _cmj_fun56 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.NClob), "getNClob", "(Ljava/lang/String;)Ljava/sql/NClob;", false, false, false );
            _cmj_fun57 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getNString", "(I)Ljava/lang/String;", false, false, false );
            _cmj_fun58 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getNString", "(Ljava/lang/String;)Ljava/lang/String;", false, false, false );
            _cmj_fun59 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(I)Ljava/lang/Object;", false, false, false );
            _cmj_fun60 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(Ljava/lang/String;)Ljava/lang/Object;", false, false, false );
            _cmj_fun61 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(ILjava/util/Map;)Ljava/lang/Object;", false, false, false );
            _cmj_fun62 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(ILjava/lang/Class;)Ljava/lang/Object;", false, false, false );
            _cmj_fun63 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/Object;", false, false, false );
            _cmj_fun64 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getObject", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", false, false, false );
            _cmj_fun65 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Ref), "getRef", "(I)Ljava/sql/Ref;", false, false, false );
            _cmj_fun66 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Ref), "getRef", "(Ljava/lang/String;)Ljava/sql/Ref;", false, false, false );
            _cmj_fun67 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getRow", "()I", false, false, false );
            _cmj_fun68 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.RowId), "getRowId", "(I)Ljava/sql/RowId;", false, false, false );
            _cmj_fun69 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.RowId), "getRowId", "(Ljava/lang/String;)Ljava/sql/RowId;", false, false, false );
            _cmj_fun70 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "getShort", "(I)S", false, false, false );
            _cmj_fun71 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "getShort", "(Ljava/lang/String;)S", false, false, false );
            _cmj_fun72 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLXML), "getSQLXML", "(I)Ljava/sql/SQLXML;", false, false, false );
            _cmj_fun73 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLXML), "getSQLXML", "(Ljava/lang/String;)Ljava/sql/SQLXML;", false, false, false );
            _cmj_fun74 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Statement), "getStatement", "()Ljava/sql/Statement;", false, false, false );
            _cmj_fun75 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getString", "(I)Ljava/lang/String;", false, false, false );
            _cmj_fun76 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getString", "(Ljava/lang/String;)Ljava/lang/String;", false, false, false );
            _cmj_fun77 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Time), "getTime", "(I)Ljava/sql/Time;", false, false, false );
            _cmj_fun78 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Time), "getTime", "(Ljava/lang/String;)Ljava/sql/Time;", false, false, false );
            _cmj_fun79 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Time), "getTime", "(ILjava/util/Calendar;)Ljava/sql/Time;", false, false, false );
            _cmj_fun80 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Time), "getTime", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Time;", false, false, false );
            _cmj_fun81 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "getTimestamp", "(I)Ljava/sql/Timestamp;", false, false, false );
            _cmj_fun82 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "getTimestamp", "(Ljava/lang/String;)Ljava/sql/Timestamp;", false, false, false );
            _cmj_fun83 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "getTimestamp", "(ILjava/util/Calendar;)Ljava/sql/Timestamp;", false, false, false );
            _cmj_fun84 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "getTimestamp", "(Ljava/lang/String;Ljava/util/Calendar;)Ljava/sql/Timestamp;", false, false, false );
            _cmj_fun85 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getType", "()I", false, false, false );
            _cmj_fun86 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getUnicodeStream", "(I)Ljava/io/InputStream;", false, false, false );
            _cmj_fun87 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getUnicodeStream", "(Ljava/lang/String;)Ljava/io/InputStream;", false, false, false );
            _cmj_fun88 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Net.URL), "getURL", "(I)Ljava/net/URL;", false, false, false );
            _cmj_fun89 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Net.URL), "getURL", "(Ljava/lang/String;)Ljava/net/URL;", false, false, false );
            _cmj_fun90 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLWarning), "getWarnings", "()Ljava/sql/SQLWarning;", false, false, false );
            _cmj_fun91 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "insertRow", "()V", false, false, false );
            _cmj_fun92 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isAfterLast", "()Z", false, false, false );
            _cmj_fun93 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isBeforeFirst", "()Z", false, false, false );
            _cmj_fun94 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isClosed", "()Z", false, false, false );
            _cmj_fun95 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isFirst", "()Z", false, false, false );
            _cmj_fun96 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isLast", "()Z", false, false, false );
            _cmj_fun97 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "last", "()Z", false, false, false );
            _cmj_fun98 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "moveToCurrentRow", "()V", false, false, false );
            _cmj_fun99 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "moveToInsertRow", "()V", false, false, false );
            _cmj_fun100 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "next", "()Z", false, false, false );
            _cmj_fun101 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "previous", "()Z", false, false, false );
            _cmj_fun102 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "refreshRow", "()V", false, false, false );
            _cmj_fun103 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "relative", "(I)Z", false, false, false );
            _cmj_fun104 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "rowDeleted", "()Z", false, false, false );
            _cmj_fun105 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "rowInserted", "()Z", false, false, false );
            _cmj_fun106 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "rowUpdated", "()Z", false, false, false );
            _cmj_fun107 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFetchDirection", "(I)V", false, false, false );
            _cmj_fun108 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFetchSize", "(I)V", false, false, false );
            _cmj_fun109 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateArray", "(ILjava/sql/Array;)V", false, false, false );
            _cmj_fun110 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateArray", "(Ljava/lang/String;Ljava/sql/Array;)V", false, false, false );
            _cmj_fun111 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateAsciiStream", "(ILjava/io/InputStream;)V", false, false, false );
            _cmj_fun112 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun113 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateAsciiStream", "(ILjava/io/InputStream;I)V", false, false, false );
            _cmj_fun114 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateAsciiStream", "(ILjava/io/InputStream;J)V", false, false, false );
            _cmj_fun115 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", false, false, false );
            _cmj_fun116 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateAsciiStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", false, false, false );
            _cmj_fun117 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBigDecimal", "(ILjava/math/BigDecimal;)V", false, false, false );
            _cmj_fun118 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBigDecimal", "(Ljava/lang/String;Ljava/math/BigDecimal;)V", false, false, false );
            _cmj_fun119 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBinaryStream", "(ILjava/io/InputStream;)V", false, false, false );
            _cmj_fun120 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun121 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBinaryStream", "(ILjava/io/InputStream;I)V", false, false, false );
            _cmj_fun122 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBinaryStream", "(ILjava/io/InputStream;J)V", false, false, false );
            _cmj_fun123 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;I)V", false, false, false );
            _cmj_fun124 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBinaryStream", "(Ljava/lang/String;Ljava/io/InputStream;J)V", false, false, false );
            _cmj_fun125 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBlob", "(ILjava/io/InputStream;)V", false, false, false );
            _cmj_fun126 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBlob", "(ILjava/sql/Blob;)V", false, false, false );
            _cmj_fun127 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun128 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBlob", "(Ljava/lang/String;Ljava/sql/Blob;)V", false, false, false );
            _cmj_fun129 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBlob", "(ILjava/io/InputStream;J)V", false, false, false );
            _cmj_fun130 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBlob", "(Ljava/lang/String;Ljava/io/InputStream;J)V", false, false, false );
            _cmj_fun131 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBoolean", "(IZ)V", false, false, false );
            _cmj_fun132 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBoolean", "(Ljava/lang/String;Z)V", false, false, false );
            _cmj_fun133 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateByte", "(IB)V", false, false, false );
            _cmj_fun134 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateByte", "(Ljava/lang/String;B)V", false, false, false );
            _cmj_fun135 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBytes", "(I[B)V", false, false, false );
            _cmj_fun136 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateBytes", "(Ljava/lang/String;[B)V", false, false, false );
            _cmj_fun137 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateCharacterStream", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun138 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun139 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateCharacterStream", "(ILjava/io/Reader;I)V", false, false, false );
            _cmj_fun140 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateCharacterStream", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun141 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;I)V", false, false, false );
            _cmj_fun142 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun143 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateClob", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun144 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateClob", "(ILjava/sql/Clob;)V", false, false, false );
            _cmj_fun145 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateClob", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun146 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateClob", "(Ljava/lang/String;Ljava/sql/Clob;)V", false, false, false );
            _cmj_fun147 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateClob", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun148 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun149 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateDate", "(ILjava/sql/Date;)V", false, false, false );
            _cmj_fun150 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateDate", "(Ljava/lang/String;Ljava/sql/Date;)V", false, false, false );
            _cmj_fun151 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateDouble", "(ID)V", false, false, false );
            _cmj_fun152 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateDouble", "(Ljava/lang/String;D)V", false, false, false );
            _cmj_fun153 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateFloat", "(IF)V", false, false, false );
            _cmj_fun154 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateFloat", "(Ljava/lang/String;F)V", false, false, false );
            _cmj_fun155 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateInt", "(II)V", false, false, false );
            _cmj_fun156 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateInt", "(Ljava/lang/String;I)V", false, false, false );
            _cmj_fun157 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateLong", "(IJ)V", false, false, false );
            _cmj_fun158 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateLong", "(Ljava/lang/String;J)V", false, false, false );
            _cmj_fun159 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNCharacterStream", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun160 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun161 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNCharacterStream", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun162 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNCharacterStream", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun163 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNClob", "(ILjava/io/Reader;)V", false, false, false );
            _cmj_fun164 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNClob", "(ILjava/sql/NClob;)V", false, false, false );
            _cmj_fun165 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;)V", false, false, false );
            _cmj_fun166 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNClob", "(Ljava/lang/String;Ljava/sql/NClob;)V", false, false, false );
            _cmj_fun167 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNClob", "(ILjava/io/Reader;J)V", false, false, false );
            _cmj_fun168 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNClob", "(Ljava/lang/String;Ljava/io/Reader;J)V", false, false, false );
            _cmj_fun169 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNString", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun170 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNString", "(Ljava/lang/String;Ljava/lang/String;)V", false, false, false );
            _cmj_fun171 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNull", "(I)V", false, false, false );
            _cmj_fun172 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateNull", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun173 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateObject", "(ILjava/lang/Object;)V", false, false, false );
            _cmj_fun174 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateObject", "(Ljava/lang/String;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun175 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateObject", "(ILjava/lang/Object;I)V", false, false, false );
            _cmj_fun176 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateObject", "(Ljava/lang/String;Ljava/lang/Object;I)V", false, false, false );
            _cmj_fun177 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateRef", "(ILjava/sql/Ref;)V", false, false, false );
            _cmj_fun178 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateRef", "(Ljava/lang/String;Ljava/sql/Ref;)V", false, false, false );
            _cmj_fun179 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateRow", "()V", false, false, false );
            _cmj_fun180 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateRowId", "(ILjava/sql/RowId;)V", false, false, false );
            _cmj_fun181 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateRowId", "(Ljava/lang/String;Ljava/sql/RowId;)V", false, false, false );
            _cmj_fun182 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateShort", "(IS)V", false, false, false );
            _cmj_fun183 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateShort", "(Ljava/lang/String;S)V", false, false, false );
            _cmj_fun184 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateSQLXML", "(ILjava/sql/SQLXML;)V", false, false, false );
            _cmj_fun185 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateSQLXML", "(Ljava/lang/String;Ljava/sql/SQLXML;)V", false, false, false );
            _cmj_fun186 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateString", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun187 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateString", "(Ljava/lang/String;Ljava/lang/String;)V", false, false, false );
            _cmj_fun188 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateTime", "(ILjava/sql/Time;)V", false, false, false );
            _cmj_fun189 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateTime", "(Ljava/lang/String;Ljava/sql/Time;)V", false, false, false );
            _cmj_fun190 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateTimestamp", "(ILjava/sql/Timestamp;)V", false, false, false );
            _cmj_fun191 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "updateTimestamp", "(Ljava/lang/String;Ljava/sql/Timestamp;)V", false, false, false );
            _cmj_fun192 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "wasNull", "()Z", false, false, false );
        }
    
        public const int        CLOSE_CURSORS_AT_COMMIT = 2;
        public const int        CONCUR_READ_ONLY = 1007;
        public const int        CONCUR_UPDATABLE = 1008;
        public const int        FETCH_FORWARD = 1000;
        public const int        FETCH_REVERSE = 1001;
        public const int        FETCH_UNKNOWN = 1002;
        public const int        HOLD_CURSORS_OVER_COMMIT = 1;
        public const int        TYPE_FORWARD_ONLY = 1003;
        public const int        TYPE_SCROLL_INSENSITIVE = 1004;
        public const int        TYPE_SCROLL_SENSITIVE = 1005;
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ResultSetImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ResultSetImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.ResultSet</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.ResultSetImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.ResultSetImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static void UpdateObject(int arg0, object arg1, global::Java.Sql.SQLType arg2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2) )
            {
                _cmj_fun0.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void UpdateObject(string arg0, object arg1, global::Java.Sql.SQLType arg2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2) )
            {
                _cmj_fun1.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void UpdateObject(int arg0, object arg1, global::Java.Sql.SQLType arg2, int arg3)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2).Add(arg3) )
            {
                _cmj_fun2.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void UpdateObject(string arg0, object arg1, global::Java.Sql.SQLType arg2, int arg3)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2).Add(arg3) )
            {
                _cmj_fun3.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public bool Absolute(int row)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(row) )
            {
                return _cmj_fun4.CallBool( this, cmj_jmargs );
            }
        }        
        
        public void AfterLast()
        {
            _cmj_fun5.CallVoid( this );
        }        
        
        public void BeforeFirst()
        {
            _cmj_fun6.CallVoid( this );
        }        
        
        public void CancelRowUpdates()
        {
            _cmj_fun7.CallVoid( this );
        }        
        
        public void ClearWarnings()
        {
            _cmj_fun8.CallVoid( this );
        }        
        
        public void Close()
        {
            _cmj_fun9.CallVoid( this );
        }        
        
        public void DeleteRow()
        {
            _cmj_fun10.CallVoid( this );
        }        
        
        public int FindColumn(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun11.CallInt( this, cmj_jmargs );
            }
        }        
        
        public bool First()
        {
            return _cmj_fun12.CallBool( this );
        }        
        
        public global::Java.Sql.Array GetArray(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun13.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun13.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ArrayImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Array)_cmj_fun13.CallObject( this, typeof(global::Java.Sql.Array), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Array GetArray(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun14.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun14.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ArrayImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Array)_cmj_fun14.CallObject( this, typeof(global::Java.Sql.Array), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.InputStream GetAsciiStream(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun15.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun15.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.InputStream)_cmj_fun15.CallObject( this, typeof(global::Java.Io.InputStream), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.InputStream GetAsciiStream(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun16.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun16.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.InputStream)_cmj_fun16.CallObject( this, typeof(global::Java.Io.InputStream), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Math.BigDecimal GetBigDecimal(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun17.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun17.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun17.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Math.BigDecimal GetBigDecimal(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun18.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun18.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun18.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Math.BigDecimal GetBigDecimal(int columnIndex, int scale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(scale) )
            {
                if(_cmj_fun19.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun19.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun19.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Math.BigDecimal GetBigDecimal(string columnLabel, int scale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(scale) )
            {
                if(_cmj_fun20.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun20.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun20.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.InputStream GetBinaryStream(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun21.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun21.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.InputStream)_cmj_fun21.CallObject( this, typeof(global::Java.Io.InputStream), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.InputStream GetBinaryStream(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun22.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun22.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.InputStream)_cmj_fun22.CallObject( this, typeof(global::Java.Io.InputStream), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Blob GetBlob(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun23.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun23.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.BlobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Blob)_cmj_fun23.CallObject( this, typeof(global::Java.Sql.Blob), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Blob GetBlob(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun24.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun24.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.BlobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Blob)_cmj_fun24.CallObject( this, typeof(global::Java.Sql.Blob), false, cmj_jmargs );
        
            }
        }        
        
        public bool GetBoolean(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun25.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool GetBoolean(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun26.CallBool( this, cmj_jmargs );
            }
        }        
        
        public byte GetByte(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun27.CallByte( this, cmj_jmargs );
            }
        }        
        
        public byte GetByte(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun28.CallByte( this, cmj_jmargs );
            }
        }        
        
        public global::Codemesh.JuggerNET.byteArray GetBytes(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun29.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun29.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Codemesh.JuggerNET.byteArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Codemesh.JuggerNET.byteArray)_cmj_fun29.CallObject( this, typeof(global::Codemesh.JuggerNET.byteArray), false, cmj_jmargs );
        
            }
        }        
        
        public global::Codemesh.JuggerNET.byteArray GetBytes(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun30.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun30.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Codemesh.JuggerNET.byteArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Codemesh.JuggerNET.byteArray)_cmj_fun30.CallObject( this, typeof(global::Codemesh.JuggerNET.byteArray), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.Reader GetCharacterStream(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun31.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun31.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Reader)_cmj_fun31.CallObject( this, typeof(global::Java.Io.Reader), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.Reader GetCharacterStream(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun32.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun32.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Reader)_cmj_fun32.CallObject( this, typeof(global::Java.Io.Reader), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Clob GetClob(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun33.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun33.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Clob)_cmj_fun33.CallObject( this, typeof(global::Java.Sql.Clob), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Clob GetClob(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun34.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun34.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Clob)_cmj_fun34.CallObject( this, typeof(global::Java.Sql.Clob), false, cmj_jmargs );
        
            }
        }        
        
        public int GetConcurrency()
        {
            return _cmj_fun35.CallInt( this );
        }        
        
        public string GetCursorName()
        {
            return _cmj_fun36.CallString( this );
        }        
        
        public global::Java.Sql.Date GetDate(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun37.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun37.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Date)_cmj_fun37.CallObject( this, typeof(global::Java.Sql.Date), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Date GetDate(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun38.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun38.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Date)_cmj_fun38.CallObject( this, typeof(global::Java.Sql.Date), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Date GetDate(int columnIndex, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(cal) )
            {
                if(_cmj_fun39.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun39.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Date)_cmj_fun39.CallObject( this, typeof(global::Java.Sql.Date), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Date GetDate(string columnLabel, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(cal) )
            {
                if(_cmj_fun40.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun40.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Date)_cmj_fun40.CallObject( this, typeof(global::Java.Sql.Date), false, cmj_jmargs );
        
            }
        }        
        
        public double GetDouble(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun41.CallDouble( this, cmj_jmargs );
            }
        }        
        
        public double GetDouble(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun42.CallDouble( this, cmj_jmargs );
            }
        }        
        
        public int GetFetchDirection()
        {
            return _cmj_fun43.CallInt( this );
        }        
        
        public int GetFetchSize()
        {
            return _cmj_fun44.CallInt( this );
        }        
        
        public float GetFloat(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun45.CallFloat( this, cmj_jmargs );
            }
        }        
        
        public float GetFloat(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun46.CallFloat( this, cmj_jmargs );
            }
        }        
        
        public int GetHoldability()
        {
            return _cmj_fun47.CallInt( this );
        }        
        
        public int GetInt(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun48.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int GetInt(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun49.CallInt( this, cmj_jmargs );
            }
        }        
        
        public long GetLong(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun50.CallLong( this, cmj_jmargs );
            }
        }        
        
        public long GetLong(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun51.CallLong( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.ResultSetMetaData GetMetaData()
        {
            if(_cmj_fun52.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun52.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetMetaDataImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSetMetaData)_cmj_fun52.CallObject( this, typeof(global::Java.Sql.ResultSetMetaData), false );
        
        }        
        
        public global::Java.Io.Reader GetNCharacterStream(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun53.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun53.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Reader)_cmj_fun53.CallObject( this, typeof(global::Java.Io.Reader), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.Reader GetNCharacterStream(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun54.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun54.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Reader)_cmj_fun54.CallObject( this, typeof(global::Java.Io.Reader), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.NClob GetNClob(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun55.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun55.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.NClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.NClob)_cmj_fun55.CallObject( this, typeof(global::Java.Sql.NClob), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.NClob GetNClob(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun56.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun56.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.NClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.NClob)_cmj_fun56.CallObject( this, typeof(global::Java.Sql.NClob), false, cmj_jmargs );
        
            }
        }        
        
        public string GetNString(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun57.CallString( this, cmj_jmargs );
            }
        }        
        
        public string GetNString(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun58.CallString( this, cmj_jmargs );
            }
        }        
        
        public object GetObject(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun59.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun60.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(int columnIndex, global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(map) )
            {
                return _cmj_fun61.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(int columnIndex, global::Java.Lang.Class type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(type) )
            {
                return _cmj_fun62.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(string columnLabel, global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(map) )
            {
                return _cmj_fun63.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetObject(string columnLabel, global::Java.Lang.Class type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(type) )
            {
                return _cmj_fun64.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.Ref GetRef(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun65.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun65.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.RefImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Ref)_cmj_fun65.CallObject( this, typeof(global::Java.Sql.Ref), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Ref GetRef(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun66.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun66.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.RefImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Ref)_cmj_fun66.CallObject( this, typeof(global::Java.Sql.Ref), false, cmj_jmargs );
        
            }
        }        
        
        public int GetRow()
        {
            return _cmj_fun67.CallInt( this );
        }        
        
        public global::Java.Sql.RowId GetRowId(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun68.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun68.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.RowIdImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.RowId)_cmj_fun68.CallObject( this, typeof(global::Java.Sql.RowId), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.RowId GetRowId(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun69.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun69.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.RowIdImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.RowId)_cmj_fun69.CallObject( this, typeof(global::Java.Sql.RowId), false, cmj_jmargs );
        
            }
        }        
        
        public short GetShort(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun70.CallShort( this, cmj_jmargs );
            }
        }        
        
        public short GetShort(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun71.CallShort( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.SQLXML GetSQLXML(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun72.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun72.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.SQLXMLImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.SQLXML)_cmj_fun72.CallObject( this, typeof(global::Java.Sql.SQLXML), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.SQLXML GetSQLXML(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun73.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun73.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.SQLXMLImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.SQLXML)_cmj_fun73.CallObject( this, typeof(global::Java.Sql.SQLXML), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Statement GetStatement()
        {
            if(_cmj_fun74.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun74.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.StatementImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Statement)_cmj_fun74.CallObject( this, typeof(global::Java.Sql.Statement), false );
        
        }        
        
        public string GetString(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                return _cmj_fun75.CallString( this, cmj_jmargs );
            }
        }        
        
        public string GetString(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                return _cmj_fun76.CallString( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.Time GetTime(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun77.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun77.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Time( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Time)_cmj_fun77.CallObject( this, typeof(global::Java.Sql.Time), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Time GetTime(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun78.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun78.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Time( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Time)_cmj_fun78.CallObject( this, typeof(global::Java.Sql.Time), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Time GetTime(int columnIndex, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(cal) )
            {
                if(_cmj_fun79.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun79.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Time( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Time)_cmj_fun79.CallObject( this, typeof(global::Java.Sql.Time), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Time GetTime(string columnLabel, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(cal) )
            {
                if(_cmj_fun80.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun80.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Time( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Time)_cmj_fun80.CallObject( this, typeof(global::Java.Sql.Time), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Timestamp GetTimestamp(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun81.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun81.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun81.CallObject( this, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Timestamp GetTimestamp(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun82.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun82.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun82.CallObject( this, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Timestamp GetTimestamp(int columnIndex, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(cal) )
            {
                if(_cmj_fun83.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun83.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun83.CallObject( this, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.Timestamp GetTimestamp(string columnLabel, global::Java.Util.Calendar cal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(cal) )
            {
                if(_cmj_fun84.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun84.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun84.CallObject( this, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }        
        
        public int GetType_Java()
        {
            return _cmj_fun85.CallInt( this );
        }        
        
        public global::Java.Io.InputStream GetUnicodeStream(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                if(_cmj_fun86.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun86.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.InputStream)_cmj_fun86.CallObject( this, typeof(global::Java.Io.InputStream), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.InputStream GetUnicodeStream(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                if(_cmj_fun87.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun87.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.InputStream)_cmj_fun87.CallObject( this, typeof(global::Java.Io.InputStream), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Net.URL GetURL(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                long    jnet_ref = (long)_cmj_fun88.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Net.URL( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }        
        
        public global::Java.Net.URL GetURL(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                long    jnet_ref = (long)_cmj_fun89.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Net.URL( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }        
        
        public global::Java.Sql.SQLWarning GetWarnings()
        {
            if(_cmj_fun90.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun90.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.SQLWarning( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.SQLWarning)_cmj_fun90.CallObject( this, typeof(global::Java.Sql.SQLWarning), false );
        
        }        
        
        public void InsertRow()
        {
            _cmj_fun91.CallVoid( this );
        }        
        
        public bool IsAfterLast()
        {
            return _cmj_fun92.CallBool( this );
        }        
        
        public bool IsBeforeFirst()
        {
            return _cmj_fun93.CallBool( this );
        }        
        
        public bool IsClosed()
        {
            return _cmj_fun94.CallBool( this );
        }        
        
        public bool IsFirst()
        {
            return _cmj_fun95.CallBool( this );
        }        
        
        public bool IsLast()
        {
            return _cmj_fun96.CallBool( this );
        }        
        
        public bool Last()
        {
            return _cmj_fun97.CallBool( this );
        }        
        
        public void MoveToCurrentRow()
        {
            _cmj_fun98.CallVoid( this );
        }        
        
        public void MoveToInsertRow()
        {
            _cmj_fun99.CallVoid( this );
        }        
        
        public bool Next()
        {
            return _cmj_fun100.CallBool( this );
        }        
        
        public bool Previous()
        {
            return _cmj_fun101.CallBool( this );
        }        
        
        public void RefreshRow()
        {
            _cmj_fun102.CallVoid( this );
        }        
        
        public bool Relative(int rows)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(rows) )
            {
                return _cmj_fun103.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool RowDeleted()
        {
            return _cmj_fun104.CallBool( this );
        }        
        
        public bool RowInserted()
        {
            return _cmj_fun105.CallBool( this );
        }        
        
        public bool RowUpdated()
        {
            return _cmj_fun106.CallBool( this );
        }        
        
        public void SetFetchDirection(int direction)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(direction) )
            {
                _cmj_fun107.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetFetchSize(int rows)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(rows) )
            {
                _cmj_fun108.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateArray(int columnIndex, global::Java.Sql.Array x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun109.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateArray(string columnLabel, global::Java.Sql.Array x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun110.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateAsciiStream(int columnIndex, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun111.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateAsciiStream(string columnLabel, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun112.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateAsciiStream(int columnIndex, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x).Add(length) )
            {
                _cmj_fun113.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateAsciiStream(int columnIndex, global::Java.Io.InputStream x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x).Add(length) )
            {
                _cmj_fun114.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateAsciiStream(string columnLabel, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x).Add(length) )
            {
                _cmj_fun115.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateAsciiStream(string columnLabel, global::Java.Io.InputStream x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x).Add(length) )
            {
                _cmj_fun116.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBigDecimal(int columnIndex, global::Java.Math.BigDecimal x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun117.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBigDecimal(string columnLabel, global::Java.Math.BigDecimal x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun118.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBinaryStream(int columnIndex, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun119.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBinaryStream(string columnLabel, global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun120.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBinaryStream(int columnIndex, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x).Add(length) )
            {
                _cmj_fun121.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBinaryStream(int columnIndex, global::Java.Io.InputStream x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x).Add(length) )
            {
                _cmj_fun122.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBinaryStream(string columnLabel, global::Java.Io.InputStream x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x).Add(length) )
            {
                _cmj_fun123.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBinaryStream(string columnLabel, global::Java.Io.InputStream x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x).Add(length) )
            {
                _cmj_fun124.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBlob(int columnIndex, global::Java.Io.InputStream inputStream)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(inputStream) )
            {
                _cmj_fun125.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBlob(int columnIndex, global::Java.Sql.Blob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun126.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBlob(string columnLabel, global::Java.Io.InputStream inputStream)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(inputStream) )
            {
                _cmj_fun127.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBlob(string columnLabel, global::Java.Sql.Blob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun128.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBlob(int columnIndex, global::Java.Io.InputStream inputStream, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(inputStream).Add(length) )
            {
                _cmj_fun129.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBlob(string columnLabel, global::Java.Io.InputStream inputStream, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(inputStream).Add(length) )
            {
                _cmj_fun130.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBoolean(int columnIndex, bool x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun131.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBoolean(string columnLabel, bool x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun132.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateByte(int columnIndex, byte x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun133.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateByte(string columnLabel, byte x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun134.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBytes(int columnIndex, global::Codemesh.JuggerNET.byteArray x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun135.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateBytes(string columnLabel, global::Codemesh.JuggerNET.byteArray x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun136.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateCharacterStream(int columnIndex, global::Java.Io.Reader x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun137.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateCharacterStream(string columnLabel, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(reader) )
            {
                _cmj_fun138.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateCharacterStream(int columnIndex, global::Java.Io.Reader x, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x).Add(length) )
            {
                _cmj_fun139.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateCharacterStream(int columnIndex, global::Java.Io.Reader x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x).Add(length) )
            {
                _cmj_fun140.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateCharacterStream(string columnLabel, global::Java.Io.Reader reader, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(reader).Add(length) )
            {
                _cmj_fun141.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateCharacterStream(string columnLabel, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(reader).Add(length) )
            {
                _cmj_fun142.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateClob(int columnIndex, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(reader) )
            {
                _cmj_fun143.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateClob(int columnIndex, global::Java.Sql.Clob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun144.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateClob(string columnLabel, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(reader) )
            {
                _cmj_fun145.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateClob(string columnLabel, global::Java.Sql.Clob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun146.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateClob(int columnIndex, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(reader).Add(length) )
            {
                _cmj_fun147.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateClob(string columnLabel, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(reader).Add(length) )
            {
                _cmj_fun148.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateDate(int columnIndex, global::Java.Sql.Date x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun149.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateDate(string columnLabel, global::Java.Sql.Date x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun150.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateDouble(int columnIndex, double x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun151.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateDouble(string columnLabel, double x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun152.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateFloat(int columnIndex, float x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun153.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateFloat(string columnLabel, float x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun154.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateInt(int columnIndex, int x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun155.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateInt(string columnLabel, int x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun156.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateLong(int columnIndex, long x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun157.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateLong(string columnLabel, long x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun158.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNCharacterStream(int columnIndex, global::Java.Io.Reader x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun159.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNCharacterStream(string columnLabel, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(reader) )
            {
                _cmj_fun160.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNCharacterStream(int columnIndex, global::Java.Io.Reader x, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x).Add(length) )
            {
                _cmj_fun161.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNCharacterStream(string columnLabel, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(reader).Add(length) )
            {
                _cmj_fun162.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNClob(int columnIndex, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(reader) )
            {
                _cmj_fun163.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNClob(int columnIndex, global::Java.Sql.NClob nClob)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(nClob) )
            {
                _cmj_fun164.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNClob(string columnLabel, global::Java.Io.Reader reader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(reader) )
            {
                _cmj_fun165.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNClob(string columnLabel, global::Java.Sql.NClob nClob)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(nClob) )
            {
                _cmj_fun166.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNClob(int columnIndex, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(reader).Add(length) )
            {
                _cmj_fun167.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNClob(string columnLabel, global::Java.Io.Reader reader, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(reader).Add(length) )
            {
                _cmj_fun168.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNString(int columnIndex, string nString)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(nString) )
            {
                _cmj_fun169.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNString(string columnLabel, string nString)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(nString) )
            {
                _cmj_fun170.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNull(int columnIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex) )
            {
                _cmj_fun171.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateNull(string columnLabel)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel) )
            {
                _cmj_fun172.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateObject(int columnIndex, object x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun173.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateObject(string columnLabel, object x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun174.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateObject(int columnIndex, object x, int scaleOrLength)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x).Add(scaleOrLength) )
            {
                _cmj_fun175.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateObject(string columnLabel, object x, int scaleOrLength)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x).Add(scaleOrLength) )
            {
                _cmj_fun176.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateRef(int columnIndex, global::Java.Sql.Ref x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun177.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateRef(string columnLabel, global::Java.Sql.Ref x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun178.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateRow()
        {
            _cmj_fun179.CallVoid( this );
        }        
        
        public void UpdateRowId(int columnIndex, global::Java.Sql.RowId x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun180.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateRowId(string columnLabel, global::Java.Sql.RowId x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun181.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateShort(int columnIndex, short x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun182.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateShort(string columnLabel, short x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun183.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateSQLXML(int columnIndex, global::Java.Sql.SQLXML xmlObject)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(xmlObject) )
            {
                _cmj_fun184.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateSQLXML(string columnLabel, global::Java.Sql.SQLXML xmlObject)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(xmlObject) )
            {
                _cmj_fun185.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateString(int columnIndex, string x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun186.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateString(string columnLabel, string x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun187.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateTime(int columnIndex, global::Java.Sql.Time x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun188.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateTime(string columnLabel, global::Java.Sql.Time x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun189.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateTimestamp(int columnIndex, global::Java.Sql.Timestamp x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(x) )
            {
                _cmj_fun190.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void UpdateTimestamp(string columnLabel, global::Java.Sql.Timestamp x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnLabel).Add(x) )
            {
                _cmj_fun191.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public bool WasNull()
        {
            return _cmj_fun192.CallBool( this );
        }        
    }    
    

}
