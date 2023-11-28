namespace ImWood
{
    partial class FormKitchenAccessories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitchenAccessories));
            this.dataGridAccessories = new System.Windows.Forms.DataGridView();
            this.BtnAddAccessory = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.LblName = new System.Windows.Forms.Label();
            this.ColumnKitchenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAccessories
            // 
            this.dataGridAccessories.AllowUserToAddRows = false;
            this.dataGridAccessories.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridAccessories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAccessories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAccessories.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAccessories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccessories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKitchenID,
            this.ColumnType,
            this.ColumnQuantity,
            this.ColumnID,
            this.ColumnDescription,
            this.ColumnDelete});
            this.dataGridAccessories.Location = new System.Drawing.Point(13, 25);
            this.dataGridAccessories.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridAccessories.Name = "dataGridAccessories";
            this.dataGridAccessories.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridAccessories.RowTemplate.Height = 25;
            this.dataGridAccessories.Size = new System.Drawing.Size(462, 204);
            this.dataGridAccessories.TabIndex = 0;
            this.dataGridAccessories.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAccessories_CellClick);
            this.dataGridAccessories.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAccessories_CellEndEdit);
            // 
            // BtnAddAccessory
            // 
            this.BtnAddAccessory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddAccessory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAddAccessory.Location = new System.Drawing.Point(11, 235);
            this.BtnAddAccessory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddAccessory.Name = "BtnAddAccessory";
            this.BtnAddAccessory.Size = new System.Drawing.Size(244, 24);
            this.BtnAddAccessory.TabIndex = 2;
            this.BtnAddAccessory.Text = "Add";
            this.BtnAddAccessory.UseVisualStyleBackColor = true;
            this.BtnAddAccessory.Click += new System.EventHandler(this.BtnAddAccessory_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPrint.Location = new System.Drawing.Point(261, 235);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(215, 24);
            this.BtnPrint.TabIndex = 2;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(210, 1);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(86, 22);
            this.LblName.TabIndex = 11;
            this.LblName.Text = "Akesorët";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColumnKitchenID
            // 
            this.ColumnKitchenID.DataPropertyName = "KitchenID";
            this.ColumnKitchenID.HeaderText = "KitchenID";
            this.ColumnKitchenID.Name = "ColumnKitchenID";
            this.ColumnKitchenID.ReadOnly = true;
            this.ColumnKitchenID.Visible = false;
            // 
            // ColumnType
            // 
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
            this.ColumnQuantity.Width = 60;
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "Shifra";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.DataPropertyName = "Description";
            this.ColumnDescription.HeaderText = "Pershkrimi";
            this.ColumnDescription.Name = "ColumnDescription";
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Fshi";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "Fshi";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 50;
            // 
            // FormKitchenAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 270);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnAddAccessory);
            this.Controls.Add(this.dataGridAccessories);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormKitchenAccessories";
            this.ShowInTaskbar = false;
            this.Text = "Aksesoare";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormKitchenAccessories_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLesonitDimensions_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAccessories;
        private System.Windows.Forms.Button BtnAddAccessory;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKitchenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}