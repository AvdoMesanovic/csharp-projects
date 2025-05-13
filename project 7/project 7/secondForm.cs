using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_7
{
    public partial class frmMedicalConcerns : Form
    {
        public frmMedicalConcerns()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Tag = txtMedicalConcerns.Text;
                if (string.IsNullOrEmpty(txtMedicalConcerns.Text))
                {
                    throw new Exception("Please enter any medical concerns" + 
                                         "\n\nIf you don't have any, please enter 'None'");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
