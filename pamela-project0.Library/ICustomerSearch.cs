using pamela_project0.Library;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace pamela_project0.ConsoleApp
{
    //interface IDataBase
    //{

    //}
    // ICustomerSearch<T>
    //{
        //DTO.Response FindCustomer(string find);
    //}
    //interface IInputCustomer<T>
    //{
       // DTO.Response Input(string name);
    //}

    //public interface IRepository<T> : where T : Customer
    public interface ICustomerRepository
    {
        string Name { get; }
        List<Order> OrderHistory { get; }
        IEnumerable GetCustomers();
        void InsertCustomer(Customer Name);
        Customer GetCustomerbyName(string name); 

        
    }
    
}
