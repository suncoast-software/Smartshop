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
        public ICommand ClearInputCommand { get; set; }
        public ICommand SaveInvoiceCommand { get; set; }
        public ICommand AddNewCustomerCommand { get; set; }
        public ICommand AddNewItemCommand { get; set; }
        public ICommand EdititemCommand { get; set; }

        private ICollection<Customer> customers;
        public ICollection<Customer> Customers
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

        private ObservableCollection<Item> createdItems;
        public ObservableCollection<Item> CreatedItems
        {
            get { return createdItems; }
            set { OnPropertyChanged(ref createdItems, value); }
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
                OnPropertyChanged(ref selectedItem, value);
                //SelectedItemChanged();
            }
        }

        private Item createdItem;
        public Item CreatedItem
        {
            get { return createdItem; }
            set 
            { 
                OnPropertyChanged(ref createdItem, value);
                //AddNewItem();
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

        private ulong itemNumber;
        public ulong ItemNumber
        {
            get { return itemNumber; }
            set { OnPropertyChanged(ref itemNumber, value); }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { OnPropertyChanged(ref quantity, value); }
        }

        private string desc;
        public string Desc
        {
            get { return desc; }
            set { OnPropertyChanged(ref desc, value); }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { OnPropertyChanged(ref price, value); }
        }

        public AddNewInvoiceViewModel(List<Customer> _customers)
        {
            ClearInputCommand = new RelayCommand(ClearInputs);
            SaveInvoiceCommand = new RelayCommand(SaveInvoice);
            AddNewCustomerCommand = new RelayCommand(LoadNewCustomerView);
            AddNewItemCommand = new RelayCommand(AddNewItem);
            EdititemCommand = new RelayCommand(EditItem);
            NewInvoiceNumber = Helpers.Utils.GenerateId(IdType.INVOICE);
            CreatedItems = new ObservableCollection<Item>();
            Customers = _customers;
            //GetCustomersByName();
            LoadItems();
        }

        private void AddNewItem()
        {
            var item = new Item()
            {
                Name = ItemName,
                Desc = Desc,
                Quantity = Quantity,
                ItemNumber = ItemNumber,
                Price = Price
            };
            
            CreatedItems.Add(item);
        }

        private void EditItem()
        {

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
            //using var db = new SmartshopDbContext();
            SelectedItem = Items.Where(x => x.Name == ItemName).FirstOrDefault();

        }
    }
}
