namespace WinForm_Model
{
    partial class frmLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_login = new System.Windows.Forms.Button();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_user_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_login);
            this.groupBox1.Controls.Add(this.text_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.text_user_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(264, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            this.groupBox1.UseWaitCursor = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.button_login.Location = new System.Drawing.Point(66, 169);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(133, 27);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.UseWaitCursor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // text_password
            // 
            this.text_password.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.text_password.Location = new System.Drawing.Point(31, 111);
            this.text_password.Name = "text_password";
            this.text_password.Size = new System.Drawing.Size(203, 22);
            this.text_password.TabIndex = 2;
            this.text_password.UseSystemPasswordChar = true;
            this.text_password.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            this.label2.UseWaitCursor = true;
            // 
            // text_user_name
            // 
            this.text_user_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.text_user_name.Location = new System.Drawing.Point(31, 59);
            this.text_user_name.Name = "text_user_name";
            this.text_user_name.Size = new System.Drawing.Size(203, 22);
            this.text_user_name.TabIndex = 1;
            this.text_user_name.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            this.label1.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 73);
            this.label3.TabIndex = 4;
            this.label3.Text = "CENTRAL ASIA STUNTING INITIATIVE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_user_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}