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
            CreateFilterInterface();
        }
        private void CreateFilterInterface()
        {
            Panel filterPanel = new Panel
            {
                Size = new Size(450, 600),
                Location = new Point((this.Width - 450) / 2, (this.Height - 600) / 2),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Price range slider
            Label lblPriceRange = new Label
            {
                Text = "Price Range Per Night",
                Location = new Point(20, 20),
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true
            };
            filterPanel.Controls.Add(lblPriceRange);

            TrackBar trkMinPrice = new TrackBar
            {
                Minimum = 500,
                Maximum = 3000,
                TickFrequency = 10,
                Value = 500, // Default value
                Location = new Point(20, 50),
                Width = 200
            };
            Label lblMinPrice = new Label
            {
                Text = "Rp 500K",
                Location = new Point(230, 50),
                Font = new Font("Montserrat", 8),
                ForeColor = Color.Black
            };
            filterPanel.Controls.Add(trkMinPrice);
            filterPanel.Controls.Add(lblMinPrice);

            TrackBar trkMaxPrice = new TrackBar
            {
                Minimum = 500,
                Maximum = 3000,
                TickFrequency = 10,
                Value = 3000, // Default value
                Location = new Point(20, 80),
                Width = 200
            };
            Label lblMaxPrice = new Label
            {
                Text = "Rp 3000K",
                Location = new Point(230, 80),
                Font = new Font("Montserrat", 8),
                ForeColor = Color.Black
            };
            filterPanel.Controls.Add(trkMaxPrice);
            filterPanel.Controls.Add(lblMaxPrice);

            // Update labels on trackbar value change
            trkMinPrice.ValueChanged += (s, e) => lblMinPrice.Text = $"Rp {trkMinPrice.Value}K";
            trkMaxPrice.ValueChanged += (s, e) => lblMaxPrice.Text = $"Rp {trkMaxPrice.Value}K";

            // Star Rating
            Label lblStarRating = new Label
            {
                Text = "Star Rating",
                Location = new Point(20, 120),
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true
            };
            filterPanel.Controls.Add(lblStarRating);

            // Min and Max Rating selection
            ComboBox cmbMinRating = new ComboBox
            {
                Location = new Point(20, 150),
                Width = 100
            };
            ComboBox cmbMaxRating = new ComboBox
            {
                Location = new Point(130, 150),
                Width = 100
            };

            for (float i = 1; i <= 5; i += 0.5f)
            {
                cmbMinRating.Items.Add(i.ToString("0.0"));
                cmbMaxRating.Items.Add(i.ToString("0.0"));
            }
            cmbMinRating.SelectedIndex = 0; // Default to 1.0
            cmbMaxRating.SelectedIndex = 5; // Default to 5.0

            filterPanel.Controls.Add(cmbMinRating);
            filterPanel.Controls.Add(cmbMaxRating);

            // Facilities
            Label lblFacilities = new Label
            {
                Text = "Facilities",
                Location = new Point(20, 190),
                Font = new Font("Montserrat", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true
            };
            filterPanel.Controls.Add(lblFacilities);

            CheckBox chkPool = new CheckBox { Text = "Pool", Location = new Point(20, 220), AutoSize = true };
            CheckBox chkGym = new CheckBox { Text = "Gym", Location = new Point(120, 220), AutoSize = true };
            CheckBox chkSpa = new CheckBox { Text = "Spa", Location = new Point(200, 220), AutoSize = true };
            CheckBox chkRestaurant = new CheckBox { Text = "Restaurant", Location = new Point(20, 250), AutoSize = true };
            CheckBox chkWifi = new CheckBox { Text = "Wi-Fi", Location = new Point(120, 250), AutoSize = true };
            CheckBox chkBreakfast = new CheckBox { Text = "Breakfast", Location = new Point(200, 250), AutoSize = true };


            filterPanel.Controls.Add(chkPool);
            filterPanel.Controls.Add(chkGym);
            filterPanel.Controls.Add(chkSpa);
            filterPanel.Controls.Add(chkRestaurant);
            filterPanel.Controls.Add(chkWifi);
            filterPanel.Controls.Add(chkBreakfast);

            // Apply Button
            Button btnApply = new Button
            {
                Text = "Apply Filter",
                Location = new Point(150, 300),
                Size = new Size(120, 30),
                BackColor = Color.Green,
                ForeColor = Color.White,
                Font = new Font("Montserrat", 9, FontStyle.Bold)
            };
            btnApply.Click += (s, e) =>
            {
                // Example values for the filters (replace with actual values from the UI)
                int minPrice = trkMinPrice.Value; // Get from trackbar
                int maxPrice = trkMaxPrice.Value; // Get from trackbar
                float minRating = float.Parse(cmbMinRating.SelectedItem.ToString()); // Get from ComboBox
                float maxRating = float.Parse(cmbMaxRating.SelectedItem.ToString()); // Get from ComboBox
                List<string> selectedFacilities = new List<string>();

                // Collect selected facilities
                if (chkPool.Checked) selectedFacilities.Add("POOL");
                if (chkGym.Checked) selectedFacilities.Add("GYM");
                if (chkSpa.Checked) selectedFacilities.Add("SPA");
                if (chkRestaurant.Checked) selectedFacilities.Add("RESTAURANT");
                if (chkWifi.Checked) selectedFacilities.Add("WIFI");
                if (chkBreakfast.Checked) selectedFacilities.Add("BREAKFAST");


                // Call the UpdateHotelDisplay method with the selected filters
                UpdateHotelDisplay(minPrice, maxPrice, minRating, maxRating, selectedFacilities);

                // Hide the filter panel
                filterPanel.Visible = false;
            };
            filterPanel.Controls.Add(btnApply);

            this.Controls.Add(filterPanel);
            filterPanel.BringToFront();
        }
        private void UpdateHotelDisplay(int minPrice, int maxPrice, float minRating, float maxRating, List<string> selectedFacilities)
        {
            // Clear existing cards from the FlowLayoutPanel
            flpMenu.Controls.Clear();

            using (DdContext context = new DdContext())
            {
                // Build the SQL query dynamically based on the selected filters
                var query = new StringBuilder();
                query.Append("SELECT Hotel.hotelid, Hotel.firstname, Hotel.lastname, Hotel.location, Hotel.hotelRating, ");
                query.Append("Room.price, Room.imagePath, Hotel.hotelFacility1, Hotel.hotelFacility2, Hotel.hotelFacility3 ");
                query.Append("FROM Hotel ");
                query.Append("INNER JOIN Room ON Hotel.hotelid = Room.hotelId ");
                query.Append("WHERE Room.price BETWEEN @minPrice AND @maxPrice ");
                query.Append("AND Hotel.hotelRating BETWEEN @minRating AND @maxRating ");

                // Add facilities filter only if any facility is selected
                if (selectedFacilities.Count > 0)
                {
                    query.Append("AND (");

                    // Check each selected facility and add to query
                    for (int i = 0; i < selectedFacilities.Count; i++)
                    {
                        string facility = selectedFacilities[i].ToUpper(); // Make sure facility names are in uppercase to match database

                        // Check which column the facility belongs to
                        if (facility == "POOL" || facility == "GYM")
                        {
                            query.Append($"Hotel.hotelFacility1 = @facility{i} OR ");
                        }
                        else if (facility == "SPA" || facility == "RESTAURANT")
                        {
                            query.Append($"Hotel.hotelFacility2 = @facility{i} OR ");
                        }
                        else if (facility == "WIFI" || facility == "BREAKFAST")
                        {
                            query.Append($"Hotel.hotelFacility3 = @facility{i} OR ");
                        }
                    }

                    // Remove the last "OR" and close the parentheses
                    query.Length -= 3; // Remove the last " OR "
                    query.Append(")");
                }

                string sql = query.ToString();

                using (SQLiteCommand cmd = new SQLiteCommand(sql, context.Conn))
                {
                    // Bind parameters for price range and rating
                    cmd.Parameters.AddWithValue("@minPrice", minPrice);
                    cmd.Parameters.AddWithValue("@maxPrice", maxPrice);
                    cmd.Parameters.AddWithValue("@minRating", minRating);
                    cmd.Parameters.AddWithValue("@maxRating", maxRating);

                    // Bind each selected facility
                    for (int i = 0; i < selectedFacilities.Count; i++)
                    {
                        cmd.Parameters.AddWithValue($"@facility{i}", selectedFacilities[i].ToUpper());
                    }

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Read hotel data from the database
                            int hotelId = reader.GetInt32(0);
                            string fullName = $"{reader.GetString(1)} {reader.GetString(2)}";
                            string location = reader.GetString(3);
                            float hotelRating = reader.GetFloat(4);
                            int price = reader.GetInt32(5);
                            string imagePath = reader.GetString(6);
                            string facility1 = reader.GetString(7);
                            string facility2 = reader.GetString(8);
                            string facility3 = reader.GetString(9);

                            // Load the hotel image
                            Image hotelImage = Image.FromFile($"{imagePath}.jpg");

                            // Add the hotel card to the FlowLayoutPanel
                            AddCard(fullName, hotelImage, location, $"{hotelRating}⭐", hotelId, facility1, facility2, facility3);
                        }
                    }
                }
            }
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
