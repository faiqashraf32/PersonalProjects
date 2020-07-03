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

namespace Donde
{
    public partial class Delete_an_Item : Form
    {
        string itemname;
        string upc;
        string quantity;
        string location;
        string date = System.DateTime.Now.ToString("MM.dd.yyyy");
        string time = DateTime.Now.ToString("h:mm:ss tt");
        string path = "C://Users//Faiq//Documents//dondefiles//";
        bool place = false;

        string place2;

        public Delete_an_Item()
        {
            InitializeComponent();
        }

        

        private void Delete_an_Item_Load(object sender, EventArgs e)
        {
            //btnSave.Enabled = false;
            //locations
            string[] lineOfContents = File.ReadAllLines("Loco.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                cbLoco.Items.Add(tokens[0]);
            }

            string[] lineOfContents2 = File.ReadAllLines("Loco.txt");
            foreach (var line in lineOfContents2)
            {
                string[] tokens = line.Split(',');
                cbL2.Items.Add(tokens[0]);
            }
        }

        private void cbLoco_SelectedIndexChanged(object sender, EventArgs e)
        {
            place2 = cbLoco.Text;
            //MessageBox.Show(place);
            go();
        }
        public void go()
        {
            cbItems.Items.Clear();
            //MessageBox.Show(place);
            variables.vars.path = variables.vars.path + place2 + "//";

            string[] files = System.IO.Directory.GetFileSystemEntries(@variables.vars.path);
            

            //if (files.Contains("C://Users//Faiq//Documents//dondefiles//" + place + "//" ))
                           
                this.cbItems.Items.AddRange(files);
            
            variables.vars.path="C://Users//Faiq//Documents//dondefiles//";

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            variables.vars.path = cbItems.Text;
            System.IO.Directory.Delete(variables.vars.path, true);
            //Directory.Delete(@variables.vars.path);
            MessageBox.Show("Item Deleted at " + variables.vars.path);
            variables.vars.path = "C://Users//Faiq//Documents//dondefiles//";
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            create();
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void create()
        { 
            itemname = txtItemName.Text;
            upc = txtUPC.Text;
            quantity = txtQuantity.Text;


            if (cbL2.Text == "1")
            {
                path = "C://Users//Faiq//Documents//dondefiles//1";
                location = "1";
            }
            if (cbL2.Text == "2")
            {
                path = "C://Users//Faiq//Documents//dondefiles//2";
                location = "";
            }
            if (cbL2.Text == "3")
            {
                path = "C://Users//Faiq//Documents//dondefiles//3";
                location = "3";
            }
            if (cbL2.Text == "4")
            {
                path = "C://Users//Faiq//Documents//dondefiles//4";
                location = "4";
            }
            if (cbL2.Text == "5")
            {
                path = "C://Users//Faiq//Documents//dondefiles//5";
                location = "5";
            }
            //MessageBox.Show(path);
            //MessageBox.Show(location);
            //make da dang file
            //creation of file

            path = path + "//" + itemname;
            Directory.CreateDirectory(path);
            //if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
            
            //MessageBox.Show(path + "\\" + itemname);

            
            path = path + "\\" + itemname;

            StreamWriter File = new StreamWriter(path);
            System.Diagnostics.Process.Start(@path);

            File.WriteLine("Item Name: " + itemname);
            File.WriteLine("");
            File.WriteLine("UPC: " + upc);
            File.WriteLine("");
            File.WriteLine("Quantity: " + quantity);
            File.WriteLine("");
            File.WriteLine("Stored at: " + location);
            File.WriteLine("");
            File.WriteLine("Item added to inventory on: " + date + " at " + time);
            File.Close();
            variables.vars.path = "C://Users//Faiq//Documents//dondefiles//";

            //delete old file
            variables.vars.path = variables.vars.path + cbL2.Text + "//";
            System.IO.Directory.Delete(variables.vars.path, true);

            //end
            variables.vars.path = "C://Users//Faiq//Documents//dondefiles//";
        }
    }
}
