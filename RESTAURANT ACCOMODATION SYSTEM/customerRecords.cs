using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RESTAURANT_ACCOMODATION_SYSTEM
{
    public partial class customerRecords : Form
    {
        public customerRecords()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="D:\FOURTH\4TH\PROJECT\RESTAURANT ACCOMODATION SYSTEM\RESTAURANT ACCOMODATION SYSTEM\roomsDetails.mdf";Integrated Security=True;Connect Timeout=30");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void customerRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomsDetailsDataSet1.registrationsTb' table. You can move, or remove it, as needed.
            this.registrationsTbTableAdapter.Fill(this.roomsDetailsDataSet1.registrationsTb);
            // TODO: This line of code loads data into the 'customerRgistrationDataSet.registrationTB' table. You can move, or remove it, as needed.
            this.registrationTBTableAdapter.Fill(this.customerRgistrationDataSet.registrationTB);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    String query = "insert into CustomerTb1 values(" + CustId.Text + " , '" + CustName.Text + "' , '" + CustAdd.Text + "', '" + phone.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Successfully Added");
                    Con.Close();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
    }
    }
}
