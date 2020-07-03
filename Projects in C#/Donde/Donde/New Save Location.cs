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

namespace Donde
{
    public partial class New_Save_Location : Form
    {
        
        string loco;

        public New_Save_Location()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            loco = txtLoco.Text;
            variables.vars.path = variables.vars.path + loco + "//";
            Directory.CreateDirectory(variables.vars.path);
            
            MessageBox.Show("New Location added at: " + variables.vars.path + "The program will now restart in order for the new locations to load in properly.");
            variables.vars.path2 = "C://Users//Faiq//source//repos//Donde//Donde//bin//Debug//loco.txt";
            StreamWriter File =  new StreamWriter(variables.vars.path2,true);
            System.Diagnostics.Process.Start(@variables.vars.path2);
            File.WriteLine(loco);      
            File.Close();
            Application.Exit();
            Application.Restart();
        }
    }
}
