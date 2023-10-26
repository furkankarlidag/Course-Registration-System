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
    public partial class AdministratorPanel : Form
    {
        SQLCommands sQLCommands = new SQLCommands();
        public AdministratorPanel()
        {
            InitializeComponent();
            this.studentPanel.Visible = false;
            this.teacherPanel.Visible = false;
        }

        void ShowPanel(Panel panel) 
        {
            this.studentPanel.Visible= false;
            this.teacherPanel.Visible = false;

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
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 405);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.DataSource = sQLCommands.showDataTable("name,surname,gpa,numberoflesson", "students");
            this.dataGridView1.Columns["name"].HeaderText= "İSİM";
            this.dataGridView1.Columns["surname"].HeaderText = "SOYİSİM";
            this.dataGridView1.Columns["gpa"].HeaderText = "GPA";
            this.dataGridView1.Columns["numberoflesson"].HeaderText = "DERS SAYISI";

            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            ShowPanel(studentPanel);
        }

        void TeacherPanelComponent() 
        {
            this.teacherDelete = new System.Windows.Forms.Button();
            this.teacherUpdate = new System.Windows.Forms.Button();
            this.teacherAdd = new System.Windows.Forms.Button();
            this.teacherPanel.SuspendLayout();

            // 
            // teacherPanel
            // 
            this.teacherPanel.Controls.Add(this.teacherDelete);
            this.teacherPanel.Controls.Add(this.teacherUpdate);
            this.teacherPanel.Controls.Add(this.teacherAdd);
            this.teacherPanel.Location = new System.Drawing.Point(206, 12);
            this.teacherPanel.Name = "teacherPanel";
            this.teacherPanel.Size = new System.Drawing.Size(979, 737);
            this.teacherPanel.TabIndex = 11;
            // 
            // teacherDelete
            // 
            this.teacherDelete.BackColor = System.Drawing.Color.Transparent;
            this.teacherDelete.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.teacherDelete.FlatAppearance.BorderSize = 2;
            this.teacherDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.teacherDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherDelete.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherDelete.Location = new System.Drawing.Point(365, 3);
            this.teacherDelete.Name = "teacherDelete";
            this.teacherDelete.Size = new System.Drawing.Size(175, 50);
            this.teacherDelete.TabIndex = 3;
            this.teacherDelete.Text = "Hoca Sil";
            this.teacherDelete.UseVisualStyleBackColor = false;
            // 
            // teacherUpdate
            // 
            this.teacherUpdate.BackColor = System.Drawing.Color.Transparent;
            this.teacherUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.teacherUpdate.FlatAppearance.BorderSize = 2;
            this.teacherUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.teacherUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherUpdate.Location = new System.Drawing.Point(184, 3);
            this.teacherUpdate.Name = "teacherUpdate";
            this.teacherUpdate.Size = new System.Drawing.Size(175, 50);
            this.teacherUpdate.TabIndex = 2;
            this.teacherUpdate.Text = "Hoca Düzenle";
            this.teacherUpdate.UseVisualStyleBackColor = false;
            // 
            // teacherAdd
            // 
            this.teacherAdd.BackColor = System.Drawing.Color.Transparent;
            this.teacherAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.teacherAdd.FlatAppearance.BorderSize = 2;
            this.teacherAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.teacherAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.teacherAdd.Location = new System.Drawing.Point(3, 3);
            this.teacherAdd.Name = "teacherAdd";
            this.teacherAdd.Size = new System.Drawing.Size(175, 50);
            this.teacherAdd.TabIndex = 1;
            this.teacherAdd.Text = "Hoca Ekle";
            this.teacherAdd.UseVisualStyleBackColor = false;

            ShowPanel(teacherPanel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentPanelComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TeacherPanelComponent();
        }

        
    }
}
