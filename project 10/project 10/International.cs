using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_10
{
    public class International : Flight
    {
        private bool food;

        public bool Food 
        { get { return food; } set { food = value; } }

        public International(int code, DateTime departure, string destination, bool food) 
        : base(code, departure, destination)
        {
            this.Code = code;
            this.Departure = departure;
            this.Destination = destination;
            this.Food = food;
        }
    }
}
