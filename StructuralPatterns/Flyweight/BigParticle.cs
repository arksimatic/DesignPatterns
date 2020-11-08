using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Flyweight
{
    class BigParticle : Particle
    {
        public BigParticle()
        {
            size = Size.BIG;
        }
    }
}
