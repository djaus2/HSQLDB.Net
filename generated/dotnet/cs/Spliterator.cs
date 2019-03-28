/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.Spliterator
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util
{
    [global::System.Runtime.InteropServices.GuidAttribute("6A86195D-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.Spliterator")]
    public interface Spliterator 
    { 
        int Characteristics();
    
    
        long EstimateSize();
    
    
        bool TryAdvance(global::Java.Util.Function.Consumer action);
    
    
        global::Java.Util.Spliterator TrySplit();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.util.Spliterator")]
    public class SpliteratorImpl :
        global::Java.Lang.Object,
        global::Java.Util.Spliterator
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
    
        static SpliteratorImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.Spliterator", typeof(global::Java.Util.Spliterator), typeof(global::Java.Util.SpliteratorImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "forEachRemaining", "(Ljava/util/function/Consumer;)V", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Comparator), "getComparator", "()Ljava/util/Comparator;", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "getExactSizeIfKnown", "()J", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "hasCharacteristics", "(I)Z", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "characteristics", "()I", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(long), "estimateSize", "()J", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "tryAdvance", "(Ljava/util/function/Consumer;)Z", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Spliterator), "trySplit", "()Ljava/util/Spliterator;", false, false, false );
        }
    
        public const int        CONCURRENT = 4096;
        public const int        DISTINCT = 1;
        public const int        IMMUTABLE = 1024;
        public const int        NONNULL = 256;
        public const int        ORDERED = 16;
        public const int        SIZED = 64;
        public const int        SORTED = 4;
        public const int        SUBSIZED = 16384;
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public SpliteratorImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type SpliteratorImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.Spliterator</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.SpliteratorImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.SpliteratorImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static void ForEachRemaining(global::Java.Util.Function.Consumer arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                _cmj_fun0.CallVoid( null, cmj_jmargs );
            }
        }        
        
        public static global::Java.Util.Comparator GetComparator()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.ComparatorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Comparator)_cmj_fun1.CallObject( null, typeof(global::Java.Util.Comparator), false );
        
        }        
        
        public static long GetExactSizeIfKnown()
        {
            return _cmj_fun2.CallLong( null );
        }        
        
        public static bool HasCharacteristics(int arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                return _cmj_fun3.CallBool( null, cmj_jmargs );
            }
        }        
        
        public int Characteristics()
        {
            return _cmj_fun4.CallInt( this );
        }        
        
        public long EstimateSize()
        {
            return _cmj_fun5.CallLong( this );
        }        
        
        public bool TryAdvance(global::Java.Util.Function.Consumer action)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(action) )
            {
                return _cmj_fun6.CallBool( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Util.Spliterator TrySplit()
        {
            if(_cmj_fun7.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun7.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.SpliteratorImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Spliterator)_cmj_fun7.CallObject( this, typeof(global::Java.Util.Spliterator), false );
        
        }        
    }    
    

}
