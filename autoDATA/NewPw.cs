using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoDATA
{
    public partial class NewPw : Form
    {
        MySqlConnection con;
        String connectionstring;
        String query;

        public NewPw(string user)
        {
            InitializeComponent();
            label1.Text = user;
        }

        private void NewPw_Load(object sender, EventArgs e)
        {
            databaseConnect();
        }

        private void databaseConnect()
        {
            try
            {
                //connectionstring = "datasource = localhost;  DataBase= auto_data; username = root; password =";

                connectionstring = "datasource = 94.76.215.115; DataBase = petersze_autodata; username = petersze_petersze; password = Rmbg5780Ar; charset = utf8";
                con = new MySqlConnection(connectionstring);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void tbAdminGiveNewPassword_Leave(object sender, EventArgs e)
        {
            //jelszó tartalmazzon legalább egy nagybetűt, egy kisbetűt, egy számot és legalább 6 karakter hosszúságú legyen
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{6,}$");

            string password = tbAdminGiveNewPassword.Text;

            if (tbAdminGiveNewPassword.Text != "")
            {
                if (!regex.IsMatch(password))
                {
                    tbAdminGiveNewPassword.Clear();
                    MessageBox.Show("A jelszónak minimum 6 karakter hosszúnak kell lennie, illetve tartalmazzon legalább egy nagybetűt és egy kisbetűt!");
                    tbAdminGiveNewPassword.Focus();
                }
            }
        }

        private void bnAdminNewPwSave_Click(object sender, EventArgs e)
        {
            if (tbAdminGiveNewPassword.Text == "" || tbAdminConfirmNewPassword.Text == "")
            {
                MessageBox.Show("Töltse ki a jelszó mezőket!");
            }
            else if (tbAdminGiveNewPassword.Text != tbAdminConfirmNewPassword.Text)
            {
                MessageBox.Show("A jelszavak nem azonosak!");
                tbAdminGiveNewPassword.Clear();
                tbAdminConfirmNewPassword.Clear();
                tbAdminGiveNewPassword.Focus();
            }
            else
            {
                DialogResult dr = new DialogResult();
                Confirm a = new Confirm("Biztosan szeretné módosítani a " + label1.Text + " nevű felhasználó jelszavát?");
                dr = a.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        databaseConnect();

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        query = "UPDATE users SET password = '" + encryption.SHA2Hash(tbAdminGiveNewPassword.Text) + "' WHERE username = '" + label1.Text + "'";

                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        MySqlCommand insert = new MySqlCommand(query, con);
                        if (insert.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Jelszó módosítva");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Jelszó módosítása sikertelen");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (dr == DialogResult.No)
                {
                    a.Dispose();
                }
            }
        }

        private void bnAdminNewPwCancel_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            this.Dispose();
        }
    }
}
