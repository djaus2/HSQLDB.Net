/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.PseudoColumnUsage
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("64A32441-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.PseudoColumnUsage")]
    public sealed class PseudoColumnUsage :
        global::Java.Lang.Enum,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldNO_USAGE_RESTRICTIONS;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldSELECT_LIST_ONLY;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldUSAGE_UNKNOWN;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldWHERE_CLAUSE_ONLY;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
    
        static PseudoColumnUsage()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.PseudoColumnUsage", typeof(global::Java.Sql.PseudoColumnUsage));
            _cmj_fldNO_USAGE_RESTRICTIONS = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.PseudoColumnUsage), "NO_USAGE_RESTRICTIONS", "Ljava/sql/PseudoColumnUsage;", true, true );
            _cmj_fldSELECT_LIST_ONLY = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.PseudoColumnUsage), "SELECT_LIST_ONLY", "Ljava/sql/PseudoColumnUsage;", true, true );
            _cmj_fldUSAGE_UNKNOWN = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.PseudoColumnUsage), "USAGE_UNKNOWN", "Ljava/sql/PseudoColumnUsage;", true, true );
            _cmj_fldWHERE_CLAUSE_ONLY = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.PseudoColumnUsage), "WHERE_CLAUSE_ONLY", "Ljava/sql/PseudoColumnUsage;", true, true );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.PseudoColumnUsage), "valueOf", "(Ljava/lang/String;)Ljava/sql/PseudoColumnUsage;", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.PseudoColumnUsageArray), "values", "()[Ljava/sql/PseudoColumnUsage;", true, false, false );
        }
    
        public static global::Java.Sql.PseudoColumnUsage NO_USAGE_RESTRICTIONS
        {
            get
            {
                return (global::Java.Sql.PseudoColumnUsage)_cmj_fldNO_USAGE_RESTRICTIONS.Get_object();
            }
        }
        
        public static global::Java.Sql.PseudoColumnUsage SELECT_LIST_ONLY
        {
            get
            {
                return (global::Java.Sql.PseudoColumnUsage)_cmj_fldSELECT_LIST_ONLY.Get_object();
            }
        }
        
        public static global::Java.Sql.PseudoColumnUsage USAGE_UNKNOWN
        {
            get
            {
                return (global::Java.Sql.PseudoColumnUsage)_cmj_fldUSAGE_UNKNOWN.Get_object();
            }
        }
        
        public static global::Java.Sql.PseudoColumnUsage WHERE_CLAUSE_ONLY
        {
            get
            {
                return (global::Java.Sql.PseudoColumnUsage)_cmj_fldWHERE_CLAUSE_ONLY.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public PseudoColumnUsage( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        PseudoColumnUsage( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type PseudoColumnUsage if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.PseudoColumnUsage</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.PseudoColumnUsage From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.PseudoColumnUsage(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public static global::Java.Sql.PseudoColumnUsage ValueOf(string arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Sql.PseudoColumnUsage( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Sql.PseudoColumnUsageArray Values()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Sql.PseudoColumnUsageArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.PseudoColumnUsageArray)_cmj_fun1.CallObject( null, typeof(global::Java.Sql.PseudoColumnUsageArray), false );
        
        }    
    
    
    }
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="[Ljava/sql/PseudoColumnUsage;")]
    public sealed class PseudoColumnUsageArray :
        global::Codemesh.JuggerNET.JuggerNETProxyArray,
        global::Java.Lang.Cloneable,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theElementClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod  _cmj_theCtor;
    
        static PseudoColumnUsageArray()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("[Ljava/sql/PseudoColumnUsage;", typeof(global::Java.Sql.PseudoColumnUsageArray));
            _cmj_theCtor = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.PseudoColumnUsageArray), "<arrinit>", "L", false );
            _cmj_theElementClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.PseudoColumnUsage", typeof(global::Java.Sql.PseudoColumnUsage));
        }
    
        ///<summary>The constructor taking a dimension as an argument.</summary>
        ///<remarks>Use this constructor where you would normally declare a native array.
        ///instance using rectangular brackets (i.e. ClassArray[ 25 ];).
        /// This constructor will create an empty (null-initialized) array with space for
        /// the given number of elements.</remarks>
        /// <param name="size"> the number of elements that can be stored in the array (the dimension)</param>
        public PseudoColumnUsageArray(int size) : base(_cmj_theCtor, _cmj_theElementClass, size) {}
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobject"> The JNI object handle.</param>
        public PseudoColumnUsageArray( global::Codemesh.JuggerNET.JNIHandle jobject) : base(jobject) {}
    
    
        /// <summary>Creates a proxy array from a native array</summary>
        /// <param name="arr">the native array instance.</param>
        public PseudoColumnUsageArray(global::Java.Sql.PseudoColumnUsage[] arr) : base(_cmj_theCtor, _cmj_theElementClass, arr.Length)
        {
            int iMax = arr.Length;
            for (int i = 0; i < iMax; i++)
                SetElement(i, (PseudoColumnUsage)arr[i]);
        }
    
    
        /// <summary>Conversion operator from native .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use native .NET arrays in places where the
        /// compiler expects proxy array instances. You're better off using proxy arrays if you
        /// are going to use the same native array with Java APIs more than once because the entire.
        /// .NET array has to be converted to a proxy array each time you convert it.
        /// </remarks>
        public static implicit operator PseudoColumnUsageArray(global::Java.Sql.PseudoColumnUsage[] arr)
        {
            int iMax = arr.Length;
            PseudoColumnUsageArray a = new PseudoColumnUsageArray(iMax);
            for (int i = 0; i < iMax; i++)
                a.SetElement(i, (PseudoColumnUsage)arr[i]);
            return a;
        }
    
    
        /// <summary>Conversion operator from proxy arrays to .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use proxy arrays in places where the
        /// compiler expects native .NET array instances. We declare this operator explicit to prevent
        /// you from using it unintentionally. The performance penalty of unintentionally creating a
        /// .NET array from a proxy array can be significant if you're not planning to use all elements
        /// anyway. 
        /// </remarks>
        public static explicit operator global::Java.Sql.PseudoColumnUsage[](PseudoColumnUsageArray arr)
        {
            global::Java.Sql.PseudoColumnUsage[] a = new global::Java.Sql.PseudoColumnUsage[ arr.Length ];
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
        public static PseudoColumnUsageArray From(global::Codemesh.JuggerNET.JavaProxy proxy)
        {
            if (_cmj_theClass.IsTypeOf(proxy))
                return new PseudoColumnUsageArray(new global::Codemesh.JuggerNET.JNIHandle(proxy.JObjectDuplicate));
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
            get { return typeof(PseudoColumnUsage); }
        }
    
        ///<summary>The index operator allowing access to the array's elements.</summary>
        public PseudoColumnUsage this[ int index ]
        {
            get
            {
                global::Codemesh.JuggerNET.JNIHandle h = GetElement( index );
                return !h ? null : new PseudoColumnUsage( h );
            }
            set
            {
                SetElement( index, value ); global::System.GC.KeepAlive( this ); global::System.GC.KeepAlive( value );
            }
        }
    }
    
    
    

}
