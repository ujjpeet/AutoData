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
        MySqlConnection con;
        String connectionstring;
        String insertQuery;

        public Registration()
        {
            InitializeComponent();
        }

        //form LOAD esemény:
        private void Registration_Load(object sender, EventArgs e)
        {
            //FELHASZNÁLÓ REGISZTRÁCIÓ munkakörök betöltése string ARRAY :
            string[] positions = new string[]
                { "válasszon", "adminisztrátor","újságíró", "szerkesztő", "főszerkesztő", "fotós", "vágó"};
            cbRegPosition.DataSource = positions;

            //FELHASZNÁLÓ REGISZTRÁCIÓ születési dátumok:
            string[] years = new string[]
                {                    
                    "1940","1941","1942","1943","1944","1945","1946","1947","1948","1949",
                    "1950","1951","1952","1953","1954","1955","1956","1957","1958","1959",
                    "1960","1961","1962","1963","1964","1965","1966","1967","1968","1969",
                    "1970","1971","1972","1973","1974","1975","1976","1977","1978","1979",
                    "1980","1981","1982","1983","1984","1985","1986","1987","1988","1989",
                    "1990","1991","1992","1993","1994","1995","1996","1997","1998","1999",
                    "2000","2001","2002","2003","2004","2005","2006","2007","2008","2009","válasszon"
                };
            Array.Reverse(years);
            cbUserRegYear.DataSource = years;

            string[] month = new string[]                {"válasszon","01","02","03","04","05","06","07","08","09","10","11","12"};
            cbUserRegMonth.DataSource = month;

            string[] days = new string[]               {"válasszon","01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31"};
            cbUserRegDays.DataSource = days;
       }

        //MÉGSE GOMB click esemény:
        private void bnRegCancel_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            this.Close();
        }

        //FELHASZNÁLÓNÉV mező kitöltése automatikusan:

        //metódus ami átalakítja a speciális karaktereket:
        public static string RemoveAccents(string source)
        {
            //8 bit characters 
            byte[] b = Encoding.GetEncoding(1251).GetBytes(source);

            string t = Encoding.ASCII.GetString(b);
            Regex re = new Regex("[^a-zA-Z0-9]=-_/");
            string c = re.Replace(t, " ");
            return c;
        }

        private void tbRegFamilyName_TextChanged(object sender, EventArgs e)
        {
            string toreplace1 = tbRegFirstName.Text.ToLower();
            string toreplace2 = tbRegFamilyName.Text.ToLower();

            string result1 = RemoveAccents(toreplace1);
            string result2 = RemoveAccents(toreplace2);           

            lbAutUsername.Text = result1 + "." + result2;
        }

        private void tbRegFirstName_TextChanged(object sender, EventArgs e)
        {
            string toreplace1 = tbRegFirstName.Text.ToLower();
            string toreplace2 = tbRegFamilyName.Text.ToLower();

            string result1 = RemoveAccents(toreplace1);
            string result2 = RemoveAccents(toreplace2);

            lbAutUsername.Text = result1 + "." + result2;
        }

        //jelszó REGEX:
        private void tbRegPassword_Leave(object sender, EventArgs e)
        {
            //jelszó tartalmazzon legalább egy nagybetűt, egy kisbetűt, egy számot és legalább 6 karakter hosszúságú legyen
            Regex regex = new Regex(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{6,}$");

            string password = tbRegPassword.Text;

            if (tbRegPassword.Text != "")
            {
                if (!regex.IsMatch(password))
                {
                    tbRegPassword.Clear();
                    MessageBox.Show("A jelszónak minimum 6 karakter hosszúnak kell lennie, illetve tartalmazzon legalább egy nagybetűt és egy kisbetűt!");
                    tbRegPassword.Focus();
                }
            }
        }

        //beírt JELSZAVAKNAK meg kell egyezniük (textbox leave esemény):
        private void tbRegPasswordAgain_Leave(object sender, EventArgs e)
        {
            if (tbRegPassword.Text != tbRegPasswordAgain.Text)
            {
                MessageBox.Show("A jelszavak nem azonosak!");
                tbRegPassword.Clear();
                tbRegPasswordAgain.Clear();
                tbRegPassword.Focus();
            }
        }

        //REGISZTRÁCIÓ GOMB click esemény:
        private void bnRegSave_Click(object sender, EventArgs e)
        {
           if (tbRegFirstName.Text == "" || tbRegFamilyName.Text == "" || cbRegPosition.Text == ""
                ||cbRegPosition.Text == "válasszon"
                || cbUserRegYear.Text == "válasszon"
                || cbUserRegMonth.Text == "válasszon"
                || cbUserRegDays.Text == "válasszon"
                || tbRegEmail1.Text == "" || tbRegEmail2.Text == "" || tbRegEmail3.Text == ""
                || tbRegPassword.Text == ""
                || tbRegPasswordAgain.Text == "")
            {
                MessageBox.Show("Minden mezőt kötelező kitölteni!");
            }
            else
            {
                reguser();
            }
        }            

        //USER REGISZTRÁCIÓ metódus:
        private void reguser()
        {
            try
            {
                databaseconnect();

                insertQuery = "INSERT INTO users (last_name, first_name, position, birthdate, email, username, password)  " +
                    "VALUES(" +
                    "'" + tbRegFamilyName.Text + "','" + tbRegFirstName.Text + "','" + cbRegPosition.Text + "',CONCAT('" + cbUserRegYear.Text + "',' ', '" + cbUserRegMonth.Text + "',' ','" + cbUserRegDays.Text + "'), CONCAT('" + tbRegEmail1.Text + "','@','" + tbRegEmail2.Text + "','.','" + tbRegEmail3.Text + "'),'" + lbAutUsername.Text + "','" + encryption.SHA2Hash(tbRegPassword.Text) + "')";    
              
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                MySqlCommand regdata = new MySqlCommand(insertQuery, con);
                if (regdata.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Regisztráció sikeres! Be tud jelentkezni! \nFelhasználónév: " + lbAutUsername.Text + " \nJelszó: " + tbRegPassword.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A regiszráció sikertelen!");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void databaseconnect()
        {
            try
            {
                //connectionstring = "datasource = localhost;  DataBase= auto_data; username = root; password =";

                connectionstring = "datasource = 94.76.215.115; DataBase = petersze_autodata; username = petersze_petersze; password = Rmbg5780Ar; charset = utf8";
                con = new MySqlConnection(connectionstring);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
