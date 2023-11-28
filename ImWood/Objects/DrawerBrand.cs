using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImWood
{
    class DrawerBrand
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public static DataTable GetBrands()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT * FROM DrawerBrands";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void CreateBrand()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "INSERT INTO DrawerBrands (Name) VALUES (@Name)";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@Name", Name);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

    }
}
