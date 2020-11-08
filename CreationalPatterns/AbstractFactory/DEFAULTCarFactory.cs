using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class DEFAULTCarFactory
    {
        public static Car CarBuilder(CarType carType)
        {
            Car car = null;
            switch (carType)
            {
                case CarType.MICRO:
                    car = new MicroCar(Location.DEFAULT); break;
                case CarType.MINI:
                    car = new MiniCar(Location.DEFAULT); break;
                case CarType.LUXURY:
                    car = new LuxuryCar(Location.DEFAULT); break;
                default:
                    break;
            }
            return car;
        }
    }
}
