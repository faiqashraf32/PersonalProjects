namespace DropShipBoom
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBoxNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxN = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boxNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(153, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipping";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F);
            this.btnAdd.Location = new System.Drawing.Point(156, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(57, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Number of Boxes";
            // 
            // lblBoxNo
            // 
            this.lblBoxNo.AutoSize = true;
            this.lblBoxNo.Font = new System.Drawing.Font("Arial", 12F);
            this.lblBoxNo.Location = new System.Drawing.Point(250, 121);
            this.lblBoxNo.Name = "lblBoxNo";
            this.lblBoxNo.Size = new System.Drawing.Size(23, 18);
            this.lblBoxNo.TabIndex = 5;
            this.lblBoxNo.Text = "---";
            this.lblBoxNo.Click += new System.EventHandler(this.lblBoxNo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(57, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Boxes made:";
            // 
            // txtBoxN
            // 
            this.txtBoxN.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBoxN.Location = new System.Drawing.Point(223, 166);
            this.txtBoxN.MaxLength = 4;
            this.txtBoxN.Name = "txtBoxN";
            this.txtBoxN.Size = new System.Drawing.Size(100, 26);
            this.txtBoxN.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.inventoryFilesToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.refreshCountToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(408, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boxNumberToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.fileToolStripMenuItem.Text = "Shipping Files";
            // 
            // boxNumberToolStripMenuItem
            // 
            this.boxNumberToolStripMenuItem.Name = "boxNumberToolStripMenuItem";
            this.boxNumberToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.boxNumberToolStripMenuItem.Text = "Box Number";
            this.boxNumberToolStripMenuItem.Click += new System.EventHandler(this.boxNumberToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // inventoryFilesToolStripMenuItem
            // 
            this.inventoryFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.auditSpreadsheetToolStripMenuItem,
            this.sourcesToolStripMenuItem});
            this.inventoryFilesToolStripMenuItem.Name = "inventoryFilesToolStripMenuItem";
            this.inventoryFilesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.inventoryFilesToolStripMenuItem.Text = "Inventory Files";
            // 
            // auditSpreadsheetToolStripMenuItem
            // 
            this.auditSpreadsheetToolStripMenuItem.Name = "auditSpreadsheetToolStripMenuItem";
            this.auditSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.auditSpreadsheetToolStripMenuItem.Text = "Audit Spreadsheet";
            this.auditSpreadsheetToolStripMenuItem.Click += new System.EventHandler(this.auditSpreadsheetToolStripMenuItem_Click);
            // 
            // sourcesToolStripMenuItem
            // 
            this.sourcesToolStripMenuItem.Name = "sourcesToolStripMenuItem";
            this.sourcesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sourcesToolStripMenuItem.Text = "Sources";
            this.sourcesToolStripMenuItem.Click += new System.EventHandler(this.sourcesToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfBoxesToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // numberOfBoxesToolStripMenuItem
            // 
            this.numberOfBoxesToolStripMenuItem.Name = "numberOfBoxesToolStripMenuItem";
            this.numberOfBoxesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.numberOfBoxesToolStripMenuItem.Text = "Number of Boxes";
            this.numberOfBoxesToolStripMenuItem.Click += new System.EventHandler(this.numberOfBoxesToolStripMenuItem_Click);
            // 
            // refreshCountToolStripMenuItem
            // 
            this.refreshCountToolStripMenuItem.Name = "refreshCountToolStripMenuItem";
            this.refreshCountToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.refreshCountToolStripMenuItem.Text = "Refresh Count";
            this.refreshCountToolStripMenuItem.Click += new System.EventHandler(this.refreshCountToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 348);
            this.Controls.Add(this.txtBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBoxNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "DropShipBoom -- A Drop Shipper\'s Dream Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBoxNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxN;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boxNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditSpreadsheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberOfBoxesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshCountToolStripMenuItem;
    }
}

