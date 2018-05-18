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
    public partial class BorderlessResize : Form
    {
        const int DISTANCE = 10;
        public BorderlessResize()
        {
            InitializeComponent();
            panel3.Width = 0;
        }
        Point MouseHook;
        private void BorderlessResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
            
            
        }


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

        int Mx;
        int My;
        int Sw;
        int Sh;

        bool mov;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            My = MousePosition.Y;
            Mx = MousePosition.X;
            Sw = Width;
            Sh = Height;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mov == true)
            {
                int newWidth = MousePosition.X - Mx + Sw;
                int newHeight = MousePosition.Y - My + Sh;
                if (newWidth > 700)
                {
                    Width = newWidth;
                }
                if(newHeight >500)
                {
                    Height = newHeight;
                }
                
                
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
        }

        

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void BorderlessResize_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel3.Width == 0)
            {
                for (int i = 0; i < 250; i++)
                {
                    Thread.Sleep(1);
                    panel3.Width++;
                    
                }
                reportViewer1.Width -= 250;
                reportViewer1.Location = new Point(250+10, reportViewer1.Location.Y);
            }         
            else
            {
                
                for (int i = 0; i < 250; i ++)
                {
                    Thread.Sleep(1);
                    panel3.Width--;
                }
                int x = 250;
                for (int i = 0; i < 250; i++)
                {
                    reportViewer1.Location = new Point(--x+10, reportViewer1.Location.Y);
                }
                
                for (int i = 0; i < 250; i+=10)
                {
                    
                    reportViewer1.Width += 10;
                }
                

            }
                
        }
    }
}
