using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartshop.Data;
using Smartshop.Models;

namespace Smartshop.ViewModels
{
   public class CustomerViewModel : BaseViewModel
    {
        public List<Customer> CustomerList { get; set; }

        public CustomerViewModel()
        {
            //CustomerList = LoadCustomers();
        }

        private static List<Customer> LoadCustomers()
        {
            using var db = new SmartshopDbContext();
            return db.Customers.ToList();
        }
    }

    
}
