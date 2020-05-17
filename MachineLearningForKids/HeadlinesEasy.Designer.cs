namespace MachineLearningForKids
{
    partial class HeadlinesEasy
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
            this.panelMail = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTele = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInde = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGuar = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.radioMail = new System.Windows.Forms.RadioButton();
            this.radioTele = new System.Windows.Forms.RadioButton();
            this.radioInde = new System.Windows.Forms.RadioButton();
            this.radioGuar = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.Location = new System.Drawing.Point(23, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 13);
            this.panel1.TabIndex = 0;
            // 
            // panelMail
            // 
            this.panelMail.AutoScroll = true;
            this.panelMail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelMail.Location = new System.Drawing.Point(23, 104);
            this.panelMail.Name = "panelMail";
            this.panelMail.Size = new System.Drawing.Size(296, 229);
            this.panelMail.TabIndex = 1;
            this.panelMail.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panelTele
            // 
            this.panelTele.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelTele.AutoScroll = true;
            this.panelTele.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelTele.Location = new System.Drawing.Point(23, 365);
            this.panelTele.Name = "panelTele";
            this.panelTele.Size = new System.Drawing.Size(296, 229);
            this.panelTele.TabIndex = 2;
            // 
            // panelInde
            // 
            this.panelInde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInde.AutoScroll = true;
            this.panelInde.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelInde.Location = new System.Drawing.Point(710, 102);
            this.panelInde.Name = "panelInde";
            this.panelInde.Size = new System.Drawing.Size(296, 229);
            this.panelInde.TabIndex = 2;
            // 
            // panelGuar
            // 
            this.panelGuar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGuar.AutoScroll = true;
            this.panelGuar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelGuar.Location = new System.Drawing.Point(710, 365);
            this.panelGuar.Name = "panelGuar";
            this.panelGuar.Size = new System.Drawing.Size(296, 229);
            this.panelGuar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gazete başlıklarının hangi gazeteye ait olduğunu tahmin eden bir oyun yapalım :)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(120, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Daily Mail";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(96, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Daily Telegraph";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(793, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "The Independent";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(807, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "The Guardian";
            // 
            // radioMail
            // 
            this.radioMail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioMail.AutoSize = true;
            this.radioMail.Location = new System.Drawing.Point(346, 252);
            this.radioMail.Name = "radioMail";
            this.radioMail.Size = new System.Drawing.Size(67, 17);
            this.radioMail.TabIndex = 10;
            this.radioMail.TabStop = true;
            this.radioMail.Text = "DailyMail";
            this.radioMail.UseVisualStyleBackColor = true;
            // 
            // radioTele
            // 
            this.radioTele.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioTele.AutoSize = true;
            this.radioTele.Location = new System.Drawing.Point(419, 252);
            this.radioTele.Name = "radioTele";
            this.radioTele.Size = new System.Drawing.Size(73, 17);
            this.radioTele.TabIndex = 11;
            this.radioTele.TabStop = true;
            this.radioTele.Text = "Telegraph";
            this.radioTele.UseVisualStyleBackColor = true;
            // 
            // radioInde
            // 
            this.radioInde.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioInde.AutoSize = true;
            this.radioInde.Location = new System.Drawing.Point(501, 252);
            this.radioInde.Name = "radioInde";
            this.radioInde.Size = new System.Drawing.Size(85, 17);
            this.radioInde.TabIndex = 12;
            this.radioInde.TabStop = true;
            this.radioInde.Text = "Independent";
            this.radioInde.UseVisualStyleBackColor = true;
            // 
            // radioGuar
            // 
            this.radioGuar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioGuar.AutoSize = true;
            this.radioGuar.Location = new System.Drawing.Point(592, 252);
            this.radioGuar.Name = "radioGuar";
            this.radioGuar.Size = new System.Drawing.Size(87, 17);
            this.radioGuar.TabIndex = 13;
            this.radioGuar.TabStop = true;
            this.radioGuar.Text = "TheGuardian";
            this.radioGuar.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEkle.BackColor = System.Drawing.Color.Silver;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(346, 275);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(333, 23);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Haber Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtHaber
            // 
            this.txtHaber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHaber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHaber.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtHaber.Location = new System.Drawing.Point(346, 104);
            this.txtHaber.Multiline = true;
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHaber.Size = new System.Drawing.Size(333, 142);
            this.txtHaber.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(346, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Train Et!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTest.BackColor = System.Drawing.Color.Silver;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTest.Location = new System.Drawing.Point(346, 365);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(333, 49);
            this.btnTest.TabIndex = 17;
            this.btnTest.Text = "Test  Et!";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Haber Başlığı Ekleyiniz";
            // 
            // HeadlinesEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 610);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHaber);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.radioGuar);
            this.Controls.Add(this.radioInde);
            this.Controls.Add(this.radioTele);
            this.Controls.Add(this.radioMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelGuar);
            this.Controls.Add(this.panelInde);
            this.Controls.Add(this.panelTele);
            this.Controls.Add(this.panelMail);
            this.Controls.Add(this.panel1);
            this.Name = "HeadlinesEasy";
            this.Text = "HeadlinesEasy";
            this.Load += new System.EventHandler(this.HeadlinesEasy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelMail;
        private System.Windows.Forms.FlowLayoutPanel panelTele;
        private System.Windows.Forms.FlowLayoutPanel panelInde;
        private System.Windows.Forms.FlowLayoutPanel panelGuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioMail;
        private System.Windows.Forms.RadioButton radioTele;
        private System.Windows.Forms.RadioButton radioInde;
        private System.Windows.Forms.RadioButton radioGuar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtHaber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label6;
    }
}