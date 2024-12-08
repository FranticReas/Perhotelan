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

namespace Perhotelan.View
{
    public partial class frmHotelDesign : Form
    {
        private int _hotelId;

        public frmHotelDesign(int hotelId)
        {
            InitializeComponent();
            _hotelId = hotelId;
        }

        private void frmHotelDesign_Load(object sender, EventArgs e)
        {
            LoadHotelDetails(_hotelId);
        }

        private void LoadHotelDetails(int hotelId)
        {
            // Connect to the database and fetch hotel details based on the hotelId
            using (var context = new DdContext())
            {
                string query = "SELECT * FROM Hotel WHERE hotelid = @hotelId";
                SQLiteCommand command = new SQLiteCommand(query, context.Conn);
                command.Parameters.AddWithValue("@hotelId", hotelId);
                Hotel hotels = new Hotel();
                string fullName = $"{hotels.firstname} {hotels.lastname}";
                using (var reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        // Assuming column names are 'name', 'location', 'hotelRating', 'reviewCount', 'imagePath'
                        lblHotelName.Text = fullName;
                        lblLokasi.Text = reader["location"].ToString();
                        lblRating.Text = reader["hotelRating"].ToString();
                        label1.Text = $"{reader["reviewCount"]} K";

                        string imagePath = reader["imagePath"].ToString();
                        if (File.Exists(imagePath))
                        {
                            pcbHotel.Image = Image.FromFile(imagePath);
                        }

                        // Fetch available rooms if any
                        
                    }
                }
            }
        }      
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




