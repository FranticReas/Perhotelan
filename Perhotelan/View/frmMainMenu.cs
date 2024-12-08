using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perhotelan
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();

            IntializedMenuInterface();
        }

        private void IntializedMenuInterface()
        {
            using (DdContext context = new DdContext())
            {
                // Fetch all hotels from the database
                List<Hotel> hotels = context.GetAllHotels();

                foreach (var hotel in hotels)
                {
                    // Load the hotel image if the `imagePath` property is set
                    Image hotelImage = null;
                    if (!string.IsNullOrEmpty(hotel.imagePath))
                    {
                        try
                        {
                            hotelImage = Image.FromFile(hotel.imagePath);
                        }
                        catch (Exception ex)
                        {
                            // Handle image loading exceptions
                            Console.WriteLine($"Error loading image: {ex.Message}");
                        }
                    }

                    // Concatenate firstname and lastname for display
                    string fullName = $"{hotel.firstname} {hotel.lastname}";

                    // Call AddCard method to add the hotel card to the interface
                    AddCard(fullName, hotelImage, hotel.location, $"{hotel.hotelRating}⭐");
                }
            }
        }
        private void AddCard(string fullName, Image hotelImage, string hotelLocation, string hotelRating)
        {
            Panel card = new Panel
            {
                Size = new Size(348, 100),
                BackColor = Color.White,
                Margin = new Padding(5),
                Cursor = Cursors.Hand
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

            // Event handlers for clicking the card
            card.Click += (s, e) => Card_Click(fullName);
            titleLabel.Click += (s, e) => Card_Click(fullName);
            subtitleLabel.Click += (s, e) => Card_Click(fullName);
            ratingLabel.Click += (s, e) => Card_Click(fullName);
            pictureBox.Click += (s, e) => Card_Click(fullName);

            flpMenu.Controls.Add(card);
        }

        // Event handler for card click
        private void Card_Click(string hotelName)
        {
            // Open a new form or display more details about the card
            Form hotelDetailsForm = new Form
            {
                Text = hotelName,
                Size = new Size(400, 300)
            };

            Label hotelInfoLabel = new Label
            {
                Text = "Sementara " + hotelName,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12)
            };

            hotelDetailsForm.Controls.Add(hotelInfoLabel);
            hotelDetailsForm.ShowDialog(); // Show the details form as a modal dialog
        }
        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            foreach (Panel card in flpMenu.Controls.OfType<Panel>())
            {
                Label titleLabel = card.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Font.Bold);

                if (titleLabel != null)
                {
                    bool isMatch = titleLabel.Text.ToLower().Contains(searchText);
                    card.Visible = isMatch;
                }
            }
        }

        private void flpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            frmBooking bookingForm = new frmBooking();
            SwitchForm(this, bookingForm);
        }

        public static void SwitchForm(Form currentForm, Form newForm)
        {
            currentForm.Hide();       // Sembunyikan form sekarang
            newForm.ShowDialog();     // Tampilkan form baru sebagai dialog
            currentForm.Show();       // Kembalikan form lama jika diperlukan
        }
    }
}
