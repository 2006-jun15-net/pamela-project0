using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using pamela_project0.ConsoleApp;

namespace pamela_project0.Library
{
    public class CustomerRepository
    {
        private readonly ICustomerRepository info;
        
        public CustomerRepository(ICustomerRepository info)
        {
            this.info = info;
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

        public Customer GetCustomerByName(string CustomerName)
        {

            return info.First(r => r.Name == CustomerName);
        }
        public void InsertCustomer(Customer Name)
        {

            //info.Customer.Add(Name);
        }

    }
    

    public class StoreRepository 
    {
        public void AddOrder(Order order, Store location)
        {
            location.PastOrders.Add(order);
        }
    }
}
