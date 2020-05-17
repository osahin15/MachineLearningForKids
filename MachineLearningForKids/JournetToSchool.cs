using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningForKids.JourneySchool;

namespace MachineLearningForKids
{
    public partial class JournetToSchool : MetroFramework.Forms.MetroForm
    {
        private Journeyschool<string> student;
        private List<string> ageList = new List<string>();
        private List<string> distanceList = new List<string>();
        private List<string> friendList = new List<string>();
        
        private int i = 0;
        public JournetToSchool()
        {
            InitializeComponent();
        }

        private void JournetToSchool_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            List<RadioButton> radios = new List<RadioButton>(){radiocar,radiowalk,radiocycle};
            List<TextBox> textBoxs = new List<TextBox>(){txtage,txtdistance,txtfriends};
            //ageList = new List<string>();
            //distanceList = new List<string>();
            //friendList = new List<string>();
            Label l1 = new Label();
            Label l2 = new Label();
            Label l3 = new Label();
           

           

            FlowLayoutPanel labelPanel = new FlowLayoutPanel();
            labelPanel.Size = new Size(110,95);
            labelPanel.BackColor = Color.DarkOrange;
            labelPanel.FlowDirection = FlowDirection.TopDown;

            if (txtage.Text=="")
            {
                MessageBox.Show("Yaş Bilgisi Boş Bırakılamaz!");
            }
            else if (txtdistance.Text=="")
            {
                MessageBox.Show("Mesafe Bilgisi Boş Bırakılamaz!");
            }else if (txtfriends.Text == "")
            {
                MessageBox.Show("Arkadaş Bilgisi Boş Bırakılamaz!(0 olsa da giriniz!)");
            }
            else
            {
               student = new Journeyschool<string>(txtage.Text,txtdistance.Text,txtfriends.Text);
                ageList.Add(student.Ag);
                distanceList.Add(student.Dis);
                friendList.Add(student.Fri);


                l1.Text = "Yaş:" + student.Ag;
                l2.Text = "Mesafe:" + student.Dis;
                l3.Text = "Arkadaş:" + student.Fri;

                List<Label> labels = new List<Label>() { l1, l2, l3 };
             
                if (radios.Find(i => i.Checked) == radiocar)
                {
                    for (int j = 0; j < labels.Count; j++)
                    {
                        labelPanel.Controls.Add(labels[j]);
                    }
                    panelCar.Controls.Add(labelPanel);

                }
                else if (radios.Find(i => i.Checked) == radiowalk)
                {
                    for (int j = 0; j < labels.Count; j++)
                    {
                        labelPanel.Controls.Add(labels[j]);

                    }
                    panelWalk.Controls.Add(labelPanel);

                }
                else if (radios.Find(i => i.Checked) == radiocycle)
                {
                    for (int j = 0; j < labels.Count; j++)
                    {
                        labelPanel.Controls.Add(labels[j]);
                    }
                    panelCycle.Controls.Add(labelPanel);
                }
                else
                {
                    MessageBox.Show("Lütfen Seyahat Seçeneklerinden Birini Seçiniz! ");
                }
            }
          
           

            i++;
            Temizle();
            
        }

        public void Temizle()
        {
            txtage.Text = "";
            txtdistance.Text = "";
            txtfriends.Text = "";
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            label7.Text = "Test Etmek için Yeniden Doldurun ve Test Et!";
            radiocar.Visible = false;
            radiocycle.Visible = false;
            radiowalk.Visible = false;
            btnEkle.Visible = false;
            btnTest.Visible = true;
            btnTrain.Visible = false; 

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int rastgele = rand.Next(50, 100);
            
            for (int j = 0; j < ageList.Count; j++)
            {
                if (Convert.ToInt32(txtage.Text) < 9 && Convert.ToDouble(txtdistance.Text) > 2)
                {
                    if (Convert.ToInt32(ageList[j]) < 9 || Convert.ToDouble(distanceList[j]) > 2)
                    {
                        MessageBox.Show("%" + rastgele + "olasılık ile Araba ile seyahat ediyor.");
                        break;
                    }

                }
                else if (Convert.ToInt32(txtage.Text)>9 && Convert.ToDouble(txtdistance.Text)<1.5)
                {
                    if (Convert.ToInt32(ageList[j])>9|| Convert.ToDouble(distanceList[j])<2)
                    {
                        MessageBox.Show("%" + rastgele + "olasılık ile Yürüyerek seyahat ediyor.");
                        break;
                    }

                }else if (Convert.ToInt32(txtage.Text) > 12 && Convert.ToDouble(txtdistance.Text) < 2 && Convert.ToDouble(txtdistance.Text)>0.8)
                {
                    if (Convert.ToInt32(ageList[j]) > 12 || Convert.ToDouble(distanceList[j]) < 2)
                    {
                        MessageBox.Show("%" + rastgele + "olasılık ile Bisikletle seyahat ediyor.");
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli Başarıya ulaşan bir tahmin üretilemedi");
                    break;
                }
                               
            }
           Temizle();
        }
    }
}
