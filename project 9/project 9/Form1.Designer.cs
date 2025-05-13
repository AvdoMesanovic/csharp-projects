namespace project_9
{
    partial class frmCompanyCountryInfo
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
            this.lblRemoveName = new System.Windows.Forms.Label();
            this.txtRemoveName = new System.Windows.Forms.TextBox();
            this.lblRemoveCountry = new System.Windows.Forms.Label();
            this.btnRemoveCountry = new System.Windows.Forms.Button();
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.lblAddCountry = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnViewInfo = new System.Windows.Forms.Button();
            this.lblViewInfoName = new System.Windows.Forms.Label();
            this.txtViewInformation = new System.Windows.Forms.TextBox();
            this.lblViewInfo = new System.Windows.Forms.Label();
            this.btnNumberCountries = new System.Windows.Forms.Button();
            this.btnLargest = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblViewAll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumCountries = new System.Windows.Forms.Label();
            this.txtCountryInformation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblFields = new System.Windows.Forms.Label();
            this.gboSortBy = new System.Windows.Forms.GroupBox();
            this.rdoSize = new System.Windows.Forms.RadioButton();
            this.rdoPopulation = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.gboSortBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemoveName
            // 
            this.lblRemoveName.AutoSize = true;
            this.lblRemoveName.Location = new System.Drawing.Point(33, 422);
            this.lblRemoveName.Name = "lblRemoveName";
            this.lblRemoveName.Size = new System.Drawing.Size(83, 32);
            this.lblRemoveName.TabIndex = 33;
            this.lblRemoveName.Text = "Name:";
            // 
            // txtRemoveName
            // 
            this.txtRemoveName.Location = new System.Drawing.Point(122, 415);
            this.txtRemoveName.Name = "txtRemoveName";
            this.txtRemoveName.Size = new System.Drawing.Size(200, 39);
            this.txtRemoveName.TabIndex = 32;
            this.txtRemoveName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRemoveCountry
            // 
            this.lblRemoveCountry.AutoSize = true;
            this.lblRemoveCountry.Location = new System.Drawing.Point(122, 371);
            this.lblRemoveCountry.Name = "lblRemoveCountry";
            this.lblRemoveCountry.Size = new System.Drawing.Size(207, 32);
            this.lblRemoveCountry.TabIndex = 31;
            this.lblRemoveCountry.Text = "Remove a country";
            // 
            // btnRemoveCountry
            // 
            this.btnRemoveCountry.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemoveCountry.Location = new System.Drawing.Point(139, 470);
            this.btnRemoveCountry.Name = "btnRemoveCountry";
            this.btnRemoveCountry.Size = new System.Drawing.Size(167, 81);
            this.btnRemoveCountry.TabIndex = 30;
            this.btnRemoveCountry.Text = "REMOVE";
            this.btnRemoveCountry.UseVisualStyleBackColor = false;
            this.btnRemoveCountry.Click += new System.EventHandler(this.btnRemoveCountry_Click);
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddCountry.Location = new System.Drawing.Point(137, 246);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(167, 81);
            this.btnAddCountry.TabIndex = 29;
            this.btnAddCountry.Text = "ADD";
            this.btnAddCountry.UseVisualStyleBackColor = false;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // lblAddCountry
            // 
            this.lblAddCountry.AutoSize = true;
            this.lblAddCountry.Location = new System.Drawing.Point(140, 203);
            this.lblAddCountry.Name = "lblAddCountry";
            this.lblAddCountry.Size = new System.Drawing.Size(164, 32);
            this.lblAddCountry.TabIndex = 24;
            this.lblAddCountry.Text = "Add a country";
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.Gold;
            this.btnViewAll.Location = new System.Drawing.Point(140, 639);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(167, 81);
            this.btnViewAll.TabIndex = 37;
            this.btnViewAll.Text = "VIEW ALL";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnViewInfo
            // 
            this.btnViewInfo.BackColor = System.Drawing.Color.Yellow;
            this.btnViewInfo.Location = new System.Drawing.Point(474, 303);
            this.btnViewInfo.Name = "btnViewInfo";
            this.btnViewInfo.Size = new System.Drawing.Size(167, 81);
            this.btnViewInfo.TabIndex = 41;
            this.btnViewInfo.Text = "VIEW";
            this.btnViewInfo.UseVisualStyleBackColor = false;
            this.btnViewInfo.Click += new System.EventHandler(this.btnViewInfo_Click);
            // 
            // lblViewInfoName
            // 
            this.lblViewInfoName.AutoSize = true;
            this.lblViewInfoName.Location = new System.Drawing.Point(367, 245);
            this.lblViewInfoName.Name = "lblViewInfoName";
            this.lblViewInfoName.Size = new System.Drawing.Size(83, 32);
            this.lblViewInfoName.TabIndex = 43;
            this.lblViewInfoName.Text = "Name:";
            // 
            // txtViewInformation
            // 
            this.txtViewInformation.Location = new System.Drawing.Point(456, 245);
            this.txtViewInformation.Name = "txtViewInformation";
            this.txtViewInformation.Size = new System.Drawing.Size(200, 39);
            this.txtViewInformation.TabIndex = 42;
            this.txtViewInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblViewInfo
            // 
            this.lblViewInfo.AutoSize = true;
            this.lblViewInfo.Location = new System.Drawing.Point(481, 173);
            this.lblViewInfo.Name = "lblViewInfo";
            this.lblViewInfo.Size = new System.Drawing.Size(160, 64);
            this.lblViewInfo.TabIndex = 44;
            this.lblViewInfo.Text = "View country \r\n information";
            // 
            // btnNumberCountries
            // 
            this.btnNumberCountries.BackColor = System.Drawing.Color.Yellow;
            this.btnNumberCountries.Location = new System.Drawing.Point(474, 641);
            this.btnNumberCountries.Name = "btnNumberCountries";
            this.btnNumberCountries.Size = new System.Drawing.Size(167, 81);
            this.btnNumberCountries.TabIndex = 45;
            this.btnNumberCountries.Text = "VIEW";
            this.btnNumberCountries.UseVisualStyleBackColor = false;
            this.btnNumberCountries.Click += new System.EventHandler(this.btnNumberCountries_Click);
            // 
            // btnLargest
            // 
            this.btnLargest.BackColor = System.Drawing.Color.Yellow;
            this.btnLargest.Location = new System.Drawing.Point(474, 470);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(167, 81);
            this.btnLargest.TabIndex = 47;
            this.btnLargest.Text = "VIEW";
            this.btnLargest.UseVisualStyleBackColor = false;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Thistle;
            this.btnSort.Location = new System.Drawing.Point(939, 137);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(167, 81);
            this.btnSort.TabIndex = 48;
            this.btnSort.Text = "SORT";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblViewAll
            // 
            this.lblViewAll.AutoSize = true;
            this.lblViewAll.Location = new System.Drawing.Point(122, 597);
            this.lblViewAll.Name = "lblViewAll";
            this.lblViewAll.Size = new System.Drawing.Size(201, 32);
            this.lblViewAll.TabIndex = 50;
            this.lblViewAll.Text = "View all countries";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 51;
            this.label1.Text = "Largest country";
            // 
            // lblNumCountries
            // 
            this.lblNumCountries.AutoSize = true;
            this.lblNumCountries.Location = new System.Drawing.Point(431, 599);
            this.lblNumCountries.Name = "lblNumCountries";
            this.lblNumCountries.Size = new System.Drawing.Size(236, 32);
            this.lblNumCountries.TabIndex = 52;
            this.lblNumCountries.Text = "Number of countries";
            // 
            // txtCountryInformation
            // 
            this.txtCountryInformation.Location = new System.Drawing.Point(717, 344);
            this.txtCountryInformation.Multiline = true;
            this.txtCountryInformation.Name = "txtCountryInformation";
            this.txtCountryInformation.Size = new System.Drawing.Size(597, 378);
            this.txtCountryInformation.TabIndex = 53;
            this.txtCountryInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 32);
            this.label2.TabIndex = 59;
            this.label2.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(231, 90);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(425, 39);
            this.txtCompanyName.TabIndex = 60;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Location = new System.Drawing.Point(982, 235);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(0, 32);
            this.lblFields.TabIndex = 62;
            // 
            // gboSortBy
            // 
            this.gboSortBy.Controls.Add(this.rdoSize);
            this.gboSortBy.Controls.Add(this.rdoPopulation);
            this.gboSortBy.Controls.Add(this.rdoName);
            this.gboSortBy.Location = new System.Drawing.Point(717, 224);
            this.gboSortBy.Name = "gboSortBy";
            this.gboSortBy.Size = new System.Drawing.Size(597, 101);
            this.gboSortBy.TabIndex = 63;
            this.gboSortBy.TabStop = false;
            this.gboSortBy.Text = "Sort countries by";
            // 
            // rdoSize
            // 
            this.rdoSize.AutoSize = true;
            this.rdoSize.Location = new System.Drawing.Point(485, 38);
            this.rdoSize.Name = "rdoSize";
            this.rdoSize.Size = new System.Drawing.Size(88, 36);
            this.rdoSize.TabIndex = 2;
            this.rdoSize.TabStop = true;
            this.rdoSize.Text = "Size";
            this.rdoSize.UseVisualStyleBackColor = true;
            // 
            // rdoPopulation
            // 
            this.rdoPopulation.AutoSize = true;
            this.rdoPopulation.Location = new System.Drawing.Point(230, 38);
            this.rdoPopulation.Name = "rdoPopulation";
            this.rdoPopulation.Size = new System.Drawing.Size(159, 36);
            this.rdoPopulation.TabIndex = 1;
            this.rdoPopulation.TabStop = true;
            this.rdoPopulation.Text = "Population";
            this.rdoPopulation.UseVisualStyleBackColor = true;
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(30, 38);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(109, 36);
            this.rdoName.TabIndex = 0;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // frmCompanyCountryInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1370, 761);
            this.Controls.Add(this.gboSortBy);
            this.Controls.Add(this.lblFields);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCountryInformation);
            this.Controls.Add(this.lblNumCountries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblViewAll);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnLargest);
            this.Controls.Add(this.btnNumberCountries);
            this.Controls.Add(this.lblViewInfo);
            this.Controls.Add(this.lblViewInfoName);
            this.Controls.Add(this.txtViewInformation);
            this.Controls.Add(this.btnViewInfo);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.lblRemoveName);
            this.Controls.Add(this.txtRemoveName);
            this.Controls.Add(this.lblRemoveCountry);
            this.Controls.Add(this.btnRemoveCountry);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.lblAddCountry);
            this.Name = "frmCompanyCountryInfo";
            this.Text = "Company Country Information";
            this.Load += new System.EventHandler(this.frmCompanyCountryInfo_Load);
            this.gboSortBy.ResumeLayout(false);
            this.gboSortBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRemoveName;
        private TextBox txtRemoveName;
        private Label lblRemoveCountry;
        private Button btnRemoveCountry;
        private Button btnAddCountry;
        private Label lblAddCountry;
        private Button btnViewAll;
        private Button btnViewInfo;
        private Label lblViewInfoName;
        private TextBox txtViewInformation;
        private Label lblViewInfo;
        private Button btnNumberCountries;
        private Button btnLargest;
        private Button btnSort;
        private Label lblViewAll;
        private Label label1;
        private Label lblNumCountries;
        private TextBox txtCountryInformation;
        private Label label2;
        private TextBox txtCompanyName;
        private Label lblFields;
        private GroupBox gboSortBy;
        private RadioButton rdoSize;
        private RadioButton rdoPopulation;
        private RadioButton rdoName;
    }
}