using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Iterator
{
    class CarIterator : IIterator
    {
        int index;
        string[] cars;

        public CarIterator(string[] cars)
        {
            this.cars = cars;
        }

        public bool hasNext()
        {
            if (index < cars.Length) return true;
            else return false;
        }

        public Object next()
        {
            return cars[index++];
        }
    }
}
