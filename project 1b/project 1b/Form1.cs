namespace project_1b
{
    public partial class frmAddMultiply : Form
    {
        public frmAddMultiply()
        {
            InitializeComponent();
        }

        private void frmAddMultiply_Load(object sender, EventArgs e)
        {

        }

        private void lblValueA_Click(object sender, EventArgs e)
        {

        }

        private void btnResult1_Click(object sender, EventArgs e)
        {
            decimal result = Convert.ToDecimal(txtValue1.Text) + (Convert.ToDecimal(txtValue2.Text) * Convert.ToDecimal(txtValue3.Text));   
            txtValue4.Text = result.ToString();
        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            decimal result = (Convert.ToDecimal(txtValue1.Text) + Convert.ToDecimal(txtValue2.Text)) * Convert.ToDecimal(txtValue3.Text);
            txtValue5.Text = result.ToString();
        }
    }
}