using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_9
{
    public class Country : IComparable<Country>
    {
        private string name;
        private long population;
        private decimal size;

        public Country(string n)
        {
            name = n;
        }

        public Country(string n, long p, decimal d)
        {
            name = n;
            population = p;
            size = d;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long Population
        {
            get { return population; }
            set { population = value; }
        }

        public decimal Size
        {
            get { return size; }
            set { size = value; }
        }

        public int CompareTo(Country c) => Name.CompareTo(c.Name);

        public bool LessThan(Country c) 
        {
            if (c == null)
                return false;
            if (Decimal.Compare(Size, c.Size) < 0)
                return true;
            else 
                return false;
        }

        public static bool operator <(Country c1, Country c2)
        {
            if (Object.Equals(c1, null))
                if (Object.Equals(c2, null))
                    return true;
                else
                    return false;
            else
                return c1.LessThan(c2);
        }

        public bool GreaterThan(Country c)
        {
            if (c == null)
                return false;
            if (Decimal.Compare(Size, c.Size) > 0)
                return true;
            else
                return false;
        }

        public static bool operator >(Country c1, Country c2)
        {
            if (Object.Equals(c1, null))
                if (Object.Equals(c2, null))
                    return true;
                else
                    return false;
            else
                return c1.GreaterThan(c2);
        }
    }
}
