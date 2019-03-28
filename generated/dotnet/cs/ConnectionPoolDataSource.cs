/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.ConnectionPoolDataSource
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("7103E0F7-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.ConnectionPoolDataSource")]
    public interface ConnectionPoolDataSource :
        global::Javax.Sql.CommonDataSource
    { 
        global::Javax.Sql.PooledConnection GetPooledConnection();
    
    
        global::Javax.Sql.PooledConnection GetPooledConnection(string user, string password);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.ConnectionPoolDataSource")]
    public class ConnectionPoolDataSourceImpl :
        global::Javax.Sql.CommonDataSourceImpl,
        global::Javax.Sql.ConnectionPoolDataSource
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
    
        static ConnectionPoolDataSourceImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.ConnectionPoolDataSource", typeof(global::Javax.Sql.ConnectionPoolDataSource), typeof(global::Javax.Sql.ConnectionPoolDataSourceImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Sql.PooledConnection), "getPooledConnection", "()Ljavax/sql/PooledConnection;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Sql.PooledConnection), "getPooledConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/sql/PooledConnection;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ConnectionPoolDataSourceImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ConnectionPoolDataSourceImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.ConnectionPoolDataSource</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.ConnectionPoolDataSourceImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.ConnectionPoolDataSourceImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Javax.Sql.PooledConnection GetPooledConnection()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Javax.Sql.PooledConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Javax.Sql.PooledConnection)_cmj_fun0.CallObject( this, typeof(global::Javax.Sql.PooledConnection), false );
        
        }        
        
        public global::Javax.Sql.PooledConnection GetPooledConnection(string user, string password)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(user).Add(password) )
            {
                if(_cmj_fun1.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun1.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Sql.PooledConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Sql.PooledConnection)_cmj_fun1.CallObject( this, typeof(global::Javax.Sql.PooledConnection), false, cmj_jmargs );
        
            }
        }        
    }    
    

}
