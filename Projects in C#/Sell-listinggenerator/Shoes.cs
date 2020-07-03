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
using System.Collections.Generic;
using variables;

namespace Sell_listinggenerator
{
    public partial class Shoes : Form
    {
        string name;
        string UPC;

        int print;
        string des1;
        string des2;
        string des3;
        string des4;
        string des5;

        string date;
        string time;

        public Shoes()
        {
            InitializeComponent();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            build();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";
            txtOutDes4.Text = "";
            txtOutDes5.Text = "";
            txtUPC.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            write();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstAll.Items.Clear();
        }

        public void collect()
        {
            des1 = txtOutDes1.Text;
            des2 = txtOutDes2.Text;
            des3 = txtOutDes3.Text;
            des4 = txtOutDes4.Text;
            des5 = txtOutDes5.Text;
            UPC = txtUPC.Text;
            name = txtItemName.Text;
            date = System.DateTime.Now.ToString("MM.dd.yyyy");
            time = DateTime.Now.ToString("h:mm:ss tt");
        }

        public void build()
        {
            collect();

            lstAll.Items.Clear();

            lstAll.Items.Add(name);
            lstAll.Items.Add("");
            lstAll.Items.Add(des1);
            lstAll.Items.Add(des2);
            lstAll.Items.Add(des3);
            lstAll.Items.Add(des4);
            lstAll.Items.Add(des5);
            lstAll.Items.Add("");
            lstAll.Items.Add("100% Authentic");
            lstAll.Items.Add("Have a nice day!!!!!");
            lstAll.Items.Add("");
            lstAll.Items.Add("UPC: " + UPC);
            lstAll.Items.Add("");
            lstAll.Items.Add("File creation: " + date + " at " + time);

        }

        public void write()
        {
            variables.vars.y = "";
            variables.vars.y = variables.vars.y + name + ".txt";
            StreamWriter File = new StreamWriter(variables.vars.y);
            //C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//
            //MessageBox.Show(variables.vars.x);
            System.Diagnostics.Process.Start(@variables.vars.y);

            //File.WriteLine("");
            //+ "/n"--new line

            //btnPrint.Enabled = false;

            File.WriteLine("______________________________________________________");

            File.WriteLine(name);
            File.WriteLine("");

            //File.WriteLine("");

            //description additives
            if (des1 == "")
            {
                File.WriteLine("");
            }
            else if (des1 != "")
            {
                File.WriteLine(des1);
            }
            if (des2 == "")
            {
                File.WriteLine("");
            }
            else if (des2 != "")
            {
                File.WriteLine(des2);
            }
            if (des3 == "")
            {
                File.WriteLine("");
            }
            else if (des3 != "")
            {
                File.WriteLine(des3);
            }
            if (des4 == "")
            {
                File.WriteLine("");
            }
            else if (des4 != "")
            {
                File.WriteLine(des4);
            }
            if (des5 == "")
            {
                File.WriteLine("");
            }
            else if (des5 != "")
            {
                File.WriteLine(des5);
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
           // variables.vars.y = "C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//";

        }

        private void btnTory_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "NIB Tory Burch Flip Flops COLOR";
            txtOutDes1.Text = "Multicolored patterned fabric";
           txtOutDes2.Text = "Tory Burch logo on front of shoes";
            txtOutDes3.Text = "Tory Burch emblem print on shoes";
           txtOutDes4.Text = "Diamond Tory Burch design on the bottom of shoes";
            txtOutDes5.Text = "US Women Size NUMBER shoes";
           MessageBox.Show("Don't forget the UPC code, and update any unknowns (in caps) in the filled in boxes!");
        }

        private void Shoes_Load(object sender, EventArgs e)
        {

        }
    }
}
