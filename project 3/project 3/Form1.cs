namespace project_3
{
    public partial class frmCityPopulation : Form
    {
        public frmCityPopulation()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string yearlyPopulation = txtYearlyPopulation.Text;
            char c;

            double currentPopulation = Convert.ToDouble(txtCurrentPopulation.Text);
            int targetPopulation = Convert.ToInt32(txtTargetPopulation.Text);
            double growthRate = Convert.ToDouble(txtGrowthRate.Text) / 100;
            int whichDigit = Convert.ToInt32(txtWhichDigit.Text);
            int counterYears = 0;
            int numCounter = 0;

            while (currentPopulation <= targetPopulation)
            { 
                currentPopulation = (currentPopulation * growthRate) + currentPopulation;
                yearlyPopulation += Math.Round(currentPopulation).ToString() + Environment.NewLine;
                counterYears++;
            }

            txtYearlyPopulation.Text = yearlyPopulation;

            for (int i = 0; i < yearlyPopulation.Length; i++)
            {
                c = yearlyPopulation[i];
                if (Convert.ToInt32(c - '0') == whichDigit)
                {
                    numCounter++;
                }
            }

            txtYearsToTarget.Text = txtCityName.Text + ": " + counterYears.ToString() + " years";
            txtNumber.Text = numCounter.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCityName.Clear();
            txtCurrentPopulation.Clear();
            txtTargetPopulation.Clear();
            txtGrowthRate.Clear();
            txtYearlyPopulation.Clear();
            txtYearsToTarget.Clear();
            txtNumber.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}