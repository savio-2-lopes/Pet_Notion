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
    public partial class UC_RemovePets : UserControl
    {
        function fn = new function();
        String query;
        public UC_RemovePets()
        {
            InitializeComponent();
        }

        private void UC_RemovePets_Load(object sender, EventArgs e)
        {
            delLabel.Text = "Como EXCLUIR?";
            delLabel.ForeColor = Color.Blue;
            loadData();
        }

        public void loadData()
        {
            query = "SELECT * FROM pet";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM pet WHERE nome LIKE '" + txtSearch.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Remover Pet?", "Mensagem Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "DELETE FROM pet WHERE id = " + id + "";
                fn.setData(query);
                loadData();
            }
        }

        private void delLabel_Click(object sender, EventArgs e)
        {
            delLabel.ForeColor = Color.Red;
            delLabel.Text = "*Clique na linha para excluir o Pet.";
        }

        private void UC_RemovePets_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void UC_RemovePets_Enter(object sender, EventArgs e){}
    }
}