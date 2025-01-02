using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;
using Perhotelan.Model.Repository;
using Perhotelan.View;
using Perhotelan.Controller;

namespace Perhotelan.View
{
    public partial class frmPrivacy : Form
    {
        private int _userId;
        public frmPrivacy(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch searchForm = new frmSearch(_userId);
            SwitchForm(this, searchForm);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking bookingForm = new frmBooking(_userId);
            SwitchForm(this, bookingForm);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainMenu menuForm = new frmMainMenu(_userId);
            SwitchForm(this, menuForm);
        }
        public static void SwitchForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();       // Sembunyikan form sekarang
            newForm.ShowDialog();     // Tampilkan form baru sebagai dialog
            currentForm.Show();       // Kembalikan form lama jika diperlukan
        }
    }
}
