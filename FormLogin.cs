using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity3
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text != "Student") || (txtPassword.Text != "mypassword!"))
            {
                // Output error if the username or password does not match expected input
                MessageBox.Show("Incorrect Login Credentials!");
            }
            else
            {
                MessageBox.Show("Welcome!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Return to menu
            this.Hide();
            new FormMainMenu().Show();
        }
    }
}
