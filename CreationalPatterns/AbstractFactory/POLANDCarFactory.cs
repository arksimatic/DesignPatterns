using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class POLANDCarFactory
    {
        public static Car CarBuilder(CarType carType)
        {
            Car car = null;
            switch (carType)
            {
                case CarType.MICRO:
                    car = new MicroCar(Location.POLAND); break;
                case CarType.MINI:
                    car = new MiniCar(Location.POLAND); break;
                case CarType.LUXURY:
                    car = new LuxuryCar(Location.POLAND); break;
                default:
                    break;
            }
            return car;
        }
    }
}
