namespace project_5
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

        private bool validScore(bool result, double num)
        {

            if (num < 0 || num > 100)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
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
            try
            {
                bool result = true;

                result = validScore(result, Convert.ToDouble(txtScore1.Text));
                if (result == false)
                {
                    txtScore1.Clear();
                    txtScore1.Focus();
                    MessageBox.Show("Score must be within the 0 - 100 range", "Percentage Entry");
                }
                else
                {
                    result = true;
                }

                result = validScore(result, Convert.ToDouble(txtScore2.Text));
                if (result == false)
                {
                    txtScore2.Clear();
                    txtScore2.Focus();
                    MessageBox.Show("Score must be within the 0 - 100 range", "Percentage Entry");
                }
                else
                {
                    result = true;
                }

                result = validScore(result, Convert.ToDouble(txtScore3.Text));
                if (result == false)
                {
                    txtScore3.Clear();
                    txtScore3.Focus();
                    MessageBox.Show("Score must be within the 0 - 100 range", "Percentage Entry");
                }

                string empName = txtName.Text;

                char grade = '0';
                char empType = Convert.ToChar(txtEmployeeType.Text);

                double salary = 0;
                double finalSalary;
                double score1 = Convert.ToDouble(txtScore1.Text) * .25;
                double score2 = Convert.ToDouble(txtScore2.Text) * .35;
                double score3 = Convert.ToDouble(txtScore3.Text) * .4;
                double yearsWorked = Convert.ToDouble(txtYearsWorked.Text);

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

                if (yearsWorked >= 5 && yearsWorked <= 10)
                {
                    finalSalary = (salary * .02) + salary;
                }

                else if (yearsWorked > 10)
                {
                    finalSalary = (salary * .05) + salary;
                }

                else
                {
                    finalSalary = salary;
                }

                txtFinalSalary.Text = empName + ": " + finalSalary.ToString("c");
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect data type entered", "Data Entry");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Value entered was too large or too small", "Wrong Value");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.GetType().ToString());
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
            txtYearsWorked.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}