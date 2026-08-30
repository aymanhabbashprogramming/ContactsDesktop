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

            if (_Contact.ImagePath != "")
            {
                pbContactImage.Load(_Contact.ImagePath);
            }

            btnRemoveImage.Visible = (_Contact.ImagePath != "");
            cbCountries.SelectedIndex= cbCountries.FindString(clsCountry.Find(_ContactID).CountryName);
        }




    }
}
