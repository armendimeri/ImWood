namespace ImWood
{
    partial class FormKitchenElements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitchenElements));
            this.DataGridElements = new System.Windows.Forms.DataGridView();
            this.ColumnElementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhoto = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAddElement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridElements)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridElements
            // 
            this.DataGridElements.AllowUserToAddRows = false;
            this.DataGridElements.AllowUserToDeleteRows = false;
            this.DataGridElements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridElements.BackgroundColor = System.Drawing.Color.White;
            this.DataGridElements.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnElementID,
            this.ColumnName,
            this.ColumnQuantity,
            this.ColumnPhoto,
            this.ColumnDelete});
            this.DataGridElements.Location = new System.Drawing.Point(13, 14);
            this.DataGridElements.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridElements.Name = "DataGridElements";
            this.DataGridElements.ReadOnly = true;
            this.DataGridElements.RowHeadersVisible = false;
            this.DataGridElements.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridElements.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridElements.RowTemplate.Height = 100;
            this.DataGridElements.Size = new System.Drawing.Size(818, 449);
            this.DataGridElements.TabIndex = 0;
            this.DataGridElements.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridElements_CellContentClick);
            // 
            // ColumnElementID
            // 
            this.ColumnElementID.DataPropertyName = "ElementID";
            this.ColumnElementID.HeaderText = "ElementID";
            this.ColumnElementID.Name = "ColumnElementID";
            this.ColumnElementID.ReadOnly = true;
            this.ColumnElementID.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Emri";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.HeaderText = "Sasia";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // ColumnPhoto
            // 
            this.ColumnPhoto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPhoto.DataPropertyName = "Photo";
            this.ColumnPhoto.HeaderText = "Photo";
            this.ColumnPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnPhoto.Name = "ColumnPhoto";
            this.ColumnPhoto.ReadOnly = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Fshi";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "Fshi";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            // 
            // BtnAddElement
            // 
            this.BtnAddElement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddElement.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddElement.Location = new System.Drawing.Point(213, 471);
            this.BtnAddElement.Name = "BtnAddElement";
            this.BtnAddElement.Size = new System.Drawing.Size(412, 45);
            this.BtnAddElement.TabIndex = 1;
            this.BtnAddElement.Text = "Shto Element";
            this.BtnAddElement.UseVisualStyleBackColor = true;
            this.BtnAddElement.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormKitchenElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 521);
            this.Controls.Add(this.BtnAddElement);
            this.Controls.Add(this.DataGridElements);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKitchenElements";
            this.ShowInTaskbar = false;
            this.Text = "Elementet e Kuzhinës";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKitchenElements_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridElements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridElements;
        private System.Windows.Forms.Button BtnAddElement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnElementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewImageColumn ColumnPhoto;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}