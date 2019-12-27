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
    public partial class Settings : Form
    {
       //paraméteres konstruktor:
        public Settings(string user)
        {
            InitializeComponent();
            label2.Text = user;
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
                        connectionstring = "datasource = localhost;  DataBase= auto_data; username = root; password =";

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
