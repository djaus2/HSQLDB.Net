/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.Boolean
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:14 EDT 2018
 */


namespace Java.Lang
{
    [global::System.Runtime.InteropServices.GuidAttribute("091CF454-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.Boolean")]
    public sealed class Boolean :
        global::Java.Lang.ComparableImpl,
        global::System.IConvertible,
        global::Java.Io.Serializable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldFALSE;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldTRUE;
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
    
        static Boolean()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.Boolean", typeof(global::Java.Lang.Boolean));
            _cmj_fldFALSE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Lang.Boolean), "FALSE", "Ljava/lang/Boolean;", true, true );
            _cmj_fldTRUE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Lang.Boolean), "TRUE", "Ljava/lang/Boolean;", true, true );
            _cmj_fldTYPE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Lang.Class), "TYPE", "Ljava/lang/Class;", true, true );
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Boolean), "<init>", "(Ljava/lang/String;)V", false );
            _cmj_ctr1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Boolean), "<init>", "(Z)V", false );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "booleanValue", "()Z", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compare", "(ZZ)I", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getBoolean", "(Ljava/lang/String;)Z", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "hashCode", "(Z)I", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "logicalAnd", "(ZZ)Z", true, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "logicalOr", "(ZZ)Z", true, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "logicalXor", "(ZZ)Z", true, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "parseBoolean", "(Ljava/lang/String;)Z", true, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toString", "(Z)Ljava/lang/String;", true, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Boolean), "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;", true, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Boolean), "valueOf", "(Z)Ljava/lang/Boolean;", true, false, false );
        }
    
        public static global::Java.Lang.Boolean FALSE
        {
            get
            {
                return (global::Java.Lang.Boolean)_cmj_fldFALSE.Get_object();
            }
        }
        
        public static global::Java.Lang.Boolean TRUE
        {
            get
            {
                return (global::Java.Lang.Boolean)_cmj_fldTRUE.Get_object();
            }
        }
        
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
        public Boolean( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        Boolean( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        public Boolean(string s) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                JObject = (long)_cmj_ctr0.CallObject( this, cmj_jmargs );
            }
        }
    
        public Boolean(bool value) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                JObject = (long)_cmj_ctr1.CallObject( this, cmj_jmargs );
            }
        }
    
    
        /// <summary>Returns an instance of type Boolean if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.Boolean</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Boolean From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Boolean(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
    
    
        public static explicit  operator bool(Boolean rhs)
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue( rhs );
        }
    
        public bool BooleanValue()
        {
            return _cmj_fun0.CallBool( this );
        }    
    
        public static int Compare(bool x, bool y)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x).Add(y) )
            {
                return _cmj_fun1.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static bool GetBoolean(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                return _cmj_fun2.CallBool( null, cmj_jmargs );
            }
        }    
    
        public static int HashCode(bool value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                return _cmj_fun3.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static bool LogicalAnd(bool a, bool b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(a).Add(b) )
            {
                return _cmj_fun4.CallBool( null, cmj_jmargs );
            }
        }    
    
        public static bool LogicalOr(bool a, bool b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(a).Add(b) )
            {
                return _cmj_fun5.CallBool( null, cmj_jmargs );
            }
        }    
    
        public static bool LogicalXor(bool a, bool b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(a).Add(b) )
            {
                return _cmj_fun6.CallBool( null, cmj_jmargs );
            }
        }    
    
        public static bool ParseBoolean(string s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                return _cmj_fun7.CallBool( null, cmj_jmargs );
            }
        }    
    
        public static string ToString(bool b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(b) )
            {
                return _cmj_fun8.CallString( null, cmj_jmargs );
            }
        }    
    
        public static global::Java.Lang.Boolean ValueOf(string s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                long    jnet_ref = (long)_cmj_fun9.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Boolean( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Lang.Boolean ValueOf(bool b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(b) )
            {
                long    jnet_ref = (long)_cmj_fun10.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Boolean( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        /// <summary>Returns the object's typecode.</summary>
        global::System.TypeCode global::System.IConvertible.GetTypeCode()
        {
            return global::System.TypeCode.Object;
        }
    
    
        /// <summary>Returns the object's boolean representation.</summary>
        bool    global::System.IConvertible.ToBoolean( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this);
        }
    
    
        /// <summary>Returns the object's byte representation.</summary>
        byte    global::System.IConvertible.ToByte( global::System.IFormatProvider formatProvider )
        {
            return (byte)(global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1 : 0);
        }
    
    
        /// <summary>Returns the object's char representation.</summary>
        char    global::System.IConvertible.ToChar( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToChar( global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) );
        }
    
    
        /// <summary>Returns the object's DateTime representation.</summary>
        global::System.DateTime    global::System.IConvertible.ToDateTime( global::System.IFormatProvider formatProvider )
        {
            throw new global::System.InvalidCastException();
        }
    
    
        /// <summary>Returns the object's Decimal representation.</summary>
        global::System.Decimal    global::System.IConvertible.ToDecimal( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToDecimal( global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) );
        }
    
    
        /// <summary>Returns the object's double representation.</summary>
        double    global::System.IConvertible.ToDouble( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1.0 : 0.0;
        }
    
    
        /// <summary>Returns the object's Int16 representation.</summary>
        short    global::System.IConvertible.ToInt16( global::System.IFormatProvider formatProvider )
        {
            return (short)(global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1 : 0);
        }
    
    
        /// <summary>Returns the object's Int32 representation.</summary>
        int    global::System.IConvertible.ToInt32( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1 : 0;
        }
    
    
        /// <summary>Returns the object's Int64 representation.</summary>
        long    global::System.IConvertible.ToInt64( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1 : 0;
        }
    
    
        /// <summary>Returns the object's sbyte representation.</summary>
        sbyte    global::System.IConvertible.ToSByte( global::System.IFormatProvider formatProvider )
        {
            return (sbyte)(global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1 : 0);
        }
    
    
        /// <summary>Returns the object's float representation.</summary>
        float    global::System.IConvertible.ToSingle( global::System.IFormatProvider formatProvider )
        {
            return global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1.0f : 0.0f;
        }
    
    
        /// <summary>Returns the object's string representation.</summary>
        string    global::System.IConvertible.ToString( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToString( global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this), formatProvider );
        }
    
    
        /// <summary>Returns the an object of the given type.</summary>
        object    global::System.IConvertible.ToType( global::System.Type type, global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ChangeType( global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1 : 0, type );
        }
    
    
        /// <summary>Returns the object's UInt16 representation.</summary>
        ushort    global::System.IConvertible.ToUInt16( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToUInt16( global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1 : 0);
        }
    
    
        /// <summary>Returns the object's UInt32 representation.</summary>
        uint    global::System.IConvertible.ToUInt32( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToUInt32( global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1 : 0 );
        }
    
    
        /// <summary>Returns the object's UInt64 representation.</summary>
        ulong    global::System.IConvertible.ToUInt64( global::System.IFormatProvider formatProvider )
        {
            return global::System.Convert.ToUInt64( global::Codemesh.JuggerNET.NativeInterface.ToBooleanValue(this) ? 1 : 0 );
        }
    
    
    
    }

}
