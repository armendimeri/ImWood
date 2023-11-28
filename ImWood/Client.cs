using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ImWood
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Town { get; set; }

        public Client(string _name, string _phone, string _town)
        {
            Name = _name;
            Phone = _phone;
            Town = _town;
        }


        public Client (int _id)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT * FROM Clients WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", _id);
                connect.Open();
                SqlDataReader reader = CMD.ExecuteReader();
                while(reader.Read())
                {
                    Name = reader["Name"].ToString();
                    Phone = reader["Phone"].ToString();
                    Town = reader["Town"].ToString();
                }
            }
        }

        public void SaveDB()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "INSERT INTO Clients (Name, Phone, Town) VALUES (@Name, @Phone, @Town)";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@Name", Name);
                CMD.Parameters.AddWithValue("@Phone", Phone);
                CMD.Parameters.AddWithValue("@Town", Town);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static DataTable GetClients()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT * FROM Clients";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

    }
}
