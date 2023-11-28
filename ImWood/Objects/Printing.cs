using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Windows.Forms;
using System.Data;
namespace ImWood
{
    class Printing
    {
        public static Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

        public static void PrintFioka(DataGridView grid, string clientname, string phone, string projectName, DateTime ExpireDate, string konstruktDesc, string title)
        {
            double totalm2 = 0;
            double totalQuantity = 0;
            try
            {
                var documents = wordApp.Documents;

                if (documents.Count > 0)
                {
                    wordApp.Quit(SaveChanges: false);
                    wordApp = new Microsoft.Office.Interop.Word.Application();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "During Printing");
                wordApp = new Microsoft.Office.Interop.Word.Application();
            }

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = Directory.GetCurrentDirectory() + "\\docs\\" + "Fioka.docx";


            Document wordDoc = new Document();

            int rowCount = 2;
            try
            {
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

                int rowNumber = 1;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    wordDoc.Tables[2].Rows.Add(ref oMissing);
                    wordDoc.Tables[2].Rows[rowCount].Cells[1].Range.Text = rowNumber.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[2].Range.Text = row.Cells[1].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[3].Range.Text = row.Cells[2].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[4].Range.Text = row.Cells[3].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[5].Range.Text = row.Cells[4].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[6].Range.Text = row.Cells[5].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[7].Range.Text = row.Cells[6].Value.ToString();

                    wordDoc.Tables[2].Rows[rowCount].Cells[9].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[10].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[11].Range.Text = "⃝";

                    double ProductWidth = Convert.ToDouble(row.Cells["ColumnWidth"].Value);
                    double ProductHeight = Convert.ToDouble(row.Cells["ColumnHeight"].Value);
                    int Quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                    totalm2 += (ProductHeight * ProductWidth) * Quantity;
                    totalQuantity += Quantity;
                    rowCount++;
                    rowNumber++;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                MessageBox.Show("error: " + ex.StackTrace);
            }

            foreach (Field myMergeField in wordDoc.Fields)
            {

                Range rngFieldCode = myMergeField.Code;

                String fieldText = rngFieldCode.Text;


                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    if (fieldName == "ClientName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(clientname);
                    }

                    if (fieldName == "Phone")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(phone);
                    }

                    if (fieldName == "ProjectName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(projectName);
                    }
                    if (fieldName == "ExpireDate")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(ExpireDate.ToString("dd/MM/yyyy"));
                    }
                    if (fieldName == "Konstrukt")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(konstruktDesc);
                    }

                    if (fieldName == "DocTitle")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(title);
                    }

                    if (fieldName == "TotalQuantity")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(totalQuantity.ToString());
                    }

                    if (fieldName == "TotalSquare")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(String.Format("{0:0.0}", totalm2 / 1000000));
                    }
                }
            }
            wordApp.Visible = true;
            wordDoc.Activate();
            wordApp.Activate();
            //wordDoc.PrintOut(Copies: 1);
        }

        public static void PrintPolica(DataGridView grid, string clientname, string phone, string projectName, DateTime ExpireDate, string konstruktDesc, string title)
        {
            double totalm2 = 0;
            double totalQuantity = 0;
            try
            {
                var documents = wordApp.Documents;

                if (documents.Count > 0)
                {
                    wordApp.Quit(SaveChanges: false);
                    wordApp = new Microsoft.Office.Interop.Word.Application();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "During Printing");
                wordApp = new Microsoft.Office.Interop.Word.Application();
            }

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = Directory.GetCurrentDirectory() + "\\docs\\" + "Polica.docx";


            Document wordDoc = new Document();

            int rowCount = 2;
            try
            {
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

                int rowNumber = 1;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    wordDoc.Tables[2].Rows.Add(ref oMissing);
                    wordDoc.Tables[2].Rows[rowCount].Cells[1].Range.Text = rowNumber.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[2].Range.Text = row.Cells[1].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[3].Range.Text = row.Cells[2].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[4].Range.Text = row.Cells[3].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[5].Range.Text = row.Cells[4].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[6].Range.Text = row.Cells[5].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[7].Range.Text = row.Cells[6].Value.ToString();

                    wordDoc.Tables[2].Rows[rowCount].Cells[9].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[10].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[11].Range.Text = "⃝";

                    double ProductWidth = Convert.ToDouble(row.Cells["ColumnWidth"].Value);
                    double ProductHeight = Convert.ToDouble(row.Cells["ColumnHeight"].Value);
                    int Quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                    totalm2 += (ProductHeight * ProductWidth) * Quantity;
                    totalQuantity += Quantity;
                    rowCount++;
                    rowNumber++;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                MessageBox.Show("error: " + ex.StackTrace);
            }

            foreach (Field myMergeField in wordDoc.Fields)
            {

                Range rngFieldCode = myMergeField.Code;

                String fieldText = rngFieldCode.Text;


                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    if (fieldName == "ClientName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(clientname);
                    }

                    if (fieldName == "Phone")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(phone);
                    }

                    if (fieldName == "ProjectName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(projectName);
                    }
                    if (fieldName == "ExpireDate")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(ExpireDate.ToString("dd/MM/yyyy"));
                    }
                    if (fieldName == "Lesonit")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(konstruktDesc);
                    }

                    if (fieldName == "DocTitle")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(title);
                    }

                    if (fieldName == "TotalQuantity")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(totalQuantity.ToString());
                    }

                    if (fieldName == "TotalSquare")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(String.Format("{0:0.0}", totalm2 / 1000000));
                    }
                }
            }
            wordApp.Visible = true;
            wordDoc.Activate();
            wordApp.Activate();
            //wordDoc.PrintOut(Copies: 1);
        }

        public static void PrintKonstrukt(DataGridView grid, string clientname, string phone, string projectName, DateTime ExpireDate, string konstruktDesc, string title)
        {
            double totalm2 = 0;
            double totalQuantity = 0;
            try
            {
                var documents = wordApp.Documents;

                if (documents.Count > 0)
                {
                    wordApp.Quit(SaveChanges: false);
                    wordApp = new Microsoft.Office.Interop.Word.Application();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "During Printing");
                wordApp = new Microsoft.Office.Interop.Word.Application();
            }

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = Directory.GetCurrentDirectory() + "\\docs\\" + "Konstrukti.docx";


            Document wordDoc = new Document();

            int rowCount = 2;
            try
            {
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);                

                int rowNumber = 1;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    wordDoc.Tables[2].Rows.Add(ref oMissing);
                    wordDoc.Tables[2].Rows[rowCount].Cells[1].Range.Text = rowNumber.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[2].Range.Text = row.Cells[1].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[3].Range.Text = row.Cells[2].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[4].Range.Text = row.Cells[3].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[5].Range.Text = row.Cells[4].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[6].Range.Text = row.Cells[5].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[7].Range.Text = row.Cells[6].Value.ToString();

                    wordDoc.Tables[2].Rows[rowCount].Cells[9].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[10].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[11].Range.Text = "⃝";

                    double ProductWidth = Convert.ToDouble(row.Cells["ColumnWidth"].Value);
                    double ProductHeight = Convert.ToDouble(row.Cells["ColumnHeight"].Value);
                    int Quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                    totalm2 += (ProductHeight * ProductWidth) * Quantity;
                    totalQuantity += Quantity;
                    rowCount++;
                    rowNumber++;
                }
            }            
            catch (Exception ex)
            {
                Log.Error(ex, "");
                MessageBox.Show("error: " + ex.StackTrace);
            }

            foreach (Field myMergeField in wordDoc.Fields)
            {

                Range rngFieldCode = myMergeField.Code;

                String fieldText = rngFieldCode.Text;


                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    if (fieldName == "ClientName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(clientname);
                    }

                    if (fieldName == "Phone")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(phone);
                    }

                    if (fieldName == "ProjectName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(projectName);
                    }
                    if (fieldName == "ExpireDate")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(ExpireDate.ToString("dd/MM/yyyy"));
                    }
                    if (fieldName == "Konstrukt")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(konstruktDesc);
                    }

                    if (fieldName == "DocTitle")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(title);
                    }

                    if (fieldName == "TotalQuantity")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(totalQuantity.ToString());
                    }
                    
                    if (fieldName == "TotalSquare")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(String.Format("{0:0.0}", totalm2 / 1000000));
                    }
                }
            }
            wordApp.Visible = true;
            wordDoc.Activate();
            wordApp.Activate();
            //wordDoc.PrintOut(Copies: 1);
        }

        public static void PrintFront(DataGridView grid, string clientname, string phone, string projectName, DateTime ExpireDate, string konstruktDesc)
        {
            double totalm2 = 0;
            double totalQuantity = 0;
            try
            {
                var documents = wordApp.Documents;

                if (documents.Count > 0)
                {
                    wordApp.Quit(SaveChanges: false);
                    wordApp = new Microsoft.Office.Interop.Word.Application();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "During Printing");
                wordApp = new Microsoft.Office.Interop.Word.Application();
            }

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = Directory.GetCurrentDirectory() + "\\docs\\" + "Front.docx";


            Document wordDoc = new Document();

            int rowCount = 2;
            try
            {
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

                int rowNumber = 1;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    wordDoc.Tables[2].Rows.Add(ref oMissing);
                    wordDoc.Tables[2].Rows[rowCount].Cells[1].Range.Text = rowNumber.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[2].Range.Text = row.Cells[1].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[3].Range.Text = row.Cells[2].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[4].Range.Text = row.Cells[3].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[5].Range.Text = row.Cells[4].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[6].Range.Text = row.Cells[5].Value.ToString();

                    wordDoc.Tables[2].Rows[rowCount].Cells[7].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[8].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[9].Range.Text = "⃝";

                    double ProductWidth = Convert.ToDouble(row.Cells["ColumnWidth"].Value);
                    double ProductHeight = Convert.ToDouble(row.Cells["ColumnHeight"].Value);
                    int Quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                    totalm2 += (ProductHeight * ProductWidth) * Quantity;
                    totalQuantity += Quantity;
                    rowCount++;
                    rowNumber++;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                MessageBox.Show("error: " + ex.StackTrace);
            }

            foreach (Field myMergeField in wordDoc.Fields)
            {

                Range rngFieldCode = myMergeField.Code;

                String fieldText = rngFieldCode.Text;


                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    if (fieldName == "ClientName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(clientname);
                    }

                    if (fieldName == "Phone")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(phone);
                    }

                    if (fieldName == "ProjectName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(projectName);
                    }
                    if (fieldName == "ExpireDate")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(ExpireDate.ToString("dd/MM/yyyy"));
                    }
                    if (fieldName == "Front")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(konstruktDesc);
                    }

                    if (fieldName == "TotalQuantity")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(totalQuantity.ToString());
                    }

                    if (fieldName == "TotalSquare")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(String.Format("{0:0.0}", totalm2 / 1000000));
                    }
                }
            }
            wordApp.Visible = true;
            wordDoc.Activate();
            wordApp.Activate();
            //wordDoc.PrintOut(Copies: 1);
        }

        public static void PrintLesonit(DataGridView grid, string clientname, string phone, string projectName, DateTime ExpireDate, string konstruktDesc)
        {
            double totalm2 = 0;
            double totalQuantity = 0;
            try
            {
                var documents = wordApp.Documents;

                if (documents.Count > 0)
                {
                    wordApp.Quit(SaveChanges: false);
                    wordApp = new Microsoft.Office.Interop.Word.Application();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "During Printing");
                wordApp = new Microsoft.Office.Interop.Word.Application();
            }

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = Directory.GetCurrentDirectory() + "\\docs\\" + "Lesonit.docx";


            Document wordDoc = new Document();

            int rowCount = 2;
            try
            {
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

                int rowNumber = 1;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    wordDoc.Tables[2].Rows.Add(ref oMissing);
                    wordDoc.Tables[2].Rows[rowCount].Cells[1].Range.Text = rowNumber.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[2].Range.Text = row.Cells[1].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[3].Range.Text = row.Cells[2].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[4].Range.Text = row.Cells[3].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[5].Range.Text = row.Cells[4].Value.ToString();
                    wordDoc.Tables[2].Rows[rowCount].Cells[6].Range.Text = row.Cells[5].Value.ToString();

                    wordDoc.Tables[2].Rows[rowCount].Cells[7].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[8].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCount].Cells[9].Range.Text = "⃝";

                    double ProductWidth = Convert.ToDouble(row.Cells["ColumnWidth"].Value);
                    double ProductHeight = Convert.ToDouble(row.Cells["ColumnHeight"].Value);
                    int Quantity = Convert.ToInt32(row.Cells["ColumnQuantity"].Value);
                    totalm2 += (ProductHeight * ProductWidth) * Quantity;
                    totalQuantity += Quantity;
                    rowCount++;
                    rowNumber++;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                MessageBox.Show("error: " + ex.StackTrace);
            }

            foreach (Field myMergeField in wordDoc.Fields)
            {

                Range rngFieldCode = myMergeField.Code;

                String fieldText = rngFieldCode.Text;


                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    if (fieldName == "ClientName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(clientname);
                    }

                    if (fieldName == "Phone")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(phone);
                    }

                    if (fieldName == "ProjectName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(projectName);
                    }
                    if (fieldName == "ExpireDate")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(ExpireDate.ToString("dd/MM/yyyy"));
                    }
                    if (fieldName == "Lesonit")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(konstruktDesc);
                    }

                    if (fieldName == "TotalQuantity")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(totalQuantity.ToString());
                    }

                    if (fieldName == "TotalSquare")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(String.Format("{0:0.0}", totalm2 / 1000000));
                    }
                }
            }
            wordApp.Visible = true;
            wordDoc.Activate();
            wordApp.Activate();
            //wordDoc.PrintOut(Copies: 1);
        }


        public static void PrintProcess(DataGridView grid, string clientname, string phone, string projectName, DateTime ExpireDate, System.Data.DataTable totalTable)
        {
            double totalm2 = 0;
            double totalQuantity = 0;
            try
            {
                var documents = wordApp.Documents;

                if (documents.Count > 0)
                {
                    wordApp.Quit(SaveChanges: false);
                    wordApp = new Microsoft.Office.Interop.Word.Application();
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "During Printing");
                wordApp = new Microsoft.Office.Interop.Word.Application();
            }

            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = Directory.GetCurrentDirectory() + "\\docs\\" + "Procesi.docx";


            Document wordDoc = new Document();

            int rowCountAccessories = 2;
            int rowCountTotals = 2;
            try
            {
                wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

                

                foreach(DataRow row in totalTable.Rows)
                {
                   
                    wordDoc.Tables[2].Rows[rowCountTotals].Cells[1].Range.Text = row[0].ToString();
                    wordDoc.Tables[2].Rows[rowCountTotals].Cells[2].Range.Text = row[1].ToString();
                    wordDoc.Tables[2].Rows[rowCountTotals].Cells[3].Range.Text = row[2].ToString();
                    wordDoc.Tables[2].Rows[rowCountTotals].Cells[4].Range.Text = row[3].ToString();

                    wordDoc.Tables[2].Rows[rowCountTotals].Cells[5].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCountTotals].Cells[6].Range.Text = "⃝";
                    wordDoc.Tables[2].Rows[rowCountTotals].Cells[7].Range.Text = "⃝";

                    rowCountTotals++;
                }


                int rowNumber = 1;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    wordDoc.Tables[3].Rows.Add(ref oMissing);
                    wordDoc.Tables[3].Rows[rowCountAccessories].Cells[1].Range.Text = rowNumber.ToString();
                    wordDoc.Tables[3].Rows[rowCountAccessories].Cells[2].Range.Text = row.Cells[1].Value.ToString();
                    wordDoc.Tables[3].Rows[rowCountAccessories].Cells[3].Range.Text = row.Cells[3].Value.ToString();
                    wordDoc.Tables[3].Rows[rowCountAccessories].Cells[4].Range.Text = row.Cells[4].Value.ToString();
                    wordDoc.Tables[3].Rows[rowCountAccessories].Cells[5].Range.Text = row.Cells[2].Value.ToString();

                    wordDoc.Tables[3].Rows[rowCountAccessories].Cells[6].Range.Text = "⃝";
                    wordDoc.Tables[3].Rows[rowCountAccessories].Cells[7].Range.Text = "⃝";
                    wordDoc.Tables[3].Rows[rowCountAccessories].Cells[8].Range.Text = "⃝";                   
                    rowCountAccessories++;
                    rowNumber++;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                MessageBox.Show("error: " + ex.StackTrace);
            }

            foreach (Field myMergeField in wordDoc.Fields)
            {

                Range rngFieldCode = myMergeField.Code;

                String fieldText = rngFieldCode.Text;


                // ONLY GETTING THE MAILMERGE FIELDS

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    // MERGEFIELD  MyFieldName  \\* MERGEFORMAT

                    // THIS HAS TO BE EDITED TO GET ONLY THE FIELDNAME "MyFieldName"

                    Int32 endMerge = fieldText.IndexOf("\\");

                    Int32 fieldNameLength = fieldText.Length - endMerge;

                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    // GIVES THE FIELDNAMES AS THE USER HAD ENTERED IN .dot FILE

                    fieldName = fieldName.Trim();

                    // THE PROGRAMMER CAN HAVE HIS OWN IMPLEMENTATIONS HERE

                    if (fieldName == "ClientName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(clientname);
                    }

                    if (fieldName == "Phone")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(phone);
                    }

                    if (fieldName == "ProjectName")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(projectName);
                    }
                    if (fieldName == "ExpireDate")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(ExpireDate.ToString("dd/MM/yyyy"));
                    }

                  

                    if (fieldName == "TotalQuantity")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(totalQuantity.ToString());
                    }

                    if (fieldName == "TotalSquare")
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(String.Format("{0:0.0}", totalm2 / 1000000));
                    }
                }
            }
            wordApp.Visible = true;
            wordDoc.Activate();
            wordApp.Activate();
            //wordDoc.PrintOut(Copies: 1);
        }
    }
}
