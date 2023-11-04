using iTextSharp.text.pdf.parser.clipper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            subPanels.Add(comingMessagePanel);
            subPanels.Add(mainPanel);
            subPanels.Add(denemePanel);
            subPanels.Add(acilanDerslerPanel);
            subPanels.Add(messageSendPanel);
            subPanels.Add(choosingPanel);
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
            int messageno = 0;
            int i = 0;

            List<int> receiptIDList = sQLCommands.showColumnInt("receiptid", "messages", "receiptid", sicilNo);
            List<int> senderIDList = sQLCommands.showColumnInt("senderid", "messages", "receiptid", sicilNo);
            List<string> messageList = sQLCommands.showColumnString("message", "messages", "receiptid", sicilNo);
            List<int> messageNoList = sQLCommands.showColumnInt("messageno", "messages", "receiptid", sicilNo);

            for (int j = 0; j < receiptIDList.Count; j++)
            {
                senderid = senderIDList[j];
                message = messageList[j];
                messageno = messageNoList[j];

                Panel panel68 = new Panel();
                Label label88 = new Label();
                Label label98 = new Label();
                Button button68 = new Button();

                panel68.BackColor = System.Drawing.Color.MediumSeaGreen;
                // panel68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                panel68.Controls.Add(button68);
                panel68.Controls.Add(label98);
                panel68.Controls.Add(label88);
                panel68.Location = new System.Drawing.Point(20, YEkseni + i * 160);
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


                gelenmesaj.Controls.Add(panel68);

                i++;
            }
            comingMessagePanel.Controls.Add(gelenmesaj);
            comingMessagePanel.Visible = true;

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
            Random random = new Random();
            //Console.WriteLine(sQLCommands.findUserID("teachers", comboBox1.SelectedText));
            sQLCommands.sendMessage(sicilNo, sQLCommands.findUserID("teachers", comboBox1.SelectedItem.ToString()), textBox1.Text, random.Next(1, 100));
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
            this.panel4.Controls.Clear();
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
                            panel5.BackColor = System.Drawing.Color.MediumSeaGreen;
                            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                            // panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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


        private void button3_Click(object sender, EventArgs e)
        {

            foreach (Panel panel1 in subPanels)
            {
                panel1.Visible = false;
            }

            SQLCommands sQLCommands = new SQLCommands();
            int sizeY = 12;
            string interest = string.Empty;
            int teacherID = 0;
            int i = 0;
            string connectionString = "server=localHost; port=5432; Database=yazlab; user ID=postgres; password=12345";
            this.panel6.Controls.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT sicilno, interests FROM teachers_interest_table ";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("p1", sicilNo);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teacherID = reader.GetInt32(0);
                            interest = reader.GetString(1);

                            Label label96 = new Label();
                            if (!this.interestsComboBox.Items.Contains(interest))
                            {
                                this.interestsComboBox.Items.Add(interest);
                            }
                            label96.BackColor = System.Drawing.Color.Teal;
                            //label96.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                            label96.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label96.ForeColor = System.Drawing.SystemColors.Control;
                            label96.Location = new System.Drawing.Point(11, sizeY + i * 35);
                            label96.Name = "label9";
                            label96.Size = new System.Drawing.Size(709, 27);
                            label96.TabIndex = 1;
                            label96.Text = sQLCommands.getInfoAboutTeacher(teacherID) + " - " + interest +
                                "     *** Kontenjan: " + sQLCommands.numOfQuote(teacherID);
                            this.panel6.Controls.Add(label96);

                            
                            string deneme = sQLCommands.getInfoAboutTeacher(teacherID);
                            comboBox2.Items.Add(sQLCommands.getInfoAboutTeacher(teacherID));
                            i++;
                        }
                    }
                }
                connection.Close();
                List<string> dersisimler = sQLCommands.showCloumn("dersisim", "acilandersler");

                for (int j = 0; j < dersisimler.Count; j++)
                {
                    comboBox3.Items.Add(dersisimler[j]);
                }
                if (sQLCommands.compareLessons(sicilNo))
                {
                    choosingPanel.Controls.Remove(this.panel7);
                    Panel panel77 = new Panel();
                    panel77.BackColor = System.Drawing.Color.Red;
                    panel77.Location = new System.Drawing.Point(19, 346);
                    panel77.Name = "panel77";
                    panel77.Size = new System.Drawing.Size(727, 177);
                    panel77.TabIndex = 5;

                    Label label = new Label();
                    label.AutoSize = true;
                    label.BackColor = System.Drawing.Color.Transparent;
                    label.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label.ForeColor = System.Drawing.Color.White;
                    label.Text = "ACILAN TUM DERSLERI SECTINIZ!!!";
                    label.Location = new System.Drawing.Point(180, 75);

                    label.Size = new System.Drawing.Size(243, 26);
                    panel77.Controls.Add(label);
                    choosingPanel.Controls.Add(panel77);
                }
                choosingPanel.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SQLCommands sQLCommands = new SQLCommands();
            if (!sQLCommands.lessonsControl(sicilNo))
            {
                MessageBox.Show("LUTFEN TRANSKRIPTINIZI SISTEME YUKLEYINIZ!!!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                scanPDF scanpdf = new scanPDF(sicilNo);
                scanpdf.ShowDialog();
            }
            else
            {
                if (true)
                {
                    string dersID = sQLCommands.findLesson("acilandersler", comboBox3.SelectedItem.ToString());
                    sQLCommands.createRequest(sicilNo, sQLCommands.findUserID("teachers", comboBox2.SelectedItem.ToString()), dersID);
                    MessageBox.Show("DERS TALEBINIZ BASARIYLA ALINDI!!!", "BASARILI ISLEM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel8.Controls.Clear();

            SQLCommands sQLCommands = new SQLCommands();
            int indexofY = 18;
            foreach (Panel panel1 in subPanels)
            {
                panel1.Visible = false;
            }

            int receiptID = 0;
            string dersID = string.Empty;
            string requestStatus = string.Empty;
            int i = 0;
            string connectionString = "server=localhost; port=5432; Database=yazlab; user ID=postgres; password=12345";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT receiptid, dersid, status FROM request_table WHERE senderid=@p1";

                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("p1", sicilNo);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            receiptID = reader.GetInt32(0);
                            dersID = reader.GetString(1);
                            requestStatus = reader.GetString(2);

                            Panel panel91 = new Panel();
                            panel91.BackColor = System.Drawing.Color.DarkSlateGray;
                            // panel91.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                            panel91.Location = new System.Drawing.Point(22, indexofY + i * 130); // 130 yerine panel yüksekliği ne ise onu kullanabilirsiniz
                            panel91.Name = "panel91";
                            panel91.Size = new System.Drawing.Size(681, 119); // Panel yüksekliği burada da kullanılabilir
                            panel91.TabIndex = 0;

                            Label label141 = new Label();
                            label141.BackColor = System.Drawing.Color.Transparent;
                            label141.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label141.ForeColor = System.Drawing.SystemColors.Info;
                            label141.Location = new System.Drawing.Point(15, 16);
                            label141.Name = "label141";
                            label141.Size = new System.Drawing.Size(643, 23);
                            label141.TabIndex = 0;
                            label141.Text = "GÖNDERİLEN ÖĞRETİM GÖREVLİSİ: " + sQLCommands.getInfoAboutTeacher(receiptID);

                            Label label151 = new Label();
                            label151.BackColor = System.Drawing.Color.Transparent;
                            label151.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label151.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                            label151.Location = new System.Drawing.Point(15, 39);
                            label151.Name = "label151";
                            label151.Size = new System.Drawing.Size(643, 23);
                            label151.TabIndex = 1;
                            label151.Text = "DERS: " + sQLCommands.getInfoAboutLesson(dersID);

                            Label label161 = new Label();
                            label161.BackColor = System.Drawing.Color.Transparent;
                            label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label161.ForeColor = System.Drawing.Color.Aqua;
                            label161.Location = new System.Drawing.Point(15, 62);
                            label161.Name = "label161";
                            label161.Size = new System.Drawing.Size(81, 23);
                            label161.TabIndex = 2;
                            label161.Text = "Durum:";
                            //deneme123
                            Label label171 = new Label();
                            label171.BackColor = System.Drawing.Color.Transparent;
                            label171.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label171.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                            label171.Location = new System.Drawing.Point(91, 62);
                            if (requestStatus == "Bekliyor")
                                label171.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
                            else if (requestStatus == "Onaylandı")
                                label171.ForeColor = System.Drawing.Color.LimeGreen;
                            else
                                label171.ForeColor = System.Drawing.Color.Red;
                            label171.Name = "label171";
                            label171.Size = new System.Drawing.Size(373, 23);
                            label171.TabIndex = 3;
                            label171.Text = requestStatus;

                            panel91.Controls.Add(label171);
                            panel91.Controls.Add(label151);
                            panel91.Controls.Add(label141);
                            panel91.Controls.Add(label161);
                            this.panel8.Controls.Add(panel91);

                            i++;
                        }
                    }
                }
                connection.Close();
                requestPanel.Visible = true;
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            SQLCommands sQLCommands = new SQLCommands();
            int receiptid = 0;
            string dersid = string.Empty;

            int i = 0;
            int sizeofY = 72;
            string connectionString = "server=localHost; port=5432; Database=yazlab; user ID=postgres; password=12345";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT receiptid,dersid FROM request_table WHERE senderid=@p1 AND status=@p2";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("p1", sicilNo);
                    command.Parameters.AddWithValue("p2", "Onaylandı");
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            receiptid = reader.GetInt32(0);
                            dersid = reader.GetString(1);

                            Panel panel93 = new Panel();
                            Label label153 = new Label();
                            Label label163 = new Label();
                            Label label173 = new Label();
                            Label label183 = new Label();
                            panel93.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                            // panel93.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                            panel93.Location = new System.Drawing.Point(23, sizeofY + i * 130);
                            panel93.Name = "panel9";
                            panel93.Size = new System.Drawing.Size(714, 103);
                            panel93.TabIndex = 3;
                            // 
                            // label15
                            // 
                            label153.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label153.Location = new System.Drawing.Point(223, 16);
                            label153.Name = "label15";
                            label153.Size = new System.Drawing.Size(450, 28);
                            label153.TabIndex = 0;
                            label153.Text = sQLCommands.getInfoAboutTeacher(receiptid);
                            // 
                            // label16
                            // 
                            label163.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label163.ForeColor = System.Drawing.Color.Black;
                            label163.Location = new System.Drawing.Point(13, 16);
                            label163.Name = "label16";
                            label163.Size = new System.Drawing.Size(204, 26);
                            label163.TabIndex = 1;
                            label163.Text = "Dersi Veren Hoca:";
                            // 
                            // label17
                            // 
                            label173.AutoSize = true;
                            label173.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label173.ForeColor = System.Drawing.Color.Blue;
                            label173.Location = new System.Drawing.Point(13, 54);
                            label173.Name = "label17";
                            label173.Size = new System.Drawing.Size(68, 25);
                            label173.TabIndex = 2;
                            label173.Text = "Ders:";
                            // 
                            // label18
                            // 
                            label183.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label183.ForeColor = System.Drawing.Color.Blue;
                            label183.Location = new System.Drawing.Point(87, 54);
                            label183.Name = "label18";
                            label183.Size = new System.Drawing.Size(450, 28);
                            label183.TabIndex = 3;
                            label183.Text = sQLCommands.getInfoAboutLesson(dersid);

                            panel93.Controls.Add(label183);
                            panel93.Controls.Add(label173);
                            panel93.Controls.Add(label163);
                            panel93.Controls.Add(label153);
                            denemePanel.Controls.Add(panel93);
                            i++;
                        }
                    }
                }
                connection.Close();



                denemePanel.Visible = true;

            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            this.panel6.Controls.Clear();
            SQLCommands sQLCommands = new SQLCommands();
            int sizeY = 12;
            string interest = string.Empty;
            int teacherID = 0;
            int i = 0;

            string connectionString = "server=localHost; port=5432; Database=yazlab; user ID=postgres; password=12345";
            this.panel6.Controls.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            Console.WriteLine(this.interestsComboBox.SelectedItem);
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT sicilno, interests FROM teachers_interest_table WHERE interests=@p1 ";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("p1", this.interestsComboBox.SelectedItem.ToString());
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            teacherID = reader.GetInt32(0);
                            interest = reader.GetString(1);

                            Label label96 = new Label();
                            if (!this.interestsComboBox.Items.Contains(interest))
                            {
                                this.interestsComboBox.Items.Add(interest);
                            }
                            label96.BackColor = System.Drawing.Color.Teal;
                            //label96.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                            label96.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            label96.ForeColor = System.Drawing.SystemColors.Control;
                            label96.Location = new System.Drawing.Point(11, sizeY + i * 35);
                            label96.Name = "label9";
                            label96.Size = new System.Drawing.Size(709, 27);
                            label96.TabIndex = 1;
                            label96.Text = sQLCommands.getInfoAboutTeacher(teacherID) + " - " + interest +
                                "     *** Kontenjan: " + sQLCommands.numOfQuote(teacherID);
                            this.panel6.Controls.Add(label96);

                            i++;

                            //comboBox2.Items.Add(sQLCommands.getInfoAboutTeacher(teacherID));

                        }
                    }
                }
                connection.Close();
                //this.interestsComboBox.Items.Clear();
            }
        }
    }
}
