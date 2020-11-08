using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    class CarFactory
    {
        public static Car CarBuilder(CarType carType)
        {
            Car car = null;
            Location location = Location.POLAND; //this one should be done automatically, by the gps or something

            switch (location)
            {
                case Location.POLAND:
                    POLANDCarFactory.CarBuilder(carType);
                    break;
                case Location.USA:
                    USACarFactory.CarBuilder(carType);
                    break;
                case Location.UK:
                    UKCarFactory.CarBuilder(carType);
                    break;
                default:
                    DEFAULTCarFactory.CarBuilder(carType);
                    break;
            }

            return car;
        }
    }
}
