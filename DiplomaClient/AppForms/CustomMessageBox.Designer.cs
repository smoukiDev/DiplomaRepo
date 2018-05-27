namespace DiplomaClient
{
    partial class CustomMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Location = new System.Drawing.Point(188, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(120, 120);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 37;
            this.pbIcon.TabStop = false;
            // 
            // rtbMessage
            // 
            this.rtbMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbMessage.Location = new System.Drawing.Point(12, 143);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbMessage.Size = new System.Drawing.Size(476, 62);
            this.rtbMessage.TabIndex = 38;
            this.rtbMessage.Text = "";
            // 
            // but1
            // 
            this.but1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.but1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but1.FlatAppearance.BorderSize = 0;
            this.but1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.but1.Location = new System.Drawing.Point(10, 10);
            this.but1.Margin = new System.Windows.Forms.Padding(10);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(135, 50);
            this.but1.TabIndex = 3;
            this.but1.Text = "B1";
            this.but1.UseVisualStyleBackColor = false;
            this.but1.Click += new System.EventHandler(this.but1_Click);
            // 
            // but2
            // 
            this.but2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.but2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but2.FlatAppearance.BorderSize = 0;
            this.but2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.but2.Location = new System.Drawing.Point(170, 10);
            this.but2.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(135, 50);
            this.but2.TabIndex = 4;
            this.but2.Text = "B2";
            this.but2.UseVisualStyleBackColor = false;
            this.but2.Click += new System.EventHandler(this.but2_Click);
            // 
            // but3
            // 
            this.but3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.but3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but3.FlatAppearance.BorderSize = 0;
            this.but3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.but3.Location = new System.Drawing.Point(330, 10);
            this.but3.Margin = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(135, 50);
            this.but3.TabIndex = 5;
            this.but3.Text = "B3";
            this.but3.UseVisualStyleBackColor = false;
            this.but3.Click += new System.EventHandler(this.but3_Click);
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.Transparent;
            this.butClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butClose.BackgroundImage")));
            this.butClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClose.FlatAppearance.BorderSize = 0;
            this.butClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Location = new System.Drawing.Point(438, 12);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(50, 50);
            this.butClose.TabIndex = 40;
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.but1);
            this.panel1.Controls.Add(this.but2);
            this.panel1.Controls.Add(this.but3);
            this.panel1.Location = new System.Drawing.Point(12, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 70);
            this.panel1.TabIndex = 41;
            // 
            // tbMessage
            // 
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMessage.Cursor = System.Windows.Forms.Cursors.No;
            this.tbMessage.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMessage.Location = new System.Drawing.Point(12, 160);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(476, 28);
            this.tbMessage.TabIndex = 42;
            this.tbMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMessage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbMessage_MouseClick);
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DiplomaClient.Properties.Resources.CustomMessageBoxBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.rtbMessage);
            this.Controls.Add(this.pbIcon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomMessageBox";
            this.TopMost = true;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomMessageBox_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMessage;
    }
}