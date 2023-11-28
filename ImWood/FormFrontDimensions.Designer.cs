namespace ImWood
{
    partial class FormFrontDimensions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFrontDimensions));
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DataGridViewDimensions = new System.Windows.Forms.DataGridView();
            this.LblName = new System.Windows.Forms.Label();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDimensions)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.Location = new System.Drawing.Point(245, 231);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(230, 27);
            this.BtnPrint.TabIndex = 15;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(12, 231);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(227, 27);
            this.BtnAdd.TabIndex = 14;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DataGridViewDimensions
            // 
            this.DataGridViewDimensions.AllowUserToAddRows = false;
            this.DataGridViewDimensions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.DataGridViewDimensions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewDimensions.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewDimensions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridViewDimensions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDimensions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnHeight,
            this.ColumnWidth,
            this.ColumnQuantity,
            this.ColumnFunction,
            this.ColumnComment,
            this.ColumnDelete});
            this.DataGridViewDimensions.Location = new System.Drawing.Point(12, 18);
            this.DataGridViewDimensions.Name = "DataGridViewDimensions";
            this.DataGridViewDimensions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridViewDimensions.RowTemplate.Height = 20;
            this.DataGridViewDimensions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDimensions.Size = new System.Drawing.Size(463, 207);
            this.DataGridViewDimensions.TabIndex = 13;
            this.DataGridViewDimensions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDimensions_CellClick);
            this.DataGridViewDimensions.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridViewDimensions_RowPostPaint);
            // 
            // LblName
            // 
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(201, -4);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(80, 22);
            this.LblName.TabIndex = 16;
            this.LblName.Text = "Front";
            this.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 2;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
            this.ColumnID.Width = 2;
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.DataPropertyName = "Height";
            this.ColumnHeight.HeaderText = "Lartësia (Tekstura)";
            this.ColumnHeight.Name = "ColumnHeight";
            this.ColumnHeight.Width = 70;
            // 
            // ColumnWidth
            // 
            this.ColumnWidth.DataPropertyName = "Width";
            this.ColumnWidth.HeaderText = "Gjërësia";
            this.ColumnWidth.Name = "ColumnWidth";
            this.ColumnWidth.Width = 70;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.HeaderText = "Sasia";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.Width = 60;
            // 
            // ColumnFunction
            // 
            this.ColumnFunction.DataPropertyName = "Funksioni";
            this.ColumnFunction.HeaderText = "Funksion";
            this.ColumnFunction.Name = "ColumnFunction";
            this.ColumnFunction.Width = 80;
            // 
            // ColumnComment
            // 
            this.ColumnComment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnComment.DataPropertyName = "Comment";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnComment.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnComment.HeaderText = "Komenti";
            this.ColumnComment.Name = "ColumnComment";
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Fshi";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.Text = "Fshi";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 40;
            // 
            // FormFrontDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 270);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DataGridViewDimensions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFrontDimensions";
            this.ShowInTaskbar = false;
            this.Text = "Front";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLesonitDimensions_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDimensions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DataGridViewDimensions;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}