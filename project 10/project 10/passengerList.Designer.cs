namespace project_10
{
    partial class frmPassengerList
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
            this.txtFlightDetails = new System.Windows.Forms.TextBox();
            this.txtFlightCode = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFlightDetails
            // 
            this.txtFlightDetails.Location = new System.Drawing.Point(187, 114);
            this.txtFlightDetails.Multiline = true;
            this.txtFlightDetails.Name = "txtFlightDetails";
            this.txtFlightDetails.ReadOnly = true;
            this.txtFlightDetails.Size = new System.Drawing.Size(499, 432);
            this.txtFlightDetails.TabIndex = 3;
            this.txtFlightDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFlightCode
            // 
            this.txtFlightCode.Location = new System.Drawing.Point(187, 60);
            this.txtFlightCode.Name = "txtFlightCode";
            this.txtFlightCode.ReadOnly = true;
            this.txtFlightCode.Size = new System.Drawing.Size(499, 39);
            this.txtFlightCode.TabIndex = 2;
            this.txtFlightCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(350, 565);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 81);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPassengerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 684);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtFlightCode);
            this.Controls.Add(this.txtFlightDetails);
            this.Name = "frmPassengerList";
            this.Text = "List of Passengers";
            this.Load += new System.EventHandler(this.frmPassengerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFlightDetails;
        private TextBox txtFlightCode;
        private Button btnExit;
    }
}