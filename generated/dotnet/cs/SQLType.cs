/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.SQLType
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("2534081C-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.SQLType")]
    public interface SQLType 
    { 
        string GetName();
    
    
        string GetVendor();
    
    
        global::Java.Lang.Integer GetVendorTypeNumber();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.SQLType")]
    public class SQLTypeImpl :
        global::Java.Lang.Object,
        global::Java.Sql.SQLType
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
    
        static SQLTypeImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.SQLType", typeof(global::Java.Sql.SQLType), typeof(global::Java.Sql.SQLTypeImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getVendor", "()Ljava/lang/String;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Integer), "getVendorTypeNumber", "()Ljava/lang/Integer;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public SQLTypeImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type SQLTypeImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.SQLType</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.SQLTypeImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.SQLTypeImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public string GetName()
        {
            return _cmj_fun0.CallString( this );
        }        
        
        public string GetVendor()
        {
            return _cmj_fun1.CallString( this );
        }        
        
        public global::Java.Lang.Integer GetVendorTypeNumber()
        {
            long    jnet_ref = (long)_cmj_fun2.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Integer( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }        
    }    
    

}
