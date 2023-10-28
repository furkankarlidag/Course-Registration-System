using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Registration_System
{
    public partial class scanPDF : Form
    {
        string path;
        int sicilNo;
        
        public scanPDF(int sicilNo)
        {
            InitializeComponent();
            this.sicilNo = sicilNo;
            idNo.Text = sicilNo.ToString();
            SQLCommands sQLCommands = new SQLCommands();
            List<string> studentInfo = sQLCommands.getInfoAboutStudent(sicilNo);
            nameLabel.Text = studentInfo[0];
            surnameLabel.Text = studentInfo[1];
            if (sQLCommands.lessonsControl(sicilNo))
            {
                transkriptBilgi.Text = "Transkript basariyla yuklendi.!!";
                transkriptBilgi.ForeColor = Color.White;
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Dosya Seç";
            openFileDialog.Filter = "Tüm Dosyalar (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                DOSYAYOLU.Text = path;
                DOSYAYOLU.ForeColor = Color.White;
                
                
            }
        }
        private void loadPDF_Click(object sender, EventArgs e)
        {
            SQLCommands SQLCommands = new SQLCommands();    
            List<string> dersKodlari = new List<string>();
            string patternString = @"([A-Z]{3}\d{3})\s+(.*?Z)\s+([A-Z]{1}[a-z]{1})\s+(\d)\s+(\d)\s+(\d)\s+(\d)\s+([A-Z]{2})"; // Z ye kadar okuyor harf notunu da okumaya calis

            using (PdfReader reader = new PdfReader(path))
            {                                                               //  7.eleman akts kismi
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    StringBuilder pageText = new StringBuilder();
                    var lines = PdfTextExtractor.GetTextFromPage(reader, page).Split('\n');
                    for (int line = 0; line < lines.Length; line++)
                    {
                        //Console.WriteLine(lines[line]);
                        MatchCollection matches = Regex.Matches(lines[line].Trim(), patternString);
                        if (matches.Count > 0)
                        {
                            foreach (Match match in matches)
                            {
                                //Console.WriteLine(match.Groups[1].Value);
                                SQLCommands.insertLessonFromPDF(match.Groups[1].Value, match.Groups[2].Value, int.Parse(match.Groups[7].Value));
                                SQLCommands.insertToLessonsAndStudents(sicilNo, match.Groups[1].Value, match.Groups[8].Value);
                                Console.WriteLine(sicilNo);
                            }
                        }
                    }
                }
            }
            if (SQLCommands.lessonsControl(sicilNo))
            {
                transkriptBilgi.Text = "Transkript basariyla yuklendi.!!";
                transkriptBilgi.ForeColor = Color.White;
            }
            
        }

       
    }
}
