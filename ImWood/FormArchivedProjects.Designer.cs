namespace ImWood
{
    partial class FormArchivedProjects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArchivedProjects));
            this.DataGridProjects = new System.Windows.Forms.DataGridView();
            this.ColumnKitchenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateStarted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFinished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridProjects
            // 
            this.DataGridProjects.AllowUserToAddRows = false;
            this.DataGridProjects.AllowUserToDeleteRows = false;
            this.DataGridProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridProjects.BackgroundColor = System.Drawing.Color.White;
            this.DataGridProjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKitchenID,
            this.ColumnClient,
            this.ColumnName,
            this.ColumnDateStarted,
            this.ColumnExpireDate,
            this.ColumnFinished});
            this.DataGridProjects.Location = new System.Drawing.Point(14, 17);
            this.DataGridProjects.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.DataGridProjects.Name = "DataGridProjects";
            this.DataGridProjects.ReadOnly = true;
            this.DataGridProjects.RowHeadersVisible = false;
            this.DataGridProjects.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridProjects.RowTemplate.Height = 40;
            this.DataGridProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridProjects.Size = new System.Drawing.Size(800, 566);
            this.DataGridProjects.TabIndex = 2;
            this.DataGridProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridProjects_CellDoubleClick);
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
            // ColumnFinished
            // 
            this.ColumnFinished.DataPropertyName = "DateFinished";
            this.ColumnFinished.HeaderText = "Mbaroi";
            this.ColumnFinished.Name = "ColumnFinished";
            this.ColumnFinished.ReadOnly = true;
            this.ColumnFinished.Width = 165;
            // 
            // FormArchivedProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 600);
            this.Controls.Add(this.DataGridProjects);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormArchivedProjects";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekte te Arkivuara";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormArchivedProjects_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKitchenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateStarted;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFinished;
    }
}