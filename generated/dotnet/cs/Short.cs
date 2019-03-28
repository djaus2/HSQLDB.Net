/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.Short
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang
{
    [global::System.Runtime.InteropServices.GuidAttribute("1CA327A8-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.Short")]
    public sealed class Short :
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
    
        static Short()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.Short", typeof(global::Java.Lang.Short));
            _cmj_fldTYPE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Lang.Class), "TYPE", "Ljava/lang/Class;", true, true );
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Short), "<init>", "(Ljava/lang/String;)V", false );
            _cmj_ctr1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Short), "<init>", "(S)V", false );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compare", "(SS)I", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compareTo", "(Ljava/lang/Short;)I", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Short), "decode", "(Ljava/lang/String;)Ljava/lang/Short;", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "hashCode", "(S)I", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "parseShort", "(Ljava/lang/String;)S", true, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "parseShort", "(Ljava/lang/String;I)S", true, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "reverseBytes", "(S)S", true, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toString", "(S)Ljava/lang/String;", true, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "toUnsignedInt", "(S)I", true, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "toUnsignedLong", "(S)J", true, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Short), "valueOf", "(Ljava/lang/String;)Ljava/lang/Short;", true, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Short), "valueOf", "(S)Ljava/lang/Short;", true, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Short), "valueOf", "(Ljava/lang/String;I)Ljava/lang/Short;", true, false, false );
        }
    
        public const int        BYTES = 2;
        public const short      MAX_VALUE = 32767;
        public const short      MIN_VALUE = -32768;
        public const int        SIZE = 16;
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
        public Short( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        Short( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        public Short(string s) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                JObject = (long)_cmj_ctr0.CallObject( this, cmj_jmargs );
            }
        }
    
        public Short(short value) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                JObject = (long)_cmj_ctr1.CallObject( this, cmj_jmargs );
            }
        }
    
    
        /// <summary>Returns an instance of type Short if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.Short</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Short From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Short(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public static int Compare(short x, short y)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x).Add(y) )
            {
                return _cmj_fun0.CallInt( null, cmj_jmargs );
            }
        }    
    
        public int CompareTo(object anotherShort)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(anotherShort) )
            {
                return _cmj_fun1.CallInt( this, cmj_jmargs );
            }
        }    
    
        public static global::Java.Lang.Short Decode(string nm)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(nm) )
            {
                long    jnet_ref = (long)_cmj_fun2.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Short( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static int HashCode(short value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                return _cmj_fun3.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static short ParseShort(string s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                return _cmj_fun4.CallShort( null, cmj_jmargs );
            }
        }    
    
        public static short ParseShort(string s, int radix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s).Add(radix) )
            {
                return _cmj_fun5.CallShort( null, cmj_jmargs );
            }
        }    
    
        public static short ReverseBytes(short i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(i) )
            {
                return _cmj_fun6.CallShort( null, cmj_jmargs );
            }
        }    
    
        public static string ToString(short s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                return _cmj_fun7.CallString( null, cmj_jmargs );
            }
        }    
    
        public static int ToUnsignedInt(short x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                return _cmj_fun8.CallInt( null, cmj_jmargs );
            }
        }    
    
        public static long ToUnsignedLong(short x)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(x) )
            {
                return _cmj_fun9.CallLong( null, cmj_jmargs );
            }
        }    
    
        public static global::Java.Lang.Short ValueOf(string s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                long    jnet_ref = (long)_cmj_fun10.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Short( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Lang.Short ValueOf(short s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s) )
            {
                long    jnet_ref = (long)_cmj_fun11.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Short( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Lang.Short ValueOf(string s, int radix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(s).Add(radix) )
            {
                long    jnet_ref = (long)_cmj_fun12.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Short( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
    
    }

}
