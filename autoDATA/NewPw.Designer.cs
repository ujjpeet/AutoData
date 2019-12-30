namespace autoDATA
{
    partial class NewPw
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
            this.label3 = new System.Windows.Forms.Label();
            this.bnAdminNewPwSave = new System.Windows.Forms.Button();
            this.tbAdminConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.tbAdminGiveNewPassword = new System.Windows.Forms.TextBox();
            this.lbNewPasswordAgain = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.bnAdminNewPwCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 111);
            this.label3.MaximumSize = new System.Drawing.Size(300, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 51);
            this.label3.TabIndex = 38;
            this.label3.Text = "* A jelszónak legalább 6 karakterből kell állnia, tartalmazzon legalább egy nagyb" +
    "etűt, egy kisbetűt és egy számot is";
            // 
            // bnAdminNewPwSave
            // 
            this.bnAdminNewPwSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bnAdminNewPwSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnAdminNewPwSave.Location = new System.Drawing.Point(113, 177);
            this.bnAdminNewPwSave.Name = "bnAdminNewPwSave";
            this.bnAdminNewPwSave.Size = new System.Drawing.Size(101, 27);
            this.bnAdminNewPwSave.TabIndex = 37;
            this.bnAdminNewPwSave.Text = "Mentés";
            this.bnAdminNewPwSave.UseVisualStyleBackColor = false;
            this.bnAdminNewPwSave.Click += new System.EventHandler(this.bnAdminNewPwSave_Click);
            // 
            // tbAdminConfirmNewPassword
            // 
            this.tbAdminConfirmNewPassword.Location = new System.Drawing.Point(204, 65);
            this.tbAdminConfirmNewPassword.Name = "tbAdminConfirmNewPassword";
            this.tbAdminConfirmNewPassword.PasswordChar = '*';
            this.tbAdminConfirmNewPassword.Size = new System.Drawing.Size(161, 22);
            this.tbAdminConfirmNewPassword.TabIndex = 36;
            // 
            // tbAdminGiveNewPassword
            // 
            this.tbAdminGiveNewPassword.Location = new System.Drawing.Point(204, 28);
            this.tbAdminGiveNewPassword.Name = "tbAdminGiveNewPassword";
            this.tbAdminGiveNewPassword.PasswordChar = '*';
            this.tbAdminGiveNewPassword.Size = new System.Drawing.Size(161, 22);
            this.tbAdminGiveNewPassword.TabIndex = 35;
            this.tbAdminGiveNewPassword.Leave += new System.EventHandler(this.tbAdminGiveNewPassword_Leave);
            // 
            // lbNewPasswordAgain
            // 
            this.lbNewPasswordAgain.AutoSize = true;
            this.lbNewPasswordAgain.Location = new System.Drawing.Point(36, 65);
            this.lbNewPasswordAgain.Name = "lbNewPasswordAgain";
            this.lbNewPasswordAgain.Size = new System.Drawing.Size(146, 17);
            this.lbNewPasswordAgain.TabIndex = 34;
            this.lbNewPasswordAgain.Text = "Új jelszó mégegyszer:";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Location = new System.Drawing.Point(36, 28);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(65, 17);
            this.lbNewPassword.TabIndex = 33;
            this.lbNewPassword.Text = "Új jelszó:";
            // 
            // bnAdminNewPwCancel
            // 
            this.bnAdminNewPwCancel.Location = new System.Drawing.Point(239, 177);
            this.bnAdminNewPwCancel.Name = "bnAdminNewPwCancel";
            this.bnAdminNewPwCancel.Size = new System.Drawing.Size(107, 27);
            this.bnAdminNewPwCancel.TabIndex = 39;
            this.bnAdminNewPwCancel.Text = "Mégse";
            this.bnAdminNewPwCancel.UseVisualStyleBackColor = true;
            this.bnAdminNewPwCancel.Click += new System.EventHandler(this.bnAdminNewPwCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // NewPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 234);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bnAdminNewPwCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnAdminNewPwSave);
            this.Controls.Add(this.tbAdminConfirmNewPassword);
            this.Controls.Add(this.tbAdminGiveNewPassword);
            this.Controls.Add(this.lbNewPasswordAgain);
            this.Controls.Add(this.lbNewPassword);
            this.Name = "NewPw";
            this.Text = "Új jelszó";
            this.Load += new System.EventHandler(this.NewPw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnAdminNewPwSave;
        private System.Windows.Forms.TextBox tbAdminConfirmNewPassword;
        private System.Windows.Forms.TextBox tbAdminGiveNewPassword;
        private System.Windows.Forms.Label lbNewPasswordAgain;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Button bnAdminNewPwCancel;
        private System.Windows.Forms.Label label1;
    }
}