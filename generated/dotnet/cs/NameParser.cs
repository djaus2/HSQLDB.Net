/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.naming.NameParser
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Naming
{
    [global::System.Runtime.InteropServices.GuidAttribute("44471E38-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.naming.NameParser")]
    public interface NameParser 
    { 
        global::Javax.Naming.Name Parse(string name);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.naming.NameParser")]
    public class NameParserImpl :
        global::Java.Lang.Object,
        global::Javax.Naming.NameParser
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
    
        static NameParserImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.naming.NameParser", typeof(global::Javax.Naming.NameParser), typeof(global::Javax.Naming.NameParserImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Name), "parse", "(Ljava/lang/String;)Ljavax/naming/Name;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public NameParserImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type NameParserImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.naming.NameParser</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Naming.NameParserImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Naming.NameParserImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Javax.Naming.Name Parse(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun0.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun0.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Name)_cmj_fun0.CallObject( this, typeof(global::Javax.Naming.Name), false, cmj_jmargs );
        
            }
        }        
    }    
    

}
