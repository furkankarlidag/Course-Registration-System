using System.Collections.Generic;
using System.Windows.Forms;

namespace Course_Registration_System
{
    partial class studentForm
    {
        List<Panel> subPanels = new List<Panel>();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.surname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.sicilID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.acilanderslerbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.acilanDerslerPanel = new System.Windows.Forms.Panel();
            this.acilanDerslerLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.surname);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.sicilID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(966, 118);
            this.panel1.TabIndex = 0;
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.Color.White;
            this.surname.Location = new System.Drawing.Point(760, 83);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(200, 23);
            this.surname.TabIndex = 4;
            this.surname.Text = "soyisim";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(760, 55);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(215, 23);
            this.name.TabIndex = 3;
            this.name.Text = "isim";
            // 
            // sicilID
            // 
            this.sicilID.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sicilID.ForeColor = System.Drawing.Color.White;
            this.sicilID.Location = new System.Drawing.Point(759, 21);
            this.sicilID.Name = "sicilID";
            this.sicilID.Size = new System.Drawing.Size(201, 34);
            this.sicilID.TabIndex = 2;
            this.sicilID.Text = "sıcıl no";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ PANELİ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.mainPanel.Location = new System.Drawing.Point(190, 124);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(774, 591);
            this.mainPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.acilanderslerbutton);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.messageButton);
            this.panel2.Location = new System.Drawing.Point(-11, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 591);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(23, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "ALINAN DERSLER";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(23, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "DERS SEÇİMİ";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // acilanderslerbutton
            // 
            this.acilanderslerbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.acilanderslerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acilanderslerbutton.Location = new System.Drawing.Point(23, 151);
            this.acilanderslerbutton.Name = "acilanderslerbutton";
            this.acilanderslerbutton.Size = new System.Drawing.Size(158, 39);
            this.acilanderslerbutton.TabIndex = 2;
            this.acilanderslerbutton.Text = "AÇILAN DERSLER";
            this.acilanderslerbutton.UseVisualStyleBackColor = false;
            this.acilanderslerbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "TRANSKRİPT YÜKLEME";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // messageButton
            // 
            this.messageButton.BackColor = System.Drawing.Color.LimeGreen;
            this.messageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageButton.Location = new System.Drawing.Point(23, 21);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(158, 39);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "MESAJLAR";
            this.messageButton.UseVisualStyleBackColor = false;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // acilanDerslerPanel
            // 
            this.acilanDerslerPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.acilanDerslerPanel.Location = new System.Drawing.Point(190, 124);
            this.acilanDerslerPanel.Controls.Add(this.acilanDerslerLabel);
            this.acilanDerslerPanel.Name = "acilanDerslerPanel";
            this.acilanDerslerPanel.Size = new System.Drawing.Size(774, 591);
            this.acilanDerslerPanel.TabIndex = 2;
            this.acilanDerslerPanel.Visible = false;
            // 
            // acilanDerslerLabel
            // 
            this.acilanDerslerLabel.AutoSize = true;
            this.acilanDerslerLabel.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acilanDerslerLabel.Location = new System.Drawing.Point(21, 14);
            
            this.acilanDerslerLabel.Name = "acilanDerslerLabel";
            this.acilanDerslerLabel.Size = new System.Drawing.Size(219, 39);
            this.acilanDerslerLabel.TabIndex = 0;
            this.acilanDerslerLabel.Text = "AÇILAN DERSLER";
            // 
            // messagePanel
            // 
            this.messagePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            
            this.messagePanel.Location = new System.Drawing.Point(190, 124);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(774, 591);
            this.messagePanel.TabIndex = 3;
            this.messagePanel.Visible = false;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(963, 698);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(acilanDerslerPanel);
            this.MaximumSize = new System.Drawing.Size(979, 737);
            this.MinimumSize = new System.Drawing.Size(979, 737);
            this.Name = "studentForm";
            this.Text = "studentForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.messagePanel.ResumeLayout(false);
            this.messagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label sicilID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel acilanDerslerPanel;
        private System.Windows.Forms.Button messageButton;
        private System.Windows.Forms.Panel messagePanel;
        private Button button4;
        private Button button3;
        private Button acilanderslerbutton;
        private Button button1;
        private Label acilanDerslerLabel;
    }
}