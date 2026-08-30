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
        private Form _ActiveForm = null;

        private void OpenForm(Form form)
        {
            if (_ActiveForm != null)
            {
                if (_ActiveForm.GetType() == form.GetType())
                    return;

                _ActiveForm.Close();
            }

            _ActiveForm = form;
            _ActiveForm.MdiParent = this;
            _ActiveForm.Show();
        }

        private void btnContactsList_Click(object sender, EventArgs e)
        {
            OpenForm(new Form1());
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            OpenForm(new frmAddEditCountry(-1));
        }
    }
}
