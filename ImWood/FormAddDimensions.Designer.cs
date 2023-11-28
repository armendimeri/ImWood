namespace ImWood
{
    partial class FormAddDimensions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddDimensions));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxKant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbBoxType = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.TxtBoxFunction = new System.Windows.Forms.TextBox();
            this.LblFunction = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxKant2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lartësia (Tekstura)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBoxWidth
            // 
            this.TxtBoxWidth.Location = new System.Drawing.Point(103, 98);
            this.TxtBoxWidth.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TxtBoxWidth.Name = "TxtBoxWidth";
            this.TxtBoxWidth.Size = new System.Drawing.Size(88, 25);
            this.TxtBoxWidth.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gjërësia:";
            // 
            // TxtBoxHeight
            // 
            this.TxtBoxHeight.Location = new System.Drawing.Point(103, 65);
            this.TxtBoxHeight.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TxtBoxHeight.Name = "TxtBoxHeight";
            this.TxtBoxHeight.Size = new System.Drawing.Size(88, 25);
            this.TxtBoxHeight.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sasia:";
            // 
            // TxtBoxQuantity
            // 
            this.TxtBoxQuantity.Location = new System.Drawing.Point(103, 131);
            this.TxtBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TxtBoxQuantity.Name = "TxtBoxQuantity";
            this.TxtBoxQuantity.Size = new System.Drawing.Size(88, 25);
            this.TxtBoxQuantity.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kant 1:";
            // 
            // TxtBoxKant
            // 
            this.TxtBoxKant.Location = new System.Drawing.Point(102, 164);
            this.TxtBoxKant.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TxtBoxKant.Name = "TxtBoxKant";
            this.TxtBoxKant.Size = new System.Drawing.Size(88, 25);
            this.TxtBoxKant.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tipi:";
            // 
            // CmbBoxType
            // 
            this.CmbBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBoxType.FormattingEnabled = true;
            this.CmbBoxType.Items.AddRange(new object[] {
            "Front",
            "Konstrukti",
            "Fioka",
            "Polica",
            "Lesonit"});
            this.CmbBoxType.Location = new System.Drawing.Point(103, 22);
            this.CmbBoxType.Name = "CmbBoxType";
            this.CmbBoxType.Size = new System.Drawing.Size(88, 25);
            this.CmbBoxType.TabIndex = 0;
            this.CmbBoxType.SelectedIndexChanged += new System.EventHandler(this.CmbBoxType_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(54, 281);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(155, 38);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "Shto";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // TxtBoxFunction
            // 
            this.TxtBoxFunction.Location = new System.Drawing.Point(102, 230);
            this.TxtBoxFunction.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TxtBoxFunction.MaxLength = 10;
            this.TxtBoxFunction.Name = "TxtBoxFunction";
            this.TxtBoxFunction.Size = new System.Drawing.Size(89, 25);
            this.TxtBoxFunction.TabIndex = 6;
            // 
            // LblFunction
            // 
            this.LblFunction.AutoSize = true;
            this.LblFunction.Location = new System.Drawing.Point(33, 233);
            this.LblFunction.Name = "LblFunction";
            this.LblFunction.Size = new System.Drawing.Size(64, 17);
            this.LblFunction.TabIndex = 9;
            this.LblFunction.Text = "Funksioni:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kant 2:";
            // 
            // TxtBoxKant2
            // 
            this.TxtBoxKant2.Location = new System.Drawing.Point(103, 197);
            this.TxtBoxKant2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.TxtBoxKant2.Name = "TxtBoxKant2";
            this.TxtBoxKant2.Size = new System.Drawing.Size(88, 25);
            this.TxtBoxKant2.TabIndex = 5;
            // 
            // FormAddDimensions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 328);
            this.Controls.Add(this.LblFunction);
            this.Controls.Add(this.TxtBoxFunction);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CmbBoxType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtBoxKant2);
            this.Controls.Add(this.TxtBoxKant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtBoxQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtBoxWidth);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddDimensions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shto Dimenzion";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAddDimensions_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxKant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbBoxType;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtBoxFunction;
        private System.Windows.Forms.Label LblFunction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBoxKant2;
    }
}