using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ImWood
{
    class Accessory
    {
        public int ElementID { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; }
        public string Shifra { get; set; }
        public string Description { get; set; }
        public Accessory(int elementid, string type, int quantity, string shifra, string description)
        {
            ElementID = elementid;
            Type = type;
            Quantity = quantity;
            Shifra = shifra;
            Description = description;
        }

        public bool Check()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Accessories WHERE ElementID = @ElementID and Type = @Type";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@Type", Type);
                CMD.Parameters.AddWithValue("@ElementID", ElementID);
                connect.Open();
                int number = Convert.ToInt32(CMD.ExecuteScalar());
                if (number > 0)
                {
                    return false;
                }
                else return true;
            }
        }

        public static void DeleteAccessoryRow(int kitchenid, string type, string shifra)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "DELETE FROM KitchenAccessories WHERE KitchenID = @ID AND [Type] = @Type AND ID = @Shifra";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", kitchenid);
                CMD.Parameters.AddWithValue("@Type", type);
                CMD.Parameters.AddWithValue("@Shifra", shifra);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static void AddAccessoryRow(string id, string type, int kitchenid, double quantity, string description)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "UPDATE KitchenAccessories SET ID = @ID, Quantity = @Quantity, Description = @Description WHERE [Type] = @Type AND KitchenID = @KitchenID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", id);
                CMD.Parameters.AddWithValue("@Type", type);
                CMD.Parameters.AddWithValue("@KitchenID", kitchenid);
                CMD.Parameters.AddWithValue("@Quantity", quantity);
                CMD.Parameters.AddWithValue("@Description", description);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static DataTable GetKitchenAccessories(int kitchenid)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT * FROM KitchenAccessories WHERE KitchenID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", kitchenid);
                SqlDataAdapter adapter = new SqlDataAdapter(CMD);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
        public void Save()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "INSERT INTO Accessories (ElementID, Type, Quantity) VALUES (@ElementID, @Type, @Quantity)";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ElementID", ElementID);
                CMD.Parameters.AddWithValue("@Type", Type);
                CMD.Parameters.AddWithValue("@Quantity", Quantity);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public void AddToKitchen(int kitchenID)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"DECLARE @Count int
SELECT @Count = COUNT(*) FROM KitchenAccessories WHERE KitchenID = @KitchenID AND [Type] = @Type AND ID = @Shifra
IF @Count > 0
BEGIN
UPDATE KitchenAccessories SET Quantity += @Quantity WHERE KitchenID = @KitchenID AND [Type] = @Type AND ID = @Shifra
END
ELSE
BEGIN
INSERT INTO KitchenAccessories (KitchenID, [Type], Quantity, Description, ID) 
                        VALUES (@KitchenID, @Type, @Quantity, @Description, @Shifra)
END";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@KitchenID", kitchenID);
                CMD.Parameters.AddWithValue("@Type", Type);
                CMD.Parameters.AddWithValue("@Quantity", Quantity);
                CMD.Parameters.AddWithValue("@Description", Description);
                CMD.Parameters.AddWithValue("@Shifra", Shifra);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static DataTable GetAccessories(int elementid)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT * FROM Accessories WHERE ElementID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", elementid);
                SqlDataAdapter adapter = new SqlDataAdapter(CMD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }            
        }

        public static void SubtractAccessory(string Type, int quantity, int kitchenID)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "UPDATE KitchenAccessories SET Quantity = Quantity - @Quantity WHERE KitchenID = @ID AND [Type] = @Type";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", kitchenID);
                CMD.Parameters.AddWithValue("@Type", Type);
                CMD.Parameters.AddWithValue("@Quantity", quantity);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static void Delete(int elementid, string type)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "DELETE FROM Accessories WHERE ElementID = @ElementID AND Type = @Type";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ElementID", elementid);
                CMD.Parameters.AddWithValue("@Type", type);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }
    }
}
