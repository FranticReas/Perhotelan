using Perhotelan.Model.Entity;
using Perhotelan.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Repository
{
    class HotelRepository
    {
        // deklarasi objek connection
        private SQLiteConnection _conn;

        // constructor
        public HotelRepository(DdContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }
        public List<Hotel> GetAllHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            string query = "SELECT * FROM Hotel";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var hotel = new Hotel
                        {
                            hotelId = reader["hotelid"].ToString(),
                            firstname = reader["firstname"].ToString(),
                            lastname = reader["lastname"].ToString(),
                            location = reader["location"].ToString(),
                            hotelRating = Convert.ToDecimal(reader["hotelRating"]),
                            reviewCount = Convert.ToInt32(reader["reviewCount"]),
                            facility1 = reader["hotelFacility1"].ToString(),
                            facility2 = reader["hotelFacility2"].ToString(),
                            facility3 = reader["hotelFacility3"].ToString(),
                            imagePath = reader["imagePath"].ToString()
                        };

                        hotels.Add(hotel);
                    }
                }
            }
            return hotels;
        }


       
    }
}
