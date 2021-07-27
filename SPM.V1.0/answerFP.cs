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
    public partial class answerFP : Sample
    {
        FP fp = new FP();
        public static double value1;
        public static double value2;
       

        public answerFP()
        {
            InitializeComponent();

            
        }

        private void answerFP_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            answer.Text = (value2*value1).ToString();

        }

        private void answer_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
