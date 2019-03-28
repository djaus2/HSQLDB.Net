/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.RowSetInternal
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("3DF9C9DD-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.RowSetInternal")]
    public interface RowSetInternal 
    { 
        global::Java.Sql.Connection GetConnection();
    
    
        global::Java.Sql.ResultSet GetOriginal();
    
    
        global::Java.Sql.ResultSet GetOriginalRow();
    
    
        global::Java.Lang.ObjectArray GetParams();
    
    
        void SetMetaData(global::Javax.Sql.RowSetMetaData md);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.RowSetInternal")]
    public class RowSetInternalImpl :
        global::Java.Lang.Object,
        global::Javax.Sql.RowSetInternal
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
    
        static RowSetInternalImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.RowSetInternal", typeof(global::Javax.Sql.RowSetInternal), typeof(global::Javax.Sql.RowSetInternalImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.Connection), "getConnection", "()Ljava/sql/Connection;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getOriginal", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getOriginalRow", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ObjectArray), "getParams", "()[Ljava/lang/Object;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setMetaData", "(Ljavax/sql/RowSetMetaData;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public RowSetInternalImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type RowSetInternalImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.RowSetInternal</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.RowSetInternalImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.RowSetInternalImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public global::Java.Sql.Connection GetConnection()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ConnectionImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.Connection)_cmj_fun0.CallObject( this, typeof(global::Java.Sql.Connection), false );
        
        }        
        
        public global::Java.Sql.ResultSet GetOriginal()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun1.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public global::Java.Sql.ResultSet GetOriginalRow()
        {
            if(_cmj_fun2.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun2.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun2.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public global::Java.Lang.ObjectArray GetParams()
        {
            if(_cmj_fun3.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun3.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ObjectArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ObjectArray)_cmj_fun3.CallObject( this, typeof(global::Java.Lang.ObjectArray), false );
        
        }        
        
        public void SetMetaData(global::Javax.Sql.RowSetMetaData md)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(md) )
            {
                _cmj_fun4.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
