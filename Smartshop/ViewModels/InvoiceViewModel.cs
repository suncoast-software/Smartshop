﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Microsoft.EntityFrameworkCore;
using Smartshop.Data;
using Smartshop.Helpers;
using Smartshop.Models;
using Smartshop.Utility;

namespace Smartshop.ViewModels
{
    public class InvoiceViewModel : BaseViewModel
    {
        public ICommand SaveInvoiceCommand { get; set; }
        public ICommand DeleteInputCommand { get; set; }
        public ICommand NewCustomerCommand { get; set; }
        public ICommand NewInvoiceCommand { get; set; }
        public ICommand SelectedItemChanged { get; set; }

        private string curDate;
        public string CurDate
        {
            get { return curDate; }
            set { OnPropertyChanged(ref curDate, value); }
        }
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

        private Customer selectedCustomer;
        public Customer SelectedCustomer
        {
            get { return selectedCustomer; }
            set 
            {
                OnPropertyChanged(ref selectedCustomer, value);
                SelectedCustomerChanged();
            }
        }

        private Invoice selectedInvoice;
        public Invoice SelectedInvoice
        {
            get { return selectedInvoice; }
            set 
            { 
                OnPropertyChanged(ref selectedInvoice, value);
                SelectedInvoiceChanged();
            }
        }

        private ICollection<Item> items;
        public ICollection<Item> Items
        {
            get { return items; }
            set { OnPropertyChanged(ref items, value); }
        }

        private string invNumber;
        public string InvNumber
        {
            get { return invNumber; }
            set { OnPropertyChanged(ref invNumber, value); }
        }

        public InvoiceViewModel(List<Customer> _customers)
        {
            Customers = _customers;
            SaveInvoiceCommand = new RelayCommand(SaveInvoice);
            DeleteInputCommand = new RelayCommand(DeleteInput);
            NewCustomerCommand = new RelayCommand(CreateNewCustomer);
            NewInvoiceCommand = new RelayCommand(CreateNewInvoice);

            invNumber = Utils.GenerateId(IdType.INVOICE);
        }

        private void CreateNewInvoice()
        {
            throw new NotImplementedException();
        }

        public void SaveInvoice()
        {
            throw new NotImplementedException("Not Implimented!");
        }

        public void DeleteInput()
        {
            throw new NotImplementedException("Not Implimented!");
        }

        public void CreateNewCustomer()
        {
            throw new NotImplementedException("Not Implimented!");
        }

        public void SelectedCustomerChanged()
        {
            using var db = new SmartshopDbContext();
            Customer = db.Customers.Where(c => c.CompanyName == SelectedCustomer.CompanyName)
                .Include(i => i.Invoices)
                .FirstOrDefault();
        }

        public void SelectedInvoiceChanged()
        {
            
            if (SelectedInvoice == null)
            {
                Items = null;
                return;
            }
            else
            {
                using var db = new SmartshopDbContext();
                Items = db.Items.Where(i => i.InvoiceNumber == SelectedInvoice.InvoiceNumber).ToList();
            }
                
        }
    }
}
