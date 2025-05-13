namespace project_2
{
    public partial class frmIceCreamCost : Form
    {
        public frmIceCreamCost()
        {
            InitializeComponent();
        }

        const double vanillaCost = 2.5;
        const double chocCost = 3.5;

        private void btnTotalCost_Click(object sender, EventArgs e)
        {
            double totalCost = (Convert.ToDouble(txtVanillaScoops.Text) * vanillaCost) + (Convert.ToDouble(txtChocScoops.Text) * chocCost);
            txtTotalCostOutput.Text = "$" + Math.Round(totalCost, 2).ToString("n2");
        }

        private void btnAvgCost_Click(object sender, EventArgs e)
        {
            double totalCost = (Convert.ToDouble(txtVanillaScoops.Text) * vanillaCost) + (Convert.ToDouble(txtChocScoops.Text) * chocCost);
            double average = totalCost / (Convert.ToDouble(txtVanillaScoops.Text) + Convert.ToDouble(txtChocScoops.Text));
            txtAvgCostOutput.Text = "$" + Math.Round(average, 2).ToString("n2");
        }

        private void btnVanillaPercent_Click(object sender, EventArgs e)
        {
            double vanillaPercent = (Convert.ToDouble(txtVanillaScoops.Text) / (Convert.ToDouble(txtVanillaScoops.Text) + Convert.ToDouble(txtChocScoops.Text))) * 100;
            txtVanillaPercentOutput.Text = Math.Round(vanillaPercent, 2).ToString("n2") + "%";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVanillaScoops.Clear();
            txtChocScoops.Clear();
            txtTotalCostOutput.Clear();
            txtAvgCostOutput.Clear();
            txtVanillaPercentOutput.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}