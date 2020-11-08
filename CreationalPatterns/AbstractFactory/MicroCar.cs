using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class MicroCar : Car
    {
        public MicroCar(Location location) : base(CarType.MICRO, location)
        {

        }

        public override string ToString()
        {
            return "MicroCar";
        }
    }
}
