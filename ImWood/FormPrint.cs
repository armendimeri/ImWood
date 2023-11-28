using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ImWood
{
    public partial class FormPrint : Form
    {
        int KitchenID;
        private Client client { get; set; }
        private Kitchen kitchen { get; set; }
        public FormPrint(int _kitchenid)
        {
            InitializeComponent();
            LoadDimensions();
            KitchenID = _kitchenid;
            LoadDimensions();
            LoadAccessories();
            CheckDuplicates();
            kitchen = new Kitchen(_kitchenid);
            client = new Client(kitchen.ClientID);
        }

        private void CheckDuplicates()
        {
            foreach(DataGridViewRow row in DataGridViewDimensions.Rows)
            {                
                string value;
                var type = row.Cells["ColumnType"].Value.ToString();
                var width = row.Cells["ColumnWidth"].Value.ToString();
                var height = row.Cells["ColumnHeight"].Value.ToString();
                var kant = row.Cells["ColumnKant"].Value.ToString();
                value = type + " " + width + " " + height + " " + kant;
                for (int i = 0; i < DataGridViewDimensions.Rows.Count; i++)
                {
                    DataGridViewRow compareRow = DataGridViewDimensions.Rows[i];
                    if (compareRow.Index > row.Index)
                    {
                        string compareValue;
                        var comparetype = compareRow.Cells["ColumnType"].Value.ToString();
                        var comparewidth = compareRow.Cells["ColumnWidth"].Value.ToString();
                        var compareheight = compareRow.Cells["ColumnHeight"].Value.ToString();
                        var comparekant = compareRow.Cells["ColumnKant"].Value.ToString();
                        compareValue = comparetype + " " + comparewidth + " " + compareheight + " " + comparekant;
                        if (value == compareValue)
                        {
                            int compareQuantity = Convert.ToInt32(compareRow.Cells["ColumnQuantity"].Value);
                            int quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                            row.Cells["ColumnQuantity"].Value = quantity + compareQuantity;
                            DataGridViewDimensions.Rows.RemoveAt(compareRow.Index);
                            i--;
                        }
                    }
                }
            }
        }

        private void LoadDimensions()
        {
            DataGridViewDimensions.AutoGenerateColumns = false;
            DataGridViewDimensions.DataSource = Dimension.GetKitchenDimensions(KitchenID, "");
        }

        private void LoadAccessories()
        {
            dataGridAccessories.AutoGenerateColumns = false;
            dataGridAccessories.DataSource = Accessory.GetKitchenAccessories(KitchenID);
        }

        int KonsCount;
        int FrontCount;
        int FiokCount;
        int LesonitCount;
        int PolicaCount;

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            KonsCount = 0;
            FrontCount = 0;
            FiokCount = 0;
            LesonitCount = 0;
            PolicaCount = 0;

            foreach (DataGridViewRow row in DataGridViewDimensions.Rows)
            {
                if (row.Cells["ColumnType"].Value.ToString() == "Konstrukti")
                {
                    KonsCount++;
                }
                else if (row.Cells["ColumnType"].Value.ToString() == "Front")
                {
                    FrontCount++;
                }
                else if (row.Cells["ColumnType"].Value.ToString() == "Fioka")
                {
                    FiokCount++;
                }
                else if (row.Cells["ColumnType"].Value.ToString() == "Lesonit")
                {
                    LesonitCount++;
                }
                else if (row.Cells["ColumnType"].Value.ToString() == "Polica")
                {
                    PolicaCount++;
                }
            }
            PrintDocument printDimensions = new PrintDocument();
            PrintController printController = new StandardPrintController();
            printDimensions.PrintController = printController;
            printDimensions.PrintPage += printDimensions_PrintPage;
            PrintDialog dialog = new PrintDialog();            
            dialog.Document = printDimensions;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (KonsCount > 0)
                {
                    DimensionPrint = "Konstrukti";
                    printDimensions.DocumentName = "Konstrukti";
                    printDimensions.Print();
                }

                if (FrontCount > 0)
                {
                    PrintDocument printFront = new PrintDocument();
                    printFront.DocumentName = "Front";
                    DimensionPrint = "Front";
                    printFront.PrintPage += printLesonit_PrintPage;
                    printFront.Print();
                }

                if (FiokCount > 0)
                {
                    DimensionPrint = "Fioka";
                    printDimensions.DocumentName = "Fioka";
                    printDimensions.Print();
                }
                if (LesonitCount > 0)
                {
                    PrintDocument printLesonit = new PrintDocument();
                    printLesonit.DocumentName = "Lesonit";
                    DimensionPrint = "Lesonit";
                    printLesonit.PrintPage += printLesonit_PrintPage;
                    printLesonit.Print();
                }
                if (PolicaCount > 0)
                {
                    DimensionPrint = "Polica";
                    printDimensions.DocumentName = "Polica";
                    printDimensions.Print();
                }
                
                
            }
            PrintDocument printAccessories = new PrintDocument();
            printAccessories.PrintPage += printAccessories_PrintPage;
            dialog.Document = printAccessories;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                printAccessories.DocumentName = "Materialet";
                printAccessories.Print();
            }

        }

        void printLesonit_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (!e.HasMorePages)
            {
                IndexDimensions = 0;
                IndexPrintDimensions = 1;
            }
            Graphics graphics = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            Font font15 = new Font("Calibri", 15);
            Font font12 = new Font("Calibri", 12);
            Font font14 = new Font("Calibri", 14, FontStyle.Bold);
            float pageHeight = e.PageSettings.PrintableArea.Height;
            Pen penBold = new Pen(Color.Black, 3);
            Pen pen = new Pen(Color.DarkGray);
            float fontHeight = font12.GetHeight();
            SolidBrush brush = new SolidBrush(Color.Black);
            Font stringFontBold = new Font("Calibri", 14, FontStyle.Bold);
            Font stringFont = new Font("Calibri", 12);

            int startX = 65;
            int startY = 50;
            int Offset = 0;
            StringFormat formatRight = new StringFormat();
            formatRight.Alignment = StringAlignment.Near;

            Image img = Image.FromFile(Application.StartupPath + "/img/Logo.jpg");
            Point ulCorner = new Point(startX, startY);
            graphics.DrawImage(img, ulCorner);

          if(DimensionPrint == "Lesonit")
          {

            graphics.DrawString("Lesonit:", stringFontBold, brush, startX, startY + 55);
            Rectangle rComment = new Rectangle(startX, startY + 80, 265, 60);
            graphics.DrawRectangle(pen, rComment);
          }
          else if (DimensionPrint == "Front")
          {
              graphics.DrawString("Front:", stringFontBold, brush, startX, startY + 55);
              Rectangle rComment = new Rectangle(startX, startY + 80, 265, 60);
              graphics.DrawRectangle(pen, rComment);
          }
            

            Rectangle rMaster = new Rectangle(490, startY - 7, 226, 50);
            Rectangle r2 = new Rectangle(495, startY + Offset, 220, 28);
            Offset += 20;
            Rectangle r3 = new Rectangle(495, startY + Offset, 220, 28);
            Offset += 20;
            graphics.DrawRectangle(pen, rMaster);


            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString("Klienti: " + client.Name, stringFont);
            float width = stringSize.Width / 2;

            graphics.DrawString("Klienti: " + client.Name + "", stringFont, new SolidBrush(Color.Black), r2, formatRight);
            graphics.DrawString("Data e Mbarimit: " + kitchen.DateExpire.ToString("dd/MM/yyyy"), stringFont, new SolidBrush(Color.Black), r3, formatRight);

            Offset += 100;

            Offset += 50;

            Rectangle rBackground = new Rectangle(startX, startY + Offset - 20, 690, 45);
            graphics.FillRectangle(new SolidBrush(Color.LightGray), rBackground);
            graphics.DrawString("No.", font12, new SolidBrush(Color.Black), startX + 5, startY + Offset);
            graphics.DrawString("Lartësia \n (Tekstura)", font12, new SolidBrush(Color.Black), startX + 78, startY + Offset - 20, format);
            graphics.DrawString("Gjërësia", font12, new SolidBrush(Color.Black), startX + 168, startY + Offset, format);
            graphics.DrawString("Sasia", font12, new SolidBrush(Color.Black), startX + 258, startY + Offset, format);
            if (DimensionPrint == "Lesonit")
            {
                graphics.DrawString("Pozicioni", font12, new SolidBrush(Color.Black), startX + 399, startY + Offset, format);
            }
            else
            {
                graphics.DrawString("Funksioni", font12, new SolidBrush(Color.Black), startX + 399, startY + Offset, format);
            }
            graphics.DrawString("Koment", font12, new SolidBrush(Color.Black), startX + 593, startY + Offset, format);

            Offset += 25;
            Point startPoint1 = new Point(startX, startY + Offset);
            Point endPoint1 = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penBold, startPoint1, endPoint1);
            Offset += 10;
            double totalm2 = 0;
            while (IndexDimensions < DataGridViewDimensions.Rows.Count)
            {
                //if (Offset + 100 > pageHeight)
                //{
                //    Offset -= 10;
                //    e.HasMorePages = true;
                //    Point startPoint2 = new Point(startX, startY + Offset);
                //    Point endPoint2 = new Point(startX + 690, startY + Offset);
                //    graphics.DrawLine(penBold, startPoint2, endPoint2);

                //    Pen penVertical = new Pen(Color.DarkGray, 1);
                //    Point linePoint1 = new Point(startX, startY + 250);
                //    Point linePoint2 = new Point(startX, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint1, linePoint2);

                //    Point linePoint3 = new Point(startX + 35, startY + 250);
                //    Point linePoint4 = new Point(startX + 35, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint3, linePoint4);

                //    Point linePoint5 = new Point(startX + 115, startY + 250);
                //    Point linePoint6 = new Point(startX + 115, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint5, linePoint6);

                //    Point linePoint7 = new Point(startX + 195, startY + 250);
                //    Point linePoint8 = new Point(startX + 195, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint7, linePoint8);

                //    Point linePoint9 = new Point(startX + 260, startY + 250);
                //    Point linePoint10 = new Point(startX + 260, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint9, linePoint10);

                //    Point linePoint15 = new Point(startX + 425, startY + 250);
                //    Point linePoint16 = new Point(startX + 425, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint15, linePoint16);

                //    Point linePoint17 = new Point(startX + 690, startY + 250);
                //    Point linePoint18 = new Point(startX + 690, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint17, linePoint18);
                //    Offset -= 10;
                //    return;
                //}
                //else
                //{
                //    e.HasMorePages = false;
                //}

                DataGridViewRow row = DataGridViewDimensions.Rows[IndexDimensions];
                string ProductType = row.Cells["ColumnType"].Value.ToString();
                if (ProductType == DimensionPrint)
                {
                    double ProductWidth = Convert.ToDouble(row.Cells["ColumnWidth"].Value);
                    double ProductHeight = Convert.ToDouble(row.Cells["ColumnHeight"].Value);
                    string ProductKant = row.Cells["ColumnKant"].Value.ToString();
                    string ProductKant2 = row.Cells["ColumnKant2"].Value.ToString();
                    int Quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                    double total = (ProductWidth * ProductHeight) * Quantity;
                    string comment = row.Cells["ColumnComment"].Value.ToString();
                    string funksioni = row.Cells["ColumnFunction"].Value.ToString();
                    graphics.DrawString(IndexPrintDimensions.ToString(), font12, new SolidBrush(Color.Black), startX + 5, startY + Offset);
                    graphics.DrawString(ProductHeight.ToString(), font14, new SolidBrush(Color.Black), startX + 78, startY + Offset, format);
                    graphics.DrawString(ProductWidth.ToString(), font14, new SolidBrush(Color.Black), startX + 168, startY + Offset, format);
                    graphics.DrawString(Quantity.ToString(), font14, new SolidBrush(Color.Black), startX + 258, startY + Offset, format);
                    graphics.DrawString(funksioni, font12, new SolidBrush(Color.Black), startX + 399, startY + Offset, format);
                    graphics.DrawString(comment, font12, new SolidBrush(Color.Black), startX + 593, startY + Offset, format);

                    Offset += 28;
                    Point startPointDimensions = new Point(startX, startY + Offset);
                    Point endPointDimension = new Point(startX + 690, startY + Offset);
                    graphics.DrawLine(pen, startPointDimensions, endPointDimension);
                    Offset += 10;

                    totalm2 = totalm2 + ((ProductHeight * ProductWidth) * Quantity);
                    IndexPrintDimensions++;
                }
                IndexDimensions++;
            }
            Offset -= 10;

            #region Lines


            Point startPoint2End = new Point(startX, startY + Offset);
            Point endPoint2End = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penBold, startPoint2End, endPoint2End);

            startY -= 1;
            Pen penVerticalEnd = new Pen(Color.DarkGray, 1);
            Point linePoint1End = new Point(startX, startY + 217);
            Point linePoint2End = new Point(startX, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint1End, linePoint2End);

            Point linePoint3End = new Point(startX + 33, startY + 217);
            Point linePoint4End = new Point(startX + 33, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint3End, linePoint4End);

            Point linePoint5End = new Point(startX + 123, startY + 217);
            Point linePoint6End = new Point(startX + 123, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint5End, linePoint6End);

            Point linePoint7End = new Point(startX + 213, startY + 217);
            Point linePoint8End = new Point(startX + 213, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint7End, linePoint8End);

            Point linePoint9End = new Point(startX + 303, startY + 217);
            Point linePoint10End = new Point(startX + 303, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint9End, linePoint10End);

            Point linePoint15End = new Point(startX + 496, startY + 217);
            Point linePoint16End = new Point(startX + 496, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint15End, linePoint16End);

            Point linePoint17End = new Point(startX + 690, startY + 217);
            Point linePoint18End = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint17End, linePoint18End);
            #endregion

            Offset += 10;

            string grossTotal = "Total: " + String.Format("{0:0.0}", totalm2 / 1000000);

            StringFormat formatTotal = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            Rectangle r1 = new Rectangle(450, startY + Offset, 266, 30);

            Font stringFont2 = new Font("Arial", 13, FontStyle.Bold);
            stringSize = e.Graphics.MeasureString(grossTotal, stringFontBold);
            width = stringSize.Width / 2;

            graphics.DrawString(grossTotal, stringFont2, new SolidBrush(Color.Black), startX + 690 - width, startY + Offset, format);
            Offset = Offset + 20;
        }

        public int IndexAccessories { get; set; }
        public int IndexPrintAccessories = 1;
        void printAccessories_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            Font font15 = new Font("Calibri", 15);
            Font font10 = new Font("Calibri", 12);
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
            stringSize = e.Graphics.MeasureString("Klienti: " + client.Name, stringFont);
            float width = stringSize.Width / 2;

            graphics.DrawString("Klienti: " + client.Name + "", stringFont, new SolidBrush(Color.Black), r2, formatRight);
            graphics.DrawString("Data e Mbarimit: " + kitchen.DateExpire.ToString("dd/MM/yyyy"), stringFont, new SolidBrush(Color.Black), r3, formatRight);

            Offset += 20;

            graphics.DrawString("Aksesore / Materiale", new Font("Calibri", 22, FontStyle.Bold), new SolidBrush(Color.Black), startX + 340, startY + Offset, format);
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
                if (Offset+100 >= pageHeight)
                {
                    e.HasMorePages = true;
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
                }
                string shifra = dataGridAccessories.Rows[IndexAccessories].Cells["ColumnAccessoryID"].Value.ToString();
                string accessoryType = dataGridAccessories.Rows[IndexAccessories].Cells["ColumnAccessoryType"].Value.ToString();
                double Quantity = Convert.ToDouble(dataGridAccessories.Rows[IndexAccessories].Cells["ColumnAccessoryQuantity"].Value);
                graphics.DrawString(IndexPrintAccessories.ToString(), font10, new SolidBrush(Color.Black), startX + 5, startY + Offset);
                graphics.DrawString(accessoryType, font10, new SolidBrush(Color.Black), startX + 35, startY + Offset);
                graphics.DrawString(shifra, font10, new SolidBrush(Color.Black), startX + 301, startY + Offset, format);
                graphics.DrawString(Quantity.ToString(), font10, new SolidBrush(Color.Black), startX + 421, startY + Offset, format);
                Offset += 23;
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

        public string DimensionPrint { get; set; }



        public int IndexDimensions { get; set; }
        public int IndexPrintDimensions = 1;
        double totalm2;  
        void printDimensions_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (!e.HasMorePages)
            {
                IndexDimensions = 0;
                IndexPrintDimensions = 1;
                totalm2 = 0;  
            }
            Graphics graphics = e.Graphics;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            Font font15 = new Font("Calibri", 15);
            Font font12 = new Font("Calibri", 12);
            Font font14 = new Font("Calibri", 14, FontStyle.Bold);
            float pageHeight = e.PageSettings.PrintableArea.Height;
            Pen penBold = new Pen(Color.Black, 3);
            Pen pen = new Pen(Color.DarkGray);
            float fontHeight = font12.GetHeight();
            SolidBrush brush = new SolidBrush(Color.Black);
            Font stringFontBold = new Font("Calibri", 14, FontStyle.Bold);
            Font stringFont = new Font("Calibri", 12);

            int startX = 65;
            int startY = 50;
            int Offset = 0;
            StringFormat formatRight = new StringFormat();
            formatRight.Alignment = StringAlignment.Near;

            Image img = Image.FromFile(Application.StartupPath + "/img/Logo.jpg");
            Point ulCorner = new Point(startX, startY);
            graphics.DrawImage(img, ulCorner);

            if (DimensionPrint == "Konstrukti")
            {
                graphics.DrawString("Konstrukt:", stringFontBold, brush, startX, startY + 55);
                Rectangle rCommentReal = new Rectangle(startX + 5, startY + 80, 255, 55);
                Rectangle rComment = new Rectangle(startX, startY + 80, 265, 60);
                graphics.DrawRectangle(pen, rComment);
                graphics.DrawString(kitchen.KonstMaterial, stringFont, brush, rCommentReal, formatRight); 
            }
            else if (DimensionPrint == "Front")
            {
                graphics.DrawString("Front Material:", stringFontBold, brush, startX, startY + 55);
                Rectangle rCommentReal = new Rectangle(startX + 5, startY + 75, 255, 55);
                Rectangle rComment = new Rectangle(startX, startY + 80, 265, 60);
                graphics.DrawRectangle(pen, rComment);
                graphics.DrawString(kitchen.FrontMaterial, stringFont, brush, rCommentReal, formatRight);
            }
            else if (DimensionPrint == "Fioka")
            {
                graphics.DrawString("Fioka:", stringFontBold, brush, startX, startY + 55);
                Rectangle rComment = new Rectangle(startX, startY + 80, 265, 60);
                graphics.DrawRectangle(pen, rComment);
            }
            else if (DimensionPrint == "Polica")
            {
                graphics.DrawString("Polica:", stringFontBold, brush, startX, startY + 55);
                Rectangle rComment = new Rectangle(startX, startY + 80, 265, 60);
                graphics.DrawRectangle(pen, rComment);
            }


            Rectangle rMaster = new Rectangle(490, startY - 7, 226, 50);
            Rectangle r2 = new Rectangle(495, startY + Offset, 220, 28);
            Offset += 20;
            Rectangle r3 = new Rectangle(495, startY + Offset, 220, 28);
            Offset += 20;
            graphics.DrawRectangle(pen, rMaster);

            
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString("Klienti: " + client.Name, stringFont);
            float width = stringSize.Width / 2;

            graphics.DrawString("Klienti: " + client.Name + "", stringFont, new SolidBrush(Color.Black), r2, formatRight);
            graphics.DrawString("Data e Mbarimit: " + kitchen.DateExpire.ToString("dd/MM/yyyy"), stringFont, new SolidBrush(Color.Black), r3, formatRight);

            Offset += 100;

            Offset += 50;

            Rectangle rBackground= new Rectangle(startX, startY + Offset - 20, 690, 45);
            graphics.FillRectangle(new SolidBrush(Color.LightGray), rBackground);
            graphics.DrawString("No.", font12, new SolidBrush(Color.Black), startX+5, startY + Offset);
            graphics.DrawString("Lartësia \n (Tekstura)", font12, new SolidBrush(Color.Black), startX + 78, startY + Offset -20, format);
            graphics.DrawString("Gjërësia", font12, new SolidBrush(Color.Black), startX + 168, startY + Offset, format);
            graphics.DrawString("Sasia", font12, new SolidBrush(Color.Black), startX + 248, startY + Offset, format);
            if (DimensionPrint != "Lesonit" && DimensionPrint != "Front")
            {
                graphics.DrawString("Kant 1", font12, new SolidBrush(Color.Black), startX + 318, startY + Offset, format);
                graphics.DrawString("Kant 2", font12, new SolidBrush(Color.Black), startX + 388, startY + Offset, format);
            }
            if (DimensionPrint == "Lesonit")
            {
                graphics.DrawString("Pozicioni", font12, new SolidBrush(Color.Black), startX + 430, startY + Offset, format);
            }
            else
            {
                graphics.DrawString("Pozicioni", font12, new SolidBrush(Color.Black), startX + 468, startY + Offset, format);
            }
            graphics.DrawString("Koment", font12, new SolidBrush(Color.Black), startX + 601, startY + Offset, format);
            Offset += 25;            
            Point startPoint1 = new Point(startX, startY + Offset);
            Point endPoint1 = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penBold, startPoint1, endPoint1);
            Offset += 10;
                      
            while (IndexDimensions < DataGridViewDimensions.Rows.Count)
            {
                //if (Offset + 100 > pageHeight)
                //{
                //    Offset -= 10;
                //    e.HasMorePages = true;
                //    Point startPoint2 = new Point(startX, startY + Offset);
                //    Point endPoint2 = new Point(startX + 690, startY + Offset);
                //    graphics.DrawLine(penBold, startPoint2, endPoint2);

                //    Pen penVertical = new Pen(Color.DarkGray, 1);
                //    Point linePoint1 = new Point(startX, startY + 250);
                //    Point linePoint2 = new Point(startX, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint1, linePoint2);

                //    Point linePoint3 = new Point(startX + 35, startY + 250);
                //    Point linePoint4 = new Point(startX + 35, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint3, linePoint4);

                //    Point linePoint5 = new Point(startX + 115, startY + 250);
                //    Point linePoint6 = new Point(startX + 115, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint5, linePoint6);

                //    Point linePoint7 = new Point(startX + 195, startY + 250);
                //    Point linePoint8 = new Point(startX + 195, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint7, linePoint8);

                //    Point linePoint9 = new Point(startX + 260, startY + 250);
                //    Point linePoint10 = new Point(startX + 260, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint9, linePoint10);

                //    Point linePoint15 = new Point(startX + 425, startY + 250);
                //    Point linePoint16 = new Point(startX + 425, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint15, linePoint16);

                //    Point linePoint17 = new Point(startX + 690, startY + 250);
                //    Point linePoint18 = new Point(startX + 690, startY + Offset);
                //    graphics.DrawLine(penVertical, linePoint17, linePoint18);
                //    Offset -= 10;
                //    return;
                //}
                //else
                //{
                //    e.HasMorePages = false;
                //}

                DataGridViewRow row = DataGridViewDimensions.Rows[IndexDimensions];
                string ProductType = row.Cells["ColumnType"].Value.ToString();
                if (ProductType == DimensionPrint)
                {
                    double ProductWidth = Convert.ToDouble(row.Cells["ColumnWidth"].Value);
                    double ProductHeight = Convert.ToDouble(row.Cells["ColumnHeight"].Value);
                    string ProductKant = row.Cells["ColumnKant"].Value.ToString();
                    string ProductKant2 = row.Cells["ColumnKant2"].Value.ToString();
                    int Quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                    double total = (ProductWidth * ProductHeight) * Quantity;
                    string comment = row.Cells["ColumnComment"].Value.ToString();
                    string funksioni = row.Cells["ColumnFunction"].Value.ToString();
                    graphics.DrawString(IndexPrintDimensions.ToString(), font12, new SolidBrush(Color.Black), startX + 5, startY + Offset);
                    graphics.DrawString(ProductHeight.ToString(), font14, new SolidBrush(Color.Black), startX + 78, startY + Offset, format);
                    graphics.DrawString(ProductWidth.ToString(), font14, new SolidBrush(Color.Black), startX + 168, startY + Offset, format);
                    graphics.DrawString(Quantity.ToString(), font14, new SolidBrush(Color.Black), startX + 248, startY + Offset, format);
                    if (DimensionPrint == "Lesonit")
                    {
                        graphics.DrawString(funksioni, font12, new SolidBrush(Color.Black), startX + 340, startY + Offset, format);     
                    }
                    else
                    {
                        graphics.DrawString(ProductKant, font12, new SolidBrush(Color.Black), startX + 318, startY + Offset, format);
                        graphics.DrawString(ProductKant2, font12, new SolidBrush(Color.Black), startX + 388, startY + Offset, format);
                        graphics.DrawString(funksioni, font12, new SolidBrush(Color.Black), startX + 423, startY + Offset, format);                         
                    }
                                 
                    graphics.DrawString(comment, font12, new SolidBrush(Color.Black), startX + 601, startY + Offset, format);
                    Offset += 28;
                    Point startPointDimensions = new Point(startX, startY + Offset);
                    Point endPointDimension = new Point(startX + 690, startY + Offset);
                    graphics.DrawLine(pen, startPointDimensions, endPointDimension);
                    Offset += 10;
                    
                    totalm2 +=  (ProductHeight * ProductWidth) * Quantity;
                    IndexPrintDimensions++;
                }
                IndexDimensions++;
            }
            Offset -= 10;

            #region Lines

            
            Point startPoint2End = new Point(startX, startY + Offset);
            Point endPoint2End = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penBold, startPoint2End, endPoint2End);

            startY -= 1;
            Pen penVerticalEnd = new Pen(Color.DarkGray, 1);
            Point linePoint1End = new Point(startX, startY + 217);
            Point linePoint2End = new Point(startX, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint1End, linePoint2End);

            Point linePoint3End = new Point(startX + 33, startY + 217);
            Point linePoint4End = new Point(startX + 33, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint3End, linePoint4End);

            Point linePoint5End = new Point(startX + 123, startY + 217);
            Point linePoint6End = new Point(startX + 123, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint5End, linePoint6End);

            Point linePoint7End = new Point(startX + 213, startY + 217);
            Point linePoint8End = new Point(startX + 213, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint7End, linePoint8End);

            Point linePoint9End = new Point(startX + 283, startY + 217);
            Point linePoint10End = new Point(startX + 283, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint9End, linePoint10End);

            Point linePoint15End = new Point(startX + 353, startY + 217);
            Point linePoint16End = new Point(startX + 353, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint15End, linePoint16End);

            Point linePoint152End = new Point(startX + 423, startY + 217);
            Point linePoint162End = new Point(startX + 423, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint152End, linePoint162End);

            Point linePoint153End = new Point(startX + 513, startY + 217);
            Point linePoint163End = new Point(startX + 513, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint153End, linePoint163End);

            Point linePoint17End = new Point(startX + 690, startY + 217);
            Point linePoint18End = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penVerticalEnd, linePoint17End, linePoint18End);
            #endregion

            Offset += 10;

            string grossTotal = "Total: " + String.Format("{0:0.0}",totalm2/1000000);

            StringFormat formatTotal = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            Rectangle r1 = new Rectangle(450, startY + Offset, 266, 30);            

            Font stringFont2 = new Font("Arial", 13, FontStyle.Bold);
            stringSize = e.Graphics.MeasureString(grossTotal, stringFontBold);
            width = stringSize.Width / 2;

            graphics.DrawString(grossTotal, stringFont2, new SolidBrush(Color.Black), startX + 690 - width, startY + Offset, format);
            Offset = Offset + 20;
        }

        private void FormPrint_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
