namespace MachineLearningForKids
{
    partial class Chameleon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chameleon));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnMakeMenu = new System.Windows.Forms.Button();
            this.btnTestMenu = new System.Windows.Forms.Button();
            this.btnTrainMenu = new System.Windows.Forms.Button();
            this.pnlTest = new System.Windows.Forms.Panel();
            this.btnTest = new System.Windows.Forms.Button();
            this.pctRenksiz = new System.Windows.Forms.PictureBox();
            this.btnRenkTest = new System.Windows.Forms.Button();
            this.pctYesil = new System.Windows.Forms.PictureBox();
            this.pctMavi = new System.Windows.Forms.PictureBox();
            this.pctKirmizi = new System.Windows.Forms.PictureBox();
            this.pctRenkTest = new System.Windows.Forms.PictureBox();
            this.pnlTrain = new System.Windows.Forms.Panel();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRenkEkle = new System.Windows.Forms.Button();
            this.rdoYesil = new System.Windows.Forms.RadioButton();
            this.flwMavi = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoMavi = new System.Windows.Forms.RadioButton();
            this.rdoKirmizi = new System.Windows.Forms.RadioButton();
            this.flwYesil = new System.Windows.Forms.FlowLayoutPanel();
            this.flwKirmizi = new System.Windows.Forms.FlowLayoutPanel();
            this.barLearn = new System.Windows.Forms.ProgressBar();
            this.pnlMenu.SuspendLayout();
            this.pnlTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRenksiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKirmizi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRenkTest)).BeginInit();
            this.pnlTrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMenu.BackColor = System.Drawing.Color.Snow;
            this.pnlMenu.Controls.Add(this.barLearn);
            this.pnlMenu.Controls.Add(this.btnMakeMenu);
            this.pnlMenu.Controls.Add(this.btnTestMenu);
            this.pnlMenu.Controls.Add(this.btnTrainMenu);
            this.pnlMenu.Location = new System.Drawing.Point(25, 81);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1209, 536);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnMakeMenu
            // 
            this.btnMakeMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMakeMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnMakeMenu.Enabled = false;
            this.btnMakeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMakeMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMakeMenu.Location = new System.Drawing.Point(820, 223);
            this.btnMakeMenu.Name = "btnMakeMenu";
            this.btnMakeMenu.Size = new System.Drawing.Size(169, 75);
            this.btnMakeMenu.TabIndex = 2;
            this.btnMakeMenu.Text = "Make";
            this.btnMakeMenu.UseVisualStyleBackColor = false;
            this.btnMakeMenu.Click += new System.EventHandler(this.btnMakeMenu_Click);
            // 
            // btnTestMenu
            // 
            this.btnTestMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTestMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTestMenu.Enabled = false;
            this.btnTestMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTestMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTestMenu.Location = new System.Drawing.Point(531, 223);
            this.btnTestMenu.Name = "btnTestMenu";
            this.btnTestMenu.Size = new System.Drawing.Size(169, 75);
            this.btnTestMenu.TabIndex = 1;
            this.btnTestMenu.Text = "Learn And Test";
            this.btnTestMenu.UseVisualStyleBackColor = false;
            this.btnTestMenu.Click += new System.EventHandler(this.btnTestMenu_Click);
            // 
            // btnTrainMenu
            // 
            this.btnTrainMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrainMenu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTrainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrainMenu.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTrainMenu.Location = new System.Drawing.Point(235, 223);
            this.btnTrainMenu.Name = "btnTrainMenu";
            this.btnTrainMenu.Size = new System.Drawing.Size(169, 75);
            this.btnTrainMenu.TabIndex = 0;
            this.btnTrainMenu.Text = "Train";
            this.btnTrainMenu.UseVisualStyleBackColor = false;
            this.btnTrainMenu.Click += new System.EventHandler(this.btnTrainMenu_Click);
            // 
            // pnlTest
            // 
            this.pnlTest.BackColor = System.Drawing.Color.Snow;
            this.pnlTest.Controls.Add(this.btnTest);
            this.pnlTest.Controls.Add(this.pctRenksiz);
            this.pnlTest.Controls.Add(this.btnRenkTest);
            this.pnlTest.Controls.Add(this.pctYesil);
            this.pnlTest.Controls.Add(this.pctMavi);
            this.pnlTest.Controls.Add(this.pctKirmizi);
            this.pnlTest.Controls.Add(this.pctRenkTest);
            this.pnlTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTest.Location = new System.Drawing.Point(20, 60);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(1219, 573);
            this.pnlTest.TabIndex = 1;
            this.pnlTest.Visible = false;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTest.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTest.Location = new System.Drawing.Point(271, 468);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(673, 55);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pctRenksiz
            // 
            this.pctRenksiz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctRenksiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctRenksiz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctRenksiz.Image = ((System.Drawing.Image)(resources.GetObject("pctRenksiz.Image")));
            this.pctRenksiz.Location = new System.Drawing.Point(710, 181);
            this.pctRenksiz.Name = "pctRenksiz";
            this.pctRenksiz.Size = new System.Drawing.Size(234, 174);
            this.pctRenksiz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRenksiz.TabIndex = 5;
            this.pctRenksiz.TabStop = false;
            // 
            // btnRenkTest
            // 
            this.btnRenkTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRenkTest.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRenkTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenkTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenkTest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRenkTest.Location = new System.Drawing.Point(310, 65);
            this.btnRenkTest.Name = "btnRenkTest";
            this.btnRenkTest.Size = new System.Drawing.Size(265, 62);
            this.btnRenkTest.TabIndex = 4;
            this.btnRenkTest.Text = "Renk Ekle";
            this.btnRenkTest.UseVisualStyleBackColor = false;
            this.btnRenkTest.Click += new System.EventHandler(this.btnRenkTest_Click);
            // 
            // pctYesil
            // 
            this.pctYesil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctYesil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctYesil.BackgroundImage")));
            this.pctYesil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctYesil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctYesil.Image = ((System.Drawing.Image)(resources.GetObject("pctYesil.Image")));
            this.pctYesil.Location = new System.Drawing.Point(710, 181);
            this.pctYesil.Name = "pctYesil";
            this.pctYesil.Size = new System.Drawing.Size(234, 174);
            this.pctYesil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctYesil.TabIndex = 3;
            this.pctYesil.TabStop = false;
            this.pctYesil.Visible = false;
            // 
            // pctMavi
            // 
            this.pctMavi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctMavi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctMavi.BackgroundImage")));
            this.pctMavi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctMavi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctMavi.Image = ((System.Drawing.Image)(resources.GetObject("pctMavi.Image")));
            this.pctMavi.Location = new System.Drawing.Point(710, 181);
            this.pctMavi.Name = "pctMavi";
            this.pctMavi.Size = new System.Drawing.Size(234, 174);
            this.pctMavi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMavi.TabIndex = 2;
            this.pctMavi.TabStop = false;
            this.pctMavi.Visible = false;
            // 
            // pctKirmizi
            // 
            this.pctKirmizi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctKirmizi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctKirmizi.BackgroundImage")));
            this.pctKirmizi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctKirmizi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctKirmizi.Image = ((System.Drawing.Image)(resources.GetObject("pctKirmizi.Image")));
            this.pctKirmizi.Location = new System.Drawing.Point(710, 181);
            this.pctKirmizi.Name = "pctKirmizi";
            this.pctKirmizi.Size = new System.Drawing.Size(234, 174);
            this.pctKirmizi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctKirmizi.TabIndex = 1;
            this.pctKirmizi.TabStop = false;
            this.pctKirmizi.Visible = false;
            // 
            // pctRenkTest
            // 
            this.pctRenkTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctRenkTest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pctRenkTest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctRenkTest.Location = new System.Drawing.Point(271, 133);
            this.pctRenkTest.Name = "pctRenkTest";
            this.pctRenkTest.Size = new System.Drawing.Size(340, 266);
            this.pctRenkTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctRenkTest.TabIndex = 0;
            this.pctRenkTest.TabStop = false;
            // 
            // pnlTrain
            // 
            this.pnlTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTrain.BackColor = System.Drawing.Color.Snow;
            this.pnlTrain.Controls.Add(this.btnTrain);
            this.pnlTrain.Controls.Add(this.btnRenkEkle);
            this.pnlTrain.Controls.Add(this.rdoYesil);
            this.pnlTrain.Controls.Add(this.flwMavi);
            this.pnlTrain.Controls.Add(this.rdoMavi);
            this.pnlTrain.Controls.Add(this.rdoKirmizi);
            this.pnlTrain.Controls.Add(this.flwYesil);
            this.pnlTrain.Controls.Add(this.flwKirmizi);
            this.pnlTrain.Location = new System.Drawing.Point(25, 63);
            this.pnlTrain.Name = "pnlTrain";
            this.pnlTrain.Size = new System.Drawing.Size(1209, 570);
            this.pnlTrain.TabIndex = 2;
            this.pnlTrain.Visible = false;
            // 
            // btnTrain
            // 
            this.btnTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrain.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrain.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnTrain.Location = new System.Drawing.Point(237, 483);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(758, 59);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnRenkEkle
            // 
            this.btnRenkEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRenkEkle.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRenkEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRenkEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRenkEkle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRenkEkle.Location = new System.Drawing.Point(534, 49);
            this.btnRenkEkle.Name = "btnRenkEkle";
            this.btnRenkEkle.Size = new System.Drawing.Size(148, 39);
            this.btnRenkEkle.TabIndex = 5;
            this.btnRenkEkle.Text = "Renk Ekle";
            this.btnRenkEkle.UseVisualStyleBackColor = false;
            this.btnRenkEkle.Click += new System.EventHandler(this.btnRenkEkle_Click);
            // 
            // rdoYesil
            // 
            this.rdoYesil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoYesil.AutoSize = true;
            this.rdoYesil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoYesil.Location = new System.Drawing.Point(914, 110);
            this.rdoYesil.Name = "rdoYesil";
            this.rdoYesil.Size = new System.Drawing.Size(75, 29);
            this.rdoYesil.TabIndex = 4;
            this.rdoYesil.TabStop = true;
            this.rdoYesil.Text = "Yeşil";
            this.rdoYesil.UseVisualStyleBackColor = true;
            // 
            // flwMavi
            // 
            this.flwMavi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwMavi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flwMavi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwMavi.Location = new System.Drawing.Point(489, 145);
            this.flwMavi.Name = "flwMavi";
            this.flwMavi.Size = new System.Drawing.Size(230, 317);
            this.flwMavi.TabIndex = 1;
            // 
            // rdoMavi
            // 
            this.rdoMavi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoMavi.AutoSize = true;
            this.rdoMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoMavi.Location = new System.Drawing.Point(566, 110);
            this.rdoMavi.Name = "rdoMavi";
            this.rdoMavi.Size = new System.Drawing.Size(75, 29);
            this.rdoMavi.TabIndex = 3;
            this.rdoMavi.TabStop = true;
            this.rdoMavi.Text = "Mavi";
            this.rdoMavi.UseVisualStyleBackColor = true;
            // 
            // rdoKirmizi
            // 
            this.rdoKirmizi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoKirmizi.AutoSize = true;
            this.rdoKirmizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdoKirmizi.Location = new System.Drawing.Point(215, 110);
            this.rdoKirmizi.Name = "rdoKirmizi";
            this.rdoKirmizi.Size = new System.Drawing.Size(91, 29);
            this.rdoKirmizi.TabIndex = 2;
            this.rdoKirmizi.TabStop = true;
            this.rdoKirmizi.Text = "Kırmızı";
            this.rdoKirmizi.UseVisualStyleBackColor = true;
            // 
            // flwYesil
            // 
            this.flwYesil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwYesil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flwYesil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwYesil.Location = new System.Drawing.Point(835, 145);
            this.flwYesil.Name = "flwYesil";
            this.flwYesil.Size = new System.Drawing.Size(230, 317);
            this.flwYesil.TabIndex = 1;
            // 
            // flwKirmizi
            // 
            this.flwKirmizi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwKirmizi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flwKirmizi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwKirmizi.Location = new System.Drawing.Point(148, 145);
            this.flwKirmizi.Name = "flwKirmizi";
            this.flwKirmizi.Size = new System.Drawing.Size(230, 317);
            this.flwKirmizi.TabIndex = 0;
            // 
            // barLearn
            // 
            this.barLearn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.barLearn.Location = new System.Drawing.Point(531, 305);
            this.barLearn.Maximum = 1000000;
            this.barLearn.Name = "barLearn";
            this.barLearn.Size = new System.Drawing.Size(169, 23);
            this.barLearn.TabIndex = 3;
            this.barLearn.Visible = false;
            // 
            // Chameleon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 661);
            this.Controls.Add(this.pnlTrain);
            this.Controls.Add(this.pnlTest);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Chameleon";
            this.Text = "Chameleon";
            this.Load += new System.EventHandler(this.Chameleon_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctRenksiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKirmizi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRenkTest)).EndInit();
            this.pnlTrain.ResumeLayout(false);
            this.pnlTrain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMakeMenu;
        private System.Windows.Forms.Button btnTestMenu;
        private System.Windows.Forms.Button btnTrainMenu;
        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.Panel pnlTrain;
        private System.Windows.Forms.FlowLayoutPanel flwKirmizi;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRenkEkle;
        private System.Windows.Forms.RadioButton rdoYesil;
        private System.Windows.Forms.RadioButton rdoMavi;
        private System.Windows.Forms.RadioButton rdoKirmizi;
        private System.Windows.Forms.FlowLayoutPanel flwYesil;
        private System.Windows.Forms.FlowLayoutPanel flwMavi;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox pctRenksiz;
        private System.Windows.Forms.Button btnRenkTest;
        private System.Windows.Forms.PictureBox pctYesil;
        private System.Windows.Forms.PictureBox pctMavi;
        private System.Windows.Forms.PictureBox pctKirmizi;
        private System.Windows.Forms.PictureBox pctRenkTest;
        private System.Windows.Forms.ProgressBar barLearn;
    }
}