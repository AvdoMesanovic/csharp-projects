using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_10
{
    public class Flight
    {
        private int code;
        private DateTime departure;
        private string destination;
        private List<string> passengerList = new List<string>();

        public Flight() { }

        public Flight(int c, DateTime dep, string dest) 
        {
            c = code;
            dep = departure;
            dest = destination;
        }

        public int Code
        { get { return code; } set { code = value; } }

        public DateTime Departure
        { get { return departure; } set { departure = value; } }

        public string Destination
        { get { return destination; } set { destination = value; } }

        public List<string> PassengerList
        { get { return passengerList; } set { passengerList = value; } }
    }
}
