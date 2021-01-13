using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartshop.Utility;

namespace Smartshop.Models
{
   public class AppUser : ObservableObject
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { OnPropertyChanged(ref id, value); }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set { OnPropertyChanged(ref username, value); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { OnPropertyChanged(ref email, value); }
        }
        private string hashPassword;
        public string HashPassword
        {
            get { return hashPassword; }
            set { OnPropertyChanged(ref hashPassword, value); }
        }
        private bool isLoggedIn;
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { OnPropertyChanged(ref isLoggedIn, value); }
        }
        private bool isAdmin;
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { OnPropertyChanged(ref isAdmin, value); }
        }
    }
}
