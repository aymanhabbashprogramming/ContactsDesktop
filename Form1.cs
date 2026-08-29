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
    }
}
