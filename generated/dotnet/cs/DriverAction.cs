/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.DriverAction
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("01C37B0A-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.DriverAction")]
    public interface DriverAction 
    { 
        void Deregister();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.DriverAction")]
    public class DriverActionImpl :
        global::Java.Lang.Object,
        global::Java.Sql.DriverAction
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
    
        static DriverActionImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.DriverAction", typeof(global::Java.Sql.DriverAction), typeof(global::Java.Sql.DriverActionImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "deregister", "()V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public DriverActionImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type DriverActionImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.DriverAction</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.DriverActionImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.DriverActionImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void Deregister()
        {
            _cmj_fun0.CallVoid( this );
        }        
    }    
    

}
