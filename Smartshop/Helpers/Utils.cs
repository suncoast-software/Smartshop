using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Smartshop.Helpers
{
   public class Utils
    {
        public static string HashPassword(string password)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

            byte[] password_bytes = Encoding.ASCII.GetBytes(password);
            byte[] hashBytes = sha1.ComputeHash(password_bytes);

            return Convert.ToBase64String(hashBytes);
        }
    }
}
