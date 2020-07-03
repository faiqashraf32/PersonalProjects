namespace FaiqRewards
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
            this.txtActNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lb5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLisNo = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblPts = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setPointsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doublePointsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rewardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbDou1 = new System.Windows.Forms.Label();
            this.lbDo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtActNo
            // 
            this.txtActNo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActNo.Location = new System.Drawing.Point(104, 49);
            this.txtActNo.Name = "txtActNo";
            this.txtActNo.Size = new System.Drawing.Size(100, 26);
            this.txtActNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(25, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loyalty #:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(94, 104);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Arial", 12F);
            this.lb5.Location = new System.Drawing.Point(39, 153);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(49, 18);
            this.lb5.TabIndex = 3;
            this.lb5.Text = "- - - - -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(25, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Listings #:";
            // 
            // txtLisNo
            // 
            this.txtLisNo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLisNo.Location = new System.Drawing.Point(110, 220);
            this.txtLisNo.Name = "txtLisNo";
            this.txtLisNo.Size = new System.Drawing.Size(100, 26);
            this.txtLisNo.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(94, 262);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblPts
            // 
            this.lblPts.AutoSize = true;
            this.lblPts.Font = new System.Drawing.Font("Arial", 12F);
            this.lblPts.Location = new System.Drawing.Point(177, 153);
            this.lblPts.Name = "lblPts";
            this.lblPts.Size = new System.Drawing.Size(49, 18);
            this.lblPts.TabIndex = 7;
            this.lblPts.Text = "- - - - -";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPointsToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // setPointsToolStripMenuItem
            // 
            this.setPointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem1,
            this.setPointsToolStripMenuItem1,
            this.doublePointsToolStripMenuItem1});
            this.setPointsToolStripMenuItem.Name = "setPointsToolStripMenuItem";
            this.setPointsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.setPointsToolStripMenuItem.Text = "Options";
            this.setPointsToolStripMenuItem.Click += new System.EventHandler(this.setPointsToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.resetToolStripMenuItem1.Text = "Reset";
            this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem1_Click);
            // 
            // setPointsToolStripMenuItem1
            // 
            this.setPointsToolStripMenuItem1.Name = "setPointsToolStripMenuItem1";
            this.setPointsToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.setPointsToolStripMenuItem1.Text = "Set Points";
            this.setPointsToolStripMenuItem1.Click += new System.EventHandler(this.setPointsToolStripMenuItem1_Click);
            // 
            // doublePointsToolStripMenuItem1
            // 
            this.doublePointsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem1,
            this.disableToolStripMenuItem1});
            this.doublePointsToolStripMenuItem1.Name = "doublePointsToolStripMenuItem1";
            this.doublePointsToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.doublePointsToolStripMenuItem1.Text = "Double Points";
            // 
            // enableToolStripMenuItem1
            // 
            this.enableToolStripMenuItem1.Name = "enableToolStripMenuItem1";
            this.enableToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.enableToolStripMenuItem1.Text = "Enable";
            this.enableToolStripMenuItem1.Click += new System.EventHandler(this.enableToolStripMenuItem1_Click);
            // 
            // disableToolStripMenuItem1
            // 
            this.disableToolStripMenuItem1.Name = "disableToolStripMenuItem1";
            this.disableToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.disableToolStripMenuItem1.Text = "Disable";
            this.disableToolStripMenuItem1.Click += new System.EventHandler(this.disableToolStripMenuItem1_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rewardsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.resetToolStripMenuItem.Text = "View";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // rewardsToolStripMenuItem
            // 
            this.rewardsToolStripMenuItem.Name = "rewardsToolStripMenuItem";
            this.rewardsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.rewardsToolStripMenuItem.Text = "Rewards";
            this.rewardsToolStripMenuItem.Click += new System.EventHandler(this.rewardsToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // lbDou1
            // 
            this.lbDou1.AutoSize = true;
            this.lbDou1.Font = new System.Drawing.Font("Arial", 12F);
            this.lbDou1.Location = new System.Drawing.Point(39, 188);
            this.lbDou1.Name = "lbDou1";
            this.lbDou1.Size = new System.Drawing.Size(106, 18);
            this.lbDou1.TabIndex = 9;
            this.lbDou1.Text = "Double Points";
            // 
            // lbDo
            // 
            this.lbDo.AutoSize = true;
            this.lbDo.Font = new System.Drawing.Font("Arial", 12F);
            this.lbDo.Location = new System.Drawing.Point(177, 188);
            this.lbDo.Name = "lbDo";
            this.lbDo.Size = new System.Drawing.Size(49, 18);
            this.lbDo.TabIndex = 10;
            this.lbDo.Text = "- - - - -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 292);
            this.Controls.Add(this.lbDo);
            this.Controls.Add(this.lbDou1);
            this.Controls.Add(this.lblPts);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtLisNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtActNo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Faiq Loyalty";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtActNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLisNo;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblPts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label lbDou1;
        private System.Windows.Forms.Label lbDo;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setPointsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doublePointsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rewardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
    }
}

