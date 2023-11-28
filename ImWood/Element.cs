using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImWood
{
    class Element
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Image Photo { get; set; }
        public bool Locked { get; set; }
        public string Category { get; set; }
        public string Design { get; set; }



        public Element(int _id)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT * FROM Elements WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", _id);
                connect.Open();
                SqlDataReader reader = CMD.ExecuteReader();
                while(reader.Read())
                {
                    ID = _id;
                    Name = reader["Name"].ToString();
                    Byte[] data = new Byte[0];
                    data = (Byte[])(reader["Photo"]);
                    MemoryStream mem = new MemoryStream(data);
                    Photo = Image.FromStream(mem);
                    Locked = Convert.ToBoolean(reader["Locked"]);
                    Category = reader["Category"].ToString();
                    Design = reader["Design"].ToString();
                }
            }
        }

        public Element(string name, Image photo, string category, string design)
        {
            Name = name;
            Photo = photo;
            Category = category;
            Design = design;            
        }

        public static void Lock(int elementid)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "UPDATE Elements SET Locked = 1 WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", elementid);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }


        public static void UnLock(int elementid)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "UPDATE Elements SET Locked = 0 WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", elementid);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static MemoryStream GetImage(int id)
        {            
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT Photo FROM Elements WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", id);
                connect.Open();
                SqlDataReader reader= CMD.ExecuteReader();
                while(reader.Read())
                {
                    Byte[] data = new Byte[0];
                    try
                    {
                    data = (Byte[])(reader["Photo"]);
                    MemoryStream mem = new MemoryStream(data);
                    return mem;              
                    }
                    catch
                    {
                        return null;
                    }
                }
                return null;
            }
        }

        public static void UpdateImage(string location, int ID)
        {
            byte[] image = File.ReadAllBytes(location); ;
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "UPDATE Elements SET Photo = @Photo WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@ID", ID);
                CMD.Parameters.AddWithValue("@Photo", image);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public void AddNew(string location)
        {
            byte[] image = File.ReadAllBytes(location);;
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"INSERT INTO ELEMENTS (Name, Photo, Category, Design) 
                VALUES (@Name, @Photo, @Category, @Design) SELECT SCOPE_IDENTITY()";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@Name", Name);
                CMD.Parameters.AddWithValue("@Photo", image);
                CMD.Parameters.AddWithValue("@Design", Design);
                CMD.Parameters.AddWithValue("@Category", Category);
                connect.Open();
                ID = Convert.ToInt32(CMD.ExecuteScalar());
            }
        }

        public void AddNew()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"INSERT INTO ELEMENTS (Name, Category, Design) 
                VALUES (@Name, @Category, @Design) SELECT SCOPE_IDENTITY()";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@Name", Name);
                CMD.Parameters.AddWithValue("@Design", Design);
                CMD.Parameters.AddWithValue("@Category", Category);
                connect.Open();
                ID = Convert.ToInt32(CMD.ExecuteScalar());
            }
        }

        public static DataTable GetElements()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT ID, Name, Category, Design, Locked FROM Elements";
                SqlDataAdapter adater = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adater.Fill(table);
                return table;
            }
        }

        public static DataTable GetElementsLocked()
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT ID, Name, Category, Design FROM Elements WHERE Locked = 1";
                SqlDataAdapter adater = new SqlDataAdapter(query, connect);
                DataTable table = new DataTable();
                adater.Fill(table);
                return table;
            }
        }


        public static DataTable GetKitchenElements(int kitchenID)
        {
            using (SqlConnection connnect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"SELECT ElementID, Quantity, Name, Photo, Category, Design
                        FROM KitchenElements
                        INNER JOIN [Elements] ON [Elements].ID = KitchenElements.ElementID
                        WHERE KitchenID = @ID";
                SqlCommand CMD = new SqlCommand(query, connnect);
                CMD.Parameters.AddWithValue("@ID", kitchenID);
                SqlDataAdapter adapter = new SqlDataAdapter(CMD);
                var table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        private static bool CheckElementKitchen(int elementid, int kitchenid)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "SELECT COUNT(KitchenID) FROM KitchenElements WHERE KitchenID = @KitchenID AND ElementID = @ElementID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@KitchenID", kitchenid);
                CMD.Parameters.AddWithValue("@ElementID", elementid);
                connect.Open();
                int count = Convert.ToInt32(CMD.ExecuteScalar());
                if (count == 0)
                {
                    return true;
                }
                else return false;
            }
        }
        public static void AddToKitchen(int elementid, int kitchenid, int quantity)
        {
            if (CheckElementKitchen(elementid, kitchenid))
            {
                using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
                {
                    string query = @"INSERT INTO KitchenElements (KitchenID, ElementID, Quantity) VALUES (@KitchenID, @ElementID, @Quantity)

Declare @Type varchar(50)
DECLARE @Count int
DECLARE @QuantityAccessory int
SELECT * INTO #TempAccessories
FROM Accessories
WHERE ElementID = @ElementID

while exists (select * from #TempAccessories)
BEGIN
SELECT TOP 1 @ElementID = ElementID, @Type = Type, @QuantityAccessory = Quantity 
FROM #TempAccessories
SELECT @Count = COUNT(*) FROM KitchenAccessories WHERE KitchenID = @KitchenID AND [Type] = @Type
SET @QuantityAccessory = @QuantityAccessory * @Quantity
IF @Count > 0
BEGIN
UPDATE KitchenAccessories SET Quantity += @QuantityAccessory WHERE [Type] = @Type AND KitchenID = @KitchenID
END
ELSE
BEGIN
INSERT INTO KitchenAccessories (KitchenID, [Type], Quantity) VALUES (@KitchenID, @Type, @QuantityAccessory)
END
DELETE FROM #TempAccessories WHERE [Type] = @Type
END";
                    SqlCommand CMD = new SqlCommand(query, connect);
                    CMD.Parameters.AddWithValue("@KitchenID", kitchenid);
                    CMD.Parameters.AddWithValue("@ElementID", elementid);
                    CMD.Parameters.AddWithValue("@Quantity", quantity);
                    connect.Open();
                    CMD.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateElement(string category, string design, int id)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = "UPDATE Elements SET Category = @Category, Design = @Design WHERE ID = @ID";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@Category", category);
                CMD.Parameters.AddWithValue("@Design", design);
                CMD.Parameters.AddWithValue("@ID", id);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }

        public static void DeleteElementFromKitchen(int elmentid, int kitchenid)
        {
            using (SqlConnection connect = new SqlConnection(Properties.Settings.Default.ConnectionString))
            {
                string query = @"
DECLARE @QuantityElement int
DECLARE @QuantityAccessory int
DECLARE @CurrentQuantity int
DECLARE @Type varchar(50)

SELECT @QuantityElement = Quantity FROM KitchenElements 
WHERE KitchenID = @KitchenID AND ElementID = @ElementID


SELECT * INTO #TempAccessories from Accessories
WHERE ElementID = @ElementID


while exists (select * from #TempAccessories)
BEGIN
SELECT TOP 1 @Type = [Type], @QuantityAccessory = Quantity 
FROM #TempAccessories

UPDATE KitchenAccessories SET Quantity = Quantity -(@QuantityAccessory * @QuantityElement) WHERE KitchenID = @KitchenID AND [Type] = @Type

SELECT @CurrentQuantity = Quantity FROM KitchenAccessories WHERE KitchenID = @KitchenID AND [Type] = @Type

IF @CurrentQuantity < 1
BEGIN
DELETE FROM KitchenAccessories WHERE [Type] = @Type AND KitchenID = @KitchenID
END
DELETE FROM #TempAccessories WHERE [Type] = @Type
END

DELETE FROM KitchenElements WHERE KitchenID = @KitchenID AND ElementID = @ElementID ";
                SqlCommand CMD = new SqlCommand(query, connect);
                CMD.Parameters.AddWithValue("@KitchenID", kitchenid);
                CMD.Parameters.AddWithValue("@ElementID", elmentid);
                connect.Open();
                CMD.ExecuteNonQuery();
            }
        }
    }
}
