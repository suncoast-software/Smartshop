using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smartshop.Utility;

namespace Smartshop.Models
{
   public class Item : ObservableObject
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { OnPropertyChanged(ref id, value); }
        }

        private ulong invoiceNumber;
        public ulong InvoiceNumber
        {
            get { return invoiceNumber; }
            set { OnPropertyChanged(ref invoiceNumber, value); }
        }

        private ulong itemNumber;
        public ulong ItemNumber
        {
            get { return itemNumber; }
            set { OnPropertyChanged(ref itemNumber, value); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { OnPropertyChanged(ref name, value); }
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

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { OnPropertyChanged(ref quantity, value); }
        }
    }
}
