using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_ACCOMODATION_SYSTEM
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Emmanuel" && txtPassword.Text == "Kendagor26")
            {
                labelError.Visible = false;
                dashBoard ds = new dashBoard();
                this.Hide();
                ds.Show();

            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();

            }
        }
    }
}
