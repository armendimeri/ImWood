namespace ImWood
{
    partial class FormElements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormElements));
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBoxSearchElements = new WindowsFormsAero.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.BtnLock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControlElements = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDesign = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLocked = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChkBoxActiveFilters = new System.Windows.Forms.CheckBox();
            this.CmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.CmbBoxDesign = new System.Windows.Forms.ComboBox();
            this.BtnChangePicture = new System.Windows.Forms.Button();
            this.BtnAccessories = new System.Windows.Forms.Button();
            this.BtnLesonit = new System.Windows.Forms.Button();
            this.BtnFioka = new System.Windows.Forms.Button();
            this.BtnPolica = new System.Windows.Forms.Button();
            this.BtnFront = new System.Windows.Forms.Button();
            this.BtnKonstrukt = new System.Windows.Forms.Button();
            this.CmbBoxElementCategory = new System.Windows.Forms.ComboBox();
            this.CmbBoxElementDesign = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ChkBoxAllowEdit = new System.Windows.Forms.CheckBox();
            this.BtnUnlock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlElements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(6, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(351, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Shto Element";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtBoxSearchElements
            // 
            this.TxtBoxSearchElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxSearchElements.CueBannerText = "Kërko...";
            this.TxtBoxSearchElements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxSearchElements.Location = new System.Drawing.Point(6, 73);
            this.TxtBoxSearchElements.Name = "TxtBoxSearchElements";
            this.TxtBoxSearchElements.ShowCueFocused = true;
            this.TxtBoxSearchElements.Size = new System.Drawing.Size(132, 29);
            this.TxtBoxSearchElements.TabIndex = 2;
            this.TxtBoxSearchElements.TextChanged += new System.EventHandler(this.TxtBoxSearchElements_TextChanged);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPhoto.Location = new System.Drawing.Point(381, 12);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(572, 571);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 5;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // BtnLock
            // 
            this.BtnLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLock.Location = new System.Drawing.Point(959, 550);
            this.BtnLock.Name = "BtnLock";
            this.BtnLock.Size = new System.Drawing.Size(176, 30);
            this.BtnLock.TabIndex = 12;
            this.BtnLock.Text = "Aktivizo";
            this.BtnLock.UseVisualStyleBackColor = true;
            this.BtnLock.Click += new System.EventHandler(this.BtnLock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.gridControlElements);
            this.groupBox1.Controls.Add(this.ChkBoxActiveFilters);
            this.groupBox1.Controls.Add(this.CmbBoxCategory);
            this.groupBox1.Controls.Add(this.CmbBoxDesign);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtBoxSearchElements);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 608);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elementet";
            // 
            // gridControlElements
            // 
            this.gridControlElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControlElements.Location = new System.Drawing.Point(6, 117);
            this.gridControlElements.MainView = this.gridView1;
            this.gridControlElements.Name = "gridControlElements";
            this.gridControlElements.Size = new System.Drawing.Size(351, 485);
            this.gridControlElements.TabIndex = 5;
            this.gridControlElements.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlElements.DoubleClick += new System.EventHandler(this.gridControlElements_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnName,
            this.gridColumnCategory,
            this.gridColumnDesign,
            this.gridColumnLocked});
            this.gridView1.GridControl = this.gridControlElements;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowHeight = 30;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnDesign, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ID";
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.OptionsColumn.AllowEdit = false;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 182;
            // 
            // gridColumnCategory
            // 
            this.gridColumnCategory.Caption = "Category";
            this.gridColumnCategory.FieldName = "Category";
            this.gridColumnCategory.Name = "gridColumnCategory";
            this.gridColumnCategory.Visible = true;
            this.gridColumnCategory.VisibleIndex = 1;
            this.gridColumnCategory.Width = 78;
            // 
            // gridColumnDesign
            // 
            this.gridColumnDesign.Caption = "Dizajn";
            this.gridColumnDesign.FieldName = "Design";
            this.gridColumnDesign.Name = "gridColumnDesign";
            this.gridColumnDesign.Visible = true;
            this.gridColumnDesign.VisibleIndex = 2;
            this.gridColumnDesign.Width = 114;
            // 
            // gridColumnLocked
            // 
            this.gridColumnLocked.Caption = "Lock";
            this.gridColumnLocked.FieldName = "Locked";
            this.gridColumnLocked.Name = "gridColumnLocked";
            this.gridColumnLocked.Visible = true;
            this.gridColumnLocked.VisibleIndex = 2;
            this.gridColumnLocked.Width = 58;
            // 
            // ChkBoxActiveFilters
            // 
            this.ChkBoxActiveFilters.AutoSize = true;
            this.ChkBoxActiveFilters.Location = new System.Drawing.Point(342, 82);
            this.ChkBoxActiveFilters.Name = "ChkBoxActiveFilters";
            this.ChkBoxActiveFilters.Size = new System.Drawing.Size(15, 14);
            this.ChkBoxActiveFilters.TabIndex = 4;
            this.ChkBoxActiveFilters.UseVisualStyleBackColor = true;
            this.ChkBoxActiveFilters.CheckedChanged += new System.EventHandler(this.ChkBoxActiveFilters_CheckedChanged);
            // 
            // CmbBoxCategory
            // 
            this.CmbBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxCategory.FormattingEnabled = true;
            this.CmbBoxCategory.Location = new System.Drawing.Point(144, 76);
            this.CmbBoxCategory.Name = "CmbBoxCategory";
            this.CmbBoxCategory.Size = new System.Drawing.Size(80, 25);
            this.CmbBoxCategory.TabIndex = 3;
            this.CmbBoxCategory.SelectedIndexChanged += new System.EventHandler(this.CmbBoxCategory_SelectedIndexChanged);
            // 
            // CmbBoxDesign
            // 
            this.CmbBoxDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxDesign.FormattingEnabled = true;
            this.CmbBoxDesign.Location = new System.Drawing.Point(231, 77);
            this.CmbBoxDesign.Name = "CmbBoxDesign";
            this.CmbBoxDesign.Size = new System.Drawing.Size(105, 25);
            this.CmbBoxDesign.TabIndex = 3;
            this.CmbBoxDesign.SelectedIndexChanged += new System.EventHandler(this.CmbBoxDesign_SelectedIndexChanged);
            // 
            // BtnChangePicture
            // 
            this.BtnChangePicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnChangePicture.Location = new System.Drawing.Point(375, 590);
            this.BtnChangePicture.Name = "BtnChangePicture";
            this.BtnChangePicture.Size = new System.Drawing.Size(578, 31);
            this.BtnChangePicture.TabIndex = 14;
            this.BtnChangePicture.Text = "Foto...";
            this.BtnChangePicture.UseVisualStyleBackColor = true;
            this.BtnChangePicture.Click += new System.EventHandler(this.BtnChangePicture_Click);
            // 
            // BtnAccessories
            // 
            this.BtnAccessories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccessories.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAccessories.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAccessories.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnAccessories.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAccessories.Location = new System.Drawing.Point(960, 351);
            this.BtnAccessories.Name = "BtnAccessories";
            this.BtnAccessories.Size = new System.Drawing.Size(176, 60);
            this.BtnAccessories.TabIndex = 22;
            this.BtnAccessories.Text = "Aksesorët";
            this.BtnAccessories.UseVisualStyleBackColor = false;
            this.BtnAccessories.Click += new System.EventHandler(this.BtnAccessories_Click_1);
            // 
            // BtnLesonit
            // 
            this.BtnLesonit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLesonit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLesonit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLesonit.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnLesonit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLesonit.Location = new System.Drawing.Point(960, 285);
            this.BtnLesonit.Name = "BtnLesonit";
            this.BtnLesonit.Size = new System.Drawing.Size(176, 60);
            this.BtnLesonit.TabIndex = 21;
            this.BtnLesonit.Text = "Lesonit";
            this.BtnLesonit.UseVisualStyleBackColor = false;
            this.BtnLesonit.Click += new System.EventHandler(this.BtnLesonit_Click);
            // 
            // BtnFioka
            // 
            this.BtnFioka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFioka.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFioka.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFioka.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnFioka.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFioka.Location = new System.Drawing.Point(960, 219);
            this.BtnFioka.Name = "BtnFioka";
            this.BtnFioka.Size = new System.Drawing.Size(176, 60);
            this.BtnFioka.TabIndex = 20;
            this.BtnFioka.Text = "Fioka";
            this.BtnFioka.UseVisualStyleBackColor = false;
            this.BtnFioka.Click += new System.EventHandler(this.BtnFioka_Click);
            // 
            // BtnPolica
            // 
            this.BtnPolica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPolica.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPolica.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPolica.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnPolica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPolica.Location = new System.Drawing.Point(960, 153);
            this.BtnPolica.Name = "BtnPolica";
            this.BtnPolica.Size = new System.Drawing.Size(176, 60);
            this.BtnPolica.TabIndex = 19;
            this.BtnPolica.Text = "Polica";
            this.BtnPolica.UseVisualStyleBackColor = false;
            this.BtnPolica.Click += new System.EventHandler(this.BtnPolica_Click);
            // 
            // BtnFront
            // 
            this.BtnFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFront.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFront.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFront.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnFront.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFront.Location = new System.Drawing.Point(960, 17);
            this.BtnFront.Name = "BtnFront";
            this.BtnFront.Size = new System.Drawing.Size(176, 60);
            this.BtnFront.TabIndex = 17;
            this.BtnFront.Text = "Front";
            this.BtnFront.UseVisualStyleBackColor = false;
            this.BtnFront.Click += new System.EventHandler(this.BtnFront_Click);
            // 
            // BtnKonstrukt
            // 
            this.BtnKonstrukt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKonstrukt.BackColor = System.Drawing.SystemColors.Control;
            this.BtnKonstrukt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnKonstrukt.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnKonstrukt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKonstrukt.Location = new System.Drawing.Point(960, 85);
            this.BtnKonstrukt.Name = "BtnKonstrukt";
            this.BtnKonstrukt.Size = new System.Drawing.Size(176, 60);
            this.BtnKonstrukt.TabIndex = 18;
            this.BtnKonstrukt.Text = "Konstrukt";
            this.BtnKonstrukt.UseVisualStyleBackColor = false;
            this.BtnKonstrukt.Click += new System.EventHandler(this.BtnKonstrukt_Click);
            // 
            // CmbBoxElementCategory
            // 
            this.CmbBoxElementCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbBoxElementCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxElementCategory.Enabled = false;
            this.CmbBoxElementCategory.FormattingEnabled = true;
            this.CmbBoxElementCategory.Location = new System.Drawing.Point(1031, 417);
            this.CmbBoxElementCategory.Name = "CmbBoxElementCategory";
            this.CmbBoxElementCategory.Size = new System.Drawing.Size(105, 25);
            this.CmbBoxElementCategory.TabIndex = 5;
            // 
            // CmbBoxElementDesign
            // 
            this.CmbBoxElementDesign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbBoxElementDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxElementDesign.Enabled = false;
            this.CmbBoxElementDesign.FormattingEnabled = true;
            this.CmbBoxElementDesign.Location = new System.Drawing.Point(1031, 448);
            this.CmbBoxElementDesign.Name = "CmbBoxElementDesign";
            this.CmbBoxElementDesign.Size = new System.Drawing.Size(105, 25);
            this.CmbBoxElementDesign.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(960, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Kategoria:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(976, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dizajni:";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Enabled = false;
            this.BtnSave.Location = new System.Drawing.Point(963, 479);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(154, 30);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "Ruaj";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ChkBoxAllowEdit
            // 
            this.ChkBoxAllowEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkBoxAllowEdit.AutoSize = true;
            this.ChkBoxAllowEdit.Location = new System.Drawing.Point(1126, 489);
            this.ChkBoxAllowEdit.Name = "ChkBoxAllowEdit";
            this.ChkBoxAllowEdit.Size = new System.Drawing.Size(15, 14);
            this.ChkBoxAllowEdit.TabIndex = 24;
            this.ChkBoxAllowEdit.UseVisualStyleBackColor = true;
            this.ChkBoxAllowEdit.CheckedChanged += new System.EventHandler(this.ChkBoxAllowEdit_CheckedChanged);
            // 
            // BtnUnlock
            // 
            this.BtnUnlock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUnlock.Location = new System.Drawing.Point(959, 515);
            this.BtnUnlock.Name = "BtnUnlock";
            this.BtnUnlock.Size = new System.Drawing.Size(176, 30);
            this.BtnUnlock.TabIndex = 25;
            this.BtnUnlock.Text = "Deaktivizo";
            this.BtnUnlock.UseVisualStyleBackColor = true;
            this.BtnUnlock.Click += new System.EventHandler(this.BtnUnlock_Click);
            // 
            // FormElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 632);
            this.Controls.Add(this.BtnUnlock);
            this.Controls.Add(this.ChkBoxAllowEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbBoxElementCategory);
            this.Controls.Add(this.BtnAccessories);
            this.Controls.Add(this.CmbBoxElementDesign);
            this.Controls.Add(this.BtnLesonit);
            this.Controls.Add(this.BtnFioka);
            this.Controls.Add(this.BtnPolica);
            this.Controls.Add(this.BtnFront);
            this.Controls.Add(this.BtnKonstrukt);
            this.Controls.Add(this.BtnChangePicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnLock);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormElements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elementet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormElements_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormElements_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlElements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private WindowsFormsAero.TextBox TxtBoxSearchElements;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button BtnLock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnChangePicture;
        private System.Windows.Forms.Button BtnAccessories;
        private System.Windows.Forms.Button BtnKonstrukt;
        private System.Windows.Forms.Button BtnFront;
        private System.Windows.Forms.Button BtnPolica;
        private System.Windows.Forms.Button BtnFioka;
        private System.Windows.Forms.Button BtnLesonit;
        private System.Windows.Forms.ComboBox CmbBoxDesign;
        private System.Windows.Forms.ComboBox CmbBoxCategory;
        private System.Windows.Forms.CheckBox ChkBoxActiveFilters;
        private System.Windows.Forms.ComboBox CmbBoxElementCategory;
        private System.Windows.Forms.ComboBox CmbBoxElementDesign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.CheckBox ChkBoxAllowEdit;
        private System.Windows.Forms.Button BtnUnlock;
        private DevExpress.XtraGrid.GridControl gridControlElements;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCategory;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDesign;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLocked;
    }
}