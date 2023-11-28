namespace ImWood
{
    partial class FormDrawerCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrawerCalculator));
            this.DataGridDrawers = new System.Windows.Forms.DataGridView();
            this.ColumnDrawerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDrawerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBoxSearch = new WindowsFormsAero.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataGridSelectedDrawers = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LblDrawerModelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxQTY = new System.Windows.Forms.TextBox();
            this.TxtBoxDepth = new System.Windows.Forms.TextBox();
            this.TxtBoxWidthW = new System.Windows.Forms.TextBox();
            this.BtnAddDrawer = new System.Windows.Forms.Button();
            this.ChkBoxInbox = new System.Windows.Forms.CheckBox();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKitchenDrawerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDimensionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDrawers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSelectedDrawers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridDrawers
            // 
            this.DataGridDrawers.AllowUserToAddRows = false;
            this.DataGridDrawers.AllowUserToDeleteRows = false;
            this.DataGridDrawers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridDrawers.BackgroundColor = System.Drawing.Color.White;
            this.DataGridDrawers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDrawers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDrawerID,
            this.ColumnDrawerName});
            this.DataGridDrawers.Location = new System.Drawing.Point(7, 69);
            this.DataGridDrawers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridDrawers.Name = "DataGridDrawers";
            this.DataGridDrawers.ReadOnly = true;
            this.DataGridDrawers.RowHeadersVisible = false;
            this.DataGridDrawers.RowTemplate.Height = 24;
            this.DataGridDrawers.Size = new System.Drawing.Size(274, 731);
            this.DataGridDrawers.TabIndex = 1;
            this.DataGridDrawers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDrawers_CellClick);
            // 
            // ColumnDrawerID
            // 
            this.ColumnDrawerID.DataPropertyName = "ID";
            this.ColumnDrawerID.HeaderText = "ID";
            this.ColumnDrawerID.Name = "ColumnDrawerID";
            this.ColumnDrawerID.ReadOnly = true;
            this.ColumnDrawerID.Visible = false;
            // 
            // ColumnDrawerName
            // 
            this.ColumnDrawerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDrawerName.DataPropertyName = "Name";
            this.ColumnDrawerName.HeaderText = "Name";
            this.ColumnDrawerName.Name = "ColumnDrawerName";
            this.ColumnDrawerName.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.TxtBoxSearch);
            this.groupBox1.Controls.Add(this.DataGridDrawers);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 808);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modeli i Fiokes";
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.CueBannerText = "Kërko...";
            this.TxtBoxSearch.Location = new System.Drawing.Point(8, 30);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.ShowCueFocused = true;
            this.TxtBoxSearch.Size = new System.Drawing.Size(272, 31);
            this.TxtBoxSearch.TabIndex = 0;
            this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.DataGridSelectedDrawers);
            this.groupBox2.Location = new System.Drawing.Point(768, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 808);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiokat E Zgjedhura";
            // 
            // DataGridSelectedDrawers
            // 
            this.DataGridSelectedDrawers.AllowUserToAddRows = false;
            this.DataGridSelectedDrawers.AllowUserToDeleteRows = false;
            this.DataGridSelectedDrawers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridSelectedDrawers.BackgroundColor = System.Drawing.Color.White;
            this.DataGridSelectedDrawers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSelectedDrawers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnKitchenDrawerID,
            this.ColumnDimensionID,
            this.ColumnQuantity,
            this.ColumnInbox,
            this.ColumnDelete});
            this.DataGridSelectedDrawers.Location = new System.Drawing.Point(6, 36);
            this.DataGridSelectedDrawers.Name = "DataGridSelectedDrawers";
            this.DataGridSelectedDrawers.ReadOnly = true;
            this.DataGridSelectedDrawers.RowHeadersVisible = false;
            this.DataGridSelectedDrawers.RowTemplate.Height = 24;
            this.DataGridSelectedDrawers.Size = new System.Drawing.Size(504, 764);
            this.DataGridSelectedDrawers.TabIndex = 0;
            this.DataGridSelectedDrawers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSelectedDrawers_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChkBoxInbox);
            this.groupBox3.Controls.Add(this.BtnAddDrawer);
            this.groupBox3.Controls.Add(this.LblDrawerModelName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TxtBoxQTY);
            this.groupBox3.Controls.Add(this.TxtBoxDepth);
            this.groupBox3.Controls.Add(this.TxtBoxWidthW);
            this.groupBox3.Location = new System.Drawing.Point(306, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 331);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Të dhënat e elementit";
            // 
            // LblDrawerModelName
            // 
            this.LblDrawerModelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDrawerModelName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDrawerModelName.ForeColor = System.Drawing.Color.DarkRed;
            this.LblDrawerModelName.Location = new System.Drawing.Point(6, 36);
            this.LblDrawerModelName.Name = "LblDrawerModelName";
            this.LblDrawerModelName.Size = new System.Drawing.Size(444, 54);
            this.LblDrawerModelName.TabIndex = 2;
            this.LblDrawerModelName.Text = "Selekto modelin";
            this.LblDrawerModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sasia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thellësia e Fiokës D:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gjërësia e Elementit W:";
            // 
            // TxtBoxQTY
            // 
            this.TxtBoxQTY.Location = new System.Drawing.Point(254, 182);
            this.TxtBoxQTY.Name = "TxtBoxQTY";
            this.TxtBoxQTY.Size = new System.Drawing.Size(100, 31);
            this.TxtBoxQTY.TabIndex = 2;
            // 
            // TxtBoxDepth
            // 
            this.TxtBoxDepth.Location = new System.Drawing.Point(254, 145);
            this.TxtBoxDepth.Name = "TxtBoxDepth";
            this.TxtBoxDepth.Size = new System.Drawing.Size(100, 31);
            this.TxtBoxDepth.TabIndex = 1;
            // 
            // TxtBoxWidthW
            // 
            this.TxtBoxWidthW.Location = new System.Drawing.Point(254, 106);
            this.TxtBoxWidthW.Name = "TxtBoxWidthW";
            this.TxtBoxWidthW.Size = new System.Drawing.Size(100, 31);
            this.TxtBoxWidthW.TabIndex = 0;
            // 
            // BtnAddDrawer
            // 
            this.BtnAddDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddDrawer.Location = new System.Drawing.Point(6, 274);
            this.BtnAddDrawer.Name = "BtnAddDrawer";
            this.BtnAddDrawer.Size = new System.Drawing.Size(445, 51);
            this.BtnAddDrawer.TabIndex = 10;
            this.BtnAddDrawer.Text = "ADD";
            this.BtnAddDrawer.UseVisualStyleBackColor = true;
            this.BtnAddDrawer.Click += new System.EventHandler(this.BtnAddDrawer_Click);
            // 
            // ChkBoxInbox
            // 
            this.ChkBoxInbox.AutoSize = true;
            this.ChkBoxInbox.Location = new System.Drawing.Point(231, 228);
            this.ChkBoxInbox.Name = "ChkBoxInbox";
            this.ChkBoxInbox.Size = new System.Drawing.Size(120, 29);
            this.ChkBoxInbox.TabIndex = 4;
            this.ChkBoxInbox.Text = "Inbox Fiok";
            this.ChkBoxInbox.UseVisualStyleBackColor = true;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnKitchenDrawerID
            // 
            this.ColumnKitchenDrawerID.DataPropertyName = "DrawerID";
            this.ColumnKitchenDrawerID.HeaderText = "ID";
            this.ColumnKitchenDrawerID.Name = "ColumnKitchenDrawerID";
            this.ColumnKitchenDrawerID.ReadOnly = true;
            this.ColumnKitchenDrawerID.Visible = false;
            // 
            // ColumnDimensionID
            // 
            this.ColumnDimensionID.DataPropertyName = "DimensionID";
            this.ColumnDimensionID.HeaderText = "DimensionID";
            this.ColumnDimensionID.Name = "ColumnDimensionID";
            this.ColumnDimensionID.ReadOnly = true;
            this.ColumnDimensionID.Visible = false;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.HeaderText = "Quantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            this.ColumnQuantity.Width = 90;
            // 
            // ColumnInbox
            // 
            this.ColumnInbox.DataPropertyName = "Inbox";
            this.ColumnInbox.HeaderText = "Inbox";
            this.ColumnInbox.Name = "ColumnInbox";
            this.ColumnInbox.ReadOnly = true;
            this.ColumnInbox.Width = 70;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Delete";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "Delete";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 80;
            // 
            // FormDrawerCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 848);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDrawerCalculator";
            this.Text = "Drawer Calculator";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDrawers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSelectedDrawers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridDrawers;
        private System.Windows.Forms.GroupBox groupBox1;
        private WindowsFormsAero.TextBox TxtBoxSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDrawerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDrawerName;
        private System.Windows.Forms.DataGridView DataGridSelectedDrawers;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label LblDrawerModelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxQTY;
        private System.Windows.Forms.TextBox TxtBoxDepth;
        private System.Windows.Forms.TextBox TxtBoxWidthW;
        private System.Windows.Forms.Button BtnAddDrawer;
        private System.Windows.Forms.CheckBox ChkBoxInbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKitchenDrawerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDimensionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnInbox;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}