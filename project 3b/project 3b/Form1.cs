namespace project_3b
{
    public partial class frmHotelReservations : Form
    {
        public frmHotelReservations()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            double totalCost = 0;
            double netCost = 0;
            double discount = 0;
            int reservationDays = Convert.ToInt32(txtNumDays.Text);

            char roomType = Convert.ToChar(txtRoomType.Text);
            char custStatus = Convert.ToChar(txtCustomerStatus.Text);

            if (roomType == 'Y')
            {
                totalCost = reservationDays * 70;
            }
            if (roomType == 'N')
            {
                totalCost = reservationDays * 50;
            }
            if (custStatus == 'G' && reservationDays >= 2 && reservationDays <= 6)
            {
                discount = totalCost * .2;
                netCost = totalCost - discount;
            }
            if (custStatus == 'G' && reservationDays >= 7)
            {
                discount = totalCost * .3;
                netCost = totalCost - discount;
            }
            if (custStatus == 'P' && reservationDays >= 2 && reservationDays <= 5)
            {
                discount = totalCost * .3;
                netCost = totalCost - discount;
            }
            if (custStatus == 'P' && reservationDays >= 6)
            {
                discount = totalCost * .35;
                netCost = totalCost - discount;
            }
            if (custStatus == 'R')
            {
                discount = 0;
                netCost = totalCost;
            }

            txtSummary.Text = "Total Cost: " + totalCost.ToString("c") + Environment.NewLine + 
                              "Discount: " + discount.ToString("c") + Environment.NewLine + 
                              "Net Cost: " + netCost.ToString("c");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerStatus.Clear();
            txtNumDays.Clear();
            txtRoomType.Clear();
            txtSummary.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}