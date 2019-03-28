/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: javax.sql.RowSetMetaData
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:16 EDT 2018
 */


namespace Javax.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("0118F26F-D854-2795-E274-EEACF589631A")]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="javax.sql.RowSetMetaData")]
    public interface RowSetMetaData :
        global::Java.Sql.ResultSetMetaData
    { 
        void SetAutoIncrement(int columnIndex, bool property);
    
    
        void SetCaseSensitive(int columnIndex, bool property);
    
    
        void SetCatalogName(int columnIndex, string catalogName);
    
    
        void SetColumnCount(int columnCount);
    
    
        void SetColumnDisplaySize(int columnIndex, int size);
    
    
        void SetColumnLabel(int columnIndex, string label);
    
    
        void SetColumnName(int columnIndex, string columnName);
    
    
        void SetColumnType(int columnIndex, int SQLType);
    
    
        void SetColumnTypeName(int columnIndex, string typeName);
    
    
        void SetCurrency(int columnIndex, bool property);
    
    
        void SetNullable(int columnIndex, int property);
    
    
        void SetPrecision(int columnIndex, int precision);
    
    
        void SetScale(int columnIndex, int scale);
    
    
        void SetSchemaName(int columnIndex, string schemaName);
    
    
        void SetSearchable(int columnIndex, bool property);
    
    
        void SetSigned(int columnIndex, bool property);
    
    
        void SetTableName(int columnIndex, string tableName);
    }
    
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="javax.sql.RowSetMetaData")]
    public class RowSetMetaDataImpl :
        global::Java.Sql.ResultSetMetaDataImpl,
        global::Javax.Sql.RowSetMetaData
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
    
        static RowSetMetaDataImpl()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("javax.sql.RowSetMetaData", typeof(global::Javax.Sql.RowSetMetaData), typeof(global::Javax.Sql.RowSetMetaDataImpl), null);
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setAutoIncrement", "(IZ)V", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCaseSensitive", "(IZ)V", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCatalogName", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setColumnCount", "(I)V", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setColumnDisplaySize", "(II)V", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setColumnLabel", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setColumnName", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setColumnType", "(II)V", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setColumnTypeName", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setCurrency", "(IZ)V", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setNullable", "(II)V", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setPrecision", "(II)V", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setScale", "(II)V", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setSchemaName", "(ILjava/lang/String;)V", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setSearchable", "(IZ)V", false, false, false );
            _cmj_fun15 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setSigned", "(IZ)V", false, false, false );
            _cmj_fun16 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(void), "setTableName", "(ILjava/lang/String;)V", false, false, false );
        }
    
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public RowSetMetaDataImpl( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type RowSetMetaDataImpl if the given proxy instance
        /// represents a Java object that is type-compatible with javax.sql.RowSetMetaData</summary>
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Javax.Sql.RowSetMetaDataImpl From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (_cmj_theClass.IsTypeOf(jp))
                return new global::Javax.Sql.RowSetMetaDataImpl(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        
        public void SetAutoIncrement(int columnIndex, bool property)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(property) )
            {
                _cmj_fun0.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCaseSensitive(int columnIndex, bool property)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(property) )
            {
                _cmj_fun1.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCatalogName(int columnIndex, string catalogName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(catalogName) )
            {
                _cmj_fun2.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetColumnCount(int columnCount)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnCount) )
            {
                _cmj_fun3.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetColumnDisplaySize(int columnIndex, int size)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(size) )
            {
                _cmj_fun4.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetColumnLabel(int columnIndex, string label)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(label) )
            {
                _cmj_fun5.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetColumnName(int columnIndex, string columnName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(columnName) )
            {
                _cmj_fun6.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetColumnType(int columnIndex, int SQLType)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(SQLType) )
            {
                _cmj_fun7.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetColumnTypeName(int columnIndex, string typeName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(typeName) )
            {
                _cmj_fun8.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetCurrency(int columnIndex, bool property)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(property) )
            {
                _cmj_fun9.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetNullable(int columnIndex, int property)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(property) )
            {
                _cmj_fun10.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetPrecision(int columnIndex, int precision)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(precision) )
            {
                _cmj_fun11.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetScale(int columnIndex, int scale)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(scale) )
            {
                _cmj_fun12.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetSchemaName(int columnIndex, string schemaName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(schemaName) )
            {
                _cmj_fun13.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetSearchable(int columnIndex, bool property)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(property) )
            {
                _cmj_fun14.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetSigned(int columnIndex, bool property)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(property) )
            {
                _cmj_fun15.CallVoid( this, cmj_jmargs );
            }
        }        
        
        public void SetTableName(int columnIndex, string tableName)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 2 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(columnIndex).Add(tableName) )
            {
                _cmj_fun16.CallVoid( this, cmj_jmargs );
            }
        }        
    }    
    

}
