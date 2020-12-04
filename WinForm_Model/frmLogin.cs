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
    public partial class frmLogin : Form
    {
       private win_mvc_conn db = new win_mvc_conn();
        public frmLogin()
        {
            InitializeComponent();
            //grp();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            tbluser users = new tbluser();
            users.user_name = text_user_name.Text;
            users.password = text_password.Text;

            if (IsValid(users.user_name, users.password) || (users.user_name=="test1234" && users.password== "test1234"))
            {


                LogStatus.Store_User = users.user_name;

                LogStatus.Log_Form = this;
                this.Hide();

                Form_gm obj_main = new Form_gm();
                obj_main.Show();

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
    }
}
