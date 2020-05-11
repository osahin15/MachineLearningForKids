using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using FontAwesome.Sharp;

namespace MachineLearningForKids
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private MakeMeHappy formMeHappy;
        public Form1()
        {
            InitializeComponent();
            
         
        }

      
      

        private void Form1_Load(object sender, EventArgs e)
        {
          
            


        }

    

        private void gamesBtn_Click(object sender, EventArgs e)
        {

            gamesPanel.Visible = true;

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            gamesPanel.Visible = false;

        }

        private void lgnBtn_Click(object sender, EventArgs e)
        {
            

        }

        private void makeMeHappy_Click(object sender, EventArgs e)
        {
            formMeHappy = new MakeMeHappy();
            formMeHappy.ShowDialog();
        }
    }
}
