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
    public partial class FormAddElement : Form
    {
        private Element element { get; set; }
        private string location { get; set; }
        public FormAddElement()
        {
            InitializeComponent();

            CmbBoxDesign.DataSource = Properties.Settings.Default.ElementDesigns;
            CmbBoxCategory.DataSource = Properties.Settings.Default.ElementCategories;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                location = dialog.FileName;
                pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);                
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            element = new Element(TxtBoxName.Text, pictureBoxPhoto.Image, CmbBoxCategory.Text, CmbBoxDesign.Text);
            if (location != null)
            {
                element.AddNew(location);
            }
            else element.AddNew();
            if (element.ID != 0)
            {
                BtnAccessories.Enabled = true;
                BtnDimensions.Enabled = true;
                BtnSave.Enabled = false;
            }
        }

        private void BtnDimensions_Click(object sender, EventArgs e)
        {
            FormDimensions form = new FormDimensions(element.ID, false);
            form.ShowDialog();
        }

        private void BtnAccessories_Click(object sender, EventArgs e)
        {
            FormAccessories form = new FormAccessories(element.ID, false);
            form.ShowDialog();
        }

        private void CmbBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAddElement_Load(object sender, EventArgs e)
        {

        }
    }
}
