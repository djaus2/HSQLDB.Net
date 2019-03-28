/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.Comparable
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:14 EDT 2018
 */


namespace Java.Lang
{
    [global::System.Runtime.InteropServices.GuidAttribute("72AC812E-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.lang.Comparable")]
    public interface Comparable 
    { 
        int CompareTo(object o);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.Comparable")]
    public class ComparableImpl :
        global::Java.Lang.Object,
        global::Java.Lang.Comparable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
    
        static ComparableImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.Comparable", typeof(global::Java.Lang.Comparable), typeof(global::Java.Lang.ComparableImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compareTo", "(Ljava/lang/Object;)I", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ComparableImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        /// <summary>Creates a Comparable proxy from a .NET string instance.
        /// <para>You can use this constructor when you need to treat a .NET string
        /// as an instance of type Comparable.  This constructor wraps a
        /// corresponding Java string in a proxy object of type Comparable.</para></summary>
        /// <param name="str"> The .NET string for which we want a corresponding Java string.</param>
        public ComparableImpl( string str ) : base( new global::Codemesh.JuggerNET.JNIHandle( global::Codemesh.JuggerNET.JavaClass.FromTypedInstance(null, null, str))) { }
    
    
        /// <summary>Returns an instance of type ComparableImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.Comparable</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.ComparableImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.ComparableImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public int CompareTo(object o)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(o) )
            {
                return _cmj_fun0.CallInt( this, cmj_jmargs );
            }
        }        
    }    
    

}
