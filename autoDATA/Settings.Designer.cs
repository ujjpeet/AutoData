﻿namespace autoDATA
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
            this.lbOldPassword = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.lbNewPasswordAgain = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bnSettingsSave = new System.Windows.Forms.Button();
            this.bnSettingsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOldPassword
            // 
            this.lbOldPassword.AutoSize = true;
            this.lbOldPassword.Location = new System.Drawing.Point(60, 43);
            this.lbOldPassword.Name = "lbOldPassword";
            this.lbOldPassword.Size = new System.Drawing.Size(81, 17);
            this.lbOldPassword.TabIndex = 0;
            this.lbOldPassword.Text = "Régi jelszó:";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.Location = new System.Drawing.Point(60, 80);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(65, 17);
            this.lbNewPassword.TabIndex = 1;
            this.lbNewPassword.Text = "Új jelszó:";
            // 
            // lbNewPasswordAgain
            // 
            this.lbNewPasswordAgain.AutoSize = true;
            this.lbNewPasswordAgain.Location = new System.Drawing.Point(60, 117);
            this.lbNewPasswordAgain.Name = "lbNewPasswordAgain";
            this.lbNewPasswordAgain.Size = new System.Drawing.Size(146, 17);
            this.lbNewPasswordAgain.TabIndex = 2;
            this.lbNewPasswordAgain.Text = "Új jelszó mégegyszer:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(161, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(228, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(161, 22);
            this.textBox3.TabIndex = 5;
            // 
            // bnSettingsSave
            // 
            this.bnSettingsSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnSettingsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnSettingsSave.Location = new System.Drawing.Point(133, 173);
            this.bnSettingsSave.Name = "bnSettingsSave";
            this.bnSettingsSave.Size = new System.Drawing.Size(87, 35);
            this.bnSettingsSave.TabIndex = 6;
            this.bnSettingsSave.Text = "Mentés";
            this.bnSettingsSave.UseVisualStyleBackColor = false;
            // 
            // bnSettingsCancel
            // 
            this.bnSettingsCancel.BackColor = System.Drawing.Color.Red;
            this.bnSettingsCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnSettingsCancel.Location = new System.Drawing.Point(252, 173);
            this.bnSettingsCancel.Name = "bnSettingsCancel";
            this.bnSettingsCancel.Size = new System.Drawing.Size(87, 35);
            this.bnSettingsCancel.TabIndex = 7;
            this.bnSettingsCancel.Text = "Mégse";
            this.bnSettingsCancel.UseVisualStyleBackColor = false;
            this.bnSettingsCancel.Click += new System.EventHandler(this.bnSettingsCancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 261);
            this.ControlBox = false;
            this.Controls.Add(this.bnSettingsCancel);
            this.Controls.Add(this.bnSettingsSave);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbNewPasswordAgain);
            this.Controls.Add(this.lbNewPassword);
            this.Controls.Add(this.lbOldPassword);
            this.Name = "Settings";
            this.Text = "Beállítások";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOldPassword;
        private System.Windows.Forms.Label lbNewPassword;
        private System.Windows.Forms.Label lbNewPasswordAgain;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bnSettingsSave;
        private System.Windows.Forms.Button bnSettingsCancel;
    }
}