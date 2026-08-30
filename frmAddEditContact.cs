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

        }
    }
}
