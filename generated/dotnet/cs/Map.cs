/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.Map
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util
{
    [global::System.Runtime.InteropServices.GuidAttribute("E105579C-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.Map")]
    public interface Map 
    { 
        void Clear();
    
    
        bool ContainsKey(object key);
    
    
        bool ContainsValue(object value);
    
    
        object Get(object key);
    
    
        bool IsEmpty();
    
    
        object Put(object key, object value);
    
    
        void PutAll(global::Java.Util.Map m);
    
    
        object Remove(object key);
    
    
        int Size();
    
    
        global::Java.Util.Collection Values();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.Map")]
    public class MapImpl :
        global::Java.Lang.Object,
        global::Java.Util.Map
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
    
        static MapImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.Map", typeof(global::Java.Util.Map), typeof(global::Java.Util.MapImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getOrDefault", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "putIfAbsent", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "remove", "(Ljava/lang/Object;Ljava/lang/Object;)Z", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "replace", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "replace", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;)Z", true, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "clear", "()V", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "containsKey", "(Ljava/lang/Object;)Z", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "containsValue", "(Ljava/lang/Object;)Z", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "get", "(Ljava/lang/Object;)Ljava/lang/Object;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isEmpty", "()Z", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "putAll", "(Ljava/util/Map;)V", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "size", "()I", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Collection), "values", "()Ljava/util/Collection;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public MapImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type MapImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.Map</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.MapImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.MapImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static object GetOrDefault(object arg0, object arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                return _cmj_fun0.CallObject( null, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public static object PutIfAbsent(object arg0, object arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                return _cmj_fun1.CallObject( null, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public static bool Remove(object arg0, object arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                return _cmj_fun2.CallBool( null, cmj_jmargs );
            }
        }        
        
        public static object Replace(object arg0, object arg1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1) )
            {
                return _cmj_fun3.CallObject( null, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public static bool Replace(object arg0, object arg1, object arg2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0).Add(arg1).Add(arg2) )
            {
                return _cmj_fun4.CallBool( null, cmj_jmargs );
            }
        }        
        
        public void Clear()
        {
            _cmj_fun5.CallVoid( this );
        }        
        
        public bool ContainsKey(object key)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(key) )
            {
                return _cmj_fun6.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool ContainsValue(object value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                return _cmj_fun7.CallBool( this, cmj_jmargs );
            }
        }        
        
        public object Get(object key)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(key) )
            {
                return _cmj_fun8.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public bool IsEmpty()
        {
            return _cmj_fun9.CallBool( this );
        }        
        
        public object Put(object key, object value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(key).Add(value) )
            {
                return _cmj_fun10.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public void PutAll(global::Java.Util.Map m)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(m) )
            {
                _cmj_fun11.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public object Remove(object key)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(key) )
            {
                return _cmj_fun12.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public int Size()
        {
            return _cmj_fun13.CallInt( this );
        }        
        
        public global::Java.Util.Collection Values()
        {
            if(_cmj_fun14.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun14.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.CollectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Collection)_cmj_fun14.CallObject( this, typeof(global::Java.Util.Collection), false );
        
        }        
    }    
    

}
