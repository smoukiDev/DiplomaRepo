namespace DiplomaClient
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.butClose = new System.Windows.Forms.Button();
            this.butMin = new System.Windows.Forms.Button();
            this.panHeader = new System.Windows.Forms.Panel();
            this.lblWindowTitle = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassConfirm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.rtbAdress = new System.Windows.Forms.RichTextBox();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.butAddAvatar = new System.Windows.Forms.Button();
            this.butRemoveAvatar = new System.Windows.Forms.Button();
            this.butRegister = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lblErrorLog = new System.Windows.Forms.Label();
            this.panFooter = new System.Windows.Forms.Panel();
            this.lblPassSecure = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonMakeVisible1 = new System.Windows.Forms.Button();
            this.buttonMakeVisible2 = new System.Windows.Forms.Button();
            this.butCleanPass = new System.Windows.Forms.Button();
            this.ofdProfilePic = new System.Windows.Forms.OpenFileDialog();
            this.pLogin = new System.Windows.Forms.Panel();
            this.pPassword = new System.Windows.Forms.Panel();
            this.pConfirmPassword = new System.Windows.Forms.Panel();
            this.pFName = new System.Windows.Forms.Panel();
            this.pLName = new System.Windows.Forms.Panel();
            this.pEmail = new System.Windows.Forms.Panel();
            this.pPhone = new System.Windows.Forms.Panel();
            this.pAdress = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.butMoveBack = new System.Windows.Forms.Button();
            this.panHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(12, 108);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(421, 28);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.butClose.Location = new System.Drawing.Point(947, 7);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(50, 50);
            this.butClose.TabIndex = 9;
            this.butClose.UseVisualStyleBackColor = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butMin
            // 
            this.butMin.BackColor = System.Drawing.Color.Transparent;
            this.butMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butMin.BackgroundImage")));
            this.butMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMin.FlatAppearance.BorderSize = 0;
            this.butMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMin.Location = new System.Drawing.Point(891, 7);
            this.butMin.Name = "butMin";
            this.butMin.Size = new System.Drawing.Size(50, 50);
            this.butMin.TabIndex = 10;
            this.butMin.UseVisualStyleBackColor = false;
            this.butMin.Click += new System.EventHandler(this.butMin_Click);
            // 
            // panHeader
            // 
            this.panHeader.Controls.Add(this.butMoveBack);
            this.panHeader.Controls.Add(this.lblWindowTitle);
            this.panHeader.Controls.Add(this.pbLogo);
            this.panHeader.Controls.Add(this.butClose);
            this.panHeader.Controls.Add(this.butMin);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(1000, 66);
            this.panHeader.TabIndex = 11;
            this.panHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panHeader_MouseMove);
            // 
            // lblWindowTitle
            // 
            this.lblWindowTitle.AutoSize = true;
            this.lblWindowTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWindowTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWindowTitle.Location = new System.Drawing.Point(71, 27);
            this.lblWindowTitle.Name = "lblWindowTitle";
            this.lblWindowTitle.Size = new System.Drawing.Size(152, 30);
            this.lblWindowTitle.TabIndex = 13;
            this.lblWindowTitle.Text = "Registration";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 7);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(62, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 12;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // tbPass
            // 
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.Location = new System.Drawing.Point(12, 183);
            this.tbPass.MaxLength = 20;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '⦁';
            this.tbPass.Size = new System.Drawing.Size(421, 28);
            this.tbPass.TabIndex = 12;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // tbPassConfirm
            // 
            this.tbPassConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassConfirm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassConfirm.Location = new System.Drawing.Point(12, 258);
            this.tbPassConfirm.Name = "tbPassConfirm";
            this.tbPassConfirm.PasswordChar = '⦁';
            this.tbPassConfirm.Size = new System.Drawing.Size(421, 28);
            this.tbPassConfirm.TabIndex = 15;
            this.tbPassConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Confirm Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 30);
            this.label5.TabIndex = 22;
            this.label5.Text = "Last Name:";
            // 
            // tbLName
            // 
            this.tbLName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLName.Location = new System.Drawing.Point(12, 479);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(421, 28);
            this.tbLName.TabIndex = 21;
            this.tbLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(7, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 30);
            this.label6.TabIndex = 20;
            this.label6.Text = "Middle Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 30);
            this.label7.TabIndex = 19;
            this.label7.Text = "First Name:";
            // 
            // tbMName
            // 
            this.tbMName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMName.Location = new System.Drawing.Point(12, 404);
            this.tbMName.Name = "tbMName";
            this.tbMName.Size = new System.Drawing.Size(421, 28);
            this.tbMName.TabIndex = 18;
            this.tbMName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFName
            // 
            this.tbFName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFName.Location = new System.Drawing.Point(12, 329);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(421, 28);
            this.tbFName.TabIndex = 17;
            this.tbFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(551, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "Adress:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(551, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 30);
            this.label9.TabIndex = 26;
            this.label9.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(551, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 30);
            this.label10.TabIndex = 25;
            this.label10.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(556, 258);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(421, 28);
            this.tbEmail.TabIndex = 23;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbAdress
            // 
            this.rtbAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAdress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbAdress.Location = new System.Drawing.Point(556, 409);
            this.rtbAdress.Name = "rtbAdress";
            this.rtbAdress.Size = new System.Drawing.Size(421, 105);
            this.rtbAdress.TabIndex = 29;
            this.rtbAdress.Text = "";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = global::DiplomaClient.Properties.Resources.UserProfileDefault;
            this.pbAvatar.InitialImage = null;
            this.pbAvatar.Location = new System.Drawing.Point(556, 108);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(123, 110);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 30;
            this.pbAvatar.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(551, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 30);
            this.label11.TabIndex = 31;
            this.label11.Text = "Profile Picture:";
            // 
            // cbGender
            // 
            this.cbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGender.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(762, 108);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(215, 38);
            this.cbGender.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(757, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 30);
            this.label12.TabIndex = 33;
            this.label12.Text = "Gender:";
            // 
            // butAddAvatar
            // 
            this.butAddAvatar.BackColor = System.Drawing.Color.Transparent;
            this.butAddAvatar.BackgroundImage = global::DiplomaClient.Properties.Resources.UploadImageButton;
            this.butAddAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butAddAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAddAvatar.FlatAppearance.BorderSize = 0;
            this.butAddAvatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butAddAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butAddAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddAvatar.Location = new System.Drawing.Point(685, 108);
            this.butAddAvatar.Name = "butAddAvatar";
            this.butAddAvatar.Size = new System.Drawing.Size(50, 50);
            this.butAddAvatar.TabIndex = 14;
            this.butAddAvatar.UseVisualStyleBackColor = false;
            this.butAddAvatar.Click += new System.EventHandler(this.butAddAvatar_Click);
            // 
            // butRemoveAvatar
            // 
            this.butRemoveAvatar.BackColor = System.Drawing.Color.Transparent;
            this.butRemoveAvatar.BackgroundImage = global::DiplomaClient.Properties.Resources.RemoveImageButton;
            this.butRemoveAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butRemoveAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butRemoveAvatar.FlatAppearance.BorderSize = 0;
            this.butRemoveAvatar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butRemoveAvatar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butRemoveAvatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRemoveAvatar.Location = new System.Drawing.Point(685, 168);
            this.butRemoveAvatar.Name = "butRemoveAvatar";
            this.butRemoveAvatar.Size = new System.Drawing.Size(50, 50);
            this.butRemoveAvatar.TabIndex = 14;
            this.butRemoveAvatar.UseVisualStyleBackColor = false;
            this.butRemoveAvatar.Click += new System.EventHandler(this.butRemoveAvatar_Click);
            // 
            // butRegister
            // 
            this.butRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRegister.FlatAppearance.BorderSize = 0;
            this.butRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegister.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegister.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butRegister.Location = new System.Drawing.Point(12, 520);
            this.butRegister.Name = "butRegister";
            this.butRegister.Size = new System.Drawing.Size(421, 76);
            this.butRegister.TabIndex = 34;
            this.butRegister.Text = "Сreate Account";
            this.butRegister.UseVisualStyleBackColor = true;
            this.butRegister.Click += new System.EventHandler(this.butRegister_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.BackColor = System.Drawing.Color.Transparent;
            this.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLoading.ErrorImage = null;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(448, 520);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(90, 76);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 35;
            this.pbLoading.TabStop = false;
            // 
            // lblErrorLog
            // 
            this.lblErrorLog.AutoSize = true;
            this.lblErrorLog.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorLog.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorLog.Location = new System.Drawing.Point(12, 5);
            this.lblErrorLog.Name = "lblErrorLog";
            this.lblErrorLog.Size = new System.Drawing.Size(89, 22);
            this.lblErrorLog.TabIndex = 36;
            this.lblErrorLog.Text = "ErrorLog:";
            // 
            // panFooter
            // 
            this.panFooter.Controls.Add(this.lblPassSecure);
            this.panFooter.Controls.Add(this.lblErrorLog);
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFooter.Location = new System.Drawing.Point(0, 602);
            this.panFooter.Name = "panFooter";
            this.panFooter.Size = new System.Drawing.Size(1000, 36);
            this.panFooter.TabIndex = 37;
            this.panFooter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panFooter_MouseMove);
            // 
            // lblPassSecure
            // 
            this.lblPassSecure.AutoSize = true;
            this.lblPassSecure.BackColor = System.Drawing.Color.Transparent;
            this.lblPassSecure.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassSecure.Location = new System.Drawing.Point(12, 5);
            this.lblPassSecure.Name = "lblPassSecure";
            this.lblPassSecure.Size = new System.Drawing.Size(116, 22);
            this.lblPassSecure.TabIndex = 37;
            this.lblPassSecure.Text = "PassSecure:";
            // 
            // mtbPhone
            // 
            this.mtbPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbPhone.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbPhone.Location = new System.Drawing.Point(556, 329);
            this.mtbPhone.Mask = "+990009990099";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(421, 28);
            this.mtbPhone.TabIndex = 38;
            this.mtbPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbPhone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mtbPhone_MouseClick);
            // 
            // buttonMakeVisible1
            // 
            this.buttonMakeVisible1.BackgroundImage = global::DiplomaClient.Properties.Resources.MakeVisibleButton;
            this.buttonMakeVisible1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMakeVisible1.Location = new System.Drawing.Point(396, 146);
            this.buttonMakeVisible1.Name = "buttonMakeVisible1";
            this.buttonMakeVisible1.Size = new System.Drawing.Size(37, 31);
            this.buttonMakeVisible1.TabIndex = 39;
            this.buttonMakeVisible1.UseVisualStyleBackColor = true;
            this.buttonMakeVisible1.Click += new System.EventHandler(this.buttonMakeVisible1_Click);
            // 
            // buttonMakeVisible2
            // 
            this.buttonMakeVisible2.BackgroundImage = global::DiplomaClient.Properties.Resources.MakeVisibleButton;
            this.buttonMakeVisible2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMakeVisible2.Location = new System.Drawing.Point(396, 221);
            this.buttonMakeVisible2.Name = "buttonMakeVisible2";
            this.buttonMakeVisible2.Size = new System.Drawing.Size(37, 31);
            this.buttonMakeVisible2.TabIndex = 40;
            this.buttonMakeVisible2.UseVisualStyleBackColor = true;
            this.buttonMakeVisible2.Click += new System.EventHandler(this.buttonMakeVisible2_Click);
            // 
            // butCleanPass
            // 
            this.butCleanPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butCleanPass.FlatAppearance.BorderSize = 0;
            this.butCleanPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCleanPass.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCleanPass.Image = ((System.Drawing.Image)(resources.GetObject("butCleanPass.Image")));
            this.butCleanPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCleanPass.Location = new System.Drawing.Point(556, 520);
            this.butCleanPass.Name = "butCleanPass";
            this.butCleanPass.Size = new System.Drawing.Size(421, 76);
            this.butCleanPass.TabIndex = 41;
            this.butCleanPass.Text = "Refresh";
            this.butCleanPass.UseVisualStyleBackColor = true;
            this.butCleanPass.Click += new System.EventHandler(this.butCleanPass_Click);
            // 
            // pLogin
            // 
            this.pLogin.Location = new System.Drawing.Point(433, 108);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(20, 28);
            this.pLogin.TabIndex = 42;
            this.pLogin.Visible = false;
            // 
            // pPassword
            // 
            this.pPassword.Location = new System.Drawing.Point(433, 183);
            this.pPassword.Name = "pPassword";
            this.pPassword.Size = new System.Drawing.Size(20, 28);
            this.pPassword.TabIndex = 43;
            this.pPassword.Visible = false;
            // 
            // pConfirmPassword
            // 
            this.pConfirmPassword.Location = new System.Drawing.Point(433, 258);
            this.pConfirmPassword.Name = "pConfirmPassword";
            this.pConfirmPassword.Size = new System.Drawing.Size(20, 28);
            this.pConfirmPassword.TabIndex = 44;
            this.pConfirmPassword.Visible = false;
            // 
            // pFName
            // 
            this.pFName.Location = new System.Drawing.Point(433, 329);
            this.pFName.Name = "pFName";
            this.pFName.Size = new System.Drawing.Size(20, 28);
            this.pFName.TabIndex = 45;
            this.pFName.Visible = false;
            // 
            // pLName
            // 
            this.pLName.Location = new System.Drawing.Point(433, 479);
            this.pLName.Name = "pLName";
            this.pLName.Size = new System.Drawing.Size(20, 28);
            this.pLName.TabIndex = 46;
            this.pLName.Visible = false;
            // 
            // pEmail
            // 
            this.pEmail.Location = new System.Drawing.Point(536, 258);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(20, 28);
            this.pEmail.TabIndex = 45;
            this.pEmail.Visible = false;
            // 
            // pPhone
            // 
            this.pPhone.Location = new System.Drawing.Point(536, 329);
            this.pPhone.Name = "pPhone";
            this.pPhone.Size = new System.Drawing.Size(20, 28);
            this.pPhone.TabIndex = 46;
            this.pPhone.Visible = false;
            // 
            // pAdress
            // 
            this.pAdress.Location = new System.Drawing.Point(536, 409);
            this.pAdress.Name = "pAdress";
            this.pAdress.Size = new System.Drawing.Size(20, 105);
            this.pAdress.TabIndex = 47;
            this.pAdress.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // butMoveBack
            // 
            this.butMoveBack.BackColor = System.Drawing.Color.Transparent;
            this.butMoveBack.BackgroundImage = global::DiplomaClient.Properties.Resources.MoveBackButton;
            this.butMoveBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butMoveBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMoveBack.FlatAppearance.BorderSize = 0;
            this.butMoveBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butMoveBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.butMoveBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMoveBack.Location = new System.Drawing.Point(835, 7);
            this.butMoveBack.Name = "butMoveBack";
            this.butMoveBack.Size = new System.Drawing.Size(50, 50);
            this.butMoveBack.TabIndex = 14;
            this.butMoveBack.UseVisualStyleBackColor = false;
            this.butMoveBack.Click += new System.EventHandler(this.butMoveBack_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 638);
            this.Controls.Add(this.pAdress);
            this.Controls.Add(this.pPhone);
            this.Controls.Add(this.pEmail);
            this.Controls.Add(this.pLName);
            this.Controls.Add(this.pFName);
            this.Controls.Add(this.pConfirmPassword);
            this.Controls.Add(this.pPassword);
            this.Controls.Add(this.pLogin);
            this.Controls.Add(this.butCleanPass);
            this.Controls.Add(this.buttonMakeVisible2);
            this.Controls.Add(this.buttonMakeVisible1);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.panFooter);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.butRegister);
            this.Controls.Add(this.butRemoveAvatar);
            this.Controls.Add(this.butAddAvatar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.rtbAdress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMName);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassConfirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.tbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.panFooter.ResumeLayout(false);
            this.panFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butMin;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblWindowTitle;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.RichTextBox rtbAdress;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button butAddAvatar;
        private System.Windows.Forms.Button butRemoveAvatar;
        private System.Windows.Forms.Button butRegister;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lblErrorLog;
        private System.Windows.Forms.Panel panFooter;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Button buttonMakeVisible1;
        private System.Windows.Forms.Button buttonMakeVisible2;
        private System.Windows.Forms.Button butCleanPass;
        private System.Windows.Forms.OpenFileDialog ofdProfilePic;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.Panel pPassword;
        private System.Windows.Forms.Panel pConfirmPassword;
        private System.Windows.Forms.Panel pFName;
        private System.Windows.Forms.Panel pLName;
        private System.Windows.Forms.Panel pEmail;
        private System.Windows.Forms.Panel pPhone;
        private System.Windows.Forms.Panel pAdress;
        private System.Windows.Forms.Label lblPassSecure;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button butMoveBack;
    }
}