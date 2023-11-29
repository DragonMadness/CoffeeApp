using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp.model
{
    public class Building
    {
        public string Address {  get; set; }
        public string WorkTime { get; set; }
        public List<Product> AccessibleProducts { get; set; }

        public Building(string address, string workTime, List<Product> accessibleProducts)
        {
            Address = address;
            WorkTime = workTime;
            AccessibleProducts = accessibleProducts;
        }

    }
}
