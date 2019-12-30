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
    public partial class Converters : Form
    {
        public double loero;
        public double ps;
        public double hp;
        public double bhp;
        public double kw;
        public double kmh;
        public double mph;
        public double ms;

        public Converters()
        {
            InitializeComponent();
        }

        private void bnCloseWindow_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Confirm a = new Confirm("Be akarja zárni a Konvertáló ablakot?");
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

        private void bnLE_Click(object sender, EventArgs e)
        {
            loero = Convert.ToDouble(tbLE.Value);

            if (loero < 0 || loero > 99999)
            {
                MessageBox.Show("A lóerő 0 és 100 000 között lehet");
                tbLE.Value = 0;
            }
            else
            {
                ps = Math.Round(loero * 0.98592325737265);
                hp = loero;
                bhp = Math.Round(loero * 0.98632007061953);
                kw = Math.Round(loero * 0.73549875);
                try
                {
                    tbPS.Value = Convert.ToDecimal(ps);
                    tbHP.Value = Convert.ToDecimal(hp);
                    tbBHP.Value = Convert.ToDecimal(bhp);
                    tbkw.Value = Convert.ToDecimal(kw);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnPS_Click(object sender, EventArgs e)
        {
            ps = Convert.ToDouble(tbPS.Value);

            if (ps < 0 || ps > 99999)
            {
                MessageBox.Show("A PS 0 és 100 000 között lehet");
                tbPS.Value = 0;
            }
            else
            {
                loero = Math.Round(ps * 1.0142777265087);
                hp = Math.Round(ps * 1.0142777265087);
                bhp = Math.Round(ps * 1.01419878);
                kw = Math.Round(ps * 0.74626866);

                try
                {
                    tbLE.Value = Convert.ToDecimal(loero);
                    tbHP.Value = Convert.ToDecimal(hp);
                    tbBHP.Value = Convert.ToDecimal(bhp);
                    tbkw.Value = Convert.ToDecimal(kw);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnHP_Click(object sender, EventArgs e)
        {
            hp = Convert.ToDouble(tbHP.Value);

            if (hp < 0 || hp > 99999)
            {
                MessageBox.Show("A HP 0 és 100 000 között lehet");
                tbHP.Value = 0;
            }
            else
            {
                loero = hp;
                ps = Math.Round(hp * 0.98592325737265);
                bhp = Math.Round(hp * 0.98632007061953);
                kw = Math.Round(hp * 0.73549875);

                try
                {
                    tbPS.Value = Convert.ToDecimal(ps);
                    tbLE.Value = Convert.ToDecimal(loero);
                    tbBHP.Value = Convert.ToDecimal(bhp);
                    tbkw.Value = Convert.ToDecimal(kw);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnBHP_Click(object sender, EventArgs e)
        {
            bhp = Convert.ToDouble(tbBHP.Value);

            if (bhp < 0 || bhp > 99999)
            {
                MessageBox.Show("A BHP 0 és 100 000 között lehet");
                tbBHP.Value = 0;
            }
            else
            {
                loero = Math.Round(bhp * 1.013869665424);
                ps = Math.Round(bhp * 1.01010101);
                hp = Math.Round(bhp * 1.013869665424);
                kw = Math.Round(bhp * 0.74569987158227);

                try
                {
                    tbLE.Value = Convert.ToDecimal(loero);
                    tbPS.Value = Convert.ToDecimal(ps);
                    tbHP.Value = Convert.ToDecimal(hp);
                    tbkw.Value = Convert.ToDecimal(kw);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnKW_Click(object sender, EventArgs e)
        {
            kw = Convert.ToDouble(tbkw.Value);

            if (kw < 0 || kw > 99999)
            {
                MessageBox.Show("A KW 0 és 100 000 között lehet");
                tbkw.Value = 0;
            }
            else
            {
                loero = Math.Round(kw * 1.3596216173039);
                ps = Math.Round(kw * 1.34);
                hp = Math.Round(kw * 1.3596216173039);
                bhp = Math.Round(kw * 1.341022089595);

                try
                {
                    tbLE.Value = Convert.ToDecimal(loero);
                    tbPS.Value = Convert.ToDecimal(ps);
                    tbHP.Value = Convert.ToDecimal(hp);
                    tbBHP.Value = Convert.ToDecimal(bhp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnKMH_Click(object sender, EventArgs e)
        {
            kmh = Convert.ToDouble(tbKMH.Value);

            if (kmh < 0 || kmh > 9999)
            {
                MessageBox.Show("A KM/H 0 és 10 000 között lehet");
                tbKMH.Value = 0;
            }
            else
            {
                mph = Math.Round(kmh * 0.621371);
                ms = Math.Round(kmh * 0.277778);

                try
                {
                    tbMPH.Value = Convert.ToDecimal(mph);
                    tbMS.Value = Convert.ToDecimal(ms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnMPH_Click(object sender, EventArgs e)
        {
            mph = Convert.ToDouble(tbMPH.Value);

            if (mph < 0 || mph > 9999)
            {
                MessageBox.Show("Az MPH 0 és 10 000 között lehet");
                tbMPH.Value = 0;
            }
            else
            {
                kmh = Math.Round(mph * 1.6);
                ms = Math.Round(mph * 0.44704);

                try
                {
                    tbKMH.Value = Convert.ToDecimal(kmh);
                    tbMS.Value = Convert.ToDecimal(ms);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bnMS_Click(object sender, EventArgs e)
        {
            ms = Convert.ToDouble(tbMS.Value);

            if (ms < 0 || ms > 9999)
            {
                MessageBox.Show("A M/S 0 és 10 000 között lehet");
                tbMS.Value = 0;
            }
            else
            {
                kmh = Math.Round(ms * 3.6);
                mph = Math.Round(ms * 2.23694);

                try
                {
                    tbKMH.Value = Convert.ToDecimal(kmh);
                    tbMPH.Value = Convert.ToDecimal(mph);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //MEZŐK TÖRLÉSE gomb esemény:
        private void bnConvertersClearFields_Click(object sender, EventArgs e)
        {
            tbLE.Value = 0;
            tbPS.Value = 0;
            tbHP.Value = 0;
            tbBHP.Value = 0;
            tbkw.Value = 0;
            tbKMH.Value = 0;
            tbMPH.Value = 0;
            tbMS.Value = 0;
        }
    }    
}