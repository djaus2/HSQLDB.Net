/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.security.BasicPermission
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Security
{
    [global::System.Runtime.InteropServices.GuidAttribute("05AC2C1B-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.security.BasicPermission")]
    public abstract class BasicPermission :
        global::Java.Security.Permission,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr1;
    
        static BasicPermission()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.security.BasicPermission", typeof(global::Java.Security.BasicPermission), typeof(global::Java.Security.BasicPermission.BasicPermissionImpl), null);
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Security.BasicPermission), "<init>", "(Ljava/lang/String;)V", false );
            _cmj_ctr1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Security.BasicPermission), "<init>", "(Ljava/lang/String;Ljava/lang/String;)V", false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public BasicPermission( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        protected BasicPermission( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        public BasicPermission(string name) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                JObject = (long)_cmj_ctr0.CallObject( this, cmj_jmargs );
            }
        }
    
        public BasicPermission(string name, string actions) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(actions) )
            {
                JObject = (long)_cmj_ctr1.CallObject( this, cmj_jmargs );
            }
        }
    
    
        /// <summary>Returns an instance of type BasicPermission if the given proxy instance
        /// represents a Java object that is type-compatible with java.security.BasicPermission</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Security.BasicPermission From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Security.BasicPermission.BasicPermissionImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        
        [global::System.Serializable]
        [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.security.BasicPermission")]
        public class BasicPermissionImpl :
            global::Java.Security.BasicPermission,
            global::System.Runtime.Serialization.ISerializable
        
        {
        
        
        
            /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
            /// <para>You should never have to use this constructor explicitly. It is a
            /// constructor that is required by the JuggerNET framework.</para></summary>
            /// <param name="jobj"> The JNI object handle.</param>
            public BasicPermissionImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
        
        
            ///<summary>Reinflate a serialized object.</summary>
            protected BasicPermissionImpl( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
            {
            }
        
            void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
            {
                global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
            }
        
            /// <summary>Returns an instance of type BasicPermissionImpl if the given proxy instance
            /// represents a Java object that is type-compatible with java.security.BasicPermission</summary>
            /// <param name="proxy">A proxy object of any type.</param>
            public static new global::Java.Security.BasicPermission.BasicPermissionImpl From( object proxy )
            {
                global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
                if (_cmj_theClass.IsTypeOf(jp))
                    return new global::Java.Security.BasicPermission.BasicPermissionImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
                else
                    return null;
            }
        }    
    
    }

}
