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
using variables;
using System.Dynamic;


namespace Donde
{
    public partial class Form1 : Form
    {
        string itemname;
        string upc;
        string quantity;
        string location;
        string date= System.DateTime.Now.ToString("MM.dd.yyyy");
        string time = System.DateTime.Now.ToString("h:mm:ss tt");
        string path = "C://Users//Faiq//Documents//dondefiles//";
        bool place = false;

        

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            data();
        }

        public void data()
        {
            itemname = txtItemName.Text;
            upc = txtUPC.Text;
            quantity = txtQuantity.Text;


            if (cbloco.Text == "1")
            {
                path = "C://Users//Faiq//Documents//dondefiles//1";
                location = "1";
            }
            if (cbloco.Text == "2")
            {
                path = "C://Users//Faiq//Documents//dondefiles//2";
                location = "";
            }
            if (cbloco.Text == "3")
            {
                path = "C://Users//Faiq//Documents//dondefiles//3";
                location = "3";
            }
            if (cbloco.Text == "4")
            {
                path = "C://Users//Faiq//Documents//dondefiles//4";
                location = "4";
            }
            if (cbloco.Text == "5")
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lbdate.Text = date;
            //lbtime.Text = time;

           

            //locations
            string[] lineOfContents = File.ReadAllLines("Loco.txt");
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                cbloco.Items.Add(tokens[0]);
            }
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtQuantity.Text = "";
            txtUPC.Text = "";
            cbloco.Text = "";

            itemname = "";
            upc = "";
            quantity = "";
            location = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "Tom Clancy";
            txtUPC.Text = "654564165456";
            txtQuantity.Text = "3";
            cbloco.SelectedText = "5";
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C://Users//Faiq//Documents//dondefiles//");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Save_Location form = new New_Save_Location();
            form.ShowDialog();
            
        }

        private void cbloco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbloco.SelectedValue == "")
            {
                place = false;
            }
            else if (cbloco.SelectedValue != "")
            {
                place = true;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (place == false)
            {
                MessageBox.Show("Please select a location via the 'Stored At' drop down menu.");
            }
            //if (variables.vars.loc == "")
            //{
              //  MessageBox.Show("Please select a location via the 'Stored At' drop down menu.");
            //}
            else if (place == true)
            {
                bye();
            }
            
              
            
            
        }
        public void bye()
        {
            variables.vars.loc = cbloco.SelectedText.ToString();
            variables.vars.path = variables.vars.path + variables.vars.loc;
            Remove_A_Location bye = new Remove_A_Location();
            bye.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_an_Item del = new Delete_an_Item();
            del.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lbtime.Text = dateTime.ToString();

        }
    }
}
