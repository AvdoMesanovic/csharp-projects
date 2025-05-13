namespace project_6
{
    public partial class frmSportParticipation : Form
    {
        public frmSportParticipation()
        {
            InitializeComponent();
        }

        private string[] sports = new string[] { "Squash", "Table Tennis", "Football" };
        private int[] numParticipants = new int[] { 25, 30, 105 };

        private void btnAddSport_Click(object sender, EventArgs e)
        {
            string newSportName = txtSportAddName.Text;
            int newSportParticipants = Convert.ToInt32(txtSportAddNumParticipants.Text);

            sports = sports.Concat(new string[] { newSportName }).ToArray();
            numParticipants = numParticipants.Concat(new int[] { newSportParticipants }).ToArray();
        }

        private void btnRemoveSport_Click(object sender, EventArgs e)
        {
            string[] sports2 = new string[sports.Length - 1];
            int[] numParticipants2 = new int[numParticipants.Length - 1];

            int num = 0;

            for (int i = 0; i < sports.Length - 1; ++i)
            {
                if (sports[i] == txtRemoveSportName.Text)
                {
                    num = i;
                }
            }

            Array.Copy(sports, 0, sports2, 0, num - 1);
            Array.Copy(sports, num + 1, sports2, num + 1, num + 1);
            Array.Copy(numParticipants, 0, numParticipants2, 0, num - 1);
            Array.Copy(numParticipants, num, numParticipants2, num, num - (sports.Length - 1));
            
            sports = sports2;
            numParticipants = numParticipants2;
        }

        private void btnViewParticipants_Click(object sender, EventArgs e)
        {
            int num = 0;
            for (int i = 0; i < sports.Length; ++i)
            {
                if (sports[i] == txtParticipantsName.Text)
                {
                    num = i;
                }
            }
            txtNumParticipants.Text = numParticipants[num].ToString();
        }

        private void btnViewHighestParticipants_Click(object sender, EventArgs e)
        {
            int largest = numParticipants[0];
            for (int i = 1; i < numParticipants.Length; ++i)
            {
                if (numParticipants[i] > largest)
                {
                    largest = i;
                }
            }
            txtHighestName.Text = sports[largest];
            txtHighestNumParticipants.Text = numParticipants[largest].ToString();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            string allSports = "";
            for (int i = 0; i < sports.Length; ++i)
            {
                allSports += sports[i] + ": " + numParticipants[i] + "\n";
            }
            MessageBox.Show(allSports, "All Sports");
        }
    }
}