using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using WinForm_Model.Model;
using static WinForm_Model.frmLogin;

namespace WinForm_Model
{
    class SQLiteDatabase
    {
        // This class implements all the functions required to create table, insert data, update data in the SQLite Database.
        //

        public static String DATABASE_PATH = "enc";
        public static String DATABASE_NAME = DATABASE_PATH+"\\casi_gm.db3";
        public static int DATABASE_VERSION = 3;
        public static string DATABASE_PASSWORD = "Aku@ku123";
        
        public static String SQL_CREATE_USERS = "CREATE TABLE users ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
            + " username TEXT,"
            + " password TEXT,"
            + " full_name TEXT"
            + " );";

        public static String SQL_CREATE_VILLAGES = "CREATE TABLE villages ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
            + " country TEXT,"
            + " district TEXT,"
            + " uc TEXT,"
            + " village TEXT,"
            + " country_code TEXT,"
            + " district_code TEXT,"
            + " uc_code TEXT,"
            + " villlage_code TEXT,"
            + " cluster_no TEXT"
            + " );";

        public static String SQL_CREATE_ZSTANDARDS = "CREATE TABLE zstandards ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
            + " sex TEXT,"
            + " age TEXT,"
            + " measure TEXT,"
            + " L TEXT,"
            + " M TEXT,"
            + " S TEXT,"
            + " cat TEXT"
            + " );";

        public static String SQL_CREATE_FORMS = "CREATE TABLE forms ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
           + " cr10 TEXT,"
            + " cr11 TEXT,"
            + " cr12 TEXT,"
            + " cr13m TEXT,"
            + " cr13f TEXT,"
            + " cr16 TEXT,"
            + " cr21 TEXT,"
            + " cr22 TEXT,"
            + " cr23 TEXT,"
            + " cr17a TEXT,"
            + " cr17b TEXT,"
            + " cr18a TEXT,"
            + " cr18b TEXT,"
            + " cr19a TEXT,"
            + " cr19b TEXT,"
            + " cr20a TEXT,"
            + " cr20b TEXT,"
            + " cr24a TEXT,"
            + " cr24b TEXT,"
            + " cr24c TEXT,"
            + " cr24d TEXT,"
            + " cr24e TEXT,"
            + " cr24f TEXT,"
            + " cr25a TEXT,"
            + " cr25b TEXT,"
            + " cr25c TEXT,"
            + " cr26a TEXT,"
            + " cr26b TEXT,"
            + " cr26c TEXT,"
            + " cr26d TEXT,"
            + " cr27a TEXT,"
            + " cr27b TEXT,"
            + " cr27c TEXT,"
            + " cr28a01 TEXT,"
            + " cr28a02 TEXT,"
            + " cr28b01 TEXT,"
            + " cr28b02 TEXT,"
            + " cr28c01 TEXT,"
            + " cr28c02 TEXT,"
            + " cr28d01 TEXT,"
            + " cr28d02 TEXT,"
            + " cr28e01 TEXT,"
            + " cr28e02 TEXT,"
            + " cr28f01 TEXT,"
            + " cr28f02 TEXT,"
            + " cr28fx01 TEXT,"
            + " cr28fx02 TEXT,"
            + " cr28fx98 TEXT"
            + " );";



        private static String SQL_DELETE_USERS =
            "DROP TABLE IF EXISTS users";

        private static String SQL_DELETE_VILLAGES =
            "DROP TABLE IF EXISTS villages";

        private static String SQL_DELETE_ZSTANDARDS =
            "DROP TABLE IF EXISTS zstandards";


        //public static String SQL_INSERT_USERS = INSERT INTO SyncInformation(timestamp, last_sync_value, last_retrieved_change_file, status) values('


        private static SqliteConnection con;
        private static String strCon;
        private static string connectionString;

        public SQLiteDatabase()
        {

            if (!Directory.Exists(DATABASE_PATH))
            {
                Directory.CreateDirectory(DATABASE_PATH);
            }

            //SqliteConnection.CreateFile(DATABASE_NAME);

            String strCon = "Data Source=" + DATABASE_NAME;
            Boolean dbExsits = File.Exists(DATABASE_NAME);

            connectionString = new SqliteConnectionStringBuilder(strCon)
            {
                Mode = SqliteOpenMode.ReadWriteCreate,
                Password = DATABASE_PASSWORD
            }.ToString();
            con = new SqliteConnection(connectionString);

            if (!dbExsits)
            {
                CreateTables();
            }
            //SQLiteCommand cmd = new SQLiteCommand(sql, con);
            //cmd.ExecuteNonQuery();
            //con.Close();



        }

        public static void CreateDatabase()
        {
            if (!File.Exists(DATABASE_NAME))
            {
                //SqliteConnection.CreateFile(DATABASE_NAME);

                String strCon = "Data Source=" + DATABASE_NAME;

                connectionString = new SqliteConnectionStringBuilder(strCon)
                {
                    Mode = SqliteOpenMode.ReadWriteCreate,
                    Password = DATABASE_PASSWORD
                }.ToString();
                con = new SqliteConnection(connectionString);

                try
                {
                    CreateTables();
                }
                catch { }


                //SQLiteCommand cmd = new SQLiteCommand(sql, con);
                //cmd.ExecuteNonQuery();
                //con.Close();

            }
          

                strCon = "Data Source=" + DATABASE_NAME;
                con = new SqliteConnection(strCon);

       


        }


        public static void CreateTables()
        {

            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = @SQL_CREATE_USERS;
                cmd.ExecuteNonQuery();

                cmd.CommandText = @SQL_CREATE_VILLAGES;
                cmd.ExecuteNonQuery();

                cmd.CommandText = @SQL_CREATE_ZSTANDARDS;
                cmd.ExecuteNonQuery();

                cmd.CommandText = @SQL_CREATE_FORMS;
                cmd.ExecuteNonQuery();

            };
            con.Close();
        }


        //public static void CreateTables()
        //{


        //    using (var cmd = new SQLiteCommand(con))
        //    {

        //        cmd.CommandText = @SQL_CREATE_USERS;
        //        cmd.ExecuteNonQuery();

        //        cmd.CommandText = @SQL_CREATE_VILLAGES;
        //        cmd.ExecuteNonQuery();

        //        cmd.CommandText = @SQL_DELETE_ZSTANDARDS;
        //        cmd.ExecuteNonQuery();

        //        //cmd.CommandText = @SQL_DELETE_FORMS;
        //        //cmd.ExecuteNonQuery();

        //    };
        //    con.Close();
        //}

        public static void InsertTestUser(List<user_model> users)
        {


            using (con)
            {
                con.Open();


                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO users (username, password) VALUES(@username, @password)";

                    for (int i = 0; i < users.Count; i++)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@username", users[i].username);
                        cmd.Parameters.AddWithValue("@password", users[i].password);

                        cmd.ExecuteNonQuery();
                    }
                }

                con.Close();
            }
        }



        public static void InsertForm(form_data forms_data)
        {


            using (con)
            {
                try
                {
                    con.Open();


                    using (var cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO forms (cr10,cr11,cr12,cr13m,cr13f,cr16,cr21,cr22,cr23,cr17a,cr17b,cr18a,cr18b,cr19a,cr19b,cr20a,cr20b,cr24a,cr24b,cr24c,cr24d,cr24e,cr24f,cr25a,cr25b,cr25c,cr26a,cr26b,cr26c,cr26d,cr27a,cr27b,cr27c,cr28a01,cr28a02,cr28b01,cr28b02,cr28c01,cr28c02,cr28d01,cr28d02,cr28e01,cr28e02,cr28f01,cr28f02,cr28fx01,cr28fx02,cr28fx98) VALUES(@cr10,@cr11,@cr12,@cr13m,@cr13f,@cr16,@cr21,@cr22,@cr23,@cr17a,@cr17b,@cr18a,@cr18b,@cr19a,@cr19b,@cr20a,@cr20b,@cr24a,@cr24b,@cr24c,@cr24d,@cr24e,@cr24f,@cr25a,@cr25b,@cr25c,@cr26a,@cr26b,@cr26c,@cr26d,@cr27a,@cr27b,@cr27c,@cr28a01,@cr28a02,@cr28b01,@cr28b02,@cr28c01,@cr28c02,@cr28d01,@cr28d02,@cr28e01,@cr28e02,@cr28f01,@cr28f02,@cr28fx01,@cr28fx02,@cr28fx98)";

                        //for (int i = 0; i < forms_data.Count; i++)
                        //{
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("cr10", forms_data.cr10);
                        cmd.Parameters.AddWithValue("cr11", forms_data.cr11);
                        cmd.Parameters.AddWithValue("cr12", forms_data.cr12);
                        cmd.Parameters.AddWithValue("cr13m", forms_data.cr12);
                        cmd.Parameters.AddWithValue("cr13f", forms_data.cr12);
                        cmd.Parameters.AddWithValue("cr16", forms_data.cr16);
                        cmd.Parameters.AddWithValue("cr21", forms_data.cr21);
                        cmd.Parameters.AddWithValue("cr22", forms_data.cr22);
                        cmd.Parameters.AddWithValue("cr23", forms_data.cr23);
                        cmd.Parameters.AddWithValue("cr17a", forms_data.cr17a);
                        cmd.Parameters.AddWithValue("cr17b", forms_data.cr17b);
                        cmd.Parameters.AddWithValue("cr18a", forms_data.cr18a);
                        cmd.Parameters.AddWithValue("cr18b", forms_data.cr18b);
                        cmd.Parameters.AddWithValue("cr19a", forms_data.cr19a);
                        cmd.Parameters.AddWithValue("cr19b", forms_data.cr19b);
                        cmd.Parameters.AddWithValue("cr20a", forms_data.cr20a);
                        cmd.Parameters.AddWithValue("cr20b", forms_data.cr20b);
                        cmd.Parameters.AddWithValue("cr24a", forms_data.cr24a);
                        cmd.Parameters.AddWithValue("cr24b", forms_data.cr24b);
                        cmd.Parameters.AddWithValue("cr24c", forms_data.cr24c);
                        cmd.Parameters.AddWithValue("cr24d", forms_data.cr24d);
                        cmd.Parameters.AddWithValue("cr24e", forms_data.cr24e);
                        cmd.Parameters.AddWithValue("cr24f", forms_data.cr24f);
                        cmd.Parameters.AddWithValue("cr25a", forms_data.cr25a);
                        cmd.Parameters.AddWithValue("cr25b", forms_data.cr25b);
                        cmd.Parameters.AddWithValue("cr25c", forms_data.cr25c);
                        cmd.Parameters.AddWithValue("cr26a", forms_data.cr26a);
                        cmd.Parameters.AddWithValue("cr26b", forms_data.cr26b);
                        cmd.Parameters.AddWithValue("cr26c", forms_data.cr26c);
                        cmd.Parameters.AddWithValue("cr26d", forms_data.cr26d);
                        cmd.Parameters.AddWithValue("cr27a", forms_data.cr27a);
                        cmd.Parameters.AddWithValue("cr27b", forms_data.cr27b);
                        cmd.Parameters.AddWithValue("cr27c", forms_data.cr27c);
                        cmd.Parameters.AddWithValue("cr28a01", forms_data.cr28a01);
                        cmd.Parameters.AddWithValue("cr28a02", forms_data.cr28a02);
                        cmd.Parameters.AddWithValue("cr28b01", forms_data.cr28b01);
                        cmd.Parameters.AddWithValue("cr28b02", forms_data.cr28b02);
                        cmd.Parameters.AddWithValue("cr28c01", forms_data.cr28c01);
                        cmd.Parameters.AddWithValue("cr28c02", forms_data.cr28c02);
                        cmd.Parameters.AddWithValue("cr28d01", forms_data.cr28d01);
                        cmd.Parameters.AddWithValue("cr28d02", forms_data.cr28d02);
                        cmd.Parameters.AddWithValue("cr28e01", forms_data.cr28e01);
                        cmd.Parameters.AddWithValue("cr28e02", forms_data.cr28e02);
                        cmd.Parameters.AddWithValue("cr28f01", forms_data.cr28f01);
                        cmd.Parameters.AddWithValue("cr28f02", forms_data.cr28f02);
                        cmd.Parameters.AddWithValue("cr28fx01", forms_data.cr28fx01);
                        cmd.Parameters.AddWithValue("cr28fx02", forms_data.cr28fx02);
                        cmd.Parameters.AddWithValue("cr28fx98", forms_data.cr28fx98);

                        cmd.ExecuteNonQuery();
                         MessageBox.Show("SUCCESS!", "Form saved!");

                        //}
                    }

                    con.Close();
                } catch (Exception e)
                {
                    MessageBox.Show("ERROR!", "Form was not saved. "+"\n"+e.Message);
                }
            }
        }


        public List<form_data> GetAllForms()
        {
            List<form_data> fdList = new List<form_data>();


            con.Open();
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = @"SELECT * from forms";
                SqliteDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    form_data fd = new form_data();
                    fd.id = Int32.Parse(r["id"].ToString());
                    fd.cr10 = r["cr10"].ToString();


                    // 
                    fdList.Add(fd);
                }
            }
            con.Close();

            return fdList;
        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        //                                   SQLite Database
        ////////////////////////////////////////////////////////////////////////////////////////////


        public static void InsertRecords(long last_sync_value, string last_retrieved_change_file)
        {
            //SQLiteConnection.CreateFile("SyncInfoDatabase.sqllite");
            string sql = @"INSERT INTO SyncInformation(timestamp, last_sync_value, last_retrieved_change_file, status) values ('" +
                    DateTime.UtcNow.ToString() + "', " + last_sync_value.ToString() + ", '" + last_retrieved_change_file + "', 'CREATED')";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();


            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static string SelectNextUploadedFile()
        {
            string Change_captureFile = "";
            //SQLiteConnection.("SyncInfoDatabase.sqllite");
            string sql = @"SELECT last_retrieved_change_file FROM SyncInformation where status = 'CREATED' order by datetime(timestamp) LIMIT 1";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            object tempval = cmd.ExecuteScalar();
            if (tempval != null)
            {
                Change_captureFile = Convert.ToString(tempval);
                Console.WriteLine($"File To Upload -> {Change_captureFile}");
            }

            else
                Console.WriteLine($"No Files To Upload ");
            con.Close();
            return Change_captureFile;
        }
        public static long SelectLastSyncVersion()
        {
            long last_sync_version = 0;
            //SQLiteConnection.CreateFile("SyncInfoDatabase.sqllite");
            string sql = @"SELECT max(last_sync_value) as last_sync_version FROM SyncInformation";
            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            object tempval = cmd.ExecuteScalar();
            if (tempval.GetType() != typeof(DBNull))
                last_sync_version = Convert.ToInt64(tempval);
            con.Close();
            Console.WriteLine($"Last Sync Version -> {last_sync_version}");
            return last_sync_version;
        }
        public static void UpdateRecords(string last_retrieved_change_file_value)
        {
            //SQLiteConnection.CreateFile("SyncInfoDatabase.sqllite");
            string sql = @"Update SyncInformation set status = 'Uploaded' where last_retrieved_change_file = '" + last_retrieved_change_file_value + "'";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static string[] GetFilesToDelete()
        {
            List<string> filestodelete = new List<string>();
            //SQLiteConnection.("SyncInfoDatabase.sqllite");
            string sql = @"SELECT last_retrieved_change_file FROM SyncInformation where status = 'Uploaded' order by datetime(timestamp)";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                filestodelete.Add(Convert.ToString(reader["last_retrieved_change_file"]));
            }
            con.Close();
            return filestodelete.ToArray();
        }

        public static void DeleteEntryFromDatabase(string filename)
        {
            string sql = @"Delete  FROM SyncInformation where status = 'Uploaded' and last_retrieved_change_file = '" + filename + "'";

            SQLiteConnection con = new SQLiteConnection("Data Source=SyncInfoDatabase.sqllite;Version=3;");
            con.Open();
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
