namespace ImWood
{
    partial class FormProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProject));
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.BtnSelectClient = new System.Windows.Forms.Button();
            this.LblClient = new System.Windows.Forms.Label();
            this.TxtBoxComment = new System.Windows.Forms.TextBox();
            this.DatePickerExpireDate = new System.Windows.Forms.DateTimePicker();
            this.TxtBoxFrontMaterial = new System.Windows.Forms.TextBox();
            this.TxtBoxKonstruktMaterial = new System.Windows.Forms.TextBox();
            this.BtnElements = new System.Windows.Forms.Button();
            this.BtnFinishProject = new System.Windows.Forms.Button();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxPolica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxFioka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBoxLesonit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAccessories = new System.Windows.Forms.Button();
            this.BtnLesonit = new System.Windows.Forms.Button();
            this.BtnFioka = new System.Windows.Forms.Button();
            this.BtnPolica = new System.Windows.Forms.Button();
            this.BtnFront = new System.Windows.Forms.Button();
            this.BtnKonstrukt = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnProjectPDF = new System.Windows.Forms.Button();
            this.BtnADD = new System.Windows.Forms.Button();
            this.groupBoxClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClient.Controls.Add(this.BtnSelectClient);
            this.groupBoxClient.Controls.Add(this.LblClient);
            this.groupBoxClient.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxClient.Location = new System.Drawing.Point(13, 14);
            this.groupBoxClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxClient.Size = new System.Drawing.Size(305, 136);
            this.groupBoxClient.TabIndex = 0;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Klienti";
            // 
            // BtnSelectClient
            // 
            this.BtnSelectClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelectClient.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSelectClient.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnSelectClient.Location = new System.Drawing.Point(38, 91);
            this.BtnSelectClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSelectClient.Name = "BtnSelectClient";
            this.BtnSelectClient.Size = new System.Drawing.Size(224, 35);
            this.BtnSelectClient.TabIndex = 2;
            this.BtnSelectClient.Text = "Selekto Klient...";
            this.BtnSelectClient.UseVisualStyleBackColor = false;
            this.BtnSelectClient.Click += new System.EventHandler(this.BtnSelectClient_Click);
            // 
            // LblClient
            // 
            this.LblClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblClient.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblClient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblClient.Location = new System.Drawing.Point(7, 31);
            this.LblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(289, 52);
            this.LblClient.TabIndex = 0;
            this.LblClient.Text = "NUK KENI SELEKTUAR KLIENT";
            this.LblClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtBoxComment
            // 
            this.TxtBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxComment.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.TxtBoxComment.Location = new System.Drawing.Point(86, 440);
            this.TxtBoxComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxComment.MaxLength = 1000;
            this.TxtBoxComment.Multiline = true;
            this.TxtBoxComment.Name = "TxtBoxComment";
            this.TxtBoxComment.Size = new System.Drawing.Size(230, 116);
            this.TxtBoxComment.TabIndex = 10;
            // 
            // DatePickerExpireDate
            // 
            this.DatePickerExpireDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePickerExpireDate.CustomFormat = "dd, MMMM, yyyy";
            this.DatePickerExpireDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.DatePickerExpireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerExpireDate.Location = new System.Drawing.Point(86, 171);
            this.DatePickerExpireDate.Name = "DatePickerExpireDate";
            this.DatePickerExpireDate.Size = new System.Drawing.Size(230, 27);
            this.DatePickerExpireDate.TabIndex = 3;
            // 
            // TxtBoxFrontMaterial
            // 
            this.TxtBoxFrontMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxFrontMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.TxtBoxFrontMaterial.Location = new System.Drawing.Point(86, 245);
            this.TxtBoxFrontMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxFrontMaterial.MaxLength = 500;
            this.TxtBoxFrontMaterial.Name = "TxtBoxFrontMaterial";
            this.TxtBoxFrontMaterial.Size = new System.Drawing.Size(230, 29);
            this.TxtBoxFrontMaterial.TabIndex = 5;
            // 
            // TxtBoxKonstruktMaterial
            // 
            this.TxtBoxKonstruktMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxKonstruktMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.TxtBoxKonstruktMaterial.Location = new System.Drawing.Point(86, 284);
            this.TxtBoxKonstruktMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxKonstruktMaterial.MaxLength = 500;
            this.TxtBoxKonstruktMaterial.Name = "TxtBoxKonstruktMaterial";
            this.TxtBoxKonstruktMaterial.Size = new System.Drawing.Size(230, 29);
            this.TxtBoxKonstruktMaterial.TabIndex = 6;
            // 
            // BtnElements
            // 
            this.BtnElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnElements.BackColor = System.Drawing.SystemColors.Control;
            this.BtnElements.Enabled = false;
            this.BtnElements.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnElements.Location = new System.Drawing.Point(338, 482);
            this.BtnElements.Name = "BtnElements";
            this.BtnElements.Size = new System.Drawing.Size(151, 36);
            this.BtnElements.TabIndex = 17;
            this.BtnElements.Text = "Elementet";
            this.BtnElements.UseVisualStyleBackColor = false;
            this.BtnElements.Click += new System.EventHandler(this.BtnElements_Click);
            // 
            // BtnFinishProject
            // 
            this.BtnFinishProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFinishProject.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFinishProject.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BtnFinishProject.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnFinishProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnFinishProject.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFinishProject.Location = new System.Drawing.Point(338, 524);
            this.BtnFinishProject.Name = "BtnFinishProject";
            this.BtnFinishProject.Size = new System.Drawing.Size(308, 34);
            this.BtnFinishProject.TabIndex = 19;
            this.BtnFinishProject.Text = "Mbaro Projektin";
            this.BtnFinishProject.UseVisualStyleBackColor = false;
            this.BtnFinishProject.Click += new System.EventHandler(this.BtnFinishProject_Click);
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxName.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.TxtBoxName.Location = new System.Drawing.Point(86, 210);
            this.TxtBoxName.MaxLength = 50;
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(230, 29);
            this.TxtBoxName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Konstrukt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Front:";
            // 
            // TxtBoxPolica
            // 
            this.TxtBoxPolica.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxPolica.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.TxtBoxPolica.Location = new System.Drawing.Point(86, 326);
            this.TxtBoxPolica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxPolica.MaxLength = 500;
            this.TxtBoxPolica.Name = "TxtBoxPolica";
            this.TxtBoxPolica.Size = new System.Drawing.Size(230, 29);
            this.TxtBoxPolica.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Polica:";
            // 
            // TxtBoxFioka
            // 
            this.TxtBoxFioka.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxFioka.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.TxtBoxFioka.Location = new System.Drawing.Point(86, 365);
            this.TxtBoxFioka.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxFioka.MaxLength = 500;
            this.TxtBoxFioka.Name = "TxtBoxFioka";
            this.TxtBoxFioka.Size = new System.Drawing.Size(230, 29);
            this.TxtBoxFioka.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fioka:";
            // 
            // TxtBoxLesonit
            // 
            this.TxtBoxLesonit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBoxLesonit.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F, System.Drawing.FontStyle.Bold);
            this.TxtBoxLesonit.Location = new System.Drawing.Point(86, 404);
            this.TxtBoxLesonit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtBoxLesonit.MaxLength = 500;
            this.TxtBoxLesonit.Name = "TxtBoxLesonit";
            this.TxtBoxLesonit.Size = new System.Drawing.Size(230, 29);
            this.TxtBoxLesonit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lesonit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Afati:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Artikulli:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Koment:";
            // 
            // BtnAccessories
            // 
            this.BtnAccessories.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccessories.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAccessories.Enabled = false;
            this.BtnAccessories.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAccessories.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnAccessories.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAccessories.Location = new System.Drawing.Point(338, 346);
            this.BtnAccessories.Name = "BtnAccessories";
            this.BtnAccessories.Size = new System.Drawing.Size(308, 60);
            this.BtnAccessories.TabIndex = 16;
            this.BtnAccessories.Text = "Aksesorët";
            this.BtnAccessories.UseVisualStyleBackColor = false;
            this.BtnAccessories.Click += new System.EventHandler(this.BtnAccessories_Click);
            // 
            // BtnLesonit
            // 
            this.BtnLesonit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLesonit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnLesonit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnLesonit.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnLesonit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLesonit.Location = new System.Drawing.Point(338, 280);
            this.BtnLesonit.Name = "BtnLesonit";
            this.BtnLesonit.Size = new System.Drawing.Size(308, 60);
            this.BtnLesonit.TabIndex = 15;
            this.BtnLesonit.Text = "Lesonit";
            this.BtnLesonit.UseVisualStyleBackColor = false;
            this.BtnLesonit.Click += new System.EventHandler(this.BtnLesonit_Click);
            // 
            // BtnFioka
            // 
            this.BtnFioka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFioka.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFioka.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFioka.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnFioka.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFioka.Location = new System.Drawing.Point(338, 214);
            this.BtnFioka.Name = "BtnFioka";
            this.BtnFioka.Size = new System.Drawing.Size(308, 60);
            this.BtnFioka.TabIndex = 14;
            this.BtnFioka.Text = "Fioka";
            this.BtnFioka.UseVisualStyleBackColor = false;
            this.BtnFioka.Click += new System.EventHandler(this.BtnFioka_Click);
            // 
            // BtnPolica
            // 
            this.BtnPolica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPolica.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPolica.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnPolica.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnPolica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPolica.Location = new System.Drawing.Point(338, 148);
            this.BtnPolica.Name = "BtnPolica";
            this.BtnPolica.Size = new System.Drawing.Size(308, 60);
            this.BtnPolica.TabIndex = 13;
            this.BtnPolica.Text = "Polica";
            this.BtnPolica.UseVisualStyleBackColor = false;
            this.BtnPolica.Click += new System.EventHandler(this.BtnPolica_Click);
            // 
            // BtnFront
            // 
            this.BtnFront.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFront.BackColor = System.Drawing.SystemColors.Control;
            this.BtnFront.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnFront.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnFront.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFront.Location = new System.Drawing.Point(338, 12);
            this.BtnFront.Name = "BtnFront";
            this.BtnFront.Size = new System.Drawing.Size(308, 60);
            this.BtnFront.TabIndex = 11;
            this.BtnFront.Text = "Front";
            this.BtnFront.UseVisualStyleBackColor = false;
            this.BtnFront.Click += new System.EventHandler(this.BtnFront_Click);
            // 
            // BtnKonstrukt
            // 
            this.BtnKonstrukt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKonstrukt.BackColor = System.Drawing.SystemColors.Control;
            this.BtnKonstrukt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnKonstrukt.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnKonstrukt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnKonstrukt.Location = new System.Drawing.Point(338, 80);
            this.BtnKonstrukt.Name = "BtnKonstrukt";
            this.BtnKonstrukt.Size = new System.Drawing.Size(308, 60);
            this.BtnKonstrukt.TabIndex = 12;
            this.BtnKonstrukt.Text = "Konstrukt";
            this.BtnKonstrukt.UseVisualStyleBackColor = false;
            this.BtnKonstrukt.Click += new System.EventHandler(this.BtnKonstrukt_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.BtnSave.Image = global::ImWood.Properties.Resources.SaveIcon24;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSave.Location = new System.Drawing.Point(495, 482);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(151, 36);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Ruaj";
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnProjectPDF
            // 
            this.BtnProjectPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnProjectPDF.BackColor = System.Drawing.SystemColors.Control;
            this.BtnProjectPDF.Enabled = false;
            this.BtnProjectPDF.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnProjectPDF.Image = global::ImWood.Properties.Resources.documentIcon58;
            this.BtnProjectPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnProjectPDF.Location = new System.Drawing.Point(414, 412);
            this.BtnProjectPDF.Name = "BtnProjectPDF";
            this.BtnProjectPDF.Size = new System.Drawing.Size(232, 60);
            this.BtnProjectPDF.TabIndex = 16;
            this.BtnProjectPDF.Text = "Projekti (PDF)";
            this.BtnProjectPDF.UseVisualStyleBackColor = false;
            this.BtnProjectPDF.Click += new System.EventHandler(this.BtnProjectPDF_Click);
            // 
            // BtnADD
            // 
            this.BtnADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnADD.BackColor = System.Drawing.SystemColors.Control;
            this.BtnADD.Enabled = false;
            this.BtnADD.Font = new System.Drawing.Font("Segoe UI Semibold", 25.25F, System.Drawing.FontStyle.Bold);
            this.BtnADD.Image = global::ImWood.Properties.Resources._1448297897_document_new;
            this.BtnADD.Location = new System.Drawing.Point(338, 412);
            this.BtnADD.Name = "BtnADD";
            this.BtnADD.Size = new System.Drawing.Size(70, 60);
            this.BtnADD.TabIndex = 20;
            this.BtnADD.UseVisualStyleBackColor = false;
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 564);
            this.Controls.Add(this.BtnADD);
            this.Controls.Add(this.TxtBoxComment);
            this.Controls.Add(this.TxtBoxName);
            this.Controls.Add(this.DatePickerExpireDate);
            this.Controls.Add(this.TxtBoxFrontMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxLesonit);
            this.Controls.Add(this.TxtBoxFioka);
            this.Controls.Add(this.TxtBoxPolica);
            this.Controls.Add(this.TxtBoxKonstruktMaterial);
            this.Controls.Add(this.BtnFinishProject);
            this.Controls.Add(this.BtnProjectPDF);
            this.Controls.Add(this.BtnAccessories);
            this.Controls.Add(this.BtnLesonit);
            this.Controls.Add(this.BtnFioka);
            this.Controls.Add(this.BtnPolica);
            this.Controls.Add(this.BtnFront);
            this.Controls.Add(this.BtnKonstrukt);
            this.Controls.Add(this.BtnElements);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.groupBoxClient);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projekt i Ri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProject_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormProject_KeyDown);
            this.groupBoxClient.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClient;
        private System.Windows.Forms.Button BtnSelectClient;
        private System.Windows.Forms.Label LblClient;
        private System.Windows.Forms.TextBox TxtBoxComment;
        private System.Windows.Forms.DateTimePicker DatePickerExpireDate;
        private System.Windows.Forms.TextBox TxtBoxFrontMaterial;
        private System.Windows.Forms.TextBox TxtBoxKonstruktMaterial;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnElements;
        private System.Windows.Forms.Button BtnAccessories;
        private System.Windows.Forms.Button BtnFinishProject;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxPolica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxFioka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBoxLesonit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnKonstrukt;
        private System.Windows.Forms.Button BtnFront;
        private System.Windows.Forms.Button BtnPolica;
        private System.Windows.Forms.Button BtnFioka;
        private System.Windows.Forms.Button BtnLesonit;
        private System.Windows.Forms.Button BtnProjectPDF;
        private System.Windows.Forms.Button BtnADD;
    }
}