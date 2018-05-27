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
using Oracle.ManagedDataAccess.Client;
using DiplomaClient.dsSalesHistoryTableAdapters;

namespace DiplomaClient
{
    public partial class MainForm : Form
    {
        private string userId = "";
        //constant values in one place
        const int panSliderMIN = 0;
        const int panSliserMAX = 370;
        const int panContentMargin = 13;
        const int FormMaxWidth = 1024;
        const int FormMaxHeight = 768;
        public MainForm()
        {
            InitializeComponent();
            //Start up Profile Panel Display          
            panReport.Visible = false;
            panAdminPanel.Visible = false;
            panProfile.Visible = true;
            //Events Handheld
            this.lblMenu.Click += new System.EventHandler(this.pbMenuOne_Click);
            this.pbMenu.Click += new System.EventHandler(this.pbMenuOne_Click);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panFooter_MouseMove);
            //DECORATION//
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
            //report panel design
            panReport.BackColor = ColorPalette.white2;
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
            panAdminPanelSearch.BackColor = ColorPalette.white2;
            ////profile panel design
            //panProfileHeader.BackColor = ColorPalette.white1;            
            panProfile.BackColor = ColorPalette.white2;
            panProfileHeader.BackColor = ColorPalette.white1;
            panProfileAvatar.BackColor = ColorPalette.white2;
            panProfileFooter.BackColor = ColorPalette.white1;
            //Start Up Slider Panel Width
            panSlider.Width = panSliderMIN;
            
        }
        public MainForm(string userId)
        {
            this.userId = userId;
            InitializeComponent();
            //Start up Profile Panel Display          
            panReport.Visible = false;
            panAdminPanel.Visible = false;
            panProfile.Visible = true;
            //Events Handheld
            this.lblMenu.Click += new System.EventHandler(this.pbMenuOne_Click);
            this.pbMenu.Click += new System.EventHandler(this.pbMenuOne_Click);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panFooter_MouseMove);
            //DECORATION//
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
            //report panel design
            panReport.BackColor = ColorPalette.white2;
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
            panAdminPanelSearch.BackColor = ColorPalette.white2;
            ////profile panel design
            //panProfileHeader.BackColor = ColorPalette.white1;            
            panProfile.BackColor = ColorPalette.white2;
            panProfileHeader.BackColor = ColorPalette.white1;
            panProfileAvatar.BackColor = ColorPalette.white2;
            panProfileFooter.BackColor = ColorPalette.white1;
            //Start Up Slider Panel Width
            panSlider.Width = panSliderMIN;

        }
        //Drag Form Handler
        Point MouseHook;
        private void panFooter_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            {
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
                //Stick To Desktop Corners Flag Drop
                disAttach = false;
            }
        }
        //Close Form
        private void butClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
        //Slider Menu Handler
        private void pbMenuOne_Click(object sender, EventArgs e)
        {
            
            if (panSlider.Width == panSliderMIN)
            {

                //soft animation Profile Panel
                butIsAdmin.Visible = false;
                butIsNotAdmin.Visible = false;
                butAvatarDisplay.Visible = false;
                butAddAvatar.Visible = false;
                butRemoveAvatar.Visible = false;
                tbLogin1.Visible = false;
                tbFName.Visible = false;
                tbMName.Visible = false;
                tbLName.Visible = false;
                tbGender.Visible = false;
                tbEmail.Visible = false;
                mtbPhone.Visible = false;
                tbAdress.Visible = false;
                tbOldPassword.Visible = false;
                tbPass.Visible = false;
                tbPassConfirm.Visible = false;
                butEditProfile.Visible = false;
                butSaveProfileChanges.Visible = false;
                butChangePassword.Visible = false;
                buttonMakeVisible1.Visible = false;
                buttonMakeVisible2.Visible = false;
                buttonMakeVisible3.Visible = false;
                butGenderExchange.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;
                lbl6.Visible = false;
                lbl7.Visible = false;
                lbl8.Visible = false;
                lbl9.Visible = false;
                lbl10.Visible = false;
                lbl11.Visible = false;
                // soft animation Report Panel
                butAnalysis.Visible = false;
                reportViewer1.Visible = false;
                // soft animation Admin Panel
                dgvAdmin.Visible = false;
                butUserData.Visible = false;
                butUserActivity.Visible = false;
                butUserModules.Visible = false;
                butBlokUser.Visible = false;
                butAddUser.Visible = false;
                butEditUser.Visible = false;
                butDeleteUser.Visible = false;
                butEditModules.Visible = false;
                tbSearch.Visible = false;
                butSearch.Visible = false;
                butRefreshGrid.Visible = false;
                //Switch picture box menu image
                pbMenuOne.Image = Properties.Resources.MenuButtonEnable;
                //Slider Appearance Animation
                for (int i = 0; i < panSliserMAX; i++)
                {
                    //Thread.Sleep(1);
                    panSlider.Width++;
                    

                }
                //Profile/Admin/Report Panels Resize/Relocation
                panAdminPanel.Width -= panSliserMAX;
                panAdminPanel.Location = new Point(panSliserMAX + panContentMargin, panAdminPanel.Location.Y);
                panProfile.Width -= panSliserMAX;
                panProfile.Location = new Point(panSliserMAX + panContentMargin, panProfile.Location.Y);
                panReport.Width -= panSliserMAX;
                panReport.Location = new Point(panSliserMAX + panContentMargin, panReport.Location.Y);
                //Delay for components reapperance
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
                //soft animation Profile Panel
                butIsAdmin.Visible = true;
                butIsNotAdmin.Visible = true;
                butAvatarDisplay.Visible = true;
                butAddAvatar.Visible = true;
                butRemoveAvatar.Visible = true;
                tbLogin1.Visible = true;
                tbFName.Visible = true;
                tbMName.Visible = true;
                tbLName.Visible = true;
                tbGender.Visible = true;
                tbEmail.Visible = true;
                mtbPhone.Visible = true;
                tbAdress.Visible = true;
                tbOldPassword.Visible = true;
                tbPass.Visible = true;
                tbPassConfirm.Visible = true;
                butEditProfile.Visible = true;
                butSaveProfileChanges.Visible = true;
                butChangePassword.Visible = true;
                buttonMakeVisible1.Visible = true;
                buttonMakeVisible2.Visible = true;
                buttonMakeVisible3.Visible = true;
                butGenderExchange.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                lbl6.Visible = true;
                lbl7.Visible = true;
                lbl8.Visible = true;
                lbl9.Visible = true;
                lbl10.Visible = true;
                lbl11.Visible = true;
                // soft animation Models Panel
                butAnalysis.Visible = true;
                reportViewer1.Visible = true;
                // soft animation admin panel
                dgvAdmin.Visible = true;
                butUserData.Visible = true;
                butUserActivity.Visible = true;
                butUserModules.Visible = true;
                butBlokUser.Visible = true;
                butAddUser.Visible = true;
                butEditUser.Visible = true;
                butDeleteUser.Visible = true;
                butEditModules.Visible = true;
                tbSearch.Visible = true;
                butSearch.Visible = true;
                butRefreshGrid.Visible = true;
            }
            else
            {
                //soft animation Profile Panel
                butIsAdmin.Visible = false;
                butIsNotAdmin.Visible = false;
                butAvatarDisplay.Visible = false;
                butAddAvatar.Visible = false;
                butRemoveAvatar.Visible = false;
                tbLogin1.Visible = false;
                tbFName.Visible = false;
                tbMName.Visible = false;
                tbLName.Visible = false;
                tbGender.Visible = false;
                tbEmail.Visible = false;
                mtbPhone.Visible = false;
                tbAdress.Visible = false;
                tbOldPassword.Visible = false;
                tbPass.Visible = false;
                tbPassConfirm.Visible = false;
                butEditProfile.Visible = false;
                butSaveProfileChanges.Visible = false;
                butChangePassword.Visible = false;
                buttonMakeVisible1.Visible = false;
                buttonMakeVisible2.Visible = false;
                buttonMakeVisible3.Visible = false;
                butGenderExchange.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                lbl4.Visible = false;
                lbl5.Visible = false;
                lbl6.Visible = false;
                lbl7.Visible = false;
                lbl8.Visible = false;
                lbl9.Visible = false;
                lbl10.Visible = false;
                lbl11.Visible = false;
                // soft animation Report Panel
                butAnalysis.Visible = false;
                reportViewer1.Visible = false;
                // soft animation Admin Panel
                dgvAdmin.Visible = false;
                butUserData.Visible = false;
                butUserActivity.Visible = false;
                butUserModules.Visible = false;
                butBlokUser.Visible = false;
                butAddUser.Visible = false;
                butEditUser.Visible = false;
                butDeleteUser.Visible = false;
                butEditModules.Visible = false;
                tbSearch.Visible = false;
                butSearch.Visible = false;
                butRefreshGrid.Visible = false;
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
                //Delay for Soft
                Thread.Sleep(250);
                //Slider Disapperance Animation
                for (int i = 0; i < panSliserMAX; i++)
                {
                    //Thread.Sleep(1);
                    panSlider.Width--;
                }
                //Admin/Profile/Report Width Gap Separated Variables
                int x1 = panSliserMAX;
                //int x2 = panSliserMAX;//profile pan animation bag
                int x3 = panSliserMAX;
                //Admin/Profile/Report Relocation Animation
                for (int i = 0; i < panSliserMAX; i++)
                {
                    //panProfile.Location = new Point(--x2 + panContentMargin, panProfile.Location.Y);//profile pan animation bag
                    panAdminPanel.Location = new Point(--x1 + panContentMargin, panAdminPanel.Location.Y);                    
                    panReport.Location = new Point(--x3 + panContentMargin, panReport.Location.Y);
                }
                
                Thread.Sleep(250); //profile pan animation bag
                panProfile.Location = new Point(0 + panContentMargin, panProfile.Location.Y); //profile pan animation bag
                panProfile.Width += panSliserMAX; //profile pan animation bag
                //Admin/Profile/Report Resize Animation
                for (int i = 0; i < panSliserMAX; i += 10)
                {
                    
                    panAdminPanel.Width += 10;
                    //panProfile.Width += 10;//profile pan animation bag                  
                    panReport.Width += 10;
                }
                //Switch picture box menu image
                pbMenuOne.Image = Properties.Resources.MenuButtonDisable;
                //soft animation Profile Panel
                butIsAdmin.Visible = true;
                butIsNotAdmin.Visible = true;
                butAvatarDisplay.Visible = true;
                butAddAvatar.Visible = true;
                butRemoveAvatar.Visible = true;
                tbLogin1.Visible = true;
                tbFName.Visible = true;
                tbMName.Visible = true;
                tbLName.Visible = true;
                tbGender.Visible = true;
                tbEmail.Visible = true;
                mtbPhone.Visible = true;
                tbAdress.Visible = true;
                tbOldPassword.Visible = true;
                tbPass.Visible = true;
                tbPassConfirm.Visible = true;
                butEditProfile.Visible = true;
                butSaveProfileChanges.Visible = true;
                butChangePassword.Visible = true;
                buttonMakeVisible1.Visible = true;
                buttonMakeVisible2.Visible = true;
                buttonMakeVisible3.Visible = true;
                butGenderExchange.Visible = true;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                lbl4.Visible = true;
                lbl5.Visible = true;
                lbl6.Visible = true;
                lbl7.Visible = true;
                lbl8.Visible = true;
                lbl9.Visible = true;
                lbl10.Visible = true;
                lbl11.Visible = true;
                // soft animation Models Panel
                butAnalysis.Visible = true;
                reportViewer1.Visible = true;
                // soft animation admin panel
                dgvAdmin.Visible = true;
                butUserData.Visible = true;
                butUserActivity.Visible = true;
                butUserModules.Visible = true;
                butBlokUser.Visible = true;
                butAddUser.Visible = true;
                butEditUser.Visible = true;
                butDeleteUser.Visible = true;
                butEditModules.Visible = true;
                tbSearch.Visible = true;
                butSearch.Visible = true;
                butRefreshGrid.Visible = true;

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
        //Menu Button switch Handlers
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
            //Defaulth value for lblAdminOption
            lblAdminOption.Text = "User Data";
            //Data Grid Material Design
            dgvAdmin.BorderStyle = BorderStyle.None;
            dgvAdmin.AlternatingRowsDefaultCellStyle.BackColor = ColorPalette.white2;
            dgvAdmin.RowsDefaultCellStyle.BackColor = Color.White;
            dgvAdmin.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvAdmin.DefaultCellStyle.SelectionBackColor = ColorPalette.orange1;
            dgvAdmin.DefaultCellStyle.SelectionForeColor = Color.Black ;
            dgvAdmin.BackgroundColor = Color.White;

            dgvAdmin.EnableHeadersVisualStyles = false;
            dgvAdmin.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = ColorPalette.red2;
            dgvAdmin.ColumnHeadersDefaultCellStyle.ForeColor = ColorPalette.white1;

            dgvAdmin.RowHeadersDefaultCellStyle.BackColor = ColorPalette.red2;
            dgvAdmin.RowHeadersDefaultCellStyle.SelectionBackColor = ColorPalette.orange1;
            //Search Field Changable Search Tips
            ttSearchAdvice.Dispose();
            ttSearchAdvice = new ToolTip();
            ttSearchAdvice.SetToolTip(tbSearch, "Search by Last Name");
            ttSearchAdvice.ToolTipIcon = ToolTipIcon.Info;
            ////Set ToolTips for Admin Panel Buttons
            SetAdminPanelTips();
            //Set ToolTips for Profile Panel Buttons
            SetProfilePanelTips();
            //UserAccountData OnLoad Form Filling
            UserDataFormFill();


        }
        //Search Field Changable Search Tips
        ToolTip ttSearchAdvice = new ToolTip();
        private void butUserData_Click(object sender, EventArgs e)
        {
            lblAdminOption.Text = "User Data";
            butBlokUser.Visible = true;
            butAddUser.Visible = true;
            butEditUser.Visible = true;
            butDeleteUser.Visible = true;
            butEditModules.Visible = false;
            //Search Field Changable Search Tips
            ttSearchAdvice.Dispose();
            ttSearchAdvice = new ToolTip();
            ttSearchAdvice.SetToolTip(tbSearch, "Search by Last Name");
            ttSearchAdvice.ToolTipIcon = ToolTipIcon.Info;

        }
        private void butUserActivity_Click(object sender, EventArgs e)
        {
            lblAdminOption.Text = "User Activity";
            butBlokUser.Visible = false;
            butAddUser.Visible = false;
            butEditUser.Visible = false;
            butDeleteUser.Visible = false;
            butEditModules.Visible = false;
            //Search Field Changable Search Tips
            ttSearchAdvice.Dispose() ;
            ttSearchAdvice = new ToolTip();
            ttSearchAdvice.SetToolTip(tbSearch, "Search by UserID");
            ttSearchAdvice.ToolTipIcon = ToolTipIcon.Info;
        }
        private void butUserModules_Click(object sender, EventArgs e)
        {
            lblAdminOption.Text = "User's Models";
            butBlokUser.Visible = false;
            butAddUser.Visible = false;
            butEditUser.Visible = false;
            butDeleteUser.Visible = false;
            butEditModules.Visible = true;
            //Search Field Changable Search Tips
            ttSearchAdvice.Dispose();
            ttSearchAdvice = new ToolTip();
            ttSearchAdvice.SetToolTip(tbSearch, "Search by UserID");
            ttSearchAdvice.ToolTipIcon = ToolTipIcon.Info;
        }
        //Set ToolTips for Admin Panel Buttons
        ToolTip ttAddUser;
        ToolTip ttEditUser;
        ToolTip ttDeleteUser;
        ToolTip ttBlockUser;
        ToolTip ttEditModules;
        private void SetAdminPanelTips()
        {
            ttAddUser = new ToolTip();
            ttAddUser.SetToolTip(butAddUser, "Create User with UserData, which are entered in selected string");
            ttAddUser.ToolTipIcon = ToolTipIcon.Info;
            ttEditUser = new ToolTip();
            ttEditUser.SetToolTip(butEditUser, "Edit UserData of selected User");
            ttEditUser.ToolTipIcon = ToolTipIcon.Info;
            ttDeleteUser = new ToolTip();
            ttDeleteUser.SetToolTip(butDeleteUser, "Delete Account and All User Data of selected User");
            ttDeleteUser.ToolTipIcon = ToolTipIcon.Info;
            ttBlockUser = new ToolTip();
            ttBlockUser.SetToolTip(butBlokUser, "Block/Unblock Access of User to his UserAccount");
            ttBlockUser.ToolTipIcon = ToolTipIcon.Info;
            ttEditModules = new ToolTip();
            ttEditModules.SetToolTip(butEditModules, "Save Permissions for selected User");
            ttEditModules.ToolTipIcon = ToolTipIcon.Info;


        }
        //Password Fields Text Visibility Handlers
        private void buttonMakeVisible1_Click(object sender, EventArgs e)
        {
            if (tbOldPassword.PasswordChar == '⦁')
                tbOldPassword.PasswordChar = '\0';
            else
                tbOldPassword.PasswordChar = '⦁';
        }
        private void buttonMakeVisible2_Click(object sender, EventArgs e)
        {
            if (tbPass.PasswordChar == '⦁')
                tbPass.PasswordChar = '\0';
            else
                tbPass.PasswordChar = '⦁';
        }
        private void buttonMakeVisible3_Click(object sender, EventArgs e)
        {
            if (tbPassConfirm.PasswordChar == '⦁')
                tbPassConfirm.PasswordChar = '\0';
            else
                tbPassConfirm.PasswordChar = '⦁';
        }
        //Edit Profile Flag
        bool isEdit = false;
        //Edit Profile Button
        private void butEditProfile_Click(object sender, EventArgs e)
        {
            if(!isEdit)
            {
                tbLogin1.Enabled = true;
                tbFName.Enabled = true;
                tbMName.Enabled = true;
                tbLName.Enabled = true;
                butGenderExchange.Enabled = true;
                tbEmail.Enabled = true;
                mtbPhone.Enabled = true;
                tbAdress.Enabled = true;
                isEdit = true;
            }
            else
            {
                tbLogin1.Enabled = false;
                tbFName.Enabled = false;
                tbMName.Enabled = false;
                tbLName.Enabled = false;
                butGenderExchange.Enabled = false;
                tbEmail.Enabled = false;
                mtbPhone.Enabled = false;
                tbAdress.Enabled = false;
                isEdit = false;
            }
            

        }
        //Edit Password Flag
        bool isEditPass = false;
        //Edit Password Button
        private void butChangePassword_Click(object sender, EventArgs e)
        {
            if(!isEditPass)
            {
                tbOldPassword.Enabled = true;
                tbPass.Enabled = true;
                tbPassConfirm.Enabled = true;
                buttonMakeVisible1.Enabled = true;
                buttonMakeVisible2.Enabled = true;
                buttonMakeVisible3.Enabled = true;
                isEditPass = true;
            }
            else
            {
                tbOldPassword.Enabled = false;
                tbPass.Enabled = false;
                tbPassConfirm.Enabled = false;
                buttonMakeVisible1.Enabled = false;
                buttonMakeVisible2.Enabled = false;
                buttonMakeVisible3.Enabled = false;
                isEditPass = false;
            }
        }
        //Button Save changes
        private void butSaveProfileChanges_Click(object sender, EventArgs e)
        {
            if(isEdit)
            {
                tbLogin1.Enabled = false;
                tbFName.Enabled = false;
                tbMName.Enabled = false;
                tbLName.Enabled = false;
                butGenderExchange.Enabled = false;
                tbEmail.Enabled = false;
                mtbPhone.Enabled = false;
                tbAdress.Enabled = false;
                isEdit = false;
            }
        
            if(isEditPass)
            {
                tbOldPassword.Enabled = false;
                tbPass.Enabled = false;
                tbPassConfirm.Enabled = false;
                buttonMakeVisible1.Enabled = false;
                buttonMakeVisible2.Enabled = false;
                buttonMakeVisible3.Enabled = false;
                isEditPass = false;
            }
        }
        //Set ToolTips for Profile Pannel Buttons
        ToolTip ttEditProfile;
        ToolTip ttChangePass;
        ToolTip ttSaveChanges;
        ToolTip ttAddAvatar;
        ToolTip ttRemoveAvatar;
        private void SetProfilePanelTips()
        {
            ttEditProfile = new ToolTip();
            ttEditProfile.SetToolTip(butEditProfile, "Unlock profile fields to edit");
            ttEditProfile.ToolTipIcon = ToolTipIcon.Info;
            ttChangePass = new ToolTip();
            ttChangePass.SetToolTip(butChangePassword, "Unlock profile fields to change password");
            ttChangePass.ToolTipIcon = ToolTipIcon.Info;
            ttSaveChanges = new ToolTip();
            ttSaveChanges.SetToolTip(butSaveProfileChanges, "Save profile changes from fields");
            ttSaveChanges.ToolTipIcon = ToolTipIcon.Info;
            ttAddAvatar = new ToolTip();
            ttAddAvatar.SetToolTip(butAddAvatar, "Change Avatar picture & save in profile");
            ttAddAvatar.ToolTipIcon = ToolTipIcon.Info;
            ttRemoveAvatar = new ToolTip();
            ttRemoveAvatar.SetToolTip(butRemoveAvatar, "Remove Avatar & delete it from profile");
            ttRemoveAvatar.ToolTipIcon = ToolTipIcon.Info;

        }
        //UserAccountData OnLoad Form Filling       
        private void UserDataFormFill()
        {
            //Menu Buttons Activation
            UDFFMenuButs();
            UDFFAdminPanelBut();

        }
        //Menu Buttons Activation
        private void UDFFMenuButs()
        {
            try
            {
                SecurityModule sm = new SecurityModule();
                OracleConnection con = new OracleConnection(sm.SalesHistotyConnectionSrtingProp);
                string menuButsAccessQuery = $"SELECT M1, M2, M3, M4, M5, M6 FROM CLIENTMODULEACCESS WHERE USERID={userId}";
                OracleDataAdapter adp = new OracleDataAdapter(menuButsAccessQuery, con);
                //menuButTable
                DataTable mBT = new DataTable();
                adp.Fill(mBT);
                menuButsAccessQuery = null;
                adp.Dispose();
                con.Dispose();
                DataRow dr = mBT.Rows[0];
                mBT = null;
                if (dr[0].ToString() == "T")
                    buts3.Enabled = true;
                else
                    buts3.Enabled = false;
                if (dr[1].ToString() == "T")
                    buts4.Enabled = true;
                else
                    buts4.Enabled = false;
                if (dr[2].ToString() == "T")
                    buts5.Enabled = true;
                else
                    buts5.Enabled = false;
                if (dr[3].ToString() == "T")
                    buts6.Enabled = true;
                else
                    buts6.Enabled = false;
                if (dr[4].ToString() == "T")
                    buts7.Enabled = true;
                else
                    buts7.Enabled = false;
                if (dr[5].ToString() == "T")
                    buts8.Enabled = true;
                else
                    buts8.Enabled = false;
            }
            catch(Exception ex)
            {
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.Error, ex.Message, "ОК", () => {this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                error.Show();
            }
        }

        private void UDFFAdminPanelBut()
        {
            try
            {
                SecurityModule sm = new SecurityModule();
                OracleConnection con = new OracleConnection(sm.SalesHistotyConnectionSrtingProp);
                string adminPanAccessQuery = $"SELECT ISADMIN FROM CLIENTAPPUSERS WHERE USERID={userId}";
                OracleDataAdapter adp = new OracleDataAdapter(adminPanAccessQuery, con);
                //adminButTable
                DataTable aBT = new DataTable();
                adp.Fill(aBT);
                adminPanAccessQuery = null;
                adp.Dispose();
                con.Dispose();
                DataRow dr = aBT.Rows[0];
                string isAdminFlag = dr[0].ToString();
                aBT = null;
                dr = null;
                if (isAdminFlag == "T")
                {
                    buts2.Enabled = true;
                    butIsAdmin.Visible = true;
                    butIsNotAdmin.Visible = false;
                    
                }
                    
                else
                {
                    buts2.Enabled = false;
                    butIsAdmin.Visible = false;
                    butIsNotAdmin.Visible = true;
                }
                    

            }
            catch (Exception ex)
            {
                CustomMessageBox error = new CustomMessageBox(Properties.Resources.Error, ex.Message, "ОК", () => { this.Enabled = true; }, true, ColorPalette.red1, ColorPalette.white1);
                this.Enabled = false;
                error.Show();
            }
        }
    }
}
