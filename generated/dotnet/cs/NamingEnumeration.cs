/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.naming.NamingEnumeration
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Naming
{
    [global::System.Runtime.InteropServices.GuidAttribute("65823D31-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.naming.NamingEnumeration")]
    public interface NamingEnumeration :
        global::Java.Util.Enumeration
    { 
        void Close();
    
    
        bool HasMore();
    
    
        object Next();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.naming.NamingEnumeration")]
    public class NamingEnumerationImpl :
        global::Java.Util.EnumerationImpl,
        global::Javax.Naming.NamingEnumeration
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
    
        static NamingEnumerationImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.naming.NamingEnumeration", typeof(global::Javax.Naming.NamingEnumeration), typeof(global::Javax.Naming.NamingEnumerationImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "close", "()V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "hasMore", "()Z", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "next", "()Ljava/lang/Object;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public NamingEnumerationImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type NamingEnumerationImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.naming.NamingEnumeration</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Naming.NamingEnumerationImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Naming.NamingEnumerationImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void Close()
        {
            _cmj_fun0.CallVoid( this );
        }        
        
        public bool HasMore()
        {
            return _cmj_fun1.CallBool( this );
        }        
        
        public object Next()
        {
            return _cmj_fun2.CallObject( this, typeof(object), false );
        }        
    }    
    

}
