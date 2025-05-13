using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace project_10
{
    public partial class frmAirlineFlights : Form
    {
        public frmAirlineFlights()
        {
            InitializeComponent();
        }

        Airline airline = new Airline("Avdo Air");

        Flight england = new International(765809, new DateTime(2022, 7, 25), "England", true);
        Flight thailand = new International(902410, new DateTime(2022, 5, 11), "Thailand", false);
        Flight ecuador = new International(359310, new DateTime(2022, 10, 29), "Ecuador", true);

        string[] englandNames = { "Dale", "Irena", "Nathan" };
        string[] thailandNames = { "Robert", "Fred", "Sylvia" };
        string[] ecuadorNames = { "Ashley", "Darian", "Lori" };

        Flight newYork = new Domestic(105670, new DateTime(2022, 4, 5), "New York", false);
        Flight missouri = new Domestic(591467, new DateTime(2022, 2, 15), "Missouri", true);
        Flight texas = new Domestic(632480, new DateTime(2022, 12, 30), "Texas", false);

        string[] newYorkNames = { "Dustin", "Collin", "Anna" };
        string[] missouriNames = { "PJ", "Nikki", "Dejan" };
        string[] texasNames = { "Porter", "Harry", "Margaret" };
        

        private void frmAirlineFlights_Load(object sender, EventArgs e)
        {
            txtAirlineName.Text = airline.Name;

            airline.FlightList.Add(england);
            airline.FlightList.Add(thailand);
            airline.FlightList.Add(ecuador);
            airline.FlightList.Add(newYork);
            airline.FlightList.Add(missouri);
            airline.FlightList.Add(texas);

            foreach (string name in englandNames)
            {
                airline.FlightList[0].PassengerList.Add(name);
            }

            foreach (string name in thailandNames)
            {
                airline.FlightList[1].PassengerList.Add(name);
            }

            foreach (string name in ecuadorNames)
            {
                airline.FlightList[2].PassengerList.Add(name);
            }

            foreach (string name in newYorkNames)
            {
                airline.FlightList[3].PassengerList.Add(name);
            }

            foreach (string name in missouriNames)
            {
                airline.FlightList[4].PassengerList.Add(name);
            }

            foreach (string name in texasNames)
            {
                airline.FlightList[5].PassengerList.Add(name);
            }
        }

        private void btnAddPassenger_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtAddName.Text) == true)
                {
                    throw new Exception("Please enter a name");
                }
                if (String.IsNullOrEmpty(txtAddFlightCode.Text) == true)
                {
                    throw new Exception("Please enter the flight code");
                }

                Flight chosen = new Flight();
                bool check = false;

                foreach (Flight f in airline.FlightList)
                {
                    if (f.Code.ToString() == txtAddFlightCode.Text)
                    {
                        chosen = f;
                        check = true;
                    }
                }

                if (check == false) 
                {
                    throw new Exception("That flight code does not match with any flights in our system");
                }

                chosen.PassengerList.Add(txtAddName.Text);
                MessageBox.Show("Successfully added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewPassengers_Click(object sender, EventArgs e)
        {
            try
            {
                Flight chosen = new Flight();
                bool check = false;

                foreach (Flight f in airline.FlightList)
                {
                    if (f.Code.ToString() == txtFlightCode.Text)
                    {
                        chosen = f;
                        check = true;
                    }
                }

                if (check == false)
                {
                    throw new Exception("That flight code does not match with any flights in our system");
                }

                Form newCountry = new frmPassengerList(chosen);
                newCountry.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewFlights_Click(object sender, EventArgs e)
        {
            string display = "";

            if (rdoAll.Checked == true)
            {
                foreach (Flight f in airline.FlightList)
                {
                    display += f.Code.ToString() + ", " + f.Destination + ", " + f.Departure.ToShortDateString() + ", ";
                    if (f.GetType() == typeof(International))
                    {
                        if (((International)f).Food == true)
                        {
                            display += "Food";
                        }
                        if (((International)f).Food == false)
                        {
                            display += "No food";
                        }
                    }
                    if (f.GetType() == typeof(Domestic))
                    {
                        if (((Domestic)f).Visa == true)
                        {
                            display += "Visa";
                        }
                        if (((Domestic)f).Visa == false)
                        {
                            display += "No Visa";
                        }
                    }
                    display += "\n";
                }
                MessageBox.Show(display, "All Flights");
            }

            if (rdoDomestic.Checked == true)
            {
                foreach (Flight f in airline.FlightList)
                {
                    if (f.GetType() == typeof(Domestic))
                    {
                        display += f.Code.ToString() + ", " + f.Destination + ", " + f.Departure.ToShortDateString() + ", ";
                        if (((Domestic)f).Visa == true)
                        {
                            display += "Visa";
                        }
                        if (((Domestic)f).Visa == false)
                        {
                            display += "No Visa";
                        }
                        display += "\n";
                    }
                }
                MessageBox.Show(display, "Domestic Flights");
            }

            if (rdoInternational.Checked == true)
            {
                foreach (Flight f in airline.FlightList)
                {
                    if (f.GetType() == typeof(International))
                    {
                        display += f.Code.ToString() + ", " + f.Destination + ", " + f.Departure.ToShortDateString() + ", ";
                        if (((International)f).Food == true)
                        {
                            display += "Food";
                        }
                        if (((International)f).Food == false)
                        {
                            display += "No food";
                        }
                        display += "\n";
                    }
                }
                MessageBox.Show(display, "International Flights");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}