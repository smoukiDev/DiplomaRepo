using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace DiplomaClient
{
    public partial class CustomMessageBox : Form
    {
        
        Action but_2_Action = null;
        SoundPlayer sp;
        public CustomMessageBox()
        {
            InitializeComponent();
            
        }

        public CustomMessageBox(Image icon, string message, string but2Title, Action but2Action, bool multiline, Color but2Color, Color but2txtColor)
        {
            //Notification Sound
            sp = new SoundPlayer(Properties.Resources.Sonar_FX);
            sp.Play();         
            InitializeComponent();
            pbIcon.Image = icon;
            but1.Visible = false;
            but3.Visible = false;
            if (multiline == true)
            {
                tbMessage.Visible = false;
                rtbMessage.Text = message;
            }            
            else
            {
                rtbMessage.Visible = false;
                tbMessage.Enabled = false;
                tbMessage.Text = message;
            }
            but1.Visible = false;
            but3.Visible = false;
            but2.BackColor = but2Color;
            but2.ForeColor = but2txtColor;
            but2.Text = but2Title;
            but_2_Action = but2Action;



        }

        Point MouseHook;
        private void CustomMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but1_Click(object sender, EventArgs e)
        {
            
        }

        private void but2_Click(object sender, EventArgs e)
        {
            if(but_2_Action !=null)
            but_2_Action();
            this.Close();
        }

        private void but3_Click(object sender, EventArgs e)
        {

        }

        private void tbMessage_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
