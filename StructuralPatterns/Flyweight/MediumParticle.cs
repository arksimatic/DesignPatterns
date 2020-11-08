using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Flyweight
{
    class MediumParticle : Particle
    {
        public MediumParticle()
        {
            size = Size.MEDIUM;
        }
    }
}
