/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.time.Instant
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Time
{
    [global::System.Runtime.InteropServices.GuidAttribute("41D01FEC-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.time.Instant")]
    public sealed class Instant :
        global::Java.Lang.ComparableImpl,
        global::Java.Io.Serializable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldEPOCH;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldMAX;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldMIN;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun6;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun7;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun8;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun9;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun10;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun11;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun12;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun13;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun14;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun15;
    
        static Instant()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.time.Instant", typeof(global::Java.Time.Instant));
            _cmj_fldEPOCH = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.Instant), "EPOCH", "Ljava/time/Instant;", true, true );
            _cmj_fldMAX = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.Instant), "MAX", "Ljava/time/Instant;", true, true );
            _cmj_fldMIN = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.Instant), "MIN", "Ljava/time/Instant;", true, true );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getEpochSecond", "()J", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getNano", "()I", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isAfter", "(Ljava/time/Instant;)Z", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isBefore", "(Ljava/time/Instant;)Z", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "minusMillis", "(J)Ljava/time/Instant;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "minusNanos", "(J)Ljava/time/Instant;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "minusSeconds", "(J)Ljava/time/Instant;", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "now", "()Ljava/time/Instant;", true, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "ofEpochMilli", "(J)Ljava/time/Instant;", true, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "ofEpochSecond", "(J)Ljava/time/Instant;", true, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "ofEpochSecond", "(JJ)Ljava/time/Instant;", true, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "parse", "(Ljava/lang/CharSequence;)Ljava/time/Instant;", true, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "plusMillis", "(J)Ljava/time/Instant;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "plusNanos", "(J)Ljava/time/Instant;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "plusSeconds", "(J)Ljava/time/Instant;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "toEpochMilli", "()J", false, false, false );
        }
    
        public static global::Java.Time.Instant EPOCH
        {
            get
            {
                return (global::Java.Time.Instant)_cmj_fldEPOCH.Get_object();
            }
        }
        
        public static global::Java.Time.Instant MAX
        {
            get
            {
                return (global::Java.Time.Instant)_cmj_fldMAX.Get_object();
            }
        }
        
        public static global::Java.Time.Instant MIN
        {
            get
            {
                return (global::Java.Time.Instant)_cmj_fldMIN.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Instant( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        Instant( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type Instant if the given proxy instance
        /// represents a Java object that is type-compatible with java.time.Instant</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Time.Instant From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Time.Instant(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public long GetEpochSecond()
        {
            return _cmj_fun0.CallLong( this );
        }    
    
        public int GetNano()
        {
            return _cmj_fun1.CallInt( this );
        }    
    
        public bool IsAfter(global::Java.Time.Instant otherInstant)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(otherInstant) )
            {
                return _cmj_fun2.CallBool( this, cmj_jmargs );
            }
        }    
    
        public bool IsBefore(global::Java.Time.Instant otherInstant)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(otherInstant) )
            {
                return _cmj_fun3.CallBool( this, cmj_jmargs );
            }
        }    
    
        public global::Java.Time.Instant MinusMillis(long millisToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(millisToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun4.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.Instant MinusNanos(long nanosToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nanosToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun5.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.Instant MinusSeconds(long secondsToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(secondsToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun6.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.Instant Now()
        {
            long    jnet_ref = (long)_cmj_fun7.CallObject( null );
            return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public static global::Java.Time.Instant OfEpochMilli(long epochMilli)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(epochMilli) )
            {
                long    jnet_ref = (long)_cmj_fun8.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.Instant OfEpochSecond(long epochSecond)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(epochSecond) )
            {
                long    jnet_ref = (long)_cmj_fun9.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.Instant OfEpochSecond(long epochSecond, long nanoAdjustment)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(epochSecond).Add(nanoAdjustment) )
            {
                long    jnet_ref = (long)_cmj_fun10.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.Instant Parse(global::Java.Lang.CharSequence text)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(text) )
            {
                long    jnet_ref = (long)_cmj_fun11.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.Instant PlusMillis(long millisToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(millisToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun12.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.Instant PlusNanos(long nanosToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nanosToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun13.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.Instant PlusSeconds(long secondsToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(secondsToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun14.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public long ToEpochMilli()
        {
            return _cmj_fun15.CallLong( this );
        }    
    
    
    }

}
