/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.Number
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang
{
    [global::System.Runtime.InteropServices.GuidAttribute("6FEF9D9D-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.lang.Number")]
    public abstract class Number :
        global::Java.Io.SerializableImpl,
        global::System.IConvertible,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
    
        static Number()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.Number", typeof(global::Java.Lang.Number), typeof(global::Java.Lang.Number.NumberImpl), null);
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Number), "<init>", "()V", false );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(byte), "byteValue", "()B", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(double), "doubleValue", "()D", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(float), "floatValue", "()F", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "intValue", "()I", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "longValue", "()J", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "shortValue", "()S", false, false, false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Number( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        protected Number( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        public Number() : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            JObject = (long)_cmj_ctr0.CallObject( this );
        }
    
    
        /// <summary>Returns an instance of type Number if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.Number</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Number From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Number.NumberImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
    
    
        public static explicit  operator double(Number rhs)
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToDoubleValue( rhs );
        }
    
    
        public static explicit  operator float(Number rhs)
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToSingleValue( rhs );
        }
    
    
        public static explicit  operator int(Number rhs)
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToIntegerValue( rhs );
        }
    
    
        public static explicit  operator long(Number rhs)
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToLongValue( rhs );
        }
    
    
        public static explicit  operator short(Number rhs)
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToShortValue( rhs );
        }
    
    
    
        public byte ByteValue()
        {
            return _cmj_fun0.CallByte( this );
        }    
    
        public double DoubleValue()
        {
            return _cmj_fun1.CallDouble( this );
        }    
    
        public float FloatValue()
        {
            return _cmj_fun2.CallFloat( this );
        }    
    
        public int IntValue()
        {
            return _cmj_fun3.CallInt( this );
        }    
    
        public long LongValue()
        {
            return _cmj_fun4.CallLong( this );
        }    
    
        public short ShortValue()
        {
            return _cmj_fun5.CallShort( this );
        }    
    
        /// <summary>Returns the object's typecode.</summary>
        global::System.TypeCode global::System.IConvertible.GetTypeCode()
        {
            return global::System.TypeCode.Object;
        }
    
    
        /// <summary>Returns the object's boolean representation.</summary>
        bool    global::System.IConvertible.ToBoolean( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToBoolean( global::Codemesh.JuggerNET.NativeInterface.ToIntegerValue( this ) );
        }
    
    
        /// <summary>Returns the object's byte representation.</summary>
        byte    global::System.IConvertible.ToByte( global::System.IFormatProvider formatProvider )
        {
            return (byte)global::Codemesh.JuggerNET.NativeInterface.ToIntegerValue( this );
        }
    
    
        /// <summary>Returns the object's char representation.</summary>
        char    global::System.IConvertible.ToChar( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToChar( global::Codemesh.JuggerNET.NativeInterface.ToIntegerValue( this ) );
        }
    
    
        /// <summary>Returns the object's DateTime representation.</summary>
        global::System.DateTime    global::System.IConvertible.ToDateTime( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's Decimal representation.</summary>
        global::System.Decimal    global::System.IConvertible.ToDecimal( global::System.IFormatProvider formatProvider )
        {
            return new global::System.Decimal( global::Codemesh.JuggerNET.NativeInterface.ToDoubleValue( this ) );
        }
    
    
        /// <summary>Returns the object's double representation.</summary>
        double    global::System.IConvertible.ToDouble( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToDoubleValue( this );
        }
    
    
        /// <summary>Returns the object's Int16 representation.</summary>
        short    global::System.IConvertible.ToInt16( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToShortValue( this );
        }
    
    
        /// <summary>Returns the object's Int32 representation.</summary>
        int    global::System.IConvertible.ToInt32( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToIntegerValue( this );
        }
    
    
        /// <summary>Returns the object's Int64 representation.</summary>
        long    global::System.IConvertible.ToInt64( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToLongValue( this );
        }
    
    
        /// <summary>Returns the object's sbyte representation.</summary>
        sbyte    global::System.IConvertible.ToSByte( global::System.IFormatProvider formatProvider )
        {
            return (sbyte)global::Codemesh.JuggerNET.NativeInterface.ToIntegerValue( this );
        }
    
    
        /// <summary>Returns the object's float representation.</summary>
        float    global::System.IConvertible.ToSingle( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToSingleValue( this );
        }
    
    
        /// <summary>Returns the object's string representation.</summary>
        string    global::System.IConvertible.ToString( global::System.IFormatProvider formatProvider )
        {
            if( this is global::Java.Lang.Float )
                return global::System.Convert.ToString( global::Codemesh.JuggerNET.NativeInterface.ToSingleValue(this), formatProvider );    
            if( this is global::Java.Lang.Double )
                return global::System.Convert.ToString( global::Codemesh.JuggerNET.NativeInterface.ToDoubleValue(this), formatProvider );
            else
            return global::System.Convert.ToString( global::Codemesh.JuggerNET.NativeInterface.ToLongValue(this), formatProvider );
        }
    
    
        /// <summary>Returns the an object of the given type.</summary>
        object    global::System.IConvertible.ToType( global::System.Type type, global::System.IFormatProvider formatProvider )
        {
            if( this is global::Java.Lang.Float )
                return global::System.Convert.ChangeType( global::Codemesh.JuggerNET.NativeInterface.ToSingleValue(this), type );    
            if( this is global::Java.Lang.Double )
                return global::System.Convert.ChangeType( global::Codemesh.JuggerNET.NativeInterface.ToDoubleValue(this), type );
            else
            return global::System.Convert.ChangeType( global::Codemesh.JuggerNET.NativeInterface.ToLongValue(this), type );
        }
    
    
        /// <summary>Returns the object's UInt16 representation.</summary>
        ushort    global::System.IConvertible.ToUInt16( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToUInt16( global::Codemesh.JuggerNET.NativeInterface.ToIntegerValue( this ) );
        }
    
    
        /// <summary>Returns the object's UInt32 representation.</summary>
        uint    global::System.IConvertible.ToUInt32( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToUInt32( global::Codemesh.JuggerNET.NativeInterface.ToLongValue( this ) );
        }
    
    
        /// <summary>Returns the object's UInt64 representation.</summary>
        ulong    global::System.IConvertible.ToUInt64( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToUInt64( global::Codemesh.JuggerNET.NativeInterface.ToLongValue( this ) );
        }
    
        
        
        
        [global::System.Serializable]
        [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.Number")]
        public class NumberImpl :
            global::Java.Lang.Number,
            global::System.Runtime.Serialization.ISerializable
        
        {
        
        
        
            /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
            /// <para>You should never have to use this constructor explicitly. It is a
            /// constructor that is required by the JuggerNET framework.</para></summary>
            /// <param name="jobj"> The JNI object handle.</param>
            public NumberImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
        
        
            ///<summary>Reinflate a serialized object.</summary>
            protected NumberImpl( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
                base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
            {
            }
        
            void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
            {
                global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
            }
        
            /// <summary>Returns an instance of type NumberImpl if the given proxy instance
            /// represents a Java object that is type-compatible with java.lang.Number</summary>
            /// <param name="proxy">A proxy object of any type.</param>
            public static new global::Java.Lang.Number.NumberImpl From( object proxy )
            {
                global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
                if (_cmj_theClass.IsTypeOf(jp))
                    return new global::Java.Lang.Number.NumberImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
                else
                    return null;
            }
        }    
    
    }

}
