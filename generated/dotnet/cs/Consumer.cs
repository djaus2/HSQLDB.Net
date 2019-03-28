/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.function.Consumer
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util.Function
{
    [global::System.Runtime.InteropServices.GuidAttribute("DF26FBAC-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.function.Consumer")]
    public interface Consumer 
    { 
        void Accept(object t);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.function.Consumer")]
    public class ConsumerImpl :
        global::Java.Lang.Object,
        global::Java.Util.Function.Consumer
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
    
        static ConsumerImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.function.Consumer", typeof(global::Java.Util.Function.Consumer), typeof(global::Java.Util.Function.ConsumerImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Function.Consumer), "andThen", "(Ljava/util/function/Consumer;)Ljava/util/function/Consumer;", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "accept", "(Ljava/lang/Object;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ConsumerImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ConsumerImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.function.Consumer</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.Function.ConsumerImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.Function.ConsumerImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static global::Java.Util.Function.Consumer AndThen(global::Java.Util.Function.Consumer arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                if(_cmj_fun0.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun0.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.Function.ConsumerImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.Function.Consumer)_cmj_fun0.CallObject( null, typeof(global::Java.Util.Function.Consumer), false, cmj_jmargs );
        
            }
        }        
        
        public void Accept(object t)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(t) )
            {
                _cmj_fun1.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
