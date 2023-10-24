using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void addUser(string name, string surname, string password, string type)
        {
            connection.Open();
            string text = "insert into users (id,name,surname,password,type) values (@p1,@p2,@p3,@p4,@p5)"; //"insert into devices (dmac) values (@p1)"
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

        public void delete(string table, string column, string value)
        {
            connection.Open();
            string text = "delete from " + table + " where " + column + "=@p1"; // column hangi sutunun hangi degere esit oldugunu bulacak 
            NpgsqlCommand cmd1 = new NpgsqlCommand(text, connection);
            cmd1.Parameters.AddWithValue("p1", value);
            cmd1.ExecuteNonQuery();
            connection.Close();
        }

        public void updateData(string table, string column, string change_value, string new_value)
        {
            connection.Open();
            string text = "update " + table + "set " + column + "=@p1 where " + column + "=@p2"; // "update devices set dmac=@p1 where dmac=@p2"
            NpgsqlCommand cmd = new NpgsqlCommand("update devices set dmac=@p1 where dmac=@p2", connection);
            cmd.Parameters.AddWithValue("p1", new_value);
            cmd.Parameters.AddWithValue("p2", change_value);
            cmd.ExecuteNonQuery();
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
