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
    public partial class FormFrontDimensions : Form
    {
        int ProjectID;
        string DimensionPrint;
        string material;
        DateTime Expire;
        string Client;
        int ElementID;
        Kitchen project;
        public FormFrontDimensions(int projectid, string _dimensions, DateTime expire, string client, string _material)
        {
            DimensionPrint = _dimensions;
            material = _material;
            Client = client;
            InitializeComponent();
            ProjectID = projectid;
            DataGridViewDimensions.AutoGenerateColumns = false;
            LoadDimensions();
            Expire = expire;
            project = new Kitchen(projectid);
        }

        public FormFrontDimensions(int elementid, string dimensionType)
        {
            InitializeComponent();
            BtnPrint.Visible = false;
            ElementID = elementid;
            DimensionPrint = dimensionType;
            DataGridViewDimensions.AutoGenerateColumns = false;
            LoadDimensions();
        }

        private void LoadDimensions()
        {
            if (ProjectID != 0)
            {
                DataGridViewDimensions.DataSource = Dimension.GetKitchenDimensions(ProjectID, DimensionPrint);
            }
            else
            {
                DataGridViewDimensions.DataSource = Dimension.GetDimensions(ElementID, DimensionPrint);
            }

            foreach (DataGridViewRow row in DataGridViewDimensions.Rows)
            {
                double width = Convert.ToDouble(row.Cells["ColumnWidth"].Value);
                double height = Convert.ToDouble(row.Cells["ColumnHeight"].Value);
                string funksioni = row.Cells["ColumnFunction"].Value.ToString();

                foreach (DataGridViewRow rowCompare in DataGridViewDimensions.Rows)
                {
                    if (row.Index != rowCompare.Index)
                    {
                        double widthCompare = Convert.ToDouble(rowCompare.Cells["ColumnWidth"].Value);
                        double heightCompare = Convert.ToDouble(rowCompare.Cells["ColumnHeight"].Value);
                        int quantity = Convert.ToInt32(rowCompare.Cells["ColumnQuantity"].Value);
                        string funksionCompare = rowCompare.Cells["ColumnFunction"].Value.ToString();
                        if (width == widthCompare && height == heightCompare && funksioni == funksionCompare)
                        {
                            row.Cells["ColumnQuantity"].Value = Convert.ToInt32(row.Cells["ColumnQuantity"].Value) + quantity;
                            DataGridViewDimensions.Rows.Remove(rowCompare);
                        }
                    }
                }
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

        private void DataGridViewDimensions_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FormAddDimensions dime = new FormAddDimensions(ElementID, ProjectID, "Front");
            dime.ShowDialog();
            LoadDimensions();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            Printing.PrintFront(DataGridViewDimensions, Client, "", project.Name, Expire, material);

            //PrintDocument printFront = new PrintDocument();
            //printFront.DocumentName = "Front";
            //printFront.PrintPage += printFront_PrintPage;
            //PrintDialog dialog = new PrintDialog();
            //dialog.Document = printFront;
            //if (dialog.ShowDialog() == DialogResult.OK)
            //{
            //    printFront.Print();
            //}
        }

        public int IndexDimensions { get; set; }
        public int IndexPrintDimensions = 1;
        double totalm2;
        private bool morePages
        {
            get; set;
        }
        private void printFront_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (!morePages)
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


            graphics.DrawString("Front:", stringFontBold, brush, startX, startY + 55);
            Rectangle rComment = new Rectangle(startX, startY + 80, 265, 60);
            Rectangle rCommentReal = new Rectangle(startX + 5, startY + 80, 255, 55);
            graphics.DrawRectangle(pen, rComment);
            graphics.DrawString(material, stringFont, brush, rCommentReal, formatRight);

            #region Right Box

            Rectangle rMaster = new Rectangle(490, startY - 7, 226, 50);
            Rectangle r2 = new Rectangle(495, startY + Offset, 220, 28);
            Offset += 20;
            Rectangle r3 = new Rectangle(495, startY + Offset, 220, 28);
            Offset += 20;
            graphics.DrawRectangle(pen, rMaster);
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString("Klienti: " + Client, stringFont);
            float width = stringSize.Width / 2;

            graphics.DrawString("Klienti: " + Client + "", stringFont, new SolidBrush(Color.Black), r2, formatRight);
            graphics.DrawString("Data e Mbarimit: " + Expire.ToString("dd/MM/yyyy"), stringFont, new SolidBrush(Color.Black), r3, formatRight);
            #endregion
            
            Offset += 100;

            Offset += 50;

            Rectangle rBackground = new Rectangle(startX, startY + Offset - 20, 690, 45);
            graphics.FillRectangle(new SolidBrush(Color.LightGray), rBackground);
            graphics.DrawString("No.", font12, new SolidBrush(Color.Black), startX + 5, startY + Offset);
            graphics.DrawString("Lartësia \n (Tekstura)", font12, new SolidBrush(Color.Black), startX + 78, startY + Offset - 20, format);
            graphics.DrawString("Gjërësia", font12, new SolidBrush(Color.Black), startX + 168, startY + Offset, format);
            graphics.DrawString("Sasia", font12, new SolidBrush(Color.Black), startX + 258, startY + Offset, format);
            graphics.DrawString("Funksioni", font12, new SolidBrush(Color.Black), startX + 399, startY + Offset, format);            
            graphics.DrawString("Koment", font12, new SolidBrush(Color.Black), startX + 593, startY + Offset, format);

            Offset += 25;
            Point startPoint1 = new Point(startX, startY + Offset);
            Point endPoint1 = new Point(startX + 690, startY + Offset);
            graphics.DrawLine(penBold, startPoint1, endPoint1);
            Offset += 10;

            while (IndexDimensions < DataGridViewDimensions.Rows.Count)
            {
                if (Offset + 100 > pageHeight)
                {
                    Offset -= 10;
                    e.HasMorePages = true;
                    morePages = true;
                    Point startPoint2 = new Point(startX, startY + Offset);
                    Point Point2 = new Point(startX + 690, startY + Offset);
                    graphics.DrawLine(penBold, startPoint2, Point2);

                    startY -= 1;
                    Pen penVertical = new Pen(Color.DarkGray, 1);
                    Point linePoint1 = new Point(startX, startY + 217);
                    Point linePoint2 = new Point(startX, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint1, linePoint2);

                    Point linePoint3 = new Point(startX + 33, startY + 217);
                    Point linePoint4 = new Point(startX + 33, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint3, linePoint4);

                    Point linePoint5 = new Point(startX + 123, startY + 217);
                    Point linePoint6 = new Point(startX + 123, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint5, linePoint6);

                    Point linePoint7 = new Point(startX + 213, startY + 217);
                    Point linePoint8 = new Point(startX + 213, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint7, linePoint8);

                    Point linePoint9 = new Point(startX + 303, startY + 217);
                    Point linePoint10 = new Point(startX + 303, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint9, linePoint10);

                    Point linePoint15 = new Point(startX + 496, startY + 217);
                    Point linePoint16 = new Point(startX + 496, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint15, linePoint16);

                    Point linePoint17 = new Point(startX + 690, startY + 217);
                    Point linePoint18 = new Point(startX + 690, startY + Offset);
                    graphics.DrawLine(penVertical, linePoint17, linePoint18);

                    Offset -= 10;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                    morePages = false;
                }

                DataGridViewRow row = DataGridViewDimensions.Rows[IndexDimensions];

                    double ProductWidth = Convert.ToDouble(row.Cells["ColumnWidth"].Value);
                    double ProductHeight = Convert.ToDouble(row.Cells["ColumnHeight"].Value);
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

        private void DataGridViewDimensions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(DataGridViewDimensions.Rows[e.RowIndex].Cells["ColumnID"].Value);
                if(id != 0)
                {
                    if (ProjectID != 0)
                    {
                        Dimension.DeleteManualDimensions(id);
                    }
                    else
                    {
                        Dimension.Delete(id);
                    }
                    DataGridViewDimensions.Rows.Remove((DataGridViewDimensions.Rows[e.RowIndex]));
                }
            }
        }
    }
}
