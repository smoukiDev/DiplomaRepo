using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaClient
{
    public partial class HashTest : Form
    {
        public HashTest()
        {
            InitializeComponent();
        }

        private void butSI_Click(object sender, EventArgs e)
        {
            string salt =  tbSalt.Text;
            string hash = tbHash.Text;
            SecurityModule sm = new SecurityModule();
            string hash2 = sm.GenerateSHA256Hash(tbPassSI.Text, salt);
            if (hash == hash2)
                MessageBox.Show("Sing in");
            else
                MessageBox.Show("Get Lost");
        }

        private void butHash_Click(object sender, EventArgs e)
        {
            SecurityModule sm = new SecurityModule();
            string salt = sm.GenerateSalt(10);
            tbSalt.Text = salt;
            tbHash.Text = sm.GenerateSHA256Hash(tbPass.Text, salt);
        }

    }
}
