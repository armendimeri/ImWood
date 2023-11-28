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
    public partial class FormClients : Form
    {
        bool SelectClient { get; set; }
        public int ClientID { get; set; }
        public string ClientName { get; set; }

        public FormClients(bool selectClient)
        {
            InitializeComponent();
            SelectClient = selectClient;
            LoadClients();
        }

        private void LoadClients()
        {
            DataGridClients.DataSource = Client.GetClients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddClient form = new FormAddClient();
            form.ShowDialog();
            LoadClients();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = DataGridClients.DataSource;
                bs.Filter = "Name LIKE '%" + textBox2.Text + "%'";
            }
            catch { }
        }

        private void DataGridClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                ClientID = Convert.ToInt32(DataGridClients.Rows[e.RowIndex].Cells["ColumnID"].Value);
                ClientName = DataGridClients.Rows[e.RowIndex].Cells["ColumnName"].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FormClients_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
