/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.Driver
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("9F26A7B4-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.Driver")]
    public interface Driver 
    { 
        bool AcceptsURL(string url);
    
    
        global::Java.Sql.Connection Connect(string url, global::Java.Util.Properties info);
    
    
        int GetMajorVersion();
    
    
        int GetMinorVersion();
    
    
        global::Java.Util.Logging.Logger GetParentLogger();
    
    
        global::Java.Sql.DriverPropertyInfoArray GetPropertyInfo(string url, global::Java.Util.Properties info);
    
    
        bool JdbcCompliant();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.Driver")]
    public class DriverImpl :
        global::Java.Lang.Object,
        global::Java.Sql.Driver
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun6;
    
        static DriverImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.Driver", typeof(global::Java.Sql.Driver), typeof(global::Java.Sql.DriverImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "acceptsURL", "(Ljava/lang/String;)Z", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Connection), "connect", "(Ljava/lang/String;Ljava/util/Properties;)Ljava/sql/Connection;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMajorVersion", "()I", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getMinorVersion", "()I", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Logging.Logger), "getParentLogger", "()Ljava/util/logging/Logger;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.DriverPropertyInfoArray), "getPropertyInfo", "(Ljava/lang/String;Ljava/util/Properties;)[Ljava/sql/DriverPropertyInfo;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "jdbcCompliant", "()Z", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public DriverImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type DriverImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.Driver</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.DriverImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.DriverImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public bool AcceptsURL(string url)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(url) )
            {
                return _cmj_fun0.CallBool( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Sql.Connection Connect(string url, global::Java.Util.Properties info)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(url).Add(info) )
            {
                if(_cmj_fun1.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun1.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.Connection)_cmj_fun1.CallObject( this, typeof(global::Java.Sql.Connection), false, cmj_jmargs );
        
            }
        }        
        
        public int GetMajorVersion()
        {
            return _cmj_fun2.CallInt( this );
        }        
        
        public int GetMinorVersion()
        {
            return _cmj_fun3.CallInt( this );
        }        
        
        public global::Java.Util.Logging.Logger GetParentLogger()
        {
            if(_cmj_fun4.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun4.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.Logging.Logger( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Logging.Logger)_cmj_fun4.CallObject( this, typeof(global::Java.Util.Logging.Logger), false );
        
        }        
        
        public global::Java.Sql.DriverPropertyInfoArray GetPropertyInfo(string url, global::Java.Util.Properties info)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(url).Add(info) )
            {
                if(_cmj_fun5.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun5.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.DriverPropertyInfoArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.DriverPropertyInfoArray)_cmj_fun5.CallObject( this, typeof(global::Java.Sql.DriverPropertyInfoArray), false, cmj_jmargs );
        
            }
        }        
        
        public bool JdbcCompliant()
        {
            return _cmj_fun6.CallBool( this );
        }        
    }    
    

}
