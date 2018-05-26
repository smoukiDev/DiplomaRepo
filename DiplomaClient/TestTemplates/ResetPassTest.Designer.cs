namespace DiplomaClient.TestTemplates
{
    partial class ResetPassTest
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
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butSend = new System.Windows.Forms.Button();
            this.tbHash = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butEnterCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEmail.Location = new System.Drawing.Point(52, 71);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(453, 29);
            this.tbEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // butSend
            // 
            this.butSend.Location = new System.Drawing.Point(52, 106);
            this.butSend.Name = "butSend";
            this.butSend.Size = new System.Drawing.Size(133, 53);
            this.butSend.TabIndex = 2;
            this.butSend.Text = "Send";
            this.butSend.UseVisualStyleBackColor = true;
            this.butSend.Click += new System.EventHandler(this.butSend_Click);
            // 
            // tbHash
            // 
            this.tbHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbHash.Location = new System.Drawing.Point(52, 200);
            this.tbHash.Name = "tbHash";
            this.tbHash.Size = new System.Drawing.Size(453, 29);
            this.tbHash.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(48, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hash";
            // 
            // butEnterCode
            // 
            this.butEnterCode.Location = new System.Drawing.Point(52, 235);
            this.butEnterCode.Name = "butEnterCode";
            this.butEnterCode.Size = new System.Drawing.Size(133, 53);
            this.butEnterCode.TabIndex = 5;
            this.butEnterCode.Text = "Send";
            this.butEnterCode.UseVisualStyleBackColor = true;
            // 
            // ResetCodeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 392);
            this.Controls.Add(this.butEnterCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHash);
            this.Controls.Add(this.butSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmail);
            this.Name = "ResetCodeTest";
            this.Text = "ResetCodeTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butSend;
        private System.Windows.Forms.TextBox tbHash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butEnterCode;
    }
}