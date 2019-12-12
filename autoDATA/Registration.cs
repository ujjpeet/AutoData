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

            string[] month = new string[]                {"válasszon","január","február","március","április","május","június","július","augusztus","szeptember","október","november","december"};
            cbUserRegMonth.DataSource = month;

            string[] days = new string[]               {"válasszon","01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31" };
            cbUserRegDays.DataSource = days;
       }

        //MÉGSE GOMB click esemény:
        private void bnRegCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        //FELHASZNÁLÓNÉV mező kitöltése automatikusan:
        private void tbRegFamilyName_TextChanged(object sender, EventArgs e)
        {
            string toreplace1 = tbRegFirstName.Text.ToLower();
            string toreplace2 = tbRegFamilyName.Text.ToLower();

            string result1 = RemoveSpecialCharacters(toreplace1);
            string result2 = RemoveSpecialCharacters(toreplace2);

            lbAutUsername.Text = result1 + result2;
        }

        private void tbRegFirstName_TextChanged(object sender, EventArgs e)
        {
            string toreplace1 = tbRegFirstName.Text.ToLower();
            string toreplace2 = tbRegFamilyName.Text.ToLower();

            string result1 = RemoveSpecialCharacters(toreplace1);
            string result2 = RemoveSpecialCharacters(toreplace2);

            lbAutUsername.Text = result1 + result2;
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
           if (tbRegFirstName.Text == "" || tbRegFamilyName.Text == "" || cbRegPosition.Text == ""
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
            MySqlConnection con;
            String connectionstring;
            String insertQuery;

            try
            {
                connectionstring = "datasource = localhost;  DataBase= auto_data; username = root; password =";

                insertQuery = "INSERT INTO users (last_name, first_name, position, birthdate, email, username, password)  " +
                    "VALUES(" +
                    "'" + tbRegFamilyName.Text + "','" + tbRegFirstName.Text + "','" + cbRegPosition.Text + "',CONCAT('" + cbUserRegYear.Text + "',' ', '" + cbUserRegMonth.Text + "',' ','" + cbUserRegDays.Text + "'), CONCAT('" + tbRegEmail1.Text + "','@','" + tbRegEmail2.Text + "','.','" + tbRegEmail3.Text + "'),'" + lbAutUsername.Text + "','" + encryption.SHA2Hash(tbRegPassword.Text) + "')";                                        

                con = new MySqlConnection(connectionstring);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                MySqlCommand regdata = new MySqlCommand(insertQuery, con);
                if (regdata.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Felhasználó rögzítve!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Felhasználó rögzítése sikertelen!");
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
