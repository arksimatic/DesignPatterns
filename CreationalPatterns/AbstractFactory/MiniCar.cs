using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class MiniCar : Car
    {
        public MiniCar(Location location) : base(CarType.MINI, location)
        {

        }
        public override string ToString()
        {
            return "MiniCar";
        }
    }
}
