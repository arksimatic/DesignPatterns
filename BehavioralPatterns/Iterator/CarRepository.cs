using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPatterns.Iterator
{
    class CarRepository : IContainer
    {
        public string[] cars;
        public CarRepository(string[] cars)
        {
            this.cars = cars;
        }

        public IIterator GetIterator()
        {
            return new CarIterator(cars);
        }
    }
}
