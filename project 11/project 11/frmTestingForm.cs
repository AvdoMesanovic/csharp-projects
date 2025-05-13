using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_11
{
    public partial class frmTestingForm : Form
    {
        public frmTestingForm()
        {
            InitializeComponent();
        }

        string testerPath = @"C:\Users\avdom\OneDrive\Documents\source\repos\c#\project 11\project 11\Testers.txt";
        string translationPath = @"C:\Users\avdom\OneDrive\Documents\source\repos\c#\project 11\project 11\Translation.txt";
        string output = "";

        List<string> testers = new List<string>();

        List<string> americanWords = new List<string>();
        List<string> englishWords = new List<string>();

        int count = 0;
        int score = 0;

        private void frmTestingForm_Load(object sender, EventArgs e)
        {
            StreamReader readTranslation = new StreamReader(new FileStream(translationPath, FileMode.Open, FileAccess.Read));
            StreamReader readTester = new StreamReader(new FileStream(testerPath, FileMode.Open, FileAccess.Read));

            while (readTranslation.Peek() != -1)
            {
                string row = readTranslation.ReadLine();
                string[] columns = row.Split(",");
                string americanWord = columns[0];
                americanWords.Add(americanWord);
                string englishWord = columns[1];
                englishWords.Add(englishWord);
            }
            readTranslation.Close();

            txtAmerican.Text = americanWords[0];

            while (readTester.Peek() != -1)
            {
                string tester = readTester.ReadLine();
                testers.Add(tester);
                readTester.ReadLine();
            }
            readTester.Close();

            foreach (string tester in testers) 
            {
                lstTesterList.Items.Add(tester);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            txtAmerican.Text = americanWords[count];
            if (count < americanWords.Count - 1)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            txtAmerican.Text = americanWords[count];

            if (txtEnglish.Text == englishWords[count])
            {
                MessageBox.Show("Yes!");
                score++;
            }
            else
            {
                MessageBox.Show("No");
            }

            txtEnglish.Clear();

            if (count == 10)
            {
                MessageBox.Show("End of test");
                txtEnglish.ReadOnly = true;
                Close();
            }

            output = lstTesterList.Text + ": " + Environment.NewLine + score.ToString();
            Tag = output;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
