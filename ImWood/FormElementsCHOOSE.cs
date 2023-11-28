using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImWood
{
    public partial class FormElementsCHOOSE : Form
    {
        private int elementID { get; set; }
        int KitchenID { get; set; }
        public FormElementsCHOOSE(int kitchenid)
        {
            InitializeComponent();
            KitchenID = kitchenid;
            DataGridViewElements.AutoGenerateColumns = false;
            DataGridViewElements.DataSource = Element.GetElementsLocked();
            CmbBoxDesign.DataSource = Properties.Settings.Default.ElementDesigns;
            CmbBoxCategory.DataSource = Properties.Settings.Default.ElementCategories;
        }


        private void TxtBoxSearchElements_TextChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void DataGridViewElements_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadElement();
        }

        private void LoadElement()
        {
            elementID = Convert.ToInt32(DataGridViewElements.CurrentRow.Cells["ColumnElementID"].Value);
            MemoryStream ms = new MemoryStream();
            ms = Element.GetImage(elementID);
            if (ms != null)
            {
                pictureBoxPhoto.Image = Image.FromStream(ms);
            }
            BtnSave.Enabled = true;
            TxtBoxQuantity.Focus();
            TxtBoxQuantity.SelectAll();
        }

        private void DataGridViewElements_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadElement();                        
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Element.AddToKitchen(elementID, KitchenID, int.Parse(TxtBoxQuantity.Text));
            BtnSave.Enabled = false;
        }

        private void FormElementsCHOOSE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CmbBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void CmbBoxDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void ChkBoxActiveFilters_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkBoxActiveFilters.Checked)
            {
                CmbBoxDesign.Enabled = false;
                CmbBoxCategory.Enabled = false;
            }
            else
            {
                CmbBoxDesign.Enabled = true;
                CmbBoxCategory.Enabled = true;
            }
            UpdateSearch();
        }

        private void UpdateSearch()
        {
            string strElementSearch = "";
            if (ChkBoxActiveFilters.Checked)
            {
                strElementSearch = "Name LIKE '%" + TxtBoxSearchElements.Text + @"%' 
                AND Category LIKE '%" + CmbBoxCategory.Text + "%' AND Design LIKE '%" + CmbBoxDesign.Text + "%'";
            }
            else
            {
                strElementSearch = "Name LIKE '%" + TxtBoxSearchElements.Text + @"%'";
            }
            BindingSource bs = new BindingSource();
            bs.DataSource = DataGridViewElements.DataSource;
            bs.Filter = strElementSearch;
            ColumnElementID.Visible = false;
        }

        private void BtnFront_Click(object sender, EventArgs e)
        {
            if (!Universal.frontShowed)
            {
                Universal.projectFrontDimensions = new FormFrontDimensions(elementID, "Front");
                Universal.projectFrontDimensions.Show();
                Universal.frontShowed = true;
                BtnFront.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.frontShowed = false;
                Universal.projectFrontDimensions.Dispose();
                BtnFront.BackColor = SystemColors.Control;
            }
        }

        private void BtnKonstrukt_Click(object sender, EventArgs e)
        {
            if (Universal.konstruktShowed)
            {
                Universal.projectKonstruktDimensions.Dispose();
                Universal.konstruktShowed = false;
                BtnKonstrukt.BackColor = SystemColors.Control;
            }
            else
            {
                Universal.projectKonstruktDimensions = new FormKonstruktDimensions(elementID, "Konstrukti");
                Universal.projectKonstruktDimensions.Show();
                Universal.konstruktShowed = true;
                BtnKonstrukt.BackColor = SystemColors.ControlDark;
            }
        }

        private void BtnPolica_Click(object sender, EventArgs e)
        {
            if (!Universal.policaShowed)
            {
                Universal.projectPolicaDimensions = new FormKonstruktDimensions(elementID, "Polica");
                Universal.projectPolicaDimensions.Show();
                Universal.policaShowed = true;
                BtnPolica.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.projectPolicaDimensions.Dispose();
                Universal.policaShowed = false;
                BtnPolica.BackColor = SystemColors.Control;
            }
        }

        private void BtnFioka_Click(object sender, EventArgs e)
        {
            if (!Universal.fiokaShowed)
            {
                Universal.projectFiokaDimensions = new FormKonstruktDimensions(elementID, "Fioka");
                Universal.projectFiokaDimensions.Show();
                Universal.fiokaShowed = true;
                BtnFioka.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.projectFiokaDimensions.Dispose();
                Universal.fiokaShowed = false;
                BtnFioka.BackColor = SystemColors.Control;
            }
        }

        private void BtnLesonit_Click(object sender, EventArgs e)
        {
            if (!Universal.lesonitShowed)
            {
                Universal.projectLesonitDimensions = new FormLesonitDimensions(elementID, "Lesonit");
                Universal.lesonitShowed = true;
                Universal.projectLesonitDimensions.Show();
                BtnLesonit.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.projectLesonitDimensions.Dispose();
                Universal.lesonitShowed = false;
                BtnLesonit.BackColor = SystemColors.Control;
            }
        }

        private void BtnAccessories_Click(object sender, EventArgs e)
        {
            FormAccessories acc = new FormAccessories(elementID, true);
            acc.ShowDialog();
        }
    }
}
