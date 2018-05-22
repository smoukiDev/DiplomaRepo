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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panFooter = new System.Windows.Forms.Panel();
            this.panWindowTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.panWinStateButtons = new System.Windows.Forms.Panel();
            this.butMax = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.butMin = new System.Windows.Forms.Button();
            this.panBackArea = new System.Windows.Forms.Panel();
            this.panSlider = new System.Windows.Forms.Panel();
            this.buts8 = new System.Windows.Forms.Button();
            this.buts9 = new System.Windows.Forms.Button();
            this.buts7 = new System.Windows.Forms.Button();
            this.buts6 = new System.Windows.Forms.Button();
            this.buts5 = new System.Windows.Forms.Button();
            this.buts4 = new System.Windows.Forms.Button();
            this.buts3 = new System.Windows.Forms.Button();
            this.buts2 = new System.Windows.Forms.Button();
            this.buts1 = new System.Windows.Forms.Button();
            this.panAdminPanel = new System.Windows.Forms.Panel();
            this.panAdminPanelSearch = new System.Windows.Forms.Panel();
            this.panAdminPanelFooter = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butRemoveAvatar = new System.Windows.Forms.Button();
            this.dgvAdmin = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAdminPanelHeader = new System.Windows.Forms.Panel();
            this.butUserModules = new System.Windows.Forms.Button();
            this.butUserActivity = new System.Windows.Forms.Button();
            this.butUserData = new System.Windows.Forms.Button();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.panReport = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panReportHeader = new System.Windows.Forms.Panel();
            this.lblDMAlgoritm = new System.Windows.Forms.Label();
            this.butAnalysis = new System.Windows.Forms.Button();
            this.panProfile = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panMenu = new System.Windows.Forms.Panel();
            this.panAccount = new System.Windows.Forms.Panel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pbMenuOne = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panFooter.SuspendLayout();
            this.panWindowTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panWinStateButtons.SuspendLayout();
            this.panBackArea.SuspendLayout();
            this.panSlider.SuspendLayout();
            this.panAdminPanel.SuspendLayout();
            this.panAdminPanelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).BeginInit();
            this.panelAdminPanelHeader.SuspendLayout();
            this.panReport.SuspendLayout();
            this.panReportHeader.SuspendLayout();
            this.panProfile.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.panAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuOne)).BeginInit();
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
            this.panWindowTitle.Controls.Add(this.lblTitle);
            this.panWindowTitle.Controls.Add(this.pbMenu);
            this.panWindowTitle.Location = new System.Drawing.Point(3, 0);
            this.panWindowTitle.Name = "panWindowTitle";
            this.panWindowTitle.Size = new System.Drawing.Size(367, 57);
            this.panWindowTitle.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(47, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 30);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "DM Analytics Application";
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
            this.panBackArea.Controls.Add(this.panAdminPanel);
            this.panBackArea.Controls.Add(this.panReport);
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
            // panAdminPanel
            // 
            this.panAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panAdminPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panAdminPanel.Controls.Add(this.panAdminPanelSearch);
            this.panAdminPanel.Controls.Add(this.panAdminPanelFooter);
            this.panAdminPanel.Controls.Add(this.dgvAdmin);
            this.panAdminPanel.Controls.Add(this.panelAdminPanelHeader);
            this.panAdminPanel.Location = new System.Drawing.Point(12, 9);
            this.panAdminPanel.Name = "panAdminPanel";
            this.panAdminPanel.Size = new System.Drawing.Size(1000, 628);
            this.panAdminPanel.TabIndex = 1;
            // 
            // panAdminPanelSearch
            // 
            this.panAdminPanelSearch.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panAdminPanelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panAdminPanelSearch.Location = new System.Drawing.Point(0, 60);
            this.panAdminPanelSearch.Name = "panAdminPanelSearch";
            this.panAdminPanelSearch.Size = new System.Drawing.Size(1000, 40);
            this.panAdminPanelSearch.TabIndex = 4;
            // 
            // panAdminPanelFooter
            // 
            this.panAdminPanelFooter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panAdminPanelFooter.Controls.Add(this.button3);
            this.panAdminPanelFooter.Controls.Add(this.button2);
            this.panAdminPanelFooter.Controls.Add(this.button1);
            this.panAdminPanelFooter.Controls.Add(this.butRemoveAvatar);
            this.panAdminPanelFooter.Controls.Add(this.button4);
            this.panAdminPanelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panAdminPanelFooter.Location = new System.Drawing.Point(0, 568);
            this.panAdminPanelFooter.Name = "panAdminPanelFooter";
            this.panAdminPanelFooter.Size = new System.Drawing.Size(1000, 60);
            this.panAdminPanelFooter.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::DiplomaClient.Properties.Resources.EditButton;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(887, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 18;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::DiplomaClient.Properties.Resources.LockButton;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(775, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DiplomaClient.Properties.Resources.RemoveImageButton;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(943, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // butRemoveAvatar
            // 
            this.butRemoveAvatar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butRemoveAvatar.BackColor = System.Drawing.Color.Transparent;
            this.butRemoveAvatar.BackgroundImage = global::DiplomaClient.Properties.Resources.AddUserButton;
            this.butRemoveAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butRemoveAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRemoveAvatar.FlatAppearance.BorderSize = 0;
            this.butRemoveAvatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butRemoveAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butRemoveAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRemoveAvatar.Location = new System.Drawing.Point(831, 7);
            this.butRemoveAvatar.Name = "butRemoveAvatar";
            this.butRemoveAvatar.Size = new System.Drawing.Size(50, 50);
            this.butRemoveAvatar.TabIndex = 15;
            this.butRemoveAvatar.UseVisualStyleBackColor = false;
            // 
            // dgvAdmin
            // 
            this.dgvAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvAdmin.Location = new System.Drawing.Point(0, 122);
            this.dgvAdmin.Name = "dgvAdmin";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdmin.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdmin.RowTemplate.Height = 30;
            this.dgvAdmin.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdmin.Size = new System.Drawing.Size(1000, 450);
            this.dgvAdmin.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // panelAdminPanelHeader
            // 
            this.panelAdminPanelHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelAdminPanelHeader.Controls.Add(this.butUserModules);
            this.panelAdminPanelHeader.Controls.Add(this.butUserActivity);
            this.panelAdminPanelHeader.Controls.Add(this.butUserData);
            this.panelAdminPanelHeader.Controls.Add(this.lblAdminPanel);
            this.panelAdminPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelAdminPanelHeader.Name = "panelAdminPanelHeader";
            this.panelAdminPanelHeader.Size = new System.Drawing.Size(1000, 60);
            this.panelAdminPanelHeader.TabIndex = 1;
            // 
            // butUserModules
            // 
            this.butUserModules.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butUserModules.BackColor = System.Drawing.Color.Tomato;
            this.butUserModules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butUserModules.FlatAppearance.BorderSize = 0;
            this.butUserModules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUserModules.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUserModules.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butUserModules.Location = new System.Drawing.Point(873, 5);
            this.butUserModules.Name = "butUserModules";
            this.butUserModules.Size = new System.Drawing.Size(120, 49);
            this.butUserModules.TabIndex = 37;
            this.butUserModules.Text = "Modules";
            this.butUserModules.UseVisualStyleBackColor = false;
            // 
            // butUserActivity
            // 
            this.butUserActivity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butUserActivity.BackColor = System.Drawing.Color.Tomato;
            this.butUserActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butUserActivity.FlatAppearance.BorderSize = 0;
            this.butUserActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUserActivity.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUserActivity.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butUserActivity.Location = new System.Drawing.Point(747, 5);
            this.butUserActivity.Name = "butUserActivity";
            this.butUserActivity.Size = new System.Drawing.Size(120, 49);
            this.butUserActivity.TabIndex = 36;
            this.butUserActivity.Text = "Activity";
            this.butUserActivity.UseVisualStyleBackColor = false;
            // 
            // butUserData
            // 
            this.butUserData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butUserData.BackColor = System.Drawing.Color.Tomato;
            this.butUserData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butUserData.FlatAppearance.BorderSize = 0;
            this.butUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUserData.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUserData.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butUserData.Location = new System.Drawing.Point(621, 5);
            this.butUserData.Name = "butUserData";
            this.butUserData.Size = new System.Drawing.Size(120, 49);
            this.butUserData.TabIndex = 35;
            this.butUserData.Text = "Accounts";
            this.butUserData.UseVisualStyleBackColor = false;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPanel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAdminPanel.Location = new System.Drawing.Point(13, 12);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(165, 30);
            this.lblAdminPanel.TabIndex = 19;
            this.lblAdminPanel.Text = "Admin Panel";
            // 
            // panReport
            // 
            this.panReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panReport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panReport.Controls.Add(this.reportViewer1);
            this.panReport.Controls.Add(this.panReportHeader);
            this.panReport.Location = new System.Drawing.Point(12, 9);
            this.panReport.Name = "panReport";
            this.panReport.Size = new System.Drawing.Size(1000, 628);
            this.panReport.TabIndex = 1;
            this.panReport.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Location = new System.Drawing.Point(0, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1000, 531);
            this.reportViewer1.TabIndex = 2;
            // 
            // panReportHeader
            // 
            this.panReportHeader.BackColor = System.Drawing.Color.DarkGreen;
            this.panReportHeader.Controls.Add(this.lblDMAlgoritm);
            this.panReportHeader.Controls.Add(this.butAnalysis);
            this.panReportHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panReportHeader.Location = new System.Drawing.Point(0, 0);
            this.panReportHeader.Name = "panReportHeader";
            this.panReportHeader.Size = new System.Drawing.Size(1000, 60);
            this.panReportHeader.TabIndex = 1;
            // 
            // lblDMAlgoritm
            // 
            this.lblDMAlgoritm.AutoSize = true;
            this.lblDMAlgoritm.BackColor = System.Drawing.Color.Transparent;
            this.lblDMAlgoritm.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDMAlgoritm.Location = new System.Drawing.Point(13, 13);
            this.lblDMAlgoritm.Name = "lblDMAlgoritm";
            this.lblDMAlgoritm.Size = new System.Drawing.Size(169, 30);
            this.lblDMAlgoritm.TabIndex = 18;
            this.lblDMAlgoritm.Text = "Analysis Type";
            // 
            // butAnalysis
            // 
            this.butAnalysis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.butAnalysis.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.butAnalysis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAnalysis.FlatAppearance.BorderSize = 0;
            this.butAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAnalysis.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAnalysis.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butAnalysis.Location = new System.Drawing.Point(767, 5);
            this.butAnalysis.Name = "butAnalysis";
            this.butAnalysis.Size = new System.Drawing.Size(226, 49);
            this.butAnalysis.TabIndex = 35;
            this.butAnalysis.Text = "Run Analysis";
            this.butAnalysis.UseVisualStyleBackColor = false;
            // 
            // panProfile
            // 
            this.panProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panProfile.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panProfile.Controls.Add(this.label3);
            this.panProfile.Location = new System.Drawing.Point(12, 9);
            this.panProfile.Name = "panProfile";
            this.panProfile.Size = new System.Drawing.Size(1000, 628);
            this.panProfile.TabIndex = 0;
            this.panProfile.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(628, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "profile";
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
            // panAccount
            // 
            this.panAccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panAccount.Controls.Add(this.tbLogin);
            this.panAccount.Controls.Add(this.pbAvatar);
            this.panAccount.Location = new System.Drawing.Point(440, 3);
            this.panAccount.Name = "panAccount";
            this.panAccount.Size = new System.Drawing.Size(581, 54);
            this.panAccount.TabIndex = 21;
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Enabled = false;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(193, 11);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(329, 26);
            this.tbLogin.TabIndex = 22;
            this.tbLogin.Text = "User(Admin)";
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAvatar.Image = global::DiplomaClient.Properties.Resources.UserProfileDefault;
            this.pbAvatar.Location = new System.Drawing.Point(534, 5);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(44, 43);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 20;
            this.pbAvatar.TabStop = false;
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
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::DiplomaClient.Properties.Resources.EditButton;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(943, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 19;
            this.button4.UseVisualStyleBackColor = false;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panFooter.ResumeLayout(false);
            this.panWindowTitle.ResumeLayout(false);
            this.panWindowTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panWinStateButtons.ResumeLayout(false);
            this.panBackArea.ResumeLayout(false);
            this.panSlider.ResumeLayout(false);
            this.panAdminPanel.ResumeLayout(false);
            this.panAdminPanelFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmin)).EndInit();
            this.panelAdminPanelHeader.ResumeLayout(false);
            this.panelAdminPanelHeader.PerformLayout();
            this.panReport.ResumeLayout(false);
            this.panReportHeader.ResumeLayout(false);
            this.panReportHeader.PerformLayout();
            this.panProfile.ResumeLayout(false);
            this.panProfile.PerformLayout();
            this.panMenu.ResumeLayout(false);
            this.panMenu.PerformLayout();
            this.panAccount.ResumeLayout(false);
            this.panAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panFooter;
        private System.Windows.Forms.Panel panWinStateButtons;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butMin;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Panel panWindowTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button butMax;
        private System.Windows.Forms.Panel panBackArea;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Panel panAdminPanel;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pbMenuOne;
        private System.Windows.Forms.Panel panAccount;
        private System.Windows.Forms.PictureBox pbAvatar;
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
        private System.Windows.Forms.Panel panProfile;
        private System.Windows.Forms.Panel panReport;
        private System.Windows.Forms.Label label3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Panel panReportHeader;
        private System.Windows.Forms.Label lblDMAlgoritm;
        private System.Windows.Forms.Button butAnalysis;
        private System.Windows.Forms.Panel panAdminPanelSearch;
        private System.Windows.Forms.Panel panAdminPanelFooter;
        private System.Windows.Forms.DataGridView dgvAdmin;
        private System.Windows.Forms.Panel panelAdminPanelHeader;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button butUserModules;
        private System.Windows.Forms.Button butUserActivity;
        private System.Windows.Forms.Button butUserData;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butRemoveAvatar;
        private System.Windows.Forms.Button button4;
    }
}