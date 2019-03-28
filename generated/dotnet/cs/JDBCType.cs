/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.JDBCType
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("18A0B141-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.JDBCType")]
    public sealed class JDBCType :
        global::Java.Lang.Enum,
        global::Java.Sql.SQLType,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldARRAY;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldBIGINT;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldBINARY;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldBIT;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldBLOB;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldBOOLEAN;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldCHAR;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldCLOB;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldDATALINK;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldDATE;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldDECIMAL;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldDISTINCT;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldDOUBLE;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldFLOAT;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldINTEGER;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldJAVA_OBJECT;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldLONGNVARCHAR;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldLONGVARBINARY;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldLONGVARCHAR;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldNCHAR;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldNCLOB;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldNULL;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldNUMERIC;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldNVARCHAR;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldOTHER;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldREAL;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldREF;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldREF_CURSOR;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldROWID;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldSMALLINT;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldSQLXML;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldSTRUCT;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldTIME;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldTIME_WITH_TIMEZONE;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldTIMESTAMP;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldTIMESTAMP_WITH_TIMEZONE;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldTINYINT;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldVARBINARY;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldVARCHAR;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
    
        static JDBCType()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.JDBCType", typeof(global::Java.Sql.JDBCType));
            _cmj_fldARRAY = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "ARRAY", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldBIGINT = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "BIGINT", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldBINARY = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "BINARY", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldBIT = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "BIT", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldBLOB = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "BLOB", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldBOOLEAN = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "BOOLEAN", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldCHAR = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "CHAR", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldCLOB = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "CLOB", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldDATALINK = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "DATALINK", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldDATE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "DATE", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldDECIMAL = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "DECIMAL", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldDISTINCT = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "DISTINCT", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldDOUBLE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "DOUBLE", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldFLOAT = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "FLOAT", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldINTEGER = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "INTEGER", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldJAVA_OBJECT = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "JAVA_OBJECT", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldLONGNVARCHAR = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "LONGNVARCHAR", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldLONGVARBINARY = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "LONGVARBINARY", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldLONGVARCHAR = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "LONGVARCHAR", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldNCHAR = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "NCHAR", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldNCLOB = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "NCLOB", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldNULL = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "NULL", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldNUMERIC = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "NUMERIC", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldNVARCHAR = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "NVARCHAR", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldOTHER = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "OTHER", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldREAL = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "REAL", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldREF = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "REF", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldREF_CURSOR = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "REF_CURSOR", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldROWID = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "ROWID", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldSMALLINT = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "SMALLINT", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldSQLXML = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "SQLXML", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldSTRUCT = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "STRUCT", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldTIME = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "TIME", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldTIME_WITH_TIMEZONE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "TIME_WITH_TIMEZONE", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldTIMESTAMP = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "TIMESTAMP", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldTIMESTAMP_WITH_TIMEZONE = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "TIMESTAMP_WITH_TIMEZONE", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldTINYINT = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "TINYINT", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldVARBINARY = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "VARBINARY", "Ljava/sql/JDBCType;", true, true );
            _cmj_fldVARCHAR = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "VARCHAR", "Ljava/sql/JDBCType;", true, true );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getVendor", "()Ljava/lang/String;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Integer), "getVendorTypeNumber", "()Ljava/lang/Integer;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "valueOf", "(I)Ljava/sql/JDBCType;", true, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.JDBCType), "valueOf", "(Ljava/lang/String;)Ljava/sql/JDBCType;", true, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.JDBCTypeArray), "values", "()[Ljava/sql/JDBCType;", true, false, false );
        }
    
        public static global::Java.Sql.JDBCType ARRAY
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldARRAY.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType BIGINT
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldBIGINT.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType BINARY
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldBINARY.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType BIT
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldBIT.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType BLOB
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldBLOB.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType BOOLEAN
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldBOOLEAN.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType CHAR
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldCHAR.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType CLOB
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldCLOB.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType DATALINK
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldDATALINK.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType DATE
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldDATE.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType DECIMAL
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldDECIMAL.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType DISTINCT
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldDISTINCT.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType DOUBLE
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldDOUBLE.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType FLOAT
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldFLOAT.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType INTEGER
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldINTEGER.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType JAVA_OBJECT
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldJAVA_OBJECT.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType LONGNVARCHAR
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldLONGNVARCHAR.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType LONGVARBINARY
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldLONGVARBINARY.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType LONGVARCHAR
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldLONGVARCHAR.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType NCHAR
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldNCHAR.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType NCLOB
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldNCLOB.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType NULL
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldNULL.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType NUMERIC
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldNUMERIC.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType NVARCHAR
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldNVARCHAR.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType OTHER
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldOTHER.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType REAL
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldREAL.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType REF
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldREF.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType REF_CURSOR
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldREF_CURSOR.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType ROWID
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldROWID.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType SMALLINT
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldSMALLINT.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType SQLXML
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldSQLXML.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType STRUCT
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldSTRUCT.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType TIME
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldTIME.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType TIME_WITH_TIMEZONE
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldTIME_WITH_TIMEZONE.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType TIMESTAMP
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldTIMESTAMP.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType TIMESTAMP_WITH_TIMEZONE
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldTIMESTAMP_WITH_TIMEZONE.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType TINYINT
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldTINYINT.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType VARBINARY
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldVARBINARY.Get_object();
            }
        }
        
        public static global::Java.Sql.JDBCType VARCHAR
        {
            get
            {
                return (global::Java.Sql.JDBCType)_cmj_fldVARCHAR.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public JDBCType( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        JDBCType( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type JDBCType if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.JDBCType</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.JDBCType From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.JDBCType(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public string GetName()
        {
            return _cmj_fun0.CallString( this );
        }    
    
        public string GetVendor()
        {
            return _cmj_fun1.CallString( this );
        }    
    
        public global::Java.Lang.Integer GetVendorTypeNumber()
        {
            long    jnet_ref = (long)_cmj_fun2.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Integer( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public static global::Java.Sql.JDBCType ValueOf(int arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                long    jnet_ref = (long)_cmj_fun3.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Sql.JDBCType( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Sql.JDBCType ValueOf(string type)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(type) )
            {
                long    jnet_ref = (long)_cmj_fun4.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Sql.JDBCType( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Sql.JDBCTypeArray Values()
        {
            if(_cmj_fun5.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun5.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Sql.JDBCTypeArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.JDBCTypeArray)_cmj_fun5.CallObject( null, typeof(global::Java.Sql.JDBCTypeArray), false );
        
        }    
    
    
    }
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="[Ljava/sql/JDBCType;")]
    public sealed class JDBCTypeArray :
        global::Codemesh.JuggerNET.JuggerNETProxyArray,
        global::Java.Lang.Cloneable,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theElementClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod  _cmj_theCtor;
    
        static JDBCTypeArray()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("[Ljava/sql/JDBCType;", typeof(global::Java.Sql.JDBCTypeArray));
            _cmj_theCtor = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.JDBCTypeArray), "<arrinit>", "L", false );
            _cmj_theElementClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.JDBCType", typeof(global::Java.Sql.JDBCType));
        }
    
        ///<summary>The constructor taking a dimension as an argument.</summary>
        ///<remarks>Use this constructor where you would normally declare a native array.
        ///instance using rectangular brackets (i.e. ClassArray[ 25 ];).
        /// This constructor will create an empty (null-initialized) array with space for
        /// the given number of elements.</remarks>
        /// <param name="size"> the number of elements that can be stored in the array (the dimension)</param>
        public JDBCTypeArray(int size) : base(_cmj_theCtor, _cmj_theElementClass, size) {}
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobject"> The JNI object handle.</param>
        public JDBCTypeArray( global::Codemesh.JuggerNET.JNIHandle jobject) : base(jobject) {}
    
    
        /// <summary>Creates a proxy array from a native array</summary>
        /// <param name="arr">the native array instance.</param>
        public JDBCTypeArray(global::Java.Sql.JDBCType[] arr) : base(_cmj_theCtor, _cmj_theElementClass, arr.Length)
        {
            int iMax = arr.Length;
            for (int i = 0; i < iMax; i++)
                SetElement(i, (JDBCType)arr[i]);
        }
    
    
        /// <summary>Conversion operator from native .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use native .NET arrays in places where the
        /// compiler expects proxy array instances. You're better off using proxy arrays if you
        /// are going to use the same native array with Java APIs more than once because the entire.
        /// .NET array has to be converted to a proxy array each time you convert it.
        /// </remarks>
        public static implicit operator JDBCTypeArray(global::Java.Sql.JDBCType[] arr)
        {
            int iMax = arr.Length;
            JDBCTypeArray a = new JDBCTypeArray(iMax);
            for (int i = 0; i < iMax; i++)
                a.SetElement(i, (JDBCType)arr[i]);
            return a;
        }
    
    
        /// <summary>Conversion operator from proxy arrays to .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use proxy arrays in places where the
        /// compiler expects native .NET array instances. We declare this operator explicit to prevent
        /// you from using it unintentionally. The performance penalty of unintentionally creating a
        /// .NET array from a proxy array can be significant if you're not planning to use all elements
        /// anyway. 
        /// </remarks>
        public static explicit operator global::Java.Sql.JDBCType[](JDBCTypeArray arr)
        {
            global::Java.Sql.JDBCType[] a = new global::Java.Sql.JDBCType[ arr.Length ];
            int  length = arr.Length;
            for( int i = 0; i < length; i++ )
                a[ i ] = arr[ i ];
            return a;
        }
        
    
        /// <summary>Casts another proxy object to this type if possible.
        /// <para>You rarely need this method. It is only required when you have for example
        /// an array proxy type that is type compatible on the Java side but not on the .NET side.</para>
        /// <para>A good example would be the <c>String[][]</c> and <c>Object[]</c> types in Java.
        /// The two-dimensional String array IS also a one-dimensional Object array in Java, but we cannot
        /// duplicate this behavior through inheritance in .NET.  For that reason, we provide you with this
        /// method, allowing you to take for exmaple a <c>StringArrayArray</c> object and use it to create
        /// an <c>ObjectArray</c> instance when you need to.</para></summary>
        public static JDBCTypeArray From(global::Codemesh.JuggerNET.JavaProxy proxy)
        {
            if (_cmj_theClass.IsTypeOf(proxy))
                return new JDBCTypeArray(new global::Codemesh.JuggerNET.JNIHandle(proxy.JObjectDuplicate));
            else
                return null;
        }
    
    
        ///<summary>A read-only property for the array's rank (number of dimensions).</summary>
        public override int Rank
        {
            get { return 1; }
        }
    
    
        ///<summary>A read-only property for the array's element type.</summary>
        public override global::System.Type ElementType
        {
            get { return typeof(JDBCType); }
        }
    
        ///<summary>The index operator allowing access to the array's elements.</summary>
        public JDBCType this[ int index ]
        {
            get
            {
                global::Codemesh.JuggerNET.JNIHandle h = GetElement( index );
                return !h ? null : new JDBCType( h );
            }
            set
            {
                SetElement( index, value ); global::System.GC.KeepAlive( this ); global::System.GC.KeepAlive( value );
            }
        }
    }
    
    
    

}
