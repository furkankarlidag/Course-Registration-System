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
            this.label1 = new System.Windows.Forms.Label();
            this.idNo = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.BackColor = System.Drawing.Color.White;
            this.chooseFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chooseFileButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.chooseFileButton.Location = new System.Drawing.Point(12, 93);
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
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 88);
            this.panel1.TabIndex = 5;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(170, 26);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(409, 49);
            this.header.TabIndex = 0;
            this.header.Text = "ÖĞRENCİ PDF YÜKLEME PANELİ";
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
            this.loadPDF.Location = new System.Drawing.Point(12, 229);
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
            this.infoLabel.Location = new System.Drawing.Point(20, 370);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(643, 47);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "***Lutfen once PDF secip daha sonra TRANSKRIPT YUKLE butonuna basiniz!";
            // 
            // pathNAme
            // 
            this.pathNAme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathNAme.Location = new System.Drawing.Point(8, 131);
            this.pathNAme.Name = "pathNAme";
            this.pathNAme.Size = new System.Drawing.Size(221, 23);
            this.pathNAme.TabIndex = 7;
            this.pathNAme.Text = "SECILEN DOSYA YOLU:";
            // 
            // DOSYAYOLU
            // 
            this.DOSYAYOLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOSYAYOLU.ForeColor = System.Drawing.Color.Red;
            this.DOSYAYOLU.Location = new System.Drawing.Point(9, 154);
            this.DOSYAYOLU.Name = "DOSYAYOLU";
            this.DOSYAYOLU.Size = new System.Drawing.Size(639, 38);
            this.DOSYAYOLU.TabIndex = 8;
            this.DOSYAYOLU.Text = "Henuz bir dosya secmediniz.";
            // 
            // transkriptBilgi
            // 
            this.transkriptBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transkriptBilgi.ForeColor = System.Drawing.Color.Black;
            this.transkriptBilgi.Location = new System.Drawing.Point(212, 291);
            this.transkriptBilgi.Name = "transkriptBilgi";
            this.transkriptBilgi.Size = new System.Drawing.Size(356, 34);
            this.transkriptBilgi.TabIndex = 9;
            this.transkriptBilgi.Text = "Lutfen Transkriptinizi sisteme yukleyiniz.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(408, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ogrenci Bilgileri:";
            // 
            // idNo
            // 
            this.idNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNo.ForeColor = System.Drawing.Color.MediumBlue;
            this.idNo.Location = new System.Drawing.Point(408, 114);
            this.idNo.Name = "idNo";
            this.idNo.Size = new System.Drawing.Size(97, 20);
            this.idNo.TabIndex = 11;
            this.idNo.Text = "idno";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.nameLabel.Location = new System.Drawing.Point(408, 134);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(134, 24);
            this.nameLabel.TabIndex = 12;
            this.nameLabel.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "TRANSKRIPT DURUMU:";
            // 
            // scanPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(659, 413);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transkriptBilgi);
            this.Controls.Add(this.DOSYAYOLU);
            this.Controls.Add(this.pathNAme);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.loadPDF);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chooseFileButton);
            this.MaximumSize = new System.Drawing.Size(675, 452);
            this.MinimumSize = new System.Drawing.Size(675, 452);
            this.Name = "scanPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogrenci Transkript Yukleme";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idNo;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label2;
    }
}