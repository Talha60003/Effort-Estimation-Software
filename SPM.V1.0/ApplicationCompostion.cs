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
    public partial class ApplicationCompostion : Form
    {
        public ApplicationCompostion()
        {
            InitializeComponent();
        }

        private void screensanswer_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (views.Text == "0" && sources.Text == "0" && server.Text == "0" && client.Text == "0")
            {

                error er = new error();
                er.Show();
                screensanswer.Text = "***";
            }
            else
            {
                if ((Convert.ToSingle(views.Text) < 3 && (Convert.ToSingle(sources.Text)) < 4 && Convert.ToSingle(server.Text) < 2 && Convert.ToSingle(client.Text) < 3) ||
                    (Convert.ToSingle(views.Text) < 3 && (Convert.ToSingle(sources.Text)) < 8 && (Convert.ToSingle(server.Text) == 2 || Convert.ToSingle(server.Text) == 3) && (Convert.ToSingle(client.Text) >= 3 || Convert.ToSingle(client.Text) <= 5)))
                {
                    screensanswer.Text = "Simple";
                }
                else if ((Convert.ToSingle(views.Text) < 3 && (Convert.ToSingle(sources.Text)) > 8 && Convert.ToSingle(server.Text) > 3 && Convert.ToSingle(client.Text) > 5))
                {
                    screensanswer.Text = "Medium";
                }
                else if ((((Convert.ToSingle(views.Text) >= 3 && (Convert.ToSingle(views.Text) <= 7)) && (Convert.ToSingle(sources.Text)) > 8 && Convert.ToSingle(server.Text) > 3 && Convert.ToSingle(client.Text) > 5)))
                {
                    screensanswer.Text = "Difficult";
                }
                else if ((Convert.ToSingle(views.Text) >= 3 && (Convert.ToSingle(views.Text) <= 7)) && (Convert.ToSingle(sources.Text)) < 4 && Convert.ToSingle(server.Text) < 2 && Convert.ToSingle(client.Text) < 3)
                {

                    screensanswer.Text = "Simple";
                }
                else if ((Convert.ToSingle(views.Text) >= 3 && (Convert.ToSingle(views.Text) <= 7) && (Convert.ToSingle(sources.Text)) < 8 && (Convert.ToSingle(server.Text) == 2 || Convert.ToSingle(server.Text) == 3) && (Convert.ToSingle(client.Text) >= 3 || Convert.ToSingle(client.Text) <= 5)))
                {
                    screensanswer.Text = "Medium";
                }
                else if ((Convert.ToSingle(views.Text) > 8 && (Convert.ToSingle(sources.Text)) < 4 && Convert.ToSingle(server.Text) < 2 && Convert.ToSingle(client.Text) < 3))
                {
                    screensanswer.Text = "Medium";
                }
                else if ((Convert.ToSingle(views.Text) > 8 && (Convert.ToSingle(sources.Text)) < 8 && (Convert.ToSingle(server.Text) == 2 || Convert.ToSingle(server.Text) == 3) && (Convert.ToSingle(client.Text) >= 3 || Convert.ToSingle(client.Text) <= 5)))
                {

                    screensanswer.Text = "Difficult";
                }
                else if ((Convert.ToSingle(views.Text) > 8 && (Convert.ToSingle(sources.Text)) > 8 && Convert.ToSingle(server.Text) > 3 && Convert.ToSingle(client.Text) > 5))
                {
                    screensanswer.Text = "Difficult";
                }
                else
                {
                    screensanswer.Text = "***";
                }
            }

        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (reports.Text == "0" && sourcesr.Text == "0" && serverr.Text == "0" && clientr.Text == "0")
            {

                error er = new error();
                er.Show();
                screensanswer.Text = "***";
            }
            else
            {
                if (((Convert.ToSingle(reports.Text) == 0 || Convert.ToSingle(reports.Text) == 1) && (Convert.ToSingle(sourcesr.Text)) < 4 && Convert.ToSingle(serverr.Text) < 2 && Convert.ToSingle(clientr.Text) < 3) ||
                    (Convert.ToSingle(reports.Text) < 3 && (Convert.ToSingle(sourcesr.Text)) < 8 && (Convert.ToSingle(serverr.Text) == 2 || Convert.ToSingle(serverr.Text) == 3) && (Convert.ToSingle(clientr.Text) >= 3 || Convert.ToSingle(clientr.Text) <= 5)))
                {
                    answerreports.Text = "Simple";
                }
                else if (((Convert.ToSingle(reports.Text) == 0 || Convert.ToSingle(reports.Text) == 1) && (Convert.ToSingle(sourcesr.Text)) > 8 && Convert.ToSingle(serverr.Text) > 3 && Convert.ToSingle(clientr.Text) > 5))
                {
                    answerreports.Text = "Medium";
                }
                else if ((((Convert.ToSingle(reports.Text) == 2 || Convert.ToSingle(reports.Text) == 3) && (Convert.ToSingle(sourcesr.Text)) > 8 && Convert.ToSingle(serverr.Text) > 3 && Convert.ToSingle(clientr.Text) > 5)))
                {
                    answerreports.Text = "Difficult";
                }
                else if ((Convert.ToSingle(reports.Text) == 2 || Convert.ToSingle(reports.Text) == 3) && (Convert.ToSingle(sourcesr.Text)) < 4 && Convert.ToSingle(serverr.Text) < 2 && Convert.ToSingle(clientr.Text) < 3)
                {

                    answerreports.Text = "Simple";
                }
                else if (((Convert.ToSingle(reports.Text) == 2 || Convert.ToSingle(reports.Text) == 3) && (Convert.ToSingle(sourcesr.Text)) < 8 && (Convert.ToSingle(serverr.Text) == 2 || Convert.ToSingle(serverr.Text) == 3) && (Convert.ToSingle(clientr.Text) >= 3 || Convert.ToSingle(clientr.Text) <= 5)))
                {
                    answerreports.Text = "Medium";
                }
                else if ((Convert.ToSingle(reports.Text) > 4 && (Convert.ToSingle(sourcesr.Text)) < 4 && Convert.ToSingle(serverr.Text) < 2 && Convert.ToSingle(clientr.Text) < 3))
                {
                    answerreports.Text = "Medium";
                }
                else if ((Convert.ToSingle(reports.Text) > 4 && (Convert.ToSingle(sourcesr.Text)) < 8 && (Convert.ToSingle(serverr.Text) == 2 || Convert.ToSingle(serverr.Text) == 3) && (Convert.ToSingle(clientr.Text) >= 3 || Convert.ToSingle(clientr.Text) <= 5)))
                {

                    answerreports.Text = "Difficult";
                }
                else if ((Convert.ToSingle(reports.Text) > 4 && (Convert.ToSingle(sourcesr.Text)) > 8 && Convert.ToSingle(serverr.Text) > 3 && Convert.ToSingle(clientr.Text) > 5))
                {
                    answerreports.Text = "Difficult";
                }
                else
                {

                    answerreports.Text = "***";
                }
            }
        }
        float answer;
        public void complexityscreen()
        {
            
            if (screensanswer.Text == "Simple")
            {
                answer+=1;

            } else if (screensanswer.Text == "Medium")
            {
                answer +=2;
            }
        else if(screensanswer.Text == "Difficult")
            {
                answer+=3; }
            screencomplexity.Text = Convert.ToString(answer);
            sources.Text = 0.ToString();
            views.Text= 0.ToString(); 
            server.Text= 0.ToString();
            client.Text= 0.ToString();
            screensanswer.Text = "***";
            

        }
        float  reportanswer;
        String simple = "Simple";
        string medium = "Medium";
        string difficult = "Difficult";
        public void complexityreport()
        {

            if (answerreports.Text == simple)
            {
                reportanswer += 2;

            }
            else if (answerreports.Text == medium)
            {
                reportanswer += 5;
            }
            else if (answerreports.Text==difficult)
            {
                reportanswer += 8;
            }
            reportscomplexity.Text = Convert.ToString(reportanswer);
            sourcesr.Text = 0.ToString();
            reports.Text = 0.ToString();
            serverr.Text = 0.ToString();
            clientr.Text = 0.ToString();
            
            answerreports.Text = "***";
            

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            secondwindow sw = new secondwindow();
            this.Hide();
            sw.Show();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel16_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void screencomplexity_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            complexityscreen();
            complexityreport();
            
        }
        float objectpoints,noofobjectpoints,productivity;
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            if(pastpm.Text=="0" || resuablecomp.Text=="" || complexity3gl.Text=="***" || screencomplexity.Text=="***" || reportscomplexity.Text=="***")
            {
                error er = new error();
                er.Show();
            }
            else
            {

            objectpoints = Convert.ToSingle(complexity3gl.Text) + Convert.ToSingle(screencomplexity.Text) + Convert.ToSingle(reportscomplexity.Text);
            noofobjectpoints = objectpoints * (100 - Convert.ToSingle(resuablecomp.Text)) / 100;
            productivity = noofobjectpoints / Convert.ToSingle(pastpm.Text);
            finalanswer.Text = (noofobjectpoints / productivity).ToString()+"PM";
            }
        }
        float glcompanswer;
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked == true)
            {
                glcompanswer += (Convert.ToSingle(glcomp.Text) * 10);
                complexity3gl.Text = Convert.ToSingle(glcompanswer).ToString();
                glcomp.Text = 0.ToString();


            }
            
            
        }

        private void guna2HtmlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}