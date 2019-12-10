﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoDATA
{
    public partial class Admin : Form
    {
        String connectionstring;
        MySqlConnection con;
        public string query = "";

        public Admin()
        {
            InitializeComponent();
        }

        //Form LOAD esemény:
        private void Admin_Load(object sender, EventArgs e)
        {
            databaseConnect();
            loadCarCategoriesForAdmin();
            loadCarMakesForAdminSearch();
            loadCarMakesForAdmin();

            //string ARRAY:
            //üzemanyagok:
            string[] fuels = new string[] { "válasszon", "benzin", "dízel", "LPG", "CNG", "hibrid", "elektromos", "üzemanyagcella" };
            cbAdminCarsFuel.DataSource = fuels;

            //lökettérfogat:
            string[] disparray = new string[] {
                "válasszon","0,1","0,2","0,3","0,4","0,5","0,6","0,7","0,8","0,9",
                "1,0","1,1","1,2","1,3","1,4","1,5","1,6","1,7","1,8","1,9",
                "2,0","2,1","2,2","2,3","2,4","2,5","2,6","2,7","2,8","2,9",
                "3,0","3,1","3,2","3,3","3,4","3,5","3,6","3,7","3,8","3,9",
                "4,0","4,1","4,2","4,3","4,4","4,5","4,6","4,7","4,8","4,9",
                "5,0","5,1","5,2","5,3","5,4","5,5","5,6","5,7","5,8","5,9",
                "6,0","6,1","6,2","6,3","6,4","6,5","6,6","6,7","6,8","6,9",
                "7,0","7,1","7,2","7,3","7,4","7,5","7,6","7,7","7,8","7,9",
                "8,0","n/a"
            };
            cbAdminCarsDisp.DataSource = disparray;

            //gyártási évek:
            string[] prodyearsarray = new string[] {
                "1900","1901","1902","1903","1904","1905","1906","1907","1908","1909","1910",
                "1911","1912","1913","1914","1915","1916","1917","1918","1919","1920",
                "1921","1922","1923","1924","1925","1926","1927","1928","1929","1930",
                "1931","1932","1933","1934","1935","1936","1937","1938","1939","1940",
                "1941","1942","1943","1944","1945","1946","1947","1948","1949","1950",
                "1951","1952","1953","1954","1955","1956","1957","1958","1959","1960",
                "1961","1962","1963","1964","1965","1966","1967","1968","1969","1970",
                "1971","1972","1973","1974","1975","1976","1977","1978","1979","1980",
                "1981","1982","1983","1984","1985","1986","1987","1988","1989","1990",
                "1991","1992","1993","1994","1995","1996","1997","1998","1999","2000",
                "2001","2002","2003","2004","2005","2006","2007","2008","2009","2010",
                "2011","2012","2013","2014","2015","2016","2017","2018","2019","2020",
                "válasszon"
            };
            Array.Reverse(prodyearsarray);
            cbAdminCarsProdStart.DataSource = prodyearsarray;

            string[] prodyearsarray2 = new string[] {
               "1900","1901","1902","1903","1904","1905","1906","1907","1908","1909","1910",
                "1911","1912","1913","1914","1915","1916","1917","1918","1919","1920",
                "1921","1922","1923","1924","1925","1926","1927","1928","1929","1930",
                "1931","1932","1933","1934","1935","1936","1937","1938","1939","1940",
                "1941","1942","1943","1944","1945","1946","1947","1948","1949","1950",
                "1951","1952","1953","1954","1955","1956","1957","1958","1959","1960",
                "1961","1962","1963","1964","1965","1966","1967","1968","1969","1970",
                "1971","1972","1973","1974","1975","1976","1977","1978","1979","1980",
                "1981","1982","1983","1984","1985","1986","1987","1988","1989","1990",
                "1991","1992","1993","1994","1995","1996","1997","1998","1999","2000",
                "2001","2002","2003","2004","2005","2006","2007","2008","2009","2010",
                "2011","2012","2013","2014","2015","2016","2017","2018","2019","2020",
                "még gyártásban", "válasszon"
            };
            Array.Reverse(prodyearsarray);
            cbAdminCarsProdEnd.DataSource = prodyearsarray2;

            //hengerszám betöltése:
            string[] cylinderarray = new string[] { "válasszon", "nincs", "1", "2", "3", "4", "5", "6", "8", "10", "12", "16" };
            cbAdminCarsCyl.DataSource = cylinderarray;

            //string LIST:
            //karosszériatípusok betöltése:
            List<string> bodylist = new List<string>();
            bodylist.Add("válasszon");
            bodylist.Add("ferdehátú");
            bodylist.Add("szedán");
            bodylist.Add("kombi");
            bodylist.Add("kabrió");
            bodylist.Add("kupé");
            bodylist.Add("egyterű");
            bodylist.Add("busz");
            bodylist.Add("pickup");
            bodylist.Add("terepjáró");
            cbAdminCarsBody.DataSource = bodylist;

        }

        //VÁLTÓFAJTÁK betöltése ADATBÁZISBÓL:
        private void loadGerarbox()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            query = "SELECT * FROM gears";

            try
            {
                DataTable mytable = new DataTable();
                MySqlCommand search = new MySqlCommand(query, con);
                MySqlDataReader open = search.ExecuteReader();
                mytable.Load(open);
                cbAdminCarsGearbox.DisplayMember = "gear_type";
                cbAdminCarsGearbox.DataSource = mytable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        //MYSQL adatbázis kapcsolat metódus:
        private void databaseConnect()
        {
            try
            {
                connectionstring = "datasource = localhost; DataBase = auto_data; username = root; password = ";
                con = new MySqlConnection(connectionstring);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    lbAdminConnection.Text = "Kapcsolódva";
                    lbAdminConnection.ForeColor = Color.Green;
                }
                else
                {
                    lbAdminConnection.Text = "Nincs kapcsolat";
                    lbAdminConnection.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        //AUTÓKATEGÓRIÁK betöltése ADATBÁZISBÓL:      
        public void loadCarCategoriesForAdmin()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            query = "SELECT * FROM carcategories";

            try
            {
                DataTable mytable = new DataTable();
                MySqlCommand search = new MySqlCommand(query, con);
                MySqlDataReader open = search.ExecuteReader();
                mytable.Load(open);
                cbAdminCarsCategory.DisplayMember = "categories";
                cbAdminCarsCategory.DataSource = mytable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        //AUTÓMÁRKÁK betöltése TXT FÁJLBÓL:
        private void loadCarMakesForAdminSearch()
        {
            FileStream fs = new FileStream("carmakes.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            List<string> carmakes = new List<string>();

            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    carmakes.Add(sr.ReadLine());
                }
            }

            sr.Close();
            fs.Close();

            cbAdminCarsMakeSearch.DataSource = carmakes;
        }

        private void loadCarMakesForAdmin()
        {
            FileStream fs = new FileStream("carmakes.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            List<string> carmakes = new List<string>();

            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    carmakes.Add(sr.ReadLine());
                }
            }

            sr.Close();
            fs.Close();

            cbAdminCarsMake.DataSource = carmakes;
        }

        //AUTÓMODELLEK betöltése PARAMÉTERREL TXT FÁJLBÓL:
        private void loadCarmodelsforAdmin(string path)
        {
            List<string> carmodels = new List<string>();

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    carmodels.Add(sr.ReadLine());
                }
            }

            cbAdminCarsModel.DataSource = carmodels;

            sr.Close();
            fs.Close();
        }

        private void loadCarmodelsforAdminSearch(string path)
        {
            List<string> carmodels = new List<string>();

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            using (sr)
            {
                while (!sr.EndOfStream)
                {
                    carmodels.Add(sr.ReadLine());
                }
            }

            cbAdminCarsModelSearch.DataSource = carmodels;

            sr.Close();
            fs.Close();
        }

        //Ha a KERESŐBEN ki lett választva egy MÁRKA:
        private void cbAdminCarsMakeSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cbAdminCarsMakeSearch.Text)
            {
                case "Alfa Romeo":
                    loadCarmodelsforAdminSearch("alfamodels.txt");
                    break;
                case "Alpina":
                    loadCarmodelsforAdminSearch("alpinamodels.txt");
                    break;
                case "Aston Martin":
                    loadCarmodelsforAdminSearch("astonmodels.txt");
                    break;
                case "Bentley":
                    loadCarmodelsforAdminSearch("bentleymodels.txt");
                    break;
                case "Audi":
                    loadCarmodelsforAdminSearch("audimodels.txt");
                    break;
                case "BMW":
                    loadCarmodelsforAdminSearch("bmwmodels.txt");
                    break;
                case "Citroen":
                    loadCarmodelsforAdminSearch("citroenmodels.txt");
                    break;
                case "Dacia":
                    loadCarmodelsforAdminSearch("daciamodels.txt");
                    break;
                case "Ferrari":
                    loadCarmodelsforAdminSearch("ferrarimodels.txt");
                    break;
                case "Fiat":
                    loadCarmodelsforAdminSearch("fiatmodels.txt");
                    break;
                case "Ford":
                    loadCarmodelsforAdminSearch("fordmodels.txt");
                    break;
                case "Honda":
                    loadCarmodelsforAdminSearch("hondamodels.txt");
                    break;
                case "Hyundai":
                    loadCarmodelsforAdminSearch("hyundaimodels.txt");
                    break;
                case "Jaguar":
                    loadCarmodelsforAdminSearch("jaguarmodels.txt");
                    break;
                case "Jeep":
                    loadCarmodelsforAdminSearch("jeepmodels.txt");
                    break;
                case "Kia":
                    loadCarmodelsforAdminSearch("kiamodels.txt");
                    break;
                case "Lada":
                    loadCarmodelsforAdminSearch("ladamodels.txt");
                    break;
                case "Lamborghini":
                    loadCarmodelsforAdminSearch("lamborghinimodels.txt");
                    break;
                case "Lancia":
                    loadCarmodelsforAdminSearch("lanciamodels.txt");
                    break;
                case "Land Rover":
                    loadCarmodelsforAdminSearch("landrovermodels.txt");
                    break;
                case "Lexus":
                    loadCarmodelsforAdminSearch("lexusmodels.txt");
                    break;
                case "Mazda":
                    loadCarmodelsforAdminSearch("mazdamodels.txt");
                    break;
                case "Mercedes-Benz":
                    loadCarmodelsforAdminSearch("mercedesbenzmodels.txt");
                    break;
                case "Mercedes-AMG":
                    loadCarmodelsforAdminSearch("mercedesamgmodels.txt");
                    break;
                case "Mini":
                    loadCarmodelsforAdminSearch("minimodels.txt");
                    break;
                case "Mitsubishi":
                    loadCarmodelsforAdminSearch("mitsubishimodels.txt");
                    break;
                case "Nissan":
                    loadCarmodelsforAdminSearch("nissanmodels.txt");
                    break;
                case "Opel":
                    loadCarmodelsforAdminSearch("opelmodels.txt");
                    break;
                case "Peugeot":
                    loadCarmodelsforAdminSearch("peugeotmodels.txt");
                    break;
                case "Renault":
                    loadCarmodelsforAdminSearch("renaultmodels.txt");
                    break;
                case "Rolls-Royce":
                    loadCarmodelsforAdminSearch("rollsroycemodels.txt");
                    break;
                case "Saab":
                    loadCarmodelsforAdminSearch("saabmodels.txt");
                    break;
                case "SEAT":
                    loadCarmodelsforAdminSearch("seatmodels.txt");
                    break;
                case "Smart":
                    loadCarmodelsforAdminSearch("smartmodels.txt");
                    break;
                case "Ssangyong":
                    loadCarmodelsforAdminSearch("ssangyongmodels.txt");
                    break;
                case "Subaru":
                    loadCarmodelsforAdminSearch("subarumodels.txt");
                    break;
                case "Suzuki":
                    loadCarmodelsforAdminSearch("suzukimodels.txt");
                    break;
                case "Tesla":
                    loadCarmodelsforAdminSearch("teslamodels.txt");
                    break;
                case "Toyota":
                    loadCarmodelsforAdminSearch("toyotamodels.txt");
                    break;
                case "Volkswagen":
                    loadCarmodelsforAdminSearch("vwmodels.txt");
                    break;
                case "Volvo":
                    loadCarmodelsforAdminSearch("volvomodels.txt");
                    break;
            }
        }

        //Ha egy MÁRKA ki lett választva 
        private void cbAdminCarsMake_TextChanged(object sender, EventArgs e)
        {
            switch (cbAdminCarsMake.Text)
            {

                case "Alfa Romeo":
                    loadCarmodelsforAdmin("alfamodels.txt");
                    break;
                case "Alpina":
                    loadCarmodelsforAdmin("alpinamodels.txt");
                    break;
                case "Aston Martin":
                    loadCarmodelsforAdmin("astonmodels.txt");
                    break;
                case "Bentley":
                    loadCarmodelsforAdmin("bentleymodels.txt");
                    break;
                case "Audi":
                    loadCarmodelsforAdmin("audimodels.txt");
                    break;
                case "BMW":
                    loadCarmodelsforAdmin("bmwmodels.txt");
                    break;
                case "Citroen":
                    loadCarmodelsforAdmin("citroenmodels.txt");
                    break;
                case "Dacia":
                    loadCarmodelsforAdmin("daciamodels.txt");
                    break;
                case "Ferrari":
                    loadCarmodelsforAdmin("ferrarimodels.txt");
                    break;
                case "Fiat":
                    loadCarmodelsforAdmin("fiatmodels.txt");
                    break;
                case "Ford":
                    loadCarmodelsforAdmin("fordmodels.txt");
                    break;
                case "Honda":
                    loadCarmodelsforAdmin("hondamodels.txt");
                    break;
                case "Hyundai":
                    loadCarmodelsforAdmin("hyundaimodels.txt");
                    break;
                case "Jaguar":
                    loadCarmodelsforAdmin("jaguarmodels.txt");
                    break;
                case "Jeep":
                    loadCarmodelsforAdmin("jeepmodels.txt");
                    break;
                case "Kia":
                    loadCarmodelsforAdmin("kiamodels.txt");
                    break;
                case "Lada":
                    loadCarmodelsforAdmin("ladamodels.txt");
                    break;
                case "Lamborghini":
                    loadCarmodelsforAdmin("lamborghinimodels.txt");
                    break;
                case "Lancia":
                    loadCarmodelsforAdmin("lanciamodels.txt");
                    break;
                case "Land Rover":
                    loadCarmodelsforAdmin("landrovermodels.txt");
                    break;
                case "Lexus":
                    loadCarmodelsforAdmin("lexusmodels.txt");
                    break;
                case "Mazda":
                    loadCarmodelsforAdmin("mazdamodels.txt");
                    break;
                case "Mercedes-Benz":
                    loadCarmodelsforAdmin("mercedesbenzmodels.txt");
                    break;
                case "Mercedes-AMG":
                    loadCarmodelsforAdmin("mercedesamgmodels.txt");
                    break;
                case "Mini":
                    loadCarmodelsforAdmin("minimodels.txt");
                    break;
                case "Mitsubishi":
                    loadCarmodelsforAdmin("mitsubishimodels.txt");
                    break;
                case "Nissan":
                    loadCarmodelsforAdmin("nissanmodels.txt");
                    break;
                case "Opel":
                    loadCarmodelsforAdmin("opelmodels.txt");
                    break;
                case "Peugeot":
                    loadCarmodelsforAdmin("peugeotmodels.txt");
                    break;
                case "Renault":
                    loadCarmodelsforAdmin("renaultmodels.txt");
                    break;
                case "Rolls-Royce":
                    loadCarmodelsforAdmin("rollsroycemodels.txt");
                    break;
                case "Saab":
                    loadCarmodelsforAdmin("saabmodels.txt");
                    break;
                case "SEAT":
                    loadCarmodelsforAdmin("seatmodels.txt");
                    break;
                case "Smart":
                    loadCarmodelsforAdmin("smartmodels.txt");
                    break;
                case "Ssangyong":
                    loadCarmodelsforAdmin("ssangyongmodels.txt");
                    break;
                case "Subaru":
                    loadCarmodelsforAdmin("subarumodels.txt");
                    break;
                case "Suzuki":
                    loadCarmodelsforAdmin("suzukimodels.txt");
                    break;
                case "Tesla":
                    loadCarmodelsforAdmin("teslamodels.txt");
                    break;
                case "Toyota":
                    loadCarmodelsforAdmin("toyotamodels.txt");
                    break;
                case "Volkswagen":
                    loadCarmodelsforAdmin("vwmodels.txt");
                    break;
                case "Volvo":
                    loadCarmodelsforAdmin("volvomodels.txt");
                    break;
            }
        }

        //KERESÉS gomb esemény:
        private void bnAdminCarsSearch_Click(object sender, EventArgs e)
        {
            tbAdminCarsID.Clear();
            cbAdminCarsCategory.Text = "válasszon";
            cbAdminCarsMake.Text = "válasszon";
            cbAdminCarsModel.DataSource = null;
            tbAdminCarsCode.Clear();
            cbAdminCarsBody.Text = "válasszon";
            cbAdminCarsFuel.Text = "válasszon";
            cbAdminCarsCyl.Text = "válasszon";
            cbAdminCarsCylArr.Text = "válasszon";
            cbAdminCarsAsp.Text = "válasszon";
            nudAdminCarsPower.Value = 0;
            nudAdminCarsTorque.Value = 0;
            cbAdminCarsDisp.Text = "válasszon";
            cbAdminCarsGearbox.Text = "válasszon";
            cbAdminCarsGears.Text = "válasszon";
            cbAdminCarsDrivetrain.Text = "válasszon";
            nudAdminCarsAcc100.Value = 0;
            nudAdminCarsAcc200.Value = 0;
            nudAdminCarsVmax.Value = 0;
            nudAdminCarsConsmp.Value = 0;
            cbAdminCarsProdStart.Text = "válasszon";
            cbAdminCarsProdEnd.Text = "válasszon";
            nudAdminCarsBatCap.Value = 0;
            nudAdminCarsRange.Value = 0;

            dgvAdminCars.DataSource = null;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            //ha egy mező sincs kiválasztva:
            if (cbAdminCarsMakeSearch.Text == "válasszon" && cbAdminCarsModelSearch.Text == "")
            {
                query = "SELECT * FROM cars";
            }

            if (cbAdminCarsMakeSearch.Text == "válasszon" && cbAdminCarsModelSearch.Text == "válasszon")
            {
                query = "SELECT * FROM cars";
            }

            //ha csak a márka van kiválasztva:
            else if (cbAdminCarsMakeSearch.Text != "válasszon" && cbAdminCarsModelSearch.Text == "")
            {
                query = "SELECT * FROM cars WHERE make = '" + cbAdminCarsMakeSearch.Text + "'";
            }

            else if (cbAdminCarsMakeSearch.Text != "válasszon" && cbAdminCarsModelSearch.Text == "válasszon")
            {
                query = "SELECT * FROM cars WHERE make = '" + cbAdminCarsMakeSearch.Text + "'";
            }

            //ha a márka és modell is ki van válaztva
            else if (cbAdminCarsMakeSearch.Text != "válasszon" && cbAdminCarsModelSearch.Text != "")
            {
                query = "SELECT * FROM cars WHERE make = '" + cbAdminCarsMakeSearch.Text + "' AND model = '" + cbAdminCarsModelSearch.Text + "'";
            }

            else if (cbAdminCarsMakeSearch.Text != "válasszon" && cbAdminCarsModelSearch.Text != "válasszon")
            {
                query = "SELECT * FROM cars WHERE make = '" + cbAdminCarsMakeSearch.Text + "' AND model = '" + cbAdminCarsModelSearch.Text + "'";
            }

            try
            {
                DataTable mytable = new DataTable();
                MySqlCommand search = new MySqlCommand(query, con);
                MySqlDataReader open = search.ExecuteReader();
                mytable.Load(open);
                if (mytable.Rows.Count > 0)
                {
                    dgvAdminCars.DataSource = mytable;
                }
                else
                {
                    dgvAdminCars.DataSource = mytable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        //MÓDOSÍTÁS gomb esemény:
        private void bnAdminCarsMod_Click(object sender, EventArgs e)
        {
            if (cbAdminCarsCategory.Text == "válasszon"
            || cbAdminCarsMake.Text == "válasszon" || cbAdminCarsMake.Text == ""
            || cbAdminCarsModel.Text == "válasszon" || cbAdminCarsModel.Text == ""
            || cbAdminCarsFuel.Text == "válasszon" || cbAdminCarsFuel.Text == ""
            || cbAdminCarsBody.Text == "válasszon" || cbAdminCarsBody.Text == ""
            || cbAdminCarsCyl.Text == "válasszon" || cbAdminCarsCyl.Text == ""
            || cbAdminCarsCylArr.Text == "válasszon" || cbAdminCarsCylArr.Text == ""
            || cbAdminCarsAsp.Text == "válasszon" || cbAdminCarsAsp.Text == ""
            || nudAdminCarsPower.Value == 0
            || nudAdminCarsTorque.Value == 0
            || cbAdminCarsDisp.Text == "válasszon" || cbAdminCarsDisp.Text == ""
            || cbAdminCarsGearbox.Text == "válasszon" || cbAdminCarsGearbox.Text == ""
            || cbAdminCarsGears.Text == "válasszon" || cbAdminCarsGears.Text == ""
            || cbAdminCarsDrivetrain.Text == "válasszon" || cbAdminCarsDrivetrain.Text == ""
            || nudAdminCarsAcc100.Value == 0
            || nudAdminCarsAcc200.Value == 0
            || nudAdminCarsVmax.Value == 0
            || nudAdminCarsConsmp.Value == 0
            || cbAdminCarsProdStart.Text == "válasszon" || cbAdminCarsProdStart.Text == ""
            || cbAdminCarsProdEnd.Text == "válasszon" || cbAdminCarsProdEnd.Text == ""
            )
            {
                MessageBox.Show("A csillaggal jelölt mezők kitöltése kötelező!");
            }
            else
            {


                query = "UPDATE cars SET " +
                    "category = '" + cbAdminCarsCategory.Text + "'," +
                    "make = '" + cbAdminCarsMake.Text + "' ," +
                    "model = '" + cbAdminCarsModel.Text + "'," +
                    "code = '" + tbAdminCarsCode.Text + "'," +
                    "body = '" + cbAdminCarsBody.Text + "'," +
                    "fuel_type = '" + cbAdminCarsFuel.Text + "'," +
                    "cylinder_number = '" + cbAdminCarsCyl.Text + "'," +
                    "cylinder_arrangement = '" + cbAdminCarsCylArr.Text + "'," +
                    "aspiration = '" + cbAdminCarsAsp.Text + "'," +
                    "power = '" + nudAdminCarsPower.Value + "'," +
                    "torque = '" + nudAdminCarsTorque.Value + "'," +
                    "displacement = '" + cbAdminCarsDisp.Text + "'," +
                    "gearbox_type = '" + cbAdminCarsGearbox.Text + "'," +
                    "gears = '" + cbAdminCarsGears.Text + "'," +
                    "powertrain = '" + cbAdminCarsDrivetrain.Text + "'," +
                    "acceleration100 = '" + nudAdminCarsAcc100.Value + "'," +
                    "acceleration200 = '" + nudAdminCarsAcc200.Value + "'," +
                    "vmax = '" + nudAdminCarsVmax.Value + "'," +
                    "consumption = '" + nudAdminCarsConsmp.Value + "'," +
                    "production_start = '" + cbAdminCarsProdStart.Text + "'," +
                    "production_end = '" + cbAdminCarsProdEnd.Text + "'," +
                    "bat_capacity = '" + nudAdminCarsBatCap.Value + "'," +
                    "fuel_range = '" + nudAdminCarsRange.Value + "'" +
                    "WHERE id = '" + tbAdminCarsID.Text + "'";

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                MySqlCommand insert = new MySqlCommand(query, con);
                try
                {
                    if (insert.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Gépjármű módosítva");
                    }
                    else
                    {
                        MessageBox.Show("Módosítás sikertelen");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //TÖRLÉS gomb esemény:
        private void bnAdminCarsDel_Click(object sender, EventArgs e)
        {
            if (tbAdminCarsID.Text == "")
            {
                MessageBox.Show("Jelöljön ki egy autót a törléshez!");
            }
            else
            {
                query = "DELETE FROM cars WHERE id = '" + tbAdminCarsID.Text + "'";

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                MySqlCommand insert = new MySqlCommand(query, con);
                try
                {
                    if (insert.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Gépjármű törölve");
                    }
                    else
                    {
                        MessageBox.Show("Törlés sikertelen");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        //KATTINTÁS esemény a datagrid-be:
        private void dgvAdminCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvAdminCars.Rows[e.RowIndex];

                tbAdminCarsID.Text = row.Cells[0].Value.ToString();
                cbAdminCarsCategory.Text = row.Cells[1].Value.ToString();
                cbAdminCarsMake.Text = row.Cells[2].Value.ToString();
                cbAdminCarsModel.Text = row.Cells[3].Value.ToString();
                tbAdminCarsCode.Text = row.Cells[4].Value.ToString();
                cbAdminCarsBody.Text = row.Cells[5].Value.ToString();
                cbAdminCarsFuel.Text = row.Cells[6].Value.ToString();
                cbAdminCarsCyl.Text = row.Cells[7].Value.ToString();
                cbAdminCarsCylArr.Text = row.Cells[8].Value.ToString();
                cbAdminCarsAsp.Text = row.Cells[9].Value.ToString();
                nudAdminCarsPower.Value = Convert.ToInt32(row.Cells[10].Value.ToString());
                nudAdminCarsTorque.Value = Convert.ToInt32(row.Cells[11].Value.ToString());
                cbAdminCarsDisp.Text = row.Cells[12].Value.ToString();
                cbAdminCarsGearbox.Text = row.Cells[13].Value.ToString();
                cbAdminCarsGears.Text = row.Cells[14].Value.ToString();
                cbAdminCarsDrivetrain.Text = row.Cells[15].Value.ToString();
                nudAdminCarsAcc100.Value = Convert.ToDecimal(row.Cells[16].Value.ToString());
                nudAdminCarsAcc200.Value = Convert.ToDecimal(row.Cells[17].Value.ToString());
                nudAdminCarsVmax.Value = Convert.ToInt32(row.Cells[18].Value.ToString());
                nudAdminCarsConsmp.Value = Convert.ToDecimal(row.Cells[19].Value.ToString());
                cbAdminCarsProdStart.Text = row.Cells[20].Value.ToString();
                cbAdminCarsProdEnd.Text = row.Cells[21].Value.ToString();
                nudAdminCarsBatCap.Value = Convert.ToDecimal(row.Cells[22].Value.ToString());
                nudAdminCarsRange.Value = Convert.ToInt32(row.Cells[23].Value.ToString());
            }
        }

        //ÚJ MODELL hozzáadása:
        private void btnAdminCarsAddModel_Click(object sender, EventArgs e)
        {
            if ((cbAdminCarsMake.Text == "") || (cbAdminCarsMake.Text == "válasszon"))
            {
                MessageBox.Show("Először válasszon ki egy márkát!");
            }
            else if (cbAdminCarsModel.Text == "válasszon")
            {
                MessageBox.Show("Írja be az új modellt!");
            }
            else
            {
                switch (cbAdminCarsMake.Text)
                {
                    case "Alfa Romeo":
                        addNewModel("alfamodels.txt");
                        break;
                    case "Alpina":
                        addNewModel("alpinamodels.txt");
                        break;
                    case "Aston Martin":
                        addNewModel("astonmodels.txt");
                        break;
                    case "Bentley":
                        addNewModel("bentleymodels.txt");
                        break;
                    case "Audi":
                        addNewModel("audimodels.txt");
                        break;
                    case "BMW":
                        addNewModel("bmwmodels.txt");
                        break;
                    case "Citroen":
                        addNewModel("citroenmodels.txt");
                        break;
                    case "Dacia":
                        addNewModel("daciamodels.txt");
                        break;
                    case "Ferrari":
                        addNewModel("ferrarimodels.txt");
                        break;
                    case "Fiat":
                        addNewModel("fiatmodels.txt");
                        break;
                    case "Ford":
                        addNewModel("fordmodels.txt");
                        break;
                    case "Honda":
                        addNewModel("hondamodels.txt");
                        break;
                    case "Hyundai":
                        addNewModel("hyundaimodels.txt");
                        break;
                    case "Jaguar":
                        addNewModel("jaguarmodels.txt");
                        break;
                    case "Jeep":
                        addNewModel("jeepmodels.txt");
                        break;
                    case "Kia":
                        addNewModel("kiamodels.txt");
                        break;
                    case "Lada":
                        addNewModel("ladamodels.txt");
                        break;
                    case "Lamborghini":
                        addNewModel("lamborghinimodels.txt");
                        break;
                    case "Lancia":
                        addNewModel("lanciamodels.txt");
                        break;
                    case "Land Rover":
                        addNewModel("landrovermodels.txt");
                        break;
                    case "Lexus":
                        addNewModel("lexusmodels.txt");
                        break;
                    case "Mazda":
                        addNewModel("mazdamodels.txt");
                        break;
                    case "Mercedes-Benz":
                        addNewModel("mercedesbenzmodels.txt");
                        break;
                    case "Mercedes-AMG":
                        addNewModel("mercedesamgmodels.txt");
                        break;
                    case "Mini":
                        addNewModel("minimodels.txt");
                        break;
                    case "Mitsubishi":
                        addNewModel("mitsubishimodels.txt");
                        break;
                    case "Nissan":
                        addNewModel("nissanmodels.txt");
                        break;
                    case "Opel":
                        addNewModel("opelmodels.txt");
                        break;
                    case "Peugeot":
                        addNewModel("peugeotmodels.txt");
                        break;
                    case "Renault":
                        addNewModel("renaultmodels.txt");
                        break;
                    case "Rolls-Royce":
                        addNewModel("rollsroycemodels.txt");
                        break;
                    case "Saab":
                        addNewModel("saabmodels.txt");
                        break;
                    case "SEAT":
                        addNewModel("seatmodels.txt");
                        break;
                    case "Smart":
                        addNewModel("smartmodels.txt");
                        break;
                    case "Ssangyong":
                        addNewModel("ssangyongmodels.txt");
                        break;
                    case "Subaru":
                        addNewModel("subarumodels.txt");
                        break;
                    case "Suzuki":
                        addNewModel("suzukimodels.txt");
                        break;
                    case "Tesla":
                        addNewModel("teslamodels.txt");
                        break;
                    case "Toyota":
                        addNewModel("toyotamodels.txt");
                        break;
                    case "Volkswagen":
                        addNewModel("vwmodels.txt");
                        break;
                    case "Volvo":
                        addNewModel("volvomodels.txt");
                        break;
                }
            }
        }

        private void addNewModel(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                using (sw)
                {
                    sw.WriteLine("\n" + cbAdminCarsModel.Text);
                }

                MessageBox.Show("Új modell regisztrálása sikeres");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Új modell regisztrálása sikertelen" +"\n"+ex);
            }

            sw.Close();
            fs.Close();
        }

        //BEZÁRÁS gomb esemény:
        private void bnCloseWindow_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Confirm a = new Confirm();
            dr = a.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dr == DialogResult.No)
            {
                a.Dispose();
            }
        }

        //MEZŐK TÖRLÉSE gomb esemény:
        private void bnAdminCarsClearFields_Click(object sender, EventArgs e)
        {
            tbAdminCarsID.Clear();
            cbAdminCarsCategory.Text = "válasszon";
            cbAdminCarsMake.Text = "válasszon";
            cbAdminCarsModel.DataSource = null;
            tbAdminCarsCode.Clear();
            cbAdminCarsBody.Text = "válasszon";
            cbAdminCarsFuel.Text = "válasszon";
            cbAdminCarsCyl.Text = "válasszon";
            cbAdminCarsCylArr.Text = "válasszon";
            cbAdminCarsAsp.Text = "válasszon";
            nudAdminCarsPower.Value = 0;
            nudAdminCarsTorque.Value = 0;
            cbAdminCarsDisp.Text = "válasszon";
            cbAdminCarsGearbox.Text = "válasszon";
            cbAdminCarsGears.Text = "válasszon";
            cbAdminCarsDrivetrain.Text = "válasszon";
            nudAdminCarsAcc100.Value = 0;
            nudAdminCarsAcc200.Value = 0;
            nudAdminCarsVmax.Value = 0;
            nudAdminCarsConsmp.Value = 0;
            cbAdminCarsProdStart.Text = "válasszon";
            cbAdminCarsProdEnd.Text = "válasszon";
            nudAdminCarsBatCap.Value = 0;
            nudAdminCarsRange.Value = 0;
        }
    }
}