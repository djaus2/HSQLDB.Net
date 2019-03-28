/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.reflect.AnnotatedElement
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang.Reflect
{
    [global::System.Runtime.InteropServices.GuidAttribute("386F7BC9-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.lang.reflect.AnnotatedElement")]
    public interface AnnotatedElement 
    { 
        global::Java.Lang.Annotation.Annotation GetAnnotation(global::Java.Lang.Class annotationClass);
    
    
        global::Java.Lang.Annotation.AnnotationArray GetAnnotations();
    
    
        global::Java.Lang.Annotation.AnnotationArray GetDeclaredAnnotations();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.reflect.AnnotatedElement")]
    public class AnnotatedElementImpl :
        global::Java.Lang.Object,
        global::Java.Lang.Reflect.AnnotatedElement
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun6;
    
        static AnnotatedElementImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.reflect.AnnotatedElement", typeof(global::Java.Lang.Reflect.AnnotatedElement), typeof(global::Java.Lang.Reflect.AnnotatedElementImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Annotation.AnnotationArray), "getAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Annotation.Annotation), "getDeclaredAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", true, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Annotation.AnnotationArray), "getDeclaredAnnotationsByType", "(Ljava/lang/Class;)[Ljava/lang/annotation/Annotation;", true, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isAnnotationPresent", "(Ljava/lang/Class;)Z", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Annotation.Annotation), "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Annotation.AnnotationArray), "getAnnotations", "()[Ljava/lang/annotation/Annotation;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Annotation.AnnotationArray), "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public AnnotatedElementImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type AnnotatedElementImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.reflect.AnnotatedElement</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Reflect.AnnotatedElementImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Reflect.AnnotatedElementImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public static global::Java.Lang.Annotation.AnnotationArray GetAnnotationsByType(global::Java.Lang.Class arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                if(_cmj_fun0.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun0.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Lang.Annotation.AnnotationArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Lang.Annotation.AnnotationArray)_cmj_fun0.CallObject( null, typeof(global::Java.Lang.Annotation.AnnotationArray), false, cmj_jmargs );
        
            }
        }        
        
        public static global::Java.Lang.Annotation.Annotation GetDeclaredAnnotation(global::Java.Lang.Class arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                if(_cmj_fun1.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun1.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Lang.Annotation.AnnotationImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Lang.Annotation.Annotation)_cmj_fun1.CallObject( null, typeof(global::Java.Lang.Annotation.Annotation), false, cmj_jmargs );
        
            }
        }        
        
        public static global::Java.Lang.Annotation.AnnotationArray GetDeclaredAnnotationsByType(global::Java.Lang.Class arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                if(_cmj_fun2.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun2.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Lang.Annotation.AnnotationArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Lang.Annotation.AnnotationArray)_cmj_fun2.CallObject( null, typeof(global::Java.Lang.Annotation.AnnotationArray), false, cmj_jmargs );
        
            }
        }        
        
        public static bool IsAnnotationPresent(global::Java.Lang.Class arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                return _cmj_fun3.CallBool( null, cmj_jmargs );
            }
        }        
        
        public global::Java.Lang.Annotation.Annotation GetAnnotation(global::Java.Lang.Class annotationClass)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(annotationClass) )
            {
                if(_cmj_fun4.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun4.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Lang.Annotation.AnnotationImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Lang.Annotation.Annotation)_cmj_fun4.CallObject( this, typeof(global::Java.Lang.Annotation.Annotation), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Lang.Annotation.AnnotationArray GetAnnotations()
        {
            if(_cmj_fun5.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun5.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Annotation.AnnotationArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Annotation.AnnotationArray)_cmj_fun5.CallObject( this, typeof(global::Java.Lang.Annotation.AnnotationArray), false );
        
        }        
        
        public global::Java.Lang.Annotation.AnnotationArray GetDeclaredAnnotations()
        {
            if(_cmj_fun6.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun6.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Annotation.AnnotationArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Annotation.AnnotationArray)_cmj_fun6.CallObject( this, typeof(global::Java.Lang.Annotation.AnnotationArray), false );
        
        }        
    }    
    

}
