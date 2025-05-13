using System.IO;

namespace project_11
{
    public partial class frmAmericanToEnglish : Form
    {
        public frmAmericanToEnglish()
        {
            InitializeComponent();
        }

        string testerPath = @"C:\Users\avdom\OneDrive\Documents\source\repos\c#\project 11\project 11\Testers.txt";
        string translationPath = @"C:\Users\avdom\OneDrive\Documents\source\repos\c#\project 11\project 11\Translation.txt";

        List<string> americanWords = new List<string>();
        List<string> englishWords = new List<string>();

        List<string> testers = new List<string>();
        List<string> scores = new List<string>();

        int count = 0;

        private void frmAmericanToEnglish_Load(object sender, EventArgs e)
        {
            StreamReader textIn = new StreamReader(new FileStream(translationPath, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(",");
                string americanWord = columns[0];
                americanWords.Add(americanWord);
                string englishWord = columns[1];
                englishWords.Add(englishWord);
            }
            textIn.Close();

            txtAmerican.Text = americanWords[0];
            txtEnglish.Text = englishWords[0];
        }

        private void btnNextWord_Click(object sender, EventArgs e)
        {
            txtAmerican.Text = americanWords[count];
            txtEnglish.Text = englishWords[count];
            if (count < americanWords.Count - 1)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            txtAmerican.Text = americanWords[count];
            txtEnglish.Text = englishWords[count];
        }

        private void btnDisplayTesters_Click(object sender, EventArgs e)
        {
            StreamReader textIn = new StreamReader(new FileStream(testerPath, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string tester = textIn.ReadLine();
                testers.Add(tester);
                string row = textIn.ReadLine();
                string[] columns = row.Split(",");
                string score = columns[1];
                scores.Add(score);
            }
            textIn.Close();

            string display = "";

            for (int i = 0; i < testers.Count; i++)
            {
                display += testers[i] + ": " + scores[i] + "%" + Environment.NewLine;
            }

            MessageBox.Show(display, "Testers and Scores");
        }

        private void btnTakeTest_Click(object sender, EventArgs e)
        {
            frmTestingForm testForm = new frmTestingForm();
            testForm.ShowDialog();

            StreamWriter textOut = new StreamWriter(new FileStream(testerPath, FileMode.OpenOrCreate, FileAccess.Write));
            textOut.WriteLine();
            textOut.WriteLine("Updated scores:");
            textOut.WriteLine(testForm.Tag);
            textOut.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}