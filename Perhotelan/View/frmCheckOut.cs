using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perhotelan.View
{
    public partial class frmCheckOut : Form
    {
        public Action<DateTime> CheckOutDate;
        // Delegate untuk mengirim tanggal check-out
        public Action<DateTime> OnCheckoutDateSelected { get; set; }
        public frmCheckOut()
        {
            InitializeComponent();
            dtpCheckOut.MinDate = DateTime.Now;
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {

        }

        private void lblPickTime_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Ambil tanggal check-out dari DateTimePicker
            DateTime checkoutDate = dtpCheckOut.Value;

            // Panggil delegate untuk meneruskan tanggal
            OnCheckoutDateSelected?.Invoke(checkoutDate);

            // Tutup form
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Tutup form tanpa melakukan apa-apa
            this.Close();
        }
    }
}
