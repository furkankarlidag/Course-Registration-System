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
            //studentpanel studentPanel = new studentpanel();
            AdministratorPanel adminPanel = new AdministratorPanel();
            //teacherpanel teacherPanel = new teacherpanel();
            SQLCommands sQLCommands = new SQLCommands();
            if (sQLCommands.control(sicilID, password) == "student")
            {
                //studentPanel.Visible = true;

            }

            else if (sQLCommands.control(sicilID, password) == "teacher")
            {
                //teacherPanel.Visible = true;
            }

            else if (sQLCommands.control(sicilID, password) == "admin")
            {
                adminPanel.Visible = true;
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
