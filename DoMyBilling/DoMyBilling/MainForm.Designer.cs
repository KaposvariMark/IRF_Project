namespace DoMyBilling
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.lbl_cName = new System.Windows.Forms.Label();
            this.lbl_taxID = new System.Windows.Forms.Label();
            this.lbl_cAddress2 = new System.Windows.Forms.Label();
            this.lbl_cAddress1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_companyName = new System.Windows.Forms.Label();
            this.lbl_companyAddress1 = new System.Windows.Forms.Label();
            this.lbl_companyAddress2 = new System.Windows.Forms.Label();
            this.lbl_companyTaxID = new System.Windows.Forms.Label();
            this.labelCompanyInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRecipientInfo = new System.Windows.Forms.Label();
            this.lbl_recipientTaxID = new System.Windows.Forms.Label();
            this.lbl_recipientAddress2 = new System.Windows.Forms.Label();
            this.lbl_recipientAddress1 = new System.Windows.Forms.Label();
            this.lbl_recipientName = new System.Windows.Forms.Label();
            this.lbl_rName = new System.Windows.Forms.Label();
            this.lbl_rTaxID = new System.Windows.Forms.Label();
            this.lbl_rAddress2 = new System.Windows.Forms.Label();
            this.lbl_rAddress1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importCSVToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.importCSVToolStripMenuItem.Text = "Import CSV";
            this.importCSVToolStripMenuItem.Click += new System.EventHandler(this.importCSVToolStripMenuItem_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 27);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(100, 20);
            this.textBoxPath.TabIndex = 1;
            // 
            // lbl_cName
            // 
            this.lbl_cName.AutoSize = true;
            this.lbl_cName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_cName.Location = new System.Drawing.Point(30, 75);
            this.lbl_cName.Name = "lbl_cName";
            this.lbl_cName.Size = new System.Drawing.Size(88, 16);
            this.lbl_cName.TabIndex = 2;
            this.lbl_cName.Text = "Company Name:";
            // 
            // lbl_taxID
            // 
            this.lbl_taxID.AutoSize = true;
            this.lbl_taxID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_taxID.Location = new System.Drawing.Point(30, 225);
            this.lbl_taxID.Name = "lbl_taxID";
            this.lbl_taxID.Size = new System.Drawing.Size(71, 16);
            this.lbl_taxID.TabIndex = 3;
            this.lbl_taxID.Text = "Tax Number:";
            // 
            // lbl_cAddress2
            // 
            this.lbl_cAddress2.AutoSize = true;
            this.lbl_cAddress2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_cAddress2.Location = new System.Drawing.Point(30, 175);
            this.lbl_cAddress2.Name = "lbl_cAddress2";
            this.lbl_cAddress2.Size = new System.Drawing.Size(79, 16);
            this.lbl_cAddress2.TabIndex = 4;
            this.lbl_cAddress2.Text = "Street and No.:";
            // 
            // lbl_cAddress1
            // 
            this.lbl_cAddress1.AutoSize = true;
            this.lbl_cAddress1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_cAddress1.Location = new System.Drawing.Point(30, 125);
            this.lbl_cAddress1.Name = "lbl_cAddress1";
            this.lbl_cAddress1.Size = new System.Drawing.Size(96, 16);
            this.lbl_cAddress1.TabIndex = 5;
            this.lbl_cAddress1.Text = "Postcode and City:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelCompanyInfo);
            this.panel1.Controls.Add(this.lbl_companyTaxID);
            this.panel1.Controls.Add(this.lbl_companyAddress2);
            this.panel1.Controls.Add(this.lbl_companyAddress1);
            this.panel1.Controls.Add(this.lbl_companyName);
            this.panel1.Controls.Add(this.lbl_cName);
            this.panel1.Controls.Add(this.lbl_taxID);
            this.panel1.Controls.Add(this.lbl_cAddress2);
            this.panel1.Controls.Add(this.lbl_cAddress1);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 300);
            this.panel1.TabIndex = 6;
            // 
            // lbl_companyName
            // 
            this.lbl_companyName.AutoSize = true;
            this.lbl_companyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_companyName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_companyName.Location = new System.Drawing.Point(135, 75);
            this.lbl_companyName.Name = "lbl_companyName";
            this.lbl_companyName.Size = new System.Drawing.Size(68, 18);
            this.lbl_companyName.TabIndex = 6;
            this.lbl_companyName.Text = "PlaceHolder";
            // 
            // lbl_companyAddress1
            // 
            this.lbl_companyAddress1.AutoSize = true;
            this.lbl_companyAddress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_companyAddress1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_companyAddress1.Location = new System.Drawing.Point(135, 125);
            this.lbl_companyAddress1.Name = "lbl_companyAddress1";
            this.lbl_companyAddress1.Size = new System.Drawing.Size(68, 18);
            this.lbl_companyAddress1.TabIndex = 7;
            this.lbl_companyAddress1.Text = "PlaceHolder";
            // 
            // lbl_companyAddress2
            // 
            this.lbl_companyAddress2.AutoSize = true;
            this.lbl_companyAddress2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_companyAddress2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_companyAddress2.Location = new System.Drawing.Point(135, 175);
            this.lbl_companyAddress2.Name = "lbl_companyAddress2";
            this.lbl_companyAddress2.Size = new System.Drawing.Size(68, 18);
            this.lbl_companyAddress2.TabIndex = 8;
            this.lbl_companyAddress2.Text = "PlaceHolder";
            // 
            // lbl_companyTaxID
            // 
            this.lbl_companyTaxID.AutoSize = true;
            this.lbl_companyTaxID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_companyTaxID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_companyTaxID.Location = new System.Drawing.Point(135, 225);
            this.lbl_companyTaxID.Name = "lbl_companyTaxID";
            this.lbl_companyTaxID.Size = new System.Drawing.Size(68, 18);
            this.lbl_companyTaxID.TabIndex = 9;
            this.lbl_companyTaxID.Text = "PlaceHolder";
            // 
            // labelCompanyInfo
            // 
            this.labelCompanyInfo.AutoSize = true;
            this.labelCompanyInfo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCompanyInfo.Location = new System.Drawing.Point(153, 25);
            this.labelCompanyInfo.Name = "labelCompanyInfo";
            this.labelCompanyInfo.Size = new System.Drawing.Size(67, 20);
            this.labelCompanyInfo.TabIndex = 10;
            this.labelCompanyInfo.Text = "Seller Info:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelRecipientInfo);
            this.panel2.Controls.Add(this.lbl_recipientTaxID);
            this.panel2.Controls.Add(this.lbl_recipientAddress2);
            this.panel2.Controls.Add(this.lbl_recipientAddress1);
            this.panel2.Controls.Add(this.lbl_recipientName);
            this.panel2.Controls.Add(this.lbl_rName);
            this.panel2.Controls.Add(this.lbl_rTaxID);
            this.panel2.Controls.Add(this.lbl_rAddress2);
            this.panel2.Controls.Add(this.lbl_rAddress1);
            this.panel2.Location = new System.Drawing.Point(368, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 300);
            this.panel2.TabIndex = 7;
            // 
            // labelRecipientInfo
            // 
            this.labelRecipientInfo.AutoSize = true;
            this.labelRecipientInfo.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRecipientInfo.Location = new System.Drawing.Point(132, 25);
            this.labelRecipientInfo.Name = "labelRecipientInfo";
            this.labelRecipientInfo.Size = new System.Drawing.Size(88, 20);
            this.labelRecipientInfo.TabIndex = 10;
            this.labelRecipientInfo.Text = "Recipient Info:";
            // 
            // lbl_recipientTaxID
            // 
            this.lbl_recipientTaxID.AutoSize = true;
            this.lbl_recipientTaxID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_recipientTaxID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_recipientTaxID.Location = new System.Drawing.Point(135, 225);
            this.lbl_recipientTaxID.Name = "lbl_recipientTaxID";
            this.lbl_recipientTaxID.Size = new System.Drawing.Size(68, 18);
            this.lbl_recipientTaxID.TabIndex = 9;
            this.lbl_recipientTaxID.Text = "PlaceHolder";
            // 
            // lbl_recipientAddress2
            // 
            this.lbl_recipientAddress2.AutoSize = true;
            this.lbl_recipientAddress2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_recipientAddress2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_recipientAddress2.Location = new System.Drawing.Point(135, 175);
            this.lbl_recipientAddress2.Name = "lbl_recipientAddress2";
            this.lbl_recipientAddress2.Size = new System.Drawing.Size(68, 18);
            this.lbl_recipientAddress2.TabIndex = 8;
            this.lbl_recipientAddress2.Text = "PlaceHolder";
            // 
            // lbl_recipientAddress1
            // 
            this.lbl_recipientAddress1.AutoSize = true;
            this.lbl_recipientAddress1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_recipientAddress1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_recipientAddress1.Location = new System.Drawing.Point(135, 125);
            this.lbl_recipientAddress1.Name = "lbl_recipientAddress1";
            this.lbl_recipientAddress1.Size = new System.Drawing.Size(68, 18);
            this.lbl_recipientAddress1.TabIndex = 7;
            this.lbl_recipientAddress1.Text = "PlaceHolder";
            // 
            // lbl_recipientName
            // 
            this.lbl_recipientName.AutoSize = true;
            this.lbl_recipientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_recipientName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_recipientName.Location = new System.Drawing.Point(135, 75);
            this.lbl_recipientName.Name = "lbl_recipientName";
            this.lbl_recipientName.Size = new System.Drawing.Size(68, 18);
            this.lbl_recipientName.TabIndex = 6;
            this.lbl_recipientName.Text = "PlaceHolder";
            // 
            // lbl_rName
            // 
            this.lbl_rName.AutoSize = true;
            this.lbl_rName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_rName.Location = new System.Drawing.Point(30, 75);
            this.lbl_rName.Name = "lbl_rName";
            this.lbl_rName.Size = new System.Drawing.Size(88, 16);
            this.lbl_rName.TabIndex = 2;
            this.lbl_rName.Text = "Company Name:";
            // 
            // lbl_rTaxID
            // 
            this.lbl_rTaxID.AutoSize = true;
            this.lbl_rTaxID.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_rTaxID.Location = new System.Drawing.Point(30, 225);
            this.lbl_rTaxID.Name = "lbl_rTaxID";
            this.lbl_rTaxID.Size = new System.Drawing.Size(71, 16);
            this.lbl_rTaxID.TabIndex = 3;
            this.lbl_rTaxID.Text = "Tax Number:";
            // 
            // lbl_rAddress2
            // 
            this.lbl_rAddress2.AutoSize = true;
            this.lbl_rAddress2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_rAddress2.Location = new System.Drawing.Point(30, 175);
            this.lbl_rAddress2.Name = "lbl_rAddress2";
            this.lbl_rAddress2.Size = new System.Drawing.Size(79, 16);
            this.lbl_rAddress2.TabIndex = 4;
            this.lbl_rAddress2.Text = "Street and No.:";
            // 
            // lbl_rAddress1
            // 
            this.lbl_rAddress1.AutoSize = true;
            this.lbl_rAddress1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_rAddress1.Location = new System.Drawing.Point(30, 125);
            this.lbl_rAddress1.Name = "lbl_rAddress1";
            this.lbl_rAddress1.Size = new System.Drawing.Size(96, 16);
            this.lbl_rAddress1.TabIndex = 5;
            this.lbl_rAddress1.Text = "Postcode and City:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label lbl_cName;
        private System.Windows.Forms.Label lbl_taxID;
        private System.Windows.Forms.Label lbl_cAddress2;
        private System.Windows.Forms.Label lbl_cAddress1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_companyTaxID;
        private System.Windows.Forms.Label lbl_companyAddress2;
        private System.Windows.Forms.Label lbl_companyAddress1;
        private System.Windows.Forms.Label lbl_companyName;
        private System.Windows.Forms.Label labelCompanyInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRecipientInfo;
        private System.Windows.Forms.Label lbl_recipientTaxID;
        private System.Windows.Forms.Label lbl_recipientAddress2;
        private System.Windows.Forms.Label lbl_recipientAddress1;
        private System.Windows.Forms.Label lbl_recipientName;
        private System.Windows.Forms.Label lbl_rName;
        private System.Windows.Forms.Label lbl_rTaxID;
        private System.Windows.Forms.Label lbl_rAddress2;
        private System.Windows.Forms.Label lbl_rAddress1;
    }
}

