using Perhotelan.Model.Context;
using Perhotelan.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Repository
{
    class RoomRepository
    {
        // deklarasi objek connection
        private SQLiteConnection _conn;

        // constructor
        public RoomRepository(DdContext context)
        {
            // inisialisasi objek connection
            _conn = context.Conn;
        }
        public List<Room> GetRoomsByHotelId(int hotelId)
        {
            List<Room> rooms = new List<Room>();
            string query = "SELECT * FROM Room WHERE hotelId = @hotelId AND status = 'free'";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@hotelId", hotelId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var room = new Room
                        {
                            roomId = Convert.ToInt32(reader["roomId"]),
                            roomType = reader["roomType"].ToString(),
                            maxGuest = Convert.ToInt32(reader["maxGuest"]),
                            price = Convert.ToInt32(reader["price"]),
                            roomSize = Convert.ToInt32(reader["roomSize"]),
                            bedType = reader["bedType"].ToString(),
                            hotelId = Convert.ToInt32(reader["hotelId"]),
                            imagePath = reader["imagePath"].ToString(),
                            status = reader["status"].ToString()
                        };

                        rooms.Add(room);
                    }
                }
            }
            return rooms;
        }
        public int GetRoomPrice(int roomId)
        {
            int price = 0;
            string query = "SELECT price FROM Room WHERE roomId = @roomId";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                // Tambahkan parameter ke query
                cmd.Parameters.AddWithValue("@roomId", roomId);

                using (var reader = cmd.ExecuteReader())
                {
                    // Periksa apakah ada baris untuk dibaca
                    if (reader.Read())
                    {
                        // Pastikan kolom "price" tidak null
                        if (!reader.IsDBNull(reader.GetOrdinal("price")))
                        {
                            price = reader.GetInt32(reader.GetOrdinal("price"));
                        }
                    }
                }
            }
            return price;
        }
        public Room GetRoomById(int roomId)
        {
            Room room = null;
            string sql = "SELECT * FROM Room WHERE roomId = @roomId";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@roomId", roomId);

                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        room = new Room
                        {
                            roomId = Convert.ToInt32(reader["roomId"]),
                            roomType = reader["roomType"].ToString(),
                            price = Convert.ToInt32(reader["price"]),
                            maxGuest = Convert.ToInt32(reader["maxGuest"]),
                            roomSize = Convert.ToInt32(reader["roomSize"]),
                            bedType = reader["bedType"].ToString(),
                            imagePath = reader["imagePath"].ToString(),
                            hotelId = Convert.ToInt32(reader["hotelId"]),
                            status = reader["status"].ToString()
                        };
                    }
                }
            }
            return room;
        }
        public void UpdateRoomStatus(int roomId, string status)
        {
            string query = "UPDATE Room SET status = @status WHERE roomId = @roomId";

            using (var cmd = new SQLiteCommand(query, _conn))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@roomId", roomId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
