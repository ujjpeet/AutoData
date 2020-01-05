using MySql.Data.MySqlClient;
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
    
    public partial class Login : Form
    {
        static int attempt = 3;        

        public Login()
        {
            InitializeComponent();
        }

        //MÉGSE gomb esemény:
        private void bnLoginCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //REGISZTRÁCIÓ gomb esemény:
        private void lbReg_Click(object sender, EventArgs e)
        {
            Registration myreg = new Registration();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Regisztráció")
                {
                    IsOpen = true;
                    myreg.BringToFront();
                    myreg.Activate();
                }
            }
            if (IsOpen == false)
            {
                myreg = new Registration();

                myreg.Show();
                myreg.BringToFront();
                myreg.Activate();
            }
        }

        //BELÉPÉS gomb esemény:
        private void bnLoginOK_Click(object sender, EventArgs e)
        {
            if (attempt == 0)
            {
                MessageBox.Show("Belépési kísérletek száma elfogyott, lépjen kapcsolatba az adminisztrátorral");
                Application.Exit();
            }
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Felhasználónév és jelszó mezők kitöltése kötelező!");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                checkuser();
            }
        }

        private void checkuser()
        {
            MySqlConnection con;
            String connectionstring;
            String query;

            try
            {
                //connectionstring = "datasource = localhost;  DataBase= auto_data; username = root; password =";
                             
                connectionstring = "datasource = 94.76.215.115; DataBase = petersze_autodata; username = petersze_petersze; password = Rmbg5780Ar; charset = utf8";

                con = new MySqlConnection(connectionstring);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                query = "SELECT username, password FROM users WHERE username = '"+tbUsername.Text+"' AND password = '"+ encryption.SHA2Hash(tbPassword.Text) + "'";

                DataTable mytable = new DataTable();
                MySqlCommand search = new MySqlCommand(query, con);
                MySqlDataReader open = search.ExecuteReader();
                mytable.Load(open);
                if (mytable.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    attempt--;
                    MessageBox.Show("Sikertelen belépési kísérlet! " + "\nMaradék kísérletek száma: " + attempt);
                    this.DialogResult = DialogResult.Cancel;                   
                }  
            }
            catch (Exception ex)
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show(ex.Message);
            }
        }

        //ELFELEJTETT JELSZÓ gomb kattintás:
        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "")
            {
                MessageBox.Show("Először írja be a felhasználónevét!");
            }
            else
            {
                try
                {
                    emailSend();
                    MessageBox.Show("Adminisztrátor értesítve. \nHamarosan megkapja új jelszavát.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //ELFELEJTETT JELSZÓ email küldés metódus:
        private void emailSend()
        {
            MailMessage mail = new MailMessage();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Timeout = 20000;

            mail.From = new MailAddress("csharptest.peter@gmail.com");
            mail.To.Add("ujjpetertamas@gmail.com");
            mail.Subject = "Elfelejtett jelszó";
            mail.Body = "Felhasználó: "+ tbUsername.Text + " elfelejtette a jelszavát";

            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("csharptest.peter@gmail.com", "Lol0ka01");
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }
    }
}
