/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.Array
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("157C414D-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.Array")]
    public interface Array 
    { 
        void Free();
    
    
        object GetArray();
    
    
        object GetArray(global::Java.Util.Map map);
    
    
        object GetArray(long index, int count);
    
    
        object GetArray(long index, int count, global::Java.Util.Map map);
    
    
        int GetBaseType();
    
    
        string GetBaseTypeName();
    
    
        global::Java.Sql.ResultSet GetResultSet();
    
    
        global::Java.Sql.ResultSet GetResultSet(global::Java.Util.Map map);
    
    
        global::Java.Sql.ResultSet GetResultSet(long index, int count);
    
    
        global::Java.Sql.ResultSet GetResultSet(long index, int count, global::Java.Util.Map map);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.Array")]
    public class ArrayImpl :
        global::Java.Lang.Object,
        global::Java.Sql.Array
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
    
        static ArrayImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.Array", typeof(global::Java.Sql.Array), typeof(global::Java.Sql.ArrayImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "free", "()V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getArray", "()Ljava/lang/Object;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getArray", "(Ljava/util/Map;)Ljava/lang/Object;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getArray", "(JI)Ljava/lang/Object;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "getArray", "(JILjava/util/Map;)Ljava/lang/Object;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getBaseType", "()I", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getBaseTypeName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getResultSet", "()Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getResultSet", "(Ljava/util/Map;)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getResultSet", "(JI)Ljava/sql/ResultSet;", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.ResultSet), "getResultSet", "(JILjava/util/Map;)Ljava/sql/ResultSet;", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public ArrayImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type ArrayImpl if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.Array</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.ArrayImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.ArrayImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void Free()
        {
            _cmj_fun0.CallVoid( this );
        }        
        
        public object GetArray()
        {
            return _cmj_fun1.CallObject( this, typeof(object), false );
        }        
        
        public object GetArray(global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(map) )
            {
                return _cmj_fun2.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetArray(long index, int count)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index).Add(count) )
            {
                return _cmj_fun3.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public object GetArray(long index, int count, global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index).Add(count).Add(map) )
            {
                return _cmj_fun4.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }        
        
        public int GetBaseType()
        {
            return _cmj_fun5.CallInt( this );
        }        
        
        public string GetBaseTypeName()
        {
            return _cmj_fun6.CallString( this );
        }        
        
        public global::Java.Sql.ResultSet GetResultSet()
        {
            if(_cmj_fun7.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun7.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.ResultSet)_cmj_fun7.CallObject( this, typeof(global::Java.Sql.ResultSet), false );
        
        }        
        
        public global::Java.Sql.ResultSet GetResultSet(global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(map) )
            {
                if(_cmj_fun8.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun8.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun8.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetResultSet(long index, int count)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index).Add(count) )
            {
                if(_cmj_fun9.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun9.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun9.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
        
        public global::Java.Sql.ResultSet GetResultSet(long index, int count, global::Java.Util.Map map)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 3 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(index).Add(count).Add(map) )
            {
                if(_cmj_fun10.IsLeafType)
                {
                    long    jnet_ref = (long)_cmj_fun10.CallObject( this, cmj_jmargs );
                    return  jnet_ref == 0 ? null : new global::Java.Sql.ResultSetImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
                }
                else
                    return (global::Java.Sql.ResultSet)_cmj_fun10.CallObject( this, typeof(global::Java.Sql.ResultSet), false, cmj_jmargs );
        
            }
        }        
    }    
    

}
