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
    public partial class FormAddClient : Form
    {
        public FormAddClient()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Client clt = new Client(TxtBoxName.Text, TxtBoxPhone.Text, TxtBoxTown.Text);
            clt.SaveDB();
        }
    }
}
