/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.io.Serializable
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:14 EDT 2018
 */


namespace Java.Io
{
    [global::System.Runtime.InteropServices.GuidAttribute("3D8CC91B-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.io.Serializable")]
    public interface Serializable 
    { 
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.io.Serializable")]
    public class SerializableImpl :
        global::Java.Lang.Object,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
    
        static SerializableImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.io.Serializable", typeof(global::Java.Io.Serializable), typeof(global::Java.Io.SerializableImpl), null);
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public SerializableImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        /// <summary>Creates a Serializable proxy from a .NET string instance.
        /// <para>You can use this constructor when you need to treat a .NET string
        /// as an instance of type Serializable.  This constructor wraps a
        /// corresponding Java string in a proxy object of type Serializable.</para></summary>
        /// <param name="str"> The .NET string for which we want a corresponding Java string.</param>
        public SerializableImpl( string str ) : base( new global::Codemesh.JuggerNET.JNIHandle( global::Codemesh.JuggerNET.JavaClass.FromTypedInstance(null, null, str))) { }
    
    
        /// <summary>Returns an instance of type SerializableImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.io.Serializable</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Io.SerializableImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Io.SerializableImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
    }    
    

}
