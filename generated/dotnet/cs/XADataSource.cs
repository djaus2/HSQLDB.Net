/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.XADataSource
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("24BA38E6-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.XADataSource")]
    public interface XADataSource :
        global::Javax.Sql.CommonDataSource
    { 
        global::Javax.Sql.XAConnection GetXAConnection();
    
    
        global::Javax.Sql.XAConnection GetXAConnection(string user, string password);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.XADataSource")]
    public class XADataSourceImpl :
        global::Javax.Sql.CommonDataSourceImpl,
        global::Javax.Sql.XADataSource
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
    
        static XADataSourceImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.XADataSource", typeof(global::Javax.Sql.XADataSource), typeof(global::Javax.Sql.XADataSourceImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Sql.XAConnection), "getXAConnection", "()Ljavax/sql/XAConnection;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Sql.XAConnection), "getXAConnection", "(Ljava/lang/String;Ljava/lang/String;)Ljavax/sql/XAConnection;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public XADataSourceImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type XADataSourceImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.XADataSource</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.XADataSourceImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.XADataSourceImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Javax.Sql.XAConnection GetXAConnection()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Javax.Sql.XAConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Javax.Sql.XAConnection)_cmj_fun0.CallObject( this, typeof(global::Javax.Sql.XAConnection), false );
        
        }        
        
        public global::Javax.Sql.XAConnection GetXAConnection(string user, string password)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(user).Add(password) )
            {
                if(_cmj_fun1.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun1.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Sql.XAConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Sql.XAConnection)_cmj_fun1.CallObject( this, typeof(global::Javax.Sql.XAConnection), false, cmj_jmargs );
        
            }
        }        
    }    
    

}
