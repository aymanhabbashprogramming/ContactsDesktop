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
    public partial class frmAddEditContact : Form
    {
        public enum enMode { AddNew =  0, Update = 1 };
        private enMode _Mode;
        int _ContactID = 0;
        clsContact _Contact;

        private bool _ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                txtFirstName.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                txtLastName.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number is required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                txtPhone.SelectAll();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
                txtAddress.SelectAll();
                return false;
            }

            if (cbCountries.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a country.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCountries.Focus();
                return false;
            }

            if (dtpDateOfBirth.Value > DateTime.Now)
            {
                MessageBox.Show("Date of Birth cannot be in the future.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDateOfBirth.Focus();
                return false;
            }

            return true;
        }
        private void _FillCountriesInComboBox()
        {
            DataTable dataTable = clsCountry.GetAllCountries();

            foreach (DataRow Row in dataTable.Rows)
            {
                cbCountries.Items.Add(Row["CountryName"]);
            }
        }
        public frmAddEditContact(int ContactID)
        {
            InitializeComponent();
            _ContactID = ContactID;

            if (_ContactID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }

            btnRemoveImage.Visible = (pbContactImage.Image != null);
        }
        private void frmAddEditContact_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _LoadData()
        {
            _FillCountriesInComboBox();
            cbCountries.SelectedIndex = 0;

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Contact";
                _Contact = new clsContact();
                return;
            }

            _Contact = clsContact.Find(_ContactID);

            if (_Contact == null)
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _ContactID);
                this.Close();

                return;
            }

            lblMode.Text = "Edit Contact With ID = " + _ContactID;
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtPhone.Text = _Contact.Phone;
            txtAddress.Text = _Contact.Address;
            txtEmail.Text  = _Contact.Email;
            dtpDateOfBirth.Value = _Contact.DateOfBirth;
            lblContactID.Text = _Contact.ID.ToString();

            if (!string.IsNullOrEmpty(_Contact.ImagePath))
            {
                pbContactImage.Load(_Contact.ImagePath);
            }

            btnRemoveImage.Visible = !string.IsNullOrEmpty(_Contact.ImagePath);
            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.Find(_Contact.CountryID).CountryName);
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);

                pbContactImage.Load(selectedFilePath);
                btnRemoveImage.Visible = (pbContactImage.Image != null);

            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbContactImage.ImageLocation = null;
            btnRemoveImage.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateFields() == false)
            {
                return; 
            }

            int NewCountryID = clsCountry.Find(cbCountries.Text).ID;

            _Contact.FirstName = txtFirstName.Text.Trim();
            _Contact.LastName = txtLastName.Text.Trim();
            _Contact.Email = txtEmail.Text.Trim();
            _Contact.Phone = txtPhone.Text.Trim();
            _Contact.Address = txtAddress.Text.Trim();
            _Contact.DateOfBirth = dtpDateOfBirth.Value;
            _Contact.CountryID = NewCountryID;

            if (pbContactImage.ImageLocation != null)
                _Contact.ImagePath = pbContactImage.ImageLocation;
            else
                _Contact.ImagePath = "";


            if (_Contact.Save())
            {
                MessageBox.Show("Data Saved Successfully.");
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.");
            }

            _Mode = enMode.Update;
            lblMode.Text = "Edit Contact ID = " + _Contact.ID;
            lblContactID.Text = _Contact.ID.ToString();
        }
    }
}
