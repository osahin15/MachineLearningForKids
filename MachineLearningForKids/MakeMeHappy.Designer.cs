namespace MachineLearningForKids
{
    partial class MakeMeHappy
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
            this.pctureTrain = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblSad = new System.Windows.Forms.Label();
            this.lblHappy = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.rsmTrainBtn = new System.Windows.Forms.Button();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnTest = new System.Windows.Forms.Button();
            this.rsmTestBtn = new System.Windows.Forms.Button();
            this.pctureTest = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pctureTrain)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctureTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pctureTrain
            // 
            this.pctureTrain.Location = new System.Drawing.Point(81, 44);
            this.pctureTrain.Name = "pctureTrain";
            this.pctureTrain.Size = new System.Drawing.Size(195, 142);
            this.pctureTrain.TabIndex = 0;
            this.pctureTrain.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(77)))), ((int)(((byte)(98)))));
            this.metroPanel1.Controls.Add(this.lblSad);
            this.metroPanel1.Controls.Add(this.lblHappy);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.btnTrain);
            this.metroPanel1.Controls.Add(this.rsmTrainBtn);
            this.metroPanel1.Controls.Add(this.pctureTrain);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 106);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(378, 384);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblSad
            // 
            this.lblSad.AutoSize = true;
            this.lblSad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSad.ForeColor = System.Drawing.Color.Maroon;
            this.lblSad.Location = new System.Drawing.Point(177, 295);
            this.lblSad.Name = "lblSad";
            this.lblSad.Size = new System.Drawing.Size(0, 24);
            this.lblSad.TabIndex = 8;
            // 
            // lblHappy
            // 
            this.lblHappy.AutoSize = true;
            this.lblHappy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHappy.ForeColor = System.Drawing.Color.Maroon;
            this.lblHappy.Location = new System.Drawing.Point(177, 254);
            this.lblHappy.Name = "lblHappy";
            this.lblHappy.Size = new System.Drawing.Size(0, 24);
            this.lblHappy.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sad Train Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Happy Train Data:";
            // 
            // btnTrain
            // 
            this.btnTrain.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTrain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Location = new System.Drawing.Point(81, 327);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(195, 31);
            this.btnTrain.TabIndex = 4;
            this.btnTrain.Text = "Train";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // rsmTrainBtn
            // 
            this.rsmTrainBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rsmTrainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rsmTrainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rsmTrainBtn.ForeColor = System.Drawing.Color.White;
            this.rsmTrainBtn.Location = new System.Drawing.Point(81, 204);
            this.rsmTrainBtn.Name = "rsmTrainBtn";
            this.rsmTrainBtn.Size = new System.Drawing.Size(195, 31);
            this.rsmTrainBtn.TabIndex = 3;
            this.rsmTrainBtn.Text = "Resim Ekle";
            this.rsmTrainBtn.UseVisualStyleBackColor = true;
            this.rsmTrainBtn.Click += new System.EventHandler(this.rsmTrainBtn_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.metroPanel2.Controls.Add(this.btnTest);
            this.metroPanel2.Controls.Add(this.rsmTestBtn);
            this.metroPanel2.Controls.Add(this.pctureTest);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(456, 106);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(378, 384);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTest.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(100, 327);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(195, 31);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Learn and Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // rsmTestBtn
            // 
            this.rsmTestBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rsmTestBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rsmTestBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rsmTestBtn.ForeColor = System.Drawing.Color.White;
            this.rsmTestBtn.Location = new System.Drawing.Point(100, 204);
            this.rsmTestBtn.Name = "rsmTestBtn";
            this.rsmTestBtn.Size = new System.Drawing.Size(195, 31);
            this.rsmTestBtn.TabIndex = 4;
            this.rsmTestBtn.Text = "Resim Ekle";
            this.rsmTestBtn.UseVisualStyleBackColor = true;
            this.rsmTestBtn.Click += new System.EventHandler(this.rsmTestBtn_Click);
            // 
            // pctureTest
            // 
            this.pctureTest.Location = new System.Drawing.Point(100, 44);
            this.pctureTest.Name = "pctureTest";
            this.pctureTest.Size = new System.Drawing.Size(195, 142);
            this.pctureTest.TabIndex = 2;
            this.pctureTest.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Train";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(586, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Learn And Test";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(15, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 10);
            this.panel1.TabIndex = 5;
            // 
            // MakeMeHappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "MakeMeHappy";
            this.Resizable = false;
            this.Text = "MakeMeHappy";
            this.Load += new System.EventHandler(this.MakeMeHappy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctureTrain)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctureTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctureTrain;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button rsmTrainBtn;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button rsmTestBtn;
        private System.Windows.Forms.PictureBox pctureTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSad;
        private System.Windows.Forms.Label lblHappy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}