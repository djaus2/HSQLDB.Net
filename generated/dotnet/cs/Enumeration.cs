/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.Enumeration
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util
{
    [global::System.Runtime.InteropServices.GuidAttribute("2F287C87-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.Enumeration")]
    public interface Enumeration 
    { 
        bool HasMoreElements();
    
    
        object NextElement();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.Enumeration")]
    public class EnumerationImpl :
        global::Java.Lang.Object,
        global::Java.Util.Enumeration
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
    
        static EnumerationImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.Enumeration", typeof(global::Java.Util.Enumeration), typeof(global::Java.Util.EnumerationImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "hasMoreElements", "()Z", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "nextElement", "()Ljava/lang/Object;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public EnumerationImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type EnumerationImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.Enumeration</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.EnumerationImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.EnumerationImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public bool HasMoreElements()
        {
            return _cmj_fun0.CallBool( this );
        }        
        
        public object NextElement()
        {
            return _cmj_fun1.CallObject( this, typeof(object), false );
        }        
    }    
    

}
