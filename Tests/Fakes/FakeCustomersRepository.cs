﻿using System.Linq;
using CCE.WebConnection.BL.Models.ViewModels;
using CCE.WebConnection.BL.Repository.Abstract;

namespace CCE.WebConnection.Tests.Fakes
{
    public class FakeCustomersRepository : ICustomersRepository
    {
        private CustomersViewModel customerList;

        public FakeCustomersRepository(CustomersViewModel customers)
        {
            customerList = customers;
        }

        public CustomersViewModel GetAll()
        {
            return customerList;
        }

        public CustomerViewModel GetByID(int customerID)
        {
            return customerList.Customers.SingleOrDefault(c => c.CustomerID == customerID);
        }

        public void Save(CustomerViewModel customerViewModel)
        {
            customerList.Customers[0].CustomerName = customerViewModel.CustomerName;
        }

        public void Delete(CustomerViewModel customerViewModel)
        {
            customerList.Customers.RemoveAt(0);
        }
    }
}
