using System;
using System.Collections.Generic;
using pamela_project0.Library;


namespace pamela_project0.ConsoleApp
{
    //class Program
    //{
    //    
    //}
    static class Program
    {
        // customer has a first and last name and an ID number
        //public string CustomerFirstName { get; set; }
        //public string CustomerLastName { get; set; }
        //public int CustomerID { get; set; } = 100;

        static void Main(string[] args)
        {
            Customer numberOne = new Customer();

            numberOne.CustomerFirstName = "Pamela";
            numberOne.CustomerLastName = "Soulis";

            Console.WriteLine($"The customer's name is {numberOne.CustomerFirstName} {numberOne.CustomerLastName}");
        }

        //public Customer(string CustomerFirstName, string CustomerLastName)
        //{

        // this.CustomerFirstName = CustomerFirstName;
        //this.CustomerLastName = CustomerLastName;
        //}


    }

}
