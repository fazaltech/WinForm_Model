﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Model
{
    public partial class Form_gm : Form
    {
        public Form_gm()
        {
            InitializeComponent();
            list_cr24();
        }

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
            string_variable list = new string_variable();
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

                combox_cr24.DataSource = bindingSource1.DataSource;

                combox_cr24.DisplayMember = "Value";
                combox_cr24.ValueMember = "Id";
            }
            catch {



            }

        }

        public class list_view
        {

            public int Id { get; set; }
            public string Label { get; set; }
            public string Value { get; set; }
        }
    }
}
