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

        private Customer cust;
        public Customer Cust
        {
            get { return cust; }
            set { OnPropertyChanged(ref cust, value); }
        }

        public AddNewCustomerViewModel()
        {
            SaveCustomerCommand = new RelayCommand(SaveCustomer);
            DeleteInputCommand = new RelayCommand(DeleteInputs); 
        }

        public async void SaveCustomer()
        {
            
            Cust.CompanyName = companyName;
            Cust.ContactName = contactName;
            Cust.Email = email;
            Cust.Phone = phone;
            Cust.Address = address;

            if (IsValid())
            {
                using var db = new SmartshopDbContext();
                await db.AddAsync(cust);
                await db.SaveChangesAsync();
            }
        }

        public void DeleteInputs()
        {
            CompanyName = "";
            ContactName = "";
            Email = "";
            Phone = "";
            Address = "";
        }

        private bool IsValid()
        {
            var valid = Cust != null ? true : false;
            return valid;
        }
    }
}
