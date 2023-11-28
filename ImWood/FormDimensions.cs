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
    public partial class FormDimensions : Form
    {
        private int ElementID { get; set; }
        public FormDimensions(int elementID, bool locked)
        {
            InitializeComponent();
            ElementID = elementID;
            LoadDimensions();
            if(locked)
            {
                BtnAddDimension.Visible = false;
                ColumnDelete.Visible = false;
            }
        }

        private void FormDimensions_Load(object sender, EventArgs e)
        {

        }

        private void LoadDimensions()
        {
            DataGridDimensions.AutoGenerateColumns = false;
            //DataGridDimensions.DataSource = Dimension.GetDimensions(ElementID);
        }

        private void BtnAddDimension_Click(object sender, EventArgs e)
        {
            FormAddDimensions form = new FormAddDimensions(ElementID, 0, "");
            form.ShowDialog();
            LoadDimensions();
        }

        private void DataGridDimensions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                foreach (DataGridViewRow item in this.DataGridDimensions.SelectedRows)
                {
                    int id = Convert.ToInt32(DataGridDimensions.Rows[item.Index].Cells["ColumnID"].Value);
                    Dimension.Delete(id);
                    DataGridDimensions.Rows.RemoveAt(item.Index);                
                }
            }
        }

        private void FormDimensions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


    }
}
