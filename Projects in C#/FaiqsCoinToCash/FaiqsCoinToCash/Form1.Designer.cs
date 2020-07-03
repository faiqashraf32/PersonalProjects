namespace FaiqsCoinToCash
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
            this.lbDate = new System.Windows.Forms.Label();
            this.lbNewBal = new System.Windows.Forms.Label();
            this.msMe = new System.Windows.Forms.MenuStrip();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulkCoinDepositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepAm = new System.Windows.Forms.TextBox();
            this.lbD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtActBal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lbTransID = new System.Windows.Forms.Label();
            this.lstRecent = new System.Windows.Forms.ListBox();
            this.msMe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Arial", 12F);
            this.lbDate.Location = new System.Drawing.Point(136, 57);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(42, 18);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Date";
            // 
            // lbNewBal
            // 
            this.lbNewBal.AutoSize = true;
            this.lbNewBal.Font = new System.Drawing.Font("Arial", 12F);
            this.lbNewBal.Location = new System.Drawing.Point(241, 541);
            this.lbNewBal.Name = "lbNewBal";
            this.lbNewBal.Size = new System.Drawing.Size(13, 18);
            this.lbNewBal.TabIndex = 1;
            this.lbNewBal.Text = "-";
            // 
            // msMe
            // 
            this.msMe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionToolStripMenuItem,
            this.bulkCoinDepositToolStripMenuItem});
            this.msMe.Location = new System.Drawing.Point(0, 0);
            this.msMe.Name = "msMe";
            this.msMe.Size = new System.Drawing.Size(948, 24);
            this.msMe.TabIndex = 2;
            this.msMe.Text = "menuStrip1";
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.functionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // bulkCoinDepositToolStripMenuItem
            // 
            this.bulkCoinDepositToolStripMenuItem.Name = "bulkCoinDepositToolStripMenuItem";
            this.bulkCoinDepositToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.bulkCoinDepositToolStripMenuItem.Text = "Bulk Coin Deposit";
            this.bulkCoinDepositToolStripMenuItem.Click += new System.EventHandler(this.bulkCoinDepositToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.Location = new System.Drawing.Point(143, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Faiq\'s Coin To Cash";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtActNo
            // 
            this.txtActNo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtActNo.Location = new System.Drawing.Point(156, 104);
            this.txtActNo.Name = "txtActNo";
            this.txtActNo.Size = new System.Drawing.Size(196, 26);
            this.txtActNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Account Number:";
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Arial", 12F);
            this.btnOpen.Location = new System.Drawing.Point(212, 149);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 33);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(23, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Deposit Amount:";
            // 
            // txtDepAm
            // 
            this.txtDepAm.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDepAm.Location = new System.Drawing.Point(156, 265);
            this.txtDepAm.Name = "txtDepAm";
            this.txtDepAm.Size = new System.Drawing.Size(196, 26);
            this.txtDepAm.TabIndex = 7;
            this.txtDepAm.TextChanged += new System.EventHandler(this.txtDepAm_TextChanged);
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Font = new System.Drawing.Font("Arial", 12F);
            this.lbD.Location = new System.Drawing.Point(153, 198);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(63, 18);
            this.lbD.TabIndex = 9;
            this.lbD.Text = "Deposit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(23, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Account Balance:";
            // 
            // txtActBal
            // 
            this.txtActBal.Font = new System.Drawing.Font("Arial", 12F);
            this.txtActBal.Location = new System.Drawing.Point(156, 310);
            this.txtActBal.Name = "txtActBal";
            this.txtActBal.Size = new System.Drawing.Size(196, 26);
            this.txtActBal.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F);
            this.label7.Location = new System.Drawing.Point(23, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Balance:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F);
            this.txtTotal.Location = new System.Drawing.Point(156, 353);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(196, 26);
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // cbPayment
            // 
            this.cbPayment.Font = new System.Drawing.Font("Arial", 12F);
            this.cbPayment.FormattingEnabled = true;
            this.cbPayment.Items.AddRange(new object[] {
            "Paid",
            "Payment Delayed",
            "Other (Enter) >>>"});
            this.cbPayment.Location = new System.Drawing.Point(156, 404);
            this.cbPayment.Name = "cbPayment";
            this.cbPayment.Size = new System.Drawing.Size(145, 26);
            this.cbPayment.TabIndex = 14;
            this.cbPayment.SelectedIndexChanged += new System.EventHandler(this.cbPayment_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F);
            this.label8.Location = new System.Drawing.Point(23, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Payment Status:";
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Arial", 12F);
            this.txtOther.Location = new System.Drawing.Point(307, 404);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(196, 26);
            this.txtOther.TabIndex = 16;
            // 
            // btnComplete
            // 
            this.btnComplete.Font = new System.Drawing.Font("Arial", 12F);
            this.btnComplete.Location = new System.Drawing.Point(199, 501);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(102, 33);
            this.btnComplete.TabIndex = 17;
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(23, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNotes.Location = new System.Drawing.Point(156, 453);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(196, 26);
            this.txtNotes.TabIndex = 18;
            // 
            // lbTransID
            // 
            this.lbTransID.AutoSize = true;
            this.lbTransID.Font = new System.Drawing.Font("Arial", 12F);
            this.lbTransID.Location = new System.Drawing.Point(153, 230);
            this.lbTransID.Name = "lbTransID";
            this.lbTransID.Size = new System.Drawing.Size(32, 18);
            this.lbTransID.TabIndex = 20;
            this.lbTransID.Text = "ID#";
            this.lbTransID.Click += new System.EventHandler(this.lbTransID_Click);
            // 
            // lstRecent
            // 
            this.lstRecent.Font = new System.Drawing.Font("Arial", 10F);
            this.lstRecent.FormattingEnabled = true;
            this.lstRecent.ItemHeight = 16;
            this.lstRecent.Location = new System.Drawing.Point(520, 33);
            this.lstRecent.Name = "lstRecent";
            this.lstRecent.Size = new System.Drawing.Size(416, 532);
            this.lstRecent.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 583);
            this.Controls.Add(this.lstRecent);
            this.Controls.Add(this.lbTransID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtActBal);
            this.Controls.Add(this.lbD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepAm);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtActNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNewBal);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.msMe);
            this.MainMenuStrip = this.msMe;
            this.Name = "Form1";
            this.Text = "Deposit Coin To Cash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMe.ResumeLayout(false);
            this.msMe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbNewBal;
        private System.Windows.Forms.MenuStrip msMe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtActNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepAm;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtActBal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ComboBox cbPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lbTransID;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ListBox lstRecent;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulkCoinDepositToolStripMenuItem;
    }
}

