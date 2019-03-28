/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.XAConnection
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("AAA65B5F-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.XAConnection")]
    public interface XAConnection :
        global::Javax.Sql.PooledConnection
    { 
        global::Javax.Transaction.Xa.XAResource GetXAResource();
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.XAConnection")]
    public class XAConnectionImpl :
        global::Javax.Sql.PooledConnectionImpl,
        global::Javax.Sql.XAConnection
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
    
        static XAConnectionImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.XAConnection", typeof(global::Javax.Sql.XAConnection), typeof(global::Javax.Sql.XAConnectionImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Transaction.Xa.XAResource), "getXAResource", "()Ljavax/transaction/xa/XAResource;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public XAConnectionImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type XAConnectionImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.XAConnection</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.XAConnectionImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.XAConnectionImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Javax.Transaction.Xa.XAResource GetXAResource()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Javax.Transaction.Xa.XAResourceImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Javax.Transaction.Xa.XAResource)_cmj_fun0.CallObject( this, typeof(global::Javax.Transaction.Xa.XAResource), false );
        
        }        
    }    
    

}
