/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.Long
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang
{
    [global::System.Runtime.InteropServices.GuidAttribute("537E0DD0-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.Long")]
    public sealed class Long :
        global::Java.Lang.Number,
        global::Java.Lang.Comparable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldTYPE;
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
    
        static Long()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.Long", typeof(global::Java.Lang.Long));
            _cmj_fldTYPE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Lang.Class), "TYPE", "Ljava/lang/Class;", true, true );
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Long), "<init>", "(J)V", false );
            _cmj_ctr1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Long), "<init>", "(Ljava/lang/String;)V", false );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "bitCount", "(J)I", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compare", "(JJ)I", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compareTo", "(Ljava/lang/Long;)I", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compareUnsigned", "(JJ)I", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Long), "decode", "(Ljava/lang/String;)Ljava/lang/Long;", true, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "divideUnsigned", "(JJ)J", true, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Long), "getLong", "(Ljava/lang/String;)Ljava/lang/Long;", true, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Long), "getLong", "(Ljava/lang/String;J)Ljava/lang/Long;", true, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Long), "getLong", "(Ljava/lang/String;Ljava/lang/Long;)Ljava/lang/Long;", true, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "hashCode", "(J)I", true, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "highestOneBit", "(J)J", true, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "lowestOneBit", "(J)J", true, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "max", "(JJ)J", true, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "min", "(JJ)J", true, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "numberOfLeadingZeros", "(J)I", true, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "numberOfTrailingZeros", "(J)I", true, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "parseLong", "(Ljava/lang/String;)J", true, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "parseLong", "(Ljava/lang/String;I)J", true, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "parseUnsignedLong", "(Ljava/lang/String;)J", true, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "parseUnsignedLong", "(Ljava/lang/String;I)J", true, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "remainderUnsigned", "(JJ)J", true, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "reverse", "(J)J", true, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "reverseBytes", "(J)J", true, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "rotateLeft", "(JI)J", true, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "rotateRight", "(JI)J", true, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "signum", "(J)I", true, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "sum", "(JJ)J", true, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toBinaryString", "(J)Ljava/lang/String;", true, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toHexString", "(J)Ljava/lang/String;", true, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toOctalString", "(J)Ljava/lang/String;", true, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toString", "(J)Ljava/lang/String;", true, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toString", "(JI)Ljava/lang/String;", true, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toUnsignedString", "(J)Ljava/lang/String;", true, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toUnsignedString", "(JI)Ljava/lang/String;", true, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Long), "valueOf", "(J)Ljava/lang/Long;", true, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Long), "valueOf", "(Ljava/lang/String;)Ljava/lang/Long;", true, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Long), "valueOf", "(Ljava/lang/String;I)Ljava/lang/Long;", true, false, false );
        }
    
        public const int        BYTES = 8;
        public const long       MAX_VALUE = 9223372036854775807L;
        public const long       MIN_VALUE = -9223372036854775808L;
        public const int        SIZE = 64;
        public static global::Java.Lang.Class TYPE
        {
            get
            {
                return (global::Java.Lang.Class)_cmj_fldTYPE.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Long( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        Long( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        public Long(long value) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                JObject = (long)_cmj_ctr0.CallObject( this, cmj_jmargs );
            }
        }
    
        public Long(string s) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                JObject = (long)_cmj_ctr1.CallObject( this, cmj_jmargs );
            }
        }
    
    
        /// <summary>Returns an instance of type Long if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.Long</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Long From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Long(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public static int BitCount(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun0.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static int Compare(long x, long y)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x).Add(y) )
            {
                return _cmj_fun1.CallInt( null, cmj_jmargs );
            }
        }    
    
        public int CompareTo(object anotherLong)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(anotherLong) )
            {
                return _cmj_fun2.CallInt( this, cmj_jmargs );
            }
        }    
    
        public static int CompareUnsigned(long x, long y)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x).Add(y) )
            {
                return _cmj_fun3.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static global::Java.Lang.Long Decode(string nm)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nm) )
            {
                long    jnet_ref = (long)_cmj_fun4.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Long( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static long DivideUnsigned(long dividend, long divisor)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(dividend).Add(divisor) )
            {
                return _cmj_fun5.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static global::Java.Lang.Long GetLong(string nm)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nm) )
            {
                long    jnet_ref = (long)_cmj_fun6.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Long( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Lang.Long GetLong(string nm, long val)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nm).Add(val) )
            {
                long    jnet_ref = (long)_cmj_fun7.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Long( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Lang.Long GetLong(string nm, global::Java.Lang.Long val)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nm).Add(val) )
            {
                long    jnet_ref = (long)_cmj_fun8.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Long( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static int HashCode(long value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                return _cmj_fun9.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static long HighestOneBit(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun10.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long LowestOneBit(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun11.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long Max(long a, long b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(a).Add(b) )
            {
                return _cmj_fun12.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long Min(long a, long b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(a).Add(b) )
            {
                return _cmj_fun13.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static int NumberOfLeadingZeros(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun14.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static int NumberOfTrailingZeros(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun15.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static long ParseLong(string s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                return _cmj_fun16.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long ParseLong(string s, int radix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s).Add(radix) )
            {
                return _cmj_fun17.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long ParseUnsignedLong(string s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                return _cmj_fun18.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long ParseUnsignedLong(string s, int radix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s).Add(radix) )
            {
                return _cmj_fun19.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long RemainderUnsigned(long dividend, long divisor)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(dividend).Add(divisor) )
            {
                return _cmj_fun20.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long Reverse(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun21.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long ReverseBytes(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun22.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long RotateLeft(long i, int distance)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i).Add(distance) )
            {
                return _cmj_fun23.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static long RotateRight(long i, int distance)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i).Add(distance) )
            {
                return _cmj_fun24.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static int Signum(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun25.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static long Sum(long a, long b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(a).Add(b) )
            {
                return _cmj_fun26.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static string ToBinaryString(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun27.CallString( null, cmj_jmargs );
            }
        }    
    
        public static string ToHexString(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun28.CallString( null, cmj_jmargs );
            }
        }    
    
        public static string ToOctalString(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun29.CallString( null, cmj_jmargs );
            }
        }    
    
        public static string ToString(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun30.CallString( null, cmj_jmargs );
            }
        }    
    
        public static string ToString(long i, int radix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i).Add(radix) )
            {
                return _cmj_fun31.CallString( null, cmj_jmargs );
            }
        }    
    
        public static string ToUnsignedString(long i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun32.CallString( null, cmj_jmargs );
            }
        }    
    
        public static string ToUnsignedString(long i, int radix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i).Add(radix) )
            {
                return _cmj_fun33.CallString( null, cmj_jmargs );
            }
        }    
    
        public static global::Java.Lang.Long ValueOf(long l)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(l) )
            {
                long    jnet_ref = (long)_cmj_fun34.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Long( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Lang.Long ValueOf(string s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                long    jnet_ref = (long)_cmj_fun35.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Long( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Lang.Long ValueOf(string s, int radix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s).Add(radix) )
            {
                long    jnet_ref = (long)_cmj_fun36.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Long( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
    
    }

}
