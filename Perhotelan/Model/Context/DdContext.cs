using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Perhotelan.Model.Entity;


namespace Perhotelan.Model.Context
{
    class DdContext : IDisposable
    {
        // deklarasi private variabel / field
        private SQLiteConnection _conn;
        // deklarasi property Conn (connection), untuk menyimpan objek koneksi
        public SQLiteConnection Conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }
        // Method untuk melakukan koneksi ke database
        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null; // declare connection object
            try
            {
                // Get the full path of the database
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string dbName = @"database/hotelapp.db";


                // Check if the database file exists
                if (!File.Exists(dbName))
                {
                    throw new FileNotFoundException("Database file not found.", dbName);
                }

                // Declare connection string
                string connectionString = $"Data Source={dbName}; FailIfMissing=True;";

                // Initialize and open the connection
                conn = new SQLiteConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex) // handle errors
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
                throw new InvalidOperationException("Could not open database connection.", ex);
            }
            return conn;
        }

        // Method ini digunakan untuk menghapus objek koneksi dari memory ketika sudah tidak digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed)
                    {
                        _conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Error closing connection: {0}", ex.Message);
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }

        public List<Hotel> GetAllHotels()
        {
            List<Hotel> hotels = new List<Hotel>();
            string query = "SELECT * FROM Hotel"; // Assuming hotel table exists

            using (var cmd = new SQLiteCommand(query, Conn))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var hotel = new Hotel
                        {
                            hotelId = reader["hotelId"].ToString(),  // Use column names instead of index
                            firstname = reader["firstname"].ToString(),
                            lastname = reader["lastname"].ToString(),
                            location = reader["location"].ToString(),
                            hotelRating = Convert.ToDecimal(reader["hotelRating"]),
                            reviewCount = Convert.ToInt32(reader["reviewCount"]),
                            imagePath = reader["imagePath"].ToString()
                        };

                        hotels.Add(hotel);
                    }
                }
            }
            return hotels;
        }


        public List<Room> GetRoomsByHotelId(int hotelId)
        {
            List<Room> rooms = new List<Room>();
            string query = "SELECT * FROM room WHERE hotelId = @hotelId";

            using (var cmd = new SQLiteCommand(query, Conn))
            {
                cmd.Parameters.AddWithValue("@hotelId", hotelId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var room = new Room
                        {
                            roomId = reader.GetInt32(0),
                            roomType = reader.GetString(1),
                            maxGuest = reader.GetInt32(2),
                            price = reader.GetString(3),
                            roomSize = reader.GetInt32(4),
                            imagePath = reader.GetString(5),
                        };

                        rooms.Add(room);
                    }
                }
            }
            return rooms;
        }

    }
}
