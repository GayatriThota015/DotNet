using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Encryptdec;
using System.IO;

namespace ExtraCreditAss
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();
            rf.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (UsertextBox1.Text.Length < 3 || PasswordtextBox2.Text.Length < 5)
            {
                MessageBox.Show("Username & Password are too short or INVALID");
            }

            else
            {
                string dir = UsertextBox1.Text;
                if (!Directory.Exists("data\\" + dir))
                    MessageBox.Show("User {0} was not found!", dir);
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string encusr = sr.ReadLine();
                    string encpass = sr.ReadLine();
                    sr.Close();

                    string decusr = Encrypt.Dencrypt(encusr);
                    string decpass = Encrypt.Dencrypt(encpass);

                    if(decusr == UsertextBox1.Text && decpass == PasswordtextBox2.Text)
                    {
                        MessageBox.Show("Welcome {0} to the private area!", decusr);
                    }
                    else
                    {
                        MessageBox.Show("Error user or password is wrong!");
                    }
              


                }

            }
        }
    }
}
