using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using pamela_project0.ConsoleApp;

namespace pamela_project0.Library
{
    public class CustomerRepository : ICustomerRepository
    {
        //private readonly ICustomerRepository info;
        
        public CustomerRepository(ICustomerRepository db)
        {
            this.db = db;
        }

        //public IEnumerable<Customer> GetCustomers(string search = null)
        //{
           // if (search == null)
            //{
                //foreach (var item in _info)
                //{
                   // return item;
                //}
            //}
            //return info.GetCustomers.ToList();
        //}

        //public Customer GetCustomerByName(string CustomerName)
        //{

           // return data.First(r => r.Name == CustomerName); ??
        //}
        public void AddCustomer(Customer Name)
        {
        
            db.Customer.Add(Name);
        }

    }
    

    public class StoreRepository 
    {
        // add to the store's order history
        public void AddOrder(Order order, Store location)
        {
            location.PastOrders.Add(order);
        }
    }
}
