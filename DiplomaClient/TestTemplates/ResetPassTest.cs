using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaClient.TestTemplates
{
    public partial class ResetPassTest : Form
    {
        public ResetPassTest()
        {
            InitializeComponent();
        }
        SecurityModule sm;
        private void butSend_Click(object sender, EventArgs e)
        {
            sm = new SecurityModule();
            try
            {
                tbHash.Text = sm.ForgotPasswordConfirmCode(tbEmail.Text, sm.GenerateForgotPasswordConfirmCode());
            }
            catch (Exception ex)
            {
                CustomMessageBox cmb = new CustomMessageBox(null, ex.Message, "OK", () => { this.Enabled = true; }, false, ColorPalette.red2, ColorPalette.white1);
                cmb.Show();
            }
            
        }
    }
}
