using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Login : Form
    {
        Functions Con;
        public Login()
        {
            InitializeComponent();
            Con = new Functions();
        }

        private void ResetLbl_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void checkLogin()
        {
            if (UNameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            }
            else if (UNameTb.Text == "Admin" && PasswordTb.Text == "Password")
            {
                Departments db = new Departments();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password!!");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            checkLogin();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Con.Exit();
        }

        private void PasswordTb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                checkLogin();
            }
        }

        private void UNameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                checkLogin();
            }
        }
    }
}
