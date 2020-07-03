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
using pics;
using vars;

namespace List
{
    public partial class Handbag : Form
    {
        //basics
        string itemname;
        string brandname;
        string upc;

        //pockets
        int multiO, multiI;
        int zipO, zipI;

        //description outside
        string deso1, deso2, deso3, deso4;

        //description inside
        string desi1, desi2, desi3, desi4;

        //measurements
        string length;
        string height;
        string depth;
        string hdrop;
        string sdrop;

        //other
        string path = "C://Users//Faiq//Documents//listsave//";
        string photo;
        string date;
        string time;

        //forms
        Boolean bag = false;
        Boolean jewel = false;
        Boolean make = false;
        Boolean shoez = false;

        //move
        string sourceFile;
        string destinationFile;


        //for photos
        string npath1, npath2, npath3, npath4, npath5, npath6, npath7, npath8, npath9, npath10, npath11, npath12;
        string name1, name2, name3, name4, name5, name6, name7, name8, name9, name10, name11, name12;
        bool o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12 = false;
        string oldfilepath1, oldfilepath2, oldfilepath3, oldfilepath4, oldfilepath5, oldfilepath6, oldfilepath7, oldfilepath8, oldfilepath9, oldfilepath10, oldfilepath11, oldfilepath12;
        string oldfilename1, oldfilename2, oldfilename3, oldfilename4, oldfilename5, oldfilename6, oldfilename7, oldfilename8, oldfilename9, oldfilename10, oldfilename11, oldfilename12;
        string source1, source2, source3, source4, source5, source6, source7, source8, source9, source10, source11, source12;


      

        //light vs dark mode
        //bool light = true;
        //bool dark = false;



        public void forms()
        {
            Handbag handbag = new Handbag();
            Makeup makeup = new Makeup();
            Jewelry jewels = new Jewelry();
            shoes shoe = new shoes();

            //customize to current form's code


            if (bag == true)
            {
                handbag.ShowDialog();
                bag = false;
            }
            if (make == true)
            {
                makeup.ShowDialog();
                make = false;
            }
            if (jewel == true)
            {
                jewels.ShowDialog();
                jewel = false;
            }
            if (shoez == true)
            {
                shoe.ShowDialog();
                shoez = false;
            }
        }

        public void move2()
        {
            //'C:\Users\Faiq\Pictures\test\DSC_0287.JPG1.Jpeg'
            System.Drawing.Image pic1 = System.Drawing.Image.FromFile(pics.pic.pl1);
            MessageBox.Show(pics.pic.pl1);
            photo = "C://Users//Faiq//Documents//listsave//handbag//" + itemname + "//pictures//";
            sourceFile = pb1.ImageLocation;
            destinationFile = pics.pic.pl1.Replace(sourceFile, photo + itemname + " 1" + ".Jpeg"+"//");
            photo = photo + destinationFile;
            MessageBox.Show(destinationFile);
            pic1.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
        public void move()
        {
            //move the pictures
            //"pick up" the pictures

            


            System.Drawing.Image pic1 = System.Drawing.Image.FromFile(pics.pic.pl1 + "1"+".Jpeg");
            System.Drawing.Image pic2 = System.Drawing.Image.FromFile(pics.pic.pl2 +"2"+ ".Jpeg");
            System.Drawing.Image pic3 = System.Drawing.Image.FromFile(pics.pic.pl3 +"3"+ ".Jpeg");
            System.Drawing.Image pic4 = System.Drawing.Image.FromFile(pics.pic.pl4 +"4"+ ".Jpeg");
            System.Drawing.Image pic5 = System.Drawing.Image.FromFile(pics.pic.pl5 +"5"+ ".Jpeg");
            System.Drawing.Image pic6 = System.Drawing.Image.FromFile(pics.pic.pl6 +"6"+ ".Jpeg");
            System.Drawing.Image pic7 = System.Drawing.Image.FromFile(pics.pic.pl7 +"7"+ ".Jpeg");
            System.Drawing.Image pic8 = System.Drawing.Image.FromFile(pics.pic.pl8 +"8"+ ".Jpeg");
            System.Drawing.Image pic9 = System.Drawing.Image.FromFile(pics.pic.pl9 +"9"+ ".Jpeg");
            System.Drawing.Image pic10 = System.Drawing.Image.FromFile(pics.pic.pl10 + "10"+".Jpeg");
            System.Drawing.Image pic11 = System.Drawing.Image.FromFile(pics.pic.pl11 + "11" +".Jpeg");
            System.Drawing.Image pic12 = System.Drawing.Image.FromFile(pics.pic.pl12 + "12"+".Jpeg");

            

            //C:\Users\Faiq\Documents\listsave\handbag\Debug on
            photo = "C://Users//Faiq//Documents//listsave//handbag//"+itemname +"//pictures";

            pic1.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic2.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic3.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic4.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic5.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic6.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic7.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic8.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic9.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic10.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic11.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
            pic12.Save(photo, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetpics();
            lstAll.Items.Clear();

            //clearing form
            txtItemName.Text = "";
            txtBrand.Text = "";
            txtBrand.Enabled = false;
            cbBrands.ResetText();
            txtUPC.Text = "";
            txtMI.Text = "";
            txtMO.Text = "";
            txtZI.Text = "";
            txtZO.Text = "";
            txtDO1.Text = "";
            txtDO2.Text = "";
            txtDO3.Text = "";
            txtDO4.Text = "";
            txtDI1.Text = "";
            txtDI2.Text = "";
            txtDI3.Text = "";
            txtDI4.Text = "";
            txtL.Text = "";
            txtH.Text = "";
            txtD.Text = "";
            txtHD.Text = "";
            txtSD.Text = "";
            // pb1.Image.Dispose();
            //pb1.Image = null;
            //pb2.Image.Dispose();
            //pb2.Image = null;
            // pb3.Image.Dispose();
            //  pb3.Image = null;
            // pb4.Image.Dispose();
            //   pb4.Image = null;
            //   pb5.Image.Dispose();
            //  pb5.Image = null;
            // pb6.Image.Dispose();
            // pb6.Image = null;
            //  pb7.Image.Dispose();
            //  pb7.Image = null;
            // pb8.Image.Dispose();
            // pb8.Image = null;
            //  pb9.Image.Dispose();
            //  pb9.Image = null;
            //  pb10.Image.Dispose();
            //  pb10.Image = null;
            //pb11.Image.Dispose();
            //pb11.Image = null;
            //  pb12.Image.Dispose();
            //  pb12.Image = null;
            //reset all variables
            //basics
            itemname = "";
            brandname = ""; 
            upc = "";

            //pockets
            //multiO = "";
            //multiI = "";
            //zipO = "";
            //zipI = "";

            //description outside
            deso1 = "";
            deso2 = "";
            deso3 = "";
            deso4 = "";

            //description inside
            desi1 = "";
            desi2 = "";
            desi3 = "";
            desi4 = "";

            //measurements
            length = "";
            height = "";
            depth = "";
            hdrop = "";
            sdrop = "";

            //other
            path = "C://Users//Faiq//Documents//listsave//";

            //place
            

        }

        private void materialTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDO4.Text = "MATERIAL tag";
        }

        private void hVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Vinyl";
            txtDO2.Text = "Handles";
        }

        private void hVSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Vinyl";
            txtDO2.Text = "Handles";
            txtDO3.Text = "Strap";
        }

        private void vSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Vinyl";
            txtDO2.Text = "Strap";
        }

        private void vToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Vinyl";
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd1 = new OpenFileDialog();
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
        }

        public void build()
        {
            //BUILD

            //lstAll.Items.Add("");
            //lstAll.Items.Add();

            lstAll.Items.Add(itemname);
            lstAll.Items.Add("");

            //description outside
            lstAll.Items.Add("Outside:");
            if (deso1 != "")
            {
                lstAll.Items.Add(deso1);
            }
            if (deso2 != "")
            {
                lstAll.Items.Add(deso2);
            }
            if (deso3 != "")
            {
                lstAll.Items.Add(deso3);
            }
            if (deso4 != "")
            {
                lstAll.Items.Add(deso4);
            }

            //description inside
            lstAll.Items.Add("Inside:");
            if (desi1 != "")
            {
                lstAll.Items.Add(desi1);
            }
            if (desi2 != "")
            {
                lstAll.Items.Add(desi2);
            }
            if (desi3 != "")
            {
                lstAll.Items.Add(desi3);
            }
            if (desi4 != "")
            {
                lstAll.Items.Add(desi4);
            }
            lstAll.Items.Add("");

            //measurements
            lstAll.Items.Add("Approximate Measurements");
            lstAll.Items.Add("");
            lstAll.Items.Add("(Middle Point)");
            lstAll.Items.Add("");
            lstAll.Items.Add(length + " (L) " + height + " (H) " + depth + " (D) ");
            lstAll.Items.Add("");

            if (hdrop != "")
            {
                lstAll.Items.Add("Handle Drop:");
                lstAll.Items.Add(hdrop + " inches");
                lstAll.Items.Add("");
            }
            if (sdrop != "")
            {
                lstAll.Items.Add("Strap Drop:");
                lstAll.Items.Add(sdrop + " inches");
                lstAll.Items.Add("");

            }
            lstAll.Items.Add("");
            lstAll.Items.Add("100% Authentic");
            lstAll.Items.Add("Have a nice day!!!!!");
            lstAll.Items.Add("");
            lstAll.Items.Add("UPC: " + upc);
        }

        public void folder()
        {
            //string root = path + itemname;
            //if (!Directory.Exists(root)) { Directory.CreateDirectory(root);}
            //if (!Directory.Exists(root)) { Directory.CreateDirectory(root + "\\pictures"); }
            //string rootDirectory = path;
            //itemname = txtItemName.Text;
            //path = path + "\\" + itemname;
            //if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            //if (!Directory.Exists(path + "\\pictures")) { Directory.CreateDirectory(path + "\\pictures"); }
            //if (!Directory.Exists(path + "\\pictures")) { Directory.CreateDirectory("\\pictures"); }
            //if (!Directory.Exists(path + "\\pictures")) { Directory.CreateDirectory("\\pictures"); }
        }

      
        public void cleanme()
        {
            cbBrands.Text = "";
            txtItemName.Text = "";
            txtUPC.Text = "";
        }
      

        private void openCurrentSavePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@path);
        }

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void coachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            cleanme();
            txtBrand.Text = "Coach";
            txtItemName.Text = "NWT Coach F# $";
            txtUPC.Text = "889532";
            cbBrands.SelectedText = "Coach";
        }

        private void kateSpadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanme();
            txtBrand.Text = "Kate Spade";
            txtItemName.Text = "NWT Kate Spade PXRU# $";
            txtUPC.Text = "098689";
            cbBrands.SelectedText = "Kate Spade";
        }

        private void michaelKorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanme();
            txtBrand.Text = "Michael Kors";
            txtItemName.Text = "NWT Michael Kors $";
            txtUPC.Text = "888";
            cbBrands.SelectedText = "Michael Kors";
        }

        private void toryBurchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanme();
            txtBrand.Text = "Tory Burch";
            txtItemName.Text = "NWT Tory Burch OS $";
            txtUPC.Text = "190041";
            cbBrands.SelectedText = "Tory Burch";
        }

        private void newWithTagsBrandToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nWTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbBrands.SelectedItem = "Other (enter)";
            //cbBrands.Text = "";
            txtItemName.Text = "";
            txtItemName.Text = "NWT";
        }

        private void nWTKateSpadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            cbBrands.Text = "";
            cbBrands.SelectedText = "Kate Spade";
            txtItemName.Text = "NWT Kate Spade $";
        }

        private void nWTMichaelKorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            cbBrands.Text = "";
            cbBrands.SelectedText = "Michael Kors";
            txtItemName.Text = "NWT Michael Kors $";
        }

        private void nWTToryBurchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            cbBrands.Text = "";
            cbBrands.SelectedText = "Tory Burch";
            txtItemName.Text = "NWT Tory Burch $";
        }

        private void nylonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ctoonToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void resetdo()
        {
            txtDO1.Text = "";
            txtDO2.Text = "";
            txtDO3.Text = "";
            txtDO4.Text = "";
            
        }

        private void cHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Cotton";
            txtDO2.Text = "Handles";
        }

        private void cHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();


            txtDO1.Text = "COLOR Cotton";
            txtDO2.Text = "Handles";
            txtDO3.Text = "Strap";
        }

        private void cSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Cotton";
            txtDO2.Text = "Strap";
        }

        private void hFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Fabric";
            txtDO2.Text = "Handles";
        }

        private void fSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Fabric";
            txtDO2.Text = "Strap";
        }

        private void hFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();


            txtDO1.Text = "COLOR Fabric";
            txtDO2.Text = "Handles";
            txtDO3.Text = "Strap";
        }

        private void hLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();


            txtDO1.Text = "COLOR Leather";
            txtDO2.Text = "Handles";
            txtDO3.Text = "Strap";
        }

        private void hNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Nylon";
            txtDO2.Text = "Handles";
            txtDO3.Text = "Strap";
        }

        private void hLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Leather";
            txtDO2.Text = "Handles";
        }

        private void hSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void lSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Leather";
            txtDO2.Text = "Strap";
        }

        private void hNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Nylon";
            txtDO2.Text = "Handles";
        }

        private void nSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "COLOR Nylon";
            txtDO2.Text = "Strap";
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {

            darken();

        }

        public void extra()
        {
            //labels
            labelitemname.BackColor = Color.GreenYellow;
            labelbrand.BackColor = Color.GreenYellow;
            labelmfp.BackColor = Color.GreenYellow;
            labelmes.BackColor = Color.GreenYellow;
            labelout.BackColor = Color.GreenYellow;
            labelin.BackColor = Color.GreenYellow;
            labeldeso.BackColor = Color.GreenYellow;
            labeldesi.BackColor = Color.GreenYellow;
            labell.BackColor = Color.GreenYellow;
            labelh.BackColor = Color.GreenYellow;
            labeld.BackColor = Color.GreenYellow;
            labelhd.BackColor = Color.GreenYellow;
            labelsd.BackColor = Color.GreenYellow;
            labelzip.BackColor = Color.GreenYellow;
            labelupc.BackColor = Color.GreenYellow;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lighten();         
        }

        public void darken()
        {
            Handbag.ActiveForm.BackColor = Color.DarkBlue;
            btnGen.BackColor = Color.DeepSkyBlue;
            btnReset.BackColor = Color.DeepSkyBlue;
            btnSubmit.BackColor = Color.DeepSkyBlue;

            //menustrip
            createFolderToolStripMenuItem.BackColor = Color.DarkBlue;
            openCurrentSavePathToolStripMenuItem1.BackColor = Color.DarkBlue;
            changeSavePathToolStripMenuItem.BackColor = Color.DarkBlue;
            fillToolStripMenuItem.BackColor = Color.DarkBlue;
            modeToolStripMenuItem.BackColor = Color.DarkBlue;
            ms1.BackColor = Color.DarkBlue;
            lightToolStripMenuItem.BackColor = Color.DarkBlue;
            darkToolStripMenuItem.BackColor = Color.DarkBlue;
            coachToolStripMenuItem.BackColor = Color.DarkBlue;
            michaelKorsToolStripMenuItem.BackColor = Color.DarkBlue;
            toryBurchToolStripMenuItem.BackColor = Color.DarkBlue;
            kateSpadeToolStripMenuItem.BackColor = Color.DarkBlue;
            fillToolStripMenuItem.BackColor = Color.DarkBlue;
            brandToolStripMenuItem.BackColor = Color.DarkBlue;
            newWithTagsBrandToolStripMenuItem.BackColor = Color.DarkBlue;
            typicalBagToolStripMenuItem.BackColor = Color.DarkBlue;
            nWTCoachToolStripMenuItem.BackColor = Color.DarkBlue;
            nWTKateSpadeToolStripMenuItem.BackColor = Color.DarkBlue;
            nWTMichaelKorsToolStripMenuItem.BackColor = Color.DarkBlue;
            nWTToolStripMenuItem.BackColor = Color.DarkBlue;
            nWTToryBurchToolStripMenuItem.BackColor = Color.DarkBlue;
            cottonToolStripMenuItem.BackColor = Color.DarkBlue;
            fabricToolStripMenuItem.BackColor = Color.DarkBlue;
            leatherToolStripMenuItem.BackColor = Color.DarkBlue;
            nylonToolStripMenuItem.BackColor = Color.DarkBlue;
            cHToolStripMenuItem.BackColor = Color.DarkBlue;
            cHSToolStripMenuItem.BackColor = Color.DarkBlue;
            cSToolStripMenuItem.BackColor = Color.DarkBlue;
            hFSToolStripMenuItem.BackColor = Color.DarkBlue;
            hFToolStripMenuItem.BackColor = Color.DarkBlue;
            fSToolStripMenuItem.BackColor = Color.DarkBlue;
            hLSToolStripMenuItem.BackColor = Color.DarkBlue;
            hLToolStripMenuItem.BackColor = Color.DarkBlue;
            lSToolStripMenuItem.BackColor = Color.DarkBlue;
            hNToolStripMenuItem.BackColor = Color.DarkBlue;
            hNSToolStripMenuItem.BackColor = Color.DarkBlue;
            nSToolStripMenuItem.BackColor = Color.DarkBlue;
            handlesStrapToolStripMenuItem.BackColor = Color.DarkBlue;
            defaultToolStripMenuItem.BackColor = Color.DarkBlue;
            sellToolStripMenuItem.BackColor = Color.DarkBlue;
            handbagToolStripMenuItem.BackColor = Color.DarkBlue;
            jewelryToolStripMenuItem.BackColor = Color.DarkBlue;
            makeupToolStripMenuItem.BackColor = Color.DarkBlue;
            shoesToolStripMenuItem.BackColor = Color.DarkBlue;
            dustbagIncludedToolStripMenuItem.BackColor = Color.DarkBlue;
            //menu strip fore color
            createFolderToolStripMenuItem.ForeColor = Color.GreenYellow;
            openCurrentSavePathToolStripMenuItem1.ForeColor = Color.GreenYellow;
            changeSavePathToolStripMenuItem.ForeColor = Color.GreenYellow;
            savePathToolStripMenuItem.ForeColor=Color.GreenYellow;
            fillToolStripMenuItem.ForeColor = Color.GreenYellow;
            modeToolStripMenuItem.ForeColor = Color.GreenYellow;
            lightToolStripMenuItem.ForeColor = Color.GreenYellow;
            darkToolStripMenuItem.ForeColor = Color.GreenYellow;
            coachToolStripMenuItem.ForeColor = Color.GreenYellow;
            michaelKorsToolStripMenuItem.ForeColor = Color.GreenYellow;
            toryBurchToolStripMenuItem.ForeColor = Color.GreenYellow;
            kateSpadeToolStripMenuItem.ForeColor = Color.GreenYellow;
            fillToolStripMenuItem.ForeColor = Color.GreenYellow;
            brandToolStripMenuItem.ForeColor = Color.GreenYellow;
            newWithTagsBrandToolStripMenuItem.ForeColor = Color.GreenYellow;
            typicalBagToolStripMenuItem.ForeColor = Color.GreenYellow;
            nWTCoachToolStripMenuItem.ForeColor = Color.GreenYellow;
            nWTKateSpadeToolStripMenuItem.ForeColor = Color.GreenYellow;
            nWTMichaelKorsToolStripMenuItem.ForeColor = Color.GreenYellow;
            nWTToolStripMenuItem.ForeColor = Color.GreenYellow;
            nWTToryBurchToolStripMenuItem.ForeColor = Color.GreenYellow;
            cottonToolStripMenuItem.ForeColor = Color.GreenYellow;
            fabricToolStripMenuItem.ForeColor = Color.GreenYellow;
            leatherToolStripMenuItem.ForeColor = Color.GreenYellow;
            nylonToolStripMenuItem.ForeColor = Color.GreenYellow;
            cHToolStripMenuItem.ForeColor = Color.GreenYellow;
            cHSToolStripMenuItem.ForeColor = Color.GreenYellow;
            cSToolStripMenuItem.ForeColor = Color.GreenYellow;
            hFSToolStripMenuItem.ForeColor = Color.GreenYellow;
            hFToolStripMenuItem.ForeColor = Color.GreenYellow;
            fSToolStripMenuItem.ForeColor = Color.GreenYellow;
            hLSToolStripMenuItem.ForeColor = Color.GreenYellow;
            hLToolStripMenuItem.ForeColor = Color.GreenYellow;
            lSToolStripMenuItem.ForeColor = Color.GreenYellow;
            hNToolStripMenuItem.ForeColor = Color.GreenYellow;
            hNSToolStripMenuItem.ForeColor = Color.GreenYellow;
            nSToolStripMenuItem.ForeColor = Color.GreenYellow;
            handlesStrapToolStripMenuItem.ForeColor = Color.GreenYellow;
            defaultToolStripMenuItem.ForeColor = Color.GreenYellow;
            sellToolStripMenuItem.ForeColor = Color.GreenYellow;
            handbagToolStripMenuItem.ForeColor = Color.GreenYellow;
            jewelryToolStripMenuItem.ForeColor = Color.GreenYellow;
            makeupToolStripMenuItem.ForeColor = Color.GreenYellow;
            shoesToolStripMenuItem.ForeColor = Color.GreenYellow;
            dustbagIncludedToolStripMenuItem.ForeColor = Color.GreenYellow;

            //listbox
            lstAll.BackColor = Color.DarkBlue;
            lstAll.ForeColor = Color.FloralWhite;
            //labels
            labelitemname.ForeColor = Color.GreenYellow;
            labelbrand.ForeColor = Color.GreenYellow;
            labelmfp.ForeColor = Color.GreenYellow;
            labelmes.ForeColor = Color.GreenYellow;
            labelout.ForeColor = Color.GreenYellow;
            labelin.ForeColor = Color.GreenYellow;
            labeldeso.ForeColor = Color.GreenYellow;
            labeldesi.ForeColor = Color.GreenYellow;
            labell.ForeColor = Color.GreenYellow;
            labelh.ForeColor = Color.GreenYellow;
            labeld.ForeColor = Color.GreenYellow;
            labelhd.ForeColor = Color.GreenYellow;
            labelsd.ForeColor = Color.GreenYellow;
            labelzip.ForeColor = Color.GreenYellow;
            labelupc.ForeColor = Color.GreenYellow;

            //textbox
            txtItemName.BackColor = Color.DarkBlue;
            cbBrands.BackColor = Color.DarkBlue;
            txtBrand.BackColor = Color.DarkBlue;
            txtUPC.BackColor = Color.DarkBlue;
            txtMI.BackColor = Color.DarkBlue;
            txtMO.BackColor = Color.DarkBlue;
            txtZI.BackColor = Color.DarkBlue;
            txtZO.BackColor = Color.DarkBlue;
            txtDO1.BackColor = Color.DarkBlue;
            txtDO2.BackColor = Color.DarkBlue;
            txtDO3.BackColor = Color.DarkBlue;
            txtDO4.BackColor = Color.DarkBlue;
            txtDI1.BackColor = Color.DarkBlue;
            txtDI2.BackColor = Color.DarkBlue;
            txtDI3.BackColor = Color.DarkBlue;
            txtDI4.BackColor = Color.DarkBlue;
            txtH.BackColor = Color.DarkBlue;
            txtD.BackColor = Color.DarkBlue;
            txtL.BackColor = Color.DarkBlue;
            txtHD.BackColor = Color.DarkBlue;
            txtSD.BackColor = Color.DarkBlue;


            txtItemName.ForeColor = Color.GreenYellow;
            cbBrands.ForeColor = Color.GreenYellow;
            txtBrand.ForeColor = Color.GreenYellow;
            txtUPC.ForeColor = Color.GreenYellow;
            txtMI.ForeColor = Color.GreenYellow;
            txtMO.ForeColor = Color.GreenYellow;
            txtZI.ForeColor = Color.GreenYellow;
            txtZO.ForeColor = Color.GreenYellow;
            txtDO1.ForeColor = Color.GreenYellow;
            txtDO2.ForeColor = Color.GreenYellow;
            txtDO3.ForeColor = Color.GreenYellow;
            txtDO4.ForeColor = Color.GreenYellow;
            txtDI1.ForeColor = Color.GreenYellow;
            txtDI2.ForeColor = Color.GreenYellow;
            txtDI3.ForeColor = Color.GreenYellow;
            txtDI4.ForeColor = Color.GreenYellow;
            txtH.ForeColor = Color.GreenYellow;
            txtD.ForeColor = Color.GreenYellow;
            txtL.ForeColor = Color.GreenYellow;
            txtHD.ForeColor = Color.GreenYellow;
            txtSD.ForeColor = Color.GreenYellow;
        }

        public void lighten()
        {
            //menustrip back color
            createFolderToolStripMenuItem.BackColor = Color.FloralWhite;
            openCurrentSavePathToolStripMenuItem1.BackColor = Color.FloralWhite;
            changeSavePathToolStripMenuItem.BackColor = Color.FloralWhite;
            savePathToolStripMenuItem.BackColor = Color.FloralWhite;
            fillToolStripMenuItem.BackColor = Color.FloralWhite;
            modeToolStripMenuItem.BackColor = Color.FloralWhite;
            ms1.BackColor = Color.FloralWhite;
            lightToolStripMenuItem.BackColor = Color.FloralWhite;
            darkToolStripMenuItem.BackColor = Color.FloralWhite;
            coachToolStripMenuItem.BackColor = Color.FloralWhite;
            michaelKorsToolStripMenuItem.BackColor = Color.FloralWhite;
            toryBurchToolStripMenuItem.BackColor = Color.FloralWhite;
            kateSpadeToolStripMenuItem.BackColor = Color.FloralWhite;
            fillToolStripMenuItem.BackColor = Color.FloralWhite;
            brandToolStripMenuItem.BackColor = Color.FloralWhite;
            newWithTagsBrandToolStripMenuItem.BackColor = Color.FloralWhite;
            typicalBagToolStripMenuItem.BackColor = Color.FloralWhite;
            nWTCoachToolStripMenuItem.BackColor = Color.FloralWhite;
            nWTKateSpadeToolStripMenuItem.BackColor = Color.FloralWhite;
            nWTMichaelKorsToolStripMenuItem.BackColor = Color.FloralWhite;
            nWTToolStripMenuItem.BackColor = Color.FloralWhite;
            nWTToryBurchToolStripMenuItem.BackColor = Color.FloralWhite;
            cottonToolStripMenuItem.BackColor = Color.FloralWhite;
            fabricToolStripMenuItem.BackColor = Color.FloralWhite;
            leatherToolStripMenuItem.BackColor = Color.FloralWhite;
            nylonToolStripMenuItem.BackColor = Color.FloralWhite;
            cHToolStripMenuItem.BackColor = Color.FloralWhite;
            cHSToolStripMenuItem.BackColor = Color.FloralWhite;
            cSToolStripMenuItem.BackColor = Color.FloralWhite;
            hFSToolStripMenuItem.BackColor = Color.FloralWhite;
            hFToolStripMenuItem.BackColor = Color.FloralWhite;
            fSToolStripMenuItem.BackColor = Color.FloralWhite;
            hLSToolStripMenuItem.BackColor = Color.FloralWhite;
            hLToolStripMenuItem.BackColor = Color.FloralWhite;
            lSToolStripMenuItem.BackColor = Color.FloralWhite;
            hNToolStripMenuItem.BackColor = Color.FloralWhite;
            hNSToolStripMenuItem.BackColor = Color.FloralWhite;
            nSToolStripMenuItem.BackColor = Color.FloralWhite;
            handlesStrapToolStripMenuItem.BackColor = Color.FloralWhite;
            defaultToolStripMenuItem.BackColor = Color.FloralWhite;
            sellToolStripMenuItem.BackColor = Color.FloralWhite;
            handbagToolStripMenuItem.BackColor = Color.FloralWhite;
            jewelryToolStripMenuItem.BackColor = Color.FloralWhite;
            makeupToolStripMenuItem.BackColor = Color.FloralWhite;
            shoesToolStripMenuItem.BackColor = Color.FloralWhite;
            dustbagIncludedToolStripMenuItem.BackColor = Color.FloralWhite;
            //menustrip fore color
            createFolderToolStripMenuItem.ForeColor = Color.Black;
            openCurrentSavePathToolStripMenuItem1.ForeColor = Color.Black;
            changeSavePathToolStripMenuItem.ForeColor = Color.Black;
            fillToolStripMenuItem.ForeColor = Color.Black;
            modeToolStripMenuItem.ForeColor = Color.Black;
            ms1.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;
            coachToolStripMenuItem.ForeColor = Color.Black;
            michaelKorsToolStripMenuItem.ForeColor = Color.Black;
            toryBurchToolStripMenuItem.ForeColor = Color.Black;
            kateSpadeToolStripMenuItem.ForeColor = Color.Black;
            fillToolStripMenuItem.ForeColor = Color.Black;
            brandToolStripMenuItem.ForeColor = Color.Black;
            newWithTagsBrandToolStripMenuItem.ForeColor = Color.Black;
            typicalBagToolStripMenuItem.ForeColor = Color.Black;
            nWTCoachToolStripMenuItem.ForeColor = Color.Black;
            nWTKateSpadeToolStripMenuItem.ForeColor = Color.Black;
            nWTMichaelKorsToolStripMenuItem.ForeColor = Color.Black;
            nWTToolStripMenuItem.ForeColor = Color.Black;
            nWTToryBurchToolStripMenuItem.ForeColor = Color.Black;
            cottonToolStripMenuItem.ForeColor = Color.Black;
            fabricToolStripMenuItem.ForeColor = Color.Black;
            leatherToolStripMenuItem.ForeColor = Color.Black;
            nylonToolStripMenuItem.ForeColor = Color.Black;
            cHToolStripMenuItem.ForeColor = Color.Black;
            cHSToolStripMenuItem.ForeColor = Color.Black;
            cSToolStripMenuItem.ForeColor = Color.Black;
            hFSToolStripMenuItem.ForeColor = Color.Black;
            hFToolStripMenuItem.ForeColor = Color.Black;
            fSToolStripMenuItem.ForeColor = Color.Black;
            hLSToolStripMenuItem.ForeColor = Color.Black;
            hLToolStripMenuItem.ForeColor = Color.Black;
            lSToolStripMenuItem.ForeColor = Color.Black;
            hNToolStripMenuItem.ForeColor = Color.Black;
            hNSToolStripMenuItem.ForeColor = Color.Black;
            nSToolStripMenuItem.ForeColor = Color.Black;
            handlesStrapToolStripMenuItem.ForeColor = Color.Black;
            defaultToolStripMenuItem.ForeColor = Color.Black;
            sellToolStripMenuItem.ForeColor = Color.Black;
            handbagToolStripMenuItem.ForeColor = Color.Black;
            jewelryToolStripMenuItem.ForeColor = Color.Black;
            makeupToolStripMenuItem.ForeColor = Color.Black;
            shoesToolStripMenuItem.ForeColor = Color.Black;
            savePathToolStripMenuItem.ForeColor = Color.Black;
            dustbagIncludedToolStripMenuItem.ForeColor = Color.Black;
            //labels
            labelitemname.ForeColor = Color.Black;
            labelbrand.ForeColor = Color.Black;
            labelmfp.ForeColor = Color.Black;
            labelmes.ForeColor = Color.Black;
            labelout.ForeColor = Color.Black;
            labelin.ForeColor = Color.Black;
            labeldeso.ForeColor = Color.Black;
            labeldesi.ForeColor = Color.Black;
            labell.ForeColor = Color.Black;
            labelh.ForeColor = Color.Black;
            labeld.ForeColor = Color.Black;
            labelhd.ForeColor = Color.Black;
            labelsd.ForeColor = Color.Black;
            labelzip.ForeColor = Color.Black;
            labelupc.ForeColor = Color.Black;

            //listbox
            lstAll.BackColor = Color.FloralWhite;
            lstAll.ForeColor = Color.Black;
            
            //textbox back color
            txtItemName.BackColor = Color.Aqua;
            cbBrands.BackColor = Color.Aqua;
            txtBrand.BackColor = Color.Aqua;
            txtUPC.BackColor = Color.Aqua;
            txtMI.BackColor = Color.Aqua;
            txtMO.BackColor = Color.Aqua;
            txtZI.BackColor = Color.Aqua;
            txtZO.BackColor = Color.Aqua;
            txtDO1.BackColor = Color.Aqua;
            txtDO2.BackColor = Color.Aqua;
            txtDO3.BackColor = Color.Aqua;
            txtDO4.BackColor = Color.Aqua;
            txtDI1.BackColor = Color.Aqua;
            txtDI2.BackColor = Color.Aqua;
            txtDI3.BackColor = Color.Aqua;
            txtDI4.BackColor = Color.Aqua;
            txtH.BackColor = Color.Aqua;
            txtD.BackColor = Color.Aqua;
            txtL.BackColor = Color.Aqua;
            txtHD.BackColor = Color.Aqua;
            txtSD.BackColor = Color.Aqua;

            //textbox fore color
            txtItemName.ForeColor = Color.Black;
            cbBrands.ForeColor = Color.Black;
            txtBrand.ForeColor = Color.Black;
            txtUPC.ForeColor = Color.Black;
            txtMI.ForeColor = Color.Black;
            txtMO.ForeColor = Color.Black;
            txtZI.ForeColor = Color.Black;
            txtZO.ForeColor = Color.Black;
            txtDO1.ForeColor = Color.Black;
            txtDO2.ForeColor = Color.Black;
            txtDO3.ForeColor = Color.Black;
            txtDO4.ForeColor = Color.Black;
            txtDI1.ForeColor = Color.Black;
            txtDI2.ForeColor = Color.Black;
            txtDI3.ForeColor = Color.Black;
            txtDI4.ForeColor = Color.Black;
            txtH.ForeColor = Color.Black;
            txtD.ForeColor = Color.Black;
            txtL.ForeColor = Color.Black;
            txtHD.ForeColor = Color.Black;
            txtSD.ForeColor = Color.Black;

            //form
            Handbag.ActiveForm.BackColor = Color.FloralWhite;
            btnGen.BackColor = Color.LightSkyBlue;
            btnReset.BackColor = Color.LightSkyBlue;
            btnSubmit.BackColor = Color.LightSkyBlue;

            



            //listbox
            lstAll.BackColor = Color.FloralWhite;
            lstAll.ForeColor = Color.Black;

            //textbox
            txtItemName.BackColor = Color.Aqua;
            cbBrands.BackColor = Color.Aqua;
            txtBrand.BackColor = Color.Aqua;
            txtUPC.BackColor = Color.Aqua;
            txtMI.BackColor = Color.Aqua;
            txtMO.BackColor = Color.Aqua;
            txtZI.BackColor = Color.Aqua;
            txtZO.BackColor = Color.Aqua;
            txtDO1.BackColor = Color.Aqua;
            txtDO2.BackColor = Color.Aqua;
            txtDO3.BackColor = Color.Aqua;
            txtDO4.BackColor = Color.Aqua;
            txtDI1.BackColor = Color.Aqua;
            txtDI2.BackColor = Color.Aqua;
            txtDI3.BackColor = Color.Aqua;
            txtDI4.BackColor = Color.Aqua;
            txtH.BackColor = Color.Aqua;
            txtD.BackColor = Color.Aqua;
            txtL.BackColor = Color.Aqua;
            txtHD.BackColor = Color.Aqua;
            txtSD.BackColor = Color.Aqua;


            
        }

        public void def()
        {
            Handbag.ActiveForm.BackColor = SystemColors.Control;
            
            btnGen.BackColor = SystemColors.Control;
            btnReset.BackColor = SystemColors.Control;
            btnSubmit.BackColor = SystemColors.Control;

            //menustrip back color
            createFolderToolStripMenuItem.BackColor = SystemColors.Control;
            openCurrentSavePathToolStripMenuItem1.BackColor = SystemColors.Control;
            changeSavePathToolStripMenuItem.BackColor = SystemColors.Control;
            savePathToolStripMenuItem.BackColor = SystemColors.Control;
            fillToolStripMenuItem.BackColor = SystemColors.Control;
            modeToolStripMenuItem.BackColor = SystemColors.Control;
            ms1.BackColor = SystemColors.Control;
            lightToolStripMenuItem.BackColor = SystemColors.Control;
            darkToolStripMenuItem.BackColor = SystemColors.Control;
            coachToolStripMenuItem.BackColor = SystemColors.Control;
            michaelKorsToolStripMenuItem.BackColor = SystemColors.Control;
            toryBurchToolStripMenuItem.BackColor = SystemColors.Control;
            kateSpadeToolStripMenuItem.BackColor = SystemColors.Control;
            fillToolStripMenuItem.BackColor = SystemColors.Control;
            brandToolStripMenuItem.BackColor = SystemColors.Control;
            newWithTagsBrandToolStripMenuItem.BackColor = SystemColors.Control;
            typicalBagToolStripMenuItem.BackColor = SystemColors.Control;
            nWTCoachToolStripMenuItem.BackColor = SystemColors.Control;
            nWTKateSpadeToolStripMenuItem.BackColor = SystemColors.Control;
            nWTMichaelKorsToolStripMenuItem.BackColor = SystemColors.Control;
            nWTToolStripMenuItem.BackColor = SystemColors.Control;
            nWTToryBurchToolStripMenuItem.BackColor = SystemColors.Control;
            cottonToolStripMenuItem.BackColor = SystemColors.Control;
            fabricToolStripMenuItem.BackColor = SystemColors.Control;
            leatherToolStripMenuItem.BackColor = SystemColors.Control;
            nylonToolStripMenuItem.BackColor = SystemColors.Control;
            cHToolStripMenuItem.BackColor = SystemColors.Control;
            cHSToolStripMenuItem.BackColor = SystemColors.Control;
            cSToolStripMenuItem.BackColor = SystemColors.Control;
            hFSToolStripMenuItem.BackColor = SystemColors.Control;
            hFToolStripMenuItem.BackColor = SystemColors.Control;
            fSToolStripMenuItem.BackColor = SystemColors.Control;
            hLSToolStripMenuItem.BackColor = SystemColors.Control;
            hLToolStripMenuItem.BackColor = SystemColors.Control;
            lSToolStripMenuItem.BackColor = SystemColors.Control;
            hNToolStripMenuItem.BackColor = SystemColors.Control;
            hNSToolStripMenuItem.BackColor = SystemColors.Control;
            nSToolStripMenuItem.BackColor = SystemColors.Control;
            handlesStrapToolStripMenuItem.BackColor = SystemColors.Control;
            defaultToolStripMenuItem.BackColor = SystemColors.Control;
            sellToolStripMenuItem.BackColor = SystemColors.Control;
            handbagToolStripMenuItem.BackColor = SystemColors.Control;
            jewelryToolStripMenuItem.BackColor = SystemColors.Control;
            makeupToolStripMenuItem.BackColor = SystemColors.Control;
            shoesToolStripMenuItem.BackColor = SystemColors.Control;
            dustbagIncludedToolStripMenuItem.BackColor = SystemColors.Control;

            //menu strip fore color
            createFolderToolStripMenuItem.ForeColor = Color.Black;
            openCurrentSavePathToolStripMenuItem1.ForeColor = Color.Black;
            changeSavePathToolStripMenuItem.ForeColor = Color.Black;
            savePathToolStripMenuItem.ForeColor = Color.Black;
            fillToolStripMenuItem.ForeColor = Color.Black;
            modeToolStripMenuItem.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;
            coachToolStripMenuItem.ForeColor = Color.Black;
            michaelKorsToolStripMenuItem.ForeColor = Color.Black;
            toryBurchToolStripMenuItem.ForeColor = Color.Black;
            kateSpadeToolStripMenuItem.ForeColor = Color.Black;
            fillToolStripMenuItem.ForeColor = Color.Black;
            brandToolStripMenuItem.ForeColor = Color.Black;
            newWithTagsBrandToolStripMenuItem.ForeColor = Color.Black;
            typicalBagToolStripMenuItem.ForeColor = Color.Black;
            nWTCoachToolStripMenuItem.ForeColor = Color.Black;
            nWTKateSpadeToolStripMenuItem.ForeColor = Color.Black;
            nWTMichaelKorsToolStripMenuItem.ForeColor = Color.Black;
            nWTToolStripMenuItem.ForeColor = Color.Black;
            nWTToryBurchToolStripMenuItem.ForeColor = Color.Black;
            cottonToolStripMenuItem.ForeColor = Color.Black;
            fabricToolStripMenuItem.ForeColor = Color.Black;
            leatherToolStripMenuItem.ForeColor = Color.Black;
            nylonToolStripMenuItem.ForeColor = Color.Black;
            cHToolStripMenuItem.ForeColor = Color.Black;
            cHSToolStripMenuItem.ForeColor = Color.Black;
            cSToolStripMenuItem.ForeColor = Color.Black;
            hFSToolStripMenuItem.ForeColor = Color.Black;
            hFToolStripMenuItem.ForeColor = Color.Black;
            fSToolStripMenuItem.ForeColor = Color.Black;
            hLSToolStripMenuItem.ForeColor = Color.Black;
            hLToolStripMenuItem.ForeColor = Color.Black;
            lSToolStripMenuItem.ForeColor = Color.Black;
            hNToolStripMenuItem.ForeColor = Color.Black;
            hNSToolStripMenuItem.ForeColor = Color.Black;
            nSToolStripMenuItem.ForeColor = Color.Black;
            handlesStrapToolStripMenuItem.ForeColor = Color.Black;
            defaultToolStripMenuItem.ForeColor = Color.Black;
            sellToolStripMenuItem.ForeColor = Color.Black;
            handbagToolStripMenuItem.ForeColor = Color.Black;
            jewelryToolStripMenuItem.ForeColor = Color.Black;
            makeupToolStripMenuItem.ForeColor = Color.Black;
            shoesToolStripMenuItem.ForeColor = Color.Black;
            dustbagIncludedToolStripMenuItem.ForeColor = Color.Black;
            //listbox
            lstAll.BackColor = Color.White;
            lstAll.ForeColor = Color.Black;

            //labels
            labelitemname.ForeColor = Color.Black;
            labelbrand.ForeColor = Color.Black;
            labelmfp.ForeColor = Color.Black;
            labelmes.ForeColor = Color.Black;
            labelout.ForeColor = Color.Black;
            labelin.ForeColor = Color.Black;
            labeldeso.ForeColor = Color.Black;
            labeldesi.ForeColor = Color.Black;
            labell.ForeColor = Color.Black;
            labelh.ForeColor = Color.Black;
            labeld.ForeColor = Color.Black;
            labelhd.ForeColor = Color.Black;
            labelsd.ForeColor = Color.Black;
            labelzip.ForeColor = Color.Black;
            labelupc.ForeColor = Color.Black;

            //textbox
            txtItemName.BackColor = Color.White;
            txtBrand.BackColor = Color.White;
            txtUPC.BackColor = Color.White;
            txtMI.BackColor = Color.White;
            txtMO.BackColor = Color.White;
            txtZI.BackColor = Color.White;
            txtZO.BackColor = Color.White;
            txtDO1.BackColor = Color.White;
            txtDO2.BackColor = Color.White;
            txtDO3.BackColor = Color.White;
            txtDO4.BackColor = Color.White;
            txtDI1.BackColor = Color.White;
            txtDI2.BackColor = Color.White;
            txtDI3.BackColor = Color.White;
            txtDI4.BackColor = Color.White;
            txtH.BackColor = Color.White;
            txtD.BackColor = Color.White;
            txtL.BackColor = Color.White;
            txtHD.BackColor = Color.White;
            txtSD.BackColor = Color.White;
            cbBrands.BackColor = Color.White;
           

            txtItemName.ForeColor = Color.Black;
            cbBrands.ForeColor = Color.Black;
            txtBrand.ForeColor = Color.Black;
            txtUPC.ForeColor = Color.Black;
            txtMI.ForeColor = Color.Black;
            txtMO.ForeColor = Color.Black;
            txtZI.ForeColor = Color.Black;
            txtZO.ForeColor = Color.Black;
            txtDO1.ForeColor = Color.Black;
            txtDO2.ForeColor = Color.Black;
            txtDO3.ForeColor = Color.Black;
            txtDO4.ForeColor = Color.Black;
            txtDI1.ForeColor = Color.Black;
            txtDI2.ForeColor = Color.Black;
            txtDI3.ForeColor = Color.Black;
            txtDI4.ForeColor = Color.Black;
            txtH.ForeColor = Color.Black;
            txtD.ForeColor = Color.Black;
            txtL.ForeColor = Color.Black;
            txtHD.ForeColor = Color.Black;
            txtSD.ForeColor = Color.Black;
        }

        private void handlesStrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();

            txtDO1.Text = "Handles";
            txtDO2.Text = "Strap";
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            def();
        }

        private void nWTCoachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanme();
            cbBrands.SelectedText = "Coach";
            txtItemName.Text = "NWT Coach $";
        }

        private void makeupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            make = true;
            forms();
        }

        private void handbagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in Handbag. Please try another form.");
        }

        private void jewelryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jewel = true;
            forms();
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shoez = true;
            forms();
        }

        private void dustbagIncludedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDO4.Text = "Dustbag included";
        }

        private void changeSavePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Save_Location f = new Change_Save_Location();
            f.ShowDialog();
            //MessageBox.Show("Coming Soon");
            //changeSavePathToolStripMenuItem.Enabled = false;
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

        private void createFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Please fill in item name in order to continue.");
            }
            else
            {
                //creation of file
                itemname = txtItemName.Text;
                path = "C:\\Users\\Faiqe\\Documents\\listsave\\";
                path = path + "handbag" + "\\" + itemname;
                if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
                if (!Directory.Exists(path + "\\pictures")) { Directory.CreateDirectory(path + "\\pictures"); }
                //  System.Diagnostics.Process.Start(@"C:\\Users\\Faiqe\\Documents\\listsave\\");
                System.Diagnostics.Process.Start(@path);
            }
        }

        public void grind21()
        {
            string name = itemname.Replace("$", "");
            if (o1 == true)
            {
                name1 = name;
                npath1 = source1.Replace(oldfilepath1, path + name1 + " 1" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source1);
                MessageBox.Show(npath1);
                image.Save(npath1, System.Drawing.Imaging.ImageFormat.Jpeg);
                System.Diagnostics.Process.Start(npath1);
            }
        }
        public void grind()
        {
            string name = itemname.Replace("$", "");
            if (o1 == true)
            {
                name1 = name;
                npath1 = source1.Replace(oldfilename1 + oldfilepath1, path + name1 + " 1" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source1);
                image.Save(npath1, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath1);
            }
            if (o2 == true)
            {
                name2 = name;
                npath2 = source2.Replace(oldfilename2, name2 + " 2" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source2);
                image.Save(npath2, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath2);
            }
            if (o3 == true)
            {
                name3 = name;
                npath3 = source3.Replace(oldfilename3, name3 + " 3" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source3);
                image.Save(npath3, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath3);
            }
            if (o4 == true)
            {
                name4 = name;
                npath4 = source4.Replace(oldfilename4, name4 + " 4" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source4);
                image.Save(npath4, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath4);
            }
            if (o5 == true)
            {
                name5 = name;
                npath5 = source5.Replace(oldfilename5, name5 + " 5" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source5);
                image.Save(npath5, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath5);
            }
            if (o6 == true)
            {
                name6 = name;
                npath6 = source6.Replace(oldfilename6, name6 + " 6" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source6);
                image.Save(npath6, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath6);
            }
            if (o7 == true)
            {
                name7 = name;
                npath7 = source7.Replace(oldfilename7, name7 + " 7" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source7);
                image.Save(npath7, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath7);
            }
            if (o8 == true)
            {
                name8 = name;
                npath8 = source8.Replace(oldfilename8, name8 + " 8" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source8);
                image.Save(npath8, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath8);
            }
            if (o9 == true)
            {
                name9 = name;
                npath9 = source9.Replace(oldfilename9, name9 + " 9" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source9);
                image.Save(npath9, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath9);
            }
            if (o10 == true)
            {
                name10 = name;
                npath10 = source10.Replace(oldfilename10, name10 + " 10" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source10);
                image.Save(npath10, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath10);
            }
            if (o11 == true)
            {
                name11 = name;
                npath11 = source11.Replace(oldfilename11, name11 + " 11" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source11);
                image.Save(npath11, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath11);
            }
            if (o12 == true)
            {
                name12 = name;
                npath12 = source12.Replace(oldfilename12, name12 + " 12" + ".Jpeg");
                System.Drawing.Image image = System.Drawing.Image.FromFile(source12);
                image.Save(npath12, System.Drawing.Imaging.ImageFormat.Jpeg);
                //System.Diagnostics.Process.Start(npath12);
            }

            MessageBox.Show("Done at original file location.");
        }

        public void resetpics()
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
        }

        private void openCurrentSavePathToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\\Users\\Faiqe\\Documents\\listsave\\");
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
            //move();
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

        private void labelsd_Click(object sender, EventArgs e)
        {
            debug();
            
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();
            txtDO1.Text = "COLOR Leather";
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();
            txtDO1.Text = "COLOR Fabric";
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetdo();
            txtDO1.Text = "COLOR Nylon";
        }

        public void create()
        {
            //creation of file
            //files saves at "C://Users//Faiq//Desktop//listsave";

            StreamReader w = new StreamReader(variables.f);
            path = w.ReadToEnd();
            //creation of file
            itemname = txtItemName.Text;
            
            path = path  +  "\\" + itemname+"\\";
           // MessageBox.Show(path);
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            if (!Directory.Exists(path + "\\pictures")) { Directory.CreateDirectory(path + "\\pictures"); }
            

            //old
            path = path + "\\" + itemname;

            StreamWriter File = new StreamWriter(path);
            System.Diagnostics.Process.Start(@path);

            //MessageBox.Show(brandname);

            //File.WriteLine("");

            File.WriteLine(itemname);
            File.WriteLine("");

            //description outside
            File.WriteLine("Outside:");
            if (deso1 != "")
            {
                File.WriteLine(deso1);
            }
            if (deso2 != "")
            {
                File.WriteLine(deso2);
            }
            if (deso3 != "")
            {
                File.WriteLine(deso3);
            }
            if (deso4 != "")
            {
                File.WriteLine(deso4);
            }
            if (multiO == 1)
            {
                File.WriteLine(multiO + " Multifunctional Pocket");
            }
            else if (multiO >= 1)
            {
                File.WriteLine(multiO + " Multifunctional Pockets");
            }
            if (zipO == 1)
            {
                File.WriteLine(zipO + " Zip Pocket");
            }
            else if (zipO >= 1)
            {
                File.WriteLine(zipO + " Zip Pockets");
            }
            File.WriteLine(brandname + " Emblem");
            File.WriteLine("");

            //description inside
            File.WriteLine("Inside:");
            if (desi1 != "")
            {
                File.WriteLine(desi1);
            }
            if (desi2 != "")
            {
                File.WriteLine(desi2);
            }
            if (desi3 != "")
            {
                File.WriteLine(desi3);
            }
            if (desi4 != "")
            {
                File.WriteLine(desi4);
            }

            if (multiI == 1)
            {
                File.WriteLine(multiI + " Multifunctional Pocket");
            }
            else if (multiI >= 1)
            {
                File.WriteLine(multiI + " Multifunctional Pockets");
            }
            if (zipI == 1)
            {
                File.WriteLine(zipI + " Zip Pocket");
            }
            else if (zipI >= 1)
            {
                File.WriteLine(zipI + " Zip Pockets");
            }

            File.WriteLine(brandname + " Patch");
            File.WriteLine("");

            //measurements
            File.WriteLine("Approximate Measurements");
            File.WriteLine("");
            File.WriteLine("(Middle Point)");
            File.WriteLine("");
            File.WriteLine(length + " (L) " + height + " (H) " + depth + " (D) ");
            File.WriteLine("");

            if (hdrop == "")
            {
                File.WriteLine("");
            }
            if (hdrop != "")
            {
                File.WriteLine("Handle Drop:");
                File.WriteLine(hdrop + " inches");
                File.WriteLine("");
            }
            if (sdrop == "")
            {
                File.WriteLine("");
            }
            if (sdrop != "")
            {
                File.WriteLine("Strap Drop:");
                File.WriteLine(sdrop + " inches");
                File.WriteLine("");

            }
            File.WriteLine("");
            File.WriteLine("100% Authentic");
            File.WriteLine("Have a nice day!!!!!");
            File.WriteLine("");
            if (upc == "")
            {

            }
            else
            {
                File.WriteLine("UPC: " + upc);
            }
            File.WriteLine("");
            File.WriteLine("File was generated on: " + date + " at " + time);
            File.Close();

            //path = "C://Users//Faiq//Documents//listsave//";
            //grind21();
            //move2();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            create();
            //MessageBox.Show(path);
        }

        public void debug()
        {
            txtItemName.Text = "Debug on";
            cbBrands.SelectedText = "Kate Spade";
            txtUPC.Text = "5886969525414";
            //description outside:
            txtDO1.Text = "a";
            txtDO2.Text = "b";
            txtDO3.Text = "C";
            txtDO4.Text = "";

            //description inside:
            txtDI1.Text = "d";
            txtDI2.Text = "";
            txtDI3.Text = "e";
            txtDI4.Text = "f";

            //Measurements:
            txtL.Text = "4";
            txtH.Text = "3";
            txtD.Text = "1";
            txtHD.Text = "2";
            txtSD.Text = "5";

            //pockets
            txtMO.Text = "0";
            txtMI.Text = "1";
            txtZO.Text = "0";
            txtZI.Text = "1";

            //pictureboxes
            pb1.ImageLocation = @"C:\Users\Faiq\Pictures\test\DSC_0287.JPG";
            pics.pic.pl1 = pb1.ImageLocation;
            pb2.ImageLocation = @"C:\Users\Faiq\Pictures\test\DSC_0287.JPG";
            pics.pic.pl2 = pb1.ImageLocation;
            pb3.ImageLocation = @"C:\Users\Faiq\Pictures\test\DSC_0287.JPG";
            pics.pic.pl3 = pb1.ImageLocation;
            pb4.ImageLocation = @"C:\Users\Faiq\Pictures\test\DSC_0287.JPG";
            pics.pic.pl4 = pb1.ImageLocation;
            pb5.ImageLocation = @"C:\Users\Faiq\Pictures\test\DSC_0287.JPG";
            pics.pic.pl5 = pb1.ImageLocation;
            pb6.ImageLocation = @"C:\Users\Faiq\Pictures\test\DSC_0287.JPG";
            pics.pic.pl6 = pb1.ImageLocation;

            pb7.ImageLocation = @"C: \Users\Faiq\Pictures\test\IMG_1939.JPG";
            pics.pic.pl7 = pb6.ImageLocation;
            pb8.ImageLocation = @"C: \Users\Faiq\Pictures\test\IMG_1939.JPG";
            pics.pic.pl8 = pb6.ImageLocation;
            pb9.ImageLocation = @"C: \Users\Faiq\Pictures\test\IMG_1939.JPG";
            pics.pic.pl9 = pb6.ImageLocation;
            pb10.ImageLocation = @"C: \Users\Faiq\Pictures\test\IMG_1939.JPG";
            pics.pic.pl10 = pb6.ImageLocation;
            pb11.ImageLocation = @"C: \Users\Faiq\Pictures\test\IMG_1939.JPG";
            pics.pic.pl11 = pb6.ImageLocation;
            pb12.ImageLocation = @"C: \Users\Faiq\Pictures\test\IMG_1939.JPG";
            pics.pic.pl12 = pb6.ImageLocation;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBrands.SelectedItem == "Kate Spade")
            {
                txtBrand.Text = "Kate Spade";
                brandname = txtBrand.Text;
                txtBrand.Enabled = false;
            }
            if (cbBrands.SelectedItem == "Tory Burch")
            {
                brandname = "Tory Burch";
                txtBrand.Enabled = false;
            }
            if (cbBrands.SelectedItem == "Michael Kors")
            {
                brandname = "Michael Kors";
                txtBrand.Enabled = false;
            }
            if (cbBrands.SelectedItem == "Coach")
            {
                brandname = "Coach";
                txtBrand.Enabled = false;
            }
            if (cbBrands.SelectedItem == "Other (enter)")
            {
                txtBrand.Enabled = true;
                brandname = txtBrand.Text;
            }
            //MessageBox.Show(brandname);
        }

        public Handbag()
        {

            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            collectnbuild();
        }

        public void collectnbuild()
        {
            //COLLECT

            itemname = txtItemName.Text;
            brandname = txtBrand.Text;
            upc = txtUPC.Text;

            //description outside:
            deso1 = txtDO1.Text;
            deso2 = txtDO2.Text;
            deso3 = txtDO3.Text;
            deso4 = txtDO4.Text;

            //description inside:
            desi1 = txtDI1.Text;
            desi2 = txtDI2.Text;
            desi3 = txtDI3.Text;
            desi4 = txtDI4.Text;

            //pockets
            multiI = Convert.ToInt32(txtMI.Text);
            multiO = Convert.ToInt32(txtMO.Text);
            zipI = Convert.ToInt32(txtZI.Text);
            zipO = Convert.ToInt32(txtZO.Text);

            //Measurements:
            length = txtL.Text;
            height = txtH.Text;
            depth = txtD.Text;
            hdrop = txtHD.Text;
            sdrop = txtSD.Text;

            //date time
            date = System.DateTime.Now.ToString("MM.dd.yyyy");
            time = DateTime.Now.ToString("h:mm:ss tt");

            //BUILD

            //lstAll.Items.Add("");
            //lstAll.Items.Add();

            lstAll.Items.Add(itemname);
            lstAll.Items.Add("");

            //description outside
            lstAll.Items.Add("Outside:");
            if (deso1 != "")
            {
                lstAll.Items.Add(deso1);
            }
            if (deso2 != "")
            {
                lstAll.Items.Add(deso2);
            }
            if (deso3 != "")
            {
                lstAll.Items.Add(deso3);
            }
            if (deso4 != "")
            {
                lstAll.Items.Add(deso4);
            }
            lstAll.Items.Add(brandname + " Emblem");
            lstAll.Items.Add("");
            //zipO = Convert.ToInt16(txtZO.Text);
            if (multiO == 1)
            {
                lstAll.Items.Add(multiO + " Multifunctional Pocket");
            }
            else if (multiO >= 1)
            {
                lstAll.Items.Add(multiO + " Multifunctional Pockets");
            }
            if (zipO == 1)
            {
                lstAll.Items.Add(zipO + " Zip Pocket");
            }
            else if (zipO >= 1)
            {
                lstAll.Items.Add(zipO + " Zip Pockets");
            }


            //description inside
            lstAll.Items.Add("Inside:");
            if (desi1 != "")
            {
                lstAll.Items.Add(desi1);
            }
            if (desi2 != "")
            {
                lstAll.Items.Add(desi2);
            }
            if (desi3 != "")
            {
                lstAll.Items.Add(desi3);
            }
            if (desi4 != "")
            {
                lstAll.Items.Add(desi4);
            }
            if (multiI == 1)
            {
                lstAll.Items.Add(multiI + " Multifunctional Pocket");
            }
            else if (multiI >= 1)
            {
                lstAll.Items.Add(multiI + " Multifunctional Pockets");
            }
                if (zipI == 1)
                {
                    lstAll.Items.Add(zipI + " Zip Pocket");
                }
                else if (zipI >= 1)
                {
                    lstAll.Items.Add(zipI + " Zip Pockets");
                }
                lstAll.Items.Add("");
            
            lstAll.Items.Add(brandname + " Patch");
            lstAll.Items.Add("");
            //measurements
            lstAll.Items.Add("Approximate Measurements");
                lstAll.Items.Add("");
                lstAll.Items.Add("(Middle Point)");
                lstAll.Items.Add("");
                lstAll.Items.Add(length + " (L) " + height + " (H) " + depth + " (D) ");
                lstAll.Items.Add("");

                if (hdrop != "")
                {
                    lstAll.Items.Add("Handle Drop:");
                    lstAll.Items.Add(hdrop + " inches");
                    lstAll.Items.Add("");
                }
                if (sdrop != "")
                {
                    lstAll.Items.Add("Strap Drop:");
                    lstAll.Items.Add(sdrop + " inches");
                    lstAll.Items.Add("");

                }
                lstAll.Items.Add("");
                lstAll.Items.Add("100% Authentic");
                lstAll.Items.Add("Have a nice day!!!!!");
                lstAll.Items.Add("");
                lstAll.Items.Add("UPC: " + upc);
            lstAll.Items.Add("");
            lstAll.Items.Add("File creation: " + date + " at " + time);


        }
        }
    }

