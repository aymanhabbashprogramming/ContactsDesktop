using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsDesktopPresentation
{
    public partial class frmCountriesList : Form
    {
        public frmCountriesList()
        {
            InitializeComponent();
        }

        private void _RefreshdgvAllCountriesList()
        {
            dgvAllCountries.DataSource = clsCountry.GetAllCountries();
        }
        private void frmCountriesList_Load(object sender, EventArgs e)
        {
            _RefreshdgvAllCountriesList();
        }

        private void btnAddNewCountry_Click(object sender, EventArgs e)
        {
            frmAddEditCountry addEditCountry = new frmAddEditCountry(-1);
            addEditCountry.ShowDialog();
            _RefreshdgvAllCountriesList();
        }

        private void btnResfreshList_Click(object sender, EventArgs e)
        {
            _RefreshdgvAllCountriesList();
        }

        private void btnFindCountry_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCountrytID.Text))
            {
                MessageBox.Show("Please enter a Country ID", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCountrytID.Focus();
                return;
            }

            int CountryID = Convert.ToInt32(txtCountrytID.Text.Trim());

            clsCountry country = clsCountry.Find(CountryID);

            if (country != null)
            {
                dgvAllCountries.DataSource = new List<clsCountry> { country };
                txtCountrytID.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Country not found.");
                txtCountrytID.Text = string.Empty;
                txtCountrytID.Focus();
            }
        }
    }
}
