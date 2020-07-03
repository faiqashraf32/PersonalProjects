using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vars;
using System.IO;
namespace List
{
    public partial class Change_Save_Location : Form
    {
        public Change_Save_Location()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            variables.loc = txtNew.Text;
            variables.f = "C://Users//Faiq//Documents//Visual Studio 2017//Projects//List//List//loc.txt";
            StreamWriter w = new StreamWriter(variables.f);
            w.WriteLine(variables.loc);
            w.Close();
            MessageBox.Show("Change location successfully. Files will now be saved at: " + variables.loc);
            this.Close();
        }
    }
}
