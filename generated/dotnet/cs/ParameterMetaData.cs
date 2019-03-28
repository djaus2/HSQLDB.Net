/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.ParameterMetaData
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("1FCF4F0C-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.ParameterMetaData")]
    public interface ParameterMetaData :
        global::Java.Sql.Wrapper
    { 
        string GetParameterClassName(int param);
    
    
        int GetParameterCount();
    
    
        int GetParameterMode(int param);
    
    
        int GetParameterType(int param);
    
    
        string GetParameterTypeName(int param);
    
    
        int GetPrecision(int param);
    
    
        int GetScale(int param);
    
    
        int IsNullable(int param);
    
    
        bool IsSigned(int param);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.ParameterMetaData")]
    public class ParameterMetaDataImpl :
        global::Java.Sql.WrapperImpl,
        global::Java.Sql.ParameterMetaData
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
    
        static ParameterMetaDataImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.ParameterMetaData", typeof(global::Java.Sql.ParameterMetaData), typeof(global::Java.Sql.ParameterMetaDataImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getParameterClassName", "(I)Ljava/lang/String;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getParameterCount", "()I", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getParameterMode", "(I)I", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getParameterType", "(I)I", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getParameterTypeName", "(I)Ljava/lang/String;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getPrecision", "(I)I", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getScale", "(I)I", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "isNullable", "(I)I", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isSigned", "(I)Z", false, false, false );
        }
    
        public const int        ParameterModeIn = 1;
        public const int        ParameterModeInOut = 2;
        public const int        ParameterModeOut = 4;
        public const int        ParameterModeUnknown = 0;
        public const int        ParameterNoNulls = 0;
        public const int        ParameterNullable = 1;
        public const int        ParameterNullableUnknown = 2;
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ParameterMetaDataImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ParameterMetaDataImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.ParameterMetaData</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.ParameterMetaDataImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.ParameterMetaDataImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public string GetParameterClassName(int param)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(param) )
            {
                return _cmj_fun0.CallString( this, cmj_jmargs );
            }
        }        
        
        public int GetParameterCount()
        {
            return _cmj_fun1.CallInt( this );
        }        
        
        public int GetParameterMode(int param)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(param) )
            {
                return _cmj_fun2.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int GetParameterType(int param)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(param) )
            {
                return _cmj_fun3.CallInt( this, cmj_jmargs );
            }
        }        
        
        public string GetParameterTypeName(int param)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(param) )
            {
                return _cmj_fun4.CallString( this, cmj_jmargs );
            }
        }        
        
        public int GetPrecision(int param)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(param) )
            {
                return _cmj_fun5.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int GetScale(int param)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(param) )
            {
                return _cmj_fun6.CallInt( this, cmj_jmargs );
            }
        }        
        
        public int IsNullable(int param)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(param) )
            {
                return _cmj_fun7.CallInt( this, cmj_jmargs );
            }
        }        
        
        public bool IsSigned(int param)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(param) )
            {
                return _cmj_fun8.CallBool( this, cmj_jmargs );
            }
        }        
    }    
    

}
