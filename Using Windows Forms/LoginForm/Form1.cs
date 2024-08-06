using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        frmDashboard frm = new frmDashboard();



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        private void btnMinimized_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            if (userName == "admin" && password == "1234") 
            {
                this.Hide();
                frm.Show();

            }
            else 
            {
                MessageBox.Show("Fail");
            }

        }
    }
}
