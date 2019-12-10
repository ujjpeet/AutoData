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
        public Converters()
        {
            InitializeComponent();
        }

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

        private void Converters_Load(object sender, EventArgs e)
        {
            tbLE.Text = "Lóerő";
            tbLE.ForeColor = Color.Gray;

            tbPS.Text = "PS";
            tbPS.ForeColor = Color.Gray;

            tbHP.Text = "HP";
            tbHP.ForeColor = Color.Gray;

            tbBHP.Text = "BHP";
            tbBHP.ForeColor = Color.Gray;

            tbkw.Text = "kw";
            tbkw.ForeColor = Color.Gray;

            tbKMH.Text = "km/h";
            tbKMH.ForeColor = Color.Gray;

            tbMPH.Text = "mph";
            tbMPH.ForeColor = Color.Gray;

            tbMS.Text = "m/s";
            tbMS.ForeColor = Color.Gray;
        }      

        private void tbLE_Enter(object sender, EventArgs e)
        {
            if (tbLE.Text == "Lóerő")
            {
                tbLE.Text = "";
            }
        }

        private void tbLE_Leave(object sender, EventArgs e)
        {
            if (tbLE.Text == "")
            {
                tbLE.Text = "Lóerő";
            }
        }

        private void tbLE_TextChanged(object sender, EventArgs e)
        {
            if (tbLE.Text == "Lóerő")
            {
                tbLE.ForeColor = Color.Gray;
            }
            else
            {
                tbLE.ForeColor = Color.Black;
            }
        }

        private void tbPS_Enter(object sender, EventArgs e)
        {
            if (tbPS.Text == "PS")
            {
                tbPS.Text = "";
            }
        }

        private void tbPS_Leave(object sender, EventArgs e)
        {
            if (tbPS.Text == "")
            {
                tbPS.Text = "PS";
            }
        }

        private void tbPS_TextChanged(object sender, EventArgs e)
        {
            if (tbPS.Text == "PS")
            {
                tbPS.ForeColor = Color.Gray;
            }
            else
            {
                tbPS.ForeColor = Color.Black;
            }
        }     

        private void tbHP_Enter(object sender, EventArgs e)
        {
            if (tbHP.Text == "HP")
            {
                tbHP.Text = "";
            }
        }

        private void tbHP_Leave(object sender, EventArgs e)
        {
            if (tbHP.Text == "")
            {
                tbHP.Text = "HP";
            }
        }

        private void tbHP_TextChanged(object sender, EventArgs e)
        {
            if (tbHP.Text == "HP")
            {
                tbHP.ForeColor = Color.Gray;
            }
            else
            {
                tbHP.ForeColor = Color.Black;
            }
        }      

        private void tbBHP_Enter(object sender, EventArgs e)
        {
            if (tbBHP.Text == "BHP")
            {
                tbBHP.Text = "";
            }
        }

        private void tbBHP_Leave(object sender, EventArgs e)
        {
            if (tbBHP.Text == "")
            {
                tbBHP.Text = "BHP";
            }
        }

        private void tbBHP_TextChanged(object sender, EventArgs e)
        {
            if (tbBHP.Text == "BHP")
            {
                tbBHP.ForeColor = Color.Gray;
            }
            else
            {
                tbBHP.ForeColor = Color.Black;
            }
        }

        private void tbkw_Enter(object sender, EventArgs e)
        {
            if (tbkw.Text == "kw")
            {
                tbkw.Text = "";
            }
        }

        private void tbkw_Leave(object sender, EventArgs e)
        {
            if (tbkw.Text == "")
            {
                tbkw.Text = "kw";
            }
        }

        private void tbkw_TextChanged(object sender, EventArgs e)
        {
            if (tbkw.Text == "kw")
            {
                tbkw.ForeColor = Color.Gray;
            }
            else
            {
                tbkw.ForeColor = Color.Black;
            }
        }

        private void tbKMH_Enter(object sender, EventArgs e)
        {
            if (tbKMH.Text == "km/h")
            {
                tbKMH.Text = "";
            }
        }

        private void tbKMH_Leave(object sender, EventArgs e)
        {
            if (tbKMH.Text == "")
            {
                tbKMH.Text = "km/h";
            }
        }

        private void tbKMH_TextChanged(object sender, EventArgs e)
        {
            if (tbKMH.Text == "km/h")
            {
                tbKMH.ForeColor = Color.Gray;
            }
            else
            {
                tbKMH.ForeColor = Color.Black;
            }
        }

        private void tbMPH_Enter(object sender, EventArgs e)
        {
            if (tbMPH.Text == "mph")
            {
                tbMPH.Text = "";
            }

        }

        private void tbMPH_Leave(object sender, EventArgs e)
        {
            if (tbMPH.Text == "")
            {
                tbMPH.Text = "mph";
            }
        }    

        private void tbMPH_TextChanged(object sender, EventArgs e)
        {
            if (tbMPH.Text == "mph")
            {
                tbMPH.ForeColor = Color.Gray;
            }
            else
            {
                tbMPH.ForeColor = Color.Black;
            }
        }

        private void tbMS_Enter(object sender, EventArgs e)
        {
            if (tbMS.Text == "m/s")
            {
                tbMS.Text = "";
            }
        }

        private void tbMS_Leave(object sender, EventArgs e)
        {
            if (tbMS.Text == "")
            {
                tbMS.Text = "m/s";
            }
        }

        private void tbMS_TextChanged(object sender, EventArgs e)
        {
            if (tbMS.Text == "m/s")
            {
                tbMS.ForeColor = Color.Gray;
            }
            else
            {
                tbMS.ForeColor = Color.Black;
            }
        }
    }    
}