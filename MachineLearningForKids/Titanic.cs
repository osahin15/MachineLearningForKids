using MachineLearningForKids.TitanicFolder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class Titanic : MetroFramework.Forms.MetroForm
    {
        private TitanicManager titanicManager;
        private List<TitanicManager> titanicManagers;
       
   
        public Titanic()
        {
            InitializeComponent();
            titanicManagers= new List<TitanicManager>();
            titanicManager = new TitanicManager();
        }

        private void Titanic_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            infoPanel.Visible = true;
        }

        private int i = 0;
        
        private void kisiEkleBtn_Click(object sender, EventArgs e)
        {

            Label l1 = new Label();
            Label l2 = new Label();
            Label l3 = new Label();
            Label l4 = new Label();
            Label l5 = new Label();
            Label l6 = new Label();
            Label l7 = new Label();

            button1.Visible = true;
            
            //Panellerin içine eklenen Labelların bulundugu panel.
            FlowLayoutPanel sPanel = new FlowLayoutPanel();
            sPanel.FlowDirection = FlowDirection.TopDown;
            sPanel.Size = new Size(110,170);
            sPanel.BackColor = Color.Gray;
            sPanel.WrapContents = true;
            List<Label> labels = new List<Label>() { l1, l2, l3, l4, l5, l6, l7 };


            //Combo box seçili mi kontrolleri
            if (ticketClassCmb.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen Bilet Sınıfı Seçin..");

                }
                else if (genderCmb.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen Cİnsiyet seçin..");
                }
                else if (cmboEmbarked.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen Yer seçin");
                }
                else
                {

                    titanicManager.ParentChild = txtParent.Text;
                    titanicManager.Age = ageTxt.Text;
                    titanicManager.Sibling = txtSibling.Text;
                    titanicManager.Ucret = txtUcret.Text;
                    titanicManager.TicketClass = ticketClassCmb.SelectedItem.ToString();
                    titanicManager.Gender = genderCmb.SelectedItem.ToString();
                    titanicManager.Embarked = cmboEmbarked.SelectedItem.ToString();

                    titanicManagers.Add(titanicManager);

                    //Survive ve Not survive kontrolleri ve panellere ekleme işlemi
                    if (checkBox1.Checked)
                    {

                        l1.Text = "Sınıf:" + titanicManagers[i].TicketClass;
                        l2.Text = "Cins:" + titanicManagers[i].Gender;
                        l3.Text = "Yaş:" + titanicManagers[i].Age;
                        l4.Text = "Kar.ve Eş:" + titanicManagers[i].Sibling;
                        l5.Text = "Ebe.ve Çocuk:" + titanicManagers[i].ParentChild;
                        l6.Text = "Ücret:" + titanicManagers[i].Ucret;
                        l7.Text = "Yer:" + titanicManagers[i].Embarked;
                        
                        for (int j = 0; j < labels.Count; j++)
                        {                        
                           sPanel.Controls.Add(labels[j]);                            
                        }
                        survivedPanel.Controls.Add(sPanel);
                    }
                    else if (checkBox2.Checked)
                    {
                        l1.Text = "Sınıf:" + titanicManagers[i].TicketClass;
                        l2.Text = "Cins:" + titanicManagers[i].Gender;
                        l3.Text = "Yaş:" + titanicManagers[i].Age;
                        l4.Text = "Kar.ve Eş:" + titanicManagers[i].Sibling;
                        l5.Text = "Ebe.ve Çocuk:" + titanicManagers[i].ParentChild;
                        l6.Text = "Ücret:" + titanicManagers[i].Ucret;
                        l7.Text = "Yer:" + titanicManagers[i].Embarked;

                    for (int j = 0; j < labels.Count; j++)
                        {
                             sPanel.Controls.Add(labels[j]);
                        }

                          notSurvivePanel.Controls.Add(sPanel);

                    }
                    else
                    {
                        MessageBox.Show("Lütfen Survive ve Did not Survive Bilgileri Eksiksiz Giriniz!!!", "Alert",
                            MessageBoxButtons.OK);
                    }
                    i++;
                }            
                 Temizle();   

        }
        //Textbox ve Comboboxları temizleyen metot
        public void Temizle()
        {
            ticketClassCmb.SelectedIndex = -1;
            genderCmb.SelectedIndex = -1;
            ageTxt.Clear();
            txtSibling.Clear();
            txtParent.Clear();
            txtUcret.Clear();
            cmboEmbarked.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox2.Checked = false;

        }
   
        //Train butonu
        private void button1_Click(object sender, EventArgs e)
        {
            kisiEkleBtn.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            btnTest.Visible = true;
            button1.Visible = false;
         
        }
        //Test bölümü
        private void btnTest_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
                 
                if (genderCmb.SelectedItem.ToString()=="Kadın" && Convert.ToInt32(txtParent.Text)>0)
                {
                    foreach (TitanicManager person in titanicManagers)
                    {
                    if (person.Gender == "Kadın" || Convert.ToInt32(person.ParentChild) > 0)
                    {
                        int s1 = rand.Next(70, 100);

                        MessageBox.Show("% " + s1 + " olasılık ile Survived ");
                        break;
                    }
                }                
                }
                else if (ticketClassCmb.SelectedItem.ToString()=="1" && Convert.ToInt32(ageTxt.Text)<=60)
                {
                    foreach (TitanicManager person in titanicManagers)
                    {
                    if (person.TicketClass == "1" || Convert.ToInt32(person.Age) <= 60)
                    {
                        int s2 = rand.Next(50, 80);
                        MessageBox.Show("% " + s2 + " olasılık ile Survived ");
                        break;
                    }
                }
                 
                  
                }
                else if (genderCmb.SelectedItem.ToString()=="Erkek" && ticketClassCmb.SelectedIndex+1 == 1)
                {
                    foreach (TitanicManager person in titanicManagers)
                    {
                    if (person.Gender == "Erkek" || person.TicketClass == "1")
                    {
                        int s3 = rand.Next(50, 80);
                        MessageBox.Show("% " + s3 + " olasılık ile Survived ");
                        break;
                    }
                }
                 
                  
                }
                else
                {
                    int s4 = rand.Next(50, 100);
                    MessageBox.Show("% "+ s4 +" olasılık ile Did Not Survive ");
                    
                }

            Temizle();
           
        }
       
    }
}
