namespace project_1b
{
    partial class frmAddMultiply
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
            this.lblValueA = new System.Windows.Forms.Label();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.lblValueB = new System.Windows.Forms.Label();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.lblValueC = new System.Windows.Forms.Label();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.btnResult1 = new System.Windows.Forms.Button();
            this.btnResult2 = new System.Windows.Forms.Button();
            this.txtValue4 = new System.Windows.Forms.TextBox();
            this.txtValue5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValueA
            // 
            this.lblValueA.AutoSize = true;
            this.lblValueA.Location = new System.Drawing.Point(169, 98);
            this.lblValueA.Name = "lblValueA";
            this.lblValueA.Size = new System.Drawing.Size(99, 32);
            this.lblValueA.TabIndex = 0;
            this.lblValueA.Text = "Value A:";
            this.lblValueA.Click += new System.EventHandler(this.lblValueA_Click);
            // 
            // txtValue1
            // 
            this.txtValue1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValue1.Location = new System.Drawing.Point(274, 88);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(110, 50);
            this.txtValue1.TabIndex = 1;
            this.txtValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValueB
            // 
            this.lblValueB.AutoSize = true;
            this.lblValueB.Location = new System.Drawing.Point(438, 101);
            this.lblValueB.Name = "lblValueB";
            this.lblValueB.Size = new System.Drawing.Size(98, 32);
            this.lblValueB.TabIndex = 2;
            this.lblValueB.Text = "Value B:";
            // 
            // txtValue2
            // 
            this.txtValue2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValue2.Location = new System.Drawing.Point(542, 88);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(110, 50);
            this.txtValue2.TabIndex = 3;
            this.txtValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValueC
            // 
            this.lblValueC.AutoSize = true;
            this.lblValueC.Location = new System.Drawing.Point(703, 98);
            this.lblValueC.Name = "lblValueC";
            this.lblValueC.Size = new System.Drawing.Size(99, 32);
            this.lblValueC.TabIndex = 4;
            this.lblValueC.Text = "Value C:";
            // 
            // txtValue3
            // 
            this.txtValue3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValue3.Location = new System.Drawing.Point(808, 88);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(110, 50);
            this.txtValue3.TabIndex = 5;
            this.txtValue3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResult1
            // 
            this.btnResult1.BackColor = System.Drawing.Color.Yellow;
            this.btnResult1.Location = new System.Drawing.Point(322, 171);
            this.btnResult1.Name = "btnResult1";
            this.btnResult1.Size = new System.Drawing.Size(214, 90);
            this.btnResult1.TabIndex = 6;
            this.btnResult1.Text = "A + (B * C)";
            this.btnResult1.UseVisualStyleBackColor = false;
            this.btnResult1.Click += new System.EventHandler(this.btnResult1_Click);
            // 
            // btnResult2
            // 
            this.btnResult2.BackColor = System.Drawing.Color.Orange;
            this.btnResult2.Location = new System.Drawing.Point(322, 284);
            this.btnResult2.Name = "btnResult2";
            this.btnResult2.Size = new System.Drawing.Size(214, 90);
            this.btnResult2.TabIndex = 7;
            this.btnResult2.Text = "(A + B) * C";
            this.btnResult2.UseVisualStyleBackColor = false;
            this.btnResult2.Click += new System.EventHandler(this.btnResult2_Click);
            // 
            // txtValue4
            // 
            this.txtValue4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValue4.Location = new System.Drawing.Point(555, 184);
            this.txtValue4.Name = "txtValue4";
            this.txtValue4.Size = new System.Drawing.Size(200, 64);
            this.txtValue4.TabIndex = 8;
            this.txtValue4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValue5
            // 
            this.txtValue5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValue5.Location = new System.Drawing.Point(555, 298);
            this.txtValue5.Name = "txtValue5";
            this.txtValue5.Size = new System.Drawing.Size(200, 64);
            this.txtValue5.TabIndex = 9;
            this.txtValue5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAddMultiply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1153, 420);
            this.Controls.Add(this.txtValue5);
            this.Controls.Add(this.txtValue4);
            this.Controls.Add(this.btnResult2);
            this.Controls.Add(this.btnResult1);
            this.Controls.Add(this.txtValue3);
            this.Controls.Add(this.lblValueC);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.lblValueB);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.lblValueA);
            this.Name = "frmAddMultiply";
            this.Text = "Addition and Multiplication";
            this.Load += new System.EventHandler(this.frmAddMultiply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValueA;
        private TextBox txtValue1;
        private Label lblValueB;
        private TextBox txtValue2;
        private Label lblValueC;
        private TextBox txtValue3;
        private Button btnResult1;
        private Button btnResult2;
        private TextBox txtValue4;
        private TextBox txtValue5;
    }
}