/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.xml.transform.Result
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Xml.Transform
{
    [global::System.Runtime.InteropServices.GuidAttribute("F52412AE-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.xml.transform.Result")]
    public interface Result 
    { 
        string GetSystemId();
    
    
        void SetSystemId(string systemId);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.xml.transform.Result")]
    public class ResultImpl :
        global::Java.Lang.Object,
        global::Javax.Xml.Transform.Result
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
    
        static ResultImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.xml.transform.Result", typeof(global::Javax.Xml.Transform.Result), typeof(global::Javax.Xml.Transform.ResultImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getSystemId", "()Ljava/lang/String;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setSystemId", "(Ljava/lang/String;)V", false, false, false );
        }
    
        public const string     PI_DISABLE_OUTPUT_ESCAPING = "javax.xml.transform.disable-output-escaping";
        public const string     PI_ENABLE_OUTPUT_ESCAPING = "javax.xml.transform.enable-output-escaping";
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ResultImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ResultImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.xml.transform.Result</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Xml.Transform.ResultImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Xml.Transform.ResultImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public string GetSystemId()
        {
            return _cmj_fun0.CallString( this );
        }        
        
        public void SetSystemId(string systemId)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(systemId) )
            {
                _cmj_fun1.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
