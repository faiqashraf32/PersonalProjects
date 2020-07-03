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

namespace Sell_listinggenerator
{
    public partial class Change : Form
    {
        
        
        public Change()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            variables.vars.y = txtPath.Text;
           
            MessageBox.Show("New File path saved as: " + variables.vars.y);
            this.Close();
            Form1 ui = new Form1();
            ui.ShowDialog();
        }
    }
}
