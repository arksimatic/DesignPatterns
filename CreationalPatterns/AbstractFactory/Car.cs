using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    abstract class Car
    {
        CarType CarType { get; set; }
        Location Location { get; set; }
        protected Car(CarType carType, Location location)
        {
            this.CarType = carType;
            this.Location = location;
        }
    }
}
