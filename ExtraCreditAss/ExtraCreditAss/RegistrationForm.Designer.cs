namespace ExtraCreditAss
{
    partial class RegistrationForm
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
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.UsertextBox1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.usrname = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.Location = new System.Drawing.Point(141, 113);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.Size = new System.Drawing.Size(284, 26);
            this.PasswordtextBox2.TabIndex = 11;
            // 
            // UsertextBox1
            // 
            this.UsertextBox1.Location = new System.Drawing.Point(141, 44);
            this.UsertextBox1.Name = "UsertextBox1";
            this.UsertextBox1.Size = new System.Drawing.Size(284, 26);
            this.UsertextBox1.TabIndex = 10;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(29, 119);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 20);
            this.password.TabIndex = 9;
            this.password.Text = "Password:";
            // 
            // usrname
            // 
            this.usrname.AutoSize = true;
            this.usrname.Location = new System.Drawing.Point(29, 47);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(87, 20);
            this.usrname.TabIndex = 8;
            this.usrname.Text = "Username:";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(298, 199);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(127, 48);
            this.Register.TabIndex = 7;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 289);
            this.Controls.Add(this.PasswordtextBox2);
            this.Controls.Add(this.UsertextBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.Register);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordtextBox2;
        private System.Windows.Forms.TextBox UsertextBox1;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label usrname;
        private System.Windows.Forms.Button Register;
    }
}