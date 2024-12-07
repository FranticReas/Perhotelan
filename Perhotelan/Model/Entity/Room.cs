using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Entity
{
    class Room
    {
        public int roomId { get; set; }
        public string roomType { get; set; }
        public double price { get; set; }
        public int maxGuest { get; set; }
        public string roomSize { get; set; } 
        public string bedType { get; set; }
        public string roomRating { get; set; }
        public string roomFacility { get; set; }
        public string imagePath { get; set; }
    }
}
