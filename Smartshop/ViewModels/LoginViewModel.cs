using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartshop.Data;
using Smartshop.Models;
using Smartshop.Utility;

namespace Smartshop.ViewModels
{
   public class LoginViewModel : BaseViewModel
    {
        public RelayCommand LoginCommand { get; private set; }
        public RelayCommand OnCancelCommand { get; private set; }

        private AppUser _user;

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(LoginUser);
        }
        public AppUser User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged(ref _user, value);
            }
        }

        public void LoginUser()
        {
            //Dependency Injection Here
            using var _db = new SmartshopDbContext();
            User = _db.AppUsers.Where(u => u.Id == 1).FirstOrDefault();
            
        }

    }
}
