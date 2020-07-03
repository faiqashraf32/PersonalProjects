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
using vars;

namespace List
{
    public partial class shoes : Form
    {
        //basics
        string itemname;
        string upc;

        //description
        string des1, des2, des3, des4;

        //other
        string path = vars.variables.f;
        string date;
        string time;

        //forms
        Boolean bag = false;
        Boolean jewel = false;
        Boolean make = false;
        Boolean shoez = false;

        public shoes()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            collectnbuild();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstAll.Items.Clear();

            //clearing form
            txtItemName.Text = "";
            txtDO1.Text = "";
            txtDO2.Text = "";
            txtDO3.Text = "";
            txtDO4.Text = "";


            //reset all variables
            //basics
            itemname = "";
            upc = "";


            //description outside
            des1 = "";
            des2 = "";
            des3 = "";
            des4 = "";


            //other
            path = "C://Users//Faiq//Documents//listsave//";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            create();
        }

        public void darken()
        {
            Handbag.ActiveForm.BackColor = Color.DarkBlue;
            btnGen.BackColor = Color.LightSkyBlue;
            btnReset.BackColor = Color.LightSkyBlue;
            btnSubmit.BackColor = Color.LightSkyBlue;

            //menustrip
            openCurrentSavePathToolStripMenuItem.BackColor = Color.DarkBlue;
            fillToolStripMenuItem.BackColor = Color.DarkBlue;
            modeToolStripMenuItem.BackColor = Color.DarkBlue;
            ms1.BackColor = Color.DarkBlue;
            lightToolStripMenuItem.BackColor = Color.DarkBlue;
            darkToolStripMenuItem.BackColor = Color.DarkBlue;
            sellToolStripMenuItem.BackColor = Color.DarkBlue;
            handbagToolStripMenuItem.BackColor = Color.DarkBlue;
            fillToolStripMenuItem.BackColor = Color.DarkBlue;
            jewelryToolStripMenuItem.BackColor = Color.DarkBlue;
            makeupToolStripMenuItem.BackColor = Color.DarkBlue;
            shoesToolStripMenuItem.BackColor = Color.DarkBlue;

            defaultToolStripMenuItem.BackColor = Color.DarkBlue;

            openCurrentSavePathToolStripMenuItem.ForeColor = Color.GreenYellow;
            fillToolStripMenuItem.ForeColor = Color.GreenYellow;
            modeToolStripMenuItem.ForeColor = Color.GreenYellow;
            lightToolStripMenuItem.ForeColor = Color.GreenYellow;
            darkToolStripMenuItem.ForeColor = Color.GreenYellow;
            fillToolStripMenuItem.ForeColor = Color.GreenYellow;
            defaultToolStripMenuItem.ForeColor = Color.GreenYellow;
            sellToolStripMenuItem.ForeColor = Color.GreenYellow;
            handbagToolStripMenuItem.ForeColor = Color.GreenYellow;
            jewelryToolStripMenuItem.ForeColor = Color.GreenYellow;
            makeupToolStripMenuItem.ForeColor = Color.GreenYellow;
            shoesToolStripMenuItem.ForeColor = Color.GreenYellow;

            //listbox
            lstAll.BackColor = Color.DarkBlue;
            lstAll.ForeColor = Color.FloralWhite;
            //labels
            labelitemname.ForeColor = Color.GreenYellow;
            labelupc.ForeColor = Color.GreenYellow;

            //textbox
            txtItemName.BackColor = Color.DarkBlue;  
            txtUPC.BackColor = Color.DarkBlue;

            txtDO1.BackColor = Color.DarkBlue;
            txtDO2.BackColor = Color.DarkBlue;
            txtDO3.BackColor = Color.DarkBlue;
            txtDO4.BackColor = Color.DarkBlue;



            txtItemName.ForeColor = Color.GreenYellow;
            txtUPC.ForeColor = Color.GreenYellow;

            txtDO1.ForeColor = Color.GreenYellow;
            txtDO2.ForeColor = Color.GreenYellow;
            txtDO3.ForeColor = Color.GreenYellow;
            txtDO4.ForeColor = Color.GreenYellow;

        }

        public void lighten()
        {
            //menustrip back color
            openCurrentSavePathToolStripMenuItem.BackColor = Color.FloralWhite;
            fillToolStripMenuItem.BackColor = Color.FloralWhite;
            modeToolStripMenuItem.BackColor = Color.FloralWhite;
            ms1.BackColor = Color.FloralWhite;
            lightToolStripMenuItem.BackColor = Color.FloralWhite;
            darkToolStripMenuItem.BackColor = Color.FloralWhite;
            sellToolStripMenuItem.BackColor = Color.FloralWhite; ;
            handbagToolStripMenuItem.BackColor = Color.FloralWhite; ;
            fillToolStripMenuItem.BackColor = Color.FloralWhite; ;
            jewelryToolStripMenuItem.BackColor = Color.FloralWhite; ;
            makeupToolStripMenuItem.BackColor = Color.FloralWhite; ;
            shoesToolStripMenuItem.BackColor = Color.FloralWhite; ;



            defaultToolStripMenuItem.BackColor = Color.FloralWhite;
            //menustrip fore color
            openCurrentSavePathToolStripMenuItem.ForeColor = Color.Black;
            fillToolStripMenuItem.ForeColor = Color.Black;
            modeToolStripMenuItem.ForeColor = Color.Black;
            ms1.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;

            fillToolStripMenuItem.ForeColor = Color.Black;

            defaultToolStripMenuItem.ForeColor = Color.Black;
            sellToolStripMenuItem.ForeColor = Color.Black;
            handbagToolStripMenuItem.ForeColor = Color.Black;
            jewelryToolStripMenuItem.ForeColor = Color.Black;
            makeupToolStripMenuItem.ForeColor = Color.Black;
            shoesToolStripMenuItem.ForeColor = Color.Black;

            //labels
            labelitemname.ForeColor = Color.Black;



            //listbox
            lstAll.BackColor = Color.FloralWhite;
            lstAll.ForeColor = Color.Black;

            //textbox back color
            txtItemName.BackColor = Color.Aqua;
            txtUPC.BackColor = Color.Aqua;

            txtDO1.BackColor = Color.Aqua;
            txtDO2.BackColor = Color.Aqua;
            txtDO3.BackColor = Color.Aqua;
            txtDO4.BackColor = Color.Aqua;


            //textbox fore color
            txtItemName.ForeColor = Color.Black;
            txtUPC.ForeColor = Color.Black;

            txtDO1.ForeColor = Color.Black;
            txtDO2.ForeColor = Color.Black;
            txtDO3.ForeColor = Color.Black;
            txtDO4.ForeColor = Color.Black;


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
            txtUPC.BackColor = Color.Aqua;

            txtDO1.BackColor = Color.Aqua;
            txtDO2.BackColor = Color.Aqua;
            txtDO3.BackColor = Color.Aqua;
            txtDO4.BackColor = Color.Aqua;



        }

        public void def()
        {
            Handbag.ActiveForm.BackColor = SystemColors.Control;

            btnGen.BackColor = SystemColors.Control;
            btnReset.BackColor = SystemColors.Control;
            btnSubmit.BackColor = SystemColors.Control;

            //menustrip back color
            openCurrentSavePathToolStripMenuItem.BackColor = SystemColors.Control;
            fillToolStripMenuItem.BackColor = SystemColors.Control;
            modeToolStripMenuItem.BackColor = SystemColors.Control;
            ms1.BackColor = SystemColors.Control;
            lightToolStripMenuItem.BackColor = SystemColors.Control;
            darkToolStripMenuItem.BackColor = SystemColors.Control;

            fillToolStripMenuItem.BackColor = SystemColors.Control;

            defaultToolStripMenuItem.BackColor = SystemColors.Control;
            sellToolStripMenuItem.BackColor = SystemColors.Control;
            handbagToolStripMenuItem.BackColor = SystemColors.Control;
            jewelryToolStripMenuItem.BackColor = SystemColors.Control;
            makeupToolStripMenuItem.BackColor = SystemColors.Control;
            shoesToolStripMenuItem.BackColor = SystemColors.Control;

            //menu strip fore color
            openCurrentSavePathToolStripMenuItem.ForeColor = Color.Black;
            fillToolStripMenuItem.ForeColor = Color.Black;
            modeToolStripMenuItem.ForeColor = Color.Black;
            lightToolStripMenuItem.ForeColor = Color.Black;
            darkToolStripMenuItem.ForeColor = Color.Black;
            fillToolStripMenuItem.ForeColor = Color.Black;
            defaultToolStripMenuItem.ForeColor = Color.Black;
            sellToolStripMenuItem.ForeColor = Color.Black;
            handbagToolStripMenuItem.ForeColor = Color.Black;
            jewelryToolStripMenuItem.ForeColor = Color.Black;
            makeupToolStripMenuItem.ForeColor = Color.Black;
            shoesToolStripMenuItem.ForeColor = Color.Black;

            //listbox
            lstAll.BackColor = Color.White;
            lstAll.ForeColor = Color.Black;

            //labels
            labelitemname.ForeColor = Color.Black;
            labelupc.ForeColor = Color.Black;

            //textbox
            txtItemName.BackColor = Color.White;
            txtUPC.BackColor = Color.White;

            txtDO1.BackColor = Color.White;
            txtDO2.BackColor = Color.White;
            txtDO3.BackColor = Color.White;
            txtDO4.BackColor = Color.White;



            txtItemName.ForeColor = Color.Black;
            txtUPC.ForeColor = Color.Black;

            txtDO1.ForeColor = Color.Black;
            txtDO2.ForeColor = Color.Black;
            txtDO3.ForeColor = Color.Black;
            txtDO4.ForeColor = Color.Black;

        }

        private void openCurrentSavePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@path);
        }

        private void toryBurchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NIB Tory Burch Flip Flops COLOR US Women SIZE";
            txtDO1.Text = "Multicolored patterned fabric";
            txtDO2.Text = "Tory Burch logo on front of shoes";
            txtDO3.Text = "Tory Burch emblem print on shoes";
            txtDO4.Text = "Diamond Tory Burch design on the bottom of shoes";
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lighten();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            darken();
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            def();
        }

        private void handbagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bag = true;
            forms();
        }

        private void jewelryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jewel = true;
            forms();
        }

        private void makeupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            make = true;
            forms();
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are already in shoes. Please select another form.");

        }

        public void collectnbuild()
        {
            //COLLECT

            itemname = txtItemName.Text;
            upc = txtUPC.Text;

            //description outside:
            des1 = txtDO1.Text;
            des2 = txtDO2.Text;
            des3 = txtDO3.Text;
            des4 = txtDO4.Text;

            //date time
            date = System.DateTime.Now.ToString("MM.dd.yyyy");
            time = DateTime.Now.ToString("h:mm:ss tt");

            //BUILD

            //lstAll.Items.Add("");
            //lstAll.Items.Add();

            lstAll.Items.Add(itemname);
            lstAll.Items.Add("");

            //description outside
            
            if (des1 != "")
            {
                lstAll.Items.Add(des1);
            }
            if (des2 != "")
            {
                lstAll.Items.Add(des2);
            }
            if (des3 != "")
            {
                lstAll.Items.Add(des3);
            }
            if (des4 != "")
            {
                lstAll.Items.Add(des4);
            }

            lstAll.Items.Add("");

            lstAll.Items.Add("");
            lstAll.Items.Add("100% Authentic");
            lstAll.Items.Add("Have a nice day!!!!!");
            lstAll.Items.Add("");
            lstAll.Items.Add("UPC: " + upc);
            lstAll.Items.Add("");
            lstAll.Items.Add("File creation: " + date + " at " + time);

        }

        public void create()
        {
            //creation of file
            itemname = txtItemName.Text;
            path = path + "\\" + "Shoes" + "\\" + itemname;
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            if (!Directory.Exists(path + "\\pictures")) { Directory.CreateDirectory(path + "\\pictures"); }
            //MessageBox.Show(path + "\\" + itemname);

            //old
            path = path + "\\" + itemname;

            StreamWriter File = new StreamWriter(path);
            System.Diagnostics.Process.Start(@path);

            //File.WriteLine("");

            File.WriteLine(itemname);
            File.WriteLine("");

            //description outside
            File.WriteLine("Outside:");
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



        }

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
    }
}
