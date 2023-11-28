namespace ImWood
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.DataGridCurrentKitchens = new System.Windows.Forms.DataGridView();
            this.ColumnKitchenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDaysLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnNewProject = new System.Windows.Forms.ToolStripButton();
            this.BtnElements = new System.Windows.Forms.ToolStripButton();
            this.BtnOldProjects = new System.Windows.Forms.ToolStripButton();
            this.BtnDrawers = new System.Windows.Forms.ToolStripButton();
            this.BtnSettings = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCurrentKitchens)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridCurrentKitchens
            // 
            this.DataGridCurrentKitchens.AllowUserToAddRows = false;
            this.DataGridCurrentKitchens.AllowUserToDeleteRows = false;
            this.DataGridCurrentKitchens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridCurrentKitchens.BackgroundColor = System.Drawing.Color.White;
            this.DataGridCurrentKitchens.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridCurrentKitchens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCurrentKitchens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKitchenID,
            this.ColumnClient,
            this.ColumnName,
            this.ColumnDateStarted,
            this.ColumnExpireDate,
            this.ColumnDaysLeft});
            this.DataGridCurrentKitchens.Location = new System.Drawing.Point(13, 63);
            this.DataGridCurrentKitchens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridCurrentKitchens.Name = "DataGridCurrentKitchens";
            this.DataGridCurrentKitchens.ReadOnly = true;
            this.DataGridCurrentKitchens.RowHeadersVisible = false;
            this.DataGridCurrentKitchens.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridCurrentKitchens.RowTemplate.Height = 40;
            this.DataGridCurrentKitchens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCurrentKitchens.Size = new System.Drawing.Size(823, 513);
            this.DataGridCurrentKitchens.TabIndex = 1;
            this.DataGridCurrentKitchens.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCurrentKitchens_CellDoubleClick);
            // 
            // ColumnKitchenID
            // 
            this.ColumnKitchenID.DataPropertyName = "ID";
            this.ColumnKitchenID.HeaderText = "ID";
            this.ColumnKitchenID.Name = "ColumnKitchenID";
            this.ColumnKitchenID.ReadOnly = true;
            this.ColumnKitchenID.Visible = false;
            // 
            // ColumnClient
            // 
            this.ColumnClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnClient.DataPropertyName = "Client";
            this.ColumnClient.HeaderText = "Klienti";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "ProjectName";
            this.ColumnName.HeaderText = "Artikulli";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 130;
            // 
            // ColumnDateStarted
            // 
            this.ColumnDateStarted.DataPropertyName = "DateStarted";
            this.ColumnDateStarted.HeaderText = "Filloi";
            this.ColumnDateStarted.Name = "ColumnDateStarted";
            this.ColumnDateStarted.ReadOnly = true;
            this.ColumnDateStarted.Width = 165;
            // 
            // ColumnExpireDate
            // 
            this.ColumnExpireDate.DataPropertyName = "DateExpire";
            this.ColumnExpireDate.HeaderText = "Afati";
            this.ColumnExpireDate.Name = "ColumnExpireDate";
            this.ColumnExpireDate.ReadOnly = true;
            this.ColumnExpireDate.Width = 165;
            // 
            // ColumnDaysLeft
            // 
            this.ColumnDaysLeft.DataPropertyName = "Days";
            this.ColumnDaysLeft.HeaderText = "Mbetja";
            this.ColumnDaysLeft.Name = "ColumnDaysLeft";
            this.ColumnDaysLeft.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNewProject,
            this.BtnElements,
            this.BtnOldProjects,
            this.BtnDrawers,
            this.BtnSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1315, 58);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendar1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.monthCalendar1.Location = new System.Drawing.Point(852, 63);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 14, 12, 14);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.Location = new System.Drawing.Point(657, 16);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(179, 39);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Image = global::ImWood.Properties.Resources._1448297897_document_new;
            this.BtnNewProject.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(84, 55);
            this.BtnNewProject.Text = "Projekt i Ri";
            this.BtnNewProject.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnNewProject.Click += new System.EventHandler(this.BtnNewProject_Click);
            // 
            // BtnElements
            // 
            this.BtnElements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnElements.Image = global::ImWood.Properties.Resources.drawer_archive_icon;
            this.BtnElements.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnElements.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnElements.Name = "BtnElements";
            this.BtnElements.Size = new System.Drawing.Size(80, 55);
            this.BtnElements.Text = "Elementet";
            this.BtnElements.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnElements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnElements.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // BtnOldProjects
            // 
            this.BtnOldProjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnOldProjects.Image = global::ImWood.Properties.Resources.app_x_archive_icon;
            this.BtnOldProjects.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnOldProjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnOldProjects.Name = "BtnOldProjects";
            this.BtnOldProjects.Size = new System.Drawing.Size(154, 55);
            this.BtnOldProjects.Text = "Projekte Te Mbaruara";
            this.BtnOldProjects.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnOldProjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnOldProjects.Click += new System.EventHandler(this.BtnOldProjects_Click);
            // 
            // BtnDrawers
            // 
            this.BtnDrawers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDrawers.Image = global::ImWood.Properties.Resources.DrawerIcon32x;
            this.BtnDrawers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDrawers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDrawers.Name = "BtnDrawers";
            this.BtnDrawers.Size = new System.Drawing.Size(53, 55);
            this.BtnDrawers.Text = "Fiokat";
            this.BtnDrawers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDrawers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDrawers.Click += new System.EventHandler(this.BtnDrawers_Click);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSettings.Image = global::ImWood.Properties.Resources.SettingsIcon;
            this.BtnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(66, 55);
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 590);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DataGridCurrentKitchens);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Inner Design";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCurrentKitchens)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridCurrentKitchens;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnElements;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripButton BtnNewProject;
        private System.Windows.Forms.ToolStripButton BtnOldProjects;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.ToolStripButton BtnSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKitchenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateStarted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDaysLeft;
        private System.Windows.Forms.ToolStripButton BtnDrawers;
    }
}

