using Microsoft.VisualBasic.ApplicationServices;
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

namespace Perhotelan.View
{
    public partial class frmSearch : Form
    {
        private int _userId;
        public frmSearch(int userId)
        {
            _userId = userId;
            InitializeComponent();
            IntializedSearch();

        }
        private void IntializedSearch()
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
        private void Card_Click(string fullname, int hotelid)
        {
            // Open the detailed hotel form with the selected hotel's ID
            var hotelDetailsForm = new frmHotelDesign(hotelid, _userId);
            hotelDetailsForm.ShowDialog();
        }
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            foreach (Panel card in flpMenu.Controls.OfType<Panel>())
            {
                Label titleLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Font.Bold);
                string hotelId = card.Tag?.ToString().ToLower(); // Ambil hotelId dari Tag

                if (titleLabel != null)
                {
                    bool isMatch;

                    if (searchText.StartsWith("#"))
                    {
                        // Pencarian berdasarkan hotelId (hilangkan tanda # untuk pencocokan)
                        string searchId = searchText.Substring(1); // Buang karakter #
                        isMatch = hotelId != null && hotelId.Contains(searchId);
                    }
                    else
                    {
                        // Pencarian berdasarkan nama hotel
                        isMatch = titleLabel.Text.ToLower().Contains(searchText);
                    }

                    card.Visible = isMatch; // Tampilkan/hilangkan card sesuai hasil pencocokan
                }
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            

            // Panel untuk filter
            Panel filterPanel = new Panel
            {
                Size = new Size(450, 400), // Ukuran panel diperbesar
                Location = new Point((this.Width - 450) / 2, (this.Height - 400) / 2), // Pusatkan panel
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Label untuk range rating
            Label lblRatingRange = new Label
            {
                Text = "Rating Range:",
                Location = new Point(20, 20),
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true
            };
            filterPanel.Controls.Add(lblRatingRange);

            // TrackBar untuk rating minimal
            TrackBar trackBarRatingMin = new TrackBar
            {
                Minimum = 0,
                Maximum = 50, // Representasikan 0 - 5.0 dengan skala 0 - 50
                TickFrequency = 5,
                Size = new Size(200, 30),
                Location = new Point(20, 50)
            };
            filterPanel.Controls.Add(trackBarRatingMin);

            // TrackBar untuk rating maksimal
            TrackBar trackBarRatingMax = new TrackBar
            {
                Minimum = 0,
                Maximum = 50,
                TickFrequency = 5,
                Size = new Size(200, 30),
                Location = new Point(230, 50)
            };
            filterPanel.Controls.Add(trackBarRatingMax);

            // Label untuk menampilkan range rating
            Label lblRatingValue = new Label
            {
                Text = "0.0 - 5.0",
                Location = new Point(20, 90),
                Font = new Font("Montserrat", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true
            };
            filterPanel.Controls.Add(lblRatingValue);

            // Event handler untuk trackBarRatingMin dan trackBarRatingMax
            trackBarRatingMin.Scroll += (s, ev) =>
            {
                double minRating = trackBarRatingMin.Value / 10.0;
                double maxRating = trackBarRatingMax.Value / 10.0;
                if (minRating > maxRating)
                    trackBarRatingMin.Value = trackBarRatingMax.Value;
                lblRatingValue.Text = $"{minRating:0.0} - {maxRating:0.0}";
            };

            trackBarRatingMax.Scroll += (s, ev) =>
            {
                double minRating = trackBarRatingMin.Value / 10.0;
                double maxRating = trackBarRatingMax.Value / 10.0;
                if (maxRating < minRating)
                    trackBarRatingMax.Value = trackBarRatingMin.Value;
                lblRatingValue.Text = $"{minRating:0.0} - {maxRating:0.0}";
            };

            // Label untuk range harga
            Label lblPriceRange = new Label
            {
                Text = "Price Range:",
                Location = new Point(20, 130),
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true
            };
            filterPanel.Controls.Add(lblPriceRange);

            // TrackBar untuk harga minimal
            TrackBar trackBarPriceMin = new TrackBar
            {
                Minimum = 0,
                Maximum = 3000,
                TickFrequency = 500,
                Size = new Size(200, 30),
                Location = new Point(20, 160)
            };
            filterPanel.Controls.Add(trackBarPriceMin);

            // TrackBar untuk harga maksimal
            TrackBar trackBarPriceMax = new TrackBar
            {
                Minimum = 0,
                Maximum = 3000,
                TickFrequency = 500,
                Size = new Size(200, 30),
                Location = new Point(230, 160)
            };
            filterPanel.Controls.Add(trackBarPriceMax);

            // Label untuk menampilkan range harga
            Label lblPriceValue = new Label
            {
                Text = "0 - 3000",
                Location = new Point(20, 200),
                Font = new Font("Montserrat", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                AutoSize = true
            };
            filterPanel.Controls.Add(lblPriceValue);

            // Event handler untuk trackBarPriceMin dan trackBarPriceMax
            trackBarPriceMin.Scroll += (s, ev) =>
            {
                int minPrice = trackBarPriceMin.Value;
                int maxPrice = trackBarPriceMax.Value;
                if (minPrice > maxPrice)
                    trackBarPriceMin.Value = trackBarPriceMax.Value;
                lblPriceValue.Text = $"{minPrice} - {maxPrice}";
            };

            trackBarPriceMax.Scroll += (s, ev) =>
            {
                int minPrice = trackBarPriceMin.Value;
                int maxPrice = trackBarPriceMax.Value;
                if (maxPrice < minPrice)
                    trackBarPriceMax.Value = trackBarPriceMin.Value;
                lblPriceValue.Text = $"{minPrice} - {maxPrice}";
            };

            // Tombol Apply Filter
            Button btnApplyFilter = new Button
            {
                Text = "Apply Filter",
                Size = new Size(120, 30),
                Location = new Point(150, 250),
                BackColor = Color.Green,
                ForeColor = Color.White,
                Font = new Font("Montserrat", 9, FontStyle.Bold)
            };
            filterPanel.Controls.Add(btnApplyFilter);

            // Tombol Cancel
            Button btnCancel = new Button
            {
                Text = "Cancel",
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                Location = new Point(300, 250),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                AutoSize = true
            };
            btnCancel.Click += (s, ev) => filterPanel.Dispose();
            filterPanel.Controls.Add(btnCancel);

            // Event handler untuk Apply Filter
            btnApplyFilter.Click += (s, ev) =>
            {
                // Logic untuk menerapkan filter
                MessageBox.Show("Filter applied!");
                filterPanel.Visible = false; // Sembunyikan panel filter
            };

            // Tambahkan panel ke form
            this.Controls.Add(filterPanel);
            filterPanel.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMainMenu menuForm = new frmMainMenu(_userId);
            SwitchForm(this, menuForm);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking bookForm = new frmBooking(_userId);
            SwitchForm(this, bookForm);
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
    }
}
