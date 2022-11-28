using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            WelcomeForm wf = new WelcomeForm(username,password);

            if (username == "teboho" & password == "1818" & HumanCheckBox.Checked)
            {
                //this.Hide();
                wf.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }


        }

    }
}
