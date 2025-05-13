namespace project_3
{
    partial class frmCityPopulation
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
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCityPopulation = new System.Windows.Forms.Label();
            this.lblTargetPopulation = new System.Windows.Forms.Label();
            this.lblGrowthRate = new System.Windows.Forms.Label();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.txtWhichDigit = new System.Windows.Forms.TextBox();
            this.txtTargetPopulation = new System.Windows.Forms.TextBox();
            this.txtCurrentPopulation = new System.Windows.Forms.TextBox();
            this.lblYearlyPopulation = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtYearsToTarget = new System.Windows.Forms.TextBox();
            this.lblYearsToTarget = new System.Windows.Forms.Label();
            this.txtYearlyPopulation = new System.Windows.Forms.TextBox();
            this.txtGrowthRate = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblWhichDigit = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(62, 70);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(55, 32);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City";
            // 
            // lblCityPopulation
            // 
            this.lblCityPopulation.AutoSize = true;
            this.lblCityPopulation.Location = new System.Drawing.Point(62, 148);
            this.lblCityPopulation.Name = "lblCityPopulation";
            this.lblCityPopulation.Size = new System.Drawing.Size(215, 32);
            this.lblCityPopulation.TabIndex = 1;
            this.lblCityPopulation.Text = "Current Population";
            // 
            // lblTargetPopulation
            // 
            this.lblTargetPopulation.AutoSize = true;
            this.lblTargetPopulation.Location = new System.Drawing.Point(62, 228);
            this.lblTargetPopulation.Name = "lblTargetPopulation";
            this.lblTargetPopulation.Size = new System.Drawing.Size(200, 32);
            this.lblTargetPopulation.TabIndex = 2;
            this.lblTargetPopulation.Text = "Target Population";
            // 
            // lblGrowthRate
            // 
            this.lblGrowthRate.AutoSize = true;
            this.lblGrowthRate.Location = new System.Drawing.Point(62, 307);
            this.lblGrowthRate.Name = "lblGrowthRate";
            this.lblGrowthRate.Size = new System.Drawing.Size(145, 32);
            this.lblGrowthRate.TabIndex = 3;
            this.lblGrowthRate.Text = "Growth Rate";
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(170, 70);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(313, 39);
            this.txtCityName.TabIndex = 4;
            this.txtCityName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWhichDigit
            // 
            this.txtWhichDigit.BackColor = System.Drawing.Color.Cyan;
            this.txtWhichDigit.Location = new System.Drawing.Point(655, 533);
            this.txtWhichDigit.Name = "txtWhichDigit";
            this.txtWhichDigit.Size = new System.Drawing.Size(149, 39);
            this.txtWhichDigit.TabIndex = 6;
            this.txtWhichDigit.Text = "3";
            this.txtWhichDigit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTargetPopulation
            // 
            this.txtTargetPopulation.Location = new System.Drawing.Point(283, 228);
            this.txtTargetPopulation.Name = "txtTargetPopulation";
            this.txtTargetPopulation.Size = new System.Drawing.Size(200, 39);
            this.txtTargetPopulation.TabIndex = 7;
            this.txtTargetPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrentPopulation
            // 
            this.txtCurrentPopulation.Location = new System.Drawing.Point(283, 145);
            this.txtCurrentPopulation.Name = "txtCurrentPopulation";
            this.txtCurrentPopulation.Size = new System.Drawing.Size(200, 39);
            this.txtCurrentPopulation.TabIndex = 8;
            this.txtCurrentPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYearlyPopulation
            // 
            this.lblYearlyPopulation.AutoSize = true;
            this.lblYearlyPopulation.Location = new System.Drawing.Point(604, 19);
            this.lblYearlyPopulation.Name = "lblYearlyPopulation";
            this.lblYearlyPopulation.Size = new System.Drawing.Size(197, 32);
            this.lblYearlyPopulation.TabIndex = 9;
            this.lblYearlyPopulation.Text = "Yearly Population";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.LightCoral;
            this.btnCalculate.Location = new System.Drawing.Point(62, 449);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 61);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(246, 572);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 61);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Chartreuse;
            this.btnClear.Location = new System.Drawing.Point(62, 572);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 61);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtYearsToTarget
            // 
            this.txtYearsToTarget.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtYearsToTarget.Location = new System.Drawing.Point(302, 460);
            this.txtYearsToTarget.Name = "txtYearsToTarget";
            this.txtYearsToTarget.Size = new System.Drawing.Size(502, 39);
            this.txtYearsToTarget.TabIndex = 13;
            this.txtYearsToTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYearsToTarget
            // 
            this.lblYearsToTarget.AutoSize = true;
            this.lblYearsToTarget.Location = new System.Drawing.Point(433, 410);
            this.lblYearsToTarget.Name = "lblYearsToTarget";
            this.lblYearsToTarget.Size = new System.Drawing.Size(239, 32);
            this.lblYearsToTarget.TabIndex = 14;
            this.lblYearsToTarget.Text = "Years to Reach Target";
            // 
            // txtYearlyPopulation
            // 
            this.txtYearlyPopulation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtYearlyPopulation.Location = new System.Drawing.Point(607, 70);
            this.txtYearlyPopulation.Multiline = true;
            this.txtYearlyPopulation.Name = "txtYearlyPopulation";
            this.txtYearlyPopulation.Size = new System.Drawing.Size(200, 286);
            this.txtYearlyPopulation.TabIndex = 15;
            this.txtYearlyPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrowthRate
            // 
            this.txtGrowthRate.Location = new System.Drawing.Point(283, 317);
            this.txtGrowthRate.Name = "txtGrowthRate";
            this.txtGrowthRate.Size = new System.Drawing.Size(200, 39);
            this.txtGrowthRate.TabIndex = 16;
            this.txtGrowthRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.Cyan;
            this.txtNumber.Location = new System.Drawing.Point(655, 594);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(149, 39);
            this.txtNumber.TabIndex = 17;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWhichDigit
            // 
            this.lblWhichDigit.AutoSize = true;
            this.lblWhichDigit.ForeColor = System.Drawing.Color.Blue;
            this.lblWhichDigit.Location = new System.Drawing.Point(481, 536);
            this.lblWhichDigit.Name = "lblWhichDigit";
            this.lblWhichDigit.Size = new System.Drawing.Size(150, 32);
            this.lblWhichDigit.TabIndex = 18;
            this.lblWhichDigit.Text = "Which Digit?";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.ForeColor = System.Drawing.Color.Blue;
            this.lblNumber.Location = new System.Drawing.Point(529, 597);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(102, 32);
            this.lblNumber.TabIndex = 19;
            this.lblNumber.Text = "Number";
            // 
            // frmCityPopulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 672);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblWhichDigit);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtGrowthRate);
            this.Controls.Add(this.txtYearlyPopulation);
            this.Controls.Add(this.lblYearsToTarget);
            this.Controls.Add(this.txtYearsToTarget);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblYearlyPopulation);
            this.Controls.Add(this.txtCurrentPopulation);
            this.Controls.Add(this.txtTargetPopulation);
            this.Controls.Add(this.txtWhichDigit);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.lblGrowthRate);
            this.Controls.Add(this.lblTargetPopulation);
            this.Controls.Add(this.lblCityPopulation);
            this.Controls.Add(this.lblCity);
            this.Name = "frmCityPopulation";
            this.Text = "City Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCity;
        private Label lblCityPopulation;
        private Label lblTargetPopulation;
        private Label lblGrowthRate;
        private TextBox txtCityName;
        private TextBox txtWhichDigit;
        private TextBox txtTargetPopulation;
        private TextBox txtCurrentPopulation;
        private Label lblYearlyPopulation;
        private Button btnCalculate;
        private Button btnExit;
        private Button btnClear;
        private TextBox txtYearsToTarget;
        private Label lblYearsToTarget;
        private TextBox txtYearlyPopulation;
        private TextBox txtGrowthRate;
        private TextBox txtNumber;
        private Label lblWhichDigit;
        private Label lblNumber;
    }
}