/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.RowSetReader
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("1B25A3E3-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.RowSetReader")]
    public interface RowSetReader 
    { 
        void ReadData(global::Javax.Sql.RowSetInternal caller);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.RowSetReader")]
    public class RowSetReaderImpl :
        global::Java.Lang.Object,
        global::Javax.Sql.RowSetReader
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
    
        static RowSetReaderImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.RowSetReader", typeof(global::Javax.Sql.RowSetReader), typeof(global::Javax.Sql.RowSetReaderImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "readData", "(Ljavax/sql/RowSetInternal;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public RowSetReaderImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type RowSetReaderImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.RowSetReader</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.RowSetReaderImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.RowSetReaderImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void ReadData(global::Javax.Sql.RowSetInternal caller)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(caller) )
            {
                _cmj_fun0.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
