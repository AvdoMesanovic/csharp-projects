namespace project_6b
{
    public partial class frmSportParticipation : Form
    {
        public frmSportParticipation()
        {
            InitializeComponent();
        }

        private List<string> sports = new List<string> { "Squash", "Table Tennis", "Football" };
        private List<int> numParticipants = new List<int> { 25, 30, 105 };

        private void btnAddSport_Click(object sender, EventArgs e)
        {
            string s = txtSportAddName.Text;
            int num = Convert.ToInt32(txtSportAddNumParticipants.Text);
            sports.Add(s);
            numParticipants.Add(num);
        }

        private void btnRemoveSport_Click(object sender, EventArgs e)
        {
            string s = txtRemoveSportName.Text;

            int num = 0;

            for (int i = 0; i < sports.Count; i++)
            {
                if (sports[i] == s)
                {
                    num = i;
                }
            }
            sports.Remove(s);
            numParticipants.Remove(numParticipants[num]);
        }

        private void btnViewParticipants_Click(object sender, EventArgs e)
        {
            int num = 0;
            for (int i = 0; i < sports.Count; ++i)
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
            for (int i = 1; i < numParticipants.Count; ++i)
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
            for (int i = 0; i < sports.Count; ++i)
            {
                allSports += sports[i] + ": " + numParticipants[i] + "\n";
            }
            MessageBox.Show(allSports, "All Sports");
        }
    }
}