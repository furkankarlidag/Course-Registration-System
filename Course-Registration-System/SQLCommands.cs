using iTextSharp.text;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace Course_Registration_System
{
    public class SQLCommands
    {
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost; port=5432; Database=yazlab; user ID=postgres; password=12345");
        public List<String> showCloumn(string column, string table)
        {
            List<string> data = new List<string>();
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
                    string cleanedItem = item.ToString().Trim(); // Boşlukları temizle
                    if (!string.IsNullOrEmpty(cleanedItem)) // Boş olanları filtrele
                    {
                        data.Add(cleanedItem);
                        Console.WriteLine(cleanedItem);
                    }
                }
            }

            connection.Close();
            return data;

        }

        public DataTable SpecialQuery1() 
        {
            connection.Open();
            string query = "SELECT * FROM students s WHERE s.SicilNo NOT IN (SELECT DISTINCT SenderID FROM request_table)";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            connection.Close();
            return dataTable;
        }
        public DataTable SpecialQuery2()
        {
            connection.Open();
            string query = "SELECT * FROM students s WHERE s.NumberofLesson <> (SELECT COUNT(*) FROM acilandersler)";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];

            connection.Close();
            return dataTable;
        }
        public DataTable SpecialQuery3()
        {
            connection.Open();
            string query = "SELECT * FROM students s WHERE s.SicilNo IN ( SELECT s.SicilNo FROM students s WHERE s.NumberofLesson <> (SELECT COUNT(*) FROM acilandersler a WHERE a.SicilNo = s.SicilNo) ) ORDER BY s.GPA DESC";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            DataTable dataTable = dataSet.Tables[0];

            connection.Close();
            return dataTable;
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

        public DataTable showDataTableWhere(string column, string table, string where)
        {
            connection.Open();
            string query = "select " + column + " from " + table + " where " +where+" >0";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(query, connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            connection.Close();
            return dataTable;
        }

        public List<int> returnTeacher()
        {
            connection.Open();
            List<int> list = new List<int>();
            string sql = "SELECT * FROM teachers";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {

                        int teacherId = Convert.ToInt32(row["sicilno"]);
                        list.Add(teacherId);

                    }
                }
            }
            connection.Close();
            return list;
        }

        public int returnMessageNum()
        {
            int numberofMessages = 0;
            connection.Open();

            string sql = "SELECT * FROM messages";
            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        numberofMessages++;

                    }
                }
            }
            connection.Close();
            return numberofMessages;
        }

        public DataTable showQueryDataTable(string column, string table, string where, string value)
        {
            connection.Open();
            string query = "select " + column + " from " + table + " where " + where + " = @p1";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            if (IsNumeric(value))
            {
                if (int.TryParse(value, out int result))
                {
                    cmd.Parameters.AddWithValue("p1", result);
                }
                else
                {
                    float.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p1", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p1", NpgsqlDbType.Varchar, value);

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            connection.Close();
            return dataTable;
        }

        public DataTable showTwoQueryDataTable(string column, string table, string where, string value, string where2, string value2)
        {
            connection.Open();
            string query = "select " + column + " from " + table + " where " + where + " = @p1  and "+where2 + " = @p2";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            if (IsNumeric(value))
            {
                if (int.TryParse(value, out int result))
                {
                    cmd.Parameters.AddWithValue("p1", result);
                }
                else
                {
                    float.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p1", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p1", NpgsqlDbType.Varchar, value);

            if (IsNumeric(value2))
            {
                if (int.TryParse(value2, out int result))
                {
                    cmd.Parameters.AddWithValue("p2", result);
                }
                else
                {
                    float.TryParse(value2, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p2", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p2", NpgsqlDbType.Varchar, value2);

            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(cmd);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            DataTable dataTable = dataSet.Tables[0];

            connection.Close();
            return dataTable;
        }

        public void sendRequest(int senderID, int receiptID, string message, int messageNo)
        {
            connection.Open();
            string query = "INSERT INTO messages (senderid,receiptid,message,messageno) values (@p1,@p2,@p3,@p4)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("p1", senderID);
            cmd.Parameters.AddWithValue("p2", receiptID);
            cmd.Parameters.AddWithValue("p3", message);
            cmd.Parameters.AddWithValue("p4", messageNo);
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public int findUserID(string type, string nameSurname)
        {
            string name = string.Empty;
            string surname = string.Empty;
            string[] nameParts = nameSurname.Split(' ');

            if (nameParts.Length == 2)
            {
                name = nameParts[0];
                surname = nameParts[1];
            }
            int userID = 0;
            string sql = "SELECT sicilno FROM " + type + " WHERE name=@p1 AND surname=@p2";

            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("p1", name);
                command.Parameters.AddWithValue("p2", surname);
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {

                        userID = Convert.ToInt32(row["sicilno"]);


                    }
                }
            }
            connection.Close();
            return userID;
        }
        public int onlyCount(string column, string table) 
        {
            int count = 0;
            connection.Open();
            string query = "select " + "Count(" + column + ")" + " from " + table;
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);

            object num = cmd.ExecuteScalar();

            if (num != null)
            {
                count = Convert.ToInt32(num);
            }

            connection.Close();
            return count;
        }
        public int dataCount(string column, string table, string where, string value)
        {
            int count = 0;
            connection.Open();
            string query = "select " + "Count(" + column + ")" + " from " + table + " where " + where + " = @p1";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            if (IsNumeric(value))
            {
                if (int.TryParse(value, out int result))
                {
                    cmd.Parameters.AddWithValue("p1", result);
                }
                else
                {
                    float.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float numbbur);
                    cmd.Parameters.AddWithValue("p1", numbbur);
                }
            }
            else
                cmd.Parameters.AddWithValue("p1", NpgsqlDbType.Varchar, value);

            object num = cmd.ExecuteScalar();

            if (num != null)
            {
                count = Convert.ToInt32(num);
            }

            connection.Close();
            return count;
        }
        public int garipCount(string column, string table, string where, string value, string where2, string value2)
        {
            int count = 0;
            connection.Open();
            string query = "select " + "Count(" + column + ")" + " from " + table + " where " + where + " = @p1 and "+ where2 + " = @p2";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            if (IsNumeric(value))
            {
                if (int.TryParse(value, out int result))
                {
                    cmd.Parameters.AddWithValue("p1", result);
                }
                else
                {
                    float.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float numbbur);
                    cmd.Parameters.AddWithValue("p1", numbbur);
                }
            }
            else
                cmd.Parameters.AddWithValue("p1", NpgsqlDbType.Varchar, value);

            if (IsNumeric(value2))
            {
                if (int.TryParse(value2, out int result))
                {
                    cmd.Parameters.AddWithValue("p2", result);
                }
                else
                {
                    float.TryParse(value2, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float numbbur);
                    cmd.Parameters.AddWithValue("p2", numbbur);
                }
            }
            else
                cmd.Parameters.AddWithValue("p2", NpgsqlDbType.Varchar, value2);

            object num = cmd.ExecuteScalar();

            if (num != null)
            {
                count = Convert.ToInt32(num);
            }

            connection.Close();
            return count;
        }
        public int ultiGaripCount(string column, string table, string where, string value, string where2, string value2,string where3, string value3, string where4, string value4)
        {
            int count = 0;
            connection.Open();
            string query = "select " + "Count(" + column + ")" + " from " + table + " where " + where + " = @p1 and " + where2 + " = @p2 and "+ where3 +" = @p3 and " + where4 + " = @p4";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            if (IsNumeric(value))
            {
                if (int.TryParse(value, out int result))
                {
                    cmd.Parameters.AddWithValue("p1", result);
                }
                else
                {
                    float.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float numbbur);
                    cmd.Parameters.AddWithValue("p1", numbbur);
                }
            }
            else
                cmd.Parameters.AddWithValue("p1", NpgsqlDbType.Varchar, value);

            if (IsNumeric(value2))
            {
                if (int.TryParse(value2, out int result))
                {
                    cmd.Parameters.AddWithValue("p2", result);
                }
                else
                {
                    float.TryParse(value2, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float numbbur);
                    cmd.Parameters.AddWithValue("p2", numbbur);
                }
            }
            else
                cmd.Parameters.AddWithValue("p2", NpgsqlDbType.Varchar, value2);

            if (IsNumeric(value3))
            {
                if (int.TryParse(value3, out int result))
                {
                    cmd.Parameters.AddWithValue("p3", result);
                }
                else
                {
                    float.TryParse(value3, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float numbbur);
                    cmd.Parameters.AddWithValue("p3", numbbur);
                }
            }
            else
                cmd.Parameters.AddWithValue("p3", NpgsqlDbType.Varchar, value3);

            if (IsNumeric(value4))
            {
                if (int.TryParse(value4, out int result))
                {
                    cmd.Parameters.AddWithValue("p4", result);
                }
                else
                {
                    float.TryParse(value4, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float numbbur);
                    cmd.Parameters.AddWithValue("p4", numbbur);
                }
            }
            else
                cmd.Parameters.AddWithValue("p4", NpgsqlDbType.Varchar, value4);

            object num = cmd.ExecuteScalar();

            if (num != null)
            {
                count = Convert.ToInt32(num);
            }

            connection.Close();
            return count;
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

        public void addStudents(string id, string name, string surname, string gpa, string numberoflesson)
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

        public void addTeachers(string id, string name, string surname, string quota)
        {
            connection.Open();
            string text = "insert into teachers (sicilno,name,surname,quota) values (@p1,@p2,@p3,@p4)"; //"insert into devices (dmac) values (@p1)"
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            cmd1.Parameters.AddWithValue("p1", Convert.ToInt32(id));
            cmd1.Parameters.AddWithValue("p2", name);
            cmd1.Parameters.AddWithValue("p3", surname);
            cmd1.Parameters.AddWithValue("p4", Convert.ToInt32(quota));
            cmd1.ExecuteNonQuery();
            connection.Close();

        }
        public void addRequest(string senderid, string receiptid, string dersid, string status)
        {
            connection.Open();
            string text = "insert into request_table (senderid,receiptid,dersid,status) values (@p1,@p2,@p3,@p4)"; //"insert into devices (dmac) values (@p1)"
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            cmd1.Parameters.AddWithValue("p1", Convert.ToInt32(senderid));
            cmd1.Parameters.AddWithValue("p2", Convert.ToInt32(receiptid));
            cmd1.Parameters.AddWithValue("p3", dersid);
            cmd1.Parameters.AddWithValue("p4", status);
            cmd1.ExecuteNonQuery();
            connection.Close();

        }

        public void addTeachersInterest(string id, string interest)
        {
            connection.Open();
            string text = "insert into teachers_interest_table (sicilno,interests) values (@p1,@p2)"; //"insert into devices (dmac) values (@p1)"
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            cmd1.Parameters.AddWithValue("p1", Convert.ToInt32(id));
            cmd1.Parameters.AddWithValue("p2", interest);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }

        public void addAcilanDersler(string dersid, string dersisim)
        {
            connection.Open();
            string text = "insert into acilandersler (dersid,dersisim) values (@p1,@p2)"; //"insert into devices (dmac) values (@p1)"
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            cmd1.Parameters.AddWithValue("p1", dersid);
            cmd1.Parameters.AddWithValue("p2", dersisim);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }

        public void delete(string table, string column, string value)
        {
            connection.Open();
            string text = "delete from " + table + " where " + column + "=@p1"; // column hangi sutunun hangi degere esit oldugunu bulacak 
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            if (IsNumeric(value))
            {
                if (int.TryParse(value, out int result))
                {
                    cmd1.Parameters.AddWithValue("p1", result);
                }
                else
                {
                    float.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float numbbur);
                    cmd1.Parameters.AddWithValue("p1", numbbur);
                }
            }
            else
                cmd1.Parameters.AddWithValue("p1", NpgsqlDbType.Varchar, value);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }
        public void deleteThree(string table, string senderid, string receiptid, string dersid)
        {
            connection.Open();
            string text = "delete from " + table + " where " + " senderid " + "=@p1 and" + " receiptid " + "=@p2 and" + " dersid " + "=@p3"; // column hangi sutunun hangi degere esit oldugunu bulacak 
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            int.TryParse(senderid, out int result);
            cmd1.Parameters.AddWithValue("p1", result);
            if (IsNumeric(receiptid))
            {
                if (int.TryParse(receiptid, out int result1))
                {
                    cmd1.Parameters.AddWithValue("p2", result1);
                }
                else
                {
                    float.TryParse(receiptid, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd1.Parameters.AddWithValue("p2", num);
                }
            }
            else
                cmd1.Parameters.AddWithValue("p2", receiptid);

            cmd1.Parameters.AddWithValue("p3", dersid);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }

        public void updateData(string table, string column, string id, string change_value, string new_value)
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
        public void updateThreeData(string table, string column, string senderid, string receiptid, string dersid, string new_value)
        {
            connection.Open();
            string text = "update " + table + " set " + column + " = @p1 where " +"senderid = @p2 and "+ "receiptid = @p3 and "+ "dersid = @p4"; // "update devices set dmac=@p1 where dmac=@p2"
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
            if (IsNumeric(senderid))
            {
                if (int.TryParse(senderid, out int result))
                {
                    cmd.Parameters.AddWithValue("p2", result);
                }
                else
                {
                    float.TryParse(senderid, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p2", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p2", senderid);

            if (IsNumeric(receiptid))
            {
                if (int.TryParse(receiptid, out int result))
                {
                    cmd.Parameters.AddWithValue("p3", result);
                }
                else
                {
                    float.TryParse(receiptid, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p3", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p3", receiptid);

            if (IsNumeric(dersid))
            {
                if (int.TryParse(dersid, out int result))
                {
                    cmd.Parameters.AddWithValue("p4", result);
                }
                else
                {
                    float.TryParse(receiptid, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p4", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p4", dersid);

            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public void updateTwoData(string table, string column, string senderid, string receiptid, string dersid, string new_value)
        {
            connection.Open();
            string text = "update " + table + " set " + column + " = @p1 where " + "senderid != @p2 and " + "receiptid = @p3 and " + "dersid = @p4"; // "update devices set dmac=@p1 where dmac=@p2"
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
            if (IsNumeric(senderid))
            {
                if (int.TryParse(senderid, out int result))
                {
                    cmd.Parameters.AddWithValue("p2", result);
                }
                else
                {
                    float.TryParse(senderid, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p2", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p2", senderid);

            if (IsNumeric(receiptid))
            {
                if (int.TryParse(receiptid, out int result))
                {
                    cmd.Parameters.AddWithValue("p3", result);
                }
                else
                {
                    float.TryParse(receiptid, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p3", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p3", receiptid);

            if (IsNumeric(dersid))
            {
                if (int.TryParse(dersid, out int result))
                {
                    cmd.Parameters.AddWithValue("p4", result);
                }
                else
                {
                    float.TryParse(dersid, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out float num);
                    cmd.Parameters.AddWithValue("p4", num);
                }
            }
            else
                cmd.Parameters.AddWithValue("p4", dersid);

            cmd.ExecuteNonQuery();
            connection.Close();

        }
        public bool IsNumeric(string input)
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
            string text = "SELECT * FROM " + table + " ORDER BY " + sort;
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

        public string getInfoAboutTeacher(int id)
        {
            connection.Open();
            string info = string.Empty;
            string query = "SELECT name,surname FROM teachers WHERE sicilno=@p1";
            NpgsqlCommand cmd = new NpgsqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@p1", id);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                info = reader.GetString(0) + " " + reader.GetString(1);


            }
            connection.Close();
            return info;
        }

        public void insertLessonFromPDF(string lessonID, string lessonName, int credit)
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

        public void insertToLessonsAndStudents(int sicilNo, string lessonID, string point)
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

        public bool lessonsControl(int id)
        {
            connection.Open();

            string checkQuery = "SELECT * FROM students_and_lessons WHERE sicilno = @p1";
            NpgsqlCommand checkCmd = new NpgsqlCommand(checkQuery, connection);
            checkCmd.Parameters.AddWithValue("p1", id);
            NpgsqlDataReader reader = checkCmd.ExecuteReader();
            if (reader.Read())
            {
                int intValue = reader.GetInt32(0);
                string stringValue = intValue.ToString(); // İlk sütun "name"
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                connection.Close();
                return false;
            }

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
