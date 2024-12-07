using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perhotelan.Model.Entity
{
    class User
    {
        public int userId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public int noHp { get; set; }
        public string userTgl {  get; set; }
    }
}
