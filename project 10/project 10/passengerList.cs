using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_10
{
    public partial class frmPassengerList : Form
    {
        private Flight flight;

        public frmPassengerList(Flight f)
        {
            InitializeComponent();
            flight = f;
        }

        private void frmPassengerList_Load(object sender, EventArgs e)
        {
            string display = "";
            string passengers = "";

            foreach (string p in flight.PassengerList) 
            {
                passengers += p + Environment.NewLine;
            }

            display = "Departs on " + flight.Departure.ToShortDateString() + Environment.NewLine
                    + "Destination: " + flight.Destination + Environment.NewLine + Environment.NewLine
                    + "Passenger List: " + Environment.NewLine + passengers;

            txtFlightCode.Text = "Flight " + flight.Code.ToString();
            txtFlightDetails.Text = display;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
