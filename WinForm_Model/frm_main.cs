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
using Newtonsoft.Json;
using System.Web;

namespace WinForm_Model
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
            get_data();
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
            public string villlage_code { get; set; }
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
            int a = 1;




        }


    }
}
