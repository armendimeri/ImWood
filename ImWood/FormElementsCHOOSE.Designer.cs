namespace ImWood
{
    partial class FormElementsCHOOSE
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormElementsCHOOSE));
            this.DataGridViewElements = new System.Windows.Forms.DataGridView();
            this.TxtBoxSearchElements = new WindowsFormsAero.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxQuantity = new System.Windows.Forms.TextBox();
            this.ChkBoxActiveFilters = new System.Windows.Forms.CheckBox();
            this.CmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.CmbBoxDesign = new System.Windows.Forms.ComboBox();
            this.ColumnElementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnElementName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAccessories = new System.Windows.Forms.Button();
            this.BtnLesonit = new System.Windows.Forms.Button();
            this.BtnFioka = new System.Windows.Forms.Button();
            this.BtnPolica = new System.Windows.Forms.Button();
            this.BtnFront = new System.Windows.Forms.Button();
            this.BtnKonstrukt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewElements
            // 
            this.DataGridViewElements.AllowUserToAddRows = false;
            this.DataGridViewElements.AllowUserToDeleteRows = false;
            this.DataGridViewElements.AllowUserToResizeColumns = false;
            this.DataGridViewElements.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridViewElements.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DataGridViewElements.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewElements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnElementID,
            this.ColumnElementName,
            this.ColumnCategory,
            this.ColumnDesign});
            this.DataGridViewElements.Location = new System.Drawing.Point(12, 48);
            this.DataGridViewElements.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridViewElements.Name = "DataGridViewElements";
            this.DataGridViewElements.ReadOnly = true;
            this.DataGridViewElements.RowHeadersVisible = false;
            this.DataGridViewElements.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridViewElements.RowTemplate.Height = 30;
            this.DataGridViewElements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewElements.Size = new System.Drawing.Size(359, 525);
            this.DataGridViewElements.TabIndex = 0;
            this.DataGridViewElements.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewElements_CellClick);
            this.DataGridViewElements.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridViewElements_KeyDown);
            // 
            // TxtBoxSearchElements
            // 
            this.TxtBoxSearchElements.CueBannerText = "Kërko...";
            this.TxtBoxSearchElements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxSearchElements.Location = new System.Drawing.Point(12, 12);
            this.TxtBoxSearchElements.Name = "TxtBoxSearchElements";
            this.TxtBoxSearchElements.ShowCueFocused = true;
            this.TxtBoxSearchElements.Size = new System.Drawing.Size(141, 29);
            this.TxtBoxSearchElements.TabIndex = 2;
            this.TxtBoxSearchElements.TextChanged += new System.EventHandler(this.TxtBoxSearchElements_TextChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Enabled = false;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.BtnSave.Location = new System.Drawing.Point(12, 580);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(1105, 65);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "SELEKTO";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPhoto.Location = new System.Drawing.Point(377, 12);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(511, 561);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.75F);
            this.label1.Location = new System.Drawing.Point(972, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sasia";
            // 
            // TxtBoxQuantity
            // 
            this.TxtBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 65F);
            this.TxtBoxQuantity.Location = new System.Drawing.Point(940, 451);
            this.TxtBoxQuantity.MaxLength = 3;
            this.TxtBoxQuantity.Name = "TxtBoxQuantity";
            this.TxtBoxQuantity.Size = new System.Drawing.Size(149, 123);
            this.TxtBoxQuantity.TabIndex = 9;
            this.TxtBoxQuantity.Text = "1";
            this.TxtBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChkBoxActiveFilters
            // 
            this.ChkBoxActiveFilters.AutoSize = true;
            this.ChkBoxActiveFilters.Location = new System.Drawing.Point(356, 22);
            this.ChkBoxActiveFilters.Name = "ChkBoxActiveFilters";
            this.ChkBoxActiveFilters.Size = new System.Drawing.Size(15, 14);
            this.ChkBoxActiveFilters.TabIndex = 12;
            this.ChkBoxActiveFilters.UseVisualStyleBackColor = true;
            this.ChkBoxActiveFilters.CheckedChanged += new System.EventHandler(this.ChkBoxActiveFilters_CheckedChanged);
            // 
            // CmbBoxCategory
            // 
            this.CmbBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxCategory.Enabled = false;
            this.CmbBoxCategory.FormattingEnabled = true;
            this.CmbBoxCategory.Location = new System.Drawing.Point(159, 15);
            this.CmbBoxCategory.Name = "CmbBoxCategory";
            this.CmbBoxCategory.Size = new System.Drawing.Size(80, 25);
            this.CmbBoxCategory.TabIndex = 10;
            this.CmbBoxCategory.SelectedIndexChanged += new System.EventHandler(this.CmbBoxCategory_SelectedIndexChanged);
            // 
            // CmbBoxDesign
            // 
            this.CmbBoxDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxDesign.Enabled = false;
            this.CmbBoxDesign.FormattingEnabled = true;
            this.CmbBoxDesign.Location = new System.Drawing.Point(245, 16);
            this.CmbBoxDesign.Name = "CmbBoxDesign";
            this.CmbBoxDesign.Size = new System.Drawing.Size(105, 25);
            this.CmbBoxDesign.TabIndex = 11;
            this.CmbBoxDesign.SelectedIndexChanged += new System.EventHandler(this.CmbBoxDesign_SelectedIndexChanged);
            // 
            // ColumnElementID
            // 
            this.ColumnElementID.DataPropertyName = "ID";
            this.ColumnElementID.HeaderText = "ID";
            this.ColumnElementID.Name = "ColumnElementID";
            this.ColumnElementID.ReadOnly = true;
            this.ColumnElementID.Visible = false;
            this.ColumnElementID.Width = 70;
            // 
            // ColumnElementName
            // 
            this.ColumnElementName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnElementName.DataPropertyName = "Name";
            this.ColumnElementName.HeaderText = "Emri";
            this.ColumnElementName.Name = "ColumnElementName";
            this.ColumnElementName.ReadOnly = true;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.DataPropertyName = "Category";
            this.ColumnCategory.HeaderText = "Kategoria";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            // 
            // ColumnDesign
            // 
            this.ColumnDesign.DataPropertyName = "Design";
            this.ColumnDesign.HeaderText = "Dizajni";
            this.ColumnDesign.Name = "ColumnDesign";
            this.ColumnDesign.ReadOnly = true;
            // 
            // BtnAccessories
            // 
            this.BtnAccessories.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAccessories.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAccessories.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnAccessories.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAccessories.Location = new System.Drawing.Point(925, 346);
            this.BtnAccessories.Name = "BtnAccessories";
            this.BtnAccessories.Size = new System.Drawing.Size(176, 60);
            this.BtnAccessories.TabIndex = 28;
            this.BtnAccessories.Text = "Aksesorët";
            this.BtnAccessories.UseVisualStyleBackColor = false;
            this.BtnAccessories.Click += new System.EventHandler(this.BtnAccessories_Click);
            // 
            // BtnLesonit
            // 
            this.BtnLesonit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLesonit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLesonit.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnLesonit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLesonit.Location = new System.Drawing.Point(925, 280);
            this.BtnLesonit.Name = "BtnLesonit";
            this.BtnLesonit.Size = new System.Drawing.Size(176, 60);
            this.BtnLesonit.TabIndex = 27;
            this.BtnLesonit.Text = "Lesonit";
            this.BtnLesonit.UseVisualStyleBackColor = false;
            this.BtnLesonit.Click += new System.EventHandler(this.BtnLesonit_Click);
            // 
            // BtnFioka
            // 
            this.BtnFioka.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFioka.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFioka.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnFioka.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFioka.Location = new System.Drawing.Point(925, 214);
            this.BtnFioka.Name = "BtnFioka";
            this.BtnFioka.Size = new System.Drawing.Size(176, 60);
            this.BtnFioka.TabIndex = 26;
            this.BtnFioka.Text = "Fioka";
            this.BtnFioka.UseVisualStyleBackColor = false;
            this.BtnFioka.Click += new System.EventHandler(this.BtnFioka_Click);
            // 
            // BtnPolica
            // 
            this.BtnPolica.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPolica.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPolica.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnPolica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPolica.Location = new System.Drawing.Point(925, 148);
            this.BtnPolica.Name = "BtnPolica";
            this.BtnPolica.Size = new System.Drawing.Size(176, 60);
            this.BtnPolica.TabIndex = 25;
            this.BtnPolica.Text = "Polica";
            this.BtnPolica.UseVisualStyleBackColor = false;
            this.BtnPolica.Click += new System.EventHandler(this.BtnPolica_Click);
            // 
            // BtnFront
            // 
            this.BtnFront.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFront.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFront.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnFront.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFront.Location = new System.Drawing.Point(925, 12);
            this.BtnFront.Name = "BtnFront";
            this.BtnFront.Size = new System.Drawing.Size(176, 60);
            this.BtnFront.TabIndex = 23;
            this.BtnFront.Text = "Front";
            this.BtnFront.UseVisualStyleBackColor = false;
            this.BtnFront.Click += new System.EventHandler(this.BtnFront_Click);
            // 
            // BtnKonstrukt
            // 
            this.BtnKonstrukt.BackColor = System.Drawing.SystemColors.Control;
            this.BtnKonstrukt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnKonstrukt.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnKonstrukt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKonstrukt.Location = new System.Drawing.Point(925, 80);
            this.BtnKonstrukt.Name = "BtnKonstrukt";
            this.BtnKonstrukt.Size = new System.Drawing.Size(176, 60);
            this.BtnKonstrukt.TabIndex = 24;
            this.BtnKonstrukt.Text = "Konstrukt";
            this.BtnKonstrukt.UseVisualStyleBackColor = false;
            this.BtnKonstrukt.Click += new System.EventHandler(this.BtnKonstrukt_Click);
            // 
            // FormElementsCHOOSE
            // 
            this.AcceptButton = this.BtnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 657);
            this.Controls.Add(this.BtnAccessories);
            this.Controls.Add(this.BtnLesonit);
            this.Controls.Add(this.BtnFioka);
            this.Controls.Add(this.BtnPolica);
            this.Controls.Add(this.BtnFront);
            this.Controls.Add(this.BtnKonstrukt);
            this.Controls.Add(this.ChkBoxActiveFilters);
            this.Controls.Add(this.CmbBoxCategory);
            this.Controls.Add(this.CmbBoxDesign);
            this.Controls.Add(this.TxtBoxQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.TxtBoxSearchElements);
            this.Controls.Add(this.DataGridViewElements);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormElementsCHOOSE";
            this.ShowInTaskbar = false;
            this.Text = "Elementet";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormElementsCHOOSE_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridViewElements;
        private WindowsFormsAero.TextBox TxtBoxSearchElements;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxQuantity;
        private System.Windows.Forms.CheckBox ChkBoxActiveFilters;
        private System.Windows.Forms.ComboBox CmbBoxCategory;
        private System.Windows.Forms.ComboBox CmbBoxDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnElementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnElementName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesign;
        private System.Windows.Forms.Button BtnAccessories;
        private System.Windows.Forms.Button BtnLesonit;
        private System.Windows.Forms.Button BtnFioka;
        private System.Windows.Forms.Button BtnPolica;
        private System.Windows.Forms.Button BtnFront;
        private System.Windows.Forms.Button BtnKonstrukt;
    }
}