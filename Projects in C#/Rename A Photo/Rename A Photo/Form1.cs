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

namespace Rename_A_Photo
{
    public partial class Form1 : Form
    {
        string npath1, npath2, npath3, npath4, npath5, npath6, npath7, npath8, npath9, npath10, npath11, npath12;
        string name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12;
        bool o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12 = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            spath = txtPath.Text;
            MessageBox.Show("New save path is: " + spath);
            spa = true;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        string oldfilepath1, oldfilepath2, oldfilepath3, oldfilepath4, oldfilepath5, oldfilepath6, oldfilepath7, oldfilepath8, oldfilepath9, oldfilepath10, oldfilepath11, oldfilepath12;
        string oldfilename1, oldfilename2, oldfilename3, oldfilename4, oldfilename5, oldfilename6, oldfilename7, oldfilename8, oldfilename9, oldfilename10, oldfilename11, oldfilename12;
        string source1, source2, source3, source4, source5, source6, source7, source8, source9, source10, source11, source12;
        string spath;
        bool spa;
        string loco1, loco2, loco3, loco4, loco5, loco6, loco7, loco8, loco9, loco10, loco11, loco12;
        bool delete = false;
        OpenFileDialog ofd1 = new OpenFileDialog();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDelete.Checked == true)
            {
                delete = true;
                lbWill.Visible = true;
                lbwilln.Visible = false;
            }
            else if (cbDelete.Checked == false)
            {
                delete = false;
                lbWill.Visible = false;
                lbwilln.Visible = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    spath = folderDialog.SelectedPath.ToString();
                    MessageBox.Show("New save path is: "+spath);
                    spa = true;
                    txtPath.Text = spath;
                    // folderDialog.SelectedPath -- your result
                }
                else
                {
                    spath = "";
                    spa = false;
                }
            }
        }
        
        private void pb4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd4 = new OpenFileDialog();
            ofd4.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd4.ShowDialog() == DialogResult.OK)
            {
                PictureBox p4 = new PictureBox();
                pb4.ImageLocation = ofd4.FileName;
                this.Controls.Add(p4);
                source4 = pb4.ImageLocation;
                oldfilepath4 = ofd4.FileName;
                oldfilename4 = Path.GetFileName(oldfilepath4);
                o4 = true;
            }
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd5 = new OpenFileDialog();
            ofd5.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd5.ShowDialog() == DialogResult.OK)
            {
                PictureBox p5 = new PictureBox();
                pb5.ImageLocation = ofd5.FileName;
                this.Controls.Add(p5);
                source5 = pb5.ImageLocation;
                oldfilepath5 = ofd5.FileName;
                oldfilename5 = Path.GetFileName(oldfilepath5);
                o5 = true;
            }
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd6 = new OpenFileDialog();
            ofd6.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd6.ShowDialog() == DialogResult.OK)
            {
                PictureBox p6 = new PictureBox();
                pb6.ImageLocation = ofd6.FileName;
                this.Controls.Add(p6);
                source6 = pb6.ImageLocation;
                oldfilepath6 = ofd6.FileName;
                oldfilename6 = Path.GetFileName(oldfilepath6);
                o6 = true;
            }
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd7 = new OpenFileDialog();
            ofd7.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd7.ShowDialog() == DialogResult.OK)
            {
                PictureBox p7 = new PictureBox();
                pb7.ImageLocation = ofd7.FileName;
                this.Controls.Add(p7);
                source7 = pb7.ImageLocation;
                oldfilepath7 = ofd7.FileName;
                oldfilename7 = Path.GetFileName(oldfilepath7);
                o7 = true;
            }
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd8 = new OpenFileDialog();
            ofd8.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd8.ShowDialog() == DialogResult.OK)
            {
                PictureBox p8 = new PictureBox();
                pb8.ImageLocation = ofd8.FileName;
                this.Controls.Add(p8);
                source8 = pb8.ImageLocation;
                oldfilepath8 = ofd8.FileName;
                oldfilename8 = Path.GetFileName(oldfilepath8);
                o8 = true;
            }
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd9 = new OpenFileDialog();
            ofd9.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd9.ShowDialog() == DialogResult.OK)
            {
                PictureBox p9 = new PictureBox();
                pb9.ImageLocation = ofd9.FileName;
                this.Controls.Add(p9);
                source9 = pb9.ImageLocation;
                oldfilepath9 = ofd9.FileName;
                oldfilename9 = Path.GetFileName(oldfilepath9);
                o9 = true;
            }
        }

        private void pb10_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd10 = new OpenFileDialog();
            ofd10.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd10.ShowDialog() == DialogResult.OK)
            {
                PictureBox p10 = new PictureBox();
                pb10.ImageLocation = ofd10.FileName;
                this.Controls.Add(p10);
                source10 = pb10.ImageLocation;
                oldfilepath10 = ofd10.FileName;
                oldfilename10 = Path.GetFileName(oldfilepath10);
                o10 = true;
            }
        }

        private void pb11_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd11 = new OpenFileDialog();
            ofd11.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd11.ShowDialog() == DialogResult.OK)
            {
                PictureBox p11 = new PictureBox();
                pb11.ImageLocation = ofd11.FileName;
                this.Controls.Add(p11);
                source11 = pb11.ImageLocation;
                oldfilepath11 = ofd11.FileName;
                oldfilename11 = Path.GetFileName(oldfilepath11);
                o11 = true;
            }
        }

        private void pb12_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd12 = new OpenFileDialog();
            ofd12.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd12.ShowDialog() == DialogResult.OK)
            {
                PictureBox p12 = new PictureBox();
                pb12.ImageLocation = ofd12.FileName;
                this.Controls.Add(p12);
                source12 = pb12.ImageLocation;
                oldfilepath12 = ofd12.FileName;
                oldfilename12 = Path.GetFileName(oldfilepath12);
                o12 = true;
            }
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd3 = new OpenFileDialog();
            ofd3.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd3.ShowDialog() == DialogResult.OK)
            {
                PictureBox p3 = new PictureBox();
                pb3.ImageLocation = ofd3.FileName;
                this.Controls.Add(p3);
                source3 = pb3.ImageLocation;
                oldfilepath3 = ofd3.FileName;
                oldfilename3 = Path.GetFileName(oldfilepath3);
                o3 = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            grind();
        }

        public void grind()
        {

           if (o1==true && spa == true)
            {
                name1 = txtNew.Text;
                loco1 = spath +"/"+ name1 +" 1" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source1);
                image.Save(loco1, System.Drawing.Imaging.ImageFormat.Jpeg);
                pb1.Image = null;
                ofd1 = null;
               // MessageBox.Show("The file has been saved at: " + loco1);
                //MessageBox.Show(source1);
                //pb1.Image = null;
                //if (delete == true)
                //{
                //  System.IO.File.Delete(source1);
                //}
                //else if (delete == false)
                //{
                //  reset();
                //}
            }
            else if (o1 == true && spa == false)
            {
                name1 = txtNew.Text;
                npath1 = source1.Replace(oldfilename1, name1 + " 1" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source1);
                image.Save(npath1, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
                pb1.Image = null;
                ofd1 = null;
                // MessageBox.Show("The file has been saved at: " + npath1);
                //MessageBox.Show(source1);
                //pb1.Image = null;
                //if (delete == true)
                //{
                //  System.IO.File.Delete(source1);
                //}
                //else if (delete == false)
                //{
                //  reset();
                //}
            }
            if (o2 == true && spa == true)
            {
                name2 = txtNew.Text;
                loco2 = spath + "/" + name2 + " 2" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source2);
                image.Save(loco2, System.Drawing.Imaging.ImageFormat.Jpeg);
              //  MessageBox.Show("The file has been saved at: " + loco2);
            }
            else if (o2 == true && spa == false)
            {
                name2 = txtNew.Text;
                npath2 = source2.Replace(oldfilename2, name2 + " 2" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source2);
                image.Save(npath2, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
              //  MessageBox.Show("The file has been saved at: " + npath2);
            }
            if (o3 == true && spa == true)
            {
                name3 = txtNew.Text;
                loco3 = spath + "/" + name3 + " 3" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source3);
                image.Save(loco3, System.Drawing.Imaging.ImageFormat.Jpeg);
             //   MessageBox.Show("The file has been saved at: " + loco3);
            }
            else if (o3 == true && spa == false)
            {
                name3 = txtNew.Text;
                npath3 = source3.Replace(oldfilename3, name3 + " 3" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source3);
                image.Save(npath3, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
              //  MessageBox.Show("The file has been saved at: " + npath3);
            }
            if (o4 == true && spa == true)
            {
                name4 = txtNew.Text;
                loco4 = spath + "/" + name4 + " 4" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source4);
                image.Save(loco4, System.Drawing.Imaging.ImageFormat.Jpeg);
             //   MessageBox.Show("The file has been saved at: " + loco4);
            }
            else if (o4 == true && spa == false)
            {
                name4 = txtNew.Text;
                npath4 = source4.Replace(oldfilename4, name4 + " 4" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source4);
                image.Save(npath4, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
             //   MessageBox.Show("The file has been saved at: " + npath4);
            }
            if (o5 == true && spa == true)
            {
                name5 = txtNew.Text;
                loco5 = spath + "/" + name5 + " 5" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source5);
                image.Save(loco5, System.Drawing.Imaging.ImageFormat.Jpeg);
            //    MessageBox.Show("The file has been saved at: " + loco5);
            }
            else if (o5 == true && spa == false)
            {
                name5 = txtNew.Text;
                npath5 = source5.Replace(oldfilename5, name5 + " 5" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source5);
                image.Save(npath5, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
            //    MessageBox.Show("The file has been saved at: " + npath5);
            }
            if (o6 == true && spa == true)
            {
                name6 = txtNew.Text;
                loco6 = spath + "/" + name6 + " 6" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source6);
                image.Save(loco6, System.Drawing.Imaging.ImageFormat.Jpeg);
             //   MessageBox.Show("The file has been saved at: " + loco6);
            }
            else if (o6 == true && spa == false)
            {
                name6 = txtNew.Text;
                npath6 = source6.Replace(oldfilename6, name6 + " 6" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source6);
                image.Save(npath6, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
              //  MessageBox.Show("The file has been saved at: " + npath6);
            }
            if (o7 == true && spa == true)
            {
                name7 = txtNew.Text;
                loco7 = spath + "/" + name7 + " 7" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source7);
                image.Save(loco7, System.Drawing.Imaging.ImageFormat.Jpeg);
             //   MessageBox.Show("The file has been saved at: " + loco7);
            }
            else if (o7 == true && spa == false)
            {
                name7 = txtNew.Text;
                npath7 = source7.Replace(oldfilename7, name7 + " 7" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source7);
                image.Save(npath7, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
              //  MessageBox.Show("The file has been saved at: " + npath7);
            }
            if (o8 == true && spa == true)
            {
                name8 = txtNew.Text;
                loco8 = spath + "/" + name8 + " 8" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source8);
                image.Save(loco8, System.Drawing.Imaging.ImageFormat.Jpeg);
              //  MessageBox.Show("The file has been saved at: " + loco8);
            }
            else if (o8 == true && spa == false)
            {
                name8 = txtNew.Text;
                npath8 = source8.Replace(oldfilename8, name8 + " 8" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source8);
                image.Save(npath8, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
                //MessageBox.Show("The file has been saved at: " + npath8);
            }
            if (o9 == true && spa == true)
            {
                name9 = txtNew.Text;
                loco9 = spath + "/" + name9 + " 9" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source9);
                image.Save(loco9, System.Drawing.Imaging.ImageFormat.Jpeg);
                //MessageBox.Show("The file has been saved at: " + loco9);
            }
            else if (o9 == true && spa == false)
            {
                name9 = txtNew.Text;
                npath9 = source9.Replace(oldfilename9, name9 + " 9" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source9);
                image.Save(npath9, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
               // MessageBox.Show("The file has been saved at: " + npath9);
            }
            if (o10 == true && spa == true)
            {
                name10 = txtNew.Text;
                loco10 = spath + "/" + name10 + " 10" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source10);
                image.Save(loco10, System.Drawing.Imaging.ImageFormat.Jpeg);
               // MessageBox.Show("The file has been saved at: " + loco10);
            }
            else if (o10 == true && spa == false)
            {
                name10 = txtNew.Text;
                npath10 = source10.Replace(oldfilename10, name10 + " 10" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source10);
                image.Save(npath10, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
               // MessageBox.Show("The file has been saved at: " + npath10);
            }
            if (o11 == true && spa == true)
            {
                name11 = txtNew.Text;
                loco11 = spath + "/" + name11 + " 11" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source11);
                image.Save(loco11, System.Drawing.Imaging.ImageFormat.Jpeg);
              //  MessageBox.Show("The file has been saved at: " + loco11);
            }
            else if (o11 == true && spa == false)
            {
                name11 = txtNew.Text;
                npath11 = source11.Replace(oldfilename11, name11 + " 11" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source11);
                image.Save(npath11, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
               // MessageBox.Show("The file has been saved at: " + npath11);
            }
            if (o12 == true && spa == true)
            {
                name12 = txtNew.Text;
                loco12 = spath + "/" + name12 + " 12" + ".Jpeg";
                System.Drawing.Image image = System.Drawing.Image.FromFile(source12);
                image.Save(loco12, System.Drawing.Imaging.ImageFormat.Jpeg);
               // MessageBox.Show("The file has been saved at: " + loco12);
            }
            else if (o12 == true && spa == false)
            {
                name12 = txtNew.Text;
                npath12 = source12.Replace(oldfilename12, name12 + " 12" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source12);
                image.Save(npath12, System.Drawing.Imaging.ImageFormat.Jpeg); //<<<<<<<<<<<<<<<<<<<
               // MessageBox.Show("The file has been saved at: " + npath12);
            }
            reset();
        }

        public void reset()
        {
            pb1.Image = null;
            pb2.Image = null;
            pb3.Image = null;
            pb4.Image = null;
            pb5.Image = null;
            pb6.Image = null;
            pb7.Image = null;
            pb8.Image = null;
            pb9.Image = null;
            pb10.Image = null;
            pb11.Image = null;
            pb12.Image = null;
            txtNew.Text = "";
            

            //delete
            if (delete == true)
            {
                File.Delete(source1);
                //after the atrocity
                cbDelete.Checked = false;
                MessageBox.Show("All original files have been deleted successfully. Process complete.");
            }
            else if (delete == false)
            {
                cbDelete.Checked = false;
                MessageBox.Show("Process complete.");
            }

        }

        public void check()
        {
            
            
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            
            ofd1.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd1.ShowDialog() == DialogResult.OK)
            {
                PictureBox p1 = new PictureBox();
                pb1.ImageLocation = ofd1.FileName;
                this.Controls.Add(p1);
                source1 = pb1.ImageLocation;
                oldfilepath1 = ofd1.FileName;
                oldfilename1 = Path.GetFileName(oldfilepath1);
                o1 = true;
            }


           // MessageBox.Show(oldfilename);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.Filter = "JPG|*.jpg|PNG|*.png|JPEG|*.JPEG|PSD|*.PSD|psd|*.psd|BMP|*.bmp";
            //ofd.Filter = "jpg|*.jpg |jpeg|*.jpeg|png|*.png|JPG|*.JPG |JPEG|*.JPEG|PNG|*.PNG";
            if (ofd2.ShowDialog() == DialogResult.OK)
            {
                PictureBox p2 = new PictureBox();
                pb2.ImageLocation = ofd2.FileName;
                this.Controls.Add(p2);
                source2 = pb2.ImageLocation;
                oldfilepath2 = ofd2.FileName;
                oldfilename2 = Path.GetFileName(oldfilepath2);
                o2 = true;
            }
            //lbC.Text = oldfilename;
            //lb2.Text = oldfilepath;
        }
    }
}
