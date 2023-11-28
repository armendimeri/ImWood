namespace ImWood
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DataGridViewAccessoryTypes = new System.Windows.Forms.DataGridView();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TxtBoxSearch = new WindowsFormsAero.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAccessoryTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(50, 59);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(152, 54);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Shto";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(50, 26);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(152, 27);
            this.TxtBoxName.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TxtBoxName);
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Location = new System.Drawing.Point(19, 389);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 123);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shto Tip";
            // 
            // DataGridViewAccessoryTypes
            // 
            this.DataGridViewAccessoryTypes.AllowUserToAddRows = false;
            this.DataGridViewAccessoryTypes.AllowUserToDeleteRows = false;
            this.DataGridViewAccessoryTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewAccessoryTypes.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewAccessoryTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAccessoryTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDelete});
            this.DataGridViewAccessoryTypes.Location = new System.Drawing.Point(19, 47);
            this.DataGridViewAccessoryTypes.Name = "DataGridViewAccessoryTypes";
            this.DataGridViewAccessoryTypes.ReadOnly = true;
            this.DataGridViewAccessoryTypes.RowHeadersVisible = false;
            this.DataGridViewAccessoryTypes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewAccessoryTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridViewAccessoryTypes.RowTemplate.Height = 30;
            this.DataGridViewAccessoryTypes.Size = new System.Drawing.Size(250, 336);
            this.DataGridViewAccessoryTypes.TabIndex = 6;
            this.DataGridViewAccessoryTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAccessoryTypes_CellClick);
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Fshi";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "Fshi";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 80;
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.CueBannerText = "Kërko...";
            this.TxtBoxSearch.Location = new System.Drawing.Point(19, 13);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.ShowCueFocused = true;
            this.TxtBoxSearch.Size = new System.Drawing.Size(250, 27);
            this.TxtBoxSearch.TabIndex = 9;
            this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 524);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.DataGridViewAccessoryTypes);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSettings";
            this.Text = "Settings";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSettings_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAccessoryTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DataGridViewAccessoryTypes;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private WindowsFormsAero.TextBox TxtBoxSearch;

    }
}