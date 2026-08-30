using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;


namespace ContactsDesktopPresentation
{
    public partial class Form1 : Form
    {
        private void _RefreshContactsList()
        {
            dgvAllContacts.DataSource= clsContact.GetAllContacts();
        }
        public Form1()
        {
            InitializeComponent();
            _RefreshContactsList();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            frmAddEditContact addEditContact = new frmAddEditContact(-1);
            addEditContact.ShowDialog();
            _RefreshContactsList();
        }

        private void tsmiEditContact_Click(object sender, EventArgs e)
        {
            frmAddEditContact addEditContact = new frmAddEditContact((int)dgvAllContacts.CurrentRow.Cells[0].Value);
            addEditContact.ShowDialog();
            _RefreshContactsList();
        }

        private void tsmiDeleteContac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete contact [" + dgvAllContacts.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)

            {
                if (clsContact.DeleteContact((int)dgvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshContactsList();
                }

                else
                {

                    MessageBox.Show("Contact is not deleted.");
                }

            }
        }

        private void btnResfreshList_Click(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }

        private void btnFindContact_Click(object sender, EventArgs e)
        {
            int ContactID = Convert.ToInt32(txtContactID.Text.Trim());

            clsContact contact = clsContact.Find(ContactID);

            if (contact != null)
            {
                dgvAllContacts.DataSource = new List<clsContact> { contact };
                txtContactID.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Contact not found.");
                txtContactID.Text = string.Empty;
            }
        }
    }
}
