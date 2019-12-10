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
using System.IO;

namespace autoDATA
{
    public partial class carDataBase : Form
    {
        String connectionstring;
        MySqlConnection con;
        public string query = "";

        public carDataBase()
        {
            InitializeComponent();
        }

        //Form LOAD esemény:
        private void carDataBase_Load(object sender, EventArgs e)
        {
            lbCarSearchBatCap.Visible = false;
            tbCarSearchBatCap.Visible = false;
            lbCarSearchBatCapkw.Visible = false;
            lbCarSearchFuelRange.Visible = false;
            tbCarSearchFuelRange.Visible = false;
            lbCarSearchFuelRangekm.Visible = false;

            lbCarRegBatCapacity.Visible = false;
            nudCarRegBatCap.Visible = false;
            lbCarRegBatCapkwh.Visible = false;
            lbCarRegRange.Visible = false;
            nudCarRegRange.Visible = false;
            lbCarRegFuelRangekm.Visible = false;

            databaseConnect();
            loadCarMakesForCarSearch();
            loadCarMakesForCarReg();
            loadCarCategoriesForCarReg();
            loadFuelTypesForCarReg();
            loadDisplacementForCarReg();
            loadCylindersForCarReg();
            loadGerarbox();
            loadCarRegProdYearsStart();
            loadCarRegProdYearsEnd();

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
            cbCarRegBody.DataSource = bodylist;
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
                    lbConnect.Text = "Kapcsolódva";
                    lbConnect.ForeColor = Color.Green;
                }
                else
                {
                    lbConnect.Text = "Nincs kapcsolat";
                    lbConnect.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        //AUTÓKATEGÓRIÁK betöltése ADATBÁZISBÓL:      
        public void loadCarCategoriesForCarReg()
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
                cbCarRegCategories.DisplayMember = "categories";
                cbCarRegCategories.DataSource = mytable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        //AUTÓMÁRKÁK betöltése TXT FÁJLBÓL:
        private void loadCarMakesForCarSearch()
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

            cbCarSearchMake.DataSource = carmakes;
        }

        private void loadCarMakesForCarReg()
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

            cbCarRegMake.DataSource = carmakes;
        }

        //AUTÓMODELLEK betöltése PARAMÉTERREL TXT FÁJLBÓL:
        private void loadCarmodelsforCarSearch(string path)
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

            cbCarSearchModel.DataSource = carmodels;

            sr.Close();
            fs.Close();
        }

        private void loadCarmodelsforCarReg(string path)
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

            cbCarRegModel.DataSource = carmodels;

            sr.Close();
            fs.Close();
        }

        //ÜZEMANYAGFAJTÁK betöltése STRING ARRAY:        
        private void loadFuelTypesForCarReg()
        {
            string[] fuels = new string[] { "válasszon", "benzin", "dízel", "LPG", "CNG", "hibrid", "elektromos", "üzemanyagcella" };
            cbCarRegFuel.DataSource = fuels;
        }

        //LÖKETTÉRFOGAT betöltése STRING ARRAY:
        private void loadDisplacementForCarReg()
        {
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

            cbCarRegDisp.DataSource = disparray;
        }

        //GYÁRTÁSI ÉVEK betöltése STRING ARRAY:
        private void loadCarRegProdYearsStart()
        {
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

            cbCarRegProdStart.DataSource = prodyearsarray;
        }

        private void loadCarRegProdYearsEnd()
        {
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
                "még gyártásban", "válasszon"
            };

            Array.Reverse(prodyearsarray);

            cbCarRegProdEnd.DataSource = prodyearsarray;
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
                DataTable mytable2 = new DataTable();
                MySqlCommand search = new MySqlCommand(query, con);
                MySqlDataReader open = search.ExecuteReader();
                mytable2.Load(open);
                cbCarRegGearboxType.DisplayMember = "gear_type";
                cbCarRegGearboxType.DataSource = mytable2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        //HENGERSZÁM betöltése STRING ARRAY:
        private void loadCylindersForCarReg()
        {
            string[] cylinderarray = new string[] { "válasszon", "nincs", "1", "2", "3", "4", "5", "6", "8", "10", "12", "16" };
            cbCarRegCyl.DataSource = cylinderarray;
        }

        //ha egy MÁRKA ki lett választva, akkor csak ezeket a MODELLEKET mutassa (textchanged események):
        //SWITCH CASE elágazásokkal:
        private void cbCarSearchMake_TextChanged(object sender, EventArgs e)
        {
            switch (cbCarSearchMake.Text)
            {

                case "Alfa Romeo":
                    loadCarmodelsforCarSearch("alfamodels.txt");
                    break;
                case "Alpina":
                    loadCarmodelsforCarSearch("alpinamodels.txt");
                    break;
                case "Aston Martin":
                    loadCarmodelsforCarSearch("astonmodels.txt");
                    break;
                case "Bentley":
                    loadCarmodelsforCarSearch("bentleymodels.txt");
                    break;
                case "Audi":
                    loadCarmodelsforCarSearch("audimodels.txt");
                    break;
                case "BMW":
                    loadCarmodelsforCarSearch("bmwmodels.txt");
                    break;
                case "Citroen":
                    loadCarmodelsforCarSearch("citroenmodels.txt");
                    break;
                case "Dacia":
                    loadCarmodelsforCarSearch("daciamodels.txt");
                    break;
                case "Ferrari":
                    loadCarmodelsforCarSearch("ferrarimodels.txt");
                    break;
                case "Fiat":
                    loadCarmodelsforCarSearch("fiatmodels.txt");
                    break;
                case "Ford":
                    loadCarmodelsforCarSearch("fordmodels.txt");
                    break;
                case "Honda":
                    loadCarmodelsforCarSearch("hondamodels.txt");
                    break;
                case "Hyundai":
                    loadCarmodelsforCarSearch("hyundaimodels.txt");
                    break;
                case "Jaguar":
                    loadCarmodelsforCarSearch("jaguarmodels.txt");
                    break;
                case "Jeep":
                    loadCarmodelsforCarSearch("jeepmodels.txt");
                    break;
                case "Kia":
                    loadCarmodelsforCarSearch("kiamodels.txt");
                    break;
                case "Lada":
                    loadCarmodelsforCarSearch("ladamodels.txt");
                    break;
                case "Lamborghini":
                    loadCarmodelsforCarSearch("lamborghinimodels.txt");
                    break;
                case "Lancia":
                    loadCarmodelsforCarSearch("lanciamodels.txt");
                    break;
                case "Land Rover":
                    loadCarmodelsforCarSearch("landrovermodels.txt");
                    break;
                case "Lexus":
                    loadCarmodelsforCarSearch("lexusmodels.txt");
                    break;
                case "Mazda":
                    loadCarmodelsforCarSearch("mazdamodels.txt");
                    break;
                case "Mercedes-Benz":
                    loadCarmodelsforCarSearch("mercedesbenzmodels.txt");
                    break;
                case "Mercedes-AMG":
                    loadCarmodelsforCarSearch("mercedesamgmodels.txt");
                    break;
                case "Mini":
                    loadCarmodelsforCarSearch("minimodels.txt");
                    break;
                case "Mitsubishi":
                    loadCarmodelsforCarSearch("mitsubishimodels.txt");
                    break;
                case "Nissan":
                    loadCarmodelsforCarSearch("nissanmodels.txt");
                    break;
                case "Opel":
                    loadCarmodelsforCarSearch("opelmodels.txt");
                    break;
                case "Peugeot":
                    loadCarmodelsforCarSearch("peugeotmodels.txt");
                    break;
                case "Renault":
                    loadCarmodelsforCarSearch("renaultmodels.txt");
                    break;
                case "Rolls-Royce":
                    loadCarmodelsforCarSearch("rollsroycemodels.txt");
                    break;
                case "Saab":
                    loadCarmodelsforCarSearch("saabmodels.txt");
                    break;
                case "SEAT":
                    loadCarmodelsforCarSearch("seatmodels.txt");
                    break;
                case "Smart":
                    loadCarmodelsforCarSearch("smartmodels.txt");
                    break;
                case "Ssangyong":
                    loadCarmodelsforCarSearch("ssangyongmodels.txt");
                    break;
                case "Subaru":
                    loadCarmodelsforCarSearch("subarumodels.txt");
                    break;
                case "Suzuki":
                    loadCarmodelsforCarSearch("suzukimodels.txt");
                    break;
                case "Tesla":
                    loadCarmodelsforCarSearch("teslamodels.txt");
                    break;
                case "Toyota":
                    loadCarmodelsforCarSearch("toyotamodels.txt");
                    break;
                case "Volkswagen":
                    loadCarmodelsforCarSearch("vwmodels.txt");
                    break;
                case "Volvo":
                    loadCarmodelsforCarSearch("volvomodels.txt");
                    break;
            }
        }

        //IF elágazásokkal:
        private void cbCarRegMake_TextChanged(object sender, EventArgs e)
        {
            if (cbCarRegMake.Text == "Alfa Romeo")
            {
                loadCarmodelsforCarReg("alfamodels.txt");
            }
            else if (cbCarRegMake.Text == "Alpina")
            {
                loadCarmodelsforCarReg("alpinamodels.txt");
            }
            else if (cbCarRegMake.Text == "Aston Martin")
            {
                loadCarmodelsforCarReg("astonmodels.txt");
            }
            else if (cbCarRegMake.Text == "Bentley")
            {
                loadCarmodelsforCarReg("bentleymodels.txt");
            }
            else if (cbCarRegMake.Text == "Audi")
            {
                loadCarmodelsforCarReg("audimodels.txt");
            }
            else if (cbCarRegMake.Text == "BMW")
            {
                loadCarmodelsforCarReg("bmwmodels.txt");
            }
            else if (cbCarRegMake.Text == "Citroen")
            {
                loadCarmodelsforCarReg("citroenmodels.txt");
            }
            else if (cbCarRegMake.Text == "Dacia")
            {
                loadCarmodelsforCarReg("daciamodels.txt");
            }
            else if (cbCarRegMake.Text == "Ferrari")
            {
                loadCarmodelsforCarReg("ferrarimodels.txt");
            }
            else if (cbCarRegMake.Text == "Fiat")
            {
                loadCarmodelsforCarReg("fiatmodels.txt");
            }
            else if (cbCarRegMake.Text == "Ford")
            {
                loadCarmodelsforCarReg("fordmodels.txt");
            }
            else if (cbCarRegMake.Text == "Honda")
            {
                loadCarmodelsforCarReg("hondamodels.txt");
            }
            else if (cbCarRegMake.Text == "Hyundai")
            {
                loadCarmodelsforCarReg("hyundaimodels.txt");
            }
            else if (cbCarRegMake.Text == "Jaguar")
            {
                loadCarmodelsforCarReg("jaguarmodels.txt");
            }
            else if (cbCarRegMake.Text == "Jeep")
            {
                loadCarmodelsforCarReg("jeepmodels.txt");
            }
            else if (cbCarRegMake.Text == "Kia")
            {
                loadCarmodelsforCarReg("kiamodels.txt");
            }
            else if (cbCarRegMake.Text == "Lada")
            {
                loadCarmodelsforCarReg("ladamodels.txt");
            }
            else if (cbCarRegMake.Text == "Lamborghini")
            {
                loadCarmodelsforCarReg("lamborghinimodels.txt");
            }
            else if (cbCarRegMake.Text == "Lancia")
            {
                loadCarmodelsforCarReg("lanciamodels.txt");
            }
            else if (cbCarRegMake.Text == "Land Rover")
            {
                loadCarmodelsforCarReg("landrovermodels.txt");
            }
            else if (cbCarRegMake.Text == "Lexus")
            {
                loadCarmodelsforCarReg("lexusmodels.txt");
            }
            else if (cbCarRegMake.Text == "Mazda")
            {
                loadCarmodelsforCarReg("mazdamodels.txt");
            }
            else if (cbCarRegMake.Text == "Mercedes-Benz")
            {
                loadCarmodelsforCarReg("mercedesbenzmodels.txt");
            }
            else if (cbCarRegMake.Text == "Mercedes-AMG")
            {
                loadCarmodelsforCarReg("mercedesamgmodels.txt");
            }
            else if (cbCarRegMake.Text == "Mini")
            {
                loadCarmodelsforCarReg("minimodels.txt");
            }
            else if (cbCarRegMake.Text == "Mitsubishi")
            {
                loadCarmodelsforCarReg("mitsubishimodels.txt");
            }
            else if (cbCarRegMake.Text == "Nissan")
            {
                loadCarmodelsforCarReg("nissanmodels.txt");
            }
            else if (cbCarRegMake.Text == "Opel")
            {
                loadCarmodelsforCarReg("opelmodels.txt");
            }
            else if (cbCarRegMake.Text == "Peugeot")
            {
                loadCarmodelsforCarReg("peugeotmodels.txt");
            }
            else if (cbCarRegMake.Text == "Renault")
            {
                loadCarmodelsforCarReg("renaultmodels.txt");
            }
            else if (cbCarRegMake.Text == "Rolls-Royce")
            {
                loadCarmodelsforCarReg("rollsroycemodels.txt");
            }
            else if (cbCarRegMake.Text == "Saab")
            {
                loadCarmodelsforCarReg("saabmodels.txt");
            }
            else if (cbCarRegMake.Text == "SEAT")
            {
                loadCarmodelsforCarReg("seatmodels.txt");
            }
            else if (cbCarRegMake.Text == "Smart")
            {
                loadCarmodelsforCarReg("smartmodels.txt");
            }
            else if (cbCarRegMake.Text == "Ssangyong")
            {
                loadCarmodelsforCarReg("ssangyongmodels.txt");
            }
            else if (cbCarRegMake.Text == "Subaru")
            {
                loadCarmodelsforCarReg("subarumodels.txt");
            }
            else if (cbCarRegMake.Text == "Suzuki")
            {
                loadCarmodelsforCarReg("suzukimodels.txt");
            }
            else if (cbCarRegMake.Text == "Tesla")
            {
                loadCarmodelsforCarReg("teslamodels.txt");
            }
            else if (cbCarRegMake.Text == "Toyota")
            {
                loadCarmodelsforCarReg("toyotamodels.txt");
            }
            else if (cbCarRegMake.Text == "Volkswagen")
            {
                loadCarmodelsforCarReg("vwmodels.txt");
            }
            else if (cbCarRegMake.Text == "Volvo")
            {
                loadCarmodelsforCarReg("volvomodels.txt");
            }
        }

        //KERESÉS GOMB click esemény:
        private void bnCarSearch_Click(object sender, EventArgs e)
        {
            clearData();
            dgvCarSearch.DataSource = null;

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            //ha egy mező sincs kiválasztva:
            if (cbCarSearchMake.Text == "válasszon" && cbCarSearchModel.Text == "")
            {
                query = "SELECT * FROM cars";
            }

            if (cbCarSearchMake.Text == "válasszon" && cbCarSearchModel.Text == "válasszon")
            {
                query = "SELECT * FROM cars";
            }

            //ha csak a márka van kiválasztva:
            else if (cbCarSearchMake.Text != "válasszon" && cbCarSearchModel.Text == "")
            {
                query = "SELECT * FROM cars WHERE make = '" + cbCarSearchMake.Text + "'";
            }

            else if (cbCarSearchMake.Text != "válasszon" && cbCarSearchModel.Text == "válasszon")
            {
                query = "SELECT * FROM cars WHERE make = '" + cbCarSearchMake.Text + "'";
            }

            //ha a márka és modell is ki van válaztva
            else if (cbCarSearchMake.Text != "válasszon" && cbCarSearchModel.Text != "")
            {
                query = "SELECT * FROM cars WHERE make = '" + cbCarSearchMake.Text + "' AND model = '" + cbCarSearchModel.Text + "'";
            }

            else if (cbCarSearchMake.Text != "válasszon" && cbCarSearchModel.Text != "válasszon")
            {
                query = "SELECT * FROM cars WHERE make = '" + cbCarSearchMake.Text + "' AND model = '" + cbCarSearchModel.Text + "'";
            }

            try
            {
                DataTable mytable = new DataTable();
                MySqlCommand search = new MySqlCommand(query, con);
                MySqlDataReader open = search.ExecuteReader();
                mytable.Load(open);
                if (mytable.Rows.Count > 0)
                {
                    dgvCarSearch.DataSource = mytable;
                }
                else
                {
                    dgvCarSearch.DataSource = mytable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        //ha NINCS VÁLTÓ lett kiválasztva:
        private void cbCarRegGearboxType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCarRegGearboxType.Text == "nincs")
            {
                cbCarRegGearsNum.Text = "n/a";
            }
        }

        //ha az ELEKTROMOS üzemanyagtípus van kiválasztva, akkor változzon a FORM kinézete (textchanged esemény):
        private void cbFuelType_TextChanged(object sender, EventArgs e)
        {
            if (cbCarRegFuel.Text == "elektromos")
            {
                lbCarRegBatCapacity.Visible = true;
                nudCarRegBatCap.Visible = true;
                lbCarRegBatCapkwh.Visible = true;
                lbCarRegRange.Visible = true;
                nudCarRegRange.Visible = true;
                lbCarRegFuelRangekm.Visible = true;
                cbCarRegCyl.Text = "nincs";
                cbCarRegCylArr.Text = "n/a";
                cbCarRegAsp.Text = "n/a";
                cbCarRegDisp.Text = "n/a";

            }
            else if (cbCarRegFuel.Text == "hibrid")
            {
                lbCarRegBatCapacity.Visible = true;
                nudCarRegBatCap.Visible = true;
                lbCarRegBatCapkwh.Visible = true;
                lbCarRegRange.Visible = true;
                nudCarRegRange.Visible = true;
                lbCarRegFuelRangekm.Visible = true;
            }
            else
            {
                lbCarRegBatCapacity.Visible = false;
                nudCarRegBatCap.Visible = false;
                lbCarRegBatCapkwh.Visible = false;
                lbCarRegRange.Visible = false;
                nudCarRegRange.Visible = false;
                lbCarRegFuelRangekm.Visible = false;
            }
        }

        private void tbCarSearchFuel_TextChanged(object sender, EventArgs e)
        {
            if (tbCarSearchFuel.Text == "elektromos" || tbCarSearchFuel.Text == "hibrid")
            {
                lbCarSearchBatCap.Visible = true;
                tbCarSearchBatCap.Visible = true;
                lbCarSearchBatCapkw.Visible = true;
                lbCarSearchFuelRange.Visible = true;
                tbCarSearchFuelRange.Visible = true;
                lbCarSearchFuelRangekm.Visible = true;
            }
        }

        //RÖGZÍTÉS GOMB click esemény:
        private void bnCarReg_Click(object sender, EventArgs e)
        {
            if (
                cbCarRegCategories.Text == "válasszon"
                || cbCarRegMake.Text == "" || cbCarRegMake.Text == "válasszon"
                || cbCarRegModel.Text == "" || cbCarRegModel.Text == "válasszon"
                || cbCarRegBody.Text == "válasszon" || cbCarRegBody.Text == ""
                || cbCarRegFuel.Text == "" || cbCarRegFuel.Text == "válasszon"
                || cbCarRegCyl.Text == "" || cbCarRegCyl.Text == "válasszon"
                || cbCarRegCylArr.Text == "" || cbCarRegCylArr.Text == "válasszon"
                || cbCarRegAsp.Text == "" || cbCarRegAsp.Text == "válasszon"                
                || cbCarRegDisp.Text == "" || cbCarRegDisp.Text == "válasszon"
                || cbCarRegGearboxType.Text == "" || cbCarRegGearboxType.Text == "válasszon"
                || cbCarRegGearsNum.Text == "" || cbCarRegGearsNum.Text == "válasszon"
                || cbCarRegDrivetrain.Text == "" || cbCarRegDrivetrain.Text == "válasszon"
                || nudCarRegAcc100.Value == 0
                || nudCarRegAcc200.Value == 0
                || nudCarRegVmax.Value == 0
                || nudCarRegConsmp.Value == 0
                || cbCarRegProdStart.Text == "" || cbCarRegProdStart.Text == "válasszon"
                || cbCarRegProdEnd.Text == "" || cbCarRegProdEnd.Text == "válasszon"
                )
            {
                MessageBox.Show("A csillaggal jelölt mezők kitöltése kötelező!");
            }
            else
            {
                string insertQuery = "INSERT INTO cars " +
                    "(category, make, model, code, body, fuel_type, cylinder_number, cylinder_arrangement, aspiration, power, torque, " +
                    "displacement, gearbox_type, gears, powertrain, acceleration100, acceleration200, vmax, consumption," +
                    "production_start, production_end, bat_capacity, fuel_range, registered_by)" +
                    "VALUES" +
                    "(" +
                    "'" + cbCarRegCategories.Text + "'," +
                    "'" + cbCarRegMake.Text + "'," +
                    "'" + cbCarRegModel.Text + "'," +
                    "'" + tbCarRegCode.Text + "'," +
                    "'" + cbCarRegBody.Text + "'," +
                    "'" + cbCarRegFuel.Text + "'," +
                    "'" + cbCarRegCyl.Text + "'," +
                    "'" + cbCarRegCylArr.Text + "'," +
                    "'" + cbCarRegAsp.Text + "'," +
                    "'" + nudCarRegPower.Value + "'," +
                    "'" + nudCarRegTorque.Value + "'," +
                    "'" + cbCarRegDisp.Text + "'," +
                    "'" + cbCarRegGearboxType.Text + "'," +
                    "'" + cbCarRegGearsNum.Text + "'," +
                    "'" + cbCarRegDrivetrain.Text + "'," +
                    "'" + nudCarRegAcc100.Value + "'," +
                    "'" + nudCarRegAcc200.Value + "'," +
                    "'" + nudCarRegVmax.Value + "'," +
                    "'" + nudCarRegConsmp.Value + "'," +
                    "'" + cbCarRegProdStart.Text + "'," +
                    "'" + cbCarRegProdEnd.Text + "'," +
                    "'" + nudCarRegBatCap.Value + "'," +
                    "'" + nudCarRegRange.Value + "'," +
                    "2)";

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                MySqlCommand insert = new MySqlCommand(insertQuery, con);
                try
                {
                    if (insert.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Gépjármű regisztrálva");
                    }
                    else
                    {
                        MessageBox.Show("Regisztráció sikertelen");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //MEZŐK TÖRLÉSE GOMBOK click eseményei:  
        private void bnClearFieldsCarReg_Click(object sender, EventArgs e)
        {
            cbCarRegCategories.Text = "válasszon";
            cbCarRegMake.Text = "válasszon";
            cbCarRegModel.DataSource = null;
            tbCarRegCode.Text = "";
            cbCarRegBody.Text = "válasszon";
            cbCarRegFuel.Text = "válasszon";
            cbCarRegCyl.Text = "válasszon";
            cbCarRegCylArr.Text = "";
            cbCarRegAsp.Text = "";
            nudCarRegPower.Value = 0;
            nudCarRegTorque.Value = 0;
            cbCarRegDisp.Text = "válasszon";
            cbCarRegGearboxType.Text = "válasszon";
            cbCarRegGearsNum.Text = "";
            cbCarRegDrivetrain.Text = "";
            nudCarRegAcc100.Value = 0;
            nudCarRegAcc200.Value = 0;
            nudCarRegVmax.Value = 0;
            nudCarRegConsmp.Value = 0;
            cbCarRegProdStart.Text = "";
            cbCarRegProdEnd.Text = "";
            nudCarRegBatCap.Value = 0;
            nudCarRegRange.Value = 0;
        }

        private void bnClearFieldsCarSearch_Click(object sender, EventArgs e)
        {
            cbCarSearchMake.Text = "válasszon";
            cbCarSearchModel.DataSource = null;
        }

        //KERESŐ ABLAK adatok törlése metódus:
        private void clearData()
        {
            tbCarSearchCategory.Clear();
            tbCarSearchMake.Clear();
            tbCarSearchModel.Clear();
            tbCarSearchCode.Clear();
            tbCarSearchBody.Clear();
            tbCarSearchFuel.Clear(); ;
            tbCarSearchCyl.Clear();
            tbCarSearchCylArr.Clear();
            tbCarSearchAsp.Clear();
            tbCarSearchPower.Clear();
            nudCarRegTorque.ResetText();
            tbCarSearchDisp.Clear();
            tbCarSearchGearboxType.Clear();
            tbCarSearchGears.Clear();
            tbCarSearchDrivetrain.Clear();
            tbCarSearchAcc100.Clear();
            tbCarSearchAcc200.Clear();
            tbCarSearchVmax.Clear();
            tbCarSearchfuelConsmp.Clear();
            tbCarSearchProdStart.Clear();
            tbCarSearchProdEnd.Clear();
            tbCarSearchBatCap.Clear();
            tbCarSearchFuelRange.Clear();
        }

        //KATTINTÁS esemény a datagrid-be:
        private void CarSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCarSearch.Rows[e.RowIndex];

                tbCarSearchCategory.Text = row.Cells[1].Value.ToString();
                tbCarSearchMake.Text = row.Cells[2].Value.ToString();
                tbCarSearchModel.Text = row.Cells[3].Value.ToString();
                tbCarSearchCode.Text = row.Cells[4].Value.ToString();
                tbCarSearchBody.Text = row.Cells[5].Value.ToString();
                tbCarSearchFuel.Text = row.Cells[6].Value.ToString();
                tbCarSearchCyl.Text = row.Cells[7].Value.ToString();
                tbCarSearchCylArr.Text = row.Cells[8].Value.ToString();
                tbCarSearchAsp.Text = row.Cells[9].Value.ToString();
                tbCarSearchPower.Text = row.Cells[10].Value.ToString();
                tbCarSearchTorque.Text = row.Cells[11].Value.ToString();
                tbCarSearchDisp.Text = row.Cells[12].Value.ToString();
                tbCarSearchGearboxType.Text = row.Cells[13].Value.ToString();
                tbCarSearchGears.Text = row.Cells[14].Value.ToString();
                tbCarSearchDrivetrain.Text = row.Cells[15].Value.ToString();
                tbCarSearchAcc100.Text = row.Cells[16].Value.ToString();
                tbCarSearchAcc200.Text = row.Cells[17].Value.ToString();
                tbCarSearchVmax.Text = row.Cells[18].Value.ToString();
                tbCarSearchfuelConsmp.Text = row.Cells[19].Value.ToString();
                tbCarSearchProdStart.Text = row.Cells[20].Value.ToString();
                tbCarSearchProdEnd.Text = row.Cells[21].Value.ToString();
                tbCarSearchBatCap.Text = row.Cells[22].Value.ToString();
                tbCarSearchFuelRange.Text = row.Cells[23].Value.ToString();
            }
        }

        //BEZÁRÁS GOMB click esemény:
        private void bnCloseWindow_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Confirm a = new Confirm();
            dr = a.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                this.Close();
                con.Close();
            }
            else if (dr == DialogResult.No)
            {
                a.Dispose();
            }
        }
    }
}
