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
            // Sementara
            Image hotelImage = Image.FromFile("asset/images.jpg");
            for (int i = 0; i < 5; i++)
            {
                AddCard("Hotel " + (i + 1), "lokasi - bumi 🗿", "100k/malam", "🌟 4.3", hotelImage);
            }
        }
        private void AddCard(string hotelName, string hotelLocation, string hotelPricing, string hotelRating, Image hotelImage)
        {
            Panel card = new Panel
            {
                Size = new Size(348, 100),
                BackColor = Color.FromArgb(100, 181, 246),
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
                Text = hotelName,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(100, 10)

            };
            card.Controls.Add(titleLabel);

            Label subtitleLabel = new Label
            {
                Text = hotelLocation,
                Font = new Font("Segoe UI", 5, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(100, 35)
            };
            card.Controls.Add(subtitleLabel);

            Label instructorLabel = new Label
            {
                Text = hotelPricing,
                Font = new Font("Segoe UI", 5, FontStyle.Regular),
                ForeColor = Color.White,
                Location = new Point(100, 80)
            };
            card.Controls.Add(instructorLabel);

            Label ratingLabel = new Label
            {
                Text = hotelRating,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(card.Width - 50, 10), // Adjust the position to the top-right
                AutoSize = true,
                TextAlign = ContentAlignment.TopRight
            };
            card.Controls.Add(ratingLabel);

            //Untuk membuka tab
            card.Click += (s, e) => Card_Click(hotelName);
            titleLabel.Click += (s, e) => Card_Click(hotelName);
            subtitleLabel.Click += (s, e) => Card_Click(hotelName);
            instructorLabel.Click += (s, e) => Card_Click(hotelName);
            ratingLabel.Click += (s, e) => Card_Click(hotelName);
            pictureBox.Click += (s, e) => Card_Click(hotelName);

            flpMenu.Controls.Add(card);
        }
        // Event handler for card click
        private void Card_Click(string hotelName)
        {
            // Open a new form or display more details about the card
            Form hotelDetailsForm = new Form
            {
                Text = "Hotel " + hotelName,
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
            bookingForm.Show();
        }
    }
}
