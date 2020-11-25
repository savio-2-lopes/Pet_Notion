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
    public partial class UC_News : UserControl
    {
        public UC_News()
        {
            InitializeComponent();
            
            
            
        }

        private void BtnSalvarData_Click(object sender, EventArgs e)
        {
            ControleCalendario cc = new ControleCalendario();
            cc.Data = monthCalendar1.SelectionStart.ToShortDateString();
            cc.Status = TextStatus.Text;
            cc.Observacao = TextArea.Text;

            cc.salvarDados();

            TextStatus.Text = "";
            TextArea.Text = "";
            


        }
    }
}
