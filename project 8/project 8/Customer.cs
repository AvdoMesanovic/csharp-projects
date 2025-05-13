using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_8
{
    public class Customer
    {
        private string name;
        private string travelClass;
        private string travelMonth;
        private string travelYear;
        private string destination;
        private double travelCost;
        private string medicalConcerns;

        public Customer(string n)
        {
            name = n;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            { 
                name = value; 
            }
        }

        public string TravelClass
        {
            get
            {
                return travelClass;
            }
            set
            {
                travelClass = value;
            }
        }

        public string TravelMonth
        {
            get
            {
                return travelMonth;
            }
            set
            {
                travelMonth = value;
            }
        }

        public string TravelYear
        {
            get
            {
                return travelYear;
            }
            set
            {
                travelYear = value;
            }
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public double TravelCost
        {
            get
            {
                return travelCost;
            }
            set
            {
                travelCost = value;
            }
        }

        public string MedicalConcerns
        {
            get
            {
                return medicalConcerns;
            }
            set
            {
                medicalConcerns = value;
            }
        }

        public void Display()
        {
            string display = "";

            display += name + "\n";
            display += "Medical concerns: " + medicalConcerns + "\n";
            display += travelClass + "\n";
            display += destination + ": " + travelCost.ToString("c") + "\n";
            display += travelMonth + "\n";
            display += travelYear + "\n";

            MessageBox.Show(display, "Customer Information");
        }
    }
}
