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

namespace DropShipBoom
{
    public partial class Form1 : Form
    {
        //boxes
        double box;
        double nbox;
        //money
        double money = 0;

        //string path = "C:\Users\Faiq\Documents\Visual Studio 2017\Projects\DropShipBoom\DropShipBoom\files\boxno.txt";
        string path = "C://Users//Faiq//Documents//Visual Studio 2017//Projects//DropShipBoom//DropShipBoom//files//boxno.txt";
        string path2 = "C://Users//Faiq//Documents//Visual Studio 2017//Projects//DropShipBoom//DropShipBoom//files//shiphist.txt";
        string path3 = "C://Users//Faiq//Documents//Visual Studio 2017//Projects//DropShipBoom//DropShipBoom//files//sources.txt";
        string datetime = Convert.ToString(System.DateTime.Today);
        string path4="C://Users//Faiq//Documents//Visual Studio 2017//Projects//DropShipBoom//DropShipBoom//files//archive//";

        string[] Link = new string[100];

        public Form1()
        {
            InitializeComponent();
            datetime = DateTime.Now.ToString();
            refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StreamWriter f = new StreamWriter(path);
            nbox = Convert.ToDouble(txtBoxN.Text);
            box = box + nbox;
            //write boxes

            f.WriteLine(box.ToString());
            f.Close();

            //save to history file
            
            StreamWriter h = new StreamWriter(path2,true);
            if (box >= 1.01)
            {
                h.WriteLine(nbox.ToString() + " boxes made on " + DateTime.Now.ToString());
            }
            else if (box == 1)
            {
                h.WriteLine(nbox.ToString() + " box made on " + DateTime.Now.ToString());
            }
            //h.WriteLine(Convert.ToString(h),nbox.ToString() + " Boxes made on: " + datetim);
            h.Close();

            //upon completion
            MessageBox.Show("Save completed.");
            txtBoxN.Text = "";
            refresh();
        }
    

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            //box number
            string[] lineOfContents = File.ReadAllLines(path);
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                box = Convert.ToDouble(tokens[0]);
                lblBoxNo.Text = box.ToString();
            }

        }

        public void debugship()
        {
            StreamWriter f = new StreamWriter(path);
            f.WriteLine("19");
            f.Close();
            StreamWriter w = new StreamWriter(path2);
            w.WriteLine("19");
            w.Close();
            refresh();
        }

        private void auditSpreadsheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Faiq\Documents\Visual Studio 2017\Projects\DropShipBoom\DropShipBoom\files\quantites.xlsx");
        }

        private void sourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Faiq\Documents\Visual Studio 2017\Projects\DropShipBoom\DropShipBoom\files\sources.txt");
        }

        private void boxNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Faiq\Documents\Visual Studio 2017\Projects\DropShipBoom\DropShipBoom\files\boxno.txt");
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Faiq\Documents\Visual Studio 2017\Projects\DropShipBoom\DropShipBoom\files\shiphist.txt");
        }

        private void numberOfBoxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reset();
            StreamWriter f = new StreamWriter(path);
            f.WriteLine("0");
            f.Close();
            MessageBox.Show("Counter set to 0.");

        }

        public void reset()
        {
            StreamWriter f = new StreamWriter(path);
            f.WriteLine("0");
            f.Close();
            MessageBox.Show("Counter set to 0.");

            //clear active history file
            //path2 = path2.Replace("//shiphist.txt","");
            //MessageBox.Show(path2);
            string day = Convert.ToString(System.DateTime.Today);
            day = day.Replace("/", "-");
            day = day.Replace(":", "");
            day = day.Replace("120000 AM", "");
            //MessageBox.Show(day);

            //write datetime in archive file
            StreamWriter w = new StreamWriter(path2);
            w.WriteLine("File archived on: " + datetime.ToString(), true);
            w.Close();

            //make copy of old file
            //MessageBox.Show(day);
            string npath = path4 + day + " shiphist.txt";
            File.Copy(path2, npath);
            MessageBox.Show("File Copied");

            //clear old file
            StreamWriter h = new StreamWriter(path2);
            h.WriteLine("");
            h.Close();
            refresh();
            MessageBox.Show("file has been archived at: " + npath);
        }
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refreshCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void lblBoxNo_Click(object sender, EventArgs e)
        {

        }
    }
}
