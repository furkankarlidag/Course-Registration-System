using System;

namespace Course_Registration_System
{
    partial class scanPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scanPDF));
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadPDF = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.pathNAme = new System.Windows.Forms.Label();
            this.DOSYAYOLU = new System.Windows.Forms.Label();
            this.transkriptBilgi = new System.Windows.Forms.Label();
            this.idNo = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.BackColor = System.Drawing.Color.White;
            this.chooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chooseFileButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.chooseFileButton.Location = new System.Drawing.Point(436, 10);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(187, 35);
            this.chooseFileButton.TabIndex = 4;
            this.chooseFileButton.Text = "PDF SEC";
            this.chooseFileButton.UseVisualStyleBackColor = false;
            this.chooseFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.header);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.idNo);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 88);
            this.panel1.TabIndex = 5;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(161, 27);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(297, 37);
            this.header.TabIndex = 0;
            this.header.Text = "TRANSKRİPT YÜKLEME";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadPDF
            // 
            this.loadPDF.BackColor = System.Drawing.Color.White;
            this.loadPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loadPDF.ForeColor = System.Drawing.Color.DarkGreen;
            this.loadPDF.Location = new System.Drawing.Point(355, 16);
            this.loadPDF.Name = "loadPDF";
            this.loadPDF.Size = new System.Drawing.Size(264, 40);
            this.loadPDF.TabIndex = 4;
            this.loadPDF.Text = "TRANSKRIPT YUKLE";
            this.loadPDF.UseVisualStyleBackColor = false;
            this.loadPDF.Click += new System.EventHandler(this.loadPDF_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Red;
            this.infoLabel.Location = new System.Drawing.Point(8, 218);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(643, 47);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "***Lutfen once PDF secip daha sonra TRANSKRIPT YUKLE butonuna basiniz!";
            // 
            // pathNAme
            // 
            this.pathNAme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathNAme.Location = new System.Drawing.Point(12, 12);
            this.pathNAme.Name = "pathNAme";
            this.pathNAme.Size = new System.Drawing.Size(221, 23);
            this.pathNAme.TabIndex = 7;
            this.pathNAme.Text = "SECILEN DOSYA YOLU:";
            // 
            // DOSYAYOLU
            // 
            this.DOSYAYOLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOSYAYOLU.ForeColor = System.Drawing.Color.IndianRed;
            this.DOSYAYOLU.Location = new System.Drawing.Point(13, 48);
            this.DOSYAYOLU.Name = "DOSYAYOLU";
            this.DOSYAYOLU.Size = new System.Drawing.Size(622, 20);
            this.DOSYAYOLU.TabIndex = 8;
            this.DOSYAYOLU.Text = "**Henuz bir dosya secmediniz.";
            // 
            // transkriptBilgi
            // 
            this.transkriptBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transkriptBilgi.ForeColor = System.Drawing.Color.IndianRed;
            this.transkriptBilgi.Location = new System.Drawing.Point(8, 76);
            this.transkriptBilgi.Name = "transkriptBilgi";
            this.transkriptBilgi.Size = new System.Drawing.Size(356, 20);
            this.transkriptBilgi.TabIndex = 9;
            this.transkriptBilgi.Text = "Lutfen Transkriptinizi sisteme yukleyiniz.";
            // 
            // idNo
            // 
            this.idNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNo.ForeColor = System.Drawing.Color.MediumBlue;
            this.idNo.Location = new System.Drawing.Point(499, 20);
            this.idNo.Name = "idNo";
            this.idNo.Size = new System.Drawing.Size(116, 20);
            this.idNo.TabIndex = 11;
            this.idNo.Text = "idno";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.nameLabel.Location = new System.Drawing.Point(499, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(150, 24);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "TRANSKRIPT DURUMU:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.pathNAme);
            this.panel2.Controls.Add(this.DOSYAYOLU);
            this.panel2.Controls.Add(this.chooseFileButton);
            this.panel2.Location = new System.Drawing.Point(9, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 78);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.loadPDF);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.transkriptBilgi);
            this.panel3.Location = new System.Drawing.Point(13, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 117);
            this.panel3.TabIndex = 16;
            // 
            // scanPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(659, 413);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(675, 452);
            this.MinimumSize = new System.Drawing.Size(675, 452);
            this.Name = "scanPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogrenci Transkript Yukleme";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button loadPDF;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label pathNAme;
        private System.Windows.Forms.Label DOSYAYOLU;
        private System.Windows.Forms.Label transkriptBilgi;
        private System.Windows.Forms.Label idNo;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}