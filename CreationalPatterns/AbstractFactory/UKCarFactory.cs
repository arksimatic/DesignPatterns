using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class UKCarFactory
    {
        public static Car CarBuilder(CarType carType)
        {
            Car car = null;
            switch (carType)
            {
                case CarType.MICRO:
                    car = new MicroCar(Location.UK); break;
                case CarType.MINI:
                    car = new MiniCar(Location.UK); break;
                case CarType.LUXURY:
                    car = new LuxuryCar(Location.UK); break;
                default:
                    break;
            }
            return car;
        }
    }
}
