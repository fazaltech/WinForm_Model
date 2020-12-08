using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;

namespace WinForm_Model
{
    internal class SqliteCommand
    {
        private string commandText;
        private SQLiteConnection con;
        private SqliteConnection con1;
        private string v;

        public SqliteCommand(SqliteConnection con1)
        {
            this.con1 = con1;
        }

        public SqliteCommand(string v)
        {
            this.v = v;
        }

        public SqliteCommand(string commandText, SQLiteConnection con)
        {
            this.commandText = commandText;
            this.con = con;
        }

        public static implicit operator SqlCommand(SqliteCommand v)
        {
            throw new NotImplementedException();
        }
    }
}