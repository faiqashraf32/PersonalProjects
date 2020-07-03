namespace Sell_listinggenerator
{
    partial class Change
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(118, 79);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(773, 20);
            this.txtPath.TabIndex = 1;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Arial", 12F);
            this.lblQ.Location = new System.Drawing.Point(12, 81);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(85, 18);
            this.lblQ.TabIndex = 2;
            this.lblQ.Text = "Enter Path:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(427, 124);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 202);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.txtPath);
            this.Name = "Change";
            this.Text = "Change Path";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Button btnSave;
    }
}