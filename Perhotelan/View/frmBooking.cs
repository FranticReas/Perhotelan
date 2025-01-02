using Microsoft.VisualBasic.ApplicationServices;
using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;
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
using System.Drawing.Imaging;
using QRCoder;
using Perhotelan.Controller;
using Perhotelan.View;

namespace Perhotelan
{
    public partial class frmBooking : Form
    {
        private int _userId;
        public frmBooking(int userId)
        {
            _userId = userId;
            InitializeComponent();
            InitializedBookingInterface();
            btnOngoing_Click(this, EventArgs.Empty);
        }
        private void InitializedBookingInterface()
        {
            using (DdContext context = new DdContext())
            {
                // Initialize repositories
                var hotelService = new HotelRepository(context);
                var roomService = new RoomRepository(context);
                var transactionService = new TransactionRepository(context);
                var roomController = new RoomController(roomService);
                var hotelController = new HotelController(hotelService);

                // Initialize the TransactionController
                var transactionController = new TransactionController(transactionService);

                try
                {
                    // Fetch all transactions for the logged-in user using the controller
                    var transactions = transactionController.GetTransactionsByUserId(_userId);

                    foreach (var transaction in transactions)
                    {
                        // Fetch the room linked to this transaction using the RoomRepository
                        var room = roomController.GetRoomById(transaction.roomId);
                        if (room == null) continue;

                        // Fetch the hotel linked to the room using the HotelRepository
                        var hotel = hotelController.GetHotelById(room.hotelId);
                        if (hotel == null) continue;

                        // Combine firstname and lastname for the full hotel name
                        string hotelFullName = $"{hotel.firstname} {hotel.lastname}";

                        // Attempt to load the room's image
                        Image hotelImage;
                        if (!string.IsNullOrEmpty(room.imagePath) && File.Exists(room.imagePath))
                        {
                            hotelImage = Image.FromFile(room.imagePath);
                        }
                        else
                        {
                            // Use a default image if no valid image path is found
                            hotelImage = Image.FromFile(Path.Combine("asset", "room1.jpg"));
                        }

                        // Add booking card to the interface
                        AddBookingCard(
                            hotelFullName,     // Combined firstname and lastname
                            hotel.location,    // Location from the `Hotel` table
                            transaction.status, // Status from the `Transaction_` table
                            hotelImage,         // Room image from the `Room` table
                            transaction.transactionId // Passing transactionId
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error initializing booking interface: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddBookingCard(string hotelName, string location, string bookingStatus, Image hotelImage, int transactionId)
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
                ForeColor = bookingStatus == "Dibatalkan" ? Color.Red : Color.Green,  // Set color based on status
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
                        using (DdContext context = new DdContext())
                        {
                            // Initialize the TransactionController and RoomController
                            var transactionService = new TransactionRepository(context);
                            var roomService = new RoomRepository(context);
                            var transactionController = new TransactionController(transactionService);
                            var roomController = new RoomController(roomService);

                            try
                            {
                                // Get the roomId associated with the transaction
                                var roomId = transactionController.GetRoomIdByUserId(_userId);

                                // Update the transaction status to "Cancelled"
                                transactionController.UpdateTransactionStatus(transactionId, "Dibatalkan");

                                // Update the room status to "free" (available)
                                roomController.UpdateRoomStatus(roomId, "free");

                                // Update UI elements
                                statusLabel.Text = "Dibatalkan";
                                statusLabel.ForeColor = Color.Red;

                                // Refresh the ongoing transactions
                                btnOngoing.PerformClick();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error while canceling the transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
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
            // Simpan transactionId ke dalam properti Tag
            viewTicketButton.Tag = transactionId; // Pastikan `transactionId` adalah ID transaksi yang benar

            // Tambahkan event handler untuk tombol
            viewTicketButton.Click += viewTicketButton_Click;
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
                    Label statusLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.Contains("Booked"));
                    if (statusLabel != null)
                    {
                        card.Visible = true;

                        // Remove description label
                        Label descriptionLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "DescriptionLabel");
                        if (descriptionLabel != null)
                        {
                            card.Controls.Remove(descriptionLabel);
                        }

                        // Show "Batalkan" button
                        Button cancelButton = card.Controls.OfType<Button>().FirstOrDefault(btn => btn.Text == "Batalkan");
                        if (cancelButton != null)
                        {
                            cancelButton.Visible = true;
                        }

                        // Show "Lihat Tiket" button
                        Button viewTicketButton = card.Controls.OfType<Button>().FirstOrDefault(btn => btn.Text == "Lihat Ticket");
                        if (viewTicketButton == null)
                        {
                            viewTicketButton = new Button
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
                        }
                    }
                    else
                    {
                        card.Visible = false;
                    }
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
                    if (statusLabel != null)
                    {
                        card.Visible = true;
                        // Set status label's color and description
                        statusLabel.ForeColor = Color.Green;
                        statusLabel.Text = "Selesai";

                        // Add description
                        Label descriptionLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "DescriptionLabel");
                        if (descriptionLabel == null)
                        {
                            descriptionLabel = new Label
                            {
                                Name = "DescriptionLabel",
                                Text = "Yay, telah diselesaikan!",
                                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                                ForeColor = Color.Green,
                                Location = new Point(100, 80),
                                AutoSize = true
                            };
                            card.Controls.Add(descriptionLabel);
                        }

                        // Hide Cancel button
                        Button cancelButton = card.Controls.OfType<Button>().FirstOrDefault(btn => btn.Text == "Batalkan");
                        if (cancelButton != null)
                        {
                            cancelButton.Visible = false;
                        }
                        // Remove "Lihat Tiket" button
                        Button viewTicketButton = card.Controls.OfType<Button>().FirstOrDefault(btn => btn.Text == "Lihat Ticket");
                        if (viewTicketButton != null)
                        {
                            card.Controls.Remove(viewTicketButton);
                        }
                    }
                    else
                    {
                        card.Visible = false;
                    }
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
                    if (statusLabel != null)
                    {
                        card.Visible = true;

                        // Set status label's color and description
                        statusLabel.ForeColor = Color.Red;
                        statusLabel.Text = "Dibatalkan";

                        // Add description
                        Label descriptionLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "DescriptionLabel");
                        if (descriptionLabel == null)
                        {
                            descriptionLabel = new Label
                            {
                                Name = "DescriptionLabel",
                                Text = "Anda telah membatalkan transaksi ini",
                                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                                ForeColor = Color.Red,
                                Location = new Point(100, 80),
                                AutoSize = true
                            };
                            card.Controls.Add(descriptionLabel);
                        }

                        // Remove "Lihat Tiket" button
                        Button viewTicketButton = card.Controls.OfType<Button>().FirstOrDefault(btn => btn.Text == "Lihat Ticket");
                        if (viewTicketButton != null)
                        {
                            card.Controls.Remove(viewTicketButton);
                        }

                        // Hide "Batalkan" button
                        Button cancelButton = card.Controls.OfType<Button>().FirstOrDefault(btn => btn.Text == "Batalkan");
                        if (cancelButton != null)
                        {
                            cancelButton.Visible = false;
                        }
                    }
                    else
                    {
                        card.Visible = false;
                    }
                }
            }
        }
        private void viewTicketButton_Click(object sender, EventArgs e)
        {
            // Ambil detail transaksi
            var transactionId = ((Button)sender).Tag as int?;
            if (transactionId == null) return;

            using (DdContext context = new DdContext())
            {
                var transactionService = new TransactionRepository(context);
                var roomService = new RoomRepository(context);
                var hotelService = new HotelRepository(context);
                var userService = new UserRepository(context); // Assuming you have a UserRepository

                // Ambil transaksi
                var transaction = transactionService.GetTransactionById_(transactionId.Value);
                if (transaction == null)
                {
                    MessageBox.Show("Transaksi tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ambil room berdasarkan roomId dari transaksi
                var room = roomService.GetRoomById(transaction.roomId);
                if (room == null)
                {
                    MessageBox.Show("Room tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Ambil hotel berdasarkan hotelId dari room
                var hotel = hotelService.GetHotelById(room.hotelId);
                string hotelName = hotel != null ? $"{hotel.firstname} {hotel.lastname}" : "Hotel Tidak Diketahui";

                // Retrieve user information
                var user = userService.GetUserById(transaction.userId); // Assuming GetUserById is available
                string userFullName = user != null ? $"{user.username}" : "Nama Tidak Diketahui";
                string userPhoneNumber = user != null ? user.phoneNumber : "Nomor Tidak Diketahui";

                // Membuat form tiket
                Form ticketForm = new Form
                {
                    Text = "Tiket Hotel",
                    Size = new Size(302, 504),
                    StartPosition = FormStartPosition.CenterParent,
                    ControlBox = false
                };

                // Panel Header
                Panel pnlHeader = new Panel
                {
                    BackColor = Color.FromArgb(17, 70, 60),
                    Dock = DockStyle.Top,
                    Size = new Size(302, 43)
                };

                Button btnBack = new Button
                {
                    Text = "<",
                    Font = new Font("Montserrat Black", 16F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(250, 199, 131),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(40, 43)
                };
                btnBack.Click += (s, e2) => ticketForm.Close();

                // Label Hotel
                Label lblHotel = new Label
                {
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Montserrat Black", 24F, FontStyle.Bold),
                    ForeColor = SystemColors.ControlLightLight,
                    Location = new Point(46, -1),
                    Margin = new Padding(0),
                    Name = "lblHotel",
                    Size = new Size(135, 44),
                    TabIndex = 15,
                    Text = "HOTEL"
                };

                // Label Ku
                Label lblKu = new Label
                {
                    AutoEllipsis = true,
                    AutoSize = true,
                    BackColor = Color.Transparent,
                    Font = new Font("Montserrat Black", 24F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(250, 199, 131),
                    Location = new Point(181, 0),
                    Margin = new Padding(0),
                    Name = "lblKu",
                    Size = new Size(68, 44),
                    TabIndex = 16,
                    Text = "KU"
                };

                pnlHeader.Controls.Add(btnBack);
                pnlHeader.Controls.Add(lblHotel);
                pnlHeader.Controls.Add(lblKu);
                ticketForm.Controls.Add(pnlHeader);

                // Tambahkan nama hotel
                Label hotelLabel = new Label
                {
                    Text = hotelName,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(10, 50),
                    AutoSize = true
                };
                ticketForm.Controls.Add(hotelLabel);

                // QR Code
                PictureBox qrCodePictureBox = new PictureBox
                {
                    Size = new Size(150, 150),
                    Location = new Point(70, 80),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                ticketForm.Controls.Add(qrCodePictureBox);

                string qrData = $"Nama     : {userFullName}\n" +
                                $"No HP    : {userPhoneNumber}\n" +
                                $"Check-in : {transaction.checkIn:dd MMMM yyyy}\n" +
                                $"Check-out: {transaction.checkOut:dd MMMM yyyy}";

                // Generate QR Code atau gunakan path default
                try
                {
                    qrCodePictureBox.Image = GenerateQRCode(qrData);
                }
                catch
                {
                    qrCodePictureBox.Image = Image.FromFile(Path.Combine("asset", "QRKode.jpg"));
                }

                // Tambahkan detail transaksi
                Label detailLabel = new Label
                {
                    Text = $"Nama     : {userFullName}\n" +
                           $"No HP    : {userPhoneNumber}\n" +
                           $"Check-in : {transaction.checkIn:dd MMMM yyyy}\n" +
                           $"Check-out: {transaction.checkOut:dd MMMM yyyy}",
                    Font = new Font("Segoe UI", 9),
                    Location = new Point(10, 250),
                    AutoSize = true
                };
                ticketForm.Controls.Add(detailLabel);

                // Tombol selesai
                Button closeButton = new Button
                {
                    Text = "Selesai",
                    Font = new Font("Segoe UI", 10),
                    Size = new Size(250, 40),
                    Location = new Point(20, 430),
                    BackColor = Color.Green,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                closeButton.Click += (s, e2) =>
                {

                    using (DdContext context = new DdContext())
                    {
                        var roomService = new RoomRepository(context);
                        var roomController = new RoomController(roomService);
                        int roomId = transactionService.GetRoomIdByTransaction(_userId);
                        var service = new TransactionRepository(context);
                        var transactionController = new TransactionController(service);
                        transactionController.UpdateTransactionStatus(transactionId.Value, "Selesai");
                        roomController.UpdateRoomStatus(roomId, "free");
                    }
                    flpBookings.Controls.Clear();
                    InitializedBookingInterface();
                    btnOngoing_Click(this, EventArgs.Empty);
                    ticketForm.Close();
                };
                ticketForm.Controls.Add(closeButton);

                // Tampilkan form
                ticketForm.ShowDialog();
            }
        }

        private Image GenerateQRCode(string qrData)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrCodeImage = qrCode.GetGraphic(20);
                    return qrCodeImage;
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
            frmMainMenu menuForm = new frmMainMenu(_userId);
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
            var form = new frmSearch(_userId);
            SwitchForm(this, form);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmProfil profilForm = new frmProfil(_userId);
            SwitchForm(this, profilForm);
        }
    }
}
