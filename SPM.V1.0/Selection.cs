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
    public partial class Selection : Form
    {
        Cocomo cocomo = new Cocomo();
        Slim slim = new Slim();
        FP FPA = new FP();
        secondwindow second = new secondwindow();
        
        public Selection()
        {
            InitializeComponent();
        }
        private void Selection_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
        private void Cocomo_Click(object sender, EventArgs e)
        {
            this.Hide();
            cocomo.Show();

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            slim.Show();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FPA.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            second.Show();
        }
    }
}
