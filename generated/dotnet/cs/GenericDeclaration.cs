/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.reflect.GenericDeclaration
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang.Reflect
{
    [global::System.Runtime.InteropServices.GuidAttribute("A27DA268-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.lang.reflect.GenericDeclaration")]
    public interface GenericDeclaration :
        global::Java.Lang.Reflect.AnnotatedElement
    { 
        global::Java.Lang.Reflect.TypeVariableArray GetTypeParameters();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.reflect.GenericDeclaration")]
    public class GenericDeclarationImpl :
        global::Java.Lang.Reflect.AnnotatedElementImpl,
        global::Java.Lang.Reflect.GenericDeclaration
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
    
        static GenericDeclarationImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.reflect.GenericDeclaration", typeof(global::Java.Lang.Reflect.GenericDeclaration), typeof(global::Java.Lang.Reflect.GenericDeclarationImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.TypeVariableArray), "getTypeParameters", "()[Ljava/lang/reflect/TypeVariable;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public GenericDeclarationImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type GenericDeclarationImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.reflect.GenericDeclaration</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Reflect.GenericDeclarationImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Reflect.GenericDeclarationImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Java.Lang.Reflect.TypeVariableArray GetTypeParameters()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.TypeVariableArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.TypeVariableArray)_cmj_fun0.CallObject( this, typeof(global::Java.Lang.Reflect.TypeVariableArray), false );
        
        }        
    }    
    

}
