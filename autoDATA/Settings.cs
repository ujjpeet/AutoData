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
    public partial class Settings : Form
    {
       //paraméteres konstruktor:
        public Settings(string user)
        {
            InitializeComponent();
            label2.Text = user;
        }

        //jelszó REGEX:
        private void tbSettingsNewPassword_Leave(object sender, EventArgs e)
        {
            //jelszó tartalmazzon legalább egy nagybetűt, egy kisbetűt, egy számot és legalább 6 karakter hosszúságú legyen
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{6,}$");

            string password = tbSettingsNewPassword.Text;

            if (!regex.IsMatch(password))
            {
                tbSettingsNewPassword.Clear();
                MessageBox.Show("A jelszónak minimum 6 karakter hosszúnak kell lennie, illetve tartalmazzon legalább egy nagybetűt és egy kisbetűt!");
                tbSettingsNewPassword.Focus();
            }
        }

        //beírt jelszavaknak azonosnak kell lenniük:
        private void tbSettingsConfirmNewPassword_Leave(object sender, EventArgs e)
        {
            if (tbSettingsNewPassword.Text != tbSettingsConfirmNewPassword.Text)
            {
                MessageBox.Show("A jelszavak nem azonosak!");
                tbSettingsNewPassword.Clear();
                tbSettingsConfirmNewPassword.Clear();
                tbSettingsNewPassword.Focus();
            }
        }

        //MÉGSE gomb esemény:
        private void bnSettingsCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //MENTÉS gomb esemény:
        private void bnSettingsSave_Click(object sender, EventArgs e)
        {
            MySqlConnection con;
            String connectionstring;
            String query;

            if (tbSettingsNewPassword.Text != tbSettingsConfirmNewPassword.Text)
            {
                MessageBox.Show("A jelszavak nem azonosak!");
                tbSettingsNewPassword.Clear();
                tbSettingsConfirmNewPassword.Clear();
                tbSettingsNewPassword.Focus();
            }
            else
            {
                DialogResult dr = new DialogResult();
                Confirm a = new Confirm("Biztosan módosítani szeretné a jelszavát?");
                dr = a.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        //connectionstring = "datasource = localhost;  DataBase= auto_data; username = root; password =";

                        connectionstring = "datasource = 94.76.215.115; DataBase = petersze_autodata; username = petersze_petersze; password = Rmbg5780Ar; charset = utf8";

                        con = new MySqlConnection(connectionstring);
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        query = "UPDATE users SET password = '" + encryption.SHA2Hash(tbSettingsNewPassword.Text) + "' WHERE username = '" + label2.Text + "'";

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
    }
}
