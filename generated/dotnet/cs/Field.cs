/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.reflect.Field
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang.Reflect
{
    [global::System.Runtime.InteropServices.GuidAttribute("4F096995-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.reflect.Field")]
    public sealed class Field :
        global::Java.Lang.Reflect.AnnotatedElementImpl
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
    
        static Field()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.reflect.Field", typeof(global::Java.Lang.Reflect.Field));
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "get", "(Ljava/lang/Object;)Ljava/lang/Object;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.AnnotatedType), "getAnnotatedType", "()Ljava/lang/reflect/AnnotatedType;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Annotation.AnnotationArray), "getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getBoolean", "(Ljava/lang/Object;)Z", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(byte), "getByte", "(Ljava/lang/Object;)B", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(char), "getChar", "(Ljava/lang/Object;)C", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "getDeclaringClass", "()Ljava/lang/Class;", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(double), "getDouble", "(Ljava/lang/Object;)D", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(float), "getFloat", "(Ljava/lang/Object;)F", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Type), "getGenericType", "()Ljava/lang/reflect/Type;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getInt", "(Ljava/lang/Object;)I", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getLong", "(Ljava/lang/Object;)J", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getModifiers", "()I", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(short), "getShort", "(Ljava/lang/Object;)S", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "getType", "()Ljava/lang/Class;", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isEnumConstant", "()Z", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isSynthetic", "()Z", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "set", "(Ljava/lang/Object;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setBoolean", "(Ljava/lang/Object;Z)V", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setByte", "(Ljava/lang/Object;B)V", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setChar", "(Ljava/lang/Object;C)V", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setDouble", "(Ljava/lang/Object;D)V", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setFloat", "(Ljava/lang/Object;F)V", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setInt", "(Ljava/lang/Object;I)V", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setLong", "(Ljava/lang/Object;J)V", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setShort", "(Ljava/lang/Object;S)V", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toGenericString", "()Ljava/lang/String;", false, false, false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Field( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type Field if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.reflect.Field</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Reflect.Field From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Reflect.Field(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public object Get(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun0.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }    
    
        public global::Java.Lang.Reflect.AnnotatedType GetAnnotatedType()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.AnnotatedTypeImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.AnnotatedType)_cmj_fun1.CallObject( this, typeof(global::Java.Lang.Reflect.AnnotatedType), false );
        
        }    
    
        public global::Java.Lang.Annotation.AnnotationArray GetAnnotationsByType(global::Java.Lang.Class annotationClass)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(annotationClass) )
            {
                if(_cmj_fun2.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun2.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Lang.Annotation.AnnotationArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Lang.Annotation.AnnotationArray)_cmj_fun2.CallObject( this, typeof(global::Java.Lang.Annotation.AnnotationArray), false, cmj_jmargs );
        
            }
        }    
    
        public bool GetBoolean(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun3.CallBool( this, cmj_jmargs );
            }
        }    
    
        public byte GetByte(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun4.CallByte( this, cmj_jmargs );
            }
        }    
    
        public char GetChar(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun5.CallChar( this, cmj_jmargs );
            }
        }    
    
        public global::Java.Lang.Class GetDeclaringClass()
        {
            long    jnet_ref = (long)_cmj_fun6.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public double GetDouble(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun7.CallDouble( this, cmj_jmargs );
            }
        }    
    
        public float GetFloat(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun8.CallFloat( this, cmj_jmargs );
            }
        }    
    
        public global::Java.Lang.Reflect.Type GetGenericType()
        {
            if(_cmj_fun9.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun9.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.TypeImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.Type)_cmj_fun9.CallObject( this, typeof(global::Java.Lang.Reflect.Type), false );
        
        }    
    
        public int GetInt(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun10.CallInt( this, cmj_jmargs );
            }
        }    
    
        public long GetLong(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun11.CallLong( this, cmj_jmargs );
            }
        }    
    
        public int GetModifiers()
        {
            return _cmj_fun12.CallInt( this );
        }    
    
        public string GetName()
        {
            return _cmj_fun13.CallString( this );
        }    
    
        public short GetShort(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun14.CallShort( this, cmj_jmargs );
            }
        }    
    
        public global::Java.Lang.Class GetType_Java()
        {
            long    jnet_ref = (long)_cmj_fun15.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public bool IsEnumConstant()
        {
            return _cmj_fun16.CallBool( this );
        }    
    
        public bool IsSynthetic()
        {
            return _cmj_fun17.CallBool( this );
        }    
    
        public void Set(object obj, object value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj).Add(value) )
            {
                _cmj_fun18.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetBoolean(object obj, bool z)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj).Add(z) )
            {
                _cmj_fun19.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetByte(object obj, byte b)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj).Add(b) )
            {
                _cmj_fun20.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetChar(object obj, char c)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj).Add(c) )
            {
                _cmj_fun21.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetDouble(object obj, double d)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj).Add(d) )
            {
                _cmj_fun22.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetFloat(object obj, float f)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj).Add(f) )
            {
                _cmj_fun23.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetInt(object obj, int i)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj).Add(i) )
            {
                _cmj_fun24.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetLong(object obj, long l)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj).Add(l) )
            {
                _cmj_fun25.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetShort(object obj, short s)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj).Add(s) )
            {
                _cmj_fun26.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public string ToGenericString()
        {
            return _cmj_fun27.CallString( this );
        }    
    
    
    }
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="[Ljava/lang/reflect/Field;")]
    public sealed class FieldArray :
        global::Codemesh.JuggerNET.JuggerNETProxyArray,
        global::Java.Lang.Cloneable,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theElementClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod  _cmj_theCtor;
    
        static FieldArray()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("[Ljava/lang/reflect/Field;", typeof(global::Java.Lang.Reflect.FieldArray));
            _cmj_theCtor = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.FieldArray), "<arrinit>", "L", false );
            _cmj_theElementClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.reflect.Field", typeof(global::Java.Lang.Reflect.Field));
        }
    
        ///<summary>The constructor taking a dimension as an argument.</summary>
        ///<remarks>Use this constructor where you would normally declare a native array.
        ///instance using rectangular brackets (i.e. ClassArray[ 25 ];).
        /// This constructor will create an empty (null-initialized) array with space for
        /// the given number of elements.</remarks>
        /// <param name="size"> the number of elements that can be stored in the array (the dimension)</param>
        public FieldArray(int size) : base(_cmj_theCtor, _cmj_theElementClass, size) {}
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobject"> The JNI object handle.</param>
        public FieldArray( global::Codemesh.JuggerNET.JNIHandle jobject) : base(jobject) {}
    
    
        /// <summary>Creates a proxy array from a native array</summary>
        /// <param name="arr">the native array instance.</param>
        public FieldArray(global::Java.Lang.Reflect.Field[] arr) : base(_cmj_theCtor, _cmj_theElementClass, arr.Length)
        {
            int iMax = arr.Length;
            for (int i = 0; i < iMax; i++)
                SetElement(i, (Field)arr[i]);
        }
    
    
        /// <summary>Conversion operator from native .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use native .NET arrays in places where the
        /// compiler expects proxy array instances. You're better off using proxy arrays if you
        /// are going to use the same native array with Java APIs more than once because the entire.
        /// .NET array has to be converted to a proxy array each time you convert it.
        /// </remarks>
        public static implicit operator FieldArray(global::Java.Lang.Reflect.Field[] arr)
        {
            int iMax = arr.Length;
            FieldArray a = new FieldArray(iMax);
            for (int i = 0; i < iMax; i++)
                a.SetElement(i, (Field)arr[i]);
            return a;
        }
    
    
        /// <summary>Conversion operator from proxy arrays to .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use proxy arrays in places where the
        /// compiler expects native .NET array instances. We declare this operator explicit to prevent
        /// you from using it unintentionally. The performance penalty of unintentionally creating a
        /// .NET array from a proxy array can be significant if you're not planning to use all elements
        /// anyway. 
        /// </remarks>
        public static explicit operator global::Java.Lang.Reflect.Field[](FieldArray arr)
        {
            global::Java.Lang.Reflect.Field[] a = new global::Java.Lang.Reflect.Field[ arr.Length ];
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
        public static FieldArray From(global::Codemesh.JuggerNET.JavaProxy proxy)
        {
            if (_cmj_theClass.IsTypeOf(proxy))
                return new FieldArray(new global::Codemesh.JuggerNET.JNIHandle(proxy.JObjectDuplicate));
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
            get { return typeof(Field); }
        }
    
        ///<summary>The index operator allowing access to the array's elements.</summary>
        public Field this[ int index ]
        {
            get
            {
                global::Codemesh.JuggerNET.JNIHandle h = GetElement( index );
                return !h ? null : new Field( h );
            }
            set
            {
                SetElement( index, value ); global::System.GC.KeepAlive( this ); global::System.GC.KeepAlive( value );
            }
        }
    }
    
    
    

}
