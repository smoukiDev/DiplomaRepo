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
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panFooter_MouseMove);        
            //DECORATION
            lblTitle.ForeColor = ColorPalette.white1;
            //general window panels design
            panFooter.BackColor = ColorPalette.grey3;
            panMenu.BackColor = ColorPalette.orange1;
            panBackArea.BackColor = ColorPalette.grey3;
            panSlider.BackColor = ColorPalette.red2;
            //slider menu buttons design
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
            //models panel design
            panReportHeader.BackColor = ColorPalette.white1;
            butAnalysis.BackColor = ColorPalette.red2;
            butAnalysis.ForeColor = ColorPalette.white1;
            //admin panel design
            //panAdminPanel.BackColor = ColorPalette.white1;
            panelAdminPanelHeader.BackColor = ColorPalette.white1;
            panAdminPanelFooter.BackColor = ColorPalette.white1;
            butUserData.BackColor = ColorPalette.red2;
            butUserActivity.BackColor = ColorPalette.red2;
            butUserModules.BackColor = ColorPalette.red2;
            butUserData.ForeColor = ColorPalette.white1;
            butUserActivity.ForeColor = ColorPalette.white1;
            butUserModules.ForeColor = ColorPalette.white1;
            //slider start width
            panSlider.Width = panSliderMIN;
            
        }
        //Drag Form Handler
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
        //Minimize Window condition
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
        //stick distance from bounds
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
        //Slider Menu Handler for 2 picture box buttons & label of Menu
        private void pbMenuOne_Click(object sender, EventArgs e)
        {
            
            if (panSlider.Width == panSliderMIN)
            {

                dgvAdmin.Visible = false;
                // buttons soft animation
                butAnalysis.Visible = false;
                butUserData.Visible = false;
                butUserActivity.Visible = false;
                butUserModules.Visible = false;
                //Switch picture box menu image
                pbMenuOne.Image = Properties.Resources.MenuButtonEnable;
                for (int i = 0; i < panSliserMAX; i++)
                {
                    Thread.Sleep(1);
                    panSlider.Width++;
                    

                }
                panAdminPanel.Width -= panSliserMAX;
                panAdminPanel.Location = new Point(panSliserMAX + panContentMargin, panAdminPanel.Location.Y);
                panProfile.Width -= panSliserMAX;
                panProfile.Location = new Point(panSliserMAX + panContentMargin, panProfile.Location.Y);
                panReport.Width -= panSliserMAX;
                panReport.Location = new Point(panSliserMAX + panContentMargin, panReport.Location.Y);
                Thread.Sleep(250);
                //slider buttons soft animation
                buts1.Visible = true;
                buts2.Visible = true;
                buts3.Visible = true;
                buts4.Visible = true;
                buts5.Visible = true;
                buts6.Visible = true;
                buts7.Visible = true;
                buts8.Visible = true;
                buts9.Visible = true;

                dgvAdmin.Visible = true;
                // buttons soft animation
                butAnalysis.Visible = true;
                butUserData.Visible = true;
                butUserActivity.Visible = true;
                butUserModules.Visible = true;

            }
            else
            {
                dgvAdmin.Visible = false;
                // buttons soft animation
                butAnalysis.Visible = false;
                butUserData.Visible = false;
                butUserActivity.Visible = false;
                butUserModules.Visible = false;
                //slider buttons soft animation
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
                int x1 = panSliserMAX;
                int x2 = panSliserMAX;
                int x3 = panSliserMAX;
                for (int i = 0; i < panSliserMAX; i++)
                {
                    panAdminPanel.Location = new Point(--x1 + panContentMargin, panAdminPanel.Location.Y);
                    panProfile.Location = new Point(--x2 + panContentMargin, panProfile.Location.Y);
                    panReport.Location = new Point(--x3 + panContentMargin, panReport.Location.Y);
                }

                for (int i = 0; i < panSliserMAX; i += 10)
                {

                    panAdminPanel.Width += 10;
                    panProfile.Width += 10;
                    panReport.Width += 10;
                }
                //Switch picture box menu image
                pbMenuOne.Image = Properties.Resources.MenuButtonDisable;

                dgvAdmin.Visible = true;
                // buttons soft animation
                butAnalysis.Visible = true;
                butUserData.Visible = true;
                butUserActivity.Visible = true;
                butUserModules.Visible = true;

            }
        }
        //Resize Feature Varuables & 3 Handlers
        int Mx;
        int My;
        int Sw;
        int Sh;
        bool mov;        
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
        //Stick To Desktop Corner
        //!!!Right Corner Fix Bag
        //Flag Enable Disattach from Desctop Corner
        bool disAttach = false;
        private void panFooter_MouseUp(object sender, MouseEventArgs e)
        {
            
            if (!disAttach && this.Width != Screen.PrimaryScreen.Bounds.Width && this.Height != Screen.PrimaryScreen.WorkingArea.Height)
            {
                if (this.Location.X == 0 || this.Location.Y == 0)
                {
                    //!!!Add Delay and Hightlight Border
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
            panAdminPanel.Visible = false;
            panReport.Visible = false;
            panProfile.Visible = true;
            buts1.BackColor = ColorPalette.orange1;            
            buts2.BackColor = ColorPalette.white1;
            buts3.BackColor = ColorPalette.white1;
            buts4.BackColor = ColorPalette.white1;
            buts5.BackColor = ColorPalette.white1;
            buts6.BackColor = ColorPalette.white1;
            buts7.BackColor = ColorPalette.white1;
            buts8.BackColor = ColorPalette.white1;
            

        }
        private void buts2_Click(object sender, EventArgs e)
        {            
            panReport.Visible = false;
            panProfile.Visible = false;
            panAdminPanel.Visible = true;
            buts1.BackColor = ColorPalette.white1;
            buts2.BackColor = ColorPalette.orange1;
            buts3.BackColor = ColorPalette.white1;
            buts4.BackColor = ColorPalette.white1;
            buts5.BackColor = ColorPalette.white1;
            buts6.BackColor = ColorPalette.white1;
            buts7.BackColor = ColorPalette.white1;
            buts8.BackColor = ColorPalette.white1;
        }
        private void buts3_Click(object sender, EventArgs e)
        {
            
            panProfile.Visible = false;
            panAdminPanel.Visible = false;
            panReport.Visible = true;
            buts1.BackColor = ColorPalette.white1;
            buts2.BackColor = ColorPalette.white1;
            buts3.BackColor = ColorPalette.orange1;
            buts4.BackColor = ColorPalette.white1;
            buts5.BackColor = ColorPalette.white1;
            buts6.BackColor = ColorPalette.white1;
            buts7.BackColor = ColorPalette.white1;
            buts8.BackColor = ColorPalette.white1;
        }
        private void buts4_Click(object sender, EventArgs e)
        {
            panProfile.Visible = false;
            panAdminPanel.Visible = false;
            panReport.Visible = true;
            buts1.BackColor = ColorPalette.white1;
            buts2.BackColor = ColorPalette.white1;
            buts3.BackColor = ColorPalette.white1;
            buts4.BackColor = ColorPalette.orange1;
            buts5.BackColor = ColorPalette.white1;
            buts6.BackColor = ColorPalette.white1;
            buts7.BackColor = ColorPalette.white1;
            buts8.BackColor = ColorPalette.white1;
        }
        private void buts5_Click(object sender, EventArgs e)
        {
            panProfile.Visible = false;
            panAdminPanel.Visible = false;
            panReport.Visible = true;
            buts1.BackColor = ColorPalette.white1;
            buts2.BackColor = ColorPalette.white1;
            buts3.BackColor = ColorPalette.white1;
            buts4.BackColor = ColorPalette.white1;
            buts5.BackColor = ColorPalette.orange1;
            buts6.BackColor = ColorPalette.white1;
            buts7.BackColor = ColorPalette.white1;
            buts8.BackColor = ColorPalette.white1;
        }
        private void buts6_Click(object sender, EventArgs e)
        {
            panProfile.Visible = false;
            panAdminPanel.Visible = false;
            panReport.Visible = true;
            buts1.BackColor = ColorPalette.white1;
            buts2.BackColor = ColorPalette.white1;
            buts3.BackColor = ColorPalette.white1;
            buts4.BackColor = ColorPalette.white1;
            buts5.BackColor = ColorPalette.white1;
            buts6.BackColor = ColorPalette.orange1;
            buts7.BackColor = ColorPalette.white1;
            buts8.BackColor = ColorPalette.white1;
        }
        private void buts7_Click(object sender, EventArgs e)
        {
            panProfile.Visible = false;
            panAdminPanel.Visible = false;
            panReport.Visible = true;
            buts1.BackColor = ColorPalette.white1;
            buts2.BackColor = ColorPalette.white1;
            buts3.BackColor = ColorPalette.white1;
            buts4.BackColor = ColorPalette.white1;
            buts5.BackColor = ColorPalette.white1;
            buts6.BackColor = ColorPalette.white1;
            buts7.BackColor = ColorPalette.orange1;
            buts8.BackColor = ColorPalette.white1;
        }
        private void buts8_Click(object sender, EventArgs e)
        {
            panProfile.Visible = false;
            panAdminPanel.Visible = false;
            panReport.Visible = true;
            buts1.BackColor = ColorPalette.white1;
            buts2.BackColor = ColorPalette.white1;
            buts3.BackColor = ColorPalette.white1;
            buts4.BackColor = ColorPalette.white1;
            buts5.BackColor = ColorPalette.white1;
            buts6.BackColor = ColorPalette.white1;
            buts7.BackColor = ColorPalette.white1;
            buts8.BackColor = ColorPalette.orange1;
        }
        private void buts9_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            //dataGridView1.BorderStyle = BorderStyle.None;
            //dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            //dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            //dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            //dataGridView1.BackgroundColor = Color.White;

            //dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            //dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
