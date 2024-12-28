using Perhotelan.Model.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Perhotelan.View;
using Perhotelan.Model.Entity;
using Perhotelan.Model.Repository;
using System.Diagnostics;
using Perhotelan.Controller;

namespace Perhotelan.View
{
    public partial class frmHotelDesign : Form
    {
        // Delegate untuk meneruskan tanggal check-out
        public Action<DateTime> OnCheckoutDateSelected { get; set; }

        private int _hotelId;
        int userId;
        public frmHotelDesign(int hotelid, int userId)
        {
            this.userId = userId;
            _hotelId = hotelid;
            InitializeComponent();
            InitializeRoomInterface();
        }

        private void frmHotelDesign_Load(object sender, EventArgs e)
        {
            LoadHotelDetails(_hotelId);
        }
        private void LoadHotelDetails(int hotelid)
        {
            try
            {
                // Gunakan DdContext dan HotelController
                using (var context = new DdContext())
                {
                    var hotelRepository = new HotelRepository(context);
                    var hotelController = new HotelController(hotelRepository);

                    // Ambil data hotel menggunakan controller
                    var hotel = hotelController.GetHotelById(hotelid);

                    if (hotel != null)
                    {
                        // Tampilkan data hotel di UI
                        string fullname = $"{hotel.firstname} {hotel.lastname}";
                        string imagePath = hotel.imagePath;
                        decimal hotelRating = hotel.hotelRating;
                        int reviewCount = hotel.reviewCount;
                        string location = hotel.location;
                        pcbHotel.Image = Image.FromFile($"{imagePath}.jpg");

                        lblHotelName.Text = fullname;
                        lblRating.Text = hotelRating.ToString();
                        lblReview.Text = reviewCount.ToString();
                        lblLokasi.Text = location;
                    }
                    else
                    {
                        // Tangani kasus ketika hotel tidak ditemukan
                        MessageBox.Show("Hotel not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Tangani kesalahan umum
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeRoomInterface()
        {
            try
            {
                using (var context = new DdContext())
                {
                    // Inisialisasi repository dan controller
                    var roomRepository = new RoomRepository(context);
                    var roomController = new RoomController(roomRepository);

                    // Ambil data kamar berdasarkan hotel ID
                    List<Room> rooms = roomController.GetRoomsByHotelId(_hotelId);

                    foreach (var room in rooms)
                    {
                        Image roomImage = null;
                        roomImage = Image.FromFile($"{room.imagePath}.jpg");
                        // Tampilkan detail kamar menggunakan metode AddRoomCard
                        AddRoomCard(room.roomType, roomImage, room.price.ToString(), room.maxGuest, room.roomId, room.bedType);
                    }
                }
            }
            catch (Exception ex)
            {
                // Tangani kesalahan umum
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddRoomCard(string roomName, Image roomImage, string roomPrice, int maxGuest, int roomId, string bedType)
        {
            // Main card panel
            Panel card = new Panel
            {
                Size = new Size(271, 120),
                BackColor = Color.White,
                Margin = new Padding(5),
                Cursor = Cursors.Hand
            };

            // Room image
            PictureBox pictureBox = new PictureBox
            {
                Image = roomImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(271, 120),
                Location = new Point(0, 0)
            };
            card.Controls.Add(pictureBox);

            // Price label
            Label priceLabel = new Label
            {
                Text = roomPrice,
                Font = new Font("Montserrat", 12, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(180, 128, 128, 128),
                Location = new Point(10, 10),
                AutoSize = true
            };
            card.Controls.Add(priceLabel);

            // Room name label
            Label nameLabel = new Label
            {
                Text = roomName.ToUpper(),
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(180, 128, 128, 128),
                Location = new Point(10, 40),
                AutoSize = true
            };
            card.Controls.Add(nameLabel);

            // Icon and detail labels for guests, room size, and bed type
            int iconY = 95; // Y-coordinate for icons and details
            int spacing = 70; // Space between each icon-text pair

            // Guest icon and label
            PictureBox guestIcon = new PictureBox
            {
                Image = Image.FromFile("asset/people.png"), // Path to guest icon
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(180, 128, 128, 128),
                Size = new Size(20, 20),
                Location = new Point(10, iconY)
            };
            card.Controls.Add(guestIcon);

            Label guestLabel = new Label
            {
                Text = $"{maxGuest}",
                Font = new Font("Montserrat", 8, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(180, 128, 128, 128),
                Location = new Point(35, iconY + 2),
                AutoSize = true
            };
            card.Controls.Add(guestLabel);

            // Room size icon and label
            PictureBox sizeIcon = new PictureBox
            {
                Image = Image.FromFile("asset/size.png"), // Path to size icon
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(180, 128, 128, 128),
                Size = new Size(20, 20),
                Location = new Point(10 + spacing, iconY)
            };
            card.Controls.Add(sizeIcon);

            Label sizeLabel = new Label
            {
                Text = "40 m²",
                Font = new Font("Montserrat", 8, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(180, 128, 128, 128),
                Location = new Point(35 + spacing, iconY + 2),
                AutoSize = true
            };
            card.Controls.Add(sizeLabel);

            // Bed type icon and label
            PictureBox bedIcon = new PictureBox
            {
                Image = Image.FromFile("asset/bed.png"), // Path to bed icon
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(180, 128, 128, 128),
                Size = new Size(20, 20),
                Location = new Point(30 + 2 * spacing, iconY)
            };
            card.Controls.Add(bedIcon);

            Label bedLabel = new Label
            {
                Text = bedType,
                Font = new Font("Montserrat", 8, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(180, 128, 128, 128),
                Location = new Point(50 + 2 * spacing, iconY + 2),
                AutoSize = true
            };
            card.Controls.Add(bedLabel);

            // Add click events to all elements
            card.Click += (s, e) => RoomCard_Click(roomId);
            foreach (Control control in card.Controls)
            {
                control.Click += (s, e) => RoomCard_Click(roomId);
            }

            // Add card to the FlowLayoutPanel
            flpRoom.Controls.Add(card);

            // Send the image to the back for proper layering
            pictureBox.SendToBack();
        }
        // Event handler for room card click
        private void RoomCard_Click(int roomId)
        {
            OpenDatePicker(roomId);
        }
        private void OpenDatePicker(int roomId)
        {
            // Buat instance form check-in
            frmCheckIn checkInForm = new frmCheckIn(_hotelId);

            // Hubungkan delegate OnDateSelected
            checkInForm.OnDateSelected = (selectedDate) =>
            {
                // Setelah tanggal check-in dipilih, buka form check-out
                frmCheckOut checkoutForm = new frmCheckOut();

                checkoutForm.OnCheckoutDateSelected = (checkoutDate) =>
                {
                    if (checkoutDate <= selectedDate)
                    {
                        MessageBox.Show("Check-out date must be after check-in date!", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        using (DdContext context = new DdContext())
                        {
                            RoomRepository service = new RoomRepository(context);
                            int nigthly_rate = service.GetRoomPrice(roomId);
                            int price = CalculatePrice(selectedDate, checkoutDate, nigthly_rate);
                            // Proses tanggal check-in dan check-out
                            ProcessSelectedDate(selectedDate, checkoutDate, roomId, this.userId, price);
                        }
                    }
                };

                // Tampilkan form check-out sebagai dialog
                checkoutForm.ShowDialog();
            };

            // Tampilkan form check-in sebagai dialog
            checkInForm.ShowDialog();
        }
        private int CalculatePrice(DateTime checkinDate, DateTime checkoutDate, int nightlyRate)
        {
            // Hitung jumlah malam (durasi menginap)
            int numberOfNights = (checkoutDate - checkinDate).Days;

            // Pastikan jumlah malam tidak negatif (fallback untuk logika tambahan)
            if (numberOfNights < 1)
                numberOfNights = 1;

            // Hitung total harga
            return numberOfNights * nightlyRate;
        }
        private void ProcessSelectedDate(DateTime checkinDate, DateTime checkoutDate, int roomId, int userId, int price)
        {
            using (DdContext context = new DdContext())
            {
                {
                    var roomService = new RoomRepository(context);
                    var roomControler = new RoomController(roomService);

                    // Create a transaction instance
                    var transaction = new Transaction_
                    {
                        transactionDate = DateTime.Now,           // Transaction date
                        checkIn = checkinDate,                    // Check-in date
                        checkOut = checkoutDate,                  // Check-out date
                        status = "Booked",                        // Room status
                        roomId = roomId,                          // Room ID
                        price = price,                            // Room price
                        userId = userId                           // User ID
                    };
                    var service = new TransactionRepository(context);
                    var transactionController = new TransactionController(service);

                    // Call the Create method to add the transaction data to the database
                    int result = transactionController.CreateTransaction(transaction);

                    if (result > 0)
                    {
                        // Update room status to 'occupied'
                        roomControler.UpdateRoomStatus(roomId, "occupied");
                        // Refresh the room interface to update available rooms
                        RefreshRoomInterface();
                        // Transaction added successfully
                        MessageBox.Show("Transaction added successfully!\n" +
                            $"Check-in: {checkinDate:dddd, dd MMMM yyyy}\n" +
                            $"Check-out: {checkoutDate:dddd, dd MMMM yyyy}\n" +
                            $"Room ID: {roomId}\nPrice: {price:C}",
                            "Transaction Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Failed to add transaction
                        MessageBox.Show("Failed to add transaction. Please try again.",
                            "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void RefreshRoomInterface()
        {
            // Clear the current room cards (assuming there is a method to do this)
            ClearRoomCards();

            using (DdContext context = new DdContext())
            {
                var service = new RoomRepository(context);
                var roomController = new RoomController(service);

                // Fetch all rooms with status 'free' from the database
                List<Room> rooms = roomController.GetRoomsByHotelId(_hotelId);

                foreach (var room in rooms)
                {
                    Image roomImage = Image.FromFile($"{room.imagePath}.jpg");
                    // Display room details on the card
                    AddRoomCard(room.roomType, roomImage, room.price.ToString(), room.maxGuest, room.roomId, room.bedType);
                }
            }
        }
        private void ClearRoomCards()
        {
            flpRoom.Controls.Clear();
        }

    }
}




