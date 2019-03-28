/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.DataSource
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("3531CB3D-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.DataSource")]
    public interface DataSource :
        global::Javax.Sql.CommonDataSource,
        global::Java.Sql.Wrapper
    { 
        global::Java.Sql.Connection GetConnection();
    
    
        global::Java.Sql.Connection GetConnection(string username, string password);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.DataSource")]
    public class DataSourceImpl :
        global::Javax.Sql.CommonDataSourceImpl,
        global::Javax.Sql.DataSource
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
    
        static DataSourceImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.DataSource", typeof(global::Javax.Sql.DataSource), typeof(global::Javax.Sql.DataSourceImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Connection), "getConnection", "()Ljava/sql/Connection;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Connection), "getConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljava/sql/Connection;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isWrapperFor", "(Ljava/lang/Class;)Z", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "unwrap", "(Ljava/lang/Class;)Ljava/lang/Object;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public DataSourceImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type DataSourceImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.DataSource</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.DataSourceImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.DataSourceImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Java.Sql.Connection GetConnection()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Connection)_cmj_fun0.CallObject( this, typeof(global::Java.Sql.Connection), false );
        
        }        
        
        public global::Java.Sql.Connection GetConnection(string username, string password)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(username).Add(password) )
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
        
        public bool IsWrapperFor(global::Java.Lang.Class iface)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(iface) )
            {
                return _cmj_fun2.CallBool( this, cmj_jmargs );
            }
        }        
        
        public object Unwrap(global::Java.Lang.Class iface)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(iface) )
            {
                return _cmj_fun3.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
    }    
    

}
