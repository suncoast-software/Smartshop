using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smartshop.Models
{
   public class AppUser
    {
        public ulong Id { get; set; }
        public string Email { get; set; }
        public string HashPassword { get; set; }
        public bool IsLoggedIn { get; set; }
        public bool IsAdmin { get; set; }
    }
}
