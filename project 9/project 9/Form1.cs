using System.Diagnostics.Metrics;

namespace project_9
{
    public partial class frmCompanyCountryInfo : Form
    {
        public frmCompanyCountryInfo()
        {
            InitializeComponent();
        }

        Company company = new Company("Avdino Solutions");
        Country uk = new Country("United Kingdom", 67530172, 93410);
        Country thailand = new Country("Thailand", 69037513, 197260);
        Country china = new Country("China", 1433783686, 3600950);

        private void frmCompanyCountryInfo_Load(object sender, EventArgs e)
        {
            txtCompanyName.Text = company.Name;
            company.AddCountry(uk);
            company.AddCountry(thailand);
            company.AddCountry(china);
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            Form newCountry = new frmNewCountry();
            newCountry.ShowDialog();
            company.AddCountry((Country)newCountry.Tag);
        }

        private void btnRemoveCountry_Click(object sender, EventArgs e)
        {
            string nameCountry = txtRemoveName.Text;
            Country country = company[nameCountry];
            if (country == null)
            {
                MessageBox.Show("This Country is not affiliated with Avdino Solutions");
            }
            else
            {
                company.RemoveCountry(country);
                MessageBox.Show(country.Name + " has been removed", "Remove Country");
            }
            txtRemoveName.Clear();
        }

        private void btnLargest_Click(object sender, EventArgs e)
        {
            string display = "";

            Country largest = company.HighestPerSqMile(company.CountryList[0]);
            display = largest.Name + ", " + largest.Population.ToString() +
                          " people, " + largest.Size.ToString() + " sq mi " + "\n";

            MessageBox.Show(display, "Largest Country in Avdino Solutions");
        }

        private void btnViewInfo_Click(object sender, EventArgs e)
        {
            string nameCountry = txtViewInformation.Text;
            Country country = company[nameCountry];
            MessageBox.Show(country.Name + ", " + country.Population.ToString() +
                          " people, " + country.Size.ToString() + " sq mi ",
                          "Country Information");
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            string display = "";
            foreach (Country country in company.CountryList)
            {
                display += country.Name + ", " + country.Population.ToString() +
                          " people, " + country.Size.ToString() + " sq mi " + "\n";
            }
            MessageBox.Show(display, "All Countries Associated with Avdino Solutions");
        }

        private void btnNumberCountries_Click(object sender, EventArgs e)
        {
            MessageBox.Show(company.NumCountries.ToString(), "Number of Countries");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            company.SortCountries();
            string display = "";
            if (rdoName.Checked == true)
            {
                foreach (Country country in company.CountryList)
                {
                    display += country.Name + ", " + country.Population.ToString() +
                              " people, " + country.Size.ToString() + " sq mi " + Environment.NewLine;
                }
            }

            if (rdoPopulation.Checked == true)
            {
                foreach (Country country in company.CountryList)
                {
                    display += country.Population.ToString() + " people, " + country.Name +
                              ", " + country.Size.ToString() + " sq mi " + Environment.NewLine;                    
                }
            }

            if (rdoSize.Checked == true)
            {
                foreach (Country country in company.CountryList)
                {
                    display += country.Size.ToString() + " sq mi, " + country.Name +
                              ", " + country.Population.ToString() + " people " + Environment.NewLine;
                }
            }
            txtCountryInformation.Text = display;
        }
    }
}