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
    public partial class UC_UpdatePets : UserControl
    {
        function fn = new function();
        String query;
        public UC_UpdatePets()
        {
            InitializeComponent();
        }

        private void UC_UpdatePets_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData()
        {
            query = "SELECT * FROM pet";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchPet_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM pet WHERE nome LIKE '" + txtSearchPet.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        int id;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id                              = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String nome                     = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            String sexo                     = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String raca                     = guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            String vermifugacao             = guna2DataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            String vacinas                  = guna2DataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            String peso                     = guna2DataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            String quantidade_refeicoes_dia = guna2DataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            txtNome.Text            = nome;
            txtSexo.Text            = sexo;
            txtPeso.Text            = peso;
            txtRaca.Text            = raca;
            txtVermifugacao.Text    = vermifugacao;
            txtVacina.Text          = vacinas;
            txtPeso.Text            = peso;
            txtRefeicoes.Text       = quantidade_refeicoes_dia;
        }

        private void btnUpdate_Click(object sender, EventArgs e){}

        private void btnEditar_Click(object sender, EventArgs e)
        {
            query = "UPDATE pet SET nome= '" + txtNome.Text + "', sexo= '" + txtSexo.Text + "', raca= '" + txtRaca.Text + "', vermifugacao= '" + txtVermifugacao.Text + "', vacinas= '" + txtVacina.Text + "', peso= '" + txtPeso.Text + "', quantidade_refeicoes_dia= '" + txtRefeicoes.Text + "' where id = " + id + "";

            fn.setData(query);
            loadData();

            txtNome.Clear();
            txtSexo.Clear();
            txtPeso.Clear();
            txtRaca.Clear();
            txtVermifugacao.Clear();
            txtVacina.Clear();
            txtPeso.Clear();
            txtRefeicoes.Clear();
        }
    }
}