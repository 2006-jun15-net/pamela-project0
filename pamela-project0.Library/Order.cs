using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.CompilerServices;

namespace pamela_project0.Library
{
    public class Order
    {
        private int _quantity;
        private string _customer;
        //private string _location;
        //private string _OrderTime;

        // an order has an ID number
        public int Id { get; set; }

        // order has to have a customer with name
        public string Customer
        {
            get => _customer; 
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("An order has to have a customer.", nameof(value));
                }
                _customer = value;
            }
        }

        // an order can have multiple products
        public List<Product> TheProducts { get; set; } = new List<Product>();

        // This rejects orders if quantity (number of products in the order) is below 0 or above 5: quantity=TheProducts.Count
        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException($"The quantity of products {value} is too high.", nameof(value));
                }
                _quantity = value;
            }
        }
    }
}
