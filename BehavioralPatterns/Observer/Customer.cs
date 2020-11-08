using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    class Customer
    {
        public string Name;
        public Customer(string name)
        {
            Name = name;
        }

        public void Inform(Shop shop, Merchandise merchandise)
        {
            Console.WriteLine($"Customer {Name} informed about new {merchandise.Name} in {shop.Name}");
        }
    }
}
