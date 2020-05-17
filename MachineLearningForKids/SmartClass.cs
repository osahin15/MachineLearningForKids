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
    public partial class SmartClass : MetroFramework.Forms.MetroForm
    {

        SmartClassTest smartClass = new SmartClassTest();
        public bool returnVal = false;
        public bool resultLampOn;
        public bool resultLampOff;
        public bool resultFanOn;
        public bool resultFanOff;

        public SmartClass()
        {
            InitializeComponent();
        }

        private void SmartClass_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            Label lbl = new Label();
            lbl.Text = txt_Train.Text;
            if (lbl.Text == "")
            {
                MessageBox.Show("Lütfen Train Etmek İstediğiniz Kelimeleri Giriniz.",
                    MessageBoxButtons.OK.ToString());
            }
            else if (rdo_FanOff.Checked)
            {
                lyt_FanOff.Controls.Add(lbl);
            }

            else if (rdo_FanOn.Checked)
            {
                lyt_FanOn.Controls.Add(lbl);
            }

            else if (rdo_LampOn.Checked)
            {
                lyt_LampOn.Controls.Add(lbl);
            }

            else if (rdo_LampOff.Checked)
            {
                lyt_LampOff.Controls.Add(lbl);
            }
            else
            {
                MessageBox.Show("Lütfen Bir tane Alan Seçiniz", MessageBoxButtons.OK.ToString());
            }
            txt_Train.Clear();
        }

        private void btn_Test_Click(object sender, EventArgs e)
        {
            bool kontrol = false;
            resultLampOn = smartClass.getLampOn(txt_Test.Text, smartClass.lampOn, returnVal);
            resultLampOff = smartClass.getLampOff(txt_Test.Text, smartClass.lampOff, returnVal);
            resultFanOn = smartClass.getFanOn(txt_Test.Text, smartClass.fanOn, returnVal);
            resultFanOff = smartClass.getFanOff(txt_Test.Text, smartClass.fanOff, returnVal);

            if (resultLampOn == true)
            {
                pct_FanOn.Visible = false;
                pct_LampAndFan.Visible = false;
                pct_LampOn.Visible = true;
                kontrol = true;
            }
            if (resultLampOff == true)
            {
                pct_FanOn.Visible = false;
                pct_LampAndFan.Visible = true;
                pct_LampOn.Visible = false;
                kontrol = true;
            }
            if (resultFanOn == true)
            {
                pct_FanOn.Visible = true;
                pct_LampAndFan.Visible = false;
                pct_LampOn.Visible = false;
                kontrol = true;
            }
            if (resultFanOff == true)
            {
                pct_FanOn.Visible = false;
                pct_LampAndFan.Visible = true;
                pct_LampOn.Visible = false;
                kontrol = true;
            }
            if (!kontrol)
            {
                MessageBox.Show("Cümle Anlaşılamadı.", MessageBoxButtons.OK.ToString());
            }
        }

        private void btn_Train_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Train Edildi");
        }
    }
}
