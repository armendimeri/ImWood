using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ImWood
{
    public class Kitchen
    {
        public int ID { get; private set; }
        public int ClientID { get; set; }
        public string Name { get; set; }
        public DateTime DateStarted { get; set; }
        public DateTime DateExpire { get; set; }
        public string Comments { get; set; }
        public bool Finished { get; set; }
        public string FrontMaterial { get; set; }
        public string KonstMaterial { get; set; }
        public string ClientName {get; set;}

        public string PolicaMaterial { get; set; }
        public string FiokaMaterial { get; set; }
        public string LesonitMaterial { get; set; }

        public Kitchen(string _name, int _clientid, DateTime _expire, string _Comments, string _frontmat, string _konstmat)
        {
            ClientID = _clientid;
            DateExpire = _expire;
            Comments = _Comments;
            FrontMaterial = _frontmat;
            KonstMaterial = _konstmat;
            Name = _name;
        }


        public static void Finish(int kitchenid)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "UPDATE Kitchens SET Finished = 1, DateFinished = CURRENT_TIMESTAMP WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", kitchenid);
                connect.Open();
                CMD.ExecuteNonQuery();
            }

        }

        public static DataTable GetUnfinished()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"SELECT Kitchens.Name as ProjectName, Kitchens.ID, DateStarted, DateExpire, Clients.Name + ' - ' + Phone as Client, 
                                CONVERT(varchar(10), DATEDIFF(DAY, CURRENT_TIMESTAMP, DateExpire))  + ' ditë' as Days
                                FROM Kitchens
                                INNER JOIN Clients ON Kitchens.ClientID = Clients.ID
                                WHERE Kitchens.Finished = 0";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public static DataTable GetFinished()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"SELECT Kitchens.ID, DateStarted, DateExpire, Clients.Name + ' - ' + Phone as Client, DateFinished, Kitchens.Name as ProjectName
FROM Kitchens
INNER JOIN Clients ON Kitchens.ClientID = Clients.ID
WHERE Kitchens.Finished = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public Kitchen(int _ID)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"SELECT Kitchens.ID, ClientID, DateStarted, DateExpire, Comments, Finished, FrontMaterial, 
KonstMaterial, Clients.Name as ClientName, Kitchens.Name as ProjectName, FiokaMaterial, PolicaMaterial, LesonitMaterial
 FROM Kitchens
INNER JOIN Clients ON Clients.ID = ClientID WHERE Kitchens.ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", _ID);
                connect.Open();
                SqlDataReader reader = CMD.ExecuteReader();
                while(reader.Read())
                {
                    ClientID = int.Parse(reader["ClientID"].ToString());
                    DateStarted = Convert.ToDateTime(reader["DateStarted"]);
                    DateExpire = Convert.ToDateTime(reader["DateExpire"]);
                    Comments = reader["Comments"].ToString();
                    FrontMaterial = reader["FrontMaterial"].ToString();
                    KonstMaterial = reader["konstMaterial"].ToString();
                    ClientName = reader["ClientName"].ToString();
                    Name = reader["ProjectName"].ToString();
                    ID = _ID;
                    Finished = Convert.ToBoolean(reader["Finished"]);
                    PolicaMaterial = reader["PolicaMaterial"].ToString();
                    FiokaMaterial = reader["FiokaMaterial"].ToString();
                    LesonitMaterial = reader["LesonitMaterial"].ToString();                   
                }
            }
        }

        public void Save()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"UPDATE Kitchens SET Name = @Name, ClientID = @ClientID, DateExpire = @Expire, 
Comments = @Comments, FrontMaterial = @Front, KonstMaterial = @Konst, PolicaMaterial = @PolicaMaterial, 
LesonitMaterial = @LesonitMaterial, FiokaMaterial = @FiokaMaterial WHERE ID = @KitchenID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ClientID", ClientID);
                CMD.Parameters.AddWithValue("@Expire", DateExpire);
                CMD.Parameters.AddWithValue("@comments", Comments);
                CMD.Parameters.AddWithValue("@Front", FrontMaterial);
                CMD.Parameters.AddWithValue("@Konst", KonstMaterial);
                CMD.Parameters.AddWithValue("@KitchenID", ID);
                CMD.Parameters.AddWithValue("@Name", Name);
                CMD.Parameters.AddWithValue("@PolicaMaterial", PolicaMaterial);
                CMD.Parameters.AddWithValue("@LesonitMaterial", LesonitMaterial);
                CMD.Parameters.AddWithValue("@FiokaMaterial", FiokaMaterial);

                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public void AddDB()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"INSERT INTO Kitchens (Name, ClientID, DateExpire, Comments, FrontMaterial, KonstMaterial) 
                VALUES (@Name, @ClientID, @DateExpire, @Comments, @FrontMaterial, @KonstMaterial) SELECT SCOPE_IDENTITY()";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ClientID", ClientID);
                CMD.Parameters.AddWithValue("@DateExpire", DateExpire);
                CMD.Parameters.AddWithValue("@Comments", Comments);
                CMD.Parameters.AddWithValue("@FrontMaterial", FrontMaterial);
                CMD.Parameters.AddWithValue("@KonstMaterial", KonstMaterial);
                CMD.Parameters.AddWithValue("@Name", Name);
                connect.Open();
                ID = Convert.ToInt32(CMD.ExecuteScalar());
                Finished = false;
                DateStarted = DateTime.Now;
            }
        }
    }
}
