using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using pamela_project0.Library;


namespace pamela_project0.ConsoleApp
{

    static class Program
    {

        static void Main(string[] args)
        {
            // customer 
            Customer numberOne = new Customer
            {
                CustomerFirstName = "Pamela",
                CustomerLastName = "Soulis"
            };

            // order time
            //Order order = new Order();
            var OrderTime = DateTime.Now;

            Product FirstProduct = new Product
            {
                TheProduct = "Pizza"
            };


            Console.WriteLine($"The customer's name is {numberOne.CustomerFirstName} {numberOne.CustomerLastName} \n " +
                $"and she placed an order for a {FirstProduct.TheProduct} at {OrderTime}");

        }


    }

}
