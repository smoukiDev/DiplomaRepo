namespace DiplomaClient
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panFooter = new System.Windows.Forms.Panel();
            this.panWindowTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.panWinStateButtons = new System.Windows.Forms.Panel();
            this.butMax = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butMin = new System.Windows.Forms.Button();
            this.panBackArea = new System.Windows.Forms.Panel();
            this.panProfile = new System.Windows.Forms.Panel();
            this.panMenu = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenuOne = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panAccount = new System.Windows.Forms.Panel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.buts1 = new System.Windows.Forms.Button();
            this.buts2 = new System.Windows.Forms.Button();
            this.buts3 = new System.Windows.Forms.Button();
            this.buts4 = new System.Windows.Forms.Button();
            this.buts5 = new System.Windows.Forms.Button();
            this.buts6 = new System.Windows.Forms.Button();
            this.buts7 = new System.Windows.Forms.Button();
            this.buts9 = new System.Windows.Forms.Button();
            this.buts8 = new System.Windows.Forms.Button();
            this.panSlider = new System.Windows.Forms.Panel();
            this.panFooter.SuspendLayout();
            this.panWindowTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panWinStateButtons.SuspendLayout();
            this.panBackArea.SuspendLayout();
            this.panMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panAccount.SuspendLayout();
            this.panSlider.SuspendLayout();
            this.SuspendLayout();
            // 
            // panFooter
            // 
            this.panFooter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panFooter.Controls.Add(this.panWindowTitle);
            this.panFooter.Controls.Add(this.panWinStateButtons);
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFooter.Location = new System.Drawing.Point(0, 0);
            this.panFooter.Name = "panFooter";
            this.panFooter.Size = new System.Drawing.Size(1024, 60);
            this.panFooter.TabIndex = 0;
            this.panFooter.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panFooter_MouseDoubleClick);
            this.panFooter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panFooter_MouseMove);
            this.panFooter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panFooter_MouseUp);
            // 
            // panWindowTitle
            // 
            this.panWindowTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panWindowTitle.Controls.Add(this.label1);
            this.panWindowTitle.Controls.Add(this.pbMenu);
            this.panWindowTitle.Location = new System.Drawing.Point(3, 0);
            this.panWindowTitle.Name = "panWindowTitle";
            this.panWindowTitle.Size = new System.Drawing.Size(367, 57);
            this.panWindowTitle.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "DM Analytics Application";
            // 
            // pbMenu
            // 
            this.pbMenu.BackColor = System.Drawing.Color.Transparent;
            this.pbMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(-6, 4);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(62, 50);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 16;
            this.pbMenu.TabStop = false;
            // 
            // panWinStateButtons
            // 
            this.panWinStateButtons.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panWinStateButtons.Controls.Add(this.butMax);
            this.panWinStateButtons.Controls.Add(this.butClose);
            this.panWinStateButtons.Controls.Add(this.butMin);
            this.panWinStateButtons.Location = new System.Drawing.Point(804, 3);
            this.panWinStateButtons.Name = "panWinStateButtons";
            this.panWinStateButtons.Size = new System.Drawing.Size(217, 54);
            this.panWinStateButtons.TabIndex = 18;
            // 
            // butMax
            // 
            this.butMax.BackColor = System.Drawing.Color.Transparent;
            this.butMax.BackgroundImage = global::DiplomaClient.Properties.Resources.MaximizeButton2;
            this.butMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMax.FlatAppearance.BorderSize = 0;
            this.butMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMax.Location = new System.Drawing.Point(52, 1);
            this.butMax.Name = "butMax";
            this.butMax.Size = new System.Drawing.Size(50, 50);
            this.butMax.TabIndex = 16;
            this.butMax.UseVisualStyleBackColor = false;
            this.butMax.Click += new System.EventHandler(this.butMax_Click);
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
            this.butClose.Location = new System.Drawing.Point(164, 1);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(50, 50);
            this.butClose.TabIndex = 14;
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butMin
            // 
            this.butMin.BackColor = System.Drawing.Color.Transparent;
            this.butMin.BackgroundImage = global::DiplomaClient.Properties.Resources.MinimizeButton;
            this.butMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMin.FlatAppearance.BorderSize = 0;
            this.butMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMin.Location = new System.Drawing.Point(108, 1);
            this.butMin.Name = "butMin";
            this.butMin.Size = new System.Drawing.Size(50, 50);
            this.butMin.TabIndex = 15;
            this.butMin.UseVisualStyleBackColor = false;
            this.butMin.Click += new System.EventHandler(this.butMin_Click);
            // 
            // panBackArea
            // 
            this.panBackArea.BackColor = System.Drawing.Color.Crimson;
            this.panBackArea.Controls.Add(this.panSlider);
            this.panBackArea.Controls.Add(this.panProfile);
            this.panBackArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panBackArea.Location = new System.Drawing.Point(0, 120);
            this.panBackArea.Name = "panBackArea";
            this.panBackArea.Size = new System.Drawing.Size(1024, 648);
            this.panBackArea.TabIndex = 3;
            this.panBackArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panBackArea_MouseDown);
            this.panBackArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panBackArea_MouseMove);
            this.panBackArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panBackArea_MouseUp);
            // 
            // panProfile
            // 
            this.panProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panProfile.BackColor = System.Drawing.Color.Teal;
            this.panProfile.Location = new System.Drawing.Point(12, 9);
            this.panProfile.Name = "panProfile";
            this.panProfile.Size = new System.Drawing.Size(1000, 628);
            this.panProfile.TabIndex = 1;
            // 
            // panMenu
            // 
            this.panMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panMenu.Controls.Add(this.panAccount);
            this.panMenu.Controls.Add(this.lblMenu);
            this.panMenu.Controls.Add(this.pbMenuOne);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(0, 60);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(1024, 60);
            this.panMenu.TabIndex = 2;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMenu.Location = new System.Drawing.Point(59, 14);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(82, 30);
            this.lblMenu.TabIndex = 19;
            this.lblMenu.Text = "Menu";
            // 
            // pbMenuOne
            // 
            this.pbMenuOne.BackColor = System.Drawing.Color.Transparent;
            this.pbMenuOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMenuOne.Image = global::DiplomaClient.Properties.Resources.MenuButtonDisable;
            this.pbMenuOne.Location = new System.Drawing.Point(11, 8);
            this.pbMenuOne.Name = "pbMenuOne";
            this.pbMenuOne.Size = new System.Drawing.Size(44, 43);
            this.pbMenuOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenuOne.TabIndex = 18;
            this.pbMenuOne.TabStop = false;
            this.pbMenuOne.Click += new System.EventHandler(this.pbMenuOne_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::DiplomaClient.Properties.Resources.UserProfileDefault;
            this.pictureBox1.Location = new System.Drawing.Point(416, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panAccount
            // 
            this.panAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panAccount.Controls.Add(this.tbLogin);
            this.panAccount.Controls.Add(this.pictureBox1);
            this.panAccount.Location = new System.Drawing.Point(558, 3);
            this.panAccount.Name = "panAccount";
            this.panAccount.Size = new System.Drawing.Size(463, 54);
            this.panAccount.TabIndex = 21;
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Enabled = false;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(9, 13);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(401, 26);
            this.tbLogin.TabIndex = 22;
            this.tbLogin.Text = "User(Admin)";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buts1
            // 
            this.buts1.BackColor = System.Drawing.Color.Coral;
            this.buts1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buts1.FlatAppearance.BorderSize = 0;
            this.buts1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buts1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buts1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buts1.Location = new System.Drawing.Point(9, 9);
            this.buts1.Name = "buts1";
            this.buts1.Size = new System.Drawing.Size(350, 60);
            this.buts1.TabIndex = 35;
            this.buts1.Text = "Profile";
            this.buts1.UseVisualStyleBackColor = false;
            this.buts1.Visible = false;
            this.buts1.Click += new System.EventHandler(this.buts1_Click);
            // 
            // buts2
            // 
            this.buts2.BackColor = System.Drawing.Color.Coral;
            this.buts2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buts2.FlatAppearance.BorderSize = 0;
            this.buts2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buts2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buts2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buts2.Location = new System.Drawing.Point(9, 75);
            this.buts2.Name = "buts2";
            this.buts2.Size = new System.Drawing.Size(350, 60);
            this.buts2.TabIndex = 36;
            this.buts2.Text = "Admin Panel";
            this.buts2.UseVisualStyleBackColor = false;
            this.buts2.Visible = false;
            this.buts2.Click += new System.EventHandler(this.buts2_Click);
            // 
            // buts3
            // 
            this.buts3.BackColor = System.Drawing.Color.Coral;
            this.buts3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buts3.FlatAppearance.BorderSize = 0;
            this.buts3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buts3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buts3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buts3.Location = new System.Drawing.Point(9, 141);
            this.buts3.Name = "buts3";
            this.buts3.Size = new System.Drawing.Size(350, 60);
            this.buts3.TabIndex = 37;
            this.buts3.Text = "Explore";
            this.buts3.UseVisualStyleBackColor = false;
            this.buts3.Visible = false;
            this.buts3.Click += new System.EventHandler(this.buts3_Click);
            // 
            // buts4
            // 
            this.buts4.BackColor = System.Drawing.Color.Coral;
            this.buts4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buts4.FlatAppearance.BorderSize = 0;
            this.buts4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buts4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buts4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buts4.Location = new System.Drawing.Point(9, 207);
            this.buts4.Name = "buts4";
            this.buts4.Size = new System.Drawing.Size(350, 60);
            this.buts4.TabIndex = 38;
            this.buts4.Text = "Association Rules";
            this.buts4.UseVisualStyleBackColor = false;
            this.buts4.Visible = false;
            this.buts4.Click += new System.EventHandler(this.buts4_Click);
            // 
            // buts5
            // 
            this.buts5.BackColor = System.Drawing.Color.Coral;
            this.buts5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buts5.FlatAppearance.BorderSize = 0;
            this.buts5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buts5.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buts5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buts5.Location = new System.Drawing.Point(9, 273);
            this.buts5.Name = "buts5";
            this.buts5.Size = new System.Drawing.Size(350, 60);
            this.buts5.TabIndex = 39;
            this.buts5.Text = "Classification";
            this.buts5.UseVisualStyleBackColor = false;
            this.buts5.Visible = false;
            this.buts5.Click += new System.EventHandler(this.buts5_Click);
            // 
            // buts6
            // 
            this.buts6.BackColor = System.Drawing.Color.Coral;
            this.buts6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buts6.FlatAppearance.BorderSize = 0;
            this.buts6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buts6.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buts6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buts6.Location = new System.Drawing.Point(9, 339);
            this.buts6.Name = "buts6";
            this.buts6.Size = new System.Drawing.Size(350, 60);
            this.buts6.TabIndex = 40;
            this.buts6.Text = "Clustering";
            this.buts6.UseVisualStyleBackColor = false;
            this.buts6.Visible = false;
            this.buts6.Click += new System.EventHandler(this.buts6_Click);
            // 
            // buts7
            // 
            this.buts7.BackColor = System.Drawing.Color.Coral;
            this.buts7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buts7.FlatAppearance.BorderSize = 0;
            this.buts7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buts7.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buts7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buts7.Location = new System.Drawing.Point(9, 405);
            this.buts7.Name = "buts7";
            this.buts7.Size = new System.Drawing.Size(350, 60);
            this.buts7.TabIndex = 41;
            this.buts7.Text = "Regression";
            this.buts7.UseVisualStyleBackColor = false;
            this.buts7.Visible = false;
            this.buts7.Click += new System.EventHandler(this.buts7_Click);
            // 
            // buts9
            // 
            this.buts9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buts9.BackColor = System.Drawing.Color.Coral;
            this.buts9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buts9.FlatAppearance.BorderSize = 0;
            this.buts9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buts9.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buts9.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buts9.Location = new System.Drawing.Point(9, 574);
            this.buts9.Name = "buts9";
            this.buts9.Size = new System.Drawing.Size(350, 60);
            this.buts9.TabIndex = 42;
            this.buts9.Text = "Logout";
            this.buts9.UseVisualStyleBackColor = false;
            this.buts9.Visible = false;
            this.buts9.Click += new System.EventHandler(this.buts9_Click);
            // 
            // buts8
            // 
            this.buts8.BackColor = System.Drawing.Color.Coral;
            this.buts8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buts8.FlatAppearance.BorderSize = 0;
            this.buts8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buts8.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buts8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buts8.Location = new System.Drawing.Point(9, 471);
            this.buts8.Name = "buts8";
            this.buts8.Size = new System.Drawing.Size(350, 60);
            this.buts8.TabIndex = 43;
            this.buts8.Text = "Anomaly Detect";
            this.buts8.UseVisualStyleBackColor = false;
            this.buts8.Visible = false;
            this.buts8.Click += new System.EventHandler(this.buts8_Click);
            // 
            // panSlider
            // 
            this.panSlider.BackColor = System.Drawing.Color.LightSalmon;
            this.panSlider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panSlider.Controls.Add(this.buts8);
            this.panSlider.Controls.Add(this.buts9);
            this.panSlider.Controls.Add(this.buts7);
            this.panSlider.Controls.Add(this.buts6);
            this.panSlider.Controls.Add(this.buts5);
            this.panSlider.Controls.Add(this.buts4);
            this.panSlider.Controls.Add(this.buts3);
            this.panSlider.Controls.Add(this.buts2);
            this.panSlider.Controls.Add(this.buts1);
            this.panSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panSlider.Location = new System.Drawing.Point(0, 0);
            this.panSlider.Name = "panSlider";
            this.panSlider.Size = new System.Drawing.Size(10, 648);
            this.panSlider.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panBackArea);
            this.Controls.Add(this.panMenu);
            this.Controls.Add(this.panFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panFooter.ResumeLayout(false);
            this.panWindowTitle.ResumeLayout(false);
            this.panWindowTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panWinStateButtons.ResumeLayout(false);
            this.panBackArea.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panAccount.ResumeLayout(false);
            this.panAccount.PerformLayout();
            this.panSlider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFooter;
        private System.Windows.Forms.Panel panWinStateButtons;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butMin;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Panel panWindowTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butMax;
        private System.Windows.Forms.Panel panBackArea;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panProfile;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pbMenuOne;
        private System.Windows.Forms.Panel panAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Panel panSlider;
        private System.Windows.Forms.Button buts8;
        private System.Windows.Forms.Button buts9;
        private System.Windows.Forms.Button buts7;
        private System.Windows.Forms.Button buts6;
        private System.Windows.Forms.Button buts5;
        private System.Windows.Forms.Button buts4;
        private System.Windows.Forms.Button buts3;
        private System.Windows.Forms.Button buts2;
        private System.Windows.Forms.Button buts1;
    }
}