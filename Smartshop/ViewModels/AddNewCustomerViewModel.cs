using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Smartshop.Data;
using Smartshop.Models;
using Smartshop.Utility;

namespace Smartshop.ViewModels
{
   public class AddNewCustomerViewModel : BaseViewModel
    {
        public ICommand SaveCustomerCommand { get; set; }
        public ICommand DeleteInputCommand { get; set; }

        private string companyName;
        public string CompanyName
        {
            get { return companyName; }
            set { OnPropertyChanged(ref companyName, value); }
        }

        private string contactName;
        public string ContactName
        {
            get { return contactName; }
            set { OnPropertyChanged(ref contactName, value); }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { OnPropertyChanged(ref email, value); }
        }

        private string phone;
        public string Phone
        {
            get { return phone; }
            set { OnPropertyChanged(ref phone, value); }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { OnPropertyChanged(ref address, value); }
        }

        public AddNewCustomerViewModel()
        {
            SaveCustomerCommand = new RelayCommand(SaveCustomer);
            DeleteInputCommand = new RelayCommand(DeleteInputs);

        }

        public async void SaveCustomer()
        {
            
        }

        public void DeleteInputs()
        {
            CompanyName = "";
            ContactName = "";
            Email = "";
            Phone = "";
            Address = "";
        }
    }
}
