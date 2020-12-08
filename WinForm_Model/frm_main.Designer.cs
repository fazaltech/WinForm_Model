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
            this.combo_cr04 = new System.Windows.Forms.ComboBox();
            this.combo_cr05 = new System.Windows.Forms.ComboBox();
            this.text_cr07 = new System.Windows.Forms.TextBox();
            this.label_cr07 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_cr09 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_cr02c = new System.Windows.Forms.RadioButton();
            this.radio_cr02b = new System.Windows.Forms.RadioButton();
            this.radio_cr02a = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_cr08 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_cr01
            // 
            this.label_cr01.AutoSize = true;
            this.label_cr01.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr01.Location = new System.Drawing.Point(26, 46);
            this.label_cr01.Name = "label_cr01";
            this.label_cr01.Size = new System.Drawing.Size(52, 18);
            this.label_cr01.TabIndex = 0;
            this.label_cr01.Text = "District";
            this.label_cr01.Click += new System.EventHandler(this.label_cr01_Click);
            // 
            // label_cr02
            // 
            this.label_cr02.AutoSize = true;
            this.label_cr02.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr02.Location = new System.Drawing.Point(26, 82);
            this.label_cr02.Name = "label_cr02";
            this.label_cr02.Size = new System.Drawing.Size(121, 18);
            this.label_cr02.TabIndex = 1;
            this.label_cr02.Text = "Place of Screening";
            this.label_cr02.Click += new System.EventHandler(this.label_cr02_Click);
            // 
            // label_cr03
            // 
            this.label_cr03.AutoSize = true;
            this.label_cr03.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr03.Location = new System.Drawing.Point(26, 189);
            this.label_cr03.Name = "label_cr03";
            this.label_cr03.Size = new System.Drawing.Size(52, 18);
            this.label_cr03.TabIndex = 0;
            this.label_cr03.Text = "Facility";
            this.label_cr03.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_cr04
            // 
            this.label_cr04.AutoSize = true;
            this.label_cr04.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr04.Location = new System.Drawing.Point(26, 225);
            this.label_cr04.Name = "label_cr04";
            this.label_cr04.Size = new System.Drawing.Size(95, 18);
            this.label_cr04.TabIndex = 1;
            this.label_cr04.Text = "Union Council";
            this.label_cr04.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_cr05
            // 
            this.label_cr05.AutoSize = true;
            this.label_cr05.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr05.Location = new System.Drawing.Point(26, 261);
            this.label_cr05.Name = "label_cr05";
            this.label_cr05.Size = new System.Drawing.Size(167, 18);
            this.label_cr05.TabIndex = 1;
            this.label_cr05.Text = "City / Village of residence";
            this.label_cr05.Click += new System.EventHandler(this.label4_Click);
            // 
            // combo_cr01
            // 
            this.combo_cr01.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.combo_cr01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cr01.FormattingEnabled = true;
            this.combo_cr01.Location = new System.Drawing.Point(221, 38);
            this.combo_cr01.Name = "combo_cr01";
            this.combo_cr01.Size = new System.Drawing.Size(151, 26);
            this.combo_cr01.TabIndex = 1;
            this.combo_cr01.SelectedIndexChanged += new System.EventHandler(this.combo_cr01_SelectedIndexChanged);
            this.combo_cr01.DisplayMemberChanged += new System.EventHandler(this.combo_cr01_DisplayMemberChanged);
            this.combo_cr01.SelectedValueChanged += new System.EventHandler(this.combo_cr01_SelectedValueChanged);
            this.combo_cr01.Enter += new System.EventHandler(this.combo_cr01_Enter);
            this.combo_cr01.Leave += new System.EventHandler(this.combo_cr01_Leave);
            // 
            // combo_cr04
            // 
            this.combo_cr04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cr04.FormattingEnabled = true;
            this.combo_cr04.Location = new System.Drawing.Point(221, 223);
            this.combo_cr04.Name = "combo_cr04";
            this.combo_cr04.Size = new System.Drawing.Size(151, 26);
            this.combo_cr04.TabIndex = 6;
            this.combo_cr04.SelectedIndexChanged += new System.EventHandler(this.combo_cr04_SelectedIndexChanged);
            this.combo_cr04.Leave += new System.EventHandler(this.combo_cr04_Leave);
            // 
            // combo_cr05
            // 
            this.combo_cr05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cr05.FormattingEnabled = true;
            this.combo_cr05.Location = new System.Drawing.Point(221, 261);
            this.combo_cr05.Name = "combo_cr05";
            this.combo_cr05.Size = new System.Drawing.Size(151, 26);
            this.combo_cr05.TabIndex = 7;
            this.combo_cr05.SelectedIndexChanged += new System.EventHandler(this.combo_cr05_SelectedIndexChanged);
            // 
            // text_cr07
            // 
            this.text_cr07.Location = new System.Drawing.Point(221, 299);
            this.text_cr07.Name = "text_cr07";
            this.text_cr07.Size = new System.Drawing.Size(151, 26);
            this.text_cr07.TabIndex = 8;
            this.text_cr07.TextChanged += new System.EventHandler(this.text_cr07_TextChanged);
            // 
            // label_cr07
            // 
            this.label_cr07.AutoSize = true;
            this.label_cr07.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr07.Location = new System.Drawing.Point(26, 297);
            this.label_cr07.Name = "label_cr07";
            this.label_cr07.Size = new System.Drawing.Size(112, 18);
            this.label_cr07.TabIndex = 1;
            this.label_cr07.Text = "Assessor’s Name";
            this.label_cr07.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(26, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khandan Number";
            this.label1.Click += new System.EventHandler(this.label4_Click);
            // 
            // text_cr09
            // 
            this.text_cr09.Location = new System.Drawing.Point(221, 375);
            this.text_cr09.Name = "text_cr09";
            this.text_cr09.Size = new System.Drawing.Size(151, 26);
            this.text_cr09.TabIndex = 10;
            this.text_cr09.TextChanged += new System.EventHandler(this.text_cr09_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_cr02c);
            this.groupBox1.Controls.Add(this.radio_cr02b);
            this.groupBox1.Controls.Add(this.radio_cr02a);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label_cr08);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.combo_cr01);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.text_cr09);
            this.groupBox1.Controls.Add(this.label_cr07);
            this.groupBox1.Controls.Add(this.label_cr05);
            this.groupBox1.Controls.Add(this.text_cr07);
            this.groupBox1.Controls.Add(this.label_cr04);
            this.groupBox1.Controls.Add(this.label_cr03);
            this.groupBox1.Controls.Add(this.combo_cr05);
            this.groupBox1.Controls.Add(this.label_cr02);
            this.groupBox1.Controls.Add(this.combo_cr04);
            this.groupBox1.Controls.Add(this.label_cr01);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.Location = new System.Drawing.Point(21, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 441);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Growth Monitoring - Screening Log for Children Under 5";
            // 
            // radio_cr02c
            // 
            this.radio_cr02c.AutoSize = true;
            this.radio_cr02c.Location = new System.Drawing.Point(221, 146);
            this.radio_cr02c.Name = "radio_cr02c";
            this.radio_cr02c.Size = new System.Drawing.Size(107, 22);
            this.radio_cr02c.TabIndex = 4;
            this.radio_cr02c.TabStop = true;
            this.radio_cr02c.Text = "radioButton1";
            this.radio_cr02c.UseVisualStyleBackColor = true;
            // 
            // radio_cr02b
            // 
            this.radio_cr02b.AutoSize = true;
            this.radio_cr02b.Location = new System.Drawing.Point(221, 114);
            this.radio_cr02b.Name = "radio_cr02b";
            this.radio_cr02b.Size = new System.Drawing.Size(107, 22);
            this.radio_cr02b.TabIndex = 3;
            this.radio_cr02b.TabStop = true;
            this.radio_cr02b.Text = "radioButton1";
            this.radio_cr02b.UseVisualStyleBackColor = true;
            // 
            // radio_cr02a
            // 
            this.radio_cr02a.AutoSize = true;
            this.radio_cr02a.Location = new System.Drawing.Point(221, 82);
            this.radio_cr02a.Name = "radio_cr02a";
            this.radio_cr02a.Size = new System.Drawing.Size(107, 22);
            this.radio_cr02a.TabIndex = 2;
            this.radio_cr02a.TabStop = true;
            this.radio_cr02a.Text = "radioButton1";
            this.radio_cr02a.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(221, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label_cr08
            // 
            this.label_cr08.AutoSize = true;
            this.label_cr08.Location = new System.Drawing.Point(26, 333);
            this.label_cr08.Name = "label_cr08";
            this.label_cr08.Size = new System.Drawing.Size(117, 18);
            this.label_cr08.TabIndex = 5;
            this.label_cr08.Text = "Date of Screening";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(221, 337);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Central Asia Stunting Initiative ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(242, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start Activity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox combo_cr04;
        private System.Windows.Forms.ComboBox combo_cr05;
        private System.Windows.Forms.TextBox text_cr07;
        private System.Windows.Forms.Label label_cr07;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_cr09;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_cr08;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radio_cr02c;
        private System.Windows.Forms.RadioButton radio_cr02b;
        private System.Windows.Forms.RadioButton radio_cr02a;
    }
}

