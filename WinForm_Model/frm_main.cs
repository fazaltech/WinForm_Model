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
            controls_text();


            District_DropDown();


        }
        private win_mvc_conn db = new win_mvc_conn();
        string_variable list = new string_variable();
        private DataRow emptyRow;


        private void button_insert_Click(object sender, EventArgs e)
        {

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

        public string cr02 = "-1";
        public string cr06 = "-1";
        public string cr0698 = "-1";
        public string cr03 = "-1";
        public string cr07 = "-1";
        
        public string cr09 = "-1";
        
       

        public void controls_value()
        {

            if (radio_cr02a.Checked) { cr02 = "1"; }else if (radio_cr02b.Checked) { cr02 = "2"; } else if (radio_cr02c.Checked) { cr02 = "3"; }
            if (radio_cr0601.Checked) { cr06 = "1"; } else if (radio_cr0602.Checked) { cr06 = "2"; } else if (radio_cr0603.Checked) { cr06 = "3"; } else if (radio_cr0604.Checked) { cr06 = "4"; } else if (radio_cr0605.Checked) { cr06 = "5"; } else if (radio_cr06098.Checked) { cr06 = "98"; }
            if (text_cr06other.Text != null) { cr0698 = text_cr06other.Text; }
            if (text_cr03.Text != null) { cr03 = text_cr03.Text; }
            if (text_cr07.Text != null) { cr07 = text_cr07.Text; }
            if (text_cr09.Text != null) { cr09 = text_cr09.Text; }
            DataBaseVariable.ScreenData = dateTime_cr08.Value;
            DataBaseVariable.dis1 = combo_cr01.SelectedValue.ToString();
            DataBaseVariable.ucss1 = combo_cr04.SelectedValue.ToString();
            DataBaseVariable.vill1 = combo_cr05.SelectedValue.ToString();
            DataBaseVariable.CR_09 = cr09;
            DataBaseVariable.CR_06 = cr06;
            DataBaseVariable.CR_0698 = cr0698;
            DataBaseVariable.CR_07 = cr07;
            DataBaseVariable.CR_02 = cr02;
            DataBaseVariable.CR_03 = cr03;
            

            //if (radio_cr18a.Checked) { cr18 = "1"; } else if (!radio_cr18a.Checked) { cr18 = "2"; }
            //if (radio_cr19a.Checked) { cr18 = "1"; } else if (!radio_cr19a.Checked) { cr19 = "2"; }
            //if (radio_cr20a.Checked) { cr20 = "1"; } else if (!radio_cr20a.Checked) { cr20 = "2"; }
        }


        public void controls_text()
        {
            radio_cr02a.Text = list.cr02a;
            radio_cr02b.Text = list.cr02b;
            radio_cr02c.Text = list.cr02c;
            radio_cr0601.Text = list.cr06a;
            radio_cr0602.Text = list.cr06b;
            radio_cr0603.Text = list.cr06c;
            radio_cr0604.Text = list.cr06d;
            radio_cr0605.Text = list.cr06e;
            radio_cr06098.Text = list.cr06x;
        }



        private void District_DropDown()
        {
            combo_cr01.DisplayMember = "Select";

            try
            {
                DataBase cn = new DataBase();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from villages where country_code=2 group by district", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);


                emptyRow = ds.Tables[0].NewRow();
                emptyRow["district"] = "";
                emptyRow["district_code"] = "";
                ds.Tables[0].Rows.Add(emptyRow);




                DataView newView =
                new DataView(ds.Tables[0],       // source table
                "",                             // filter
                "district_code",            // sort by column
                DataViewRowState.CurrentRows);  // rows with state to display

                combo_cr01.DataSource = newView;
                combo_cr01.DisplayMember = "district";

                combo_cr01.ValueMember = "district_code";
                var dt = ds.Tables[0];





            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Village_DropDown()
        {
            //string getvalue = combo_cr04.
            string getvalue = combo_cr04.SelectedValue.ToString();


            try
            {
                DataBase cn = new DataBase();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from villages  where uc_code ='" + getvalue + "' group by village", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                emptyRow = ds.Tables[0].NewRow();
                emptyRow["village"] = "";
                emptyRow["district_code"] = "";
                ds.Tables[0].Rows.Add(emptyRow);

                DataView newView =
                new DataView(ds.Tables[0],       // source table
                "",                             // filter
                "villlage_code",            // sort by column
                DataViewRowState.CurrentRows);  // rows with state to display

                combo_cr05.DataSource = newView;
                combo_cr05.DisplayMember = "village";
                combo_cr05.ValueMember = "villlage_code";
                var dt = ds.Tables[0];




            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




        private void UCDropDown()
        {
            string dis = combo_cr01.SelectedValue.ToString();


            try
            {
                DataBase cn = new DataBase();

                SQLiteDataAdapter da = new SQLiteDataAdapter("select * from villages  where district_code ='" + dis + "' group by uc", cn.cn);
                DataSet ds = new DataSet();
                da.Fill(ds);

                emptyRow = ds.Tables[0].NewRow();
                emptyRow["village"] = "";
                emptyRow["district_code"] = "";
                ds.Tables[0].Rows.Add(emptyRow);

                DataView newView =
                new DataView(ds.Tables[0],       // source table
                "",                             // filter
                "uc_code",            // sort by column
                DataViewRowState.CurrentRows);  // rows with state to display

                combo_cr04.DataSource = newView;
                combo_cr04.DisplayMember = "uc";
                combo_cr04.ValueMember = "uc_code";
                var dt = ds.Tables[0];




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


            combo_cr05.DataSource = null;
            combo_cr05.Items.Clear();
            UCDropDown();
        }

        private void combo_cr01_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void combo_cr01_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void text_cr09_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void combo_cr02_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_cr03_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_cr04_SelectedIndexChanged(object sender, EventArgs e)
        {
            Village_DropDown();
        }

        private void combo_cr05_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void text_cr07_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_cr01_Leave(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (ValidateForm())
            {
                DataBaseVariable.dis1 = combo_cr01.SelectedValue.ToString();
                DataBaseVariable.ucss1 = combo_cr04.SelectedValue.ToString();
                DataBaseVariable.vill1 = combo_cr05.SelectedValue.ToString();
                controls_value();

                DataBaseVariable.frm_main1 = this;
                this.Hide();

                Form_gm obj_frmgm = new Form_gm();
                obj_frmgm.Show();
            }






        }
        private bool ValidateForm()
        {

            if (combo_cr01.SelectedIndex < 1)
            {
                errorProvider1.SetError(combo_cr01, "Please select District.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }


            if (combo_cr04.SelectedIndex < 1)
            {
                errorProvider1.SetError(combo_cr04, "Please select UC.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (combo_cr05.SelectedIndex < 1)
            {
                errorProvider1.SetError(combo_cr05, "Please select Village.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (!(radio_cr02a.Checked || radio_cr02b.Checked || radio_cr02c.Checked))
            {
                errorProvider1.SetError(grp_cr02, "Please select Place of Screening.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (string.IsNullOrEmpty(text_cr09.Text))
            {
                errorProvider1.SetError(text_cr09, "Please select enter Khandan Number.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(text_cr03.Text))
            {
                errorProvider1.SetError(text_cr03, "Please select enter Facility.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(text_cr07.Text))
            {
                errorProvider1.SetError(text_cr07, "Please select enter Assessor Name.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radio_cr06098_CheckedChanged(object sender, EventArgs e)
        {
            if (text_cr06other.Visible == true)
            {
                text_cr06other.Visible = false;
                label_cr06other.Visible = false;
                text_cr06other.Text = "";

            }

        }

        private void radio_cr06098_Click(object sender, EventArgs e)
        {
            if (text_cr06other.Visible == false)
            {
                label_cr06other.Visible = true;
                text_cr06other.Visible = true;

            }

        }
    }
}
