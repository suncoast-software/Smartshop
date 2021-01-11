using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartshop.Utility;

namespace Smartshop.Models
{
    public class Customer : ObservableObject
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { OnPropertyChanged(ref _id, value); }
        }

        private ulong _customerNumber;

        public ulong CustomerNumber
        {
            get { return _customerNumber; }
            set { OnPropertyChanged(ref _customerNumber, value); }
        }


        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { OnPropertyChanged(ref _companyName, value); }
        }

        private string _contactName;

        public string ContactName
        {
            get { return _contactName; }
            set { OnPropertyChanged(ref _contactName, value); }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { OnPropertyChanged(ref _email, value); }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { OnPropertyChanged(ref _phone, value); }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { OnPropertyChanged(ref _address, value); }
        }

        private ICollection<Invoice> invoices;

        public ICollection<Invoice> Invoices
        {
            get { return invoices; }
            set { OnPropertyChanged(ref invoices, value); }
        }

    }
}
