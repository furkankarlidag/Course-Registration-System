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
    public partial class LoginPanel : Form
    {
        
        public LoginPanel()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string password = this.passwordTextBox.Text;
            int sicilID = int.Parse(this.usernameTextBox.Text);



            SQLCommands sQLCommands = new SQLCommands();
            if (sQLCommands.control(sicilID, password) == "Student" || sQLCommands.control(sicilID, password) == "student")
            {
                studentForm studentForm = new studentForm(sicilID);
                studentForm.Visible = true;

            }

            else if (sQLCommands.control(sicilID, password) == "Teacher" || sQLCommands.control(sicilID, password) == "teacher")
            {
                teacherPanel teacherPanel = new teacherPanel(sicilID);
                teacherPanel.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
            }

            else if (sQLCommands.control(sicilID, password) == "admin")
            {
                AdministratorPanel adminPanel = new AdministratorPanel();
                adminPanel.Visible = true;
                timer1.Interval = 1000;
                timer1.Start();
            }

            else
            {
                MessageBox.Show("Sicil no veya sifre yanlis!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        

        private void LoginPanel_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
