using Perhotelan.Controller;
using Perhotelan.Model.Context;
using Perhotelan.Model.Repository;
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
    public partial class frmLupaPassword : Form
    {
        public event Action ShowResetPass;
        public frmLupaPassword()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please Enter Your Email");
                return;
            }

            using (var context = new DdContext())
            {
                // Inisialisasi repository dan controller
                var userRepository = new UserRepository(context);

                try
                {
                    userRepository.GenerateSendToken(email);

                    // Setelah token dikirim, buka form reset password
                    frmResetPassword resetPasswordForm = new frmResetPassword(); // Kirim email sebagai parameter ke form reset password
                    this.Hide(); // Sembunyikan form saat ini
                    resetPasswordForm.ShowDialog(); // Tampilkan form reset password
                    this.Show(); // Tampilkan kembali form saat ini setelah form reset password ditutup
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            ShowResetPass?.Invoke();
            DialogResult = DialogResult.OK;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

