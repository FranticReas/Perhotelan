using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Entity
{
    class Hotel
    {
        public string hotelId { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string location { get; set; }
        public decimal hotelRating { get; set; }
        public int reviewCount { get; set; }
        public string imagePath { get; set; }
        public List<Room> AvailableRooms { get; set; }
    }
}
