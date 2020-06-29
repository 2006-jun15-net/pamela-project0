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

            Console.WriteLine("Welcome to Store Application");

            while (true)
            {
                Console.WriteLine("a:\tSelect a store location");
                Console.WriteLine("b:\tPlace an order");
                Console.WriteLine("Enter \"q\" to exit: ");
                var input = Console.ReadLine();
                if (input == "b")
                {
                    var customer = new Customer();
                    while (customer.Name == null)
                    {
                        customer = Console.WriteLine("Please enter your name: ");
                        input = Console.ReadLine();
                        
                    }
                    CustomerRepository.AddCustomer(customer);

                    var order = new Order();
                    {

                    }
                    StoreRepository.AddOrder(order, )
                }
                else if (input == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid input");
                }
            }



            // customer 
            //Customer numberOne = new Customer
            //{
                //Name = "Pamela Soulis"
            //};

            // order time
            //Order order = new Order();
            //var OrderTime = DateTime.Now;

            //Product FirstProduct = new Product
            //{
                //TheProducts = "Shirt and Jeans"
            //};


            //Console.WriteLine($"The customer's name is {numberOne.Name} \n " +
                //$"and she placed an order for a {FirstProduct.TheProducts}");

        }


    }

}

/using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace pamela_soulis_project0DataAccess
//{
//    public interface IMapper
//    {
//        //maps an EF location to a business model
        
//        {
//            //
//        }
       
//        {
            
//        }


//    }
//}
