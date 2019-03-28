/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.transaction.xa.XAResource
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Transaction.Xa
{
    [global::System.Runtime.InteropServices.GuidAttribute("A1422174-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.transaction.xa.XAResource")]
    public interface XAResource 
    { 
        int GetTransactionTimeout();
    
    
        bool IsSameRM(global::Javax.Transaction.Xa.XAResource arg0);
    
    
        bool SetTransactionTimeout(int arg0);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.transaction.xa.XAResource")]
    public class XAResourceImpl :
        global::Java.Lang.Object,
        global::Javax.Transaction.Xa.XAResource
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
    
        static XAResourceImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.transaction.xa.XAResource", typeof(global::Javax.Transaction.Xa.XAResource), typeof(global::Javax.Transaction.Xa.XAResourceImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getTransactionTimeout", "()I", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isSameRM", "(Ljavax/transaction/xa/XAResource;)Z", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "setTransactionTimeout", "(I)Z", false, false, false );
        }
    
        public const int        TMENDRSCAN = 8388608;
        public const int        TMFAIL = 536870912;
        public const int        TMJOIN = 2097152;
        public const int        TMNOFLAGS = 0;
        public const int        TMONEPHASE = 1073741824;
        public const int        TMRESUME = 134217728;
        public const int        TMSTARTRSCAN = 16777216;
        public const int        TMSUCCESS = 67108864;
        public const int        TMSUSPEND = 33554432;
        public const int        XA_OK = 0;
        public const int        XA_RDONLY = 3;
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public XAResourceImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type XAResourceImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.transaction.xa.XAResource</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Transaction.Xa.XAResourceImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Transaction.Xa.XAResourceImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public int GetTransactionTimeout()
        {
            return _cmj_fun0.CallInt( this );
        }        
        
        public bool IsSameRM(global::Javax.Transaction.Xa.XAResource arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                return _cmj_fun1.CallBool( this, cmj_jmargs );
            }
        }        
        
        public bool SetTransactionTimeout(int arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                return _cmj_fun2.CallBool( this, cmj_jmargs );
            }
        }        
    }    
    

}
