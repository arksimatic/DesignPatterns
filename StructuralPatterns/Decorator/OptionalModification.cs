using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Decorator
{
    class OptionalModification : Weapon
    {
        protected Weapon weapon;

        public OptionalModification(Weapon weapon)
        {
            this.weapon = weapon;
        }

        public override void shot()
        {
            weapon.shot();
        }
    }
}
