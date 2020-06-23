using System;
using System.Collections.Generic;
using pamela_project0.Library;


namespace pamela_project0.ConsoleApp
{

    static class Program
    {

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
