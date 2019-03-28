/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.concurrent.Executor
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util.Concurrent
{
    [global::System.Runtime.InteropServices.GuidAttribute("1D55198A-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.concurrent.Executor")]
    public interface Executor 
    { 
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.concurrent.Executor")]
    public class ExecutorImpl :
        global::Java.Lang.Object,
        global::Java.Util.Concurrent.Executor
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
    
        static ExecutorImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.concurrent.Executor", typeof(global::Java.Util.Concurrent.Executor), typeof(global::Java.Util.Concurrent.ExecutorImpl), null);
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ExecutorImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ExecutorImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.concurrent.Executor</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.Concurrent.ExecutorImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.Concurrent.ExecutorImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
    }    
    

}
