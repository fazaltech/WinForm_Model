using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Model
{
    class DataBase
    {
        public SQLiteConnection cn = null;

        public DataBase()
        {
            try
            {
                cn = new SQLiteConnection(ConfigurationSettings.AppSettings["cnStr"]);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {

            }
        }
    }
}
