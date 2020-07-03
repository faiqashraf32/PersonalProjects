namespace Reform
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
            this.txtNew = new System.Windows.Forms.TextBox();
            this.btnConv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PB1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(21, 54);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(100, 20);
            this.txtNew.TabIndex = 0;
            // 
            // btnConv
            // 
            this.btnConv.Location = new System.Drawing.Point(77, 106);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(75, 23);
            this.btnConv.TabIndex = 1;
            this.btnConv.Text = "Convert";
            this.btnConv.UseVisualStyleBackColor = true;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New File Name";
            // 
            // txtInc
            // 
            this.txtInc.Location = new System.Drawing.Point(140, 54);
            this.txtInc.Name = "txtInc";
            this.txtInc.Size = new System.Drawing.Size(39, 20);
            this.txtInc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number:";
            // 
            // PB1
            // 
            this.PB1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB1.Location = new System.Drawing.Point(244, 24);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(115, 127);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB1.TabIndex = 5;
            this.PB1.TabStop = false;
            this.PB1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 180);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConv);
            this.Controls.Add(this.txtNew);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Button btnConv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PB1;
    }
}

