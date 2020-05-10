using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (tuser.Text == "")
            {
                MessageBox.Show("Please enter User ID");
                tuser.Focus();
            }
            else if (tpass.Text == "")
            {
                MessageBox.Show("Please enter Password");
                tpass.Focus();
            }
            else if (tuser.Text == "admin" && tpass.Text == "admin")
            {

                MessageBox.Show("Login Successful");
                DMenu dm = new DMenu();
                dm.Show();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }

        }

        private void tuser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tpass.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tuser.Focus();
            }
        }

        private void tpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                login.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tpass.Focus();
            }
        }

        private void login_Click_1(object sender, EventArgs e)
        {
            if (tuser.Text == "")
            {
                MessageBox.Show("Please enter User ID");
                tuser.Focus();
            }
            else if (tpass.Text == "")
            {
                MessageBox.Show("Please enter Password");
                tpass.Focus();
            }
            else if (tuser.Text == "admin" && tpass.Text == "admin")
            {

                MessageBox.Show("Login Successful");
                DMenu dm = new DMenu();
                dm.Show();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tuser_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tpass.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tuser.Focus();
            }
        }

        private void tpass_DoubleClick(object sender, EventArgs e)
        {

        }

        private void tpass_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                tpass.Focus();
            }
            else if (e.KeyData == Keys.Escape)
            {
                tuser.Focus();
            }
        }
    }
}
