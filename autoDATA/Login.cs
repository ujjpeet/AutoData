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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bnLoginCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lbReg_Click(object sender, EventArgs e)
        {
            Registration myreg = new Registration();
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Regisztráció")
                {
                    IsOpen = true;
                    myreg.BringToFront();
                    myreg.Activate();
                }
            }
            if (IsOpen == false)
            {
                myreg = new Registration();

                myreg.Show();
                myreg.BringToFront();
                myreg.Activate();
            }
        }
    }
}
