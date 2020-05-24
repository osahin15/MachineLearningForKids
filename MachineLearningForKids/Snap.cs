using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class Snap : MetroFramework.Forms.MetroForm
    {

        public string dosyaYolu;
        public string dosyaAdi;
        public string dosyaYoluTest;
        public string dosyaAdiTest;

        public Snap()
        {
            InitializeComponent();
        }

        private void Snap_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Oyunumuzu Oynamak İçin Her Bir Kart Türünden 10 Tane Ekleyip Train Ediniz.Bakalım Öğrenebilecek mi? ",
                "Oyun Bilgi", MessageBoxButtons.OK);
        }

        private void btnResimTrain_Click(object sender, EventArgs e)
        {

            PictureBox picture = new PictureBox();
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Size = new Size(40, 30);

            if (rdoKupa.Checked)
            {
                Dosya();
                if (dosyaAdi == "Kupa" || dosyaAdi == "kupa")
                {
                    picture.ImageLocation = dosyaYolu;
                    flwKupa.Controls.Add(picture);
                }

                else if (dosyaAdi == "bos")
                {
                    MessageBox.Show("Lütfen Bir Dosya Seçiniz.",
                        "Dosya Seçilmedi", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Seçtiğiniz Türde Bir Kart Giriniz.",
                        "Hata",MessageBoxButtons.OK);
                    Dosya();
                }
            }
            else if (rdoKaro.Checked)
            {
                Dosya();
                if (dosyaAdi == "Karo" || dosyaAdi == "karo")
                {
                    picture.ImageLocation = dosyaYolu;
                    flwKaro.Controls.Add(picture);
                }

                else if (dosyaAdi == "bos")
                {
                    MessageBox.Show("Lütfen Bir Dosya Seçiniz.",
                        "Dosya Seçilmedi", MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Seçtiğiniz Türde Bir Kart Giriniz.",
                        "Hata",MessageBoxButtons.OK);
                    Dosya();
                }
            }

            else if (rdoMaca.Checked)
            {
                Dosya();
                if (dosyaAdi == "Maca" || dosyaAdi == "maca")
                {
                    picture.ImageLocation = dosyaYolu;
                    flwMaca.Controls.Add(picture);
                }

                else if (dosyaAdi == "bos")
                {
                    MessageBox.Show("Lütfen Bir Dosya Seçiniz.",
                        "Dosya Seçilmedi",MessageBoxButtons.OK);
                }

                else
                {
                    MessageBox.Show("Seçtiğiniz Türde Bir Kart Giriniz.",
                        "Hata",MessageBoxButtons.OK);
                    Dosya();
                }
            }

            else if (rdoSinek.Checked)
            {
                Dosya();
                if (dosyaAdi == "Sinek" || dosyaAdi == "sinek")
                {
                    picture.ImageLocation = dosyaYolu;
                    flwSinek.Controls.Add(picture);
                }
                else if (dosyaAdi == "bos")
                {
                    MessageBox.Show("Lütfen Bir Dosya Seçiniz.",
                        "Dosya Seçilmedi", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz Türde Bir Kart Giriniz.");
                    Dosya();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kart Türü Seçiniz.");
            }
        }
        public void Dosya()
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png|Tüm Dosyalar|*.*";
            dosya.ShowDialog();
            dosyaYolu = dosya.FileName;
            dosyaAdi = Path.GetFileNameWithoutExtension(dosyaYolu);
            if (dosyaAdi == "")
            {
                dosyaAdi = "bos";
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {

            if (flwKupa.Controls.Count < 10)
            {
                MessageBox.Show("Lütfen Train İçin En Az 10 Tane Resim Ekleyiniz.");
            }
            else if (flwKaro.Controls.Count < 10)
            {
                MessageBox.Show("Lütfen Train İçin En Az 10 Tane Resim Ekleyiniz.");
            }

            else if (flwMaca.Controls.Count < 10)
            {
                MessageBox.Show("Lütfen Train İçin En Az 10 Tane Resim Ekleyiniz.");
            }

            else if (flwSinek.Controls.Count < 10)
            {
                MessageBox.Show("Lütfen Train İçin En Az 10 Tane Resim Ekleyiniz.");
            }
            else
            {
                MessageBox.Show("Train Edildi.");
            }
            btnResimTrain.Enabled = false;
        }

        private void btnResimTest_Click(object sender, EventArgs e)
        {
            Dosya();
            dosyaYoluTest = dosyaYolu;
            dosyaAdiTest = dosyaAdi;
            pctTest.ImageLocation = dosyaYoluTest;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(dosyaAdiTest=="Kupa" || dosyaAdiTest=="kupa")
            {
                MessageBox.Show("Seçtiğiniz Kart Kupa !",
                    "Tahmin",MessageBoxButtons.OK);
            }
            else if(dosyaAdiTest=="Karo" || dosyaAdiTest=="karo")
            {
                MessageBox.Show("Seçtiğiniz Kart Karo",
                    "Tahmin", MessageBoxButtons.OK);
            }

            else if (dosyaAdiTest == "Maca" || dosyaAdiTest == "maca")
            {
                MessageBox.Show("Seçtiğiniz Kart Maça",
                    "Tahmin", MessageBoxButtons.OK);
            }

            else if (dosyaAdiTest == "Sinek" || dosyaAdiTest == "sinek")
            {
                MessageBox.Show("Seçtiğiniz Kart Sinek",
                    "Tahmin", MessageBoxButtons.OK);
            }
        }
    }
}
