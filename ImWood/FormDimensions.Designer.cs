namespace ImWood
{
    partial class FormDimensions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDimensions));
            this.DataGridDimensions = new System.Windows.Forms.DataGridView();
            this.BtnAddDimension = new System.Windows.Forms.Button();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKant2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDimensions)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridDimensions
            // 
            this.DataGridDimensions.AllowUserToAddRows = false;
            this.DataGridDimensions.AllowUserToDeleteRows = false;
            this.DataGridDimensions.AllowUserToResizeColumns = false;
            this.DataGridDimensions.AllowUserToResizeRows = false;
            this.DataGridDimensions.BackgroundColor = System.Drawing.Color.White;
            this.DataGridDimensions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridDimensions.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DataGridDimensions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridDimensions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridDimensions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnHeight,
            this.ColumnWidth,
            this.ColumnQuantity,
            this.ColumnKant,
            this.ColumnKant2,
            this.ColumnType,
            this.ColumnDelete});
            this.DataGridDimensions.Location = new System.Drawing.Point(12, 12);
            this.DataGridDimensions.Name = "DataGridDimensions";
            this.DataGridDimensions.ReadOnly = true;
            this.DataGridDimensions.RowHeadersVisible = false;
            this.DataGridDimensions.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridDimensions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridDimensions.RowTemplate.Height = 35;
            this.DataGridDimensions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridDimensions.Size = new System.Drawing.Size(653, 273);
            this.DataGridDimensions.TabIndex = 2;
            this.DataGridDimensions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridDimensions_CellClick);
            // 
            // BtnAddDimension
            // 
            this.BtnAddDimension.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddDimension.Location = new System.Drawing.Point(193, 306);
            this.BtnAddDimension.Name = "BtnAddDimension";
            this.BtnAddDimension.Size = new System.Drawing.Size(300, 49);
            this.BtnAddDimension.TabIndex = 3;
            this.BtnAddDimension.Text = "Shto Dimenzion";
            this.BtnAddDimension.UseVisualStyleBackColor = true;
            this.BtnAddDimension.Click += new System.EventHandler(this.BtnAddDimension_Click);
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            this.ColumnID.Width = 75;
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.DataPropertyName = "Height";
            this.ColumnHeight.HeaderText = "Lartësia (Tekstura)";
            this.ColumnHeight.Name = "ColumnHeight";
            this.ColumnHeight.ReadOnly = true;
            this.ColumnHeight.Width = 90;
            // 
            // ColumnWidth
            // 
            this.ColumnWidth.DataPropertyName = "Width";
            this.ColumnWidth.HeaderText = "Gjërësia";
            this.ColumnWidth.Name = "ColumnWidth";
            this.ColumnWidth.ReadOnly = true;
            this.ColumnWidth.Width = 90;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.HeaderText = "Sasia";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            this.ColumnQuantity.Width = 70;
            // 
            // ColumnKant
            // 
            this.ColumnKant.DataPropertyName = "Kant";
            this.ColumnKant.HeaderText = "Kant 1";
            this.ColumnKant.Name = "ColumnKant";
            this.ColumnKant.ReadOnly = true;
            // 
            // ColumnKant2
            // 
            this.ColumnKant2.DataPropertyName = "Kant2";
            this.ColumnKant2.HeaderText = "Kant 2";
            this.ColumnKant2.Name = "ColumnKant2";
            this.ColumnKant2.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnType.DataPropertyName = "Type";
            this.ColumnType.HeaderText = "Tipi";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Fshi";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDelete.Text = "Fshi";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 70;
            // 
            // FormDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 367);
            this.Controls.Add(this.BtnAddDimension);
            this.Controls.Add(this.DataGridDimensions);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormDimensions";
            this.ShowInTaskbar = false;
            this.Text = "Dimenzionet";
            this.Load += new System.EventHandler(this.FormDimensions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDimensions_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDimensions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridDimensions;
        private System.Windows.Forms.Button BtnAddDimension;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKant2;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
    }
}