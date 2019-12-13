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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        //FORM LOAD esemény:
        private void Form1_Load(object sender, EventArgs e)
        {
           bnAdmin.Enabled = false;
           bnSettings.Enabled = false;
           bnConverters.Enabled = false;
           bnDatabase.Enabled = false;
           bnLogout.Enabled = false;
           bnLogin.Enabled = true;
        }     

        //KONVERTÁLÓK GOMB click esemény:
        private void bnConverters_Click(object sender, EventArgs e)
        {
            Converters myconverter = new Converters();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Konvertálók")
                {
                    IsOpen = true;
                    myconverter.BringToFront();
                    myconverter.Activate();
                }
            }
            if (IsOpen == false)
            {
                myconverter = new Converters();
               
                myconverter.Show();
                myconverter.BringToFront();
                myconverter.Activate();
            }
        }

        //AUTÓ ADATBÁZIS GOMB click esemény:
        private void bnDatabase_Click(object sender, EventArgs e)
        {
            carDataBase mycardatabasemain = new carDataBase(lbLoggedInAs.Text);
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Autó adatbázis")
                {
                    IsOpen = true;
                    mycardatabasemain.BringToFront();
                    mycardatabasemain.Activate();
                }
            }
            if (IsOpen == false)
            {
                mycardatabasemain = new carDataBase(lbLoggedInAs.Text);

                mycardatabasemain.Show();
                mycardatabasemain.BringToFront();
                mycardatabasemain.Activate();
            }
        }

        //BEÁLLÍTÁSOK GOMB click esemény:
        private void bnSettings_Click(object sender, EventArgs e)
        { 
            //hogy ki van belépve, paraméterként átadva a Settings form konstruktorának:
            Settings mysettings = new Settings(lbLoggedInAs.Text);           

            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Beállítások")
                {                      
                    IsOpen = true;
                    mysettings.BringToFront();
                    mysettings.Activate();
                }
            }
            if (IsOpen == false)
            {
                mysettings = new Settings(lbLoggedInAs.Text);
                mysettings.Show();
                mysettings.BringToFront();
                mysettings.Activate();
            }
        }

        //ADMIN GOMB click esemény:
        private void bnAdmin_Click(object sender, EventArgs e)
        {
            Admin myadmin = new Admin();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Adminisztrátori felület")
                {
                    IsOpen = true;
                    myadmin.BringToFront();
                    myadmin.Activate();
                }
            }
            if (IsOpen == false)
            {
                myadmin = new Admin();
                myadmin.Show();
                myadmin.BringToFront();
                myadmin.Activate();
            }
        }

        //BELÉPÉS GOMB click esemény:
        private void bnLogin_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Login a = new Login();
            dr = a.ShowDialog();
            if (dr == DialogResult.OK)
            {                
                bnSettings.Enabled = true;
                bnConverters.Enabled = true;
                bnDatabase.Enabled = true;
                bnLogout.Enabled = true;
                bnLogin.Enabled = false;

                lbLoggedInAs.Text = ((Login)a).tbUsername.Text;                

                if (lbLoggedInAs.Text == "admin")
                {
                    bnAdmin.Enabled = true;
                }
            }
            else
            {
                a.Dispose();
            }
        }      

        //PROGRAM BEZÁRÁSA GOMB click esemény:
        private void bnCloseProgram_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Confirm a = new Confirm();
            dr = a.ShowDialog();
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dr == DialogResult.No)
            {
                a.Dispose();
            }
        }

        //KILÉPÉS gomb esemény:
        private void bnLogout_Click(object sender, EventArgs e)
        {
            lbLoggedInAs.Text = "";
            bnAdmin.Enabled = false;
            bnSettings.Enabled = false;
            bnConverters.Enabled = false;
            bnDatabase.Enabled = false;
            bnLogout.Enabled = false;
            bnLogin.Enabled = true;
        }

        //ADMIN KONTAKT kattintás:
        private void lbAdminContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Küldjön egy emailt az ujjpetertamas@gmail.com emailcímre!");
        }
    }
}
