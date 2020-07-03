using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace moveafile
{
    public partial class Form1 : Form
    {
        
        OpenFileDialog ofd = new OpenFileDialog();
        string oldfilename;
        string newfilename;
        string path;
        string npath;
        string save;

        int x = 0;

        bool PL1= true;
        bool PL2 = false;
        bool PL3 = false;
        bool PL4 = false;
        bool PL5 = false;
        bool PL6 = false;
        bool PL7 = false;
        bool PL8 = false;
        bool PL9 = false;
        bool PL10 = false;
        bool PL11 = false;
        bool PL12 = false;

        string S1;
        string S2;
        string S3;
        string S4;
        string S5;
        string S6;
        string S7;
        string S8;
        string S9;
        string S10;
        string S11;
        string S12;

        string PH1 ;
        string PH2 ;
        string PH3 ;
        string PH4 ;
        string PH5 ;
        string PH6 ;
        string PH7 ;
        string PH8 ;
        string PH9 ;
        string PH10 ;
        string PH11 ;
        string PH12 ;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        public void grind21()
        {


            //System.Diagnostics.Process.Start(path);
          // if (PL1 == true)
                oldfilename = PH1;
                newfilename = txtNew.Text;
                path = S1;
                npath = path.Replace(oldfilename, newfilename + " 1" + ".Jpeg");

                //     oldfilename = txtFileName.Text;
                //   newfilename = txtNew.Text;
                // path = txtSource.Text;
                //npath = path.Replace(oldfilename, newfilename + "2" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(path);
                image.Save(npath, System.Drawing.Imaging.ImageFormat.Jpeg);
                //PL2 = false;
                //PL3 = true;


                oldfilename = PH2;
                newfilename = txtNew.Text;
                path = S2;
                npath = path.Replace(oldfilename, newfilename + ".Jpeg");

                //     oldfilename = txtFileName.Text;
                //   newfilename = txtNew.Text;
                // path = txtSource.Text;
                //npath = path.Replace(oldfilename, newfilename + "2" + ".Jpeg");
                System.Drawing.Image image2 = System.Drawing.Image.FromFile(path);
                image2.Save(npath, System.Drawing.Imaging.ImageFormat.Jpeg);
              //  PL2 = false;
               // PL3 = true;
            //}
        }
        public void grind()
        {


            //System.Diagnostics.Process.Start(path);

            
               

            //if (PL2 == true)
            //{
            //  oldfilename = pb2.ImageLocation;
            //newfilename = txtNew.Text;
            //path = txtSource.Text;
            //npath = path.Replace(oldfilename, newfilename + "2" + ".Jpeg");
            //PL2 = false;
            //PL3 = true;
            //}

            //MessageBox.Show(npath);



        }

        private void pb1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p1 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb1.ImageLocation = ofd.FileName;
                this.Controls.Add(p1);
                PH1 = pb1.ImageLocation;
                S1 = txtSource.Text;
                PL1 = true;
            }

            //MessageBox.Show(S1);
            //  else if (pb1.ImageLocation != "")
            //  {
            //      
            //  }

        }



        private void btnChange_Click(object sender, EventArgs e)
        {

            
                oldfilename = PH1;
                newfilename = txtNew.Text;
                path = S1;
            //npath = path.Replace(oldfilename, newfilename + " 1" + ".Jpeg");
                npath.Substring(0,8);
            npath = path + newfilename + " 1";
            MessageBox.Show(npath);
            System.Drawing.Image image = System.Drawing.Image.FromFile(npath);
                image.Save(npath, System.Drawing.Imaging.ImageFormat.Jpeg);
                //
            


            //oldfilename = txtFileName.Text;
            //newfilename = txtNew.Text;
            //path = txtSource.Text;
            //npath = path.Replace(oldfilename, newfilename + ".Jpeg");
            // (o) MessageBox.Show(npath);

            //System.Drawing.Image image = System.Drawing.Image.FromFile(path);

            //image.Save(npath, System.Drawing.Imaging.ImageFormat.Jpeg);
            // oldfilename = txtFileName.Text;
            // newfilename = txtNew.Text;

            //grind();
            //MessageBox.Show(S1);
            //MessageBox.Show(S2);


        }

        private void pb2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p2 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb2.ImageLocation = ofd.FileName;
                this.Controls.Add(p2);
                PH2= pb2.ImageLocation;
                S2 = txtSource.Text;
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p3 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb3.ImageLocation = ofd.FileName;
                this.Controls.Add(p3);
            }
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p4 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb4.ImageLocation = ofd.FileName;
                this.Controls.Add(p4);
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p5 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb5.ImageLocation = ofd.FileName;
                this.Controls.Add(p5);
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p6 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb6.ImageLocation = ofd.FileName;
                this.Controls.Add(p6);
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p7 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb7.ImageLocation = ofd.FileName;
                this.Controls.Add(p7);
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p8 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb8.ImageLocation = ofd.FileName;
                this.Controls.Add(p8);
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p99 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb9.ImageLocation = ofd.FileName;
                this.Controls.Add(p99);
            }
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p10 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb10.ImageLocation = ofd.FileName;
                this.Controls.Add(p10);
            }
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p111 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb11.ImageLocation = ofd.FileName;
                this.Controls.Add(p111);
            }
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                PictureBox p12 = new PictureBox();
                txtSource.Text = ofd.FileName;
                txtFileName.Text = ofd.SafeFileName;
                pb12.ImageLocation = ofd.FileName;
                this.Controls.Add(p12);
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PH1);
        }

        public void old()

        {
            //System.Drawing.Image image = System.Drawing.Image.FromFile(@"C:\Users\Faiq\Pictures\test\IMG_1939.JPG");
            //image.Save(@"C:\Users\Faiq\Pictures\test\here\works.png", System.Drawing.Imaging.ImageFormat.Png);
            //image.Save(@"C:\Users\Faiq\Pictures\test\here\works.Bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            //image.Save(@"C:\Users\Faiq\Pictures\test\here\works.Gif", System.Drawing.Imaging.ImageFormat.Gif);
            //image.Save(@"C:\Users\Faiq\Pictures\test\here\works.Tiff", System.Drawing.Imaging.ImageFormat.Tiff);

            //oldfilename = ofd.FileName;
            //newfilename = txtNew.Text;
            //path = txtSource.Text;

            //System.IO.File.Move(@"C:\Users\Faiq\Pictures\test\IMG_1939.JPG", @"C: \Users\Faiq\Pictures\test\" + newfilename);
            //System.IO.File.Move(oldfilename, @"C: \Users\Faiq\Pictures\test\" + newfilename);
            //System.IO.File.Move(oldfilename, newfilename);
            //txtFileName.Text = newfilename;
            //oldfilename = "";
        }

        private void btnCon1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
