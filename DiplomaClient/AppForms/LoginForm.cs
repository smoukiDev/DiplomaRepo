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
    public partial class LoginForm : Form
    {
        //actions delay constant
        const int delay1 = 300;
        
        public LoginForm()
        {

            InitializeComponent();
            //controls decoration       
            lblForget.ForeColor = ColorPalette.red1;
            butReg.BackColor = ColorPalette.red1;
            butReg.ForeColor = ColorPalette.white1;
            butLog.BackColor = ColorPalette.red1;
            butLog.ForeColor = ColorPalette.white1;
            pbLoading.Visible = false;
            try
            {
                SecurityModule sm = new SecurityModule();
                Oracle.ManagedDataAccess.Client.OracleConnection con = new Oracle.ManagedDataAccess.Client.OracleConnection(sm.SalesHistotyConnectionSrtingProp);
                con.Open();
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {

                CustomMessageBox error = new CustomMessageBox(Properties.Resources.ImageNotFound, "404 Not Found - Could not connect to the server\n" + ex.Message, "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                error.Show();
                tbLogin.Enabled = false;
                tbPass.Enabled = false;
                butCleanLogin.Enabled = false;
                butCleanPass.Enabled = false;
                buttonMakeVisible.Enabled = false;
                lblForget.Enabled = false;
                butLog.Enabled = false;
                butReg.Enabled = false;
                

            }
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
        //Clear button for Login Textbox
        private void butCleanLogin_Click(object sender, EventArgs e)
        {
            tbLogin.Clear();
        }
        //Clear button for Pass Textbox
        private void butCleanPass_Click(object sender, EventArgs e)
        {
            tbPass.Clear();
        }
        //Make Visible or Invisible Pass
        private void buttonMakeVisible_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '⦁')
                tbPass.PasswordChar = '\0';
            else
                tbPass.PasswordChar = '⦁';
        }
        private void butLog_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            string isAccountLock = "";
            pbLoading.Visible = true;
            try
            {
                SecurityModule sm = new SecurityModule();
                OracleConnection con = new OracleConnection(sm.SalesHistotyConnectionSrtingProp);
                string loginQuery = "SELECT USERID, LOGIN, PASSHASH, ISBLOCK FROM CLIENTAPPUSERS";
                OracleDataAdapter adp = new OracleDataAdapter(loginQuery, con);
                DataTable table = new DataTable();
                adp.Fill(table);
                adp.Dispose();
                con.Dispose();
                foreach (DataRow row in table.Rows)
                {
                    if (tbLogin.Text == row[1].ToString())
                    {
                        if (sm.GenerateSHA256Hash(tbPass.Text) == row[2].ToString())
                        {
                            if (row[3].ToString() == "F")
                                isAccountLock = "F";
                            if (row[3].ToString()=="T")
                                isAccountLock = "T";
                            if (row[3].ToString()=="F")
                                
                            {
                                
                                isSuccess = true;
                                MainForm mainform = new MainForm(row[0].ToString());
                                QueriesTableAdapter qta = new QueriesTableAdapter();
                                qta.LOGINLOG(Convert.ToDecimal(row[0].ToString()));
                                qta.Dispose();
                                this.Hide();
                                mainform.Show();
                                tbLogin.Clear();
                                tbPass.Clear();
                                break;
                            }
                            
                            


                        }
                    }
                }
            }
            catch(Exception ex)
            {
                isSuccess = true;
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.Error, ex.Message, "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                error.Show();
            }
            if(isAccountLock == "T")
            {
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.Error, "Access to accound has been locked", "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                error.Show();
                pbLoading.Visible = false;
                return;
            }
            if (isSuccess == false)
            {
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.Error, "Incorrect Login or Password", "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                error.Show();
            }
            pbLoading.Visible = false;
        }
        private void butReg_Click(object sender, EventArgs e)
        {
            tbLogin.Clear();
            tbPass.Clear();
            RegisterForm registerForm = new RegisterForm(); 
            this.Hide();
            
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

        private void lblForget_Click(object sender, EventArgs e)
        {
            tbLogin.Clear();
            tbPass.Clear();
            PasswordReset passwordReset = new PasswordReset();
            this.Hide();
            passwordReset.Show();
        }
    }
}
