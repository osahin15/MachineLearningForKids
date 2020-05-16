using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class JudgeaBook : MetroFramework.Forms.MetroForm
    {
        private string dosyaYoluTest;
        private string dosyaYolu;
        private string dosyaAdi;
        List<PictureBox> pictures = new List<PictureBox>();
        public JudgeaBook()
        {
            InitializeComponent();
        }

        private void JudgeaBook_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
                       
            //PictureBox işlemleri.
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(106,80);


            List<RadioButton> radios = new List<RadioButton>() { cocukRadio, bilimRadio, romantikRadio, gerilimRadio };
            

            if (radios.Find(i=>i.Checked)==cocukRadio)
            {
                Dosya();
                if (dosyaAdi[0] =='c')
                {
                    pictureBox.ImageLocation = dosyaYolu;
                    pictures.Add(pictureBox);
                    cocukPanel.Controls.Add(pictureBox);

                }
                else
                {
                    MessageBox.Show("Çocuk türünde bir kitap Seçiniz..");
                    Dosya();
                }

            }else if (radios.Find(i=>i.Checked)==bilimRadio)
            {
                Dosya();
                if (dosyaAdi[0]=='b')
                {
                    pictureBox.ImageLocation = dosyaYolu;
                    pictures.Add(pictureBox);
                    bilimPanel.Controls.Add(pictureBox);
                }
                else
                {
                    MessageBox.Show("Bilim Kurgu türünde bir kitap seçiniz..");
                    Dosya();
                }
            }else if (radios.Find(i=>i.Checked)==romantikRadio)
            {
                Dosya();
                if (dosyaAdi[0]=='r')
                {
                    pictureBox.ImageLocation = dosyaYolu;
                    pictures.Add(pictureBox);
                    romantikPanel.Controls.Add(pictureBox);
                }
                else
                {
                    MessageBox.Show("Romantik türünde bir kitap seçiniz..");
                    Dosya();
                }
                
            }else if (radios.Find(i=>i.Checked)==gerilimRadio)
            {
                Dosya();
                if (dosyaAdi[0] == 'g')
                {
                    pictureBox.ImageLocation = dosyaYolu;
                    pictures.Add(pictureBox);
                    gerilimPanel.Controls.Add(pictureBox);
                }
                else
                {
                    MessageBox.Show("Gerilim türünde bir kitap seçiniz..");
                    Dosya();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir Kitap türünü seçin");
            }
            

 
                
            

        }
        //Dosya işlemleri..
        public void Dosya()
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png|Tüm Dosyalar|*.*";
            dosya.ShowDialog();
            dosyaYolu = dosya.FileName;
            dosyaAdi = Path.GetFileNameWithoutExtension(dosyaYolu);
            if (dosyaAdi=="")
            {
                dosyaAdi = "bos";
                MessageBox.Show("Dosya Secilmedi");
            }
           
        }
      
        private void btnTrain_Click(object sender, EventArgs e)
        {
            if (pictures.Count <= 3)
            {
                MessageBox.Show("Lütfen Train Edebilmek için en az 4 Resim Ekleyiniz..");
            }
            else
            {
                List<RadioButton> radios = new List<RadioButton>() { cocukRadio, bilimRadio, gerilimRadio, romantikRadio };
                foreach (var radio in radios)
                {
                    radio.Visible = false;
                }

                List<FlowLayoutPanel> layoutPanels = new List<FlowLayoutPanel>() { bilimPanel, gerilimPanel, cocukPanel, romantikPanel };
                foreach (var layout in layoutPanels)
                {
                    layout.Visible = false;
                }

                List<Label> labels = new List<Label>() { lblCocuk, lblBilim, lblGerilim, lblRomantik };
                foreach (var label in labels)
                {
                    label.Visible = false;
                }


                lblDegisecek.Text = "Test Edilecek Resim Ekleyiniz!";

                btnTest.Visible = true;
                btnTstResm.Visible = true;
                btnEkle.Visible = false;
                btnTrain.Visible = false;
                testPicture.Visible = true;
            }


           
        }

        private void btnTstResm_Click(object sender, EventArgs e)
        {
           
            
            Dosya();
            dosyaYoluTest = dosyaYolu;         
            testPicture.ImageLocation = dosyaYoluTest;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
           

            if (dosyaAdi[0] == 'c')
            {
                MessageBox.Show("Cocuk Kitabı :)", "Tahmin", MessageBoxButtons.OK);

            }
            else if (dosyaAdi[0] == 'b')
            {
                MessageBox.Show("Bilim Kitabı :)", "Tahmin", MessageBoxButtons.OK);
            }
            else if (dosyaAdi[0] == 'r')
            {
                MessageBox.Show("Romantik Kitap :)", "Tahmin", MessageBoxButtons.OK);
            }
            else if (dosyaAdi[0] == 'g')
            {
                MessageBox.Show("Gerilim Kitabı :)", "Tahmin", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Seçilen Tür Tahmin Edilememiştir. Lütfen Yeniden Deneyiniz.", "Hata");
            }
                
            
        }

     
    }
}
