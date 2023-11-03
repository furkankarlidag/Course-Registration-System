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
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.acilanderslerbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.messageButton = new System.Windows.Forms.Button();
            this.acilanDerslerPanel = new System.Windows.Forms.Panel();
            this.acilanDerslerLabel = new System.Windows.Forms.Label();
            this.denemePanel = new System.Windows.Forms.Panel();
            this.filterButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.interestsComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.requestPanel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.choosingPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gelenmesaj = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
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
            this.comingMessagePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.acilanDerslerPanel.SuspendLayout();
            this.denemePanel.SuspendLayout();
            this.requestPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.choosingPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.messageSendPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.comingMessagePanel.SuspendLayout();
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
            this.surname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.Color.White;
            this.surname.Location = new System.Drawing.Point(787, 78);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(200, 23);
            this.surname.TabIndex = 4;
            this.surname.Text = "soyisim";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(787, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(215, 23);
            this.name.TabIndex = 3;
            this.name.Text = "isim";
            // 
            // sicilID
            // 
            this.sicilID.BackColor = System.Drawing.Color.Transparent;
            this.sicilID.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sicilID.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sicilID.Location = new System.Drawing.Point(786, 19);
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
            this.panel2.Controls.Add(this.button7);
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(23, 435);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(158, 39);
            this.button7.TabIndex = 6;
            this.button7.Text = "ALINAN DERSLER";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            this.button4.Text = "TALEPLER";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // denemePanel
            // 
            this.denemePanel.AutoScroll = true;
            this.denemePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.denemePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            // this.denemePanel.Controls.Add(this.filterButton);
            //this.denemePanel.Controls.Add(this.label15);
            //this.denemePanel.Controls.Add(this.interestsComboBox);
            this.denemePanel.Controls.Add(this.label14);
            //this.denemePanel.Controls.Add(this.panel6);
            this.denemePanel.Location = new System.Drawing.Point(190, 124);
            this.denemePanel.Name = "denemePanel";
            this.denemePanel.Size = new System.Drawing.Size(774, 591);
            this.denemePanel.TabIndex = 3;
            this.denemePanel.Visible = false;
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterButton.Location = new System.Drawing.Point(647, 54);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(99, 26);
            this.filterButton.TabIndex = 6;
            this.filterButton.Text = "FILTRELE";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(383, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 19);
            this.label15.TabIndex = 5;
            this.label15.Text = "Ilgi Alani Seciniz:";
            // 
            // interestsComboBox
            // 
            this.interestsComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.interestsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.interestsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestsComboBox.FormattingEnabled = true;
            this.interestsComboBox.Location = new System.Drawing.Point(519, 27);
            this.interestsComboBox.Name = "interestsComboBox";
            this.interestsComboBox.Size = new System.Drawing.Size(227, 24);
            this.interestsComboBox.TabIndex = 0;

            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(15, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(377, 45);
            this.label14.TabIndex = 2;
            this.label14.Text = "ALINAN DERSLER";
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Location = new System.Drawing.Point(17, 86);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(729, 214);
            this.panel6.TabIndex = 3;
            // 
            // requestPanel
            // 
            this.requestPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.requestPanel.Controls.Add(this.panel8);
            this.requestPanel.Controls.Add(this.label13);
            this.requestPanel.Location = new System.Drawing.Point(190, 124);
            this.requestPanel.Name = "requestPanel";
            this.requestPanel.Size = new System.Drawing.Size(774, 591);
            this.requestPanel.TabIndex = 3;
            this.requestPanel.Visible = false;
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.Location = new System.Drawing.Point(19, 72);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(742, 487);
            this.panel8.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(10, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(377, 39);
            this.label13.TabIndex = 2;
            this.label13.Text = "TALEPLER";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "HOCA VE DERS SECIMI";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.Controls.Add(this.button6);
            this.panel7.Controls.Add(this.comboBox3);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.comboBox2);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Location = new System.Drawing.Point(19, 346);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(727, 177);
            this.panel7.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(456, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(181, 52);
            this.button6.TabIndex = 4;
            this.button6.Text = "DERS SECIMINI TAMAMLA";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(266, 65);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(371, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(17, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(243, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "Alacağınız Dersi Seçiniz:";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(329, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(308, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(305, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "Dersi Veren Öğretim Görevlisi:\r\n";
            // 
            // choosingPanel
            // 
            this.choosingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.choosingPanel.Controls.Add(this.label9);
            this.choosingPanel.Controls.Add(this.panel7);
            this.choosingPanel.Controls.Add(this.label10);
            this.choosingPanel.Controls.Add(this.label8);
            this.choosingPanel.Controls.Add(this.filterButton);
            this.choosingPanel.Controls.Add(this.label15);
            this.choosingPanel.Controls.Add(this.interestsComboBox);

            this.choosingPanel.Controls.Add(this.panel6);
            this.choosingPanel.Location = new System.Drawing.Point(190, 124);
            this.choosingPanel.Name = "choosingPanel";
            this.choosingPanel.Size = new System.Drawing.Size(774, 591);
            this.choosingPanel.TabIndex = 3;
            this.choosingPanel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Ders Veren Hocalar ve Ilgi Alanlari";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(10, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(377, 39);
            this.label8.TabIndex = 2;
            this.label8.Text = "DERS SEÇİMİ";
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
            // comingMessagePanel
            // 
            this.comingMessagePanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.comingMessagePanel.Controls.Add(this.gelenmesaj);
            this.comingMessagePanel.Controls.Add(this.label7);
            this.comingMessagePanel.Location = new System.Drawing.Point(190, 124);
            this.comingMessagePanel.Name = "comingMessagePanel";
            this.comingMessagePanel.Size = new System.Drawing.Size(774, 591);
            this.comingMessagePanel.TabIndex = 3;
            this.comingMessagePanel.Visible = false;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(963, 698);
            this.Controls.Add(this.denemePanel);
            this.Controls.Add(this.messageSendPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.acilanDerslerPanel);
            this.Controls.Add(this.comingMessagePanel);
            this.Controls.Add(this.choosingPanel);
            this.Controls.Add(this.requestPanel);
            this.MaximumSize = new System.Drawing.Size(979, 737);
            this.MinimumSize = new System.Drawing.Size(979, 737);
            this.Name = "studentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KOU Ogrenci Paneli";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.acilanDerslerPanel.ResumeLayout(false);
            this.acilanDerslerPanel.PerformLayout();
            this.denemePanel.ResumeLayout(false);
            this.denemePanel.PerformLayout();
            this.requestPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.choosingPanel.ResumeLayout(false);
            this.choosingPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.messageSendPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.comingMessagePanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel denemePanel;
        private System.Windows.Forms.Panel requestPanel;
        private System.Windows.Forms.Panel choosingPanel;
        private System.Windows.Forms.Panel comingMessagePanel;
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
        private Label label8;
        private Panel panel6;
        private Label label10;
        private Label label9;
        private Panel panel7;
        private Label label12;
        private ComboBox comboBox2;
        private Label label11;
        private Button button6;
        private ComboBox comboBox3;
        private Button button7;
        private Panel panel8;
        private Label label13;
        private Label label14;
        private Button filterButton;
        private Label label15;
        private ComboBox interestsComboBox;
    }
}