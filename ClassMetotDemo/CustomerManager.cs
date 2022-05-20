using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        
            Customer customer;
            List<Customer> _customers;
            public CustomerManager()
            {
                _customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name ="Ahmet",Surname="Çiftçi",Money=1500},
                new Customer() { Id = 2, Name ="Mehmet",Surname="Göksu",Money =1800}
            };
            }

            public void Add(Customer customer)
            {
                _customers.Add(customer);
            }
            public void Delete(Customer customer)
            {
                var dltCustomer = _customers.SingleOrDefault(c => c.Name == customer.Name);
                _customers.Remove(dltCustomer);
            }
            public List<Customer> GetAll()
            {
                return _customers;
            }
        
    }
}
