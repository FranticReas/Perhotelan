using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Entity
{
    class Room
    {
        public int roomId { get; set; }
        public string roomType { get; set; }
        public string price { get; set; }
        public int maxGuest { get; set; }
        public int roomSize { get; set; } 
        public string bedType { get; set; }
        public string imagePath { get; set; }
        [ForeignKey("Hotel")]
        public int hotelid { get; set; }

    }
}
