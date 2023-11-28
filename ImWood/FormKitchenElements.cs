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
    public partial class FormKitchenElements : Form
    {
        int KitchenID;
        public FormKitchenElements(int kitchenid, bool _finished)
        {
            InitializeComponent();
            KitchenID = kitchenid;
            DataGridElements.AutoGenerateColumns = false;
            if (_finished)
            {
                BtnAddElement.Visible = false;
                ColumnDelete.Visible = false;
            }
            LoadElements();
        }

        private void LoadElements()
        {
            DataGridElements.DataSource = Element.GetKitchenElements(KitchenID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormElementsCHOOSE form = new FormElementsCHOOSE(KitchenID);
            form.ShowDialog();
            LoadElements();
        }

        private void DataGridElements_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                int elementid = Convert.ToInt32(DataGridElements.Rows[e.RowIndex].Cells["ColumnElementID"].Value);
                Element.DeleteElementFromKitchen(elementid, KitchenID);
                DataGridElements.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void FormKitchenElements_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
