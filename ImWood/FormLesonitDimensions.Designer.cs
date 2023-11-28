namespace ImWood
{
    partial class FormLesonitDimensions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLesonitDimensions));
            this.BtnPrint = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DataGridViewDimensions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
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
            this.BtnPrint.Location = new System.Drawing.Point(252, 237);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(230, 27);
            this.BtnPrint.TabIndex = 12;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Location = new System.Drawing.Point(12, 237);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(234, 27);
            this.BtnAdd.TabIndex = 11;
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
            this.DataGridViewDimensions.Location = new System.Drawing.Point(12, 29);
            this.DataGridViewDimensions.Name = "DataGridViewDimensions";
            this.DataGridViewDimensions.ReadOnly = true;
            this.DataGridViewDimensions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridViewDimensions.RowTemplate.Height = 20;
            this.DataGridViewDimensions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewDimensions.Size = new System.Drawing.Size(470, 202);
            this.DataGridViewDimensions.TabIndex = 10;
            this.DataGridViewDimensions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewDimensions_CellClick);
            this.DataGridViewDimensions.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridViewDimensions_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Lesonit";
            // 
            // ColumnID
            // 
            this.ColumnID.DataPropertyName = "ID";
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 2;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            this.ColumnID.Width = 2;
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.DataPropertyName = "Height";
            this.ColumnHeight.HeaderText = "Lartësia (Tekstura)";
            this.ColumnHeight.Name = "ColumnHeight";
            this.ColumnHeight.ReadOnly = true;
            this.ColumnHeight.Width = 70;
            // 
            // ColumnWidth
            // 
            this.ColumnWidth.DataPropertyName = "Width";
            this.ColumnWidth.HeaderText = "Gjërësia";
            this.ColumnWidth.Name = "ColumnWidth";
            this.ColumnWidth.ReadOnly = true;
            this.ColumnWidth.Width = 70;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.DataPropertyName = "Quantity";
            this.ColumnQuantity.HeaderText = "Sasia";
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.ReadOnly = true;
            this.ColumnQuantity.Width = 60;
            // 
            // ColumnFunction
            // 
            this.ColumnFunction.DataPropertyName = "Funksioni";
            this.ColumnFunction.HeaderText = "Pozicion";
            this.ColumnFunction.Name = "ColumnFunction";
            this.ColumnFunction.ReadOnly = true;
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
            this.ColumnComment.ReadOnly = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Fshi";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Text = "Fshi";
            this.ColumnDelete.UseColumnTextForButtonValue = true;
            this.ColumnDelete.Width = 40;
            // 
            // FormLesonitDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DataGridViewDimensions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLesonitDimensions";
            this.ShowInTaskbar = false;
            this.Text = "Lesonit";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLesonitDimensions_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDimensions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridView DataGridViewDimensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
    }
}