namespace List
{
    partial class Change_Save_Location
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
            this.btnSave = new System.Windows.Forms.Button();
            this.labelupc = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(287, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelupc
            // 
            this.labelupc.AutoSize = true;
            this.labelupc.Font = new System.Drawing.Font("Arial", 12F);
            this.labelupc.Location = new System.Drawing.Point(262, 27);
            this.labelupc.Name = "labelupc";
            this.labelupc.Size = new System.Drawing.Size(119, 18);
            this.labelupc.TabIndex = 49;
            this.labelupc.Text = "New Save Path:";
            // 
            // txtNew
            // 
            this.txtNew.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNew.Location = new System.Drawing.Point(62, 73);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(566, 26);
            this.txtNew.TabIndex = 50;
            // 
            // Change_Save_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 196);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelupc);
            this.Controls.Add(this.txtNew);
            this.Name = "Change_Save_Location";
            this.Text = "Change_Save_Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelupc;
        private System.Windows.Forms.TextBox txtNew;
    }
}