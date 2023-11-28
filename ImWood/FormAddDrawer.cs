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
    public partial class FormAddDrawer : Form
    {
        public FormAddDrawer()
        {
            InitializeComponent();
            LoadBrands();
        }

        public void LoadBrands()
        {
            CmbBoxBrand.DisplayMember = "Name";
            CmbBoxBrand.ValueMember = "ID";
            CmbBoxBrand.DataSource = DrawerBrand.GetBrands();

            CmbBoxFormula.DataSource = Enum.GetValues(typeof(DrawerTypes));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawerTypes formula;
            Enum.TryParse<DrawerTypes>(CmbBoxFormula.SelectedValue.ToString(), out formula);
            Drawer drawer = new Drawer
            {
                Name = TxtBoxName.Text,
                KantA1 = TxtBoxKantA1.Text,
                KantA2 = TxtBoxKantA2.Text,
                KantB1 = TxtBoxKantB1.Text,
                KantB2 = TxtBoxKantB2.Text,
                a = double.Parse(TxtBoxA.Text),
                x = double.Parse(TxtBoxX.Text),
                y = double.Parse(TxtBoxY.Text),
                z = double.Parse(TxtBoxZ.Text),
                s = double.Parse(TxtBoxS.Text),
                Formula = formula,
                BrandID = (int)CmbBoxBrand.SelectedValue
            };

            drawer.Create();
            this.Close();
        }

        private void FormAddDrawer_Load(object sender, EventArgs e)
        {

        }
    }
}
