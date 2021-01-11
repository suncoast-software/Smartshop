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

        private Customer customer;
        public Customer Customer
        {
            get { return customer; }
            set { OnPropertyChanged(ref customer, value); }
        }

        public AddNewCustomerViewModel()
        {
            SaveCustomerCommand = new RelayCommand(SaveCustomer);
            DeleteInputCommand = new RelayCommand(DeleteInputs);

        }

        public async void SaveCustomer()
        {
            using var db = new SmartshopDbContext();
            await db.AddAsync(customer);
            await db.SaveChangesAsync();
        }

        public void DeleteInputs()
        {

        }
    }
}
