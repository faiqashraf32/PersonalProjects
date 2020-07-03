namespace Sell_listinggenerator
{
    partial class Shoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shoes));
            this.label13 = new System.Windows.Forms.Label();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.lstAll = new System.Windows.Forms.ListBox();
            this.txtOutDes3 = new System.Windows.Forms.TextBox();
            this.txtOutDes2 = new System.Windows.Forms.TextBox();
            this.txtOutDes1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutDes5 = new System.Windows.Forms.TextBox();
            this.txtOutDes4 = new System.Windows.Forms.TextBox();
            this.btnTory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F);
            this.label13.Location = new System.Drawing.Point(130, 366);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 18);
            this.label13.TabIndex = 55;
            this.label13.Text = "UPC:";
            // 
            // txtUPC
            // 
            this.txtUPC.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUPC.Location = new System.Drawing.Point(178, 360);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(154, 26);
            this.txtUPC.TabIndex = 54;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(269, 447);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 51;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(641, 462);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 52;
            this.btnPrint.Text = "Submit";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(796, 462);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 53;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(153, 447);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 50;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // lstAll
            // 
            this.lstAll.FormattingEnabled = true;
            this.lstAll.Location = new System.Drawing.Point(533, 64);
            this.lstAll.Name = "lstAll";
            this.lstAll.Size = new System.Drawing.Size(396, 381);
            this.lstAll.TabIndex = 49;
            // 
            // txtOutDes3
            // 
            this.txtOutDes3.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOutDes3.Location = new System.Drawing.Point(88, 182);
            this.txtOutDes3.Name = "txtOutDes3";
            this.txtOutDes3.Size = new System.Drawing.Size(332, 26);
            this.txtOutDes3.TabIndex = 48;
            // 
            // txtOutDes2
            // 
            this.txtOutDes2.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOutDes2.Location = new System.Drawing.Point(88, 144);
            this.txtOutDes2.Name = "txtOutDes2";
            this.txtOutDes2.Size = new System.Drawing.Size(332, 26);
            this.txtOutDes2.TabIndex = 47;
            // 
            // txtOutDes1
            // 
            this.txtOutDes1.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOutDes1.Location = new System.Drawing.Point(87, 107);
            this.txtOutDes1.Name = "txtOutDes1";
            this.txtOutDes1.Size = new System.Drawing.Size(333, 26);
            this.txtOutDes1.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(204, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 18);
            this.label7.TabIndex = 45;
            this.label7.Text = "Description:";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemName.Location = new System.Drawing.Point(111, 18);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(680, 26);
            this.txtItemName.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 43;
            this.label1.Text = "Item Name:";
            // 
            // txtOutDes5
            // 
            this.txtOutDes5.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOutDes5.Location = new System.Drawing.Point(88, 260);
            this.txtOutDes5.Name = "txtOutDes5";
            this.txtOutDes5.Size = new System.Drawing.Size(332, 26);
            this.txtOutDes5.TabIndex = 57;
            // 
            // txtOutDes4
            // 
            this.txtOutDes4.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOutDes4.Location = new System.Drawing.Point(88, 222);
            this.txtOutDes4.Name = "txtOutDes4";
            this.txtOutDes4.Size = new System.Drawing.Size(332, 26);
            this.txtOutDes4.TabIndex = 56;
            // 
            // btnTory
            // 
            this.btnTory.Location = new System.Drawing.Point(192, 311);
            this.btnTory.Name = "btnTory";
            this.btnTory.Size = new System.Drawing.Size(104, 23);
            this.btnTory.TabIndex = 58;
            this.btnTory.Text = "Tory Burch Shoe";
            this.btnTory.UseVisualStyleBackColor = true;
            this.btnTory.Click += new System.EventHandler(this.btnTory_Click);
            // 
            // Shoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 503);
            this.Controls.Add(this.btnTory);
            this.Controls.Add(this.txtOutDes5);
            this.Controls.Add(this.txtOutDes4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.lstAll);
            this.Controls.Add(this.txtOutDes3);
            this.Controls.Add(this.txtOutDes2);
            this.Controls.Add(this.txtOutDes1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shoes";
            this.Text = "Shoes";
            this.Load += new System.EventHandler(this.Shoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ListBox lstAll;
        private System.Windows.Forms.TextBox txtOutDes3;
        private System.Windows.Forms.TextBox txtOutDes2;
        private System.Windows.Forms.TextBox txtOutDes1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutDes5;
        private System.Windows.Forms.TextBox txtOutDes4;
        private System.Windows.Forms.Button btnTory;
    }
}