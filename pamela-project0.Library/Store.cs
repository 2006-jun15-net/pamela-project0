using System;
using System.Collections.Generic;
using System.Text;

namespace pamela_project0.Library
{
    public class Store
    {
        // order history of the store location
        public List<Order> PastOrders { get; set; } = new List<Order>();

        // store location has an inventory
    }
}
