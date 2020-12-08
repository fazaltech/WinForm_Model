using System;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace WinForm_Model
{
    internal class SqliteCommand
    {
        private string commandText;
        private SQLiteConnection con;

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