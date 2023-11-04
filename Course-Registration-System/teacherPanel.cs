using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string tmpStundentId;
        
        Dictionary<string, int> lessonGrading = new Dictionary<string, int>();
        List<string> lessonNames = new List<string>();
        List<TextBox> textBoxes = new List<TextBox>();
        List<Panel> panels = new List<Panel>();
        int last;

        bool staticveri = true;
        string dersid;
        string sicilNo;

        SQLCommands sQLCommands = new SQLCommands();
        public teacherPanel(int id)
        {
            teacherNameSurname = sQLCommands.getInfoAboutTeacher(id);
            
           
            teacherId = id;
            
            InitializeComponent();
        }

        void ShowPanel(Panel panel)
        {
            teacherInterestPanel.Visible = false;
            teacherMessagePanel.Visible = false;
            teacherLessonRequestPanel.Visible= false;
            teacherGradingPanel.Visible = false;
            teacherStudentPanel.Visible = false;

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


            List<Panel> panelList = new List<Panel>();
            int teacherRequestCount = sQLCommands.garipCount("*", "request_table", "status", "Bekliyor", "receiptid", teacherId.ToString());
            DataTable dataTable = sQLCommands.showTwoQueryDataTable("*", "request_table", "status", "Bekliyor", "receiptid", teacherId.ToString());
            int num = 24;


            if (teacherRequestCount > 0)
            {

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    string studentId;
                    string name;
                    string surname;
                    string lessonName;
                    string lessonId;
                    DataTable data = sQLCommands.showQueryDataTable("sicilno,name,surname", "users", "sicilno", row["senderid"].ToString());
                    DataTable data2 = sQLCommands.showQueryDataTable("dersisim,dersid", "acilandersler", "dersid", row["dersid"].ToString());
                    DataRow row2 = data.Rows[0];
                    DataRow row1 = data2.Rows[0];
                    studentId = row2["sicilno"].ToString();
                    name = row2["name"].ToString();
                    surname = row2["surname"].ToString();
                    lessonName = row1["dersisim"].ToString();
                    lessonId = row1["dersid"].ToString();

                    Panel panel1 = new Panel();
                    Button lessonRequestDeclineButton = new Button();
                    Button lessonRequestAcceptButton = new Button();
                    Label lessonRequestLessonNameLabel = new Label();
                    LinkLabel lessonRequestStudentNameLabel = new LinkLabel();

                    // 
                    // panel1
                    // 
                    panel1.BackColor = System.Drawing.Color.Aquamarine;
                    panel1.Controls.Add(lessonRequestDeclineButton);
                    panel1.Controls.Add(lessonRequestAcceptButton);
                    panel1.Controls.Add(lessonRequestLessonNameLabel);
                    panel1.Controls.Add(lessonRequestStudentNameLabel);
                    panel1.Cursor = System.Windows.Forms.Cursors.Default;
                    panel1.Location = new System.Drawing.Point(24, num + (i * 80));
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
                    lessonRequestDeclineButton.Click += new System.EventHandler((senderObj, eventArgs) =>
                    {
                        sQLCommands.deleteThree("request_table", studentId.ToString(), teacherId.ToString(), lessonId);
                        panel1.BackColor = System.Drawing.Color.IndianRed;
                        panel1.Controls.Remove(lessonRequestAcceptButton);
                        panel1.Controls.Remove(lessonRequestDeclineButton);
                    });
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

                    lessonRequestAcceptButton.Click += new System.EventHandler((senderObj, eventArgs) =>
                    {

                        string teacherQuota = sQLCommands.getValue("quota", " teachers ", "sicilno = " + teacherId);
                        int.TryParse(teacherQuota, out int teacherQuotaNum);
                        if (teacherQuotaNum > 0)
                        {
                            string studentLesson = sQLCommands.getValue("numberoflesson", "students", "sicilno = " + studentId);
                            teacherQuotaNum--;

                            sQLCommands.updateThreeData("request_table", "status", studentId, teacherId.ToString(), lessonId, "Onaylandı");
                            sQLCommands.updateTwoData("request_table", "status", studentId, teacherId.ToString(), lessonId, "Reddedildi");
                            sQLCommands.updateData("public.teachers", "quota", "sicilno", teacherId.ToString(), teacherQuotaNum.ToString());
                            string studentNumberLesson = sQLCommands.getValue("numberoflesson", " students ", "sicilno = " + studentId);
                            int.TryParse(studentNumberLesson, out int studentNumberNum);
                            studentNumberNum++;
                            sQLCommands.updateData("public.students", "numberoflesson", "sicilno", studentId, studentNumberNum.ToString());


                            panel1.BackColor = System.Drawing.Color.GreenYellow;
                            panel1.Controls.Remove(lessonRequestAcceptButton);
                            panel1.Controls.Remove(lessonRequestDeclineButton);
                        }
                        else
                        {
                            MessageBox.Show("Kontenjanınız dolmuştur", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    });
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

                    panelList.Add(panel1);

                    this.teacherLessonRequestPanel.Controls.Add(panel1);


                }

            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void teacherGradingButton_Click(object sender, EventArgs e)
        {
            ShowPanel(teacherGradingPanel);
            DataTable dataTable = sQLCommands.showDataTable("*", "students_and_lessons");
            int count = sQLCommands.onlyCount("*", "students_and_lessons");

            int num = 56;
            //63

            if (count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    string lessonId = row["lessonid"].ToString();
                    string lessonName = sQLCommands.getValue("lessonname", "lesson", "lessonid= '" + lessonId + "'");

                    Panel panel1 = new Panel();
                    Label label1 = new Label();
                    TextBox textBox1 = new TextBox();
                    // 
                    // panel1
                    //
                    //
                    panel1.SuspendLayout();
                    panel1.BackColor = System.Drawing.Color.LightYellow;
                    panel1.Controls.Add(textBox1);
                    panel1.Controls.Add(label1);
                    panel1.Location = new System.Drawing.Point(71, num + (i * 70));
                    panel1.Name = "panel1";
                    panel1.Size = new System.Drawing.Size(715, 57);
                    panel1.TabIndex = 0;
                    last = num + (i * 70);
                    // 
                    // label1
                    // 
                    label1.AutoSize = true;
                    label1.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    label1.Location = new System.Drawing.Point(3, 14);
                    label1.Name = "label1";
                    label1.Size = new System.Drawing.Size(324, 29);
                    label1.TabIndex = 0;
                    label1.Text = lessonName;
                    lessonNames.Add(lessonName);
                    // 
                    // textBox1
                    // 
                    textBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    textBox1.Location = new System.Drawing.Point(610, 15);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new System.Drawing.Size(99, 33);
                    textBox1.TabIndex = 1;
                    textBoxes.Add(textBox1);

                    panels.Add(panel1);
                    teacherGradingPanel.Controls.Add(panel1);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (TextBox item in textBoxes)
            {
                if (!(string.IsNullOrWhiteSpace(item.Text)) && sQLCommands.IsNumeric(item.Text))
                {
                    int.TryParse(item.Text, out int result);
                    lessonGrading.Add(lessonNames[i], result);
                }
                else
                {
                    lessonGrading.Add(lessonNames[i], 0);
                }
                i++;
            }
            MessageBox.Show("Başarıyla Kaydedildi", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GradingCalculator();
        }

        public void GradingCalculator()
        {
            int tmp = last + 150;
            float sum = 0;
            DataTable dataTable = sQLCommands.showDataTable("distinct sicilno", "students_and_lessons");

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                DataTable data = sQLCommands.showQueryDataTable("lessonletterpoint,lessonid", "students_and_lessons", "sicilno", row["sicilno"].ToString());
                for (int j = 0; j < data.Rows.Count; j++)
                {
                    DataRow dataRow = data.Rows[j];
                    string lessonName = sQLCommands.getValue("lessonname", "lesson", "lessonid= '" + dataRow["lessonid"].ToString()+"'");
                    string credit1 = sQLCommands.getValue("credit", "lesson", "lessonid= '"+dataRow["lessonid"].ToString()+"'");
                    int.TryParse(credit1, out int credit);
                    int lessonGrad = lessonGrading[lessonName];
                    float letterpoint = 0.0f;
                    if (dataRow["lessonletterpoint"].ToString().Equals("AA"))
                        letterpoint = 4.0f;
                    else if (dataRow["lessonletterpoint"].ToString().Equals("BA"))
                        letterpoint = 3.5f;
                    else if (dataRow["lessonletterpoint"].ToString().Equals("BB"))
                        letterpoint = 3.0f;
                    else if (dataRow["lessonletterpoint"].ToString().Equals("CB"))
                        letterpoint = 2.5f;
                    else if (dataRow["lessonletterpoint"].ToString().Equals("CC"))
                        letterpoint = 2.0f;
                    else if (dataRow["lessonletterpoint"].ToString().Equals("DC"))
                        letterpoint = 1.5f;
                    else
                        letterpoint = 0.0f;
                    sum = sum + (letterpoint * credit * lessonGrad);
                }
                Panel panel1 = new Panel();
                Label label1 = new Label();
                Label label3 = new Label();
                panel1.SuspendLayout();
                // 
                // panel1
                // 
                panel1.BackColor = System.Drawing.Color.Aquamarine;
                panel1.Controls.Add(label3);
                panel1.Controls.Add(label1);
                panel1.Location = new System.Drawing.Point(71, tmp+(70*i));
                panel1.Name = "panel1";
                panel1.Size = new System.Drawing.Size(715, 57);
                panel1.TabIndex = 0;
                // 
                // label1
                // 
                label1.AutoSize = true;
                label1.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label1.Location = new System.Drawing.Point(3, 14);
                label1.Name = "label1";
                label1.Size = new System.Drawing.Size(102, 29);
                label1.TabIndex = 0;
                DataTable studentName = sQLCommands.showQueryDataTable("name,surname", "users", "sicilno", row["sicilno"].ToString());
                DataRow dataRow1 = studentName.Rows[0];
                label1.Text = dataRow1["name"].ToString()+" "+dataRow1["surname"].ToString();
                // 
                // label3
                // 
                label3.AutoSize = true;
                label3.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                label3.Location = new System.Drawing.Point(610, 14);
                label3.Name = "label3";
                label3.Size = new System.Drawing.Size(102, 29);
                label3.TabIndex = 1;
                label3.Text = sum.ToString();
                // 
                // Form1
                // 

                teacherGradingPanel.Controls.Add(panel1);
                panel1.ResumeLayout(false);
                panel1.PerformLayout();

            }
        }

        private void teacherInterestbutton_Click(object sender, EventArgs e)
        {
            ShowPanel(teacherInterestPanel);
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            
        }

        private void teacherStudentbutton_Click(object sender, EventArgs e)
        {

            ShowPanel(teacherStudentPanel);
            DataGridView dataGridView1 = new System.Windows.Forms.DataGridView();
            Label sicilNoLabelDgm = new System.Windows.Forms.Label();
            Label adLabelDgm = new System.Windows.Forms.Label();
            Label OrtalamaLabelDgm = new System.Windows.Forms.Label();
            Label dersSayısıLabelDgm = new System.Windows.Forms.Label();
            Label teacherQuotaLabel = new System.Windows.Forms.Label();
            DataGridView dataGridView2 = new System.Windows.Forms.DataGridView();
            Label dersAdıLabelDgm = new System.Windows.Forms.Label();
            Label sicilNoLabel = new System.Windows.Forms.Label();
            Label adLabel = new System.Windows.Forms.Label();
            Label ortalamaLabel = new System.Windows.Forms.Label();
            Label dersSayısıLabel = new System.Windows.Forms.Label();
            Label dersAdıLabel = new System.Windows.Forms.Label();
            Button ekleButton = new System.Windows.Forms.Button();
            teacherStudentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView2)).BeginInit();

            // 
            // teacherStudentPanel
            // 
            teacherStudentPanel.Controls.Add(ekleButton);
            teacherStudentPanel.Controls.Add(dersAdıLabel);
            teacherStudentPanel.Controls.Add(dersSayısıLabel);
            teacherStudentPanel.Controls.Add(ortalamaLabel);
            teacherStudentPanel.Controls.Add(adLabel);
            teacherStudentPanel.Controls.Add(sicilNoLabel);
            teacherStudentPanel.Controls.Add(dersAdıLabelDgm);
            teacherStudentPanel.Controls.Add(dataGridView2);
            teacherStudentPanel.Controls.Add(teacherQuotaLabel);
            teacherStudentPanel.Controls.Add(dersSayısıLabelDgm);
            teacherStudentPanel.Controls.Add(OrtalamaLabelDgm);
            teacherStudentPanel.Controls.Add(adLabelDgm);
            teacherStudentPanel.Controls.Add(sicilNoLabelDgm);
            teacherStudentPanel.Controls.Add(dataGridView1);
            teacherStudentPanel.Location = new System.Drawing.Point(200, 174);
            teacherStudentPanel.Name = "teacherStudentPanel";
            teacherStudentPanel.Size = new System.Drawing.Size(972, 575);
            teacherStudentPanel.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(3, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(481, 225);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += new System.EventHandler((senderObj, eventArgs) =>
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    sicilNoLabel.Text = selectedRow.Cells["sicilno"].Value.ToString();
                    sicilNo = selectedRow.Cells["sicilno"].Value.ToString();
                    adLabel.Text = selectedRow.Cells["name"].Value.ToString() + " " + selectedRow.Cells["surname"].Value.ToString();
                    ortalamaLabel.Text = selectedRow.Cells["gpa"].Value.ToString();
                    dersSayısıLabel.Text = selectedRow.Cells["numberoflesson"].Value.ToString();
                }
            });
            if (staticveri) 
            {
                dataGridView1.DataSource = sQLCommands.SpecialQuery1();
                dataGridView1.Columns["sicilno"].HeaderText = "SİCİLNO";
                dataGridView1.Columns["name"].HeaderText = "İSİM";
                dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
                dataGridView1.Columns["gpa"].HeaderText = "GPA";
                dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";
                
            }
            else
            {
                dataGridView1.DataSource = sQLCommands.SpecialQuery2();
                dataGridView1.Columns["sicilno"].HeaderText = "SİCİLNO";
                dataGridView1.Columns["name"].HeaderText = "İSİM";
                dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
                dataGridView1.Columns["gpa"].HeaderText = "GPA";
                dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";
            }
            // 
            // sicilNoLabelDgm
            // 
            sicilNoLabelDgm.AutoSize = true;
            sicilNoLabelDgm.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            sicilNoLabelDgm.Location = new System.Drawing.Point(7, 292);
            sicilNoLabelDgm.Name = "sicilNoLabelDgm";
            sicilNoLabelDgm.Size = new System.Drawing.Size(127, 37);
            sicilNoLabelDgm.TabIndex = 1;
            sicilNoLabelDgm.Text = "Sicil No:";
            // 
            // adLabelDgm
            // 
            adLabelDgm.AutoSize = true;
            adLabelDgm.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            adLabelDgm.Location = new System.Drawing.Point(7, 329);
            adLabelDgm.Name = "adLabelDgm";
            adLabelDgm.Size = new System.Drawing.Size(198, 37);
            adLabelDgm.TabIndex = 2;
            adLabelDgm.Text = "İsim Soyisim:";
            // 
            // OrtalamaLabelDgm
            // 
            OrtalamaLabelDgm.AutoSize = true;
            OrtalamaLabelDgm.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            OrtalamaLabelDgm.Location = new System.Drawing.Point(7, 366);
            OrtalamaLabelDgm.Name = "OrtalamaLabelDgm";
            OrtalamaLabelDgm.Size = new System.Drawing.Size(153, 37);
            OrtalamaLabelDgm.TabIndex = 3;
            OrtalamaLabelDgm.Text = "Ortalama:";
            // 
            // dersSayısıLabelDgm
            // 
            dersSayısıLabelDgm.AutoSize = true;
            dersSayısıLabelDgm.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dersSayısıLabelDgm.Location = new System.Drawing.Point(7, 403);
            dersSayısıLabelDgm.Name = "dersSayısıLabelDgm";
            dersSayısıLabelDgm.Size = new System.Drawing.Size(174, 37);
            dersSayısıLabelDgm.TabIndex = 4;
            dersSayısıLabelDgm.Text = "Ders Sayısı:";
            // 
            // teacherQuotaLabel
            // 
            teacherQuotaLabel.AutoSize = true;
            teacherQuotaLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            teacherQuotaLabel.ForeColor = System.Drawing.Color.Firebrick;
            teacherQuotaLabel.Location = new System.Drawing.Point(3, 3);
            teacherQuotaLabel.Name = "teacherQuotaLabel";
            teacherQuotaLabel.Size = new System.Drawing.Size(101, 37);
            teacherQuotaLabel.TabIndex = 5;
            string hocaKotası = sQLCommands.getValue("quota", "teachers", "sicilno="+"'"+ teacherId.ToString()+"'");
            teacherQuotaLabel.Text = hocaKotası;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = System.Drawing.Color.LightGreen;
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new System.Drawing.Point(488, 53);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new System.Drawing.Size(481, 225);
            dataGridView2.TabIndex = 6;
            dataGridView2.SelectionChanged += new System.EventHandler((senderObj, eventArgs) =>
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];
                    dersAdıLabel.Text = selectedRow.Cells["dersisim"].Value.ToString();
                    dersid = selectedRow.Cells["dersid"].Value.ToString();
                }
            });
            dataGridView2.DataSource = sQLCommands.showDataTable("*", "acilandersler");
            dataGridView2.Columns["dersid"].HeaderText = "DERS İD";
            dataGridView2.Columns["dersisim"].HeaderText = "DERS İSİM";
            // 
            // dersAdıLabelDgm
            // 
            dersAdıLabelDgm.AutoSize = true;
            dersAdıLabelDgm.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dersAdıLabelDgm.Location = new System.Drawing.Point(481, 292);
            dersAdıLabelDgm.Name = "dersAdıLabelDgm";
            dersAdıLabelDgm.Size = new System.Drawing.Size(142, 37);
            dersAdıLabelDgm.TabIndex = 7;
            dersAdıLabelDgm.Text = "Ders Adı:";
            // 
            // sicilNoLabel
            // 
            sicilNoLabel.AutoSize = true;
            sicilNoLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            sicilNoLabel.Location = new System.Drawing.Point(234, 292);
            sicilNoLabel.Name = "sicilNoLabel";
            sicilNoLabel.Size = new System.Drawing.Size(85, 37);
            sicilNoLabel.TabIndex = 8;
            sicilNoLabel.Text = " ";
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            adLabel.Location = new System.Drawing.Point(234, 329);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(85, 37);
            adLabel.TabIndex = 9;
            adLabel.Text = " ";
            // 
            // ortalamaLabel
            // 
            ortalamaLabel.AutoSize = true;
            ortalamaLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            ortalamaLabel.Location = new System.Drawing.Point(234, 366);
            ortalamaLabel.Name = "ortalamaLabel";
            ortalamaLabel.Size = new System.Drawing.Size(85, 37);
            ortalamaLabel.TabIndex = 10;
            ortalamaLabel.Text = " ";
            // 
            // dersSayısıLabel
            // 
            dersSayısıLabel.AutoSize = true;
            dersSayısıLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dersSayısıLabel.Location = new System.Drawing.Point(234, 403);
            dersSayısıLabel.Name = "dersSayısıLabel";
            dersSayısıLabel.Size = new System.Drawing.Size(85, 37);
            dersSayısıLabel.TabIndex = 11;
            dersSayısıLabel.Text = " ";
            // 
            // dersAdıLabel
            // 
            dersAdıLabel.AutoSize = true;
            dersAdıLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dersAdıLabel.Location = new System.Drawing.Point(661, 292);
            dersAdıLabel.Name = "dersAdıLabel";
            dersAdıLabel.Size = new System.Drawing.Size(85, 37);
            dersAdıLabel.TabIndex = 12;
            dersAdıLabel.Text = " ";
            // 
            // ekleButton
            // 
            ekleButton.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            ekleButton.Location = new System.Drawing.Point(367, 475);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new System.Drawing.Size(181, 41);
            ekleButton.TabIndex = 13;
            ekleButton.Text = "Ekle";
            ekleButton.UseVisualStyleBackColor = true;
            ekleButton.Click += new System.EventHandler((senderObj, eventArgs) =>
            {
                sQLCommands.addRequest(sicilNo, teacherId.ToString(), dersid, "Onaylandı");

                if (staticveri)
                {
                    dataGridView1.DataSource = sQLCommands.SpecialQuery1();
                    dataGridView1.Columns["sicilno"].HeaderText = "SİCİLNO";
                    dataGridView1.Columns["name"].HeaderText = "İSİM";
                    dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
                    dataGridView1.Columns["gpa"].HeaderText = "GPA";
                    dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";

                }
                else
                {

                    dataGridView1.DataSource = sQLCommands.SpecialQuery2();
                    dataGridView1.Columns["sicilno"].HeaderText = "SİCİLNO";
                    dataGridView1.Columns["name"].HeaderText = "İSİM";
                    dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
                    dataGridView1.Columns["gpa"].HeaderText = "GPA";
                    dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";
                }

                MessageBox.Show("İşleminiz başarıyla gerçekleşti", "Başarılı İşlem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            });

            teacherStudentPanel.ResumeLayout(false);
            teacherStudentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView2)).EndInit();
        }
        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBox1.Text == "Mesajinizi buraya giriniz!.")
            {
                textBox1.Text = "";
            }
        }
        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Mesajinizi buraya giriniz!.";
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            SQLCommands sQLCommands = new SQLCommands();
            Random random = new Random();
            //Console.WriteLine(sQLCommands.findUserID("teachers", comboBox1.SelectedText));
            sQLCommands.sendMessage(teacherId, sQLCommands.findUserID("students", comboBox1.SelectedItem.ToString()), textBox1.Text, random.Next(1, 10000));
            textBox1.Text = "Mesajinizi buraya giriniz!.";
            MessageBox.Show("Mesajiniz basairiyla gonderdildi.", "Basarili Islem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void teacherMessagesButton_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SQLCommands sQLCommands = new SQLCommands();
            List<string> teacherIDList = sQLCommands.showCloumn("sicilno","students");
            for (int j = 0; j < teacherIDList.Count; j++)
            {
                this.comboBox1.Items.Add(sQLCommands.printAll(int.Parse(teacherIDList[j])));
            }

            this.panel2.Controls.Clear();
            
            int panelY = 16;
            string message = string.Empty;
            int senderid = 0;
            int i = 0;
            string connectionString = "server=localHost; port=5432; Database=yazlab; user ID=postgres; password=12345";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT senderid, message FROM messages where receiptid=@p1";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("p1", teacherId);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                           
                            senderid = reader.GetInt32(0);
                            message = reader.GetString(1);
                           
                            // 
                            // panel3
                            // 
                            Panel panel33 = new Panel();
                            Label label53 = new Label();
                            Label label63 = new Label();
                            panel33.BackColor = System.Drawing.Color.Teal;
                            panel33.Location = new System.Drawing.Point(21, panelY + i*120);
                            panel33.Name = "panel3";
                            panel33.Size = new System.Drawing.Size(889, 100);
                            panel33.TabIndex = 0;
                            // 
                            // label5
                            // 
                           
                            label53.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label53.Location = new System.Drawing.Point(9, 9);
                            label53.Name = "label5";
                            label53.Size = new System.Drawing.Size(370, 22);
                            label53.TabIndex = 4;
                            
                            label53.Text = "GONDEREN: " + sQLCommands.printAll(senderid);
                            // 
                            // label6
                            // 
                            label63.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label63.ForeColor = System.Drawing.SystemColors.Control;
                            label63.Location = new System.Drawing.Point(9, 31);
                            label63.Name = "label6";
                            label63.Size = new System.Drawing.Size(865, 55);
                            label63.TabIndex = 5;
                            label63.Text = "MESAJ: " + message;
                            panel33.Controls.Add(label63);
                            panel33.Controls.Add(label53);
                            panel2.Controls.Add(panel33);
                            i++;
                        }
                    }
                }
                connection.Close();
            }
            ShowPanel(teacherMessagePanel);
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}