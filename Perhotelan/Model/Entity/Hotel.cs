using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Entity
{
    class Hotel
    {
        public int hotelId { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public double hotelRating { get; set; }
        public int reviewCount { get; set; }
        public string imagePath { get; set; }
        public List<Room> AvailableRooms { get; set; }
    }
}
