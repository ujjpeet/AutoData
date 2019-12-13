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
            checkuser();
        }

        private void checkuser()
        {
            MySqlConnection con;
            String connectionstring;
            String query;

            try
            {
                connectionstring = "datasource = localhost;  DataBase= auto_data; username = root; password =";

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
                    --attempt;
                    MessageBox.Show("Sikertelen belépési kísérlet! " + "\nMaradék kísérletek száma: " + attempt);
                    this.DialogResult = DialogResult.No;
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ELFELEJTETT JELSZÓ kattintás:
        private void lbForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Küldjön egy emailt az ujjpetertamas@gmail.com emailcímre!");
        }
    }
}
