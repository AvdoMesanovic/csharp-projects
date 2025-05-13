namespace project_2
{
    partial class frmIceCreamCost
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
            this.lblScoopsNumber = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtVanillaScoops = new System.Windows.Forms.TextBox();
            this.txtChocScoops = new System.Windows.Forms.TextBox();
            this.txtChocPrice = new System.Windows.Forms.TextBox();
            this.txtVanillaPrice = new System.Windows.Forms.TextBox();
            this.lblVanilla = new System.Windows.Forms.Label();
            this.lblChocolate = new System.Windows.Forms.Label();
            this.txtTotalCostOutput = new System.Windows.Forms.TextBox();
            this.txtVanillaPercentOutput = new System.Windows.Forms.TextBox();
            this.txtAvgCostOutput = new System.Windows.Forms.TextBox();
            this.btnTotalCost = new System.Windows.Forms.Button();
            this.btnAvgCost = new System.Windows.Forms.Button();
            this.btnVanillaPercent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScoopsNumber
            // 
            this.lblScoopsNumber.AutoSize = true;
            this.lblScoopsNumber.Location = new System.Drawing.Point(169, 120);
            this.lblScoopsNumber.Name = "lblScoopsNumber";
            this.lblScoopsNumber.Size = new System.Drawing.Size(140, 32);
            this.lblScoopsNumber.TabIndex = 0;
            this.lblScoopsNumber.Text = "# of Scoops";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(193, 217);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(116, 32);
            this.lblUnitPrice.TabIndex = 1;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // txtVanillaScoops
            // 
            this.txtVanillaScoops.Location = new System.Drawing.Point(336, 120);
            this.txtVanillaScoops.Name = "txtVanillaScoops";
            this.txtVanillaScoops.Size = new System.Drawing.Size(132, 39);
            this.txtVanillaScoops.TabIndex = 2;
            this.txtVanillaScoops.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChocScoops
            // 
            this.txtChocScoops.Location = new System.Drawing.Point(499, 120);
            this.txtChocScoops.Name = "txtChocScoops";
            this.txtChocScoops.Size = new System.Drawing.Size(132, 39);
            this.txtChocScoops.TabIndex = 3;
            this.txtChocScoops.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChocPrice
            // 
            this.txtChocPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtChocPrice.Location = new System.Drawing.Point(499, 214);
            this.txtChocPrice.Name = "txtChocPrice";
            this.txtChocPrice.Size = new System.Drawing.Size(132, 39);
            this.txtChocPrice.TabIndex = 5;
            this.txtChocPrice.Text = "$3.50";
            this.txtChocPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVanillaPrice
            // 
            this.txtVanillaPrice.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtVanillaPrice.Location = new System.Drawing.Point(336, 214);
            this.txtVanillaPrice.Name = "txtVanillaPrice";
            this.txtVanillaPrice.Size = new System.Drawing.Size(132, 39);
            this.txtVanillaPrice.TabIndex = 4;
            this.txtVanillaPrice.Text = "$2.50";
            this.txtVanillaPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVanilla
            // 
            this.lblVanilla.AutoSize = true;
            this.lblVanilla.Location = new System.Drawing.Point(359, 64);
            this.lblVanilla.Name = "lblVanilla";
            this.lblVanilla.Size = new System.Drawing.Size(83, 32);
            this.lblVanilla.TabIndex = 6;
            this.lblVanilla.Text = "Vanilla";
            // 
            // lblChocolate
            // 
            this.lblChocolate.AutoSize = true;
            this.lblChocolate.Location = new System.Drawing.Point(504, 64);
            this.lblChocolate.Name = "lblChocolate";
            this.lblChocolate.Size = new System.Drawing.Size(121, 32);
            this.lblChocolate.TabIndex = 7;
            this.lblChocolate.Text = "Chocolate";
            // 
            // txtTotalCostOutput
            // 
            this.txtTotalCostOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalCostOutput.Location = new System.Drawing.Point(267, 325);
            this.txtTotalCostOutput.Name = "txtTotalCostOutput";
            this.txtTotalCostOutput.Size = new System.Drawing.Size(157, 39);
            this.txtTotalCostOutput.TabIndex = 13;
            this.txtTotalCostOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVanillaPercentOutput
            // 
            this.txtVanillaPercentOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtVanillaPercentOutput.Location = new System.Drawing.Point(267, 514);
            this.txtVanillaPercentOutput.Name = "txtVanillaPercentOutput";
            this.txtVanillaPercentOutput.Size = new System.Drawing.Size(157, 39);
            this.txtVanillaPercentOutput.TabIndex = 12;
            this.txtVanillaPercentOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAvgCostOutput
            // 
            this.txtAvgCostOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtAvgCostOutput.Location = new System.Drawing.Point(267, 418);
            this.txtAvgCostOutput.Name = "txtAvgCostOutput";
            this.txtAvgCostOutput.Size = new System.Drawing.Size(157, 39);
            this.txtAvgCostOutput.TabIndex = 11;
            this.txtAvgCostOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTotalCost
            // 
            this.btnTotalCost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnTotalCost.Location = new System.Drawing.Point(84, 307);
            this.btnTotalCost.Name = "btnTotalCost";
            this.btnTotalCost.Size = new System.Drawing.Size(150, 75);
            this.btnTotalCost.TabIndex = 14;
            this.btnTotalCost.Text = "Total Cost";
            this.btnTotalCost.UseVisualStyleBackColor = false;
            this.btnTotalCost.Click += new System.EventHandler(this.btnTotalCost_Click);
            // 
            // btnAvgCost
            // 
            this.btnAvgCost.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAvgCost.Location = new System.Drawing.Point(84, 400);
            this.btnAvgCost.Name = "btnAvgCost";
            this.btnAvgCost.Size = new System.Drawing.Size(150, 75);
            this.btnAvgCost.TabIndex = 15;
            this.btnAvgCost.Text = "Average Cost";
            this.btnAvgCost.UseVisualStyleBackColor = false;
            this.btnAvgCost.Click += new System.EventHandler(this.btnAvgCost_Click);
            // 
            // btnVanillaPercent
            // 
            this.btnVanillaPercent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnVanillaPercent.Location = new System.Drawing.Point(84, 496);
            this.btnVanillaPercent.Name = "btnVanillaPercent";
            this.btnVanillaPercent.Size = new System.Drawing.Size(150, 75);
            this.btnVanillaPercent.TabIndex = 16;
            this.btnVanillaPercent.Text = "Percent of Vanilla";
            this.btnVanillaPercent.UseVisualStyleBackColor = false;
            this.btnVanillaPercent.Click += new System.EventHandler(this.btnVanillaPercent_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClear.Location = new System.Drawing.Point(481, 411);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 53);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnExit.Location = new System.Drawing.Point(481, 507);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 53);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmIceCreamCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 627);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVanillaPercent);
            this.Controls.Add(this.btnAvgCost);
            this.Controls.Add(this.btnTotalCost);
            this.Controls.Add(this.txtTotalCostOutput);
            this.Controls.Add(this.txtVanillaPercentOutput);
            this.Controls.Add(this.txtAvgCostOutput);
            this.Controls.Add(this.lblChocolate);
            this.Controls.Add(this.lblVanilla);
            this.Controls.Add(this.txtChocPrice);
            this.Controls.Add(this.txtVanillaPrice);
            this.Controls.Add(this.txtChocScoops);
            this.Controls.Add(this.txtVanillaScoops);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblScoopsNumber);
            this.Name = "frmIceCreamCost";
            this.Text = "Ice Cream Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblScoopsNumber;
        private Label lblUnitPrice;
        private TextBox txtVanillaScoops;
        private TextBox txtChocScoops;
        private TextBox txtChocPrice;
        private TextBox txtVanillaPrice;
        private Label lblVanilla;
        private Label lblChocolate;
        private TextBox txtTotalCostOutput;
        private TextBox txtVanillaPercentOutput;
        private TextBox txtAvgCostOutput;
        private Button btnTotalCost;
        private Button btnAvgCost;
        private Button btnVanillaPercent;
        private Button button1;
        private Button btnClear;
        private Button btnExit;
    }
}