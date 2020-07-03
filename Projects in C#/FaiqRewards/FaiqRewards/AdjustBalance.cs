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
namespace FaiqRewards
{
    public partial class AdjustBalance : Form
    { string path = "C://Users//Faiq//Documents//Visual Studio 2017//Projects//FaiqRewards//FaiqRewards//ai.txt";
        string newbal;

        public AdjustBalance()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newbal = txtPB.Text;
            StreamWriter File = new StreamWriter(path);
            System.Diagnostics.Process.Start(@path);
            File.WriteLine(newbal);
            File.Close();
            this.Close();
        }
    }
}
