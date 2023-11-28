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
    public partial class FormAddDimensions : Form
    {
        int ElementID { get; set; }
        int KitchenID { get; set; }
        public FormAddDimensions(int elementid, int kitchenid, string type)
        {
            InitializeComponent();
            ElementID = elementid;
            KitchenID = kitchenid;
            if (type.Length > 2)
            {
                CmbBoxType.Visible = false;
            }
            CmbBoxType.Text = type;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (CmbBoxType.Text.Length > 1)
            {
                if (ElementID != 0)
                {
                    Dimension dim = new Dimension(Convert.ToDouble(TxtBoxWidth.Text), Convert.ToDouble(TxtBoxHeight.Text), int.Parse(TxtBoxQuantity.Text),
                        TxtBoxKant.Text, TxtBoxKant2.Text, CmbBoxType.Text, ElementID, 0, "", TxtBoxFunction.Text);
                    dim.AddToDB();
                }
                else
                {
                    Dimension dim = new Dimension(Convert.ToDouble(TxtBoxWidth.Text), Convert.ToDouble(TxtBoxHeight.Text), int.Parse(TxtBoxQuantity.Text),
                        TxtBoxKant.Text, TxtBoxKant2.Text, CmbBoxType.Text, 0, KitchenID, "", TxtBoxFunction.Text);
                    dim.AddToDBMANUAL();
                }
                
                TxtBoxFunction.Text = "";
                TxtBoxHeight.Text = "";
                TxtBoxKant.Text = "";
                TxtBoxQuantity.Text = "";
                TxtBoxWidth.Text = "";
                TxtBoxKant2.Text = "";
            }
        }

        private void CmbBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbBoxType.Text == "Front")
            {
                TxtBoxKant.Text = "";
                TxtBoxKant2.Text = "";
                TxtBoxKant.Enabled = false;
                TxtBoxKant2.Enabled = false;
                TxtBoxFunction.Enabled = true;
                LblFunction.Text = "Funksioni:";
            }
            else if (CmbBoxType.Text == "Lesonit")
            {
                TxtBoxKant.Text = "";
                TxtBoxKant2.Text = "";
                TxtBoxKant.Enabled = false;
                TxtBoxKant2.Enabled = false;
                TxtBoxFunction.Enabled = false;
                TxtBoxFunction.Text = "";
                
            }
            else
            {
                TxtBoxKant.Enabled = true;
                TxtBoxKant2.Enabled = true;
                TxtBoxFunction.Text = "";
                LblFunction.Text = "Pozicioni:";
                
            }
        }

        private void FormAddDimensions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
      
    }
}
