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


        public void controls_text()
        {
            radio_cr02a.Text = list.cr02a;
            radio_cr02b.Text = list.cr02b;
            radio_cr02c.Text = list.cr02c;
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
    }
} 
