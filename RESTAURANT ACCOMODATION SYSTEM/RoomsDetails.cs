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
    public partial class RoomsDetails : Form
        
    {
        public RoomsDetails()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Emmanue\Documents\roomsDetails.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RoomsDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roomsDetailsDataSet.roomsDetails' table. You can move, or remove it, as needed.
            this.roomsDetailsTableAdapter.Fill(this.roomsDetailsDataSet.roomsDetails);
            // TODO: This line of code loads data into the 'accomodationsdbDataSet1.roomtb' table. You can move, or remove it, as needed.
            
            dataGridView1.DataSource = roomsDetailsDataSet;
            

        }

        private void AddRoombtn_Click(object sender, EventArgs e)
        {
            if (txtRoom.Text == "" || comboRoom.Text == "" || comboBed.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Fill all the fields");
               
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into roomsDetails values(" + txtRoom.Text + ", '" + comboRoom.Text + "', '" + comboBed.Text + "', '" + txtPrice.Text + "' )";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Room successfully Added");
                    conn.Close();

                }
                catch(Exception myex)
                {
                    MessageBox.Show(myex.Message);
                }
            }
        }
    }
}
