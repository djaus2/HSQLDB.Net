using System;
using System.IO;
using Codemesh.JuggerNET;
using Java.Lang;
using Java.Sql;
using Java.Util;

namespace Codeview2
{
    public class MyApp
    {
        public static string DBName { get; set; } = "GitHub";
        public static string DBFolder { get; set; } = @"C:\Temp\GitHub";
        public static bool ReplaceExistingScriptAndConfigFiles { get; set; } = true;
        public static bool FilterScript { get; set; } = false;
        public static bool ClearDestinationFolder { get; set; } = true;

        public static string dataExtn = ".data";
        public static string configExtn = ".properties";
        public static string scriptExtn = ".script";


        public static void Main(string[] args)
        {
            string db_file_name_prefix = args.Length > 0 && !"-info".Equals(args[0].ToLower()) ? args[0] : "test_db";

            //for now just terminate if we're invoked with the -info option
            if (args.Length > 0 && "-info".Equals(args[0].ToLower()))
                return;

            //the database connection
            Connection conn = null;
            Console.WriteLine("Success1!");

            IJvmLoader loader = JvmLoader.GetJvmLoader(true, true, TraceFacility.TraceJvm, TraceLevel.TraceErrors);
            //loader.JvmPath = @"jvm.dll";
            try
            {
                loader.JvmPath = @"C:\Program Files\Java\jdk1.8.0_161\jre\bin\server\jvm.dll";
                //loader.AppendBootClassPath = "hsqldb.jar";
                loader.AppendToClassPath("hsqldb.jar");
                //Append your db jar:
                // loader.AppendToClassPath("MyHSQLDB.jar");
                //Append any other Java jars needed eg:
                loader.AppendToClassPath("castor-0.9.3.21.jar");
                IJvm jvm = loader.Load();
                if (jvm != null)
                {
                    Console.WriteLine("Success2!");
                    // put the hsqldb classes (driver) on the bootclasspath to work around a 
                    // limitation in the DriverManager when invoked from .NET
                    //loader.AppendBootClassPath = "../lib/hsqldb.jar;../../lib/hsqldb.jar";


                    Console.WriteLine("Success2.1!");
                    Class.ForName("java.lang.String");
                    Console.WriteLine("Success2.5!");

                    Console.WriteLine("Success3!");
                    // make the JDBC driver available by preloading it
                    Class.ForName("org.hsqldb.jdbcDriver");
                    Console.WriteLine("Success4!");
                    // connect to the database.   This will load the db files and start the
                    // database if it is not alread running.
                    // db_file_name_prefix is used to open or create files that hold the state
                    // of the db.
                    // It can contain directory names relative to the
                    // current working directory



                    conn = DriverManager.GetConnection("jdbc:hsqldb:" + db_file_name_prefix,
                                                        "sa",                     // username
                                                        "");
                    Console.WriteLine("Success5!");
                    try
                    {
                        //Uncomment this first time run:
                        //Update(conn, "CREATE TABLE sample_table ( id INTEGER IDENTITY, str_col VARCHAR(256), num_col INTEGER)");

                        //// add some rows - will create duplicates if run more then once
                        //// the id column is automatically generated
                        Update(conn, "INSERT INTO sample_table(str_col,num_col) VALUES('Ford', 100)");
                        Update(conn, "INSERT INTO sample_table(str_col,num_col) VALUES('Toyota', 200)");
                        Update(conn, "INSERT INTO sample_table(str_col,num_col) VALUES('Honda', 300)");
                        Update(conn, "INSERT INTO sample_table(str_col,num_col) VALUES('GM', 400)");
                        Update(conn, "INSERT INTO sample_table(str_col,num_col) VALUES('BMW', 80)");
                        Update(conn, "INSERT INTO sample_table(str_col,num_col) VALUES('Mercedes-Benz', 60)");
                        Update(conn, "INSERT INTO sample_table(str_col,num_col) VALUES('VW', 800)");
                    }
                    catch (SQLException sqle)
                    {
                        Console.WriteLine(sqle.Message);
                    }
                    catch (Throwable it)
                    {
                        Console.WriteLine(it.StackTrace);
                    }
                    catch (System.Exception ie)
                    {
                        Console.WriteLine(ie.ToString());
                    }
                    Console.WriteLine("Success6!");
                    try
                    {
                        Console.WriteLine("---------------");

                        // do a query
                        Query(conn, "SELECT * FROM sample_table WHERE num_col < 250");


                        Console.WriteLine("---------------");

                        // do another query
                        //Query(conn, "SELECT str_col FROM sample_table WHERE num_col >= 100");

                        Console.WriteLine("---------------");

                        conn.Close();
                    }
                    catch (Throwable t)
                    {
                        Console.WriteLine("Caught throwable of type {0}", t.GetClass().GetName());
                        Console.WriteLine(t.ToString());
                        return;
                    }
                    catch (JuggerNETFrameworkException jnfe)
                    {
                        Console.WriteLine("Caught framework exception");
                        Console.WriteLine(jnfe.Message);
                        Console.WriteLine(jnfe.StackTrace);
                        return;
                    }
                    Console.WriteLine("Success7!");
                }
                else
                    Console.WriteLine("No Jvm!");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Done!");


        }

        public static void Dump(ResultSet rs)
        {
            // the order of the rows in a cursor
            // are implementation dependent unless you use the SQL ORDER statement
            ResultSetMetaData meta = rs.GetMetaData();

            int colmax = meta.GetColumnCount();
            int i;
            object o = null;



            for (i = 0; i < colmax; ++i)
            {
                Console.Write(meta.GetColumnName(i + 1));
                Console.Write('\t');
            }
            Console.WriteLine();
            //Console.WriteLine(meta.GetCatalogName(0));
            Console.WriteLine(colmax);

            // the result set is a cursor into the data.  You can only
            // point to one row at a time
            // assume we are pointing to BEFORE the first row
            // rs.next() points to next row and returns true
            // or false if there is no next row, which breaks the loop
            for (; rs.Next();)
            {



                for (i = 0; i < colmax; ++i)
                {


                    // Is SQL the first column is indexed
                    try
                    {
                        o = rs.GetObject(i + 1);
                        // with 1 not 0
                        if (o != null)
                        {

                            Console.Write("{0}\t", o.ToString());
                        }
                        else
                            Console.Write(".\t");
                    }

                    catch (System.Exception ex)
                    {
                        Console.Write("-\t");

                    }
                }

                Console.WriteLine("");
            }
        }


        public static void Update(Connection conn, System.String expression)
        {
            Statement st = null;

            st = conn.CreateStatement();    // statements

            int i = st.ExecuteUpdate(expression);    // run the query

            if (i == -1)
            {
                Console.WriteLine("db error : {0}", expression);
            }

            st.Close();
        }


        public static void Query(Connection conn, System.String expression)
        {
            Statement st = null;
            ResultSet rs = null;

            st = conn.CreateStatement();         // statement objects can be reused with

            // repeated calls to execute but we
            // choose to make a new one each time
            rs = st.ExecuteQuery(expression);    // run the query

            // do something with the result set.
            Dump(rs);
            st.Close();
            // NOTE!! if you close a statement the associated ResultSet is closed 
            // too so you should copy the contents to some other object.
            // the result set is invalidated also  if you recycle an Statement
            // and try to execute some other query before the result set has been
            // completely examined.
        }
    }
}