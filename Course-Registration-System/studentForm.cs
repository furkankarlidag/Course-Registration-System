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
    public partial class studentForm : Form
    {
        int sicilNo;
        
        public studentForm(int sicilNo)
        {
            InitializeComponent();
            this.sicilNo = sicilNo;
            sicilID.Text = sicilNo.ToString();
            SQLCommands sQLCommands = new SQLCommands();
            List<string> studentInfo  = sQLCommands.getInfoAboutStudent(sicilNo);
            name.Text = studentInfo[0];
            surname.Text = studentInfo[1];
            subPanels.Add(messagePanel);
            subPanels.Add(mainPanel);
            subPanels.Add(acilanDerslerPanel);
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            foreach(Panel panel in subPanels)
            {
                panel.Visible = false;
            }
            messagePanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in subPanels)
            {
                panel.Visible = false;
            }
            scanPDF transkriptPanel = new scanPDF(sicilNo);
         
            transkriptPanel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Panel panel1 in subPanels)
            {
                panel1.Visible = false;
            }

            int panelSize = 80;
            int labelSize = 19;
            SQLCommands sQLCommands = new SQLCommands();
            List<Panel> panels = new List<Panel>();
            List<string> dersIDler = sQLCommands.showCloumn("dersID", "acilandersler");
            for (int i = 0; i < dersIDler.Count; i++) {
                
                
                List<string> dersIsimler = sQLCommands.showCloumn("dersisim", "acilandersler");
                Panel panel = new Panel();
                panel.BackColor = System.Drawing.Color.LimeGreen;
                Label label = new Label();
                panel.Controls.Add(label);
                panel.Location = new System.Drawing.Point(28, panelSize + i*75);
                panel.Name = "panel3";
                panel.Size = new System.Drawing.Size(683, 59);
                panel.TabIndex = 1;

                
                
                label.BackColor = System.Drawing.Color.White;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Location = new System.Drawing.Point(15, 19);
                label.Name = "label1";
                label.Size = new System.Drawing.Size(652, 26);
                label.TabIndex = 0;
                label.Text = dersIDler[i] + " - " + dersIsimler[i];
               

                acilanDerslerPanel.Controls.Add(panel);
                

            }
            acilanDerslerPanel.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
