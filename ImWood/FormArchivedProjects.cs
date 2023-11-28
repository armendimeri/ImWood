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
    public partial class FormArchivedProjects : Form
    {
        public FormArchivedProjects()
        {
            InitializeComponent();
            DataGridProjects.DataSource = Kitchen.GetFinished();
        }

        private void DataGridProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = Convert.ToInt32(DataGridProjects.Rows[e.RowIndex].Cells["ColumnKitchenID"].Value);
                FormProject form = new FormProject(id);
                form.Show();
            }
        }

        private void FormArchivedProjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
