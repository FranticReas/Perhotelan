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
            string query = "SELECT * FROM Room WHERE hotelId = @hotelId";

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
                            price = reader["price"].ToString(),
                            roomSize = Convert.ToInt32(reader["roomSize"]),
                            bedType = reader["bedType"].ToString(),
                            hotelid = Convert.ToInt32(reader["hotelId"]),
                            imagePath = reader["imagePath"].ToString()
                        };

                        rooms.Add(room);
                    }
                }
            }
            return rooms;
        }
    }
}
