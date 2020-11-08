using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Flyweight
{
    public enum Size {SMALL, MEDIUM, BIG}
    public abstract class Particle
    {
        public Size size;
        public string color;
    }
}
