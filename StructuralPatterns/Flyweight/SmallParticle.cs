using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Flyweight
{
    class SmallParticle : Particle
    {
        public SmallParticle()
        {
            size = Size.SMALL;
        }
    }
}
