using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_9
{
    public partial class frmNewCountry : Form
    {
        public frmNewCountry()
        {
            InitializeComponent();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            Country c = new Country(txtAddName.Text);
            c.Population = Convert.ToUInt32(txtAddPopulation.Text);
            c.Size = Convert.ToDecimal(txtAddSize.Text);

            Tag = c;

            txtAddName.Clear();
            txtAddPopulation.Clear();
            txtAddSize.Clear();

            MessageBox.Show("Sucessfully added!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
