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
using System.Runtime.InteropServices;
using Oracle.ManagedDataAccess.Client;
using DiplomaClient.dsSalesHistoryTableAdapters;


namespace DiplomaClient
{
    public partial class PasswordReset : Form
    {
        //actions delay constant
        const int delay1 = 300;


        public PasswordReset()
        {

            InitializeComponent();
            //events
            //Events Handheld
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.panFooter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.pbLogo.Click +=  new System.EventHandler(this.butMoveBack_Click);           
            //controls decoration 
            panFooter.BackColor = ColorPalette.grey3;
            lblTitle.ForeColor = ColorPalette.white1;           
            butDo.BackColor = ColorPalette.red1;
            butDo.ForeColor = ColorPalette.white1;      
            butUseCode.BackColor = ColorPalette.red1;
            butUseCode.ForeColor = ColorPalette.white1;
            butChangePass.BackColor = ColorPalette.red1;
            butChangePass.ForeColor = ColorPalette.white1;
            lblSendAgain.ForeColor = ColorPalette.red1;
            pbLoading.Visible = false;
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

        //Drag Form Feature
        Point MouseHook;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
        //Close Button with Delay
        private void butClose_Click(object sender, EventArgs e)
        {
            Thread.Sleep(delay1);
            this.Close();
            Environment.Exit(0);
        }
        //Minimize Button with Delay
        private void butMin_Click(object sender, EventArgs e)
        {
            Thread.Sleep(delay1);
            this.WindowState = FormWindowState.Minimized;
        }
        //MoveBack
        private void butMoveBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.loginform.Show();
        }
        //Clear button for Login Textbox
        private void butCleanLogin_Click(object sender, EventArgs e)
        {
            tbEmail.Clear();
        }
        //Clear button for Pass Textbox
        private void butCleanPass_Click(object sender, EventArgs e)
        {
            tbConfirmCode.Clear();
        }
        //Make Visible or Invisible Pass
        private void buttonMakeVisible_Click(object sender, EventArgs e)
        {
            if (tbConfirmCode.PasswordChar == '⦁')
                tbConfirmCode.PasswordChar = '\0';
            else
                tbConfirmCode.PasswordChar = '⦁';
        }


        private void butCleanPass3_Click(object sender, EventArgs e)
        {
            tbPass.Clear();
        }

        private void buttonMakeVisible2_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '⦁')
                tbPass.PasswordChar = '\0';
            else
                tbPass.PasswordChar = '⦁';
        }

        private void butCleanPass4_Click(object sender, EventArgs e)
        {
            tbConfirmPass.Clear();
        }

        private void buttonMakeVisible3_Click(object sender, EventArgs e)
        {
            if (tbConfirmPass.PasswordChar == '⦁')
                tbConfirmPass.PasswordChar = '\0';
            else
                tbConfirmPass.PasswordChar = '⦁';
        }

        string userId = null;
        string userEmail = null;
        string ConfirmPassHash =null;
        SecurityModule sm = new SecurityModule();
        private void butDo_Click(object sender, EventArgs e)
        {
            
            
            bool isSuccess = false;
            
            pbLoading.Visible = true;
            try
            {
                OracleConnection con = new OracleConnection(sm.SalesHistotyConnectionSrtingProp);
                string loginQuery = "SELECT USERID, EMAIL, ISBLOCK FROM CLIENTAPPUSERS";
                OracleDataAdapter adp = new OracleDataAdapter(loginQuery, con);
                DataTable table = new DataTable();
                adp.Fill(table);
                adp.Dispose();
                con.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    if(row[1].ToString()==tbEmail.Text)
                    {
                        if(row[2].ToString()=="F")
                        {
                            userId = row[0].ToString();
                            userEmail = row[1].ToString();
                            isSuccess = true;
                            break;
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                isSuccess = true;
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.Error, ex.Message, "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                error.Show();
            }


            if (isSuccess == false)
            {
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.Error, "There isn't available account with such email adress", "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                error.Show();
            }

            
            
            if(isSuccess)
            {
                try
                {
                    ConfirmPassHash = sm.ForgotPasswordConfirmCode(userEmail, sm.GenerateForgotPasswordConfirmCode());
                    CustomMessageBox success = new CustomMessageBox(Properties.Resources.Success, "Confirm Code has been sent on your Email:)", "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                    this.Enabled = false;
                    success.Show();
                    tbConfirmCode.Enabled = true;
                    butCleanPass2.Enabled = true;
                    buttonMakeVisible1.Enabled = true;
                    butDo.Visible = false;
                    butUseCode.Visible = true;
                    lblSendAgain.Visible = true;
                    
                }
                catch (Exception ex)
                {
                    
                    CustomMessageBox error = new CustomMessageBox(Properties.Resources.ImageNotFound, "404 Not Found - There isn't Internet Connection\n" + ex.Message, "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                    this.Enabled = false;
                    error.Show();
                }
            }
            
            pbLoading.Visible = false;
        }

        private void butUseCode_Click(object sender, EventArgs e)
        {
            
            if(ConfirmPassHash==sm.GenerateSHA256Hash(tbConfirmCode.Text))
            {
                
                tbPass.Enabled = true;
                tbConfirmPass.Enabled = true;
                butCleanPass3.Enabled = true;
                buttonMakeVisible2.Enabled = true;
                butCleanPass4.Enabled = true;
                buttonMakeVisible3.Enabled = true;
                butDo.Visible = false;
                butUseCode.Visible = false;
                butChangePass.Visible = true;
            }
        }
        
        private void butChangePass_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == tbConfirmPass.Text && tbPass.Text != "" && tbConfirmPass.Text != "")
            {
                ValidationPasswordSecure();
                CustomMessageBox update2 = new CustomMessageBox(Properties.Resources.ImageNotFound, false, "Are you sure you want to change password?", () => { this.Enabled = true; }, "Yes", "No", "Cancel", () => { SPFCommitPassword(); }, () => { SPFRevertPassword(); });
                this.Enabled = false;
                update2.Show();
            }
            else
            {
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.Error, "Incorrect Password Confirmation\n OrFieldsEmpty", "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                error.Show();
                tbConfirmPass.Clear();
                tbPass.Clear();
            }
        }

        private void SPFCommitPassword()
        {
            try
            {
                
                QueriesTableAdapter qta = new QueriesTableAdapter();
                qta.UPDATEPASS(Convert.ToDecimal(userId), tbPass.Text, sm.GenerateSHA256Hash(tbPass.Text));
                qta.PASSRESETLOG(Convert.ToDecimal(userId));
                qta.Dispose();

            }
            catch (Exception ex)
            {
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.Error, ex.Message, "ОК", null, true, ColorPalette.red1, ColorPalette.white1);
                error.Show();
            }
            tbEmail.Clear();
            tbConfirmCode.Clear();
            tbConfirmPass.Clear();
            tbPass.Clear();
            butPassValid.Visible = false;
            tbConfirmCode.Enabled = false;
            butCleanPass2.Enabled = false;
            buttonMakeVisible1.Enabled = false;
            tbPass.Enabled = false;
            butCleanPass3.Enabled = false;
            buttonMakeVisible2.Enabled = false;
            tbConfirmPass.Enabled = false;
            butCleanPass3.Enabled = false;
            buttonMakeVisible2.Enabled = false;
            lblSendAgain.Visible = false;
            butChangePass.Visible = false;
            butUseCode.Visible = false;
            butDo.Visible = true;



        }
        private void SPFRevertPassword()
        {
            tbEmail.Clear();
            tbConfirmCode.Clear();
            tbConfirmPass.Clear();
            tbPass.Clear();
            butPassValid.Visible = false;
            tbConfirmCode.Enabled = false;
            butCleanPass2.Enabled = false;
            buttonMakeVisible1.Enabled = false;
            tbPass.Enabled = false;
            butCleanPass3.Enabled = false;
            buttonMakeVisible2.Enabled = false;
            tbConfirmPass.Enabled = false;
            butCleanPass3.Enabled = false;
            buttonMakeVisible2.Enabled = false;
            lblSendAgain.Visible = false;
            butChangePass.Visible = false;
            butUseCode.Visible = false;
            butDo.Visible = true;
        }
        ToolTip ttPassValid = new ToolTip();
        private void ValidationPasswordSecure()
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
            if (isCaps == false || isDigit == false || isSymbol == false || pass.Length < 8)
            {
                butPassValid.BackgroundImage = Properties.Resources.PassValidation;
                ttPassValid.Dispose();
                ttPassValid = new ToolTip();
                ttPassValid.SetToolTip(butPassValid, "Insecure Pass. It has to be at least 8 symbols with digit, uppercase letter and symbol.");
                ttPassValid.ToolTipIcon = ToolTipIcon.Info;
                butPassValid.Visible = true;

            }
            else
            {
                butPassValid.BackgroundImage = Properties.Resources.SaveUpdaterAvatar;
                ttPassValid.Dispose();
                ttPassValid = new ToolTip();
                ttPassValid.SetToolTip(butPassValid, "Secure pass");
                ttPassValid.ToolTipIcon = ToolTipIcon.Info;
                butPassValid.Visible = true;


            }


        }

        private void lblSendAgain_Click(object sender, EventArgs e)
        {
            try
            {
                ConfirmPassHash = sm.ForgotPasswordConfirmCode(userEmail, sm.GenerateForgotPasswordConfirmCode());
                CustomMessageBox success = new CustomMessageBox(Properties.Resources.Success, "Confirm Code has been sent on your Email:)", "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                success.Show();
                
            }
            catch (Exception ex)
            {
                
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.ImageNotFound, "404 Not Found - There isn't Internet Connection\n" + ex.Message, "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                error.Show();
            }
        }
    }
}
