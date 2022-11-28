using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3App
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm(string username, string passwordD)
        {
            InitializeComponent();

            usernamePassTextBox.Text = username + " " + passwordD; //pass to the screen welcome form
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void totalAmount_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                loanAmount.Text = (float.Parse(principleAmount.Text) * float.Parse(duration.Text).ToString)
            }
            catch 
            { 
            }
        }
    }
}
