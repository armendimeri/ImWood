namespace ImWood
{
    partial class FormDrawers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDrawers));
            this.BtnAddBrand = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBoxSearchBrands = new WindowsFormsAero.TextBox();
            this.DatGridBrands = new System.Windows.Forms.DataGridView();
            this.ColumnBrandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtBoxSearchDrawers = new WindowsFormsAero.TextBox();
            this.BtnAddDrawer = new System.Windows.Forms.Button();
            this.DataGridDrawers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatGridBrands)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDrawers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddBrand
            // 
            this.BtnAddBrand.Location = new System.Drawing.Point(7, 31);
            this.BtnAddBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnAddBrand.Name = "BtnAddBrand";
            this.BtnAddBrand.Size = new System.Drawing.Size(260, 37);
            this.BtnAddBrand.TabIndex = 0;
            this.BtnAddBrand.Text = "Shto Brend";
            this.BtnAddBrand.UseVisualStyleBackColor = true;
            this.BtnAddBrand.Click += new System.EventHandler(this.BtnAddBrand_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.TxtBoxSearchBrands);
            this.groupBox1.Controls.Add(this.BtnAddBrand);
            this.groupBox1.Controls.Add(this.DatGridBrands);
            this.groupBox1.Location = new System.Drawing.Point(14, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(279, 750);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brendet";
            // 
            // TxtBoxSearchBrands
            // 
            this.TxtBoxSearchBrands.CueBannerText = "Kërko...";
            this.TxtBoxSearchBrands.Location = new System.Drawing.Point(7, 75);
            this.TxtBoxSearchBrands.Name = "TxtBoxSearchBrands";
            this.TxtBoxSearchBrands.ShowCueFocused = true;
            this.TxtBoxSearchBrands.Size = new System.Drawing.Size(260, 30);
            this.TxtBoxSearchBrands.TabIndex = 1;
            // 
            // DatGridBrands
            // 
            this.DatGridBrands.AllowUserToAddRows = false;
            this.DatGridBrands.AllowUserToDeleteRows = false;
            this.DatGridBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatGridBrands.BackgroundColor = System.Drawing.Color.White;
            this.DatGridBrands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatGridBrands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnBrandID,
            this.ColumnBrandName});
            this.DatGridBrands.Location = new System.Drawing.Point(7, 112);
            this.DatGridBrands.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DatGridBrands.Name = "DatGridBrands";
            this.DatGridBrands.ReadOnly = true;
            this.DatGridBrands.RowHeadersVisible = false;
            this.DatGridBrands.RowTemplate.Height = 24;
            this.DatGridBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatGridBrands.Size = new System.Drawing.Size(260, 630);
            this.DatGridBrands.TabIndex = 0;
            // 
            // ColumnBrandID
            // 
            this.ColumnBrandID.DataPropertyName = "ID";
            this.ColumnBrandID.HeaderText = "ID";
            this.ColumnBrandID.Name = "ColumnBrandID";
            this.ColumnBrandID.ReadOnly = true;
            this.ColumnBrandID.Visible = false;
            // 
            // ColumnBrandName
            // 
            this.ColumnBrandName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBrandName.DataPropertyName = "Name";
            this.ColumnBrandName.HeaderText = "Name";
            this.ColumnBrandName.Name = "ColumnBrandName";
            this.ColumnBrandName.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TxtBoxSearchDrawers);
            this.groupBox2.Controls.Add(this.BtnAddDrawer);
            this.groupBox2.Controls.Add(this.DataGridDrawers);
            this.groupBox2.Location = new System.Drawing.Point(299, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 751);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modelet e Fiokave";
            // 
            // TxtBoxSearchDrawers
            // 
            this.TxtBoxSearchDrawers.CueBannerText = "Kërko...";
            this.TxtBoxSearchDrawers.Location = new System.Drawing.Point(15, 34);
            this.TxtBoxSearchDrawers.Name = "TxtBoxSearchDrawers";
            this.TxtBoxSearchDrawers.ShowCueFocused = true;
            this.TxtBoxSearchDrawers.Size = new System.Drawing.Size(260, 30);
            this.TxtBoxSearchDrawers.TabIndex = 2;
            // 
            // BtnAddDrawer
            // 
            this.BtnAddDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddDrawer.Location = new System.Drawing.Point(541, 29);
            this.BtnAddDrawer.Name = "BtnAddDrawer";
            this.BtnAddDrawer.Size = new System.Drawing.Size(205, 39);
            this.BtnAddDrawer.TabIndex = 1;
            this.BtnAddDrawer.Text = "Shto Model";
            this.BtnAddDrawer.UseVisualStyleBackColor = true;
            this.BtnAddDrawer.Click += new System.EventHandler(this.BtnAddDrawer_Click);
            // 
            // DataGridDrawers
            // 
            this.DataGridDrawers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridDrawers.Location = new System.Drawing.Point(15, 75);
            this.DataGridDrawers.MainView = this.gridView1;
            this.DataGridDrawers.Name = "DataGridDrawers";
            this.DataGridDrawers.Size = new System.Drawing.Size(731, 667);
            this.DataGridDrawers.TabIndex = 0;
            this.DataGridDrawers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.DataGridDrawers;
            this.gridView1.Name = "gridView1";
            // 
            // FormDrawers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 786);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDrawers";
            this.Text = "Fiokat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatGridBrands)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDrawers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddBrand;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DatGridBrands;
        private WindowsFormsAero.TextBox TxtBoxSearchBrands;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl DataGridDrawers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBrandName;
        private WindowsFormsAero.TextBox TxtBoxSearchDrawers;
        private System.Windows.Forms.Button BtnAddDrawer;
    }
}