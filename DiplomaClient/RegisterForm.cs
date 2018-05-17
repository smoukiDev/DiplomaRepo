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
        //actions delay constant
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
            //create variable link to this form
            registerFormBuf = this;
            //error panels fill in color
            pLogin.BackColor = ColorPalette.red1;
            pPassword.BackColor = ColorPalette.red1;
            pConfirmPassword.BackColor = ColorPalette.red1;
            pFName.BackColor = ColorPalette.red1;
            pLName.BackColor = ColorPalette.red1;
            pEmail.BackColor = ColorPalette.red1;
            pPhone.BackColor = ColorPalette.red1;
            pAdress.BackColor =  ColorPalette.red1;
            //erroe log empty
            lblErrorLog.Text = "";

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
        //Register Button
        private void butRegister_Click(object sender, EventArgs e)
        {
            
            //Loading is Visible
            pbLoading.Visible = true;
            //Error is Log Visible
            //lblErrorLog.Visible = true;
            ValidationIsMainFieldsFull();
            
                

        }
        //Checks Is Main Fields Fill in or not
        private void ValidationIsMainFieldsFull()
        {
            //Is Main Fields Fill In
            bool isMainFieldsFull = true;
            //Validation
            if (tbLogin.Text == "")
            {
                pLogin.Visible = true;
                isMainFieldsFull = false;
            }
            else
            {
                pLogin.Visible = false;
                isMainFieldsFull = true;
            }

            if (tbPass.Text == "")
            {
                pPassword.Visible = true;
                isMainFieldsFull = false;
            }
            else
            {
                pPassword.Visible = false;
                isMainFieldsFull = true;
            }

            if (tbPassConfirm.Text == "")
            {
                pConfirmPassword.Visible = true;
                isMainFieldsFull = false;
            }
            else
            {
                pConfirmPassword.Visible = false;
                isMainFieldsFull = true;
            }

            if (tbFName.Text == "")
            {
                pFName.Visible = true;
                isMainFieldsFull = false;
            }
            else
            {
                pFName.Visible = false;
                isMainFieldsFull = true;
            }

            if (tbLName.Text == "")
            {
                pLName.Visible = true;
                isMainFieldsFull = false;
            }
            else
            {
                pLName.Visible = false;
                isMainFieldsFull = true;
            }

            if (tbEmail.Text == "")
            {
                pEmail.Visible = true;
                isMainFieldsFull = false;
            }
            else
            {
                pEmail.Visible = false;
                isMainFieldsFull = true;
            }

            if (mtbPhone.Text == "+" || mtbPhone.Text.Length<11)
            {
                pPhone.Visible = true;
                isMainFieldsFull = false;
            }
            else
            {
                pPhone.Visible = false;
                isMainFieldsFull = true;
            }

            if (rtbAdress.Text == "")
            {
                pAdress.Visible = true;
                isMainFieldsFull = false;
            }
            else
            {
                pAdress.Visible = false;
                isMainFieldsFull = true;
            }
            if (isMainFieldsFull == false)
            {
                lblErrorLog.Text = "Necessary fields weren't filled in:(";
                lblErrorLog.Visible = true;
            }
            else
            {
                lblErrorLog.Text = "";
                lblErrorLog.Visible = false;
            }
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
                ofdProfilePic = new OpenFileDialog();
                ofdProfilePic.ShowDialog();
                FileStream fs = new FileStream(ofdProfilePic.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                var newAvatarPicture = new byte[fs.Length];
                fs.Read(newAvatarPicture, 0, Convert.ToInt32(fs.Length));
                pbAvatar.Image = byteArrayToImage(newAvatarPicture);
                fs.Dispose();

            }
            catch
            {
                //Custom Message Box
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
        //Discard avatar button
        private void butRemoveAvatar_Click(object sender, EventArgs e)
        {
            pbAvatar.Image = Properties.Resources.UserProfileDefault;
        }
        //Phone Field Cursor Autoposition
        private void mtbPhone_MouseClick(object sender, MouseEventArgs e)
        {
            if (mtbPhone.Text == "+")
                mtbPhone.SelectionStart = 1;
            else
                mtbPhone.SelectionStart = mtbPhone.Text.Length;
        }
    }
}
