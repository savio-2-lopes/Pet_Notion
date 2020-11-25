using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Care___Login.AllUserControls
{
    public partial class UC_AddPets : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddPets()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e){}

        private void label7_Click(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}

        private void UC_AddPets_Load(object sender, EventArgs e){}

        private void label4_Click(object sender, EventArgs e){}

        private void label3_Click(object sender, EventArgs e){}

        private void label8_Click(object sender, EventArgs e){}

        private void label6_Click(object sender, EventArgs e){}

        private void label5_Click(object sender, EventArgs e){}

        private void btnAddPets_Click(object sender, EventArgs e){}

        public void clearAll()
        {
            txtSexo.SelectedIndex       = -1; 
            txtRaca.SelectedIndex       = -1;
            txtVacina.SelectedIndex     = -1;
            txtData.Clear();
            txtNome.Clear();
            txtPeso.Clear();
            txtQuantidade.Clear();
        }

        private void UC_AddPets_Leave(object sender, EventArgs e)
        {
            clearAll();    

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton9_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO pet (nome,sexo,raca,vermifugacao,vacinas,peso,quantidade_refeicoes_dia) VALUES " + "('" + txtNome.Text + "', '" + txtSexo.Text + "', '" + txtRaca.Text + "', '" + txtData.Text + "', '" + txtVacina.Text + "', '" + txtPeso.Text + "', '" + txtQuantidade.Text + "')";
            fn.setData(query);
            clearAll();
        }

        private void txtVacina_SelectedIndexChanged(object sender, EventArgs e){}
    }
}
