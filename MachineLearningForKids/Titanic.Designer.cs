namespace MachineLearningForKids
{
    partial class Titanic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.survivedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notSurvivePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.kisiEkleBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmboEmbarked = new MetroFramework.Controls.MetroComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSibling = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.genderCmb = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketClassCmb = new MetroFramework.Controls.MetroComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.infoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Location = new System.Drawing.Point(23, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 10);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(484, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titanic";
            // 
            // survivedPanel
            // 
            this.survivedPanel.AutoScroll = true;
            this.survivedPanel.BackColor = System.Drawing.Color.Transparent;
            this.survivedPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.survivedPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.survivedPanel.Location = new System.Drawing.Point(15, 239);
            this.survivedPanel.Name = "survivedPanel";
            this.survivedPanel.Size = new System.Drawing.Size(311, 401);
            this.survivedPanel.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(23, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 81);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fotoğrafa tıklayın ve açılacak pencerede bulunan bilgileri eksiksiz doldurmaya ça" +
    "lışın.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(102, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 12;
            this.label3.Text = "Survived";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(722, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Did not Survive";
            // 
            // notSurvivePanel
            // 
            this.notSurvivePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notSurvivePanel.AutoScroll = true;
            this.notSurvivePanel.BackColor = System.Drawing.Color.Transparent;
            this.notSurvivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notSurvivePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.notSurvivePanel.Location = new System.Drawing.Point(681, 239);
            this.notSurvivePanel.Name = "notSurvivePanel";
            this.notSurvivePanel.Size = new System.Drawing.Size(311, 401);
            this.notSurvivePanel.TabIndex = 13;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.infoPanel.Controls.Add(this.checkBox2);
            this.infoPanel.Controls.Add(this.checkBox1);
            this.infoPanel.Controls.Add(this.kisiEkleBtn);
            this.infoPanel.Controls.Add(this.label13);
            this.infoPanel.Controls.Add(this.label12);
            this.infoPanel.Controls.Add(this.cmboEmbarked);
            this.infoPanel.Controls.Add(this.label11);
            this.infoPanel.Controls.Add(this.txtUcret);
            this.infoPanel.Controls.Add(this.label10);
            this.infoPanel.Controls.Add(this.txtParent);
            this.infoPanel.Controls.Add(this.label9);
            this.infoPanel.Controls.Add(this.txtSibling);
            this.infoPanel.Controls.Add(this.label8);
            this.infoPanel.Controls.Add(this.ageTxt);
            this.infoPanel.Controls.Add(this.label7);
            this.infoPanel.Controls.Add(this.label6);
            this.infoPanel.Controls.Add(this.genderCmb);
            this.infoPanel.Controls.Add(this.label5);
            this.infoPanel.Controls.Add(this.ticketClassCmb);
            this.infoPanel.Location = new System.Drawing.Point(349, 287);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(317, 283);
            this.infoPanel.TabIndex = 15;
            this.infoPanel.Visible = false;
           
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatAppearance.BorderSize = 0;
            this.checkBox2.Location = new System.Drawing.Point(141, 228);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 17);
            this.checkBox2.TabIndex = 18;
            this.checkBox2.Text = "DidNotSurvive";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.Location = new System.Drawing.Point(20, 228);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Survived";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // kisiEkleBtn
            // 
            this.kisiEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisiEkleBtn.Location = new System.Drawing.Point(76, 253);
            this.kisiEkleBtn.Name = "kisiEkleBtn";
            this.kisiEkleBtn.Size = new System.Drawing.Size(161, 23);
            this.kisiEkleBtn.TabIndex = 16;
            this.kisiEkleBtn.Text = "Ekle";
            this.kisiEkleBtn.UseVisualStyleBackColor = true;
            this.kisiEkleBtn.Click += new System.EventHandler(this.kisiEkleBtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(213, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "yoksa 0 giriniz!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(213, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "yoksa 0 giriniz!";
            // 
            // cmboEmbarked
            // 
            this.cmboEmbarked.FormattingEnabled = true;
            this.cmboEmbarked.ItemHeight = 23;
            this.cmboEmbarked.Items.AddRange(new object[] {
            "Cherbourg(France)",
            "Queenstown(Ireland)",
            "Southampton(England)"});
            this.cmboEmbarked.Location = new System.Drawing.Point(139, 189);
            this.cmboEmbarked.Name = "cmboEmbarked";
            this.cmboEmbarked.Size = new System.Drawing.Size(161, 29);
            this.cmboEmbarked.Sorted = true;
            this.cmboEmbarked.TabIndex = 13;
            this.cmboEmbarked.UseSelectable = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(17, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Bindiği Yer";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(139, 163);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(69, 20);
            this.txtUcret.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(17, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Bilet Ücreti";
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(139, 137);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(69, 20);
            this.txtParent.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(17, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ebeveyn ve Çocuk";
            // 
            // txtSibling
            // 
            this.txtSibling.Location = new System.Drawing.Point(139, 110);
            this.txtSibling.Name = "txtSibling";
            this.txtSibling.Size = new System.Drawing.Size(69, 20);
            this.txtSibling.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(17, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kardeş ve Eşler";
            // 
            // ageTxt
            // 
            this.ageTxt.Location = new System.Drawing.Point(139, 83);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(69, 20);
            this.ageTxt.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Yaş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cinsiyet";
            // 
            // genderCmb
            // 
            this.genderCmb.FormattingEnabled = true;
            this.genderCmb.ItemHeight = 23;
            this.genderCmb.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.genderCmb.Location = new System.Drawing.Point(139, 46);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(69, 29);
            this.genderCmb.Sorted = true;
            this.genderCmb.TabIndex = 2;
            this.genderCmb.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(17, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bilet Sınıfı";
            // 
            // ticketClassCmb
            // 
            this.ticketClassCmb.FormattingEnabled = true;
            this.ticketClassCmb.ItemHeight = 23;
            this.ticketClassCmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ticketClassCmb.Location = new System.Drawing.Point(139, 14);
            this.ticketClassCmb.Name = "ticketClassCmb";
            this.ticketClassCmb.Size = new System.Drawing.Size(69, 29);
            this.ticketClassCmb.Sorted = true;
            this.ticketClassCmb.TabIndex = 0;
            this.ticketClassCmb.UseSelectable = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(349, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "Train!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTest.Location = new System.Drawing.Point(349, 576);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(317, 52);
            this.btnTest.TabIndex = 18;
            this.btnTest.Text = "Test Et!";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MachineLearningForKids.Properties.Resources.arrow;
            this.pictureBox2.Location = new System.Drawing.Point(304, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::MachineLearningForKids.Properties.Resources.project_titanic;
            this.pictureBox1.Location = new System.Drawing.Point(349, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Titanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 663);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.notSurvivePanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.survivedPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Titanic";
            this.Text = "Titanic";
            this.Load += new System.EventHandler(this.Titanic_Load);
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel survivedPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel notSurvivePanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox ticketClassCmb;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSibling;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox genderCmb;
        private MetroFramework.Controls.MetroComboBox cmboEmbarked;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button kisiEkleBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTest;
    }
}