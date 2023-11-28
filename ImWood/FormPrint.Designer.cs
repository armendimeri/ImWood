namespace ImWood
{
    partial class FormPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrint));
            this.GroupBoxDimensions = new System.Windows.Forms.GroupBox();
            this.DataGridViewDimensions = new System.Windows.Forms.DataGridView();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKant2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIsManual = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridAccessories = new System.Windows.Forms.DataGridView();
            this.ColumnKitchenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccessoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccessoryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccessoryQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.GroupBoxDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDimensions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessories)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxDimensions
            // 
            this.GroupBoxDimensions.Controls.Add(this.DataGridViewDimensions);
            this.GroupBoxDimensions.Location = new System.Drawing.Point(13, 14);
            this.GroupBoxDimensions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxDimensions.Name = "GroupBoxDimensions";
            this.GroupBoxDimensions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBoxDimensions.Size = new System.Drawing.Size(837, 581);
            this.GroupBoxDimensions.TabIndex = 1;
            this.GroupBoxDimensions.TabStop = false;
            this.GroupBoxDimensions.Text = "Dimenzionet";
            // 
            // DataGridViewDimensions
            // 
            this.DataGridViewDimensions.AllowUserToAddRows = false;
            this.DataGridViewDimensions.AllowUserToDeleteRows = false;
            this.DataGridViewDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewDimensions.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewDimensions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewDimensions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDimensions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnType,
            this.ColumnHeight,
            this.ColumnWidth,
            this.ColumnQuantity,
            this.ColumnKant,
            this.ColumnKant2,
            this.ColumnIsManual,
            this.ColumnFunction,
            this.ColumnComment});
            this.DataGridViewDimensions.Location = new System.Drawing.Point(7, 28);
            this.DataGridViewDimensions.Name = "DataGridViewDimensions";
            this.DataGridViewDimensions.ReadOnly = true;
            this.DataGridViewDimensions.RowHeadersVisible = false;
            this.DataGridViewDimensions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridViewDimensions.RowTemplate.Height = 35;
            this.DataGridViewDimensions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDimensions.Size = new System.Drawing.Size(823, 545);
            this.DataGridViewDimensions.TabIndex = 7;
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "Type";
            this.ColumnType.HeaderText = "Tipi";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.DataPropertyName = "Height";
            this.ColumnHeight.HeaderText = "Lartësia (Tekstura)";
            this.ColumnHeight.Name = "ColumnHeight";
            this.ColumnHeight.ReadOnly = true;
            this.ColumnHeight.Width = 80;
            // 
            // ColumnWidth
            // 
            this.ColumnWidth.DataPropertyName = "Width";
            this.ColumnWidth.HeaderText = "Gjërësia";
            this.ColumnWidth.Name = "ColumnWidth";
            this.ColumnWidth.ReadOnly = true;
            this.ColumnWidth.Width = 80;
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
            this.ColumnKant.Width = 70;
            // 
            // ColumnKant2
            // 
            this.ColumnKant2.DataPropertyName = "Kant2";
            this.ColumnKant2.HeaderText = "Kant 2";
            this.ColumnKant2.Name = "ColumnKant2";
            this.ColumnKant2.ReadOnly = true;
            this.ColumnKant2.Width = 70;
            // 
            // ColumnIsManual
            // 
            this.ColumnIsManual.DataPropertyName = "Manual";
            this.ColumnIsManual.HeaderText = "Manuale";
            this.ColumnIsManual.Name = "ColumnIsManual";
            this.ColumnIsManual.ReadOnly = true;
            this.ColumnIsManual.Width = 75;
            // 
            // ColumnFunction
            // 
            this.ColumnFunction.DataPropertyName = "Funksioni";
            this.ColumnFunction.HeaderText = "Funksioni";
            this.ColumnFunction.Name = "ColumnFunction";
            this.ColumnFunction.ReadOnly = true;
            this.ColumnFunction.Width = 80;
            // 
            // ColumnComment
            // 
            this.ColumnComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnComment.DataPropertyName = "Comment";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnComment.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnComment.HeaderText = "Komenti";
            this.ColumnComment.Name = "ColumnComment";
            this.ColumnComment.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridAccessories);
            this.groupBox2.Location = new System.Drawing.Point(858, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(401, 581);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aksesoret (Materialet)";
            // 
            // dataGridAccessories
            // 
            this.dataGridAccessories.AllowUserToAddRows = false;
            this.dataGridAccessories.AllowUserToDeleteRows = false;
            this.dataGridAccessories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAccessories.BackgroundColor = System.Drawing.Color.White;
            this.dataGridAccessories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridAccessories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAccessories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKitchenID,
            this.ColumnAccessoryID,
            this.ColumnAccessoryType,
            this.ColumnAccessoryQuantity});
            this.dataGridAccessories.Location = new System.Drawing.Point(8, 30);
            this.dataGridAccessories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridAccessories.Name = "dataGridAccessories";
            this.dataGridAccessories.ReadOnly = true;
            this.dataGridAccessories.RowHeadersVisible = false;
            this.dataGridAccessories.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridAccessories.RowTemplate.Height = 38;
            this.dataGridAccessories.Size = new System.Drawing.Size(385, 543);
            this.dataGridAccessories.TabIndex = 1;
            // 
            // ColumnKitchenID
            // 
            this.ColumnKitchenID.DataPropertyName = "KitchenID";
            this.ColumnKitchenID.HeaderText = "KitchenID";
            this.ColumnKitchenID.Name = "ColumnKitchenID";
            this.ColumnKitchenID.ReadOnly = true;
            this.ColumnKitchenID.Visible = false;
            // 
            // ColumnAccessoryID
            // 
            this.ColumnAccessoryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAccessoryID.DataPropertyName = "ID";
            this.ColumnAccessoryID.HeaderText = "Shifra";
            this.ColumnAccessoryID.Name = "ColumnAccessoryID";
            this.ColumnAccessoryID.ReadOnly = true;
            // 
            // ColumnAccessoryType
            // 
            this.ColumnAccessoryType.DataPropertyName = "Type";
            this.ColumnAccessoryType.HeaderText = "Tipi";
            this.ColumnAccessoryType.Name = "ColumnAccessoryType";
            this.ColumnAccessoryType.ReadOnly = true;
            // 
            // ColumnAccessoryQuantity
            // 
            this.ColumnAccessoryQuantity.DataPropertyName = "Quantity";
            this.ColumnAccessoryQuantity.HeaderText = "Sasia";
            this.ColumnAccessoryQuantity.Name = "ColumnAccessoryQuantity";
            this.ColumnAccessoryQuantity.ReadOnly = true;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Location = new System.Drawing.Point(480, 603);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(262, 42);
            this.BtnPrint.TabIndex = 2;
            this.BtnPrint.Text = "PRINTO";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 657);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBoxDimensions);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Printo";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPrint_KeyDown);
            this.GroupBoxDimensions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDimensions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAccessories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxDimensions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DataGridViewDimensions;
        private System.Windows.Forms.DataGridView dataGridAccessories;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKitchenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccessoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccessoryType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAccessoryQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKant2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnIsManual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
    }
}