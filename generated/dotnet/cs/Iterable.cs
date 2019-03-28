/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.Iterable
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang
{
    [global::System.Runtime.InteropServices.GuidAttribute("E96B41C6-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.lang.Iterable")]
    public interface Iterable :
        global::System.Collections.IEnumerable
    { 
        global::Java.Util.Iterator Iterator();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.Iterable")]
    public class IterableImpl :
        global::Java.Lang.Object,
        global::Java.Lang.Iterable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
    
        static IterableImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.Iterable", typeof(global::Java.Lang.Iterable), typeof(global::Java.Lang.IterableImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "forEach", "(Ljava/util/function/Consumer;)V", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Spliterator), "spliterator", "()Ljava/util/Spliterator;", true, false, false );
            
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Iterator), "iterator", "()Ljava/util/Iterator;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public IterableImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type IterableImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.Iterable</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.IterableImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.IterableImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static void ForEach(global::Java.Util.Function.Consumer arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                _cmj_fun0.CallVoid( null, cmj_jmargs );
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
        
        /// <summary>Implements the <c>IEnumerable</c> interface to support <c>foreach</c>.</summary>
        public global::System.Collections.IEnumerator GetEnumerator()
        {
            return new global::Codemesh.JuggerNET.IterableEnumerator( this );
        }
        
        
        
        
        public global::Java.Util.Iterator Iterator()
        {
            if(_cmj_fun3.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun3.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.IteratorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Iterator)_cmj_fun3.CallObject( this, typeof(global::Java.Util.Iterator), false );
        
        }        
    }    
    

}
