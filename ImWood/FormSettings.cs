using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImWood
{
   

    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();


            loaditems();
            DataGridViewAccessoryTypes.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
            DataGridViewAccessoryTypes.Columns[1].DisplayIndex = 0;
     
            
        }


        private void loaditems()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Tipi");
            foreach(String acc in Properties.Settings.Default.AccTypes)
            {
                table.Rows.Add(acc);                   
            }
            DataGridViewAccessoryTypes.DataSource = table;      
        }


        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AccTypes.Add(TxtBoxName.Text);
            Properties.Settings.Default.Save();
            loaditems();
            TxtBoxName.Text = "";
            TxtBoxName.Focus();
        }


        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = DataGridViewAccessoryTypes.DataSource;
            bs.Filter = "Tipi LIKE '%" + TxtBoxSearch.Text + "%'";

        }

        private void DataGridViewAccessoryTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Properties.Settings.Default.AccTypes.RemoveAt(e.RowIndex);
                loaditems();
            }
        }

        private void FormSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }



}
