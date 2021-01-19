using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Smartshop.Data;
using Smartshop.Models;
using Smartshop.Utility;

namespace Smartshop.ViewModels
{
   public class AddNewInvoiceViewModel : BaseViewModel
    {
        //TODO: add implimentation 

        public ICommand ClearInputCommand { get; set; }
        public ICommand SaveInvoiceCommand { get; set; }

        private List<String> customers;
        public List<String> Customers
        {
            get { return customers; }
            set { OnPropertyChanged(ref customers, value); }
        }

        private Customer customer;
        public Customer Customer
        {
            get { return customer; }
            set { OnPropertyChanged(ref customer, value); }
        }

        private Invoice invoice;
        public Invoice Invoice
        {
            get { return invoice; }
            set { OnPropertyChanged(ref invoice, value); }
        }

        public AddNewInvoiceViewModel()
        {
            ClearInputCommand = new RelayCommand(ClearInputs);
            SaveInvoiceCommand = new RelayCommand(SaveInvoice);
            Customers = GetCustomersByName();
        }

        public void SaveInvoice()
        {
           
        }

        public void ClearInputs()
        {
            
        }

        private List<String> GetCustomersByName()
        {
            using var db = new SmartshopDbContext();
            return db.Customers.Select(c => c.CompanyName).ToList();
        }
    }
}
