using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Care___Login
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();

            if(user == "Guest")
            {
                btnAddPets.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
            }
            else if(user == "User")
            {
                btnAddPets.Show();
                btnUpdate.Show();
                btnRemove.Show();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddPets1.Visible = false;
            uC_UpdatePets1.Visible = false;
            uC_RemovePets1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e){}

        private void uC_Welcome1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Welcome1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAddPets_Click(object sender, EventArgs e)
        {
            uC_AddPets1.Visible = true;
            uC_AddPets1.BringToFront(); 
        }

        private void uC_AddPets1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.Visible = true;
            uC_Welcome1.BringToFront();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uC_UpdatePets1.Visible = true;
            uC_UpdatePets1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uC_RemovePets1.Visible = true;
            uC_RemovePets1.BringToFront();
        }

        private void guna2ImageButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton5_Click(object sender, EventArgs e)
        {
            Login fm = new Login();
            this.Hide();
            fm.Show();
        }

        private void guna2ImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
