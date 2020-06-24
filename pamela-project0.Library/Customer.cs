using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pamela_project0.Library
{
    public class Customer
    {
        // customer has a name 
        public string Name { get; set; }
        //public string CustomerLastName { get; set; }
        //public int CustomerID { get; set; } = 0;


        // customer has an order history
        public List<Order> OrderHistory { get; set; } = new List<Order>(); 

       

        //public DTO.Response FindCustomer(string name)
        //{
            //if find the customer in the database:
            //return ThisCustomer.Name = name;

        //}

        //function Register(Name as string) as Response

    }

}
