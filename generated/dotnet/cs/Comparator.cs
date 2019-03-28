/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.Comparator
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util
{
    [global::System.Runtime.InteropServices.GuidAttribute("DCC29296-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.Comparator")]
    public interface Comparator 
    { 
        int Compare(object o1, object o2);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.Comparator")]
    public class ComparatorImpl :
        global::Java.Lang.Object,
        global::Java.Util.Comparator
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun6;
    
        static ComparatorImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.Comparator", typeof(global::Java.Util.Comparator), typeof(global::Java.Util.ComparatorImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Comparator), "naturalOrder", "()Ljava/util/Comparator;", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Comparator), "nullsFirst", "(Ljava/util/Comparator;)Ljava/util/Comparator;", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Comparator), "nullsLast", "(Ljava/util/Comparator;)Ljava/util/Comparator;", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Comparator), "reverseOrder", "()Ljava/util/Comparator;", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Comparator), "reversed", "()Ljava/util/Comparator;", true, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Comparator), "thenComparing", "(Ljava/util/Comparator;)Ljava/util/Comparator;", true, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ComparatorImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ComparatorImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.Comparator</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.ComparatorImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.ComparatorImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static global::Java.Util.Comparator NaturalOrder()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.ComparatorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Comparator)_cmj_fun0.CallObject( null, typeof(global::Java.Util.Comparator), false );
        
        }        
        
        public static global::Java.Util.Comparator NullsFirst(global::Java.Util.Comparator arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                if(_cmj_fun1.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun1.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.ComparatorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.Comparator)_cmj_fun1.CallObject( null, typeof(global::Java.Util.Comparator), false, cmj_jmargs );
        
            }
        }        
        
        public static global::Java.Util.Comparator NullsLast(global::Java.Util.Comparator arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                if(_cmj_fun2.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun2.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.ComparatorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.Comparator)_cmj_fun2.CallObject( null, typeof(global::Java.Util.Comparator), false, cmj_jmargs );
        
            }
        }        
        
        public static global::Java.Util.Comparator ReverseOrder()
        {
            if(_cmj_fun3.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun3.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.ComparatorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Comparator)_cmj_fun3.CallObject( null, typeof(global::Java.Util.Comparator), false );
        
        }        
        
        public static global::Java.Util.Comparator Reversed()
        {
            if(_cmj_fun4.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun4.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.ComparatorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Comparator)_cmj_fun4.CallObject( null, typeof(global::Java.Util.Comparator), false );
        
        }        
        
        public static global::Java.Util.Comparator ThenComparing(global::Java.Util.Comparator arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                if(_cmj_fun5.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun5.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.ComparatorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.Comparator)_cmj_fun5.CallObject( null, typeof(global::Java.Util.Comparator), false, cmj_jmargs );
        
            }
        }        
        
        public int Compare(object o1, object o2)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(o1).Add(o2) )
            {
                return _cmj_fun6.CallInt( this, cmj_jmargs );
            }
        }        
    }    
    

}
