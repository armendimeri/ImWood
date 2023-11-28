namespace ImWood
{
    partial class FormAddAccessory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAccessory));
            this.TxtBoxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DataGridViewAccessoryTypes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.dataGridQuickSearch = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxDescription = new System.Windows.Forms.TextBox();
            this.TxtBoxID = new System.Windows.Forms.TextBox();
            this.TxtBoxType = new System.Windows.Forms.TextBox();
            this.TxtBoxSearch = new WindowsFormsAero.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAccessoryTypes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuickSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBoxQuantity
            // 
            this.TxtBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.TxtBoxQuantity.Location = new System.Drawing.Point(108, 79);
            this.TxtBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxQuantity.Name = "TxtBoxQuantity";
            this.TxtBoxQuantity.Size = new System.Drawing.Size(77, 27);
            this.TxtBoxQuantity.TabIndex = 1;
            this.TxtBoxQuantity.Text = "1";
            this.TxtBoxQuantity.Enter += new System.EventHandler(this.TxtBoxQuantity_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sasia:";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(6, 397);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(270, 35);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "SHTO";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.DataGridViewAccessoryTypes.Location = new System.Drawing.Point(6, 59);
            this.DataGridViewAccessoryTypes.Name = "DataGridViewAccessoryTypes";
            this.DataGridViewAccessoryTypes.ReadOnly = true;
            this.DataGridViewAccessoryTypes.RowHeadersVisible = false;
            this.DataGridViewAccessoryTypes.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewAccessoryTypes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridViewAccessoryTypes.RowTemplate.Height = 30;
            this.DataGridViewAccessoryTypes.Size = new System.Drawing.Size(308, 373);
            this.DataGridViewAccessoryTypes.TabIndex = 7;
            this.DataGridViewAccessoryTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAccessoryTypes_CellClick);
            this.DataGridViewAccessoryTypes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridQuickSearch_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.LblStatus);
            this.groupBox2.Controls.Add(this.dataGridQuickSearch);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnAdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtBoxQuantity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtBoxDescription);
            this.groupBox2.Controls.Add(this.TxtBoxID);
            this.groupBox2.Controls.Add(this.TxtBoxType);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 438);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detajet";
            // 
            // LblStatus
            // 
            this.LblStatus.Location = new System.Drawing.Point(6, 319);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(270, 63);
            this.LblStatus.TabIndex = 8;
            // 
            // dataGridQuickSearch
            // 
            this.dataGridQuickSearch.AllowUserToAddRows = false;
            this.dataGridQuickSearch.AllowUserToDeleteRows = false;
            this.dataGridQuickSearch.BackgroundColor = System.Drawing.Color.White;
            this.dataGridQuickSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuickSearch.ColumnHeadersVisible = false;
            this.dataGridQuickSearch.Location = new System.Drawing.Point(108, 56);
            this.dataGridQuickSearch.Name = "dataGridQuickSearch";
            this.dataGridQuickSearch.ReadOnly = true;
            this.dataGridQuickSearch.RowHeadersVisible = false;
            this.dataGridQuickSearch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridQuickSearch.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridQuickSearch.RowTemplate.Height = 20;
            this.dataGridQuickSearch.Size = new System.Drawing.Size(147, 207);
            this.dataGridQuickSearch.TabIndex = 7;
            this.dataGridQuickSearch.Visible = false;
            this.dataGridQuickSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAccessoryTypes_CellClick);
            this.dataGridQuickSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridQuickSearch_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Përshkrimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Shifra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipi:";
            // 
            // TxtBoxDescription
            // 
            this.TxtBoxDescription.Location = new System.Drawing.Point(108, 176);
            this.TxtBoxDescription.Name = "TxtBoxDescription";
            this.TxtBoxDescription.Size = new System.Drawing.Size(147, 27);
            this.TxtBoxDescription.TabIndex = 3;
            // 
            // TxtBoxID
            // 
            this.TxtBoxID.Location = new System.Drawing.Point(108, 127);
            this.TxtBoxID.Name = "TxtBoxID";
            this.TxtBoxID.Size = new System.Drawing.Size(147, 27);
            this.TxtBoxID.TabIndex = 2;
            // 
            // TxtBoxType
            // 
            this.TxtBoxType.Location = new System.Drawing.Point(108, 30);
            this.TxtBoxType.Name = "TxtBoxType";
            this.TxtBoxType.Size = new System.Drawing.Size(147, 27);
            this.TxtBoxType.TabIndex = 0;
            this.TxtBoxType.TextChanged += new System.EventHandler(this.TxtBoxType_TextChanged);
            this.TxtBoxType.Enter += new System.EventHandler(this.TxtBoxType_Enter);
            this.TxtBoxType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBoxType_KeyDown);
            this.TxtBoxType.Leave += new System.EventHandler(this.TxtBoxType_Leave);
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxSearch.CueBannerText = "Kërko...";
            this.TxtBoxSearch.Location = new System.Drawing.Point(6, 26);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.ShowCueFocused = true;
            this.TxtBoxSearch.Size = new System.Drawing.Size(308, 27);
            this.TxtBoxSearch.TabIndex = 10;
            this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DataGridViewAccessoryTypes);
            this.groupBox1.Controls.Add(this.TxtBoxSearch);
            this.groupBox1.Location = new System.Drawing.Point(309, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 438);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aksesorët";
            // 
            // FormAddAccessory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddAccessory";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto Aksesor";
            this.Load += new System.EventHandler(this.FormAddAccessory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAddAccessory_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAccessoryTypes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuickSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DataGridViewAccessoryTypes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxDescription;
        private System.Windows.Forms.TextBox TxtBoxID;
        private System.Windows.Forms.TextBox TxtBoxType;
        private WindowsFormsAero.TextBox TxtBoxSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.DataGridView dataGridQuickSearch;
    }
}