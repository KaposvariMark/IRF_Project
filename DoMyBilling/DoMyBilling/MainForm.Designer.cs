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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.lbl_cName = new System.Windows.Forms.Label();
            this.lbl_taxID = new System.Windows.Forms.Label();
            this.lbl_cAddress2 = new System.Windows.Forms.Label();
            this.lbl_cAddress1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_cTax = new System.Windows.Forms.TextBox();
            this.textBox_cAddress2 = new System.Windows.Forms.TextBox();
            this.textBox_cAddress1 = new System.Windows.Forms.TextBox();
            this.textBox_cName = new System.Windows.Forms.TextBox();
            this.labelCompanyInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_rTax = new System.Windows.Forms.TextBox();
            this.textBox_rAddress2 = new System.Windows.Forms.TextBox();
            this.textBox_rAddress1 = new System.Windows.Forms.TextBox();
            this.textBox_rName = new System.Windows.Forms.TextBox();
            this.labelRecipientInfo = new System.Windows.Forms.Label();
            this.lbl_rName = new System.Windows.Forms.Label();
            this.lbl_rTaxID = new System.Windows.Forms.Label();
            this.lbl_rAddress2 = new System.Windows.Forms.Label();
            this.lbl_rAddress1 = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.lbl_timerTime = new System.Windows.Forms.Label();
            this.lbl_timerDate = new System.Windows.Forms.Label();
            this.btn_GenerateExcel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(1009, 24);
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
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.importCSVToolStripMenuItem.Text = "Import CSV";
            this.importCSVToolStripMenuItem.Click += new System.EventHandler(this.importCSVToolStripMenuItem_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 39);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(537, 20);
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
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox_cTax);
            this.panel1.Controls.Add(this.textBox_cAddress2);
            this.panel1.Controls.Add(this.textBox_cAddress1);
            this.panel1.Controls.Add(this.textBox_cName);
            this.panel1.Controls.Add(this.labelCompanyInfo);
            this.panel1.Controls.Add(this.lbl_cName);
            this.panel1.Controls.Add(this.lbl_taxID);
            this.panel1.Controls.Add(this.lbl_cAddress2);
            this.panel1.Controls.Add(this.lbl_cAddress1);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 290);
            this.panel1.TabIndex = 6;
            // 
            // textBox_cTax
            // 
            this.textBox_cTax.Location = new System.Drawing.Point(132, 224);
            this.textBox_cTax.Name = "textBox_cTax";
            this.textBox_cTax.Size = new System.Drawing.Size(215, 20);
            this.textBox_cTax.TabIndex = 13;
            // 
            // textBox_cAddress2
            // 
            this.textBox_cAddress2.Location = new System.Drawing.Point(132, 174);
            this.textBox_cAddress2.Name = "textBox_cAddress2";
            this.textBox_cAddress2.Size = new System.Drawing.Size(215, 20);
            this.textBox_cAddress2.TabIndex = 12;
            // 
            // textBox_cAddress1
            // 
            this.textBox_cAddress1.Location = new System.Drawing.Point(132, 124);
            this.textBox_cAddress1.Name = "textBox_cAddress1";
            this.textBox_cAddress1.Size = new System.Drawing.Size(215, 20);
            this.textBox_cAddress1.TabIndex = 11;
            // 
            // textBox_cName
            // 
            this.textBox_cName.Location = new System.Drawing.Point(132, 74);
            this.textBox_cName.Name = "textBox_cName";
            this.textBox_cName.Size = new System.Drawing.Size(215, 20);
            this.textBox_cName.TabIndex = 10;
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
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox_rTax);
            this.panel2.Controls.Add(this.textBox_rAddress2);
            this.panel2.Controls.Add(this.textBox_rAddress1);
            this.panel2.Controls.Add(this.textBox_rName);
            this.panel2.Controls.Add(this.labelRecipientInfo);
            this.panel2.Controls.Add(this.lbl_rName);
            this.panel2.Controls.Add(this.lbl_rTaxID);
            this.panel2.Controls.Add(this.lbl_rAddress2);
            this.panel2.Controls.Add(this.lbl_rAddress1);
            this.panel2.Location = new System.Drawing.Point(393, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 290);
            this.panel2.TabIndex = 7;
            // 
            // textBox_rTax
            // 
            this.textBox_rTax.Location = new System.Drawing.Point(132, 224);
            this.textBox_rTax.Name = "textBox_rTax";
            this.textBox_rTax.Size = new System.Drawing.Size(215, 20);
            this.textBox_rTax.TabIndex = 17;
            // 
            // textBox_rAddress2
            // 
            this.textBox_rAddress2.Location = new System.Drawing.Point(132, 174);
            this.textBox_rAddress2.Name = "textBox_rAddress2";
            this.textBox_rAddress2.Size = new System.Drawing.Size(215, 20);
            this.textBox_rAddress2.TabIndex = 16;
            // 
            // textBox_rAddress1
            // 
            this.textBox_rAddress1.Location = new System.Drawing.Point(132, 124);
            this.textBox_rAddress1.Name = "textBox_rAddress1";
            this.textBox_rAddress1.Size = new System.Drawing.Size(215, 20);
            this.textBox_rAddress1.TabIndex = 15;
            // 
            // textBox_rName
            // 
            this.textBox_rName.Location = new System.Drawing.Point(132, 74);
            this.textBox_rName.Name = "textBox_rName";
            this.textBox_rName.Size = new System.Drawing.Size(215, 20);
            this.textBox_rName.TabIndex = 14;
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
            // lbl_rName
            // 
            this.lbl_rName.AutoSize = true;
            this.lbl_rName.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_rName.Location = new System.Drawing.Point(30, 75);
            this.lbl_rName.Name = "lbl_rName";
            this.lbl_rName.Size = new System.Drawing.Size(85, 16);
            this.lbl_rName.TabIndex = 2;
            this.lbl_rName.Text = "Recipient Name:";
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
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // lbl_timerTime
            // 
            this.lbl_timerTime.AutoSize = true;
            this.lbl_timerTime.Location = new System.Drawing.Point(941, 42);
            this.lbl_timerTime.Name = "lbl_timerTime";
            this.lbl_timerTime.Size = new System.Drawing.Size(53, 13);
            this.lbl_timerTime.TabIndex = 8;
            this.lbl_timerTime.Text = "óó:pp:mm";
            // 
            // lbl_timerDate
            // 
            this.lbl_timerDate.AutoSize = true;
            this.lbl_timerDate.Location = new System.Drawing.Point(857, 42);
            this.lbl_timerDate.Name = "lbl_timerDate";
            this.lbl_timerDate.Size = new System.Drawing.Size(61, 13);
            this.lbl_timerDate.TabIndex = 9;
            this.lbl_timerDate.Text = "éééé:hh:nn";
            // 
            // btn_GenerateExcel
            // 
            this.btn_GenerateExcel.Location = new System.Drawing.Point(467, 372);
            this.btn_GenerateExcel.Name = "btn_GenerateExcel";
            this.btn_GenerateExcel.Size = new System.Drawing.Size(100, 30);
            this.btn_GenerateExcel.TabIndex = 10;
            this.btn_GenerateExcel.Text = "Generate";
            this.btn_GenerateExcel.UseVisualStyleBackColor = true;
            this.btn_GenerateExcel.Click += new System.EventHandler(this.btn_GenerateExcel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(774, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 290);
            this.listBox1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 411);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_GenerateExcel);
            this.Controls.Add(this.lbl_timerDate);
            this.Controls.Add(this.lbl_timerTime);
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
        private System.Windows.Forms.Label labelCompanyInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelRecipientInfo;
        private System.Windows.Forms.Label lbl_rName;
        private System.Windows.Forms.Label lbl_rTaxID;
        private System.Windows.Forms.Label lbl_rAddress2;
        private System.Windows.Forms.Label lbl_rAddress1;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label lbl_timerTime;
        private System.Windows.Forms.Label lbl_timerDate;
        private System.Windows.Forms.TextBox textBox_cTax;
        private System.Windows.Forms.TextBox textBox_cAddress2;
        private System.Windows.Forms.TextBox textBox_cAddress1;
        private System.Windows.Forms.TextBox textBox_cName;
        private System.Windows.Forms.TextBox textBox_rTax;
        private System.Windows.Forms.TextBox textBox_rAddress2;
        private System.Windows.Forms.TextBox textBox_rAddress1;
        private System.Windows.Forms.TextBox textBox_rName;
        private System.Windows.Forms.Button btn_GenerateExcel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

