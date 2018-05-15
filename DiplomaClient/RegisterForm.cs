using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Collections;

namespace DiplomaClient
{
    public partial class RegisterForm : Form
    {
        //Reference To This Form in Other Forms
        internal RegisterForm registerFormBuf;
        const int delay1 = 300;
        public RegisterForm()
        {

            InitializeComponent();
            //decoration
            pbLoading.Visible = false;
            lblErrorLog.Visible = false;
            lblWindowTitle.ForeColor = ColorPalette.white1;
            panHeader.BackColor = ColorPalette.grey3;
            panFooter.BackColor = ColorPalette.grey3;
            butRegister.BackColor = ColorPalette.red1;
            butRegister.ForeColor = ColorPalette.white1;
            pbAvatar.BackColor = ColorPalette.white1;
            cbGender.SelectedIndex = 0;
            //displayform
            this.Show();
            registerFormBuf = this;

        }
        //Drag Form Feature
        Point MouseHook;
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {          
                if (e.Button != MouseButtons.Left) MouseHook = e.Location;
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);            
        }
        private void panHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
        private void panFooter_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
        //Close Button with Delay
        private void butClose_Click(object sender, EventArgs e)
        {
            Thread.Sleep(delay1);
            this.Close();
            Program.loginform.Show();
            
        }
        //Mimimize Button with Delay
        private void butMin_Click(object sender, EventArgs e)
        {
            Thread.Sleep(delay1);
            this.WindowState = FormWindowState.Minimized;
        }
        //Make Pass/Passconfirm visible/invisible
        private void buttonMakeVisible1_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '⦁')
                tbPass.PasswordChar = '\0';
            else
                tbPass.PasswordChar = '⦁';
        }

        private void buttonMakeVisible2_Click(object sender, EventArgs e)
        {
            if (tbPassConfirm.PasswordChar == '⦁')
                tbPassConfirm.PasswordChar = '\0';
            else
                tbPassConfirm.PasswordChar = '⦁';
        }

        private void butRegister_Click(object sender, EventArgs e)
        {
            pbLoading.Visible = true;
            lblErrorLog.Visible = true;
        }
        //Clear fields button
        private void butCleanPass_Click(object sender, EventArgs e)
        {
            tbLogin.Clear();
            tbPass.Clear();
            tbPassConfirm.Clear();
            tbFName.Clear();
            tbMName.Clear();
            tbLName.Clear();
            pbAvatar.Image = Properties.Resources.UserProfileDefault;
            cbGender.SelectedIndex = 0;
            tbEmail.Clear();
            mtbPhone.Clear();
            rtbAdress.Clear();

        }
        //Upload Avatar Button
        private void butAddAvatar_Click(object sender, EventArgs e)
        {
            try
            {

                ofdProfilePic.ShowDialog();
                FileStream fs = new FileStream(ofdProfilePic.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                var newAvatarPicture = new byte[fs.Length];
                fs.Read(newAvatarPicture, 0, Convert.ToInt32(fs.Length));
                pbAvatar.Image = byteArrayToImage(newAvatarPicture);

            }
            catch
            {
                CustomMessageBox cmb = new CustomMessageBox(Properties.Resources.ImageNotFound, "Sorry:( Image wasn't been uploaded","OK", () => { registerFormBuf.Enabled = true;}, false,ColorPalette.red1,ColorPalette.white1);
                this.Enabled = false;     
                cmb.Show();
            }
        }

        //Сonvertation Method(Binary Array into Image)
        public Image byteArrayToImage(byte[] byteArrayIn) 
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms, true, false);
            return returnImage;
        }

        private void butRemoveAvatar_Click(object sender, EventArgs e)
        {
            pbAvatar.Image = Properties.Resources.UserProfileDefault;
        }

        private void mtbPhone_MouseClick(object sender, MouseEventArgs e)
        {
            if (mtbPhone.Text == "+")
                mtbPhone.SelectionStart = 1;
            else
                mtbPhone.SelectionStart = mtbPhone.Text.Length;
        }
    }
}
