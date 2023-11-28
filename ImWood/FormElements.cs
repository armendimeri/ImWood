using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FormElements : Form
    {
        private int elementID { get; set; }
        public FormElements()
        {
            InitializeComponent();

            LoadElements();

            CmbBoxCategory.Enabled = false;
            CmbBoxDesign.Enabled = false;
            CmbBoxDesign.DataSource = Properties.Settings.Default.ElementDesigns;
            CmbBoxCategory.DataSource = Properties.Settings.Default.ElementCategories;

            CmbBoxElementDesign.DataSource = Properties.Settings.Default.ElementDesigns;
            CmbBoxElementCategory.DataSource = Properties.Settings.Default.ElementCategories;

        }

        private void LoadElements()
        {
            gridControlElements.DataSource = Element.GetElements();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddElement form = new FormAddElement();
            form.ShowDialog();
            LoadElements();
        }

        private void TxtBoxSearchElements_TextChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private bool locked { get; set; }       

        private void gridControlElements_DoubleClick(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gridControlElements.MainView).GetSelectedRows();
            DataRowView selectedrow = (DataRowView)(((GridView)gridControlElements.MainView).GetRow(selRows[0]));

            elementID = Convert.ToInt32(selectedrow["ID"]);            
            locked = Convert.ToBoolean(selectedrow["Locked"]);

            MemoryStream ms = new MemoryStream();
            ms = Element.GetImage(elementID);
            if (ms != null)
            {
                pictureBoxPhoto.Image = Image.FromStream(ms);
            }
            else pictureBoxPhoto.Image = null;
            if (!locked)
            {

                BtnAccessories.Enabled = true;
                BtnLock.Visible = true;
                BtnLock.Enabled = true;
            }
            else
            {
                BtnAccessories.Enabled = true;
                BtnLock.Visible = false;
            }
        }


        private void BtnDimensions_Click(object sender, EventArgs e)
        {
            FormDimensions dimensions = new FormDimensions(elementID, locked);
            dimensions.ShowDialog();
        }


        private void BtnLock_Click(object sender, EventArgs e)
        {
            Element.Lock(elementID);
            BtnLock.Enabled = false;
            BtnAccessories.Enabled = false;

            LoadElements();
        }

        string location;
        private void BtnChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                location = dialog.FileName;
                pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);
            }
            Element.UpdateImage(location, elementID);
        }

        private void FormElements_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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

        private void BtnAccessories_Click_1(object sender, EventArgs e)
        {
            FormAccessories acc = new FormAccessories(elementID, locked);
            acc.ShowDialog();
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
            bs.DataSource = gridControlElements.DataSource;
            bs.Filter = strElementSearch;
            
        }
        private void CmbBoxDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSearch();
        }

        private void CmbBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Element.UpdateElement(CmbBoxElementCategory.Text, CmbBoxElementDesign.Text, elementID);
            LoadElements();
        }

        private void ChkBoxAllowEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (!ChkBoxAllowEdit.Checked)
            {
                CmbBoxElementDesign.Enabled = false;
                CmbBoxElementCategory.Enabled = false;
                BtnSave.Enabled = false;
            }
            else
            {
                CmbBoxElementDesign.Enabled = true;
                CmbBoxElementCategory.Enabled = true;
                BtnSave.Enabled = true;
            }
        }

        private void BtnUnlock_Click(object sender, EventArgs e)
        {
            Element.UnLock(elementID);
            BtnLock.Enabled = false;
            BtnAccessories.Enabled = false;
            LoadElements();
        }

        private void FormElements_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Universal.accessoriesShowed)
            {
                Universal.projectAccessories.Dispose();
                Universal.accessoriesShowed = false;
            }

            if (Universal.konstruktShowed)
            {
                Universal.projectKonstruktDimensions.Dispose();
                Universal.konstruktShowed = false;
            }

            if (Universal.lesonitShowed)
            {
                Universal.projectLesonitDimensions.Dispose();
                Universal.lesonitShowed = false;
            }

            if (Universal.policaShowed)
            {
                Universal.projectPolicaDimensions.Dispose();
                Universal.policaShowed = false;
            }

            if (Universal.fiokaShowed)
            {
                Universal.projectFiokaDimensions.Dispose();
                Universal.fiokaShowed = false;
            }

            if (Universal.frontShowed)
            {
                Universal.projectFrontDimensions.Dispose();
                Universal.frontShowed = false;
            }
        }


    }
}
