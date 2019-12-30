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
using System.Data.SqlClient;

namespace autoDATA
{
    public partial class carDataBase : Form
    {
        String connectionstring;
        MySqlConnection con;
        public string query = "";

        public carDataBase(string user)
        {
            InitializeComponent();
            label6.Text = user;
        }

        //Form LOAD esemény:
        private void carDataBase_Load(object sender, EventArgs e)
        {
            label6.Visible = false;    
            textBox1.Visible = false;

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
            bodylist.Add("sport");
            cbCarRegBody.DataSource = bodylist;
            
            //meg kell tudni h ki van belogolva és hogy milyen id tartozik a userhez, mert kell az autó rögzítéshez:
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {                
                query = "SELECT id FROM users WHERE username = '" + label6.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, con);
                textBox1.Text = cmd.ExecuteScalar().ToString();         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //MYSQL adatbázis kapcsolat metódus:
        private void databaseConnect()
        {
            try
            {
                //connectionstring = "datasource = localhost; DataBase = auto_data; username = root; password = ; charset = utf8";

                connectionstring = "datasource = 94.76.215.115; DataBase = petersze_autodata; username = petersze_petersze; password = Rmbg5780Ar; charset = utf8";

                using (con = new MySqlConnection(connectionstring))
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
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

        //AUTÓMÁRKÁK betöltése adatbázisból:
        private void loadCarMakesForCarSearch()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            query = "SELECT * FROM carmakes";

            try
            {
                DataTable mytable = new DataTable();
                MySqlCommand search = new MySqlCommand(query, con);
                MySqlDataReader open = search.ExecuteReader();
                mytable.Load(open);
                cbCarSearchMake.DisplayMember = "makes";
                cbCarSearchMake.DataSource = mytable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void loadCarMakesForCarReg()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            query = "SELECT * FROM carmakes";

            try
            {
                DataTable mytable = new DataTable();
                MySqlCommand search = new MySqlCommand(query, con);
                MySqlDataReader open = search.ExecuteReader();
                mytable.Load(open);
                cbCarRegMake.DisplayMember = "makes";
                cbCarRegMake.DataSource = mytable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        //AUTÓMODELLEK metódusa PARAMÉTERREL adatbázisból:
        private void loadCarmodelsforCarSearch(string make)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                query = "SELECT model FROM " + @make;
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@make", make));
                MySqlDataReader open = cmd.ExecuteReader();
                DataTable mytable = new DataTable();
                mytable.Load(open);
                cbCarSearchModel.DisplayMember = "model";
                cbCarSearchModel.DataSource = mytable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void loadCarmodelsforCarReg(string make)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            try
            {
                query = "SELECT model FROM " + @make;
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@make", make));
                MySqlDataReader open = cmd.ExecuteReader();
                DataTable mytable = new DataTable();
                mytable.Load(open);
                cbCarRegModel.DisplayMember = "model";
                cbCarRegModel.DataSource = mytable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }        

        //ha egy MÁRKA ki lett választva, akkor csak ezeket a MODELLEKET mutassa (textchanged események):
        //SWITCH CASE elágazásokkal:
        private void cbCarSearchMake_TextChanged(object sender, EventArgs e)
        {
            switch (cbCarSearchMake.Text)
            {
                case "Alfa Romeo":
                    loadCarmodelsforCarSearch("alfaromeo");
                    break;
                case "Alpina":
                    loadCarmodelsforCarSearch("alpina");
                    break;
                case "Aston Martin":
                    loadCarmodelsforCarSearch("astonmartin");
                    break;
                case "Audi":
                    loadCarmodelsforCarSearch("audi");
                    break;
                case "Bentley":
                    loadCarmodelsforCarSearch("bentley");
                    break;
                case "BMW":
                    loadCarmodelsforCarSearch("bmw");
                    break;
                case "Bugatti":
                    loadCarmodelsforCarSearch("bugatti");
                    break;
                case "Citroen":
                    loadCarmodelsforCarSearch("citroen");
                    break;
                case "Dacia":
                    loadCarmodelsforCarSearch("dacia");
                    break;
                case "Ferrari":
                    loadCarmodelsforCarSearch("ferrari+");
                    break;
                case "Fiat":
                    loadCarmodelsforCarSearch("fiat");
                    break;
                case "Ford":
                    loadCarmodelsforCarSearch("ford");
                    break;
                case "Honda":
                    loadCarmodelsforCarSearch("honda");
                    break;
                case "Hyundai":
                    loadCarmodelsforCarSearch("hyundai");
                    break;
                case "Jaguar":
                    loadCarmodelsforCarSearch("jaguar");
                    break;
                case "Jeep":
                    loadCarmodelsforCarSearch("jeep");
                    break;
                case "Kia":
                    loadCarmodelsforCarSearch("kia");
                    break;
                case "Lada":
                    loadCarmodelsforCarSearch("lada");
                    break;
                case "Lamborghini":
                    loadCarmodelsforCarSearch("lamborghini");
                    break;
                case "Lancia":
                    loadCarmodelsforCarSearch("lancia");
                    break;
                case "Land Rover":
                    loadCarmodelsforCarSearch("landrover");
                    break;
                case "Lexus":
                    loadCarmodelsforCarSearch("lexus");
                    break;
                case "Mazda":
                    loadCarmodelsforCarSearch("mazda");
                    break;
                case "Mercedes-Benz":
                    loadCarmodelsforCarSearch("mercedesbenz");
                    break;
                case "Mercedes-AMG":
                    loadCarmodelsforCarSearch("mercedesamg");
                    break;
                case "Mini":
                    loadCarmodelsforCarSearch("mini");
                    break;
                case "Mitsubishi":
                    loadCarmodelsforCarSearch("mitsubishi");
                    break;
                case "Nissan":
                    loadCarmodelsforCarSearch("nissan");
                    break;
                case "Opel":
                    loadCarmodelsforCarSearch("opel");
                    break;
                case "Peugeot":
                    loadCarmodelsforCarSearch("peugeot");
                    break;
                case "Porsche":
                    loadCarmodelsforCarSearch("porsche");
                    break;
                case "Renault":
                    loadCarmodelsforCarSearch("renault");
                    break;
                case "Rolls-Royce":
                    loadCarmodelsforCarSearch("rollsroyce");
                    break;
                case "Saab":
                    loadCarmodelsforCarSearch("saab");
                    break;
                case "SEAT":
                    loadCarmodelsforCarSearch("seat");
                    break;
                case "Skoda":
                    loadCarmodelsforCarSearch("skoda");
                    break;
                case "Smart":
                    loadCarmodelsforCarSearch("smart");
                    break;
                case "Ssangyong":
                    loadCarmodelsforCarSearch("ssangyong");
                    break;
                case "Subaru":
                    loadCarmodelsforCarSearch("subaru");
                    break;
                case "Suzuki":
                    loadCarmodelsforCarSearch("suzuki");
                    break;
                case "Tesla":
                    loadCarmodelsforCarSearch("tesla");
                    break;
                case "Toyota":
                    loadCarmodelsforCarSearch("toyota");
                    break;
                case "Volkswagen":
                    loadCarmodelsforCarSearch("volkswagen");
                    break;
                case "Volvo":
                    loadCarmodelsforCarSearch("volvo");
                    break;
            }
        }
               
        private void cbCarRegMake_TextChanged(object sender, EventArgs e)
        {           
            switch (cbCarRegMake.Text)
            {
                case "Alfa Romeo":
                    loadCarmodelsforCarReg("alfaromeo");
                    break;
                case "Alpina":
                    loadCarmodelsforCarReg("alpina");
                    break;
                case "Aston Martin":
                    loadCarmodelsforCarReg("astonmartin");
                    break;
                case "Audi":
                    loadCarmodelsforCarReg("audi");
                    break;
                case "Bentley":
                    loadCarmodelsforCarReg("bentley");
                    break;
                case "BMW":
                    loadCarmodelsforCarReg("bmw");
                    break;
                case "Bugatti":
                    loadCarmodelsforCarReg("bugatti");
                    break;
                case "Citroen":
                    loadCarmodelsforCarReg("citroen");
                    break;
                case "Dacia":
                    loadCarmodelsforCarReg("dacia");
                    break;
                case "Ferrari":
                    loadCarmodelsforCarReg("ferrari+");
                    break;
                case "Fiat":
                    loadCarmodelsforCarReg("fiat");
                    break;
                case "Ford":
                    loadCarmodelsforCarReg("ford");
                    break;
                case "Honda":
                    loadCarmodelsforCarReg("honda");
                    break;
                case "Hyundai":
                    loadCarmodelsforCarReg("hyundai");
                    break;
                case "Jaguar":
                    loadCarmodelsforCarReg("jaguar");
                    break;
                case "Jeep":
                    loadCarmodelsforCarReg("jeep");
                    break;
                case "Kia":
                    loadCarmodelsforCarReg("kia");
                    break;
                case "Lada":
                    loadCarmodelsforCarReg("lada");
                    break;
                case "Lamborghini":
                    loadCarmodelsforCarReg("lamborghini");
                    break;
                case "Lancia":
                    loadCarmodelsforCarReg("lancia");
                    break;
                case "Land Rover":
                    loadCarmodelsforCarReg("landrover");
                    break;
                case "Lexus":
                    loadCarmodelsforCarReg("lexus");
                    break;
                case "Mazda":
                    loadCarmodelsforCarReg("mazda");
                    break;
                case "Mercedes-Benz":
                    loadCarmodelsforCarReg("mercedesbenz");
                    break;
                case "Mercedes-AMG":
                    loadCarmodelsforCarReg("mercedesamg");
                    break;
                case "Mini":
                    loadCarmodelsforCarReg("mini");
                    break;
                case "Mitsubishi":
                    loadCarmodelsforCarReg("mitsubishi");
                    break;
                case "Nissan":
                    loadCarmodelsforCarReg("nissan");
                    break;
                case "Opel":
                    loadCarmodelsforCarReg("opel");
                    break;
                case "Peugeot":
                    loadCarmodelsforCarReg("peugeot");
                    break;
                case "Porsche":
                    loadCarmodelsforCarReg("porsche");
                    break;
                case "Renault":
                    loadCarmodelsforCarReg("renault");
                    break;
                case "Rolls-Royce":
                    loadCarmodelsforCarReg("rollsroyce");
                    break;
                case "Saab":
                    loadCarmodelsforCarReg("saab");
                    break;
                case "SEAT":
                    loadCarmodelsforCarReg("seat");
                    break;
                case "Skoda":
                    loadCarmodelsforCarReg("skoda");
                    break;
                case "Smart":
                    loadCarmodelsforCarReg("smart");
                    break;
                case "Ssangyong":
                    loadCarmodelsforCarReg("ssangyong");
                    break;
                case "Subaru":
                    loadCarmodelsforCarReg("subaru");
                    break;
                case "Suzuki":
                    loadCarmodelsforCarReg("suzuki");
                    break;
                case "Tesla":
                    loadCarmodelsforCarReg("tesla");
                    break;
                case "Toyota":
                    loadCarmodelsforCarReg("toyota");
                    break;
                case "Volkswagen":
                    loadCarmodelsforCarReg("volkswagen");
                    break;
                case "Volvo":
                    loadCarmodelsforCarReg("volvo");
                    break;
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
                query = "SELECT id AS 'ID', category AS 'KATEGÓRIA', make AS 'MÁRKA', model AS 'MODELL', code AS 'GYÁRI KÓD', body AS 'KAROSSZÉRIA', fuel_type AS 'ÜZEMANYAG', cylinder_number AS 'HENGERSZÁM', cylinder_arrangement AS 'HENGERELRENDEZÉS', aspiration AS 'FELTÖLTÉS', power AS 'TELJESÍTMÉNY', torque AS 'NYOMATÉK', displacement AS 'HENGERŰRTARTALOM', gearbox_type AS 'SEBESSÉGVÁLTÓ', gears AS 'FOKOZATOK', powertrain AS 'HAJTÁS', acceleration100 AS '0-100', acceleration200 AS '0-200', vmax AS 'VÉGSEBESSÉG', consumption AS 'FOGYASZTÁS', production_start AS 'GYÁRTÁS KEZDETE', production_end AS 'GYÁRTÁS VÉGE', bat_capacity AS 'AKKU', fuel_range AS 'HATÓTÁV' FROM cars";

                loadCarSearchDataToTable(query);
            }

            else if (cbCarSearchMake.Text == "válasszon" && cbCarSearchModel.Text == "válasszon")
            {
                query = "SELECT id AS 'ID', category AS 'KATEGÓRIA', make AS 'MÁRKA', model AS 'MODELL', code AS 'GYÁRI KÓD', body AS 'KAROSSZÉRIA', fuel_type AS 'ÜZEMANYAG', cylinder_number AS 'HENGERSZÁM', cylinder_arrangement AS 'HENGERELRENDEZÉS', aspiration AS 'FELTÖLTÉS', power AS 'TELJESÍTMÉNY', torque AS 'NYOMATÉK', displacement AS 'HENGERŰRTARTALOM', gearbox_type AS 'SEBESSÉGVÁLTÓ', gears AS 'FOKOZATOK', powertrain AS 'HAJTÁS', acceleration100 AS '0-100', acceleration200 AS '0-200', vmax AS 'VÉGSEBESSÉG', consumption AS 'FOGYASZTÁS', production_start AS 'GYÁRTÁS KEZDETE', production_end AS 'GYÁRTÁS VÉGE', bat_capacity AS 'AKKU', fuel_range AS 'HATÓTÁV' FROM cars";

                loadCarSearchDataToTable(query);
            }

            //ha csak a márka van kiválasztva:
            else if (cbCarSearchMake.Text != "válasszon" && cbCarSearchModel.Text == "")
            {
                query = "SELECT id AS 'ID', category AS 'KATEGÓRIA', make AS 'MÁRKA', model AS 'MODELL', code AS 'GYÁRI KÓD', body AS 'KAROSSZÉRIA', fuel_type AS 'ÜZEMANYAG', cylinder_number AS 'HENGERSZÁM', cylinder_arrangement AS 'HENGERELRENDEZÉS', aspiration AS 'FELTÖLTÉS', power AS 'TELJESÍTMÉNY', torque AS 'NYOMATÉK', displacement AS 'HENGERŰRTARTALOM', gearbox_type AS 'SEBESSÉGVÁLTÓ', gears AS 'FOKOZATOK', powertrain AS 'HAJTÁS', acceleration100 AS '0-100', acceleration200 AS '0-200', vmax AS 'VÉGSEBESSÉG', consumption AS 'FOGYASZTÁS', production_start AS 'GYÁRTÁS KEZDETE', production_end AS 'GYÁRTÁS VÉGE', bat_capacity AS 'AKKU', fuel_range AS 'HATÓTÁV' FROM cars WHERE make = '" + cbCarSearchMake.Text + "'";

                loadCarSearchDataToTable(query);
            }

            else if (cbCarSearchMake.Text != "válasszon" && cbCarSearchModel.Text == "válasszon")
            {
                query = "SELECT id AS 'ID', category AS 'KATEGÓRIA', make AS 'MÁRKA', model AS 'MODELL', code AS 'GYÁRI KÓD', body AS 'KAROSSZÉRIA', fuel_type AS 'ÜZEMANYAG', cylinder_number AS 'HENGERSZÁM', cylinder_arrangement AS 'HENGERELRENDEZÉS', aspiration AS 'FELTÖLTÉS', power AS 'TELJESÍTMÉNY', torque AS 'NYOMATÉK', displacement AS 'HENGERŰRTARTALOM', gearbox_type AS 'SEBESSÉGVÁLTÓ', gears AS 'FOKOZATOK', powertrain AS 'HAJTÁS', acceleration100 AS '0-100', acceleration200 AS '0-200', vmax AS 'VÉGSEBESSÉG', consumption AS 'FOGYASZTÁS', production_start AS 'GYÁRTÁS KEZDETE', production_end AS 'GYÁRTÁS VÉGE', bat_capacity AS 'AKKU', fuel_range AS 'HATÓTÁV' FROM cars WHERE make = '" + cbCarSearchMake.Text + "'";

                loadCarSearchDataToTable(query);
            }

            //ha a márka és modell is ki van válaztva
            else if (cbCarSearchMake.Text != "válasszon" && cbCarSearchModel.Text != "")
            {
                query = "SELECT id AS 'ID', category AS 'KATEGÓRIA', make AS 'MÁRKA', model AS 'MODELL', code AS 'GYÁRI KÓD', body AS 'KAROSSZÉRIA', fuel_type AS 'ÜZEMANYAG', cylinder_number AS 'HENGERSZÁM', cylinder_arrangement AS 'HENGERELRENDEZÉS', aspiration AS 'FELTÖLTÉS', power AS 'TELJESÍTMÉNY', torque AS 'NYOMATÉK', displacement AS 'HENGERŰRTARTALOM', gearbox_type AS 'SEBESSÉGVÁLTÓ', gears AS 'FOKOZATOK', powertrain AS 'HAJTÁS', acceleration100 AS '0-100', acceleration200 AS '0-200', vmax AS 'VÉGSEBESSÉG', consumption AS 'FOGYASZTÁS', production_start AS 'GYÁRTÁS KEZDETE', production_end AS 'GYÁRTÁS VÉGE', bat_capacity AS 'AKKU', fuel_range AS 'HATÓTÁV' FROM cars WHERE make = '" + cbCarSearchMake.Text + "' AND model = '" + cbCarSearchModel.Text + "'";

                loadCarSearchDataToTable(query);
            }

            else if (cbCarSearchMake.Text != "válasszon" && cbCarSearchModel.Text != "válasszon")
            {
                query = "SELECT id AS 'ID', category AS 'KATEGÓRIA', make AS 'MÁRKA', model AS 'MODELL', code AS 'GYÁRI KÓD', body AS 'KAROSSZÉRIA', fuel_type AS 'ÜZEMANYAG', cylinder_number AS 'HENGERSZÁM', cylinder_arrangement AS 'HENGERELRENDEZÉS', aspiration AS 'FELTÖLTÉS', power AS 'TELJESÍTMÉNY', torque AS 'NYOMATÉK', displacement AS 'HENGERŰRTARTALOM', gearbox_type AS 'SEBESSÉGVÁLTÓ', gears AS 'FOKOZATOK', powertrain AS 'HAJTÁS', acceleration100 AS '0-100', acceleration200 AS '0-200', vmax AS 'VÉGSEBESSÉG', consumption AS 'FOGYASZTÁS', production_start AS 'GYÁRTÁS KEZDETE', production_end AS 'GYÁRTÁS VÉGE', bat_capacity AS 'AKKU', fuel_range AS 'HATÓTÁV' FROM cars WHERE make = '" + cbCarSearchMake.Text + "' AND model = '" + cbCarSearchModel.Text + "'";

                loadCarSearchDataToTable(query);
            }
            
        }

        //ADATOK BETÖLTÉSE TÁBLÁBA metódusok:
        private void loadCarSearchDataToTable(string query)
        {
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

        private void loadCarRegDataToTable(string query)
        {
            try
            {                
                DataTable mytable = new DataTable();
                MySqlCommand search = new MySqlCommand(query, con);
                MySqlDataReader open = search.ExecuteReader();
                mytable.Load(open);
                if (mytable.Rows.Count > 0)
                {
                    dgvCarReg.DataSource = mytable;
                }
                else
                {
                    dgvCarReg.DataSource = mytable;
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
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }           

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
                    "'"+textBox1.Text+"')";

                string query = "SELECT id AS 'ID', category AS 'KATEGÓRIA', make AS 'MÁRKA', model AS 'MODELL', code AS 'GYÁRI KÓD', body AS 'KAROSSZÉRIA', fuel_type AS 'ÜZEMANYAG', cylinder_number AS 'HENGERSZÁM', cylinder_arrangement AS 'HENGERELRENDEZÉS', aspiration AS 'FELTÖLTÉS', power AS 'TELJESÍTMÉNY', torque AS 'NYOMATÉK', displacement AS 'HENGERŰRTARTALOM', gearbox_type AS 'SEBESSÉGVÁLTÓ', gears AS 'FOKOZATOK', powertrain AS 'HAJTÁS', acceleration100 AS '0-100', acceleration200 AS '0-200', vmax AS 'VÉGSEBESSÉG', consumption AS 'FOGYASZTÁS', production_start AS 'GYÁRTÁS KEZDETE', production_end AS 'GYÁRTÁS VÉGE', bat_capacity AS 'AKKU', fuel_range AS 'HATÓTÁV' FROM cars";

                try
                {
                    MySqlCommand insert = new MySqlCommand(insertQuery, con);
                    if (insert.ExecuteNonQuery() == 1)
                    {
                        loadCarRegDataToTable(query);
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
            cbCarRegCylArr.Text = "válasszon";
            cbCarRegAsp.Text = "válasszon";
            nudCarRegPower.Value = 0;
            nudCarRegTorque.Value = 0;
            cbCarRegDisp.Text = "válasszon";
            cbCarRegGearboxType.Text = "válasszon";
            cbCarRegGearsNum.Text = "válasszon";
            cbCarRegDrivetrain.Text = "válasszon";
            nudCarRegAcc100.Value = 0;
            nudCarRegAcc200.Value = 0;
            nudCarRegVmax.Value = 0;
            nudCarRegConsmp.Value = 0;
            cbCarRegProdStart.Text = "válasszon";
            cbCarRegProdEnd.Text = "válasszon";
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

        //ADATOK EXPORTÁLÁSA gomb:
        private void bnExportData_Click(object sender, EventArgs e)
        {
            if (dgvCarSearch.Rows.Count == 0)
            {
                MessageBox.Show("Az adattábla üres");
            }
            else
            {
                copyAlltoClipboard();
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;
                xlexcel = new Microsoft.Office.Interop.Excel.Application();
                xlexcel.Visible = true;
                xlWorkBook = xlexcel.Workbooks.Add(misValue);
                xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            }
        }

        private void copyAlltoClipboard()
        {
            //a datagridview ClipboardCopyMode property-jét át kell először állítani: EnableAlwaysIncludeHeaderText-re
            dgvCarSearch.SelectAll();
            DataObject dataObj = dgvCarSearch.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
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
            Confirm a = new Confirm("Biztos be akarja zárni az Autó adatbázist?");
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
