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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if(UsertextBox1.Text.Length < 3 || PasswordtextBox2.Text.Length < 5)
            {
                MessageBox.Show("Username & Password are too short or INVALID");
            }

            else
            {
                string dir = UsertextBox1.Text;
                Directory.CreateDirectory("data\\" + dir);

                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                string encusr = Encrypt.Encryp(UsertextBox1.Text);
                string encpass = Encrypt.Encryp(PasswordtextBox2.Text);

                sw.WriteLine(encusr);
                sw.WriteLine(encpass);
                sw.Close();

                MessageBox.Show("User {0} was successfully created.", UsertextBox1.Text);
                this.Close();



            }



        }
    }
}
