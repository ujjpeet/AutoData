namespace autoDATA
{
    partial class ErrorReport
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
            this.bnSendErrorReport = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.tbErrorReport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnSendErrorReport
            // 
            this.bnSendErrorReport.Location = new System.Drawing.Point(83, 280);
            this.bnSendErrorReport.Name = "bnSendErrorReport";
            this.bnSendErrorReport.Size = new System.Drawing.Size(96, 36);
            this.bnSendErrorReport.TabIndex = 0;
            this.bnSendErrorReport.Text = "Bejelentés";
            this.bnSendErrorReport.UseVisualStyleBackColor = true;
            this.bnSendErrorReport.Click += new System.EventHandler(this.bnSendErrorReport_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.Location = new System.Drawing.Point(209, 280);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 36);
            this.bnCancel.TabIndex = 1;
            this.bnCancel.Text = "Mégse";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // tbErrorReport
            // 
            this.tbErrorReport.Location = new System.Drawing.Point(12, 97);
            this.tbErrorReport.Multiline = true;
            this.tbErrorReport.Name = "tbErrorReport";
            this.tbErrorReport.Size = new System.Drawing.Size(350, 161);
            this.tbErrorReport.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Írja le a tapasztalt hibát:";
            // 
            // ErrorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 342);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbErrorReport);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.bnSendErrorReport);
            this.Name = "ErrorReport";
            this.Text = "Hibabejelentés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnSendErrorReport;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.TextBox tbErrorReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}