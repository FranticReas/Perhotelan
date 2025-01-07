using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Entity
{

    [Table("user")]
    public class User
    {
        public int userId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string phoneNumber { get; set; }
        public DateTime? birthdate { get; set; }
        public string imagePath { get; set; }
        public string reset_token { get; set; }
        public DateTime token_expiry { get; set; }

    }
}
