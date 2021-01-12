using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Smartshop.Utility;
using Smartshop.Views;

namespace Smartshop.ViewModels
{
   public class AppViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { OnPropertyChanged(ref _selectedViewModel, value); }
        }

        public string CurDate { get; } = DateTime.Now.ToLongDateString();

        public ICommand LoadCustomerViewCommand { get; set; }
        public ICommand LoadLoginViewCommand { get; set; }
        public AppViewModel()
        {
            LoadCustomerViewCommand = new RelayCommand(LoadCustomerView);
            LoadLoginViewCommand = new RelayCommand(LoadLoginView);
           // _selectedViewModel = new LoginViewModel();
        }

        public void LoadCustomerView()
        {
            SelectedViewModel = new AddNewCustomerViewModel();
            
        }

        public void LoadLoginView()
        {
            SelectedViewModel = new LoginViewModel();
        }
    }
}
