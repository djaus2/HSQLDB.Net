/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.time.LocalTime
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Time
{
    [global::System.Runtime.InteropServices.GuidAttribute("C4B59C23-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.time.LocalTime")]
    public sealed class LocalTime :
        global::Java.Lang.ComparableImpl,
        global::Java.Io.Serializable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldMAX;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldMIDNIGHT;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldMIN;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldNOON;
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
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun16;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun17;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun18;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun19;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun20;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun21;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun22;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun23;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun24;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun25;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun26;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun27;
    
        static LocalTime()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.time.LocalTime", typeof(global::Java.Time.LocalTime));
            _cmj_fldMAX = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.LocalTime), "MAX", "Ljava/time/LocalTime;", true, true );
            _cmj_fldMIDNIGHT = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.LocalTime), "MIDNIGHT", "Ljava/time/LocalTime;", true, true );
            _cmj_fldMIN = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.LocalTime), "MIN", "Ljava/time/LocalTime;", true, true );
            _cmj_fldNOON = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.LocalTime), "NOON", "Ljava/time/LocalTime;", true, true );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "atDate", "(Ljava/time/LocalDate;)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getHour", "()I", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMinute", "()I", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getNano", "()I", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getSecond", "()I", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isAfter", "(Ljava/time/LocalTime;)Z", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isBefore", "(Ljava/time/LocalTime;)Z", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "minusHours", "(J)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "minusMinutes", "(J)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "minusNanos", "(J)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "minusSeconds", "(J)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "now", "()Ljava/time/LocalTime;", true, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "of", "(II)Ljava/time/LocalTime;", true, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "of", "(III)Ljava/time/LocalTime;", true, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "of", "(IIII)Ljava/time/LocalTime;", true, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "ofNanoOfDay", "(J)Ljava/time/LocalTime;", true, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "ofSecondOfDay", "(J)Ljava/time/LocalTime;", true, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "parse", "(Ljava/lang/CharSequence;)Ljava/time/LocalTime;", true, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "plusHours", "(J)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "plusMinutes", "(J)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "plusNanos", "(J)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "plusSeconds", "(J)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "toNanoOfDay", "()J", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "toSecondOfDay", "()I", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "withHour", "(I)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "withMinute", "(I)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "withNano", "(I)Ljava/time/LocalTime;", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "withSecond", "(I)Ljava/time/LocalTime;", false, false, false );
        }
    
        public static global::Java.Time.LocalTime MAX
        {
            get
            {
                return (global::Java.Time.LocalTime)_cmj_fldMAX.Get_object();
            }
        }
        
        public static global::Java.Time.LocalTime MIDNIGHT
        {
            get
            {
                return (global::Java.Time.LocalTime)_cmj_fldMIDNIGHT.Get_object();
            }
        }
        
        public static global::Java.Time.LocalTime MIN
        {
            get
            {
                return (global::Java.Time.LocalTime)_cmj_fldMIN.Get_object();
            }
        }
        
        public static global::Java.Time.LocalTime NOON
        {
            get
            {
                return (global::Java.Time.LocalTime)_cmj_fldNOON.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public LocalTime( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        LocalTime( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type LocalTime if the given proxy instance
        /// represents a Java object that is type-compatible with java.time.LocalTime</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Time.LocalTime From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Time.LocalTime(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public global::Java.Time.LocalDateTime AtDate(global::Java.Time.LocalDate date)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(date) )
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public int GetHour()
        {
            return _cmj_fun1.CallInt( this );
        }    
    
        public int GetMinute()
        {
            return _cmj_fun2.CallInt( this );
        }    
    
        public int GetNano()
        {
            return _cmj_fun3.CallInt( this );
        }    
    
        public int GetSecond()
        {
            return _cmj_fun4.CallInt( this );
        }    
    
        public bool IsAfter(global::Java.Time.LocalTime other)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(other) )
            {
                return _cmj_fun5.CallBool( this, cmj_jmargs );
            }
        }    
    
        public bool IsBefore(global::Java.Time.LocalTime other)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(other) )
            {
                return _cmj_fun6.CallBool( this, cmj_jmargs );
            }
        }    
    
        public global::Java.Time.LocalTime MinusHours(long hoursToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hoursToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun7.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime MinusMinutes(long minutesToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(minutesToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun8.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime MinusNanos(long nanosToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nanosToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun9.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime MinusSeconds(long secondsToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(secondsToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun10.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalTime Now()
        {
            long    jnet_ref = (long)_cmj_fun11.CallObject( null );
            return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public static global::Java.Time.LocalTime Of(int hour, int minute)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hour).Add(minute) )
            {
                long    jnet_ref = (long)_cmj_fun12.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalTime Of(int hour, int minute, int second)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hour).Add(minute).Add(second) )
            {
                long    jnet_ref = (long)_cmj_fun13.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalTime Of(int hour, int minute, int second, int nanoOfSecond)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hour).Add(minute).Add(second).Add(nanoOfSecond) )
            {
                long    jnet_ref = (long)_cmj_fun14.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalTime OfNanoOfDay(long nanoOfDay)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nanoOfDay) )
            {
                long    jnet_ref = (long)_cmj_fun15.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalTime OfSecondOfDay(long secondOfDay)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(secondOfDay) )
            {
                long    jnet_ref = (long)_cmj_fun16.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalTime Parse(global::Java.Lang.CharSequence text)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(text) )
            {
                long    jnet_ref = (long)_cmj_fun17.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime PlusHours(long hoursToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hoursToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun18.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime PlusMinutes(long minutesToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(minutesToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun19.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime PlusNanos(long nanosToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nanosToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun20.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime PlusSeconds(long secondstoAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(secondstoAdd) )
            {
                long    jnet_ref = (long)_cmj_fun21.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public long ToNanoOfDay()
        {
            return _cmj_fun22.CallLong( this );
        }    
    
        public int ToSecondOfDay()
        {
            return _cmj_fun23.CallInt( this );
        }    
    
        public global::Java.Time.LocalTime WithHour(int hour)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hour) )
            {
                long    jnet_ref = (long)_cmj_fun24.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime WithMinute(int minute)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(minute) )
            {
                long    jnet_ref = (long)_cmj_fun25.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime WithNano(int nanoOfSecond)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nanoOfSecond) )
            {
                long    jnet_ref = (long)_cmj_fun26.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalTime WithSecond(int second)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(second) )
            {
                long    jnet_ref = (long)_cmj_fun27.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
    
    }

}
