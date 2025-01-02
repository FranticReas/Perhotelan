using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;
using Perhotelan.Model.Repository;
using Perhotelan.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Perhotelan.View
{
    public partial class frmProfil : Form
    {
        private int _userId;
        public frmProfil(int userId)
        {
            _userId = userId;
            InitializeComponent();
            InitializeLoadProfile();
        }
        private void InitializeLoadProfile()
        {
            SuspendLayout();

            // Gunakan metode AddCard untuk menambahkan komponen profil
            AddCard();

            ResumeLayout(false);
        }
        private void AddCard()
        {
            // Panel utama untuk kartu profil
            Panel card = new Panel
            {
                Size = new Size(300, 200),
                Location = new Point(30, 70),
                Margin = new Padding(5),
            };

            // PictureBox untuk gambar profil
            PictureBox pbProfile = new PictureBox
            {
                Size = new Size(70, 70),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile("C:/Users/desir/Desktop/Tugas/Kuliah/s3/Pemograman 2/UTS/Perhotelan/Perhotelan/asset/profil.png") // Pastikan path ini benar
            };
            card.Controls.Add(pbProfile);

            // Label untuk nama
            Label lblName = new Label
            {
                Location = new Point(90, 15),
                AutoSize = true,
                Font = new Font("Montserrat", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 70, 60),
                Text = " " // Placeholder, diisi dari database
            };
            card.Controls.Add(lblName);

            // Label untuk email
            Label lblEmail = new Label
            {
                Location = new Point(90, 38),
                AutoSize = true,
                Font = new Font("Montserrat", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(17, 70, 60),
                Text = " " // Placeholder, diisi dari database
            };
            card.Controls.Add(lblEmail);

            // Label untuk nomor HP
            Label lblPhoneNumber = new Label
            {
                Location = new Point(90, 60),
                AutoSize = true,
                Font = new Font("Montserrat", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(17, 70, 60),
                Text = " " // Placeholder, diisi dari database
            };
            card.Controls.Add(lblPhoneNumber);

            // Tambahkan panel ke form
            Controls.Add(card);
            // Ambil data dari database
            try
            {
                using (DdContext context = new DdContext())
                {
                    string query = "SELECT username, email, phoneNumber FROM User WHERE userId = @UserId";
                    using (SQLiteCommand command = new SQLiteCommand(query, context.Conn))
                    {
                        command.Parameters.AddWithValue("@UserId", _userId);

                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblName.Text += reader["username"].ToString();
                                lblEmail.Text += reader["email"].ToString();
                                lblPhoneNumber.Text += reader["phoneNumber"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Data pengguna tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi error saat memuat profil: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            frmMainMenu menuForm = new frmMainMenu(_userId);
            SwitchForm(this, menuForm);
        }
        private void btnBooking_Click_1(object sender, EventArgs e)
        {
            frmBooking bookingForm = new frmBooking(_userId);
            SwitchForm(this, bookingForm);
        }
        public static void SwitchForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();       // Sembunyikan form sekarang
            newForm.ShowDialog();     // Tampilkan form baru sebagai dialog
            currentForm.Show();       // Kembalikan form lama jika diperlukan
        }
        private void flpMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblHotel_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnBooking2_Click(object sender, EventArgs e)
        {
            frmBooking bookingForm = new frmBooking(_userId);
            SwitchForm(this, bookingForm);
        }
        private void btnProfilUpdate_Click(object sender, EventArgs e)
        {
            frmUpdateProfile updateForm = new frmUpdateProfile(_userId);
            SwitchForm(this, updateForm);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            var updateForm = new frmLogin();
            SwitchForm(this, updateForm);
        }
        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            frmPrivacy privacyForm = new frmPrivacy(_userId);
            SwitchForm(this, privacyForm);
        }
    }
}
