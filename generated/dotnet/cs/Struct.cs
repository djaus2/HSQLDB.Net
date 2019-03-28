/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.Struct
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("B8DF9B61-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.Struct")]
    public interface Struct 
    { 
        global::Java.Lang.ObjectArray GetAttributes();
    
    
        global::Java.Lang.ObjectArray GetAttributes(global::Java.Util.Map map);
    
    
        string GetSQLTypeName();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.Struct")]
    public class StructImpl :
        global::Java.Lang.Object,
        global::Java.Sql.Struct
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
    
        static StructImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.Struct", typeof(global::Java.Sql.Struct), typeof(global::Java.Sql.StructImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ObjectArray), "getAttributes", "()[Ljava/lang/Object;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ObjectArray), "getAttributes", "(Ljava/util/Map;)[Ljava/lang/Object;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getSQLTypeName", "()Ljava/lang/String;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public StructImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type StructImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.Struct</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.StructImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.StructImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Java.Lang.ObjectArray GetAttributes()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ObjectArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ObjectArray)_cmj_fun0.CallObject( this, typeof(global::Java.Lang.ObjectArray), false );
        
        }        
        
        public global::Java.Lang.ObjectArray GetAttributes(global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(map) )
            {
                if(_cmj_fun1.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun1.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Lang.ObjectArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Lang.ObjectArray)_cmj_fun1.CallObject( this, typeof(global::Java.Lang.ObjectArray), false, cmj_jmargs );
        
            }
        }        
        
        public string GetSQLTypeName()
        {
            return _cmj_fun2.CallString( this );
        }        
    }    
    

}
