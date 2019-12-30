namespace autoDATA
{
    partial class Settings
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
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.lbNewPasswordAgain = new System.Windows.Forms.Label();
            this.tbSettingsNewPassword = new System.Windows.Forms.TextBox();
            this.tbSettingsConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.bnSettingsSave = new System.Windows.Forms.Button();
            this.bnSettingsCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Location = new System.Drawing.Point(58, 35);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(65, 17);
            this.lbNewPassword.TabIndex = 1;
            this.lbNewPassword.Text = "Új jelszó:";
            // 
            // lbNewPasswordAgain
            // 
            this.lbNewPasswordAgain.AutoSize = true;
            this.lbNewPasswordAgain.Location = new System.Drawing.Point(58, 72);
            this.lbNewPasswordAgain.Name = "lbNewPasswordAgain";
            this.lbNewPasswordAgain.Size = new System.Drawing.Size(146, 17);
            this.lbNewPasswordAgain.TabIndex = 2;
            this.lbNewPasswordAgain.Text = "Új jelszó mégegyszer:";
            // 
            // tbSettingsNewPassword
            // 
            this.tbSettingsNewPassword.Location = new System.Drawing.Point(226, 35);
            this.tbSettingsNewPassword.Name = "tbSettingsNewPassword";
            this.tbSettingsNewPassword.PasswordChar = '*';
            this.tbSettingsNewPassword.Size = new System.Drawing.Size(161, 22);
            this.tbSettingsNewPassword.TabIndex = 4;
            this.tbSettingsNewPassword.Leave += new System.EventHandler(this.tbSettingsNewPassword_Leave);
            // 
            // tbSettingsConfirmNewPassword
            // 
            this.tbSettingsConfirmNewPassword.Location = new System.Drawing.Point(226, 72);
            this.tbSettingsConfirmNewPassword.Name = "tbSettingsConfirmNewPassword";
            this.tbSettingsConfirmNewPassword.PasswordChar = '*';
            this.tbSettingsConfirmNewPassword.Size = new System.Drawing.Size(161, 22);
            this.tbSettingsConfirmNewPassword.TabIndex = 5;
            this.tbSettingsConfirmNewPassword.Leave += new System.EventHandler(this.tbSettingsConfirmNewPassword_Leave);
            // 
            // bnSettingsSave
            // 
            this.bnSettingsSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnSettingsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnSettingsSave.Location = new System.Drawing.Point(131, 128);
            this.bnSettingsSave.Name = "bnSettingsSave";
            this.bnSettingsSave.Size = new System.Drawing.Size(87, 35);
            this.bnSettingsSave.TabIndex = 6;
            this.bnSettingsSave.Text = "Mentés";
            this.bnSettingsSave.UseVisualStyleBackColor = false;
            this.bnSettingsSave.Click += new System.EventHandler(this.bnSettingsSave_Click);
            // 
            // bnSettingsCancel
            // 
            this.bnSettingsCancel.BackColor = System.Drawing.Color.Red;
            this.bnSettingsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnSettingsCancel.Location = new System.Drawing.Point(250, 128);
            this.bnSettingsCancel.Name = "bnSettingsCancel";
            this.bnSettingsCancel.Size = new System.Drawing.Size(87, 35);
            this.bnSettingsCancel.TabIndex = 7;
            this.bnSettingsCancel.Text = "Mégse";
            this.bnSettingsCancel.UseVisualStyleBackColor = false;
            this.bnSettingsCancel.Click += new System.EventHandler(this.bnSettingsCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 8;
            this.label2.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 200);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnSettingsCancel);
            this.Controls.Add(this.bnSettingsSave);
            this.Controls.Add(this.tbSettingsConfirmNewPassword);
            this.Controls.Add(this.tbSettingsNewPassword);
            this.Controls.Add(this.lbNewPasswordAgain);
            this.Controls.Add(this.lbNewPassword);
            this.Name = "Settings";
            this.Text = "Beállítások";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label lbNewPasswordAgain;
        private System.Windows.Forms.TextBox tbSettingsNewPassword;
        private System.Windows.Forms.TextBox tbSettingsConfirmNewPassword;
        private System.Windows.Forms.Button bnSettingsSave;
        private System.Windows.Forms.Button bnSettingsCancel;
       // private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}