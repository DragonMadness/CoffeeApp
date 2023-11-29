using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp.model
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        } 

    }
}
