using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Model.Model;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Web;
using System.Data.SQLite;

namespace WinForm_Model
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            // get_data();
            District_DropDown();
            
            //UCDropDown();

        }
        private win_mvc_conn db = new win_mvc_conn();


        public void Insert()
        {

            //tbluser users = new tbluser();
            //users.user_id = Convert.ToInt32(this.txt_usr_id.Text);
            //users.user_name= txt_usr_name.Text;
            //users.fullname = txt_full_name.Text;
            //users.email_id = txt_email.Text;
            //bool result = SaveUserDetails(users);  
            ////ShowStatus(result, "Save");

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Insert();
        }
        public bool SaveUserDetails(tbluser user_add) // calling SaveStudentMethod for insert a new record  
        {
            bool result = false;
            if (user_add != null)
            {
                db.tblusers.Add(user_add);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        //public void get_data()
        //{

           
        //    var get_key = new post_data()
        //    {
        //        table = "villages"
        //    };
        //    var test = JsonConvert.SerializeObject(get_key);



        //    HttpWebRequest webRequest;

        //    string requestParams = test.ToString();

        //    webRequest = (HttpWebRequest)WebRequest.Create("http://f38158/casi_gm/api/getdata.php");

        //    webRequest.Method = "POST";
        //    webRequest.ContentType = "application/json";

        //    byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
        //    webRequest.ContentLength = byteArray.Length;
        //    Stream requestStream = webRequest.GetRequestStream();

        //    requestStream.Write(byteArray, 0, byteArray.Length);


        //    // Get the response.
        //    WebResponse response = webRequest.GetResponse();

        //    Stream responseStream = response.GetResponseStream();

        //    StreamReader rdr = new StreamReader(responseStream, Encoding.UTF8);
        //    string Json = rdr.ReadToEnd(); // response from server
        //    var obj = JsonConvert.DeserializeObject<List<data_villages>>(Json);




        //    DataBase cn = new DataBase();

        //    SQLiteDataAdapter da = null;
        //    DataSet ds = null;

        //    da = new SQLiteDataAdapter("delete from villages", cn.cn);
        //    ds = new DataSet();
        //    da.Fill(ds);


        //    for (int a = 0; a <= obj.Count - 1; a++)
        //    {

        //        string qry = "insert into villages(village_code, village, district_code, district, uc_code, uc,country,country_code,cluster_no) values('" + obj[a].village_code + "', '" + obj[a].village + "', '" + obj[a].district_code + "', '" + obj[a].district + "', '" + obj[a].uc_code + "', '" + obj[a].uc + "', '" + obj[a].country + "', '" + obj[a].country_code + "', '" + obj[a].cluster_no + "')";

        //        da = new SQLiteDataAdapter(qry, cn.cn);

        //        ds = new DataSet();
        //        da.Fill(ds);

        //    }




        //}





        private void District_DropDown()
        {
            combo_cr01.DisplayMember = "Select";
            
            try
            {
                DataBase cn = new DataBase();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from villages where country_code=2 group by district_code", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                da.Fill(ds);

                combo_cr01.DataSource = ds.Tables[0];
                combo_cr01.DisplayMember = "district";
                combo_cr01.ValueMember = "district_code";
                var dt = ds.Tables[0];

       


                //for (i = 0; i <= dt.Rows.Count; i++)
                //{
                //    combo_cr01.Items.Insert(0, "select member");
                //    combo_cr01.SelectedIndex = 0;
                //    combo_cr01.Items.Add(dt.Rows[i][1]);
                //}
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void UCDropDown()
        {
            string dis = combo_cr01.ValueMember.ToString();
            try
            {
                DataBase cn = new DataBase();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from villages where district_code ='" + dis + "' ", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                da.Fill(ds);

                combo_cr04.DataSource = ds.Tables[0];
                combo_cr04.DisplayMember = "uc";
                combo_cr04.ValueMember = "uc_code";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void label_cr01_Click(object sender, EventArgs e)
        {

        }

        private void label_cr02_Click(object sender, EventArgs e)
        {
         
        }

        private void combo_cr01_SelectedIndexChanged(object sender, EventArgs e)
        {
            combo_cr04.Enabled = true;
            UCDropDown();
        }

        private void combo_cr01_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void combo_cr01_DisplayMemberChanged(object sender, EventArgs e)
        {
           
        }
    }
}
