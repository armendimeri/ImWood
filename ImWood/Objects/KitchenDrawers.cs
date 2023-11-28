using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ImWood.Objects
{
    class KitchenDrawers
    {
        public int ID { get; set; }

        public int DrawerID { get; set; }
        public int DimensionID { get; set; }
        public int Quantity { get; set; }
        public bool Inbox { get; set; }

        public KitchenDrawers() { }

        public void Save()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "INSERT INTO KitchenDrawers (DrawerID, DimensionID, Quantity, Inbox) VALUES (@DrawerID, @DimensionID, @Quantity, @Inbox)";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@DrawerID", DrawerID);
                CMD.Parameters.AddWithValue("@DimensionID", DimensionID);
                CMD.Parameters.AddWithValue("@Quantity", Quantity);
                CMD.Parameters.AddWithValue("@Inbox", Inbox);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static void Delete(int _drawerID, int _dimID)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "DELETE FROM KitchenDrawers WHERE DrawerID = @DrawerID AND DimensionID = @DimID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@DrawerID", _drawerID);
                CMD.Parameters.AddWithValue("@DimID", _dimID);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static DataTable GetKitchenDrawers(int _kitchenID)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"SELECT DrawerModels.Name, KitchenDrawers.Quantity, KitchenDrawers.DimensionID, KitchenDrawers.Inbox , DrawerID
FROM KitchenDrawers
INNER JOIN DrawerModels ON DrawerID = DrawerModels.ID
INNER JOIN ManualDimensions ON DimensionID = ManualDimensions.ID
WHERE ManualDimensions.KitchenID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", _kitchenID);
                var table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(CMD);
                adapter.Fill(table);
                return table;
            }
        }
    }
}
