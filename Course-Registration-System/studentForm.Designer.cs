using System;
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
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.acilanderslerbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.acilanDerslerPanel = new System.Windows.Forms.Panel();
            this.acilanDerslerLabel = new System.Windows.Forms.Label();
            this.messagePanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.messageSendPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gelenmesaj = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.acilanDerslerPanel.SuspendLayout();
            this.messagePanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.messageSendPanel.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.surname.Location = new System.Drawing.Point(760, 78);
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
            this.panel2.Controls.Add(this.button2);
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(23, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "MESAJ GONDER";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LimeGreen;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(23, 368);
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
            this.button3.Location = new System.Drawing.Point(23, 302);
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
            this.acilanderslerbutton.Location = new System.Drawing.Point(23, 235);
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
            this.button1.Location = new System.Drawing.Point(23, 160);
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
            this.messageButton.Location = new System.Drawing.Point(23, 14);
            this.messageButton.Name = "messageButton";
            this.messageButton.Size = new System.Drawing.Size(158, 53);
            this.messageButton.TabIndex = 0;
            this.messageButton.Text = "GELEN MESAJLAR";
            this.messageButton.UseVisualStyleBackColor = false;
            this.messageButton.Click += new System.EventHandler(this.messageButton_Click);
            // 
            // acilanDerslerPanel
            // 
            this.acilanDerslerPanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.acilanDerslerPanel.Controls.Add(this.acilanDerslerLabel);
            this.acilanDerslerPanel.Location = new System.Drawing.Point(190, 124);
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
            this.messagePanel.Controls.Add(this.gelenmesaj);
            this.messagePanel.Controls.Add(this.label7);
            this.messagePanel.Location = new System.Drawing.Point(190, 124);
            this.messagePanel.Name = "messagePanel";
            this.messagePanel.Size = new System.Drawing.Size(774, 591);
            this.messagePanel.TabIndex = 3;
            this.messagePanel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.ForestGreen;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(23, 23);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(670, 99);
            this.panel5.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(646, 63);
            this.label6.TabIndex = 1;
            this.label6.Text = "MESAJ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "ALICI:";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.SeaGreen;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(19, 255);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 307);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 80);
            this.label4.TabIndex = 2;
            this.label4.Text = "GONDERILEN MESAJLAR";
            // 
            // messageSendPanel
            // 
            this.messageSendPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.messageSendPanel.Controls.Add(this.panel3);
            this.messageSendPanel.Controls.Add(this.panel4);
            this.messageSendPanel.Controls.Add(this.label2);
            this.messageSendPanel.Controls.Add(this.label4);
            this.messageSendPanel.Location = new System.Drawing.Point(190, 124);
            this.messageSendPanel.Name = "messageSendPanel";
            this.messageSendPanel.Size = new System.Drawing.Size(774, 591);
            this.messageSendPanel.TabIndex = 4;
            this.messageSendPanel.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(19, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(727, 145);
            this.panel3.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(593, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 26);
            this.button5.TabIndex = 3;
            this.button5.Text = "GONDER";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(23, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(680, 63);
            this.textBox1.TabIndex = 2;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Mesajinizi buraya giriniz!.";
            this.textBox1.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            this.textBox1.LostFocus += new System.EventHandler(this.textBox1_LostFocus);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(365, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "ALICI:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 80);
            this.label2.TabIndex = 2;
            this.label2.Text = "MESAJ GÖNDER";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 39);
            this.label7.TabIndex = 2;
            this.label7.Text = "GELEN MESAJLAR";
            // 
            // gelenmesaj
            // 
            this.gelenmesaj.AutoScroll = true;
            this.gelenmesaj.BackColor = System.Drawing.Color.Green;
            this.gelenmesaj.Location = new System.Drawing.Point(22, 72);
            this.gelenmesaj.Name = "gelenmesaj";
            this.gelenmesaj.Size = new System.Drawing.Size(724, 490);
            this.gelenmesaj.TabIndex = 3;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(963, 698);
            this.Controls.Add(this.messagePanel);
            this.Controls.Add(this.messageSendPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.acilanDerslerPanel);
            this.MaximumSize = new System.Drawing.Size(979, 737);
            this.MinimumSize = new System.Drawing.Size(979, 737);
            this.Name = "studentForm";
            this.Text = "studentForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.acilanDerslerPanel.ResumeLayout(false);
            this.acilanDerslerPanel.PerformLayout();
            this.messagePanel.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.messageSendPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Panel messageSendPanel;
        private Button button4;
        private Button button3;
        private Button acilanderslerbutton;
        private Button button1;
        private Label acilanDerslerLabel;
        private Label label2;
        private Button button2;
        private Panel panel3;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Button button5;
        private Label label4;
        private Panel panel4;
        private Panel panel5;
        private Label label6;
        private Label label5;
        private Panel gelenmesaj;
        private Label label7;
    }
}