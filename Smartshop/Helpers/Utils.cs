using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Smartshop.Models;

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

        public static string GenerateId(IdType type)
        {
            Random rnd = new Random();
            var builder = new StringBuilder();
            var prefix = "";

            switch (type)
            {
                case IdType.APPUSER:
                    prefix = "100-";
                    for (int i = 0; i < 12; i++)
                    {
                        var num = rnd.Next(1, 9);
                        builder.Append(num);
                    }
                    return prefix + builder.ToString();

                case IdType.CUSTOMER:
                    prefix = "200-";
                    for (int i = 0; i < 12; i++)
                    {
                        var num = rnd.Next(1, 9);
                        builder.Append(num);
                    }
                    return prefix + builder.ToString();

                case IdType.INVOICE:
                    prefix = "300-";
                    for (int i = 0; i < 12; i++)
                    {
                        var num = rnd.Next(1, 9);
                        builder.Append(num);
                    }
                    return prefix + builder.ToString();

                case IdType.ITEM:
                    prefix = "400-";
                    for (int i = 0; i < 12; i++)
                    {
                        var num = rnd.Next(1, 9);
                        builder.Append(num);
                    }
                    return prefix + builder.ToString();

                default:
                    return "";
            }
        }
    }
}
