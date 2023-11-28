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
    public partial class FormAddBrand : Form
    {
        public FormAddBrand()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtBoxName.Text.Length > 1)
            {
                DrawerBrand brand = new DrawerBrand { Name = TxtBoxName.Text };
                brand.CreateBrand();
                this.Close();
            }
            else
            {
                MessageBox.Show("Brand name too short");
            }
        }
    }
}
