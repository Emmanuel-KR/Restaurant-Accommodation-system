using System;
using System.Windows.Forms;

namespace RESTAURANT_ACCOMODATION_SYSTEM
{
    public partial class dashBoard : Form
    {
        public dashBoard()
        {
            InitializeComponent();
        }
        

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAddRoom.Left + 20;
            RoomsDetails rd = new RoomsDetails();
            rd.Show();
            this.Hide();
        }

        private void btnCustomerRegs_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRegs.Left + 20;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCheckout.Left + 20;
        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerDetails.Left + 20;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnEmployee.Left + 20;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dashBoard_Load(object sender, EventArgs e)
        {
            btnAddRoom.PerformClick();
        }
    }
}
