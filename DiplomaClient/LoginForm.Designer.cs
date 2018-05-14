namespace DiplomaClient
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.butLog = new System.Windows.Forms.Button();
            this.butCleanPass = new System.Windows.Forms.Button();
            this.butReg = new System.Windows.Forms.Button();
            this.buttonMakeVisible = new System.Windows.Forms.Button();
            this.butCleanLogin = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.butClose = new System.Windows.Forms.Button();
            this.butMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblForget = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.White;
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(73, 302);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(333, 28);
            this.tbLogin.TabIndex = 0;
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPass
            // 
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.Location = new System.Drawing.Point(73, 418);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '⦁';
            this.tbPass.Size = new System.Drawing.Size(333, 28);
            this.tbPass.TabIndex = 1;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butLog
            // 
            this.butLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butLog.FlatAppearance.BorderSize = 0;
            this.butLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLog.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLog.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butLog.Location = new System.Drawing.Point(73, 558);
            this.butLog.Name = "butLog";
            this.butLog.Size = new System.Drawing.Size(333, 50);
            this.butLog.TabIndex = 2;
            this.butLog.Text = "Login";
            this.butLog.UseVisualStyleBackColor = true;
            // 
            // butCleanPass
            // 
            this.butCleanPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butCleanPass.BackgroundImage")));
            this.butCleanPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butCleanPass.Location = new System.Drawing.Point(369, 381);
            this.butCleanPass.Name = "butCleanPass";
            this.butCleanPass.Size = new System.Drawing.Size(37, 31);
            this.butCleanPass.TabIndex = 3;
            this.butCleanPass.UseVisualStyleBackColor = true;
            this.butCleanPass.Click += new System.EventHandler(this.butCleanPass_Click);
            // 
            // butReg
            // 
            this.butReg.FlatAppearance.BorderSize = 0;
            this.butReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReg.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butReg.Location = new System.Drawing.Point(73, 625);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(333, 50);
            this.butReg.TabIndex = 4;
            this.butReg.Text = "Register";
            this.butReg.UseVisualStyleBackColor = true;
            // 
            // buttonMakeVisible
            // 
            this.buttonMakeVisible.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMakeVisible.BackgroundImage")));
            this.buttonMakeVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMakeVisible.Location = new System.Drawing.Point(326, 381);
            this.buttonMakeVisible.Name = "buttonMakeVisible";
            this.buttonMakeVisible.Size = new System.Drawing.Size(37, 31);
            this.buttonMakeVisible.TabIndex = 5;
            this.buttonMakeVisible.UseVisualStyleBackColor = true;
            this.buttonMakeVisible.Click += new System.EventHandler(this.buttonMakeVisible_Click);
            // 
            // butCleanLogin
            // 
            this.butCleanLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butCleanLogin.BackgroundImage")));
            this.butCleanLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butCleanLogin.Location = new System.Drawing.Point(369, 265);
            this.butCleanLogin.Name = "butCleanLogin";
            this.butCleanLogin.Size = new System.Drawing.Size(37, 31);
            this.butCleanLogin.TabIndex = 6;
            this.butCleanLogin.UseVisualStyleBackColor = true;
            this.butCleanLogin.Click += new System.EventHandler(this.butCleanLogin_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(145, 63);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(209, 128);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
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
            this.butClose.Location = new System.Drawing.Point(418, 12);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(50, 50);
            this.butClose.TabIndex = 8;
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
            this.butMin.Location = new System.Drawing.Point(362, 12);
            this.butMin.Name = "butMin";
            this.butMin.Size = new System.Drawing.Size(50, 50);
            this.butMin.TabIndex = 9;
            this.butMin.UseVisualStyleBackColor = false;
            this.butMin.Click += new System.EventHandler(this.butMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "DM Analytics Application";
            // 
            // lblForget
            // 
            this.lblForget.AutoSize = true;
            this.lblForget.BackColor = System.Drawing.Color.Transparent;
            this.lblForget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForget.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForget.Location = new System.Drawing.Point(161, 518);
            this.lblForget.Name = "lblForget";
            this.lblForget.Size = new System.Drawing.Size(176, 25);
            this.lblForget.TabIndex = 11;
            this.lblForget.Text = "Forget Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(68, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 12;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(68, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password:";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 720);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblForget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butMin);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.butCleanLogin);
            this.Controls.Add(this.buttonMakeVisible);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.butCleanPass);
            this.Controls.Add(this.butLog);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button butLog;
        private System.Windows.Forms.Button butCleanPass;
        private System.Windows.Forms.Button butReg;
        private System.Windows.Forms.Button buttonMakeVisible;
        private System.Windows.Forms.Button butCleanLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblForget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}