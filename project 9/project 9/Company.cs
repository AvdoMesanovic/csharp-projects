using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_9
{
    public class Company
    {
        private string name;
        private List<Country> countryList = new List<Country>();

        public Company(string n)
        {
            name = n;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Country> CountryList
        {
            get { return countryList; }
            set { countryList = value; }
        }

        public int NumCountries
        {
            get
            {
                return countryList.Count;
            }
        }

        public void AddCountry(Country c)
        {
            countryList.Add(c);
        }

        public void RemoveCountry(Country c)
        {
            countryList.Remove(c);
        }

        public void SortCountries()
        {
            countryList.Sort();
        }

        public Country HighestPerSqMile(Country c)
        {
            c = countryList[0];
            for (int i = 1; i < countryList.Count; i++)
            {
                if (countryList[i] > c)
                {
                    c = countryList[i];
                }
            }
            return c;
        }

        public Country this[string s]
        {
            get
            {
                foreach (Country c in countryList)
                {
                    if (c.Name == s)
                    {
                        return c;
                    }
                }
                return null;
            }
        }

        public Country this[int i]
        {
            get
            {
                if (i < 0 || i >= countryList.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return countryList[i];

            }
        }
    }
}
