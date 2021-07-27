using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPM.V1._0
{
    public partial class secondwindow : Form
    {
       
        
        public secondwindow()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Selection select = new Selection();
            this.Hide();
            select.Show();
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            ApplicationCompostion ac = new ApplicationCompostion();
            this.Hide();
            ac.Show();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
