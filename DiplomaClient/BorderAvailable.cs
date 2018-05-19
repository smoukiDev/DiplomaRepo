using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomaClient
{
    public partial class BorderAvailable : Form
    {
        public BorderAvailable()
        {
            InitializeComponent();
            this.MaximizeBox = true;
        }

        private void BorderAvailable_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void BorderAvailable_Resize(object sender, EventArgs e)
        {
            panel2.Location = new Point(0,panel1.Height);
        }
        Point MouseHook;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y  = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            this.Location = new Point(0, y);
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
           
        }
    }
}
