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
        }

        private void BorderAvailable_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void BorderAvailable_Resize(object sender, EventArgs e)
        {
            panel2.Location = new Point(0,panel1.Height);
        }
    }
}
