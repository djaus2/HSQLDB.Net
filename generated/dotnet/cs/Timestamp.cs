/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.Timestamp
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("E8105E0A-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.Timestamp")]
    public class Timestamp :
        global::Java.Util.Date,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun6;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun7;
    
        static Timestamp()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.Timestamp", typeof(global::Java.Sql.Timestamp));
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "<init>", "(J)V", false );
            _cmj_ctr1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "<init>", "(IIIIIII)V", false );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compareTo", "(Ljava/sql/Timestamp;)I", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compareTo", "(Ljava/util/Date;)I", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "from", "(Ljava/time/Instant;)Ljava/sql/Timestamp;", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getNanos", "()I", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNanos", "(I)V", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "toLocalDateTime", "()Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "valueOf", "(Ljava/lang/String;)Ljava/sql/Timestamp;", true, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Timestamp), "valueOf", "(Ljava/time/LocalDateTime;)Ljava/sql/Timestamp;", true, false, false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Timestamp( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        protected Timestamp( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        public Timestamp(long time) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(time) )
            {
                JObject = (long)_cmj_ctr0.CallObject( this, cmj_jmargs );
            }
        }
    
        public Timestamp(int year, int month, int date, int hour, int minute, int second, int nano) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 7 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(date).Add(hour).Add(minute).Add(second).Add(nano) )
            {
                JObject = (long)_cmj_ctr1.CallObject( this, cmj_jmargs );
            }
        }
    
    
        /// <summary>Returns an instance of type Timestamp if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.Timestamp</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.Timestamp From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.Timestamp(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public int CompareTo(global::Java.Sql.Timestamp ts)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(ts) )
            {
                return _cmj_fun0.CallInt( this, cmj_jmargs );
            }
        }    
    
        public int CompareTo(global::Java.Util.Date o)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(o) )
            {
                return _cmj_fun1.CallInt( this, cmj_jmargs );
            }
        }    
    
        public static global::Java.Sql.Timestamp From(global::Java.Time.Instant instant)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(instant) )
            {
                if(_cmj_fun2.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun2.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun2.CallObject( null, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }    
    
        public int GetNanos()
        {
            return _cmj_fun3.CallInt( this );
        }    
    
        public void SetNanos(int n)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(n) )
            {
                _cmj_fun4.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public global::Java.Time.LocalDateTime ToLocalDateTime()
        {
            long    jnet_ref = (long)_cmj_fun5.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public static global::Java.Sql.Timestamp ValueOf(string s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                if(_cmj_fun6.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun6.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun6.CallObject( null, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }    
    
        public static global::Java.Sql.Timestamp ValueOf(global::Java.Time.LocalDateTime dateTime)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(dateTime) )
            {
                if(_cmj_fun7.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun7.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.Timestamp( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Timestamp)_cmj_fun7.CallObject( null, typeof(global::Java.Sql.Timestamp), false, cmj_jmargs );
        
            }
        }    
    
    
    }

}
