namespace project_6b
{
    partial class frmSportParticipation
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.lblAddNewSport = new System.Windows.Forms.Label();
            this.txtSportAddNumParticipants = new System.Windows.Forms.TextBox();
            this.txtSportAddName = new System.Windows.Forms.TextBox();
            this.lblAddSportParticipants = new System.Windows.Forms.Label();
            this.lblAddSportName = new System.Windows.Forms.Label();
            this.btnAddSport = new System.Windows.Forms.Button();
            this.btnRemoveSport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParticipantsName = new System.Windows.Forms.TextBox();
            this.txtNumParticipants = new System.Windows.Forms.TextBox();
            this.txtHighestNumParticipants = new System.Windows.Forms.TextBox();
            this.txtHighestName = new System.Windows.Forms.TextBox();
            this.lblViewHighest = new System.Windows.Forms.Label();
            this.btnViewParticipants = new System.Windows.Forms.Button();
            this.btnViewHighestParticipants = new System.Windows.Forms.Button();
            this.lblSportParticipants = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRemoveSportName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblHighestName = new System.Windows.Forms.Label();
            this.lblHighestParticipants = new System.Windows.Forms.Label();
            this.lblViewSport = new System.Windows.Forms.Label();
            this.lblSportName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 614);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "View all sports";
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.Gold;
            this.btnViewAll.Location = new System.Drawing.Point(404, 659);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(167, 71);
            this.btnViewAll.TabIndex = 1;
            this.btnViewAll.Text = "VIEW ALL";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // lblAddNewSport
            // 
            this.lblAddNewSport.AutoSize = true;
            this.lblAddNewSport.Location = new System.Drawing.Point(172, 33);
            this.lblAddNewSport.Name = "lblAddNewSport";
            this.lblAddNewSport.Size = new System.Drawing.Size(188, 32);
            this.lblAddNewSport.TabIndex = 2;
            this.lblAddNewSport.Text = "Add a new sport";
            // 
            // txtSportAddNumParticipants
            // 
            this.txtSportAddNumParticipants.Location = new System.Drawing.Point(165, 132);
            this.txtSportAddNumParticipants.Name = "txtSportAddNumParticipants";
            this.txtSportAddNumParticipants.Size = new System.Drawing.Size(200, 39);
            this.txtSportAddNumParticipants.TabIndex = 3;
            this.txtSportAddNumParticipants.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSportAddName
            // 
            this.txtSportAddName.Location = new System.Drawing.Point(165, 77);
            this.txtSportAddName.Name = "txtSportAddName";
            this.txtSportAddName.Size = new System.Drawing.Size(200, 39);
            this.txtSportAddName.TabIndex = 4;
            this.txtSportAddName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAddSportParticipants
            // 
            this.lblAddSportParticipants.AutoSize = true;
            this.lblAddSportParticipants.Location = new System.Drawing.Point(23, 135);
            this.lblAddSportParticipants.Name = "lblAddSportParticipants";
            this.lblAddSportParticipants.Size = new System.Drawing.Size(140, 32);
            this.lblAddSportParticipants.TabIndex = 5;
            this.lblAddSportParticipants.Text = "Participants:";
            // 
            // lblAddSportName
            // 
            this.lblAddSportName.AutoSize = true;
            this.lblAddSportName.Location = new System.Drawing.Point(76, 80);
            this.lblAddSportName.Name = "lblAddSportName";
            this.lblAddSportName.Size = new System.Drawing.Size(83, 32);
            this.lblAddSportName.TabIndex = 6;
            this.lblAddSportName.Text = "Name:";
            // 
            // btnAddSport
            // 
            this.btnAddSport.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddSport.Location = new System.Drawing.Point(182, 189);
            this.btnAddSport.Name = "btnAddSport";
            this.btnAddSport.Size = new System.Drawing.Size(167, 71);
            this.btnAddSport.TabIndex = 7;
            this.btnAddSport.Text = "ADD";
            this.btnAddSport.UseVisualStyleBackColor = false;
            this.btnAddSport.Click += new System.EventHandler(this.btnAddSport_Click);
            // 
            // btnRemoveSport
            // 
            this.btnRemoveSport.BackColor = System.Drawing.Color.LightCoral;
            this.btnRemoveSport.Location = new System.Drawing.Point(182, 487);
            this.btnRemoveSport.Name = "btnRemoveSport";
            this.btnRemoveSport.Size = new System.Drawing.Size(167, 71);
            this.btnRemoveSport.TabIndex = 8;
            this.btnRemoveSport.Text = "REMOVE";
            this.btnRemoveSport.UseVisualStyleBackColor = false;
            this.btnRemoveSport.Click += new System.EventHandler(this.btnRemoveSport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 9;
            // 
            // txtParticipantsName
            // 
            this.txtParticipantsName.Location = new System.Drawing.Point(608, 77);
            this.txtParticipantsName.Name = "txtParticipantsName";
            this.txtParticipantsName.Size = new System.Drawing.Size(200, 39);
            this.txtParticipantsName.TabIndex = 10;
            this.txtParticipantsName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumParticipants
            // 
            this.txtNumParticipants.Location = new System.Drawing.Point(608, 221);
            this.txtNumParticipants.Name = "txtNumParticipants";
            this.txtNumParticipants.ReadOnly = true;
            this.txtNumParticipants.Size = new System.Drawing.Size(200, 39);
            this.txtNumParticipants.TabIndex = 11;
            this.txtNumParticipants.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHighestNumParticipants
            // 
            this.txtHighestNumParticipants.Location = new System.Drawing.Point(608, 519);
            this.txtHighestNumParticipants.Name = "txtHighestNumParticipants";
            this.txtHighestNumParticipants.ReadOnly = true;
            this.txtHighestNumParticipants.Size = new System.Drawing.Size(200, 39);
            this.txtHighestNumParticipants.TabIndex = 14;
            this.txtHighestNumParticipants.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHighestName
            // 
            this.txtHighestName.Location = new System.Drawing.Point(608, 460);
            this.txtHighestName.Name = "txtHighestName";
            this.txtHighestName.ReadOnly = true;
            this.txtHighestName.Size = new System.Drawing.Size(200, 39);
            this.txtHighestName.TabIndex = 13;
            this.txtHighestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblViewHighest
            // 
            this.lblViewHighest.AutoSize = true;
            this.lblViewHighest.Location = new System.Drawing.Point(462, 322);
            this.lblViewHighest.Name = "lblViewHighest";
            this.lblViewHighest.Size = new System.Drawing.Size(514, 32);
            this.lblViewHighest.TabIndex = 12;
            this.lblViewHighest.Text = "View sport with highest number of participants";
            // 
            // btnViewParticipants
            // 
            this.btnViewParticipants.BackColor = System.Drawing.Color.Yellow;
            this.btnViewParticipants.Location = new System.Drawing.Point(624, 135);
            this.btnViewParticipants.Name = "btnViewParticipants";
            this.btnViewParticipants.Size = new System.Drawing.Size(167, 71);
            this.btnViewParticipants.TabIndex = 15;
            this.btnViewParticipants.Text = "VIEW";
            this.btnViewParticipants.UseVisualStyleBackColor = false;
            this.btnViewParticipants.Click += new System.EventHandler(this.btnViewParticipants_Click);
            // 
            // btnViewHighestParticipants
            // 
            this.btnViewHighestParticipants.BackColor = System.Drawing.Color.Yellow;
            this.btnViewHighestParticipants.Location = new System.Drawing.Point(624, 369);
            this.btnViewHighestParticipants.Name = "btnViewHighestParticipants";
            this.btnViewHighestParticipants.Size = new System.Drawing.Size(167, 71);
            this.btnViewHighestParticipants.TabIndex = 16;
            this.btnViewHighestParticipants.Text = "VIEW";
            this.btnViewHighestParticipants.UseVisualStyleBackColor = false;
            this.btnViewHighestParticipants.Click += new System.EventHandler(this.btnViewHighestParticipants_Click);
            // 
            // lblSportParticipants
            // 
            this.lblSportParticipants.AutoSize = true;
            this.lblSportParticipants.Location = new System.Drawing.Point(462, 224);
            this.lblSportParticipants.Name = "lblSportParticipants";
            this.lblSportParticipants.Size = new System.Drawing.Size(140, 32);
            this.lblSportParticipants.TabIndex = 18;
            this.lblSportParticipants.Text = "Participants:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 32);
            this.label9.TabIndex = 23;
            this.label9.Text = "Name:";
            // 
            // txtRemoveSportName
            // 
            this.txtRemoveSportName.Location = new System.Drawing.Point(165, 433);
            this.txtRemoveSportName.Name = "txtRemoveSportName";
            this.txtRemoveSportName.Size = new System.Drawing.Size(200, 39);
            this.txtRemoveSportName.TabIndex = 21;
            this.txtRemoveSportName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 389);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(180, 32);
            this.label11.TabIndex = 19;
            this.label11.Text = "Remove a sport";
            // 
            // lblHighestName
            // 
            this.lblHighestName.AutoSize = true;
            this.lblHighestName.Location = new System.Drawing.Point(526, 463);
            this.lblHighestName.Name = "lblHighestName";
            this.lblHighestName.Size = new System.Drawing.Size(76, 32);
            this.lblHighestName.TabIndex = 24;
            this.lblHighestName.Text = "Sport:";
            // 
            // lblHighestParticipants
            // 
            this.lblHighestParticipants.AutoSize = true;
            this.lblHighestParticipants.Location = new System.Drawing.Point(462, 522);
            this.lblHighestParticipants.Name = "lblHighestParticipants";
            this.lblHighestParticipants.Size = new System.Drawing.Size(140, 32);
            this.lblHighestParticipants.TabIndex = 25;
            this.lblHighestParticipants.Text = "Participants:";
            // 
            // lblViewSport
            // 
            this.lblViewSport.AutoSize = true;
            this.lblViewSport.Location = new System.Drawing.Point(462, 33);
            this.lblViewSport.Name = "lblViewSport";
            this.lblViewSport.Size = new System.Drawing.Size(493, 32);
            this.lblViewSport.TabIndex = 26;
            this.lblViewSport.Text = "View number of participants for which sport?";
            // 
            // lblSportName
            // 
            this.lblSportName.AutoSize = true;
            this.lblSportName.Location = new System.Drawing.Point(526, 80);
            this.lblSportName.Name = "lblSportName";
            this.lblSportName.Size = new System.Drawing.Size(76, 32);
            this.lblSportName.TabIndex = 27;
            this.lblSportName.Text = "Sport:";
            // 
            // frmSportParticipation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1000, 759);
            this.Controls.Add(this.lblSportName);
            this.Controls.Add(this.lblViewSport);
            this.Controls.Add(this.lblHighestParticipants);
            this.Controls.Add(this.lblHighestName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRemoveSportName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSportParticipants);
            this.Controls.Add(this.btnViewHighestParticipants);
            this.Controls.Add(this.btnViewParticipants);
            this.Controls.Add(this.txtHighestNumParticipants);
            this.Controls.Add(this.txtHighestName);
            this.Controls.Add(this.lblViewHighest);
            this.Controls.Add(this.txtNumParticipants);
            this.Controls.Add(this.txtParticipantsName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRemoveSport);
            this.Controls.Add(this.btnAddSport);
            this.Controls.Add(this.lblAddSportName);
            this.Controls.Add(this.lblAddSportParticipants);
            this.Controls.Add(this.txtSportAddName);
            this.Controls.Add(this.txtSportAddNumParticipants);
            this.Controls.Add(this.lblAddNewSport);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.label1);
            this.Name = "frmSportParticipation";
            this.Text = "Sport Participation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnViewAll;
        private Label lblAddNewSport;
        private TextBox txtSportAddNumParticipants;
        private TextBox txtSportAddName;
        private Label lblAddSportParticipants;
        private Label lblAddSportName;
        private Button btnAddSport;
        private Button btnRemoveSport;
        private Label label5;
        private TextBox txtParticipantsName;
        private TextBox txtNumParticipants;
        private TextBox txtHighestNumParticipants;
        private TextBox txtHighestName;
        private Label lblViewHighest;
        private Button btnViewParticipants;
        private Button btnViewHighestParticipants;
        private Label lblSportParticipants;
        private Label label9;
        private TextBox txtRemoveSportName;
        private Label label11;
        private Label lblHighestName;
        private Label lblHighestParticipants;
        private Label lblViewSport;
        private Label lblSportName;
    }
}