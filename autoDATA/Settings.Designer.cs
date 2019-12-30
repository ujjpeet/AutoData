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
            this.label3 = new System.Windows.Forms.Label();
            this.bnSaveSet = new System.Windows.Forms.Button();
            this.tbSettingsFirstName = new System.Windows.Forms.TextBox();
            this.lbRegFirstName = new System.Windows.Forms.Label();
            this.cbSettingsPosition = new System.Windows.Forms.ComboBox();
            this.tbSettingsFamilyName = new System.Windows.Forms.TextBox();
            this.lbRegEmail = new System.Windows.Forms.Label();
            this.lbRegBirthdate = new System.Windows.Forms.Label();
            this.lbRegPos = new System.Windows.Forms.Label();
            this.lbRegFamilyName = new System.Windows.Forms.Label();
            this.tbSettingsEmail = new System.Windows.Forms.TextBox();
            this.dtpSettings = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Location = new System.Drawing.Point(42, 396);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(65, 17);
            this.lbNewPassword.TabIndex = 1;
            this.lbNewPassword.Text = "Új jelszó:";
            // 
            // lbNewPasswordAgain
            // 
            this.lbNewPasswordAgain.AutoSize = true;
            this.lbNewPasswordAgain.Location = new System.Drawing.Point(42, 433);
            this.lbNewPasswordAgain.Name = "lbNewPasswordAgain";
            this.lbNewPasswordAgain.Size = new System.Drawing.Size(146, 17);
            this.lbNewPasswordAgain.TabIndex = 2;
            this.lbNewPasswordAgain.Text = "Új jelszó mégegyszer:";
            // 
            // tbSettingsNewPassword
            // 
            this.tbSettingsNewPassword.Location = new System.Drawing.Point(210, 396);
            this.tbSettingsNewPassword.Name = "tbSettingsNewPassword";
            this.tbSettingsNewPassword.PasswordChar = '*';
            this.tbSettingsNewPassword.Size = new System.Drawing.Size(153, 22);
            this.tbSettingsNewPassword.TabIndex = 4;
            this.tbSettingsNewPassword.Leave += new System.EventHandler(this.tbSettingsNewPassword_Leave);
            // 
            // tbSettingsConfirmNewPassword
            // 
            this.tbSettingsConfirmNewPassword.Location = new System.Drawing.Point(210, 433);
            this.tbSettingsConfirmNewPassword.Name = "tbSettingsConfirmNewPassword";
            this.tbSettingsConfirmNewPassword.PasswordChar = '*';
            this.tbSettingsConfirmNewPassword.Size = new System.Drawing.Size(153, 22);
            this.tbSettingsConfirmNewPassword.TabIndex = 5;
            // 
            // bnSettingsSave
            // 
            this.bnSettingsSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bnSettingsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnSettingsSave.Location = new System.Drawing.Point(124, 472);
            this.bnSettingsSave.Name = "bnSettingsSave";
            this.bnSettingsSave.Size = new System.Drawing.Size(160, 29);
            this.bnSettingsSave.TabIndex = 6;
            this.bnSettingsSave.Text = "Új jelszó mentése";
            this.bnSettingsSave.UseVisualStyleBackColor = false;
            this.bnSettingsSave.Click += new System.EventHandler(this.bnSettingsSave_Click);
            // 
            // bnSettingsCancel
            // 
            this.bnSettingsCancel.BackColor = System.Drawing.Color.Red;
            this.bnSettingsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnSettingsCancel.Location = new System.Drawing.Point(220, 253);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 325);
            this.label3.MaximumSize = new System.Drawing.Size(300, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 51);
            this.label3.TabIndex = 32;
            this.label3.Text = "* A jelszónak legalább 6 karakterből kell állnia, tartalmazzon legalább egy nagyb" +
    "etűt, egy kisbetűt és egy számot is";
            // 
            // bnSaveSet
            // 
            this.bnSaveSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnSaveSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnSaveSet.Location = new System.Drawing.Point(106, 253);
            this.bnSaveSet.Name = "bnSaveSet";
            this.bnSaveSet.Size = new System.Drawing.Size(87, 35);
            this.bnSaveSet.TabIndex = 33;
            this.bnSaveSet.Text = "Mentés";
            this.bnSaveSet.UseVisualStyleBackColor = false;
            this.bnSaveSet.Click += new System.EventHandler(this.bnSaveSet_Click);
            // 
            // tbSettingsFirstName
            // 
            this.tbSettingsFirstName.Location = new System.Drawing.Point(163, 100);
            this.tbSettingsFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSettingsFirstName.Name = "tbSettingsFirstName";
            this.tbSettingsFirstName.Size = new System.Drawing.Size(200, 22);
            this.tbSettingsFirstName.TabIndex = 48;
            // 
            // lbRegFirstName
            // 
            this.lbRegFirstName.AutoSize = true;
            this.lbRegFirstName.Location = new System.Drawing.Point(42, 103);
            this.lbRegFirstName.Name = "lbRegFirstName";
            this.lbRegFirstName.Size = new System.Drawing.Size(83, 17);
            this.lbRegFirstName.TabIndex = 47;
            this.lbRegFirstName.Text = "Keresztnév:";
            // 
            // cbSettingsPosition
            // 
            this.cbSettingsPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettingsPosition.FormattingEnabled = true;
            this.cbSettingsPosition.Location = new System.Drawing.Point(163, 138);
            this.cbSettingsPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSettingsPosition.Name = "cbSettingsPosition";
            this.cbSettingsPosition.Size = new System.Drawing.Size(121, 24);
            this.cbSettingsPosition.TabIndex = 46;
            // 
            // tbSettingsFamilyName
            // 
            this.tbSettingsFamilyName.Location = new System.Drawing.Point(163, 63);
            this.tbSettingsFamilyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSettingsFamilyName.Name = "tbSettingsFamilyName";
            this.tbSettingsFamilyName.Size = new System.Drawing.Size(200, 22);
            this.tbSettingsFamilyName.TabIndex = 40;
            // 
            // lbRegEmail
            // 
            this.lbRegEmail.AutoSize = true;
            this.lbRegEmail.Location = new System.Drawing.Point(42, 204);
            this.lbRegEmail.Name = "lbRegEmail";
            this.lbRegEmail.Size = new System.Drawing.Size(46, 17);
            this.lbRegEmail.TabIndex = 39;
            this.lbRegEmail.Text = "Email:";
            // 
            // lbRegBirthdate
            // 
            this.lbRegBirthdate.AutoSize = true;
            this.lbRegBirthdate.Location = new System.Drawing.Point(42, 172);
            this.lbRegBirthdate.Name = "lbRegBirthdate";
            this.lbRegBirthdate.Size = new System.Drawing.Size(112, 17);
            this.lbRegBirthdate.TabIndex = 38;
            this.lbRegBirthdate.Text = "Születési dátum:";
            // 
            // lbRegPos
            // 
            this.lbRegPos.AutoSize = true;
            this.lbRegPos.Location = new System.Drawing.Point(42, 138);
            this.lbRegPos.Name = "lbRegPos";
            this.lbRegPos.Size = new System.Drawing.Size(74, 17);
            this.lbRegPos.TabIndex = 37;
            this.lbRegPos.Text = "Munkakör:";
            // 
            // lbRegFamilyName
            // 
            this.lbRegFamilyName.AutoSize = true;
            this.lbRegFamilyName.Location = new System.Drawing.Point(42, 66);
            this.lbRegFamilyName.Name = "lbRegFamilyName";
            this.lbRegFamilyName.Size = new System.Drawing.Size(85, 17);
            this.lbRegFamilyName.TabIndex = 36;
            this.lbRegFamilyName.Text = "Családi név:";
            // 
            // tbSettingsEmail
            // 
            this.tbSettingsEmail.Location = new System.Drawing.Point(163, 204);
            this.tbSettingsEmail.Name = "tbSettingsEmail";
            this.tbSettingsEmail.Size = new System.Drawing.Size(200, 22);
            this.tbSettingsEmail.TabIndex = 52;
            // 
            // dtpSettings
            // 
            this.dtpSettings.Location = new System.Drawing.Point(163, 172);
            this.dtpSettings.Name = "dtpSettings";
            this.dtpSettings.Size = new System.Drawing.Size(200, 22);
            this.dtpSettings.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(159, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Adataim";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 533);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSettings);
            this.Controls.Add(this.tbSettingsEmail);
            this.Controls.Add(this.tbSettingsFirstName);
            this.Controls.Add(this.lbRegFirstName);
            this.Controls.Add(this.cbSettingsPosition);
            this.Controls.Add(this.tbSettingsFamilyName);
            this.Controls.Add(this.lbRegEmail);
            this.Controls.Add(this.lbRegBirthdate);
            this.Controls.Add(this.lbRegPos);
            this.Controls.Add(this.lbRegFamilyName);
            this.Controls.Add(this.bnSaveSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnSettingsCancel);
            this.Controls.Add(this.bnSettingsSave);
            this.Controls.Add(this.tbSettingsConfirmNewPassword);
            this.Controls.Add(this.tbSettingsNewPassword);
            this.Controls.Add(this.lbNewPasswordAgain);
            this.Controls.Add(this.lbNewPassword);
            this.Name = "Settings";
            this.Text = "Beállítások";
            this.Load += new System.EventHandler(this.Settings_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnSaveSet;
        private System.Windows.Forms.TextBox tbSettingsFirstName;
        private System.Windows.Forms.Label lbRegFirstName;
        private System.Windows.Forms.ComboBox cbSettingsPosition;
        private System.Windows.Forms.TextBox tbSettingsFamilyName;
        private System.Windows.Forms.Label lbRegEmail;
        private System.Windows.Forms.Label lbRegBirthdate;
        private System.Windows.Forms.Label lbRegPos;
        private System.Windows.Forms.Label lbRegFamilyName;
        private System.Windows.Forms.TextBox tbSettingsEmail;
        private System.Windows.Forms.DateTimePicker dtpSettings;
        private System.Windows.Forms.Label label1;
    }
}