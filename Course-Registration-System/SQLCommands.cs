using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace Course_Registration_System
{
    public class SQLCommands
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=yazlab; user ID=postgres; password=12345");
        public List<String> showCloumn(string column, string table)
        {
            List<String> data = new List<String>();
            connection.Open();
            string query = "select " + column + " from " + table;
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    data.Add(item + "");
                }
            }
            connection.Close();
            return data;
        }
        public string getValue(string column, string table, string where)
        {
            string value = null;
            connection.Open();

            string query = "SELECT " + column + " FROM " + table + " WHERE " + where;

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
            {
                // ExecuteScalar ile sorguyu çalıştırın ve sonucu alın
                object result = cmd.ExecuteScalar();

                // Sonucu değerlendirin
                if (result != null && result != DBNull.Value)
                {
                    value = result.ToString();
                }
            }

            connection.Close();
            return value;
        }
        public DataTable showDataTable(string column, string table)
        {
            List<String> data = new List<String>();
            connection.Open();
            string query = "select " + column + " from " + table;
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];
            
            connection.Close();
            return dataTable;
        }

        public void addUser(string name, string surname, string password, string type)
        {
            connection.Open();
            string text = "insert into users (sicilno,name,surname,password,type) values (@p1,@p2,@p3,@p4,@p5)"; //"insert into devices (dmac) values (@p1)"
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            Random random = new Random();
            int id = random.Next(2000, 3000 + 1);
            cmd1.Parameters.AddWithValue("p1", id);
            cmd1.Parameters.AddWithValue("p2", name);
            cmd1.Parameters.AddWithValue("p3", surname);
            cmd1.Parameters.AddWithValue("p4", password);
            cmd1.Parameters.AddWithValue("p5", type);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }

        public void addStudents(string id ,string name, string surname, string gpa, string numberoflesson)
        {
            connection.Open();
            string text = "insert into students (sicilno,name,surname,gpa,numberoflesson) values (@p1,@p2,@p3,@p4,@p5)"; //"insert into devices (dmac) values (@p1)"
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            float.TryParse(gpa, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float gpaValue);
            cmd1.Parameters.AddWithValue("p1", Convert.ToInt32(id));
            cmd1.Parameters.AddWithValue("p2", name);
            cmd1.Parameters.AddWithValue("p3", surname);
            cmd1.Parameters.AddWithValue("p4", gpaValue);
            cmd1.Parameters.AddWithValue("p5", Convert.ToInt32(numberoflesson));
            cmd1.ExecuteNonQuery();
            connection.Close();
        }

        public void delete(string table, string column, string value)
        {
            connection.Open();
            string text = "delete from " + table + " where " + column + "=@p1"; // column hangi sutunun hangi degere esit oldugunu bulacak 
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            cmd1.Parameters.AddWithValue("p1", value);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }

        public void updateData(string table, string column,string id ,string change_value, string new_value)
        {
            connection.Open();
            string text = "update " + table + " set " + column + " = @p1 where " + id + " = @p2 "; // "update devices set dmac=@p1 where dmac=@p2"
            NpgsqlCommand cmd = new NpgsqlCommand(text, connection);
            if (IsNumeric(new_value)) 
            {
                if (int.TryParse(new_value, out int result))
                {
                    cmd.Parameters.AddWithValue("p1", result);
                }
                else
                {
                    float.TryParse(new_value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p1", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p1", new_value);
            if (IsNumeric(change_value))
            {
                if (int.TryParse(change_value, out int result))
                {
                    cmd.Parameters.AddWithValue("p2", result);
                }
                else
                {
                    float.TryParse(change_value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p2", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p2", change_value);
            cmd.ExecuteNonQuery();
            connection.Close();

        }
        private bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsDigit(c) && !char.IsPunctuation(c))
                {
                    return false;
                }
            }
            return true;
        }

        public void sort(string table, string sort) 
        {
            connection.Open();
            string text = "SELECT * FROM " +table+ " ORDER BY "+sort;
            NpgsqlCommand cmd = new NpgsqlCommand(text, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public List<string> getInfoAboutStudent(int id)
        {
            connection.Open();
            List<string> studentInfo = new List<string>();
            string query = "SELECT name,surname FROM students WHERE sicilno=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@p1", id);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string name = reader.GetString(0); // İlk sütun "name"
                string surname = reader.GetString(1); // İkinci sütun "surname"
                studentInfo.Add(name);
                studentInfo.Add(surname);
            }
            connection.Close();
            return studentInfo;
        }

        public void insertLessonFromPDF(string lessonID,string lessonName,int credit)
        {
            connection.Open();
            string checkQuery = "SELECT lessonname FROM lesson WHERE lessonid = @p1";
            NpgsqlCommand checkCmd = new NpgsqlCommand(checkQuery, connection);
            checkCmd.Parameters.AddWithValue("p1", lessonID);
            NpgsqlDataReader reader = checkCmd.ExecuteReader();
            if (reader.Read())
            {
                string name = reader.GetString(0); // İlk sütun "name"
                reader.Close(); 
            }
            else
            {
                reader.Close();
                string text = "INSERT INTO lesson (lessonid, lessonname, credit) VALUES (@p1, @p2, @p3)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
                cmd1.Parameters.AddWithValue("p1", lessonID);
                cmd1.Parameters.AddWithValue("p2", lessonName.Substring(0, lessonName.Length - 1));
                cmd1.Parameters.AddWithValue("p3", credit);
                cmd1.ExecuteNonQuery();
            }
            connection.Close();
        }

        public void insertToLessonsAndStudents(int sicilNo,string lessonID,string point)
        {
            connection.Open();

            string checkQuery = "SELECT * FROM students_and_lessons WHERE lessonid = @p1 AND sicilno = @p2";
            NpgsqlCommand checkCmd = new NpgsqlCommand(checkQuery, connection);
            checkCmd.Parameters.AddWithValue("p1", lessonID);
            checkCmd.Parameters.AddWithValue("p2", sicilNo);
            NpgsqlDataReader reader = checkCmd.ExecuteReader();
            if (reader.Read())
            {
                int intValue = reader.GetInt32(0); 
                string stringValue = intValue.ToString(); // İlk sütun "name"
                reader.Close();
            }
            else
            {
                reader.Close();
                string text = "INSERT INTO students_and_lessons (lessonid, sicilno, lessonletterpoint) VALUES (@p1, @p2, @p3)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
                cmd1.Parameters.AddWithValue("p1", lessonID);
                cmd1.Parameters.AddWithValue("p2", sicilNo);
                cmd1.Parameters.AddWithValue("p3", point);
                cmd1.ExecuteNonQuery();
            }
            connection.Close();

        }

        public string control(int id, string password)
        {
            connection.Open();
            string query = "SELECT * FROM users WHERE sicilno=@p1 AND password=@p2";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@p1", id);
            cmd.Parameters.AddWithValue("@p2", password);

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                string userType = row["type"].ToString();
                connection.Close();
                return userType;
            }
            else
            {
                connection.Close();
                return "false";
            }
            

        }

        public void printAll(string column, string table)
        {
            List<String> data = new List<String>();
            connection.Open();
            string query = "select " + column + " from " + table;
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            foreach (DataRow row in dataTable.Rows)
            {
            }

        }
    }
}
