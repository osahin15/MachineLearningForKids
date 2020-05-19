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
    public partial class ChatBots : MetroFramework.Forms.MetroForm
    {
        ChatBotsTest test = new ChatBotsTest();
        public bool returnVal;
        public bool resultFood;
        public bool resultCountries;
        public bool resultLifeSpan;
        public bool resultSpecies;
        public bool resultSize;

        public string textFood = "";
        public string textCountries = "";
        public string textLifeSpan = "";
        public string textSpecies = "";
        public string textSize = "";

        public ChatBots()
        {
            InitializeComponent();
        }

        private void ChatBots_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = txt_Train.Text;

            if(lbl.Text=="")
            {
                MessageBox.Show("Lütfen Train Etmek İçin Sorulari Giriniz.",
                    "Hata", MessageBoxButtons.OK);
            }

            else if(rdo_Food.Checked)
            {
                flw_Food.Controls.Add(lbl);
            }

            else if (rdo_Countries.Checked)
            {
                flw_Countries.Controls.Add(lbl);
            }

            else if (rdo_LifeSpan.Checked)
            {
                flw_LifeSpan.Controls.Add(lbl);
            }

            else if (rdo_Species.Checked)
            {
                flw_Species.Controls.Add(lbl);
            }

            else if (rdo_Size.Checked)
            {
                flw_Size.Controls.Add(lbl);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Tane Alan Seçiniz.",
                    "Hata", MessageBoxButtons.OK);
            }
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {
            pnl_Giris.Visible = false;
            pnl_Test.Visible = false;
            pnl_Train.Visible = true;
        }

        private void btn_MenuMake_Click(object sender, EventArgs e)
        {
            pnl_Giris.Visible = false;
            pnl_Train.Visible = false;
            pnl_Test.Visible = true;
        }

        private void btn_Make_Click(object sender, EventArgs e)
        {
            if (txt_Food.Text == "")
            {
                MessageBox.Show("Lütfen Food Alanini Doldurunuz.",
                    "Hata", MessageBoxButtons.OK);
            }

            else if (txt_Countries.Text == "")
            {
                MessageBox.Show("Lütfen Countries Alanini Doldurunuz.",
                    "Hata", MessageBoxButtons.OK);
            }

            else if (txt_LifeSpan.Text == "")
            {
                MessageBox.Show("Lütfen Lifespan Alanini Doldurunuz.",
                    "Hata", MessageBoxButtons.OK);
            }

            else if (txt_Species.Text == "")
            {
                MessageBox.Show("Lütfen Species Alanini Doldurunuz.",
                    "Hata", MessageBoxButtons.OK);
            }

            else if (txt_Size.Text == "")
            {
                MessageBox.Show("Lütfen Size Alanini Doldurunuz.",
                    "Hata", MessageBoxButtons.OK);
            }
            textFood = txt_Food.Text;
            textCountries = txt_Countries.Text;
            textLifeSpan = txt_LifeSpan.Text;
            textSpecies = txt_Species.Text;
            textSize = txt_Size.Text;
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            resultFood = test.FindFood(txt_Test.Text, test.TestFood, returnVal);
            resultCountries = test.FindCountries(txt_Test.Text, test.TestCountries, returnVal);
            resultLifeSpan = test.FindLifeSpan(txt_Test.Text, test.TestLifeSpan, returnVal);
            resultSpecies = test.FindSpecies(txt_Test.Text, test.TestSpecies, returnVal);
            resultSize = test.FindSize(txt_Test.Text, test.TestSize, returnVal);

            if(resultFood)
            {
                if(textFood=="")
                {
                    MessageBox.Show("I havent been taught anything about that yet",
                        "Owl Says", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(textFood,
                        "Owl Says", MessageBoxButtons.OK);
                }
            }

            if(resultCountries)
            {
                if (textCountries == "")
                {
                    MessageBox.Show("I havent been taught anything about that yet",
                        "Owl Says", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(textCountries,
                        "Owl Says", MessageBoxButtons.OK);
                }
            }

            if(resultLifeSpan)
            {
                if (textLifeSpan == "")
                {
                    MessageBox.Show("I havent been taught anything about that yet",
                        "Owl Says", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(textLifeSpan,
                        "Owl Says", MessageBoxButtons.OK);
                }
            }

            if(resultSpecies)
            {
                if (textSpecies == "")
                {
                    MessageBox.Show("I havent been taught anything about that yet",
                        "Owl Says", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(textSpecies,
                    "Owl Says", MessageBoxButtons.OK);
                }
                
            }

            if(resultSize)
            {
                if (textSize == "")
                {
                    MessageBox.Show("I havent been taught anything about that yet",
                        "Owl Says", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(textSize,
                    "Owl Says", MessageBoxButtons.OK);
                }
                
            }
        }

        private void btn_TrainBack_Click(object sender, EventArgs e)
        {
            pnl_Train.Visible = false;
            pnl_Giris.Visible = true;
            pnl_Test.Visible = false;
        }

        private void btn_TestMenu_Click(object sender, EventArgs e)
        {
            Learn_bar.Visible = true;
            for (int i = 0; i < 1000000; i++)
            {
                Learn_bar.Value = i;
            }
            MessageBox.Show("Status: Available!","Status",MessageBoxButtons.OK);
            Learn_bar.Visible = false;
        }
    }
}
