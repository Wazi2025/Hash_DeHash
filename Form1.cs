using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hash_DeHash
{
    public partial class Mainform : Form
    {
        private string password;
        private bool btnHashClicked = false;
        public Mainform()
        {
            InitializeComponent();
            
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            password = tbPassword.Text;
            tbPassword.Clear();

            tbHashedPassword.Text = Program.HashPassword(password);
            btnHashClicked = true;
        }

        private void btnDeHash_Click(object sender, EventArgs e)
        {
            string hashedPassword = tbHashedPassword.Text;
            
            Program.VerifyPassword(password, hashedPassword);
            tbPassword.Text = password;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                btnHash.Enabled = false;
                btnDeHash.Enabled = false;
            }
            else
            {
                btnHash.Enabled = true;
                //btnDeHash.Enabled = true;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbHashedPassword.Clear();

            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                btnHash.Enabled = false;
                btnDeHash.Enabled = false;
            }
            else
            {
                btnHash.Enabled = true;
                //if(btnHashClicked)
                //    btnDeHash.Enabled = true;
            }
            
        }

        private void tbHashedPassword_TextChanged(object sender, EventArgs e)
        {
            //btnHashClicked = true;
            btnDeHash.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Text = "About";
            aboutBox.ShowDialog();
        }
    }
}
