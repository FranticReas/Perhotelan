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
    public partial class frmUpdateProfile : Form
    {
        private int _userId;

        public frmUpdateProfile(int userId)
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
            Panel card = new Panel
            {
                Size = new Size(300, 700),
                Location = new Point(30, 70),
                Margin = new Padding(5),
            };

            PictureBox pbProfile = new PictureBox
            {
                Size = new Size(120, 120),
                Location = new Point(105, 10),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile("profil.png") // Pastikan path ini benar
            };
            card.Controls.Add(pbProfile);

            // Label untuk nama
            Label lblName = new Label
            {
                Location = new Point(70, 152),
                AutoSize = true,
                Font = new Font("Montserrat", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(17, 70, 60),
                Text = " " // Placeholder, diisi dari database
            };
            card.Controls.Add(lblName);

            // Label untuk email
            Label lblEmail = new Label
            {
                Location = new Point(70, 193),
                AutoSize = true,
                Font = new Font("Montserrat", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(17, 70, 60),
                Text = " " // Placeholder, diisi dari database
            };
            card.Controls.Add(lblEmail);

            // Label untuk nomor HP
            Label lblPhoneNumber = new Label
            {
                Location = new Point(70, 234),
                AutoSize = true,
                Font = new Font("Montserrat", 11, FontStyle.Regular),
                ForeColor = Color.FromArgb(17, 70, 60),
                Text = " " // Placeholder, diisi dari database
            };
            card.Controls.Add(lblPhoneNumber);

            Controls.Add(card);

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

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmProfil profilForm = new frmProfil(_userId);
            SwitchForm(this, profilForm);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainMenu menuForm = new frmMainMenu(_userId);
            SwitchForm(this, menuForm);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking bookingForm = new frmBooking(_userId);
            SwitchForm(this, bookingForm);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmEditProfile EditProfileForm = new frmEditProfile(_userId);
            ShowForm(this, EditProfileForm);
        }
        public static void SwitchForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();       // Sembunyikan form sekarang
            newForm.ShowDialog();     // Tampilkan form baru sebagai dialog
            currentForm.Show();       // Kembalikan form lama jika diperlukan
        }

        public static void ShowForm(Form currentForm, Form newForm)
        {
            newForm.ShowDialog();     // Tampilkan form baru sebagai dialog
            currentForm.Show();
        }

       
    }
}

