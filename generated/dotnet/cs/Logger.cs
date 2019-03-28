/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.util.logging.Logger
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Java.Util.Logging
{
    [global::System.Runtime.InteropServices.GuidAttribute("51DC68DF-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.util.logging.Logger")]
    public class Logger :
        global::Java.Lang.Object
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldGlobal;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun6;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun7;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun8;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun9;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun10;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun11;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun12;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun13;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun14;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun15;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun16;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun17;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun18;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun19;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun20;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun21;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun22;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun23;
    
        static Logger()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.util.logging.Logger", typeof(global::Java.Util.Logging.Logger));
            _cmj_fldGlobal = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Util.Logging.Logger), "global", "Ljava/util/logging/Logger;", true, true );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "config", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "entering", "(Ljava/lang/String;Ljava/lang/String;)V", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "entering", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "entering", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/Object;)V", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "exiting", "(Ljava/lang/String;Ljava/lang/String;)V", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "exiting", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "fine", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "finer", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "finest", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Logging.Logger), "getAnonymousLogger", "()Ljava/util/logging/Logger;", true, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Logging.Logger), "getAnonymousLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", true, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Logging.Logger), "getGlobal", "()Ljava/util/logging/Logger;", true, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Logging.Logger), "getLogger", "(Ljava/lang/String;)Ljava/util/logging/Logger;", true, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Logging.Logger), "getLogger", "(Ljava/lang/String;Ljava/lang/String;)Ljava/util/logging/Logger;", true, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Logging.Logger), "getParent", "()Ljava/util/logging/Logger;", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getResourceBundleName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "getUseParentHandlers", "()Z", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "info", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setParent", "(Ljava/util/logging/Logger;)V", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setUseParentHandlers", "(Z)V", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "severe", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "throwing", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Throwable;)V", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "warning", "(Ljava/lang/String;)V", false, false, false );
        }
    
        public const string     GLOBAL_LOGGER_NAME = "global";
        public static global::Java.Util.Logging.Logger Global
        {
            get
            {
                return (global::Java.Util.Logging.Logger)_cmj_fldGlobal.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Logger( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type Logger if the given proxy instance
        /// represents a Java object that is type-compatible with java.util.logging.Logger</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Util.Logging.Logger From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Util.Logging.Logger(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public void Config(string msg)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(msg) )
            {
                _cmj_fun0.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Entering(string sourceClass, string sourceMethod)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sourceClass).Add(sourceMethod) )
            {
                _cmj_fun1.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Entering(string sourceClass, string sourceMethod, object param1)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sourceClass).Add(sourceMethod).Add(param1) )
            {
                _cmj_fun2.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Entering(string sourceClass, string sourceMethod, global::Java.Lang.ObjectArray params_)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sourceClass).Add(sourceMethod).Add(params_) )
            {
                _cmj_fun3.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Exiting(string sourceClass, string sourceMethod)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sourceClass).Add(sourceMethod) )
            {
                _cmj_fun4.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Exiting(string sourceClass, string sourceMethod, object result)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sourceClass).Add(sourceMethod).Add(result) )
            {
                _cmj_fun5.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Fine(string msg)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(msg) )
            {
                _cmj_fun6.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Finer(string msg)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(msg) )
            {
                _cmj_fun7.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Finest(string msg)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(msg) )
            {
                _cmj_fun8.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public static global::Java.Util.Logging.Logger GetAnonymousLogger()
        {
            if(_cmj_fun9.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun9.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.Logging.Logger( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Logging.Logger)_cmj_fun9.CallObject( null, typeof(global::Java.Util.Logging.Logger), false );
        
        }    
    
        public static global::Java.Util.Logging.Logger GetAnonymousLogger(string resourceBundleName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(resourceBundleName) )
            {
                if(_cmj_fun10.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun10.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.Logging.Logger( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.Logging.Logger)_cmj_fun10.CallObject( null, typeof(global::Java.Util.Logging.Logger), false, cmj_jmargs );
        
            }
        }    
    
        public static global::Java.Util.Logging.Logger GetGlobal()
        {
            if(_cmj_fun11.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun11.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Util.Logging.Logger( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Logging.Logger)_cmj_fun11.CallObject( null, typeof(global::Java.Util.Logging.Logger), false );
        
        }    
    
        public static global::Java.Util.Logging.Logger GetLogger(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun12.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun12.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.Logging.Logger( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.Logging.Logger)_cmj_fun12.CallObject( null, typeof(global::Java.Util.Logging.Logger), false, cmj_jmargs );
        
            }
        }    
    
        public static global::Java.Util.Logging.Logger GetLogger(string name, string resourceBundleName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(resourceBundleName) )
            {
                if(_cmj_fun13.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun13.CallObject( null, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Util.Logging.Logger( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Util.Logging.Logger)_cmj_fun13.CallObject( null, typeof(global::Java.Util.Logging.Logger), false, cmj_jmargs );
        
            }
        }    
    
        public string GetName()
        {
            return _cmj_fun14.CallString( this );
        }    
    
        public global::Java.Util.Logging.Logger GetParent()
        {
            if(_cmj_fun15.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun15.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.Logging.Logger( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Logging.Logger)_cmj_fun15.CallObject( this, typeof(global::Java.Util.Logging.Logger), false );
        
        }    
    
        public string GetResourceBundleName()
        {
            return _cmj_fun16.CallString( this );
        }    
    
        public bool GetUseParentHandlers()
        {
            return _cmj_fun17.CallBool( this );
        }    
    
        public void Info(string msg)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(msg) )
            {
                _cmj_fun18.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetParent(global::Java.Util.Logging.Logger parent)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(parent) )
            {
                _cmj_fun19.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void SetUseParentHandlers(bool useParentHandlers)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(useParentHandlers) )
            {
                _cmj_fun20.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Severe(string msg)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(msg) )
            {
                _cmj_fun21.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Throwing(string sourceClass, string sourceMethod, global::Java.Lang.Throwable thrown)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sourceClass).Add(sourceMethod).Add(thrown) )
            {
                _cmj_fun22.CallVoid( this, cmj_jmargs );
            }
        }    
    
        public void Warning(string msg)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(msg) )
            {
                _cmj_fun23.CallVoid( this, cmj_jmargs );
            }
        }    
    
    
    }

}
