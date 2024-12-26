using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Entity
{
    class Transaction_
    {
        public int transactionId { get; set; }
        public DateTime transactionDate { get; set; }
        public DateTime checkIn { get; set; }
        public DateTime checkOut { get; set; }
        public string status { get; set; }
        public int price { get; set; }

        [ForeignKey("Room")]
        public int roomId { get; set; }
        [ForeignKey("User")]
        public int userId { get; set; }

        // Properti tambahan untuk menyimpan data pengguna
        public string UserFullName { get; set; }
        public string UserPhoneNumber { get; set; }

    }
}
