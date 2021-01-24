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
        public ICommand NewCustomerCommand { get; set; }

        private List<Customer> customers;
        public List<Customer> Customers
        {
            get { return customers; }
            set { OnPropertyChanged(ref customers, value); }
        }

        private List<Item> items;
        public List<Item> Items
        {
            get { return items; }
            set { OnPropertyChanged(ref items, value); }
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

        private string newInvoiceNumber;
        public string NewInvoiceNumber
        {
            get { return newInvoiceNumber; }
            set { OnPropertyChanged(ref newInvoiceNumber, value); }
        }

        private Item selectedItem;
        public Item SelectedItem
        {
            get { return selectedItem; }
            set 
            {
                SelectedItemChanged();
                OnPropertyChanged(ref selectedItem, value);
            }
        }

        private Customer selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return selectedCustomer; }
            set { OnPropertyChanged(ref selectedCustomer, value); }
        }

        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { OnPropertyChanged(ref itemName, value); }
        }

        public AddNewInvoiceViewModel()
        {
            ClearInputCommand = new RelayCommand(ClearInputs);
            SaveInvoiceCommand = new RelayCommand(SaveInvoice);
            NewCustomerCommand = new RelayCommand(LoadNewCustomerView);
            NewInvoiceNumber = Helpers.Utils.GenerateId(IdType.INVOICE);
            GetCustomersByName();
            LoadItems();
        }

        private void LoadNewCustomerView()
        {

        }

        public void SaveInvoice()
        {
           
        }

        public void ClearInputs()
        {
            
        }

        private void GetCustomersByName()
        {
            using var db = new SmartshopDbContext();
            Customers = db.Customers.ToList();
        }

        private void LoadItems()
        {
            using var db = new SmartshopDbContext();
            Items = db.Items.OrderBy(x => x.Name).Distinct().ToList();
        }

        public void SelectedItemChanged()
        { 
            if (SelectedItem == null)
            {
                return;
            }
            else
            {
                using var db = new SmartshopDbContext();
                SelectedItem = db.Items.Where(x => x.Name == ItemName).FirstOrDefault();
            }

        }
    }
}
