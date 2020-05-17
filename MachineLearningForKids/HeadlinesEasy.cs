using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class HeadlinesEasy : MetroFramework.Forms.MetroForm
    {
        List<string> maiList = new List<string>();
        List<string> teleList = new List<string>();
        List<string> indeList = new List<string>();
        List<string> guarList = new List<string>();

        public HeadlinesEasy()
        {
            InitializeComponent();
        }

        private void HeadlinesEasy_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Label label = new Label();
            label.AutoSize = false;
            label.Size = new Size(293,62);
            label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label.BackColor = Color.FromArgb(192, 255, 192);

            label.Text = txtHaber.Text;
            if (txtHaber.Text=="")
            {
                MessageBox.Show("Bir Haber Başlığı Girmediniz!");
            }
            else
            {
                if (radioMail.Checked)
                {
                    panelMail.Controls.Add(label);
                    maiList.Add(txtHaber.Text);
                }
                else if (radioTele.Checked)
                {
                    panelTele.Controls.Add(label);
                    teleList.Add(txtHaber.Text);
                }
                else if (radioGuar.Checked)
                {
                    panelGuar.Controls.Add(label);
                    guarList.Add(txtHaber.Text);
                }
                else if (radioInde.Checked)
                {
                    panelInde.Controls.Add(label);
                    indeList.Add(txtHaber.Text);
                }
                else
                {
                    MessageBox.Show("Lütfen Gazete Seçin!");
                }
            }

            txtHaber.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<RadioButton> radios = new List<RadioButton>(){radioGuar,radioInde,radioMail,radioTele};

            foreach (var radio in radios)
            {
                radio.Visible = false; 
            }
            btnTest.Visible = true;
            btnEkle.Visible = false;
            button1.Visible = false;
        }

        private int i = 0;

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string[] isimler = {"Independent", "Daily Mail", "Telegraph", "The Guardian"};
            int no = rand.Next(0, isimler.Length);

            if (indeList.Contains(txtHaber.Text))
            {
                MessageBox.Show("%" + rand.Next(80, 100) + " olasılıkla Independent");

            }else if (maiList.Contains(txtHaber.Text))
            {
                MessageBox.Show("%" + rand.Next(80, 100) + " olasılıkla Daily Mail");
            }else if (guarList.Contains(txtHaber.Text))
            {
                MessageBox.Show("%" + rand.Next(80, 100) + " olasılıkla The Guardian");
            }else if (teleList.Contains(txtHaber.Text))
            {
                MessageBox.Show("%" + rand.Next(80, 100) + " olasılıkla Telegraph");
            }
            else
            {
                if (txtHaber.Text=="")
                {
                    MessageBox.Show("Lütfen Haber Girin");
                }
                else
                {
                    MessageBox.Show("%" + rand.Next(0, 50) + "olaslıkla  " + isimler[no]);
                }
            
            }

            txtHaber.Text = "";
        }
    }
}
