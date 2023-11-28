using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImWood.Objects
{
    public enum DrawerTypes { SmartBox, SmartSlide};
    class Drawer
    {
        public int ID { get; set; }
        public int BrandID { get; set; }
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public double s { get; set; }
        public double a { get; set; }
        public string Name { get; set; }
        public string KantA1 { get; set; }
        public string KantA2 { get; set; }
        public string KantB1 { get; set; }
        public string KantB2 { get; set; }
        public DrawerTypes Formula { get; set; }
        public Drawer() { }
        public Drawer(int _id)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT * FROM DrawerModels WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", _id);
                connect.Open();
                SqlDataReader reader = CMD.ExecuteReader();
                while(reader.Read())
                {
                    ID = _id;
                    BrandID = (int)reader["BrandID"];
                    x = Convert.ToDouble(reader["x"]);
                    y = Convert.ToDouble(reader["y"]);
                    z = Convert.ToDouble(reader["z"]);
                    s = Convert.ToDouble(reader["s"]);
                    a = Convert.ToDouble(reader["a"]);
                    Name = reader["Name"].ToString();
                    KantA1 = reader["KantA1"].ToString();
                    KantA2 = reader["KantA2"].ToString();
                    KantB1 = reader["KantB1"].ToString();
                    KantB2 = reader["KantB2"].ToString();
                    Formula = (DrawerTypes)Convert.ToInt32(reader["Formula"]);
                }
            }
        }

        

        public static DataTable GetAllDrawers()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"SELECT DrawerModels.ID, x,y,z,s,a, DrawerModels.Name, [Formula], KantA1, KantA2, KantB1, KantB2, DrawerBrands.Name as BrandName FROM DrawerModels 
INNER JOIN DrawerBrands ON DrawerBrands.ID = DrawerModels.BrandID";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void Create()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"INSERT INTO DrawerModels (Name, x, z, y, s, a, KantA1, KantA2, KantB1, KantB2, Formula, BrandID) 
                    VALUES (@Name, @x, @z, @y, @s, @a, @KantA1, @KantA2, @KantB1, @KantB2, @Formula, @BrandID)";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@Name", Name);
                CMD.Parameters.AddWithValue("@x", x);
                CMD.Parameters.AddWithValue("@z", z);
                CMD.Parameters.AddWithValue("@y", y);
                CMD.Parameters.AddWithValue("@s", s);
                CMD.Parameters.AddWithValue("@a", a);
                CMD.Parameters.AddWithValue("@KantA1", KantA1);
                CMD.Parameters.AddWithValue("@KantA2", KantA2);
                CMD.Parameters.AddWithValue("@KantB1", KantB1);
                CMD.Parameters.AddWithValue("@KantB2", KantB2);
                CMD.Parameters.AddWithValue("@Formula", Formula);
                CMD.Parameters.AddWithValue("@BrandID", BrandID);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }
    }
}
