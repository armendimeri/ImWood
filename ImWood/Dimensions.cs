using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImWood
{
    enum DimensionType { Front, Konstrukt, Fjok, Lesonit}
    class Dimension
    {
        public int ID { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int Quantity { get; set; }
        public string Kant { get; set; }
        public string Type { get; set; }
        public int ElementID { get; set; }
        public int KitchenID { get; set; }
        public string Comment { get; set; }
        public string Function { get; set; }
        public string Kant2 { get; set; }
        public Dimension(double _width, double _height, int _quantity, string _kant, string kant2, string _type, 
            int _element, int _kitchenID, string _comment, string _function)
        {
            Width = _width;
            Height = _height;
            Quantity = _quantity;
            Kant = _kant;
            Type = _type;
            ElementID = _element;
            KitchenID = _kitchenID;
            Function = _function;
            Comment = _comment;
            Kant2 = kant2;
        }


        public Dimension(int _ID)
        {
         using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT * FROM ManualDimensions WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", _ID);
                connect.Open();
                SqlDataReader reader = CMD.ExecuteReader();
                while(reader.Read())
                {
                    Height = Convert.ToInt32(reader["Height"]);
                }
            }   
        }
        
        public void AddToDB()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"INSERT INTO Dimensions (Height, Width, Quantity, Kant, Kant2, Type, ElementID, Funksioni) 
VALUES (@Height, @Width, @Quantity, @Kant, @Kant2, @Type, @ElementID, @Function) 
                SELECT SCOPE_IDENTITY()";                

                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@Height", Height);
                CMD.Parameters.AddWithValue("@Width", Width);
                CMD.Parameters.AddWithValue("@Quantity", Quantity);
                CMD.Parameters.AddWithValue("@Type", Type);
                CMD.Parameters.AddWithValue("@ElementID", ElementID);
                CMD.Parameters.AddWithValue("@Kant", Kant);
                CMD.Parameters.AddWithValue("@Function", Function);
                CMD.Parameters.AddWithValue("@Kant2", Kant2);

                connect.Open();
                ID = Convert.ToInt32(CMD.ExecuteScalar());
            }
        }

        public static DataTable GetKitchenDimensions(int kitchenID, string type)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"select Elements.ID, Dimensions.Width, Dimensions.Height, Dimensions.Quantity * KitchenElements.Quantity as Quantity, Dimensions.Kant, Dimensions.Kant2, Dimensions.[Type], 0 as [Manual], '' as Comment, Dimensions.Funksioni
                                from Dimensions
                                INNER JOIN [Elements] ON Dimensions.ElementID = [Elements].ID
                                INNER JOIN KitchenElements ON [Elements].ID = KitchenElements.ElementID
								WHERE KitchenElements.KitchenID = @ID AND Dimensions.[Type] = @Type
                                UNION
                                SELECT ID, Width, Height, Quantity, Kant, Kant2, [Type], 1 as [Manual], Comment, Funksioni
                                FROM ManualDimensions
								WHERE ManualDimensions.KitchenID = @ID AND ManualDimensions.[Type] = @Type";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", kitchenID);
                CMD.Parameters.AddWithValue("@Type", type);
                SqlDataAdapter adapter = new SqlDataAdapter(CMD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public void AddToDBMANUAL()
        {

            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"INSERT INTO 
ManualDimensions (Height, Width, Quantity, Kant, Kant2, Type, KitchenID, Comment, Funksioni) 
VALUES (@Height, @Width, @Quantity, @Kant, @Kant2, @Type, @KitchenID, @Comment, @Function) 
                SELECT SCOPE_IDENTITY()";

                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@Height", Height);
                CMD.Parameters.AddWithValue("@Width", Width);
                CMD.Parameters.AddWithValue("@Quantity", Quantity);
                CMD.Parameters.AddWithValue("@Type", Type);
                CMD.Parameters.AddWithValue("@KitchenID", KitchenID);
                CMD.Parameters.AddWithValue("@Kant", Kant);
                CMD.Parameters.AddWithValue("@Comment", Comment);
                CMD.Parameters.AddWithValue("@Function", Function);
                CMD.Parameters.AddWithValue("@Kant2", Kant2);
                connect.Open();
                ID = Convert.ToInt32(CMD.ExecuteScalar());
            }
        }

        public static void Delete(int dimensionID)
        {
            using(SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "DELETE FROM Dimensions Where ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", dimensionID);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static void DeleteManualDimensions(int id)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "DELETE FROM ManualDimensions WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", id);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static DataTable GetDimensions(int elementid, string dimenstionType)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"SELECT ID, Height, Width, Quantity, Kant, Kant2, Type, Funksioni FROM Dimensions 
                    WHERE ElementID = @ID AND Type = @Type";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", elementid);
                CMD.Parameters.AddWithValue("@Type", dimenstionType);
                SqlDataAdapter adapter = new SqlDataAdapter(CMD);
                DataTable table  = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

    }
}
