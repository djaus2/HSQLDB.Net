/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.time.LocalDate
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Time
{
    [global::System.Runtime.InteropServices.GuidAttribute("C4AE3904-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.time.LocalDate")]
    public sealed class LocalDate :
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
    
        static LocalDate()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.time.LocalDate", typeof(global::Java.Time.LocalDate));
            _cmj_fldMAX = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.LocalDate), "MAX", "Ljava/time/LocalDate;", true, true );
            _cmj_fldMIN = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Time.LocalDate), "MIN", "Ljava/time/LocalDate;", true, true );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "atStartOfDay", "()Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "atTime", "(Ljava/time/LocalTime;)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "atTime", "(II)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "atTime", "(III)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDateTime), "atTime", "(IIII)Ljava/time/LocalDateTime;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDayOfMonth", "()I", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDayOfYear", "()I", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMonthValue", "()I", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getYear", "()I", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isLeapYear", "()Z", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "lengthOfMonth", "()I", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "lengthOfYear", "()I", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "minusDays", "(J)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "minusMonths", "(J)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "minusWeeks", "(J)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "minusYears", "(J)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "now", "()Ljava/time/LocalDate;", true, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "of", "(III)Ljava/time/LocalDate;", true, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "ofEpochDay", "(J)Ljava/time/LocalDate;", true, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "ofYearDay", "(II)Ljava/time/LocalDate;", true, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "parse", "(Ljava/lang/CharSequence;)Ljava/time/LocalDate;", true, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "plusDays", "(J)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "plusMonths", "(J)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "plusWeeks", "(J)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "plusYears", "(J)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "toEpochDay", "()J", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "withDayOfMonth", "(I)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "withDayOfYear", "(I)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "withMonth", "(I)Ljava/time/LocalDate;", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.LocalDate), "withYear", "(I)Ljava/time/LocalDate;", false, false, false );
        }
    
        public static global::Java.Time.LocalDate MAX
        {
            get
            {
                return (global::Java.Time.LocalDate)_cmj_fldMAX.Get_object();
            }
        }
        
        public static global::Java.Time.LocalDate MIN
        {
            get
            {
                return (global::Java.Time.LocalDate)_cmj_fldMIN.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public LocalDate( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        LocalDate( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type LocalDate if the given proxy instance
        /// represents a Java object that is type-compatible with java.time.LocalDate</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Time.LocalDate From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Time.LocalDate(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public global::Java.Time.LocalDateTime AtStartOfDay()
        {
            long    jnet_ref = (long)_cmj_fun0.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public global::Java.Time.LocalDateTime AtTime(global::Java.Time.LocalTime time)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(time) )
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime AtTime(int hour, int minute)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hour).Add(minute) )
            {
                long    jnet_ref = (long)_cmj_fun2.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime AtTime(int hour, int minute, int second)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hour).Add(minute).Add(second) )
            {
                long    jnet_ref = (long)_cmj_fun3.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDateTime AtTime(int hour, int minute, int second, int nanoOfSecond)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 4 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hour).Add(minute).Add(second).Add(nanoOfSecond) )
            {
                long    jnet_ref = (long)_cmj_fun4.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDateTime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public int GetDayOfMonth()
        {
            return _cmj_fun5.CallInt( this );
        }    
    
        public int GetDayOfYear()
        {
            return _cmj_fun6.CallInt( this );
        }    
    
        public int GetMonthValue()
        {
            return _cmj_fun7.CallInt( this );
        }    
    
        public int GetYear()
        {
            return _cmj_fun8.CallInt( this );
        }    
    
        public bool IsLeapYear()
        {
            return _cmj_fun9.CallBool( this );
        }    
    
        public int LengthOfMonth()
        {
            return _cmj_fun10.CallInt( this );
        }    
    
        public int LengthOfYear()
        {
            return _cmj_fun11.CallInt( this );
        }    
    
        public global::Java.Time.LocalDate MinusDays(long daysToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(daysToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun12.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate MinusMonths(long monthsToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(monthsToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun13.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate MinusWeeks(long weeksToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(weeksToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun14.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate MinusYears(long yearsToSubtract)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(yearsToSubtract) )
            {
                long    jnet_ref = (long)_cmj_fun15.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalDate Now()
        {
            long    jnet_ref = (long)_cmj_fun16.CallObject( null );
            return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public static global::Java.Time.LocalDate Of(int year, int month, int dayOfMonth)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(dayOfMonth) )
            {
                long    jnet_ref = (long)_cmj_fun17.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalDate OfEpochDay(long epochDay)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(epochDay) )
            {
                long    jnet_ref = (long)_cmj_fun18.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalDate OfYearDay(int year, int dayOfYear)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(dayOfYear) )
            {
                long    jnet_ref = (long)_cmj_fun19.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Time.LocalDate Parse(global::Java.Lang.CharSequence text)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(text) )
            {
                long    jnet_ref = (long)_cmj_fun20.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate PlusDays(long daysToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(daysToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun21.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate PlusMonths(long monthsToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(monthsToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun22.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate PlusWeeks(long weeksToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(weeksToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun23.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate PlusYears(long yearsToAdd)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(yearsToAdd) )
            {
                long    jnet_ref = (long)_cmj_fun24.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public long ToEpochDay()
        {
            return _cmj_fun25.CallLong( this );
        }    
    
        public global::Java.Time.LocalDate WithDayOfMonth(int dayOfMonth)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(dayOfMonth) )
            {
                long    jnet_ref = (long)_cmj_fun26.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate WithDayOfYear(int dayOfYear)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(dayOfYear) )
            {
                long    jnet_ref = (long)_cmj_fun27.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate WithMonth(int month)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(month) )
            {
                long    jnet_ref = (long)_cmj_fun28.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Time.LocalDate WithYear(int year)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year) )
            {
                long    jnet_ref = (long)_cmj_fun29.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Time.LocalDate( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
    
    }

}
