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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            LoadKitchens();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            FormElements admin = new FormElements();
            admin.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormElements admin = new FormElements();
            admin.Show();

        }

        private void BtnNewProject_Click(object sender, EventArgs e)
        {
            FormProject form = new FormProject();
            form.Show();
        }

        private void LoadKitchens()
        {
            DataGridCurrentKitchens.DataSource = Kitchen.GetUnfinished();
        }

        private void DataGridCurrentKitchens_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = Convert.ToInt32(DataGridCurrentKitchens.Rows[e.RowIndex].Cells["ColumnKitchenID"].Value);
                FormProject form = new FormProject(id);
                form.Show();
            }
        }

        private void BtnOldProjects_Click(object sender, EventArgs e)
        {
            FormArchivedProjects form = new FormArchivedProjects();
            form.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadKitchens();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                LoadKitchens();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.Show();
        }

        private void BtnDrawers_Click(object sender, EventArgs e)
        {
            FormDrawers form = new FormDrawers();
            form.Show();
        }
    }
}
