namespace project_3b
{
    partial class frmHotelReservations
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
            this.lblNumDays = new System.Windows.Forms.Label();
            this.txtNumDays = new System.Windows.Forms.TextBox();
            this.txtCustomerStatus = new System.Windows.Forms.TextBox();
            this.lblCustomerStatus = new System.Windows.Forms.Label();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.lblTransactionSummary = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Location = new System.Drawing.Point(123, 80);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(194, 32);
            this.lblNumDays.TabIndex = 0;
            this.lblNumDays.Text = "Number of Days:";
            // 
            // txtNumDays
            // 
            this.txtNumDays.Location = new System.Drawing.Point(323, 80);
            this.txtNumDays.Name = "txtNumDays";
            this.txtNumDays.Size = new System.Drawing.Size(200, 39);
            this.txtNumDays.TabIndex = 1;
            this.txtNumDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomerStatus
            // 
            this.txtCustomerStatus.Location = new System.Drawing.Point(323, 173);
            this.txtCustomerStatus.Name = "txtCustomerStatus";
            this.txtCustomerStatus.Size = new System.Drawing.Size(200, 39);
            this.txtCustomerStatus.TabIndex = 3;
            this.txtCustomerStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCustomerStatus
            // 
            this.lblCustomerStatus.AutoSize = true;
            this.lblCustomerStatus.Location = new System.Drawing.Point(81, 173);
            this.lblCustomerStatus.Name = "lblCustomerStatus";
            this.lblCustomerStatus.Size = new System.Drawing.Size(236, 32);
            this.lblCustomerStatus.TabIndex = 2;
            this.lblCustomerStatus.Text = "Status (\'G\', \'P\', or \'R\'):";
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(323, 261);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(200, 39);
            this.txtRoomType.TabIndex = 5;
            this.txtRoomType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(12, 261);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(305, 32);
            this.lblRoomType.TabIndex = 4;
            this.lblRoomType.Text = "Executive Room (\'Y\', or \'N\'):";
            // 
            // txtSummary
            // 
            this.txtSummary.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtSummary.Location = new System.Drawing.Point(575, 77);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ReadOnly = true;
            this.txtSummary.Size = new System.Drawing.Size(200, 225);
            this.txtSummary.TabIndex = 6;
            this.txtSummary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTransactionSummary
            // 
            this.lblTransactionSummary.AutoSize = true;
            this.lblTransactionSummary.Location = new System.Drawing.Point(557, 31);
            this.lblTransactionSummary.Name = "lblTransactionSummary";
            this.lblTransactionSummary.Size = new System.Drawing.Size(242, 32);
            this.lblTransactionSummary.TabIndex = 7;
            this.lblTransactionSummary.Text = "Transaction Summary";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.LightCoral;
            this.btnConfirm.Location = new System.Drawing.Point(323, 342);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(200, 69);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Yellow;
            this.btnExit.Location = new System.Drawing.Point(575, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 69);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGreen;
            this.btnClear.Location = new System.Drawing.Point(81, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 69);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmHotelReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 455);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblTransactionSummary);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.txtCustomerStatus);
            this.Controls.Add(this.lblCustomerStatus);
            this.Controls.Add(this.txtNumDays);
            this.Controls.Add(this.lblNumDays);
            this.Name = "frmHotelReservations";
            this.Text = "Hotel Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumDays;
        private TextBox txtNumDays;
        private TextBox txtCustomerStatus;
        private Label lblCustomerStatus;
        private TextBox txtRoomType;
        private Label lblRoomType;
        private TextBox txtSummary;
        private Label lblTransactionSummary;
        private Button btnConfirm;
        private Button btnExit;
        private Button btnClear;
    }
}