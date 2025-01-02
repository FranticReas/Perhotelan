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
                            hotelId = Convert.ToInt32(reader["hotelid"]),
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
        public Hotel GetHotelById(int hotelId)
        {
            Hotel hotel = null;
            string sql = "SELECT * FROM Hotel WHERE hotelid = @hotelId";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@hotelId", hotelId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        hotel = new Hotel
                        {
                            hotelId = Convert.ToInt32(reader["hotelid"]),
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
                    }
                }
            }
            return hotel;
        }
        public List<Hotel> GetFilteredHotels(SQLiteConnection connection, List<string> facilities, int minPrice, int maxPrice, int rating)
        {
            List<Hotel> hotels = new List<Hotel>();

            string query = @"
                SELECT h.*, r.price, r.roomType
                FROM Hotel h
                INNER JOIN Room r ON h.hotelId = r.hotelId
                WHERE r.price BETWEEN @minPrice AND @maxPrice
                AND h.hotelRating >= @rating
                AND (
                    h.hotelFacility1 IN ({0}) OR
                    h.hotelFacility2 IN ({0}) OR
                    h.hotelFacility3 IN ({0})
                )";

            string parameterizedQuery = string.Join(",", facilities.Select((_, i) => $"@facility{i}"));
            query = string.Format(query, parameterizedQuery);

            using (var cmd = new SQLiteCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@minPrice", minPrice);
                cmd.Parameters.AddWithValue("@maxPrice", maxPrice);
                cmd.Parameters.AddWithValue("@rating", rating);

                for (int i = 0; i < facilities.Count; i++)
                {
                    cmd.Parameters.AddWithValue($"@facility{i}", facilities[i]);
                }

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hotels.Add(new Hotel
                        {
                            hotelId = reader.GetInt32(reader.GetOrdinal("hotelId")),
                            firstname = reader.GetString(reader.GetOrdinal("firstname")),
                            lastname = reader.GetString(reader.GetOrdinal("lastname")),
                            imagePath = reader.GetString(reader.GetOrdinal("imagePath")),
                            location = reader.GetString(reader.GetOrdinal("location")),
                            hotelRating = reader.GetDecimal(reader.GetOrdinal("hotelRating")),
                            facility1 = reader.GetString(reader.GetOrdinal("facility1")),
                            facility2 = reader.GetString(reader.GetOrdinal("facility2")),
                            facility3 = reader.GetString(reader.GetOrdinal("facility3"))
                        });
                    }
                }
            }

            return hotels;
        }
    }
}

