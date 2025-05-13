namespace project_4
{
    public partial class frmEmployeeEvaluation : Form
    {
        public frmEmployeeEvaluation()
        {
            InitializeComponent();
        }

        private void calcGrade(double score, out char grade)
        {
            grade = 'A';
            if (score >= 90)
            {
                grade = 'A';
            }
            if (score <= 89.99 && score >= 80)
            {
                grade = 'B';
            }
            if (score <= 79.99 && score >= 70)
            {
                grade = 'C';
            }
            if (score <= 69.99 && score >= 60)
            {
                grade = 'D';
            }
            if (score <= 59.99)
            {
                grade = 'F';
            }
        }

        private double calcTotal(double a, double b, double c)
        {
            return a + b + c;
        }

        public enum SalaryTypes
        {
            GradeASalary = 120000,
            GradeBSalary = 110000,
            GradeCSalary = 90000,
            GradeDSalary = 75000,
            GradeFSalary = 35000
        };

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            char grade = '0';
            char empType = Convert.ToChar(txtEmployeeType.Text);

            SalaryTypes salaries;

            double salary;
            double score1 = Convert.ToDouble(txtScore1.Text) * .25;
            double score2 = Convert.ToDouble(txtScore2.Text) * .35;
            double score3 = Convert.ToDouble(txtScore3.Text) * .4;

            double totalScore = calcTotal(score1, score2, score3);
            txtOverallScore.Text = totalScore.ToString("n2") + "%";

            calcGrade(totalScore, out grade);
            txtGrade.Text = grade.ToString();

            if (empType == 'F')
            {
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        {
                            salary = Convert.ToDouble(SalaryTypes.GradeASalary);
                            txtSalary.Text = salary.ToString("c");
                            break;
                        }
                    case 'B':
                    case 'b':
                        {
                            salary = Convert.ToDouble(SalaryTypes.GradeBSalary);
                            txtSalary.Text = salary.ToString("c");
                            break;
                        }
                    case 'C':
                    case 'c':
                        {
                            salary = Convert.ToDouble(SalaryTypes.GradeCSalary);
                            txtSalary.Text = salary.ToString("c");
                            break;
                        }
                    case 'D':
                    case 'd':
                        {
                            salary = Convert.ToDouble(SalaryTypes.GradeDSalary);
                            txtSalary.Text = salary.ToString("c");
                            break;
                        }
                    case 'F':
                    case 'f':
                        {
                            salary = Convert.ToDouble(SalaryTypes.GradeFSalary);
                            txtSalary.Text = salary.ToString("c");
                    break;
                        }
                }
            }

            else if (empType == 'P')
            {
                double hoursWorked = Convert.ToDouble(txtHoursWorked.Text);
                switch (grade)
                {
                    case 'A':
                    case 'a':
                        {
                            salary = (hoursWorked / 40) * Convert.ToDouble(SalaryTypes.GradeASalary);
                            txtSalary.Text = salary.ToString("c");
                            break;
                        }
                    case 'B':
                    case 'b':
                        {
                            salary = (hoursWorked / 40) * Convert.ToDouble(SalaryTypes.GradeBSalary);
                            txtSalary.Text = salary.ToString("c");
                            break;
                        }
                    case 'C':
                    case 'c':
                        {
                            salary = (hoursWorked / 40) * Convert.ToDouble(SalaryTypes.GradeCSalary);
                            txtSalary.Text = salary.ToString("c");
                            break;
                        }
                    case 'D':
                    case 'd':
                        {
                            salary = (hoursWorked / 40) * Convert.ToDouble(SalaryTypes.GradeDSalary);
                            txtSalary.Text = salary.ToString("c");
                            break;
                        }
                    case 'F':
                    case 'f':
                        {
                            salary = (hoursWorked / 40) * Convert.ToDouble(SalaryTypes.GradeFSalary);
                            txtSalary.Text = salary.ToString("c");
                            break;
                        }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmployeeType.Clear();
            txtGrade.Clear();
            txtHoursWorked.Clear();
            txtOverallScore.Clear();
            txtSalary.Clear();
            txtScore1.Clear();
            txtScore2.Clear();
            txtScore3.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}