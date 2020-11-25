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
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num == 0)
            {
                labelBanner.Location    = new Point(94, 367);
                labelBanner.ForeColor   = Color.Orange;
                num++;
            }
            else if(num == 1)
            {
                labelBanner.Location    = new Point(166, 367);
                labelBanner.ForeColor   = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.Location = new Point(268, 367);
                labelBanner.ForeColor = Color.RoyalBlue;
                num++;
            }
            else if (num == 3)
            {
                labelBanner.Location = new Point(340, 367);
                labelBanner.ForeColor = Color.Red;
                num = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e){}

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
