/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.SQLOutput
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("9F93E163-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.SQLOutput")]
    public interface SQLOutput 
    { 
        void WriteArray(global::Java.Sql.Array x);
    
    
        void WriteAsciiStream(global::Java.Io.InputStream x);
    
    
        void WriteBigDecimal(global::Java.Math.BigDecimal x);
    
    
        void WriteBinaryStream(global::Java.Io.InputStream x);
    
    
        void WriteBlob(global::Java.Sql.Blob x);
    
    
        void WriteBoolean(bool x);
    
    
        void WriteByte(byte x);
    
    
        void WriteBytes(global::Codemesh.JuggerNET.byteArray x);
    
    
        void WriteCharacterStream(global::Java.Io.Reader x);
    
    
        void WriteClob(global::Java.Sql.Clob x);
    
    
        void WriteDate(global::Java.Sql.Date x);
    
    
        void WriteDouble(double x);
    
    
        void WriteFloat(float x);
    
    
        void WriteInt(int x);
    
    
        void WriteLong(long x);
    
    
        void WriteNClob(global::Java.Sql.NClob x);
    
    
        void WriteNString(string x);
    
    
        void WriteObject(global::Java.Sql.SQLData x);
    
    
        void WriteRef(global::Java.Sql.Ref x);
    
    
        void WriteRowId(global::Java.Sql.RowId x);
    
    
        void WriteSQLXML(global::Java.Sql.SQLXML x);
    
    
        void WriteShort(short x);
    
    
        void WriteString(string x);
    
    
        void WriteStruct(global::Java.Sql.Struct x);
    
    
        void WriteTime(global::Java.Sql.Time x);
    
    
        void WriteTimestamp(global::Java.Sql.Timestamp x);
    
    
        void WriteURL(global::Java.Net.URL x);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.SQLOutput")]
    public class SQLOutputImpl :
        global::Java.Lang.Object,
        global::Java.Sql.SQLOutput
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
    
        static SQLOutputImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.SQLOutput", typeof(global::Java.Sql.SQLOutput), typeof(global::Java.Sql.SQLOutputImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeObject", "(Ljava/lang/Object;Ljava/sql/SQLType;)V", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeArray", "(Ljava/sql/Array;)V", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeAsciiStream", "(Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeBigDecimal", "(Ljava/math/BigDecimal;)V", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeBinaryStream", "(Ljava/io/InputStream;)V", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeBlob", "(Ljava/sql/Blob;)V", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeBoolean", "(Z)V", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeByte", "(B)V", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeBytes", "([B)V", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeCharacterStream", "(Ljava/io/Reader;)V", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeClob", "(Ljava/sql/Clob;)V", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeDate", "(Ljava/sql/Date;)V", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeDouble", "(D)V", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeFloat", "(F)V", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeInt", "(I)V", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeLong", "(J)V", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeNClob", "(Ljava/sql/NClob;)V", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeNString", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeObject", "(Ljava/sql/SQLData;)V", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeRef", "(Ljava/sql/Ref;)V", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeRowId", "(Ljava/sql/RowId;)V", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeShort", "(S)V", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeSQLXML", "(Ljava/sql/SQLXML;)V", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeString", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeStruct", "(Ljava/sql/Struct;)V", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeTime", "(Ljava/sql/Time;)V", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeTimestamp", "(Ljava/sql/Timestamp;)V", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "writeURL", "(Ljava/net/URL;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public SQLOutputImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type SQLOutputImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.SQLOutput</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.SQLOutputImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.SQLOutputImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static void WriteObject(object arg0, global::Java.Sql.SQLType arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                _cmj_fun0.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public void WriteArray(global::Java.Sql.Array x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun1.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteAsciiStream(global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun2.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteBigDecimal(global::Java.Math.BigDecimal x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun3.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteBinaryStream(global::Java.Io.InputStream x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun4.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteBlob(global::Java.Sql.Blob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun5.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteBoolean(bool x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun6.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteByte(byte x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun7.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteBytes(global::Codemesh.JuggerNET.byteArray x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun8.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteCharacterStream(global::Java.Io.Reader x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun9.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteClob(global::Java.Sql.Clob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun10.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteDate(global::Java.Sql.Date x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun11.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteDouble(double x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun12.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteFloat(float x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun13.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteInt(int x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun14.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteLong(long x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun15.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteNClob(global::Java.Sql.NClob x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun16.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteNString(string x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun17.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteObject(global::Java.Sql.SQLData x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun18.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteRef(global::Java.Sql.Ref x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun19.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteRowId(global::Java.Sql.RowId x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun20.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteShort(short x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun21.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteSQLXML(global::Java.Sql.SQLXML x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun22.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteString(string x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun23.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteStruct(global::Java.Sql.Struct x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun24.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteTime(global::Java.Sql.Time x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun25.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteTimestamp(global::Java.Sql.Timestamp x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun26.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void WriteURL(global::Java.Net.URL x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                _cmj_fun27.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
