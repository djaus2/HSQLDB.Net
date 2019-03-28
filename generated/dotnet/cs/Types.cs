/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.Types
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("168B276D-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=false, CodegenVersion="4.7.416", JavaName="java.sql.Types")]
    public class Types :
        global::Java.Lang.Object
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
    
        static Types()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.Types", typeof(global::Java.Sql.Types));
        }
    
        public const int        ARRAY = 2003;
        public const int        BIGINT = -5;
        public const int        BINARY = -2;
        public const int        BIT = -7;
        public const int        BLOB = 2004;
        public const int        BOOLEAN = 16;
        public const int        CHAR = 1;
        public const int        CLOB = 2005;
        public const int        DATALINK = 70;
        public const int        DATE = 91;
        public const int        DECIMAL = 3;
        public const int        DISTINCT = 2001;
        public const int        DOUBLE = 8;
        public const int        FLOAT = 6;
        public const int        INTEGER = 4;
        public const int        JAVA_OBJECT = 2000;
        public const int        LONGNVARCHAR = -16;
        public const int        LONGVARBINARY = -4;
        public const int        LONGVARCHAR = -1;
        public const int        NCHAR = -15;
        public const int        NCLOB = 2011;
        public const int        NULL = 0;
        public const int        NUMERIC = 2;
        public const int        NVARCHAR = -9;
        public const int        OTHER = 1111;
        public const int        REAL = 7;
        public const int        REF = 2006;
        public const int        REF_CURSOR = 2012;
        public const int        ROWID = -8;
        public const int        SMALLINT = 5;
        public const int        SQLXML = 2009;
        public const int        STRUCT = 2002;
        public const int        TIME = 92;
        public const int        TIME_WITH_TIMEZONE = 2013;
        public const int        TIMESTAMP = 93;
        public const int        TIMESTAMP_WITH_TIMEZONE = 2014;
        public const int        TINYINT = -6;
        public const int        VARBINARY = -3;
        public const int        VARCHAR = 12;
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Types( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type Types if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.Types</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.Types From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.Types(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
    
    }

}
