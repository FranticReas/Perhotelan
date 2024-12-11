using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perhotelan.View;

namespace Perhotelan.View
{
    public partial class frmCheckIn : Form
    {
        // Delegate untuk mengirim tanggal yang dipilih ke method
        public Action<DateTime> OnDateSelected { get; set; }
        public frmCheckIn(int roomId)
        {
            InitializeComponent();
            dtpCheckIn.MinDate = DateTime.Now;
        }

        private void frmRoomBooking_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // Ambil tanggal check-in dari DateTimePicker
            DateTime checkinDate = dtpCheckIn.Value;

            // Panggil delegate untuk mengirim tanggal yang dipilih
            OnDateSelected?.Invoke(checkinDate);

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
