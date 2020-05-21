using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningForKids
{
    public partial class Chameleon : MetroFramework.Forms.MetroForm
    {
        private string dosyaYolu;
        private string dosyaAdi;
        private string dosyaYoluTest;
        private string dosyaAdiTest;
        public Chameleon()
        {
            InitializeComponent();
        }

        private void Chameleon_Load(object sender, EventArgs e)
        {

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

        private void btnRenkEkle_Click(object sender, EventArgs e)
        {
            PictureBox pct = new PictureBox();
            pct.SizeMode = PictureBoxSizeMode.StretchImage;
            pct.Size = new Size(40, 30);

            if(rdoKirmizi.Checked)
            {
                Dosya();
                if(dosyaAdi[0]=='k' || dosyaAdi[0]=='K' )
                {
                    pct.ImageLocation = dosyaYolu;
                    flwKirmizi.Controls.Add(pct);
                }
                else if(dosyaAdi=="bos")
                {
                    MessageBox.Show("Lütfen Bir Dosya Seçiniz.",
                        "Dosya Seçilmedi", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz Türde Bir Renk Girinz.",
                        "Hata", MessageBoxButtons.OK);
                }
            }

            else if(rdoMavi.Checked)
            {
                Dosya();
                if (dosyaAdi[0] == 'm' || dosyaAdi[0] == 'M')
                {
                    pct.ImageLocation = dosyaYolu;
                    flwMavi.Controls.Add(pct);
                }
                else if (dosyaAdi == "bos")
                {
                    MessageBox.Show("Lütfen Bir Dosya Seçiniz.",
                        "Dosya Seçilmedi", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz Türde Bir Renk Girinz.",
                        "Hata", MessageBoxButtons.OK);
                }
            }

            else if(rdoYesil.Checked)
            {
                Dosya();
                if (dosyaAdi[0] == 'y' || dosyaAdi[0] == 'Y')
                {
                    pct.ImageLocation = dosyaYolu;
                    flwYesil.Controls.Add(pct);
                }
                else if (dosyaAdi == "bos")
                {
                    MessageBox.Show("Lütfen Bir Dosya Seçiniz.",
                        "Dosya Seçilmedi", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Seçtiğiniz Türde Bir Renk Girinz.",
                        "Hata", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bir Renk Seçiniz.");
            }
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {

            if (flwKirmizi.Controls.Count < 6)
            {
                MessageBox.Show("Lütfen Train İçin En Az 6 Tane Renk Ekleyiniz.",
                    "Kirmizi Renk",MessageBoxButtons.OK);
            }
            else if (flwMavi.Controls.Count < 6)
            {
                MessageBox.Show("Lütfen Train İçin En Az 6 Tane Renk Ekleyiniz.",
                    "Mavi Renk",MessageBoxButtons.OK);
            }

            else if (flwYesil.Controls.Count < 6)
            {
                MessageBox.Show("Lütfen Train İçin En Az 6 Tane Renk Ekleyiniz.",
                    "Yeşil Renk",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Train Edildi.",
                    "Başarılı",MessageBoxButtons.OK);
                pnlMenu.Visible = true;
                pnlTrain.Visible = false;
                pnlTest.Visible = false;
                btnTestMenu.Enabled = true;
            }
        }

        private void btnTrainMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlTrain.Visible = true;
            pnlTest.Visible = false;
        }

        private void btnMakeMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            pnlTest.Visible = true;
            pnlTrain.Visible = false;
        }

        private void btnRenkTest_Click(object sender, EventArgs e)
        {
            Dosya();
            dosyaYoluTest = dosyaYolu;
            dosyaAdiTest = dosyaAdi;
            pctRenkTest.ImageLocation = dosyaYoluTest;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (dosyaAdiTest[0] == 'K' || dosyaAdiTest[0] == 'k')
            {
                pctRenksiz.Visible = false;
                pctKirmizi.Visible = true;
                pctMavi.Visible = false;
                pctYesil.Visible = false;
            }
            else if (dosyaAdiTest[0] == 'M' || dosyaAdiTest[0] == 'm')
            {
                pctRenksiz.Visible = false;
                pctKirmizi.Visible = false;
                pctMavi.Visible = true;
                pctYesil.Visible = false;
            }
            else if (dosyaAdiTest[0] == 'Y' || dosyaAdiTest[0] == 'y')
            {
                pctRenksiz.Visible = false;
                pctKirmizi.Visible = false;
                pctMavi.Visible = false;
                pctYesil.Visible = true;
            }
        }

        private void btnTestMenu_Click(object sender, EventArgs e)
        {

            barLearn.Visible = true;
            for (int i = 0; i < 1000000; i++)
            {
                barLearn.Value = i;
            }
            MessageBox.Show("Status: Available!", "Status", MessageBoxButtons.OK);
            barLearn.Visible = false;
            btnMakeMenu.Enabled = true;
        }
    }
}
