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
using System.Dynamic;


namespace FaiqeRewards
{
    public partial class Form1 : Form
    {
        string nu;
        int pts;
        string path;
        int lisno;
        Random rnd = new Random(1-1200);
        int y = 0;
        bool db = false;
        string xp;
        string day;
        string log;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            nu = txtActNo.Text;
            if (nu == "1212")
            {
                txtActNo.Enabled = false;
                btnOpen.Enabled = false;
                lb5.Text = "Aisha Shahzad";
                path = "C://Users//Faiqe//Documents//Visual Studio 2017//Projects//FaiqRewards//FaiqRewards//ai.txt";
                txtLisNo.Enabled = true;
                btnCheck.Enabled = true;
                xp = "C://Users//Faiqe//Documents//Visual Studio 2017//Projects//FaiqRewards//FaiqRewards//air.txt";
                log = "C://Users//Faiqe//Documents//Visual Studio 2017//Projects//FaiqRewards//FaiqRewards//aiplog.txt";
                //pts
                string[] lineOfContents = File.ReadAllLines(@"C: \Users\Faiqe\Documents\Visual Studio 2017\Projects\FaiqRewards\FaiqRewards\ai.txt");
                foreach (var line in lineOfContents)
                {
                    string[] tokens = line.Split(',');
                    pts = Convert.ToInt16(tokens[0]);
                    lblPts.Text = pts.ToString();
                }

            }
            else
            {
                MessageBox.Show("Account not found. Please try again.");
                txtActNo.Enabled = true;
                btnOpen.Enabled = true;
            }
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        { 
            //Random rnd = new Random();
            //int x = rnd.Next(1, 1001); 
            //MessageBox.Show(Convert.ToString(x));
            lisno = Convert.ToInt16(txtLisNo.Text);
            day = Convert.ToString(System.DateTime.Now);

            if (db == true)
            {
                pts = pts + lisno * 4;
                StreamWriter File = new StreamWriter(path);
                //System.Diagnostics.Process.Start(@path);
                File.WriteLine(pts.ToString());
                File.Close();
            }
            else if (db == false)
            {
                pts = pts + lisno * 2;
                StreamWriter File = new StreamWriter(path);
                //System.Diagnostics.Process.Start(@path);
                File.WriteLine(pts.ToString());
                File.Close();
            }
            lblPts.Text = pts.ToString();

            //save points history
            //StreamWriter stream = new StreamWriter(log);
            //File.AppendAllText(log, "Points Earned: " + pts + " | " + day + Environment.NewLine);
            //stream.Close();

            if (pts >= 50)
            {
                win();
            }
            else if (pts <= 49.99)
            {
                MessageBox.Show("Customer does not qualify for random drawing.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLisNo.Enabled = false;
            btnCheck.Enabled = false;
            lbDo.Text = "OFF";
        }

        public void win()
        {
            int x = rnd.Next(1, 1201);
            //int x = rnd.Next(1, 1401);
            if (x > 0 && x <=300)
            {
                y = x;
                runX300();
            }
            else if (x >= 301 && x<= 600)
            {
                y = x;
                runX600();
            }
            else if (x >= 601 && x <= 900)
            {
                y = x;
                runX900();
            }
            else if (x >= 901)
            {
                y = x;
                runX901();
            }
        }

        public void runX300()
        {
            if (y>=0 && y<= 100)
            {
                MessageBox.Show("Congratulations! You win $1 off of 1 listing! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "$1 off of 1 listing | " + day + Environment.NewLine);
            }
            else if (y >= 101 && y <= 200)
            {
                MessageBox.Show("Congratulations! You win $1 off of 2 listings! Your lucky number was: " + y.ToString());
                File.AppendAllText(xp, "$1 off of 2 listings | " + day + Environment.NewLine);
                pts = pts - 50;
            }
            else if (y >= 201 && y <= 300)
            {
                MessageBox.Show("Congratulations! You win $1 off of 3 listings! Your lucky number was: " + y.ToString());
                File.AppendAllText(xp, "$1 off of 3 listings | " + day + Environment.NewLine);
                pts = pts - 50;
            }
        }

        public void runX600()
        {
            if (y >= 301 && y <= 400)
            {
                MessageBox.Show("Congratulations! You win $2 off of 1 listing! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "$2 off of 1 listing | " + day + Environment.NewLine);
            }
            else if (y >= 401 && y <= 500)
            {
                MessageBox.Show("Congratulations! You win $2 off of 2 listings! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "$2 off of 2 listings | " + day + Environment.NewLine);
            }
            else if (y >= 501 && y <= 600)
            {
                MessageBox.Show("Congratulations! You win $2 off of 3 listings! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "$2 off of 3 listings | " + day + Environment.NewLine);
            }
        }

        public void runX900()
        {
            if (y >= 601 && y <= 700)
            {
                MessageBox.Show("Congratulations! You win $3 off of 1 listing! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "$3 off of 1 listing | " + day + Environment.NewLine);
            }
            else if (y >= 701 && y <= 800)
            {
                MessageBox.Show("Congratulations! You win $3 off of 2 listings! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "$3 off of 2 listings | " + day + Environment.NewLine);
            }
            else if (y >= 801 && y <= 900)
            {
                MessageBox.Show("Congratulations! You win $3 off of 3 listings! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "$3 off of 3 listings | " + day + Environment.NewLine);
            }
        }

        public void runX901()
        {
            if (y >= 901 && y <= 1000)
            {
                MessageBox.Show("Congratulations! You win 1 free listing! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "1 free listing | " + day + Environment.NewLine);
            }
            else if (y >= 1001 && y <= 1100)
            {
                MessageBox.Show("Congratulations! You win 2 free listings! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "2 free listings | " + day + Environment.NewLine);
            }
            else if (y >= 1101 && y <= 1200)
            {
                MessageBox.Show("Congratulations! You win 3 free listings! Your lucky number was: " + y.ToString());
                pts = pts - 50;
                File.AppendAllText(xp, "3 free listings | " + day + Environment.NewLine);
            }
        }

        private void setPointsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txtActNo.Text == "")
            {
                MessageBox.Show("Please enter a valid card number.");
            }
            else if (txtActNo.Text != "")
            {
                AdjustBalance f = new AdjustBalance();
                f.ShowDialog();
            }
        }

        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtActNo.Enabled = true;
            btnOpen.Enabled = true;
            lb5.Text = "-----";
            lblPts.Text = "-----";
            txtLisNo.Enabled = false;
            btnCheck.Enabled = false;
            txtLisNo.Text = "";
            txtActNo.Text = "";
            db = false;
            lbDo.Text = "OFF";
        }

        private void enableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            db = true;
            lbDo.Text = "On";
        }

        private void disableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            db = false;
            lbDo.Text = "OFF";
        }

        private void rewardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (xp == null)
            {
                MessageBox.Show("Please enter a valid account number below.");
            }
            else if (xp != null)
            {
                System.Diagnostics.Process.Start(xp);
            }
           
        }

        private void setPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void doublePointsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (log == null)
            {
                MessageBox.Show("Please enter a valid account number below.");
            }
            else if (log != null)
            {
                System.Diagnostics.Process.Start(log);
            }
        }
    }
}
