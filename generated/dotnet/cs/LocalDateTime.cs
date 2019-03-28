/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.time.LocalDateTime
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Time
{
    [global::System.Runtime.InteropServices.GuidAttribute("E149DDF1-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.time.LocalDateTime")]
    public sealed class LocalDateTime :
        global::Java.Lang.ComparableImpl,
        global::Java.Io.Serializable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
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
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun28;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun29;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun30;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun31;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun32;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun33;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun34;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun35;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun36;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun37;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun38;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun39;
    
        static LocalDateTime()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.time.LocalDateTime", typeof(global::Java.Time.LocalDateTime));
            _cmj_fldMAX = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "MAX", "Ljava/time/LocalDateTime;", true, true );
            _cmj_fldMIN = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "MIN", "Ljava/time/LocalDateTime;", true, true );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDayOfMonth", "()I", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDayOfYear", "()I", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getHour", "()I", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMinute", "()I", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMonthValue", "()I", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getNano", "()I", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getSecond", "()I", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getYear", "()I", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "minusDays", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "minusHours", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "minusMinutes", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "minusMonths", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "minusNanos", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "minusSeconds", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "minusWeeks", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "minusYears", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "now", "()Ljava/time/LocalDateTime;", true, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "of", "(Ljava/time/LocalDate;Ljava/time/LocalTime;)Ljava/time/LocalDateTime;", true, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "of", "(IIIII)Ljava/time/LocalDateTime;", true, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "of", "(IIIIII)Ljava/time/LocalDateTime;", true, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "of", "(IIIIIII)Ljava/time/LocalDateTime;", true, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "parse", "(Ljava/lang/CharSequence;)Ljava/time/LocalDateTime;", true, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "plusDays", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "plusHours", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "plusMinutes", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "plusMonths", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "plusNanos", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "plusSeconds", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "plusWeeks", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "plusYears", "(J)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "toLocalDate", "()Ljava/time/LocalDate;", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalTime), "toLocalTime", "()Ljava/time/LocalTime;", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "withDayOfMonth", "(I)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "withDayOfYear", "(I)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "withHour", "(I)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "withMinute", "(I)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "withMonth", "(I)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun37 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "withNano", "(I)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun38 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "withSecond", "(I)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun39 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "withYear", "(I)Ljava/time/LocalDateTime;", false, false, false );
        }
    
        public static global::Java.Time.LocalDateTime MAX
        {
            get
            {
                return (global::Java.Time.LocalDateTime)_cmj_fldMAX.Get_object();
            }
        }
        
        public static global::Java.Time.LocalDateTime MIN
        {
            get
            {
                return (global::Java.Time.LocalDateTime)_cmj_fldMIN.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public LocalDateTime( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        LocalDateTime( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type LocalDateTime if the given proxy instance
        /// represents a Java object that is type-compatible with java.time.LocalDateTime</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Time.LocalDateTime From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Time.LocalDateTime(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public int GetDayOfMonth()
        {
            return _cmj_fun0.CallInt( this );
        }    
    
        public int GetDayOfYear()
        {
            return _cmj_fun1.CallInt( this );
        }    
    
        public int GetHour()
        {
            return _cmj_fun2.CallInt( this );
        }    
    
        public int GetMinute()
        {
            return _cmj_fun3.CallInt( this );
        }    
    
        public int GetMonthValue()
        {
            return _cmj_fun4.CallInt( this );
        }    
    
        public int GetNano()
        {
            return _cmj_fun5.CallInt( this );
        }    
    
        public int GetSecond()
        {
            return _cmj_fun6.CallInt( this );
        }    
    
        public int GetYear()
        {
            return _cmj_fun7.CallInt( this );
        }    
    
        public global::Java.Time.LocalDateTime MinusDays(long days)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(days) )
            {
                long    jnet_ref = (long)_cmj_fun8.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime MinusHours(long hours)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hours) )
            {
                long    jnet_ref = (long)_cmj_fun9.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime MinusMinutes(long minutes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(minutes) )
            {
                long    jnet_ref = (long)_cmj_fun10.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime MinusMonths(long months)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(months) )
            {
                long    jnet_ref = (long)_cmj_fun11.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime MinusNanos(long nanos)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nanos) )
            {
                long    jnet_ref = (long)_cmj_fun12.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime MinusSeconds(long seconds)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(seconds) )
            {
                long    jnet_ref = (long)_cmj_fun13.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime MinusWeeks(long weeks)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(weeks) )
            {
                long    jnet_ref = (long)_cmj_fun14.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime MinusYears(long years)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(years) )
            {
                long    jnet_ref = (long)_cmj_fun15.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalDateTime Now()
        {
            long    jnet_ref = (long)_cmj_fun16.CallObject( null );
            return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public static global::Java.Time.LocalDateTime Of(global::Java.Time.LocalDate date, global::Java.Time.LocalTime time)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(date).Add(time) )
            {
                long    jnet_ref = (long)_cmj_fun17.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalDateTime Of(int year, int month, int dayOfMonth, int hour, int minute)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 5 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(dayOfMonth).Add(hour).Add(minute) )
            {
                long    jnet_ref = (long)_cmj_fun18.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalDateTime Of(int year, int month, int dayOfMonth, int hour, int minute, int second)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 6 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(dayOfMonth).Add(hour).Add(minute).Add(second) )
            {
                long    jnet_ref = (long)_cmj_fun19.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalDateTime Of(int year, int month, int dayOfMonth, int hour, int minute, int second, int nanoOfSecond)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 7 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(dayOfMonth).Add(hour).Add(minute).Add(second).Add(nanoOfSecond) )
            {
                long    jnet_ref = (long)_cmj_fun20.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalDateTime Parse(global::Java.Lang.CharSequence text)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(text) )
            {
                long    jnet_ref = (long)_cmj_fun21.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime PlusDays(long days)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(days) )
            {
                long    jnet_ref = (long)_cmj_fun22.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime PlusHours(long hours)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hours) )
            {
                long    jnet_ref = (long)_cmj_fun23.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime PlusMinutes(long minutes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(minutes) )
            {
                long    jnet_ref = (long)_cmj_fun24.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime PlusMonths(long months)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(months) )
            {
                long    jnet_ref = (long)_cmj_fun25.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime PlusNanos(long nanos)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nanos) )
            {
                long    jnet_ref = (long)_cmj_fun26.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime PlusSeconds(long seconds)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(seconds) )
            {
                long    jnet_ref = (long)_cmj_fun27.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime PlusWeeks(long weeks)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(weeks) )
            {
                long    jnet_ref = (long)_cmj_fun28.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime PlusYears(long years)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(years) )
            {
                long    jnet_ref = (long)_cmj_fun29.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate ToLocalDate()
        {
            long    jnet_ref = (long)_cmj_fun30.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public global::Java.Time.LocalTime ToLocalTime()
        {
            long    jnet_ref = (long)_cmj_fun31.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Time.LocalTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public global::Java.Time.LocalDateTime WithDayOfMonth(int dayOfMonth)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(dayOfMonth) )
            {
                long    jnet_ref = (long)_cmj_fun32.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime WithDayOfYear(int dayOfYear)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(dayOfYear) )
            {
                long    jnet_ref = (long)_cmj_fun33.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime WithHour(int hour)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hour) )
            {
                long    jnet_ref = (long)_cmj_fun34.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime WithMinute(int minute)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(minute) )
            {
                long    jnet_ref = (long)_cmj_fun35.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime WithMonth(int month)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(month) )
            {
                long    jnet_ref = (long)_cmj_fun36.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime WithNano(int nanoOfSecond)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nanoOfSecond) )
            {
                long    jnet_ref = (long)_cmj_fun37.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime WithSecond(int second)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(second) )
            {
                long    jnet_ref = (long)_cmj_fun38.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime WithYear(int year)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year) )
            {
                long    jnet_ref = (long)_cmj_fun39.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
    
    }

}
