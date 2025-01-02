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
using System.Data.SQLite;
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
                Size = new Size(450, 500),
                Location = new Point((this.Width - 450) / 2, (this.Height - 500) / 2),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Filter untuk fasilitas
            Label lblFacility = new Label
            {
                Text = "Facilities:",
                Location = new Point(20, 20),
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true
            };
            filterPanel.Controls.Add(lblFacility);

            // Checkbox untuk fasilitas
            CheckBox chkGym = new CheckBox { Text = "GYM", Location = new Point(20, 50), AutoSize = true };
            CheckBox chkPool = new CheckBox { Text = "POOL", Location = new Point(100, 50), AutoSize = true };
            CheckBox chkSpa = new CheckBox { Text = "SPA", Location = new Point(20, 80), AutoSize = true };
            CheckBox chkRestaurant = new CheckBox { Text = "RESTAURANT", Location = new Point(100, 80), AutoSize = true };
            CheckBox chkWifi = new CheckBox { Text = "WIFI", Location = new Point(20, 110), AutoSize = true };
            CheckBox chkBreakfast = new CheckBox { Text = "BREAKFAST", Location = new Point(100, 110), AutoSize = true };

            filterPanel.Controls.Add(chkGym);
            filterPanel.Controls.Add(chkPool);
            filterPanel.Controls.Add(chkSpa);
            filterPanel.Controls.Add(chkRestaurant);
            filterPanel.Controls.Add(chkWifi);
            filterPanel.Controls.Add(chkBreakfast);

            // Tombol Apply Filter
            Button btnApplyFilter = new Button
            {
                Text = "Apply Filter",
                Size = new Size(120, 30),
                Location = new Point(150, 160),
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
                Location = new Point(300, 160),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                AutoSize = true
            };
            btnCancel.Click += (s, ev) => filterPanel.Dispose();
            filterPanel.Controls.Add(btnCancel);

            // Event handler untuk Apply Filter
            btnApplyFilter.Click += (s, ev) =>
            {
                // Ambil filter yang dipilih
                List<string> selectedFacilities = new List<string>();
                if (chkGym.Checked) selectedFacilities.Add("GYM");
                if (chkPool.Checked) selectedFacilities.Add("POOL");
                if (chkSpa.Checked) selectedFacilities.Add("SPA");
                if (chkRestaurant.Checked) selectedFacilities.Add("RESTAURANT");
                if (chkWifi.Checked) selectedFacilities.Add("WIFI");
                if (chkBreakfast.Checked) selectedFacilities.Add("BREAKFAST");

                if (selectedFacilities.Count == 0)
                {
                    MessageBox.Show("Please select at least one facility.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Query database
                string query = @"SELECT *  FROM Hotel WHERE hotelFacility1 IN ({0}) OR hotelFacility2 IN ({0}) OR hotelFacility3 IN ({0});";

                // Format query untuk mendukung parameter dinamika
                string parameterizedQuery = string.Join(",", selectedFacilities.Select((_, i) => $"@facility{i}"));
                query = string.Format(query, parameterizedQuery);

                List<Hotel> filteredHotels = new List<Hotel>();

                using (var context = new DdContext())
                {
                    using (var cmd = new SQLiteCommand(query, context.Conn))
                    {
                        for (int i = 0; i < selectedFacilities.Count; i++)
                        {
                            cmd.Parameters.AddWithValue($"@facility{i}", selectedFacilities[i]);
                        }

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                filteredHotels.Add(new Hotel
                                {
                                    hotelId = reader.GetInt32(reader.GetOrdinal("hotelId")),
                                    firstname = reader.GetString(reader.GetOrdinal("firstname")),
                                    lastname = reader.GetString(reader.GetOrdinal("lastname")),
                                    imagePath = reader.GetString(reader.GetOrdinal("imagePath")),
                                    location = reader.GetString(reader.GetOrdinal("location")),
                                    hotelRating = reader.GetDecimal(reader.GetOrdinal("hotelRating")),
                                    facility1 = reader.GetString(reader.GetOrdinal("hotelFacility1")),
                                    facility2 = reader.GetString(reader.GetOrdinal("hotelFacility2")),
                                    facility3 = reader.GetString(reader.GetOrdinal("hotelFacility3"))
                                });
                            }
                        }
                    }
                }

                // Tampilkan hasil di flpMenu
                flpMenu.Controls.Clear();
                foreach (var hotel in filteredHotels)
                {
                    Image hotelImage = Image.FromFile($"{hotel.imagePath}.jpg");
                    string fullName = $"{hotel.firstname} {hotel.lastname}";
                    AddCard(fullName, hotelImage, hotel.location, $"{hotel.hotelRating}⭐", Convert.ToInt32(hotel.hotelId), hotel.facility1, hotel.facility2, hotel.facility3);
                }

                filterPanel.Dispose();
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
