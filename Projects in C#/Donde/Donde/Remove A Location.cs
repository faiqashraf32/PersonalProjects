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
    public partial class Remove_A_Location : Form
    {
        public Remove_A_Location()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            
            Directory.Delete(variables.vars.path);
            variables.vars.path2 = "C://Users//Faiq//source//repos//Donde//Donde//bin//Debug//loco.txt";
            DeleteLinesFromFile();
        }


        public void DeleteLinesFromFile()
        {
            string strLineToDelete = variables.vars.loc;
            string strFilePath = variables.vars.path2;
            string strSearchText = strLineToDelete;
            string strOldText;
            string n = "";
            StreamReader sr = File.OpenText(strFilePath);
            while ((strOldText = sr.ReadLine()) != null)
            {
                if (!strOldText.Contains(strSearchText))
                {
                    n += strOldText + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(strFilePath, n);
            
            MessageBox.Show(variables.vars.path + " has been removed. The program will now restart in order for the change to take effect.");
            Application.Restart();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            //Remove_A_Location bye = new Remove_A_Location();
            //bye.Close();
            Application.Exit();
            Form1 hello = new Form1();
            hello.ShowDialog();
        }

        private void Remove_A_Location_Load(object sender, EventArgs e)
        {
            lbLoc.Text = variables.vars.path;
        }
    }
}
