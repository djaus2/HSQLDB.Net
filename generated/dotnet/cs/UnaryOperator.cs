/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.function.UnaryOperator
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util.Function
{
    [global::System.Runtime.InteropServices.GuidAttribute("B2F610FD-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.function.UnaryOperator")]
    public interface UnaryOperator 
    { 
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.function.UnaryOperator")]
    public class UnaryOperatorImpl :
        global::Java.Lang.Object,
        global::Java.Util.Function.UnaryOperator
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
    
        static UnaryOperatorImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.function.UnaryOperator", typeof(global::Java.Util.Function.UnaryOperator), typeof(global::Java.Util.Function.UnaryOperatorImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Function.UnaryOperator), "identity", "()Ljava/util/function/UnaryOperator;", true, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public UnaryOperatorImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type UnaryOperatorImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.function.UnaryOperator</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.Function.UnaryOperatorImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.Function.UnaryOperatorImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static global::Java.Util.Function.UnaryOperator Identity()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.Function.UnaryOperatorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Function.UnaryOperator)_cmj_fun0.CallObject( null, typeof(global::Java.Util.Function.UnaryOperator), false );
        
        }        
    }    
    

}
