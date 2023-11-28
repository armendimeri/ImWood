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
    public partial class FormAsk : Form
    {
        public FormAsk(string text)
        {
            InitializeComponent();
            LblMessage.Text = text;
        }
    }
}
