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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.rdoNeither = new System.Windows.Forms.RadioButton();
            this.rdoLikes = new System.Windows.Forms.RadioButton();
            this.rdoDislikes = new System.Windows.Forms.RadioButton();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtTrain = new System.Windows.Forms.TextBox();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flwLikes
            // 
            this.flwLikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwLikes.AutoScroll = true;
            this.flwLikes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwLikes.Location = new System.Drawing.Point(17, 89);
            this.flwLikes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flwLikes.Name = "flwLikes";
            this.flwLikes.Size = new System.Drawing.Size(197, 222);
            this.flwLikes.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Location = new System.Drawing.Point(1, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(902, 13);
            this.panel1.TabIndex = 1;
            // 
            // flwDislikes
            // 
            this.flwDislikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwDislikes.AutoScroll = true;
            this.flwDislikes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwDislikes.Location = new System.Drawing.Point(266, 92);
            this.flwDislikes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flwDislikes.Name = "flwDislikes";
            this.flwDislikes.Size = new System.Drawing.Size(197, 222);
            this.flwDislikes.TabIndex = 1;
            // 
            // flwNeither
            // 
            this.flwNeither.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flwNeither.AutoScroll = true;
            this.flwNeither.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flwNeither.Location = new System.Drawing.Point(17, 337);
            this.flwNeither.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flwNeither.Name = "flwNeither";
            this.flwNeither.Size = new System.Drawing.Size(197, 222);
            this.flwNeither.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEkle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(266, 492);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(197, 58);
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
            this.btnTrain.Location = new System.Drawing.Point(554, 168);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(69, 195);
            this.btnTrain.TabIndex = 4;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // rdoNeither
            // 
            this.rdoNeither.AutoSize = true;
            this.rdoNeither.Location = new System.Drawing.Point(86, 317);
            this.rdoNeither.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNeither.Name = "rdoNeither";
            this.rdoNeither.Size = new System.Drawing.Size(59, 17);
            this.rdoNeither.TabIndex = 0;
            this.rdoNeither.Text = "Neither";
            this.rdoNeither.UseVisualStyleBackColor = true;
            // 
            // rdoLikes
            // 
            this.rdoLikes.AutoSize = true;
            this.rdoLikes.Location = new System.Drawing.Point(90, 70);
            this.rdoLikes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoLikes.Name = "rdoLikes";
            this.rdoLikes.Size = new System.Drawing.Size(50, 17);
            this.rdoLikes.TabIndex = 5;
            this.rdoLikes.Text = "Likes";
            this.rdoLikes.UseVisualStyleBackColor = true;
            // 
            // rdoDislikes
            // 
            this.rdoDislikes.AutoSize = true;
            this.rdoDislikes.Location = new System.Drawing.Point(334, 70);
            this.rdoDislikes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoDislikes.Name = "rdoDislikes";
            this.rdoDislikes.Size = new System.Drawing.Size(61, 17);
            this.rdoDislikes.TabIndex = 6;
            this.rdoDislikes.Text = "Dislikes";
            this.rdoDislikes.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTest.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTest.Location = new System.Drawing.Point(649, 378);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(251, 58);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtTrain
            // 
            this.txtTrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTrain.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtTrain.Location = new System.Drawing.Point(266, 337);
            this.txtTrain.MaxLength = 140;
            this.txtTrain.Multiline = true;
            this.txtTrain.Name = "txtTrain";
            this.txtTrain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTrain.Size = new System.Drawing.Size(197, 150);
            this.txtTrain.TabIndex = 16;
            // 
            // txtTest
            // 
            this.txtTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTest.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtTest.Location = new System.Drawing.Point(649, 168);
            this.txtTest.MaxLength = 140;
            this.txtTest.Multiline = true;
            this.txtTest.Name = "txtTest";
            this.txtTest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTest.Size = new System.Drawing.Size(251, 195);
            this.txtTest.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "140 karakter giriniz!";
            // 
            // WhatDoesTwitterThinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.txtTrain);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.rdoDislikes);
            this.Controls.Add(this.rdoLikes);
            this.Controls.Add(this.rdoNeither);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.flwNeither);
            this.Controls.Add(this.flwDislikes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flwLikes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WhatDoesTwitterThinks";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
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
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.RadioButton rdoNeither;
        private System.Windows.Forms.RadioButton rdoLikes;
        private System.Windows.Forms.RadioButton rdoDislikes;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox txtTrain;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Label label1;
    }
}