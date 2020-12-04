using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm_Model.Model;

namespace WinForm_Model
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private win_mvcEntities db = new win_mvcEntities();


        public  void Insert()
        {
            
            tbluser users = new tbluser();
            users.user_id = Convert.ToInt32(this.txt_usr_id.Text);
            users.user_name= txt_usr_name.Text;
            users.fullname = txt_full_name.Text;
            users.email_id = txt_email.Text;
            bool result = SaveUserDetails(users);  
            //ShowStatus(result, "Save");

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
    }
}
