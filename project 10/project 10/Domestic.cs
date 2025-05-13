using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_10
{
    public class Domestic : Flight
    {
        private bool visa;

        public bool Visa
        { get { return visa; } set { visa = value; } }

        public Domestic(int code, DateTime departure, string destination, bool visa)
        : base(code, departure, destination)
        {
            this.Code = code;
            this.Departure = departure;
            this.Destination = destination;
            this.Visa = visa;
        }
    }
}
