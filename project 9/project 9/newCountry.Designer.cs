namespace project_9
{
    partial class frmNewCountry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddSize = new System.Windows.Forms.Label();
            this.txtAddSize = new System.Windows.Forms.TextBox();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddPopulations = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddPopulation = new System.Windows.Forms.TextBox();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddSize
            // 
            this.lblAddSize.AutoSize = true;
            this.lblAddSize.Location = new System.Drawing.Point(170, 244);
            this.lblAddSize.Name = "lblAddSize";
            this.lblAddSize.Size = new System.Drawing.Size(141, 32);
            this.lblAddSize.TabIndex = 43;
            this.lblAddSize.Text = "Size (sq mi):";
            // 
            // txtAddSize
            // 
            this.txtAddSize.Location = new System.Drawing.Point(331, 241);
            this.txtAddSize.Name = "txtAddSize";
            this.txtAddSize.Size = new System.Drawing.Size(200, 39);
            this.txtAddSize.TabIndex = 3;
            this.txtAddSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddCountry.Location = new System.Drawing.Point(348, 296);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(167, 81);
            this.btnAddCountry.TabIndex = 4;
            this.btnAddCountry.Text = "ADD";
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(170, 129);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(83, 32);
            this.lblAddName.TabIndex = 40;
            this.lblAddName.Text = "Name:";
            // 
            // lblAddPopulations
            // 
            this.lblAddPopulations.AutoSize = true;
            this.lblAddPopulations.Location = new System.Drawing.Point(170, 184);
            this.lblAddPopulations.Name = "lblAddPopulations";
            this.lblAddPopulations.Size = new System.Drawing.Size(133, 32);
            this.lblAddPopulations.TabIndex = 39;
            this.lblAddPopulations.Text = "Population:";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(331, 126);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(200, 39);
            this.txtAddName.TabIndex = 1;
            this.txtAddName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddPopulation
            // 
            this.txtAddPopulation.Location = new System.Drawing.Point(331, 181);
            this.txtAddPopulation.Name = "txtAddPopulation";
            this.txtAddPopulation.Size = new System.Drawing.Size(200, 39);
            this.txtAddPopulation.TabIndex = 2;
            this.txtAddPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Location = new System.Drawing.Point(348, 82);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(164, 32);
            this.lblAddCountry.TabIndex = 36;
            this.lblAddCountry.Text = "Add a country";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(603, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 81);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmNewCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAddSize);
            this.Controls.Add(this.txtAddSize);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.lblAddPopulations);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.txtAddPopulation);
            this.Controls.Add(this.lblAddCountry);
            this.Name = "frmNewCountry";
            this.Text = "New Country";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAddSize;
        private TextBox txtAddSize;
        private Button btnAddCountry;
        private Label lblAddName;
        private Label lblAddPopulations;
        private TextBox txtAddName;
        private TextBox txtAddPopulation;
        private Label lblAddCountry;
        private Button btnExit;
    }
}