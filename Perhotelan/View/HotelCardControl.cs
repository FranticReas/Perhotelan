using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perhotelan.View
{

    public partial class HotelCardControl : UserControl
    {
        private Panel cardPanel;
        private PictureBox hotelImage;
        private Label hotelNameLabel;
        private Label ratingLabel;
        private Label reviewsLabel;
        private Label locationLabel;
        private Button mapButton;
        private Panel roomPanel;
        private Label roomPriceLabel;
        private Label roomTypeLabel;
        // Sementara
        Image hotelimage = Image.FromFile("asset/images.jpg");
        public HotelCardControl()
        {
            InitializeComponent();
        }
        private void InitializeComponents()
        {
            // Card Panel
            cardPanel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(350, 400),
                Padding = new Padding(10),
                Margin = new Padding(10)
            };

            // Hotel Image
            hotelImage = new PictureBox
            {
                Size = new Size(320, 150),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = hotelimage // Replace with your default image
            };

            // Hotel Name
            hotelNameLabel = new Label
            {
                Text = "Tentrem Hotel Yogyakarta",
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = true
            };

            // Rating and Reviews
            ratingLabel = new Label
            {
                Text = "4.8",
                ForeColor = Color.DarkGreen,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };
            reviewsLabel = new Label
            {
                Text = "5.5k reviews",
                Font = new Font("Arial", 10),
                AutoSize = true
            };

            // Location
            locationLabel = new Label
            {
                Text = "Around Tugu Jogja",
                Font = new Font("Arial", 10),
                AutoSize = true
            };

            // Map Button
            mapButton = new Button
            {
                Text = "Map",
                Size = new Size(75, 30),
                BackColor = Color.LightBlue
            };

            // Room Panel
            roomPanel = new Panel
            {
                BackColor = Color.LightGray,
                Size = new Size(320, 100),
                Padding = new Padding(5),
                Margin = new Padding(5)
            };

            roomPriceLabel = new Label
            {
                Text = "Rp. 1.650.000",
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.DarkRed,
                AutoSize = true
            };
            roomTypeLabel = new Label
            {
                Text = "Deluxe Room",
                Font = new Font("Arial", 12),
                AutoSize = true
            };

            // Arrange components
            var mainLayout = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            cardPanel.Controls.Add(hotelImage);
            cardPanel.Controls.Add(hotelNameLabel);
            cardPanel.Controls.Add(ratingLabel);
            cardPanel.Controls.Add(reviewsLabel);
            cardPanel.Controls.Add(locationLabel);
            cardPanel.Controls.Add(mapButton);

            roomPanel.Controls.Add(roomPriceLabel);
            roomPanel.Controls.Add(roomTypeLabel);

            cardPanel.Controls.Add(roomPanel);
            mainLayout.Controls.Add(cardPanel);
            Controls.Add(mainLayout);
        }
    }
}
