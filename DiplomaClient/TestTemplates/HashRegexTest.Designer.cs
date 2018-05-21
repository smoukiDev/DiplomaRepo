namespace DiplomaClient
{
    partial class HashRegexTest
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
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbSalt = new System.Windows.Forms.TextBox();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassSI = new System.Windows.Forms.TextBox();
            this.butHash = new System.Windows.Forms.Button();
            this.butSI = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.butRegExp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.White;
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.Location = new System.Drawing.Point(44, 42);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(333, 28);
            this.tbPass.TabIndex = 1;
            this.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSalt
            // 
            this.tbSalt.BackColor = System.Drawing.Color.White;
            this.tbSalt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSalt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSalt.Location = new System.Drawing.Point(44, 124);
            this.tbSalt.Name = "tbSalt";
            this.tbSalt.Size = new System.Drawing.Size(333, 28);
            this.tbSalt.TabIndex = 2;
            this.tbSalt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbHash
            // 
            this.tbHash.BackColor = System.Drawing.Color.White;
            this.tbHash.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHash.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHash.Location = new System.Drawing.Point(44, 192);
            this.tbHash.Multiline = true;
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(333, 173);
            this.tbHash.TabIndex = 3;
            this.tbHash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hash:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Salt";
            // 
            // tbPassSI
            // 
            this.tbPassSI.BackColor = System.Drawing.Color.White;
            this.tbPassSI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassSI.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassSI.Location = new System.Drawing.Point(443, 42);
            this.tbPassSI.Name = "tbPassSI";
            this.tbPassSI.Size = new System.Drawing.Size(333, 28);
            this.tbPassSI.TabIndex = 16;
            this.tbPassSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butHash
            // 
            this.butHash.BackColor = System.Drawing.Color.IndianRed;
            this.butHash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butHash.FlatAppearance.BorderSize = 0;
            this.butHash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHash.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHash.ForeColor = System.Drawing.SystemColors.Control;
            this.butHash.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butHash.Location = new System.Drawing.Point(44, 385);
            this.butHash.Name = "butHash";
            this.butHash.Size = new System.Drawing.Size(333, 50);
            this.butHash.TabIndex = 17;
            this.butHash.Text = "Hash";
            this.butHash.UseVisualStyleBackColor = false;
            this.butHash.Click += new System.EventHandler(this.butHash_Click);
            // 
            // butSI
            // 
            this.butSI.BackColor = System.Drawing.Color.IndianRed;
            this.butSI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butSI.FlatAppearance.BorderSize = 0;
            this.butSI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butSI.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butSI.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butSI.Location = new System.Drawing.Point(443, 385);
            this.butSI.Name = "butSI";
            this.butSI.Size = new System.Drawing.Size(333, 50);
            this.butSI.TabIndex = 18;
            this.butSI.Text = "Sing In";
            this.butSI.UseVisualStyleBackColor = false;
            this.butSI.Click += new System.EventHandler(this.butSI_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(438, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pass Sing In";
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.White;
            this.tbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(44, 471);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(333, 28);
            this.tbEmail.TabIndex = 20;
            this.tbEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(39, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 30);
            this.label5.TabIndex = 21;
            this.label5.Text = "Email Validation By RegExp";
            // 
            // butRegExp
            // 
            this.butRegExp.BackColor = System.Drawing.Color.IndianRed;
            this.butRegExp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butRegExp.FlatAppearance.BorderSize = 0;
            this.butRegExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRegExp.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRegExp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.butRegExp.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.butRegExp.Location = new System.Drawing.Point(44, 517);
            this.butRegExp.Name = "butRegExp";
            this.butRegExp.Size = new System.Drawing.Size(333, 50);
            this.butRegExp.TabIndex = 22;
            this.butRegExp.Text = "Sing In";
            this.butRegExp.UseVisualStyleBackColor = false;
            this.butRegExp.Click += new System.EventHandler(this.butRegExp_Click);
            // 
            // HashTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 596);
            this.Controls.Add(this.butRegExp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butSI);
            this.Controls.Add(this.butHash);
            this.Controls.Add(this.tbPassSI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.tbSalt);
            this.Controls.Add(this.tbPass);
            this.Name = "HashTest";
            this.Text = "HashTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbSalt;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassSI;
        private System.Windows.Forms.Button butHash;
        private System.Windows.Forms.Button butSI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butRegExp;
    }
}