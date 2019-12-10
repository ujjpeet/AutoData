using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoDATA
{
    public partial class Registration : Form
    {
        public static int register;

        public Registration()
        {
            InitializeComponent();
        }


        //MÉGSE GOMB click esemény:
        private void bnRegCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        //USERNAME mező kitöltése automatikusan:
        private void tbRegFamilyName_TextChanged(object sender, EventArgs e)
        {
            string toreplace1 = tbRegFirstName.Text.ToLower();
            string toreplace2 = tbRegFamilyName.Text.ToLower();

            string result1 = RemoveSpecialCharacters(toreplace1);
            string result2 = RemoveSpecialCharacters(toreplace2);

            lbAutUsername.Text = result1 + "." + result2;
        }

        private void tbRegFirstName_TextChanged(object sender, EventArgs e)
        {
            string toreplace1 = tbRegFirstName.Text.ToLower();
            string toreplace2 = tbRegFamilyName.Text.ToLower();

            string result1 = RemoveSpecialCharacters(toreplace1);
            string result2 = RemoveSpecialCharacters(toreplace2);

            lbAutUsername.Text = result1 + "." + result2;
        }

        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }

        //beírt JELSZAVAKNAK meg kell egyezniük (textbox leave esemény):
        private void tbRegPasswordAgain_Leave(object sender, EventArgs e)
        {
            if (tbRegPassword.Text != tbRegPasswordAgain.Text)
            {
                MessageBox.Show("A jelszavak nem azonosak!");
                tbRegPassword.Clear();
                tbRegPasswordAgain.Clear();
                tbRegPassword.Focus(); //kruzor oda
            }
        }

        //REGISZTRÁCIÓ GOMB click esemény:
        private void bnRegSave_Click(object sender, EventArgs e)
        {

            if (tbRegFirstName.Text == "" || tbRegFamilyName.Text == "" || cbRegPosition.Text == "" || dtRegBirthdate.Text == ""
            || tbRegEmail1.Text == "" || tbRegEmail2.Text == "" || tbRegEmail3.Text == "" || tbRegPassword.Text == ""
            || tbRegPasswordAgain.Text == "")
            {
                MessageBox.Show("Minden mezőt kötelező kitölteni!");
            }
            else
            {
                DialogResult dr = new DialogResult();
                Confirm a = new Confirm();
                dr = a.ShowDialog();
                if (dr == DialogResult.Yes)
                {
                    FileStream fs = new FileStream("temp.txt", FileMode.Create, FileAccess.Write, FileShare.None);
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    sw.WriteLine(lbAutUsername.Text);
                    sw.WriteLine(encryption.SHA2Hash(tbRegPassword.Text));
                    sw.WriteLine(encryption.SHA5Hash(tbRegPassword.Text));
                    sw.WriteLine(encryption.MD5Hash(tbRegPassword.Text));
                    sw.Close();
                    fs.Close();

                    reguser();
                }
                else
                {
                    a.Close();
                }

            }
            
        }

        //USER REGISZTRÁCIÓ metódus:
        private void reguser()
        {
            MySqlConnection con;
            String connectionstring;
            String insertQuery, insertUser;

            try
            {
                connectionstring = "datasource = localhost;  DataBase= auto_data1; username = root; password =";

                insertQuery = "INSERT INTO users (last_name, first_name, position, birthdate, email, username, password)  " +
                    "VALUES(" +
                    "'" + tbRegFamilyName.Text + "','" + tbRegFirstName.Text + "','" + cbRegPosition.Text + "','" + dtRegBirthdate.Text + "'," +
                    "CONCAT('" + tbRegEmail1.Text + "','@','" + tbRegEmail2.Text + "','.','" + tbRegEmail3.Text + "')," +
                    "'" + lbAutUsername.Text + "','" + encryption.SHA2Hash(tbRegPassword.Text) + "','" + encryption.SHA5Hash(tbRegPassword.Text) + "', '" + encryption.MD5Hash(tbRegPassword.Text) + "')";

                insertUser = "CREATE user \'" + lbAutUsername.Text + "\'@\'% \'" + "IDENTIFIED VIA mysql_native_password USING \'" + encryption.MD5Hash(tbRegPassword.Text) + "\'; GRANT ALL PRIVILEGES ON auto_data1.* TO \'" + lbAutUsername.Text + "\'@\'% \'" + ";Flush Privileges";

                con = new MySqlConnection(connectionstring);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                MySqlCommand regdata = new MySqlCommand(insertQuery, con);
                if (regdata.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Adatok rögzítve!");

                }
                else
                {
                    MessageBox.Show("Az adatok rögzítése sikertelen!");

                }
                MySqlCommand createuser = new MySqlCommand(insertUser, con);

                if (createuser.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("A felhasználó létrehozva!");
                }
                else
                {
                    MessageBox.Show("A felhasználót nem lehet létrehozni!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
