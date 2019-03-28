/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.SQLXML
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("B6E0AEF5-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.SQLXML")]
    public interface SQLXML 
    { 
        void Free();
    
    
        global::Java.Io.InputStream GetBinaryStream();
    
    
        global::Java.Io.Reader GetCharacterStream();
    
    
        global::Javax.Xml.Transform.Source GetSource(global::Java.Lang.Class sourceClass);
    
    
        string GetString();
    
    
        global::Java.Io.OutputStream SetBinaryStream();
    
    
        global::Java.Io.Writer SetCharacterStream();
    
    
        global::Javax.Xml.Transform.Result SetResult(global::Java.Lang.Class resultClass);
    
    
        void SetString(string value);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.SQLXML")]
    public class SQLXMLImpl :
        global::Java.Lang.Object,
        global::Java.Sql.SQLXML
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
    
        static SQLXMLImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.SQLXML", typeof(global::Java.Sql.SQLXML), typeof(global::Java.Sql.SQLXMLImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "free", "()V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.InputStream), "getBinaryStream", "()Ljava/io/InputStream;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Reader), "getCharacterStream", "()Ljava/io/Reader;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Xml.Transform.Source), "getSource", "(Ljava/lang/Class;)Ljavax/xml/transform/Source;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getString", "()Ljava/lang/String;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.OutputStream), "setBinaryStream", "()Ljava/io/OutputStream;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Io.Writer), "setCharacterStream", "()Ljava/io/Writer;", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Javax.Xml.Transform.Result), "setResult", "(Ljava/lang/Class;)Ljavax/xml/transform/Result;", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setString", "(Ljava/lang/String;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public SQLXMLImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type SQLXMLImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.SQLXML</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.SQLXMLImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.SQLXMLImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void Free()
        {
            _cmj_fun0.CallVoid( this );
        }        
        
        public global::Java.Io.InputStream GetBinaryStream()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.InputStream.InputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.InputStream)_cmj_fun1.CallObject( this, typeof(global::Java.Io.InputStream), false );
        
        }        
        
        public global::Java.Io.Reader GetCharacterStream()
        {
            if(_cmj_fun2.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun2.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.Reader.ReaderImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.Reader)_cmj_fun2.CallObject( this, typeof(global::Java.Io.Reader), false );
        
        }        
        
        public global::Javax.Xml.Transform.Source GetSource(global::Java.Lang.Class sourceClass)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(sourceClass) )
            {
                if(_cmj_fun3.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun3.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Xml.Transform.SourceImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Xml.Transform.Source)_cmj_fun3.CallObject( this, typeof(global::Javax.Xml.Transform.Source), false, cmj_jmargs );
        
            }
        }        
        
        public string GetString()
        {
            return _cmj_fun4.CallString( this );
        }        
        
        public global::Java.Io.OutputStream SetBinaryStream()
        {
            if(_cmj_fun5.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun5.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.OutputStream.OutputStreamImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.OutputStream)_cmj_fun5.CallObject( this, typeof(global::Java.Io.OutputStream), false );
        
        }        
        
        public global::Java.Io.Writer SetCharacterStream()
        {
            if(_cmj_fun6.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun6.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Io.Writer.WriterImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Io.Writer)_cmj_fun6.CallObject( this, typeof(global::Java.Io.Writer), false );
        
        }        
        
        public global::Javax.Xml.Transform.Result SetResult(global::Java.Lang.Class resultClass)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(resultClass) )
            {
                if(_cmj_fun7.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun7.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Javax.Xml.Transform.ResultImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Javax.Xml.Transform.Result)_cmj_fun7.CallObject( this, typeof(global::Javax.Xml.Transform.Result), false, cmj_jmargs );
        
            }
        }        
        
        public void SetString(string value)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(value) )
            {
                _cmj_fun8.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
