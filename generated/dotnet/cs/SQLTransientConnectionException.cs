/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.SQLTransientConnectionException
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("D10F3309-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.SQLTransientConnectionException")]
    public class SQLTransientConnectionException :
        global::Java.Sql.SQLTransientException,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr6;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr7;
    
        static SQLTransientConnectionException()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.SQLTransientConnectionException", typeof(global::Java.Sql.SQLTransientConnectionException));
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLTransientConnectionException), "<init>", "()V", false );
            _cmj_ctr1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLTransientConnectionException), "<init>", "(Ljava/lang/String;)V", false );
            _cmj_ctr2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLTransientConnectionException), "<init>", "(Ljava/lang/Throwable;)V", false );
            _cmj_ctr3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLTransientConnectionException), "<init>", "(Ljava/lang/String;Ljava/lang/String;)V", false );
            _cmj_ctr4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLTransientConnectionException), "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V", false );
            _cmj_ctr5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLTransientConnectionException), "<init>", "(Ljava/lang/String;Ljava/lang/String;I)V", false );
            _cmj_ctr6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLTransientConnectionException), "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", false );
            _cmj_ctr7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.SQLTransientConnectionException), "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/Throwable;)V", false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public SQLTransientConnectionException( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        protected SQLTransientConnectionException( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        public SQLTransientConnectionException() : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            JObject = (long)_cmj_ctr0.CallObject( this );
        }
    
        public SQLTransientConnectionException(string reason) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(reason) )
            {
                JObject = (long)_cmj_ctr1.CallObject( this, cmj_jmargs );
            }
        }
    
        public SQLTransientConnectionException(global::Java.Lang.Throwable cause) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(cause) )
            {
                JObject = (long)_cmj_ctr2.CallObject( this, cmj_jmargs );
            }
        }
    
        public SQLTransientConnectionException(string reason, string SQLState) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(reason).Add(SQLState) )
            {
                JObject = (long)_cmj_ctr3.CallObject( this, cmj_jmargs );
            }
        }
    
        public SQLTransientConnectionException(string reason, global::Java.Lang.Throwable cause) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(reason).Add(cause) )
            {
                JObject = (long)_cmj_ctr4.CallObject( this, cmj_jmargs );
            }
        }
    
        public SQLTransientConnectionException(string reason, string SQLState, int vendorCode) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(reason).Add(SQLState).Add(vendorCode) )
            {
                JObject = (long)_cmj_ctr5.CallObject( this, cmj_jmargs );
            }
        }
    
        public SQLTransientConnectionException(string reason, string SQLState, global::Java.Lang.Throwable cause) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(reason).Add(SQLState).Add(cause) )
            {
                JObject = (long)_cmj_ctr6.CallObject( this, cmj_jmargs );
            }
        }
    
        public SQLTransientConnectionException(string reason, string SQLState, int vendorCode, global::Java.Lang.Throwable cause) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(reason).Add(SQLState).Add(vendorCode).Add(cause) )
            {
                JObject = (long)_cmj_ctr7.CallObject( this, cmj_jmargs );
            }
        }
    
    
        /// <summary>Returns an instance of type SQLTransientConnectionException if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.SQLTransientConnectionException</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.SQLTransientConnectionException From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.SQLTransientConnectionException(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
    
    }

}
