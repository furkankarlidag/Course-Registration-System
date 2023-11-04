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
    public partial class InfoStudent : Form
    {
        SQLCommands sQLCommands = new SQLCommands();
        public InfoStudent(string id)
        {
            InitializeComponent();
            sicilNoLabel.Text = id;
            adLabel.Text = sQLCommands.getValue("name", "students", "sicilno= " + id)+" "+ sQLCommands.getValue("surname", "students", "sicilno= " + id);
            gpaLabel.Text = sQLCommands.getValue("gpa", "students", "sicilno= " + id);
            dersSayısıLabel.Text = sQLCommands.getValue("numberoflesson", "students", "sicilno= " + id);

            dataGridView1.DataSource= sQLCommands.showQueryDataTable("lessonletterpoint,lessonid", "students_and_lessons", "sicilno", id);
            dataGridView1.Columns["lessonletterpoint"].HeaderText = "HARF NOTU";
            dataGridView1.Columns["lessonid"].HeaderText = "DERS ID";

        }
    }
}
