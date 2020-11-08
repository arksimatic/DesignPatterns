using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Observer
{
    class Merchandise
    {
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Merchandise(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
