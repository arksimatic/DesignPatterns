using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class LuxuryCar : Car
    {
        public LuxuryCar(Location location) : base(CarType.LUXURY, location)
        {

        }

        public override string ToString()
        {
            return "LuxuryCar";
        }
    }
}