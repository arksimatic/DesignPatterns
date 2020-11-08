using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Command
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public void IncresePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"Price of {Name} increased by {amount}");
        }

        public void DecreasePrice(int amount)
        {
            Price -= amount;
            Console.WriteLine($"Price of {Name} decreased by {amount}");
        }

        public override string ToString()
        {
            return $"${Name}: {Price}";
        }
    }
}
