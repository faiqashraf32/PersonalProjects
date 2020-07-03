namespace Donde
{
    partial class New_Save_Location
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
            this.txtLoco = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLoco
            // 
            this.txtLoco.Font = new System.Drawing.Font("Arial", 12F);
            this.txtLoco.Location = new System.Drawing.Point(88, 87);
            this.txtLoco.Name = "txtLoco";
            this.txtLoco.Size = new System.Drawing.Size(191, 26);
            this.txtLoco.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSave.Location = new System.Drawing.Point(141, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 26);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(124, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Location Name:";
            // 
            // New_Save_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtLoco);
            this.Name = "New_Save_Location";
            this.Text = "New_Save_Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoco;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}