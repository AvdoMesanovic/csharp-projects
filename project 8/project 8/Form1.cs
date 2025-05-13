using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace project_8
{
    public partial class frmTravelArrangements : Form
    {
        public frmTravelArrangements()
        {
            InitializeComponent();
        }

        /* England Price = 500;
           Canada Price = 250;
           China Price = 550;
           Australia Price = 750;
           Italy Price = 600;
           Ecuador Price = 350;
           Thailand Price = 650; */

        List<Customer> customerList = new List<Customer>();

        double[] prices = { 750, 250, 550, 350, 500, 600, 650 };

        string medicalConcerns = "";

        private void frmTravelArrangements_Load(object sender, EventArgs e)
        {

            string[] months = {"January", "February", "March", "April", "May", "June", "July",
                               "August", "September", "October", "November", "December"};

            string[] countries = {"England", "Canada", "China", "Australia", "Italy",
                                  "Ecuador", "Thailand"};

            int year = DateTime.Now.Year;
            int endYear = year + 5;

            foreach (string month in months)
            {
                cboSelectMonth.Items.Add(month);
            }

            while (year < endYear)
            {
                cboSelectYear.Items.Add(year);
                year++;
            }

            foreach (string country in countries)
            {
                lstDestinationList.Items.Add(country);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // exception handling
                bool isChecked = false;

                if (string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    throw new Exception("Please enter a name");
                }

                foreach (RadioButton radioButton in grpTravelClass.Controls)
                {
                    if (radioButton.Checked == true)
                    {
                        isChecked = true;
                    }
                }

                if (isChecked == false)
                {
                    throw new Exception("Please select a travel class");
                }

                if (cboSelectMonth.SelectedIndex == -1)
                {
                    throw new Exception("Please select a month");
                }

                if (cboSelectYear.SelectedIndex == -1)
                {
                    throw new Exception("Please select a year");
                }

                if (lstDestinationList.SelectedIndex == -1)
                {
                    throw new Exception("Please select a destination");
                }
                // end exception handling

                int selectedDestination = lstDestinationList.SelectedIndex;
                double price = 0;

                string outcome = "";
                outcome = txtCustomerName.Text;
                Customer customer = new Customer(Name = txtCustomerName.Text);

                // medical concerns
                if (medicalConcerns == "")
                {
                    medicalConcerns = "None";
                }
                outcome += "\n" + "Medical concerns: " + medicalConcerns;
                customer.MedicalConcerns = medicalConcerns;

                // radio button selection
                if (rdoEconomy.Checked == true)
                {
                    outcome += "\n" + "Economy Class";
                    customer.TravelClass = "Economy Class";
                    price = prices[selectedDestination];
                }
                else if (rdoBusiness.Checked == true)
                {
                    outcome += "\n" + "Business Class";
                    customer.TravelClass = "Business Class";
                    price = prices[selectedDestination] + (prices[selectedDestination] * .3);
                }
                else if (rdoFirst.Checked == true)
                {
                    outcome += "\n" + "First Class";
                    customer.TravelClass = "First Class";
                    price = prices[selectedDestination] + (prices[selectedDestination] * .55);
                }

                // list box selection
                outcome += "\n" + lstDestinationList.Text + ": " + price.ToString("c");
                customer.Destination = lstDestinationList.Text;
                customer.TravelCost = price;

                // random country checkbox
                /* if (chbRandomCountry.Checked == true)
                   {
                       outcome += "\n" + "Random Country Selected";
                   }
                   else
                   {
                       outcome += "\n" + "User Selected Country";
                   } */

                // month combo box
                outcome += "\n" + cboSelectMonth.Text;
                customer.TravelMonth = cboSelectMonth.Text;

                // year combo box
                outcome += "\n" + cboSelectYear.Text;
                customer.TravelYear = cboSelectYear.Text;

                DialogResult button;
                button = MessageBox.Show(outcome + "\n\nIs the information above correct?",
                                         "Travel Plan Information", MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    customerList.Add(customer);
                    MessageBox.Show("Submitted!" + "\n\nPress 'OK'");
                    txtCustomerName.Clear();
                    medicalConcerns = "";
                    grpTravelClass.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
                    cboSelectMonth.SelectedIndex = -1;
                    cboSelectYear.SelectedIndex = -1;
                    lstDestinationList.SelectedIndex = -1;
                    chbRandomCountry.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMedicalConcerns_Click(object sender, EventArgs e)
        {
            frmMedicalConcerns secondForm = new frmMedicalConcerns();
            secondForm.ShowDialog();
            medicalConcerns = secondForm.Tag.ToString();
        }

        private void chbRandomCountry_CheckedChanged(object sender, EventArgs e)
        {
            Random rand = new Random();
            int index = rand.Next(0, lstDestinationList.Items.Count);
            lstDestinationList.Text = lstDestinationList.Items[index].ToString();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < customerList.Count; i++)
            {
                if (txtRegisteredName.Text == customerList[i].Name)
                {
                    customerList[i].Display();
                    found = true;
                }
            }

            if (found == false)
            {
                MessageBox.Show("[ERROR] Customer not found" + "\n" +"\n" + 
                                "Please make sure the name has been entered correctly",
                                "Customer Not Found");
            }
        }
    }
}