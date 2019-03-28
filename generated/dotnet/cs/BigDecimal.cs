/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.math.BigDecimal
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Math
{
    [global::System.Runtime.InteropServices.GuidAttribute("7C923D2B-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.math.BigDecimal")]
    public class BigDecimal :
        global::Java.Lang.Number,
        global::Java.Lang.Comparable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldONE;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldTEN;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldZERO;
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
    
        static BigDecimal()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.math.BigDecimal", typeof(global::Java.Math.BigDecimal));
            _cmj_fldONE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "ONE", "Ljava/math/BigDecimal;", true, true );
            _cmj_fldTEN = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "TEN", "Ljava/math/BigDecimal;", true, true );
            _cmj_fldZERO = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "ZERO", "Ljava/math/BigDecimal;", true, true );
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "<init>", "(D)V", false );
            _cmj_ctr1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "<init>", "(I)V", false );
            _cmj_ctr2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "<init>", "(J)V", false );
            _cmj_ctr3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "<init>", "(Ljava/lang/String;)V", false );
            _cmj_ctr4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "<init>", "([C)V", false );
            _cmj_ctr5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "<init>", "([CII)V", false );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "abs", "()Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "add", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(byte), "byteValueExact", "()B", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compareTo", "(Ljava/math/BigDecimal;)I", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "divide", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "divide", "(Ljava/math/BigDecimal;I)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "divide", "(Ljava/math/BigDecimal;II)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimalArray), "divideAndRemainder", "(Ljava/math/BigDecimal;)[Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "divideToIntegralValue", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "intValueExact", "()I", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "longValueExact", "()J", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "max", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "min", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "movePointLeft", "(I)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "movePointRight", "(I)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "multiply", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "negate", "()Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "plus", "()Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "pow", "(I)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "precision", "()I", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "remainder", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "scale", "()I", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "scaleByPowerOfTen", "(I)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "setScale", "(I)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "setScale", "(II)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "shortValueExact", "()S", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "signum", "()I", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "stripTrailingZeros", "()Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "subtract", "(Ljava/math/BigDecimal;)Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toEngineeringString", "()Ljava/lang/String;", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toPlainString", "()Ljava/lang/String;", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "ulp", "()Ljava/math/BigDecimal;", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "valueOf", "(D)Ljava/math/BigDecimal;", true, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "valueOf", "(J)Ljava/math/BigDecimal;", true, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimal), "valueOf", "(JI)Ljava/math/BigDecimal;", true, false, false );
        }
    
        public const int        ROUND_CEILING = 2;
        public const int        ROUND_DOWN = 1;
        public const int        ROUND_FLOOR = 3;
        public const int        ROUND_HALF_DOWN = 5;
        public const int        ROUND_HALF_EVEN = 6;
        public const int        ROUND_HALF_UP = 4;
        public const int        ROUND_UNNECESSARY = 7;
        public const int        ROUND_UP = 0;
        public static global::Java.Math.BigDecimal ONE
        {
            get
            {
                return (global::Java.Math.BigDecimal)_cmj_fldONE.Get_object();
            }
        }
        
        public static global::Java.Math.BigDecimal TEN
        {
            get
            {
                return (global::Java.Math.BigDecimal)_cmj_fldTEN.Get_object();
            }
        }
        
        public static global::Java.Math.BigDecimal ZERO
        {
            get
            {
                return (global::Java.Math.BigDecimal)_cmj_fldZERO.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public BigDecimal( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        protected BigDecimal( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        public BigDecimal(double val) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(val) )
            {
                JObject = (long)_cmj_ctr0.CallObject( this, cmj_jmargs );
            }
        }
    
        public BigDecimal(int val) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(val) )
            {
                JObject = (long)_cmj_ctr1.CallObject( this, cmj_jmargs );
            }
        }
    
        public BigDecimal(long val) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(val) )
            {
                JObject = (long)_cmj_ctr2.CallObject( this, cmj_jmargs );
            }
        }
    
        public BigDecimal(string val) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(val) )
            {
                JObject = (long)_cmj_ctr3.CallObject( this, cmj_jmargs );
            }
        }
    
        public BigDecimal(global::Codemesh.JuggerNET.charArray in_) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(in_) )
            {
                JObject = (long)_cmj_ctr4.CallObject( this, cmj_jmargs );
            }
        }
    
        public BigDecimal(global::Codemesh.JuggerNET.charArray in_, int offset, int len) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(in_).Add(offset).Add(len) )
            {
                JObject = (long)_cmj_ctr5.CallObject( this, cmj_jmargs );
            }
        }
    
    
        /// <summary>Returns an instance of type BigDecimal if the given proxy instance
        /// represents a Java object that is type-compatible with java.math.BigDecimal</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Math.BigDecimal From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Math.BigDecimal(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public global::Java.Math.BigDecimal Abs()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Math.BigDecimal)_cmj_fun0.CallObject( this, typeof(global::Java.Math.BigDecimal), false );
        
        }    
    
        public global::Java.Math.BigDecimal Add(global::Java.Math.BigDecimal augend)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(augend) )
            {
                if(_cmj_fun1.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun1.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun1.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public byte ByteValueExact()
        {
            return _cmj_fun2.CallByte( this );
        }    
    
        public int CompareTo(object val)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(val) )
            {
                return _cmj_fun3.CallInt( this, cmj_jmargs );
            }
        }    
    
        public global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal divisor)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(divisor) )
            {
                if(_cmj_fun4.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun4.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun4.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal divisor, int roundingMode)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(divisor).Add(roundingMode) )
            {
                if(_cmj_fun5.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun5.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun5.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal Divide(global::Java.Math.BigDecimal divisor, int scale, int roundingMode)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(divisor).Add(scale).Add(roundingMode) )
            {
                if(_cmj_fun6.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun6.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun6.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimalArray DivideAndRemainder(global::Java.Math.BigDecimal divisor)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(divisor) )
            {
                if(_cmj_fun7.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun7.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimalArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimalArray)_cmj_fun7.CallObject( this, typeof(global::Java.Math.BigDecimalArray), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal DivideToIntegralValue(global::Java.Math.BigDecimal divisor)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(divisor) )
            {
                if(_cmj_fun8.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun8.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun8.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public int IntValueExact()
        {
            return _cmj_fun9.CallInt( this );
        }    
    
        public long LongValueExact()
        {
            return _cmj_fun10.CallLong( this );
        }    
    
        public global::Java.Math.BigDecimal Max(global::Java.Math.BigDecimal val)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(val) )
            {
                if(_cmj_fun11.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun11.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun11.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal Min(global::Java.Math.BigDecimal val)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(val) )
            {
                if(_cmj_fun12.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun12.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun12.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal MovePointLeft(int n)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(n) )
            {
                if(_cmj_fun13.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun13.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun13.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal MovePointRight(int n)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(n) )
            {
                if(_cmj_fun14.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun14.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun14.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal Multiply(global::Java.Math.BigDecimal multiplicand)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(multiplicand) )
            {
                if(_cmj_fun15.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun15.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun15.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal Negate()
        {
            if(_cmj_fun16.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun16.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Math.BigDecimal)_cmj_fun16.CallObject( this, typeof(global::Java.Math.BigDecimal), false );
        
        }    
    
        public global::Java.Math.BigDecimal Plus()
        {
            if(_cmj_fun17.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun17.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Math.BigDecimal)_cmj_fun17.CallObject( this, typeof(global::Java.Math.BigDecimal), false );
        
        }    
    
        public global::Java.Math.BigDecimal Pow(int n)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(n) )
            {
                if(_cmj_fun18.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun18.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun18.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public int Precision()
        {
            return _cmj_fun19.CallInt( this );
        }    
    
        public global::Java.Math.BigDecimal Remainder(global::Java.Math.BigDecimal divisor)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(divisor) )
            {
                if(_cmj_fun20.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun20.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun20.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public int Scale()
        {
            return _cmj_fun21.CallInt( this );
        }    
    
        public global::Java.Math.BigDecimal ScaleByPowerOfTen(int n)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(n) )
            {
                if(_cmj_fun22.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun22.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun22.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal SetScale(int newScale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(newScale) )
            {
                if(_cmj_fun23.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun23.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun23.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Math.BigDecimal SetScale(int newScale, int roundingMode)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(newScale).Add(roundingMode) )
            {
                if(_cmj_fun24.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun24.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun24.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public short ShortValueExact()
        {
            return _cmj_fun25.CallShort( this );
        }    
    
        public int Signum()
        {
            return _cmj_fun26.CallInt( this );
        }    
    
        public global::Java.Math.BigDecimal StripTrailingZeros()
        {
            if(_cmj_fun27.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun27.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Math.BigDecimal)_cmj_fun27.CallObject( this, typeof(global::Java.Math.BigDecimal), false );
        
        }    
    
        public global::Java.Math.BigDecimal Subtract(global::Java.Math.BigDecimal subtrahend)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(subtrahend) )
            {
                if(_cmj_fun28.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun28.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun28.CallObject( this, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public string ToEngineeringString()
        {
            return _cmj_fun29.CallString( this );
        }    
    
        public string ToPlainString()
        {
            return _cmj_fun30.CallString( this );
        }    
    
        public global::Java.Math.BigDecimal Ulp()
        {
            if(_cmj_fun31.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun31.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Math.BigDecimal)_cmj_fun31.CallObject( this, typeof(global::Java.Math.BigDecimal), false );
        
        }    
    
        public static global::Java.Math.BigDecimal ValueOf(double val)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(val) )
            {
                if(_cmj_fun32.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun32.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun32.CallObject( null, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public static global::Java.Math.BigDecimal ValueOf(long val)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(val) )
            {
                if(_cmj_fun33.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun33.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun33.CallObject( null, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
        public static global::Java.Math.BigDecimal ValueOf(long unscaledVal, int scale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(unscaledVal).Add(scale) )
            {
                if(_cmj_fun34.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun34.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Math.BigDecimal( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Math.BigDecimal)_cmj_fun34.CallObject( null, typeof(global::Java.Math.BigDecimal), false, cmj_jmargs );
        
            }
        }    
    
    
    }
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="[Ljava/math/BigDecimal;")]
    public sealed class BigDecimalArray :
        global::Codemesh.JuggerNET.JuggerNETProxyArray,
        global::Java.Lang.Cloneable,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theElementClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod  _cmj_theCtor;
    
        static BigDecimalArray()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("[Ljava/math/BigDecimal;", typeof(global::Java.Math.BigDecimalArray));
            _cmj_theCtor = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Math.BigDecimalArray), "<arrinit>", "L", false );
            _cmj_theElementClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.math.BigDecimal", typeof(global::Java.Math.BigDecimal));
        }
    
        ///<summary>The constructor taking a dimension as an argument.</summary>
        ///<remarks>Use this constructor where you would normally declare a native array.
        ///instance using rectangular brackets (i.e. ClassArray[ 25 ];).
        /// This constructor will create an empty (null-initialized) array with space for
        /// the given number of elements.</remarks>
        /// <param name="size"> the number of elements that can be stored in the array (the dimension)</param>
        public BigDecimalArray(int size) : base(_cmj_theCtor, _cmj_theElementClass, size) {}
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobject"> The JNI object handle.</param>
        public BigDecimalArray( global::Codemesh.JuggerNET.JNIHandle jobject) : base(jobject) {}
    
    
        /// <summary>Creates a proxy array from a native array</summary>
        /// <param name="arr">the native array instance.</param>
        public BigDecimalArray(global::Java.Math.BigDecimal[] arr) : base(_cmj_theCtor, _cmj_theElementClass, arr.Length)
        {
            int iMax = arr.Length;
            for (int i = 0; i < iMax; i++)
                SetElement(i, (BigDecimal)arr[i]);
        }
    
    
        /// <summary>Conversion operator from native .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use native .NET arrays in places where the
        /// compiler expects proxy array instances. You're better off using proxy arrays if you
        /// are going to use the same native array with Java APIs more than once because the entire.
        /// .NET array has to be converted to a proxy array each time you convert it.
        /// </remarks>
        public static implicit operator BigDecimalArray(global::Java.Math.BigDecimal[] arr)
        {
            int iMax = arr.Length;
            BigDecimalArray a = new BigDecimalArray(iMax);
            for (int i = 0; i < iMax; i++)
                a.SetElement(i, (BigDecimal)arr[i]);
            return a;
        }
    
    
        /// <summary>Conversion operator from proxy arrays to .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use proxy arrays in places where the
        /// compiler expects native .NET array instances. We declare this operator explicit to prevent
        /// you from using it unintentionally. The performance penalty of unintentionally creating a
        /// .NET array from a proxy array can be significant if you're not planning to use all elements
        /// anyway. 
        /// </remarks>
        public static explicit operator global::Java.Math.BigDecimal[](BigDecimalArray arr)
        {
            global::Java.Math.BigDecimal[] a = new global::Java.Math.BigDecimal[ arr.Length ];
            int  length = arr.Length;
            for( int i = 0; i < length; i++ )
                a[ i ] = arr[ i ];
            return a;
        }
        
    
        /// <summary>Casts another proxy object to this type if possible.
        /// <para>You rarely need this method. It is only required when you have for example
        /// an array proxy type that is type compatible on the Java side but not on the .NET side.</para>
        /// <para>A good example would be the <c>String[][]</c> and <c>Object[]</c> types in Java.
        /// The two-dimensional String array IS also a one-dimensional Object array in Java, but we cannot
        /// duplicate this behavior through inheritance in .NET.  For that reason, we provide you with this
        /// method, allowing you to take for exmaple a <c>StringArrayArray</c> object and use it to create
        /// an <c>ObjectArray</c> instance when you need to.</para></summary>
        public static BigDecimalArray From(global::Codemesh.JuggerNET.JavaProxy proxy)
        {
            if (_cmj_theClass.IsTypeOf(proxy))
                return new BigDecimalArray(new global::Codemesh.JuggerNET.JNIHandle(proxy.JObjectDuplicate));
            else
                return null;
        }
    
    
        ///<summary>A read-only property for the array's rank (number of dimensions).</summary>
        public override int Rank
        {
            get { return 1; }
        }
    
    
        ///<summary>A read-only property for the array's element type.</summary>
        public override global::System.Type ElementType
        {
            get { return typeof(BigDecimal); }
        }
    
        ///<summary>The index operator allowing access to the array's elements.</summary>
        public BigDecimal this[ int index ]
        {
            get
            {
                return (BigDecimal)GetElement( ElementType, index );
            }
            set
            {
                SetElement( index, value ); global::System.GC.KeepAlive( this ); global::System.GC.KeepAlive( value );
            }
        }
    }
    
    
    

}
