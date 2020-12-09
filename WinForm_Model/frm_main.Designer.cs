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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
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
            this.text_cr03 = new System.Windows.Forms.TextBox();
            this.label_cr08 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_cr02 = new System.Windows.Forms.GroupBox();
            this.errMessages = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grp_cr02.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_cr01
            // 
            this.label_cr01.AutoSize = true;
            this.label_cr01.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr01.Location = new System.Drawing.Point(26, 22);
            this.label_cr01.Name = "label_cr01";
            this.label_cr01.Size = new System.Drawing.Size(50, 17);
            this.label_cr01.TabIndex = 0;
            this.label_cr01.Text = "District";
            this.label_cr01.Click += new System.EventHandler(this.label_cr01_Click);
            // 
            // label_cr02
            // 
            this.label_cr02.AutoSize = true;
            this.label_cr02.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr02.Location = new System.Drawing.Point(26, 182);
            this.label_cr02.Name = "label_cr02";
            this.label_cr02.Size = new System.Drawing.Size(114, 17);
            this.label_cr02.TabIndex = 1;
            this.label_cr02.Text = "Place of Screening";
            this.label_cr02.Click += new System.EventHandler(this.label_cr02_Click);
            // 
            // label_cr03
            // 
            this.label_cr03.AutoSize = true;
            this.label_cr03.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr03.Location = new System.Drawing.Point(26, 338);
            this.label_cr03.Name = "label_cr03";
            this.label_cr03.Size = new System.Drawing.Size(48, 17);
            this.label_cr03.TabIndex = 0;
            this.label_cr03.Text = "Facility";
            this.label_cr03.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_cr04
            // 
            this.label_cr04.AutoSize = true;
            this.label_cr04.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr04.Location = new System.Drawing.Point(26, 75);
            this.label_cr04.Name = "label_cr04";
            this.label_cr04.Size = new System.Drawing.Size(90, 17);
            this.label_cr04.TabIndex = 1;
            this.label_cr04.Text = "Union Council";
            this.label_cr04.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_cr05
            // 
            this.label_cr05.AutoSize = true;
            this.label_cr05.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr05.Location = new System.Drawing.Point(26, 127);
            this.label_cr05.Name = "label_cr05";
            this.label_cr05.Size = new System.Drawing.Size(155, 17);
            this.label_cr05.TabIndex = 1;
            this.label_cr05.Text = "City / Village of residence";
            this.label_cr05.Click += new System.EventHandler(this.label4_Click);
            // 
            // combo_cr01
            // 
            this.combo_cr01.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.combo_cr01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cr01.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.combo_cr01.FormattingEnabled = true;
            this.combo_cr01.Location = new System.Drawing.Point(29, 43);
            this.combo_cr01.Name = "combo_cr01";
            this.combo_cr01.Size = new System.Drawing.Size(151, 25);
            this.combo_cr01.TabIndex = 1;
            this.combo_cr01.SelectedIndexChanged += new System.EventHandler(this.combo_cr01_SelectedIndexChanged);
            this.combo_cr01.DisplayMemberChanged += new System.EventHandler(this.combo_cr01_DisplayMemberChanged);
            this.combo_cr01.SelectedValueChanged += new System.EventHandler(this.combo_cr01_SelectedValueChanged);
           
            this.combo_cr01.Leave += new System.EventHandler(this.combo_cr01_Leave);
            // 
            // combo_cr04
            // 
            this.combo_cr04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cr04.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.combo_cr04.FormattingEnabled = true;
            this.combo_cr04.Location = new System.Drawing.Point(29, 93);
            this.combo_cr04.Name = "combo_cr04";
            this.combo_cr04.Size = new System.Drawing.Size(151, 25);
            this.combo_cr04.TabIndex = 6;
            this.combo_cr04.SelectedIndexChanged += new System.EventHandler(this.combo_cr04_SelectedIndexChanged);
           
            // 
            // combo_cr05
            // 
            this.combo_cr05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cr05.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.combo_cr05.FormattingEnabled = true;
            this.combo_cr05.Location = new System.Drawing.Point(29, 148);
            this.combo_cr05.Name = "combo_cr05";
            this.combo_cr05.Size = new System.Drawing.Size(151, 25);
            this.combo_cr05.TabIndex = 7;
            this.combo_cr05.SelectedIndexChanged += new System.EventHandler(this.combo_cr05_SelectedIndexChanged);
            // 
            // text_cr07
            // 
            this.text_cr07.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.text_cr07.Location = new System.Drawing.Point(29, 414);
            this.text_cr07.Name = "text_cr07";
            this.text_cr07.Size = new System.Drawing.Size(151, 25);
            this.text_cr07.TabIndex = 8;
            this.text_cr07.TextChanged += new System.EventHandler(this.text_cr07_TextChanged);
            // 
            // label_cr07
            // 
            this.label_cr07.AutoSize = true;
            this.label_cr07.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr07.Location = new System.Drawing.Point(26, 393);
            this.label_cr07.Name = "label_cr07";
            this.label_cr07.Size = new System.Drawing.Size(107, 17);
            this.label_cr07.TabIndex = 1;
            this.label_cr07.Text = "Assessor’s Name";
            this.label_cr07.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(26, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khandan Number";
            this.label1.Click += new System.EventHandler(this.label4_Click);
            // 
            // text_cr09
            // 
            this.text_cr09.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.text_cr09.Location = new System.Drawing.Point(29, 304);
            this.text_cr09.Name = "text_cr09";
            this.text_cr09.Size = new System.Drawing.Size(151, 25);
            this.text_cr09.TabIndex = 10;
            this.text_cr09.TextChanged += new System.EventHandler(this.text_cr09_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.text_cr03);
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
            this.groupBox1.Controls.Add(this.grp_cr02);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.Location = new System.Drawing.Point(21, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 454);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Section A";
          
            // 
            // radio_cr02c
            // 
            this.radio_cr02c.AutoSize = true;
            this.radio_cr02c.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radio_cr02c.Location = new System.Drawing.Point(6, 54);
            this.radio_cr02c.Name = "radio_cr02c";
            this.radio_cr02c.Size = new System.Drawing.Size(100, 21);
            this.radio_cr02c.TabIndex = 4;
            this.radio_cr02c.TabStop = true;
            this.radio_cr02c.Text = "radioButton1";
            this.radio_cr02c.UseVisualStyleBackColor = true;
            // 
            // radio_cr02b
            // 
            this.radio_cr02b.AutoSize = true;
            this.radio_cr02b.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radio_cr02b.Location = new System.Drawing.Point(6, 34);
            this.radio_cr02b.Name = "radio_cr02b";
            this.radio_cr02b.Size = new System.Drawing.Size(100, 21);
            this.radio_cr02b.TabIndex = 3;
            this.radio_cr02b.TabStop = true;
            this.radio_cr02b.Text = "radioButton1";
            this.radio_cr02b.UseVisualStyleBackColor = true;
            // 
            // radio_cr02a
            // 
            this.radio_cr02a.AutoSize = true;
            this.radio_cr02a.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.radio_cr02a.Location = new System.Drawing.Point(6, 12);
            this.radio_cr02a.Name = "radio_cr02a";
            this.radio_cr02a.Size = new System.Drawing.Size(100, 21);
            this.radio_cr02a.TabIndex = 2;
            this.radio_cr02a.TabStop = true;
            this.radio_cr02a.Text = "radioButton1";
            this.radio_cr02a.UseVisualStyleBackColor = true;
            // 
            // text_cr03
            // 
            this.text_cr03.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.text_cr03.Location = new System.Drawing.Point(29, 359);
            this.text_cr03.Name = "text_cr03";
            this.text_cr03.Size = new System.Drawing.Size(151, 25);
            this.text_cr03.TabIndex = 5;
            // 
            // label_cr08
            // 
            this.label_cr08.AutoSize = true;
            this.label_cr08.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label_cr08.Location = new System.Drawing.Point(235, 22);
            this.label_cr08.Name = "label_cr08";
            this.label_cr08.Size = new System.Drawing.Size(112, 17);
            this.label_cr08.TabIndex = 5;
            this.label_cr08.Text = "Date of Screening";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 43);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 12, 8, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 25);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(18, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Central Asia Stunting Initiative ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button1.Location = new System.Drawing.Point(242, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start Activity";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grp_cr02
            // 
            this.grp_cr02.Controls.Add(this.radio_cr02a);
            this.grp_cr02.Controls.Add(this.radio_cr02c);
            this.grp_cr02.Controls.Add(this.radio_cr02b);
            this.grp_cr02.Location = new System.Drawing.Point(29, 196);
            this.grp_cr02.Name = "grp_cr02";
            this.grp_cr02.Size = new System.Drawing.Size(151, 79);
            this.grp_cr02.TabIndex = 11;
            this.grp_cr02.TabStop = false;
            // 
            // errMessages
            // 
            this.errMessages.ForeColor = System.Drawing.Color.Red;
            this.errMessages.Location = new System.Drawing.Point(434, 76);
            this.errMessages.Name = "errMessages";
            this.errMessages.Size = new System.Drawing.Size(152, 432);
            this.errMessages.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(580, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(16, 16);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = true;
           
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(598, 574);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.errMessages);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grp_cr02.ResumeLayout(false);
            this.grp_cr02.PerformLayout();
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
        private System.Windows.Forms.TextBox text_cr03;
        private System.Windows.Forms.RadioButton radio_cr02c;
        private System.Windows.Forms.RadioButton radio_cr02b;
        private System.Windows.Forms.RadioButton radio_cr02a;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grp_cr02;
        private System.Windows.Forms.Label errMessages;
        private System.Windows.Forms.Button button2;
    }
}

