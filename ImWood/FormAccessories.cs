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
    public partial class FormAccessories : Form
    {
        private int ElementID { get; set; }
        public FormAccessories(int elementid, bool locked)
        {
            InitializeComponent();
            ElementID = elementid;
            DataGridAccessories.AutoGenerateColumns = false;
            LoadAcc();
            if (locked)
            {
                BtnAddAccessory.Visible = false;
                ColumnDelete.Visible = false;
                
            }
        }

        private void LoadAcc()
        {
            DataGridAccessories.DataSource = Accessory.GetAccessories(ElementID);
        }

        private void BtnAddAccessory_Click(object sender, EventArgs e)
        {
            FormAddAccessory form = new FormAddAccessory(ElementID);
            form.ShowDialog();
            LoadAcc();
        }

        private void DataGridAccessories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex > -1)
            {
                foreach (DataGridViewRow item in this.DataGridAccessories.SelectedRows)
                {
                    string type = DataGridAccessories.Rows[item.Index].Cells["ColumnType"].Value.ToString();
                    int elementid = Convert.ToInt32(DataGridAccessories.Rows[item.Index].Cells["ColumnElementID"].Value);
                    Accessory.Delete(elementid, type);
                    DataGridAccessories.Rows.RemoveAt(item.Index);

                }
            }
        }

        private void FormAccessories_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
