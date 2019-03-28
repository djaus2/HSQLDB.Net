/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.DriverPropertyInfo
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("19C3D1F7-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.DriverPropertyInfo")]
    public class DriverPropertyInfo :
        global::Java.Lang.Object
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldChoices;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldDescription;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldName;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldRequired;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldValue;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_ctr0;
    
        static DriverPropertyInfo()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.DriverPropertyInfo", typeof(global::Java.Sql.DriverPropertyInfo));
            _cmj_fldChoices = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Lang.StringArray), "choices", "[Ljava/lang/String;", false, false );
            _cmj_fldDescription = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(string), "description", "Ljava/lang/String;", false, false );
            _cmj_fldName = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(string), "name", "Ljava/lang/String;", false, false );
            _cmj_fldRequired = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(bool), "required", "Z", false, false );
            _cmj_fldValue = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(string), "value", "Ljava/lang/String;", false, false );
            _cmj_ctr0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.DriverPropertyInfo), "<init>", "(Ljava/lang/String;Ljava/lang/String;)V", false );
        }
    
        public global::Java.Lang.StringArray Choices
        {
            get
            {
                return (global::Java.Lang.StringArray)_cmj_fldChoices.Get_object(this);
            }
            set
            {
                _cmj_fldChoices.Set_object(this, value);
            }
        }
        
        public string           Description
        {
            get
            {
                return (string)_cmj_fldDescription.Get_object(this);
            }
            set
            {
                _cmj_fldDescription.Set_object(this, value);
            }
        }
        
        public string           Name
        {
            get
            {
                return (string)_cmj_fldName.Get_object(this);
            }
            set
            {
                _cmj_fldName.Set_object(this, value);
            }
        }
        
        public bool             Required
        {
            get
            {
                return _cmj_fldRequired.Get_bool(this);
            }
            set
            {
                _cmj_fldRequired.Set_bool(this, value);
            }
        }
        
        public string           Value
        {
            get
            {
                return (string)_cmj_fldValue.Get_object(this);
            }
            set
            {
                _cmj_fldValue.Set_object(this, value);
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public DriverPropertyInfo( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        public DriverPropertyInfo(string name, string value) : base( global::Codemesh.JuggerNET.JNIHandle.NULL )
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(value) )
            {
                JObject = (long)_cmj_ctr0.CallObject( this, cmj_jmargs );
            }
        }
    
    
        /// <summary>Returns an instance of type DriverPropertyInfo if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.DriverPropertyInfo</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.DriverPropertyInfo From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.DriverPropertyInfo(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
    
    }
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="[Ljava/sql/DriverPropertyInfo;")]
    public sealed class DriverPropertyInfoArray :
        global::Codemesh.JuggerNET.JuggerNETProxyArray,
        global::Java.Lang.Cloneable,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theElementClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod  _cmj_theCtor;
    
        static DriverPropertyInfoArray()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("[Ljava/sql/DriverPropertyInfo;", typeof(global::Java.Sql.DriverPropertyInfoArray));
            _cmj_theCtor = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.DriverPropertyInfoArray), "<arrinit>", "L", false );
            _cmj_theElementClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.DriverPropertyInfo", typeof(global::Java.Sql.DriverPropertyInfo));
        }
    
        ///<summary>The constructor taking a dimension as an argument.</summary>
        ///<remarks>Use this constructor where you would normally declare a native array.
        ///instance using rectangular brackets (i.e. ClassArray[ 25 ];).
        /// This constructor will create an empty (null-initialized) array with space for
        /// the given number of elements.</remarks>
        /// <param name="size"> the number of elements that can be stored in the array (the dimension)</param>
        public DriverPropertyInfoArray(int size) : base(_cmj_theCtor, _cmj_theElementClass, size) {}
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobject"> The JNI object handle.</param>
        public DriverPropertyInfoArray( global::Codemesh.JuggerNET.JNIHandle jobject) : base(jobject) {}
    
    
        /// <summary>Creates a proxy array from a native array</summary>
        /// <param name="arr">the native array instance.</param>
        public DriverPropertyInfoArray(global::Java.Sql.DriverPropertyInfo[] arr) : base(_cmj_theCtor, _cmj_theElementClass, arr.Length)
        {
            int iMax = arr.Length;
            for (int i = 0; i < iMax; i++)
                SetElement(i, (DriverPropertyInfo)arr[i]);
        }
    
    
        /// <summary>Conversion operator from native .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use native .NET arrays in places where the
        /// compiler expects proxy array instances. You're better off using proxy arrays if you
        /// are going to use the same native array with Java APIs more than once because the entire.
        /// .NET array has to be converted to a proxy array each time you convert it.
        /// </remarks>
        public static implicit operator DriverPropertyInfoArray(global::Java.Sql.DriverPropertyInfo[] arr)
        {
            int iMax = arr.Length;
            DriverPropertyInfoArray a = new DriverPropertyInfoArray(iMax);
            for (int i = 0; i < iMax; i++)
                a.SetElement(i, (DriverPropertyInfo)arr[i]);
            return a;
        }
    
    
        /// <summary>Conversion operator from proxy arrays to .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use proxy arrays in places where the
        /// compiler expects native .NET array instances. We declare this operator explicit to prevent
        /// you from using it unintentionally. The performance penalty of unintentionally creating a
        /// .NET array from a proxy array can be significant if you're not planning to use all elements
        /// anyway. 
        /// </remarks>
        public static explicit operator global::Java.Sql.DriverPropertyInfo[](DriverPropertyInfoArray arr)
        {
            global::Java.Sql.DriverPropertyInfo[] a = new global::Java.Sql.DriverPropertyInfo[ arr.Length ];
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
        public static DriverPropertyInfoArray From(global::Codemesh.JuggerNET.JavaProxy proxy)
        {
            if (_cmj_theClass.IsTypeOf(proxy))
                return new DriverPropertyInfoArray(new global::Codemesh.JuggerNET.JNIHandle(proxy.JObjectDuplicate));
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
            get { return typeof(DriverPropertyInfo); }
        }
    
        ///<summary>The index operator allowing access to the array's elements.</summary>
        public DriverPropertyInfo this[ int index ]
        {
            get
            {
                return (DriverPropertyInfo)GetElement( ElementType, index );
            }
            set
            {
                SetElement( index, value ); global::System.GC.KeepAlive( this ); global::System.GC.KeepAlive( value );
            }
        }
    }
    
    
    

}
