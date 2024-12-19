using Perhotelan.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Perhotelan.Model.Entity;
using Perhotelan.Model.Context;
using Perhotelan.Model.Repository;
using System.Data.SQLite;

namespace Perhotelan
{
    public partial class frmDaftar : Form
    {
        private SQLiteConnection _conn;

        // constructor
       
        public frmDaftar()
        {
            InitializeComponent();
        }

        private void TxtTglLahir_Leave(object sender, EventArgs e)
        {
            DateTime date;
            if (DateTime.TryParseExact(txtTglLahir.Text, "yyyy/MM/dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                // Date is valid
                txtTglLahir.ForeColor = Color.Black;
            }
            else
            {
                // Show error if date is invalid
                MessageBox.Show("Masukkan teks dalam format YYYY/MM/HH.");
                txtTglLahir.Focus();
                txtTglLahir.ForeColor = Color.Red;
            }
        }

        private void TogglePasswordVisibility(TextBox passwordTextBox, Button showHideButton)
        {
            if (passwordTextBox.PasswordChar == '*')
            {
                passwordTextBox.PasswordChar = '\0'; // Show password
                showHideButton.Text = "🙈"; // Change button to indicate hidden state
            }
            else
            {
                passwordTextBox.PasswordChar = '*'; // Hide password
                showHideButton.Text = "👁"; // Change button to indicate visible state
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txtPass, btnShowPass);
            Controls.Add(btnShowPass);
        }

        private void btnShowPassConfrm_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(txtPassConfrm, btnShowPassConfrm);
            Controls.Add(btnShowPassConfrm);
        }

        private bool isNewData = true;
        private void btnDaftar_Click(object sender, EventArgs e)
        {

            if (txtPass.Text != txtPassConfrm.Text)
            {
                MessageBox.Show("Password dan konfirmasi password tidak cocok.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ambil data dari form
            string username = txtNama.Text;
            string email = txtEmail.Text;
            string password = txtPass.Text;
            string phoneNumber = txtNohp.Text;
            DateTime birthdate = Convert.ToDateTime(txtTglLahir.Text);

            // Buat objek User
           
            // Panggil repository untuk menyimpan data
            using (var context = new DdContext()) // DdContext instance yang akan mengelola koneksi
            {
                User user = new User
                {
                    username = username,
                    email = email,
                    password = password,
                    phoneNumber = phoneNumber,
                    birthdate = birthdate
                };

                var connection = context.Conn; // Mengakses koneksi dari DdContext
                UserRepository userRepository = new UserRepository(context); // Kirimkan koneksi ke repository
                int result = userRepository.Create(user);

                // Tampilkan hasil
                if (result > 0)
                {
                    MessageBox.Show("Pendaftaran berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pendaftaran gagal. Silakan coba lagi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } // Koneksi aka
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtTglLahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNohp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
