using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartshop.Utility;

namespace Smartshop.Models
{
   public class Invoice : ObservableObject
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { OnPropertyChanged(ref _id, value); }
        }

        private ulong _customerId;
        public ulong CustomerId
        {
            get { return _customerId; }
            set { OnPropertyChanged(ref _customerId, value); }
        }

        private ulong _invoiceNumber;
        public ulong InvoiceNumber
        {
            get { return _invoiceNumber; }
            set { OnPropertyChanged(ref _invoiceNumber, value); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { OnPropertyChanged(ref _title, value); }
        }

        private string _desc;
        public string Desc
        {
            get { return _desc; }
            set { OnPropertyChanged(ref _desc, value); }
        }

        private string _createdBy;
        public string CreatedBy
        {
            get { return _createdBy; }
            set { OnPropertyChanged(ref _createdBy, value); }
        }

        private DateTime _createdDate;
        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { OnPropertyChanged(ref _createdDate, value); }
        }

        private DateTime _dueDate;  
        public DateTime DueDate
        {
            get { return _dueDate; }
            set { OnPropertyChanged(ref _dueDate, value); }
        }

        private Decimal _total;
        public Decimal Total
        {
            get { return _total; }
            set { OnPropertyChanged(ref _total, value); }
        }

        private ICollection<Item> _items;
        public ICollection<Item> Items
        {
            get { return _items; }
            set { OnPropertyChanged(ref _items, value); }
        }

    }
}
