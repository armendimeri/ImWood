using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImWood
{
    public partial class FormKitchenAccessories : Form
    {
        public int Order { get; set; }
        int KitchenID { get; set; }
        string Client;
        DateTime DateExpire;
        Kitchen project;
        public FormKitchenAccessories(int _id, bool _finished, string _client, DateTime _expire, Kitchen kit)
        {
            InitializeComponent();
            DateExpire = _expire;
            KitchenID = _id;
            Client = _client;
            if (_finished)
            {
                BtnAddAccessory.Visible = false;
                ColumnID.ReadOnly = true;
                ColumnQuantity.ReadOnly = true;
            }
            dataGridAccessories.AutoGenerateColumns = false;

            project = kit;

            LoadAccessories();
        }

        int ElementID;
        public FormKitchenAccessories(int elementid)
        {
            ElementID = elementid;
            dataGridAccessories.AutoGenerateColumns = false;
            dataGridAccessories.DataSource = Accessory.GetAccessories(elementid);
        }

        private void LoadAccessories()
        {
            dataGridAccessories.DataSource = Accessory.GetKitchenAccessories(KitchenID);


            foreach (DataGridViewRow row in dataGridAccessories.Rows)
            {
                string type = row.Cells["ColumnType"].Value.ToString();
                string id = row.Cells["ColumnID"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);

                foreach (DataGridViewRow rowCompare in dataGridAccessories.Rows)
                {
                    if (row.Index != rowCompare.Index)
                    {
                        string typeCompare = rowCompare.Cells["ColumnType"].Value.ToString();
                        string idCompare = rowCompare.Cells["ColumnID"].Value.ToString();
                        int quantityCompare = Convert.ToInt32(rowCompare.Cells["ColumnQuantity"].Value);

                        if (type == typeCompare && id == idCompare)
                        {
                            int currentQuantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                            row.Cells["ColumnQuantity"].Value = currentQuantity + quantityCompare;
                            dataGridAccessories.Rows.Remove(rowCompare);
                        }

                    }
                }
            }
            ColumnKitchenID.Visible = false;
        }

        private void dataGridAccessories_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridAccessories.CurrentRow.Cells["ColumnID"].Value.ToString();
            string type = dataGridAccessories.CurrentRow.Cells["ColumnType"].Value.ToString();
            double quantity = double.Parse(dataGridAccessories.CurrentRow.Cells["ColumnQuantity"].Value.ToString());
            string description = dataGridAccessories.CurrentRow.Cells["ColumnDescription"].Value.ToString();
            if (quantity > 0)
            {
                Accessory.AddAccessoryRow(id, type, KitchenID, quantity, description);
            }
            else
            {
                Accessory.DeleteAccessoryRow(KitchenID, type, id);
                dataGridAccessories.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void BtnAddAccessory_Click(object sender, EventArgs e)
        {
            FormAddAccessory form = new FormAddAccessory(KitchenID, true);
            form.ShowDialog();
            LoadAccessories();
        }

        private void FormKitchenAccessories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;        

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void FormLesonitDimensions_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            var totalTable = new DataTable();
            totalTable.Columns.Add("");
            totalTable.Columns.Add("Category");
            totalTable.Columns.Add("Desc");
            totalTable.Columns.Add("QTY");

            #region Konstrukt Total
            var konstruktTable = Dimension.GetKitchenDimensions(project.ID, "Konstrukti");
            double totalKonstrukt = 0;
            foreach(DataRow row in konstruktTable.Rows)
            {                
                double ProductHeight = double.Parse(row["Height"].ToString());
                double ProductWidth = double.Parse(row["Width"].ToString());
                double quantity = double.Parse(row["Quantity"].ToString());
                totalKonstrukt += (ProductHeight * ProductWidth) * quantity;
            }
            totalTable.Rows.Add("•", "Konstrukti", project.KonstMaterial, String.Format("{0:0.0}", totalKonstrukt / 1000000));
            #endregion

            #region Front Total
            var frontTable = Dimension.GetKitchenDimensions(project.ID, "Front");
            double totalFront = 0;
            foreach (DataRow row in frontTable.Rows)
            {
                double ProductHeight = double.Parse(row["Height"].ToString());
                double ProductWidth = double.Parse(row["Width"].ToString());
                double quantity = double.Parse(row["Quantity"].ToString());
                totalFront += (ProductHeight * ProductWidth) * quantity;
            }
            totalTable.Rows.Add("•", "Front", project.FrontMaterial, String.Format("{0:0.0}", totalFront / 1000000));
            #endregion

            #region Polica Total
            var policaTable = Dimension.GetKitchenDimensions(project.ID, "Polica");
            double totalPolica = 0;
            foreach (DataRow row in policaTable.Rows)
            {
                double ProductHeight = double.Parse(row["Height"].ToString());
                double ProductWidth = double.Parse(row["Width"].ToString());
                double quantity = double.Parse(row["Quantity"].ToString());
                totalPolica += (ProductHeight * ProductWidth) * quantity;
            }
            totalTable.Rows.Add("•", "Polica", project.PolicaMaterial, String.Format("{0:0.0}", totalPolica / 1000000));
            #endregion

            #region Fioka Total
            var fiokaTable = Dimension.GetKitchenDimensions(project.ID, "Fioka");
            double totalFioka = 0;
            foreach (DataRow row in fiokaTable.Rows)
            {
                double ProductHeight = double.Parse(row["Height"].ToString());
                double ProductWidth = double.Parse(row["Width"].ToString());
                double quantity = double.Parse(row["Quantity"].ToString());
                totalFioka += (ProductHeight * ProductWidth) * quantity;
            }
            totalTable.Rows.Add("•", "Fioka", project.FiokaMaterial, String.Format("{0:0.0}", totalFioka / 1000000));
            #endregion


            #region Lesonit Total
            var lesonitTable = Dimension.GetKitchenDimensions(project.ID, "Lesonit");
            double totalLesonit = 0;
            foreach (DataRow row in lesonitTable.Rows)
            {
                double ProductHeight = double.Parse(row["Height"].ToString());
                double ProductWidth = double.Parse(row["Width"].ToString());
                double quantity = double.Parse(row["Quantity"].ToString());
                totalLesonit += (ProductHeight * ProductWidth) * quantity;
            }
            totalTable.Rows.Add("•", "Lesonit", project.LesonitMaterial, String.Format("{0:0.0}", totalLesonit / 1000000));
            #endregion



            Printing.PrintProcess(dataGridAccessories, Client, "", project.Name, DateExpire, totalTable);


            #region Old Print
            //PrintDocument printAccessories = new PrintDocument();
            //printAccessories.PrintPage += PrintAccessories_PrintPage;
            //PrintDialog dialog = new PrintDialog();
            //dialog.Document = printAccessories;
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    printAccessories.DocumentName = "Materialet";
            //    printAccessories.Print();
            //}
            #endregion
        }

        public int IndexAccessories { get; set; }
        public int IndexPrintAccessories = 1;
        public bool morePages { get; set; }
        private void PrintAccessories_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            Font font15 = new Font("Calibri", 15);
            Font font10 = new Font("Calibri", 10);
            Pen penBold = new Pen(Color.Black, 3);
            Pen pen = new Pen(Color.DarkGray);
            float fontHeight = font10.GetHeight();
            int startX = 65;
            int startY = 50;
            int Offset = 0;
            float pageHeight = e.PageSettings.PrintableArea.Height;
            StringFormat formatRight = new StringFormat();
            formatRight.Alignment = StringAlignment.Near;

            Image img = Image.FromFile(Application.StartupPath + "/img/Logo.jpg");
            Point ulCorner = new Point(startX, startY);
            graphics.DrawImage(img, ulCorner);

            Rectangle rMaster = new Rectangle(490, startY - 7, 226, 50);
            Rectangle r2 = new Rectangle(495, startY + Offset, 220, 28);
            Offset += 20;
            Rectangle r3 = new Rectangle(495, startY + Offset, 220, 28);
            Offset += 20;
            graphics.DrawRectangle(pen, rMaster);

            Font stringFont = new Font("Calibri", 12);
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString("Klienti: " + Client, stringFont);
            float width = stringSize.Width / 2;

            graphics.DrawString("Klienti: " + Client + "", stringFont, new SolidBrush(Color.Black), r2, formatRight);
            graphics.DrawString("Data e Mbarimit: " + DateExpire.ToString("dd/MM/yyyy"), stringFont, new SolidBrush(Color.Black), r3, formatRight);

            Offset += 20;

            graphics.DrawString("Aksesoar / Materiale", new Font("Calibri", 22, FontStyle.Bold), new SolidBrush(Color.Black), startX + 340, startY + Offset, format);
            Offset += 50;

            Offset += 20;
            Rectangle rBackground = new Rectangle(startX, startY + Offset - 5, 690, 25);
            graphics.FillRectangle(new SolidBrush(Color.LightGray), rBackground);
            graphics.DrawString("No.", font10, new SolidBrush(Color.Black), startX + 5, startY + Offset);
            graphics.DrawString("Tipi", font10, new SolidBrush(Color.Black), startX + 122, startY + Offset, format);
            graphics.DrawString("Shifra", font10, new SolidBrush(Color.Black), startX + 301, startY + Offset, format);
            graphics.DrawString("Sasia", font10, new SolidBrush(Color.Black), startX + 421, startY + Offset, format);
            graphics.DrawString("Pershkrim", font10, new SolidBrush(Color.Black), startX + 540, startY + Offset, format);
            graphics.DrawString("Kontroll", font10, new SolidBrush(Color.Black), startX + 632, startY + Offset);
            Offset += 20;
            Point startPoint1 = new Point(startX, startY + Offset);
            Point endPoint1 = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penBold, startPoint1, endPoint1);
            Offset += 8;

            while (IndexAccessories < dataGridAccessories.Rows.Count)
            {

                #region lines
                if (Offset + 100 >= pageHeight)
                {
                    e.HasMorePages = true;
                    morePages = true;
                    Offset -= 10;
                    Pen penVertical = new Pen(Color.DarkGray, 1);
                    int verticalLine = 150;
                    Point linePoint1 = new Point(startX, startY + verticalLine);
                    Point linePoint2 = new Point(startX, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint1, linePoint2);

                    Point linePoint30 = new Point(startX + 33, startY + verticalLine);
                    Point linePoint40 = new Point(startX + 33, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint30, linePoint40);

                    Point linePoint3 = new Point(startX + 212, startY + verticalLine);
                    Point linePoint4 = new Point(startX + 212, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint3, linePoint4);

                    Point linePoint5 = new Point(startX + 391, startY + verticalLine);
                    Point linePoint6 = new Point(startX + 391, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint5, linePoint6);

                    Point linePoint7 = new Point(startX + 451, startY + verticalLine);
                    Point linePoint8 = new Point(startX + 451, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint7, linePoint8);

                    Point linePoint11 = new Point(startX + 630, startY + verticalLine);
                    Point linePoint12 = new Point(startX + 630, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint11, linePoint12);

                    Point linePoint9 = new Point(startX + 690, startY + verticalLine);
                    Point linePoint10 = new Point(startX + 690, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint9, linePoint10);

                    return;
                }
                else
                {
                    e.HasMorePages = false;
                    morePages = false;
                }
                #endregion

                string shifra = dataGridAccessories.Rows[IndexAccessories].Cells["ColumnID"].Value.ToString();
                string accessoryType = dataGridAccessories.Rows[IndexAccessories].Cells["ColumnType"].Value.ToString();
                double Quantity = Convert.ToDouble(dataGridAccessories.Rows[IndexAccessories].Cells["ColumnQuantity"].Value);
                string description = dataGridAccessories.Rows[IndexAccessories].Cells["ColumnDescription"].Value.ToString();
                graphics.DrawString(IndexPrintAccessories.ToString(), font10, new SolidBrush(Color.Black), startX + 5, startY + Offset);
                graphics.DrawString(accessoryType, font10, new SolidBrush(Color.Black), startX + 35, startY + Offset);
                graphics.DrawString(shifra, font10, new SolidBrush(Color.Black), startX + 301, startY + Offset, format);
                graphics.DrawString(Quantity.ToString(), font10, new SolidBrush(Color.Black), startX + 421, startY + Offset, format);
                graphics.DrawString(description, font10, new SolidBrush(Color.Black), startX + 540, startY + Offset, format);
                Offset += 19;
                Point startPointDimensions = new Point(startX, startY + Offset);
                Point endPointDimension = new Point(startX + 690, startY + Offset);
                graphics.DrawLine(pen, startPointDimensions, endPointDimension);
                Offset += 10;

                IndexAccessories++;
                IndexPrintAccessories++;
            }
            Offset -= 10;

            Pen penVerticalEnd = new Pen(Color.DarkGray, 1);
            int verticalLineEnd = 150;
            Point linePoint1End = new Point(startX, startY + verticalLineEnd);
            Point linePoint2End = new Point(startX, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint1End, linePoint2End);

            Point linePoint30End = new Point(startX + 33, startY + verticalLineEnd);
            Point linePoint40End = new Point(startX + 33, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint30End, linePoint40End);

            Point linePoint3End = new Point(startX + 212, startY + verticalLineEnd);
            Point linePoint4End = new Point(startX + 212, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint3End, linePoint4End);

            Point linePoint5End = new Point(startX + 391, startY + verticalLineEnd);
            Point linePoint6End = new Point(startX + 391, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint5End, linePoint6End);

            Point linePoint7End = new Point(startX + 451, startY + verticalLineEnd);
            Point linePoint8End = new Point(startX + 451, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint7End, linePoint8End);

            Point linePoint11End = new Point(startX + 630, startY + verticalLineEnd);
            Point linePoint12End = new Point(startX + 630, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint11End, linePoint12End);

            Point linePoint9End = new Point(startX + 690, startY + verticalLineEnd);
            Point linePoint10End = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint9End, linePoint10End);


            Point startPoint2End = new Point(startX, startY + Offset);
            Point endPoint2End = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penBold, startPoint2End, endPoint2End);
            IndexAccessories = 0;
        }

        private void dataGridAccessories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                string id = dataGridAccessories.CurrentRow.Cells["ColumnID"].Value.ToString();
                string type = dataGridAccessories.CurrentRow.Cells["ColumnType"].Value.ToString();
                double quantity = double.Parse(dataGridAccessories.CurrentRow.Cells["ColumnQuantity"].Value.ToString());
                string description = dataGridAccessories.CurrentRow.Cells["ColumnDescription"].Value.ToString();

                Accessory.DeleteAccessoryRow(KitchenID, type, id);
                dataGridAccessories.Rows.RemoveAt(e.RowIndex);
                
            }
        }
    }
}
