namespace project_4
{
    partial class frmEmployeeEvaluation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtEmployeeType = new System.Windows.Forms.TextBox();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.lblScore3 = new System.Windows.Forms.Label();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblOverallScore = new System.Windows.Forms.Label();
            this.txtOverallScore = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(56, 444);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 65);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(549, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 65);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightGreen;
            this.btnCalculate.Location = new System.Drawing.Point(304, 444);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 65);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtEmployeeType
            // 
            this.txtEmployeeType.Location = new System.Drawing.Point(466, 122);
            this.txtEmployeeType.Name = "txtEmployeeType";
            this.txtEmployeeType.Size = new System.Drawing.Size(200, 39);
            this.txtEmployeeType.TabIndex = 19;
            this.txtEmployeeType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.Location = new System.Drawing.Point(424, 78);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(288, 32);
            this.lblEmployeeType.TabIndex = 18;
            this.lblEmployeeType.Text = "Employee Type (\'F\', or \'P\')";
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(165, 244);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(200, 39);
            this.txtScore3.TabIndex = 17;
            this.txtScore3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore3
            // 
            this.lblScore3.AutoSize = true;
            this.lblScore3.Location = new System.Drawing.Point(66, 247);
            this.lblScore3.Name = "lblScore3";
            this.lblScore3.Size = new System.Drawing.Size(93, 32);
            this.lblScore3.TabIndex = 16;
            this.lblScore3.Text = "Score 3";
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(165, 158);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(200, 39);
            this.txtScore2.TabIndex = 15;
            this.txtScore2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(66, 158);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(93, 32);
            this.lblScore2.TabIndex = 14;
            this.lblScore2.Text = "Score 2";
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(165, 71);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(200, 39);
            this.txtScore1.TabIndex = 21;
            this.txtScore1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(66, 71);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(93, 32);
            this.lblScore1.TabIndex = 20;
            this.lblScore1.Text = "Score 1";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(466, 232);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(200, 39);
            this.txtHoursWorked.TabIndex = 23;
            this.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(448, 187);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(233, 32);
            this.lblHoursWorked.TabIndex = 22;
            this.lblHoursWorked.Text = "Hours Worked (if \'P\')";
            // 
            // lblOverallScore
            // 
            this.lblOverallScore.AutoSize = true;
            this.lblOverallScore.Location = new System.Drawing.Point(66, 330);
            this.lblOverallScore.Name = "lblOverallScore";
            this.lblOverallScore.Size = new System.Drawing.Size(175, 32);
            this.lblOverallScore.TabIndex = 24;
            this.lblOverallScore.Text = "Overall Percent";
            // 
            // txtOverallScore
            // 
            this.txtOverallScore.BackColor = System.Drawing.Color.Gainsboro;
            this.txtOverallScore.Location = new System.Drawing.Point(56, 375);
            this.txtOverallScore.Name = "txtOverallScore";
            this.txtOverallScore.ReadOnly = true;
            this.txtOverallScore.Size = new System.Drawing.Size(200, 39);
            this.txtOverallScore.TabIndex = 25;
            this.txtOverallScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.Gainsboro;
            this.txtGrade.Location = new System.Drawing.Point(304, 375);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.ReadOnly = true;
            this.txtGrade.Size = new System.Drawing.Size(200, 39);
            this.txtGrade.TabIndex = 27;
            this.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(366, 330);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(77, 32);
            this.lblGrade.TabIndex = 26;
            this.lblGrade.Text = "Grade";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSalary.Location = new System.Drawing.Point(549, 375);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(200, 39);
            this.txtSalary.TabIndex = 29;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(571, 330);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(157, 32);
            this.lblSalary.TabIndex = 28;
            this.lblSalary.Text = "Salary Earned";
            // 
            // frmEmployeeEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtOverallScore);
            this.Controls.Add(this.lblOverallScore);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.txtScore1);
            this.Controls.Add(this.lblScore1);
            this.Controls.Add(this.txtEmployeeType);
            this.Controls.Add(this.lblEmployeeType);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.lblScore3);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmEmployeeEvaluation";
            this.Text = "Company Employee Evaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClear;
        private Button btnExit;
        private Button btnCalculate;
        private TextBox txtEmployeeType;
        private Label lblEmployeeType;
        private TextBox txtScore3;
        private Label lblScore3;
        private TextBox txtScore2;
        private Label lblScore2;
        private TextBox txtScore1;
        private Label lblScore1;
        private TextBox txtHoursWorked;
        private Label lblHoursWorked;
        private Label lblOverallScore;
        private TextBox txtOverallScore;
        private TextBox txtGrade;
        private Label lblGrade;
        private TextBox txtSalary;
        private Label lblSalary;
    }
}