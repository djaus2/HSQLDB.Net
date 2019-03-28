/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.PooledConnection
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("01B8A7D1-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.PooledConnection")]
    public interface PooledConnection 
    { 
        void AddConnectionEventListener(global::Javax.Sql.ConnectionEventListener listener);
    
    
        void AddStatementEventListener(global::Javax.Sql.StatementEventListener listener);
    
    
        void Close();
    
    
        global::Java.Sql.Connection GetConnection();
    
    
        void RemoveConnectionEventListener(global::Javax.Sql.ConnectionEventListener listener);
    
    
        void RemoveStatementEventListener(global::Javax.Sql.StatementEventListener listener);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.PooledConnection")]
    public class PooledConnectionImpl :
        global::Java.Lang.Object,
        global::Javax.Sql.PooledConnection
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
    
        static PooledConnectionImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.PooledConnection", typeof(global::Javax.Sql.PooledConnection), typeof(global::Javax.Sql.PooledConnectionImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "addConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "addStatementEventListener", "(Ljavax/sql/StatementEventListener;)V", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "close", "()V", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Connection), "getConnection", "()Ljava/sql/Connection;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "removeConnectionEventListener", "(Ljavax/sql/ConnectionEventListener;)V", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "removeStatementEventListener", "(Ljavax/sql/StatementEventListener;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public PooledConnectionImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type PooledConnectionImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.PooledConnection</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.PooledConnectionImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.PooledConnectionImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void AddConnectionEventListener(global::Javax.Sql.ConnectionEventListener listener)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(listener, typeof(global::Javax.Sql.ConnectionEventListener)) )
            {
                _cmj_fun0.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void AddStatementEventListener(global::Javax.Sql.StatementEventListener listener)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(listener, typeof(global::Javax.Sql.StatementEventListener)) )
            {
                _cmj_fun1.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void Close()
        {
            _cmj_fun2.CallVoid( this );
        }        
        
        public global::Java.Sql.Connection GetConnection()
        {
            if(_cmj_fun3.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun3.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Connection)_cmj_fun3.CallObject( this, typeof(global::Java.Sql.Connection), false );
        
        }        
        
        public void RemoveConnectionEventListener(global::Javax.Sql.ConnectionEventListener listener)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(listener, typeof(global::Javax.Sql.ConnectionEventListener)) )
            {
                _cmj_fun4.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void RemoveStatementEventListener(global::Javax.Sql.StatementEventListener listener)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(listener, typeof(global::Javax.Sql.StatementEventListener)) )
            {
                _cmj_fun5.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
