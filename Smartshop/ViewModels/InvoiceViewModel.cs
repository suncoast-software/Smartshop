using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class InvoiceViewModel : BaseViewModel
    {
        //TODO: add implimentation 
        public ICommand SaveInvoiceCommand { get; set; }
        public ICommand DeleteInputCommand { get; set; }

        private List<Customer> customers;
        public List<Customer> Customers
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

        private string invNumber;
        public string InvNumber
        {
            get { return invNumber; }
            set { OnPropertyChanged(ref invNumber, value); }
        }

        public InvoiceViewModel()
        {
            using var db = new SmartshopDbContext();
            Customers = db.Customers.ToList();
            SaveInvoiceCommand = new RelayCommand(SaveInvoice);
            DeleteInputCommand = new RelayCommand(DeleteInput);
            invNumber = Utils.GenerateInvoiceNumber();
        }

        public void SaveInvoice()
        {

        }

        public void DeleteInput()
        {

        }
    }
}
