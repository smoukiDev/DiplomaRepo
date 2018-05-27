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
        Action but1Action = null;
        Action but2Action = null;
        //unlock parent form method
        Action unlockParentForm = null;
        //notification sound
        SoundPlayer sp;
        //useless default constructor
        public CustomMessageBox()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Constructor - Create Dialog Form with Message Picture, Message Text and One Button
        /// </summary>
        /// <param name="icon">Message Picture</param>
        /// <param name="message">Message Text</param>
        /// <param name="but2Title">Button Text</param>
        /// <param name="but2Action">Parent's Form Unlock Method</param>
        /// <param name="multiline">Single line or Multiline Message</param>
        /// <param name="but2Color">Button Color</param>
        /// <param name="but2txtColor">Button Text Color</param>
        public CustomMessageBox(Image icon, string message, string but2Title, Action unlockMethod, bool multiline, Color but2Color, Color but2txtColor)
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
            unlockParentForm = unlockMethod;
        }
        public CustomMessageBox(Image icon, bool multiline, string message, Action unlockMethod, string but1Title, string but2Title, string but3Title, Action but1Method, Action but2Method)
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
            but1.Text = but1Title;
            but2.Text = but2Title;
            but3.Text = but3Title;
            but1.BackColor = ColorPalette.red2;
            but2.BackColor = ColorPalette.red2;
            but3.BackColor = ColorPalette.red2;
            but1.ForeColor = ColorPalette.white1;
            but2.ForeColor = ColorPalette.white1;
            but3.ForeColor = ColorPalette.white1;
            but1Action = but1Method;
            but2Action = but2Method;
            unlockParentForm = unlockMethod;
        }
        //Drag Form Feature
        Point MouseHook;
        private void CustomMessageBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) MouseHook = e.Location;
            Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
        }
        //Button Close
        private void butClose_Click(object sender, EventArgs e)
        {

            if (unlockParentForm != null)
                unlockParentForm();
            this.Close();
        }
        //Button 1
        private void but1_Click(object sender, EventArgs e)
        {
            if (but1Action != null)
                but1Action();
            if (unlockParentForm != null)
                unlockParentForm();
        }
        //Button 2
        private void but2_Click(object sender, EventArgs e)
        {
            if (but2Action != null)
                but2Action();
            if (unlockParentForm !=null)
            unlockParentForm();
            this.Close();
        }
        //Button 3
        private void but3_Click(object sender, EventArgs e)
        {
            if (unlockParentForm != null)
                unlockParentForm();
            this.Close();
        }
        //useless
        private void tbMessage_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
