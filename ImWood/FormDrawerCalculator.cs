using ImWood.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImWood
{
    public partial class FormDrawerCalculator : Form
    {
        private int SelectedDrawerID;
        private int KitchenID;
        public FormDrawerCalculator(int _kitchenID)
        {
            InitializeComponent();
            DataGridDrawers.AutoGenerateColumns = false;
            DataGridSelectedDrawers.AutoGenerateColumns = false;
            KitchenID = _kitchenID;
            LoadDrawers();
            LoadKitchenDrawers();
        }

        private void LoadDrawers()
        {
            DataGridDrawers.DataSource = Drawer.GetAllDrawers();
        }


        private void LoadKitchenDrawers()
        {
            DataGridSelectedDrawers.DataSource = KitchenDrawers.GetKitchenDrawers(KitchenID);
        }

        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string filter = "Name LIKE '%" + TxtBoxSearch.Text + "%'";
            BindingSource bs = new BindingSource();
            bs.DataSource = DataGridDrawers.DataSource;
            bs.Filter = filter;
        }

        private void DataGridDrawers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedDrawerID = Convert.ToInt32(DataGridDrawers.Rows[e.RowIndex].Cells["ColumnDrawerID"].Value);
            LblDrawerModelName.Text = DataGridDrawers.Rows[e.RowIndex].Cells["ColumnDrawerName"].Value.ToString();
        }

        private void BtnAddDrawer_Click(object sender, EventArgs e)
        {
            if (SelectedDrawerID != 0)
            {
                Drawer drawer = new Drawer(SelectedDrawerID);
                double w = double.Parse(TxtBoxWidthW.Text);
                double d = double.Parse(TxtBoxDepth.Text);
                int qty = int.Parse(TxtBoxQTY.Text);

                if (drawer.Formula == DrawerTypes.SmartBox)
                {                   

                    var heightA = w + drawer.x;
                    var widthA = d + drawer.y;

                    var heightB = w + drawer.z;
                    var widthB = drawer.s;

                    double inboxPanel = 0;

                    if (ChkBoxInbox.Checked)
                    {
                        inboxPanel = w + drawer.a;
                        int inboxQty = Convert.ToInt32(inboxPanel) * qty;
                        Accessory acc = new Accessory(0, "Inbox Panel", inboxQty, "", "");
                        acc.AddToKitchen(KitchenID);
                    }

                    Dimension dimA = new Dimension(widthA, heightA, qty, drawer.KantA1, drawer.KantA2, "Fioka", 0, KitchenID, "", "");
                    dimA.AddToDBMANUAL();

                    Dimension dimB = new Dimension(widthB, heightB, qty, drawer.KantB1, drawer.KantB2, "Fioka", 0, KitchenID, "", "");
                    dimB.AddToDBMANUAL();

                    KitchenDrawers kdrawA = new KitchenDrawers { DrawerID = drawer.ID, Quantity = qty, DimensionID = dimA.ID, Inbox = ChkBoxInbox.Checked };
                    kdrawA.Save();
                    KitchenDrawers kdrawB = new KitchenDrawers { DrawerID = drawer.ID, Quantity = qty, DimensionID = dimB.ID, Inbox = ChkBoxInbox.Checked };
                    kdrawB.Save();
                    
                }
                else if (drawer.Formula == DrawerTypes.SmartSlide)
                {                 

                    var heightA = w + drawer.x;
                    var widthA = drawer.y - 10;

                    var heightB = d + drawer.z;
                    var widthB = drawer.y;

                    var lesonitHeight = w - drawer.a;
                    var lesonitWidth = d - drawer.z;

                    Dimension dimA = new Dimension(widthA, heightA, qty*2, drawer.KantA1, drawer.KantA2, "Fioka", 0, KitchenID, "", "");
                    dimA.AddToDBMANUAL();

                    Dimension dimB = new Dimension(widthB, heightB, qty*2, drawer.KantB1, drawer.KantB2, "Fioka", 0, KitchenID, "", "");
                    dimB.AddToDBMANUAL();

                    Dimension dimLesonit = new Dimension(lesonitWidth, lesonitHeight, qty, drawer.KantA1, drawer.KantA2, "Lesonit", 0, KitchenID, "", "");
                    dimA.AddToDBMANUAL();

                    KitchenDrawers kdrawA = new KitchenDrawers { DrawerID = drawer.ID, Quantity = qty, DimensionID = dimA.ID, Inbox = false };
                    kdrawA.Save();

                    KitchenDrawers kdrawB = new KitchenDrawers { DrawerID = drawer.ID, Quantity = qty, DimensionID = dimB.ID, Inbox = false };
                    kdrawB.Save();

                    KitchenDrawers kdrawLesonit = new KitchenDrawers { DrawerID = drawer.ID, Quantity = qty, DimensionID = dimLesonit.ID, Inbox = false };
                    kdrawLesonit.Save();
                }

                TxtBoxDepth.Text = "";
                TxtBoxWidthW.Text = "";
                TxtBoxQTY.Text = "";
                ChkBoxInbox.Checked = false;
                SelectedDrawerID = 0;
                LblDrawerModelName.Text = "Selekto modelin";

                LoadKitchenDrawers();
            }
        }

        private void DataGridSelectedDrawers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == ColumnDelete.Index)
                {
                    int drawerid = (int)DataGridSelectedDrawers.Rows[e.RowIndex].Cells["ColumnKitchenDrawerID"].Value;

                    foreach(DataGridViewRow row in DataGridSelectedDrawers.Rows)
                    {
                        int id = (int)row.Cells["ColumnKitchenDrawerID"].Value;

                        if (drawerid == id && row.Index != e.RowIndex)
                        {
                            int dimID = (int)row.Cells["ColumnDimensionID"].Value;
                            KitchenDrawers.Delete(drawerid, dimID);
                            Dimension.DeleteManualDimensions(dimID);                            
                        }
                        
                    }

                    int dimensionID = (int)DataGridSelectedDrawers.Rows[e.RowIndex].Cells["ColumnDimensionID"].Value;                   
                    bool inbox = (bool)DataGridSelectedDrawers.Rows[e.RowIndex].Cells["ColumnInbox"].Value;
                    if (inbox)
                    {
                        Dimension dim = new Dimension(dimensionID);
                        Drawer drawer = new Drawer(drawerid);
                        double w = dim.Height - drawer.x;
                        int wInt = Convert.ToInt32(w);
                        Accessory.SubtractAccessory("Inbox Panel", wInt, KitchenID);
                    }
                    KitchenDrawers.Delete(drawerid, dimensionID);
                    Dimension.DeleteManualDimensions(dimensionID);
                    LoadKitchenDrawers();
                }
            }
        }
    }
}
