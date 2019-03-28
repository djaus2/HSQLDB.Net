/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.List
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util
{
    [global::System.Runtime.InteropServices.GuidAttribute("3FA5465E-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.List")]
    public interface List :
        global::Java.Util.Collection
    { 
        void Add(int index, object element);
    
    
        bool AddAll(int index, global::Java.Util.Collection c);
    
    
        object Get(int index);
    
    
        int IndexOf(object o);
    
    
        int LastIndexOf(object o);
    
    
        global::Java.Util.ListIterator ListIterator();
    
    
        global::Java.Util.ListIterator ListIterator(int index);
    
    
        object Remove(int index);
    
    
        object Set(int index, object element);
    
    
        global::Java.Util.List SubList(int fromIndex, int toIndex);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.List")]
    public class ListImpl :
        global::Java.Util.CollectionImpl,
        global::Java.Util.List
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
    
        static ListImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.List", typeof(global::Java.Util.List), typeof(global::Java.Util.ListImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "replaceAll", "(Ljava/util/function/UnaryOperator;)V", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "sort", "(Ljava/util/Comparator;)V", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Spliterator), "spliterator", "()Ljava/util/Spliterator;", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "add", "(ILjava/lang/Object;)V", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "addAll", "(ILjava/util/Collection;)Z", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "get", "(I)Ljava/lang/Object;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "indexOf", "(Ljava/lang/Object;)I", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "lastIndexOf", "(Ljava/lang/Object;)I", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.ListIterator), "listIterator", "()Ljava/util/ListIterator;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.ListIterator), "listIterator", "(I)Ljava/util/ListIterator;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "remove", "(I)Ljava/lang/Object;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "set", "(ILjava/lang/Object;)Ljava/lang/Object;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.List), "subList", "(II)Ljava/util/List;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ListImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ListImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.List</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.ListImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.ListImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static void ReplaceAll(global::Java.Util.Function.UnaryOperator arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                _cmj_fun0.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static void Sort(global::Java.Util.Comparator arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                _cmj_fun1.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static global::Java.Util.Spliterator Spliterator()
        {
            if(_cmj_fun2.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun2.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.SpliteratorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Spliterator)_cmj_fun2.CallObject( null, typeof(global::Java.Util.Spliterator), false );
        
        }        
        
        public void Add(int index, object element)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index).Add(element) )
            {
                _cmj_fun3.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public bool AddAll(int index, global::Java.Util.Collection c)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index).Add(c) )
            {
                return _cmj_fun4.CallBool( this, cmj_jmargs );
            }
        }        
        
        public object Get(int index)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index) )
            {
                return _cmj_fun5.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public int IndexOf(object o)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(o) )
            {
                return _cmj_fun6.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int LastIndexOf(object o)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(o) )
            {
                return _cmj_fun7.CallInt( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Util.ListIterator ListIterator()
        {
            if(_cmj_fun8.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun8.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.ListIteratorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.ListIterator)_cmj_fun8.CallObject( this, typeof(global::Java.Util.ListIterator), false );
        
        }        
        
        public global::Java.Util.ListIterator ListIterator(int index)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index) )
            {
                if(_cmj_fun9.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun9.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.ListIteratorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.ListIterator)_cmj_fun9.CallObject( this, typeof(global::Java.Util.ListIterator), false, cmj_jmargs );
        
            }
        }        
        
        public object Remove(int index)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index) )
            {
                return _cmj_fun10.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object Set(int index, object element)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index).Add(element) )
            {
                return _cmj_fun11.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public global::Java.Util.List SubList(int fromIndex, int toIndex)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(fromIndex).Add(toIndex) )
            {
                if(_cmj_fun12.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun12.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.ListImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.List)_cmj_fun12.CallObject( this, typeof(global::Java.Util.List), false, cmj_jmargs );
        
            }
        }        
    }    
    

}
