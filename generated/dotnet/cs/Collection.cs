/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.Collection
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util
{
    [global::System.Runtime.InteropServices.GuidAttribute("A750F45E-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.Collection")]
    public interface Collection :
        global::System.Collections.ICollection,
        global::Java.Lang.Iterable
    { 
        bool Add(object e);
    
    
        bool AddAll(global::Java.Util.Collection c);
    
    
        void Clear();
    
    
        bool Contains(object o);
    
    
        bool ContainsAll(global::Java.Util.Collection c);
    
    
        bool IsEmpty();
    
    
        bool Remove(object o);
    
    
        bool RemoveAll(global::Java.Util.Collection c);
    
    
        bool RetainAll(global::Java.Util.Collection c);
    
    
        int Size();
    
    
        global::Java.Lang.ObjectArray ToArray();
    
    
        global::Java.Lang.ObjectArray ToArray(global::Java.Lang.ObjectArray a);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.Collection")]
    public class CollectionImpl :
        global::Java.Lang.IterableImpl,
        global::Java.Util.Collection
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun6;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun8;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun9;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun10;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun11;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun12;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun13;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun14;
    
        static CollectionImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.Collection", typeof(global::Java.Util.Collection), typeof(global::Java.Util.CollectionImpl), null);
            
            
            
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "removeIf", "(Ljava/util/function/Predicate;)Z", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Spliterator), "spliterator", "()Ljava/util/Spliterator;", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "add", "(Ljava/lang/Object;)Z", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "addAll", "(Ljava/util/Collection;)Z", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "clear", "()V", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "contains", "(Ljava/lang/Object;)Z", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "containsAll", "(Ljava/util/Collection;)Z", false, false, false );
            
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isEmpty", "()Z", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "remove", "(Ljava/lang/Object;)Z", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "removeAll", "(Ljava/util/Collection;)Z", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "retainAll", "(Ljava/util/Collection;)Z", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "size", "()I", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ObjectArray), "toArray", "()[Ljava/lang/Object;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ObjectArray), "toArray", "([Ljava/lang/Object;)[Ljava/lang/Object;", false, false, false );
        }
    
    /// <summary>Implements the <c>ICollection.Count</c> property.</summary>
    public int Count
    {
        get
        {
            return global::Codemesh.JuggerNET.NativeInterface.GetCollectionSize(this);
        }
    }
    
    /// <summary>Implements the <c>ICollection.IsSynchronized</c> property.</summary>
    public bool IsSynchronized
    {
        get
        {
            return false;
        }
    }
    
    /// <summary>Implements the <c>ICollection.SyncRoot</c> property.</summary>
    public object SyncRoot
    {
        get
        {
            return this;
        }
    }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public CollectionImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type CollectionImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.Collection</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.CollectionImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.CollectionImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static bool RemoveIf(global::Java.Util.Function.Predicate arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                return _cmj_fun0.CallBool( null, cmj_jmargs );
            }
        }        
        
        public static global::Java.Util.Spliterator Spliterator()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.SpliteratorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Spliterator)_cmj_fun1.CallObject( null, typeof(global::Java.Util.Spliterator), false );
        
        }        
        
        public bool Add(object e)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(e) )
            {
                return _cmj_fun2.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool AddAll(global::Java.Util.Collection c)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(c) )
            {
                return _cmj_fun3.CallBool( this, cmj_jmargs );
            }
        }        
        
        public void Clear()
        {
            _cmj_fun4.CallVoid( this );
        }        
        
        public bool Contains(object o)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(o) )
            {
                return _cmj_fun5.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool ContainsAll(global::Java.Util.Collection c)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(c) )
            {
                return _cmj_fun6.CallBool( this, cmj_jmargs );
            }
        }        
        
        /// <summary>Implements the <c>ICollection.CopyTo</c> function.</summary>
        public void CopyTo( global::System.Array array, int index )
        {
            global::Codemesh.JuggerNET.NativeInterface.CollectionCopyTo( array, index, this );
        }
        
        
        
        
        public bool IsEmpty()
        {
            return _cmj_fun8.CallBool( this );
        }        
        
        public bool Remove(object o)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(o) )
            {
                return _cmj_fun9.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool RemoveAll(global::Java.Util.Collection c)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(c) )
            {
                return _cmj_fun10.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool RetainAll(global::Java.Util.Collection c)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(c) )
            {
                return _cmj_fun11.CallBool( this, cmj_jmargs );
            }
        }        
        
        public int Size()
        {
            return _cmj_fun12.CallInt( this );
        }        
        
        public global::Java.Lang.ObjectArray ToArray()
        {
            if(_cmj_fun13.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun13.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ObjectArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ObjectArray)_cmj_fun13.CallObject( this, typeof(global::Java.Lang.ObjectArray), false );
        
        }        
        
        public global::Java.Lang.ObjectArray ToArray(global::Java.Lang.ObjectArray a)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(a) )
            {
                if(_cmj_fun14.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun14.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Lang.ObjectArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Lang.ObjectArray)_cmj_fun14.CallObject( this, typeof(global::Java.Lang.ObjectArray), false, cmj_jmargs );
        
            }
        }        
    }    
    

}
