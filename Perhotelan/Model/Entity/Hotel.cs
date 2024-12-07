using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Entity
{
    class Hotel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
        public int ReviewsCount { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public List<Room> AvailableRooms { get; set; }
    }
}
