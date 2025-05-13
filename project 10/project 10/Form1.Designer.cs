namespace project_10
{
    partial class frmAirlineFlights
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
            this.lblFlightList = new System.Windows.Forms.Label();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.lblAddFlightCode = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.txtAddFlightCode = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.lblAddPassenger = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblPassengerList = new System.Windows.Forms.Label();
            this.lblFlightCode = new System.Windows.Forms.Label();
            this.txtFlightCode = new System.Windows.Forms.TextBox();
            this.btnViewPassengers = new System.Windows.Forms.Button();
            this.txtAirlineName = new System.Windows.Forms.TextBox();
            this.lblAirlineName = new System.Windows.Forms.Label();
            this.gboViewBy = new System.Windows.Forms.GroupBox();
            this.rdoDomestic = new System.Windows.Forms.RadioButton();
            this.rdoInternational = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.btnViewFlights = new System.Windows.Forms.Button();
            this.gboViewBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFlightList
            // 
            this.lblFlightList.AutoSize = true;
            this.lblFlightList.Location = new System.Drawing.Point(290, 431);
            this.lblFlightList.Name = "lblFlightList";
            this.lblFlightList.Size = new System.Drawing.Size(116, 32);
            this.lblFlightList.TabIndex = 1;
            this.lblFlightList.Text = "Flight List";
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddPassenger.Location = new System.Drawing.Point(269, 299);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(167, 81);
            this.btnAddPassenger.TabIndex = 54;
            this.btnAddPassenger.Text = "ADD";
            this.btnAddPassenger.UseVisualStyleBackColor = false;
            this.btnAddPassenger.Click += new System.EventHandler(this.btnAddPassenger_Click);
            // 
            // lblAddFlightCode
            // 
            this.lblAddFlightCode.AutoSize = true;
            this.lblAddFlightCode.Location = new System.Drawing.Point(91, 193);
            this.lblAddFlightCode.Name = "lblAddFlightCode";
            this.lblAddFlightCode.Size = new System.Drawing.Size(142, 32);
            this.lblAddFlightCode.TabIndex = 57;
            this.lblAddFlightCode.Text = "Flight Code:";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(91, 248);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(83, 32);
            this.lblAddName.TabIndex = 56;
            this.lblAddName.Text = "Name:";
            // 
            // txtAddFlightCode
            // 
            this.txtAddFlightCode.Location = new System.Drawing.Point(252, 190);
            this.txtAddFlightCode.Name = "txtAddFlightCode";
            this.txtAddFlightCode.Size = new System.Drawing.Size(200, 39);
            this.txtAddFlightCode.TabIndex = 51;
            this.txtAddFlightCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(252, 245);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(200, 39);
            this.txtAddName.TabIndex = 52;
            this.txtAddName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddPassenger
            // 
            this.lblAddPassenger.AutoSize = true;
            this.lblAddPassenger.Location = new System.Drawing.Point(258, 145);
            this.lblAddPassenger.Name = "lblAddPassenger";
            this.lblAddPassenger.Size = new System.Drawing.Size(191, 32);
            this.lblAddPassenger.TabIndex = 55;
            this.lblAddPassenger.Text = "Add a passenger";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(701, 582);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 81);
            this.btnExit.TabIndex = 59;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblPassengerList
            // 
            this.lblPassengerList.AutoSize = true;
            this.lblPassengerList.Location = new System.Drawing.Point(701, 145);
            this.lblPassengerList.Name = "lblPassengerList";
            this.lblPassengerList.Size = new System.Drawing.Size(162, 32);
            this.lblPassengerList.TabIndex = 60;
            this.lblPassengerList.Text = "Passenger List";
            // 
            // lblFlightCode
            // 
            this.lblFlightCode.AutoSize = true;
            this.lblFlightCode.Location = new System.Drawing.Point(523, 194);
            this.lblFlightCode.Name = "lblFlightCode";
            this.lblFlightCode.Size = new System.Drawing.Size(142, 32);
            this.lblFlightCode.TabIndex = 63;
            this.lblFlightCode.Text = "Flight Code:";
            // 
            // txtFlightCode
            // 
            this.txtFlightCode.Location = new System.Drawing.Point(684, 191);
            this.txtFlightCode.Name = "txtFlightCode";
            this.txtFlightCode.Size = new System.Drawing.Size(200, 39);
            this.txtFlightCode.TabIndex = 62;
            this.txtFlightCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnViewPassengers
            // 
            this.btnViewPassengers.BackColor = System.Drawing.Color.Yellow;
            this.btnViewPassengers.Location = new System.Drawing.Point(701, 248);
            this.btnViewPassengers.Name = "btnViewPassengers";
            this.btnViewPassengers.Size = new System.Drawing.Size(167, 81);
            this.btnViewPassengers.TabIndex = 64;
            this.btnViewPassengers.Text = "VIEW";
            this.btnViewPassengers.UseVisualStyleBackColor = false;
            this.btnViewPassengers.Click += new System.EventHandler(this.btnViewPassengers_Click);
            // 
            // txtAirlineName
            // 
            this.txtAirlineName.Location = new System.Drawing.Point(255, 66);
            this.txtAirlineName.Name = "txtAirlineName";
            this.txtAirlineName.ReadOnly = true;
            this.txtAirlineName.Size = new System.Drawing.Size(629, 39);
            this.txtAirlineName.TabIndex = 66;
            this.txtAirlineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAirlineName
            // 
            this.lblAirlineName.AutoSize = true;
            this.lblAirlineName.Location = new System.Drawing.Point(91, 69);
            this.lblAirlineName.Name = "lblAirlineName";
            this.lblAirlineName.Size = new System.Drawing.Size(158, 32);
            this.lblAirlineName.TabIndex = 65;
            this.lblAirlineName.Text = "Airline Name:";
            // 
            // gboViewBy
            // 
            this.gboViewBy.Controls.Add(this.rdoDomestic);
            this.gboViewBy.Controls.Add(this.rdoInternational);
            this.gboViewBy.Controls.Add(this.rdoAll);
            this.gboViewBy.Location = new System.Drawing.Point(91, 466);
            this.gboViewBy.Name = "gboViewBy";
            this.gboViewBy.Size = new System.Drawing.Size(574, 101);
            this.gboViewBy.TabIndex = 67;
            this.gboViewBy.TabStop = false;
            this.gboViewBy.Text = "View";
            // 
            // rdoDomestic
            // 
            this.rdoDomestic.AutoSize = true;
            this.rdoDomestic.Location = new System.Drawing.Point(406, 38);
            this.rdoDomestic.Name = "rdoDomestic";
            this.rdoDomestic.Size = new System.Drawing.Size(145, 36);
            this.rdoDomestic.TabIndex = 2;
            this.rdoDomestic.TabStop = true;
            this.rdoDomestic.Text = "Domestic";
            this.rdoDomestic.UseVisualStyleBackColor = true;
            // 
            // rdoInternational
            // 
            this.rdoInternational.AutoSize = true;
            this.rdoInternational.Location = new System.Drawing.Point(170, 38);
            this.rdoInternational.Name = "rdoInternational";
            this.rdoInternational.Size = new System.Drawing.Size(180, 36);
            this.rdoInternational.TabIndex = 1;
            this.rdoInternational.TabStop = true;
            this.rdoInternational.Text = "International";
            this.rdoInternational.UseVisualStyleBackColor = true;
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(30, 38);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(72, 36);
            this.rdoAll.TabIndex = 0;
            this.rdoAll.TabStop = true;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // btnViewFlights
            // 
            this.btnViewFlights.BackColor = System.Drawing.Color.Gold;
            this.btnViewFlights.Location = new System.Drawing.Point(269, 582);
            this.btnViewFlights.Name = "btnViewFlights";
            this.btnViewFlights.Size = new System.Drawing.Size(167, 81);
            this.btnViewFlights.TabIndex = 68;
            this.btnViewFlights.Text = "VIEW";
            this.btnViewFlights.UseVisualStyleBackColor = false;
            this.btnViewFlights.Click += new System.EventHandler(this.btnViewFlights_Click);
            // 
            // frmAirlineFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(961, 706);
            this.Controls.Add(this.btnViewFlights);
            this.Controls.Add(this.gboViewBy);
            this.Controls.Add(this.txtAirlineName);
            this.Controls.Add(this.lblAirlineName);
            this.Controls.Add(this.btnViewPassengers);
            this.Controls.Add(this.lblFlightCode);
            this.Controls.Add(this.txtFlightCode);
            this.Controls.Add(this.lblPassengerList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddPassenger);
            this.Controls.Add(this.lblAddFlightCode);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.txtAddFlightCode);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.lblAddPassenger);
            this.Controls.Add(this.lblFlightList);
            this.Name = "frmAirlineFlights";
            this.Text = "Airline Flights";
            this.Load += new System.EventHandler(this.frmAirlineFlights_Load);
            this.gboViewBy.ResumeLayout(false);
            this.gboViewBy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFlightList;
        private Button btnAddPassenger;
        private Label lblAddFlightCode;
        private Label lblAddName;
        private TextBox txtAddFlightCode;
        private TextBox txtAddName;
        private Label lblAddPassenger;
        private Button btnExit;
        private Label lblPassengerList;
        private Label lblFlightCode;
        private TextBox txtFlightCode;
        private Button btnViewPassengers;
        private TextBox txtAirlineName;
        private Label lblAirlineName;
        private GroupBox gboViewBy;
        private RadioButton rdoDomestic;
        private RadioButton rdoInternational;
        private RadioButton rdoAll;
        private Button btnViewFlights;
    }
}