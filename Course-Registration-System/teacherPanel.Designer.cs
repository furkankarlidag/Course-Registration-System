using System.Windows.Forms;

namespace Course_Registration_System
{
    partial class teacherPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherPanel));
            this.teacherInterestbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.teacherLessonRequestbutton = new System.Windows.Forms.Button();
            this.teacherGradingButton = new System.Windows.Forms.Button();
            this.teacherStudentbutton = new System.Windows.Forms.Button();
            this.teacherMessagesButton = new System.Windows.Forms.Button();
            this.teacherInterestPanel = new System.Windows.Forms.Panel();
            this.teacherInterstAdd = new System.Windows.Forms.Label();
            this.teacherInterstAddTextBox = new System.Windows.Forms.TextBox();
            this.TeacherInterestAddButton = new System.Windows.Forms.Button();
            this.teacherLessonRequestPanel = new System.Windows.Forms.Panel();
            this.teacherGradingPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.teacherMessagePanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.teacherStudentPanel = new System.Windows.Forms.Panel();
            this.idnolabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.teacherInterestPanel.SuspendLayout();
            this.teacherGradingPanel.SuspendLayout();
            this.teacherMessagePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherInterestbutton
            // 
            this.teacherInterestbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherInterestbutton.Location = new System.Drawing.Point(13, 173);
            this.teacherInterestbutton.Name = "teacherInterestbutton";
            this.teacherInterestbutton.Size = new System.Drawing.Size(181, 41);
            this.teacherInterestbutton.TabIndex = 0;
            this.teacherInterestbutton.Text = "İlgi Alanı";
            this.teacherInterestbutton.UseVisualStyleBackColor = true;
            this.teacherInterestbutton.Click += new System.EventHandler(this.teacherInterestbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // teacherLessonRequestbutton
            // 
            this.teacherLessonRequestbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherLessonRequestbutton.Location = new System.Drawing.Point(13, 220);
            this.teacherLessonRequestbutton.Name = "teacherLessonRequestbutton";
            this.teacherLessonRequestbutton.Size = new System.Drawing.Size(181, 41);
            this.teacherLessonRequestbutton.TabIndex = 2;
            this.teacherLessonRequestbutton.Text = "Ders Talepleri";
            this.teacherLessonRequestbutton.UseVisualStyleBackColor = true;
            this.teacherLessonRequestbutton.Click += new System.EventHandler(this.teacherLessonRequestbutton_Click);
            // 
            // teacherGradingButton
            // 
            this.teacherGradingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherGradingButton.Location = new System.Drawing.Point(13, 267);
            this.teacherGradingButton.Name = "teacherGradingButton";
            this.teacherGradingButton.Size = new System.Drawing.Size(181, 41);
            this.teacherGradingButton.TabIndex = 4;
            this.teacherGradingButton.Text = "Puanlama";
            this.teacherGradingButton.UseVisualStyleBackColor = true;
            this.teacherGradingButton.Click += new System.EventHandler(this.teacherGradingButton_Click);
            // 
            // teacherStudentbutton
            // 
            this.teacherStudentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherStudentbutton.Location = new System.Drawing.Point(13, 314);
            this.teacherStudentbutton.Name = "teacherStudentbutton";
            this.teacherStudentbutton.Size = new System.Drawing.Size(181, 41);
            this.teacherStudentbutton.TabIndex = 5;
            this.teacherStudentbutton.Text = "Öğrenci Durumu";
            this.teacherStudentbutton.UseVisualStyleBackColor = true;
            this.teacherStudentbutton.Click += new System.EventHandler(this.teacherStudentbutton_Click);
            // 
            // teacherMessagesButton
            // 
            this.teacherMessagesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherMessagesButton.Location = new System.Drawing.Point(12, 361);
            this.teacherMessagesButton.Name = "teacherMessagesButton";
            this.teacherMessagesButton.Size = new System.Drawing.Size(181, 41);
            this.teacherMessagesButton.TabIndex = 6;
            this.teacherMessagesButton.Text = "Mesajlaşma";
            this.teacherMessagesButton.UseVisualStyleBackColor = true;
            this.teacherMessagesButton.Click += new System.EventHandler(this.teacherMessagesButton_Click);
            // 
            // teacherInterestPanel
            // 
            this.teacherInterestPanel.Controls.Add(this.teacherInterstAdd);
            this.teacherInterestPanel.Controls.Add(this.teacherInterstAddTextBox);
            this.teacherInterestPanel.Controls.Add(this.TeacherInterestAddButton);
            this.teacherInterestPanel.Location = new System.Drawing.Point(200, 173);
            this.teacherInterestPanel.Name = "teacherInterestPanel";
            this.teacherInterestPanel.Size = new System.Drawing.Size(972, 576);
            this.teacherInterestPanel.TabIndex = 7;
            this.teacherInterestPanel.Visible = false;
            // 
            // teacherInterstAdd
            // 
            this.teacherInterstAdd.AutoSize = true;
            this.teacherInterstAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherInterstAdd.Location = new System.Drawing.Point(395, 29);
            this.teacherInterstAdd.Name = "teacherInterstAdd";
            this.teacherInterstAdd.Size = new System.Drawing.Size(130, 25);
            this.teacherInterstAdd.TabIndex = 53;
            this.teacherInterstAdd.Text = "İlgi Alanları";
            // 
            // teacherInterstAddTextBox
            // 
            this.teacherInterstAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherInterstAddTextBox.Location = new System.Drawing.Point(377, 79);
            this.teacherInterstAddTextBox.Name = "teacherInterstAddTextBox";
            this.teacherInterstAddTextBox.Size = new System.Drawing.Size(175, 31);
            this.teacherInterstAddTextBox.TabIndex = 54;
            // 
            // TeacherInterestAddButton
            // 
            this.TeacherInterestAddButton.BackColor = System.Drawing.Color.LightGreen;
            this.TeacherInterestAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.TeacherInterestAddButton.FlatAppearance.BorderSize = 2;
            this.TeacherInterestAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.TeacherInterestAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherInterestAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TeacherInterestAddButton.Location = new System.Drawing.Point(377, 132);
            this.TeacherInterestAddButton.Name = "TeacherInterestAddButton";
            this.TeacherInterestAddButton.Size = new System.Drawing.Size(175, 50);
            this.TeacherInterestAddButton.TabIndex = 52;
            this.TeacherInterestAddButton.Text = "Ekle";
            this.TeacherInterestAddButton.UseVisualStyleBackColor = false;
            this.TeacherInterestAddButton.Click += new System.EventHandler(this.TeacherInterestAddButton_Click);
            // 
            // teacherLessonRequestPanel
            // 
            this.teacherLessonRequestPanel.AutoScroll = true;
            this.teacherLessonRequestPanel.Location = new System.Drawing.Point(200, 173);
            this.teacherLessonRequestPanel.Name = "teacherLessonRequestPanel";
            this.teacherLessonRequestPanel.Size = new System.Drawing.Size(972, 576);
            this.teacherLessonRequestPanel.TabIndex = 7;
            this.teacherLessonRequestPanel.Visible = false;
            // 
            // teacherGradingPanel
            // 
            this.teacherGradingPanel.AutoScroll = true;
            this.teacherGradingPanel.Controls.Add(this.button2);
            this.teacherGradingPanel.Controls.Add(this.button1);
            this.teacherGradingPanel.Location = new System.Drawing.Point(200, 173);
            this.teacherGradingPanel.Name = "teacherGradingPanel";
            this.teacherGradingPanel.Size = new System.Drawing.Size(972, 576);
            this.teacherGradingPanel.TabIndex = 7;
            this.teacherGradingPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(254, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(71, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // teacherMessagePanel
            // 
            this.teacherMessagePanel.Controls.Add(this.panel2);
            this.teacherMessagePanel.Controls.Add(this.label4);
            this.teacherMessagePanel.Controls.Add(this.panel1);
            this.teacherMessagePanel.Controls.Add(this.label1);
            this.teacherMessagePanel.Location = new System.Drawing.Point(200, 174);
            this.teacherMessagePanel.Name = "teacherMessagePanel";
            this.teacherMessagePanel.Size = new System.Drawing.Size(972, 575);
            this.teacherMessagePanel.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Location = new System.Drawing.Point(9, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 317);
            this.panel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "GELEN MESAJLAR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 135);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(723, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "GÖNDER";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "ALICI:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(664, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(21, 35);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 83);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Mesajinizi buraya giriniz!.";
            this.textBox1.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            this.textBox1.LostFocus += new System.EventHandler(this.textBox1_LostFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "MESAJ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "MESAJ GÖNDER";
            // 
            // teacherStudentPanel
            // 
            this.teacherStudentPanel.Location = new System.Drawing.Point(200, 174);
            this.teacherStudentPanel.Name = "teacherStudentPanel";
            this.teacherStudentPanel.Size = new System.Drawing.Size(972, 575);
            this.teacherStudentPanel.TabIndex = 7;
            // 
            // idnolabel
            // 
            this.idnolabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idnolabel.Location = new System.Drawing.Point(902, 32);
            this.idnolabel.Name = "idnolabel";
            this.idnolabel.Size = new System.Drawing.Size(254, 33);
            this.idnolabel.TabIndex = 9;
            this.idnolabel.Text = teacherId.ToString();
            // 
            // namelabel
            // 
            this.namelabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(902, 65);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(240, 33);
            this.namelabel.TabIndex = 11;
            this.namelabel.Text = teacherNameSurname;
            // 
            // teacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.idnolabel);
            this.Controls.Add(this.teacherStudentPanel);
            this.Controls.Add(this.teacherMessagesButton);
            this.Controls.Add(this.teacherStudentbutton);
            this.Controls.Add(this.teacherGradingButton);
            this.Controls.Add(this.teacherLessonRequestbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.teacherInterestbutton);
            this.Controls.Add(this.teacherMessagePanel);
            this.Controls.Add(this.teacherInterestPanel);
            this.Controls.Add(this.teacherLessonRequestPanel);
            this.Controls.Add(this.teacherGradingPanel);
            this.Name = "teacherPanel";
            this.Text = "teacherPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.teacherInterestPanel.ResumeLayout(false);
            this.teacherInterestPanel.PerformLayout();
            this.teacherGradingPanel.ResumeLayout(false);
            this.teacherMessagePanel.ResumeLayout(false);
            this.teacherMessagePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        

        #endregion

        private System.Windows.Forms.Button teacherInterestbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button teacherLessonRequestbutton;
        private System.Windows.Forms.Button teacherGradingButton;
        private System.Windows.Forms.Button teacherStudentbutton;
        private System.Windows.Forms.Button teacherMessagesButton;
        private System.Windows.Forms.Panel teacherInterestPanel;
        private System.Windows.Forms.Label teacherInterstAdd;
        private System.Windows.Forms.TextBox teacherInterstAddTextBox;
        private System.Windows.Forms.Button TeacherInterestAddButton;
        private System.Windows.Forms.Panel teacherLessonRequestPanel;
        private System.Windows.Forms.Panel teacherGradingPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel teacherStudentPanel;
        private System.Windows.Forms.Panel teacherMessagePanel;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private Button button3;
        private Panel panel2;
        private Label label4;
        private Label idnolabel;
        private Label namelabel;
        //private System.Windows.Forms.Button ekleButton;
        //private System.Windows.Forms.Label dersAdıLabel;
        //private System.Windows.Forms.Label dersSayısıLabel;
        //private System.Windows.Forms.Label ortalamaLabel;
        //private System.Windows.Forms.Label adLabel;
        //private System.Windows.Forms.Label sicilNoLabel;
        //private System.Windows.Forms.Label dersAdıLabelDgm;
        //private System.Windows.Forms.DataGridView dataGridView2;
        //private System.Windows.Forms.Label teacherQuotaLabel;
        //private System.Windows.Forms.Label dersSayısıLabelDgm;
        //private System.Windows.Forms.Label OrtalamaLabelDgm;
        //private System.Windows.Forms.Label adLabelDgm;
        //private System.Windows.Forms.Label sicilNoLabelDgm;
        //private System.Windows.Forms.DataGridView dataGridView1;
        //private System.Windows.Forms.Panel panel1;
        // private System.Windows.Forms.Label lessonRequestLessonNameLabel;
        // private System.Windows.Forms.Button lessonRequestDeclineButton;
        //private System.Windows.Forms.Button lessonRequestAcceptButton;
        //private System.Windows.Forms.LinkLabel lessonRequestStudentNameLabel;
    }
}