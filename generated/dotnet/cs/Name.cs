/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.naming.Name
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Naming
{
    [global::System.Runtime.InteropServices.GuidAttribute("104124B9-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.naming.Name")]
    public interface Name :
        global::Java.Lang.Comparable,
        global::Java.Io.Serializable,
        global::Java.Lang.Cloneable,
        global::System.Runtime.Serialization.ISerializable
    
    { 
        global::Javax.Naming.Name Add(string comp);
    
    
        global::Javax.Naming.Name Add(int posn, string comp);
    
    
        global::Javax.Naming.Name AddAll(global::Javax.Naming.Name suffix);
    
    
        global::Javax.Naming.Name AddAll(int posn, global::Javax.Naming.Name n);
    
    
        object Clone();
    
    
        bool EndsWith(global::Javax.Naming.Name n);
    
    
        string Get(int posn);
    
    
        global::Java.Util.Enumeration GetAll();
    
    
        global::Javax.Naming.Name GetPrefix(int posn);
    
    
        global::Javax.Naming.Name GetSuffix(int posn);
    
    
        bool IsEmpty();
    
    
        object Remove(int posn);
    
    
        int Size();
    
    
        bool StartsWith(global::Javax.Naming.Name n);
    }
    
    
    [global::System.Serializable]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.naming.Name")]
    public class NameImpl :
        global::Java.Lang.ComparableImpl,
        global::Javax.Naming.Name,
        global::System.Runtime.Serialization.ISerializable
    
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
    
        static NameImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.naming.Name", typeof(global::Javax.Naming.Name), typeof(global::Javax.Naming.NameImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Name), "add", "(Ljava/lang/String;)Ljavax/naming/Name;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Name), "add", "(ILjava/lang/String;)Ljavax/naming/Name;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Name), "addAll", "(Ljavax/naming/Name;)Ljavax/naming/Name;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Name), "addAll", "(ILjavax/naming/Name;)Ljavax/naming/Name;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "clone", "()Ljava/lang/Object;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "endsWith", "(Ljavax/naming/Name;)Z", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "get", "(I)Ljava/lang/String;", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Util.Enumeration), "getAll", "()Ljava/util/Enumeration;", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Name), "getPrefix", "(I)Ljavax/naming/Name;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Naming.Name), "getSuffix", "(I)Ljavax/naming/Name;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isEmpty", "()Z", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "remove", "(I)Ljava/lang/Object;", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "size", "()I", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "startsWith", "(Ljavax/naming/Name;)Z", false, false, false );
        }
    
        public const long       SerialVersionUID = -3617482732056931635L;
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public NameImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        ///<summary>Reinflate a serialized object.</summary>
        protected NameImpl( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
        /// <summary>Returns an instance of type NameImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.naming.Name</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Naming.NameImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Naming.NameImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Javax.Naming.Name Add(string comp)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(comp) )
            {
                if(_cmj_fun0.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun0.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Name)_cmj_fun0.CallObject( this, typeof(global::Javax.Naming.Name), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.Name Add(int posn, string comp)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(posn).Add(comp) )
            {
                if(_cmj_fun1.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun1.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Name)_cmj_fun1.CallObject( this, typeof(global::Javax.Naming.Name), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.Name AddAll(global::Javax.Naming.Name suffix)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(suffix) )
            {
                if(_cmj_fun2.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun2.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Name)_cmj_fun2.CallObject( this, typeof(global::Javax.Naming.Name), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.Name AddAll(int posn, global::Javax.Naming.Name n)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(posn).Add(n) )
            {
                if(_cmj_fun3.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun3.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Name)_cmj_fun3.CallObject( this, typeof(global::Javax.Naming.Name), false, cmj_jmargs );
        
            }
        }        
        
        public object Clone()
        {
            return _cmj_fun4.CallObject( this, typeof(object), false );
        }        
        
        public bool EndsWith(global::Javax.Naming.Name n)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(n) )
            {
                return _cmj_fun5.CallBool( this, cmj_jmargs );
            }
        }        
        
        public string Get(int posn)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(posn) )
            {
                return _cmj_fun6.CallString( this, cmj_jmargs );
            }
        }        
        
        public global::Java.Util.Enumeration GetAll()
        {
            if(_cmj_fun7.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun7.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Util.EnumerationImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Util.Enumeration)_cmj_fun7.CallObject( this, typeof(global::Java.Util.Enumeration), false );
        
        }        
        
        public global::Javax.Naming.Name GetPrefix(int posn)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(posn) )
            {
                if(_cmj_fun8.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun8.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Name)_cmj_fun8.CallObject( this, typeof(global::Javax.Naming.Name), false, cmj_jmargs );
        
            }
        }        
        
        public global::Javax.Naming.Name GetSuffix(int posn)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(posn) )
            {
                if(_cmj_fun9.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun9.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Naming.NameImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Naming.Name)_cmj_fun9.CallObject( this, typeof(global::Javax.Naming.Name), false, cmj_jmargs );
        
            }
        }        
        
        public bool IsEmpty()
        {
            return _cmj_fun10.CallBool( this );
        }        
        
        public object Remove(int posn)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(posn) )
            {
                return _cmj_fun11.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public int Size()
        {
            return _cmj_fun12.CallInt( this );
        }        
        
        public bool StartsWith(global::Javax.Naming.Name n)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(n) )
            {
                return _cmj_fun13.CallBool( this, cmj_jmargs );
            }
        }        
    }    
    

}
