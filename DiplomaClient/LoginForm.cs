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
            pbLoading.Visible = true;
        }
        private void butReg_Click(object sender, EventArgs e)
        {
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
    }
}
