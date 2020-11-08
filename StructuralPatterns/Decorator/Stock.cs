using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    class Stock : OptionalModification
    {
        public Stock(Weapon weapon) : base(weapon)
        {
            weapon.increaseDamage(10);
        }

        public override void shot()
        {
            weapon.shot();
        }
    }
}
