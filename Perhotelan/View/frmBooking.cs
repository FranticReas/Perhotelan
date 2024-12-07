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
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();

            IntializedBookingInterface();
        }
        private void IntializedBookingInterface()
        {
            // Sementara
            Image hotelImage = Image.FromFile("asset/images.jpg");
            for (int i = 0; i < 5; i++)
            {
                AddBookingCard("Hotel " + (i + 1), "lokasi - bumi 🗿", "Diproses", hotelImage);
            }
        }
        private void AddBookingCard(string hotelName, string location, string bookingStatus, Image hotelImage)
        {
            Panel card = new Panel
            {
                Size = new Size(348, 150),
                BackColor = Color.White,
                Margin = new Padding(10),
            };

            // PictureBox for the hotel image
            PictureBox pictureBox = new PictureBox
            {
                Image = hotelImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(80, 80),
                Location = new Point(10, 10)
            };
            card.Controls.Add(pictureBox);

            // Hotel name label
            Label hotelNameLabel = new Label
            {
                Text = hotelName,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(100, 10),
                AutoSize = true
            };
            card.Controls.Add(hotelNameLabel);

            // Location label
            Label locationLabel = new Label
            {
                Text = location,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(100, 35),
                AutoSize = true
            };
            card.Controls.Add(locationLabel);

            // Status label
            Label statusLabel = new Label
            {
                Text = bookingStatus,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Green,
                Location = new Point(100, 60),
                AutoSize = true
            };
            card.Controls.Add(statusLabel);

            // Cancel Booking button
            Button cancelButton = new Button
            {
                Text = "Batalkan",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Size = new Size(100, 30),
                Location = new Point(100, 90),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.Green
            };
            cancelButton.FlatAppearance.BorderColor = Color.Green;
            cancelButton.Click += (s, e) =>
            {
                // Show the confirmation dialog
                using (var confirmForm = new frmCancelConfirmation())
                {
                    confirmForm.ShowDialog();
                    if (confirmForm.IsConfirmed)
                    {
                        // Update the status label to "Canceled"
                        statusLabel.Text = "Dibatalkan";
                        statusLabel.ForeColor = Color.Red;
                        // Mengupdate diproses
                        btnOngoing.PerformClick();
                    }
                }
            };
            card.Controls.Add(cancelButton);

            // View Ticket button
            Button viewTicketButton = new Button
            {
                Text = "Lihat Ticket",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Size = new Size(100, 30),
                Location = new Point(210, 90),
                BackColor = Color.Green,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            viewTicketButton.FlatAppearance.BorderSize = 0;
            card.Controls.Add(viewTicketButton);

            // Add the card to the FlowLayoutPanel
            flpBookings.Controls.Add(card);
        }
        private void btnOngoing_Click(object sender, EventArgs e)
        {
            // Mengatur warna tombol
            SetButtonStyles(btnOngoing, btnCompleted, btnCanceled);
            // Filter bookings to show only ongoing bookings
            foreach (Control control in flpBookings.Controls)
            {
                if (control is Panel card)
                {
                    Label statusLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.Contains("Diproses"));
                    card.Visible = statusLabel != null;
                }
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            // Mengatur warna tombol
            SetButtonStyles(btnCompleted, btnOngoing, btnCanceled);
            // Filter bookings to show only completed bookings
            foreach (Control control in flpBookings.Controls)
            {
                if (control is Panel card)
                {
                    Label statusLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.Contains("Selesai"));
                    card.Visible = statusLabel != null;
                }
            }
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            // Mengatur warna tombol
            SetButtonStyles(btnCanceled, btnCompleted, btnOngoing);
            // Filter bookings to show only canceled bookings
            foreach (Control control in flpBookings.Controls)
            {
                if (control is Panel card)
                {
                    Label statusLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.Contains("Dibatalkan"));
                    card.Visible = statusLabel != null;
                }
            }
        }

        private void SetButtonStyles(Button activeButton, params Button[] inactiveButtons)
        {
            // Tombol aktif
            activeButton.BackColor = Color.FromArgb(17, 70, 60);
            activeButton.ForeColor = Color.FromKnownColor(KnownColor.ControlLightLight);

            // Tombol tidak aktif
            foreach (var button in inactiveButtons)
            {
                button.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                button.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void flpBookings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainMenu menuForm = new frmMainMenu();
            SwitchForm(this, menuForm);
        }

        public static void SwitchForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();       // Sembunyikan form sekarang
            newForm.ShowDialog();     // Tampilkan form baru sebagai dialog
            currentForm.Show();       // Kembalikan form lama jika diperlukan
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
