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
    public partial class studentForm : Form
    {
        int sicilNo;


        public studentForm(int sicilNo)
        {
            InitializeComponent();
            this.sicilNo = sicilNo;
            sicilID.Text = sicilNo.ToString();
            SQLCommands sQLCommands = new SQLCommands();
            List<string> studentInfo = sQLCommands.getInfoAboutStudent(sicilNo);
            name.Text = studentInfo[0];
            surname.Text = studentInfo[1];
            subPanels.Add(messagePanel);
            subPanels.Add(mainPanel);
            subPanels.Add(acilanDerslerPanel);
            subPanels.Add(messageSendPanel);
            comboBoxFill();
            loadMessages();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            foreach (Panel panel in subPanels)
            {
                panel.Visible = false;
            }

            SQLCommands sQLCommands = new SQLCommands();
            int YEkseni = 14;
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
                    command.Parameters.AddWithValue("p1", sicilNo);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            senderid = reader.GetInt32(0);
                            message = reader.GetString(1);

                            Panel panel68 = new Panel();
                            Label label88 = new Label();
                            Label label98 = new Label();
                            Button button68 = new Button();

                            panel68.BackColor = System.Drawing.Color.MediumSeaGreen;
                            panel68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                            panel68.Controls.Add(button68);
                            panel68.Controls.Add(label98);
                            panel68.Controls.Add(label88);
                            panel68.Location = new System.Drawing.Point(20, YEkseni + i*160);
                            panel68.Name = "panel6";
                            panel68.Size = new System.Drawing.Size(668, 131);
                            panel68.TabIndex = 0;
                            // 
                            // label8
                            // 
                            label88.AutoSize = true;
                            label88.Font = new System.Drawing.Font("Microsoft YaHei", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label88.ForeColor = System.Drawing.SystemColors.Control;
                            label88.Location = new System.Drawing.Point(5, 10);
                            label88.Name = "label8";
                            label88.Size = new System.Drawing.Size(100, 19);
                            label88.TabIndex = 0;
                            label88.Text = "GÖNDERİCİ: " + sQLCommands.getInfoAboutTeacher(senderid);
                            // 
                            // label9
                            // 
                            label98.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label98.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                            label98.Location = new System.Drawing.Point(5, 35);
                            label98.Name = "label9";
                            label98.Size = new System.Drawing.Size(649, 92);
                            label98.TabIndex = 1;
                            label98.Text = "MESAJ: " + message;
                            // 
                            // button6
                            // 
                            button68.BackColor = System.Drawing.Color.Red;
                            button68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            button68.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                            button68.Location = new System.Drawing.Point(583, 6);
                            button68.Name = "button6";
                            button68.Size = new System.Drawing.Size(75, 23);
                            button68.TabIndex = 2;
                            button68.Text = " SIL";
                            button68.UseVisualStyleBackColor = false;
                            gelenmesaj.Controls.Add(panel68);
                            messagePanel.Controls.Add(gelenmesaj);
                            i++;
                        }
                    }
                }
            }

            
            messagePanel.Visible = true;


        }

        public void comboBoxFill()
        {
            SQLCommands sQLCommands = new SQLCommands();
            List<int> teacherIDList = sQLCommands.returnTeacher();
            for (int i = 0; i < teacherIDList.Count; i++)
            {
                comboBox1.Items.Add(sQLCommands.getInfoAboutTeacher(teacherIDList[i]));
            }
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
            for (int i = 0; i < dersIDler.Count; i++)
            {


                List<string> dersIsimler = sQLCommands.showCloumn("dersisim", "acilandersler");
                Panel panel = new Panel();
                panel.BackColor = System.Drawing.Color.LimeGreen;
                Label label = new Label();
                panel.Controls.Add(label);
                panel.Location = new System.Drawing.Point(28, panelSize + i * 75);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            Console.WriteLine(textBox1.Text);
            
            SQLCommands sQLCommands = new SQLCommands();
           
            //Console.WriteLine(sQLCommands.findUserID("teachers", comboBox1.SelectedText));
            sQLCommands.sendRequest(sicilNo, sQLCommands.findUserID("teachers", comboBox1.SelectedItem.ToString()), textBox1.Text, 8);
            textBox1.Text = "Mesajinizi buraya giriniz!.";
            MessageBox.Show("Mesajiniz basairiyla gonderdildi.", "Basarili Islem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadMessages();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (Panel panel1 in subPanels)
            {
                panel1.Visible = false;
            }
            messageSendPanel.Visible = true;
        }
       

        public void loadMessages()
        {
            SQLCommands sQLCommands = new SQLCommands();
            int panelY = 23;
            string message = string.Empty;
            int receiptid = 0;
            int i = 0;
            string connectionString = "server=localHost; port=5432; Database=yazlab; user ID=postgres; password=12345";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT receiptid, message FROM messages where senderid=@p1";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("p1", sicilNo);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            receiptid = reader.GetInt32(0);
                            message = reader.GetString(1);

                            Panel panel5 = new Panel();
                            panel5.BackColor = System.Drawing.Color.ForestGreen;
                            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                            panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                            panel5.Location = new System.Drawing.Point(23, panelY + i * 130);
                            panel5.Name = "panel5";
                            panel5.Size = new System.Drawing.Size(660, 99);
                            panel5.TabIndex = 0;
                            Label label55 = new Label();
                            Label label66 = new Label();
                            label55.AutoSize = true;
                            label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label55.Location = new System.Drawing.Point(7, 8);
                            label55.Name = "label5";
                            label55.Size = new System.Drawing.Size(47, 16);
                            label55.TabIndex = 0;
                            label55.Text = "ALICI: " + sQLCommands.getInfoAboutTeacher(receiptid);


                            label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label66.ForeColor = System.Drawing.Color.White;
                            label66.Location = new System.Drawing.Point(7, 24);
                            label66.Name = "label6";
                            label66.Size = new System.Drawing.Size(646, 63);
                            label66.TabIndex = 1;
                            label66.Text = "MESAJ: " + message;
                            panel5.Controls.Add(label66);
                            panel5.Controls.Add(label55);
                            panel4.Controls.Add(panel5);
                            i++;
                        }
                    }
                }
            }



        }


    }
}
