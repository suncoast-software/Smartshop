using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Smartshop.Data;
using Smartshop.Helpers;
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
            set 
            {
                OnPropertyChanged(ref companyName, value); 
            }
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

        private bool isValid;
        public bool IsValid
        {
            get { return isValid; }
            set { OnPropertyChanged(ref isValid, value); }
        }

        public AddNewCustomerViewModel()
        {
            SaveCustomerCommand = new RelayCommand(SaveCustomer);
            DeleteInputCommand = new RelayCommand(DeleteInputs); 
        }

        public async void SaveCustomer()
        {
           
            Cust = new Customer()
            {
                CustomerNumber = ulong.Parse(Utils.GenerateId(IdType.CUSTOMER)),
                CompanyName = companyName,
                ContactName = contactName,
                Email = email,
                Phone = phone,
                Address = address
            };

            if (CompanyName != null && ContactName != null && Email != null && Phone != null && Address != null)
            {
                using var db = new SmartshopDbContext();
                await db.AddAsync(Cust);
                await db.SaveChangesAsync();
                DeleteInputs();
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

        private void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name
            });
        }
    }
}
