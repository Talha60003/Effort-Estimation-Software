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
    public partial class FP : Sample
    {
        
        
        public FP()
        {
            
            InitializeComponent();
        }
       

        private void FPA_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            simpleil.Text = 0.ToString();
            avgil.Text= 0.ToString();
            cil.Text= 0.ToString();
            simpleei.Text= 0.ToString(); 
            avgif.Text= 0.ToString();
            cif.Text= 0.ToString();
            simplee.Text= 0.ToString();
            avgei.Text= 0.ToString();
            cei.Text= 0.ToString();
            simpleo.Text= 0.ToString();
            avgo.Text= 0.ToString();
            co.Text= 0.ToString();
            simplei.Text= 0.ToString();
            avgi.Text= 0.ToString();
            ci.Text= 0.ToString();
            answer.Text= 0.ToString();

        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

            answerforufp();


        }

        private void guna2HtmlLabel14_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel17_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel20_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public string answerforufp()
        {
            answer.Text = (((7 * Convert.ToSingle(simpleil.Text)) + (10 * Convert.ToSingle(avgil.Text)) + (15 * Convert.ToSingle(cil.Text))) +
                   ((5 * Convert.ToSingle(simpleei.Text)) + (7 * Convert.ToSingle(avgif.Text)) + (10 * Convert.ToSingle(cif.Text))) +
                   ((3 * Convert.ToSingle(simplee.Text)) + (4 * Convert.ToSingle(avgei.Text)) + (6 * Convert.ToSingle(cei.Text))) +
                   ((4 * Convert.ToSingle(simpleo.Text)) + (5 * Convert.ToSingle(avgo.Text)) + (7 * Convert.ToSingle(co.Text))) +
                   ((3 * Convert.ToSingle(simplei.Text)) + (4 * Convert.ToSingle(avgi.Text)) + (6 * Convert.ToSingle(ci.Text)))).ToString();
            double value;
            value = Convert.ToSingle(answer.Text);
            answerFP.value2 = value;
            return value.ToString();

        }
        public string answerforcaf()
        {
            float subfi;
            subfi = ((0 * Convert.ToSingle(no.Text)) + (1 * Convert.ToSingle(i.Text)) + (2 * (Convert.ToSingle(m.Text))) +
                (3 * (Convert.ToSingle(a.Text))) + (4 * (Convert.ToSingle(s.Text))) + (5 * Convert.ToSingle(es.Text)));

            double value = (0.65 + (0.01 * subfi));
            caf.Text = value.ToString();
            answerFP.value1 = value;
            return value.ToString();
        }
        
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            answerforcaf();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            no.Text = 0.ToString();
            i.Text = 0.ToString();
            m.Text= 0.ToString();
            a.Text= 0.ToString();
            s.Text= 0.ToString();
            es.Text= 0.ToString();
            caf.Text = 0.ToString();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            answerFP answerFP = new answerFP();
            answerFP.Show();
        }

        private void guna2GradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
