using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Entity
{
    class Room
    {
        public string RoomType { get; set; }
        public double Price { get; set; }
        public int MaxGuests { get; set; }
        public int Size { get; set; } // Size in m²
        public string BedType { get; set; }
    }
}
