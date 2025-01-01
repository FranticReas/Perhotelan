using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perhotelan.Model.Entity;
using Perhotelan.Model.Repository;
using Perhotelan.Model.Context;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;

namespace Perhotelan.Controller
{
    class HotelController
    {
        private HotelRepository _repository;

        public HotelController(HotelRepository repository)
        {
            _repository = repository;
        }

        public List<Hotel> GetAllHotel()
        {
            try
            {
                return _repository.GetAllHotels();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<Hotel>();
            }
        }
        public Hotel GetHotelById(int hotelId)
        {
            try
            {
                return _repository.GetHotelById(hotelId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
