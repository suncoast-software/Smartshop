using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using Smartshop.Data;
using Smartshop.Helpers;
using Smartshop.Models;
using Smartshop.Utility;
using Smartshop.Views;

namespace Smartshop.ViewModels
{
   public class AppViewModel : BaseViewModel
    {
        public string CurDate { get; } = DateTime.Now.ToLongDateString();

        private BaseViewModel _selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { OnPropertyChanged(ref _selectedViewModel, value); }
        }

        private List<Customer> customers;
        public List<Customer> Customers 
        {
            get { return customers; }
            set { OnPropertyChanged(ref customers, value); }
        }

        public ICommand LoadCustomerViewCommand { get; set; }
        public ICommand LoadLoginViewCommand { get; set; }
        public ICommand LoadViewInvoiceViewCommand { get; set; }
        public ICommand LoadNewInvoiceViewCommand { get; set; }

        public AppViewModel()
        {
            Customers = LoadCustomers();
            LoadCustomerViewCommand = new RelayCommand(LoadCustomerView);
            LoadLoginViewCommand = new RelayCommand(LoadLoginView);
            LoadNewInvoiceViewCommand = new RelayCommand(LoadNewInvoiceView);
            LoadViewInvoiceViewCommand = new RelayCommand(LoadViewInvoiceView);
            SelectedViewModel = new MainAppViewModel();
    }

        private void LoadViewInvoiceView()
        {
            SelectedViewModel = new InvoiceViewModel(Customers);
        }

        public void LoadCustomerView()
        {
            SelectedViewModel = new AddNewCustomerViewModel();
            
        }

        public void LoadLoginView()
        {
            SelectedViewModel = new LoginViewModel();
        }

        public void LoadNewInvoiceView()
        {
            SelectedViewModel = new AddNewInvoiceViewModel(Customers);
        }

        private List<Customer> LoadCustomers()
        {
            using var db = new SmartshopDbContext();
            return db.Customers.ToList();
        }
    }
}
