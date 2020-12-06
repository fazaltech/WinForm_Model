namespace WinForm_Model
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_cr01 = new System.Windows.Forms.Label();
            this.label_cr02 = new System.Windows.Forms.Label();
            this.label_cr03 = new System.Windows.Forms.Label();
            this.label_cr04 = new System.Windows.Forms.Label();
            this.label_cr05 = new System.Windows.Forms.Label();
            this.combo_cr01 = new System.Windows.Forms.ComboBox();
            this.combo_cr02 = new System.Windows.Forms.ComboBox();
            this.combo_cr03 = new System.Windows.Forms.ComboBox();
            this.combo_cr04 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_cr01
            // 
            this.label_cr01.AutoSize = true;
            this.label_cr01.Location = new System.Drawing.Point(47, 44);
            this.label_cr01.Name = "label_cr01";
            this.label_cr01.Size = new System.Drawing.Size(39, 13);
            this.label_cr01.TabIndex = 0;
            this.label_cr01.Text = "District";
            this.label_cr01.Click += new System.EventHandler(this.label_cr01_Click);
            // 
            // label_cr02
            // 
            this.label_cr02.AutoSize = true;
            this.label_cr02.Location = new System.Drawing.Point(47, 82);
            this.label_cr02.Name = "label_cr02";
            this.label_cr02.Size = new System.Drawing.Size(97, 13);
            this.label_cr02.TabIndex = 1;
            this.label_cr02.Text = "Place of Screening";
            this.label_cr02.Click += new System.EventHandler(this.label_cr02_Click);
            // 
            // label_cr03
            // 
            this.label_cr03.AutoSize = true;
            this.label_cr03.Location = new System.Drawing.Point(47, 120);
            this.label_cr03.Name = "label_cr03";
            this.label_cr03.Size = new System.Drawing.Size(39, 13);
            this.label_cr03.TabIndex = 0;
            this.label_cr03.Text = "Facility";
            this.label_cr03.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_cr04
            // 
            this.label_cr04.AutoSize = true;
            this.label_cr04.Location = new System.Drawing.Point(47, 158);
            this.label_cr04.Name = "label_cr04";
            this.label_cr04.Size = new System.Drawing.Size(73, 13);
            this.label_cr04.TabIndex = 1;
            this.label_cr04.Text = "Union Council";
            this.label_cr04.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_cr05
            // 
            this.label_cr05.AutoSize = true;
            this.label_cr05.Location = new System.Drawing.Point(47, 196);
            this.label_cr05.Name = "label_cr05";
            this.label_cr05.Size = new System.Drawing.Size(127, 13);
            this.label_cr05.TabIndex = 1;
            this.label_cr05.Text = "City / Village of residence";
            this.label_cr05.Click += new System.EventHandler(this.label4_Click);
            // 
            // combo_cr01
            // 
            this.combo_cr01.FormattingEnabled = true;
            this.combo_cr01.Location = new System.Drawing.Point(199, 44);
            this.combo_cr01.Name = "combo_cr01";
            this.combo_cr01.Size = new System.Drawing.Size(121, 21);
            this.combo_cr01.TabIndex = 2;
            this.combo_cr01.SelectedIndexChanged += new System.EventHandler(this.combo_cr01_SelectedIndexChanged);
            this.combo_cr01.DisplayMemberChanged += new System.EventHandler(this.combo_cr01_DisplayMemberChanged);
            this.combo_cr01.SelectedValueChanged += new System.EventHandler(this.combo_cr01_SelectedValueChanged);
            // 
            // combo_cr02
            // 
            this.combo_cr02.FormattingEnabled = true;
            this.combo_cr02.Location = new System.Drawing.Point(199, 82);
            this.combo_cr02.Name = "combo_cr02";
            this.combo_cr02.Size = new System.Drawing.Size(121, 21);
            this.combo_cr02.TabIndex = 2;
            // 
            // combo_cr03
            // 
            this.combo_cr03.FormattingEnabled = true;
            this.combo_cr03.Location = new System.Drawing.Point(199, 120);
            this.combo_cr03.Name = "combo_cr03";
            this.combo_cr03.Size = new System.Drawing.Size(121, 21);
            this.combo_cr03.TabIndex = 2;
            // 
            // combo_cr04
            // 
            this.combo_cr04.Enabled = false;
            this.combo_cr04.FormattingEnabled = true;
            this.combo_cr04.Location = new System.Drawing.Point(199, 158);
            this.combo_cr04.Name = "combo_cr04";
            this.combo_cr04.Size = new System.Drawing.Size(121, 21);
            this.combo_cr04.TabIndex = 2;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(199, 196);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 2;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 533);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.combo_cr04);
            this.Controls.Add(this.combo_cr03);
            this.Controls.Add(this.combo_cr02);
            this.Controls.Add(this.combo_cr01);
            this.Controls.Add(this.label_cr05);
            this.Controls.Add(this.label_cr04);
            this.Controls.Add(this.label_cr03);
            this.Controls.Add(this.label_cr02);
            this.Controls.Add(this.label_cr01);
            this.Name = "frm_main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_cr01;
        private System.Windows.Forms.Label label_cr02;
        private System.Windows.Forms.Label label_cr03;
        private System.Windows.Forms.Label label_cr04;
        private System.Windows.Forms.Label label_cr05;
        private System.Windows.Forms.ComboBox combo_cr01;
        private System.Windows.Forms.ComboBox combo_cr02;
        private System.Windows.Forms.ComboBox combo_cr03;
        private System.Windows.Forms.ComboBox combo_cr04;
        private System.Windows.Forms.ComboBox comboBox5;
    }
}

