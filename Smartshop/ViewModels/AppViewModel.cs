using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartshop.Utility;

namespace Smartshop.ViewModels
{
   public class AppViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set 
            {
                _selectedViewModel = value;
                OnPropertyChanged(ref _selectedViewModel, value); 
            }
        }

        public AppViewModel()
        {
            _selectedViewModel = new LoginViewModel();
        }
    }
}
