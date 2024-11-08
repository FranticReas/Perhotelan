using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perhotelan
{
    public partial class frmCancelConfirmation : Form
    {
        public frmCancelConfirmation()
        {
            InitializeComponent();
        }
        public bool IsConfirmed { get; private set; } = false;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form without confirming
            IsConfirmed = false;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Close the form and confirm the action
            IsConfirmed = true;
            this.Close();
        }
    }
}
