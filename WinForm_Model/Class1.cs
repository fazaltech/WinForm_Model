﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_Model
{
    class SQLiteDatabaseOperations
    {
        // This class implements all the functions required to create table, insert data, update data in the SQLite Database.
        //

        public static String DATABASE_NAME = "case_gm.db";
        public static int DATABASE_VERSION = 1;
        
        public static String SQL_CREATE_FORMS = "CREATE TABLE forms ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
            + " FormID TEXT,"
            + " Data TEXT,"
            + " DeviceID TEXT"
            + " );";

        public static String SQL_CREATE_IMS = "CREATE TABLE ims ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
            + "ImsID TEXT,"
            + "Data TEXT );";

        public static String SQL_CREATE_CFS = "CREATE TABLE cfs ("
            + "_ID INTEGER PRIMARY KEY AUTOINCREMENT,"
            + "CfsID TEXT,"
            + "Data TEXT );";

        private static String TAG = "Shared_DB_HELPER_CLASS";
        private static String SQL_DELETE_FORMS =
            "DROP TABLE IF EXISTS forms";

        private static String SQL_DELETE_IMS =
            "DROP TABLE IF EXISTS ims";

        private static String SQL_DELETE_CFS =
            "DROP TABLE IF EXISTS cfs";
        private static SQLiteConnection con;


        public static void CreateDatabase()
        {
            if (!File.Exists(DATABASE_NAME))
            {
                SQLiteConnection.CreateFile(DATABASE_NAME);
                con = new SQLiteConnection("Data Source="+DATABASE_NAME+";Version="+DATABASE_VERSION+";");
                

                //SQLiteCommand cmd = new SQLiteCommand(sql, con);
                //cmd.ExecuteNonQuery();
                //con.Close();

            }
        }

        public static void CreateTables() {

            string sql = null;

            con.Open();
            using (var cmd = new SQLiteCommand(con)) {

                sql = @"CREATE TABLE villages(
                               country Text ,
                               district Integer,
                               uc TEXT,
                               village TEXT,
                               country_code TEXT,
                               district_code TEXT,
                               uc_code TEXT,
                               villlage_code TEXT,
                               cluster_no TEXT PRIMARY KEY,


);";

                cmd.CommandText = "INSERT INTO cars(name, price) VALUES('Audi',52642)";
                cmd.ExecuteNonQuery();




};
        }


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
