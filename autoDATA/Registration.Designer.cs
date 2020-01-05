namespace autoDATA
{
    partial class Registration
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
            this.bnRegCancel = new System.Windows.Forms.Button();
            this.bnRegSave = new System.Windows.Forms.Button();
            this.lbRegFamilyName = new System.Windows.Forms.Label();
            this.lbRegPos = new System.Windows.Forms.Label();
            this.lbRegBirthdate = new System.Windows.Forms.Label();
            this.lbRegEmail = new System.Windows.Forms.Label();
            this.lbRegPassword = new System.Windows.Forms.Label();
            this.lbRegPasswordAgain = new System.Windows.Forms.Label();
            this.tbRegFamilyName = new System.Windows.Forms.TextBox();
            this.tbRegPassword = new System.Windows.Forms.TextBox();
            this.tbRegPasswordAgain = new System.Windows.Forms.TextBox();
            this.tbRegEmail1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRegEmail2 = new System.Windows.Forms.TextBox();
            this.tbRegEmail3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRegPosition = new System.Windows.Forms.ComboBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbAutUsername = new System.Windows.Forms.Label();
            this.tbRegFirstName = new System.Windows.Forms.TextBox();
            this.lbRegFirstName = new System.Windows.Forms.Label();
            this.cbUserRegYear = new System.Windows.Forms.ComboBox();
            this.cbUserRegMonth = new System.Windows.Forms.ComboBox();
            this.cbUserRegDays = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnRegCancel
            // 
            this.bnRegCancel.BackColor = System.Drawing.Color.Red;
            this.bnRegCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnRegCancel.Location = new System.Drawing.Point(296, 334);
            this.bnRegCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnRegCancel.Name = "bnRegCancel";
            this.bnRegCancel.Size = new System.Drawing.Size(87, 34);
            this.bnRegCancel.TabIndex = 5;
            this.bnRegCancel.Text = "Mégse";
            this.bnRegCancel.UseVisualStyleBackColor = false;
            this.bnRegCancel.Click += new System.EventHandler(this.bnRegCancel_Click);
            // 
            // bnRegSave
            // 
            this.bnRegSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnRegSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnRegSave.Location = new System.Drawing.Point(134, 334);
            this.bnRegSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnRegSave.Name = "bnRegSave";
            this.bnRegSave.Size = new System.Drawing.Size(144, 34);
            this.bnRegSave.TabIndex = 7;
            this.bnRegSave.Text = "Regisztráció";
            this.bnRegSave.UseVisualStyleBackColor = false;
            this.bnRegSave.Click += new System.EventHandler(this.bnRegSave_Click);
            // 
            // lbRegFamilyName
            // 
            this.lbRegFamilyName.AutoSize = true;
            this.lbRegFamilyName.Location = new System.Drawing.Point(36, 23);
            this.lbRegFamilyName.Name = "lbRegFamilyName";
            this.lbRegFamilyName.Size = new System.Drawing.Size(85, 17);
            this.lbRegFamilyName.TabIndex = 8;
            this.lbRegFamilyName.Text = "Családi név:";
            // 
            // lbRegPos
            // 
            this.lbRegPos.AutoSize = true;
            this.lbRegPos.Location = new System.Drawing.Point(36, 95);
            this.lbRegPos.Name = "lbRegPos";
            this.lbRegPos.Size = new System.Drawing.Size(74, 17);
            this.lbRegPos.TabIndex = 9;
            this.lbRegPos.Text = "Munkakör:";
            // 
            // lbRegBirthdate
            // 
            this.lbRegBirthdate.AutoSize = true;
            this.lbRegBirthdate.Location = new System.Drawing.Point(36, 129);
            this.lbRegBirthdate.Name = "lbRegBirthdate";
            this.lbRegBirthdate.Size = new System.Drawing.Size(112, 17);
            this.lbRegBirthdate.TabIndex = 10;
            this.lbRegBirthdate.Text = "Születési dátum:";
            // 
            // lbRegEmail
            // 
            this.lbRegEmail.AutoSize = true;
            this.lbRegEmail.Location = new System.Drawing.Point(36, 161);
            this.lbRegEmail.Name = "lbRegEmail";
            this.lbRegEmail.Size = new System.Drawing.Size(46, 17);
            this.lbRegEmail.TabIndex = 11;
            this.lbRegEmail.Text = "Email:";
            // 
            // lbRegPassword
            // 
            this.lbRegPassword.AutoSize = true;
            this.lbRegPassword.Location = new System.Drawing.Point(36, 226);
            this.lbRegPassword.Name = "lbRegPassword";
            this.lbRegPassword.Size = new System.Drawing.Size(57, 17);
            this.lbRegPassword.TabIndex = 12;
            this.lbRegPassword.Text = "Jelszó:*";
            // 
            // lbRegPasswordAgain
            // 
            this.lbRegPasswordAgain.AutoSize = true;
            this.lbRegPasswordAgain.Location = new System.Drawing.Point(36, 256);
            this.lbRegPasswordAgain.Name = "lbRegPasswordAgain";
            this.lbRegPasswordAgain.Size = new System.Drawing.Size(89, 17);
            this.lbRegPasswordAgain.TabIndex = 13;
            this.lbRegPasswordAgain.Text = "Jelszó ismét:";
            // 
            // tbRegFamilyName
            // 
            this.tbRegFamilyName.Location = new System.Drawing.Point(157, 20);
            this.tbRegFamilyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegFamilyName.Name = "tbRegFamilyName";
            this.tbRegFamilyName.Size = new System.Drawing.Size(191, 22);
            this.tbRegFamilyName.TabIndex = 14;
            this.tbRegFamilyName.TextChanged += new System.EventHandler(this.tbRegFamilyName_TextChanged);
            // 
            // tbRegPassword
            // 
            this.tbRegPassword.Location = new System.Drawing.Point(157, 226);
            this.tbRegPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegPassword.Name = "tbRegPassword";
            this.tbRegPassword.PasswordChar = '*';
            this.tbRegPassword.Size = new System.Drawing.Size(200, 22);
            this.tbRegPassword.TabIndex = 16;
            this.tbRegPassword.Leave += new System.EventHandler(this.tbRegPassword_Leave);
            // 
            // tbRegPasswordAgain
            // 
            this.tbRegPasswordAgain.Location = new System.Drawing.Point(157, 256);
            this.tbRegPasswordAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegPasswordAgain.Name = "tbRegPasswordAgain";
            this.tbRegPasswordAgain.PasswordChar = '*';
            this.tbRegPasswordAgain.Size = new System.Drawing.Size(200, 22);
            this.tbRegPasswordAgain.TabIndex = 17;
            this.tbRegPasswordAgain.Leave += new System.EventHandler(this.tbRegPasswordAgain_Leave);
            // 
            // tbRegEmail1
            // 
            this.tbRegEmail1.Location = new System.Drawing.Point(157, 161);
            this.tbRegEmail1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegEmail1.Name = "tbRegEmail1";
            this.tbRegEmail1.Size = new System.Drawing.Size(100, 22);
            this.tbRegEmail1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "@";
            // 
            // tbRegEmail2
            // 
            this.tbRegEmail2.Location = new System.Drawing.Point(293, 161);
            this.tbRegEmail2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegEmail2.Name = "tbRegEmail2";
            this.tbRegEmail2.Size = new System.Drawing.Size(100, 22);
            this.tbRegEmail2.TabIndex = 20;
            // 
            // tbRegEmail3
            // 
            this.tbRegEmail3.Location = new System.Drawing.Point(419, 161);
            this.tbRegEmail3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegEmail3.Name = "tbRegEmail3";
            this.tbRegEmail3.Size = new System.Drawing.Size(41, 22);
            this.tbRegEmail3.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = ".";
            // 
            // cbRegPosition
            // 
            this.cbRegPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegPosition.FormattingEnabled = true;
            this.cbRegPosition.Location = new System.Drawing.Point(157, 95);
            this.cbRegPosition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRegPosition.Name = "cbRegPosition";
            this.cbRegPosition.Size = new System.Drawing.Size(121, 24);
            this.cbRegPosition.TabIndex = 23;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(36, 194);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(111, 17);
            this.lbUsername.TabIndex = 24;
            this.lbUsername.Text = "Felhasználónév:";
            // 
            // lbAutUsername
            // 
            this.lbAutUsername.AutoSize = true;
            this.lbAutUsername.Location = new System.Drawing.Point(157, 194);
            this.lbAutUsername.Name = "lbAutUsername";
            this.lbAutUsername.Size = new System.Drawing.Size(0, 17);
            this.lbAutUsername.TabIndex = 25;
            // 
            // tbRegFirstName
            // 
            this.tbRegFirstName.Location = new System.Drawing.Point(157, 57);
            this.tbRegFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRegFirstName.Name = "tbRegFirstName";
            this.tbRegFirstName.Size = new System.Drawing.Size(191, 22);
            this.tbRegFirstName.TabIndex = 27;
            this.tbRegFirstName.TextChanged += new System.EventHandler(this.tbRegFirstName_TextChanged);
            // 
            // lbRegFirstName
            // 
            this.lbRegFirstName.AutoSize = true;
            this.lbRegFirstName.Location = new System.Drawing.Point(36, 60);
            this.lbRegFirstName.Name = "lbRegFirstName";
            this.lbRegFirstName.Size = new System.Drawing.Size(83, 17);
            this.lbRegFirstName.TabIndex = 26;
            this.lbRegFirstName.Text = "Keresztnév:";
            // 
            // cbUserRegYear
            // 
            this.cbUserRegYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserRegYear.FormattingEnabled = true;
            this.cbUserRegYear.Location = new System.Drawing.Point(160, 129);
            this.cbUserRegYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUserRegYear.Name = "cbUserRegYear";
            this.cbUserRegYear.Size = new System.Drawing.Size(84, 24);
            this.cbUserRegYear.TabIndex = 28;
            // 
            // cbUserRegMonth
            // 
            this.cbUserRegMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserRegMonth.FormattingEnabled = true;
            this.cbUserRegMonth.Location = new System.Drawing.Point(250, 129);
            this.cbUserRegMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUserRegMonth.Name = "cbUserRegMonth";
            this.cbUserRegMonth.Size = new System.Drawing.Size(97, 24);
            this.cbUserRegMonth.TabIndex = 29;
            // 
            // cbUserRegDays
            // 
            this.cbUserRegDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserRegDays.FormattingEnabled = true;
            this.cbUserRegDays.Location = new System.Drawing.Point(354, 129);
            this.cbUserRegDays.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUserRegDays.Name = "cbUserRegDays";
            this.cbUserRegDays.Size = new System.Drawing.Size(96, 24);
            this.cbUserRegDays.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 292);
            this.label3.MaximumSize = new System.Drawing.Size(500, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 34);
            this.label3.TabIndex = 31;
            this.label3.Text = "* A jelszónak legalább 6 karakterből kell állnia, tartalmazzon legalább egy nagyb" +
    "etűt, egy kisbetűt és egy számot is";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 379);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbUserRegDays);
            this.Controls.Add(this.cbUserRegMonth);
            this.Controls.Add(this.cbUserRegYear);
            this.Controls.Add(this.tbRegFirstName);
            this.Controls.Add(this.lbRegFirstName);
            this.Controls.Add(this.lbAutUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.cbRegPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRegEmail3);
            this.Controls.Add(this.tbRegEmail2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRegEmail1);
            this.Controls.Add(this.tbRegPasswordAgain);
            this.Controls.Add(this.tbRegPassword);
            this.Controls.Add(this.tbRegFamilyName);
            this.Controls.Add(this.lbRegPasswordAgain);
            this.Controls.Add(this.lbRegPassword);
            this.Controls.Add(this.lbRegEmail);
            this.Controls.Add(this.lbRegBirthdate);
            this.Controls.Add(this.lbRegPos);
            this.Controls.Add(this.lbRegFamilyName);
            this.Controls.Add(this.bnRegSave);
            this.Controls.Add(this.bnRegCancel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registration";
            this.Text = "Regisztráció";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnRegCancel;
        private System.Windows.Forms.Button bnRegSave;
        private System.Windows.Forms.Label lbRegFamilyName;
        private System.Windows.Forms.Label lbRegPos;
        private System.Windows.Forms.Label lbRegBirthdate;
        private System.Windows.Forms.Label lbRegEmail;
        private System.Windows.Forms.Label lbRegPassword;
        private System.Windows.Forms.Label lbRegPasswordAgain;
        private System.Windows.Forms.TextBox tbRegFamilyName;
        private System.Windows.Forms.TextBox tbRegPassword;
        private System.Windows.Forms.TextBox tbRegPasswordAgain;
        private System.Windows.Forms.TextBox tbRegEmail1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRegEmail2;
        private System.Windows.Forms.TextBox tbRegEmail3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRegPosition;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbAutUsername;
        private System.Windows.Forms.TextBox tbRegFirstName;
        private System.Windows.Forms.Label lbRegFirstName;
        private System.Windows.Forms.ComboBox cbUserRegYear;
        private System.Windows.Forms.ComboBox cbUserRegMonth;
        private System.Windows.Forms.ComboBox cbUserRegDays;
        private System.Windows.Forms.Label label3;
    }
}