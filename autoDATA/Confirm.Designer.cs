namespace autoDATA
{
    partial class Confirm
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
            this.lbConfirmQuestion = new System.Windows.Forms.Label();
            this.bnConfirmYes = new System.Windows.Forms.Button();
            this.bnConfirmNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConfirmQuestion
            // 
            this.lbConfirmQuestion.AutoSize = true;
            this.lbConfirmQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbConfirmQuestion.Location = new System.Drawing.Point(34, 25);
            this.lbConfirmQuestion.Name = "lbConfirmQuestion";
            this.lbConfirmQuestion.Size = new System.Drawing.Size(271, 24);
            this.lbConfirmQuestion.TabIndex = 0;
            this.lbConfirmQuestion.Text = "Biztos, hogy folytatni akarja?";
            // 
            // bnConfirmYes
            // 
            this.bnConfirmYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bnConfirmYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bnConfirmYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnConfirmYes.Location = new System.Drawing.Point(77, 78);
            this.bnConfirmYes.Name = "bnConfirmYes";
            this.bnConfirmYes.Size = new System.Drawing.Size(87, 35);
            this.bnConfirmYes.TabIndex = 2;
            this.bnConfirmYes.Text = "Igen";
            this.bnConfirmYes.UseVisualStyleBackColor = false;
            // 
            // bnConfirmNo
            // 
            this.bnConfirmNo.BackColor = System.Drawing.Color.Red;
            this.bnConfirmNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.bnConfirmNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bnConfirmNo.Location = new System.Drawing.Point(180, 78);
            this.bnConfirmNo.Name = "bnConfirmNo";
            this.bnConfirmNo.Size = new System.Drawing.Size(87, 35);
            this.bnConfirmNo.TabIndex = 5;
            this.bnConfirmNo.Text = "Nem";
            this.bnConfirmNo.UseVisualStyleBackColor = false;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 147);
            this.ControlBox = false;
            this.Controls.Add(this.bnConfirmNo);
            this.Controls.Add(this.bnConfirmYes);
            this.Controls.Add(this.lbConfirmQuestion);
            this.Name = "Confirm";
            this.Text = "Megerősítés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConfirmQuestion;
        private System.Windows.Forms.Button bnConfirmYes;
        private System.Windows.Forms.Button bnConfirmNo;
    }
}