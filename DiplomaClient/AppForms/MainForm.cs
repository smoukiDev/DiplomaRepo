using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace DiplomaClient
{
    public partial class MainForm : Form
    {
        //constant values in one place
        const int panSliderMIN = 0;
        const int panSliserMAX = 370;
        const int panContentMargin = 13;
        const int FormMaxWidth = 1024;
        const int FormMaxHeight = 768;
        public MainForm()
        {
            InitializeComponent();
            //events
            this.lblMenu.Click += new System.EventHandler(this.pbMenuOne_Click);
            this.pbMenu.Click += new System.EventHandler(this.pbMenuOne_Click);
            //decoration
            label1.ForeColor = ColorPalette.white1;
            //
            panFooter.BackColor = ColorPalette.grey3;
            panMenu.BackColor = ColorPalette.orange1;
            panBackArea.BackColor = ColorPalette.grey3;
            panSlider.BackColor = ColorPalette.red2;
            panProfile.BackColor = ColorPalette.white1;
            //
            buts9.BackColor = ColorPalette.blue1;
            buts9.ForeColor = ColorPalette.white1;
            buts3.BackColor = ColorPalette.white1;
            buts4.BackColor = ColorPalette.white1;
            buts5.BackColor = ColorPalette.white1;
            buts6.BackColor = ColorPalette.white1;
            buts7.BackColor = ColorPalette.white1;
            buts8.BackColor = ColorPalette.white1;
            buts1.BackColor = ColorPalette.white1;
            buts2.BackColor = ColorPalette.white1;
            //


            //slider start width
            panSlider.Width = panSliderMIN;
            
        }
        //Drag Form Method
        Point MouseHook;
        private void panFooter_MouseMove(object sender, MouseEventArgs e)
        {
            //Drag Form
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            {
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
                disAttach = false;
            }
        }
        //Close Form
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Minimize Window
        private void butMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //maximaze & normal window condion
        int wBuf;
        int hBuf;
        Point locBuf;
        private void butMax_Click(object sender, EventArgs e)
        {
            if (this.Width < Screen.PrimaryScreen.Bounds.Width || this.Height < Screen.PrimaryScreen.WorkingArea.Height)
            {
                locBuf = this.Location;
                wBuf = this.Width;
                hBuf = this.Height;
                this.Location = new Point(0, 0);
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;

            }
            else
            {
                this.Width = wBuf;
                this.Height = hBuf;
                this.Location = locBuf;

            }
        }
        private void panFooter_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Width < Screen.PrimaryScreen.Bounds.Width || this.Height < Screen.PrimaryScreen.WorkingArea.Height)
            {
                locBuf = this.Location;
                wBuf = this.Width;
                hBuf = this.Height;
                this.Location = new Point(0, 0);
                this.Width = Screen.PrimaryScreen.Bounds.Width;
                this.Height = Screen.PrimaryScreen.WorkingArea.Height;

            }
            else
            {
                this.Width = wBuf;
                this.Height = hBuf;
                this.Location = locBuf;

            }
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
        //private void lblMenu_Click(object sender, EventArgs e)
        //{
        //    if (panSlider.Width == panSliderMIN)
        //    {
        //        pbMenuOne.Image = Properties.Resources.MenuButtonEnable;
        //        for (int i = 0; i < panSliserMAX; i++)
        //        {
        //            Thread.Sleep(1);
        //            panSlider.Width++;

        //        }
        //        panContent1.Width -= panSliserMAX;
        //        panContent1.Location = new Point(panSliserMAX + panContentMargin, panContent1.Location.Y);
        //    }
        //    else
        //    {

        //        for (int i = 0; i < panSliserMAX; i++)
        //        {
        //            Thread.Sleep(1);
        //            panSlider.Width--;
        //        }
        //        int x = panSliserMAX;
        //        for (int i = 0; i < panSliserMAX; i++)
        //        {
        //            panContent1.Location = new Point(--x + panContentMargin, panContent1.Location.Y);
        //        }

        //        for (int i = 0; i < panSliserMAX; i += 10)
        //        {

        //            panContent1.Width += 10;
        //        }
        //        pbMenuOne.Image = Properties.Resources.MenuButtonDisable;

        //    }
        //}

        //private void pbMenu_Click(object sender, EventArgs e)
        //{

        //    if (panSlider.Width == panSliderMIN)
        //    {
        //        pbMenuOne.Image = Properties.Resources.MenuButtonEnable;
        //        for (int i = 0; i < panSliserMAX; i++)
        //        {
        //            Thread.Sleep(1);
        //            panSlider.Width++;

        //        }
        //        panContent1.Width -= panSliserMAX;
        //        panContent1.Location = new Point(panSliserMAX + panContentMargin, panContent1.Location.Y);
        //    }
        //    else
        //    {

        //        for (int i = 0; i < panSliserMAX; i++)
        //        {
        //            Thread.Sleep(1);
        //            panSlider.Width--;
        //        }
        //        int x = panSliserMAX;
        //        for (int i = 0; i < panSliserMAX; i++)
        //        {
        //            panContent1.Location = new Point(--x + panContentMargin, panContent1.Location.Y);
        //        }

        //        for (int i = 0; i < panSliserMAX; i += 10)
        //        {

        //            panContent1.Width += 10;
        //        }
        //        pbMenuOne.Image = Properties.Resources.MenuButtonDisable;

        //    }

        //}
        bool separate = false;
        //Slider Menu Logo Button 
        private void pbMenuOne_Click(object sender, EventArgs e)
        {
            if (panSlider.Width == panSliderMIN)
            {
                pbMenuOne.Image = Properties.Resources.MenuButtonEnable;
                for (int i = 0; i < panSliserMAX; i++)
                {
                    Thread.Sleep(1);
                    panSlider.Width++;

                }
                panProfile.Width -= panSliserMAX;
                panProfile.Location = new Point(panSliserMAX + panContentMargin, panProfile.Location.Y);
                Thread.Sleep(250);
                buts1.Visible = true;
                buts2.Visible = true;
                buts3.Visible = true;
                buts4.Visible = true;
                buts5.Visible = true;
                buts6.Visible = true;
                buts7.Visible = true;
                buts8.Visible = true;
                buts9.Visible = true;
            }
            else
            {
                buts1.Visible = false;
                buts2.Visible = false;
                buts3.Visible = false;
                buts4.Visible = false;
                buts5.Visible = false;
                buts6.Visible = false;
                buts7.Visible = false;
                buts8.Visible = false;
                buts9.Visible = false;
                Thread.Sleep(250);
                for (int i = 0; i < panSliserMAX; i++)
                {
                    Thread.Sleep(1);
                    panSlider.Width--;
                }
                int x = panSliserMAX;
                for (int i = 0; i < panSliserMAX; i++)
                {
                    panProfile.Location = new Point(--x + panContentMargin, panProfile.Location.Y);
                }

                for (int i = 0; i < panSliserMAX; i += 10)
                {

                    panProfile.Width += 10;
                }
                pbMenuOne.Image = Properties.Resources.MenuButtonDisable;
                

            }
        }
        

        

        int Mx;
        int My;
        int Sw;
        int Sh;
        bool mov;
        //Resize Feature
        private void panBackArea_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            //Cursor changes with resizing
            this.panBackArea.Cursor = System.Windows.Forms.Cursors.SizeAll;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }
        
        private void panBackArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == true)
            {
                int newWidth = MousePosition.X - Mx + Sw;
                int newHeight = MousePosition.Y - My + Sh;
                //Minimal Window Size
                if (newWidth > FormMaxWidth)
                {
                    Width = newWidth;
                }
                if (newHeight > FormMaxHeight)
                {
                    Height = newHeight;
                }


            }
        }

        private void panBackArea_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
            //cursor restore to default when resize finish
            this.panBackArea.Cursor = System.Windows.Forms.Cursors.Default;
        }
        bool disAttach = false;
        private void panFooter_MouseUp(object sender, MouseEventArgs e)
        {
            //Stick To Desktop Corner
            if (!disAttach && this.Width != Screen.PrimaryScreen.Bounds.Width && this.Height != Screen.PrimaryScreen.WorkingArea.Height)
            {
                if (this.Location.X == 0 || this.Location.Y == 0)
                {
                    //Border visible
                    this.Location = new Point(0, 0);
                    this.Width = Screen.PrimaryScreen.Bounds.Width / 2;
                    this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                    disAttach = true;
                    return;
                }
                if (this.Location.X + this.Width == Screen.PrimaryScreen.Bounds.Width || this.Location.Y == 0)
                {

                    this.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, 0);
                    this.Width = Screen.PrimaryScreen.Bounds.Width / 2;
                    this.Height = Screen.PrimaryScreen.WorkingArea.Height;
                    disAttach = true;
                    return;

                }

            }
        }



        //Menu Button switch
        private void buts1_Click(object sender, EventArgs e)
        {

        }

        private void buts2_Click(object sender, EventArgs e)
        {

        }

        private void buts3_Click(object sender, EventArgs e)
        {

        }

        private void buts4_Click(object sender, EventArgs e)
        {

        }

        private void buts5_Click(object sender, EventArgs e)
        {

        }

        private void buts6_Click(object sender, EventArgs e)
        {

        }

        private void buts7_Click(object sender, EventArgs e)
        {

        }

        private void buts8_Click(object sender, EventArgs e)
        {

        }

        private void buts9_Click(object sender, EventArgs e)
        {

        }
    }
}
