namespace MachineLearningForKids
{
    partial class WhatDoesTwitterThinks
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
            this.flwLikes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flwDislikes = new System.Windows.Forms.FlowLayoutPanel();
            this.flwNeither = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTrain = new System.Windows.Forms.RichTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.rdoNeither = new System.Windows.Forms.RadioButton();
            this.rdoLikes = new System.Windows.Forms.RadioButton();
            this.rdoDislikes = new System.Windows.Forms.RadioButton();
            this.txtTest = new System.Windows.Forms.RichTextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flwLikes
            // 
            this.flwLikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwLikes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwLikes.Location = new System.Drawing.Point(23, 113);
            this.flwLikes.Name = "flwLikes";
            this.flwLikes.Size = new System.Drawing.Size(219, 262);
            this.flwLikes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(1, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1202, 16);
            this.panel1.TabIndex = 1;
            // 
            // flwDislikes
            // 
            this.flwDislikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwDislikes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwDislikes.Location = new System.Drawing.Point(248, 113);
            this.flwDislikes.Name = "flwDislikes";
            this.flwDislikes.Size = new System.Drawing.Size(219, 262);
            this.flwDislikes.TabIndex = 1;
            // 
            // flwNeither
            // 
            this.flwNeither.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwNeither.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwNeither.Location = new System.Drawing.Point(23, 408);
            this.flwNeither.Name = "flwNeither";
            this.flwNeither.Size = new System.Drawing.Size(219, 262);
            this.flwNeither.TabIndex = 1;
            // 
            // txtTrain
            // 
            this.txtTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrain.Location = new System.Drawing.Point(248, 408);
            this.txtTrain.Name = "txtTrain";
            this.txtTrain.Size = new System.Drawing.Size(219, 185);
            this.txtTrain.TabIndex = 2;
            this.txtTrain.Text = "";
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEkle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(248, 599);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(219, 71);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrain.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrain.Location = new System.Drawing.Point(473, 319);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(122, 128);
            this.btnTrain.TabIndex = 4;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // rdoNeither
            // 
            this.rdoNeither.AutoSize = true;
            this.rdoNeither.Location = new System.Drawing.Point(94, 381);
            this.rdoNeither.Name = "rdoNeither";
            this.rdoNeither.Size = new System.Drawing.Size(75, 21);
            this.rdoNeither.TabIndex = 0;
            this.rdoNeither.TabStop = true;
            this.rdoNeither.Text = "Neither";
            this.rdoNeither.UseVisualStyleBackColor = true;
            // 
            // rdoLikes
            // 
            this.rdoLikes.AutoSize = true;
            this.rdoLikes.Location = new System.Drawing.Point(94, 86);
            this.rdoLikes.Name = "rdoLikes";
            this.rdoLikes.Size = new System.Drawing.Size(62, 21);
            this.rdoLikes.TabIndex = 5;
            this.rdoLikes.TabStop = true;
            this.rdoLikes.Text = "Likes";
            this.rdoLikes.UseVisualStyleBackColor = true;
            // 
            // rdoDislikes
            // 
            this.rdoDislikes.AutoSize = true;
            this.rdoDislikes.Location = new System.Drawing.Point(317, 86);
            this.rdoDislikes.Name = "rdoDislikes";
            this.rdoDislikes.Size = new System.Drawing.Size(77, 21);
            this.rdoDislikes.TabIndex = 6;
            this.rdoDislikes.TabStop = true;
            this.rdoDislikes.Text = "Dislikes";
            this.rdoDislikes.UseVisualStyleBackColor = true;
            // 
            // txtTest
            // 
            this.txtTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTest.Location = new System.Drawing.Point(741, 274);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(335, 185);
            this.txtTest.TabIndex = 7;
            this.txtTest.Text = "";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTest.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTest.Location = new System.Drawing.Point(741, 465);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(335, 71);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // WhatDoesTwitterThinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 699);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.rdoDislikes);
            this.Controls.Add(this.rdoLikes);
            this.Controls.Add(this.rdoNeither);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtTrain);
            this.Controls.Add(this.flwNeither);
            this.Controls.Add(this.flwDislikes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flwLikes);
            this.Name = "WhatDoesTwitterThinks";
            this.Text = "WhatDoesTwitterThinks";
            this.Load += new System.EventHandler(this.WhatDoesTwitterThinks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwLikes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flwDislikes;
        private System.Windows.Forms.FlowLayoutPanel flwNeither;
        private System.Windows.Forms.RichTextBox txtTrain;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.RadioButton rdoNeither;
        private System.Windows.Forms.RadioButton rdoLikes;
        private System.Windows.Forms.RadioButton rdoDislikes;
        private System.Windows.Forms.RichTextBox txtTest;
        private System.Windows.Forms.Button btnTest;
    }
}