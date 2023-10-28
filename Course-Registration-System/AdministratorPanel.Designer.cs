namespace Course_Registration_System
{
    partial class AdministratorPanel
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.studentPanel = new System.Windows.Forms.Panel();
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
            this.StudentListPanel = new System.Windows.Forms.Panel();
            this.dataGridViewUsersStudentsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudentsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudentLessonList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.StudentListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersStudentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentLessonList)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğrenci Düzenleme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Öğrenci Listeleme";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(12, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hoca Düzenleme";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(12, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Hoca Listeleme";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(12, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(175, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "Öğrenci-Hoca Seçimi";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(12, 347);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "Talepler";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(12, 403);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 50);
            this.button7.TabIndex = 6;
            this.button7.Text = "Kullanıcılar";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button8.FlatAppearance.BorderSize = 2;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(12, 459);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(175, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "Otomatik Atamalar";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button9.FlatAppearance.BorderSize = 2;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(12, 515);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(175, 50);
            this.button9.TabIndex = 8;
            this.button9.Text = "Otomatik Kullanıcılar";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button10.FlatAppearance.BorderSize = 2;
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(12, 571);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(175, 50);
            this.button10.TabIndex = 9;
            this.button10.Text = "Ayarlar";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // studentPanel
            // 
            this.studentPanel.Location = new System.Drawing.Point(0, 0);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(200, 100);
            this.studentPanel.TabIndex = 0;
            // 
            // StudentUpdateButton
            // 
            this.StudentUpdateButton.Location = new System.Drawing.Point(0, 0);
            this.StudentUpdateButton.Name = "StudentUpdateButton";
            this.StudentUpdateButton.Size = new System.Drawing.Size(75, 23);
            this.StudentUpdateButton.TabIndex = 0;
            // 
            // StudentAddButton
            // 
            this.StudentAddButton.Location = new System.Drawing.Point(0, 0);
            this.StudentAddButton.Name = "StudentAddButton";
            this.StudentAddButton.Size = new System.Drawing.Size(75, 23);
            this.StudentAddButton.TabIndex = 0;
            // 
            // numberlessonTextBox
            // 
            this.numberlessonTextBox.Location = new System.Drawing.Point(0, 0);
            this.numberlessonTextBox.Name = "numberlessonTextBox";
            this.numberlessonTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberlessonTextBox.TabIndex = 0;
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(0, 0);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(100, 20);
            this.gpaTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(0, 0);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 0;
            // 
            // surnameTextBox1
            // 
            this.surnameTextBox1.Location = new System.Drawing.Point(0, 0);
            this.surnameTextBox1.Name = "surnameTextBox1";
            this.surnameTextBox1.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox1.TabIndex = 0;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(0, 0);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // numberOfLessonAdd
            // 
            this.numberOfLessonAdd.Location = new System.Drawing.Point(0, 0);
            this.numberOfLessonAdd.Name = "numberOfLessonAdd";
            this.numberOfLessonAdd.Size = new System.Drawing.Size(100, 23);
            this.numberOfLessonAdd.TabIndex = 0;
            // 
            // gpaAdd
            // 
            this.gpaAdd.Location = new System.Drawing.Point(0, 0);
            this.gpaAdd.Name = "gpaAdd";
            this.gpaAdd.Size = new System.Drawing.Size(100, 23);
            this.gpaAdd.TabIndex = 0;
            // 
            // passwordAdd
            // 
            this.passwordAdd.Location = new System.Drawing.Point(0, 0);
            this.passwordAdd.Name = "passwordAdd";
            this.passwordAdd.Size = new System.Drawing.Size(100, 23);
            this.passwordAdd.TabIndex = 0;
            // 
            // surnameAdd
            // 
            this.surnameAdd.Location = new System.Drawing.Point(0, 0);
            this.surnameAdd.Name = "surnameAdd";
            this.surnameAdd.Size = new System.Drawing.Size(100, 23);
            this.surnameAdd.TabIndex = 0;
            // 
            // NameAdd
            // 
            this.NameAdd.Location = new System.Drawing.Point(0, 0);
            this.NameAdd.Name = "NameAdd";
            this.NameAdd.Size = new System.Drawing.Size(100, 23);
            this.NameAdd.TabIndex = 0;
            // 
            // npgsqlDataAdapter1
            // 
            this.npgsqlDataAdapter1.DeleteCommand = null;
            this.npgsqlDataAdapter1.InsertCommand = null;
            this.npgsqlDataAdapter1.SelectCommand = null;
            this.npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // teacherPanel
            // 
            this.teacherPanel.Location = new System.Drawing.Point(0, 0);
            this.teacherPanel.Name = "teacherPanel";
            this.teacherPanel.Size = new System.Drawing.Size(200, 100);
            this.teacherPanel.TabIndex = 0;
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // numberlessonUpdateTextBox
            // 
            this.numberlessonUpdateTextBox.Location = new System.Drawing.Point(0, 0);
            this.numberlessonUpdateTextBox.Name = "numberlessonUpdateTextBox";
            this.numberlessonUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberlessonUpdateTextBox.TabIndex = 0;
            // 
            // gpaUpdateTextBox
            // 
            this.gpaUpdateTextBox.Location = new System.Drawing.Point(0, 0);
            this.gpaUpdateTextBox.Name = "gpaUpdateTextBox";
            this.gpaUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.gpaUpdateTextBox.TabIndex = 0;
            // 
            // passwordUpdateTextBox
            // 
            this.passwordUpdateTextBox.Location = new System.Drawing.Point(0, 0);
            this.passwordUpdateTextBox.Name = "passwordUpdateTextBox";
            this.passwordUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordUpdateTextBox.TabIndex = 0;
            // 
            // surnameUpdateTextBox
            // 
            this.surnameUpdateTextBox.Location = new System.Drawing.Point(0, 0);
            this.surnameUpdateTextBox.Name = "surnameUpdateTextBox";
            this.surnameUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameUpdateTextBox.TabIndex = 0;
            // 
            // nameUpdateTextBox
            // 
            this.nameUpdateTextBox.Location = new System.Drawing.Point(0, 0);
            this.nameUpdateTextBox.Name = "nameUpdateTextBox";
            this.nameUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameUpdateTextBox.TabIndex = 0;
            // 
            // numberOfLessonUpdate
            // 
            this.numberOfLessonUpdate.Location = new System.Drawing.Point(0, 0);
            this.numberOfLessonUpdate.Name = "numberOfLessonUpdate";
            this.numberOfLessonUpdate.Size = new System.Drawing.Size(100, 23);
            this.numberOfLessonUpdate.TabIndex = 0;
            // 
            // gpaUpdate
            // 
            this.gpaUpdate.Location = new System.Drawing.Point(0, 0);
            this.gpaUpdate.Name = "gpaUpdate";
            this.gpaUpdate.Size = new System.Drawing.Size(100, 23);
            this.gpaUpdate.TabIndex = 0;
            // 
            // passwordUpdate
            // 
            this.passwordUpdate.Location = new System.Drawing.Point(0, 0);
            this.passwordUpdate.Name = "passwordUpdate";
            this.passwordUpdate.Size = new System.Drawing.Size(100, 23);
            this.passwordUpdate.TabIndex = 0;
            // 
            // surnameUpdate
            // 
            this.surnameUpdate.Location = new System.Drawing.Point(0, 0);
            this.surnameUpdate.Name = "surnameUpdate";
            this.surnameUpdate.Size = new System.Drawing.Size(100, 23);
            this.surnameUpdate.TabIndex = 0;
            // 
            // NameUpdate
            // 
            this.NameUpdate.Location = new System.Drawing.Point(0, 0);
            this.NameUpdate.Name = "NameUpdate";
            this.NameUpdate.Size = new System.Drawing.Size(100, 23);
            this.NameUpdate.TabIndex = 0;
            // 
            // surnameRemoveTextBox
            // 
            this.surnameRemoveTextBox.Location = new System.Drawing.Point(0, 0);
            this.surnameRemoveTextBox.Name = "surnameRemoveTextBox";
            this.surnameRemoveTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameRemoveTextBox.TabIndex = 0;
            // 
            // nameRemoveTextBox
            // 
            this.nameRemoveTextBox.Location = new System.Drawing.Point(0, 0);
            this.nameRemoveTextBox.Name = "nameRemoveTextBox";
            this.nameRemoveTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameRemoveTextBox.TabIndex = 0;
            // 
            // surnameRemove
            // 
            this.surnameRemove.Location = new System.Drawing.Point(0, 0);
            this.surnameRemove.Name = "surnameRemove";
            this.surnameRemove.Size = new System.Drawing.Size(100, 23);
            this.surnameRemove.TabIndex = 0;
            // 
            // NameRemove
            // 
            this.NameRemove.Location = new System.Drawing.Point(0, 0);
            this.NameRemove.Name = "NameRemove";
            this.NameRemove.Size = new System.Drawing.Size(100, 23);
            this.NameRemove.TabIndex = 0;
            // 
            // StudentRemoveButton
            // 
            this.StudentRemoveButton.Location = new System.Drawing.Point(0, 0);
            this.StudentRemoveButton.Name = "StudentRemoveButton";
            this.StudentRemoveButton.Size = new System.Drawing.Size(75, 23);
            this.StudentRemoveButton.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // StudentListPanel
            // 
            this.StudentListPanel.Controls.Add(this.dataGridViewStudentLessonList);
            this.StudentListPanel.Controls.Add(this.dataGridViewStudentsList);
            this.StudentListPanel.Controls.Add(this.dataGridViewUsersStudentsList);
            this.StudentListPanel.Location = new System.Drawing.Point(193, 7);
            this.StudentListPanel.Name = "StudentListPanel";
            this.StudentListPanel.Size = new System.Drawing.Size(979, 742);
            this.StudentListPanel.TabIndex = 10;
            // 
            // dataGridViewUsersStudentsList
            // 
            this.dataGridViewUsersStudentsList.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridViewUsersStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsersStudentsList.Location = new System.Drawing.Point(14, 24);
            this.dataGridViewUsersStudentsList.Name = "dataGridViewUsersStudentsList";
            this.dataGridViewUsersStudentsList.Size = new System.Drawing.Size(936, 220);
            this.dataGridViewUsersStudentsList.TabIndex = 0;
            // 
            // dataGridViewStudentsList
            // 
            this.dataGridViewStudentsList.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridViewStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentsList.Location = new System.Drawing.Point(14, 250);
            this.dataGridViewStudentsList.Name = "dataGridViewStudentsList";
            this.dataGridViewStudentsList.Size = new System.Drawing.Size(936, 220);
            this.dataGridViewStudentsList.TabIndex = 1;
            // 
            // dataGridViewStudentLessonList
            // 
            this.dataGridViewStudentLessonList.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridViewStudentLessonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentLessonList.Location = new System.Drawing.Point(14, 476);
            this.dataGridViewStudentLessonList.Name = "dataGridViewStudentLessonList";
            this.dataGridViewStudentLessonList.Size = new System.Drawing.Size(936, 220);
            this.dataGridViewStudentLessonList.TabIndex = 2;
            // 
            // AdministratorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.StudentListPanel);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "AdministratorPanel";
            this.Text = "AdministratorPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.StudentListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsersStudentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentLessonList)).EndInit();
            this.ResumeLayout(false);

        }
        //BU amınakodumun windows formu yorum satırını silmiş
        //this.Controls.Add(this.teacherPanel); eklemeyi unutma buda silinirse ta amk
        //this.Controls.Add(this.studentPanel);
        //this.Controls.Add(this.teacherPanel);
        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel studentPanel;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.Panel teacherPanel;
        private System.Windows.Forms.Button teacherDelete;
        private System.Windows.Forms.Button teacherUpdate;
        private System.Windows.Forms.Button teacherAdd;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private System.Windows.Forms.Button StudentUpdateButton;
        private System.Windows.Forms.Button StudentAddButton;
        private System.Windows.Forms.TextBox numberlessonTextBox;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox surnameTextBox1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label numberOfLessonAdd;
        private System.Windows.Forms.Label gpaAdd;
        private System.Windows.Forms.Label passwordAdd;
        private System.Windows.Forms.Label surnameAdd;
        private System.Windows.Forms.Label NameAdd;
        private System.Windows.Forms.TextBox surnameRemoveTextBox;
        private System.Windows.Forms.TextBox nameRemoveTextBox;
        private System.Windows.Forms.Label surnameRemove;
        private System.Windows.Forms.Label NameRemove;
        private System.Windows.Forms.Button StudentRemoveButton;
        private System.Windows.Forms.TextBox numberlessonUpdateTextBox;
        private System.Windows.Forms.TextBox gpaUpdateTextBox;
        private System.Windows.Forms.TextBox passwordUpdateTextBox;
        private System.Windows.Forms.TextBox surnameUpdateTextBox;
        private System.Windows.Forms.TextBox nameUpdateTextBox;
        private System.Windows.Forms.Label numberOfLessonUpdate;
        private System.Windows.Forms.Label gpaUpdate;
        private System.Windows.Forms.Label passwordUpdate;
        private System.Windows.Forms.Label surnameUpdate;
        private System.Windows.Forms.Label NameUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel StudentListPanel;
        private System.Windows.Forms.DataGridView dataGridViewStudentLessonList;
        private System.Windows.Forms.DataGridView dataGridViewStudentsList;
        private System.Windows.Forms.DataGridView dataGridViewUsersStudentsList;
    }
}