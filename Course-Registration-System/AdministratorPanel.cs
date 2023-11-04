using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course_Registration_System
{
    public partial class AdministratorPanel : Form
    {
        int studentIdNo = -1 ;
        int teacherIdNo = -1 ;


        SQLCommands sQLCommands = new SQLCommands();
        public AdministratorPanel()
        {
            InitializeComponent();
            this.studentPanel.Visible = false;
            this.teacherPanel.Visible = false;
            this.StudentListPanel.Visible = false;
            this.studentTeacherChoosePanel.Visible = false;
            this.TeacherListPanel.Visible=false;
            this.lessonAddPanel.Visible = false;
            this.usersPanel.Visible = false;
            this.otoUsersPanel.Visible = false;
            this.panel2.Visible = false;

            
        }

        void ShowPanel(Panel panel) 
        {
            this.studentPanel.Visible= false;
            this.teacherPanel.Visible = false;
            this.StudentListPanel.Visible = false;
            this.studentTeacherChoosePanel.Visible = false;
            this.TeacherListPanel.Visible = false;
            this.lessonAddPanel.Visible = false;
            this.usersPanel.Visible = false;
            this.otoUsersPanel.Visible=false;
            this.panel2.Visible = false;

            panel.Visible = true;
        }

        void StudentPanelComponent() 
        {
            DataTable dataTable= new DataTable();
            this.StudentUpdateButton = new System.Windows.Forms.Button();
            this.StudentAddButton = new System.Windows.Forms.Button();
            this.numberlessonTextBox = new System.Windows.Forms.TextBox();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox1 = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfLessonAdd = new System.Windows.Forms.Label();
            this.gpaAdd = new System.Windows.Forms.Label();
            this.passwordAdd = new System.Windows.Forms.Label();
            this.surnameAdd = new System.Windows.Forms.Label();
            this.NameAdd = new System.Windows.Forms.Label();
            this.npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            this.teacherPanel = new System.Windows.Forms.Panel();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.numberlessonUpdateTextBox = new System.Windows.Forms.TextBox();
            this.gpaUpdateTextBox = new System.Windows.Forms.TextBox();
            this.passwordUpdateTextBox = new System.Windows.Forms.TextBox();
            this.surnameUpdateTextBox = new System.Windows.Forms.TextBox();
            this.nameUpdateTextBox = new System.Windows.Forms.TextBox();
            this.numberOfLessonUpdate = new System.Windows.Forms.Label();
            this.gpaUpdate = new System.Windows.Forms.Label();
            this.passwordUpdate = new System.Windows.Forms.Label();
            this.surnameUpdate = new System.Windows.Forms.Label();
            this.NameUpdate = new System.Windows.Forms.Label();
            this.surnameRemoveTextBox = new System.Windows.Forms.TextBox();
            this.nameRemoveTextBox = new System.Windows.Forms.TextBox();
            this.surnameRemove = new System.Windows.Forms.Label();
            this.NameRemove = new System.Windows.Forms.Label();
            this.StudentRemoveButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.dataGridView1);
            this.studentPanel.Controls.Add(this.surnameRemoveTextBox);
            this.studentPanel.Controls.Add(this.nameRemoveTextBox);
            this.studentPanel.Controls.Add(this.surnameRemove);
            this.studentPanel.Controls.Add(this.NameRemove);
            this.studentPanel.Controls.Add(this.StudentRemoveButton);
            this.studentPanel.Controls.Add(this.numberlessonUpdateTextBox);
            this.studentPanel.Controls.Add(this.gpaUpdateTextBox);
            this.studentPanel.Controls.Add(this.passwordUpdateTextBox);
            this.studentPanel.Controls.Add(this.surnameUpdateTextBox);
            this.studentPanel.Controls.Add(this.nameUpdateTextBox);
            this.studentPanel.Controls.Add(this.numberOfLessonUpdate);
            this.studentPanel.Controls.Add(this.gpaUpdate);
            this.studentPanel.Controls.Add(this.passwordUpdate);
            this.studentPanel.Controls.Add(this.surnameUpdate);
            this.studentPanel.Controls.Add(this.NameUpdate);
            this.studentPanel.Controls.Add(this.StudentUpdateButton);
            this.studentPanel.Controls.Add(this.StudentAddButton);
            this.studentPanel.Controls.Add(this.numberlessonTextBox);
            this.studentPanel.Controls.Add(this.gpaTextBox);
            this.studentPanel.Controls.Add(this.passwordTextBox);
            this.studentPanel.Controls.Add(this.surnameTextBox1);
            this.studentPanel.Controls.Add(this.nameTextBox);
            this.studentPanel.Controls.Add(this.numberOfLessonAdd);
            this.studentPanel.Controls.Add(this.gpaAdd);
            this.studentPanel.Controls.Add(this.passwordAdd);
            this.studentPanel.Controls.Add(this.surnameAdd);
            this.studentPanel.Controls.Add(this.NameAdd);
            this.studentPanel.Location = new System.Drawing.Point(193, 12);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(979, 737);
            this.studentPanel.TabIndex = 10;
            // 
            // StudentUpdateButton
            // 
            this.StudentUpdateButton.BackColor = System.Drawing.Color.LightGreen;
            this.StudentUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.StudentUpdateButton.FlatAppearance.BorderSize = 2;
            this.StudentUpdateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.StudentUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentUpdateButton.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentUpdateButton.Location = new System.Drawing.Point(471, 232);
            this.StudentUpdateButton.Name = "StudentUpdateButton";
            this.StudentUpdateButton.Size = new System.Drawing.Size(175, 50);
            this.StudentUpdateButton.TabIndex = 22;
            this.StudentUpdateButton.Text = "Düzenleme";
            this.StudentUpdateButton.UseVisualStyleBackColor = false;
            this.StudentUpdateButton.Click += new System.EventHandler(this.StudentUpdateButton_Click);
            // 
            // StudentAddButton
            // 
            this.StudentAddButton.BackColor = System.Drawing.Color.LightGreen;
            this.StudentAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.StudentAddButton.FlatAppearance.BorderSize = 2;
            this.StudentAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.StudentAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentAddButton.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentAddButton.Location = new System.Drawing.Point(145, 233);
            this.StudentAddButton.Name = "StudentAddButton";
            this.StudentAddButton.Size = new System.Drawing.Size(175, 50);
            this.StudentAddButton.TabIndex = 21;
            this.StudentAddButton.Text = "Ekle";
            this.StudentAddButton.UseVisualStyleBackColor = false;
            this.StudentAddButton.Click += new System.EventHandler(this.StudentAddButton_Click);
            // 
            // numberlessonTextBox
            // 
            this.numberlessonTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberlessonTextBox.Location = new System.Drawing.Point(145, 194);
            this.numberlessonTextBox.Name = "numberlessonTextBox";
            this.numberlessonTextBox.Size = new System.Drawing.Size(174, 33);
            this.numberlessonTextBox.TabIndex = 20;
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpaTextBox.Location = new System.Drawing.Point(145, 149);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(174, 33);
            this.gpaTextBox.TabIndex = 19;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.Location = new System.Drawing.Point(145, 105);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(174, 33);
            this.passwordTextBox.TabIndex = 18;
            // 
            // surnameTextBox1
            // 
            this.surnameTextBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTextBox1.Location = new System.Drawing.Point(145, 61);
            this.surnameTextBox1.Name = "surnameTextBox1";
            this.surnameTextBox1.Size = new System.Drawing.Size(174, 33);
            this.surnameTextBox1.TabIndex = 17;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.Location = new System.Drawing.Point(145, 14);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(174, 33);
            this.nameTextBox.TabIndex = 16;
            // 
            // numberOfLessonAdd
            // 
            this.numberOfLessonAdd.AutoSize = true;
            this.numberOfLessonAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberOfLessonAdd.Location = new System.Drawing.Point(4, 193);
            this.numberOfLessonAdd.Name = "numberOfLessonAdd";
            this.numberOfLessonAdd.Size = new System.Drawing.Size(135, 29);
            this.numberOfLessonAdd.TabIndex = 15;
            this.numberOfLessonAdd.Text = "Ders Sayısı:";
            // 
            // gpaAdd
            // 
            this.gpaAdd.AutoSize = true;
            this.gpaAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpaAdd.Location = new System.Drawing.Point(75, 149);
            this.gpaAdd.Name = "gpaAdd";
            this.gpaAdd.Size = new System.Drawing.Size(64, 29);
            this.gpaAdd.TabIndex = 14;
            this.gpaAdd.Text = "GPA:";
            // 
            // passwordAdd
            // 
            this.passwordAdd.AutoSize = true;
            this.passwordAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordAdd.Location = new System.Drawing.Point(70, 105);
            this.passwordAdd.Name = "passwordAdd";
            this.passwordAdd.Size = new System.Drawing.Size(69, 29);
            this.passwordAdd.TabIndex = 13;
            this.passwordAdd.Text = "Şifre:";
            // 
            // surnameAdd
            // 
            this.surnameAdd.AutoSize = true;
            this.surnameAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameAdd.Location = new System.Drawing.Point(37, 61);
            this.surnameAdd.Name = "surnameAdd";
            this.surnameAdd.Size = new System.Drawing.Size(102, 29);
            this.surnameAdd.TabIndex = 12;
            this.surnameAdd.Text = "Soyisim:";
            // 
            // NameAdd
            // 
            this.NameAdd.AutoSize = true;
            this.NameAdd.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameAdd.Location = new System.Drawing.Point(75, 17);
            this.NameAdd.Name = "NameAdd";
            this.NameAdd.Size = new System.Drawing.Size(64, 29);
            this.NameAdd.TabIndex = 11;
            this.NameAdd.Text = "İsim:";
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // numberlessonUpdateTextBox
            // 
            this.numberlessonUpdateTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberlessonUpdateTextBox.Location = new System.Drawing.Point(471, 193);
            this.numberlessonUpdateTextBox.Name = "numberlessonUpdateTextBox";
            this.numberlessonUpdateTextBox.Size = new System.Drawing.Size(174, 33);
            this.numberlessonUpdateTextBox.TabIndex = 32;
            // 
            // gpaUpdateTextBox
            // 
            this.gpaUpdateTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpaUpdateTextBox.Location = new System.Drawing.Point(471, 149);
            this.gpaUpdateTextBox.Name = "gpaUpdateTextBox";
            this.gpaUpdateTextBox.Size = new System.Drawing.Size(174, 33);
            this.gpaUpdateTextBox.TabIndex = 31;
            // 
            // passwordUpdateTextBox
            // 
            this.passwordUpdateTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordUpdateTextBox.Location = new System.Drawing.Point(471, 104);
            this.passwordUpdateTextBox.Name = "passwordUpdateTextBox";
            this.passwordUpdateTextBox.Size = new System.Drawing.Size(174, 33);
            this.passwordUpdateTextBox.TabIndex = 30;
            // 
            // surnameUpdateTextBox
            // 
            this.surnameUpdateTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameUpdateTextBox.Location = new System.Drawing.Point(471, 60);
            this.surnameUpdateTextBox.Name = "surnameUpdateTextBox";
            this.surnameUpdateTextBox.Size = new System.Drawing.Size(174, 33);
            this.surnameUpdateTextBox.TabIndex = 29;
            // 
            // nameUpdateTextBox
            // 
            this.nameUpdateTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameUpdateTextBox.Location = new System.Drawing.Point(471, 13);
            this.nameUpdateTextBox.Name = "nameUpdateTextBox";
            this.nameUpdateTextBox.Size = new System.Drawing.Size(174, 33);
            this.nameUpdateTextBox.TabIndex = 28;
            // 
            // numberOfLessonUpdate
            // 
            this.numberOfLessonUpdate.AutoSize = true;
            this.numberOfLessonUpdate.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberOfLessonUpdate.Location = new System.Drawing.Point(330, 197);
            this.numberOfLessonUpdate.Name = "numberOfLessonUpdate";
            this.numberOfLessonUpdate.Size = new System.Drawing.Size(135, 29);
            this.numberOfLessonUpdate.TabIndex = 27;
            this.numberOfLessonUpdate.Text = "Ders Sayısı:";
            // 
            // gpaUpdate
            // 
            this.gpaUpdate.AutoSize = true;
            this.gpaUpdate.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpaUpdate.Location = new System.Drawing.Point(401, 148);
            this.gpaUpdate.Name = "gpaUpdate";
            this.gpaUpdate.Size = new System.Drawing.Size(64, 29);
            this.gpaUpdate.TabIndex = 26;
            this.gpaUpdate.Text = "GPA:";
            // 
            // passwordUpdate
            // 
            this.passwordUpdate.AutoSize = true;
            this.passwordUpdate.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordUpdate.Location = new System.Drawing.Point(396, 104);
            this.passwordUpdate.Name = "passwordUpdate";
            this.passwordUpdate.Size = new System.Drawing.Size(69, 29);
            this.passwordUpdate.TabIndex = 25;
            this.passwordUpdate.Text = "Şifre:";
            // 
            // surnameUpdate
            // 
            this.surnameUpdate.AutoSize = true;
            this.surnameUpdate.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameUpdate.Location = new System.Drawing.Point(363, 60);
            this.surnameUpdate.Name = "surnameUpdate";
            this.surnameUpdate.Size = new System.Drawing.Size(102, 29);
            this.surnameUpdate.TabIndex = 24;
            this.surnameUpdate.Text = "Soyisim:";
            // 
            // NameUpdate
            // 
            this.NameUpdate.AutoSize = true;
            this.NameUpdate.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameUpdate.Location = new System.Drawing.Point(401, 16);
            this.NameUpdate.Name = "NameUpdate";
            this.NameUpdate.Size = new System.Drawing.Size(64, 29);
            this.NameUpdate.TabIndex = 23;
            this.NameUpdate.Text = "İsim:";
            // 
            // surnameRemoveTextBox
            // 
            this.surnameRemoveTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameRemoveTextBox.Location = new System.Drawing.Point(793, 59);
            this.surnameRemoveTextBox.Name = "surnameRemoveTextBox";
            this.surnameRemoveTextBox.Size = new System.Drawing.Size(174, 33);
            this.surnameRemoveTextBox.TabIndex = 40;
            // 
            // nameRemoveTextBox
            // 
            this.nameRemoveTextBox.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameRemoveTextBox.Location = new System.Drawing.Point(793, 12);
            this.nameRemoveTextBox.Name = "nameRemoveTextBox";
            this.nameRemoveTextBox.Size = new System.Drawing.Size(174, 33);
            this.nameRemoveTextBox.TabIndex = 39;
            // 
            // surnameRemove
            // 
            this.surnameRemove.AutoSize = true;
            this.surnameRemove.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameRemove.Location = new System.Drawing.Point(685, 59);
            this.surnameRemove.Name = "surnameRemove";
            this.surnameRemove.Size = new System.Drawing.Size(102, 29);
            this.surnameRemove.TabIndex = 35;
            this.surnameRemove.Text = "Soyisim:";
            // 
            // NameRemove
            // 
            this.NameRemove.AutoSize = true;
            this.NameRemove.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameRemove.Location = new System.Drawing.Point(723, 15);
            this.NameRemove.Name = "NameRemove";
            this.NameRemove.Size = new System.Drawing.Size(64, 29);
            this.NameRemove.TabIndex = 34;
            this.NameRemove.Text = "İsim:";
            // 
            // StudentRemoveButton
            // 
            this.StudentRemoveButton.BackColor = System.Drawing.Color.LightGreen;
            this.StudentRemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.StudentRemoveButton.FlatAppearance.BorderSize = 2;
            this.StudentRemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.StudentRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StudentRemoveButton.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentRemoveButton.Location = new System.Drawing.Point(792, 98);
            this.StudentRemoveButton.Name = "StudentRemoveButton";
            this.StudentRemoveButton.Size = new System.Drawing.Size(175, 50);
            this.StudentRemoveButton.TabIndex = 33;
            this.StudentRemoveButton.Text = "Sil";
            this.StudentRemoveButton.UseVisualStyleBackColor = false;
            this.StudentRemoveButton.Click += new System.EventHandler(this.StudentRemoveButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 405);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.DataSource = sQLCommands.showDataTable("sicilno,name,surname,gpa,numberoflesson", "students");
            this.dataGridView1.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridView1.Columns["name"].HeaderText= "İSİM";
            this.dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView1.Columns["gpa"].HeaderText = "GPA";
            this.dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;

            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            ShowPanel(studentPanel);
            //Student Paneli en son ekle
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                nameUpdateTextBox.Text = selectedRow.Cells["name"].Value.ToString();
                surnameUpdateTextBox.Text = selectedRow.Cells["surname"].Value.ToString();
                gpaUpdateTextBox.Text = selectedRow.Cells["gpa"].Value.ToString();
                numberlessonUpdateTextBox.Text = selectedRow.Cells["numberoflesson"].Value.ToString();

                string stringSicil = sQLCommands.getValue("sicilno", "public.users", "Name = '"+selectedRow.Cells["name"].Value.ToString() +"' AND Surname = '"+ selectedRow.Cells["surname"].Value.ToString()+"'");
                passwordUpdateTextBox.Text = sQLCommands.getValue("password", "public.users", "sicilno="+stringSicil);
                studentIdNo = Convert.ToInt32(stringSicil);

                surnameRemoveTextBox.Text= selectedRow.Cells["surname"].Value.ToString();
                nameRemoveTextBox.Text = selectedRow.Cells["name"].Value.ToString();
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                teacherNameUpdateTextBox.Text = selectedRow.Cells["name"].Value.ToString();
                teacherSurnameUpdateTextBox.Text = selectedRow.Cells["surname"].Value.ToString();
                quotaUpdateTextBox.Text = selectedRow.Cells["quota"].Value.ToString();

                string stringSicil = sQLCommands.getValue("sicilno", "public.users", "Name = '" + selectedRow.Cells["name"].Value.ToString() + "' AND Surname = '" + selectedRow.Cells["surname"].Value.ToString() + "'");
                teacherPasswordUpdateTextBox.Text = sQLCommands.getValue("password", "public.users", "sicilno=" + stringSicil);
                teacherInterstUpdateTextBox.Text = sQLCommands.getValue("interests", "public.teachers_interest_table", "sicilno=" + stringSicil);
                teacherIdNo = Convert.ToInt32(stringSicil);

                teacherSurnameRemoveTextBox.Text = selectedRow.Cells["surname"].Value.ToString();
                teacherNameRemoveTextBox.Text = selectedRow.Cells["name"].Value.ToString();
            }
        }

        void TeacherPanelComponent() 
        {
            ShowPanel(teacherPanel);

            this.dataGridView2.DataSource = sQLCommands.showDataTable("sicilno,name,surname,quota", "teachers");
            this.dataGridView2.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridView2.Columns["name"].HeaderText = "İSİM";
            this.dataGridView2.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView2.Columns["quota"].HeaderText = "KONTENJAN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPanelComponent();

            this.dataGridView1.DataSource = sQLCommands.showDataTable("sicilno,name,surname,gpa,numberoflesson", "students");
            this.dataGridView1.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridView1.Columns["name"].HeaderText = "İSİM";
            this.dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView1.Columns["gpa"].HeaderText = "GPA";
            this.dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";
        }

        private void StudentAddButton_Click(object sender, EventArgs e)
        {
            sQLCommands.addUser(nameTextBox.Text, surnameTextBox1.Text, passwordTextBox.Text, "Student");
            string number =sQLCommands.getValue("sicilno", "public.users", "name= '" +nameTextBox.Text+"' AND surname = '"+ surnameTextBox1.Text+"' and password='"+ passwordTextBox.Text+"'");
            sQLCommands.addStudents(number, nameTextBox.Text, surnameTextBox1.Text, gpaTextBox.Text, numberlessonTextBox.Text);

            this.dataGridView1.DataSource = sQLCommands.showDataTable("sicilno,name,surname,gpa,numberoflesson", "students");
            this.dataGridView1.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridView1.Columns["name"].HeaderText = "İSİM";
            this.dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView1.Columns["gpa"].HeaderText = "GPA";
            this.dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";

        }

        private void StudentUpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (nameUpdateTextBox.Text!=selectedRow.Cells["name"].Value.ToString())
                {
                    sQLCommands.updateData("public.students", "name", "sicilno", studentIdNo.ToString(), nameUpdateTextBox.Text);
                }
                if (surnameUpdateTextBox.Text != selectedRow.Cells["surname"].Value.ToString())
                {
                    sQLCommands.updateData("public.students", "surname", "sicilno", studentIdNo.ToString(), surnameUpdateTextBox.Text);
                }
                if (gpaUpdateTextBox.Text != selectedRow.Cells["gpa"].Value.ToString())
                {
                    sQLCommands.updateData("public.students", "gpa", "sicilno", studentIdNo.ToString(), gpaUpdateTextBox.Text);
                }
                if (numberlessonUpdateTextBox.Text != selectedRow.Cells["numberoflesson"].Value.ToString())
                {
                    sQLCommands.updateData("public.students", "numberoflesson", "sicilno", studentIdNo.ToString(), numberlessonUpdateTextBox.Text);
                }
                string stringSicil = sQLCommands.getValue("sicilno", "public.users", "Name = '" + selectedRow.Cells["name"].Value.ToString() + "' AND Surname = '" + selectedRow.Cells["surname"].Value.ToString() + "'");
                if (passwordUpdateTextBox.Text != stringSicil)
                {
                    sQLCommands.updateData("public.users", "password", "sicilno", studentIdNo.ToString(), passwordUpdateTextBox.Text);
                }


                this.dataGridView1.DataSource = sQLCommands.showDataTable("sicilno,name,surname,gpa,numberoflesson", "students");
                this.dataGridView1.Columns["sicilno"].HeaderText = "SİCİLNO";
                this.dataGridView1.Columns["name"].HeaderText = "İSİM";
                this.dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
                this.dataGridView1.Columns["gpa"].HeaderText = "GPA";
                this.dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";

            }

        }
        private void TeacherUpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                if (teacherNameUpdateTextBox.Text != selectedRow.Cells["name"].Value.ToString())
                {
                    sQLCommands.updateData("public.teachers", "name", "sicilno", teacherIdNo.ToString(), teacherNameUpdateTextBox.Text);
                }
                if (teacherSurnameUpdateTextBox.Text != selectedRow.Cells["surname"].Value.ToString())
                {
                    sQLCommands.updateData("public.teachers", "surname", "sicilno", teacherIdNo.ToString(), teacherSurnameUpdateTextBox.Text);
                }
                if (quotaUpdateTextBox.Text != selectedRow.Cells["quota"].Value.ToString())
                {
                    sQLCommands.updateData("public.teachers", "quota", "sicilno", teacherIdNo.ToString(), quotaUpdateTextBox.Text);
                }
                string stringSicil = sQLCommands.getValue("sicilno", "public.users", "Name = '" + selectedRow.Cells["name"].Value.ToString() + "' AND Surname = '" + selectedRow.Cells["surname"].Value.ToString() + "'");
                if (teacherPasswordUpdateTextBox.Text != stringSicil)
                {
                    sQLCommands.updateData("public.users", "password", "sicilno", teacherIdNo.ToString(), teacherPasswordUpdateTextBox.Text);
                }


                this.dataGridView2.DataSource = sQLCommands.showDataTable("sicilno,name,surname,quota", "teachers");
                this.dataGridView2.Columns["sicilno"].HeaderText = "SİCİLNO";
                this.dataGridView2.Columns["name"].HeaderText = "İSİM";
                this.dataGridView2.Columns["surname"].HeaderText = "SOYİSİM";
                this.dataGridView2.Columns["quota"].HeaderText = "KONTENJAN";

            }

        }
        private void StudentRemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string stringSicil = sQLCommands.getValue("sicilno", "public.users", "Name = '" + selectedRow.Cells["name"].Value.ToString() + "' AND Surname = '" + selectedRow.Cells["surname"].Value.ToString() + "'");
                if (passwordUpdateTextBox.Text != stringSicil)
                {
                    sQLCommands.delete("public.messages", "senderid", stringSicil);
                    sQLCommands.delete("public.messages", "receiptid", stringSicil);
                    sQLCommands.delete("public.students_and_lessons", "sicilno", stringSicil);
                    sQLCommands.delete("public.students", "sicilno", stringSicil);
                    sQLCommands.delete("public.users","sicilno",stringSicil);
                    
                }


                this.dataGridView1.DataSource = sQLCommands.showDataTable("sicilno,name,surname,gpa,numberoflesson", "students");
                this.dataGridView1.Columns["sicilno"].HeaderText = "SİCİLNO";
                this.dataGridView1.Columns["name"].HeaderText = "İSİM";
                this.dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
                this.dataGridView1.Columns["gpa"].HeaderText = "GPA";
                this.dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";

            }

        }

        private void TeacherRemoveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string stringSicil = sQLCommands.getValue("sicilno", "public.users", "Name = '" + selectedRow.Cells["name"].Value.ToString() + "' AND Surname = '" + selectedRow.Cells["surname"].Value.ToString() + "'");
                if (passwordUpdateTextBox.Text != stringSicil)
                {
                    sQLCommands.delete("public.teachers", "sicilno", stringSicil);
                    sQLCommands.delete("public.users", "sicilno", stringSicil);

                }


                this.dataGridView2.DataSource = sQLCommands.showDataTable("sicilno,name,surname,quota", "teachers");
                this.dataGridView2.Columns["sicilno"].HeaderText = "SİCİLNO";
                this.dataGridView2.Columns["name"].HeaderText = "İSİM";
                this.dataGridView2.Columns["surname"].HeaderText = "SOYİSİM";
                this.dataGridView2.Columns["quota"].HeaderText = "KONTENJAN";

            }

        }

        private void TeacherAddButton_Click(object sender, EventArgs e) 
        {
            sQLCommands.addUser(teacherNameTextBox.Text, teacherSurnameTextBox.Text, teacherPasswordTextBox.Text, "Teacher");
            string number = sQLCommands.getValue("sicilno", "public.users", "name= '" + teacherNameTextBox.Text + "' AND surname = '" + teacherSurnameTextBox.Text + "' and password='" + teacherPasswordTextBox.Text + "'");
            sQLCommands.addTeachers(number, teacherNameTextBox.Text, teacherSurnameTextBox.Text, quotaTextBox.Text);
            sQLCommands.addTeachersInterest(number, teacherInterstAddTextBox.Text);

            this.dataGridView2.DataSource = sQLCommands.showDataTable("sicilno,name,surname,quota", "teachers");
            this.dataGridView2.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridView2.Columns["name"].HeaderText = "İSİM";
            this.dataGridView2.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView2.Columns["quota"].HeaderText = "KONTENJAN";

        }
        private void button3_Click(object sender, EventArgs e)
        {
            TeacherPanelComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataGridViewUsersStudentsList.DataSource = sQLCommands.showQueryDataTable("sicilno,name,surname,password,type", "public.users", "type", "Student");
            this.dataGridViewUsersStudentsList.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridViewUsersStudentsList.Columns["name"].HeaderText = "İSİM";
            this.dataGridViewUsersStudentsList.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridViewUsersStudentsList.Columns["password"].HeaderText = "ŞİFRE";
            this.dataGridViewUsersStudentsList.Columns["type"].HeaderText = "TİP";

            this.dataGridViewStudentsList.DataSource = sQLCommands.showDataTable("sicilno,name,surname,gpa,numberoflesson", "students");
            this.dataGridViewStudentsList.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridViewStudentsList.Columns["name"].HeaderText = "İSİM";
            this.dataGridViewStudentsList.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridViewStudentsList.Columns["gpa"].HeaderText = "GPA";
            this.dataGridViewStudentsList.Columns["numberoflesson"].HeaderText = "DERS SAYISI";

            this.dataGridViewStudentLessonList.DataSource = sQLCommands.showDataTable("sicilno,lessonid,lessonletterpoint", "students_and_lessons");
            this.dataGridViewStudentLessonList.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridViewStudentLessonList.Columns["lessonid"].HeaderText = "DERS ID";
            this.dataGridViewStudentLessonList.Columns["lessonletterpoint"].HeaderText = "DERS HARF NOTU";

            ShowPanel(StudentListPanel);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowPanel(studentTeacherChoosePanel);
            this.dataGridView3.DataSource = sQLCommands.SpecialQuery2();
        }

        public List<string> GetTeacherList()
        {
            DataTable teachersData = sQLCommands.showDataTableWhere("*", "teachers", "quota");
            int teacherDataCount = teachersData.Rows.Count;
            List<string> teacherList = new List<string>();
            Random random = new Random();
            DataRow teacherRow = teachersData.Rows[0];

            for (int i = 0; i < teacherDataCount; i++)
            {
                int rastgeleSayi = random.Next(0, teacherDataCount);
                teacherRow = teachersData.Rows[rastgeleSayi];
                if (teacherList.Count > 0)
                {
                    if (teacherList.Contains(teacherRow["sicilno"].ToString()))
                    {
                        while (teacherList.Contains(teacherRow["sicilno"].ToString()))
                        {
                            rastgeleSayi = random.Next(0, teacherDataCount);
                            teacherRow = teachersData.Rows[rastgeleSayi];
                        }
                    }
                }
                teacherList.Add(teacherRow["sicilno"].ToString());
            }
            return teacherList;

        }

        private void randomlyAssignButton_Click(object sender, EventArgs e)
        {
            this.dataGridView3.DataSource = sQLCommands.SpecialQuery2();
            sQLCommands.delete("request_table", "status", "Bekliyor");
            List<string> teacherList = GetTeacherList();
            DataTable lessonData = sQLCommands.showDataTable("*", "acilandersler");
            DataTable studentData = sQLCommands.SpecialQuery2();
            dataGridView3.DataSource = studentData;

            bool staticVeri = Settings.teacherStatus;
            int tmp = 0;


            if (staticVeri) 
            {
                for (int i = 0; i < studentData.Rows.Count; i++)
                {
                    DataRow studentRow = studentData.Rows[i];
                    for (int j = 0; j < lessonData.Rows.Count; j++)
                    {
                        DataRow lessonRow = lessonData.Rows[j];
                        string teacherid = teacherList[tmp];
                        int requestCount = sQLCommands.ultiGaripCount("*", "request_table", "senderid", studentRow["sicilno"].ToString(), "receiptid", teacherid, "status", "Onaylandı", "dersid", lessonRow["dersid"].ToString());
                        if (requestCount > 0)
                            continue;
                        string teacherQuota = sQLCommands.getValue("quota", "teachers", "sicilno= " + teacherid);
                        int.TryParse(teacherQuota, out int teacherQuotaNum);
                        string studentLessonNum = sQLCommands.getValue("numberoflesson", "students", "sicilno= " + studentRow["sicilno"].ToString());
                        int.TryParse(studentLessonNum, out int studentLessonNumber);
                        studentLessonNumber++;
                        teacherQuotaNum--;
                        sQLCommands.addRequest(studentRow["sicilno"].ToString(), teacherList[tmp], lessonRow["dersid"].ToString(), "Onaylandı");
                        sQLCommands.updateData("students", "numberoflesson", "sicilno", studentRow["sicilno"].ToString(), studentLessonNumber.ToString());
                        sQLCommands.updateData("teachers", "quota", "sicilno", teacherList[tmp], teacherQuotaNum.ToString());
                        tmp++;
                        tmp = (tmp >= teacherList.Count) ? 0 : tmp;
                        teacherList = GetTeacherList();
                    }
                } 
            }
            else
            {
                for (int i = 0; i < studentData.Rows.Count; i++)
                {
                    DataRow studentRow = studentData.Rows[i];
                    teacherList = GetTeacherList();
                    string teacherid = teacherList[tmp];

                    for (int j = 0; j < lessonData.Rows.Count; j++)
                    {
                        DataRow lessonRow = lessonData.Rows[j];
                        int requestCount = sQLCommands.ultiGaripCount("*", "request_table", "senderid", studentRow["sicilno"].ToString(), "receiptid", teacherid, "status", "Onaylandı", "dersid", lessonRow["dersid"].ToString());
                        if (requestCount > 0)
                            continue;
                        string teacherQuota = sQLCommands.getValue("quota", "teachers", "sicilno= " + teacherid);
                        int.TryParse(teacherQuota, out int teacherQuotaNum);
                        string studentLessonNum = sQLCommands.getValue("numberoflesson", "students", "sicilno= " + studentRow["sicilno"].ToString());
                        int.TryParse(studentLessonNum, out int studentLessonNumber);
                        studentLessonNumber++;
                        teacherQuotaNum--;
                        sQLCommands.addRequest(studentRow["sicilno"].ToString(), teacherList[tmp], lessonRow["dersid"].ToString(), "Onaylandı");
                        sQLCommands.updateData("students", "numberoflesson", "sicilno", studentRow["sicilno"].ToString(), studentLessonNumber.ToString());
                        sQLCommands.updateData("teachers", "quota", "sicilno", teacherList[tmp], teacherQuotaNum.ToString());
                        if (teacherQuotaNum == 0) 
                        {
                            tmp++;
                            tmp = (tmp >= teacherList.Count) ? 0 : tmp;
                        }
                    }
                    tmp++;
                    tmp = (tmp >= teacherList.Count) ? 0 : tmp;
                }
            }
            dataGridView3.DataSource = sQLCommands.SpecialQuery2();
            dataGridView3.Columns["sicilno"].HeaderText = "SİCİLNO";
            dataGridView3.Columns["name"].HeaderText = "İSİM";
            dataGridView3.Columns["surname"].HeaderText = "SOYİSİM";
            dataGridView3.Columns["gpa"].HeaderText = "GPA";
            dataGridView3.Columns["numberoflesson"].HeaderText = "DERS SAYISI";

            dataGridView4.DataSource = sQLCommands.showDataTable("*", "acilandersler");
            dataGridView4.Columns["senderid"].HeaderText = "DERS ALAN";
            dataGridView4.Columns["receiptid"].HeaderText = "DERS VEREN";
            dataGridView4.Columns["dersid"].HeaderText = "DERS İD";
            dataGridView4.Columns["status"].HeaderText = "DURUM";
        }

        private void gpaSortButton_Click(object sender, EventArgs e)
        {
            this.dataGridView3.DataSource = sQLCommands.SpecialQuery3();
            sQLCommands.delete("request_table", "status", "Bekliyor");
            List<string> teacherList = GetTeacherList();
            DataTable lessonData = sQLCommands.showDataTable("*", "acilandersler");
            DataTable studentData = sQLCommands.SpecialQuery3();
            dataGridView3.DataSource = studentData;

            bool staticVeri = Settings.teacherStatus;
            int tmp = 0;


            if (staticVeri)
            {
                for (int i = 0; i < studentData.Rows.Count; i++)
                {
                    DataRow studentRow = studentData.Rows[i];
                    for (int j = 0; j < lessonData.Rows.Count; j++)
                    {
                        DataRow lessonRow = lessonData.Rows[j];
                        string teacherid = teacherList[tmp];
                        int requestCount = sQLCommands.ultiGaripCount("*", "request_table", "senderid", studentRow["sicilno"].ToString(), "receiptid", teacherid, "status", "Onaylandı", "dersid", lessonRow["dersid"].ToString());
                        if (requestCount > 0)
                            continue;
                        string teacherQuota = sQLCommands.getValue("quota", "teachers", "sicilno= " + teacherid);
                        int.TryParse(teacherQuota, out int teacherQuotaNum);
                        string studentLessonNum = sQLCommands.getValue("numberoflesson", "students", "sicilno= " + studentRow["sicilno"].ToString());
                        int.TryParse(studentLessonNum, out int studentLessonNumber);
                        studentLessonNumber++;
                        teacherQuotaNum--;
                        sQLCommands.addRequest(studentRow["sicilno"].ToString(), teacherList[tmp], lessonRow["dersid"].ToString(), "Onaylandı");
                        sQLCommands.updateData("students", "numberoflesson", "sicilno", studentRow["sicilno"].ToString(), studentLessonNumber.ToString());
                        sQLCommands.updateData("teachers", "quota", "sicilno", teacherList[tmp], teacherQuotaNum.ToString());
                        tmp++;
                        tmp = (tmp >= teacherList.Count) ? 0 : tmp;
                        teacherList = GetTeacherList();
                    }
                }
            }
            else
            {
                for (int i = 0; i < studentData.Rows.Count; i++)
                {
                    DataRow studentRow = studentData.Rows[i];
                    teacherList = GetTeacherList();
                    string teacherid = teacherList[tmp];

                    for (int j = 0; j < lessonData.Rows.Count; j++)
                    {
                        DataRow lessonRow = lessonData.Rows[j];
                        int requestCount = sQLCommands.ultiGaripCount("*", "request_table", "senderid", studentRow["sicilno"].ToString(), "receiptid", teacherid, "status", "Onaylandı", "dersid", lessonRow["dersid"].ToString());
                        if (requestCount > 0)
                            continue;
                        string teacherQuota = sQLCommands.getValue("quota", "teachers", "sicilno= " + teacherid);
                        int.TryParse(teacherQuota, out int teacherQuotaNum);
                        string studentLessonNum = sQLCommands.getValue("numberoflesson", "students", "sicilno= " + studentRow["sicilno"].ToString());
                        int.TryParse(studentLessonNum, out int studentLessonNumber);
                        studentLessonNumber++;
                        teacherQuotaNum--;
                        sQLCommands.addRequest(studentRow["sicilno"].ToString(), teacherList[tmp], lessonRow["dersid"].ToString(), "Onaylandı");
                        sQLCommands.updateData("students", "numberoflesson", "sicilno", studentRow["sicilno"].ToString(), studentLessonNumber.ToString());
                        sQLCommands.updateData("teachers", "quota", "sicilno", teacherList[tmp], teacherQuotaNum.ToString());
                        if (teacherQuotaNum == 0)
                        {
                            tmp++;
                            tmp = (tmp >= teacherList.Count) ? 0 : tmp;
                        }
                    }
                    tmp++;
                    tmp = (tmp >= teacherList.Count) ? 0 : tmp;
                }
            }
            dataGridView3.DataSource = sQLCommands.SpecialQuery3();
            dataGridView3.Columns["sicilno"].HeaderText = "SİCİLNO";
            dataGridView3.Columns["name"].HeaderText = "İSİM";
            dataGridView3.Columns["surname"].HeaderText = "SOYİSİM";
            dataGridView3.Columns["gpa"].HeaderText = "GPA";
            dataGridView3.Columns["numberoflesson"].HeaderText = "DERS SAYISI";

            dataGridView4.DataSource = sQLCommands.showDataTable("*","acilandersler");
            dataGridView4.Columns["senderid"].HeaderText = "DERS ALAN";
            dataGridView4.Columns["receiptid"].HeaderText = "DERS VEREN";
            dataGridView4.Columns["dersid"].HeaderText = "DERS İD";
            dataGridView4.Columns["status"].HeaderText = "DURUM";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            dataGridView5.DataSource = sQLCommands.showDataTable("*", "teachers");
            dataGridView5.Columns["sicilno"].HeaderText = "SİCİLNO";
            dataGridView5.Columns["name"].HeaderText = "İSİM";
            dataGridView5.Columns["surname"].HeaderText = "SOYİSİM";
            dataGridView5.Columns["quota"].HeaderText = "KONTENJAN";

            dataGridView6.DataSource = sQLCommands.showDataTable("*", "teachers_interest_table");
            dataGridView6.Columns["sicilno"].HeaderText = "SİCİLNO";
            dataGridView6.Columns["interests"].HeaderText = "İLGİ ALANLARI";

            TeacherListPanel.Visible = true;
            ShowPanel(TeacherListPanel);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowPanel(lessonAddPanel);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text) && string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Ders Adı ve Ders İD boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sQLCommands.addAcilanDersler(textBox5.Text, textBox4.Text);
                dataGridView7.DataSource = sQLCommands.showDataTable("*", "acilandersler");
                dataGridView7.Columns["dersid"].HeaderText = "DERS İD";
                dataGridView7.Columns["dersisim"].HeaderText = "DERS İSİM";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowPanel(usersPanel);

            dataGridView8.DataSource=sQLCommands.showDataTable("*", "users");
            dataGridView8.Columns["sicilno"].HeaderText = "SİCİL NO";
            dataGridView8.Columns["name"].HeaderText = "İSİM";
            dataGridView8.Columns["surname"].HeaderText = "SOYİSİM";
            dataGridView8.Columns["password"].HeaderText = "ŞİFRE";
            dataGridView8.Columns["type"].HeaderText = "TÜR";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int num);
            Random random = new Random();
            

            for (int i = 0; i < num; i++)
            {
                int id = random.Next(20000, 30000 + 1);
                int tmp = sQLCommands.dataCount("*", "users", "sicilno", id.ToString());
                while (tmp>0)
                {
                    id = random.Next(20000, 30000 + 1);
                    tmp = sQLCommands.dataCount("*", "users", "sicilno", id.ToString());
                }
                sQLCommands.addUser2(id.ToString(),"isim"+i, "soyisim"+i, "1234", "Student");
                string number = sQLCommands.getValue("sicilno", "public.users", "name= '" + "isim" + i + "' AND surname = '" + "soyisim" + i + "' and password='" + "1234" + "'");
                int rastgeleTamSayi = random.Next(200, 401);
                float gpa = (float)rastgeleTamSayi / 100.0f;
                sQLCommands.addStudents(number, "isim" + i, "soyisim" + i, gpa.ToString(), "0");
            }
            this.dataGridView9.DataSource = sQLCommands.showDataTable("*", "students");
            this.dataGridView9.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridView9.Columns["name"].HeaderText = "İSİM";
            this.dataGridView9.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView9.Columns["gpa"].HeaderText = "GPA";
            this.dataGridView9.Columns["numberoflesson"].HeaderText = "DERS SAYISI";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox2.Text, out int num);
            Random random = new Random();

            string[] ilgiAlanları = {"Bilgisayar Donanımı", "Görüntü İşleme", "Algoritmalar", "Doğal Dil İşlemesi", "Yapay Zeka",
                                    "Kriptoloji", "Veritabanı Sistemleri", "İşletim Sistemleri", "Bilgisayar Ağları",
                                    "Programlama Dilleri" };
            for (int i = 0; i < num; i++)
            {
                int id = random.Next(20000, 30000 + 1);
                int tmp = sQLCommands.dataCount("*", "users", "sicilno", id.ToString());
                while (tmp > 0)
                {
                    id = random.Next(20000, 30000 + 1);
                    tmp = sQLCommands.dataCount("*", "users", "sicilno", id.ToString());
                }
                sQLCommands.addUser2(id.ToString(),"hocaisim"+i, "hocasoyisim"+i, "hoca1234", "Teacher");
                string number = sQLCommands.getValue("sicilno", "public.users", "name= '" + "hocaisim" + i + "' AND surname = '" + "hocasoyisim" + i + "' and password='" + "hoca1234" + "'");
                sQLCommands.addTeachers(number, "hocaisim" + i, "hocasoyisim" + i, "40");
                int rastgeleSayi = random.Next(0, ilgiAlanları.Length);
                sQLCommands.addTeachersInterest(number, ilgiAlanları[rastgeleSayi]);
            }
            this.dataGridView10.DataSource = sQLCommands.showDataTable("*", "teachers");
            this.dataGridView10.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridView10.Columns["name"].HeaderText = "İSİM";
            this.dataGridView10.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView10.Columns["quota"].HeaderText = "KONTENJAN";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowPanel(otoUsersPanel);

            this.dataGridView10.DataSource = sQLCommands.showDataTable("*", "teachers");
            this.dataGridView10.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridView10.Columns["name"].HeaderText = "İSİM";
            this.dataGridView10.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView10.Columns["quota"].HeaderText = "KONTENJAN";

            this.dataGridView9.DataSource = sQLCommands.showDataTable("*", "students");
            this.dataGridView9.Columns["sicilno"].HeaderText = "SİCİLNO";
            this.dataGridView9.Columns["name"].HeaderText = "İSİM";
            this.dataGridView9.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView9.Columns["gpa"].HeaderText = "GPA";
            this.dataGridView9.Columns["numberoflesson"].HeaderText = "DERS SAYISI";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowPanel(panel2);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Settings.teacherStatus = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Settings.teacherStatus = true;
        }
    }
}
