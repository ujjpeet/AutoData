using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace autoDATA
{
    public partial class ErrorReport : Form
    {
        public ErrorReport(string user)
        {
            InitializeComponent();
            label2.Text = user;
        }

        //HIBABEJELENTÉS gomb kattintás:
        private void bnSendErrorReport_Click(object sender, EventArgs e)
        {
            if (tbErrorReport.Text == "")
            {
                MessageBox.Show("Írja le a hibát!");
            }
            else
            {
                try
                {
                    emailSend();
                    MessageBox.Show("Hiba bejelentve.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hibabejelentés sikertelen. \n" + ex.Message);
                }
            }
        }

        //HIBABEJELENTÉS email küldés metódus:
        private void emailSend()
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Timeout = 20000;

            mail.From = new MailAddress("csharptest.peter@gmail.com");
            mail.To.Add("ujjpetertamas@gmail.com");
            mail.Subject = "Hibabejelentés, felhasználó: " +label2.Text ;
            mail.Body = tbErrorReport.Text;

            /*
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            mail.Attachments.Add(attachment);
            */

            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("csharptest.peter@gmail.com", "Lol0ka01");
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }
    }
}
