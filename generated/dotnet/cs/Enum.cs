/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.Enum
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang
{
    [global::System.Runtime.InteropServices.GuidAttribute("537ADC55-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.lang.Enum")]
    public abstract class Enum :
        global::Java.Lang.ComparableImpl,
        global::Java.Io.Serializable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
    
        static Enum()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.Enum", typeof(global::Java.Lang.Enum), typeof(global::Java.Lang.Enum.EnumImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "getDeclaringClass", "()Ljava/lang/Class;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "name", "()Ljava/lang/String;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "ordinal", "()I", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Enum), "valueOf", "(Ljava/lang/Class;Ljava/lang/String;)Ljava/lang/Enum;", true, false, false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Enum( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        protected Enum( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type Enum if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.Enum</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Enum From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Enum.EnumImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public global::Java.Lang.Class GetDeclaringClass()
        {
            long    jnet_ref = (long)_cmj_fun0.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public string Name()
        {
            return _cmj_fun1.CallString( this );
        }    
    
        public int Ordinal()
        {
            return _cmj_fun2.CallInt( this );
        }    
    
        public static global::Java.Lang.Enum ValueOf(global::Java.Lang.Class enumType, string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(enumType).Add(name) )
            {
                if(_cmj_fun3.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun3.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Lang.Enum.EnumImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Lang.Enum)_cmj_fun3.CallObject( null, typeof(global::Java.Lang.Enum), false, cmj_jmargs );
        
            }
        }    
        
        
        
        [global::System.Serializable]
        [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.Enum")]
        public class EnumImpl :
            global::Java.Lang.Enum,
            global::System.Runtime.Serialization.ISerializable
        
        {
        
        
        
            /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
            /// <para>You should never have to use this constructor explicitly. It is a
            /// constructor that is required by the JuggerNET framework.</para></summary>
            /// <param name="jobj"> The JNI object handle.</param>
            public EnumImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
        
        
            ///<summary>Reinflate a serialized object.</summary>
            protected EnumImpl( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
            {
            }
        
            void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
            {
                global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
            }
        
            /// <summary>Returns an instance of type EnumImpl if the given proxy instance
            /// represents a Java object that is type-compatible with java.lang.Enum</summary>
            /// <param name="proxy">A proxy object of any type.</param>
            public static new global::Java.Lang.Enum.EnumImpl From( object proxy )
            {
                global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
                if (_cmj_theClass.IsTypeOf(jp))
                    return new global::Java.Lang.Enum.EnumImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
                else
                    return null;
            }
        }    
    
    }

}
