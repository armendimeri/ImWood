using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImWood
{
    public partial class FormProject : Form
    {
        int KitchenID { get; set; }
        int ClientID { get; set; }
        bool Finished { get; set; }
        public FormProject()
        {
            InitializeComponent();
        }

        public FormProject(int _kitchenid)
        {
            InitializeComponent();
            KitchenID = _kitchenid;
            LoadKitchen();
        }
        Kitchen kit;
        private void LoadKitchen()
        {
            kit = new Kitchen(KitchenID);
            if(kit.Finished)
            {
                TxtBoxComment.Enabled = false;
                TxtBoxFrontMaterial.Enabled = false;
                TxtBoxKonstruktMaterial.Enabled = false;
                DatePickerExpireDate.Enabled = false;
                BtnSave.Visible = false;
                BtnSelectClient.Visible = false;
                Finished = true;
            }

            LblClient.Text = kit.ClientName;
            TxtBoxComment.Text = kit.Comments;
            TxtBoxFrontMaterial.Text = kit.FrontMaterial;
            TxtBoxKonstruktMaterial.Text = kit.KonstMaterial;
            TxtBoxFioka.Text = kit.FiokaMaterial;
            TxtBoxLesonit.Text = kit.LesonitMaterial;
            TxtBoxPolica.Text = kit.PolicaMaterial;
            
            BtnAccessories.Enabled = true;
            BtnElements.Enabled = true;
            ClientID = kit.ClientID;
            TxtBoxName.Text = kit.Name;
            DatePickerExpireDate.Value = kit.DateExpire;
            this.Text = "Projekti: " + LblClient.Text;
        }



        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (KitchenID == 0)
            {
                Kitchen kitc = new Kitchen(TxtBoxName.Text, ClientID, DatePickerExpireDate.Value, TxtBoxComment.Text, TxtBoxFrontMaterial.Text, TxtBoxKonstruktMaterial.Text);
                kitc.AddDB();
                if (kitc.ID != 0)
                {
                    KitchenID = kitc.ID;
                    BtnAccessories.Enabled = true;
                    BtnElements.Enabled = true;
                }
            }
            else
            {
                Kitchen kitch = new Kitchen(KitchenID);
                kitch.FrontMaterial = TxtBoxFrontMaterial.Text;
                kitch.KonstMaterial = TxtBoxKonstruktMaterial.Text;              
                kitch.DateExpire = DatePickerExpireDate.Value;
                kitch.Comments = TxtBoxComment.Text;
                kitch.ClientID = ClientID;
                kitch.Name = TxtBoxName.Text;
                kitch.PolicaMaterial = TxtBoxPolica.Text;
                kitch.LesonitMaterial = TxtBoxLesonit.Text;
                kitch.FiokaMaterial = TxtBoxFioka.Text;
                        
                kitch.Save();
            }
        }

        private void BtnSelectClient_Click(object sender, EventArgs e)
        {
            FormClients form = new FormClients(true);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                ClientID = form.ClientID;
                LblClient.Text = form.ClientName;
            }
        }

        private void BtnElements_Click(object sender, EventArgs e)
        {
            FormKitchenElements form = new FormKitchenElements(KitchenID, Finished);
            form.ShowDialog();
        }

       
        private void BtnAccessories_Click(object sender, EventArgs e)
        {
            if (!Universal.accessoriesShowed)
            {
                Universal.projectAccessories = new FormKitchenAccessories(KitchenID, Finished, LblClient.Text, DatePickerExpireDate.Value, kit);
                Universal.projectAccessories.Show();
                Universal.accessoriesShowed = true;
                BtnAccessories.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.projectAccessories.Dispose();
                Universal.accessoriesShowed = false;
                BtnAccessories.BackColor = SystemColors.Control;                
            }
        }

        private void BtnFinishProject_Click(object sender, EventArgs e)
        {
            FormAsk ask = new FormAsk("Me këtë projekti do të mbaroet dhe ndryshime të mëtutejshme nuk do të lejoen.");
            ask.ShowDialog();
            if(ask.DialogResult == DialogResult.OK)
            {
                Kitchen.Finish(KitchenID);
                TxtBoxComment.Enabled = false;
                TxtBoxFrontMaterial.Enabled = false;
                TxtBoxKonstruktMaterial.Enabled = false;
                DatePickerExpireDate.Enabled = false;
                BtnSave.Visible = false;
                BtnSelectClient.Visible = false;
                Finished = true;
            }

        }

        private void FormProject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        

        private void FormProject_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Universal.accessoriesShowed)
            {
                Universal.projectAccessories.Dispose();
                Universal.accessoriesShowed = false;
            }

            if (Universal.konstruktShowed)
            {
                Universal.projectKonstruktDimensions.Dispose();
                Universal.konstruktShowed = false;
            }

            if (Universal.lesonitShowed)
            {
                Universal.projectLesonitDimensions.Dispose();
                Universal.lesonitShowed = false;
            }

            if (Universal.policaShowed)
            {
                Universal.projectPolicaDimensions.Dispose();
                Universal.policaShowed = false;
            }

            if (Universal.fiokaShowed)
            {
                Universal.projectFiokaDimensions.Dispose();
                Universal.fiokaShowed = false;
            }

            if (Universal.frontShowed)
            {
                Universal.projectFrontDimensions.Dispose();
                Universal.frontShowed = false;
            }
        }

        private void BtnFront_Click(object sender, EventArgs e)
        {
            if (!Universal.frontShowed)
            {
                Universal.projectFrontDimensions = new FormFrontDimensions(KitchenID, "Front", DatePickerExpireDate.Value, LblClient.Text, TxtBoxFrontMaterial.Text);
                Universal.projectFrontDimensions.Show();
                Universal.frontShowed = true;
                BtnFront.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.frontShowed = false;
                Universal.projectFrontDimensions.Dispose();
                BtnFront.BackColor = SystemColors.Control;
            }
        }

        private void BtnKonstrukt_Click(object sender, EventArgs e)
        {
            if (!Universal.konstruktShowed)
            {
                Universal.projectKonstruktDimensions = new FormKonstruktDimensions(KitchenID, "Konstrukti", DatePickerExpireDate.Value, LblClient.Text, TxtBoxKonstruktMaterial.Text);
                Universal.projectKonstruktDimensions.Show();
                Universal.konstruktShowed = true;
                BtnKonstrukt.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.projectKonstruktDimensions.Dispose();
                Universal.konstruktShowed = false;
                BtnKonstrukt.BackColor = SystemColors.Control;
            }
        }

        private void BtnPolica_Click(object sender, EventArgs e)
        {
            if(!Universal.policaShowed)
            {
                Universal.projectPolicaDimensions = new FormKonstruktDimensions(KitchenID, "Polica", DatePickerExpireDate.Value, LblClient.Text, TxtBoxPolica.Text);
                Universal.projectPolicaDimensions.Show();
                Universal.policaShowed = true;
                BtnPolica.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.projectPolicaDimensions.Dispose();
                Universal.policaShowed = false;
                BtnPolica.BackColor = SystemColors.Control;
            }
        }

        private void BtnFioka_Click(object sender, EventArgs e)
        {
            if (!Universal.fiokaShowed)
            {
                Universal.projectFiokaDimensions = new FormKonstruktDimensions(KitchenID, "Fioka", DatePickerExpireDate.Value, LblClient.Text, TxtBoxFioka.Text);
                Universal.projectFiokaDimensions.Show();
                Universal.fiokaShowed = true;
                BtnFioka.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.projectFiokaDimensions.Dispose();
                Universal.fiokaShowed = false;
                BtnFioka.BackColor = SystemColors.Control;
            }
        }

        private void BtnLesonit_Click(object sender, EventArgs e)
        {
            if (!Universal.lesonitShowed)
            {
                Universal.projectLesonitDimensions = new FormLesonitDimensions(KitchenID, DatePickerExpireDate.Value, TxtBoxLesonit.Text, LblClient.Text, "Lesonit");
                Universal.lesonitShowed = true;
                Universal.projectLesonitDimensions.Show();
                BtnLesonit.BackColor = SystemColors.ControlDark;
            }
            else
            {
                Universal.projectLesonitDimensions.Dispose();
                Universal.lesonitShowed = false;
                BtnLesonit.BackColor = SystemColors.Control;
            }
        }

        private void BtnProjectPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

        }
    }
}
