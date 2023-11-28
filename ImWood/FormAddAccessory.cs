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
    public partial class FormAddAccessory : Form
    {
        private int ElementID { get; set; }
        public int KitchenID { get; set; }
        private bool isKitchen { get; set; }
        public FormAddAccessory(int elementid)
        {
            InitializeComponent();
            ElementID = elementid;
            isKitchen = false;
            
        }

        public FormAddAccessory(int kitchenid, bool _isKitchen)
        {
            InitializeComponent();
            KitchenID = kitchenid;
            isKitchen = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DataGridViewAccessoryTypes.CurrentRow;
            string accName = row.Cells[0].Value.ToString();
            if (!isKitchen)
            {
                Accessory acc = new Accessory(ElementID, accName, int.Parse(TxtBoxQuantity.Text), "", "");
                if (acc.Check())
                { acc.Save(); LblStatus.Text = "Element added: " + accName + ", Quantity: " + TxtBoxQuantity.Text; }
                else { MessageBox.Show("Kjo shifër egziston në listën tuaj!"); }
            }
            else
            {
                Accessory acc = new Accessory(ElementID, accName, int.Parse(TxtBoxQuantity.Text), 
                    TxtBoxID.Text, TxtBoxDescription.Text);
                acc.AddToKitchen(KitchenID);
                LblStatus.Text = "Element added: " + accName + ", Quantity: " + TxtBoxQuantity.Text;
                TxtBoxType.Text = "";
                TxtBoxDescription.Text = "";
                TxtBoxQuantity.Text = "1";
                TxtBoxID.Text = "";
            }
            
            TxtBoxQuantity.Text = "1";
        }

        private void TxtBoxQuantity_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate
            {
                TxtBoxQuantity.SelectAll();
            });
        }

        private void FormAddAccessory_Load(object sender, EventArgs e)
        {
            loaditems();
        }

        private void FormAddAccessory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void loaditems()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Tipi");
            foreach (String acc in Properties.Settings.Default.AccTypes)
            {
                table.Rows.Add(acc);
            }
            DataGridViewAccessoryTypes.DataSource = table;
            DataGridViewAccessoryTypes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            dataGridQuickSearch.DataSource = table;
            dataGridQuickSearch.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DataGridViewAccessoryTypes.DataSource;
            bs.Filter = "Tipi LIKE '%" + TxtBoxSearch.Text + "%'";
        }


        private void TxtBoxType_TextChanged(object sender, EventArgs e)
        {
            if (TxtBoxType.Text.Length > 0)
            {
                dataGridQuickSearch.Visible = true;
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridQuickSearch.DataSource;
                bs.Filter = "Tipi LIKE '%" + TxtBoxType.Text + "%'";
            }
            else
            {
                dataGridQuickSearch.Visible = false;
            }
        }
    

        private void TxtBoxType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {                
                int index = dataGridQuickSearch.CurrentRow.Index;
                if (index < dataGridQuickSearch.Rows.Count)
                {
                    dataGridQuickSearch.CurrentCell = dataGridQuickSearch.Rows[index + 1].Cells[0];
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                int index = dataGridQuickSearch.CurrentRow.Index;
                if (index > 0)
                {
                    dataGridQuickSearch.CurrentCell = dataGridQuickSearch.Rows[index - 1].Cells[0];
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                string text = DataGridViewAccessoryTypes.CurrentCell.Value.ToString();
                TxtBoxType.Text = text;
                dataGridQuickSearch.Visible = false;
            }
        }

        private void DataGridViewAccessoryTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtBoxType.TextChanged -= TxtBoxType_TextChanged;
            string text = DataGridViewAccessoryTypes.CurrentCell.Value.ToString();
            TxtBoxType.Text = text;
            dataGridQuickSearch.Visible = false;
            TxtBoxType.TextChanged += TxtBoxType_TextChanged;
        }

        private void dataGridQuickSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = DataGridViewAccessoryTypes.CurrentCell.Value.ToString();
                TxtBoxType.Text = text;
                dataGridQuickSearch.Visible = false;
        
            }
        }

        private void TxtBoxType_Leave(object sender, EventArgs e)
        {
            dataGridQuickSearch.Visible = false;
        }

        private void TxtBoxType_Enter(object sender, EventArgs e)
        {
            BeginInvoke((Action)delegate
            {
                TxtBoxType.SelectAll();
            });
        }

    }
}
