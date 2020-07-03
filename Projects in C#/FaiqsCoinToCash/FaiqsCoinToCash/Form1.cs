using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excel = Microsoft.Office.Interop.Excel;

namespace FaiqsCoinToCash
{
    public partial class Form1 : Form
    {
        string actno;
        double depam;
        double acbal;
        double totbal;
        string paystat;
        string note;
        double newbal;
        public static string ah = "9638887417";
        public static string ais = "9638880380";
        bool a1 = false;
        bool a2 = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.lbDate.Text = dateTime.ToString();
        }

        private void btnOpen_Click (object sender, EventArgs e)
        {
            string w2 = txtActNo.Text;
            if (w2 == ah)
            {
                a1 = true;
                txtDepAm.Enabled = true;
                txtActBal.Enabled = true;
                txtTotal.Enabled = true;
                txtOther.Enabled = true;
                cbPayment.Enabled = true;
                txtNotes.Enabled = true;
                btnComplete.Enabled = true;
                txtActNo.Enabled = false;
                lbD.Text = "Deposit for: Ahmed Shahzad x7417";
            }
            else if (w2 == ais)
            {
                a2 = true;
                txtDepAm.Enabled = true;
                txtActBal.Enabled = true;
                txtTotal.Enabled = true;
                txtOther.Enabled = true;
                cbPayment.Enabled = true;
                txtNotes.Enabled = true;
                btnComplete.Enabled = true;
                txtActNo.Enabled = false;
                lbD.Text = "Deposit for: Aisha Shahzad x0380";
            }
            else
            {
                MessageBox.Show("No account found. Please try again.");
                txtDepAm.Enabled = false;
                txtActBal.Enabled = false;
                txtTotal.Enabled = false;
                txtOther.Enabled = false;
                cbPayment.Enabled = false;
                txtNotes.Enabled = false;
                btnComplete.Enabled = false;
                txtActNo.Enabled = true;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDepAm.Enabled = false;
            txtActBal.Enabled = false;
            txtTotal.Enabled = false;
            txtOther.Enabled = false;
            cbPayment.Enabled = false;
            txtNotes.Enabled = false;
            btnComplete.Enabled = false;
            txtOther.Enabled = false;
        }

        private void lbTransID_Click(object sender, EventArgs e)
        {
           
        }

        public void excelstuff()
        {
            
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a1 = false;
            a2 = false;
            txtDepAm.Text = "";
            txtActBal.Text = "";
            txtTotal.Text = "";
            txtOther.Text = "";
            cbPayment.Text = "";
            txtNotes.Text = "";
            btnComplete.Text = "";
            txtActNo.Text = "";
            lbD.Text = "Deposit for: ";
            txtDepAm.Enabled = false;
            txtActBal.Enabled = false;
            txtTotal.Enabled = false;
            txtOther.Enabled = false;
            cbPayment.Enabled = false;
            txtNotes.Enabled = false;
            btnComplete.Enabled = false;
            txtActNo.Enabled = true;


        }

        private void bulkCoinDepositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BulkCoinDeposit ub = new BulkCoinDeposit();
            ub.ShowDialog();
        }

        public void transact()
        {
            depam = Convert.ToDouble(txtDepAm.Text);
            acbal = Convert.ToDouble(txtActBal.Text);
            txtTotal.Text = Convert.ToString(totbal);
            txtOther.Text = Convert.ToString(cbPayment.SelectedItem);
            paystat = txtOther.Text;
            note = txtNotes.Text;
            if (paystat == "Paid")
            {
                newbal = totbal - 1;
            }
            else if (paystat == "Payment Delayed")
            {
                newbal = totbal;
            }
            else if (paystat != "Paid" || paystat != "Payment Delayed")
            {
                newbal = totbal;
            }
        }
        private void btnComplete_Click(object sender, EventArgs e)
        {
            transact();
        }

        private void txtDepAm_TextChanged(object sender, EventArgs e)
        {
            string[] lineOfContents = File.ReadAllLines("pre.txt");
            string a;
            foreach (var line in lineOfContents)
            {
                string[] tokens = line.Split(',');
                a = tokens[0];
                txtActBal.Text = a;
            }
            total();
            //MessageBox.Show(lineOfContents.ToString());
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
        public void total()
        {
            depam = Convert.ToDouble(txtDepAm.Text);
            acbal = Convert.ToDouble(txtActBal.Text);
            totbal = depam + acbal;
            txtTotal.Text = Convert.ToString(totbal);
        }

        private void cbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPayment.SelectedText == "Other (Enter) >>>")
            {
                txtOther.Enabled = true;
            }
            else
            {
                txtOther.Text = Convert.ToString(cbPayment.SelectedItem);
            }
        }
    }
}
