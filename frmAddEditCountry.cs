using ContactsBusinessLayer;
using System;
using System.Windows.Forms;

namespace ContactsDesktopPresentation
{
    public partial class frmAddEditCountry : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private clsCountry _Country;
        private int _CountryID;

        public frmAddEditCountry(int CountryID)
        {
            InitializeComponent();
            _CountryID = CountryID;

            if (_CountryID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }

        private bool _ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtCountryName.Text))
            {
                MessageBox.Show("Please enter the country name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCountryName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCountryCode.Text))
            {
                MessageBox.Show("Please enter the country code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCountryCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneCode.Text))
            {
                MessageBox.Show("Please enter the phone code.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneCode.Focus();
                return false;
            }

            return true;
        }

        private void frmAddCountry_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Country";
                _Country = new clsCountry();
                return;
            }

            _Country = clsCountry.Find(_CountryID);

            if (_Country == null)
            {
                MessageBox.Show("This form will be closed because No Country with ID = " + _CountryID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblMode.Text = "Edit Country ID = " + _Country.ID;
            txtCountryCode.Text = _Country.Code;
            txtCountryName.Text = _Country.CountryName;
            txtPhoneCode.Text = _Country.PhoneCode;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInputs())
            {
                return;
            }

            _Country.CountryName = txtCountryName.Text.Trim();
            _Country.PhoneCode = txtPhoneCode.Text.Trim();
            _Country.Code = txtCountryCode.Text.Trim();

            if (_Country.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _Mode = enMode.Update;
                lblMode.Text = "Edit Country ID = " + _Country.ID;
                lblCountryID.Text = _Country.ID.ToString();
            }
            else
            {
                MessageBox.Show("Error: Data Was Not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}