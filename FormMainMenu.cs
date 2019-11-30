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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Open registration form, closing current window
            this.Hide();
            new FormRegister().Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Open login form, closing current window
            this.Hide();
            new fmLogin().Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Exits the entire application
            Application.Exit();
        }
    }
}
