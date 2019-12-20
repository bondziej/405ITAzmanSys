using System;
using AzmanSys.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzmanSys.Forms
{
    public partial class FlightAvailabilityForm : Form
        
    {
        FlightAvailabilityFormDbConn mysqlConn;
        public FlightAvailabilityForm()
        {
            InitializeComponent();
            mysqlConn = new FlightAvailabilityFormDbConn();
            mysqlConn.connect();



        }

        private void FlightAvailabilityForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DepatureTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchFlights_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {

                if (!string.IsNullOrEmpty(tbFromLocation.Text) && !string.IsNullOrEmpty(tbToLocation.Text))
                {
                    mysqlConn.searchFlights(DepartTimePicker.Text, ArrivalTimePicker.Text, tbFromLocation.Text, tbToLocation.Text);
                    ViewAvailableFlights.DataSource = mysqlConn.qry("SELECT * FROM tblflight").Tables[0];
                }
                
                else
                {
                    MessageBox.Show("Please Enter Value");
                }
                mysqlConn.connClose();

          
            }
        }

        private void SFormToMain_Click(object sender, EventArgs e)
        {
            Close();
            MainForm mForm = new MainForm();
            mForm.Show();
            
        }

        private void ViewAvailableFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
