using Perhotelan.Controller;
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

namespace Perhotelan
{
    public partial class frmMainMenu : Form
    {
        private int _userId;
        public frmMainMenu(int userId)
        {
            _userId = userId;
            InitializeComponent();
            IntializedMenuInterface();
        }

        private void IntializedMenuInterface()
        {
            using (DdContext context = new DdContext())
            {
                // Inisialisasi repository dan controller
                var hotelRepository = new HotelRepository(context);
                var hotelController = new HotelController(hotelRepository);

                // Mendapatkan semua hotel
                var hotels = hotelController.GetAllHotel();

                foreach (var hotel in hotels)
                {
                    Image hotelImage = Image.FromFile($"{hotel.imagePath}.jpg");
                    // Concatenate firstname and lastname for display
                    string fullName = $"{hotel.firstname} {hotel.lastname}";
                    // Call AddCard method to add the hotel card to the interface
                    AddCard(fullName, hotelImage, hotel.location, $"{hotel.hotelRating}⭐", Convert.ToInt32(hotel.hotelId), hotel.facility1, hotel.facility2, hotel.facility3);
                }
            }
        }
        private void AddCard(string fullName, Image hotelImage, string hotelLocation, string hotelRating, int hotelid, string facility1, string facility2, string facility3)
        {

            Panel card = new Panel
            {
                Size = new Size(348, 100),
                BackColor = Color.White,
                Margin = new Padding(5),
                Cursor = Cursors.Hand,
                Tag = hotelid.ToString() // Simpan hotelId sebagai string di Tag
            };

            PictureBox pictureBox = new PictureBox
            {
                Image = hotelImage, // Set the custom image here
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(80, 80),
                Location = new Point(10, 10)
            };
            card.Controls.Add(pictureBox);

            Label titleLabel = new Label
            {
                Text = fullName,
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 70, 60),
                Location = new Point(96, 10),
                AutoSize = true
            };
            card.Controls.Add(titleLabel);

            Label subtitleLabel = new Label
            {
                Text = hotelLocation,
                Font = new Font("Montserrat", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(17, 70, 60),
                Location = new Point(100, 35),
                AutoSize = true
            };
            card.Controls.Add(subtitleLabel);

            Label ratingLabel = new Label
            {
                Text = hotelRating,
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 70, 60),
                Location = new Point(card.Width - 50, 10), // Adjust the position to the top-right
                AutoSize = true,
                TextAlign = ContentAlignment.TopRight
            };
            card.Controls.Add(ratingLabel);

            // Icon and detail labels for guests, room size, and bed type
            int iconY = 65; // Y-coordinate for icons and details
            int spacing = 70; // Space between each icon-text pair

            Label guestLabel = new Label
            {
                Text = $"{facility1}",
                Font = new Font("Montserrat", 8, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 70, 60),
                Location = new Point(100, iconY + 2),
                AutoSize = true
            };
            card.Controls.Add(guestLabel);

            Label sizeLabel = new Label
            {
                Text = facility2,
                Font = new Font("Montserrat", 8, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 70, 60),
                Location = new Point(105 + spacing, iconY + 2),
                AutoSize = true
            };
            card.Controls.Add(sizeLabel);

            Label bedLabel = new Label
            {
                Text = facility3,
                Font = new Font("Montserrat", 8, FontStyle.Bold),
                ForeColor = Color.FromArgb(17, 70, 60),
                Location = new Point(135 + 2 * spacing, iconY + 2),
                AutoSize = true
            };
            card.Controls.Add(bedLabel);

            // Add click events to all elements
            card.Click += (s, e) => Card_Click(fullName, hotelid);
            foreach (Control control in card.Controls)
            {
                control.Click += (s, e) => Card_Click(fullName, hotelid);
            }

            flpMenu.Controls.Add(card);
        }

        // Event handler for card click
        private void Card_Click(string fullname, int hotelid)
        {
            // Open the detailed hotel form with the selected hotel's ID
            var hotelDetailsForm = new frmHotelDesign(hotelid, _userId);
            hotelDetailsForm.ShowDialog();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch Searchform = new frmSearch(_userId);
            SwitchForm(this, Searchform);
        }
       

        private void flpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking bookingForm = new frmBooking(_userId);
            SwitchForm(this, bookingForm);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            frmProfil profilForm = new frmProfil(_userId);
            SwitchForm(this, profilForm);
        }

        public static void SwitchForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();       // Sembunyikan form sekarang
            newForm.ShowDialog();     // Tampilkan form baru sebagai dialog
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

       
    }
}
