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
    public partial class Slim : Sample
    {
        public Slim()
        {
            InitializeComponent();
        }

        private void Slim_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if(loc.Text=="0" && timeinput.Text == "0")
            {
                error er = new error();
                er.Show();

            }
            else
            {

            answer.Text = String.Format("{0:0.00}", (Convert.ToSingle(loc.Text) / (610 * Math.Pow(Convert.ToSingle(timeinput.Text), 1.33))*3)).ToString();
            }
        }

        private void guna2GradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            answer.Text = 0.ToString();
            loc.Text = 0.ToString();
            timeinput.Text = 0.ToString();
        }
    }
}
