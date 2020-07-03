using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using variables;
using System.IO;
using System.Collections.Generic;

namespace Sell_listinggenerator
{
    public partial class Form4 : Form
    {
        string name;     
        string UPC;

        int print;
        string des1;
        string des2;
        string des3;

        string date;
        string time;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtItemName.Text = "";
            txtOutDes1.Text = "";
            txtOutDes2.Text = "";
            txtOutDes3.Text = "";
            txtUPC.Text = "";
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
            lstAll.Items.Add("");
            lstAll.Items.Add("100% Authentic");
            lstAll.Items.Add("Have a nice day!!!!!");
            lstAll.Items.Add("");
            lstAll.Items.Add("UPC: " + UPC);
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
            //variables.vars.y = "C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//";

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            build();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            write();
        }
    }

    }

