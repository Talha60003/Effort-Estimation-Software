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
    public partial class Cocomo : Sample
    {
        public Cocomo()
        {
            InitializeComponent();
        }

        private void Cocomo_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {
                    }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
            organicpm.Text =(String.Format("{0:0.00}", (2.4 * Math.Pow(Convert.ToSingle(kloc.Text), 1.05))).ToString());
            organicdt.Text= String.Format("{0:0.00}", (2.5 * Math.Pow(Convert.ToSingle(String.Format("{0:0.00}", organicpm.Text)), .38))).ToString();

            semipm.Text= String.Format("{0:0.00}", (3.0 * Math.Pow(Convert.ToSingle(kloc.Text), 1.12))).ToString();
            semidt.Text= String.Format("{0:0.00}", (2.5 * Math.Pow(Convert.ToSingle(semipm.Text), .35))).ToString();

            embedpm.Text= String.Format("{0:0.00}", (3.6 * Math.Pow(Convert.ToSingle(kloc.Text), 1.20))).ToString();
            embedtime.Text= String.Format("{0:0.00}", (2.5 * Math.Pow(Convert.ToSingle(embedpm.Text), .32))).ToString();


        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            kloc.Text = 0.ToString();
            organicdt.Text= 0.ToString();
            organicpm.Text= 0.ToString();
            semidt.Text= 0.ToString();
            semipm.Text= 0.ToString();
            embedpm.Text= 0.ToString();
            embedtime.Text= 0.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
