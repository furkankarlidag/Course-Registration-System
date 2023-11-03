using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_System
{
    public partial class teacherPanel : Form
    {
        string teacherNameSurname;
        int teacherId;
        SQLCommands sQLCommands = new SQLCommands();
        public teacherPanel(int id)
        {
            teacherNameSurname= sQLCommands.getInfoAboutTeacher(id);
            teacherId = id; 
            InitializeComponent();
        }

        void ShowPanel(Panel panel)
        {
            teacherInterestPanel.Visible = false;
            teacherLessonRequestPanel.Visible= false;

            panel.Visible = true;
        }

        private void TeacherInterestAddButton_Click(object sender, EventArgs e)
        {
            ShowPanel(teacherInterestPanel);

            sQLCommands.updateData("teachers_interest_table", "interests", "sicilno", teacherId.ToString(), teacherInterstAddTextBox.Text);


        }

        private void teacherLessonRequestbutton_Click(object sender, EventArgs e)
        {
            ShowPanel(teacherLessonRequestPanel);
            int teacherRequestCount = sQLCommands.garipCount("*", "request_table", "status", "Bekliyor", "receiptid", teacherId.ToString());
            DataTable dataTable= sQLCommands.showTwoQueryDataTable("*", "request_table", "status", "Bekliyor","receiptid",teacherId.ToString());
            int num = 24;
            int i = 1;

            if(teacherRequestCount > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string name;
                    string surname;
                    string lessonName;
                    DataTable data = sQLCommands.showQueryDataTable("name,surname", "users", "sicilno", row["senderid"].ToString());
                    DataTable data2 = sQLCommands.showQueryDataTable("dersisim", "acilandersler", "dersid", row["dersid"].ToString());
                    DataRow row2 = data.Rows[0];
                    DataRow row1 = data2.Rows[0];
                    name= row2["name"].ToString();
                    surname = row2["surname"].ToString();
                    lessonName = row1["dersisim"].ToString();
                    System.Windows.Forms.Panel panel1;
                    System.Windows.Forms.Label lessonRequestLessonNameLabel;
                    System.Windows.Forms.Button lessonRequestDeclineButton;
                    System.Windows.Forms.Button lessonRequestAcceptButton;
                    System.Windows.Forms.LinkLabel lessonRequestStudentNameLabel;
                    panel1 = new System.Windows.Forms.Panel();
                    lessonRequestDeclineButton = new System.Windows.Forms.Button();
                    lessonRequestAcceptButton = new System.Windows.Forms.Button();
                    lessonRequestLessonNameLabel = new System.Windows.Forms.Label();
                    lessonRequestStudentNameLabel = new System.Windows.Forms.LinkLabel();

                    // 
                    // panel1
                    // 
                    panel1.BackColor = System.Drawing.Color.Aquamarine;
                    panel1.Controls.Add(lessonRequestDeclineButton);
                    panel1.Controls.Add(lessonRequestAcceptButton);
                    panel1.Controls.Add(lessonRequestLessonNameLabel);
                    panel1.Controls.Add(lessonRequestStudentNameLabel);
                    panel1.Cursor = System.Windows.Forms.Cursors.Default;
                    panel1.Location = new System.Drawing.Point(24, num*i);
                    panel1.Name = "panel1";
                    panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
                    panel1.Size = new System.Drawing.Size(900, 64);
                    panel1.TabIndex = 0;
                    // 
                    // lessonRequestDeclineButton
                    // 
                    lessonRequestDeclineButton.BackColor = System.Drawing.Color.Red;
                    lessonRequestDeclineButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    lessonRequestDeclineButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    lessonRequestDeclineButton.Location = new System.Drawing.Point(786, 13);
                    lessonRequestDeclineButton.Name = "lessonRequestDeclineButton";
                    lessonRequestDeclineButton.Size = new System.Drawing.Size(97, 41);
                    lessonRequestDeclineButton.TabIndex = 3;
                    lessonRequestDeclineButton.Text = "Reddet";
                    lessonRequestDeclineButton.UseVisualStyleBackColor = false;
                    lessonRequestDeclineButton.Click += new System.EventHandler(this.lessonRequestDeclineButton_Click);
                    // 
                    // lessonRequestAcceptButton
                    // 
                    lessonRequestAcceptButton.BackColor = System.Drawing.Color.Chartreuse;
                    lessonRequestAcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    lessonRequestAcceptButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    lessonRequestAcceptButton.Location = new System.Drawing.Point(683, 13);
                    lessonRequestAcceptButton.Name = "lessonRequestAcceptButton";
                    lessonRequestAcceptButton.Size = new System.Drawing.Size(97, 41);
                    lessonRequestAcceptButton.TabIndex = 2;
                    lessonRequestAcceptButton.Text = "Kabul Et";
                    lessonRequestAcceptButton.UseVisualStyleBackColor = false;
                    lessonRequestAcceptButton.Click += new System.EventHandler(this.lessonRequestAcceptButton_Click);
                    // 
                    // lessonRequestLessonNameLabel
                    // 
                    lessonRequestLessonNameLabel.AutoSize = true;
                    lessonRequestLessonNameLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    lessonRequestLessonNameLabel.Location = new System.Drawing.Point(333, 17);
                    lessonRequestLessonNameLabel.Name = "lessonRequestLessonNameLabel";
                    lessonRequestLessonNameLabel.Size = new System.Drawing.Size(73, 29);
                    lessonRequestLessonNameLabel.TabIndex = 1;
                    lessonRequestLessonNameLabel.Text = lessonName;
                    // 
                    // lessonRequestStudentNameLabel
                    // 
                   
                    lessonRequestStudentNameLabel.AutoSize = true;
                    lessonRequestStudentNameLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    lessonRequestStudentNameLabel.LinkColor = System.Drawing.Color.Black;
                    lessonRequestStudentNameLabel.Location = new System.Drawing.Point(12, 17);
                    lessonRequestStudentNameLabel.Name = "lessonRequestStudentNameLabel";
                    lessonRequestStudentNameLabel.Size = new System.Drawing.Size(119, 29);
                    lessonRequestStudentNameLabel.TabIndex = 4;
                    lessonRequestStudentNameLabel.TabStop = true;
                    lessonRequestStudentNameLabel.Text = name + " " + surname; ;
                    lessonRequestStudentNameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);

                    this.teacherLessonRequestPanel.Controls.Add(panel1);

                    i++;      
                }
            }



        }

        private void lessonRequestAcceptButton_Click(object sender, EventArgs e)
        {

        }

        private void lessonRequestDeclineButton_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }

}
