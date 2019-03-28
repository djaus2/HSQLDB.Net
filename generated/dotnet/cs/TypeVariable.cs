/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.reflect.TypeVariable
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang.Reflect
{
    [global::System.Runtime.InteropServices.GuidAttribute("87024EDB-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.lang.reflect.TypeVariable")]
    public interface TypeVariable :
        global::Java.Lang.Reflect.AnnotatedElement,
        global::Java.Lang.Reflect.Type
    { 
        global::Java.Lang.Reflect.AnnotatedTypeArray GetAnnotatedBounds();
    
    
        global::Java.Lang.Reflect.TypeArray GetBounds();
    
    
        global::Java.Lang.Reflect.GenericDeclaration GetGenericDeclaration();
    
    
        string GetName();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.reflect.TypeVariable")]
    public class TypeVariableImpl :
        global::Java.Lang.Reflect.AnnotatedElementImpl,
        global::Java.Lang.Reflect.TypeVariable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
    
        static TypeVariableImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.reflect.TypeVariable", typeof(global::Java.Lang.Reflect.TypeVariable), typeof(global::Java.Lang.Reflect.TypeVariableImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.AnnotatedTypeArray), "getAnnotatedBounds", "()[Ljava/lang/reflect/AnnotatedType;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.TypeArray), "getBounds", "()[Ljava/lang/reflect/Type;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.GenericDeclaration), "getGenericDeclaration", "()Ljava/lang/reflect/GenericDeclaration;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getName", "()Ljava/lang/String;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public TypeVariableImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type TypeVariableImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.reflect.TypeVariable</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Reflect.TypeVariableImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Reflect.TypeVariableImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Java.Lang.Reflect.AnnotatedTypeArray GetAnnotatedBounds()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.AnnotatedTypeArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.AnnotatedTypeArray)_cmj_fun0.CallObject( this, typeof(global::Java.Lang.Reflect.AnnotatedTypeArray), false );
        
        }        
        
        public global::Java.Lang.Reflect.TypeArray GetBounds()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.TypeArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.TypeArray)_cmj_fun1.CallObject( this, typeof(global::Java.Lang.Reflect.TypeArray), false );
        
        }        
        
        public global::Java.Lang.Reflect.GenericDeclaration GetGenericDeclaration()
        {
            if(_cmj_fun2.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun2.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.GenericDeclarationImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.GenericDeclaration)_cmj_fun2.CallObject( this, typeof(global::Java.Lang.Reflect.GenericDeclaration), false );
        
        }        
        
        public string GetName()
        {
            return _cmj_fun3.CallString( this );
        }        
    }    
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="[Ljava/lang/reflect/TypeVariable;")]
    public sealed class TypeVariableArray :
        global::Codemesh.JuggerNET.JuggerNETProxyArray,
        global::Java.Lang.Cloneable,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theElementClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod  _cmj_theCtor;
    
        static TypeVariableArray()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("[Ljava/lang/reflect/TypeVariable;", typeof(global::Java.Lang.Reflect.TypeVariableArray));
            _cmj_theCtor = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.TypeVariableArray), "<arrinit>", "L", false );
            _cmj_theElementClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.reflect.TypeVariable", typeof(global::Java.Lang.Reflect.TypeVariable), typeof(global::Java.Lang.Reflect.TypeVariableImpl), null);
        }
    
        ///<summary>The constructor taking a dimension as an argument.</summary>
        ///<remarks>Use this constructor where you would normally declare a native array.
        ///instance using rectangular brackets (i.e. ClassArray[ 25 ];).
        /// This constructor will create an empty (null-initialized) array with space for
        /// the given number of elements.</remarks>
        /// <param name="size"> the number of elements that can be stored in the array (the dimension)</param>
        public TypeVariableArray(int size) : base(_cmj_theCtor, _cmj_theElementClass, size) {}
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobject"> The JNI object handle.</param>
        public TypeVariableArray( global::Codemesh.JuggerNET.JNIHandle jobject) : base(jobject) {}
    
    
        /// <summary>Creates a proxy array from a native array</summary>
        /// <param name="arr">the native array instance.</param>
        public TypeVariableArray(global::Java.Lang.Reflect.TypeVariable[] arr) : base(_cmj_theCtor, _cmj_theElementClass, arr.Length)
        {
            int iMax = arr.Length;
            for (int i = 0; i < iMax; i++)
                SetElement(i, typeof(TypeVariable), (TypeVariable)arr[i]);
        }
    
    
        /// <summary>Conversion operator from native .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use native .NET arrays in places where the
        /// compiler expects proxy array instances. You're better off using proxy arrays if you
        /// are going to use the same native array with Java APIs more than once because the entire.
        /// .NET array has to be converted to a proxy array each time you convert it.
        /// </remarks>
        public static implicit operator TypeVariableArray(global::Java.Lang.Reflect.TypeVariable[] arr)
        {
            int iMax = arr.Length;
            TypeVariableArray a = new TypeVariableArray(iMax);
            for (int i = 0; i < iMax; i++)
                a.SetElement(i, typeof(TypeVariable), (TypeVariable)arr[i]);
            return a;
        }
    
    
        /// <summary>Conversion operator from proxy arrays to .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use proxy arrays in places where the
        /// compiler expects native .NET array instances. We declare this operator explicit to prevent
        /// you from using it unintentionally. The performance penalty of unintentionally creating a
        /// .NET array from a proxy array can be significant if you're not planning to use all elements
        /// anyway. 
        /// </remarks>
        public static explicit operator global::Java.Lang.Reflect.TypeVariable[](TypeVariableArray arr)
        {
            global::Java.Lang.Reflect.TypeVariable[] a = new global::Java.Lang.Reflect.TypeVariable[ arr.Length ];
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
        public static TypeVariableArray From(global::Codemesh.JuggerNET.JavaProxy proxy)
        {
            if (_cmj_theClass.IsTypeOf(proxy))
                return new TypeVariableArray(new global::Codemesh.JuggerNET.JNIHandle(proxy.JObjectDuplicate));
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
            get { return typeof(TypeVariable); }
        }
    
        ///<summary>The index operator allowing access to the array's elements.</summary>
        public TypeVariable this[ int index ]
        {
            get
            {
                return (TypeVariable)GetElement( ElementType, index );
            }
            set
            {
                SetElement( index, typeof(TypeVariable), value ); global::System.GC.KeepAlive( this ); global::System.GC.KeepAlive( value );
            }
        }
    }
    
    
    

}
