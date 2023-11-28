namespace ImWood
{
    partial class FormAsk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAsk));
            this.BtnYes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnYes
            // 
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnYes.Location = new System.Drawing.Point(78, 75);
            this.BtnYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(100, 35);
            this.BtnYes.TabIndex = 0;
            this.BtnYes.Text = "Yes";
            this.BtnYes.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(322, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LblMessage
            // 
            this.LblMessage.Location = new System.Drawing.Point(13, 9);
            this.LblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(474, 52);
            this.LblMessage.TabIndex = 1;
            this.LblMessage.Text = "label1";
            this.LblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 124);
            this.ControlBox = false;
            this.Controls.Add(this.LblMessage);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnYes);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAsk";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAsk";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LblMessage;
    }
}