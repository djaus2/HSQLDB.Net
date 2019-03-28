/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.Calendar
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util
{
    [global::System.Runtime.InteropServices.GuidAttribute("6A10B0FE-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.Calendar")]
    public abstract class Calendar :
        global::Java.Lang.ComparableImpl,
        global::Java.Io.Serializable,
        global::Java.Lang.Cloneable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
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
    
        static Calendar()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.Calendar", typeof(global::Java.Util.Calendar), typeof(global::Java.Util.Calendar.CalendarImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "add", "(II)V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "after", "(Ljava/lang/Object;)Z", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "before", "(Ljava/lang/Object;)Z", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "clear", "()V", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "clear", "(I)V", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "clone", "()Ljava/lang/Object;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "get", "(I)I", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getActualMaximum", "(I)I", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getActualMinimum", "(I)I", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getCalendarType", "()Ljava/lang/String;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getFirstDayOfWeek", "()I", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getGreatestMinimum", "(I)I", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Calendar), "getInstance", "()Ljava/util/Calendar;", true, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getLeastMaximum", "(I)I", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMaximum", "(I)I", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMinimalDaysInFirstWeek", "()I", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMinimum", "(I)I", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Date), "getTime", "()Ljava/util/Date;", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getTimeInMillis", "()J", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getWeekYear", "()I", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getWeeksInWeekYear", "()I", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isLenient", "()Z", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isSet", "(I)Z", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isWeekDateSupported", "()Z", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "roll", "(II)V", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "roll", "(IZ)V", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "set", "(II)V", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "set", "(III)V", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "set", "(IIIII)V", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "set", "(IIIIII)V", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFirstDayOfWeek", "(I)V", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setLenient", "(Z)V", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setMinimalDaysInFirstWeek", "(I)V", false, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(Ljava/util/Date;)V", false, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTimeInMillis", "(J)V", false, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setWeekDate", "(III)V", false, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "toInstant", "()Ljava/time/Instant;", false, false, false );
        }
    
        public const int        ALL_STYLES = 0;
        public const int        AM = 0;
        public const int        AM_PM = 9;
        public const int        APRIL = 3;
        public const int        AUGUST = 7;
        public const int        DATE = 5;
        public const int        DAY_OF_MONTH = 5;
        public const int        DAY_OF_WEEK = 7;
        public const int        DAY_OF_WEEK_IN_MONTH = 8;
        public const int        DAY_OF_YEAR = 6;
        public const int        DECEMBER = 11;
        public const int        DST_OFFSET = 16;
        public const int        ERA = 0;
        public const int        FEBRUARY = 1;
        public const int        FIELD_COUNT = 17;
        public const int        FRIDAY = 6;
        public const int        HOUR = 10;
        public const int        HOUR_OF_DAY = 11;
        public const int        JANUARY = 0;
        public const int        JULY = 6;
        public const int        JUNE = 5;
        public const int        LONG = 2;
        public const int        LONG_FORMAT = 2;
        public const int        LONG_STANDALONE = 32770;
        public const int        MARCH = 2;
        public const int        MAY = 4;
        public const int        MILLISECOND = 14;
        public const int        MINUTE = 12;
        public const int        MONDAY = 2;
        public const int        MONTH = 2;
        public const int        NARROW_FORMAT = 4;
        public const int        NARROW_STANDALONE = 32772;
        public const int        NOVEMBER = 10;
        public const int        OCTOBER = 9;
        public const int        PM = 1;
        public const int        SATURDAY = 7;
        public const int        SECOND = 13;
        public const int        SEPTEMBER = 8;
        public const int        SHORT = 1;
        public const int        SHORT_FORMAT = 1;
        public const int        SHORT_STANDALONE = 32769;
        public const int        SUNDAY = 1;
        public const int        THURSDAY = 5;
        public const int        TUESDAY = 3;
        public const int        UNDECIMBER = 12;
        public const int        WEDNESDAY = 4;
        public const int        WEEK_OF_MONTH = 4;
        public const int        WEEK_OF_YEAR = 3;
        public const int        YEAR = 1;
        public const int        ZONE_OFFSET = 15;
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Calendar( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        protected Calendar( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type Calendar if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.Calendar</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.Calendar From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.Calendar.CalendarImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public void Add(int field, int amount)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field).Add(amount) )
            {
                _cmj_fun0.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public bool After(object when)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(when) )
            {
                return _cmj_fun1.CallBool( this, cmj_jmargs );
            }
        }    
    
        public bool Before(object when)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(when) )
            {
                return _cmj_fun2.CallBool( this, cmj_jmargs );
            }
        }    
    
        public void Clear()
        {
            _cmj_fun3.CallVoid( this );
        }    
    
        public void Clear(int field)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field) )
            {
                _cmj_fun4.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public object Clone()
        {
            return _cmj_fun5.CallObject( this, typeof(object), false );
        }    
    
        public int Get(int field)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field) )
            {
                return _cmj_fun6.CallInt( this, cmj_jmargs );
            }
        }    
    
        public int GetActualMaximum(int field)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field) )
            {
                return _cmj_fun7.CallInt( this, cmj_jmargs );
            }
        }    
    
        public int GetActualMinimum(int field)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field) )
            {
                return _cmj_fun8.CallInt( this, cmj_jmargs );
            }
        }    
    
        public string GetCalendarType()
        {
            return _cmj_fun9.CallString( this );
        }    
    
        public int GetFirstDayOfWeek()
        {
            return _cmj_fun10.CallInt( this );
        }    
    
        public int GetGreatestMinimum(int field)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field) )
            {
                return _cmj_fun11.CallInt( this, cmj_jmargs );
            }
        }    
    
        public static global::Java.Util.Calendar GetInstance()
        {
            if(_cmj_fun12.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun12.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.Calendar.CalendarImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Calendar)_cmj_fun12.CallObject( null, typeof(global::Java.Util.Calendar), false );
        
        }    
    
        public int GetLeastMaximum(int field)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field) )
            {
                return _cmj_fun13.CallInt( this, cmj_jmargs );
            }
        }    
    
        public int GetMaximum(int field)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field) )
            {
                return _cmj_fun14.CallInt( this, cmj_jmargs );
            }
        }    
    
        public int GetMinimalDaysInFirstWeek()
        {
            return _cmj_fun15.CallInt( this );
        }    
    
        public int GetMinimum(int field)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field) )
            {
                return _cmj_fun16.CallInt( this, cmj_jmargs );
            }
        }    
    
        public global::Java.Util.Date GetTime()
        {
            if(_cmj_fun17.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun17.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Date)_cmj_fun17.CallObject( this, typeof(global::Java.Util.Date), false );
        
        }    
    
        public long GetTimeInMillis()
        {
            return _cmj_fun18.CallLong( this );
        }    
    
        public int GetWeekYear()
        {
            return _cmj_fun19.CallInt( this );
        }    
    
        public int GetWeeksInWeekYear()
        {
            return _cmj_fun20.CallInt( this );
        }    
    
        public bool IsLenient()
        {
            return _cmj_fun21.CallBool( this );
        }    
    
        public bool IsSet(int field)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field) )
            {
                return _cmj_fun22.CallBool( this, cmj_jmargs );
            }
        }    
    
        public bool IsWeekDateSupported()
        {
            return _cmj_fun23.CallBool( this );
        }    
    
        public void Roll(int field, int amount)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field).Add(amount) )
            {
                _cmj_fun24.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Roll(int field, bool up)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field).Add(up) )
            {
                _cmj_fun25.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Set(int field, int value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(field).Add(value) )
            {
                _cmj_fun26.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Set(int year, int month, int date)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(date) )
            {
                _cmj_fun27.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Set(int year, int month, int date, int hourOfDay, int minute)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 5 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(date).Add(hourOfDay).Add(minute) )
            {
                _cmj_fun28.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Set(int year, int month, int date, int hourOfDay, int minute, int second)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 6 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(date).Add(hourOfDay).Add(minute).Add(second) )
            {
                _cmj_fun29.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetFirstDayOfWeek(int value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                _cmj_fun30.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetLenient(bool lenient)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(lenient) )
            {
                _cmj_fun31.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetMinimalDaysInFirstWeek(int value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                _cmj_fun32.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetTime(global::Java.Util.Date date)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(date) )
            {
                _cmj_fun33.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetTimeInMillis(long millis)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(millis) )
            {
                _cmj_fun34.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetWeekDate(int weekYear, int weekOfYear, int dayOfWeek)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(weekYear).Add(weekOfYear).Add(dayOfWeek) )
            {
                _cmj_fun35.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public global::Java.Time.Instant ToInstant()
        {
            long    jnet_ref = (long)_cmj_fun36.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
        
        
        
        [global::System.Serializable]
        [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.Calendar")]
        public class CalendarImpl :
            global::Java.Util.Calendar,
            global::System.Runtime.Serialization.ISerializable
        
        {
        
        
        
            /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
            /// <para>You should never have to use this constructor explicitly. It is a
            /// constructor that is required by the JuggerNET framework.</para></summary>
            /// <param name="jobj"> The JNI object handle.</param>
            public CalendarImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
        
        
            ///<summary>Reinflate a serialized object.</summary>
            protected CalendarImpl( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
            {
            }
        
            void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
            {
                global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
            }
        
            /// <summary>Returns an instance of type CalendarImpl if the given proxy instance
            /// represents a Java object that is type-compatible with java.util.Calendar</summary>
            /// <param name="proxy">A proxy object of any type.</param>
            public static new global::Java.Util.Calendar.CalendarImpl From( object proxy )
            {
                global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
                if (_cmj_theClass.IsTypeOf(jp))
                    return new global::Java.Util.Calendar.CalendarImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
                else
                    return null;
            }
        }    
    
    }

}
