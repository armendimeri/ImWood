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
    public partial class FormDrawers : Form
    {
        public FormDrawers()
        {
            InitializeComponent();

            LoadBrands();
            LoadDrawers();
        }

        private void LoadBrands()
        {
            DatGridBrands.DataSource = DrawerBrand.GetBrands();
        }

        private void LoadDrawers()
        {
            DataGridDrawers.DataSource = Drawer.GetAllDrawers();
        }

        private void BtnAddBrand_Click(object sender, EventArgs e)
        {
            FormAddBrand form = new FormAddBrand();
            form.ShowDialog();
            LoadBrands();
        }

        private void BtnAddDrawer_Click(object sender, EventArgs e)
        {
            FormAddDrawer form = new FormAddDrawer();
            form.ShowDialog();
            LoadDrawers();
        }
    }
}
