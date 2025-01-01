using Perhotelan.Model.Repository;
using Perhotelan.Model.Entity;
using Perhotelan.Model.Context;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Controller
{
    class RoomController
    {
        private RoomRepository _repository;

        // Constructor
        public RoomController(RoomRepository roomRepository)
        {
            _repository = roomRepository;
        }
        // Mendapatkan daftar kamar berdasarkan hotelId
        public List<Room> GetRoomsByHotelId(int hotelId)
        {
            try
            {
                return _repository.GetRoomsByHotelId(hotelId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<Room>();
            }
        }
        // Mendapatkan harga kamar berdasarkan roomId
        public int GetRoomPrice(int roomId)
        {
            try
            {
                return _repository.GetRoomPrice(roomId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return 0;
            }
        }
        // Mendapatkan kamar berdasarkan roomId
        public Room GetRoomById(int roomId)
        {
            try
            {
                return _repository.GetRoomById(roomId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        // Memperbarui status kamar
        public void UpdateRoomStatus(int roomId, string status)
        {
            try
            {
                _repository.UpdateRoomStatus(roomId, status);
                Console.WriteLine("Status kamar berhasil diperbarui.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
