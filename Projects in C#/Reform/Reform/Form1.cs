using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reform
{
    public partial class Form1 : Form
    {
        string loc;
        string ne;
        string name;
        public Form1()
        {
            InitializeComponent();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            name = txtNew.Text + "" + txtInc.Text;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox PB1 = new PictureBox();
                this.PB1.ImageLocation = ofd.FileName;
                loc = ofd.FileName;
                this.Controls.Add(this.PB1);
                //MessageBox.Show(loc);
                ne = loc.Replace(ofd.FileName, name + "\\"); 
                MessageBox.Show(ne);
            }
        }

        private void btnConv_Click(object sender, EventArgs e)
        {
            System.Drawing.Image image = System.Drawing.Image.FromFile(ne);
            image.Save(ne, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
