namespace Donde
{
    partial class Delete_an_Item
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLoco = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUPC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbL2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Location Name:";
            // 
            // cbLoco
            // 
            this.cbLoco.Font = new System.Drawing.Font("Arial", 12F);
            this.cbLoco.FormattingEnabled = true;
            this.cbLoco.Location = new System.Drawing.Point(154, 43);
            this.cbLoco.Name = "cbLoco";
            this.cbLoco.Size = new System.Drawing.Size(219, 26);
            this.cbLoco.TabIndex = 17;
            this.cbLoco.SelectedIndexChanged += new System.EventHandler(this.cbLoco_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(30, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Item Name:";
            // 
            // cbItems
            // 
            this.cbItems.Font = new System.Drawing.Font("Arial", 12F);
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(154, 95);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(651, 26);
            this.cbItems.TabIndex = 19;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Arial", 12F);
            this.btnDelete.Location = new System.Drawing.Point(360, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 26);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSave.Location = new System.Drawing.Point(356, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(33, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(126, 308);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(81, 26);
            this.txtQuantity.TabIndex = 26;
            // 
            // txtUPC
            // 
            this.txtUPC.Font = new System.Drawing.Font("Arial", 12F);
            this.txtUPC.Location = new System.Drawing.Point(126, 268);
            this.txtUPC.Name = "txtUPC";
            this.txtUPC.Size = new System.Drawing.Size(467, 26);
            this.txtUPC.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(33, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 24;
            this.label4.Text = "UPC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.Location = new System.Drawing.Point(33, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Arial", 12F);
            this.txtItemName.Location = new System.Drawing.Point(126, 228);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(467, 26);
            this.txtItemName.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(341, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Delete an Item:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(353, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 18);
            this.label7.TabIndex = 29;
            this.label7.Text = "Edit an Item:";
            // 
            // cbL2
            // 
            this.cbL2.Font = new System.Drawing.Font("Arial", 12F);
            this.cbL2.FormattingEnabled = true;
            this.cbL2.Location = new System.Drawing.Point(126, 352);
            this.cbL2.Name = "cbL2";
            this.cbL2.Size = new System.Drawing.Size(285, 26);
            this.cbL2.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(33, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "Stored At:";
            // 
            // Delete_an_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 436);
            this.Controls.Add(this.cbL2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUPC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbLoco);
            this.Controls.Add(this.label1);
            this.Name = "Delete_an_Item";
            this.Text = "Edit/Delete an Item";
            this.Load += new System.EventHandler(this.Delete_an_Item_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLoco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUPC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbL2;
        private System.Windows.Forms.Label label8;
    }
}