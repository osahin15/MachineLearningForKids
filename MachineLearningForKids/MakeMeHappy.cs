using System;
using System.Collections;
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
    public partial class MakeMeHappy : MetroFramework.Forms.MetroForm
    {
      
        public MakeMeHappy()
        {
            InitializeComponent();
        }

        private void MakeMeHappy_Load(object sender, EventArgs e)
        {
           
            lblHappy.Text = i.ToString();
            lblSad.Text = j.ToString();
            MessageBox.Show(
                "Oyun için öncelikle Happy ve Sad resimleriyle TRAIN bölümünden eğitiniz. Daha sonra TEST bolumunde tahmin edilecek resimi ekleyip Learn ve Test et Butonuna basınız.",
                "Nasıl Yapılır?", MessageBoxButtons.OK);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
         private int i = 0, j = 0;
         private string[] happy = new string[10];
         private string[] sad = new string[10];
        private string dosyaYolu;
        public string dosyaAdi;
        private void rsmTrainBtn_Click(object sender, EventArgs e)
        {
             
            
            pctureTrain.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png|Tüm Dosyalar|*.*";
            dosya.ShowDialog();
            dosyaYolu = dosya.FileName;
            pctureTrain.ImageLocation = dosyaYolu;
            dosyaAdi = Path.GetFileNameWithoutExtension(dosyaYolu);
        
            if (dosyaAdi == "Happy" || dosyaAdi == "happy")
            {
                happy[i] = dosyaAdi;
                lblHappy.Text = (i+1).ToString();
                i++;
            }
        
            else if (dosyaAdi == "Sad" || dosyaAdi == "sad")
            {
                sad[j] = dosyaAdi;
                lblSad.Text = (j+1).ToString();
                j++;
            }                   
        }

       
        private void btnTrain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Train Edildi.Test Aşamasına geçebilirsiniz.");

            if (pctureTrain.Image!=null)
            {
                pctureTrain.Image.Dispose();
                pctureTrain.Image = null;
            }
        }

        private string dosyaYolu2;
        private string testDosyasi;
        private void rsmTestBtn_Click(object sender, EventArgs e)
        {
            pctureTest.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dosya2 = new OpenFileDialog();
            dosya2.Filter = "Resim Dosyası |*.jpg;*.nef;*.png|Tüm Dosyalar|*.*";
            dosya2.ShowDialog();
            dosyaYolu2 = dosya2.FileName;
            pctureTest.ImageLocation = dosyaYolu2;
            testDosyasi = Path.GetFileNameWithoutExtension(dosyaYolu2);
          
        }
        private int sayac = 0;

      

        private void btnTest_Click(object sender, EventArgs e)
        {
                    
                    if (happy[sayac]== testDosyasi)
                    {
                        MessageBox.Show("Happy :)");
                        
                    }
                    else if (sad[sayac]==testDosyasi)
                    {
                        MessageBox.Show("Sad :(");
                        
                    }
                    else
                    {
                        MessageBox.Show("Happy ve ya Sad olarak belirlenemedi.");
                    }

            if (pctureTest.Image!=null)
            {
                pctureTest.Image.Dispose();
                pctureTest.Image = null;

            }
            

        }

       
    }
}
