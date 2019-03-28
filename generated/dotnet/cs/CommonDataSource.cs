/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.CommonDataSource
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("500B2588-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.CommonDataSource")]
    public interface CommonDataSource 
    { 
        global::Java.Io.PrintWriter GetLogWriter();
    
    
        int GetLoginTimeout();
    
    
        global::Java.Util.Logging.Logger GetParentLogger();
    
    
        void SetLogWriter(global::Java.Io.PrintWriter out_);
    
    
        void SetLoginTimeout(int seconds);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.CommonDataSource")]
    public class CommonDataSourceImpl :
        global::Java.Lang.Object,
        global::Javax.Sql.CommonDataSource
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
    
        static CommonDataSourceImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.CommonDataSource", typeof(global::Javax.Sql.CommonDataSource), typeof(global::Javax.Sql.CommonDataSourceImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getLoginTimeout", "()I", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.PrintWriter), "getLogWriter", "()Ljava/io/PrintWriter;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Logging.Logger), "getParentLogger", "()Ljava/util/logging/Logger;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setLoginTimeout", "(I)V", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setLogWriter", "(Ljava/io/PrintWriter;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public CommonDataSourceImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type CommonDataSourceImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.CommonDataSource</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.CommonDataSourceImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.CommonDataSourceImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public int GetLoginTimeout()
        {
            return _cmj_fun0.CallInt( this );
        }        
        
        public global::Java.Io.PrintWriter GetLogWriter()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.PrintWriter( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.PrintWriter)_cmj_fun1.CallObject( this, typeof(global::Java.Io.PrintWriter), false );
        
        }        
        
        public global::Java.Util.Logging.Logger GetParentLogger()
        {
            if(_cmj_fun2.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun2.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.Logging.Logger( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Logging.Logger)_cmj_fun2.CallObject( this, typeof(global::Java.Util.Logging.Logger), false );
        
        }        
        
        public void SetLoginTimeout(int seconds)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(seconds) )
            {
                _cmj_fun3.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetLogWriter(global::Java.Io.PrintWriter out_)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(out_) )
            {
                _cmj_fun4.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
