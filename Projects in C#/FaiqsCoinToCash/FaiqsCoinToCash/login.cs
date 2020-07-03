using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaiqsCoinToCash
{
    public partial class login : Form
    {
        string uname;
        string pword;


        public login()
        {
            InitializeComponent();
            txtUname.Text = "faiqelite5";
            txtPass.Text = "FCTC4032";
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            uname = txtUname.Text;
            pword = txtPass.Text;

            
            if (uname == "faiqelite5" && pword == "FCTC4032")
            {
                //MessageBox.Show("Welcome to Faiq's Coin to Cash!");
                
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
                
            }
            else if (uname == "faiqelite5" && pword == "FCTC4032")
            {
                MessageBox.Show("The log in information provided is incorrect. Please try again");

            }


        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            // Assign the asterisk to be the password character.
            txtPass.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                txtPass.PasswordChar.ToString();
            }
            else if (cbShow.Checked == false)
            {
                txtPass.PasswordChar = '*';
            }
        }
    }
}
