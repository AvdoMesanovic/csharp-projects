using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_10
{
    public class Airline
    {
        private string name;
        private List<Flight> flightList = new List<Flight>();

        public Airline(string n) 
        {
            name = n;
        }

        public string Name
        { get { return name; } set { name = value; } }

        public List<Flight> FlightList
        { get { return flightList; } set { flightList = value; } }
    }
}
