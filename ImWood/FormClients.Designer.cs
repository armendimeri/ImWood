namespace ImWood
{
    partial class FormClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClients));
            this.DataGridClients = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTown = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new WindowsFormsAero.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridClients
            // 
            this.DataGridClients.AllowUserToAddRows = false;
            this.DataGridClients.AllowUserToDeleteRows = false;
            this.DataGridClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridClients.BackgroundColor = System.Drawing.Color.White;
            this.DataGridClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnPhone,
            this.ColumnTown});
            this.DataGridClients.Location = new System.Drawing.Point(13, 47);
            this.DataGridClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridClients.Name = "DataGridClients";
            this.DataGridClients.ReadOnly = true;
            this.DataGridClients.RowHeadersVisible = false;
            this.DataGridClients.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridClients.RowTemplate.Height = 32;
            this.DataGridClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridClients.Size = new System.Drawing.Size(364, 334);
            this.DataGridClients.TabIndex = 0;
            this.DataGridClients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridClients_CellDoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.DataPropertyName = "Name";
            this.ColumnName.HeaderText = "Emri";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.DataPropertyName = "Phone";
            this.ColumnPhone.HeaderText = "Telefon";
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.ReadOnly = true;
            // 
            // ColumnTown
            // 
            this.ColumnTown.DataPropertyName = "Town";
            this.ColumnTown.HeaderText = "Vendi";
            this.ColumnTown.Name = "ColumnTown";
            this.ColumnTown.ReadOnly = true;
            // 
            // textBox2
            // 
            this.textBox2.CueBannerText = "Kërko...";
            this.textBox2.Location = new System.Drawing.Point(13, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.ShowCueFocused = true;
            this.textBox2.Size = new System.Drawing.Size(364, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(13, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "SHTO KLIENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DataGridClients);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormClients";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Klientët";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClients_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTown;
        private WindowsFormsAero.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}