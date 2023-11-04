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
            this.teacherStudentPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.teacherInterestPanel.SuspendLayout();
            this.teacherGradingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // teacherInterestbutton
            // 
            this.teacherInterestbutton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.teacherLessonRequestbutton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.teacherGradingButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.teacherStudentbutton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.teacherMessagesButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherMessagesButton.Location = new System.Drawing.Point(12, 361);
            this.teacherMessagesButton.Name = "teacherMessagesButton";
            this.teacherMessagesButton.Size = new System.Drawing.Size(181, 41);
            this.teacherMessagesButton.TabIndex = 6;
            this.teacherMessagesButton.Text = "Mesajlaşma";
            this.teacherMessagesButton.UseVisualStyleBackColor = true;
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
            this.teacherInterstAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherInterstAdd.Location = new System.Drawing.Point(395, 29);
            this.teacherInterstAdd.Name = "teacherInterstAdd";
            this.teacherInterstAdd.Size = new System.Drawing.Size(136, 29);
            this.teacherInterstAdd.TabIndex = 53;
            this.teacherInterstAdd.Text = "İlgi Alanları";
            // 
            // teacherInterstAddTextBox
            // 
            this.teacherInterstAddTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherInterstAddTextBox.Location = new System.Drawing.Point(377, 79);
            this.teacherInterstAddTextBox.Name = "teacherInterstAddTextBox";
            this.teacherInterstAddTextBox.Size = new System.Drawing.Size(175, 33);
            this.teacherInterstAddTextBox.TabIndex = 54;
            // 
            // TeacherInterestAddButton
            // 
            this.TeacherInterestAddButton.BackColor = System.Drawing.Color.LightGreen;
            this.TeacherInterestAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.TeacherInterestAddButton.FlatAppearance.BorderSize = 2;
            this.TeacherInterestAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.TeacherInterestAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TeacherInterestAddButton.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.button2.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
            this.button1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(71, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            teacherStudentPanel.Location = new System.Drawing.Point(200, 174);
            teacherStudentPanel.Name = "teacherStudentPanel";
            teacherStudentPanel.Size = new System.Drawing.Size(972, 575);
            teacherStudentPanel.TabIndex = 7;
            // 
            // teacherPanel
            // 


            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.teacherStudentPanel);
            this.Controls.Add(this.teacherMessagesButton);
            this.Controls.Add(this.teacherStudentbutton);
            this.Controls.Add(this.teacherGradingButton);
            this.Controls.Add(this.teacherLessonRequestbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.teacherInterestbutton);
            this.Name = "teacherPanel";
            this.Text = "teacherPanel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.teacherInterestPanel.ResumeLayout(false);
            this.teacherInterestPanel.PerformLayout();
            this.teacherGradingPanel.ResumeLayout(false);
            this.teacherStudentPanel.ResumeLayout(false);
            this.teacherStudentPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        //this.Controls.Add(this.teacherInterestPanel);
        //this.Controls.Add(this.teacherLessonRequestPanel);
        //this.Controls.Add(this.teacherGradingPanel);

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