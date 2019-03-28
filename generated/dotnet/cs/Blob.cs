/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.Blob
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("744EB229-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.Blob")]
    public interface Blob 
    { 
        void Free();
    
    
        global::Java.Io.InputStream GetBinaryStream();
    
    
        global::Java.Io.InputStream GetBinaryStream(long pos, long length);
    
    
        global::Codemesh.JuggerNET.byteArray GetBytes(long pos, int length);
    
    
        long Length();
    
    
        long Position(global::Java.Sql.Blob pattern, long start);
    
    
        long Position(global::Codemesh.JuggerNET.byteArray pattern, long start);
    
    
        global::Java.Io.OutputStream SetBinaryStream(long pos);
    
    
        int SetBytes(long pos, global::Codemesh.JuggerNET.byteArray bytes);
    
    
        int SetBytes(long pos, global::Codemesh.JuggerNET.byteArray bytes, int offset, int len);
    
    
        void Truncate(long len);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.Blob")]
    public class BlobImpl :
        global::Java.Lang.Object,
        global::Java.Sql.Blob
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
    
        static BlobImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.Blob", typeof(global::Java.Sql.Blob), typeof(global::Java.Sql.BlobImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "free", "()V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getBinaryStream", "()Ljava/io/InputStream;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getBinaryStream", "(JJ)Ljava/io/InputStream;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Codemesh.JuggerNET.byteArray), "getBytes", "(JI)[B", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "length", "()J", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "position", "([BJ)J", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "position", "(Ljava/sql/Blob;J)J", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.OutputStream), "setBinaryStream", "(J)Ljava/io/OutputStream;", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "setBytes", "(J[B)I", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "setBytes", "(J[BII)I", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "truncate", "(J)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public BlobImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type BlobImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.Blob</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.BlobImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.BlobImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void Free()
        {
            _cmj_fun0.CallVoid( this );
        }        
        
        public global::Java.Io.InputStream GetBinaryStream()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.InputStream)_cmj_fun1.CallObject( this, typeof(global::Java.Io.InputStream), false );
        
        }        
        
        public global::Java.Io.InputStream GetBinaryStream(long pos, long length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos).Add(length) )
            {
                if(_cmj_fun2.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun2.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.InputStream)_cmj_fun2.CallObject( this, typeof(global::Java.Io.InputStream), false, cmj_jmargs );
        
            }
        }        
        
        public global::Codemesh.JuggerNET.byteArray GetBytes(long pos, int length)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos).Add(length) )
            {
                if(_cmj_fun3.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun3.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Codemesh.JuggerNET.byteArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Codemesh.JuggerNET.byteArray)_cmj_fun3.CallObject( this, typeof(global::Codemesh.JuggerNET.byteArray), false, cmj_jmargs );
        
            }
        }        
        
        public long Length()
        {
            return _cmj_fun4.CallLong( this );
        }        
        
        public long Position(global::Codemesh.JuggerNET.byteArray pattern, long start)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pattern).Add(start) )
            {
                return _cmj_fun5.CallLong( this, cmj_jmargs );
            }
        }        
        
        public long Position(global::Java.Sql.Blob pattern, long start)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pattern).Add(start) )
            {
                return _cmj_fun6.CallLong( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Io.OutputStream SetBinaryStream(long pos)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos) )
            {
                if(_cmj_fun7.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun7.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.OutputStream.OutputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.OutputStream)_cmj_fun7.CallObject( this, typeof(global::Java.Io.OutputStream), false, cmj_jmargs );
        
            }
        }        
        
        public int SetBytes(long pos, global::Codemesh.JuggerNET.byteArray bytes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos).Add(bytes) )
            {
                return _cmj_fun8.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int SetBytes(long pos, global::Codemesh.JuggerNET.byteArray bytes, int offset, int len)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(pos).Add(bytes).Add(offset).Add(len) )
            {
                return _cmj_fun9.CallInt( this, cmj_jmargs );
            }
        }        
        
        public void Truncate(long len)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(len) )
            {
                _cmj_fun10.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
