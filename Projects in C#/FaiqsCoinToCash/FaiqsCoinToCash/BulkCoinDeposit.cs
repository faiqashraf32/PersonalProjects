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
namespace FaiqsCoinToCash
{
    public partial class BulkCoinDeposit : Form
    {
        string dollar;
        string halfdollar;
        string quarter;
        string dime;
        string nickel;
        string penny;
        string other1;
        string note;
        double d;
        double hd;
        double q;
        double d2;
        double n;
        double p;
        double total;
        double other;
        string date = DateTime.Now.ToString();
        string actno;
        string name;
        string path;

        public BulkCoinDeposit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dollar = TXTd.Text;
            d = Convert.ToDouble(TXTd.Text);
            d = d * 1;
            lbD.Text = Convert.ToString(d);
            tot();
        }

        private void txtHD_TextChanged(object sender, EventArgs e)
        {
            halfdollar = txtHD.Text;
            hd = Convert.ToDouble(txtHD.Text);
            hd = hd * 0.5;
            lbHD.Text = Convert.ToString(hd);
            tot();
        }

        private void txtQ_TextChanged(object sender, EventArgs e)
        {
            quarter = txtQ.Text;
            q = Convert.ToDouble(txtQ.Text);
            q = q * 0.25;
            lbQ.Text = Convert.ToString(q);
            tot();
        }

        private void txtD2_TextChanged(object sender, EventArgs e)
        {
            dime = txtD2.Text;
            d2 = Convert.ToDouble(txtD2.Text);
            d2 = d2 * 0.10;
            lbD2.Text = Convert.ToString(d2);
            tot();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            nickel = txtN.Text;
            n = Convert.ToDouble(txtN.Text);
            n=n * 0.05;
            lbN.Text = Convert.ToString(n);
            tot();
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            penny = txtP.Text;
            p = Convert.ToDouble(txtP.Text);
            p = p * 0.01;
            lbP.Text = Convert.ToString(p);
            tot();
        }

        public void tot()
        {
            
            total = d + hd + q + d2 + n + p + other;
            lbTat.Text = total.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            other1 = txtOther.Text;
            other = Convert.ToDouble(txtOther.Text);
            lbOther.Text = Convert.ToString(other);
            tot();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            note = txtNotes.Text;
            actno = txtAct.Text;
            if (actno == FaiqsCoinToCash.Form1.ah)
            {
                name = "Ahmed Shahzad";
            }
            else if (actno == FaiqsCoinToCash.Form1.ais)
            {
                name = "Aisha Shahzad";
            }
            else if (actno != FaiqsCoinToCash.Form1.ais || actno != FaiqsCoinToCash.Form1.ah)
            {
                name = txtAct.Text;
            }
            else
            {
                MessageBox.Show("Account not found. Please try again.");
            }
            //lstAll.Items.Add("");
            lstAll.Items.Add("Bulk coin deposit report at Faiq's Coin To Cash");
            lstAll.Items.Add("Generated on: " + date+ " for account no.: " + actno);
            lstAll.Items.Add("Client Name: " + name);
            lstAll.Items.Add("");
            lstAll.Items.Add("Number of Dollar Coins: " + dollar);
            lstAll.Items.Add("Amount in USD: $" + d);
            lstAll.Items.Add("");
            lstAll.Items.Add("Number of Half Dollar Coins: " + halfdollar);
            lstAll.Items.Add("Amount in USD: $" + hd);
            lstAll.Items.Add("");
            lstAll.Items.Add("Number of Quarter Coins: " + quarter);
            lstAll.Items.Add("Amount in USD: $" + q);
            lstAll.Items.Add("");
            lstAll.Items.Add("Number of Dime Coins: " + dime);
            lstAll.Items.Add("Amount in USD: $" + d2);
            lstAll.Items.Add("");
            lstAll.Items.Add("Number of Nickel Coins: " + nickel);
            lstAll.Items.Add("Amount in USD: $" + n);
            lstAll.Items.Add("");
            lstAll.Items.Add("Number of Penny Coins: " + penny);
            lstAll.Items.Add("Amount in USD: $" + p);
            lstAll.Items.Add("");
            lstAll.Items.Add("Number of Other Currency: " + other1);
            lstAll.Items.Add("Amount in USD: $" + other);
            lstAll.Items.Add("");
            lstAll.Items.Add("Total: " + total);
            lstAll.Items.Add("");
            lstAll.Items.Add("Notes: " + note);
            lstAll.Items.Add("");
            lstAll.Items.Add("---End of report---");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            path = "C:\\Users\\Faiq\\Documents\\Onedrive personal\\OneDrive\\Coin To Cash\\" + "Bulk Coin Report create for "+ name + ".txt";
            StreamWriter File = new StreamWriter(path);
            

            File.WriteLine("Bulk coin deposit report at Faiq's Coin To Cash");
            File.WriteLine("Generated: " + date);
            File.WriteLine("");
            File.WriteLine("Number of Dollar Coins: " + dollar);
            File.WriteLine("Amount in USD: $" + d);
            File.WriteLine("");
            File.WriteLine("Number of Half Dollar Coins: " + halfdollar);
            File.WriteLine("Amount in USD: $" + hd);
            File.WriteLine("");
            File.WriteLine("Number of Quarter Coins: " + quarter);
            File.WriteLine("Amount in USD: $" + q);
            File.WriteLine("");
            File.WriteLine("Number of Dime Coins: " + dime);
            File.WriteLine("Amount in USD: $" + d2);
            File.WriteLine("");
            File.WriteLine("Number of Nickel Coins: " + nickel);
            File.WriteLine("Amount in USD: $" + n);
            File.WriteLine("");
            File.WriteLine("Number of Penny Coins: " + penny);
            File.WriteLine("Amount in USD: $" + p);
            File.WriteLine("");
            File.WriteLine("Number of Other Currency: " + other1);
            File.WriteLine("Amount in USD: $" + other);
            File.WriteLine("");
            File.WriteLine("Total: " + total);
            File.WriteLine("");
            File.WriteLine("Notes: " + note);
            File.WriteLine("");
            File.WriteLine("End of report");
            File.Close();
            System.Diagnostics.Process.Start(@path);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtAct.Text = "Joe Billis";
            TXTd.Text = "19";
            txtD2.Text = "35";
            txtHD.Text = "13";
            txtQ.Text = "44";
            txtP.Text = "45";
            txtN.Text = "15";
            txtNotes.Text = "Paid";
            txtOther.Text = "2"
;        }
    }
}
