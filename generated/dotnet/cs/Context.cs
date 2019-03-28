/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.naming.Context
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Naming
{
    [global::System.Runtime.InteropServices.GuidAttribute("5EE634C1-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.naming.Context")]
    public interface Context 
    { 
        object AddToEnvironment(string propName, object propVal);
    
    
        void Bind(string name, object obj);
    
    
        void Bind(global::Javax.Naming.Name name, object obj);
    
    
        void Close();
    
    
        string ComposeName(string name, string prefix);
    
    
        global::Javax.Naming.Name ComposeName(global::Javax.Naming.Name name, global::Javax.Naming.Name prefix);
    
    
        global::Javax.Naming.Context CreateSubcontext(string name);
    
    
        global::Javax.Naming.Context CreateSubcontext(global::Javax.Naming.Name name);
    
    
        void DestroySubcontext(string name);
    
    
        void DestroySubcontext(global::Javax.Naming.Name name);
    
    
        global::Java.Util.Hashtable GetEnvironment();
    
    
        string GetNameInNamespace();
    
    
        global::Javax.Naming.NameParser GetNameParser(string name);
    
    
        global::Javax.Naming.NameParser GetNameParser(global::Javax.Naming.Name name);
    
    
        global::Javax.Naming.NamingEnumeration List(string name);
    
    
        global::Javax.Naming.NamingEnumeration List(global::Javax.Naming.Name name);
    
    
        global::Javax.Naming.NamingEnumeration ListBindings(string name);
    
    
        global::Javax.Naming.NamingEnumeration ListBindings(global::Javax.Naming.Name name);
    
    
        object Lookup(string name);
    
    
        object Lookup(global::Javax.Naming.Name name);
    
    
        object LookupLink(string name);
    
    
        object LookupLink(global::Javax.Naming.Name name);
    
    
        void Rebind(string name, object obj);
    
    
        void Rebind(global::Javax.Naming.Name name, object obj);
    
    
        object RemoveFromEnvironment(string propName);
    
    
        void Rename(string oldName, string newName);
    
    
        void Rename(global::Javax.Naming.Name oldName, global::Javax.Naming.Name newName);
    
    
        void Unbind(string name);
    
    
        void Unbind(global::Javax.Naming.Name name);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.naming.Context")]
    public class ContextImpl :
        global::Java.Lang.Object,
        global::Javax.Naming.Context
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
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
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun24;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun25;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun26;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun27;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun28;
    
        static ContextImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.naming.Context", typeof(global::Javax.Naming.Context), typeof(global::Javax.Naming.ContextImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "addToEnvironment", "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "bind", "(Ljava/lang/String;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "bind", "(Ljavax/naming/Name;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "close", "()V", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "composeName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Name), "composeName", "(Ljavax/naming/Name;Ljavax/naming/Name;)Ljavax/naming/Name;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Context), "createSubcontext", "(Ljava/lang/String;)Ljavax/naming/Context;", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Context), "createSubcontext", "(Ljavax/naming/Name;)Ljavax/naming/Context;", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "destroySubcontext", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "destroySubcontext", "(Ljavax/naming/Name;)V", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Hashtable), "getEnvironment", "()Ljava/util/Hashtable;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getNameInNamespace", "()Ljava/lang/String;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.NameParser), "getNameParser", "(Ljava/lang/String;)Ljavax/naming/NameParser;", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.NameParser), "getNameParser", "(Ljavax/naming/Name;)Ljavax/naming/NameParser;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.NamingEnumeration), "list", "(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.NamingEnumeration), "list", "(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.NamingEnumeration), "listBindings", "(Ljava/lang/String;)Ljavax/naming/NamingEnumeration;", false, false, false );
            _cmj_fun17 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.NamingEnumeration), "listBindings", "(Ljavax/naming/Name;)Ljavax/naming/NamingEnumeration;", false, false, false );
            _cmj_fun18 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "lookup", "(Ljava/lang/String;)Ljava/lang/Object;", false, false, false );
            _cmj_fun19 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "lookup", "(Ljavax/naming/Name;)Ljava/lang/Object;", false, false, false );
            _cmj_fun20 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "lookupLink", "(Ljava/lang/String;)Ljava/lang/Object;", false, false, false );
            _cmj_fun21 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "lookupLink", "(Ljavax/naming/Name;)Ljava/lang/Object;", false, false, false );
            _cmj_fun22 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "rebind", "(Ljava/lang/String;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun23 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "rebind", "(Ljavax/naming/Name;Ljava/lang/Object;)V", false, false, false );
            _cmj_fun24 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "removeFromEnvironment", "(Ljava/lang/String;)Ljava/lang/Object;", false, false, false );
            _cmj_fun25 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "rename", "(Ljava/lang/String;Ljava/lang/String;)V", false, false, false );
            _cmj_fun26 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "rename", "(Ljavax/naming/Name;Ljavax/naming/Name;)V", false, false, false );
            _cmj_fun27 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "unbind", "(Ljava/lang/String;)V", false, false, false );
            _cmj_fun28 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "unbind", "(Ljavax/naming/Name;)V", false, false, false );
        }
    
        public const string     APPLET = "java.naming.applet";
        public const string     AUTHORITATIVE = "java.naming.authoritative";
        public const string     BATCHSIZE = "java.naming.batchsize";
        public const string     DNS_URL = "java.naming.dns.url";
        public const string     INITIAL_CONTEXT_FACTORY = "java.naming.factory.initial";
        public const string     LANGUAGE = "java.naming.language";
        public const string     OBJECT_FACTORIES = "java.naming.factory.object";
        public const string     PROVIDER_URL = "java.naming.provider.url";
        public const string     REFERRAL = "java.naming.referral";
        public const string     SECURITY_AUTHENTICATION = "java.naming.security.authentication";
        public const string     SECURITY_CREDENTIALS = "java.naming.security.credentials";
        public const string     SECURITY_PRINCIPAL = "java.naming.security.principal";
        public const string     SECURITY_PROTOCOL = "java.naming.security.protocol";
        public const string     STATE_FACTORIES = "java.naming.factory.state";
        public const string     URL_PKG_PREFIXES = "java.naming.factory.url.pkgs";
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ContextImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ContextImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.naming.Context</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Naming.ContextImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Naming.ContextImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public object AddToEnvironment(string propName, object propVal)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(propName).Add(propVal) )
            {
                return _cmj_fun0.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public void Bind(string name, object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(obj) )
            {
                _cmj_fun1.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void Bind(global::Javax.Naming.Name name, object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(obj) )
            {
                _cmj_fun2.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void Close()
        {
            _cmj_fun3.CallVoid( this );
        }        
        
        public string ComposeName(string name, string prefix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(prefix) )
            {
                return _cmj_fun4.CallString( this, cmj_jmargs );
            }
        }        
        
        public global::Javax.Naming.Name ComposeName(global::Javax.Naming.Name name, global::Javax.Naming.Name prefix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(prefix) )
            {
                if(_cmj_fun5.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun5.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Name)_cmj_fun5.CallObject( this, typeof(global::Javax.Naming.Name), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.Context CreateSubcontext(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun6.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun6.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.ContextImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Context)_cmj_fun6.CallObject( this, typeof(global::Javax.Naming.Context), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.Context CreateSubcontext(global::Javax.Naming.Name name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun7.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun7.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.ContextImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Context)_cmj_fun7.CallObject( this, typeof(global::Javax.Naming.Context), false, cmj_jmargs );
        
            }
        }        
        
        public void DestroySubcontext(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                _cmj_fun8.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void DestroySubcontext(global::Javax.Naming.Name name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                _cmj_fun9.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Util.Hashtable GetEnvironment()
        {
            if(_cmj_fun10.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun10.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.Hashtable( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Hashtable)_cmj_fun10.CallObject( this, typeof(global::Java.Util.Hashtable), false );
        
        }        
        
        public string GetNameInNamespace()
        {
            return _cmj_fun11.CallString( this );
        }        
        
        public global::Javax.Naming.NameParser GetNameParser(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun12.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun12.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameParserImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.NameParser)_cmj_fun12.CallObject( this, typeof(global::Javax.Naming.NameParser), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.NameParser GetNameParser(global::Javax.Naming.Name name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun13.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun13.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameParserImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.NameParser)_cmj_fun13.CallObject( this, typeof(global::Javax.Naming.NameParser), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.NamingEnumeration List(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun14.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun14.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NamingEnumerationImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.NamingEnumeration)_cmj_fun14.CallObject( this, typeof(global::Javax.Naming.NamingEnumeration), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.NamingEnumeration List(global::Javax.Naming.Name name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun15.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun15.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NamingEnumerationImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.NamingEnumeration)_cmj_fun15.CallObject( this, typeof(global::Javax.Naming.NamingEnumeration), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.NamingEnumeration ListBindings(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun16.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun16.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NamingEnumerationImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.NamingEnumeration)_cmj_fun16.CallObject( this, typeof(global::Javax.Naming.NamingEnumeration), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.NamingEnumeration ListBindings(global::Javax.Naming.Name name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                if(_cmj_fun17.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun17.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NamingEnumerationImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.NamingEnumeration)_cmj_fun17.CallObject( this, typeof(global::Javax.Naming.NamingEnumeration), false, cmj_jmargs );
        
            }
        }        
        
        public object Lookup(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                return _cmj_fun18.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object Lookup(global::Javax.Naming.Name name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                return _cmj_fun19.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object LookupLink(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                return _cmj_fun20.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object LookupLink(global::Javax.Naming.Name name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                return _cmj_fun21.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public void Rebind(string name, object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(obj) )
            {
                _cmj_fun22.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void Rebind(global::Javax.Naming.Name name, object obj)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name).Add(obj) )
            {
                _cmj_fun23.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public object RemoveFromEnvironment(string propName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(propName) )
            {
                return _cmj_fun24.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public void Rename(string oldName, string newName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(oldName).Add(newName) )
            {
                _cmj_fun25.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void Rename(global::Javax.Naming.Name oldName, global::Javax.Naming.Name newName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(oldName).Add(newName) )
            {
                _cmj_fun26.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void Unbind(string name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                _cmj_fun27.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void Unbind(global::Javax.Naming.Name name)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(name) )
            {
                _cmj_fun28.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
