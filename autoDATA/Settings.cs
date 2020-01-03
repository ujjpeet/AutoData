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
        MySqlConnection con;
        String connectionstring;
        String query;

        //paraméteres konstruktor:
        public Settings(string user)
        {
            InitializeComponent();
            label2.Text = user;
        }
        
        private void Settings_Load(object sender, EventArgs e)
        {
            //FELHASZNÁLÓ BEÁLLÍTÁSOK munkakörök betöltése string ARRAY :
            string[] positions = new string[]
                { "válasszon", "adminisztrátor","újságíró", "szerkesztő", "főszerkesztő", "fotós", "vágó"};
            cbSettingsPosition.DataSource = positions;

            databaseConnect();

            //FELHASZNÁLÓ ADATAINAK BETÖLTÉSE adatbázisból:
            loaduserinfo();
        }

        //jelszó REGEX:
        private void tbSettingsNewPassword_Leave(object sender, EventArgs e)
        {
            //jelszó tartalmazzon legalább egy nagybetűt, egy kisbetűt, egy számot és legalább 6 karakter hosszúságú legyen
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{6,}$");

            string password = tbSettingsNewPassword.Text;

            if (tbSettingsNewPassword.Text != "")
            {
                if (!regex.IsMatch(password))
                {
                    tbSettingsNewPassword.Clear();
                    MessageBox.Show("A jelszónak minimum 6 karakter hosszúnak kell lennie, illetve tartalmazzon legalább egy nagybetűt és egy kisbetűt!");
                    tbSettingsNewPassword.Focus();
                }
            }
        }              

        //MÉGSE gomb esemény:
        private void bnSettingsCancel_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            this.Dispose();
        }

        //ÚJ JELSZÓ MENTÉS gomb esemény:
        private void bnSettingsSave_Click(object sender, EventArgs e)
        {         
            
            if (tbSettingsNewPassword.Text == "" || tbSettingsConfirmNewPassword.Text == "")
            {
                MessageBox.Show("Töltse ki a jelszó mezőket!");
            }
            else if (tbSettingsNewPassword.Text != tbSettingsConfirmNewPassword.Text)
            {
                MessageBox.Show("A jelszavak nem azonosak!");
                tbSettingsNewPassword.Clear();
                tbSettingsConfirmNewPassword.Clear();
                tbSettingsNewPassword.Focus();
            }
            else
            {
                DialogResult dr = new DialogResult();
                Confirm a = new Confirm("Biztosan szeretné módosítani a jelszavát?");
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

        private void loaduserinfo()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                query = "SELECT * FROM users WHERE username = '" + label2.Text + "'";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader read = cmd.ExecuteReader();

                if (read.Read())
                {
                    tbSettingsFamilyName.Text = (read["last_name"].ToString());
                    tbSettingsFirstName.Text = (read["first_name"].ToString());
                    cbSettingsPosition.Text = (read["position"].ToString());
                    dtpSettings.Value = Convert.ToDateTime(read["birthdate"].ToString());
                    tbSettingsEmail.Text = (read["email"].ToString());
                }
                else
                {
                    MessageBox.Show("Hiba történt!");
                }
                read.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };           
        }

        private void bnSaveSet_Click(object sender, EventArgs e)
        {
            string email = tbSettingsEmail.Text;
            Regex regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");

            if (tbSettingsFamilyName.Text == ""
                || tbSettingsFirstName.Text == ""               
                || cbSettingsPosition.Text == "válasszon"
                || dtpSettings.Value == DateTime.Now
                || tbSettingsEmail.Text == ""
                )
            {
                MessageBox.Show("Minden mező kitöltése kötelező!");
            }
            else if (!regex.IsMatch(email))
            {
                MessageBox.Show("Email cím nem megfelelő");
            }
            else
            {
                string updatequery = "UPDATE users SET last_name = '" + tbSettingsFamilyName.Text + "', first_name = '" + tbSettingsFirstName.Text + "', position = '" + cbSettingsPosition.Text + "', birthdate = '" + dtpSettings.Value.ToString("yyyy/MM/dd") + "', email = '" + tbSettingsEmail.Text + "' WHERE username = '" + label2.Text + "'";
               
                DialogResult dr = new DialogResult();
                Confirm a = new Confirm("Biztosan módosítani szeretné az adatait?");
                dr = a.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        MySqlCommand insert = new MySqlCommand(updatequery, con);
                        if (insert.ExecuteNonQuery() == 1)
                        {
                            loaduserinfo();
                            MessageBox.Show("Adatok sikeresen módosítva");
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Adatok módosítása sikertelen");
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
