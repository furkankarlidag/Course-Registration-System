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
            //this.studentPanel = new System.Windows.Forms.Panel();
            this.studentAdd = new System.Windows.Forms.Button();
            this.studentUpdate = new System.Windows.Forms.Button();
            this.studentRemove = new System.Windows.Forms.Button();
            this.studentPanel.SuspendLayout();

            // 
            // studentPanel
            // 
            this.studentPanel.Controls.Add(this.studentRemove);
            this.studentPanel.Controls.Add(this.studentUpdate);
            this.studentPanel.Controls.Add(this.studentAdd);
            this.studentPanel.Location = new System.Drawing.Point(193, 12);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(979, 737);
            this.studentPanel.TabIndex = 10;
            // 
            // studentAdd
            // 
            this.studentAdd.BackColor = System.Drawing.Color.Transparent;
            this.studentAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.studentAdd.FlatAppearance.BorderSize = 2;
            this.studentAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.studentAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentAdd.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentAdd.Location = new System.Drawing.Point(3, 3);
            this.studentAdd.Name = "studentAdd";
            this.studentAdd.Size = new System.Drawing.Size(175, 50);
            this.studentAdd.TabIndex = 1;
            this.studentAdd.Text = "Öğrenci Ekle";
            this.studentAdd.UseVisualStyleBackColor = false;
            // 
            // studentUpdate
            // 
            this.studentUpdate.BackColor = System.Drawing.Color.Transparent;
            this.studentUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.studentUpdate.FlatAppearance.BorderSize = 2;
            this.studentUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.studentUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentUpdate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentUpdate.Location = new System.Drawing.Point(184, 3);
            this.studentUpdate.Name = "studentUpdate";
            this.studentUpdate.Size = new System.Drawing.Size(175, 50);
            this.studentUpdate.TabIndex = 2;
            this.studentUpdate.Text = "Öğrenci Düzenle";
            this.studentUpdate.UseVisualStyleBackColor = false;
            // 
            // studentRemove
            // 
            this.studentRemove.BackColor = System.Drawing.Color.Transparent;
            this.studentRemove.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.studentRemove.FlatAppearance.BorderSize = 2;
            this.studentRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.studentRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentRemove.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.studentRemove.Location = new System.Drawing.Point(365, 3);
            this.studentRemove.Name = "studentRemove";
            this.studentRemove.Size = new System.Drawing.Size(175, 50);
            this.studentRemove.TabIndex = 3;
            this.studentRemove.Text = "Öğrenci Sil";
            this.studentRemove.UseVisualStyleBackColor = false;

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
