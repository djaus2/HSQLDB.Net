/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.Clob
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("744F2688-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.Clob")]
    public interface Clob 
    { 
        void Free();
    
    
        global::Java.Io.InputStream GetAsciiStream();
    
    
        global::Java.Io.Reader GetCharacterStream();
    
    
        global::Java.Io.Reader GetCharacterStream(long pos, long length);
    
    
        string GetSubString(long pos, int length);
    
    
        long Length();
    
    
        long Position(string searchstr, long start);
    
    
        long Position(global::Java.Sql.Clob searchstr, long start);
    
    
        global::Java.Io.OutputStream SetAsciiStream(long pos);
    
    
        global::Java.Io.Writer SetCharacterStream(long pos);
    
    
        int SetString(long pos, string str);
    
    
        int SetString(long pos, string str, int offset, int len);
    
    
        void Truncate(long len);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.Clob")]
    public class ClobImpl :
        global::Java.Lang.Object,
        global::Java.Sql.Clob
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
    
        static ClobImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.Clob", typeof(global::Java.Sql.Clob), typeof(global::Java.Sql.ClobImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "free", "()V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getAsciiStream", "()Ljava/io/InputStream;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getCharacterStream", "()Ljava/io/Reader;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getCharacterStream", "(JJ)Ljava/io/Reader;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getSubString", "(JI)Ljava/lang/String;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "length", "()J", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "position", "(Ljava/lang/String;J)J", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "position", "(Ljava/sql/Clob;J)J", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.OutputStream), "setAsciiStream", "(J)Ljava/io/OutputStream;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Writer), "setCharacterStream", "(J)Ljava/io/Writer;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "setString", "(JLjava/lang/String;)I", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "setString", "(JLjava/lang/String;II)I", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "truncate", "(J)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ClobImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ClobImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.Clob</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.ClobImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.ClobImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void Free()
        {
            _cmj_fun0.CallVoid( this );
        }        
        
        public global::Java.Io.InputStream GetAsciiStream()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.InputStream)_cmj_fun1.CallObject( this, typeof(global::Java.Io.InputStream), false );
        
        }        
        
        public global::Java.Io.Reader GetCharacterStream()
        {
            if(_cmj_fun2.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun2.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.Reader)_cmj_fun2.CallObject( this, typeof(global::Java.Io.Reader), false );
        
        }        
        
        public global::Java.Io.Reader GetCharacterStream(long pos, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos).Add(length) )
            {
                if(_cmj_fun3.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun3.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Reader)_cmj_fun3.CallObject( this, typeof(global::Java.Io.Reader), false, cmj_jmargs );
        
            }
        }        
        
        public string GetSubString(long pos, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos).Add(length) )
            {
                return _cmj_fun4.CallString( this, cmj_jmargs );
            }
        }        
        
        public long Length()
        {
            return _cmj_fun5.CallLong( this );
        }        
        
        public long Position(string searchstr, long start)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(searchstr).Add(start) )
            {
                return _cmj_fun6.CallLong( this, cmj_jmargs );
            }
        }        
        
        public long Position(global::Java.Sql.Clob searchstr, long start)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(searchstr).Add(start) )
            {
                return _cmj_fun7.CallLong( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Io.OutputStream SetAsciiStream(long pos)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos) )
            {
                if(_cmj_fun8.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun8.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.OutputStream.OutputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.OutputStream)_cmj_fun8.CallObject( this, typeof(global::Java.Io.OutputStream), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Io.Writer SetCharacterStream(long pos)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos) )
            {
                if(_cmj_fun9.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun9.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Writer.WriterImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Writer)_cmj_fun9.CallObject( this, typeof(global::Java.Io.Writer), false, cmj_jmargs );
        
            }
        }        
        
        public int SetString(long pos, string str)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos).Add(str) )
            {
                return _cmj_fun10.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int SetString(long pos, string str, int offset, int len)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos).Add(str).Add(offset).Add(len) )
            {
                return _cmj_fun11.CallInt( this, cmj_jmargs );
            }
        }        
        
        public void Truncate(long len)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(len) )
            {
                _cmj_fun12.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
