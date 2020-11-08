using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class USACarFactory
    {
        public static Car CarBuilder(CarType carType)
        {
            Car car = null;
            switch (carType)
            {
                case CarType.MICRO:
                    car = new MicroCar(Location.USA); break;
                case CarType.MINI:
                    car = new MiniCar(Location.USA); break;
                case CarType.LUXURY:
                    car = new LuxuryCar(Location.USA); break;
                default:
                    break;
            }
            return car;
        }
    }
}
