/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.io.Writer
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:14 EDT 2018
 */


namespace Java.Io
{
    [global::System.Runtime.InteropServices.GuidAttribute("F3F0598F-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.io.Writer")]
    public abstract class Writer :
        global::Java.Lang.AutoCloseableImpl
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
    
        static Writer()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.io.Writer", typeof(global::Java.Io.Writer), typeof(global::Java.Io.Writer.WriterImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Writer), "append", "(C)Ljava/io/Writer;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Writer), "append", "(Ljava/lang/CharSequence;)Ljava/io/Writer;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Writer), "append", "(Ljava/lang/CharSequence;II)Ljava/io/Writer;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "flush", "()V", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "write", "(I)V", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "write", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "write", "([C)V", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "write", "(Ljava/lang/String;II)V", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "write", "([CII)V", false, false, false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Writer( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type Writer if the given proxy instance
        /// represents a Java object that is type-compatible with java.io.Writer</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Io.Writer From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Io.Writer.WriterImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public global::Java.Io.Writer Append(char c)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(c) )
            {
                if(_cmj_fun0.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun0.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Writer.WriterImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Writer)_cmj_fun0.CallObject( this, typeof(global::Java.Io.Writer), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Io.Writer Append(global::Java.Lang.CharSequence csq)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(csq) )
            {
                if(_cmj_fun1.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun1.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Writer.WriterImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Writer)_cmj_fun1.CallObject( this, typeof(global::Java.Io.Writer), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Io.Writer Append(global::Java.Lang.CharSequence csq, int start, int end)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(csq).Add(start).Add(end) )
            {
                if(_cmj_fun2.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun2.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.Writer.WriterImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.Writer)_cmj_fun2.CallObject( this, typeof(global::Java.Io.Writer), false, cmj_jmargs );
        
            }
        }    
    
        public void Flush()
        {
            _cmj_fun3.CallVoid( this );
        }    
    
        public void Write(int c)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(c) )
            {
                _cmj_fun4.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Write(string str)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(str) )
            {
                _cmj_fun5.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Write(global::Codemesh.JuggerNET.charArray cbuf)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(cbuf) )
            {
                _cmj_fun6.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Write(string str, int off, int len)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(str).Add(off).Add(len) )
            {
                _cmj_fun7.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Write(global::Codemesh.JuggerNET.charArray cbuf, int off, int len)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(cbuf).Add(off).Add(len) )
            {
                _cmj_fun8.CallVoid( this, cmj_jmargs );
            }
        }    
        
        
        
        [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.io.Writer")]
        public class WriterImpl :
            global::Java.Io.Writer
        {
        
        
        
            /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
            /// <para>You should never have to use this constructor explicitly. It is a
            /// constructor that is required by the JuggerNET framework.</para></summary>
            /// <param name="jobj"> The JNI object handle.</param>
            public WriterImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
        
        
            /// <summary>Returns an instance of type WriterImpl if the given proxy instance
            /// represents a Java object that is type-compatible with java.io.Writer</summary>
            /// <param name="proxy">A proxy object of any type.</param>
            public static new global::Java.Io.Writer.WriterImpl From( object proxy )
            {
                global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
                if (_cmj_theClass.IsTypeOf(jp))
                    return new global::Java.Io.Writer.WriterImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
                else
                    return null;
            }
        }    
    
    }

}
