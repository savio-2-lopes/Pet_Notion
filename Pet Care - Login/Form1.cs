using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pet_Care___Login
{
    public partial class Login : Form
    {
        public Login(){InitializeComponent();}

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string[] BuscaLogin = File.ReadAllLines(@"C:\Users\Public\DataBase\Users\" + txtUsername.Text + ".txt");
                int linha = 1;
                string password, password2;
                password = BuscaLogin[linha - 1];
                password2 = txtPassword.Text;

                if (password == password2)
                {
                    Dashboard Dashboard = new Dashboard();
                    this.Hide();
                    Dashboard.ShowDialog();
                }
                else
                {
                    LoginError();
                }
            }
            catch
            {
                LoginError();
            }
        }

        public void LoginError()
        {
            MessageBox.Show("Login e senha não coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            DirectoryInfo dirUser = new DirectoryInfo(@"C:\Users\Public\DataBase\Users");
            if (dirUser.Exists) { return; }
            else { dirUser.Create(); }
        }

        private void guna2Button1_Click(object sender, EventArgs e){}

        private void btnRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }
    }
}