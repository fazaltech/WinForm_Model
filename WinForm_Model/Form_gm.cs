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
    public partial class Form_gm : Form
    {

        private win_mvc_conn db = new win_mvc_conn();
        public Form_gm()
        {
            InitializeComponent();
            list_cr24();
            controls_text();
            controls_value();
            CenterToScreen();
           

        }

        
        string_variable list = new string_variable();
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form_gm_Load(object sender, EventArgs e)
        {

        }
        public void list_cr24()
        {
           
            List<list_view> cs06 = new List<list_view>()
            {
                new list_view() {Id = 1, Label = list.cr06a,Value = list.cr06a},
                new list_view() {Id = 2, Label = list.cr06b,Value = list.cr06b},
                new list_view() {Id = 2, Label = list.cr06c,Value = list.cr06c},
                new list_view() {Id = 2, Label = list.cr06d,Value = list.cr06d},
                new list_view() {Id = 2, Label = list.cr06e,Value = list.cr06e},

            };


            try {

                var bindingSource1 = new BindingSource();
                bindingSource1.DataSource = cs06;

                //combox_cr24.DataSource = bindingSource1.DataSource;

                //combox_cr24.DisplayMember = "Value";
                //combox_cr24.ValueMember = "Id";
            }
            catch {



            }

        }

        public void controls_text()
        {
            radio_cr13m.Text = list.cr13M;
            radio_cr13f.Text = list.cr13F;


            radio_cr17a.Text = list.cr17a;
            radio_cr17b.Text = list.cr17b;

            radio_cr18a.Text = list.cr18a;
            radio_cr18b.Text = list.cr18b;

            radio_cr19a.Text = list.cr19a;
            radio_cr19b.Text = list.cr19b;

            radio_cr20a.Text = list.cr20a;
            radio_cr20b.Text = list.cr20b;



            check_cr24a.Text = list.cr24a;
            check_cr24b.Text = list.cr24b;
            check_cr24c.Text = list.cr24c;
            check_cr24d.Text = list.cr24d;
            check_cr24e.Text = list.cr24e;
            check_cr24f.Text = list.cr24f;


            check_cr25a.Text = list.cr25a;
            check_cr25b.Text = list.cr25b;
            check_cr25c.Text = list.cr25c;

            check_cr26a.Text = list.cr26a;
            check_cr26b.Text = list.cr26b;
            check_cr26c.Text = list.cr26c;
            check_cr26d.Text = list.cr26d;

            label_cr27a.Text = list.cr27a;
            label_cr27b.Text = list.cr27b;
            label_cr27c.Text = list.cr27c;

            label_cr28a.Text = list.cr28a;
            label_cr28b.Text = list.cr28b;
            label_cr28c.Text = list.cr28c;
            label_cr28d.Text = list.cr28d;
            label_cr28e.Text = list.cr28e;
            label_cr28f.Text = list.cr28f;
            label_cr28fx.Text = list.cr28fx;


            radio_cr28a01.Text = list.cr28a01;
            radio_cr28a02.Text = list.cr28a02;
            radio_cr28b01.Text = list.cr28b01;
            radio_cr28b02.Text = list.cr28b02;
            radio_cr28c01.Text = list.cr28c01;
            radio_cr28c02.Text = list.cr28c02;
            radio_cr28d01.Text = list.cr28d01;
            radio_cr28d02.Text = list.cr28d02;
            radio_cr28e01.Text = list.cr28e01;
            radio_cr28e02.Text = list.cr28e02;
            radio_cr28f01.Text = list.cr28f01;
            radio_cr28f02.Text = list.cr28f02;
            radio_cr28fx01.Text = list.cr28fx01;
            radio_cr28fx02.Text = list.cr28fx02;



        }


        public string cr01 = "-1";
        public string cr02 = "-1";
        public string cr03 = "-1";
        public string cr04 = "-1";
        public string cr05 = "-1";
        public string cr06 = "-1";
        public string cr07 = "-1";
        public string cr08d = "-1";
        public string cr08m = "-1";
        public string cr08y = "-1";
        public string cr09 = "-1";
        public string cr10 = "-1";
        public string cr11 = "-1";
        public string cr12 = "-1";
        public string cr13 = "-1";
        public string cr14d = "-1";
        public string cr15m = "-1";
        public string cr15y = "-1";
        public string cr16 = "-1";
        public string cr17 = "-1";
        public string cr18 = "-1";
        public string cr19 = "-1";
        public string cr20 = "-1";
        public string cr21 = "-1";
        public string cr22 = "-1";
        public string cr23 = "-1";
        public string cr24a = "-1";
        public string cr24b = "-1";
        public string cr24c = "-1";
        public string cr24d = "-1";
        public string cr24e = "-1";
        public string cr24f = "-1";
        public string cr25 = "-1";
        public string cr26 = "-1";
        public string cr27a = "-1";
        public string cr27b = "-1";
        public string cr27c = "-1";
        public string cr28a = "-1";
        public string cr28b = "-1";
        public string cr28c = "-1";
        public string cr28d = "-1";
        public string cr28e = "-1";
        public string cr28f = "-1";
        public string cr28fx = "-1";



        public void controls_value()
        {

          


            if (text_cr10.Text !=null) { cr10 = text_cr10.Text; }
            if (text_cr11.Text !=null) { cr11 = text_cr11.Text; }
            if (text_cr12.Text !=null) { cr12 = text_cr12.Text; }
            if (text_cr16.Text !=null) { cr16 = text_cr16.Text; }
            if (text_cr21.Text !=null) { cr21 = text_cr21.Text; }
            if (text_cr22.Text !=null) { cr22 = text_cr22.Text; }
            if (text_cr23.Text !=null) { cr23 = text_cr23.Text; }
            if (text_cr27a.Text !=null) { cr27a = text_cr27a.Text; }
            if (text_cr27b.Text !=null) { cr27a = text_cr27b.Text; }
            if (text_cr27c.Text !=null) { cr27a = text_cr27c.Text; }
            
            
            if (text_cr28fx98.Text != null) { cr28fx = text_cr28fx98.Text; }



            //if (radio_cr17a.Checked){cr17a = "1";}

            //if (radio_cr17b.Checked) { cr17b = "1"; }
            if (radio_cr13m.Checked) { cr13 = "1"; } else if (!radio_cr13m.Checked) { cr13 = "2"; }
          
            
            if (radio_cr17a.Checked) { cr17 = "1"; } else if (!radio_cr17a.Checked) { cr17 = "2"; }
            if (radio_cr18a.Checked) { cr18 = "1"; } else if (!radio_cr18a.Checked) { cr18 = "2"; }
            if (radio_cr19a.Checked) { cr18 = "1"; } else if (!radio_cr19a.Checked) { cr19 = "2"; }
            if (radio_cr20a.Checked) { cr20 = "1"; } else if (!radio_cr20a.Checked) { cr20 = "2"; }

        
            if (check_cr24a.Checked) { cr24a = "1"; }
            if (check_cr24b.Checked) { cr24b = "2"; }
            if (check_cr24c.Checked) { cr24c = "3"; }
            if (check_cr24d.Checked) { cr24d = "4"; }
            if (check_cr24e.Checked) { cr24e = "5"; }
            if (check_cr24f.Checked) { cr24f = "6"; }

            if (check_cr25a.Checked) { cr25 = "1"; }else if (check_cr25b.Checked) { cr25 = "2"; }  if (check_cr25c.Checked) { cr25 = "3"; }

            if (check_cr26a.Checked) { cr26 = "1"; }else if (check_cr26b.Checked) { cr26 = "2"; }if (check_cr26c.Checked) { cr26 = "3"; }if (check_cr26d.Checked) { cr26 = "4"; }

           // if (check_cr27a.Checked) { cr27a = "1"; }else if (check_cr27b.Checked) { cr27b = "1"; }else if (check_cr27c.Checked) { cr27c = "1"; }

            if (radio_cr28a01.Checked) { cr28a = "1"; }else if(radio_cr28a02.Checked) { cr28a = "2"; }
            if (radio_cr28b01.Checked) { cr28b = "1"; }else if(radio_cr28b02.Checked) { cr28b = "2"; }
            if (radio_cr28c01.Checked) { cr28c = "1"; }else if(radio_cr28c02.Checked) { cr28b = "2"; }
            if (radio_cr28d01.Checked) { cr28d = "1"; }else if(radio_cr28d02.Checked) { cr28b = "2"; }
            if (radio_cr28e01.Checked) { cr28e = "1"; }else if(radio_cr28e02.Checked) { cr28b = "2"; }
            if (radio_cr28f01.Checked) { cr28fx = "1"; }else if(radio_cr28f02.Checked) { cr28fx = "2"; }



            dateTime_cr14.MaxDate = DateTime.Today;




        }

        public class list_view
        {

            public int Id { get; set; }
            public string Label { get; set; }
            public string Value { get; set; }
        }

        private void button_frmdata_Click(object sender, EventArgs e)
        {
            Insert();
        }




        public void Insert()
        {
            controls_value();

            DateTime now = DateTime.Now;
            form_data forms = new form_data();

            forms.cr01 = DataBaseVariable.dis1;
            forms.cr02 = DataBaseVariable.CR_02;
            forms.cr03 = DataBaseVariable.CR_03;
            forms.cr04 = DataBaseVariable.ucss1;
            forms.cr05 = DataBaseVariable.vill1;
            forms.cr06 = DataBaseVariable.CR_06; 
            forms.cr07 = DataBaseVariable.CR_07; 
            forms.cr08d = DataBaseVariable.ScreenData.ToString("dd");
            forms.cr08m = DataBaseVariable.ScreenData.ToString("MM");
            forms.cr08y = DataBaseVariable.ScreenData.ToString("yyyy");
            forms.cr09 = DataBaseVariable.CR_09;

            forms.cr10 = cr10;
            forms.cr11 = cr11;
            forms.cr12 = cr12;
            forms.cr13 = cr13;
           
            forms.cr14d = cr10;
            forms.cr15m = cr10;
            forms.cr15y = cr10;
            forms.cr16 = cr16;
            forms.cr21 = cr21;
            forms.cr22 = cr22;
            forms.cr23 = cr23;
            forms.cr17 = cr17;
            
            forms.cr18 = cr18;
           
            forms.cr19 = cr19;
            
            forms.cr20 = cr20;
           
            forms.cr24a = cr24a;
            forms.cr24b = cr24b;
            forms.cr24c = cr24c;
            forms.cr24d = cr24d;
            forms.cr24e = cr24e;
            forms.cr24f = cr24f;
            forms.cr25 = cr25;
           
            forms.cr26 = cr26;
           
            forms.cr27a = cr27a;
            forms.cr27b = cr27b;
            forms.cr27c = cr27c;
            forms.cr28a = cr28a;
             forms.cr28b=  cr28b;
             forms.cr28c=  cr28c;
             forms.cr28d=  cr28d;
             forms.cr28e=  cr28e;
             forms.cr28f = cr28fx;
             forms.cr28fx= cr28fx;
            
            forms.endingdatetime = now.ToString("MM/dd/yyyy HH:mm:ss.fff");
            forms.username = DataBaseVariable.UserName;

            SQLiteDatabase.InsertForm(forms);
            ////ShowStatus(result, "Save");

        }


        //public bool SaveForms(form data_add) // calling SaveStudentMethod for insert a new record  
        //{
        //    bool result = false;
        //    if (data_add != null)
        //    {
        //        db.forms.Add(data_add);
        //        db.SaveChanges();
        //        result = true;
        //    }
        //    return result;
        //}

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radio_cr18b_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radio_cr13m_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_cr13f_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            //Insert();
            if (validation())
            {

                Insert();
                DataBaseVariable.frm_gm1 = this;
                this.Hide();

                Form_gm obj_frmgm = new Form_gm();
                obj_frmgm.Show();
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void check_cr26b_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string error_text;

        public bool validation()
        {
            if (text_cr10.Text == "")
            {

                errorProvider1.SetError(text_cr10, "Please Enter Child Registration Number.");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (text_cr11.Text == "")
            {

                errorProvider1.SetError(text_cr11, "Please Enter Child Name");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (text_cr12.Text == "")
            {

                errorProvider1.SetError(text_cr12, "Please Enter Father Name");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr13m.Checked != true && radio_cr13f.Checked != true)
            {

                errorProvider1.SetError(radio_cr13m, "Please Select Gender");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (text_cr16.Text == "")
            {

                errorProvider1.SetError(text_cr16, "Please Select Gender");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr17a.Checked != true && radio_cr17b.Checked != true)
            {

                errorProvider1.SetError(radio_cr17a, "Please Select fed your child");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr18a.Checked != true && radio_cr18b.Checked != true)
            {

                errorProvider1.SetError(radio_cr18a, "Please Select child being currently exclusively");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (radio_cr19a.Checked != true && radio_cr19b.Checked != true)
            {

                errorProvider1.SetError(label27, "Please Select complimentary feeding");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr19a.Checked != true && radio_cr19b.Checked != true)
            {

                errorProvider1.SetError(label27, "Please Select complimentary feeding");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr20a.Checked != true && radio_cr20b.Checked != true)
            {

                errorProvider1.SetError(label26, "Please Select complimentary feeding");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }


            if (radio_cr20a.Checked != true && radio_cr20b.Checked != true)
            {

                errorProvider1.SetError(radio_cr20a, "Please Select complimentary feeding");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (!text_cr21.MaskFull)
            {
                errorProvider1.SetError(text_cr21, "Please Select complimentary feeding");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (text_cr22.Text == "")
            {
                errorProvider1.SetError(text_cr22, "Please Select complimentary feeding");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (text_cr23.Text == "")
            {
                errorProvider1.SetError(text_cr23, "Please Select complimentary feeding");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (check_cr24a.Checked != true && check_cr24b.Checked != true && check_cr24c.Checked != true && check_cr24d.Checked != true && check_cr24e.Checked != true && check_cr24f.Checked != true)
            {
                errorProvider1.SetError(check_cr24a, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }

            if (check_cr25a.Checked != true && check_cr25b.Checked != true && check_cr25c.Checked != true)
            {

                errorProvider1.SetError(check_cr25a, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (check_cr26a.Checked != true && check_cr26b.Checked != true && check_cr26c.Checked != true && check_cr26d.Checked != true)
            {
                errorProvider1.SetError(check_cr26a, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (text_cr27a.Text == "" && text_cr27b.Text == "" && text_cr27c.Text == "")
            {

                errorProvider1.SetError(text_cr27a, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr28a01.Checked != true && radio_cr28a02.Checked != true)
            {

                errorProvider1.SetError(radio_cr28a01, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr28b01.Checked != true && radio_cr28b02.Checked != true)
            {

                errorProvider1.SetError(radio_cr28b01, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr28c01.Checked != true && radio_cr28c02.Checked != true)
            {
                errorProvider1.SetError(radio_cr28c01, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr28d01.Checked != true && radio_cr28d02.Checked != true)
            {
                errorProvider1.SetError(radio_cr28d01, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr28e01.Checked != true && radio_cr28e02.Checked != true)
            {
                errorProvider1.SetError(radio_cr28e01, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr28f01.Checked != true && radio_cr28f02.Checked != true)
            {
                errorProvider1.SetError(radio_cr28f01, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (radio_cr28fx01.Checked != true && radio_cr28fx02.Checked != true)
            {
                errorProvider1.SetError(radio_cr28fx01, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            if (text_cr28fx98.Visible == true && text_cr28fx98.Text == "")
            {
                errorProvider1.SetError(radio_cr28fx01, "Please Select ");
                return false;
            }
            else
            {
                errorProvider1.Clear();
            }
            float height;
            if (float.TryParse(text_cr21.Text, out height))
            {
                if (height <= 010.0 || height >= 140.0)
                {
                    errorProvider1.SetError(text_cr21, "Value Between 10.0 and 140.0");
                    return false;
                }
            }
            else
            {
                errorProvider1.Clear();
            }
            float weight;
            if (float.TryParse(text_cr22.Text, out weight))
            {
                if (weight <= 00.5 || weight >= 40.0)
                {
                    errorProvider1.SetError(text_cr22, "Value Between 00.5 and 40.0 ");
                    return false;
                }
            }
            else
            {
                errorProvider1.Clear();
            }
            float mauc;
            if (float.TryParse(text_cr23.Text, out mauc))
            {
                if (mauc <= 05.0 || mauc >= 25.0)
                {
                    errorProvider1.SetError(text_cr23, "Value Between 05.0 and 25.0 ");
                    return false;
                }
            }
            float birthweight;
            if (float.TryParse(text_cr16.Text, out birthweight))
            {
                if (mauc <= 05.0 || mauc >= 40.0)
                {
                    errorProvider1.SetError(text_cr16, "Value Between 05.0 and 40.0 ");
                    return false;
                }
            }
            else
            {
                errorProvider1.Clear();
            }
            return true;


        }


        private void errorcolor(Control errc)
        {
            errc.BackColor = Color.IndianRed;
            errc.ForeColor = Color.White;
        }


        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void text_cr10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void radio_cr28fx01_Click(object sender, EventArgs e)
        {
            if (radio_cr28fx01.Checked == true)
            {
                text_cr28fx98.Visible = true;
            }
            else { text_cr28fx98.Visible = true; text_cr28fx98.Text = ""; }
        }

        private void radio_cr28fx01_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_cr28fx02_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radio_cr28fx02_Click(object sender, EventArgs e)
        {
            if (text_cr28fx98.Visible == true)
            {
                text_cr28fx98.Visible = false;
                text_cr28fx98.Text = "";
            }
           
        }

        private void text_cr10_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void text_cr11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void text_cr21_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void text_cr12_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void text_cr22_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void text_cr23_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }

        private void text_cr23_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

       

        private void dateTime_cr14_Leave(object sender, EventArgs e)
        {
            age_calulator();
        }

        public void age_calulator()
        {

            DateTime start = dateTime_cr14.Value;
            DateTime end = DateTime.Now;

            TimeSpan ts = end - start;

            //double th = td.TotalHours;
            double td = ts.TotalDays;
            double ty = td/ 365;
            double rd = td % 365;
            double tm = rd / 30;
            rd = rd % 30;

            //double tm = (td / 30);
            //double ty = (tm / 12);

            //double tm = (ts. / 24);
            string textday= rd.ToString("0");
            string textmm= tm.ToString("00");
            string textyy= ty.ToString("00");
            //string textday;
            //string textday;
            text_cr15.Text = textday+" Days "+textmm+"Month "+textyy+"year ";


        }

        private void text_cr15_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
