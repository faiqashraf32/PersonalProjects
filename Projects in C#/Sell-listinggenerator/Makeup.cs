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
using System.Collections.Generic;


namespace Sell_listinggenerator
{
    public partial class Makeup : Form
    {
        string name;
        string UPC;

        //description
        int print;
        string des1;
        string des2;
        string des3;
        string des4;
        string des5;

        //weight
        string p1;
        string p2;
        string n1;
        string n2;

        bool a1;
        bool a2;
        bool a3;
        bool a4;
        bool a5;

        string date;
        string time;

        public Makeup()
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
            txtN1.Text = "";
            txtN2.Text = "";
            txtP1.Text = "";
            txtP2.Text = "";
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
            p1 = txtP1.Text;
            p2 = txtP2.Text;
            n1 = txtN1.Text;
            n2 = txtN2.Text;

            a1 = false;
            a2 = false;
            a3 = false;
            a4 = false;
            a5 = false;
            date = System.DateTime.Now.ToString("MM.dd.yyyy");
            time = DateTime.Now.ToString("h:mm:ss tt");
        }

        public void build()
        {
            collect();

            lstAll.Items.Clear();

            lstAll.Items.Add(name);
            lstAll.Items.Add("");
            lstAll.Items.Add("Net WT. / POIDS NET: " + n1 + " X " + n2 + " OZ " + "/" + p1 + " X " + p2 + " g");
            lstAll.Items.Add("");
            lstAll.Items.Add("Includes:");
            lstAll.Items.Add(des1);
            if (des1 != "")
            {
                lstAll.Items.Add(des1);
            }
            else
            {
                lstAll.Items.Add(des2);
            }
            lstAll.Items.Add(des2);
            lstAll.Items.Add(des3);
            lstAll.Items.Add(des4);
            lstAll.Items.Add(des5);
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
            File.WriteLine("Net WT. / POIDS NET: " + n1 + " X " + n2 + " OZ " + "/" + p1 + " X " + p2 + " g");
            File.WriteLine("");
            File.WriteLine("Includes:");
            //description additives
            if (des1 != "")
            {
                File.WriteLine(des1);
                a1 = true;
            }
            else
            {
                File.WriteLine(des2);
                a2 = true;
            }
            if (a2 == true)
            {
                File.WriteLine(des3);
                a3 = true;
            }
            else if (a2 != true)
            {
                File.WriteLine(des2);
                a2 = true;
            }
            if (a3 == true)
            {
                File.WriteLine(des4);
                a4 = true;
            }
            else if (a3 != true)
            {
                File.WriteLine(des3);
                a3 = true;
            }
            if (a4 == true)
            {
                File.WriteLine(des5);
                a5 = true;
            }
            else if (a4 != true)
            {
                File.WriteLine(des4);
                a4 = true;
            }
            if (a5 == true)
            {
                //File.WriteLine("");
            }
            else if (a5 != true)
            {
                File.WriteLine(des5);
                a5 = true;
            }

            //double checker
            if (a1 == false)
            {
                File.WriteLine(des1);
            }
            if (a2 == false)
            {
                File.WriteLine(des2);
            }
            if (a3 == false)
            {
                File.WriteLine(des3);
            }
            if (a4 == false)
            {
                File.WriteLine(des4);
            }
            if (a5 == false)
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
            //variables.vars.y = "C://Users//Qiaf//Documents//Visual Studio 2015//Projects//Sell-listinggenerator//save//";

            a1 = false;
            a2 = false;
            a3 = false;
            a4 = false;
            a5 = false;

            variables.vars.y = "";

        }

        private void Makeup_Load(object sender, EventArgs e)
        {

        }
    }
}
