/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.AbstractCollection
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util
{
    [global::System.Runtime.InteropServices.GuidAttribute("465EBE20-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.AbstractCollection")]
    public abstract class AbstractCollection :
        global::Java.Util.CollectionImpl
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
    
        static AbstractCollection()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.AbstractCollection", typeof(global::Java.Util.AbstractCollection), typeof(global::Java.Util.AbstractCollection.AbstractCollectionImpl), null);
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public AbstractCollection( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type AbstractCollection if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.AbstractCollection</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.AbstractCollection From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.AbstractCollection.AbstractCollectionImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        
        [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.AbstractCollection")]
        public class AbstractCollectionImpl :
            global::Java.Util.AbstractCollection
        {
        
        
        
            /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
            /// <para>You should never have to use this constructor explicitly. It is a
            /// constructor that is required by the JuggerNET framework.</para></summary>
            /// <param name="jobj"> The JNI object handle.</param>
            public AbstractCollectionImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
        
        
            /// <summary>Returns an instance of type AbstractCollectionImpl if the given proxy instance
            /// represents a Java object that is type-compatible with java.util.AbstractCollection</summary>
            /// <param name="proxy">A proxy object of any type.</param>
            public static new global::Java.Util.AbstractCollection.AbstractCollectionImpl From( object proxy )
            {
                global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
                if (_cmj_theClass.IsTypeOf(jp))
                    return new global::Java.Util.AbstractCollection.AbstractCollectionImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
                else
                    return null;
            }
        }    
    
    }

}
