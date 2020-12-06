using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Model.Model;

namespace WinForm_Model
{
    public partial class frmLogin : Form
    {
     
        public frmLogin()
        {
            InitializeComponent();
            //grp();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private win_mvc_conn db = new win_mvc_conn();
        private void button_login_Click(object sender, EventArgs e)
        {
            tbluser users = new tbluser();
            users.user_name = text_user_name.Text;
            users.password = text_password.Text;

            if ((users.user_name == "test1234" && users.password == "test1234")|| (users.user_name == "dmu@aku" && users.password == "aku?dmu"))
            {


                LogStatus.Store_User = users.user_name;

                LogStatus.Log_Form = this;
                this.Hide();

                frm_main obj_main = new frm_main();
                obj_main.Show();

            }
            else
            {
                MessageBox.Show("Not Registered 'User-ID' or 'Password'", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_password.Text = "";
                text_user_name.Focus();
            }


        }
        //public void login( )
        //{

        //    tbluser users = new tbluser();
        //    users.user_name = text_user_name.Text;
        //    users.password = text_password.Text;

        //    if (IsValid(users.user_name, users.password))
        //    {

        //        Form1 obj_main = new Form1();
        //        obj_main.Show();

        //    }
        //}

        //public void grp()
        //{
        //    Label label = new Label();
        //    label.Text = groupBox1.Text;
        //    groupBox1.Text = "";
        //    label.Left = groupBox1.Left + (groupBox1.Width - label.Width) / 2;
        //    label.Top = groupBox1.Top + 2;
        //    label.Parent = groupBox1.Parent;
        //    label.BringToFront();
        //}


        private bool IsValid(string name, string passwords)
        {

            bool IsValid = false;


            var user = db.tblusers.FirstOrDefault(u => u.user_name == name);
            if (user != null)
            {
                if (user.password == passwords)
                {
                    IsValid = true;
                }
            }

            return IsValid;
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            get_data();
        }
        public class post_data
        {
            public string table { get; set; }


        }

        public class data_villages
        {
            public string country { get; set; }
            public string district { get; set; }
            public string uc { get; set; }
            public string village { get; set; }
            public string country_code { get; set; }
            public string district_code { get; set; }
            public string uc_code { get; set; }
            public string village_code { get; set; }
            public string cluster_no { get; set; }


        }


        public void get_data()
        {


            var get_key = new post_data()
            {
                table = "villages"
            };
            var test = JsonConvert.SerializeObject(get_key);



            HttpWebRequest webRequest;

            string requestParams = test.ToString();

            webRequest = (HttpWebRequest)WebRequest.Create("http://f38158/casi_gm/api/getdata.php");

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            Stream requestStream = webRequest.GetRequestStream();

            requestStream.Write(byteArray, 0, byteArray.Length);


            // Get the response.
            WebResponse response = webRequest.GetResponse();

            Stream responseStream = response.GetResponseStream();

            StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
            string Json = rdr.ReadToEnd(); // response from server
            var obj = JsonConvert.DeserializeObject<List<data_villages>>(Json);




            DataBase cn = new DataBase();

            SQLiteDataAdapter da = null;
            DataSet ds = null;

            da = new SQLiteDataAdapter("delete from villages", cn.cn);
            ds = new DataSet();
            da.Fill(ds);


            for (int a = 0; a <= obj.Count - 1; a++)
            {

                string qry = "insert into villages(village_code, village, district_code, district, uc_code, uc,country,country_code,cluster_no) values('" + obj[a].village_code + "', '" + obj[a].village + "', '" + obj[a].district_code + "', '" + obj[a].district + "', '" + obj[a].uc_code + "', '" + obj[a].uc + "', '" + obj[a].country + "', '" + obj[a].country_code + "', '" + obj[a].cluster_no + "')";

                da = new SQLiteDataAdapter(qry, cn.cn);

                ds = new DataSet();
                da.Fill(ds);

            }
            MessageBox.Show("Data Download", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }
    }
}
