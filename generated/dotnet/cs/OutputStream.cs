/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.io.OutputStream
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:14 EDT 2018
 */


namespace Java.Io
{
    [global::System.Runtime.InteropServices.GuidAttribute("02753FFD-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.io.OutputStream")]
    public abstract class OutputStream :
        global::Java.Lang.AutoCloseableImpl
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
    
        static OutputStream()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.io.OutputStream", typeof(global::Java.Io.OutputStream), typeof(global::Java.Io.OutputStream.OutputStreamImpl), null);
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.OutputStream), "<init>", "()V", false );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "flush", "()V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "write", "(I)V", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "write", "([B)V", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "write", "([BII)V", false, false, false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public OutputStream( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        public OutputStream() : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            JObject = (long)_cmj_ctr0.CallObject( this );
        }
    
    
        /// <summary>Returns an instance of type OutputStream if the given proxy instance
        /// represents a Java object that is type-compatible with java.io.OutputStream</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Io.OutputStream From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Io.OutputStream.OutputStreamImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public void Flush()
        {
            _cmj_fun0.CallVoid( this );
        }    
    
        public void Write(int b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(b) )
            {
                _cmj_fun1.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Write(global::Codemesh.JuggerNET.byteArray b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(b) )
            {
                _cmj_fun2.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Write(global::Codemesh.JuggerNET.byteArray b, int off, int len)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(b).Add(off).Add(len) )
            {
                _cmj_fun3.CallVoid( this, cmj_jmargs );
            }
        }    
        
        
        
        [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.io.OutputStream")]
        public class OutputStreamImpl :
            global::Java.Io.OutputStream
        {
        
        
        
            /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
            /// <para>You should never have to use this constructor explicitly. It is a
            /// constructor that is required by the JuggerNET framework.</para></summary>
            /// <param name="jobj"> The JNI object handle.</param>
            public OutputStreamImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
        
        
            /// <summary>Returns an instance of type OutputStreamImpl if the given proxy instance
            /// represents a Java object that is type-compatible with java.io.OutputStream</summary>
            /// <param name="proxy">A proxy object of any type.</param>
            public static new global::Java.Io.OutputStream.OutputStreamImpl From( object proxy )
            {
                global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
                if (_cmj_theClass.IsTypeOf(jp))
                    return new global::Java.Io.OutputStream.OutputStreamImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
                else
                    return null;
            }
        }    
    
    }

}
