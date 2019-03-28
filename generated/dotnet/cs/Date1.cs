/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.Date
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util
{
    [global::System.Runtime.InteropServices.GuidAttribute("3FA1856E-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.Date")]
    public class Date :
        global::Java.Lang.ComparableImpl,
        global::System.IConvertible,
        global::Java.Io.Serializable,
        global::Java.Lang.Cloneable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr5;
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
    
        static Date()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.Date", typeof(global::Java.Util.Date));
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Date), "<init>", "()V", false );
            _cmj_ctr1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Date), "<init>", "(J)V", false );
            _cmj_ctr2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Date), "<init>", "(Ljava/lang/String;)V", false );
            _cmj_ctr3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Date), "<init>", "(III)V", false );
            _cmj_ctr4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Date), "<init>", "(IIIII)V", false );
            _cmj_ctr5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Date), "<init>", "(IIIIII)V", false );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "UTC", "(IIIIII)J", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "after", "(Ljava/util/Date;)Z", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "before", "(Ljava/util/Date;)Z", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "clone", "()Ljava/lang/Object;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Date), "from", "(Ljava/time/Instant;)Ljava/util/Date;", true, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDate", "()I", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getDay", "()I", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getHours", "()I", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMinutes", "()I", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMonth", "()I", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getSeconds", "()I", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getTime", "()J", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getTimezoneOffset", "()I", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getYear", "()I", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "parse", "(Ljava/lang/String;)J", true, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDate", "(I)V", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setHours", "(I)V", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setMinutes", "(I)V", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setMonth", "(I)V", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setSeconds", "(I)V", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTime", "(J)V", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setYear", "(I)V", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toGMTString", "()Ljava/lang/String;", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Time.Instant), "toInstant", "()Ljava/time/Instant;", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toLocaleString", "()Ljava/lang/String;", false, false, false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Date( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        protected Date( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        public Date() : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            JObject = (long)_cmj_ctr0.CallObject( this );
        }
    
        public Date(long date) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(date) )
            {
                JObject = (long)_cmj_ctr1.CallObject( this, cmj_jmargs );
            }
        }
    
        public Date(string s) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                JObject = (long)_cmj_ctr2.CallObject( this, cmj_jmargs );
            }
        }
    
        public Date(int year, int month, int date) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(date) )
            {
                JObject = (long)_cmj_ctr3.CallObject( this, cmj_jmargs );
            }
        }
    
        public Date(int year, int month, int date, int hrs, int min) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 5 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(date).Add(hrs).Add(min) )
            {
                JObject = (long)_cmj_ctr4.CallObject( this, cmj_jmargs );
            }
        }
    
        public Date(int year, int month, int date, int hrs, int min, int sec) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 6 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(date).Add(hrs).Add(min).Add(sec) )
            {
                JObject = (long)_cmj_ctr5.CallObject( this, cmj_jmargs );
            }
        }
    
    
        /// <summary>Returns an instance of type Date if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.Date</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.Date From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.Date(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
    
    
        private static global::System.DateTime _epoch = new global::System.DateTime( 1970, 1, 1, 0, 0, 0 );
    
    
        /// <summary>Converts a Java Date to a .NET DateTime instance.
        /// <param name=\"rhs\"> The Java Date that is to be converted.</param>
        public static explicit operator global::System.DateTime(Date rhs)
        {
            if( rhs != null )
            {
                long milliSecsFromEpoch = rhs.GetTime();
                return _epoch.AddTicks( global::System.TimeSpan.TicksPerMillisecond * milliSecsFromEpoch );
            }
            else
                return global::System.DateTime.MinValue;
        }
        
    
        /// <summary>Converts a .NET DateTime to a Java Date instance.
        /// <param name=\"rhs\"> The .NET DateTime that is to be converted.</param>
        public static explicit operator Date( global::System.DateTime rhs)
        {
            global::System.TimeSpan timeOffsetFromEpoch = rhs - _epoch;
            long                    milliSecsFromEpoch = timeOffsetFromEpoch.Ticks/System.TimeSpan.TicksPerMillisecond;
            return new Date( milliSecsFromEpoch );
        }
    
        public static long UTC(int year, int month, int date, int hrs, int min, int sec)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 6 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year).Add(month).Add(date).Add(hrs).Add(min).Add(sec) )
            {
                return _cmj_fun0.CallLong( null, cmj_jmargs );
            }
        }    
    
        public bool After(global::Java.Util.Date when)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(when) )
            {
                return _cmj_fun1.CallBool( this, cmj_jmargs );
            }
        }    
    
        public bool Before(global::Java.Util.Date when)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(when) )
            {
                return _cmj_fun2.CallBool( this, cmj_jmargs );
            }
        }    
    
        public object Clone()
        {
            return _cmj_fun3.CallObject( this, typeof(object), false );
        }    
    
        public static global::Java.Util.Date From(global::Java.Time.Instant instant)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(instant) )
            {
                if(_cmj_fun4.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun4.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.Date( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.Date)_cmj_fun4.CallObject( null, typeof(global::Java.Util.Date), false, cmj_jmargs );
        
            }
        }    
    
        public int GetDate()
        {
            return _cmj_fun5.CallInt( this );
        }    
    
        public int GetDay()
        {
            return _cmj_fun6.CallInt( this );
        }    
    
        public int GetHours()
        {
            return _cmj_fun7.CallInt( this );
        }    
    
        public int GetMinutes()
        {
            return _cmj_fun8.CallInt( this );
        }    
    
        public int GetMonth()
        {
            return _cmj_fun9.CallInt( this );
        }    
    
        public int GetSeconds()
        {
            return _cmj_fun10.CallInt( this );
        }    
    
        public long GetTime()
        {
            return _cmj_fun11.CallLong( this );
        }    
    
        public int GetTimezoneOffset()
        {
            return _cmj_fun12.CallInt( this );
        }    
    
        public int GetYear()
        {
            return _cmj_fun13.CallInt( this );
        }    
    
        public static long Parse(string s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                return _cmj_fun14.CallLong( null, cmj_jmargs );
            }
        }    
    
        public void SetDate(int date)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(date) )
            {
                _cmj_fun15.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetHours(int hours)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(hours) )
            {
                _cmj_fun16.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetMinutes(int minutes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(minutes) )
            {
                _cmj_fun17.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetMonth(int month)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(month) )
            {
                _cmj_fun18.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetSeconds(int seconds)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(seconds) )
            {
                _cmj_fun19.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetTime(long time)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(time) )
            {
                _cmj_fun20.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetYear(int year)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(year) )
            {
                _cmj_fun21.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public string ToGMTString()
        {
            return _cmj_fun22.CallString( this );
        }    
    
        public global::Java.Time.Instant ToInstant()
        {
            long    jnet_ref = (long)_cmj_fun23.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Time.Instant( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public string ToLocaleString()
        {
            return _cmj_fun24.CallString( this );
        }    
    
        /// <summary>Returns the object's typecode.</summary>
        global::System.TypeCode global::System.IConvertible.GetTypeCode()
        {
            return global::System.TypeCode.Object;
        }
    
    
        /// <summary>Returns the object's boolean representation.</summary>
        bool    global::System.IConvertible.ToBoolean( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's byte representation.</summary>
        byte    global::System.IConvertible.ToByte( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's char representation.</summary>
        char    global::System.IConvertible.ToChar( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's DateTime representation.</summary>
        global::System.DateTime    global::System.IConvertible.ToDateTime( global::System.IFormatProvider formatProvider )
        {
            return (global::System.DateTime)this;
        }
    
    
        /// <summary>Returns the object's Decimal representation.</summary>
        global::System.Decimal    global::System.IConvertible.ToDecimal( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's double representation.</summary>
        double    global::System.IConvertible.ToDouble( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's Int16 representation.</summary>
        short    global::System.IConvertible.ToInt16( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's Int32 representation.</summary>
        int    global::System.IConvertible.ToInt32( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's Int64 representation.</summary>
        long    global::System.IConvertible.ToInt64( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's sbyte representation.</summary>
        sbyte    global::System.IConvertible.ToSByte( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's float representation.</summary>
        float    global::System.IConvertible.ToSingle( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's string representation.</summary>
        string    global::System.IConvertible.ToString( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToString( ((global::System.IConvertible)this).ToDateTime( formatProvider ), formatProvider );
        }
    
    
        /// <summary>Returns the an object of the given type.</summary>
        object    global::System.IConvertible.ToType( global::System.Type type, global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ChangeType( ((global::System.IConvertible)this).ToDateTime( formatProvider ), type );
        }
    
    
        /// <summary>Returns the object's UInt16 representation.</summary>
        ushort    global::System.IConvertible.ToUInt16( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's UInt32 representation.</summary>
        uint    global::System.IConvertible.ToUInt32( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's UInt64 representation.</summary>
        ulong    global::System.IConvertible.ToUInt64( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
    
    }

}
