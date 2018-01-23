namespace ExtraCreditAss
{
    partial class Login
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
            this.loginbutton = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.usrname = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.UsertextBox1 = new System.Windows.Forms.TextBox();
            this.PasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(410, 287);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(127, 48);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Log in";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(176, 287);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(127, 48);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register New User";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // usrname
            // 
            this.usrname.AutoSize = true;
            this.usrname.Location = new System.Drawing.Point(106, 99);
            this.usrname.Name = "usrname";
            this.usrname.Size = new System.Drawing.Size(87, 20);
            this.usrname.TabIndex = 2;
            this.usrname.Text = "Username:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(106, 171);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 20);
            this.password.TabIndex = 3;
            this.password.Text = "Password:";
            // 
            // UsertextBox1
            // 
            this.UsertextBox1.Location = new System.Drawing.Point(218, 96);
            this.UsertextBox1.Name = "UsertextBox1";
            this.UsertextBox1.Size = new System.Drawing.Size(284, 26);
            this.UsertextBox1.TabIndex = 4;
            // 
            // PasswordtextBox2
            // 
            this.PasswordtextBox2.Location = new System.Drawing.Point(218, 165);
            this.PasswordtextBox2.Name = "PasswordtextBox2";
            this.PasswordtextBox2.Size = new System.Drawing.Size(284, 26);
            this.PasswordtextBox2.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 377);
            this.Controls.Add(this.PasswordtextBox2);
            this.Controls.Add(this.UsertextBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usrname);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.loginbutton);
            this.Name = "Login";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label usrname;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox UsertextBox1;
        private System.Windows.Forms.TextBox PasswordtextBox2;
    }
}

