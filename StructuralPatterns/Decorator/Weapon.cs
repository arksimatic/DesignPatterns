using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    abstract class Weapon
    {
        protected int damage;
        public abstract void shot();

        public void increaseDamage(int increase)
        {
            damage += increase;
        }
    }
}

//a lot of my own code, not sure whether this pattern was correctly implemented
