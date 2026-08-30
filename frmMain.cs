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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnContactsList_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            frmAddEditCountry addEditCountry = new frmAddEditCountry(-1);
            addEditCountry.MdiParent = this;
            addEditCountry.Show();
        }
    }
}
