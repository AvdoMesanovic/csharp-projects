namespace project_8
{
    partial class frmMedicalConcerns
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
            this.lblMedicalConcerns = new System.Windows.Forms.Label();
            this.txtMedicalConcerns = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMedicalConcerns
            // 
            this.lblMedicalConcerns.AutoSize = true;
            this.lblMedicalConcerns.Location = new System.Drawing.Point(181, 40);
            this.lblMedicalConcerns.MaximumSize = new System.Drawing.Size(275, 0);
            this.lblMedicalConcerns.Name = "lblMedicalConcerns";
            this.lblMedicalConcerns.Size = new System.Drawing.Size(271, 128);
            this.lblMedicalConcerns.TabIndex = 0;
            this.lblMedicalConcerns.Text = "Please enter and submit any medical concerns that might impact your travel plans:" +
    "";
            // 
            // txtMedicalConcerns
            // 
            this.txtMedicalConcerns.Location = new System.Drawing.Point(181, 199);
            this.txtMedicalConcerns.Multiline = true;
            this.txtMedicalConcerns.Name = "txtMedicalConcerns";
            this.txtMedicalConcerns.Size = new System.Drawing.Size(433, 246);
            this.txtMedicalConcerns.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmit.Location = new System.Drawing.Point(464, 470);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 79);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmMedicalConcerns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMedicalConcerns);
            this.Controls.Add(this.lblMedicalConcerns);
            this.Name = "frmMedicalConcerns";
            this.Text = "Medical Concerns";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblMedicalConcerns;
        private TextBox txtMedicalConcerns;
        private Button btnSubmit;
    }
}