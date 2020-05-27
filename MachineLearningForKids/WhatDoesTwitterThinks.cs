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
    public partial class WhatDoesTwitterThinks : MetroFramework.Forms.MetroForm
    {
        TwitterTest twit = new TwitterTest();
        public bool resultLike;
        public bool resultDislike;
        public bool resultFlowLike;
        public bool resultFlowDislike;
        public bool ret;

        List<string> flowLikes= new List<string>();
        List<string> flowDislikes = new List<string>();

        public WhatDoesTwitterThinks()
        {
            InitializeComponent();
        }

        private void WhatDoesTwitterThinks_Load(object sender, EventArgs e)
        {
            List<RadioButton> radios = new List<RadioButton>(){rdoDislikes,rdoLikes,rdoNeither};

            foreach (var radio in radios)
            {
                radio.Checked = false;
            
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Size = new Size(150,110);
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            lbl.BackColor = Color.DeepSkyBlue;
            lbl.Text = txtTrain.Text;

            if (lbl.Text == "")
            {
                MessageBox.Show("Lütfen Train Etmek İçin Tweet Giriniz.",
                    "Hata", MessageBoxButtons.OK);
            }

            else if (rdoLikes.Checked)
            {
                flwLikes.Controls.Add(lbl);
                flowLikes.Add(lbl.Text);
            }

            else if (rdoDislikes.Checked)
            {
                flwDislikes.Controls.Add(lbl);
                flowDislikes.Add(lbl.Text);
            }

            else if (rdoNeither.Checked)
            {
                flwNeither.Controls.Add(lbl);
            }

            else
            {
                MessageBox.Show("Lütfen Bir Tane Alan Seçiniz.",
                    "Hata", MessageBoxButtons.OK);
            }
            txtTrain.Clear();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (flwLikes.Controls.Count < 6)
            {
                MessageBox.Show("Lütfen Yeterli Öğrenme İçin Gerekli Alanlara En Az 6 Tane Soru Giriniz.",
                    "Likes Alani Eksik", MessageBoxButtons.OK);
            }

            else if (flwDislikes.Controls.Count < 6)
            {
                MessageBox.Show("Lütfen Yeterli Öğrenme İçin Gerekli Alanlara En Az 6 Tane Soru Giriniz.",
                    "Dislikes Alani Eksik", MessageBoxButtons.OK);
            }

            else if (flwNeither.Controls.Count < 6)
            {
                MessageBox.Show("Lütfen Yeterli Öğrenme İçin Gerekli Alanlara En Az 6 Tane Soru Giriniz.",
                    "Neither Alanı Eksik", MessageBoxButtons.OK);
            }
            else
            {
                btnEkle.Enabled = false;
                btnTrain.Enabled = false;
                MessageBox.Show("Train Edildi.",
                    "Train", MessageBoxButtons.OK);
            }
            btnEkle.Enabled = false;
            btnTrain.Enabled = false;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            resultLike = twit.IsLike(txtTest.Text, twit.Likes, ret);
            resultDislike = twit.IsLike(txtTest.Text, twit.Dislikes, ret);
            resultFlowLike = twit.IsLıkeForFlow(txtTest.Text, flowLikes, ret);
            resultFlowDislike = twit.IsLıkeForFlow(txtTest.Text, flowDislikes, ret);

            if(resultLike || resultFlowLike)
            {
                MessageBox.Show("Like :)",
                    "Duygu Analizi", MessageBoxButtons.OK);
            }
            else if(resultDislike || resultFlowDislike)
            {
                MessageBox.Show("Dislike :(",
                    "Duygu Analizi", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Neither -_-",
                    "Duygu Analizi", MessageBoxButtons.OK);
            }
        }
    }
}
