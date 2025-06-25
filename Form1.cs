using System;
using System.Windows.Forms;


namespace Hash_DeHash
{
    public partial class Mainform : Form
    {
        //Add password field 
        private string password;

        public Mainform()
        {
            InitializeComponent();
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            password = tbPassword.Text;
            tbPassword.Clear();

            tbHashedPassword.Text = Program.HashPassword(password);
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
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbHashedPassword.SelectAll();
            tbHashedPassword.Copy();

            tbHashedPassword.Clear();

            if (!string.IsNullOrEmpty(tbPassword.Text))
                btnHash.Enabled = true;
            else
                btnHash.Enabled = false;
        }

        private void tbHashedPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbHashedPassword.Text))
                btnDeHash.Enabled = true;
            else
                btnDeHash.Enabled = false;
        }



        private void aboutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Text = "About";
            aboutBox.ShowDialog();
        }
    }
}
