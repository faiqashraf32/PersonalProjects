using System;
using System.Windows.Forms;
using System.IO;
using variables;
using System.Collections.Generic;



namespace Sell_listinggenerator
{
    public partial class Form1 : Form
    {
        string name;
        double H, D, L;
        double sDrop, hDrop;

        bool strap;
        bool noZipI;
        bool noZipO;
        bool noMFI;
        bool noMFO;


        string multiO;
        string multiI;
        int multiNo1;
        int multiNo2;

        string zipO;
        string zipI;
        int ZipNo1;
        int ZipNo2;

        string bName;
        string patch;
        string emblem;

        string UPC;

        int print;
        string des1;
        string des2;
        string des3;
        string des4;

        string date;
        string time;
       

        //String[] des = new string[5];


        //"C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//print.txt"
        //(@"C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//bin//debug//save");




        public Form1()
        {
            InitializeComponent();      
        }

        private void cbMultiO_CheckedChanged(object sender, EventArgs e)
        {
            multiNo1 = Convert.ToInt16(txtMultiO.Text);

            if (multiNo1 >= 0.01)
            {
                noMFO = true;
            }
            else
            {
                noMFO = false;
            }

            if (multiNo1 > 1)
            {
                multiO = multiNo1 + " Multifunctional Pockets";
            }
            else if (multiNo1 == 1)
            {
                multiO = multiNo1 + " Multifunctional Pocket";
            }
        }

        private void cbZipO_CheckedChanged(object sender, EventArgs e)
        {
            ZipNo1 = Convert.ToInt16(txtZP1.Text);
            
            if (ZipNo1 >= 0.01)
            {
                noZipO = true;
            }
            else
            {
                noZipO = false;
            }

            if (ZipNo1 > 1)
            {
                zipO = ZipNo1 + " Zip Pockets";
            }
            else if (ZipNo1 == 1)
            {
                zipO = ZipNo1 + " Zip Pocket";
            }
           // MessageBox.Show(Convert.ToString(ZipNo1));
        }

        private void cbMultiI_CheckedChanged(object sender, EventArgs e)
        {
            multiNo2 = Convert.ToInt16(txtMultiI.Text);

            if (multiNo2 >= 0.01)
            {
                noMFI = true;
            }
            else
            {
                noMFI = false;
            }

            if (multiNo2 > 1)
            {
                multiI = multiNo2 + " Multifunctional Pockets";
            }
            else if (multiNo2 == 1)
            {
                multiI = multiNo2 + " Multifunctional Pocket";
            }


        }

        private void cbZipI_CheckedChanged(object sender, EventArgs e)
        {
            ZipNo2 = Convert.ToInt16(txtZPI.Text);
            if (ZipNo2 >= 0.01)
            {
                noZipI = true;
            }
            else
            {
                noZipI = false;
            }

            if (ZipNo2 > 1)
            {
                zipI = ZipNo2 + " Zip Pockets";
            }
            else if (ZipNo2 == 1)
            {
                zipI = ZipNo2 + " Zip Pocket";
            }
        }

        private void cbEmblemO_CheckedChanged(object sender, EventArgs e)
        {
            bName = txtBrand.Text;
            emblem = bName + " Emblem";
        }

        private void cbPatchI_CheckedChanged(object sender, EventArgs e)
        {
            bName = txtBrand.Text;
            patch = bName + " Patch";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Please enter values in MFP, ZP, and Brand Name boxes BEFORE checking check boxes! :)");    
            variables.vars.y = "C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstAll.Items.Clear();
            
        }

        private void howToUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("Enter in all of the data for the handbag in all of the text boxes. Click the button labeled Generate to view a preview of the listing text. Click the Print Button to access the formatted text in notepad. All data is saved on the notepad for future reference."),"How To Use");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("Sell is a program designed to help sellers on eBay list handbags. Our software will format all of your listings in a proper and professional format. Sell only is for handbags at this time, but will be open to other types of items in the future."), "About");
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(("For all questions regarding our software, please visit our website: http://castlehs.com/studentsites/2014/faiq/FaiqSitesCorporateSite/index.php or email faiqsites@gmail.com."),"Help");
        }

        private void txtZPO_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            write();
            // else if (print >= 1)
            //   {
            //       System.Diagnostics.Process.Start(@"C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//print.txt");
            //   }

            //System.Diagnostics.Process.Start(@"C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBrand.Text = "";
            txtDepth.Text = "";
            txtHandle.Text = "";
            txtHeight.Text = "";
            txtItemName.Text = "";
            txtLength.Text = "";
            txtMultiI.Text = "";
            txtMultiO.Text = "";
            txtStrap.Text = "";
            txtUPC.Text = "";
            txtZP1.Text = "";
            txtZPI.Text = "";
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";
            bName = "";
            //cbMultiO.Checked = false;
            //cbMultiI.Checked = false;
            //cbPatchI.Checked = false;
            //cbEmblemO.Checked = false;
            //cbZipO.Checked = false;
            //cbZipI.Checked = false;

        }

        private void changeSavePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form2 path = new Form2();
            //path.ShowDialog();
            //Change s = new Change();
            //s.ShowDialog();
            MessageBox.Show(("Coming Soon"),"Not Available");
        }

        private void savePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (variables.vars.x == "")
            {
                MessageBox.Show(("No path found. Define a new one"),"Save Path");
            }
            else
            {
                MessageBox.Show((variables.vars.y),"Save Path");
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            cb();
            collect();
            build();
        }
        public void cb()
        {
            if (cbEmblemO.Checked == false)
            {
                cbEmblemO.Checked = true;
            }
            if (cbPatchI.Checked == false)
            {
                cbPatchI.Checked = true;
            }
            if (cbMultiO.Checked == false)
            {
                cbMultiO.Checked = true;
            }
            if (cbMultiI.Checked == false)
            {
                cbMultiI.Checked = true;
            }
            if (cbZipO.Checked == false)
            {
                cbZipO.Checked = true;
            }
            if (cbZipI.Checked == false)
            {
                cbZipI.Checked = true;
            }
        }
        public void collect()
        {
            check();

            name = txtItemName.Text;
            L = Convert.ToDouble(txtLength.Text);
            H = Convert.ToDouble(txtHeight.Text);
            D = Convert.ToDouble(txtDepth.Text);

            UPC = txtUPC.Text;

            multiNo1 = Convert.ToInt16(txtMultiO.Text);
            multiNo2 = Convert.ToInt16(txtMultiI.Text);
            ZipNo1 = Convert.ToInt16(txtZP1.Text);
            ZipNo2 = Convert.ToInt16(txtZPI.Text);

            bName = txtBrand.Text;

            hDrop = Convert.ToDouble(txtHandle.Text);
            sDrop = Convert.ToDouble(txtStrap.Text);

            if (sDrop == 0)
            {
                strap = false;
            }
            else if (sDrop >= 0.01)
            {
                strap = true;
            }

            des1 = txtOutDes1.Text;
            des2 = txtOutDes2.Text;
            des3 = txtOutDes3.Text;
            des4 = txtOutDes4.Text;

            //date = System.DateTime.Now.ToString("MM.dd.yyyy" + "h:mm:ss tt"); // ("MM.dd.yyyy")
            date = System.DateTime.Now.ToString("MM.dd.yyyy");
            time = DateTime.Now.ToString("h:mm:ss tt");
            //MessageBox.Show("File created on: "+date+ " at "+ time);
            //date = DateTime.Now.ToString("h:mm:ss tt");
        }

        public void check()
        {

            if (txtMultiI.Text == "")
            {
                btnGen.Enabled = false;
                cbMultiI.Enabled = false;
            }
            if (txtMultiO.Text == "")
            {
                btnGen.Enabled = false;
                cbMultiO.Enabled = false;
            }
            if (txtZP1.Text == "")
            {
                btnGen.Enabled = false;
                cbZipI.Enabled = false;
            }
            if (txtZPI.Text == "")
            {
                btnGen.Enabled = false;
                cbZipO.Enabled = false;
            }
            else
            {
                btnGen.Enabled = true;
                cbEmblemO.Enabled = true;
                cbPatchI.Enabled = true;
                cbZipI.Enabled = true;
                cbZipO.Enabled = true;
                cbMultiI.Enabled = true;
                cbMultiO.Enabled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            variables.vars.y = "C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//";
            string path = "C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//";
            System.Diagnostics.Process.Start(@path);
            if (@variables.vars.y == "")
            {
                MessageBox.Show(("No saved location found. Please enter a new one."),"No path found");
            }
           
                
            
        }

        public void build()
        {
            lstAll.Items.Clear();

            lstAll.Items.Add(name);
            
            lstAll.Items.Add("");

            //description
            lstAll.Items.Add("Outside:");

            //description additives (outside)
            if (des1 == "")
            {
                //lstAll.Items.Add("");
            }
            else if (des1 != "")
            {
                lstAll.Items.Add(des1);
            }
            if (des2 == "")
            {
               // lstAll.Items.Add("");
            }
            else if (des2 != "")
            {
                lstAll.Items.Add(des2);
            }
            if (des3 == "")
            {
               // lstAll.Items.Add("");
            }
            else if (des3 != "")
            {
                lstAll.Items.Add(des3);
            }
            if (des4 == "")
            {
                //lstAll.Items.Add("");
            }
            else if (des4 != "")
            {
                lstAll.Items.Add(des4);
            }
            //multifunctional pocket outside
            if (noMFO == true)
            {
                lstAll.Items.Add(multiO);
            }

            //zip pocket outside
            if (noZipO == true)
            {
                lstAll.Items.Add(zipO);
            }

            //emblem
            lstAll.Items.Add(emblem);

            lstAll.Items.Add("");
            lstAll.Items.Add("Inside:");


            //multifunctional pocket inside
            if (noMFI == true)
            {
                lstAll.Items.Add(multiI);
            }

            //zip pocket inside
            if (noZipI == true)
            {
                lstAll.Items.Add(zipI);
            }

            //patch
            lstAll.Items.Add(patch);

            lstAll.Items.Add("");
            lstAll.Items.Add("Approximate Measurements:");
            lstAll.Items.Add("(Middle Point)");
            lstAll.Items.Add(L + " (L) " + H + " (H) " + D + " (D) ");
            lstAll.Items.Add("");
            lstAll.Items.Add("Handle Drop:");
            lstAll.Items.Add(hDrop + " inches");
            if (strap == true)
            {
                lstAll.Items.Add("");
                lstAll.Items.Add("Strap Drop:");
                lstAll.Items.Add(sDrop + " inches");
            }
            lstAll.Items.Add("");
            lstAll.Items.Add("100% Authentic");
            lstAll.Items.Add("Have a nice day!!!!!");
            lstAll.Items.Add("");
            lstAll.Items.Add("");

            lstAll.Items.Add("UPC: " + UPC);
            lstAll.Items.Add("File creation: " + date + " at " + time);


        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            variables.vars.y = "";        
            MessageBox.Show(("Coming Soon. To search, exit this message, and locate the search bar at the top right of the file directory window (which will open after this message disappers). Then type in whatever search term you need to find the right item."),"Search");
            System.Diagnostics.Process.Start(@variables.vars.y);
        }

        private void handbagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 handbag = new Form1();
            handbag.ShowDialog();
        }

        private void makeupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 jewl = new Form4();
            jewl.ShowDialog();
        }

        private void shoeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shoes shoe = new Shoes();
            shoe.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Makeup makeup = new Makeup();
            makeup.ShowDialog();
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            //var brands = new List<string> { "Coach", "Michael Kors", "Kate Spade", "Tory Burch" };
            //var matching = brands.Where(v => v.name);

            //if (name.Contains(brands))
            //{
              //  txtBrand.Text = brands;
            //}
        }

        private void coachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NWT Coach F  $";
            txtBrand.Text = "Coach";
            txtUPC.Text = "889532";
        }

        private void kateSpadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NWT Kate Spade $";
            txtBrand.Text = "Kate Spade";
            txtUPC.Text = "098689";
        }

        private void toryBurchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NWT Tory Burch $";
            txtBrand.Text = "Tory Burch";
            txtUPC.Text = "190041";
        }

        private void michaelKorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NWT Michael Kors $";
            txtBrand.Text = "Michael Kors";
            txtUPC.Text = "888";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtBrand.Text = "TEST BRAND";
            txtDepth.Text = "4";
            txtHandle.Text = "3";
            txtHeight.Text = "2";
            txtItemName.Text = "DEBUG ON DATE ";
            txtLength.Text = "3";
            txtMultiI.Text = "1";
            txtMultiO.Text = "2";
            txtStrap.Text = "4";
            txtUPC.Text = "5345";
            txtZP1.Text = "3";
            txtZPI.Text = "2";
            txtOutDes1.Text = "NEW";
            txtOutDes2.Text = "CLEAN";
            txtOutDes3.Text = "DUSTBAG";
            txtOutDes4.Text = "OLD";
            bName = "TEST";
            //MessageBox.Show("File created on: " + date + " at " + time);
            //date = System.DateTime.Now.ToString("MM.dd.yyyy" + "h:mm:ss tt"); // ("MM.dd.yyyy")
            //date = System.DateTime.Now.ToString("yyyy.MM.dd")
            //MessageBox.Show(System.DateTime.Now.ToString("File created on: "+ ("MM.dd.yyyy") + " at "+ ("h:mm:ss tt"))); // ("MM.dd.yyyy"));
            //date = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void hLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";

            txtOutDes1.Text = "Handles";
            txtOutDes2.Text = "Leather";
            txtOutDes3.Text = "Strap";
        }

        private void hLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";

            txtOutDes1.Text = "Handles";
            txtOutDes2.Text = "Leather";
        }

        private void hSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";

            txtOutDes1.Text = "Handles";
            txtOutDes2.Text = "Strap";
        }

        private void hFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";

            txtOutDes1.Text = "Handles";
            txtOutDes2.Text = "Fabric";
            txtOutDes3.Text = "Strap";
        }

        private void hFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";

            txtOutDes1.Text = "Handles";
            txtOutDes2.Text = "Fabric";
        }

        private void hNSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";

            txtOutDes1.Text = "Handles";
            txtOutDes2.Text = "Nylon";
            txtOutDes3.Text = "Strap";
        }

        private void hNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";

            txtOutDes1.Text = "Handles";
            txtOutDes2.Text = "Nylon";
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Pick a Outside text filler option!");
        }

        private void newWithTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Pick a Title text filler option!");
        }

        private void nWTKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text ="NWT Kate Spade ";
        }

        private void nWTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NWT ";
        }

        private void nWTTBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NWT Tory Burch ";
        }

        private void nWTCOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NWT Coach ";
        }

        private void nWTMKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NWT Michael Kors ";
        }

        public void write()
        {

            //variables.vars.y = "C://Users//Faiq//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//";
            variables.vars.y = "";
            variables.vars.y = variables.vars.y + name + ".txt";
            StreamWriter File = new StreamWriter(variables.vars.y);
            //C://Users//Faiq//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//
            //MessageBox.Show(variables.vars.x);
            System.Diagnostics.Process.Start(@variables.vars.y);

            //File.WriteLine("");
            //+ "/n"--new line

            //btnPrint.Enabled = false;

            File.WriteLine("______________________________________________________");

            File.WriteLine(name);
            File.WriteLine("");

            //description
            File.WriteLine("Outside:");
            //File.WriteLine("");

            //description additives
            if (des1 != "")
            {
                File.WriteLine(des1);
            }
            if (des2 != "")
            {
                File.WriteLine(des2);
            }
            if (des3 != "")
            {
                File.WriteLine(des3);
            }
            if (des4 != "")
            {
                File.WriteLine(des4);
            }

            //multifunctional pocket outside
            if (noMFO == true)
            {
                File.WriteLine(multiO);
            }

            //zip pocket outside
            if (noZipO == true)
            {
                File.WriteLine(zipO);
            }

            //emblem
            File.WriteLine(emblem);

            File.WriteLine("");
            File.WriteLine("Inside:");


            //multifunctional pocket inside
            if (noMFI == true)
            {
                File.WriteLine(multiI);
            }

            //zip pocket inside
            if (noZipI == true)
            {
                File.WriteLine(zipI);
            }

            //patch
            File.WriteLine(patch);

            File.WriteLine("");
            File.WriteLine("Approximate Measurements:");
            File.WriteLine("");
            File.WriteLine("(Middle Point)");
            File.WriteLine(L + " (L) " + H + " (H) " + D + " (D) ");
            File.WriteLine("");
            File.WriteLine("Handle Drop:");
            File.WriteLine(hDrop + " inches");
            if (strap == true)
            {
                File.WriteLine("");
                File.WriteLine("Strap Drop:");
                File.WriteLine(sDrop + " inches");
            }
            File.WriteLine("");
            File.WriteLine("100% Authentic");
            File.WriteLine("Have a nice day!!!!!");
            File.WriteLine("");
            File.WriteLine("UPC: " + UPC);
            File.WriteLine("");
            File.WriteLine("File creation: " + date + " at " + time);
            File.WriteLine("______________________________________________________");

            File.Close();

            print += 1;
            variables.vars.y = "C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//";

        }

        public void donotuse()
        {
            if (txtBrand.Text == "")
            {
                btnGen.Enabled = false;
                cbEmblemO.Enabled = false;
                cbPatchI.Enabled = false;
            }
            if (txtItemName.Text == "")
            {
                btnGen.Enabled = false;
            }
            if (txtLength.Text == "")
            {
                btnGen.Enabled = false;
            }
            if (txtDepth.Text == "")
            {
                btnGen.Enabled = false;
            }
            if (txtHeight.Text == "")
            {
                btnGen.Enabled = false;
            }
            if (txtHandle.Text == "")
            {
                btnGen.Enabled = false;
            }
            if (txtStrap.Text == "")
            {
                btnGen.Enabled = false;
            }
            if (txtUPC.Text == "")
            {
                btnGen.Enabled = false;
            }
        }

        public void fill()
        {
            if (name.Contains("Tory Burch"))
            {
                txtBrand.Text = "Tory Burch";
            }
            else if (name.Contains("Kate Spade"))
            {
                txtBrand.Text = "Kate Spade";
            }
            else if (name.Contains("Coach"))
            {
                txtBrand.Text = "Coach";
            }
            else if (name.Contains("Gucci"))
            {
                txtBrand.Text = "Gucci";
            }
            else
            {
                txtBrand.Text = "";
            }
        }
    }
}
