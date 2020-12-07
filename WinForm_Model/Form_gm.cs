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

       
        public string cr10 = "-1";
        public string cr11 = "-1";
        public string cr12 = "-1";

        public string cr16 = "-1";
         
        public string cr21 = "-1";
        public string cr22 = "-1";
        public string cr23 = "-1";
         
         
        public string cr17a = "-1";
        public string cr17b = "-1";
         
        public string cr18a = "-1";
        public string cr18b = "-1";
         
        public string cr19a = "-1";
        public string cr19b = "-1";
         
        public string cr20a = "-1";
        public string cr20b = "-1";
         
        public string cr24a = "-1";
        public string cr24b = "-1";
        public string cr24c = "-1";
        public string cr24d = "-1";
        public string cr24e = "-1";
        public string cr24f = "-1";
         
         
        public string cr25a = "-1";
        public string cr25b = "-1";
        public string cr25c = "-1";
         
        public string cr26a = "-1";
        public string cr26b = "-1";
        public string cr26c = "-1";
        public string cr26d = "-1";
         
        public string cr27a = "-1";
        public string cr27b = "-1";
        public string cr27c = "-1";
         
        public string cr28a01 = "-1";
        public string cr28a02 = "-1";
        public string cr28b01 = "-1";
        public string cr28b02 = "-1";
        public string cr28c01 = "-1";
        public string cr28c02 = "-1";
        public string cr28d01 = "-1";
        public string cr28d02 = "-1";
        public string cr28e01 = "-1";
        public string cr28e02 = "-1";
        public string cr28f01 = "-1";
        public string cr28f02 = "-1";
        public string cr28fx01 = "-1";
        public string cr28fx02 = "-1";

    

        public void controls_value()
        {

          


            if (text_cr10.Text !=null) { cr10 = text_cr10.Text; }
            if (text_cr11.Text !=null) { cr11 = text_cr11.Text; }
            if (text_cr12.Text !=null) { cr12 = text_cr12.Text; }
            if (text_cr16.Text !=null) { cr16 = text_cr16.Text; }
            if (text_cr21.Text !=null) { cr21 = text_cr21.Text; }
            if (text_cr22.Text !=null) { cr22 = text_cr22.Text; }
            if (text_cr23.Text !=null) { cr23 = text_cr23.Text; }



            //if (radio_cr17a.Checked){cr17a = "1";}

            //if (radio_cr17b.Checked) { cr17b = "1"; }

            if (radio_cr18a.Checked) { cr18a = "1"; }
            if (radio_cr18b.Checked) { cr18b = "1"; }

            if (radio_cr19a.Checked) { cr19a = "1"; }
            if (radio_cr19b.Checked) { cr19b = "1"; }

            if (radio_cr20a.Checked) { cr19a = "1"; }
            if (radio_cr20b.Checked) { cr19b = "1"; }

            if (check_cr24a.Checked) { cr24a = "1"; }
            if (check_cr24b.Checked) { cr24b = "1"; }
            if (check_cr24c.Checked) { cr24c = "1"; }
            if (check_cr24d.Checked) { cr24d = "1"; }
            if (check_cr24e.Checked) { cr24e = "1"; }
            if (check_cr24f.Checked) { cr24f = "1"; }

            if (check_cr25a.Checked) { cr25a = "1"; }
            if (check_cr25b.Checked) { cr25b = "1"; }
            if (check_cr25c.Checked) { cr25c = "1"; }

            if (check_cr26a.Checked) { cr26a = "1"; }
            if (check_cr26b.Checked) { cr26b = "1"; }
            if (check_cr26c.Checked) { cr26c = "1"; }
            if (check_cr26d.Checked) { cr26d = "1"; }

            //if (check_cr27a.Checked) { cr27a = "1"; }
            //if (check_cr27b.Checked) { cr27b = "1"; }
            //if (check_cr27c.Checked) { cr27c = "1"; }


            if (radio_cr28a01.Checked) { cr28a01 = "1"; }
            if (radio_cr28a02.Checked) { cr28a02 = "1"; }
            if (radio_cr28b01.Checked) { cr28b01 = "1"; }
            if (radio_cr28b02.Checked) { cr28b02 = "1"; }
            if (radio_cr28c01.Checked) { cr28c01 = "1"; }
            if (radio_cr28c02.Checked) { cr28c02 = "1"; }
            if (radio_cr28d01.Checked) { cr28d01 = "1"; }
            if (radio_cr28d02.Checked) { cr28d02 = "1"; }
            if (radio_cr28e01.Checked) { cr28e01 = "1"; }
            if (radio_cr28e02.Checked) { cr28e02 = "1"; }

            if (radio_cr28f01.Checked) { cr28f01 = "1"; }
            if (radio_cr28f02.Checked) { cr28f02 = "1"; }
            if (radio_cr28fx01.Checked) { cr28fx01 = "1"; }
            if (radio_cr28fx02.Checked) { cr28fx02 = "1"; }

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


            form forms = new form();
            forms.cr10 = cr10;
            forms.cr11 = cr11;
            forms.cr12 = cr12;
            forms.cr16 = cr16;
            forms.cr21 = cr21;
            forms.cr22 = cr22;
            forms.cr23 = cr23;
            forms.cr17a = cr17a;
            forms.cr17b = cr17b;
            forms.cr18a = cr18a;
            forms.cr18b = cr18b;
            forms.cr19a = cr19a;
            forms.cr19b = cr19b;
            forms.cr20a = cr20a;
            forms.cr20b = cr20b;
            forms.cr24a = cr24a;
            forms.cr24b = cr24b;
            forms.cr24c = cr24c;
            forms.cr24d = cr24d;
            forms.cr24e = cr24e;
            forms.cr24f = cr24f;
            forms.cr25a = cr25a;
            forms.cr25b = cr25b;
            forms.cr25c = cr25c;
            forms.cr26a = cr26a;
            forms.cr26b = cr26b;
            forms.cr26c = cr26c;
            forms.cr26d = cr26d;
            forms.cr27a = cr27a;
            forms.cr27b = cr27b;
            forms.cr27c = cr27c;
            forms.cr28a01 = cr28a01;
            forms.cr28a02 = cr28a02;
            forms.cr28b01 = cr28b01;
            forms.cr28b02 = cr28b02;
            forms.cr28c01 = cr28c01;
            forms.cr28c02 = cr28c02;
            forms.cr28d01 = cr28d01;
            forms.cr28d02 = cr28d02;
            forms.cr28e01 = cr28e01;
            forms.cr28e02 = cr28e02;
            forms.cr28f01 = cr28f01;
            forms.cr28f02 = cr28f02;
            forms.cr28fx01 = cr28fx01;
            forms.cr28fx02 = cr28fx02;

            bool result = SaveForms(forms);
            ////ShowStatus(result, "Save");

        }


        public bool SaveForms(form data_add) // calling SaveStudentMethod for insert a new record  
        {
            bool result = false;
            if (data_add != null)
            {
                db.forms.Add(data_add);
                db.SaveChanges();
                result = true;
            }
            return result;
        }

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

            MessageBox.Show("Cr10", "TEST");


            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(text_cr10.Text, "Demo App - Message!");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
