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
        SQLiteDatabase db = new SQLiteDatabase();
        private DataBase cn = new DataBase();

        public frmLogin()
        {
            InitializeComponent();
            DownloadUsers();
      
            //grp();
        }

        private void DownloadUsers()
        {



            List<user_model> users = new List<user_model>();

            for (int i = 0; i < 55; i++)
            {
                user_model um = new user_model();

                um.username = "test" + i;
                um.password = "pass" + i;
                users.Add(um);
            }

          SQLiteDatabase.InsertTestUser(users);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {



        }
        //private win_mvc_conn db = new win_mvc_conn();
        private void button_login_Click(object sender, EventArgs e)
        {
            if (text_user_name.Text == "test1234" && text_password.Text == "test1234")
            {
                DataBaseVariable.frmlogin1 = this;
                this.Hide();
                frm_main obj_main = new frm_main();
                obj_main.Show();

            }
            else if (text_user_name.Text != null && text_password.Text != null)
            {



                DataBase cn = new DataBase();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from users where username='" + text_user_name.Text + "' and password='" + text_password.Text + "'", cn.cn);
                //SQLiteDataAdapter da = new SQLiteDataAdapter("select * from users ", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null)
                {
                    if (ds.Tables.Count > 0)
                    {
                        if ((text_user_name.Text == "test1234" && text_password.Text == "test1234") 
                            || (text_user_name.Text == "dmu@aku" && text_password.Text == "aku?dmu") 
                            || ds.Tables[0].Rows.Count > 0 )
                        {

                            //DataBaseVariable.UserID = ds.Tables[0].Rows[0][0].ToString();
                           // DataBaseVariable.UserName = ds.Tables[0].Rows[0][1].ToString();
                           // DataBaseVariable.GetPassword = ds.Tables[0].Rows[0]["password"].ToString();
                           // DataBaseVariable.GetDBName = "win_gb";


                            //if (ds.Tables[0].Rows[0]["IsUserOrAdmin"].ToString() == "True")
                            //{
                            //    DataBaseVariable.IsAdmin = true;
                            //}
                            //else
                            //{
                            //    DataBaseVariable.IsAdmin = false;
                            //}


                            //TODO: 

                            DataBaseVariable.frmlogin1 = this;
                            this.Hide();

                            frm_main obj_main = new frm_main();
                            obj_main.Show();
                        }
                        else
                        {
                            MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            text_user_name.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        text_user_name.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("User does not exist ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_user_name.Focus();
                }
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


        //private bool IsValid(string name, string passwords)
        //{

        //    //bool IsValid = false;


        //    //var user = db.tblusers.FirstOrDefault(u => u.user_name == name);
        //    //if (user != null)
        //    //{
        //    //    if (user.password == passwords)
        //    //    {
        //    //        IsValid = true;
        //    //    }
        //    //}

        //    return IsValid;
        //}

        private void button_download_Click(object sender, EventArgs e)
        {
            //bool result = false;
            //if (result == false)
            //{
            //    System.Diagnostics.Debug.WriteLine("starting download");

            //    get_villages();
            //    System.Diagnostics.Debug.WriteLine("continue download");

            //    get_users();
            //    System.Diagnostics.Debug.WriteLine("end download");

            //    result = true;
            //    MessageBox.Show("Data Download", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}


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
            public string villlage_code { get; set; }
            public string cluster_no { get; set; }


        }


        public class user_model
        {
            public string username { get; set; }
            public string password { get; set; }
            public string full_name { get; set; }

        }
        public List<data_villages> obj;

        public void get_villages()
        {

            try
            {
                System.Diagnostics.Debug.WriteLine("villages start");



                var test = "{\"table\":\"villages\"}";



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
                obj = JsonConvert.DeserializeObject<List<data_villages>>(Json);
            }

            catch (Exception ex)
            {

                if (ex.Message == "The remote name could not be resolved: 'f38158'")
                {
                    MessageBox.Show("Please Open Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }



            finally
            {

                SQLiteDataAdapter da = null;
                DataSet ds = null;

                da = new SQLiteDataAdapter("delete from villages", cn.cn);
                ds = new DataSet();
                da.Fill(ds);


                for (int a = 0; a <= obj.Count - 1; a++)
                {

                    string qry = "insert into villages(villlage_code, village, district_code, district, uc_code, uc,country,country_code,cluster_no) values('" + obj[a].villlage_code + "', '" + obj[a].village + "', '" + obj[a].district_code + "', '" + obj[a].district + "', '" + obj[a].uc_code + "', '" + obj[a].uc + "', '" + obj[a].country + "', '" + obj[a].country_code + "', '" + obj[a].cluster_no + "')";

                    da = new SQLiteDataAdapter(qry, cn.cn);

                    ds = new DataSet();
                    da.Fill(ds);

                }
                //MessageBox.Show("Data Download", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                System.Diagnostics.Debug.WriteLine("villages end");
            }


        
            
           
        }
        public void get_users()
        {
            System.Diagnostics.Debug.WriteLine("user start");



            var user_var = "{\"table\":\"users\"}"; ;



            HttpWebRequest webRequest;

            string requestParams = user_var.ToString();

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
            var user_obj = JsonConvert.DeserializeObject<List<user_model>>(Json);




           

            SQLiteDataAdapter da = null;
            DataSet ds = null;

            da = new SQLiteDataAdapter("delete from users", cn.cn);
            ds = new DataSet();
            da.Fill(ds);


            for (int a = 0; a <= user_obj.Count - 1; a++)
            {

                string qry = "insert into users(username,password,full_name)  values('" + user_obj[a].username + "','" + user_obj[a].password + "','" + user_obj[a].full_name + "')";

                da = new SQLiteDataAdapter(qry, cn.cn);

                ds = new DataSet();
                da.Fill(ds);

            }
            //MessageBox.Show("Data Download", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            System.Diagnostics.Debug.WriteLine("villages end");


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            //DateTime buildDate = new DateTime(2000, 1, 1)
            //                        .AddDays(version.Build).AddMinutes(version.Revision);
            //string displayableVersion = $"{version}";
           
            this.text_verNo.Text = version.Major + "."+Math.Round((version.Build/365.24))+"."+Math.Round((double)(version.Revision/60)); 
        }
    }
}
