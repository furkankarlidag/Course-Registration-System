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

            panel.Visible = true;
        }

        private void TeacherInterestAddButton_Click(object sender, EventArgs e)
        {
            ShowPanel(teacherInterestPanel);

            sQLCommands.updateData("teachers_interest_table", "interests", "sicilno", teacherId.ToString(), teacherInterstAddTextBox.Text);


        }

        private void teacherLessonRequestbutton_Click(object sender, EventArgs e)
        {
            int teacherRequestCount = sQLCommands.dataCount("*", "request_table", "status", "Bekliyor");
            DataTable dataTable= sQLCommands.showQueryDataTable("*", "request_table", "status", "Bekliyor");



        }

        private void lessonRequestAcceptButton_Click(object sender, EventArgs e)
        {

        }

        private void lessonRequestDeclineButton_Click(object sender, EventArgs e)
        {

        }
    }

}
