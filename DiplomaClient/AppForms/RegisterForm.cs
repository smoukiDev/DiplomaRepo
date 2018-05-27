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
using System.Runtime.InteropServices;
using DiplomaClient.dsSalesHistoryTableAdapters;

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
            butCleanPass.BackColor = ColorPalette.orange1;
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
            pAdress.BackColor = ColorPalette.red1;
            //error log empty
            lblErrorLog.Text = "";
            lblErrorLog.ForeColor = ColorPalette.white1;

            lblPassSecure.Text = "";
            lblPassSecure.ForeColor = ColorPalette.white1;

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

            //Validation Method Connected One with each other
            bool stage1 = ValidationIsMainFieldsFull();
            ValidationPasswordSecure();
            bool stage2 = ValidationPasswordConfirm();
            if(stage1 && stage2)
            {
                try
                {
                    QueriesTableAdapter qta = new QueriesTableAdapter();
                    SecurityModule sm = new SecurityModule();
                    //written as hashing without salt
                    qta.REGISTERCLIENT(tbLogin.Text, tbPass.Text, sm.GenerateSHA256Hash(tbPass.Text), null, tbFName.Text, tbLName.Text, tbMName.Text, tbEmail.Text, mtbPhone.Text, rtbAdress.Text, cbGender.SelectedItem.ToString(), ImageToByteArray(pbAvatar.Image), null, null, null);
                    qta.Dispose();
                }
                catch(Exception ex)
                {
                    CustomMessageBox incorectConfirm = new CustomMessageBox(Properties.Resources.Error, ex.Message, "ОК", () => { registerFormBuf.Enabled = true; }, false, ColorPalette.red1, ColorPalette.white1);
                    this.Enabled = false;
                    incorectConfirm.Show();
                }
            }
            pbLoading.Visible = false;


        }
        //Checks Is Main Fields Fill in or not
        private bool ValidationIsMainFieldsFull()
        {
            bool isSucceess = false;
            //Validation
            if (tbLogin.Text == "")
            {
                pLogin.Visible = true;

            }
            else
            {
                pLogin.Visible = false;
            }

            if (tbPass.Text == "")
            {
                pPassword.Visible = true;

            }
            else
            {
                pPassword.Visible = false;

            }

            if (tbPassConfirm.Text == "")
            {
                pConfirmPassword.Visible = true;

            }
            else
            {
                pConfirmPassword.Visible = false;

            }

            if (tbFName.Text == "")
            {
                pFName.Visible = true;

            }
            else
            {
                pFName.Visible = false;

            }

            if (tbLName.Text == "")
            {
                pLName.Visible = true;

            }
            else
            {
                pLName.Visible = false;
            }

            if (tbEmail.Text == "")
            {
                pEmail.Visible = true;

            }
            else
            {
                pEmail.Visible = false;

            }

            if (mtbPhone.Text == "+" || mtbPhone.Text.Length < 11)
            {
                pPhone.Visible = true;

            }
            else
            {
                pPhone.Visible = false;

            }

            if (rtbAdress.Text == "")
            {
                pAdress.Visible = true;

            }
            else
            {
                pAdress.Visible = false;

            }
            if (pLogin.Visible == true || pPassword.Visible == true || pConfirmPassword.Visible == true || pFName.Visible == true || pLName.Visible == true)
            {
                lblErrorLog.Text = "Necessary fields weren't filled in:(";
                lblErrorLog.Visible = true;
                lblPassSecure.Visible = false;
                isSucceess = false;
            }
            else
            if (pEmail.Visible == true || pPhone.Visible == true || pAdress.Visible == true)
            {
                lblErrorLog.Text = "Necessary fields weren't filled in:(";
                lblErrorLog.Visible = true;
                lblPassSecure.Visible = false;
                isSucceess = false;
            }
            else
            {
                lblErrorLog.Text = "";
                lblErrorLog.Visible = false;
                lblPassSecure.Visible = true;
                isSucceess = true;
            }
            return isSucceess;
        }
        //Compare Pass & Confirm Pass
        private bool ValidationPasswordConfirm()
        {
            bool isSucceess = true;
            if (lblErrorLog.Text == "" || lblErrorLog.Text == "ErrorLog:")
            {
                if (tbPass.Text != tbPassConfirm.Text)
                {
                    CustomMessageBox incorectConfirm = new CustomMessageBox(Properties.Resources.Error, "Password & Confirm Password fields are different!", "ОК", () => { registerFormBuf.Enabled = true; }, false, ColorPalette.red1, ColorPalette.white1);
                    this.Enabled = false;
                    incorectConfirm.Show();
                    isSucceess = false;
                }


            }
            return isSucceess;
        }
        //Check Is Password Contains UpperLetter, Digit, Symbol, Appropriate Lenth
        private void ValidationPasswordSecure()
        {
            if (lblErrorLog.Text == "" || lblErrorLog.Text == "ErrorLog:")
            {

                bool isCaps = false, isDigit = false, isSymbol = false;
                string pass = tbPass.Text;
                for (int i = 0; i < pass.Length; i++)
                {
                    if (char.IsUpper(pass[i]))
                        isCaps = true;
                    if (char.IsDigit(pass[i]))
                        isDigit = true;
                    if (char.IsPunctuation(pass[i]))
                        isSymbol = true;

                }
                if (isCaps == false || isDigit == false || isSymbol == false||pass.Length<8)
                {
                    lblPassSecure.Text = "Insecure Pass. It has to be at least 8 symbols with digit, uppercase letter and symbol.";

                }
                else
                {
                    lblPassSecure.Text = "Secure pass";

                }

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
            pbAvatar.Image = Properties.Resources.UserProfileDefault;
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
        //BackToLogin
        private void pbLogo_Click(object sender, EventArgs e)
        {
            Thread.Sleep(delay1);
            this.Close();
            Program.loginform.Show();
        }
        //Stick To Desctop Bounds
        //WndProc override
        const int DISTANCE = 2;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0046 /* WM_WINDOWPOSCHANGING */)
            {
                Rectangle workArea = SystemInformation.WorkingArea;
                Rectangle rect = (Rectangle)Marshal.PtrToStructure((IntPtr)(IntPtr.Size * 2 + m.LParam.ToInt64()), typeof(Rectangle));

                if (rect.X <= workArea.Left + DISTANCE)
                {
                    Marshal.WriteInt32(m.LParam, IntPtr.Size * 2, workArea.Left);

                }


                if (rect.X + rect.Width >= workArea.Width - DISTANCE)
                {
                    Marshal.WriteInt32(m.LParam, IntPtr.Size * 2, workArea.Right - rect.Width);
                }


                if (rect.Y <= workArea.Top + DISTANCE)
                {
                    Marshal.WriteInt32(m.LParam, IntPtr.Size * 2 + 4, workArea.Top);
                }


                if (rect.Y + rect.Height >= workArea.Height - DISTANCE)
                {
                    Marshal.WriteInt32(m.LParam, IntPtr.Size * 2 + 4, workArea.Bottom - rect.Height);
                }



            }

            base.WndProc(ref m);
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
