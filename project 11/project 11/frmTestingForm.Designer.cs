namespace project_11
{
    partial class frmTestingForm
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
            this.lblTesters = new System.Windows.Forms.Label();
            this.lstTesterList = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblAmerican = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtAmerican = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTesters
            // 
            this.lblTesters.AutoSize = true;
            this.lblTesters.Location = new System.Drawing.Point(70, 23);
            this.lblTesters.Name = "lblTesters";
            this.lblTesters.Size = new System.Drawing.Size(92, 32);
            this.lblTesters.TabIndex = 11;
            this.lblTesters.Text = "Testers:";
            // 
            // lstTesterList
            // 
            this.lstTesterList.AccessibleName = "";
            this.lstTesterList.FormattingEnabled = true;
            this.lstTesterList.ItemHeight = 32;
            this.lstTesterList.Location = new System.Drawing.Point(192, 23);
            this.lstTesterList.Name = "lstTesterList";
            this.lstTesterList.Size = new System.Drawing.Size(531, 164);
            this.lstTesterList.Sorted = true;
            this.lstTesterList.TabIndex = 50;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(378, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 81);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmit.Location = new System.Drawing.Point(378, 302);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 81);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(533, 209);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(90, 32);
            this.lblEnglish.TabIndex = 53;
            this.lblEnglish.Text = "English";
            // 
            // lblAmerican
            // 
            this.lblAmerican.AutoSize = true;
            this.lblAmerican.Location = new System.Drawing.Point(279, 209);
            this.lblAmerican.Name = "lblAmerican";
            this.lblAmerican.Size = new System.Drawing.Size(114, 32);
            this.lblAmerican.TabIndex = 52;
            this.lblAmerican.Text = "American";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(477, 244);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(200, 39);
            this.txtEnglish.TabIndex = 55;
            // 
            // txtAmerican
            // 
            this.txtAmerican.Location = new System.Drawing.Point(236, 244);
            this.txtAmerican.Name = "txtAmerican";
            this.txtAmerican.ReadOnly = true;
            this.txtAmerican.Size = new System.Drawing.Size(200, 39);
            this.txtAmerican.TabIndex = 54;
            // 
            // frmTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 513);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblAmerican);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtAmerican);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTesters);
            this.Controls.Add(this.lstTesterList);
            this.Name = "frmTestingForm";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.frmTestingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTesters;
        private ListBox lstTesterList;
        private Button btnExit;
        private Button btnSubmit;
        private Label lblEnglish;
        private Label lblAmerican;
        private TextBox txtEnglish;
        private TextBox txtAmerican;
    }
}