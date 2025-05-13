namespace project_11
{
    partial class frmAmericanToEnglish
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
            this.txtAmerican = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.lblAmerican = new System.Windows.Forms.Label();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.btnNextWord = new System.Windows.Forms.Button();
            this.btnDisplayTesters = new System.Windows.Forms.Button();
            this.lblDisplayTesters = new System.Windows.Forms.Label();
            this.btnTakeTest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAmerican
            // 
            this.txtAmerican.Location = new System.Drawing.Point(67, 101);
            this.txtAmerican.Name = "txtAmerican";
            this.txtAmerican.ReadOnly = true;
            this.txtAmerican.Size = new System.Drawing.Size(200, 39);
            this.txtAmerican.TabIndex = 50;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Location = new System.Drawing.Point(308, 101);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.ReadOnly = true;
            this.txtEnglish.Size = new System.Drawing.Size(200, 39);
            this.txtEnglish.TabIndex = 51;
            // 
            // lblAmerican
            // 
            this.lblAmerican.AutoSize = true;
            this.lblAmerican.Location = new System.Drawing.Point(110, 66);
            this.lblAmerican.Name = "lblAmerican";
            this.lblAmerican.Size = new System.Drawing.Size(114, 32);
            this.lblAmerican.TabIndex = 2;
            this.lblAmerican.Text = "American";
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(364, 66);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(90, 32);
            this.lblEnglish.TabIndex = 3;
            this.lblEnglish.Text = "English";
            // 
            // btnNextWord
            // 
            this.btnNextWord.BackColor = System.Drawing.Color.Yellow;
            this.btnNextWord.Location = new System.Drawing.Point(200, 156);
            this.btnNextWord.Name = "btnNextWord";
            this.btnNextWord.Size = new System.Drawing.Size(167, 81);
            this.btnNextWord.TabIndex = 0;
            this.btnNextWord.Text = "NEXT";
            this.btnNextWord.UseVisualStyleBackColor = false;
            this.btnNextWord.Click += new System.EventHandler(this.btnNextWord_Click);
            // 
            // btnDisplayTesters
            // 
            this.btnDisplayTesters.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDisplayTesters.Location = new System.Drawing.Point(200, 269);
            this.btnDisplayTesters.Name = "btnDisplayTesters";
            this.btnDisplayTesters.Size = new System.Drawing.Size(167, 81);
            this.btnDisplayTesters.TabIndex = 1;
            this.btnDisplayTesters.Text = "DISPLAY TESTERS";
            this.btnDisplayTesters.UseVisualStyleBackColor = false;
            this.btnDisplayTesters.Click += new System.EventHandler(this.btnDisplayTesters_Click);
            // 
            // lblDisplayTesters
            // 
            this.lblDisplayTesters.AutoSize = true;
            this.lblDisplayTesters.Location = new System.Drawing.Point(704, 108);
            this.lblDisplayTesters.Name = "lblDisplayTesters";
            this.lblDisplayTesters.Size = new System.Drawing.Size(0, 32);
            this.lblDisplayTesters.TabIndex = 57;
            // 
            // btnTakeTest
            // 
            this.btnTakeTest.BackColor = System.Drawing.Color.LightGreen;
            this.btnTakeTest.Location = new System.Drawing.Point(200, 379);
            this.btnTakeTest.Name = "btnTakeTest";
            this.btnTakeTest.Size = new System.Drawing.Size(167, 81);
            this.btnTakeTest.TabIndex = 2;
            this.btnTakeTest.Text = "TAKE TEST";
            this.btnTakeTest.UseVisualStyleBackColor = false;
            this.btnTakeTest.Click += new System.EventHandler(this.btnTakeTest_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCoral;
            this.btnExit.Location = new System.Drawing.Point(200, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(167, 81);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAmericanToEnglish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 614);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTakeTest);
            this.Controls.Add(this.lblDisplayTesters);
            this.Controls.Add(this.btnDisplayTesters);
            this.Controls.Add(this.btnNextWord);
            this.Controls.Add(this.lblEnglish);
            this.Controls.Add(this.lblAmerican);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtAmerican);
            this.Name = "frmAmericanToEnglish";
            this.Text = "American to English";
            this.Load += new System.EventHandler(this.frmAmericanToEnglish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAmerican;
        private TextBox txtEnglish;
        private Label lblAmerican;
        private Label lblEnglish;
        private Button btnNextWord;
        private Button btnDisplayTesters;
        private Label lblDisplayTesters;
        private Button btnTakeTest;
        private Button btnExit;
    }
}