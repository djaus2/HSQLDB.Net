/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.SQLInput
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("80ACFB28-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.SQLInput")]
    public interface SQLInput 
    { 
        global::Java.Sql.Array ReadArray();
    
    
        global::Java.Io.InputStream ReadAsciiStream();
    
    
        global::Java.Math.BigDecimal ReadBigDecimal();
    
    
        global::Java.Io.InputStream ReadBinaryStream();
    
    
        global::Java.Sql.Blob ReadBlob();
    
    
        bool ReadBoolean();
    
    
        byte ReadByte();
    
    
        global::Codemesh.JuggerNET.byteArray ReadBytes();
    
    
        global::Java.Io.Reader ReadCharacterStream();
    
    
        global::Java.Sql.Clob ReadClob();
    
    
        global::Java.Sql.Date ReadDate();
    
    
        double ReadDouble();
    
    
        float ReadFloat();
    
    
        int ReadInt();
    
    
        long ReadLong();
    
    
        global::Java.Sql.NClob ReadNClob();
    
    
        string ReadNString();
    
    
        object ReadObject();
    
    
        global::Java.Sql.Ref ReadRef();
    
    
        global::Java.Sql.RowId ReadRowId();
    
    
        global::Java.Sql.SQLXML ReadSQLXML();
    
    
        short ReadShort();
    
    
        string ReadString();
    
    
        global::Java.Sql.Time ReadTime();
    
    
        global::Java.Sql.Timestamp ReadTimestamp();
    
    
        global::Java.Net.URL ReadURL();
    
    
        bool WasNull();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.SQLInput")]
    public class SQLInputImpl :
        global::Java.Lang.Object,
        global::Java.Sql.SQLInput
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
    
        static SQLInputImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.SQLInput", typeof(global::Java.Sql.SQLInput), typeof(global::Java.Sql.SQLInputImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "readObject", "(Ljava/lang/Class;)Ljava/lang/Object;", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Array), "readArray", "()Ljava/sql/Array;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "readAsciiStream", "()Ljava/io/InputStream;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "readBigDecimal", "()Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "readBinaryStream", "()Ljava/io/InputStream;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Blob), "readBlob", "()Ljava/sql/Blob;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "readBoolean", "()Z", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(byte), "readByte", "()B", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Codemesh.JuggerNET.byteArray), "readBytes", "()[B", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "readCharacterStream", "()Ljava/io/Reader;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Clob), "readClob", "()Ljava/sql/Clob;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Date), "readDate", "()Ljava/sql/Date;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(double), "readDouble", "()D", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(float), "readFloat", "()F", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "readInt", "()I", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "readLong", "()J", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.NClob), "readNClob", "()Ljava/sql/NClob;", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "readNString", "()Ljava/lang/String;", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "readObject", "()Ljava/lang/Object;", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Ref), "readRef", "()Ljava/sql/Ref;", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.RowId), "readRowId", "()Ljava/sql/RowId;", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "readShort", "()S", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLXML), "readSQLXML", "()Ljava/sql/SQLXML;", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "readString", "()Ljava/lang/String;", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Time), "readTime", "()Ljava/sql/Time;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "readTimestamp", "()Ljava/sql/Timestamp;", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Net.URL), "readURL", "()Ljava/net/URL;", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "wasNull", "()Z", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public SQLInputImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type SQLInputImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.SQLInput</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.SQLInputImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.SQLInputImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static object ReadObject(global::Java.Lang.Class arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                return _cmj_fun0.CallObject( null, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.Array ReadArray()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ArrayImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Array)_cmj_fun1.CallObject( this, typeof(global::Java.Sql.Array), false );
        
        }        
        
        public global::Java.Io.InputStream ReadAsciiStream()
        {
            if(_cmj_fun2.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun2.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.InputStream)_cmj_fun2.CallObject( this, typeof(global::Java.Io.InputStream), false );
        
        }        
        
        public global::Java.Math.BigDecimal ReadBigDecimal()
        {
            if(_cmj_fun3.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun3.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Math.BigDecimal)_cmj_fun3.CallObject( this, typeof(global::Java.Math.BigDecimal), false );
        
        }        
        
        public global::Java.Io.InputStream ReadBinaryStream()
        {
            if(_cmj_fun4.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun4.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.InputStream)_cmj_fun4.CallObject( this, typeof(global::Java.Io.InputStream), false );
        
        }        
        
        public global::Java.Sql.Blob ReadBlob()
        {
            if(_cmj_fun5.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun5.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.BlobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Blob)_cmj_fun5.CallObject( this, typeof(global::Java.Sql.Blob), false );
        
        }        
        
        public bool ReadBoolean()
        {
            return _cmj_fun6.CallBool( this );
        }        
        
        public byte ReadByte()
        {
            return _cmj_fun7.CallByte( this );
        }        
        
        public global::Codemesh.JuggerNET.byteArray ReadBytes()
        {
            if(_cmj_fun8.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun8.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Codemesh.JuggerNET.byteArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Codemesh.JuggerNET.byteArray)_cmj_fun8.CallObject( this, typeof(global::Codemesh.JuggerNET.byteArray), false );
        
        }        
        
        public global::Java.Io.Reader ReadCharacterStream()
        {
            if(_cmj_fun9.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun9.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.Reader)_cmj_fun9.CallObject( this, typeof(global::Java.Io.Reader), false );
        
        }        
        
        public global::Java.Sql.Clob ReadClob()
        {
            if(_cmj_fun10.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun10.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Clob)_cmj_fun10.CallObject( this, typeof(global::Java.Sql.Clob), false );
        
        }        
        
        public global::Java.Sql.Date ReadDate()
        {
            if(_cmj_fun11.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun11.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Date)_cmj_fun11.CallObject( this, typeof(global::Java.Sql.Date), false );
        
        }        
        
        public double ReadDouble()
        {
            return _cmj_fun12.CallDouble( this );
        }        
        
        public float ReadFloat()
        {
            return _cmj_fun13.CallFloat( this );
        }        
        
        public int ReadInt()
        {
            return _cmj_fun14.CallInt( this );
        }        
        
        public long ReadLong()
        {
            return _cmj_fun15.CallLong( this );
        }        
        
        public global::Java.Sql.NClob ReadNClob()
        {
            if(_cmj_fun16.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun16.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.NClobImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.NClob)_cmj_fun16.CallObject( this, typeof(global::Java.Sql.NClob), false );
        
        }        
        
        public string ReadNString()
        {
            return _cmj_fun17.CallString( this );
        }        
        
        public object ReadObject()
        {
            return _cmj_fun18.CallObject( this, typeof(object), false );
        }        
        
        public global::Java.Sql.Ref ReadRef()
        {
            if(_cmj_fun19.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun19.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.RefImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Ref)_cmj_fun19.CallObject( this, typeof(global::Java.Sql.Ref), false );
        
        }        
        
        public global::Java.Sql.RowId ReadRowId()
        {
            if(_cmj_fun20.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun20.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.RowIdImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.RowId)_cmj_fun20.CallObject( this, typeof(global::Java.Sql.RowId), false );
        
        }        
        
        public short ReadShort()
        {
            return _cmj_fun21.CallShort( this );
        }        
        
        public global::Java.Sql.SQLXML ReadSQLXML()
        {
            if(_cmj_fun22.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun22.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.SQLXMLImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.SQLXML)_cmj_fun22.CallObject( this, typeof(global::Java.Sql.SQLXML), false );
        
        }        
        
        public string ReadString()
        {
            return _cmj_fun23.CallString( this );
        }        
        
        public global::Java.Sql.Time ReadTime()
        {
            if(_cmj_fun24.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun24.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.Time( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Time)_cmj_fun24.CallObject( this, typeof(global::Java.Sql.Time), false );
        
        }        
        
        public global::Java.Sql.Timestamp ReadTimestamp()
        {
            if(_cmj_fun25.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun25.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Timestamp)_cmj_fun25.CallObject( this, typeof(global::Java.Sql.Timestamp), false );
        
        }        
        
        public global::Java.Net.URL ReadURL()
        {
            long    jnet_ref = (long)_cmj_fun26.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Net.URL( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }        
        
        public bool WasNull()
        {
            return _cmj_fun27.CallBool( this );
        }        
    }    
    

}
