namespace project_7
{
    partial class frmTravelArrangements
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
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.grpTravelClass = new System.Windows.Forms.GroupBox();
            this.rdoFirst = new System.Windows.Forms.RadioButton();
            this.rdoBusiness = new System.Windows.Forms.RadioButton();
            this.rdoEconomy = new System.Windows.Forms.RadioButton();
            this.cboSelectMonth = new System.Windows.Forms.ComboBox();
            this.cboSelectYear = new System.Windows.Forms.ComboBox();
            this.lblTravelDate = new System.Windows.Forms.Label();
            this.lstDestinationList = new System.Windows.Forms.ListBox();
            this.lblDestinations = new System.Windows.Forms.Label();
            this.btnMedicalConcerns = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.chbRandomCountry = new System.Windows.Forms.CheckBox();
            this.grpTravelClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(48, 64);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(83, 32);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(222, 64);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(531, 39);
            this.txtCustomerName.TabIndex = 2;
            this.txtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpTravelClass
            // 
            this.grpTravelClass.Controls.Add(this.rdoFirst);
            this.grpTravelClass.Controls.Add(this.rdoBusiness);
            this.grpTravelClass.Controls.Add(this.rdoEconomy);
            this.grpTravelClass.Location = new System.Drawing.Point(48, 137);
            this.grpTravelClass.Name = "grpTravelClass";
            this.grpTravelClass.Size = new System.Drawing.Size(705, 110);
            this.grpTravelClass.TabIndex = 4;
            this.grpTravelClass.TabStop = false;
            this.grpTravelClass.Text = "Travel Class";
            // 
            // rdoFirst
            // 
            this.rdoFirst.AutoSize = true;
            this.rdoFirst.Location = new System.Drawing.Point(567, 50);
            this.rdoFirst.Name = "rdoFirst";
            this.rdoFirst.Size = new System.Drawing.Size(89, 36);
            this.rdoFirst.TabIndex = 2;
            this.rdoFirst.TabStop = true;
            this.rdoFirst.Text = "First";
            this.rdoFirst.UseVisualStyleBackColor = true;
            // 
            // rdoBusiness
            // 
            this.rdoBusiness.AutoSize = true;
            this.rdoBusiness.Location = new System.Drawing.Point(300, 50);
            this.rdoBusiness.Name = "rdoBusiness";
            this.rdoBusiness.Size = new System.Drawing.Size(136, 36);
            this.rdoBusiness.TabIndex = 1;
            this.rdoBusiness.TabStop = true;
            this.rdoBusiness.Text = "Business";
            this.rdoBusiness.UseVisualStyleBackColor = true;
            // 
            // rdoEconomy
            // 
            this.rdoEconomy.AutoSize = true;
            this.rdoEconomy.Location = new System.Drawing.Point(45, 50);
            this.rdoEconomy.Name = "rdoEconomy";
            this.rdoEconomy.Size = new System.Drawing.Size(143, 36);
            this.rdoEconomy.TabIndex = 0;
            this.rdoEconomy.TabStop = true;
            this.rdoEconomy.Text = "Economy";
            this.rdoEconomy.UseVisualStyleBackColor = true;
            // 
            // cboSelectMonth
            // 
            this.cboSelectMonth.FormattingEnabled = true;
            this.cboSelectMonth.Location = new System.Drawing.Point(222, 306);
            this.cboSelectMonth.Name = "cboSelectMonth";
            this.cboSelectMonth.Size = new System.Drawing.Size(242, 40);
            this.cboSelectMonth.TabIndex = 5;
            this.cboSelectMonth.Text = "Select a month...";
            // 
            // cboSelectYear
            // 
            this.cboSelectYear.FormattingEnabled = true;
            this.cboSelectYear.Location = new System.Drawing.Point(511, 307);
            this.cboSelectYear.Name = "cboSelectYear";
            this.cboSelectYear.Size = new System.Drawing.Size(242, 40);
            this.cboSelectYear.TabIndex = 6;
            this.cboSelectYear.Text = "Select a year...";
            // 
            // lblTravelDate
            // 
            this.lblTravelDate.AutoSize = true;
            this.lblTravelDate.Location = new System.Drawing.Point(48, 310);
            this.lblTravelDate.Name = "lblTravelDate";
            this.lblTravelDate.Size = new System.Drawing.Size(138, 32);
            this.lblTravelDate.TabIndex = 7;
            this.lblTravelDate.Text = "Travel Date:";
            // 
            // lstDestinationList
            // 
            this.lstDestinationList.AccessibleName = "";
            this.lstDestinationList.FormattingEnabled = true;
            this.lstDestinationList.ItemHeight = 32;
            this.lstDestinationList.Location = new System.Drawing.Point(222, 398);
            this.lstDestinationList.Name = "lstDestinationList";
            this.lstDestinationList.Size = new System.Drawing.Size(531, 164);
            this.lstDestinationList.Sorted = true;
            this.lstDestinationList.TabIndex = 8;
            // 
            // lblDestinations
            // 
            this.lblDestinations.AutoSize = true;
            this.lblDestinations.Location = new System.Drawing.Point(48, 398);
            this.lblDestinations.Name = "lblDestinations";
            this.lblDestinations.Size = new System.Drawing.Size(151, 32);
            this.lblDestinations.TabIndex = 9;
            this.lblDestinations.Text = "Destinations:";
            // 
            // btnMedicalConcerns
            // 
            this.btnMedicalConcerns.BackColor = System.Drawing.Color.LightCoral;
            this.btnMedicalConcerns.Location = new System.Drawing.Point(314, 652);
            this.btnMedicalConcerns.Name = "btnMedicalConcerns";
            this.btnMedicalConcerns.Size = new System.Drawing.Size(150, 79);
            this.btnMedicalConcerns.TabIndex = 10;
            this.btnMedicalConcerns.Text = "Medical Concerns";
            this.btnMedicalConcerns.UseVisualStyleBackColor = false;
            this.btnMedicalConcerns.Click += new System.EventHandler(this.btnMedicalConcerns_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirm.Location = new System.Drawing.Point(511, 652);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(150, 79);
            this.btnConfirm.TabIndex = 11;
            this.btnConfirm.Text = "Confirm Choices";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // chbRandomCountry
            // 
            this.chbRandomCountry.AutoSize = true;
            this.chbRandomCountry.Location = new System.Drawing.Point(368, 590);
            this.chbRandomCountry.Name = "chbRandomCountry";
            this.chbRandomCountry.Size = new System.Drawing.Size(227, 36);
            this.chbRandomCountry.TabIndex = 12;
            this.chbRandomCountry.Text = "Random Country";
            this.chbRandomCountry.UseVisualStyleBackColor = true;
            this.chbRandomCountry.CheckedChanged += new System.EventHandler(this.chbRandomCountry_CheckedChanged);
            // 
            // frmTravelArrangements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(818, 784);
            this.Controls.Add(this.chbRandomCountry);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnMedicalConcerns);
            this.Controls.Add(this.lblDestinations);
            this.Controls.Add(this.lstDestinationList);
            this.Controls.Add(this.lblTravelDate);
            this.Controls.Add(this.cboSelectYear);
            this.Controls.Add(this.cboSelectMonth);
            this.Controls.Add(this.grpTravelClass);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "frmTravelArrangements";
            this.Text = "Travel Arrangements";
            this.Load += new System.EventHandler(this.frmTravelArrangements_Load);
            this.grpTravelClass.ResumeLayout(false);
            this.grpTravelClass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCustomerName;
        private TextBox txtCustomerName;
        private GroupBox grpTravelClass;
        private RadioButton rdoFirst;
        private RadioButton rdoBusiness;
        private RadioButton rdoEconomy;
        private ComboBox cboSelectMonth;
        private ComboBox cboSelectYear;
        private Label lblTravelDate;
        private ListBox lstDestinationList;
        private Label lblDestinations;
        private Button btnMedicalConcerns;
        private Button btnConfirm;
        private CheckBox chbRandomCountry;
    }
}