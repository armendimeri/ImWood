namespace ImWood
{
    partial class FormAccessories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccessories));
            this.DataGridAccessories = new System.Windows.Forms.DataGridView();
            this.ColumnElementID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnAddAccessory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAccessories)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridAccessories
            // 
            this.DataGridAccessories.AllowUserToAddRows = false;
            this.DataGridAccessories.AllowUserToDeleteRows = false;
            this.DataGridAccessories.AllowUserToResizeColumns = false;
            this.DataGridAccessories.AllowUserToResizeRows = false;
            this.DataGridAccessories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridAccessories.BackgroundColor = System.Drawing.Color.White;
            this.DataGridAccessories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridAccessories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridAccessories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnElementID,
            this.ColumnType,
            this.ColumnQuantity,
            this.ColumnDelete});
            this.DataGridAccessories.Location = new System.Drawing.Point(13, 68);
            this.DataGridAccessories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridAccessories.Name = "DataGridAccessories";
            this.DataGridAccessories.ReadOnly = true;
            this.DataGridAccessories.RowHeadersVisible = false;
            this.DataGridAccessories.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridAccessories.RowTemplate.Height = 36;
            this.DataGridAccessories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridAccessories.Size = new System.Drawing.Size(343, 395);
            this.DataGridAccessories.TabIndex = 0;
            this.DataGridAccessories.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridAccessories_CellContentClick);
            // 
            // ColumnElementID
            // 
            this.ColumnElementID.DataPropertyName = "ElementID";
            this.ColumnElementID.HeaderText = "ElementID";
            this.ColumnElementID.Name = "ColumnElementID";
            this.ColumnElementID.ReadOnly = true;
            this.ColumnElementID.Visible = false;
            // 
            // ColumnType
            // 
            this.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnType.DataPropertyName = "Type";
            this.ColumnType.HeaderText = "Tipi";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.HeaderText = "Sasia";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Fshi";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "Fshi";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            // 
            // BtnAddAccessory
            // 
            this.BtnAddAccessory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddAccessory.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddAccessory.Location = new System.Drawing.Point(13, 473);
            this.BtnAddAccessory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddAccessory.Name = "BtnAddAccessory";
            this.BtnAddAccessory.Size = new System.Drawing.Size(343, 50);
            this.BtnAddAccessory.TabIndex = 1;
            this.BtnAddAccessory.Text = "Shto Aksesorë";
            this.BtnAddAccessory.UseVisualStyleBackColor = true;
            this.BtnAddAccessory.Click += new System.EventHandler(this.BtnAddAccessory_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aksesorë";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAddAccessory);
            this.Controls.Add(this.DataGridAccessories);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccessories";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aksesore";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAccessories_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridAccessories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridAccessories;
        private System.Windows.Forms.Button BtnAddAccessory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnElementID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}