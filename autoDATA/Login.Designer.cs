namespace autoDATA
{
    partial class Login
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
            this.bnLoginOK = new System.Windows.Forms.Button();
            this.bnLoginCancel = new System.Windows.Forms.Button();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbReg = new System.Windows.Forms.Label();
            this.lbForgotPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bnLoginOK
            // 
            this.bnLoginOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnLoginOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnLoginOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnLoginOK.Location = new System.Drawing.Point(101, 116);
            this.bnLoginOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnLoginOK.Name = "bnLoginOK";
            this.bnLoginOK.Size = new System.Drawing.Size(97, 34);
            this.bnLoginOK.TabIndex = 1;
            this.bnLoginOK.Text = "Belépés";
            this.bnLoginOK.UseVisualStyleBackColor = false;
            this.bnLoginOK.Click += new System.EventHandler(this.bnLoginOK_Click);
            // 
            // bnLoginCancel
            // 
            this.bnLoginCancel.BackColor = System.Drawing.Color.Red;
            this.bnLoginCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bnLoginCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnLoginCancel.Location = new System.Drawing.Point(233, 116);
            this.bnLoginCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnLoginCancel.Name = "bnLoginCancel";
            this.bnLoginCancel.Size = new System.Drawing.Size(87, 34);
            this.bnLoginCancel.TabIndex = 4;
            this.bnLoginCancel.Text = "Mégse";
            this.bnLoginCancel.UseVisualStyleBackColor = false;
            this.bnLoginCancel.Click += new System.EventHandler(this.bnLoginCancel_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(27, 30);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(111, 17);
            this.lbUsername.TabIndex = 5;
            this.lbUsername.Text = "Felhasználónév:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(27, 62);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(52, 17);
            this.lbPassword.TabIndex = 6;
            this.lbPassword.Text = "Jelszó:";
            // 
            // lbReg
            // 
            this.lbReg.AutoSize = true;
            this.lbReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbReg.ForeColor = System.Drawing.Color.Blue;
            this.lbReg.Location = new System.Drawing.Point(103, 164);
            this.lbReg.Name = "lbReg";
            this.lbReg.Size = new System.Drawing.Size(86, 17);
            this.lbReg.TabIndex = 7;
            this.lbReg.Text = "Regisztráció";
            this.lbReg.Click += new System.EventHandler(this.lbReg_Click);
            // 
            // lbForgotPassword
            // 
            this.lbForgotPassword.AutoSize = true;
            this.lbForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbForgotPassword.ForeColor = System.Drawing.Color.Blue;
            this.lbForgotPassword.Location = new System.Drawing.Point(233, 164);
            this.lbForgotPassword.Name = "lbForgotPassword";
            this.lbForgotPassword.Size = new System.Drawing.Size(106, 17);
            this.lbForgotPassword.TabIndex = 8;
            this.lbForgotPassword.Text = "Elfelejtett jelszó";
            this.lbForgotPassword.Click += new System.EventHandler(this.lbForgotPassword_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(156, 30);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(183, 22);
            this.tbUsername.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(156, 62);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(183, 22);
            this.tbPassword.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 197);
            this.ControlBox = false;
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lbForgotPassword);
            this.Controls.Add(this.lbReg);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.bnLoginCancel);
            this.Controls.Add(this.bnLoginOK);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Belépés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnLoginOK;
        private System.Windows.Forms.Button bnLoginCancel;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbReg;
        private System.Windows.Forms.Label lbForgotPassword;
        public System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
    }
}