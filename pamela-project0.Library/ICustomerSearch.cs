using pamela_project0.Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace pamela_project0.ConsoleApp
{

    //public interface IRepository<T> : where T : Customer  //generic repo for classes customer, order, product, etc?
    public interface ICustomerRepository
    {
        string Name { get; }
        List<Order> OrderHistory { get; }
        IEnumerable GetCustomers();
        void InsertCustomer(Customer Name);
        Customer GetCustomerbyName(string name); 

        
    }
    
}
