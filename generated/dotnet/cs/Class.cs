/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.Class
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:14 EDT 2018
 */


namespace Java.Lang
{
    [global::System.Runtime.InteropServices.GuidAttribute("1BC34CA4-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.Class")]
    public sealed class Class :
        global::Java.Lang.Reflect.GenericDeclarationImpl,
        global::Java.Io.Serializable,
        global::Java.Lang.Reflect.Type,
        global::System.Runtime.Serialization.ISerializable
    
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
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun28;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun29;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun30;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun31;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun32;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun33;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun34;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun35;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun36;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun37;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun38;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun39;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun40;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun41;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun42;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun43;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun44;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun45;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun46;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun47;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun48;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun49;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun50;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun51;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun52;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun53;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun54;
    
        static Class()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.Class", typeof(global::Java.Lang.Class));
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "asSubclass", "(Ljava/lang/Class;)Ljava/lang/Class;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "cast", "(Ljava/lang/Object;)Ljava/lang/Object;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "desiredAssertionStatus", "()Z", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "forName", "(Ljava/lang/String;)Ljava/lang/Class;", true, false, true );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "forName", "(Ljava/lang/String;ZLjava/lang/ClassLoader;)Ljava/lang/Class;", true, false, true );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.AnnotatedTypeArray), "getAnnotatedInterfaces", "()[Ljava/lang/reflect/AnnotatedType;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.AnnotatedType), "getAnnotatedSuperclass", "()Ljava/lang/reflect/AnnotatedType;", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getCanonicalName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ClassLoader), "getClassLoader", "()Ljava/lang/ClassLoader;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ClassArray), "getClasses", "()[Ljava/lang/Class;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "getComponentType", "()Ljava/lang/Class;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Constructor), "getConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.ConstructorArray), "getConstructors", "()[Ljava/lang/reflect/Constructor;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ClassArray), "getDeclaredClasses", "()[Ljava/lang/Class;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Constructor), "getDeclaredConstructor", "([Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.ConstructorArray), "getDeclaredConstructors", "()[Ljava/lang/reflect/Constructor;", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Field), "getDeclaredField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.FieldArray), "getDeclaredFields", "()[Ljava/lang/reflect/Field;", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Method), "getDeclaredMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.MethodArray), "getDeclaredMethods", "()[Ljava/lang/reflect/Method;", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "getDeclaringClass", "()Ljava/lang/Class;", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "getEnclosingClass", "()Ljava/lang/Class;", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Constructor), "getEnclosingConstructor", "()Ljava/lang/reflect/Constructor;", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Method), "getEnclosingMethod", "()Ljava/lang/reflect/Method;", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ObjectArray), "getEnumConstants", "()[Ljava/lang/Object;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Field), "getField", "(Ljava/lang/String;)Ljava/lang/reflect/Field;", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.FieldArray), "getFields", "()[Ljava/lang/reflect/Field;", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.TypeArray), "getGenericInterfaces", "()[Ljava/lang/reflect/Type;", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Type), "getGenericSuperclass", "()Ljava/lang/reflect/Type;", false, false, false );
            _cmj_fun29 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ClassArray), "getInterfaces", "()[Ljava/lang/Class;", false, false, false );
            _cmj_fun30 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.Method), "getMethod", "(Ljava/lang/String;[Ljava/lang/Class;)Ljava/lang/reflect/Method;", false, false, false );
            _cmj_fun31 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.MethodArray), "getMethods", "()[Ljava/lang/reflect/Method;", false, false, false );
            _cmj_fun32 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getModifiers", "()I", false, false, false );
            _cmj_fun33 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun34 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Package), "getPackage", "()Ljava/lang/Package;", false, false, false );
            _cmj_fun35 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Security.ProtectionDomain), "getProtectionDomain", "()Ljava/security/ProtectionDomain;", false, false, false );
            _cmj_fun36 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Net.URL), "getResource", "(Ljava/lang/String;)Ljava/net/URL;", false, false, false );
            _cmj_fun37 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;", false, false, false );
            _cmj_fun38 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ObjectArray), "getSigners", "()[Ljava/lang/Object;", false, false, false );
            _cmj_fun39 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getSimpleName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun40 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "getSuperclass", "()Ljava/lang/Class;", false, false, false );
            _cmj_fun41 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getTypeName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun42 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isAnnotation", "()Z", false, false, false );
            _cmj_fun43 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isAnonymousClass", "()Z", false, false, false );
            _cmj_fun44 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isArray", "()Z", false, false, false );
            _cmj_fun45 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isAssignableFrom", "(Ljava/lang/Class;)Z", false, false, false );
            _cmj_fun46 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isEnum", "()Z", false, false, false );
            _cmj_fun47 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isInstance", "(Ljava/lang/Object;)Z", false, false, false );
            _cmj_fun48 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isInterface", "()Z", false, false, false );
            _cmj_fun49 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isLocalClass", "()Z", false, false, false );
            _cmj_fun50 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isMemberClass", "()Z", false, false, false );
            _cmj_fun51 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isPrimitive", "()Z", false, false, false );
            _cmj_fun52 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isSynthetic", "()Z", false, false, false );
            _cmj_fun53 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "newInstance", "()Ljava/lang/Object;", false, false, false );
            _cmj_fun54 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toGenericString", "()Ljava/lang/String;", false, false, false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Class( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        Class( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type Class if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.Class</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Class From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Class(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public global::Java.Lang.Class AsSubclass(global::Java.Lang.Class clazz)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(clazz) )
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public object Cast(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun1.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }    
    
        public bool DesiredAssertionStatus()
        {
            return _cmj_fun2.CallBool( this );
        }    
    
        public static global::Java.Lang.Class ForName(string className)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(className) )
            {
                long    jnet_ref = (long)_cmj_fun3.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Lang.Class ForName(string name, bool initialize, global::Java.Lang.ClassLoader loader)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(initialize).Add(loader) )
            {
                long    jnet_ref = (long)_cmj_fun4.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Lang.Reflect.AnnotatedTypeArray GetAnnotatedInterfaces()
        {
            if(_cmj_fun5.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun5.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.AnnotatedTypeArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.AnnotatedTypeArray)_cmj_fun5.CallObject( this, typeof(global::Java.Lang.Reflect.AnnotatedTypeArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.AnnotatedType GetAnnotatedSuperclass()
        {
            if(_cmj_fun6.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun6.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.AnnotatedTypeImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.AnnotatedType)_cmj_fun6.CallObject( this, typeof(global::Java.Lang.Reflect.AnnotatedType), false );
        
        }    
    
        public string GetCanonicalName()
        {
            return _cmj_fun7.CallString( this );
        }    
    
        public global::Java.Lang.ClassLoader GetClassLoader()
        {
            if(_cmj_fun8.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun8.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ClassLoader.ClassLoaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ClassLoader)_cmj_fun8.CallObject( this, typeof(global::Java.Lang.ClassLoader), false );
        
        }    
    
        public global::Java.Lang.ClassArray GetClasses()
        {
            if(_cmj_fun9.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun9.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ClassArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ClassArray)_cmj_fun9.CallObject( this, typeof(global::Java.Lang.ClassArray), false );
        
        }    
    
        public global::Java.Lang.Class GetComponentType()
        {
            long    jnet_ref = (long)_cmj_fun10.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public global::Java.Lang.Reflect.Constructor GetConstructor(global::Java.Lang.ClassArray parameterTypes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterTypes) )
            {
                long    jnet_ref = (long)_cmj_fun11.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.Constructor( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Lang.Reflect.ConstructorArray GetConstructors()
        {
            if(_cmj_fun12.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun12.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.ConstructorArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.ConstructorArray)_cmj_fun12.CallObject( this, typeof(global::Java.Lang.Reflect.ConstructorArray), false );
        
        }    
    
        public global::Java.Lang.ClassArray GetDeclaredClasses()
        {
            if(_cmj_fun13.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun13.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ClassArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ClassArray)_cmj_fun13.CallObject( this, typeof(global::Java.Lang.ClassArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.Constructor GetDeclaredConstructor(global::Java.Lang.ClassArray parameterTypes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parameterTypes) )
            {
                long    jnet_ref = (long)_cmj_fun14.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.Constructor( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Lang.Reflect.ConstructorArray GetDeclaredConstructors()
        {
            if(_cmj_fun15.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun15.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.ConstructorArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.ConstructorArray)_cmj_fun15.CallObject( this, typeof(global::Java.Lang.Reflect.ConstructorArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.Field GetDeclaredField(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                long    jnet_ref = (long)_cmj_fun16.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.Field( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Lang.Reflect.FieldArray GetDeclaredFields()
        {
            if(_cmj_fun17.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun17.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.FieldArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.FieldArray)_cmj_fun17.CallObject( this, typeof(global::Java.Lang.Reflect.FieldArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.Method GetDeclaredMethod(string name, global::Java.Lang.ClassArray parameterTypes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(parameterTypes) )
            {
                long    jnet_ref = (long)_cmj_fun18.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.Method( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Lang.Reflect.MethodArray GetDeclaredMethods()
        {
            if(_cmj_fun19.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun19.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.MethodArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.MethodArray)_cmj_fun19.CallObject( this, typeof(global::Java.Lang.Reflect.MethodArray), false );
        
        }    
    
        public global::Java.Lang.Class GetDeclaringClass()
        {
            long    jnet_ref = (long)_cmj_fun20.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public global::Java.Lang.Class GetEnclosingClass()
        {
            long    jnet_ref = (long)_cmj_fun21.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public global::Java.Lang.Reflect.Constructor GetEnclosingConstructor()
        {
            long    jnet_ref = (long)_cmj_fun22.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.Constructor( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public global::Java.Lang.Reflect.Method GetEnclosingMethod()
        {
            long    jnet_ref = (long)_cmj_fun23.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.Method( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public global::Java.Lang.ObjectArray GetEnumConstants()
        {
            if(_cmj_fun24.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun24.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ObjectArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ObjectArray)_cmj_fun24.CallObject( this, typeof(global::Java.Lang.ObjectArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.Field GetField(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                long    jnet_ref = (long)_cmj_fun25.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.Field( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Lang.Reflect.FieldArray GetFields()
        {
            if(_cmj_fun26.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun26.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.FieldArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.FieldArray)_cmj_fun26.CallObject( this, typeof(global::Java.Lang.Reflect.FieldArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.TypeArray GetGenericInterfaces()
        {
            if(_cmj_fun27.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun27.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.TypeArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.TypeArray)_cmj_fun27.CallObject( this, typeof(global::Java.Lang.Reflect.TypeArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.Type GetGenericSuperclass()
        {
            if(_cmj_fun28.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun28.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.TypeImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.Type)_cmj_fun28.CallObject( this, typeof(global::Java.Lang.Reflect.Type), false );
        
        }    
    
        public global::Java.Lang.ClassArray GetInterfaces()
        {
            if(_cmj_fun29.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun29.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ClassArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ClassArray)_cmj_fun29.CallObject( this, typeof(global::Java.Lang.ClassArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.Method GetMethod(string name, global::Java.Lang.ClassArray parameterTypes)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(parameterTypes) )
            {
                long    jnet_ref = (long)_cmj_fun30.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.Method( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Lang.Reflect.MethodArray GetMethods()
        {
            if(_cmj_fun31.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun31.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.MethodArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.MethodArray)_cmj_fun31.CallObject( this, typeof(global::Java.Lang.Reflect.MethodArray), false );
        
        }    
    
        public int GetModifiers()
        {
            return _cmj_fun32.CallInt( this );
        }    
    
        public string GetName()
        {
            return _cmj_fun33.CallString( this );
        }    
    
        public global::Java.Lang.Package GetPackage()
        {
            if(_cmj_fun34.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun34.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Package( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Package)_cmj_fun34.CallObject( this, typeof(global::Java.Lang.Package), false );
        
        }    
    
        public global::Java.Security.ProtectionDomain GetProtectionDomain()
        {
            if(_cmj_fun35.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun35.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Security.ProtectionDomain( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Security.ProtectionDomain)_cmj_fun35.CallObject( this, typeof(global::Java.Security.ProtectionDomain), false );
        
        }    
    
        public global::Java.Net.URL GetResource(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                long    jnet_ref = (long)_cmj_fun36.CallObject( this, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Net.URL( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public global::Java.Io.InputStream GetResourceAsStream(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun37.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun37.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Io.InputStream)_cmj_fun37.CallObject( this, typeof(global::Java.Io.InputStream), false, cmj_jmargs );
        
            }
        }    
    
        public global::Java.Lang.ObjectArray GetSigners()
        {
            if(_cmj_fun38.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun38.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ObjectArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ObjectArray)_cmj_fun38.CallObject( this, typeof(global::Java.Lang.ObjectArray), false );
        
        }    
    
        public string GetSimpleName()
        {
            return _cmj_fun39.CallString( this );
        }    
    
        public global::Java.Lang.Class GetSuperclass()
        {
            long    jnet_ref = (long)_cmj_fun40.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public string GetTypeName()
        {
            return _cmj_fun41.CallString( this );
        }    
    
        public bool IsAnnotation()
        {
            return _cmj_fun42.CallBool( this );
        }    
    
        public bool IsAnonymousClass()
        {
            return _cmj_fun43.CallBool( this );
        }    
    
        public bool IsArray()
        {
            return _cmj_fun44.CallBool( this );
        }    
    
        public bool IsAssignableFrom(global::Java.Lang.Class cls)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(cls) )
            {
                return _cmj_fun45.CallBool( this, cmj_jmargs );
            }
        }    
    
        public bool IsEnum()
        {
            return _cmj_fun46.CallBool( this );
        }    
    
        public bool IsInstance(object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(obj) )
            {
                return _cmj_fun47.CallBool( this, cmj_jmargs );
            }
        }    
    
        public bool IsInterface()
        {
            return _cmj_fun48.CallBool( this );
        }    
    
        public bool IsLocalClass()
        {
            return _cmj_fun49.CallBool( this );
        }    
    
        public bool IsMemberClass()
        {
            return _cmj_fun50.CallBool( this );
        }    
    
        public bool IsPrimitive()
        {
            return _cmj_fun51.CallBool( this );
        }    
    
        public bool IsSynthetic()
        {
            return _cmj_fun52.CallBool( this );
        }    
    
        public object NewInstance()
        {
            return _cmj_fun53.CallObject( this, typeof(object), false );
        }    
    
        public string ToGenericString()
        {
            return _cmj_fun54.CallString( this );
        }    
    
    
    }
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="[Ljava/lang/Class;")]
    public sealed class ClassArray :
        global::Codemesh.JuggerNET.JuggerNETProxyArray,
        global::Java.Lang.Cloneable,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theElementClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod  _cmj_theCtor;
    
        static ClassArray()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("[Ljava/lang/Class;", typeof(global::Java.Lang.ClassArray));
            _cmj_theCtor = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ClassArray), "<arrinit>", "L", false );
            _cmj_theElementClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.Class", typeof(global::Java.Lang.Class));
        }
    
        ///<summary>The constructor taking a dimension as an argument.</summary>
        ///<remarks>Use this constructor where you would normally declare a native array.
        ///instance using rectangular brackets (i.e. ClassArray[ 25 ];).
        /// This constructor will create an empty (null-initialized) array with space for
        /// the given number of elements.</remarks>
        /// <param name="size"> the number of elements that can be stored in the array (the dimension)</param>
        public ClassArray(int size) : base(_cmj_theCtor, _cmj_theElementClass, size) {}
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobject"> The JNI object handle.</param>
        public ClassArray( global::Codemesh.JuggerNET.JNIHandle jobject) : base(jobject) {}
    
    
        /// <summary>Creates a proxy array from a native array</summary>
        /// <param name="arr">the native array instance.</param>
        public ClassArray(global::Java.Lang.Class[] arr) : base(_cmj_theCtor, _cmj_theElementClass, arr.Length)
        {
            int iMax = arr.Length;
            for (int i = 0; i < iMax; i++)
                SetElement(i, (Class)arr[i]);
        }
    
    
        /// <summary>Conversion operator from native .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use native .NET arrays in places where the
        /// compiler expects proxy array instances. You're better off using proxy arrays if you
        /// are going to use the same native array with Java APIs more than once because the entire.
        /// .NET array has to be converted to a proxy array each time you convert it.
        /// </remarks>
        public static implicit operator ClassArray(global::Java.Lang.Class[] arr)
        {
            int iMax = arr.Length;
            ClassArray a = new ClassArray(iMax);
            for (int i = 0; i < iMax; i++)
                a.SetElement(i, (Class)arr[i]);
            return a;
        }
    
    
        /// <summary>Conversion operator from proxy arrays to .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use proxy arrays in places where the
        /// compiler expects native .NET array instances. We declare this operator explicit to prevent
        /// you from using it unintentionally. The performance penalty of unintentionally creating a
        /// .NET array from a proxy array can be significant if you're not planning to use all elements
        /// anyway. 
        /// </remarks>
        public static explicit operator global::Java.Lang.Class[](ClassArray arr)
        {
            global::Java.Lang.Class[] a = new global::Java.Lang.Class[ arr.Length ];
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
        public static ClassArray From(global::Codemesh.JuggerNET.JavaProxy proxy)
        {
            if (_cmj_theClass.IsTypeOf(proxy))
                return new ClassArray(new global::Codemesh.JuggerNET.JNIHandle(proxy.JObjectDuplicate));
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
            get { return typeof(Class); }
        }
    
        ///<summary>The index operator allowing access to the array's elements.</summary>
        public Class this[ int index ]
        {
            get
            {
                global::Codemesh.JuggerNET.JNIHandle h = GetElement( index );
                return !h ? null : new Class( h );
            }
            set
            {
                SetElement( index, value ); global::System.GC.KeepAlive( this ); global::System.GC.KeepAlive( value );
            }
        }
    }
    
    
    

}
