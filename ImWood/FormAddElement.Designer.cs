namespace ImWood
{
    partial class FormAddElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddElement));
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDimensions = new System.Windows.Forms.Button();
            this.BtnAccessories = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.CmbBoxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBoxDesign = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(100, 14);
            this.TxtBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(199, 27);
            this.TxtBoxName.TabIndex = 0;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(356, 12);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(299, 255);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 1;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(61, 162);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(107, 32);
            this.BtnBrowse.TabIndex = 3;
            this.BtnBrowse.Text = "Browse...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Emri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Foto:";
            // 
            // BtnDimensions
            // 
            this.BtnDimensions.Enabled = false;
            this.BtnDimensions.Location = new System.Drawing.Point(16, 287);
            this.BtnDimensions.Name = "BtnDimensions";
            this.BtnDimensions.Size = new System.Drawing.Size(221, 42);
            this.BtnDimensions.TabIndex = 5;
            this.BtnDimensions.Text = "Dimenzionet";
            this.BtnDimensions.UseVisualStyleBackColor = true;
            this.BtnDimensions.Click += new System.EventHandler(this.BtnDimensions_Click);
            // 
            // BtnAccessories
            // 
            this.BtnAccessories.Enabled = false;
            this.BtnAccessories.Location = new System.Drawing.Point(399, 287);
            this.BtnAccessories.Name = "BtnAccessories";
            this.BtnAccessories.Size = new System.Drawing.Size(221, 42);
            this.BtnAccessories.TabIndex = 6;
            this.BtnAccessories.Text = "Aksesor";
            this.BtnAccessories.UseVisualStyleBackColor = true;
            this.BtnAccessories.Click += new System.EventHandler(this.BtnAccessories_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(17, 225);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(221, 42);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.Text = "RUAJ";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CmbBoxCategory
            // 
            this.CmbBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxCategory.FormattingEnabled = true;
            this.CmbBoxCategory.Location = new System.Drawing.Point(100, 52);
            this.CmbBoxCategory.Name = "CmbBoxCategory";
            this.CmbBoxCategory.Size = new System.Drawing.Size(199, 28);
            this.CmbBoxCategory.TabIndex = 1;
            this.CmbBoxCategory.SelectedIndexChanged += new System.EventHandler(this.CmbBoxCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategoria:";
            // 
            // CmbBoxDesign
            // 
            this.CmbBoxDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxDesign.FormattingEnabled = true;
            this.CmbBoxDesign.Location = new System.Drawing.Point(100, 90);
            this.CmbBoxDesign.Name = "CmbBoxDesign";
            this.CmbBoxDesign.Size = new System.Drawing.Size(199, 28);
            this.CmbBoxDesign.TabIndex = 2;
            this.CmbBoxDesign.SelectedIndexChanged += new System.EventHandler(this.CmbBoxCategory_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Design:";
            // 
            // FormAddElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbBoxDesign);
            this.Controls.Add(this.CmbBoxCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAccessories);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDimensions);
            this.Controls.Add(this.BtnBrowse);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.TxtBoxName);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddElement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shto Element";
            this.Load += new System.EventHandler(this.FormAddElement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDimensions;
        private System.Windows.Forms.Button BtnAccessories;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ComboBox CmbBoxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBoxDesign;
        private System.Windows.Forms.Label label4;
    }
}