namespace autoDATA
{
    partial class Form1
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
            this.bnLogin = new System.Windows.Forms.Button();
            this.bnDatabase = new System.Windows.Forms.Button();
            this.bnAdmin = new System.Windows.Forms.Button();
            this.bnLogout = new System.Windows.Forms.Button();
            this.bnCloseProgram = new System.Windows.Forms.Button();
            this.bnConverters = new System.Windows.Forms.Button();
            this.bnSettings = new System.Windows.Forms.Button();
            this.lbLoggedInAs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAdminContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnLogin
            // 
            this.bnLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.bnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnLogin.Location = new System.Drawing.Point(9, 40);
            this.bnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnLogin.Name = "bnLogin";
            this.bnLogin.Size = new System.Drawing.Size(78, 28);
            this.bnLogin.TabIndex = 0;
            this.bnLogin.Text = "Belépés";
            this.bnLogin.UseVisualStyleBackColor = false;
            this.bnLogin.Click += new System.EventHandler(this.bnLogin_Click);
            // 
            // bnDatabase
            // 
            this.bnDatabase.BackColor = System.Drawing.SystemColors.Menu;
            this.bnDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnDatabase.Location = new System.Drawing.Point(33, 122);
            this.bnDatabase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnDatabase.Name = "bnDatabase";
            this.bnDatabase.Size = new System.Drawing.Size(150, 41);
            this.bnDatabase.TabIndex = 1;
            this.bnDatabase.Text = "Autó adatbázis";
            this.bnDatabase.UseVisualStyleBackColor = false;
            this.bnDatabase.Click += new System.EventHandler(this.bnDatabase_Click);
            // 
            // bnAdmin
            // 
            this.bnAdmin.BackColor = System.Drawing.SystemColors.Menu;
            this.bnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnAdmin.Location = new System.Drawing.Point(61, 293);
            this.bnAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnAdmin.Name = "bnAdmin";
            this.bnAdmin.Size = new System.Drawing.Size(100, 28);
            this.bnAdmin.TabIndex = 2;
            this.bnAdmin.Text = "Admin";
            this.bnAdmin.UseVisualStyleBackColor = false;
            this.bnAdmin.Click += new System.EventHandler(this.bnAdmin_Click);
            // 
            // bnLogout
            // 
            this.bnLogout.BackColor = System.Drawing.SystemColors.Menu;
            this.bnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnLogout.Location = new System.Drawing.Point(9, 73);
            this.bnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnLogout.Name = "bnLogout";
            this.bnLogout.Size = new System.Drawing.Size(78, 28);
            this.bnLogout.TabIndex = 3;
            this.bnLogout.Text = "Kilépés";
            this.bnLogout.UseVisualStyleBackColor = false;
            this.bnLogout.Click += new System.EventHandler(this.bnLogout_Click);
            // 
            // bnCloseProgram
            // 
            this.bnCloseProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bnCloseProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnCloseProgram.Location = new System.Drawing.Point(137, 40);
            this.bnCloseProgram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnCloseProgram.Name = "bnCloseProgram";
            this.bnCloseProgram.Size = new System.Drawing.Size(65, 28);
            this.bnCloseProgram.TabIndex = 4;
            this.bnCloseProgram.Text = "Bezárás";
            this.bnCloseProgram.UseVisualStyleBackColor = false;
            this.bnCloseProgram.Click += new System.EventHandler(this.bnCloseProgram_Click);
            // 
            // bnConverters
            // 
            this.bnConverters.BackColor = System.Drawing.SystemColors.Menu;
            this.bnConverters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnConverters.Location = new System.Drawing.Point(33, 182);
            this.bnConverters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnConverters.Name = "bnConverters";
            this.bnConverters.Size = new System.Drawing.Size(150, 41);
            this.bnConverters.TabIndex = 5;
            this.bnConverters.Text = "Konvertálók";
            this.bnConverters.UseVisualStyleBackColor = false;
            this.bnConverters.Click += new System.EventHandler(this.bnConverters_Click);
            // 
            // bnSettings
            // 
            this.bnSettings.BackColor = System.Drawing.SystemColors.Menu;
            this.bnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnSettings.Location = new System.Drawing.Point(61, 260);
            this.bnSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bnSettings.Name = "bnSettings";
            this.bnSettings.Size = new System.Drawing.Size(100, 28);
            this.bnSettings.TabIndex = 6;
            this.bnSettings.Text = "Beállítások";
            this.bnSettings.UseVisualStyleBackColor = false;
            this.bnSettings.Click += new System.EventHandler(this.bnSettings_Click);
            // 
            // lbLoggedInAs
            // 
            this.lbLoggedInAs.AutoSize = true;
            this.lbLoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbLoggedInAs.Location = new System.Drawing.Point(82, 15);
            this.lbLoggedInAs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoggedInAs.Name = "lbLoggedInAs";
            this.lbLoggedInAs.Size = new System.Drawing.Size(0, 13);
            this.lbLoggedInAs.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Belépve, mint:";
            // 
            // lbAdminContact
            // 
            this.lbAdminContact.AutoSize = true;
            this.lbAdminContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAdminContact.ForeColor = System.Drawing.Color.Blue;
            this.lbAdminContact.Location = new System.Drawing.Point(71, 336);
            this.lbAdminContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdminContact.Name = "lbAdminContact";
            this.lbAdminContact.Size = new System.Drawing.Size(77, 13);
            this.lbAdminContact.TabIndex = 10;
            this.lbAdminContact.Text = "Hibabejelentés";
            this.lbAdminContact.Click += new System.EventHandler(this.lbAdminContact_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(232, 368);
            this.ControlBox = false;
            this.Controls.Add(this.lbAdminContact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLoggedInAs);
            this.Controls.Add(this.bnSettings);
            this.Controls.Add(this.bnConverters);
            this.Controls.Add(this.bnCloseProgram);
            this.Controls.Add(this.bnLogout);
            this.Controls.Add(this.bnAdmin);
            this.Controls.Add(this.bnDatabase);
            this.Controls.Add(this.bnLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Főmenü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnLogin;
        private System.Windows.Forms.Button bnDatabase;
        private System.Windows.Forms.Button bnAdmin;
        private System.Windows.Forms.Button bnLogout;
        private System.Windows.Forms.Button bnCloseProgram;
        private System.Windows.Forms.Button bnConverters;
        private System.Windows.Forms.Button bnSettings;
        public System.Windows.Forms.Label lbLoggedInAs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAdminContact;
    }
}

